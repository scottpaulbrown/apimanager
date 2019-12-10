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
    public partial class ManageAPI : Form {
        Project proj;

        private class TreeLevels {
            public const int Service = 0;
            public const int Request = 1;
        }

        public ManageAPI() {
            InitializeComponent();
            proj = new Project();
            ProjectService service = new ProjectService();
            service.ServiceName = "Participant Service";
            proj.Services.Add(service);
        }

        private void ManageAPI_Load(object sender, EventArgs e) {          
            PopulateTree();
        }

        private void ctxTree_Opening(object sender, CancelEventArgs e) {
            ctxmNewRequest.Visible = treMain.SelectedNode != null && treMain.SelectedNode.Level == TreeLevels.Service;
        }

        private void PopulateTree() {
            foreach (var service in proj.Services) {
                TreeNode serviceNode = new TreeNode(service.ServiceName);
                treMain.Nodes.Add(serviceNode);
            }
        }

        private void mnuGenFromFile_Click(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                string path = fileDialog.FileName;
                var logic = new AssemblyLogic();
                var info = logic.GetEntityFromClassFile(path);
                // find the current tab
                var curTab = tabMain.SelectedTab;
                var er = curTab.Controls[0] as EditRequest;
                er.createFieldsFromEntity(info);
            }
        }

        private void ctxmNewRequest_Click(object sender, EventArgs e) {
            TabPage page = new TabPage("New Request");
            EditRequest er = new EditRequest();
            page.Controls.Add(er);
            er.Dock = DockStyle.Fill;
            tabMain.TabPages.Add(page);
        }
    }
}
