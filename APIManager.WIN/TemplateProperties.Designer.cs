namespace APIManager.WIN {
    partial class TemplateProperties {
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
            this.grdVariables = new System.Windows.Forms.DataGridView();
            this.fileVariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileVariableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVariables
            // 
            this.grdVariables.AllowUserToAddRows = false;
            this.grdVariables.AllowUserToDeleteRows = false;
            this.grdVariables.AutoGenerateColumns = false;
            this.grdVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.grdVariables.DataSource = this.fileVariableBindingSource;
            this.grdVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVariables.Location = new System.Drawing.Point(0, 0);
            this.grdVariables.Name = "grdVariables";
            this.grdVariables.RowHeadersVisible = false;
            this.grdVariables.RowHeadersWidth = 62;
            this.grdVariables.RowTemplate.Height = 28;
            this.grdVariables.Size = new System.Drawing.Size(1272, 1510);
            this.grdVariables.TabIndex = 0;
            // 
            // fileVariableBindingSource
            // 
            this.fileVariableBindingSource.DataSource = typeof(APIManager.Logic.FileVariable);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 250;
            // 
            // TemplateProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdVariables);
            this.Name = "TemplateProperties";
            this.Size = new System.Drawing.Size(1272, 1510);
            this.Load += new System.EventHandler(this.TemplateProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileVariableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVariables;
        private System.Windows.Forms.BindingSource fileVariableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}
