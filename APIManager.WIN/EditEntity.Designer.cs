namespace APIManager.WIN {
    partial class EditEntity {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdFields = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaxLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsIdentity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDTOField = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSearchFieldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContainsSearchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entityFieldInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2428, 109);
            this.panel1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(116, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(2286, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grdFields
            // 
            this.grdFields.AutoGenerateColumns = false;
            this.grdFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.dataTypeDataGridViewTextBoxColumn,
            this.MaxLength,
            this.Scale,
            this.IsKey,
            this.IsIdentity,
            this.IsRequired,
            this.IsDTOField,
            this.isSearchFieldDataGridViewCheckBoxColumn,
            this.isContainsSearchDataGridViewCheckBoxColumn});
            this.grdFields.DataSource = this.entityFieldInfoBindingSource;
            this.grdFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFields.Location = new System.Drawing.Point(0, 109);
            this.grdFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdFields.Name = "grdFields";
            this.grdFields.RowHeadersWidth = 62;
            this.grdFields.RowTemplate.Height = 28;
            this.grdFields.Size = new System.Drawing.Size(2428, 1318);
            this.grdFields.TabIndex = 2;
            this.grdFields.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFields_CellEndEdit);
            this.grdFields.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdFields_DefaultValuesNeeded);
            this.grdFields.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFields_RowLeave);
            // 
            // FieldName
            // 
            this.FieldName.DataPropertyName = "FieldName";
            this.FieldName.HeaderText = "Name";
            this.FieldName.MinimumWidth = 8;
            this.FieldName.Name = "FieldName";
            this.FieldName.Width = 250;
            // 
            // dataTypeDataGridViewTextBoxColumn
            // 
            this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.HeaderText = "Data Type";
            this.dataTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
            this.dataTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // MaxLength
            // 
            this.MaxLength.DataPropertyName = "MaxLength";
            this.MaxLength.HeaderText = "Max Length";
            this.MaxLength.MinimumWidth = 8;
            this.MaxLength.Name = "MaxLength";
            this.MaxLength.Width = 150;
            // 
            // Scale
            // 
            this.Scale.DataPropertyName = "Scale";
            this.Scale.HeaderText = "Scale";
            this.Scale.MinimumWidth = 8;
            this.Scale.Name = "Scale";
            this.Scale.Width = 150;
            // 
            // IsKey
            // 
            this.IsKey.DataPropertyName = "IsKey";
            this.IsKey.HeaderText = "Key";
            this.IsKey.MinimumWidth = 8;
            this.IsKey.Name = "IsKey";
            this.IsKey.Width = 150;
            // 
            // IsIdentity
            // 
            this.IsIdentity.DataPropertyName = "IsIdentity";
            this.IsIdentity.HeaderText = "Identity";
            this.IsIdentity.MinimumWidth = 8;
            this.IsIdentity.Name = "IsIdentity";
            this.IsIdentity.Width = 150;
            // 
            // IsRequired
            // 
            this.IsRequired.DataPropertyName = "IsRequired";
            this.IsRequired.HeaderText = "Required";
            this.IsRequired.MinimumWidth = 8;
            this.IsRequired.Name = "IsRequired";
            this.IsRequired.Width = 150;
            // 
            // IsDTOField
            // 
            this.IsDTOField.DataPropertyName = "IsDTOField";
            this.IsDTOField.HeaderText = "DTO Field";
            this.IsDTOField.MinimumWidth = 8;
            this.IsDTOField.Name = "IsDTOField";
            this.IsDTOField.Width = 150;
            // 
            // isSearchFieldDataGridViewCheckBoxColumn
            // 
            this.isSearchFieldDataGridViewCheckBoxColumn.DataPropertyName = "IsSearchField";
            this.isSearchFieldDataGridViewCheckBoxColumn.HeaderText = "Search Field";
            this.isSearchFieldDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isSearchFieldDataGridViewCheckBoxColumn.Name = "isSearchFieldDataGridViewCheckBoxColumn";
            this.isSearchFieldDataGridViewCheckBoxColumn.Width = 150;
            // 
            // isContainsSearchDataGridViewCheckBoxColumn
            // 
            this.isContainsSearchDataGridViewCheckBoxColumn.DataPropertyName = "IsContainsSearch";
            this.isContainsSearchDataGridViewCheckBoxColumn.HeaderText = "Contains Search";
            this.isContainsSearchDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isContainsSearchDataGridViewCheckBoxColumn.Name = "isContainsSearchDataGridViewCheckBoxColumn";
            this.isContainsSearchDataGridViewCheckBoxColumn.Width = 150;
            // 
            // entityFieldInfoBindingSource
            // 
            this.entityFieldInfoBindingSource.DataSource = typeof(APIManager.Logic.EntityFieldInfo);
            // 
            // EditEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdFields);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditEntity";
            this.Size = new System.Drawing.Size(2428, 1427);
            this.Load += new System.EventHandler(this.EditEntity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityFieldInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource entityFieldInfoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsIdentity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRequired;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDTOField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSearchFieldDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContainsSearchDataGridViewCheckBoxColumn;
    }
}
