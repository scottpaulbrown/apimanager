using APIManager.Data;
using APIManager.Data.TemplateData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIManager.WIN {
    public partial class EditTemplate : Form {
        Template _template;
        List<TemplateEntityAttribute> _attrList;

        public EditTemplate() {
            InitializeComponent();
        }

        public EditTemplate(Template tmp) {
            InitializeComponent();
            _template = tmp;
            _attrList = _template.TemplateEntityAttributes.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (Save()) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditTemplate_Load(object sender, EventArgs e) {
            PopulateDropDowns();
            templateEntityAttributeBindingSource.DataSource = _attrList;
            PopulateFields();
        }

        private void PopulateDropDowns() {
            var langList = GlobalData.ReferenceTypes.LanguageTypes.ToList();
            langList.Insert(0, new LanguageType() { LanguageTypeCode = "", LanguageTypeName = "None" });
            cboLanguage.DataSource = langList;
            cboLanguage.DisplayMember = "LanguageTypeCode";
            cboLanguage.ValueMember = "LanguageTypeCode";

            var projTypeList = GlobalData.ReferenceTypes.CodeProjectTypes.ToList();
            projTypeList.Insert(0, new CodeProjectType() { CodeProjectTypeCode = "", CodeProjectTypeName = "None" });
            cboProjType.DataSource = projTypeList;
            cboProjType.DisplayMember = "CodeProjectTypeCode";
            cboProjType.ValueMember = "CodeProjectTypeCode";
        }

        private void PopulateFields() {
            txtName.Text = _template.TemplateName;
            cboLanguage.SelectedValue = _template.LanguageTypeCode != null ? _template.LanguageTypeCode : "";
            cboProjType.SelectedValue = _template.CodeProjectTypeCode != null ? _template.CodeProjectTypeCode : "";
            txtFileMask.Text = _template.FileMask;
            txtPathMask.Text = _template.PathMask;
        }

        private bool Save() {
            _template.TemplateName = txtName.Text;
            _template.PathMask = txtPathMask.Text;
            _template.FileMask = txtFileMask.Text;
            _template.CodeProjectTypeCode = cboProjType.SelectedValue.ToString().Length > 0 ? cboProjType.SelectedValue.ToString() : null;
            _template.LanguageTypeCode = cboLanguage.SelectedValue.ToString().Length > 0 ? cboLanguage.SelectedValue.ToString() : null;

            _template.DeletedEntities = Helpers.SyncList(_template.TemplateEntityAttributes, _attrList, (to, from) => to.EntityAttributeTypeCode == from.EntityAttributeTypeCode);
            var logic = new TemplateLogic(GlobalData.AppInfo);
            if (_template.TemplateId == 0) {
                logic.CreateTemplate(_template);
            } else {
                logic.UpdateTemplate(_template);
            }

            return true;
        }

        private void btnAddAttributes_Click(object sender, EventArgs e) {
            // get the list of attributes to exclude
            var exList = _attrList.Select(a => new EntityAttributeType() { EntityAttributeTypeCode = a.EntityAttributeTypeCode }).ToList();
            var frm = new ChooseEntityAttributes(exList);
            if (frm.ShowDialog() == DialogResult.OK) {
                if (frm.SelectedItems.Count > 0) {
                    // add these and update the grid
                    var newItems = frm.SelectedItems.Select(a => new TemplateEntityAttribute() {
                        EntityAttributeTypeCode = a.EntityAttributeTypeCode,
                        Template = _template
                    }).ToList();

                    newItems.ForEach(a => templateEntityAttributeBindingSource.Add(a));
                }
            }
        }

        private void ctxEntityAttr_Opening(object sender, CancelEventArgs e) {
            if (grdEntityAttributes.SelectedRows.Count == 0) {
                e.Cancel = true;
            } 
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
            var rows = grdEntityAttributes.SelectedRows;
            foreach (DataGridViewRow row in grdEntityAttributes.SelectedRows) {
                var obj = row.DataBoundItem as TemplateEntityAttribute;
                _attrList.Remove(obj);
            }

            templateEntityAttributeBindingSource.ResetBindings(false);
        }
    }
}
