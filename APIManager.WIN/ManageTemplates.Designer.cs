namespace APIManager.WIN {
    partial class ManageTemplates {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTemplates));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.sepSave = new System.Windows.Forms.ToolStripSeparator();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.templateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeProjectTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileMaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathMaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel,
            this.sepSave,
            this.btnAdd,
            this.toolStripSeparator1,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1243, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 29);
            this.btnAdd.Text = "toolStripButton1";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 31);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.templateNameDataGridViewTextBoxColumn,
            this.codeProjectTypeCodeDataGridViewTextBoxColumn,
            this.languageTypeCodeDataGridViewTextBoxColumn,
            this.fileMaskDataGridViewTextBoxColumn,
            this.pathMaskDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.templateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 791);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataSource = typeof(APIManager.Data.Template);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 29);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sepSave
            // 
            this.sepSave.Name = "sepSave";
            this.sepSave.Size = new System.Drawing.Size(6, 34);
            // 
            // Select
            // 
            this.Select.FalseValue = "0";
            this.Select.FillWeight = 10F;
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.TrueValue = "1";
            // 
            // templateNameDataGridViewTextBoxColumn
            // 
            this.templateNameDataGridViewTextBoxColumn.DataPropertyName = "TemplateName";
            this.templateNameDataGridViewTextBoxColumn.FillWeight = 25F;
            this.templateNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.templateNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.templateNameDataGridViewTextBoxColumn.Name = "templateNameDataGridViewTextBoxColumn";
            this.templateNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeProjectTypeCodeDataGridViewTextBoxColumn
            // 
            this.codeProjectTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "CodeProjectTypeCode";
            this.codeProjectTypeCodeDataGridViewTextBoxColumn.FillWeight = 15F;
            this.codeProjectTypeCodeDataGridViewTextBoxColumn.HeaderText = "Project Type";
            this.codeProjectTypeCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeProjectTypeCodeDataGridViewTextBoxColumn.Name = "codeProjectTypeCodeDataGridViewTextBoxColumn";
            this.codeProjectTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageTypeCodeDataGridViewTextBoxColumn
            // 
            this.languageTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "LanguageTypeCode";
            this.languageTypeCodeDataGridViewTextBoxColumn.FillWeight = 10F;
            this.languageTypeCodeDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageTypeCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.languageTypeCodeDataGridViewTextBoxColumn.Name = "languageTypeCodeDataGridViewTextBoxColumn";
            this.languageTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileMaskDataGridViewTextBoxColumn
            // 
            this.fileMaskDataGridViewTextBoxColumn.DataPropertyName = "FileMask";
            this.fileMaskDataGridViewTextBoxColumn.FillWeight = 25F;
            this.fileMaskDataGridViewTextBoxColumn.HeaderText = "File Mask";
            this.fileMaskDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fileMaskDataGridViewTextBoxColumn.Name = "fileMaskDataGridViewTextBoxColumn";
            this.fileMaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathMaskDataGridViewTextBoxColumn
            // 
            this.pathMaskDataGridViewTextBoxColumn.DataPropertyName = "PathMask";
            this.pathMaskDataGridViewTextBoxColumn.FillWeight = 25F;
            this.pathMaskDataGridViewTextBoxColumn.HeaderText = "Path Mask";
            this.pathMaskDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pathMaskDataGridViewTextBoxColumn.Name = "pathMaskDataGridViewTextBoxColumn";
            this.pathMaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 858);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManageTemplates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageTemplates";
            this.Load += new System.EventHandler(this.ManageTemplates_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator sepSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProjectTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileMaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathMaskDataGridViewTextBoxColumn;
    }
}