using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIManager.Logic;

namespace APIManager.WIN {
    public partial class EditEntity : UserControl {
        public delegate void IsDirtyChangedEvent(EditEntity editEntity);
        public event IsDirtyChangedEvent IsDirtyChanged;
        Func<int> getNewFieldId;

        List<string> dataTypes = new List<string>() { "string", "int", "DateTime" };
        
        public bool IsDirty { get; set; }
        public EntityInfo Entity { get; set; }

        public EditEntity() {
            InitializeComponent();
        }

        public EditEntity(EntityInfo entity, Func<int> getNewFieldIdFunc) {
            InitializeComponent();
            this.Entity = entity;
            this.getNewFieldId = getNewFieldIdFunc;
            DataGridViewComboBoxColumn col = grdFields.Columns[1] as DataGridViewComboBoxColumn;
            col.DataSource = dataTypes;
            entityFieldInfoBindingSource.DataSource = entity.Fields;
        }

        public void OnIsDirtyChanged() {
            IsDirty = true;
            IsDirtyChanged?.Invoke(this);
        }

        private void EditEntity_Load(object sender, EventArgs e) {
            txtName.Text = this.Entity.EntityName;
        }

        public void Save() {
            grdFields.EndEdit();
        }
        
        private void grdFields_RowLeave(object sender, DataGridViewCellEventArgs e) {
            // see if this is a new row
            EntityFieldInfo field = grdFields.Rows[e.RowIndex].DataBoundItem as EntityFieldInfo;
            if (field.EntityFieldId == 0) {
                field.EntityId = Entity.EntityId;
                field.EntityFieldId = getNewFieldId();
                field.StatusCode = EntityFieldStatusCodes.Staged;
            }
        }

        private void grdFields_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e) {
            e.Row.Cells["DataType"].Value = "string";
            e.Row.Cells["IsRequired"].Value = true;
        }

        private void grdFields_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            OnIsDirtyChanged();
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            Entity.EntityName = txtName.Text;
            OnIsDirtyChanged();
        }
    }
}
