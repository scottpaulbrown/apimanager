namespace APIManager.WIN {
    partial class EditTemplate {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTemplate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFileMask = new System.Windows.Forms.TextBox();
            this.txtPathMask = new System.Windows.Forms.TextBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrimaryKeyField = new System.Windows.Forms.Label();
            this.cboProjType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddAttributes = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.grdEntityAttributes = new System.Windows.Forms.DataGridView();
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxEntityAttr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateEntityAttributeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntityAttributes)).BeginInit();
            this.ctxEntityAttr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateEntityAttributeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtFileMask);
            this.panel1.Controls.Add(this.txtPathMask);
            this.panel1.Controls.Add(this.cboLanguage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblPrimaryKeyField);
            this.panel1.Controls.Add(this.cboProjType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 159);
            this.panel1.TabIndex = 3;
            // 
            // txtFileMask
            // 
            this.txtFileMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileMask.Location = new System.Drawing.Point(802, 109);
            this.txtFileMask.Name = "txtFileMask";
            this.txtFileMask.Size = new System.Drawing.Size(408, 26);
            this.txtFileMask.TabIndex = 4;
            // 
            // txtPathMask
            // 
            this.txtPathMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathMask.Location = new System.Drawing.Point(178, 109);
            this.txtPathMask.Name = "txtPathMask";
            this.txtPathMask.Size = new System.Drawing.Size(490, 26);
            this.txtPathMask.TabIndex = 3;
            // 
            // cboLanguage
            // 
            this.cboLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "Lookup",
            "Collection"});
            this.cboLanguage.Location = new System.Drawing.Point(802, 59);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(408, 28);
            this.cboLanguage.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Language:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(178, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1032, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblPrimaryKeyField
            // 
            this.lblPrimaryKeyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryKeyField.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPrimaryKeyField.Location = new System.Drawing.Point(178, 112);
            this.lblPrimaryKeyField.Name = "lblPrimaryKeyField";
            this.lblPrimaryKeyField.Size = new System.Drawing.Size(160, 20);
            this.lblPrimaryKeyField.TabIndex = 8;
            // 
            // cboProjType
            // 
            this.cboProjType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjType.FormattingEnabled = true;
            this.cboProjType.Items.AddRange(new object[] {
            "Lookup",
            "Collection"});
            this.cboProjType.Location = new System.Drawing.Point(178, 59);
            this.cboProjType.Name = "cboProjType";
            this.cboProjType.Size = new System.Drawing.Size(490, 28);
            this.cboProjType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Mask:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path Mask:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Type:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAttributes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1246, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddAttributes
            // 
            this.btnAddAttributes.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAttributes.Image")));
            this.btnAddAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAttributes.Name = "btnAddAttributes";
            this.btnAddAttributes.Size = new System.Drawing.Size(157, 33);
            this.btnAddAttributes.Text = "Add Attributes";
            this.btnAddAttributes.Click += new System.EventHandler(this.btnAddAttributes_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Entity Attributes";
            // 
            // grdEntityAttributes
            // 
            this.grdEntityAttributes.AllowUserToAddRows = false;
            this.grdEntityAttributes.AllowUserToDeleteRows = false;
            this.grdEntityAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEntityAttributes.AutoGenerateColumns = false;
            this.grdEntityAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEntityAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntityAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn});
            this.grdEntityAttributes.ContextMenuStrip = this.ctxEntityAttr;
            this.grdEntityAttributes.DataSource = this.templateEntityAttributeBindingSource;
            this.grdEntityAttributes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdEntityAttributes.Location = new System.Drawing.Point(12, 270);
            this.grdEntityAttributes.Name = "grdEntityAttributes";
            this.grdEntityAttributes.ReadOnly = true;
            this.grdEntityAttributes.RowHeadersVisible = false;
            this.grdEntityAttributes.RowHeadersWidth = 62;
            this.grdEntityAttributes.RowTemplate.Height = 28;
            this.grdEntityAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEntityAttributes.Size = new System.Drawing.Size(1219, 514);
            this.grdEntityAttributes.TabIndex = 6;
            // 
            // entityAttributeTypeCodeDataGridViewTextBoxColumn
            // 
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "EntityAttributeTypeCode";
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.HeaderText = "Attribute Type";
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.Name = "entityAttributeTypeCodeDataGridViewTextBoxColumn";
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ctxEntityAttr
            // 
            this.ctxEntityAttr.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxEntityAttr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.ctxEntityAttr.Name = "ctxEntityAttr";
            this.ctxEntityAttr.Size = new System.Drawing.Size(157, 36);
            this.ctxEntityAttr.Opening += new System.ComponentModel.CancelEventHandler(this.ctxEntityAttr_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // templateEntityAttributeBindingSource
            // 
            this.templateEntityAttributeBindingSource.DataSource = typeof(APIManager.Data.TemplateEntityAttribute);
            // 
            // EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 796);
            this.Controls.Add(this.grdEntityAttributes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EditTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTemplate";
            this.Load += new System.EventHandler(this.EditTemplate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntityAttributes)).EndInit();
            this.ctxEntityAttr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templateEntityAttributeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFileMask;
        private System.Windows.Forms.TextBox txtPathMask;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrimaryKeyField;
        private System.Windows.Forms.ComboBox cboProjType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdEntityAttributes;
        private System.Windows.Forms.BindingSource templateEntityAttributeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityAttributeTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnAddAttributes;
        private System.Windows.Forms.ContextMenuStrip ctxEntityAttr;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}