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
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace APIManager.WIN {
    public partial class ProjectManager : Form {
        AssemblyLogic al;
        Project proj;
        Revision currentRevision;
        AppData appData;
        string appDataPath = @"c:\projects\apimanager\appdata.json";
        TemplateGroup netGroup;
        bool isDirty = false;
        List<TabInfo> tabList;

        class TreeLevels {
            public const int EntityParent = 0;
            public const int Entity = 1;
        }

        public ProjectManager() {
            InitializeComponent();
            al = new AssemblyLogic();
            appData = FileTools.OpenJson<AppData>(appDataPath);
            SetupRecentsMenu();

            netGroup = new TemplateGroup();
            netGroup.Templates.Add(new TemplateInfo(new TemplateFile("BasicLogic", "{{entity_name}}Logic.cs", "{{entity_name}}Data", "Logic", LanguageTypes.DotNet)));
            netGroup.Templates.Add(new TemplateInfo(new TemplateFile("BasicController", "{{entity_name}}sController.cs", "Controllers", "API", LanguageTypes.DotNet)));
            netGroup.Templates.Add(new TemplateInfo(new TemplateFile("BasicDTO", "{{entity_name}}DTO.cs", "DTO", "Logic", LanguageTypes.DotNet)));
            netGroup.Templates.Add(new TemplateInfo(new TemplateFile("BasicSearchCriteria", "{{entity_name}}SearchCriteria.cs", "{{entity_name}}Data", "Logic", LanguageTypes.DotNet)));
        }

        private void ProjectManager_Load(object sender, EventArgs e) {
            SetupToolbar();
        }

        #region project functions

        void SaveProject() {
            foreach (TabInfo info in tabList) {
                if (info.Editor.IsDirty) {
                    // see if this entity is new
                    if (info.Editor.Entity.StatusCode == EntityStatusCodes.Staged && !proj.Entities.Any(e => e.EntityId == info.Editor.Entity.EntityId)) {
                        AddEntity(info.Entity);
                    }
                }
            }

            string fileName = $"{proj.ProjectName}.json";
            string path = Path.Combine(appData.DefaultSavePath, fileName);
            FileTools.WriteJson<Project>(proj, path);
            isDirty = false;
            SetupToolbar();
        }

        void AddEntity(EntityInfo entity) {
            // add to entity collection
            proj.Entities.Add(entity);
            // create a entity revision for it
            EntityRevision er = new EntityRevision();
            er.EntityId = entity.EntityId;
            er.EntityRevisionTypeCode = EntityRevisionTypeCodes.Add;
            if (currentRevision.EntityRevisions == null) {
                currentRevision.EntityRevisions = new List<EntityRevision>();
            }

            currentRevision.EntityRevisions.Add(er);
        }


        private void OpenFromFile() {
            if (projDialog.ShowDialog() == DialogResult.OK) {
                OpenProject(projDialog.FileName);
                AddToRecents(projDialog.FileName);
            }
        }

        void OpenProject(string path) {
            proj = FileTools.OpenJson<Project>(path);
            proj.DatabaseProjectPath = @"C:\projects\FLOAPI\DB";
            // see if there is a current revision
            currentRevision = proj.Revisions.Where(r => r.Status == RevisionStatuses.InProgress).FirstOrDefault();            
            PopulateTree();
            SetupToolbar();
            tabList = new List<TabInfo>();
        }

        #endregion

        #region app data functions

        void SaveAppData() {
            FileTools.WriteJson<AppData>(appData, appDataPath);
        }

        #endregion

        #region menu functions

        private void mnuOpenProject_Click(object sender, EventArgs e) {
            OpenFromFile();    
        }

        private void SetupRecentsMenu() {
            mnuRecents.DropDownItems.Clear();
            if (appData.RecentProjects != null) {
                foreach (var recent in appData.RecentProjects) {
                    ToolStripMenuItem item = new ToolStripMenuItem(recent);
                    item.Click += RecentClicked; ;
                    mnuRecents.DropDownItems.Add(item);
                }
            }
        }
       
        private void RecentClicked(object sender, EventArgs e) {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            OpenProject(item.Text);
        }
        
        private void AddToRecents(string path) {
            // make sure this path is not already in the app data
            if (appData.RecentProjects.Contains(path)) {
                appData.RecentProjects.Remove(path);
            }

            // insert the path at the beginning
            appData.RecentProjects.Insert(0, path);
            // make sure we have exceeded the max
            if (appData.RecentProjects.Count > 5) {
                appData.RecentProjects.RemoveAt(4);
            }

            SetupRecentsMenu();
            SaveAppData();
        }

        #endregion

        #region tree functions

        void PopulateTree() {
            treMain.Nodes.Clear();
            TreeNode newEntityNode = new TreeNode("Staged Entities");
            if (currentRevision != null) {
                // add a node to show new entities                
                treMain.Nodes.Add(newEntityNode);
            }

            // add the main folders
            TreeNode parentEntityNode = new TreeNode("Entity");
            treMain.Nodes.Add(parentEntityNode);
            foreach (var entity in proj.Entities) {
                TreeNode entityNode = new TreeNode(entity.EntityName);
                entityNode.Tag = entity;
                // see which node it should be added to
                if (entity.StatusCode == EntityStatusCodes.Staged) {
                    newEntityNode.Nodes.Add(entityNode);
                } else {
                    parentEntityNode.Nodes.Add(entityNode);
                }
            }

            parentEntityNode.Expand();
            newEntityNode.Expand();
        }

        private void treMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Tag != null && e.Node.Tag is EntityInfo) {
                var entity = e.Node.Tag as EntityInfo;
                LoadEntity(entity);
            }
        } 
        
        private void ctxTree_Opening(object sender, CancelEventArgs e) {
            var nodeLevel = treMain.SelectedNode == null ? -1 : treMain.SelectedNode.Level;
            ctxmImportEntity.Visible = nodeLevel == TreeLevels.EntityParent;
            ctxmGenAll.Visible = nodeLevel == TreeLevels.Entity;
            ctxmCreateEntity.Visible = currentRevision != null;
        }

        private void ctxmGenAll_Click(object sender, EventArgs e) {
            var opt = new GenerateCodeOptions() {
                Project = proj,
                Entity = (EntityInfo)treMain.SelectedNode.Tag,
                TemplatePath = appData.TemplatePath
            };

            NETCodeGenerator gen = new NETCodeGenerator();
            gen.GenerateTemplateGroup(opt, netGroup);
        }

        private void ctxmCreateEntity_Click(object sender, EventArgs e) {
            EntityInfo entity = new EntityInfo();
            entity.EntityName = "New Entity";
            entity.StatusCode = EntityStatusCodes.Staged;
            entity.EntityId = Helpers.GenerateUniqueId(id => proj.Entities.Any(en => en.EntityId == id));
            LoadEntity(entity);
        }
        
        private void ctxmImportEntity_Click(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {              
                var entity = al.GetEntityFromClassFile(fileDialog.FileName);
                proj.Entities.Add(entity);
                PopulateTree();
            }
        }

        #endregion

        #region entity functions

        private void LoadEntity(EntityInfo entity) {          
            var tab = new TabPage(entity.EntityName);
            tab.Tag = entity;
            tabMain.TabPages.Add(tab);
            var editor = new EditEntity(entity, () => getNewFieldId());
            tab.Controls.Add(editor);
            editor.Dock = DockStyle.Fill;
            editor.IsDirtyChanged += Editor_IsDirtyChanged;
            tabList.Add(new TabInfo(entity, editor, tab));           
        }

        private void Editor_IsDirtyChanged(EditEntity editEntity) {
            var tab = editEntity.Parent as TabPage;
            tab.Text = editEntity.Entity.EntityName + "*";
            isDirty = true;
            SetupToolbar();
        }

        int getNewFieldId() {
            return Helpers.GenerateUniqueId(id => proj.Entities.Any(e => e.Fields.Any(f => f.EntityFieldId == id)));
        }

        #endregion

        #region revisions

        private void createRevision() {
            Revision revision = new Revision();
            revision.BeginDate = DateTime.Now;
            revision.Status = RevisionStatuses.InProgress;
            // create a revision name
            int count = proj.Revisions.Count();
            revision.RevisionName = $"Revision #{count + 1}";
            proj.Revisions.Add(revision);
            currentRevision = revision;
            isDirty = true;
            SetupToolbar();
        }


        void CommitVersion() {
            // make sure everything is saved
            SaveProject();
            ProjectWorker worker = new ProjectWorker();
            worker.CommitRevision(proj, currentRevision);

        }

        #endregion

        #region toolbar
        private void btnSave_Click(object sender, EventArgs e) {
            SaveProject();
        }

        private void SetupToolbar() {
            btnSave.Enabled = isDirty;
            btnBeginRevision.Visible = proj != null && currentRevision == null;
            lblCurrentRevision.Visible = currentRevision != null;
            lblCurrentRevisionLabel.Visible = currentRevision != null;
            btnCommitRevision.Visible = currentRevision != null;
            lblCurrentRevision.Text = currentRevision != null ? currentRevision.RevisionName : string.Empty;
        }

        private void btnBeginRevision_Click(object sender, EventArgs e) {
            createRevision();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            OpenFromFile();
        }

        private void btnCommitRevision_Click(object sender, EventArgs e) {
            CommitVersion();
        }

        #endregion
    }
}
