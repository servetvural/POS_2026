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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOffice));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            barMain = new System.Windows.Forms.ToolStrip();
            btnConnect = new System.Windows.Forms.ToolStripButton();
            btnDisconnect = new System.Windows.Forms.ToolStripButton();
            mnuObjects = new System.Windows.Forms.ToolStripDropDownButton();
            btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            btnDistributions = new System.Windows.Forms.ToolStripMenuItem();
            btnUserEditor = new System.Windows.Forms.ToolStripMenuItem();
            btnPrinters = new System.Windows.Forms.ToolStripMenuItem();
            btnSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            btnStockItemList = new System.Windows.Forms.ToolStripMenuItem();
            btnImageList = new System.Windows.Forms.ToolStripMenuItem();
            btnBonusList = new System.Windows.Forms.ToolStripMenuItem();
            btnEmployees = new System.Windows.Forms.ToolStripMenuItem();
            mnuInteractive = new System.Windows.Forms.ToolStripDropDownButton();
            btnDisplay = new System.Windows.Forms.ToolStripMenuItem();
            btnStockUsage = new System.Windows.Forms.ToolStripMenuItem();
            btnKassaCalculator = new System.Windows.Forms.ToolStripMenuItem();
            btnSettings = new System.Windows.Forms.ToolStripButton();
            btnQuickReports = new System.Windows.Forms.ToolStripButton();
            btnOrderPad = new System.Windows.Forms.ToolStripButton();
            btnViewDump = new System.Windows.Forms.ToolStripButton();
            btnReports = new System.Windows.Forms.ToolStripButton();
            btnSessionAnalysis = new System.Windows.Forms.ToolStripButton();
            btnCloseAllWindows = new System.Windows.Forms.ToolStripButton();
            btnCloseApplication = new System.Windows.Forms.ToolStripButton();
            tabForms = new System.Windows.Forms.TabControl();
            imgTabPageList = new System.Windows.Forms.ImageList(components);
            statusStrip1.SuspendLayout();
            barMain.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatus });
            statusStrip1.Location = new System.Drawing.Point(0, 534);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1032, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(94, 17);
            lblStatus.Text = "DISCONNECTED";
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnConnect, btnDisconnect, mnuObjects, mnuInteractive, btnSettings, btnQuickReports, btnOrderPad, btnViewDump, btnReports, btnSessionAnalysis, btnCloseAllWindows, btnCloseApplication });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(1032, 54);
            barMain.TabIndex = 10;
            barMain.Text = "toolStrip1";
            // 
            // btnConnect
            // 
            btnConnect.AutoSize = false;
            btnConnect.Image = Properties.Resources.DisconnectedLocal32;
            btnConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(80, 51);
            btnConnect.Text = "Connect";
            btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.AutoSize = false;
            btnDisconnect.Image = Properties.Resources.ConnectedLocal32;
            btnDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(80, 51);
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDisconnect.Visible = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // mnuObjects
            // 
            mnuObjects.AutoSize = false;
            mnuObjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnMenu, btnDistributions, btnUserEditor, btnPrinters, btnSuppliers, btnStockItemList, btnImageList, btnBonusList, btnEmployees });
            mnuObjects.Image = Properties.Resources.multidisli32;
            mnuObjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            mnuObjects.Name = "mnuObjects";
            mnuObjects.Size = new System.Drawing.Size(80, 51);
            mnuObjects.Text = "Objects";
            mnuObjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnMenu
            // 
            btnMenu.Enabled = false;
            btnMenu.Image = Properties.Resources.OpenTreeView;
            btnMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(157, 38);
            btnMenu.Text = "Menus";
            btnMenu.Click += btnMenu_Click;
            // 
            // btnDistributions
            // 
            btnDistributions.Enabled = false;
            btnDistributions.Image = Properties.Resources.Split32Right;
            btnDistributions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDistributions.Name = "btnDistributions";
            btnDistributions.Size = new System.Drawing.Size(157, 38);
            btnDistributions.Text = "Distributions";
            btnDistributions.Click += btnDistributions_Click;
            // 
            // btnUserEditor
            // 
            btnUserEditor.Enabled = false;
            btnUserEditor.Image = Properties.Resources.Customers32;
            btnUserEditor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnUserEditor.Name = "btnUserEditor";
            btnUserEditor.Size = new System.Drawing.Size(157, 38);
            btnUserEditor.Text = "Users";
            btnUserEditor.Click += btnUserEditor_Click;
            // 
            // btnPrinters
            // 
            btnPrinters.Enabled = false;
            btnPrinters.Image = Properties.Resources.Printer32;
            btnPrinters.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPrinters.Name = "btnPrinters";
            btnPrinters.Size = new System.Drawing.Size(157, 38);
            btnPrinters.Text = "Printers";
            btnPrinters.Click += btnPrinters_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Enabled = false;
            btnSuppliers.Image = Properties.Resources.MultiPeople2;
            btnSuppliers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new System.Drawing.Size(157, 38);
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnStockItemList
            // 
            btnStockItemList.Enabled = false;
            btnStockItemList.Image = Properties.Resources.DataSync32;
            btnStockItemList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnStockItemList.Name = "btnStockItemList";
            btnStockItemList.Size = new System.Drawing.Size(157, 38);
            btnStockItemList.Text = "Stock";
            btnStockItemList.Click += btnStockItemList_Click;
            // 
            // btnImageList
            // 
            btnImageList.Enabled = false;
            btnImageList.Image = Properties.Resources.Brush;
            btnImageList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImageList.Name = "btnImageList";
            btnImageList.Size = new System.Drawing.Size(157, 38);
            btnImageList.Text = "Images";
            btnImageList.Click += btnImageList_Click;
            // 
            // btnBonusList
            // 
            btnBonusList.Enabled = false;
            btnBonusList.Image = Properties.Resources.Bonus32;
            btnBonusList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnBonusList.Name = "btnBonusList";
            btnBonusList.Size = new System.Drawing.Size(157, 38);
            btnBonusList.Text = "Bonus Plans";
            btnBonusList.Click += btnBonusList_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Enabled = false;
            btnEmployees.Image = Properties.Resources.BlueMan32;
            btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new System.Drawing.Size(157, 38);
            btnEmployees.Text = "Employees";
            btnEmployees.Click += btnEmployees_Click;
            // 
            // mnuInteractive
            // 
            mnuInteractive.AutoSize = false;
            mnuInteractive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnDisplay, btnStockUsage, btnKassaCalculator });
            mnuInteractive.Image = Properties.Resources.RefreshGreen;
            mnuInteractive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            mnuInteractive.ImageTransparentColor = System.Drawing.Color.Magenta;
            mnuInteractive.Name = "mnuInteractive";
            mnuInteractive.Size = new System.Drawing.Size(80, 51);
            mnuInteractive.Text = "Interactive";
            mnuInteractive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDisplay
            // 
            btnDisplay.Enabled = false;
            btnDisplay.Image = Properties.Resources.eye32;
            btnDisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new System.Drawing.Size(176, 38);
            btnDisplay.Text = "Display";
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnStockUsage
            // 
            btnStockUsage.Enabled = false;
            btnStockUsage.Image = Properties.Resources.Present32;
            btnStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnStockUsage.Name = "btnStockUsage";
            btnStockUsage.Size = new System.Drawing.Size(176, 38);
            btnStockUsage.Text = "Shopping List";
            btnStockUsage.Click += btnStockUsage_Click;
            // 
            // btnKassaCalculator
            // 
            btnKassaCalculator.Enabled = false;
            btnKassaCalculator.Image = Properties.Resources.CalculatorNice32;
            btnKassaCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnKassaCalculator.Name = "btnKassaCalculator";
            btnKassaCalculator.Size = new System.Drawing.Size(176, 38);
            btnKassaCalculator.Text = "Kassa Calculator";
            btnKassaCalculator.Click += btnKassaCalculator_Click;
            // 
            // btnSettings
            // 
            btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnSettings.AutoSize = false;
            btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSettings.Image = Properties.Resources.disli32;
            btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(60, 51);
            btnSettings.Text = "SETTINGS";
            btnSettings.Click += btnSettings_Click;
            // 
            // btnQuickReports
            // 
            btnQuickReports.AutoSize = false;
            btnQuickReports.Enabled = false;
            btnQuickReports.Image = Properties.Resources.documan_cizgili32;
            btnQuickReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnQuickReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnQuickReports.Name = "btnQuickReports";
            btnQuickReports.Size = new System.Drawing.Size(80, 51);
            btnQuickReports.Text = "Reports";
            btnQuickReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnQuickReports.Visible = false;
            btnQuickReports.Click += btnQuickReports_Click;
            // 
            // btnOrderPad
            // 
            btnOrderPad.AutoSize = false;
            btnOrderPad.Enabled = false;
            btnOrderPad.Image = Properties.Resources.GreenDollar32;
            btnOrderPad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnOrderPad.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnOrderPad.Name = "btnOrderPad";
            btnOrderPad.Size = new System.Drawing.Size(80, 51);
            btnOrderPad.Text = "OrderPad";
            btnOrderPad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnOrderPad.Visible = false;
            btnOrderPad.Click += btnOrderPad_Click;
            // 
            // btnViewDump
            // 
            btnViewDump.AutoSize = false;
            btnViewDump.Enabled = false;
            btnViewDump.Image = Properties.Resources.Digging_32;
            btnViewDump.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnViewDump.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnViewDump.Name = "btnViewDump";
            btnViewDump.Size = new System.Drawing.Size(80, 51);
            btnViewDump.Text = "View Dump";
            btnViewDump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnViewDump.Visible = false;
            btnViewDump.Click += mnuViewDumpTool_Click;
            // 
            // btnReports
            // 
            btnReports.AutoSize = false;
            btnReports.Enabled = false;
            btnReports.Image = Properties.Resources.Graph;
            btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReports.Name = "btnReports";
            btnReports.Size = new System.Drawing.Size(80, 51);
            btnReports.Text = "A Reports";
            btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReports.Visible = false;
            btnReports.Click += btnSessionReports_Click;
            // 
            // btnSessionAnalysis
            // 
            btnSessionAnalysis.AutoSize = false;
            btnSessionAnalysis.Enabled = false;
            btnSessionAnalysis.Image = Properties.Resources.Document_Chart;
            btnSessionAnalysis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionAnalysis.Name = "btnSessionAnalysis";
            btnSessionAnalysis.Size = new System.Drawing.Size(80, 51);
            btnSessionAnalysis.Text = "Analysis";
            btnSessionAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionAnalysis.Visible = false;
            btnSessionAnalysis.Click += btnSessionAnalysis_Click;
            // 
            // btnCloseAllWindows
            // 
            btnCloseAllWindows.AutoSize = false;
            btnCloseAllWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnCloseAllWindows.Image = Properties.Resources.Cancel;
            btnCloseAllWindows.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCloseAllWindows.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCloseAllWindows.Name = "btnCloseAllWindows";
            btnCloseAllWindows.Size = new System.Drawing.Size(80, 51);
            btnCloseAllWindows.Text = "Close All Windows";
            btnCloseAllWindows.Click += btnCloseAllWindows_Click;
            // 
            // btnCloseApplication
            // 
            btnCloseApplication.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnCloseApplication.AutoSize = false;
            btnCloseApplication.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnCloseApplication.Image = Properties.Resources.SquareArrowRightExpander32;
            btnCloseApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCloseApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCloseApplication.Name = "btnCloseApplication";
            btnCloseApplication.Size = new System.Drawing.Size(70, 51);
            btnCloseApplication.Text = "EXIT APPLICATION";
            btnCloseApplication.Click += btnCloseApplication_Click;
            // 
            // tabForms
            // 
            tabForms.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            tabForms.ImageList = imgTabPageList;
            tabForms.ItemSize = new System.Drawing.Size(60, 25);
            tabForms.Location = new System.Drawing.Point(0, 54);
            tabForms.Name = "tabForms";
            tabForms.SelectedIndex = 0;
            tabForms.Size = new System.Drawing.Size(1032, 25);
            tabForms.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            tabForms.TabIndex = 12;
            tabForms.SelectedIndexChanged += tabForms_SelectedIndexChanged;
            tabForms.ControlAdded += tabForms_ControlAdded;
            tabForms.ControlRemoved += tabForms_ControlRemoved;
            tabForms.MouseClick += tabForms_MouseClick;
            // 
            // imgTabPageList
            // 
            imgTabPageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imgTabPageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imgTabPageList.ImageStream");
            imgTabPageList.TransparentColor = System.Drawing.Color.Transparent;
            imgTabPageList.Images.SetKeyName(0, "Cancel.png");
            // 
            // frmOffice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(1032, 556);
            Controls.Add(tabForms);
            Controls.Add(statusStrip1);
            Controls.Add(barMain);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Segoe UI", 8.25F);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmOffice";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "POS OFFICE";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmMain_Load;
            MdiChildActivate += frmOffice_MdiChildActivate;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem btnDisplay;
        private System.Windows.Forms.ToolStripMenuItem btnStockUsage;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ImageList imgTabPageList;
        private System.Windows.Forms.ToolStripMenuItem btnEmployees;
        private System.Windows.Forms.ToolStripMenuItem btnKassaCalculator;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnQuickReports;
        private System.Windows.Forms.ToolStripButton btnOrderPad;
        private System.Windows.Forms.ToolStripButton btnViewDump;
        private System.Windows.Forms.ToolStripButton btnReports;
        private System.Windows.Forms.ToolStripButton btnSessionAnalysis;
        private System.Windows.Forms.ToolStripButton btnCloseAllWindows;
        private System.Windows.Forms.ToolStripButton btnCloseApplication;
    }
}