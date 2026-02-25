namespace DTRMAdaptorFileCopier {
    partial class frmDeleteFiles {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteFiles));
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(32, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(441, 46);
            this.lblStatus.TabIndex = 1;
            // 
            // btnCleaning
            // 
            this.btnCleaning.Location = new System.Drawing.Point(32, 87);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(441, 41);
            this.btnCleaning.TabIndex = 2;
            this.btnCleaning.Text = "START  CLEANING  AND  CLOSE APPLICATION";
            this.btnCleaning.UseVisualStyleBackColor = true;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // frmDeleteFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btnCleaning);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteFiles";
            this.Text = "CLEANING  PROCEDURE";
            this.Load += new System.EventHandler(this.frmDeleteFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCleaning;
    }
}