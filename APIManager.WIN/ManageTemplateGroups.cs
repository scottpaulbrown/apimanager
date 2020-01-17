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
    public partial class ManageTemplateGroups : Form {
        public ManageTemplateGroups() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            TemplateGroup tg = new TemplateGroup();
            var frm = new EditTemplateGroup(tg);
            if (frm.ShowDialog() == DialogResult.OK) {

            }
        }
    }
}
