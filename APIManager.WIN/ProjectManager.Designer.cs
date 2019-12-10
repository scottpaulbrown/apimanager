namespace APIManager.WIN {
    partial class ProjectManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBeginRevision = new System.Windows.Forms.ToolStripButton();
            this.lblCurrentRevisionLabel = new System.Windows.Forms.ToolStripLabel();
            this.lblCurrentRevision = new System.Windows.Forms.ToolStripLabel();
            this.btnCommitRevision = new System.Windows.Forms.ToolStripButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecents = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treMain = new System.Windows.Forms.TreeView();
            this.ctxTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmImportEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmGenAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmCreateEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.projDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ctxTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnBeginRevision,
            this.lblCurrentRevisionLabel,
            this.lblCurrentRevision,
            this.btnCommitRevision});
            this.toolStrip1.Location = new System.Drawing.Point(0, 85);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2813, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(46, 61);
            this.btnOpen.Text = "toolStripButton1";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 61);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // btnBeginRevision
            // 
            this.btnBeginRevision.Image = ((System.Drawing.Image)(resources.GetObject("btnBeginRevision.Image")));
            this.btnBeginRevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBeginRevision.Name = "btnBeginRevision";
            this.btnBeginRevision.Size = new System.Drawing.Size(186, 61);
            this.btnBeginRevision.Text = "Start Revision";
            this.btnBeginRevision.Click += new System.EventHandler(this.btnBeginRevision_Click);
            // 
            // lblCurrentRevisionLabel
            // 
            this.lblCurrentRevisionLabel.Name = "lblCurrentRevisionLabel";
            this.lblCurrentRevisionLabel.Size = new System.Drawing.Size(195, 61);
            this.lblCurrentRevisionLabel.Text = "Current Revision:";
            this.lblCurrentRevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentRevision
            // 
            this.lblCurrentRevision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRevision.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCurrentRevision.Name = "lblCurrentRevision";
            this.lblCurrentRevision.Size = new System.Drawing.Size(146, 61);
            this.lblCurrentRevision.Text = "Revision #1";
            this.lblCurrentRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCommitRevision
            // 
            this.btnCommitRevision.Image = ((System.Drawing.Image)(resources.GetObject("btnCommitRevision.Image")));
            this.btnCommitRevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCommitRevision.Name = "btnCommitRevision";
            this.btnCommitRevision.Size = new System.Drawing.Size(128, 61);
            this.btnCommitRevision.Text = "Commit";
            this.btnCommitRevision.ToolTipText = "Commit Revision";
            this.btnCommitRevision.Click += new System.EventHandler(this.btnCommitRevision_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            this.fileDialog.Filter = "C# Files|*.cs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2813, 64);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuRecents});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 60);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(311, 44);
            this.mnuOpenProject.Text = "Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuRecents
            // 
            this.mnuRecents.Name = "mnuRecents";
            this.mnuRecents.Size = new System.Drawing.Size(311, 44);
            this.mnuRecents.Text = "Recent Projects";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 175);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Size = new System.Drawing.Size(2813, 1647);
            this.splitContainer1.SplitterDistance = 935;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // treMain
            // 
            this.treMain.ContextMenuStrip = this.ctxTree;
            this.treMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treMain.Location = new System.Drawing.Point(0, 0);
            this.treMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treMain.Name = "treMain";
            this.treMain.Size = new System.Drawing.Size(935, 1647);
            this.treMain.TabIndex = 0;
            this.treMain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treMain_NodeMouseDoubleClick);
            // 
            // ctxTree
            // 
            this.ctxTree.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmImportEntity,
            this.ctxmGenAll,
            this.ctxmCreateEntity});
            this.ctxTree.Name = "ctxTree";
            this.ctxTree.Size = new System.Drawing.Size(229, 118);
            this.ctxTree.Opening += new System.ComponentModel.CancelEventHandler(this.ctxTree_Opening);
            // 
            // ctxmImportEntity
            // 
            this.ctxmImportEntity.Name = "ctxmImportEntity";
            this.ctxmImportEntity.Size = new System.Drawing.Size(228, 38);
            this.ctxmImportEntity.Text = "Import Entity";
            this.ctxmImportEntity.Click += new System.EventHandler(this.ctxmImportEntity_Click);
            // 
            // ctxmGenAll
            // 
            this.ctxmGenAll.Name = "ctxmGenAll";
            this.ctxmGenAll.Size = new System.Drawing.Size(228, 38);
            this.ctxmGenAll.Text = "Generate All";
            this.ctxmGenAll.Click += new System.EventHandler(this.ctxmGenAll_Click);
            // 
            // ctxmCreateEntity
            // 
            this.ctxmCreateEntity.Name = "ctxmCreateEntity";
            this.ctxmCreateEntity.Size = new System.Drawing.Size(228, 38);
            this.ctxmCreateEntity.Text = "Create Entity";
            this.ctxmCreateEntity.Click += new System.EventHandler(this.ctxmCreateEntity_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1873, 1647);
            this.tabMain.TabIndex = 0;
            // 
            // projDialog
            // 
            this.projDialog.FileName = "openFileDialog1";
            this.projDialog.Filter = "Project Files|*.json";
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2110, 1366);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProjectManager";
            this.Text = "ProjectManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ctxTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treMain;
        private System.Windows.Forms.OpenFileDialog projDialog;
        private System.Windows.Forms.ContextMenuStrip ctxTree;
        private System.Windows.Forms.ToolStripMenuItem ctxmImportEntity;
        private System.Windows.Forms.ToolStripMenuItem mnuRecents;
        private System.Windows.Forms.ToolStripMenuItem ctxmGenAll;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBeginRevision;
        private System.Windows.Forms.ToolStripLabel lblCurrentRevisionLabel;
        private System.Windows.Forms.ToolStripLabel lblCurrentRevision;
        private System.Windows.Forms.ToolStripButton btnCommitRevision;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripMenuItem ctxmCreateEntity;
    }
}