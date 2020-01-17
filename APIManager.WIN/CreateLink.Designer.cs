namespace APIManager.WIN {
    partial class CreateLink {
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.grdFields = new System.Windows.Forms.DataGridView();
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.maxLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isRequiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDTO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSearchFieldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContainsSearchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InitialValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityFieldEditor1 = new APIManager.WIN.EntityFieldEditor();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1041, 1288);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(345, 122);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(21, 1288);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(345, 122);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // grdFields
            // 
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
            this.grdFields.Location = new System.Drawing.Point(21, 487);
            this.grdFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdFields.Name = "grdFields";
            this.grdFields.RowHeadersVisible = false;
            this.grdFields.RowHeadersWidth = 62;
            this.grdFields.RowTemplate.Height = 28;
            this.grdFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFields.Size = new System.Drawing.Size(1356, 760);
            this.grdFields.TabIndex = 4;
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
            // entityFieldBindingSource
            // 
            this.entityFieldBindingSource.DataSource = typeof(APIManager.Data.EntityField);
            // 
            // entityFieldEditor1
            // 
            this.entityFieldEditor1.Location = new System.Drawing.Point(21, 9);
            this.entityFieldEditor1.Name = "entityFieldEditor1";
            this.entityFieldEditor1.Size = new System.Drawing.Size(1356, 470);
            this.entityFieldEditor1.TabIndex = 9;
            // 
            // CreateLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 1429);
            this.Controls.Add(this.grdFields);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.entityFieldEditor1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateLink";
            this.Load += new System.EventHandler(this.CreateLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.BindingSource entityFieldBindingSource;
        private System.Windows.Forms.DataGridView grdFields;
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
        private EntityFieldEditor entityFieldEditor1;
    }
}