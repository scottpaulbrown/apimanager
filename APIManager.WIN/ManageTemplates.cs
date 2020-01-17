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
    public enum ManageTemplatesModes {  Manage, Select }

    public partial class ManageTemplates : Form {
        List<Template> _list;
        bool _inSearch = false;
        ManageTemplatesModes _mode = ManageTemplatesModes.Manage;
        
        public List<Template> SelectedTemplates { get; set; }
        
        public ManageTemplates() {
            InitializeComponent();
        }
        
        public ManageTemplates(ManageTemplatesModes mode) {
            InitializeComponent();
            _mode = mode;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var tmp = new Template();
            var frm = new EditTemplate(tmp);
            if (frm.ShowDialog() == DialogResult.OK) {

            }
        }

        private void PopulateGrid() {
            var logic = new TemplateLogic(GlobalData.AppInfo);
            _list = logic.SearchTemplates(new SearchTemplatesArgs());
            templateBindingSource.DataSource = _list;
            dataGridView1.Columns[0].Visible = _mode == ManageTemplatesModes.Select;
        }

        private void ManageTemplates_Load(object sender, EventArgs e) {
            PopulateGrid();
            SetupToolbar();
        }

        private void txtSearch_Click(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (txtSearch.Text.Length > 1) {
                var searchList = _list.Where(a => a.TemplateName.ToUpper().Contains(txtSearch.Text.ToUpper().Trim())).ToList();
                templateBindingSource.DataSource = searchList;
                _inSearch = true;
            } else if (_inSearch) {
                templateBindingSource.DataSource = _list;
                _inSearch = false;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 1) {
                var obj = dataGridView1.SelectedRows[0].DataBoundItem as Template;
                var frm = new EditTemplate(obj);
                if (frm.ShowDialog() == DialogResult.OK) {

                }
            }
        }

        private void SetupToolbar() {
            btnSave.Visible = _mode == ManageTemplatesModes.Select;
            btnCancel.Visible = _mode == ManageTemplatesModes.Select;
            sepSave.Visible = _mode == ManageTemplatesModes.Select;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            dataGridView1.EndEdit();
            SelectedTemplates = new List<Template>();
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                var chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (chk.Value.ToString() == "1") {
                    var tmp = row.DataBoundItem as Template;
                    SelectedTemplates.Add(tmp);
                }
            }

            if (SelectedTemplates.Count > 0) {
                this.DialogResult = DialogResult.OK;
            } else {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
