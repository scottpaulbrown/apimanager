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
    public partial class DesignEntity : Form {
        private enum WizardPanels {  Fields }
        private WizardPanels _currentPanel;
        private List<EntityField> _fields;

        public DesignEntity() {
            InitializeComponent();
        }

        private void DesignEntity_Load(object sender, EventArgs e) {
            _fields = new List<EntityField>();
            SetupPanels();
            var frm = new EditEntityFields(_fields);
            frm.ShowDialog();
        }

        private void SetupPanels() {
            pnlFields.Visible = _currentPanel == WizardPanels.Fields;
        }
    }
}
