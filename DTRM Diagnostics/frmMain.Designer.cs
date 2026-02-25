namespace DTRMNS {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.wb = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnectDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDronaxWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDownloadDotNet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDownloadLocalDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDownloadSQLExpress = new System.Windows.Forms.ToolStripMenuItem();
            this.printDirect = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            resources.ApplyResources(this.wb, "wb");
            this.wb.IsWebBrowserContextMenuEnabled = false;
            this.wb.Name = "wb";
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Name = "panel2";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.printDirect});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadDetails,
            this.mnuConnectDatabase,
            this.mnuDisplayConfiguration,
            this.toolStripMenuItem1,
            this.mnuDronaxWebsite,
            this.btnPrint});
            this.fileToolStripMenuItem.Image = global::DTRM_Diagnostics.Properties.Resources.Gear;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // mnuLoadDetails
            // 
            resources.ApplyResources(this.mnuLoadDetails, "mnuLoadDetails");
            this.mnuLoadDetails.Image = global::DTRM_Diagnostics.Properties.Resources.Refresh_2;
            this.mnuLoadDetails.Name = "mnuLoadDetails";
            this.mnuLoadDetails.Click += new System.EventHandler(this.mnuLoadDetails_Click);
            // 
            // mnuConnectDatabase
            // 
            resources.ApplyResources(this.mnuConnectDatabase, "mnuConnectDatabase");
            this.mnuConnectDatabase.Image = global::DTRM_Diagnostics.Properties.Resources.DataSync32;
            this.mnuConnectDatabase.Name = "mnuConnectDatabase";
            this.mnuConnectDatabase.Click += new System.EventHandler(this.mnuConnectDatabase_Click);
            // 
            // mnuDisplayConfiguration
            // 
            resources.ApplyResources(this.mnuDisplayConfiguration, "mnuDisplayConfiguration");
            this.mnuDisplayConfiguration.Image = global::DTRM_Diagnostics.Properties.Resources.Gear;
            this.mnuDisplayConfiguration.Name = "mnuDisplayConfiguration";
            this.mnuDisplayConfiguration.Click += new System.EventHandler(this.mnuDisplayConfiguration_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // mnuDronaxWebsite
            // 
            resources.ApplyResources(this.mnuDronaxWebsite, "mnuDronaxWebsite");
            this.mnuDronaxWebsite.Image = global::DTRM_Diagnostics.Properties.Resources.Earth32;
            this.mnuDronaxWebsite.Name = "mnuDronaxWebsite";
            this.mnuDronaxWebsite.Click += new System.EventHandler(this.mnuDronaxWebsite_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Image = global::DTRM_Diagnostics.Properties.Resources.Print32;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // downloadToolStripMenuItem
            // 
            resources.ApplyResources(this.downloadToolStripMenuItem, "downloadToolStripMenuItem");
            this.downloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDownloadDotNet,
            this.mnuDownloadLocalDB,
            this.mnuDownloadSQLExpress});
            this.downloadToolStripMenuItem.Image = global::DTRM_Diagnostics.Properties.Resources.Download32;
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            // 
            // mnuDownloadDotNet
            // 
            resources.ApplyResources(this.mnuDownloadDotNet, "mnuDownloadDotNet");
            this.mnuDownloadDotNet.Image = global::DTRM_Diagnostics.Properties.Resources.Download32;
            this.mnuDownloadDotNet.Name = "mnuDownloadDotNet";
            this.mnuDownloadDotNet.Click += new System.EventHandler(this.mnuDownloadDotNet_Click);
            // 
            // mnuDownloadLocalDB
            // 
            resources.ApplyResources(this.mnuDownloadLocalDB, "mnuDownloadLocalDB");
            this.mnuDownloadLocalDB.Image = global::DTRM_Diagnostics.Properties.Resources.Download32;
            this.mnuDownloadLocalDB.Name = "mnuDownloadLocalDB";
            this.mnuDownloadLocalDB.Click += new System.EventHandler(this.mnuDownloadLocalDB_Click);
            // 
            // mnuDownloadSQLExpress
            // 
            resources.ApplyResources(this.mnuDownloadSQLExpress, "mnuDownloadSQLExpress");
            this.mnuDownloadSQLExpress.Image = global::DTRM_Diagnostics.Properties.Resources.Download32;
            this.mnuDownloadSQLExpress.Name = "mnuDownloadSQLExpress";
            this.mnuDownloadSQLExpress.Click += new System.EventHandler(this.mnuDownloadSQLExpress_Click);
            // 
            // printDirect
            // 
            resources.ApplyResources(this.printDirect, "printDirect");
            this.printDirect.Image = global::DTRM_Diagnostics.Properties.Resources.Print32;
            this.printDirect.Name = "printDirect";
            this.printDirect.Click += new System.EventHandler(this.printDirect_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.wb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuConnectDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayConfiguration;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDronaxWebsite;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDownloadDotNet;
        private System.Windows.Forms.ToolStripMenuItem mnuDownloadLocalDB;
        private System.Windows.Forms.ToolStripMenuItem mnuDownloadSQLExpress;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem printDirect;
    }
}

