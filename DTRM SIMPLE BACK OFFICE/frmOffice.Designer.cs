namespace DTRMSimpleBackOffice {
    partial class frmOffice {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOffice));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.mnuObjects = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDistributions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUserEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrinters = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStockItemList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImageList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBonusList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInteractive = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStockUsage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKassaCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHouseKeeping = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSessionReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewReportSnapShot = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSessionAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImageEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewDumpTool = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConnection = new System.Windows.Forms.ToolStripLabel();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.imgTabPageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1.SuspendLayout();
            this.barMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 17);
            this.lblStatus.Text = "DISCONNECTED";
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.btnDisconnect,
            this.mnuObjects,
            this.mnuInteractive,
            this.mnuHouseKeeping,
            this.lblConnection,
            this.btnSettings});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(958, 54);
            this.barMain.TabIndex = 10;
            this.barMain.Text = "toolStrip1";
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::DTRMSimpleBackOffice.Properties.Resources.DisconnectedLocal32;
            this.btnConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 51);
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Image = global::DTRMSimpleBackOffice.Properties.Resources.ConnectedLocal32;
            this.btnDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(70, 51);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // mnuObjects
            // 
            this.mnuObjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu,
            this.btnDistributions,
            this.btnUserEditor,
            this.btnPrinters,
            this.btnSuppliers,
            this.btnStockItemList,
            this.btnImageList,
            this.btnBonusList,
            this.btnEmployees});
            this.mnuObjects.Image = global::DTRMSimpleBackOffice.Properties.Resources.multidisli32;
            this.mnuObjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuObjects.Name = "mnuObjects";
            this.mnuObjects.Size = new System.Drawing.Size(60, 51);
            this.mnuObjects.Text = "Objects";
            this.mnuObjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnMenu
            // 
            this.btnMenu.Enabled = false;
            this.btnMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.OpenTreeView;
            this.btnMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(157, 38);
            this.btnMenu.Text = "Menus";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDistributions
            // 
            this.btnDistributions.Enabled = false;
            this.btnDistributions.Image = global::DTRMSimpleBackOffice.Properties.Resources.Split32Right;
            this.btnDistributions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDistributions.Name = "btnDistributions";
            this.btnDistributions.Size = new System.Drawing.Size(157, 38);
            this.btnDistributions.Text = "Distributions";
            this.btnDistributions.Click += new System.EventHandler(this.btnDistributions_Click);
            // 
            // btnUserEditor
            // 
            this.btnUserEditor.Enabled = false;
            this.btnUserEditor.Image = global::DTRMSimpleBackOffice.Properties.Resources.Customers32;
            this.btnUserEditor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUserEditor.Name = "btnUserEditor";
            this.btnUserEditor.Size = new System.Drawing.Size(157, 38);
            this.btnUserEditor.Text = "Users";
            this.btnUserEditor.Click += new System.EventHandler(this.btnUserEditor_Click);
            // 
            // btnPrinters
            // 
            this.btnPrinters.Enabled = false;
            this.btnPrinters.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnPrinters.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.Size = new System.Drawing.Size(157, 38);
            this.btnPrinters.Text = "Printers";
            this.btnPrinters.Click += new System.EventHandler(this.btnPrinters_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Enabled = false;
            this.btnSuppliers.Image = global::DTRMSimpleBackOffice.Properties.Resources.MultiPeople2;
            this.btnSuppliers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(157, 38);
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnStockItemList
            // 
            this.btnStockItemList.Enabled = false;
            this.btnStockItemList.Image = global::DTRMSimpleBackOffice.Properties.Resources.DataSync32;
            this.btnStockItemList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStockItemList.Name = "btnStockItemList";
            this.btnStockItemList.Size = new System.Drawing.Size(157, 38);
            this.btnStockItemList.Text = "Stock";
            this.btnStockItemList.Click += new System.EventHandler(this.btnStockItemList_Click);
            // 
            // btnImageList
            // 
            this.btnImageList.Enabled = false;
            this.btnImageList.Image = global::DTRMSimpleBackOffice.Properties.Resources.Brush;
            this.btnImageList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImageList.Name = "btnImageList";
            this.btnImageList.Size = new System.Drawing.Size(157, 38);
            this.btnImageList.Text = "Images";
            this.btnImageList.Click += new System.EventHandler(this.btnImageList_Click);
            // 
            // btnBonusList
            // 
            this.btnBonusList.Enabled = false;
            this.btnBonusList.Image = global::DTRMSimpleBackOffice.Properties.Resources.Bonus32;
            this.btnBonusList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBonusList.Name = "btnBonusList";
            this.btnBonusList.Size = new System.Drawing.Size(157, 38);
            this.btnBonusList.Text = "Bonus Plans";
            this.btnBonusList.Click += new System.EventHandler(this.btnBonusList_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Enabled = false;
            this.btnEmployees.Image = global::DTRMSimpleBackOffice.Properties.Resources.BlueMan32;
            this.btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(157, 38);
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // mnuInteractive
            // 
            this.mnuInteractive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDisplay,
            this.btnStockUsage,
            this.btnKassaCalculator});
            this.mnuInteractive.Image = global::DTRMSimpleBackOffice.Properties.Resources.RefreshGreen;
            this.mnuInteractive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuInteractive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuInteractive.Name = "mnuInteractive";
            this.mnuInteractive.Size = new System.Drawing.Size(75, 51);
            this.mnuInteractive.Text = "Interactive";
            this.mnuInteractive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Image = global::DTRMSimpleBackOffice.Properties.Resources.eye32;
            this.btnDisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(176, 38);
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnStockUsage
            // 
            this.btnStockUsage.Enabled = false;
            this.btnStockUsage.Image = global::DTRMSimpleBackOffice.Properties.Resources.Present32;
            this.btnStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStockUsage.Name = "btnStockUsage";
            this.btnStockUsage.Size = new System.Drawing.Size(176, 38);
            this.btnStockUsage.Text = "Shopping List";
            this.btnStockUsage.Click += new System.EventHandler(this.btnStockUsage_Click);
            // 
            // btnKassaCalculator
            // 
            this.btnKassaCalculator.Enabled = false;
            this.btnKassaCalculator.Image = global::DTRMSimpleBackOffice.Properties.Resources.CalculatorNice32;
            this.btnKassaCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKassaCalculator.Name = "btnKassaCalculator";
            this.btnKassaCalculator.Size = new System.Drawing.Size(176, 38);
            this.btnKassaCalculator.Text = "Kassa Calculator";
            this.btnKassaCalculator.Click += new System.EventHandler(this.btnKassaCalculator_Click);
            // 
            // mnuHouseKeeping
            // 
            this.mnuHouseKeeping.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSessionReports,
            this.btnViewReportSnapShot,
            this.btnSessionAnalysis,
            this.btnImageEditor,
            this.mnuViewDumpTool});
            this.mnuHouseKeeping.Image = global::DTRMSimpleBackOffice.Properties.Resources.Glasses32;
            this.mnuHouseKeeping.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuHouseKeeping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHouseKeeping.Name = "mnuHouseKeeping";
            this.mnuHouseKeeping.Size = new System.Drawing.Size(100, 51);
            this.mnuHouseKeeping.Text = "House Keeping";
            this.mnuHouseKeeping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSessionReports
            // 
            this.btnSessionReports.Enabled = false;
            this.btnSessionReports.Image = global::DTRMSimpleBackOffice.Properties.Resources.Graph;
            this.btnSessionReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionReports.Name = "btnSessionReports";
            this.btnSessionReports.Size = new System.Drawing.Size(209, 38);
            this.btnSessionReports.Text = "Session Reports";
            this.btnSessionReports.Click += new System.EventHandler(this.btnSessionReports_Click);
            // 
            // btnViewReportSnapShot
            // 
            this.btnViewReportSnapShot.Image = global::DTRMSimpleBackOffice.Properties.Resources.Glasses32;
            this.btnViewReportSnapShot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViewReportSnapShot.Name = "btnViewReportSnapShot";
            this.btnViewReportSnapShot.Size = new System.Drawing.Size(209, 38);
            this.btnViewReportSnapShot.Text = "View Report Snap Shot";
            this.btnViewReportSnapShot.Visible = false;
            this.btnViewReportSnapShot.Click += new System.EventHandler(this.btnViewReportSnapShot_Click);
            // 
            // btnSessionAnalysis
            // 
            this.btnSessionAnalysis.Enabled = false;
            this.btnSessionAnalysis.Image = global::DTRMSimpleBackOffice.Properties.Resources.Document_Chart;
            this.btnSessionAnalysis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionAnalysis.Name = "btnSessionAnalysis";
            this.btnSessionAnalysis.Size = new System.Drawing.Size(209, 38);
            this.btnSessionAnalysis.Text = "Session Analysis";
            this.btnSessionAnalysis.Click += new System.EventHandler(this.btnSessionAnalysis_Click);
            // 
            // btnImageEditor
            // 
            this.btnImageEditor.Image = global::DTRMSimpleBackOffice.Properties.Resources.Wizard;
            this.btnImageEditor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImageEditor.Name = "btnImageEditor";
            this.btnImageEditor.Size = new System.Drawing.Size(209, 38);
            this.btnImageEditor.Text = "Image Editor";
            this.btnImageEditor.Click += new System.EventHandler(this.btnImageEditor_Click);
            // 
            // mnuViewDumpTool
            // 
            this.mnuViewDumpTool.Image = global::DTRMSimpleBackOffice.Properties.Resources.Rubbish_32;
            this.mnuViewDumpTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuViewDumpTool.Name = "mnuViewDumpTool";
            this.mnuViewDumpTool.Size = new System.Drawing.Size(209, 38);
            this.mnuViewDumpTool.Text = "View Dump";
            this.mnuViewDumpTool.Click += new System.EventHandler(this.mnuViewDumpTool_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(0, 51);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.AutoSize = false;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::DTRMSimpleBackOffice.Properties.Resources.disli32;
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 51);
            this.btnSettings.Text = "toolStripButton1";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tabForms
            // 
            this.tabForms.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.ImageList = this.imgTabPageList;
            this.tabForms.ItemSize = new System.Drawing.Size(60, 25);
            this.tabForms.Location = new System.Drawing.Point(0, 54);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(958, 25);
            this.tabForms.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabForms.TabIndex = 12;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            this.tabForms.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabForms_ControlAdded);
            this.tabForms.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabForms_ControlRemoved);
            this.tabForms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabForms_MouseClick);
            // 
            // imgTabPageList
            // 
            this.imgTabPageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTabPageList.ImageStream")));
            this.imgTabPageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTabPageList.Images.SetKeyName(0, "Cancel.png");
            // 
            // frmOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(958, 556);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTRM SIMPLE BACK OFFICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmOffice_MdiChildActivate);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripButton btnDisconnect;
        private System.Windows.Forms.ToolStripDropDownButton mnuObjects;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnDistributions;
        private System.Windows.Forms.ToolStripMenuItem btnUserEditor;
        private System.Windows.Forms.ToolStripMenuItem btnPrinters;
        private System.Windows.Forms.ToolStripMenuItem btnSuppliers;
        private System.Windows.Forms.ToolStripMenuItem btnStockItemList;
        private System.Windows.Forms.ToolStripMenuItem btnImageList;
        private System.Windows.Forms.ToolStripMenuItem btnBonusList;
        private System.Windows.Forms.ToolStripDropDownButton mnuInteractive;
        private System.Windows.Forms.ToolStripDropDownButton mnuHouseKeeping;
        private System.Windows.Forms.ToolStripMenuItem btnDisplay;
        private System.Windows.Forms.ToolStripMenuItem btnStockUsage;
        private System.Windows.Forms.ToolStripMenuItem btnSessionReports;
        private System.Windows.Forms.ToolStripMenuItem btnViewReportSnapShot;
        private System.Windows.Forms.ToolStripMenuItem btnSessionAnalysis;
        private System.Windows.Forms.ToolStripMenuItem btnImageEditor;
        private System.Windows.Forms.ToolStripLabel lblConnection;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ImageList imgTabPageList;
        private System.Windows.Forms.ToolStripMenuItem btnEmployees;
        private System.Windows.Forms.ToolStripMenuItem btnKassaCalculator;
        private System.Windows.Forms.ToolStripMenuItem mnuViewDumpTool;
        private System.Windows.Forms.ToolStripButton btnSettings;
    }
}