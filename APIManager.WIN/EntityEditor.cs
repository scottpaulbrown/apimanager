using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIManager.Data;
using APIManager.Data.ReferenceTypesData;
using APIManager.Data.Constants;

namespace APIManager.WIN {
    public partial class EntityEditor : UserControl {
        public delegate void IsDirtyChangedEvent(EntityEditor editEntity);
        public event IsDirtyChangedEvent IsDirtyChanged;
        Project _project;

        public bool IsDirty { get; set; }
        public Entity Entity { get; set; }

        public EntityEditor() {
            InitializeComponent();
        }

        public EntityEditor(Entity entity, Project project) {
            InitializeComponent();
            this.Entity = entity;
            _project = project;
            DataGridViewComboBoxColumn col = grdFields.Columns["colDataType"] as DataGridViewComboBoxColumn;
            var refLogic = new ReferenceTypeLogic(GlobalData.AppInfo);
            var dtList = refLogic.GetAllDataTypes();
            col.DataSource = dtList;
            col.DisplayMember = "DataTypeCode";
            col.ValueMember = "DataTypeCode";
            entityFieldBindingSource.DataSource = entity.EntityFields.ToList();

            // get the links for this object
            var linkList = new List<EntityLink>();
            foreach (var field in entity.EntityFields) {
                if (field.ParentLinks.Count() > 0) {
                    linkList.AddRange(field.ParentLinks.ToList());
                }
            }

            entityLinkBindingSource.DataSource = linkList;
        }

        public void OnIsDirtyChanged() {
            IsDirty = true;
            IsDirtyChanged?.Invoke(this);
        }

        public void Save() {
            grdFields.EndEdit();
            // merge the fields back into the object
            Entity.EntityFields = entityFieldBindingSource.DataSource as List<EntityField>;
            List<EntityField> removeList = new List<EntityField>();
            // make sure the status is correct
            foreach (var field in Entity.EntityFields) {
                if (field.EntityFieldId == 0) {
                    field.StatusCode = EntityFieldStatusCodes.Staged;
                    if (string.IsNullOrEmpty(field.FieldName)) {
                        removeList.Add(field);
                    }
                }
            }
            
            if (removeList.Count > 0) {
                removeList.ForEach(f => Entity.EntityFields.Remove(f));
            }
        }

        private void grdFields_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e) {
            e.Row.Cells["DataType"].Value = "string";
            e.Row.Cells["IsRequired"].Value = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            Entity.EntityName = txtName.Text;
            OnIsDirtyChanged();
        }

        private void EntityEditor_Load(object sender, EventArgs e) {
            txtName.Text = Entity.EntityName;
        }

        private void ctxmCreateLink_Click(object sender, EventArgs e) {
            EditLink editLnk = new EditLink(_project, Entity);
            if (editLnk.ShowDialog() == DialogResult.OK) {
                // find the field that's being linked
                var field = this.Entity.EntityFields.Where(f => f.EntityFieldId == editLnk.Link.ForeignKeyFieldId).First();
                field.ParentLinks.Add(editLnk.Link);
                OnIsDirtyChanged();
            }
        }

        private void ctxmDeleteField_Click(object sender, EventArgs e) {
            var rows = grdFields.SelectedRows;
            var cnt = 0;
            foreach (DataGridViewRow row in rows) {
                var field = row.DataBoundItem as EntityField;
                // make sure this field can be deleted
                if (field.IsRequired && string.IsNullOrEmpty(field.InitialValue)) {
                    MessageBox.Show("Cannot delete a required field without specifiying an initial value (for rollback)");
                    break;
                }

                // mark this field as deleted
                field.IsDeleted = true;
                row.ReadOnly = true;                
                cnt++;
            }

            if (cnt > 0) {
                grdFields.Refresh();
                OnIsDirtyChanged();
            }
        }
        

        private void grdFields_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            var row = grdFields.Rows[e.RowIndex];
            var field = row.DataBoundItem as EntityField;
            if (field != null) {
                if (field.IsDeleted) {
                    row.DefaultCellStyle.BackColor = CommonColors.Deleted;
                } else if (field.StatusCode == EntityFieldStatusCodes.Staged) {
                    row.DefaultCellStyle.BackColor = CommonColors.Added;
                } else {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void ctxFields_Opening(object sender, CancelEventArgs e) {
            if (grdFields.SelectedRows.Count == 0) {
                e.Cancel = true;
            } else {
                grdFields.EndEdit();
                bool allUnDeleted = true;
                bool allDeleted = true;
                foreach (DataGridViewRow row in grdFields.SelectedRows) {
                    var field = row.DataBoundItem as EntityField;
                    if (field.IsDeleted) {
                        allUnDeleted = false;
                    } else {
                        allDeleted = false;
                    }
                }

                ctxmDeleteField.Visible = allUnDeleted;
                ctxmUnDeleteField.Visible = allDeleted;
            }
        }

        private void ctxmUnDeleteField_Click(object sender, EventArgs e) {
            var rows = grdFields.SelectedRows;
            foreach (DataGridViewRow row in rows) {
                var field = row.DataBoundItem as EntityField;
                // mark this field as deleted
                field.IsDeleted = false;
                row.ReadOnly = false;
            }
            
            grdFields.Refresh();
            OnIsDirtyChanged();
        }

        private void grdFields_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            OnIsDirtyChanged();
        }

        private void grdFields_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            OnIsDirtyChanged();
        }
    }
}
