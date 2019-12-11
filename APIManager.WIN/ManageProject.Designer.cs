namespace APIManager.WIN {
    partial class ManageProject {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProject));
            this.projDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBeginRevision = new System.Windows.Forms.ToolStripButton();
            this.lblCurrentRevisionLabel = new System.Windows.Forms.ToolStripLabel();
            this.lblCurrentRevision = new System.Windows.Forms.ToolStripLabel();
            this.btnGenScript = new System.Windows.Forms.ToolStripButton();
            this.btnCommitRevision = new System.Windows.Forms.ToolStripButton();
            this.ctxmGenAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmCreateEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treMain = new System.Windows.Forms.TreeView();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.ctxTree.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projDialog
            // 
            this.projDialog.FileName = "openFileDialog1";
            this.projDialog.Filter = "Project Files|*.json";
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
            this.btnGenScript,
            this.btnCommitRevision});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1298, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(34, 29);
            this.btnOpen.Text = "toolStripButton1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 29);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnBeginRevision
            // 
            this.btnBeginRevision.Image = ((System.Drawing.Image)(resources.GetObject("btnBeginRevision.Image")));
            this.btnBeginRevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBeginRevision.Name = "btnBeginRevision";
            this.btnBeginRevision.Size = new System.Drawing.Size(146, 29);
            this.btnBeginRevision.Text = "Start Revision";
            this.btnBeginRevision.Click += new System.EventHandler(this.btnBeginRevision_Click);
            // 
            // lblCurrentRevisionLabel
            // 
            this.lblCurrentRevisionLabel.Name = "lblCurrentRevisionLabel";
            this.lblCurrentRevisionLabel.Size = new System.Drawing.Size(144, 29);
            this.lblCurrentRevisionLabel.Text = "Current Revision:";
            this.lblCurrentRevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentRevision
            // 
            this.lblCurrentRevision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRevision.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCurrentRevision.Name = "lblCurrentRevision";
            this.lblCurrentRevision.Size = new System.Drawing.Size(110, 29);
            this.lblCurrentRevision.Text = "Revision #1";
            this.lblCurrentRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenScript
            // 
            this.btnGenScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGenScript.Image = ((System.Drawing.Image)(resources.GetObject("btnGenScript.Image")));
            this.btnGenScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenScript.Name = "btnGenScript";
            this.btnGenScript.Size = new System.Drawing.Size(34, 29);
            this.btnGenScript.Text = "toolStripButton1";
            this.btnGenScript.ToolTipText = "Generate Script";
            this.btnGenScript.Click += new System.EventHandler(this.btnGenScript_Click);
            // 
            // btnCommitRevision
            // 
            this.btnCommitRevision.Image = ((System.Drawing.Image)(resources.GetObject("btnCommitRevision.Image")));
            this.btnCommitRevision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCommitRevision.Name = "btnCommitRevision";
            this.btnCommitRevision.Size = new System.Drawing.Size(104, 29);
            this.btnCommitRevision.Text = "Commit";
            this.btnCommitRevision.ToolTipText = "Commit Revision";
            this.btnCommitRevision.Click += new System.EventHandler(this.btnCommitRevision_Click);
            // 
            // ctxmGenAll
            // 
            this.ctxmGenAll.Name = "ctxmGenAll";
            this.ctxmGenAll.Size = new System.Drawing.Size(183, 32);
            this.ctxmGenAll.Text = "Generate All";
            // 
            // ctxTree
            // 
            this.ctxTree.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmGenAll,
            this.ctxmCreateEntity});
            this.ctxTree.Name = "ctxTree";
            this.ctxTree.Size = new System.Drawing.Size(184, 68);
            this.ctxTree.Opening += new System.ComponentModel.CancelEventHandler(this.ctxTree_Opening);
            // 
            // ctxmCreateEntity
            // 
            this.ctxmCreateEntity.Name = "ctxmCreateEntity";
            this.ctxmCreateEntity.Size = new System.Drawing.Size(183, 32);
            this.ctxmCreateEntity.Text = "Create Entity";
            this.ctxmCreateEntity.Click += new System.EventHandler(this.ctxmCreateEntity_Click);
            // 
            // mnuRecents
            // 
            this.mnuRecents.Name = "mnuRecents";
            this.mnuRecents.Size = new System.Drawing.Size(233, 34);
            this.mnuRecents.Text = "Recent Projects";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.Size = new System.Drawing.Size(233, 34);
            this.mnuOpenProject.Text = "Open Project";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuRecents});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImport});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // mnuImport
            // 
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(230, 34);
            this.mnuImport.Text = "Import Entities";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            this.fileDialog.Filter = "C# Files|*.cs";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.treMain);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Size = new System.Drawing.Size(1298, 750);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 6;
            // 
            // treMain
            // 
            this.treMain.ContextMenuStrip = this.ctxTree;
            this.treMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treMain.Location = new System.Drawing.Point(0, 10);
            this.treMain.Name = "treMain";
            this.treMain.Size = new System.Drawing.Size(431, 740);
            this.treMain.TabIndex = 0;
            this.treMain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treMain_NodeMouseDoubleClick);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(863, 750);
            this.tabMain.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "link.png");
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 817);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageProject";
            this.Text = "ManageProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageProject_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ctxTree.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog projDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBeginRevision;
        private System.Windows.Forms.ToolStripLabel lblCurrentRevisionLabel;
        private System.Windows.Forms.ToolStripLabel lblCurrentRevision;
        private System.Windows.Forms.ToolStripButton btnCommitRevision;
        private System.Windows.Forms.ToolStripMenuItem ctxmGenAll;
        private System.Windows.Forms.ContextMenuStrip ctxTree;
        private System.Windows.Forms.ToolStripMenuItem ctxmCreateEntity;
        private System.Windows.Forms.ToolStripMenuItem mnuRecents;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripButton btnGenScript;
        private System.Windows.Forms.ImageList imageList1;
    }
}