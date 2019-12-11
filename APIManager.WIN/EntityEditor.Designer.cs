namespace APIManager.WIN {
    partial class EntityEditor {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdFields = new System.Windows.Forms.DataGridView();
            this.IsDTO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InitialValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxFields = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmDeleteField = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmUnDeleteField = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctxLinks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmCreateLink = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.maxLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isRequiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSearchFieldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContainsSearchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entityFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityLinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ForeignKeyFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryKeyEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryKeyFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).BeginInit();
            this.ctxFields.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ctxLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityLinkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1863, 78);
            this.panel1.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(88, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1758, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1863, 795);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdFields);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1855, 762);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fields";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdFields
            // 
            this.grdFields.AutoGenerateColumns = false;
            this.grdFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNameDataGridViewTextBoxColumn,
            this.colDataType,
            this.maxLengthDataGridViewTextBoxColumn,
            this.scaleDataGridViewTextBoxColumn,
            this.isKeyDataGridViewCheckBoxColumn,
            this.isIdentityDataGridViewCheckBoxColumn,
            this.isRequiredDataGridViewCheckBoxColumn,
            this.IsDTO,
            this.isSearchFieldDataGridViewCheckBoxColumn,
            this.isContainsSearchDataGridViewCheckBoxColumn,
            this.InitialValue});
            this.grdFields.ContextMenuStrip = this.ctxFields;
            this.grdFields.DataSource = this.entityFieldBindingSource;
            this.grdFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdFields.Location = new System.Drawing.Point(2, 2);
            this.grdFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdFields.Name = "grdFields";
            this.grdFields.RowHeadersWidth = 62;
            this.grdFields.RowTemplate.Height = 28;
            this.grdFields.Size = new System.Drawing.Size(1851, 758);
            this.grdFields.TabIndex = 3;
            this.grdFields.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFields_CellValueChanged);
            this.grdFields.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdFields_CurrentCellDirtyStateChanged);
            this.grdFields.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdFields_RowPrePaint);
            // 
            // IsDTO
            // 
            this.IsDTO.DataPropertyName = "IsDTO";
            this.IsDTO.HeaderText = "DTO";
            this.IsDTO.MinimumWidth = 10;
            this.IsDTO.Name = "IsDTO";
            this.IsDTO.Width = 120;
            // 
            // InitialValue
            // 
            this.InitialValue.DataPropertyName = "InitialValue";
            this.InitialValue.HeaderText = "Initial Value";
            this.InitialValue.MinimumWidth = 8;
            this.InitialValue.Name = "InitialValue";
            this.InitialValue.Width = 250;
            // 
            // ctxFields
            // 
            this.ctxFields.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxFields.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmDeleteField,
            this.ctxmUnDeleteField});
            this.ctxFields.Name = "ctxFields";
            this.ctxFields.Size = new System.Drawing.Size(185, 68);
            this.ctxFields.Opening += new System.ComponentModel.CancelEventHandler(this.ctxFields_Opening);
            // 
            // ctxmDeleteField
            // 
            this.ctxmDeleteField.Image = ((System.Drawing.Image)(resources.GetObject("ctxmDeleteField.Image")));
            this.ctxmDeleteField.Name = "ctxmDeleteField";
            this.ctxmDeleteField.Size = new System.Drawing.Size(184, 32);
            this.ctxmDeleteField.Text = "Delete Field";
            this.ctxmDeleteField.Click += new System.EventHandler(this.ctxmDeleteField_Click);
            // 
            // ctxmUnDeleteField
            // 
            this.ctxmUnDeleteField.Image = ((System.Drawing.Image)(resources.GetObject("ctxmUnDeleteField.Image")));
            this.ctxmUnDeleteField.Name = "ctxmUnDeleteField";
            this.ctxmUnDeleteField.Size = new System.Drawing.Size(184, 32);
            this.ctxmUnDeleteField.Text = "Undelete";
            this.ctxmUnDeleteField.Click += new System.EventHandler(this.ctxmUnDeleteField_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1855, 762);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Links";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ForeignKeyFieldName,
            this.PrimaryKeyEntityName,
            this.PrimaryKeyFieldName,
            this.LinkTypeName});
            this.dataGridView1.ContextMenuStrip = this.ctxLinks;
            this.dataGridView1.DataSource = this.entityLinkBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1851, 758);
            this.dataGridView1.TabIndex = 0;
            // 
            // ctxLinks
            // 
            this.ctxLinks.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ctxLinks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmCreateLink});
            this.ctxLinks.Name = "ctxLinks";
            this.ctxLinks.Size = new System.Drawing.Size(171, 36);
            // 
            // ctxmCreateLink
            // 
            this.ctxmCreateLink.Name = "ctxmCreateLink";
            this.ctxmCreateLink.Size = new System.Drawing.Size(170, 32);
            this.ctxmCreateLink.Text = "Create Link";
            this.ctxmCreateLink.Click += new System.EventHandler(this.ctxmCreateLink_Click);
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "Field Name";
            this.fieldNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            this.fieldNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // colDataType
            // 
            this.colDataType.DataPropertyName = "Datatype";
            this.colDataType.HeaderText = "Datatype";
            this.colDataType.MinimumWidth = 9;
            this.colDataType.Name = "colDataType";
            this.colDataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDataType.Width = 175;
            // 
            // maxLengthDataGridViewTextBoxColumn
            // 
            this.maxLengthDataGridViewTextBoxColumn.DataPropertyName = "MaxLength";
            this.maxLengthDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxLengthDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.maxLengthDataGridViewTextBoxColumn.Name = "maxLengthDataGridViewTextBoxColumn";
            this.maxLengthDataGridViewTextBoxColumn.Width = 120;
            // 
            // scaleDataGridViewTextBoxColumn
            // 
            this.scaleDataGridViewTextBoxColumn.DataPropertyName = "Scale";
            this.scaleDataGridViewTextBoxColumn.HeaderText = "Scale";
            this.scaleDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.scaleDataGridViewTextBoxColumn.Name = "scaleDataGridViewTextBoxColumn";
            this.scaleDataGridViewTextBoxColumn.Width = 120;
            // 
            // isKeyDataGridViewCheckBoxColumn
            // 
            this.isKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsKey";
            this.isKeyDataGridViewCheckBoxColumn.HeaderText = "Key";
            this.isKeyDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.isKeyDataGridViewCheckBoxColumn.Name = "isKeyDataGridViewCheckBoxColumn";
            this.isKeyDataGridViewCheckBoxColumn.Width = 120;
            // 
            // isIdentityDataGridViewCheckBoxColumn
            // 
            this.isIdentityDataGridViewCheckBoxColumn.DataPropertyName = "IsIdentity";
            this.isIdentityDataGridViewCheckBoxColumn.HeaderText = "Identity";
            this.isIdentityDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.isIdentityDataGridViewCheckBoxColumn.Name = "isIdentityDataGridViewCheckBoxColumn";
            this.isIdentityDataGridViewCheckBoxColumn.Width = 120;
            // 
            // isRequiredDataGridViewCheckBoxColumn
            // 
            this.isRequiredDataGridViewCheckBoxColumn.DataPropertyName = "IsRequired";
            this.isRequiredDataGridViewCheckBoxColumn.HeaderText = "Required";
            this.isRequiredDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.isRequiredDataGridViewCheckBoxColumn.Name = "isRequiredDataGridViewCheckBoxColumn";
            this.isRequiredDataGridViewCheckBoxColumn.Width = 120;
            // 
            // isSearchFieldDataGridViewCheckBoxColumn
            // 
            this.isSearchFieldDataGridViewCheckBoxColumn.DataPropertyName = "IsSearchField";
            this.isSearchFieldDataGridViewCheckBoxColumn.HeaderText = "Search";
            this.isSearchFieldDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.isSearchFieldDataGridViewCheckBoxColumn.Name = "isSearchFieldDataGridViewCheckBoxColumn";
            this.isSearchFieldDataGridViewCheckBoxColumn.Width = 120;
            // 
            // isContainsSearchDataGridViewCheckBoxColumn
            // 
            this.isContainsSearchDataGridViewCheckBoxColumn.DataPropertyName = "IsContainsSearch";
            this.isContainsSearchDataGridViewCheckBoxColumn.HeaderText = "Contains";
            this.isContainsSearchDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.isContainsSearchDataGridViewCheckBoxColumn.Name = "isContainsSearchDataGridViewCheckBoxColumn";
            this.isContainsSearchDataGridViewCheckBoxColumn.Width = 120;
            // 
            // entityFieldBindingSource
            // 
            this.entityFieldBindingSource.DataSource = typeof(APIManager.Data.EntityField);
            // 
            // entityLinkBindingSource
            // 
            this.entityLinkBindingSource.DataSource = typeof(APIManager.Data.EntityLink);
            // 
            // ForeignKeyFieldName
            // 
            this.ForeignKeyFieldName.DataPropertyName = "ForeignKeyFieldName";
            this.ForeignKeyFieldName.HeaderText = "Field";
            this.ForeignKeyFieldName.MinimumWidth = 8;
            this.ForeignKeyFieldName.Name = "ForeignKeyFieldName";
            // 
            // PrimaryKeyEntityName
            // 
            this.PrimaryKeyEntityName.DataPropertyName = "PrimaryKeyEntityName";
            this.PrimaryKeyEntityName.HeaderText = "Primary Key Entity";
            this.PrimaryKeyEntityName.MinimumWidth = 8;
            this.PrimaryKeyEntityName.Name = "PrimaryKeyEntityName";
            // 
            // PrimaryKeyFieldName
            // 
            this.PrimaryKeyFieldName.DataPropertyName = "PrimaryKeyFieldName";
            this.PrimaryKeyFieldName.HeaderText = "Primary Key Field";
            this.PrimaryKeyFieldName.MinimumWidth = 8;
            this.PrimaryKeyFieldName.Name = "PrimaryKeyFieldName";
            // 
            // LinkTypeName
            // 
            this.LinkTypeName.DataPropertyName = "LinkTypeName";
            this.LinkTypeName.HeaderText = "Link Type";
            this.LinkTypeName.MinimumWidth = 8;
            this.LinkTypeName.Name = "LinkTypeName";
            // 
            // EntityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntityEditor";
            this.Size = new System.Drawing.Size(1863, 873);
            this.Load += new System.EventHandler(this.EntityEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).EndInit();
            this.ctxFields.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ctxLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityLinkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdFields;
        private System.Windows.Forms.BindingSource entityFieldBindingSource;
        private System.Windows.Forms.ContextMenuStrip ctxLinks;
        private System.Windows.Forms.ToolStripMenuItem ctxmCreateLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRequiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSearchFieldDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContainsSearchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialValue;
        private System.Windows.Forms.ContextMenuStrip ctxFields;
        private System.Windows.Forms.ToolStripMenuItem ctxmDeleteField;
        private System.Windows.Forms.ToolStripMenuItem ctxmUnDeleteField;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryKeyFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource entityLinkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignKeyFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryKeyEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryKeyFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkTypeName;
    }
}
