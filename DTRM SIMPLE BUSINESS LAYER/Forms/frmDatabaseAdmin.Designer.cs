namespace DTRMNS {
    partial class frmDatabaseAdmin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDatabase = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.btnImportDatabase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportDatabase = new System.Windows.Forms.Button();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.expanderDatabaseList = new DronaxLibrary.Expander();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP / Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Username";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(108, 11);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(117, 20);
            this.txtServerIP.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(108, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(117, 20);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(117, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "servet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Admin Password";
            // 
            // lstDatabase
            // 
            this.lstDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstDatabase.FormattingEnabled = true;
            this.lstDatabase.ItemHeight = 18;
            this.lstDatabase.Location = new System.Drawing.Point(0, 115);
            this.lstDatabase.MinimumSize = new System.Drawing.Size(100, 4);
            this.lstDatabase.Name = "lstDatabase";
            this.lstDatabase.Size = new System.Drawing.Size(185, 363);
            this.lstDatabase.TabIndex = 9;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnClearResults);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnImportDatabase);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.btnExportDatabase);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.btnCreateDatabase);
            this.pnlTop.Controls.Add(this.txtDatabaseName);
            this.pnlTop.Controls.Add(this.btnConnect);
            this.pnlTop.Controls.Add(this.txtServerIP);
            this.pnlTop.Controls.Add(this.txtUserName);
            this.pnlTop.Controls.Add(this.txtPassword);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(665, 115);
            this.pnlTop.TabIndex = 13;
            // 
            // btnClearResults
            // 
            this.btnClearResults.Image = global::DTRMNS.Properties.Resources.Recycle_Bin;
            this.btnClearResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearResults.Location = new System.Drawing.Point(540, 55);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(102, 43);
            this.btnClearResults.TabIndex = 5;
            this.btnClearResults.Text = "CLEAR  RESULTS";
            this.btnClearResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // btnImportDatabase
            // 
            this.btnImportDatabase.Image = global::DTRMNS.Properties.Resources.FolderToDB32;
            this.btnImportDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportDatabase.Location = new System.Drawing.Point(530, 11);
            this.btnImportDatabase.Name = "btnImportDatabase";
            this.btnImportDatabase.Size = new System.Drawing.Size(112, 37);
            this.btnImportDatabase.TabIndex = 4;
            this.btnImportDatabase.Text = "IMPORT DATABASE DATA";
            this.btnImportDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportDatabase.UseVisualStyleBackColor = true;
            this.btnImportDatabase.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "New Database Name";
            // 
            // btnExportDatabase
            // 
            this.btnExportDatabase.Image = global::DTRMNS.Properties.Resources.DBToFolder32;
            this.btnExportDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportDatabase.Location = new System.Drawing.Point(249, 11);
            this.btnExportDatabase.Name = "btnExportDatabase";
            this.btnExportDatabase.Size = new System.Drawing.Size(112, 37);
            this.btnExportDatabase.TabIndex = 3;
            this.btnExportDatabase.Text = "EXPORT DATABASE DATA";
            this.btnExportDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportDatabase.UseVisualStyleBackColor = true;
            this.btnExportDatabase.Visible = false;
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Image = global::DTRMNS.Properties.Resources.Export32;
            this.btnCreateDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateDatabase.Location = new System.Drawing.Point(394, 62);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(114, 36);
            this.btnCreateDatabase.TabIndex = 0;
            this.btnCreateDatabase.Text = "CREATE DATABASE";
            this.btnCreateDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(391, 30);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(117, 20);
            this.txtDatabaseName.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::DTRMNS.Properties.Resources.DisconnectedLocal32;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(249, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 36);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(210, 115);
            this.txtResults.MinimumSize = new System.Drawing.Size(100, 4);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(455, 363);
            this.txtResults.TabIndex = 17;
            // 
            // expanderDatabaseList
            // 
            this.expanderDatabaseList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderDatabaseList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expanderDatabaseList.Caption = "";
            this.expanderDatabaseList.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expanderDatabaseList.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expanderDatabaseList.CaptionForeColor = System.Drawing.Color.White;
            this.expanderDatabaseList.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.expanderDatabaseList.ColourFixed = System.Drawing.Color.Salmon;
            this.expanderDatabaseList.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expanderDatabaseList.Dock = System.Windows.Forms.DockStyle.Left;
            this.expanderDatabaseList.ExpandableControl = this.lstDatabase;
            this.expanderDatabaseList.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expanderDatabaseList.Expanded = true;
            this.expanderDatabaseList.Fixed = false;
            this.expanderDatabaseList.Location = new System.Drawing.Point(185, 115);
            this.expanderDatabaseList.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expanderDatabaseList.LockButtonSize = new System.Drawing.Size(23, 64);
            this.expanderDatabaseList.LockButtonVisible = true;
            this.expanderDatabaseList.MinimumSize = new System.Drawing.Size(5, 5);
            this.expanderDatabaseList.Name = "expanderDatabaseList";
            this.expanderDatabaseList.Size = new System.Drawing.Size(25, 363);
            this.expanderDatabaseList.TabIndex = 14;
            // 
            // frmDatabaseAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 478);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.expanderDatabaseList);
            this.Controls.Add(this.lstDatabase);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatabaseAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Admin";
            this.Load += new System.EventHandler(this.frmDatabaseAdmin_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDatabase;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlTop;
        private DronaxLibrary.Expander expanderDatabaseList;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnImportDatabase;
        private System.Windows.Forms.Button btnExportDatabase;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabaseName;
    }
}