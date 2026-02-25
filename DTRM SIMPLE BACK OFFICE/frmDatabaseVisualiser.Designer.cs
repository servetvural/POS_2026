namespace DTRMSimpleBackOffice {
    partial class frmDatabaseVisualiser {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseVisualiser));
            this.treeAdv = new DevComponents.AdvTree.AdvTree();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.node5 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle3 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.bgLoader = new System.ComponentModel.BackgroundWorker();
            this.pBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.barMenu = new DevComponents.DotNetBar.Bar();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.btnExportImagesToFolder = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.btnCorrectImageFilenamesAccordingly = new DevComponents.DotNetBar.ButtonItem();
            this.btnDebug = new DevComponents.DotNetBar.ButtonItem();
            this.bgBackup = new System.ComponentModel.BackgroundWorker();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.chkMenus = new System.Windows.Forms.CheckBox();
            this.chkSettings = new System.Windows.Forms.CheckBox();
            this.chkTables = new System.Windows.Forms.CheckBox();
            this.chkPrinters = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkCustomers = new System.Windows.Forms.CheckBox();
            this.pnlOptions = new DevComponents.DotNetBar.PanelEx();
            this.chkImages = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkKitchenOrders = new System.Windows.Forms.CheckBox();
            this.chkXOrders = new System.Windows.Forms.CheckBox();
            this.chkALL = new System.Windows.Forms.CheckBox();
            this.chkOrders = new System.Windows.Forms.CheckBox();
            this.bgXMLLoader = new System.ComponentModel.BackgroundWorker();
            this.bgSaveToDatabase = new System.ComponentModel.BackgroundWorker();
            this.btnReload = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnBackupDatabase = new DevComponents.DotNetBar.ButtonItem();
            this.btnShrink = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportXML = new DevComponents.DotNetBar.ButtonItem();
            this.btnRunScript = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaveIntoDatabase = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeAdv
            // 
            this.treeAdv.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeAdv.AllowDrop = true;
            this.treeAdv.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeAdv.BackgroundStyle.Class = "TreeBorderKey";
            this.treeAdv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAdv.ExpandButtonSize = new System.Drawing.Size(16, 16);
            this.treeAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeAdv.ImageList = this.imgList;
            this.treeAdv.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.treeAdv.Location = new System.Drawing.Point(0, 115);
            this.treeAdv.Name = "treeAdv";
            this.treeAdv.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.treeAdv.NodesConnector = this.nodeConnector1;
            this.treeAdv.NodeStyle = this.elementStyle3;
            this.treeAdv.PathSeparator = ";";
            this.treeAdv.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.treeAdv.Size = new System.Drawing.Size(1031, 605);
            this.treeAdv.Styles.Add(this.elementStyle1);
            this.treeAdv.Styles.Add(this.elementStyle2);
            this.treeAdv.Styles.Add(this.elementStyle3);
            this.treeAdv.TabIndex = 0;
            this.treeAdv.Text = "advTree1";
            this.treeAdv.SelectionChanged += new System.EventHandler(this.TreeAdv_SelectionChanged);
            this.treeAdv.BeforeNodeDrop += new DevComponents.AdvTree.TreeDragDropEventHandler(this.TreeAdv_BeforeNodeDrop);
            this.treeAdv.AfterNodeDrop += new DevComponents.AdvTree.TreeDragDropEventHandler(this.TreeAdv_AfterNodeDrop);
            this.treeAdv.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.TreeAdv_NodeDoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Database.png");
            this.imgList.Images.SetKeyName(1, "MultiPeople2.png");
            this.imgList.Images.SetKeyName(2, "Usergroup.png");
            this.imgList.Images.SetKeyName(3, "User White.png");
            this.imgList.Images.SetKeyName(4, "Print.png");
            this.imgList.Images.SetKeyName(5, "Gear.png");
            this.imgList.Images.SetKeyName(6, "GearGreen.png");
            this.imgList.Images.SetKeyName(7, "GearRed.png");
            this.imgList.Images.SetKeyName(8, "table10person32.png");
            this.imgList.Images.SetKeyName(9, "table2person32.png");
            this.imgList.Images.SetKeyName(10, "Restaurant.png");
            this.imgList.Images.SetKeyName(11, "Sample 1332.png");
            this.imgList.Images.SetKeyName(12, "Project4.png");
            this.imgList.Images.SetKeyName(13, "Split32Right.png");
            this.imgList.Images.SetKeyName(14, "MultiShopping32.png");
            this.imgList.Images.SetKeyName(15, "User3.png");
            this.imgList.Images.SetKeyName(16, "Cart.png");
            this.imgList.Images.SetKeyName(17, "Order32.png");
            this.imgList.Images.SetKeyName(18, "OrderItem32.png");
            this.imgList.Images.SetKeyName(19, "XOrder32.png");
            this.imgList.Images.SetKeyName(20, "XOrderItem32.png");
            this.imgList.Images.SetKeyName(21, "chefdouble32.png");
            this.imgList.Images.SetKeyName(22, "chef32.png");
            this.imgList.Images.SetKeyName(23, "Glasses32.png");
            this.imgList.Images.SetKeyName(24, "FolderOpen_32.png");
            this.imgList.Images.SetKeyName(25, "happy2 32.png");
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2,
            this.node4});
            this.node1.Text = "node1";
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node3});
            this.node2.Text = "node2";
            // 
            // node3
            // 
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Text = "node3";
            // 
            // node4
            // 
            this.node4.Expanded = true;
            this.node4.Name = "node4";
            this.node4.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node5});
            this.node4.Text = "node4";
            // 
            // node5
            // 
            this.node5.Expanded = true;
            this.node5.Name = "node5";
            this.node5.Text = "node5";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle3
            // 
            this.elementStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elementStyle3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(224)))), ((int)(((byte)(252)))));
            this.elementStyle3.BackColorGradientAngle = 90;
            this.elementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderBottomWidth = 1;
            this.elementStyle3.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderLeftWidth = 1;
            this.elementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderRightWidth = 1;
            this.elementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle3.BorderTopWidth = 1;
            this.elementStyle3.CornerDiameter = 4;
            this.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.elementStyle3.Description = "BlueLight";
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.PaddingBottom = 3;
            this.elementStyle3.PaddingLeft = 5;
            this.elementStyle3.PaddingRight = 5;
            this.elementStyle3.PaddingTop = 3;
            this.elementStyle3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(84)))), ((int)(((byte)(115)))));
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "Blue";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.Black;
            // 
            // bgLoader
            // 
            this.bgLoader.WorkerReportsProgress = true;
            this.bgLoader.WorkerSupportsCancellation = true;
            this.bgLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgLoader_DoWork);
            this.bgLoader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgLoader_ProgressChanged);
            this.bgLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgLoader_RunWorkerCompleted);
            // 
            // pBar
            // 
            // 
            // 
            // 
            this.pBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar.Location = new System.Drawing.Point(0, 720);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(1031, 18);
            this.pBar.TabIndex = 1;
            this.pBar.Text = "progressBarX1";
            // 
            // barMenu
            // 
            this.barMenu.AntiAlias = true;
            this.barMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.barMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReload,
            this.btnEdit,
            this.btnDelete,
            this.btnBackupDatabase,
            this.btnShrink,
            this.btnImportXML,
            this.btnRunScript,
            this.btnSaveIntoDatabase,
            this.buttonItem4,
            this.btnDebug});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(1031, 57);
            this.barMenu.Stretch = true;
            this.barMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barMenu.TabIndex = 2;
            this.barMenu.TabStop = false;
            this.barMenu.Text = "bar1";
            // 
            // buttonItem4
            // 
            this.buttonItem4.AutoExpandOnClick = true;
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExportImagesToFolder,
            this.buttonItem5,
            this.btnCorrectImageFilenamesAccordingly});
            this.buttonItem4.Symbol = "";
            this.buttonItem4.Text = "IMG Functions";
            // 
            // btnExportImagesToFolder
            // 
            this.btnExportImagesToFolder.Name = "btnExportImagesToFolder";
            this.btnExportImagesToFolder.Symbol = "";
            this.btnExportImagesToFolder.Text = "Export Images To Folder";
            this.btnExportImagesToFolder.Click += new System.EventHandler(this.BtnExportImagesToFolder_Click);
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Symbol = "";
            this.buttonItem5.Text = "Export Images As XML File";
            this.buttonItem5.Click += new System.EventHandler(this.BtnExportImagesAsXML_Click);
            // 
            // btnCorrectImageFilenamesAccordingly
            // 
            this.btnCorrectImageFilenamesAccordingly.Name = "btnCorrectImageFilenamesAccordingly";
            this.btnCorrectImageFilenamesAccordingly.Symbol = "";
            this.btnCorrectImageFilenamesAccordingly.Text = "Correct Image Filenames Accordingly";
            this.btnCorrectImageFilenamesAccordingly.Click += new System.EventHandler(this.BtnCorrectImageLibraryFileNames_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Symbol = "";
            this.btnDebug.Text = "View Debug";
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // bgBackup
            // 
            this.bgBackup.WorkerReportsProgress = true;
            this.bgBackup.WorkerSupportsCancellation = true;
            this.bgBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgBackup_DoWork);
            this.bgBackup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgBackup_ProgressChanged);
            this.bgBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgBackup_RunWorkerCompleted);
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.Location = new System.Drawing.Point(483, 10);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(59, 17);
            this.chkStock.TabIndex = 6;
            this.chkStock.Text = "Stock";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // chkMenus
            // 
            this.chkMenus.AutoSize = true;
            this.chkMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMenus.Location = new System.Drawing.Point(409, 10);
            this.chkMenus.Name = "chkMenus";
            this.chkMenus.Size = new System.Drawing.Size(63, 17);
            this.chkMenus.TabIndex = 5;
            this.chkMenus.Text = "Menus";
            this.chkMenus.UseVisualStyleBackColor = true;
            // 
            // chkSettings
            // 
            this.chkSettings.AutoSize = true;
            this.chkSettings.Checked = true;
            this.chkSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSettings.Enabled = false;
            this.chkSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSettings.Location = new System.Drawing.Point(329, 10);
            this.chkSettings.Name = "chkSettings";
            this.chkSettings.Size = new System.Drawing.Size(72, 17);
            this.chkSettings.TabIndex = 4;
            this.chkSettings.Text = "Settings";
            this.chkSettings.UseVisualStyleBackColor = true;
            // 
            // chkTables
            // 
            this.chkTables.AutoSize = true;
            this.chkTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTables.Location = new System.Drawing.Point(255, 10);
            this.chkTables.Name = "chkTables";
            this.chkTables.Size = new System.Drawing.Size(64, 17);
            this.chkTables.TabIndex = 3;
            this.chkTables.Text = "Tables";
            this.chkTables.UseVisualStyleBackColor = true;
            // 
            // chkPrinters
            // 
            this.chkPrinters.AutoSize = true;
            this.chkPrinters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrinters.Location = new System.Drawing.Point(178, 10);
            this.chkPrinters.Name = "chkPrinters";
            this.chkPrinters.Size = new System.Drawing.Size(69, 17);
            this.chkPrinters.TabIndex = 2;
            this.chkPrinters.Text = "Printers";
            this.chkPrinters.UseVisualStyleBackColor = true;
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsers.Location = new System.Drawing.Point(109, 10);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(58, 17);
            this.chkUsers.TabIndex = 1;
            this.chkUsers.Text = "Users";
            this.chkUsers.UseVisualStyleBackColor = true;
            // 
            // chkCustomers
            // 
            this.chkCustomers.AutoSize = true;
            this.chkCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomers.Location = new System.Drawing.Point(18, 10);
            this.chkCustomers.Name = "chkCustomers";
            this.chkCustomers.Size = new System.Drawing.Size(84, 17);
            this.chkCustomers.TabIndex = 0;
            this.chkCustomers.Text = "Customers";
            this.chkCustomers.UseVisualStyleBackColor = true;
            // 
            // pnlOptions
            // 
            this.pnlOptions.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlOptions.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlOptions.Controls.Add(this.chkImages);
            this.pnlOptions.Controls.Add(this.chkDebug);
            this.pnlOptions.Controls.Add(this.chkKitchenOrders);
            this.pnlOptions.Controls.Add(this.chkXOrders);
            this.pnlOptions.Controls.Add(this.chkALL);
            this.pnlOptions.Controls.Add(this.chkOrders);
            this.pnlOptions.Controls.Add(this.chkStock);
            this.pnlOptions.Controls.Add(this.chkCustomers);
            this.pnlOptions.Controls.Add(this.chkMenus);
            this.pnlOptions.Controls.Add(this.chkUsers);
            this.pnlOptions.Controls.Add(this.chkSettings);
            this.pnlOptions.Controls.Add(this.chkPrinters);
            this.pnlOptions.Controls.Add(this.chkTables);
            this.pnlOptions.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 57);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(1031, 58);
            this.pnlOptions.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlOptions.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlOptions.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlOptions.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlOptions.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlOptions.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlOptions.Style.GradientAngle = 90;
            this.pnlOptions.TabIndex = 4;
            // 
            // chkImages
            // 
            this.chkImages.AutoSize = true;
            this.chkImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImages.Location = new System.Drawing.Point(557, 10);
            this.chkImages.Name = "chkImages";
            this.chkImages.Size = new System.Drawing.Size(66, 17);
            this.chkImages.TabIndex = 8;
            this.chkImages.Text = "Images";
            this.chkImages.UseVisualStyleBackColor = true;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebug.ForeColor = System.Drawing.Color.Maroon;
            this.chkDebug.Location = new System.Drawing.Point(409, 33);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(130, 17);
            this.chkDebug.TabIndex = 7;
            this.chkDebug.Text = "Debug Information";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkKitchenOrders
            // 
            this.chkKitchenOrders.AutoSize = true;
            this.chkKitchenOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKitchenOrders.ForeColor = System.Drawing.Color.Maroon;
            this.chkKitchenOrders.Location = new System.Drawing.Point(255, 33);
            this.chkKitchenOrders.Name = "chkKitchenOrders";
            this.chkKitchenOrders.Size = new System.Drawing.Size(110, 17);
            this.chkKitchenOrders.TabIndex = 7;
            this.chkKitchenOrders.Text = "Kitchen Orders";
            this.chkKitchenOrders.UseVisualStyleBackColor = true;
            // 
            // chkXOrders
            // 
            this.chkXOrders.AutoSize = true;
            this.chkXOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXOrders.ForeColor = System.Drawing.Color.Maroon;
            this.chkXOrders.Location = new System.Drawing.Point(178, 33);
            this.chkXOrders.Name = "chkXOrders";
            this.chkXOrders.Size = new System.Drawing.Size(75, 17);
            this.chkXOrders.TabIndex = 7;
            this.chkXOrders.Text = "X-Orders";
            this.chkXOrders.UseVisualStyleBackColor = true;
            // 
            // chkALL
            // 
            this.chkALL.AutoSize = true;
            this.chkALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkALL.Location = new System.Drawing.Point(18, 33);
            this.chkALL.Name = "chkALL";
            this.chkALL.Size = new System.Drawing.Size(48, 17);
            this.chkALL.TabIndex = 7;
            this.chkALL.Text = "ALL";
            this.chkALL.UseVisualStyleBackColor = true;
            this.chkALL.CheckedChanged += new System.EventHandler(this.ChkALL_CheckedChanged);
            // 
            // chkOrders
            // 
            this.chkOrders.AutoSize = true;
            this.chkOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrders.ForeColor = System.Drawing.Color.Maroon;
            this.chkOrders.Location = new System.Drawing.Point(109, 33);
            this.chkOrders.Name = "chkOrders";
            this.chkOrders.Size = new System.Drawing.Size(63, 17);
            this.chkOrders.TabIndex = 7;
            this.chkOrders.Text = "Orders";
            this.chkOrders.UseVisualStyleBackColor = true;
            // 
            // bgXMLLoader
            // 
            this.bgXMLLoader.WorkerReportsProgress = true;
            this.bgXMLLoader.WorkerSupportsCancellation = true;
            this.bgXMLLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgXMLLoader_DoWork);
            this.bgXMLLoader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgXMLLoader_ProgressChanged);
            this.bgXMLLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgXMLLoader_RunWorkerCompleted);
            // 
            // bgSaveToDatabase
            // 
            this.bgSaveToDatabase.WorkerReportsProgress = true;
            this.bgSaveToDatabase.WorkerSupportsCancellation = true;
            this.bgSaveToDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgSaveToDatabase_DoWork);
            this.bgSaveToDatabase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgSaveToDatabase_ProgressChanged);
            this.bgSaveToDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgSaveToDatabase_RunWorkerCompleted);
            // 
            // btnReload
            // 
            this.btnReload.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReload.Image = global::DTRMSimpleBackOffice.Properties.Resources.Reload_32;
            this.btnReload.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReload.Name = "btnReload";
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEdit.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBackupDatabase.Image = global::DTRMSimpleBackOffice.Properties.Resources.XML32;
            this.btnBackupDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.Text = "Export XML";
            this.btnBackupDatabase.Tooltip = "Backup Menu";
            this.btnBackupDatabase.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnShrink
            // 
            this.btnShrink.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnShrink.Image = global::DTRMSimpleBackOffice.Properties.Resources.CrossRail32;
            this.btnShrink.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Text = "Shrink Item";
            this.btnShrink.Click += new System.EventHandler(this.BtnShrink_Click);
            // 
            // btnImportXML
            // 
            this.btnImportXML.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnImportXML.Image = global::DTRMSimpleBackOffice.Properties.Resources.XMLGreen32;
            this.btnImportXML.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Text = "Import XML";
            this.btnImportXML.Tooltip = "Backup Menu";
            this.btnImportXML.Click += new System.EventHandler(this.BtnImportXML_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Image = global::DTRMSimpleBackOffice.Properties.Resources.disli32;
            this.btnRunScript.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Text = "RUN SCRIPT";
            this.btnRunScript.Click += new System.EventHandler(this.BtnRunScript_Click);
            // 
            // btnSaveIntoDatabase
            // 
            this.btnSaveIntoDatabase.Enabled = false;
            this.btnSaveIntoDatabase.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderToDBPlus32;
            this.btnSaveIntoDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSaveIntoDatabase.Name = "btnSaveIntoDatabase";
            this.btnSaveIntoDatabase.Text = "SAVE INTO DATABASE";
            this.btnSaveIntoDatabase.Click += new System.EventHandler(this.BtnSaveIntoDatabase_Click);
            // 
            // frmDatabaseVisualiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 738);
            this.Controls.Add(this.treeAdv);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.barMenu);
            this.Controls.Add(this.pBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatabaseVisualiser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DATABASE VISUALISER";
            this.Load += new System.EventHandler(this.FrmDatabaseVisualiser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree treeAdv;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.ComponentModel.BackgroundWorker bgLoader;
        private DevComponents.DotNetBar.Controls.ProgressBarX pBar;
        private System.Windows.Forms.ImageList imgList;
        private DevComponents.DotNetBar.Bar barMenu;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnBackupDatabase;
        private DevComponents.DotNetBar.ButtonItem btnReload;
        private DevComponents.DotNetBar.ButtonItem btnShrink;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.AdvTree.Node node5;
        private System.ComponentModel.BackgroundWorker bgBackup;
        private System.Windows.Forms.CheckBox chkSettings;
        private System.Windows.Forms.CheckBox chkTables;
        private System.Windows.Forms.CheckBox chkPrinters;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.CheckBox chkCustomers;
        private System.Windows.Forms.CheckBox chkMenus;
        private System.Windows.Forms.CheckBox chkStock;
        private DevComponents.DotNetBar.PanelEx pnlOptions;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkKitchenOrders;
        private System.Windows.Forms.CheckBox chkXOrders;
        private System.Windows.Forms.CheckBox chkOrders;
        private System.Windows.Forms.CheckBox chkALL;
        private DevComponents.DotNetBar.ButtonItem btnImportXML;
        private System.ComponentModel.BackgroundWorker bgXMLLoader;
        private DevComponents.DotNetBar.ButtonItem btnRunScript;
        private DevComponents.DotNetBar.ButtonItem btnSaveIntoDatabase;
        private System.ComponentModel.BackgroundWorker bgSaveToDatabase;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem btnExportImagesToFolder;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem btnCorrectImageFilenamesAccordingly;
        private System.Windows.Forms.CheckBox chkImages;
        private DevComponents.DotNetBar.ButtonItem btnDebug;
    }
}