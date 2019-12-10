using APIManager.Data;
using APIManager.Data.CodeGen;
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
    public partial class ImportEntities : Form {
        Project _proj;
        
        public List<Entity> ImportedList { get; set; }

        class DBInfo {
            public DBInfo(int id, string name) {
                Id = id;
                Name = name;
            }

            public int Id { get; set; }
            public string Name { get; set; }
        }

        public ImportEntities() {
            InitializeComponent();
        }

        public ImportEntities(Project proj) {
            InitializeComponent();
            _proj = proj;
        }

        private void ImportEntities_Load(object sender, EventArgs e) {
            PopulateDatabases();
        }

        private void PopulateDatabases() {
            var list = _proj.ProjectDatabases.Select(d => new DBInfo(d.ProjectDatabaeId, $"{d.EnvironmentTypeCode} ({d.ServerName})")).ToList();
            list.Insert(0, new DBInfo(-1, "Select Database"));
            cboDb.DataSource = list;
            cboDb.ValueMember = "Id";
            cboDb.DisplayMember = "Name";            
        }

        private void btnImport_Click(object sender, EventArgs e) {
            Import();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Import() {
            grdMain.EndEdit();
            ImportedList = new List<Entity>();
            // find all the entities that were selected
            foreach (DataGridViewRow row in grdMain.Rows) {
                var chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (chk.Value.ToString().Equals("1")) {
                    var entity = row.DataBoundItem as Entity;
                    entity.ProjectId = _proj.ProjectId;
                    _proj.Entities.Add(entity);
                    ImportedList.Add(entity);
                }
            }
        }
        private void cboDb_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboDb.SelectedIndex > 0) {
                var id = (int)cboDb.SelectedValue;
                var conn = _proj.ProjectDatabases.Where(d => d.ProjectDatabaeId == id).First();
                DBWorker worker = new DBWorker();
                var entityList = worker.GetEntitiesFromDatabase(conn);
                // exclude entities already in the system
                List<string> nameList = _proj.Entities.Select(a => a.EntityName).ToList();
                var list = entityList.Where(a => !nameList.Contains(a.EntityName)).ToList();
                entityBindingSource.DataSource = list;
                // select all entities
                SelectRows(true);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            SelectRows(true);
        }

        void SelectRows(bool select) {
            foreach (DataGridViewRow row in grdMain.Rows) {
                var chk = row.Cells[0] as DataGridViewCheckBoxCell;
                chk.Value = select ? 1 : 0;
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e) {
            SelectRows(false);
        }
    }
}
