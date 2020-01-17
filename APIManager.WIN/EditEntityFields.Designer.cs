namespace APIManager.WIN {
    partial class EditEntityFields {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEntityFields));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInitialValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkContains = new System.Windows.Forms.CheckBox();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.chkDTO = new System.Windows.Forms.CheckBox();
            this.btnSaveAddMore = new System.Windows.Forms.Button();
            this.btnSaveField = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRequired = new System.Windows.Forms.CheckBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.lblScale = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdFields = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.entityFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isRequiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDTO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSearchFieldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContainsSearchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InitialValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtInitialValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkContains);
            this.groupBox2.Controls.Add(this.chkSearch);
            this.groupBox2.Controls.Add(this.chkDTO);
            this.groupBox2.Location = new System.Drawing.Point(1069, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 216);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Options";
            // 
            // txtInitialValue
            // 
            this.txtInitialValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialValue.Location = new System.Drawing.Point(17, 155);
            this.txtInitialValue.Name = "txtInitialValue";
            this.txtInitialValue.Size = new System.Drawing.Size(281, 32);
            this.txtInitialValue.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Initial Value:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkContains
            // 
            this.chkContains.AutoSize = true;
            this.chkContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContains.Location = new System.Drawing.Point(138, 76);
            this.chkContains.Name = "chkContains";
            this.chkContains.Size = new System.Drawing.Size(133, 33);
            this.chkContains.TabIndex = 4;
            this.chkContains.Text = "Contains";
            this.chkContains.UseVisualStyleBackColor = true;
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearch.Location = new System.Drawing.Point(17, 76);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(115, 33);
            this.chkSearch.TabIndex = 3;
            this.chkSearch.Text = "Search";
            this.chkSearch.UseVisualStyleBackColor = true;
            // 
            // chkDTO
            // 
            this.chkDTO.AutoSize = true;
            this.chkDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDTO.Location = new System.Drawing.Point(17, 39);
            this.chkDTO.Name = "chkDTO";
            this.chkDTO.Size = new System.Drawing.Size(91, 33);
            this.chkDTO.TabIndex = 2;
            this.chkDTO.Text = "DTO";
            this.chkDTO.UseVisualStyleBackColor = true;
            // 
            // btnSaveAddMore
            // 
            this.btnSaveAddMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAddMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddMore.Location = new System.Drawing.Point(1170, 307);
            this.btnSaveAddMore.Name = "btnSaveAddMore";
            this.btnSaveAddMore.Size = new System.Drawing.Size(257, 40);
            this.btnSaveAddMore.TabIndex = 17;
            this.btnSaveAddMore.Text = "Save/Add Another";
            this.btnSaveAddMore.UseVisualStyleBackColor = true;
            this.btnSaveAddMore.Click += new System.EventHandler(this.btnSaveAddMore_Click);
            // 
            // btnSaveField
            // 
            this.btnSaveField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveField.Location = new System.Drawing.Point(1436, 307);
            this.btnSaveField.Name = "btnSaveField";
            this.btnSaveField.Size = new System.Drawing.Size(135, 40);
            this.btnSaveField.TabIndex = 16;
            this.btnSaveField.Text = "Save";
            this.btnSaveField.UseVisualStyleBackColor = true;
            this.btnSaveField.Click += new System.EventHandler(this.btnSaveField_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkRequired);
            this.groupBox1.Controls.Add(this.txtScale);
            this.groupBox1.Controls.Add(this.lblScale);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cboDataType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 227);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // chkRequired
            // 
            this.chkRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRequired.AutoSize = true;
            this.chkRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRequired.Location = new System.Drawing.Point(894, 70);
            this.chkRequired.Name = "chkRequired";
            this.chkRequired.Size = new System.Drawing.Size(139, 33);
            this.chkRequired.TabIndex = 1;
            this.chkRequired.Text = "Required";
            this.chkRequired.UseVisualStyleBackColor = true;
            // 
            // txtScale
            // 
            this.txtScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScale.Location = new System.Drawing.Point(916, 164);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(117, 32);
            this.txtScale.TabIndex = 4;
            // 
            // lblScale
            // 
            this.lblScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScale.Location = new System.Drawing.Point(911, 129);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(86, 31);
            this.lblScale.TabIndex = 10;
            this.lblScale.Text = "Scale:";
            this.lblScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLength
            // 
            this.txtLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(772, 164);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(125, 32);
            this.txtLength.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(767, 131);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(86, 31);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length:";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(847, 32);
            this.txtName.TabIndex = 0;
            // 
            // cboDataType
            // 
            this.cboDataType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "Lookup",
            "Collection"});
            this.cboDataType.Location = new System.Drawing.Point(6, 164);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(748, 34);
            this.cboDataType.TabIndex = 2;
            this.cboDataType.SelectedIndexChanged += new System.EventHandler(this.cboDataType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datatype:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // grdFields
            // 
            this.grdFields.AllowUserToAddRows = false;
            this.grdFields.AllowUserToDeleteRows = false;
            this.grdFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grdFields.DataSource = this.entityFieldBindingSource;
            this.grdFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdFields.Location = new System.Drawing.Point(12, 365);
            this.grdFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdFields.Name = "grdFields";
            this.grdFields.RowHeadersVisible = false;
            this.grdFields.RowHeadersWidth = 62;
            this.grdFields.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdFields.RowTemplate.Height = 28;
            this.grdFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFields.Size = new System.Drawing.Size(1559, 675);
            this.grdFields.TabIndex = 20;
            this.grdFields.SelectionChanged += new System.EventHandler(this.grdFields_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1578, 34);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 29);
            this.toolStripButton1.Text = "Done";
            // 
            // entityFieldBindingSource
            // 
            this.entityFieldBindingSource.DataSource = typeof(APIManager.Data.EntityField);
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
            // IsDTO
            // 
            this.IsDTO.DataPropertyName = "IsDTO";
            this.IsDTO.HeaderText = "DTO";
            this.IsDTO.MinimumWidth = 10;
            this.IsDTO.Name = "IsDTO";
            this.IsDTO.Width = 120;
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
            // InitialValue
            // 
            this.InitialValue.DataPropertyName = "InitialValue";
            this.InitialValue.HeaderText = "Initial Value";
            this.InitialValue.MinimumWidth = 8;
            this.InitialValue.Name = "InitialValue";
            this.InitialValue.Width = 250;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(988, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditEntityFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1049);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdFields);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveAddMore);
            this.Controls.Add(this.btnSaveField);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditEntityFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEntityFields";
            this.Load += new System.EventHandler(this.EditEntityFields_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditEntityFields_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInitialValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkContains;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.CheckBox chkDTO;
        private System.Windows.Forms.Button btnSaveAddMore;
        private System.Windows.Forms.Button btnSaveField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRequired;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource entityFieldBindingSource;
        private System.Windows.Forms.DataGridView grdFields;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRequiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSearchFieldDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContainsSearchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialValue;
        private System.Windows.Forms.Button btnCancel;
    }
}