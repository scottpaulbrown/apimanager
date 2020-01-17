using APIManager.Data;
using APIManager.Data.Constants;
using APIManager.Data.EntityData;
using APIManager.Data.General;
using APIManager.Data.ProjectData;
using APIManager.Data.ReferenceTypesData;
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
    public partial class ManageProject : Form {
        Project _project;
        Revision _currentRevision;
        AppData _appData;
        string _appDataPath = @"c:\projects\apimanager\appdata.json";        
        bool _isDirty = false;
        List<TabData> _tabList;
        List<Entity> _importedList;

        public ManageProject() {
            InitializeComponent();            
        }

        private void ManageProject_Load(object sender, EventArgs e) {           
            _appData = Helpers.OpenJson<AppData>(_appDataPath);
            GlobalData.AppInfo = new AppInfo();
            GlobalData.AppInfo.Context = new ProjManEntities();
            LoadReferenceTypes();
            SetupRecentsMenu();            
            // if there is a recent project, go ahead and load the last one
            if (_appData.RecentProjectList != null && _appData.RecentProjectList.Count > 0) {
                OpenProject(_appData.RecentProjectList[0].ProjectId);
            }
        }

        private void LoadReferenceTypes() {
            CommonReferenceTypes rt = new CommonReferenceTypes();
            ReferenceTypeLogic logic = new ReferenceTypeLogic(GlobalData.AppInfo);
            rt.CodeProjectTypes = logic.GetAllCodeProjectTypes();
            rt.LanguageTypes = logic.GetAllLanguageTypes();
            rt.EntityAttributeTypes = logic.GetAllEntityAttributeTypes();
            GlobalData.ReferenceTypes = rt;
        }

        #region menu functions

        private void mnuOpenProject_Click(object sender, EventArgs e) {
            //OpenFromFile();
        }

        private void SetupRecentsMenu() {
            mnuRecents.DropDownItems.Clear();
            if (_appData.RecentProjectList != null) {
                foreach (var recent in _appData.RecentProjectList) {
                    ToolStripMenuItem item = new ToolStripMenuItem(recent.ProjectName);
                    item.Tag = recent;
                    item.Click += RecentClicked;
                    mnuRecents.DropDownItems.Add(item);
                }
            }
        }

        private void RecentClicked(object sender, EventArgs e) {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            //OpenProject(item.Text);
        }

        private void AddToRecents(string path) {
            //// make sure this path is not already in the app data
            //if (appData.RecentProjects.Contains(path)) {
            //    appData.RecentProjects.Remove(path);
            //}

            //// insert the path at the beginning
            //appData.RecentProjects.Insert(0, path);
            //// make sure we have exceeded the max
            //if (appData.RecentProjects.Count > 5) {
            //    appData.RecentProjects.RemoveAt(4);
            //}

            //SetupRecentsMenu();
            //SaveAppData();
        }

        private void mnuImport_Click(object sender, EventArgs e) {
            ImportEntities();
        }

        private void mnuManTemplates_Click(object sender, EventArgs e) {
            var manTmp = new ManageTemplates();
            manTmp.ShowDialog();
        }
        private void manageTemplateGroupsToolStripMenuItem_Click(object sender, EventArgs e) {
            var manGrp = new ManageTemplateGroups();
            manGrp.ShowDialog();
        }

        #endregion

        #region toolbar
        private void btnSave_Click(object sender, EventArgs e) {
            SaveProject();
        }

        private void SetupToolbar() {
            btnSave.Enabled = _isDirty;
            btnBeginRevision.Visible = _project != null && _currentRevision == null;
            lblCurrentRevision.Visible = _currentRevision != null;
            lblCurrentRevisionLabel.Visible = _currentRevision != null;
            btnCommitRevision.Visible = _currentRevision != null;
            lblCurrentRevision.Text = _currentRevision != null ? _currentRevision.RevisionName : string.Empty;
        }

        private void btnBeginRevision_Click(object sender, EventArgs e) {
            createRevision();
        }

        //private void btnOpen_Click(object sender, EventArgs e) {
        //    OpenFromFile();
        //}

        private void btnCommitRevision_Click(object sender, EventArgs e) {
            CommitVersion();
        }
        
        private void btnGenScript_Click(object sender, EventArgs e) {
            GenerateScript();
        }

        #endregion

        #region project functions

        void SaveProject() {
            AddRevisionChangesArgs args = new AddRevisionChangesArgs();
            args.ProjectId = _project.ProjectId;
            args.EntityList = new List<Entity>();
            args.ImportedList = _importedList;
            
            foreach (TabData info in _tabList) {
                if (info.Editor.IsDirty) {
                    info.Editor.Save();
                    args.EntityList.Add(info.Editor.Entity);
                }
            }

            try {
                RevisionLogic logic = new RevisionLogic(GlobalData.AppInfo);
                logic.AddRevisionChanges(args);
                _isDirty = false;
                _importedList = new List<Entity>();
                OpenProject(_project.ProjectId);
            } catch (Exception ex) {
                throw;
            }
        }
        
        void OpenProject(int id) {
            ProjectLogic logic = new ProjectLogic(GlobalData.AppInfo);
            _project = logic.GetProject(id);            
            // see if there is a current revision
            _currentRevision = _project.Revisions.Where(r => r.RevisionStatusCode == RevisionStatuses.InProgress).FirstOrDefault();
            _importedList = new List<Entity>();
            PopulateTree();
            SetupToolbar();
            _tabList = new List<TabData>();
        }

        #endregion

        #region revisions

        private void createRevision() {
            RevisionLogic logic = new RevisionLogic(GlobalData.AppInfo);
            _currentRevision = logic.BeginRevision(_project.ProjectId);
            _importedList = new List<Entity>();
            SetupToolbar();
        }

        void CommitVersion() {
            // make sure everything is saved
            if (_isDirty) {
                SaveProject();
            }

            CommitRevsionArgs args = new CommitRevsionArgs() { RevisionId = _currentRevision.RevisionId, ExcuteMigration = true };
            CommitRevision rev = new CommitRevision(args);
            if (rev.ShowDialog() == DialogResult.OK) {
                var logic = new RevisionLogic(GlobalData.AppInfo);
                logic.CommitRevision(args);
                // reload the entire project
                OpenProject(_project.ProjectId);
            }
        }

        void GenerateScript() {
            // make sure everything is saved
            if (_isDirty) {
                SaveProject();
            }

            var logic = new RevisionLogic(GlobalData.AppInfo);
            logic.GenerateScript(_currentRevision.RevisionId);
        }

        #endregion

        #region entity functions

        private void LoadEntity(Entity entity) {
            var tab = new TabPage(entity.EntityName);
            tab.Tag = entity;
            tabMain.TabPages.Add(tab);
            // see if we need to make a copy
            var item = entity;
            if (entity.StatusCode == EntityStatusCodes.Active) {
                // make a copy of this entity
                item = EntityLogic.CopyEntity(entity, _currentRevision);
            }

            var editor = new EntityEditor(item, _project);
            tab.Controls.Add(editor);
            editor.Dock = DockStyle.Fill;
            editor.IsDirtyChanged += Editor_IsDirtyChanged;
            _tabList.Add(new TabData(tab, editor, entity));
        }

        private void Editor_IsDirtyChanged(EntityEditor editEntity) {
            var tab = editEntity.Parent as TabPage;
            tab.Text = editEntity.Entity.EntityName + "*";
            _isDirty = true;
            SetupToolbar();
        }

        void ImportEntities() {
            ImportEntities import = new ImportEntities(_project);
            if (import.ShowDialog() == DialogResult.OK) {
                // refresh the tree
                PopulateTree();
                _importedList.AddRange(import.ImportedList);
                _isDirty = true;
                SetupToolbar();
            }
        }

        void CreateLink() {
            var frm = new CreateLink();
            if (frm.ShowDialog() == DialogResult.OK) {

            }
        }

        #endregion

        #region tree functions

        void PopulateTree() {         
            treMain.Nodes.Clear();
            TreeNode newEntityNode = new TreeNode("Staged Entities");
            if (_currentRevision != null) {
                // add a node to show new entities                
                treMain.Nodes.Add(newEntityNode);
            }

            // add the main folders
            TreeNode parentEntityNode = new TreeNode("Entity");
            parentEntityNode.Tag = "Entity";
            treMain.Nodes.Add(parentEntityNode);
            foreach (var entity in _project.Entities) {
                TreeNode entityNode = new TreeNode(entity.EntityName);
                entityNode.Tag = entity;
                TreeNode fieldNode = new TreeNode("Fields");
                entityNode.Nodes.Add(fieldNode);
                var hasFieldChanges = LoadFieldsToNode(fieldNode, entity);
                TreeNode linkNode = new TreeNode("Links");
                entityNode.Nodes.Add(linkNode);
                var hasLinkChanges = LoadLinksToNode(linkNode, entity);
                if (hasFieldChanges || hasLinkChanges) {
                    entityNode.ForeColor = CommonColors.Modified;
                }
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

        private bool LoadFieldsToNode(TreeNode node, Entity entity) {
            var isNewEntity = entity.StatusCode == EntityStatusCodes.Staged;
            bool hasChanges = false;
            // get the fields that should be shown
            var fieldList = entity.EntityFields.Where(f => _currentRevision != null || f.StatusCode == EntityFieldStatusCodes.Active).ToList();
            foreach (var field in fieldList) {
                var isNew = !isNewEntity && field.StatusCode == EntityFieldStatusCodes.Staged;
                var isDeleted = !isNewEntity && _currentRevision != null && _currentRevision.FieldChanges.Any(c => c.EntityFieldId == field.EntityFieldId && c.FieldChangeTypeCode == FieldChangeTypes.Deleted);
                
                if (isNew || isDeleted) {
                    hasChanges = true;
                }

                var fieldNode = new TreeNode($"{field.FieldName} ({field.Datatype})");
                if (isNew) {
                    fieldNode.ForeColor = CommonColors.AddedDark;
                } else if (isDeleted) {
                    fieldNode.ForeColor = CommonColors.DeletedDark;
                }

                node.Nodes.Add(fieldNode);
            }

            return hasChanges;
        }

        private bool LoadLinksToNode(TreeNode node, Entity entity) {
            // get the fields that should be shown
            var fieldList = entity.EntityFields.Where(f => (_currentRevision != null || f.StatusCode == EntityFieldStatusCodes.Active) && (f.ParentLinks.Count() > 0)).ToList();
            var isNewEntity = entity.StatusCode == EntityStatusCodes.Staged;
            bool hasChanges = false;
            foreach (var field in fieldList) {
                if (field.ParentLinks.Count() > 0) {
                    foreach (var link in field.ParentLinks) {
                        var linkNode = new TreeNode($"{link.PrimaryKeyField.Entity.EntityName} ({link.PrimaryKeyField.FieldName}) - {link.LinkTypeCode}");  
                        if (!isNewEntity && link.StatusCode == EntityLinkStatusCodes.Staged) {
                            linkNode.ForeColor = CommonColors.AddedDark;
                            hasChanges = true;
                        }   
                        
                        node.Nodes.Add(linkNode);
                    }
                }
            }

            return hasChanges;
        }

        private void treMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Tag != null && e.Node.Tag is Entity) {
                var entity = e.Node.Tag as Entity;
                LoadEntity(entity);
            }
        }

        private void ctxTree_Opening(object sender, CancelEventArgs e) {
            bool isEntity = treMain.SelectedNode != null && treMain.SelectedNode.Tag != null && treMain.SelectedNode.Tag is Entity;
            var nodeLevel = treMain.SelectedNode == null ? -1 : treMain.SelectedNode.Level;
            //ctxmImportEntity.Visible = nodeLevel == TreeLevels.EntityParent;
            ctxmGenAll.Visible = treMain.SelectedNode != null && treMain.SelectedNode.Tag is Entity && treMain.SelectedNode.Parent.Tag.ToString() == "Entity";
            //ctxmCreateEntity.Visible = _currentRevision != null;
            createLinkToolStripMenuItem.Visible = isEntity;
        }

        private void ctxmGenAll_Click(object sender, EventArgs e) {
            //var opt = new GenerateCodeOptions() {
            //    Project = proj,
            //    Entity = (EntityInfo)treMain.SelectedNode.Tag,
            //    TemplatePath = appData.TemplatePath
            //};

            //NETCodeGenerator gen = new NETCodeGenerator();
            //gen.GenerateTemplateGroup(opt, netGroup);
        }

        private void ctxmCreateEntity_Click(object sender, EventArgs e) {
            Entity entity = new Entity();
            entity.EntityName = "NewEntity";
            entity.StatusCode = EntityStatusCodes.Staged;
            entity.ProjectId = _project.ProjectId;
            //LoadEntity(entity);
            var frm = new DesignEntity();
            if (frm.ShowDialog() == DialogResult.OK) {

            }
        }

        #endregion

        private void createLinkToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateLink();
        }
    }
}
