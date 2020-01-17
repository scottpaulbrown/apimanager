namespace APIManager.WIN {
    partial class ChooseEntityAttributes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseEntityAttributes));
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.entityAttributeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityAttributeTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityAttributeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToAddRows = false;
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMain.AutoGenerateColumns = false;
            this.grdMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn,
            this.entityAttributeTypeNameDataGridViewTextBoxColumn});
            this.grdMain.DataSource = this.entityAttributeTypeBindingSource;
            this.grdMain.Location = new System.Drawing.Point(12, 60);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.RowHeadersWidth = 62;
            this.grdMain.RowTemplate.Height = 28;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(778, 877);
            this.grdMain.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 34);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // entityAttributeTypeBindingSource
            // 
            this.entityAttributeTypeBindingSource.DataSource = typeof(APIManager.Data.EntityAttributeType);
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
            // entityAttributeTypeCodeDataGridViewTextBoxColumn
            // 
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "EntityAttributeTypeCode";
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.FillWeight = 30F;
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.HeaderText = "EntityAttributeTypeCode";
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.Name = "entityAttributeTypeCodeDataGridViewTextBoxColumn";
            this.entityAttributeTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entityAttributeTypeNameDataGridViewTextBoxColumn
            // 
            this.entityAttributeTypeNameDataGridViewTextBoxColumn.DataPropertyName = "EntityAttributeTypeName";
            this.entityAttributeTypeNameDataGridViewTextBoxColumn.FillWeight = 60F;
            this.entityAttributeTypeNameDataGridViewTextBoxColumn.HeaderText = "EntityAttributeTypeName";
            this.entityAttributeTypeNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.entityAttributeTypeNameDataGridViewTextBoxColumn.Name = "entityAttributeTypeNameDataGridViewTextBoxColumn";
            this.entityAttributeTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChooseEntityAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 949);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseEntityAttributes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseEntityAttributes";
            this.Load += new System.EventHandler(this.ChooseEntityAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityAttributeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource entityAttributeTypeBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityAttributeTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityAttributeTypeNameDataGridViewTextBoxColumn;
    }
}