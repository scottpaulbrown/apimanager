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
    public partial class EditTemplateGroup : Form {
        List<Template> _templateList;
        TemplateGroup _group;

        public EditTemplateGroup() {
            InitializeComponent();
        }

        public EditTemplateGroup(TemplateGroup group) {
            InitializeComponent();
            _group = group;
            _templateList = group.TemplateGroupMembers.Select(a => a.Template).ToList();
        }

        private void EditTemplateGroup_Load(object sender, EventArgs e) {
            SetupToolbar();
            templateBindingSource.DataSource = _templateList;
        }

        private void SetupToolbar() {
            btnAdd.Text = tabMain.SelectedIndex == 0 ? "Add Template" : "Add Attribute";
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
            SetupToolbar();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (tabMain.SelectedIndex == 0) {
                // add a new template
                var frm = new ManageTemplates(ManageTemplatesModes.Select);
                if (frm.ShowDialog() == DialogResult.OK) {
                    // get the selected templates
                    _templateList.AddRange(frm.SelectedTemplates);
                    templateBindingSource.ResetBindings(false);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            // make sure there is a name
            if (string.IsNullOrEmpty(txtName.Text)) {
                MessageBox.Show("Please provide a template group name");
                return;
            }
            // make sure at least on template is in group
            if (_templateList.Count == 0) {
                MessageBox.Show("Please add at least on template");
                return;
            }

            // convert the templates back into a templategroupmember
            var memList = _templateList.Select(a => new TemplateGroupMember() { TemplateId = a.TemplateId, TemplateGroupId = _group.TemplateGroupId }).ToList();
            // get the new and deleted templates
            var diff = Helpers.GetListDiff<TemplateGroupMember>(_group.TemplateGroupMembers, memList, (a, b) => a.TemplateId == b.TemplateId);
            // add the new templates
            diff.NewEntries.ForEach(a => _group.TemplateGroupMembers.Add(a));
            // add to the deleted list
            diff.DeletedEntries.ForEach(a => _group.DeletedMembers.Add(a));
            // save the group
            var logic = new TemplateLogic(GlobalData.AppInfo);
            if (_group.TemplateGroupId > 0) {
                logic.UpdateTemplateGroup(_group);
            } else {
                logic.CreateTemplateGroup(_group);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
