using APIManager.Data;
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
    public partial class ChooseEntityAttributes : Form {
        List<EntityAttributeType> _exList;

        public List<EntityAttributeType> SelectedItems { get; set; }

        public ChooseEntityAttributes() {
            InitializeComponent();
        }

        public ChooseEntityAttributes(List<EntityAttributeType> excludeList) {
            InitializeComponent();
            _exList = excludeList;
        }

        private void ChooseEntityAttributes_Load(object sender, EventArgs e) {
            var list = GlobalData.ReferenceTypes.EntityAttributeTypes.Where(a => !_exList.Any(ea => ea.EntityAttributeTypeCode == a.EntityAttributeTypeCode)).ToList();
            entityAttributeTypeBindingSource.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Save();
        }

        private void Save() {
            grdMain.EndEdit();
            SelectedItems = new List<EntityAttributeType>();            
            // get the list of selected entities
            foreach (DataGridViewRow row in grdMain.Rows) {
                var chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (chk.Value != null && chk.Value.ToString() == "1") {
                    SelectedItems.Add((EntityAttributeType)row.DataBoundItem);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
