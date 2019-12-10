using APIManager.Logic;
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
    public partial class ObjectSelection : Form {
        List<EntityInfo> entityList;

        public ObjectSelection() {
            InitializeComponent();
        }

        private void ObjectSelection_Load(object sender, EventArgs e) {
            var logic = new AssemblyLogic();
        }
    }
}
