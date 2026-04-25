namespace WinLayer.Forms {
    partial class frmProgress {
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
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.chkCloseWhenFinished = new System.Windows.Forms.CheckBox();
            this.btnMoreDetails = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(80, 43);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(522, 29);
            this.pBar.Step = 2;
            this.pBar.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(483, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(80, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(521, 30);
            this.lblMessage.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(80, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(521, 18);
            this.lblStatus.TabIndex = 8;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(10, 166);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(591, 250);
            this.txtDetails.TabIndex = 11;
            this.txtDetails.Text = "";
            this.txtDetails.WordWrap = false;
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Location = new System.Drawing.Point(483, 422);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(119, 32);
            this.btnSaveOutput.TabIndex = 12;
            this.btnSaveOutput.Text = "SAVE DETAILS AS ";
            this.btnSaveOutput.Visible = false;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // chkCloseWhenFinished
            // 
            this.chkCloseWhenFinished.AutoSize = true;
            this.chkCloseWhenFinished.Location = new System.Drawing.Point(12, 112);
            this.chkCloseWhenFinished.Name = "chkCloseWhenFinished";
            this.chkCloseWhenFinished.Size = new System.Drawing.Size(135, 17);
            this.chkCloseWhenFinished.TabIndex = 13;
            this.chkCloseWhenFinished.Text = "Close When Finished";
            this.chkCloseWhenFinished.UseVisualStyleBackColor = true;
            this.chkCloseWhenFinished.CheckedChanged += new System.EventHandler(this.chkCloseWhenFinished_CheckedChanged);
            // 
            // btnMoreDetails
            // 
            this.btnMoreDetails.Location = new System.Drawing.Point(168, 103);
            this.btnMoreDetails.Name = "btnMoreDetails";
            this.btnMoreDetails.Size = new System.Drawing.Size(103, 31);
            this.btnMoreDetails.TabIndex = 14;
            this.btnMoreDetails.Text = "MORE DETAILS";
            this.btnMoreDetails.UseVisualStyleBackColor = true;
            this.btnMoreDetails.Click += new System.EventHandler(this.btnMoreDetails_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::WinLayer.Properties.Resources.disli48;
            this.picImage.InitialImage = global::WinLayer.Properties.Resources.disli48;
            this.picImage.Location = new System.Drawing.Point(10, 13);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(64, 64);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 15;
            this.picImage.TabStop = false;
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 477);
            this.ControlBox = false;
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnMoreDetails);
            this.Controls.Add(this.chkCloseWhenFinished);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProgress";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "   Please Wait";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.CheckBox chkCloseWhenFinished;
        private System.Windows.Forms.Button btnMoreDetails;
        private System.Windows.Forms.PictureBox picImage;
    }
}