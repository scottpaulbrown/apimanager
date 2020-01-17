using APIManager.Data.RevisionData;
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
    public partial class CommitRevision : Form {
        CommitRevsionArgs _args;

        public CommitRevision() {
            InitializeComponent();
        }
        
        public CommitRevision(CommitRevsionArgs args) {
            InitializeComponent();
            _args = args;
        }

        private void CommitRevision_Load(object sender, EventArgs e) {
            chkCommitToDB.Checked = _args.ExcuteMigration;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCommit_Click(object sender, EventArgs e) {
            _args.ExcuteMigration = chkCommitToDB.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
