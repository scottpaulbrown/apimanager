namespace APIManager.WIN {
    partial class CommitRevision {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitRevision));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCommit = new System.Windows.Forms.ToolStripButton();
            this.chkCommitToDB = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCommit,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 34);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCommit
            // 
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(104, 29);
            this.btnCommit.Text = "Commit";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // chkCommitToDB
            // 
            this.chkCommitToDB.AutoSize = true;
            this.chkCommitToDB.Checked = true;
            this.chkCommitToDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCommitToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCommitToDB.Location = new System.Drawing.Point(34, 66);
            this.chkCommitToDB.Name = "chkCommitToDB";
            this.chkCommitToDB.Size = new System.Drawing.Size(379, 29);
            this.chkCommitToDB.TabIndex = 5;
            this.chkCommitToDB.Text = "Commit Revision Changes to Database";
            this.chkCommitToDB.UseVisualStyleBackColor = true;
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
            // CommitRevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 160);
            this.Controls.Add(this.chkCommitToDB);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CommitRevision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommitRevision";
            this.Load += new System.EventHandler(this.CommitRevision_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCommit;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.CheckBox chkCommitToDB;
    }
}