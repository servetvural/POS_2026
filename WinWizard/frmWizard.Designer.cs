namespace WinWizard {
    partial class frmWizard {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizard));
            pBar = new System.Windows.Forms.ProgressBar();
            btnCopyFiles = new System.Windows.Forms.Button();
            brnLocateDirectory = new System.Windows.Forms.Button();
            lblProgramDirectory = new System.Windows.Forms.Label();
            btnCopyFileToProgramFolder = new System.Windows.Forms.Button();
            btnClearFilesFromProgramFolder = new System.Windows.Forms.Button();
            btnStartApplication = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            lblBackupLocation = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // pBar
            // 
            pBar.Location = new System.Drawing.Point(12, 385);
            pBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pBar.Name = "pBar";
            pBar.Size = new System.Drawing.Size(203, 31);
            pBar.TabIndex = 1;
            pBar.Visible = false;
            // 
            // btnCopyFiles
            // 
            btnCopyFiles.Image = Properties.Resources.Gears;
            btnCopyFiles.Location = new System.Drawing.Point(12, 297);
            btnCopyFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCopyFiles.Name = "btnCopyFiles";
            btnCopyFiles.Size = new System.Drawing.Size(203, 70);
            btnCopyFiles.TabIndex = 0;
            btnCopyFiles.Text = "START PROCESS\r\n";
            btnCopyFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCopyFiles.UseVisualStyleBackColor = true;
            btnCopyFiles.Visible = false;
            btnCopyFiles.Click += btnCopyFiles_Click;
            // 
            // brnLocateDirectory
            // 
            brnLocateDirectory.Location = new System.Drawing.Point(234, 366);
            brnLocateDirectory.Name = "brnLocateDirectory";
            brnLocateDirectory.Size = new System.Drawing.Size(200, 50);
            brnLocateDirectory.TabIndex = 2;
            brnLocateDirectory.Text = "LOCATE PROGRAM DIRECTORY";
            brnLocateDirectory.UseVisualStyleBackColor = true;
            brnLocateDirectory.Click += brnLocateDirectory_Click;
            // 
            // lblProgramDirectory
            // 
            lblProgramDirectory.AutoSize = true;
            lblProgramDirectory.Location = new System.Drawing.Point(16, 9);
            lblProgramDirectory.Name = "lblProgramDirectory";
            lblProgramDirectory.Size = new System.Drawing.Size(104, 15);
            lblProgramDirectory.TabIndex = 3;
            lblProgramDirectory.Text = "Program Directory";
            // 
            // btnCopyFileToProgramFolder
            // 
            btnCopyFileToProgramFolder.Location = new System.Drawing.Point(12, 53);
            btnCopyFileToProgramFolder.Name = "btnCopyFileToProgramFolder";
            btnCopyFileToProgramFolder.Size = new System.Drawing.Size(150, 50);
            btnCopyFileToProgramFolder.TabIndex = 7;
            btnCopyFileToProgramFolder.Text = "COPY FILES";
            btnCopyFileToProgramFolder.UseVisualStyleBackColor = true;
            btnCopyFileToProgramFolder.Click += btnCopyFileToProgramFolder_Click;
            // 
            // btnClearFilesFromProgramFolder
            // 
            btnClearFilesFromProgramFolder.Location = new System.Drawing.Point(12, 109);
            btnClearFilesFromProgramFolder.Name = "btnClearFilesFromProgramFolder";
            btnClearFilesFromProgramFolder.Size = new System.Drawing.Size(150, 50);
            btnClearFilesFromProgramFolder.TabIndex = 8;
            btnClearFilesFromProgramFolder.Text = "CLEAR FILES";
            btnClearFilesFromProgramFolder.UseVisualStyleBackColor = true;
            btnClearFilesFromProgramFolder.Click += btnClearFilesFromProgramFolder_Click;
            // 
            // btnStartApplication
            // 
            btnStartApplication.Location = new System.Drawing.Point(181, 53);
            btnStartApplication.Name = "btnStartApplication";
            btnStartApplication.Size = new System.Drawing.Size(150, 50);
            btnStartApplication.TabIndex = 9;
            btnStartApplication.Text = "START APPLICATION";
            btnStartApplication.UseVisualStyleBackColor = true;
            btnStartApplication.Click += btnStartApplication_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(181, 109);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(150, 50);
            btnClose.TabIndex = 11;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblBackupLocation
            // 
            lblBackupLocation.AutoSize = true;
            lblBackupLocation.Location = new System.Drawing.Point(17, 30);
            lblBackupLocation.Name = "lblBackupLocation";
            lblBackupLocation.Size = new System.Drawing.Size(97, 15);
            lblBackupLocation.TabIndex = 12;
            lblBackupLocation.Text = "Backup Directory";
            // 
            // frmWizard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(346, 176);
            ControlBox = false;
            Controls.Add(lblBackupLocation);
            Controls.Add(btnClose);
            Controls.Add(btnStartApplication);
            Controls.Add(btnClearFilesFromProgramFolder);
            Controls.Add(btnCopyFileToProgramFolder);
            Controls.Add(lblProgramDirectory);
            Controls.Add(brnLocateDirectory);
            Controls.Add(pBar);
            Controls.Add(btnCopyFiles);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmWizard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "WIZARD";
            TopMost = true;
            FormClosing += frmProcess_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button brnLocateDirectory;
        private System.Windows.Forms.Label lblProgramDirectory;
        private System.Windows.Forms.Button btnCopyFileToProgramFolder;
        private System.Windows.Forms.Button btnClearFilesFromProgramFolder;
        private System.Windows.Forms.Button btnStartApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBackupLocation;
    }
}

