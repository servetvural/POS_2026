using POSLayer.Library;
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class FrmMenuEditorOld {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvMenu = new System.Windows.Forms.DataGridView();
            colMenuIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsActiveMenu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            DOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            theMenuBindingSource = new System.Windows.Forms.BindingSource(components);
            popEntityButton = new System.Windows.Forms.ContextMenuStrip(components);
            popEBAddNew = new System.Windows.Forms.ToolStripMenuItem();
            popEBEdit = new System.Windows.Forms.ToolStripMenuItem();
            popEBDelete = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            popEBSetFont = new System.Windows.Forms.ToolStripMenuItem();
            popEBSetWidth = new System.Windows.Forms.ToolStripMenuItem();
            popEBSetHeight = new System.Windows.Forms.ToolStripMenuItem();
            popEBSetPrice = new System.Windows.Forms.ToolStripMenuItem();
            popEBSetTaxRate = new System.Windows.Forms.ToolStripMenuItem();
            popEBSetToUpperCase = new System.Windows.Forms.ToolStripMenuItem();
            popEBSetToLowercase = new System.Windows.Forms.ToolStripMenuItem();
            popSetSentenceCase = new System.Windows.Forms.ToolStripMenuItem();
            popEBMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            popEBReOrder = new System.Windows.Forms.ToolStripMenuItem();
            popEBDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            popEBConvertToStockItem = new System.Windows.Forms.ToolStripMenuItem();
            popSetAllForeColourTo = new System.Windows.Forms.ToolStripMenuItem();
            popSetAllBackColourTo = new System.Windows.Forms.ToolStripMenuItem();
            popSetAllBackColourToTransparent = new System.Windows.Forms.ToolStripMenuItem();
            popSetAllDistributionTo = new System.Windows.Forms.ToolStripMenuItem();
            pnlBottom = new System.Windows.Forms.Panel();
            dgvSearchResults = new System.Windows.Forms.DataGridView();
            colDisplayImageSearch = new System.Windows.Forms.DataGridViewImageColumn();
            colIIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEntityButtonNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEntityNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityButtonSearchResultBindingSource = new System.Windows.Forms.BindingSource(components);
            pnlSearchImagePanel = new System.Windows.Forms.Panel();
            pBoxSearchItem = new System.Windows.Forms.PictureBox();
            tabMain = new System.Windows.Forms.TabControl();
            tabMenus = new System.Windows.Forms.TabPage();
            pnlRight = new System.Windows.Forms.Panel();
            pnlRightBottom = new System.Windows.Forms.Panel();
            dgvStockItems = new System.Windows.Forms.DataGridView();
            colStockUsageIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            QuantityTypeAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBSItemDisplayOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityButtonStockItemLookUpBindingSource = new System.Windows.Forms.BindingSource(components);
            pnlEBPicture = new System.Windows.Forms.Panel();
            pboxEBPicture = new System.Windows.Forms.PictureBox();
            btnEBSample = new System.Windows.Forms.Button();
            barStockUsage = new System.Windows.Forms.ToolStrip();
            btnAddStockItem = new System.Windows.Forms.ToolStripButton();
            btnEditStockItem = new System.Windows.Forms.ToolStripButton();
            btnDeleteStockItem = new System.Windows.Forms.ToolStripButton();
            btnZoomStockUsage = new System.Windows.Forms.ToolStripButton();
            btnReorderStockUsage = new System.Windows.Forms.ToolStripButton();
            btnCopyStockUsageItems = new System.Windows.Forms.ToolStripButton();
            btnPasteStockUsageItems = new System.Windows.Forms.ToolStripButton();
            btnPasteSpecialStockUsageItems = new System.Windows.Forms.ToolStripButton();
            lblImageSize = new System.Windows.Forms.ToolStripLabel();
            btnQuantityToComment = new System.Windows.Forms.ToolStripButton();
            tsSortStockItem = new System.Windows.Forms.ToolStripButton();
            tsMoveUpStockItem = new System.Windows.Forms.ToolStripButton();
            tsMoveDownStockItem = new System.Windows.Forms.ToolStripButton();
            expanderRight = new PosLibrary.Expander();
            pnlRightTop = new System.Windows.Forms.Panel();
            dgvCategoryItem = new System.Windows.Forms.DataGridView();
            colEBDisplayImage = new System.Windows.Forms.DataGridViewImageColumn();
            ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEntityButtonIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBDistributionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBFont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBDirectSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBInHousePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBTakeAwayPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBDeliveryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBDirectSaleTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBInHouseTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBTakeAwayTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBDeliveryTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBDisplayOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryItemBindingSource = new System.Windows.Forms.BindingSource(components);
            barEntityButton = new System.Windows.Forms.ToolStrip();
            btnAddEntityButton = new System.Windows.Forms.ToolStripButton();
            btnEditEntityButton = new System.Windows.Forms.ToolStripButton();
            btnDeleteEntityButton = new System.Windows.Forms.ToolStripButton();
            btnZoomEntityButton = new System.Windows.Forms.ToolStripButton();
            btnSetAll = new System.Windows.Forms.ToolStripDropDownButton();
            btnEBFontTo = new System.Windows.Forms.ToolStripMenuItem();
            btnEBWidthTo = new System.Windows.Forms.ToolStripMenuItem();
            btnEBHeightTo = new System.Windows.Forms.ToolStripMenuItem();
            btnEBPriceTo = new System.Windows.Forms.ToolStripMenuItem();
            btnEBTaxRateTo = new System.Windows.Forms.ToolStripMenuItem();
            btnSetUpperCase = new System.Windows.Forms.ToolStripMenuItem();
            btnSetToLowerCase = new System.Windows.Forms.ToolStripMenuItem();
            btnSetSentenceCase = new System.Windows.Forms.ToolStripMenuItem();
            btnSetAllForeColourTo = new System.Windows.Forms.ToolStripMenuItem();
            btnSetAllBackColourTo = new System.Windows.Forms.ToolStripMenuItem();
            btnSetAllBackColourToTransparent = new System.Windows.Forms.ToolStripMenuItem();
            btnChangeDistributionForEB = new System.Windows.Forms.ToolStripMenuItem();
            btnMoveToEntity = new System.Windows.Forms.ToolStripButton();
            btnReOrder = new System.Windows.Forms.ToolStripButton();
            btnDuplicate = new System.Windows.Forms.ToolStripButton();
            btnConvertToStockItem = new System.Windows.Forms.ToolStripButton();
            btnEntityButtonRowHeight = new System.Windows.Forms.ToolStripDropDownButton();
            btnEntityButtonRowHeight25 = new System.Windows.Forms.ToolStripMenuItem();
            btnEntityButtonRowHeight50 = new System.Windows.Forms.ToolStripMenuItem();
            btnEntityButtonRowHeight100 = new System.Windows.Forms.ToolStripMenuItem();
            btnEntityButtonRowHeight150 = new System.Windows.Forms.ToolStripMenuItem();
            btnEntityButtonRowHeight200 = new System.Windows.Forms.ToolStripMenuItem();
            tsSortCategoryItem = new System.Windows.Forms.ToolStripButton();
            tsMoveUpCategoryItem = new System.Windows.Forms.ToolStripButton();
            tsMoveDownCategoryItem = new System.Windows.Forms.ToolStripButton();
            expanderMIddle = new PosLibrary.Expander();
            pnlLeft = new System.Windows.Forms.Panel();
            pnlLeftBottom = new System.Windows.Forms.Panel();
            dgvCategory = new System.Windows.Forms.DataGridView();
            categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            distributionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryBindingSource = new System.Windows.Forms.BindingSource(components);
            barEntity = new System.Windows.Forms.ToolStrip();
            btnAddEntity = new System.Windows.Forms.ToolStripButton();
            btnEditEntity = new System.Windows.Forms.ToolStripButton();
            btnDeleteEntity = new System.Windows.Forms.ToolStripButton();
            btnReOrderEntityList = new System.Windows.Forms.ToolStripButton();
            btnZoomEntity = new System.Windows.Forms.ToolStripButton();
            tsSortCategory = new System.Windows.Forms.ToolStripButton();
            tsMoveUpCategory = new System.Windows.Forms.ToolStripButton();
            tsMoveDownCategory = new System.Windows.Forms.ToolStripButton();
            pnlEntitySample = new System.Windows.Forms.Panel();
            btnEntitySample = new System.Windows.Forms.Button();
            expanderLeft = new PosLibrary.Expander();
            pnlLeftTop = new System.Windows.Forms.Panel();
            barMenu = new System.Windows.Forms.ToolStrip();
            btnAddMenu = new System.Windows.Forms.ToolStripButton();
            btnEditMenu = new System.Windows.Forms.ToolStripButton();
            btnDeleteMenu = new System.Windows.Forms.ToolStripButton();
            btnReloadMenu = new System.Windows.Forms.ToolStripButton();
            btnSaveMenu = new System.Windows.Forms.ToolStripButton();
            mnuSetAsDefaultMenu = new System.Windows.Forms.ToolStripButton();
            btnPrintMenu = new System.Windows.Forms.ToolStripButton();
            btnLoadMenu = new System.Windows.Forms.ToolStripButton();
            btnBackupMenu = new System.Windows.Forms.ToolStripButton();
            btnZoomMenu = new System.Windows.Forms.ToolStripButton();
            btnExportStockManager = new System.Windows.Forms.ToolStripButton();
            btnImportStockManager = new System.Windows.Forms.ToolStripButton();
            btnSaveDBImagesToFolder = new System.Windows.Forms.ToolStripButton();
            btnLoadMenuList = new System.Windows.Forms.ToolStripButton();
            btnCreateDummyMenu = new System.Windows.Forms.ToolStripButton();
            btnExportMenuAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportMenuFromJSON = new System.Windows.Forms.ToolStripButton();
            tsSortMenu = new System.Windows.Forms.ToolStripButton();
            tsMoveUpMenu = new System.Windows.Forms.ToolStripButton();
            tsMoveDownMenu = new System.Windows.Forms.ToolStripButton();
            tabSearchCategoryItems = new System.Windows.Forms.TabPage();
            barSearchCategoryItems = new System.Windows.Forms.ToolStrip();
            txtSearchCategoryButtons = new System.Windows.Forms.ToolStripTextBox();
            btnSearchCategoryButtons = new System.Windows.Forms.ToolStripButton();
            chkAllMenuSearch = new System.Windows.Forms.ToolStripButton();
            lblSearchResults = new System.Windows.Forms.ToolStripLabel();
            entityButtonExtendedBindingSource = new System.Windows.Forms.BindingSource(components);
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityButtonBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)theMenuBindingSource).BeginInit();
            popEntityButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonSearchResultBindingSource).BeginInit();
            pnlSearchImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSearchItem).BeginInit();
            tabMain.SuspendLayout();
            tabMenus.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonStockItemLookUpBindingSource).BeginInit();
            pnlEBPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxEBPicture).BeginInit();
            barStockUsage.SuspendLayout();
            pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryItemBindingSource).BeginInit();
            barEntityButton.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlLeftBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            barEntity.SuspendLayout();
            pnlEntitySample.SuspendLayout();
            pnlLeftTop.SuspendLayout();
            barMenu.SuspendLayout();
            tabSearchCategoryItems.SuspendLayout();
            barSearchCategoryItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entityButtonExtendedBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AutoGenerateColumns = false;
            dgvMenu.BackgroundColor = System.Drawing.Color.White;
            dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMenuIID, colMenuName, IsActiveMenu, DOrder });
            dgvMenu.DataSource = theMenuBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMenu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMenu.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvMenu.Location = new System.Drawing.Point(0, 54);
            dgvMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersWidth = 15;
            dgvMenu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new System.Drawing.Size(1551, 252);
            dgvMenu.TabIndex = 1;
            dgvMenu.SelectionChanged += DgvMenu_SelectionChanged;
            // 
            // colMenuIID
            // 
            colMenuIID.DataPropertyName = "IID";
            colMenuIID.HeaderText = "IID";
            colMenuIID.Name = "colMenuIID";
            colMenuIID.ReadOnly = true;
            colMenuIID.Visible = false;
            // 
            // colMenuName
            // 
            colMenuName.DataPropertyName = "MenuName";
            colMenuName.HeaderText = "Menu";
            colMenuName.Name = "colMenuName";
            colMenuName.ReadOnly = true;
            colMenuName.Width = 300;
            // 
            // IsActiveMenu
            // 
            IsActiveMenu.DataPropertyName = "IsActiveMenu";
            IsActiveMenu.HeaderText = "Is Current";
            IsActiveMenu.Name = "IsActiveMenu";
            IsActiveMenu.ReadOnly = true;
            // 
            // DOrder
            // 
            DOrder.DataPropertyName = "DOrder";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DOrder.DefaultCellStyle = dataGridViewCellStyle1;
            DOrder.HeaderText = "DOrder";
            DOrder.Name = "DOrder";
            DOrder.ReadOnly = true;
            DOrder.Width = 70;
            // 
            // theMenuBindingSource
            // 
            theMenuBindingSource.DataSource = typeof(TheMenu);
            // 
            // popEntityButton
            // 
            popEntityButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { popEBAddNew, popEBEdit, popEBDelete, toolStripMenuItem1, popEBSetFont, popEBSetWidth, popEBSetHeight, popEBSetPrice, popEBSetTaxRate, popEBSetToUpperCase, popEBSetToLowercase, popSetSentenceCase, popEBMoveTo, popEBReOrder, popEBDuplicate, popEBConvertToStockItem, popSetAllForeColourTo, popSetAllBackColourTo, popSetAllBackColourToTransparent, popSetAllDistributionTo });
            popEntityButton.Name = "popEntityButton";
            popEntityButton.Size = new System.Drawing.Size(236, 428);
            // 
            // popEBAddNew
            // 
            popEBAddNew.Name = "popEBAddNew";
            popEBAddNew.Size = new System.Drawing.Size(235, 22);
            popEBAddNew.Text = "Add New";
            popEBAddNew.Click += BtnAddEntityButton_Click;
            // 
            // popEBEdit
            // 
            popEBEdit.Name = "popEBEdit";
            popEBEdit.Size = new System.Drawing.Size(235, 22);
            popEBEdit.Text = "Edit";
            popEBEdit.Click += BtnEditEntityButton_Click;
            // 
            // popEBDelete
            // 
            popEBDelete.Name = "popEBDelete";
            popEBDelete.Size = new System.Drawing.Size(235, 22);
            popEBDelete.Text = "Delete";
            popEBDelete.Click += BtnDeleteEntityButton_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(232, 6);
            // 
            // popEBSetFont
            // 
            popEBSetFont.Name = "popEBSetFont";
            popEBSetFont.Size = new System.Drawing.Size(235, 22);
            popEBSetFont.Text = "Set Font";
            popEBSetFont.Click += BtnEBFontTo_Click;
            // 
            // popEBSetWidth
            // 
            popEBSetWidth.Name = "popEBSetWidth";
            popEBSetWidth.Size = new System.Drawing.Size(235, 22);
            popEBSetWidth.Text = "Set Width";
            popEBSetWidth.Click += BtnEBWidthTo_Click;
            // 
            // popEBSetHeight
            // 
            popEBSetHeight.Name = "popEBSetHeight";
            popEBSetHeight.Size = new System.Drawing.Size(235, 22);
            popEBSetHeight.Text = "Set Height";
            popEBSetHeight.Click += BtnEBHeightTo_Click;
            // 
            // popEBSetPrice
            // 
            popEBSetPrice.Name = "popEBSetPrice";
            popEBSetPrice.Size = new System.Drawing.Size(235, 22);
            popEBSetPrice.Text = "Set Price";
            popEBSetPrice.Click += BtnEBPriceTo_Click;
            // 
            // popEBSetTaxRate
            // 
            popEBSetTaxRate.Name = "popEBSetTaxRate";
            popEBSetTaxRate.Size = new System.Drawing.Size(235, 22);
            popEBSetTaxRate.Text = "Set Tax Rate";
            popEBSetTaxRate.Click += BtnEBTaxRateTo_Click;
            // 
            // popEBSetToUpperCase
            // 
            popEBSetToUpperCase.Name = "popEBSetToUpperCase";
            popEBSetToUpperCase.Size = new System.Drawing.Size(235, 22);
            popEBSetToUpperCase.Text = "Set To UPPERCASE";
            popEBSetToUpperCase.Click += BtnSetUpperCase_Click;
            // 
            // popEBSetToLowercase
            // 
            popEBSetToLowercase.Name = "popEBSetToLowercase";
            popEBSetToLowercase.Size = new System.Drawing.Size(235, 22);
            popEBSetToLowercase.Text = "Set To lowercase";
            popEBSetToLowercase.Click += BtnSetToLowerCase_Click;
            // 
            // popSetSentenceCase
            // 
            popSetSentenceCase.Name = "popSetSentenceCase";
            popSetSentenceCase.Size = new System.Drawing.Size(235, 22);
            popSetSentenceCase.Text = "Set To Sentence Case";
            popSetSentenceCase.Click += BtnSetSentenceCase_Click;
            // 
            // popEBMoveTo
            // 
            popEBMoveTo.Name = "popEBMoveTo";
            popEBMoveTo.Size = new System.Drawing.Size(235, 22);
            popEBMoveTo.Text = "Move To Category";
            popEBMoveTo.Click += BtnMoveToEntity_Click;
            // 
            // popEBReOrder
            // 
            popEBReOrder.Name = "popEBReOrder";
            popEBReOrder.Size = new System.Drawing.Size(235, 22);
            popEBReOrder.Text = "ReOrder";
            popEBReOrder.Click += BtnReOrder_Click;
            // 
            // popEBDuplicate
            // 
            popEBDuplicate.Name = "popEBDuplicate";
            popEBDuplicate.Size = new System.Drawing.Size(235, 22);
            popEBDuplicate.Text = "Duplicate";
            popEBDuplicate.Click += BtnDuplicate_Click;
            // 
            // popEBConvertToStockItem
            // 
            popEBConvertToStockItem.Name = "popEBConvertToStockItem";
            popEBConvertToStockItem.Size = new System.Drawing.Size(235, 22);
            popEBConvertToStockItem.Text = "Convert To Stock Item";
            popEBConvertToStockItem.Click += BtnConvertToStockItem_Click;
            // 
            // popSetAllForeColourTo
            // 
            popSetAllForeColourTo.Name = "popSetAllForeColourTo";
            popSetAllForeColourTo.Size = new System.Drawing.Size(235, 22);
            popSetAllForeColourTo.Text = "Set ForeColour";
            popSetAllForeColourTo.Click += BtnSetAllForeColourTo_Click;
            // 
            // popSetAllBackColourTo
            // 
            popSetAllBackColourTo.Name = "popSetAllBackColourTo";
            popSetAllBackColourTo.Size = new System.Drawing.Size(235, 22);
            popSetAllBackColourTo.Text = "Set BackColour";
            popSetAllBackColourTo.Click += BtnSetAllBackColourTo_Click;
            // 
            // popSetAllBackColourToTransparent
            // 
            popSetAllBackColourToTransparent.Name = "popSetAllBackColourToTransparent";
            popSetAllBackColourToTransparent.Size = new System.Drawing.Size(235, 22);
            popSetAllBackColourToTransparent.Text = "Set BackColour To Transparent";
            popSetAllBackColourToTransparent.Click += BtnSetAllBackColourToTransparent_Click;
            // 
            // popSetAllDistributionTo
            // 
            popSetAllDistributionTo.Name = "popSetAllDistributionTo";
            popSetAllDistributionTo.Size = new System.Drawing.Size(235, 22);
            popSetAllDistributionTo.Text = "Set Distribution";
            popSetAllDistributionTo.Click += BtnChangeDistributionForEB_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottom.Location = new System.Drawing.Point(0, 769);
            pnlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(3183, 12);
            pnlBottom.TabIndex = 3;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.AllowUserToAddRows = false;
            dgvSearchResults.AllowUserToDeleteRows = false;
            dgvSearchResults.AutoGenerateColumns = false;
            dgvSearchResults.BackgroundColor = System.Drawing.Color.White;
            dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colDisplayImageSearch, colIIDSearch, colEntityButtonNameSearch, colEntityNameSearch });
            dgvSearchResults.DataSource = entityButtonSearchResultBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvSearchResults.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSearchResults.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvSearchResults.Location = new System.Drawing.Point(4, 42);
            dgvSearchResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvSearchResults.MultiSelect = false;
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.ReadOnly = true;
            dgvSearchResults.RowHeadersWidth = 25;
            dgvSearchResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvSearchResults.RowTemplate.Height = 40;
            dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSearchResults.Size = new System.Drawing.Size(2934, 686);
            dgvSearchResults.TabIndex = 1;
            dgvSearchResults.CellDoubleClick += DgvSearchResults_CellDoubleClick;
            dgvSearchResults.SelectionChanged += DgvSearchResults_SelectionChanged;
            // 
            // colDisplayImageSearch
            // 
            colDisplayImageSearch.DataPropertyName = "DisplayImage";
            colDisplayImageSearch.HeaderText = "Image";
            colDisplayImageSearch.Name = "colDisplayImageSearch";
            colDisplayImageSearch.ReadOnly = true;
            colDisplayImageSearch.Width = 150;
            // 
            // colIIDSearch
            // 
            colIIDSearch.DataPropertyName = "IID";
            colIIDSearch.HeaderText = "IID";
            colIIDSearch.Name = "colIIDSearch";
            colIIDSearch.ReadOnly = true;
            colIIDSearch.Visible = false;
            // 
            // colEntityButtonNameSearch
            // 
            colEntityButtonNameSearch.DataPropertyName = "EntityButtonName";
            colEntityButtonNameSearch.HeaderText = "EntityButtonName";
            colEntityButtonNameSearch.Name = "colEntityButtonNameSearch";
            colEntityButtonNameSearch.ReadOnly = true;
            colEntityButtonNameSearch.Width = 150;
            // 
            // colEntityNameSearch
            // 
            colEntityNameSearch.DataPropertyName = "EntityName";
            colEntityNameSearch.HeaderText = "EntityName";
            colEntityNameSearch.Name = "colEntityNameSearch";
            colEntityNameSearch.ReadOnly = true;
            colEntityNameSearch.Width = 150;
            // 
            // entityButtonSearchResultBindingSource
            // 
            entityButtonSearchResultBindingSource.DataSource = typeof(EntityButtonSearchResult);
            // 
            // pnlSearchImagePanel
            // 
            pnlSearchImagePanel.BackColor = System.Drawing.Color.White;
            pnlSearchImagePanel.Controls.Add(pBoxSearchItem);
            pnlSearchImagePanel.Dock = System.Windows.Forms.DockStyle.Right;
            pnlSearchImagePanel.Location = new System.Drawing.Point(2938, 42);
            pnlSearchImagePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlSearchImagePanel.Name = "pnlSearchImagePanel";
            pnlSearchImagePanel.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            pnlSearchImagePanel.Size = new System.Drawing.Size(233, 686);
            pnlSearchImagePanel.TabIndex = 2;
            // 
            // pBoxSearchItem
            // 
            pBoxSearchItem.Dock = System.Windows.Forms.DockStyle.Top;
            pBoxSearchItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pBoxSearchItem.Location = new System.Drawing.Point(0, 12);
            pBoxSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pBoxSearchItem.Name = "pBoxSearchItem";
            pBoxSearchItem.Size = new System.Drawing.Size(233, 288);
            pBoxSearchItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxSearchItem.TabIndex = 0;
            pBoxSearchItem.TabStop = false;
            // 
            // tabMain
            // 
            tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabMain.Controls.Add(tabMenus);
            tabMain.Controls.Add(tabSearchCategoryItems);
            tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMain.ItemSize = new System.Drawing.Size(180, 30);
            tabMain.Location = new System.Drawing.Point(0, 0);
            tabMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new System.Drawing.Size(3183, 769);
            tabMain.TabIndex = 13;
            // 
            // tabMenus
            // 
            tabMenus.Controls.Add(pnlRight);
            tabMenus.Controls.Add(expanderMIddle);
            tabMenus.Controls.Add(pnlLeft);
            tabMenus.Location = new System.Drawing.Point(4, 34);
            tabMenus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMenus.Name = "tabMenus";
            tabMenus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMenus.Size = new System.Drawing.Size(3175, 731);
            tabMenus.TabIndex = 2;
            tabMenus.Text = "MENUS";
            tabMenus.UseVisualStyleBackColor = true;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(pnlRightBottom);
            pnlRight.Controls.Add(expanderRight);
            pnlRight.Controls.Add(pnlRightTop);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRight.Location = new System.Drawing.Point(1578, 3);
            pnlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(1593, 725);
            pnlRight.TabIndex = 8;
            // 
            // pnlRightBottom
            // 
            pnlRightBottom.Controls.Add(dgvStockItems);
            pnlRightBottom.Controls.Add(pnlEBPicture);
            pnlRightBottom.Controls.Add(barStockUsage);
            pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRightBottom.Location = new System.Drawing.Point(0, 485);
            pnlRightBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlRightBottom.Name = "pnlRightBottom";
            pnlRightBottom.Size = new System.Drawing.Size(1593, 240);
            pnlRightBottom.TabIndex = 2;
            // 
            // dgvStockItems
            // 
            dgvStockItems.AllowDrop = true;
            dgvStockItems.AllowUserToAddRows = false;
            dgvStockItems.AllowUserToDeleteRows = false;
            dgvStockItems.AutoGenerateColumns = false;
            dgvStockItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvStockItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvStockItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStockUsageIID, colEBIID, colStockItemIID, Quantity, QuantityTypeAsString, StockName, Comment, colEBSItemDisplayOrder });
            dgvStockItems.DataSource = entityButtonStockItemLookUpBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvStockItems.DefaultCellStyle = dataGridViewCellStyle7;
            dgvStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStockItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvStockItems.Location = new System.Drawing.Point(163, 54);
            dgvStockItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvStockItems.Name = "dgvStockItems";
            dgvStockItems.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvStockItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvStockItems.RowHeadersWidth = 25;
            dgvStockItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvStockItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStockItems.Size = new System.Drawing.Size(1430, 186);
            dgvStockItems.TabIndex = 11;
            dgvStockItems.CellDoubleClick += DgvStockItems_CellDoubleClick;
            dgvStockItems.DragDrop += DgvStockItems_DragDrop;
            dgvStockItems.DragOver += Dgv_DragOver;
            dgvStockItems.MouseDown += Dgv_MouseDown;
            dgvStockItems.MouseMove += Dgv_MouseMove;
            // 
            // colStockUsageIID
            // 
            colStockUsageIID.DataPropertyName = "IID";
            colStockUsageIID.HeaderText = "IID";
            colStockUsageIID.Name = "colStockUsageIID";
            colStockUsageIID.ReadOnly = true;
            colStockUsageIID.Visible = false;
            colStockUsageIID.Width = 5;
            // 
            // colEBIID
            // 
            colEBIID.DataPropertyName = "EntityButtonIID";
            colEBIID.HeaderText = "EBIID";
            colEBIID.Name = "colEBIID";
            colEBIID.ReadOnly = true;
            colEBIID.Visible = false;
            // 
            // colStockItemIID
            // 
            colStockItemIID.DataPropertyName = "StockItemIID";
            colStockItemIID.HeaderText = "StockItemIID";
            colStockItemIID.Name = "colStockItemIID";
            colStockItemIID.ReadOnly = true;
            colStockItemIID.Visible = false;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle5;
            Quantity.HeaderText = "Stock Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 120;
            // 
            // QuantityTypeAsString
            // 
            QuantityTypeAsString.DataPropertyName = "QuantityTypeAsString";
            QuantityTypeAsString.HeaderText = "Quantity Type";
            QuantityTypeAsString.Name = "QuantityTypeAsString";
            QuantityTypeAsString.ReadOnly = true;
            // 
            // StockName
            // 
            StockName.DataPropertyName = "StockName";
            StockName.HeaderText = "Stock Item";
            StockName.Name = "StockName";
            StockName.ReadOnly = true;
            StockName.Width = 150;
            // 
            // Comment
            // 
            Comment.DataPropertyName = "Comment";
            Comment.HeaderText = "Comment";
            Comment.Name = "Comment";
            Comment.ReadOnly = true;
            Comment.Width = 150;
            // 
            // colEBSItemDisplayOrder
            // 
            colEBSItemDisplayOrder.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colEBSItemDisplayOrder.DefaultCellStyle = dataGridViewCellStyle6;
            colEBSItemDisplayOrder.HeaderText = "Order";
            colEBSItemDisplayOrder.Name = "colEBSItemDisplayOrder";
            colEBSItemDisplayOrder.ReadOnly = true;
            colEBSItemDisplayOrder.ToolTipText = "Display Order";
            colEBSItemDisplayOrder.Width = 50;
            // 
            // entityButtonStockItemLookUpBindingSource
            // 
            entityButtonStockItemLookUpBindingSource.DataSource = typeof(EntityButtonStockItemLookUp);
            // 
            // pnlEBPicture
            // 
            pnlEBPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            pnlEBPicture.Controls.Add(pboxEBPicture);
            pnlEBPicture.Controls.Add(btnEBSample);
            pnlEBPicture.Dock = System.Windows.Forms.DockStyle.Left;
            pnlEBPicture.Location = new System.Drawing.Point(0, 54);
            pnlEBPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlEBPicture.Name = "pnlEBPicture";
            pnlEBPicture.Size = new System.Drawing.Size(163, 186);
            pnlEBPicture.TabIndex = 10;
            // 
            // pboxEBPicture
            // 
            pboxEBPicture.BackColor = System.Drawing.Color.White;
            pboxEBPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            pboxEBPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pboxEBPicture.Location = new System.Drawing.Point(0, 185);
            pboxEBPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pboxEBPicture.Name = "pboxEBPicture";
            pboxEBPicture.Size = new System.Drawing.Size(163, 1);
            pboxEBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pboxEBPicture.TabIndex = 10;
            pboxEBPicture.TabStop = false;
            pboxEBPicture.DoubleClick += pboxEBPicture_DoubleClick;
            // 
            // btnEBSample
            // 
            btnEBSample.BackColor = System.Drawing.Color.White;
            btnEBSample.Dock = System.Windows.Forms.DockStyle.Top;
            btnEBSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEBSample.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnEBSample.Location = new System.Drawing.Point(0, 0);
            btnEBSample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEBSample.Name = "btnEBSample";
            btnEBSample.Size = new System.Drawing.Size(163, 185);
            btnEBSample.TabIndex = 9;
            btnEBSample.UseVisualStyleBackColor = false;
            // 
            // barStockUsage
            // 
            barStockUsage.Enabled = false;
            barStockUsage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddStockItem, btnEditStockItem, btnDeleteStockItem, btnZoomStockUsage, btnReorderStockUsage, btnCopyStockUsageItems, btnPasteStockUsageItems, btnPasteSpecialStockUsageItems, lblImageSize, btnQuantityToComment, tsSortStockItem, tsMoveUpStockItem, tsMoveDownStockItem });
            barStockUsage.Location = new System.Drawing.Point(0, 0);
            barStockUsage.Name = "barStockUsage";
            barStockUsage.Size = new System.Drawing.Size(1593, 54);
            barStockUsage.TabIndex = 1;
            barStockUsage.Text = "toolStrip1";
            // 
            // btnAddStockItem
            // 
            btnAddStockItem.Image = Properties.Resources.arti32;
            btnAddStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddStockItem.Name = "btnAddStockItem";
            btnAddStockItem.Size = new System.Drawing.Size(51, 51);
            btnAddStockItem.Text = "   Add   ";
            btnAddStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddStockItem.Click += BtnAddStockItem_Click;
            // 
            // btnEditStockItem
            // 
            btnEditStockItem.Image = Properties.Resources.MatReport_32;
            btnEditStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditStockItem.Name = "btnEditStockItem";
            btnEditStockItem.Size = new System.Drawing.Size(43, 51);
            btnEditStockItem.Text = "  Edit  ";
            btnEditStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEditStockItem.Click += BtnEditStockItem_Click;
            // 
            // btnDeleteStockItem
            // 
            btnDeleteStockItem.Image = Properties.Resources.eksi32;
            btnDeleteStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteStockItem.Name = "btnDeleteStockItem";
            btnDeleteStockItem.Size = new System.Drawing.Size(50, 51);
            btnDeleteStockItem.Text = " Delete ";
            btnDeleteStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteStockItem.Click += BtnDeleteStockItem_Click;
            // 
            // btnZoomStockUsage
            // 
            btnZoomStockUsage.Image = Properties.Resources.View32;
            btnZoomStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnZoomStockUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnZoomStockUsage.Name = "btnZoomStockUsage";
            btnZoomStockUsage.Size = new System.Drawing.Size(43, 51);
            btnZoomStockUsage.Text = "Zoom";
            btnZoomStockUsage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnZoomStockUsage.Click += BtnZoomStockUsage_Click;
            // 
            // btnReorderStockUsage
            // 
            btnReorderStockUsage.Image = Properties.Resources.ExpandHeight32;
            btnReorderStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReorderStockUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReorderStockUsage.Name = "btnReorderStockUsage";
            btnReorderStockUsage.Size = new System.Drawing.Size(54, 51);
            btnReorderStockUsage.Text = "ReOrder";
            btnReorderStockUsage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReorderStockUsage.Click += BtnReorderStockUsage_Click;
            // 
            // btnCopyStockUsageItems
            // 
            btnCopyStockUsageItems.Image = Properties.Resources.WindowCascade;
            btnCopyStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCopyStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyStockUsageItems.Name = "btnCopyStockUsageItems";
            btnCopyStockUsageItems.Size = new System.Drawing.Size(71, 51);
            btnCopyStockUsageItems.Text = "Copy Items";
            btnCopyStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyStockUsageItems.Click += BtnCopyStockUsageItems_Click;
            // 
            // btnPasteStockUsageItems
            // 
            btnPasteStockUsageItems.Image = Properties.Resources.Paste232;
            btnPasteStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPasteStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPasteStockUsageItems.Name = "btnPasteStockUsageItems";
            btnPasteStockUsageItems.Size = new System.Drawing.Size(71, 51);
            btnPasteStockUsageItems.Text = "Paste Items";
            btnPasteStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPasteStockUsageItems.Click += BtnPasteStockUsageItems_Click;
            // 
            // btnPasteSpecialStockUsageItems
            // 
            btnPasteSpecialStockUsageItems.Image = Properties.Resources.Paste232;
            btnPasteSpecialStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPasteSpecialStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPasteSpecialStockUsageItems.Name = "btnPasteSpecialStockUsageItems";
            btnPasteSpecialStockUsageItems.Size = new System.Drawing.Size(125, 51);
            btnPasteSpecialStockUsageItems.Text = "Paste And Keep Items";
            btnPasteSpecialStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPasteSpecialStockUsageItems.Click += BtnPasteSpecialStockUsageItems_Click;
            // 
            // lblImageSize
            // 
            lblImageSize.Name = "lblImageSize";
            lblImageSize.Size = new System.Drawing.Size(24, 51);
            lblImageSize.Text = "0x0";
            // 
            // btnQuantityToComment
            // 
            btnQuantityToComment.Image = Properties.Resources.copy_black_24dp1;
            btnQuantityToComment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnQuantityToComment.Name = "btnQuantityToComment";
            btnQuantityToComment.Size = new System.Drawing.Size(63, 51);
            btnQuantityToComment.Text = "Q to Com";
            btnQuantityToComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnQuantityToComment.Click += btnQuantityToComment_Click;
            // 
            // tsSortStockItem
            // 
            tsSortStockItem.AutoSize = false;
            tsSortStockItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSortStockItem.Image = Properties.Resources.updown;
            tsSortStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSortStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSortStockItem.Name = "tsSortStockItem";
            tsSortStockItem.Size = new System.Drawing.Size(60, 51);
            tsSortStockItem.Text = "toolStripButton1";
            // 
            // tsMoveUpStockItem
            // 
            tsMoveUpStockItem.AutoSize = false;
            tsMoveUpStockItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUpStockItem.Image = Properties.Resources.up2;
            tsMoveUpStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUpStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUpStockItem.Name = "tsMoveUpStockItem";
            tsMoveUpStockItem.Size = new System.Drawing.Size(60, 51);
            tsMoveUpStockItem.Text = "toolStripButton1";
            // 
            // tsMoveDownStockItem
            // 
            tsMoveDownStockItem.AutoSize = false;
            tsMoveDownStockItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDownStockItem.Image = Properties.Resources.down2;
            tsMoveDownStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDownStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDownStockItem.Name = "tsMoveDownStockItem";
            tsMoveDownStockItem.Size = new System.Drawing.Size(60, 51);
            tsMoveDownStockItem.Text = "toolStripButton1";
            // 
            // expanderRight
            // 
            expanderRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expanderRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expanderRight.Caption = "";
            expanderRight.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expanderRight.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            expanderRight.CaptionForeColor = System.Drawing.Color.White;
            expanderRight.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            expanderRight.ColourFixed = System.Drawing.Color.Salmon;
            expanderRight.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expanderRight.Dock = System.Windows.Forms.DockStyle.Top;
            expanderRight.ExpandableControl = pnlRightTop;
            expanderRight.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expanderRight.Expanded = true;
            expanderRight.Fixed = false;
            expanderRight.Location = new System.Drawing.Point(0, 462);
            expanderRight.LockButtonDock = System.Windows.Forms.DockStyle.Left;
            expanderRight.LockButtonSize = new System.Drawing.Size(37, 28);
            expanderRight.LockButtonVisible = false;
            expanderRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expanderRight.MinimumSize = new System.Drawing.Size(6, 5);
            expanderRight.Name = "expanderRight";
            expanderRight.Size = new System.Drawing.Size(1593, 23);
            expanderRight.TabIndex = 1;
            // 
            // pnlRightTop
            // 
            pnlRightTop.Controls.Add(dgvCategoryItem);
            pnlRightTop.Controls.Add(barEntityButton);
            pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlRightTop.Location = new System.Drawing.Point(0, 0);
            pnlRightTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlRightTop.Name = "pnlRightTop";
            pnlRightTop.Size = new System.Drawing.Size(1593, 462);
            pnlRightTop.TabIndex = 0;
            // 
            // dgvCategoryItem
            // 
            dgvCategoryItem.AllowDrop = true;
            dgvCategoryItem.AllowUserToAddRows = false;
            dgvCategoryItem.AllowUserToDeleteRows = false;
            dgvCategoryItem.AllowUserToOrderColumns = true;
            dgvCategoryItem.AutoGenerateColumns = false;
            dgvCategoryItem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvCategoryItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colEBDisplayImage, ItemName, colEntityButtonIID, colEBWidth, colEBHeight, colEBDistributionName, colEBFont, buttonTypeDataGridViewTextBoxColumn, colEBDirectSalePrice, colEBInHousePrice, colEBTakeAwayPrice, colEBDeliveryPrice, colEBDirectSaleTaxPercent, colEBInHouseTaxPercent, colEBTakeAwayTaxPercent, colEBDeliveryTaxPercent, colEBDisplayOrder });
            dgvCategoryItem.ContextMenuStrip = popEntityButton;
            dgvCategoryItem.DataSource = categoryItemBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategoryItem.DefaultCellStyle = dataGridViewCellStyle19;
            dgvCategoryItem.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategoryItem.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvCategoryItem.Location = new System.Drawing.Point(0, 54);
            dgvCategoryItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvCategoryItem.Name = "dgvCategoryItem";
            dgvCategoryItem.ReadOnly = true;
            dgvCategoryItem.RowHeadersWidth = 25;
            dgvCategoryItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvCategoryItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgvCategoryItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryItem.Size = new System.Drawing.Size(1593, 408);
            dgvCategoryItem.TabIndex = 0;
            dgvCategoryItem.CellDoubleClick += DgvEntityButton_CellDoubleClick;
            dgvCategoryItem.SelectionChanged += DgvEntityButton_SelectionChanged;
            dgvCategoryItem.DragDrop += DgvEntityButton_DragDrop;
            dgvCategoryItem.DragOver += Dgv_DragOver;
            dgvCategoryItem.MouseDown += Dgv_MouseDown;
            dgvCategoryItem.MouseMove += Dgv_MouseMove;
            // 
            // colEBDisplayImage
            // 
            colEBDisplayImage.DataPropertyName = "DisplayImage";
            colEBDisplayImage.HeaderText = "Image";
            colEBDisplayImage.Name = "colEBDisplayImage";
            colEBDisplayImage.ReadOnly = true;
            colEBDisplayImage.Width = 80;
            // 
            // ItemName
            // 
            ItemName.DataPropertyName = "ItemName";
            ItemName.HeaderText = "ItemName";
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            // 
            // colEntityButtonIID
            // 
            colEntityButtonIID.DataPropertyName = "IID";
            colEntityButtonIID.HeaderText = "IID";
            colEntityButtonIID.Name = "colEntityButtonIID";
            colEntityButtonIID.ReadOnly = true;
            colEntityButtonIID.Visible = false;
            // 
            // colEBWidth
            // 
            colEBWidth.DataPropertyName = "Width";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0\" px\"";
            colEBWidth.DefaultCellStyle = dataGridViewCellStyle9;
            colEBWidth.HeaderText = "Width";
            colEBWidth.Name = "colEBWidth";
            colEBWidth.ReadOnly = true;
            colEBWidth.Visible = false;
            colEBWidth.Width = 50;
            // 
            // colEBHeight
            // 
            colEBHeight.DataPropertyName = "Height";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "0\" px\"";
            colEBHeight.DefaultCellStyle = dataGridViewCellStyle10;
            colEBHeight.HeaderText = "Height";
            colEBHeight.Name = "colEBHeight";
            colEBHeight.ReadOnly = true;
            colEBHeight.Visible = false;
            colEBHeight.Width = 50;
            // 
            // colEBDistributionName
            // 
            colEBDistributionName.DataPropertyName = "DistributionName";
            colEBDistributionName.HeaderText = "Distribution";
            colEBDistributionName.Name = "colEBDistributionName";
            colEBDistributionName.ReadOnly = true;
            colEBDistributionName.Width = 170;
            // 
            // colEBFont
            // 
            colEBFont.DataPropertyName = "FFamily";
            colEBFont.HeaderText = "Font";
            colEBFont.Name = "colEBFont";
            colEBFont.ReadOnly = true;
            // 
            // buttonTypeDataGridViewTextBoxColumn
            // 
            buttonTypeDataGridViewTextBoxColumn.DataPropertyName = "ButtonType";
            buttonTypeDataGridViewTextBoxColumn.HeaderText = "ButtonType";
            buttonTypeDataGridViewTextBoxColumn.Name = "buttonTypeDataGridViewTextBoxColumn";
            buttonTypeDataGridViewTextBoxColumn.ReadOnly = true;
            buttonTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // colEBDirectSalePrice
            // 
            colEBDirectSalePrice.DataPropertyName = "SalePrice";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "c2";
            dataGridViewCellStyle11.NullValue = null;
            colEBDirectSalePrice.DefaultCellStyle = dataGridViewCellStyle11;
            colEBDirectSalePrice.HeaderText = "DS Price";
            colEBDirectSalePrice.Name = "colEBDirectSalePrice";
            colEBDirectSalePrice.ReadOnly = true;
            colEBDirectSalePrice.ToolTipText = "Direct Sale Price";
            colEBDirectSalePrice.Width = 75;
            // 
            // colEBInHousePrice
            // 
            colEBInHousePrice.DataPropertyName = "SitinPrice";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "c2";
            colEBInHousePrice.DefaultCellStyle = dataGridViewCellStyle12;
            colEBInHousePrice.HeaderText = "IH Price";
            colEBInHousePrice.Name = "colEBInHousePrice";
            colEBInHousePrice.ReadOnly = true;
            colEBInHousePrice.ToolTipText = "InHouse Price";
            colEBInHousePrice.Width = 75;
            // 
            // colEBTakeAwayPrice
            // 
            colEBTakeAwayPrice.DataPropertyName = "TaPrice";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "c2";
            colEBTakeAwayPrice.DefaultCellStyle = dataGridViewCellStyle13;
            colEBTakeAwayPrice.HeaderText = "TA Price";
            colEBTakeAwayPrice.Name = "colEBTakeAwayPrice";
            colEBTakeAwayPrice.ReadOnly = true;
            colEBTakeAwayPrice.ToolTipText = "Take Away Price";
            colEBTakeAwayPrice.Width = 75;
            // 
            // colEBDeliveryPrice
            // 
            colEBDeliveryPrice.DataPropertyName = "DPrice";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "c2";
            colEBDeliveryPrice.DefaultCellStyle = dataGridViewCellStyle14;
            colEBDeliveryPrice.HeaderText = "DL Price";
            colEBDeliveryPrice.Name = "colEBDeliveryPrice";
            colEBDeliveryPrice.ReadOnly = true;
            colEBDeliveryPrice.ToolTipText = "Delivery Price";
            colEBDeliveryPrice.Width = 75;
            // 
            // colEBDirectSaleTaxPercent
            // 
            colEBDirectSaleTaxPercent.DataPropertyName = "SaleTax";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "0\" %\"";
            dataGridViewCellStyle15.NullValue = null;
            colEBDirectSaleTaxPercent.DefaultCellStyle = dataGridViewCellStyle15;
            colEBDirectSaleTaxPercent.HeaderText = "DS Tax%";
            colEBDirectSaleTaxPercent.Name = "colEBDirectSaleTaxPercent";
            colEBDirectSaleTaxPercent.ReadOnly = true;
            colEBDirectSaleTaxPercent.ToolTipText = "Direct Sale Tax";
            colEBDirectSaleTaxPercent.Width = 80;
            // 
            // colEBInHouseTaxPercent
            // 
            colEBInHouseTaxPercent.DataPropertyName = "SitinTax";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "0\" %\"";
            colEBInHouseTaxPercent.DefaultCellStyle = dataGridViewCellStyle16;
            colEBInHouseTaxPercent.HeaderText = "IH Tax%";
            colEBInHouseTaxPercent.Name = "colEBInHouseTaxPercent";
            colEBInHouseTaxPercent.ReadOnly = true;
            colEBInHouseTaxPercent.ToolTipText = "InHouse Tax";
            colEBInHouseTaxPercent.Width = 80;
            // 
            // colEBTakeAwayTaxPercent
            // 
            colEBTakeAwayTaxPercent.DataPropertyName = "TaTax";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "0\" %\"";
            colEBTakeAwayTaxPercent.DefaultCellStyle = dataGridViewCellStyle17;
            colEBTakeAwayTaxPercent.HeaderText = "TA Tax%";
            colEBTakeAwayTaxPercent.Name = "colEBTakeAwayTaxPercent";
            colEBTakeAwayTaxPercent.ReadOnly = true;
            colEBTakeAwayTaxPercent.ToolTipText = "TakeAway Tax";
            colEBTakeAwayTaxPercent.Width = 80;
            // 
            // colEBDeliveryTaxPercent
            // 
            colEBDeliveryTaxPercent.DataPropertyName = "DTax";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "0\" %\"";
            colEBDeliveryTaxPercent.DefaultCellStyle = dataGridViewCellStyle18;
            colEBDeliveryTaxPercent.HeaderText = "DL Tax%";
            colEBDeliveryTaxPercent.Name = "colEBDeliveryTaxPercent";
            colEBDeliveryTaxPercent.ReadOnly = true;
            colEBDeliveryTaxPercent.ToolTipText = "Delivery Tax";
            colEBDeliveryTaxPercent.Width = 80;
            // 
            // colEBDisplayOrder
            // 
            colEBDisplayOrder.DataPropertyName = "DOrder";
            colEBDisplayOrder.HeaderText = "Order";
            colEBDisplayOrder.Name = "colEBDisplayOrder";
            colEBDisplayOrder.ReadOnly = true;
            colEBDisplayOrder.ToolTipText = "Display Order";
            colEBDisplayOrder.Width = 50;
            // 
            // categoryItemBindingSource
            // 
            categoryItemBindingSource.DataSource = typeof(CategoryItem);
            // 
            // barEntityButton
            // 
            barEntityButton.Enabled = false;
            barEntityButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddEntityButton, btnEditEntityButton, btnDeleteEntityButton, btnZoomEntityButton, btnSetAll, btnMoveToEntity, btnReOrder, btnDuplicate, btnConvertToStockItem, btnEntityButtonRowHeight, tsSortCategoryItem, tsMoveUpCategoryItem, tsMoveDownCategoryItem });
            barEntityButton.Location = new System.Drawing.Point(0, 0);
            barEntityButton.Name = "barEntityButton";
            barEntityButton.Size = new System.Drawing.Size(1593, 54);
            barEntityButton.TabIndex = 0;
            barEntityButton.Text = "toolStrip1";
            // 
            // btnAddEntityButton
            // 
            btnAddEntityButton.Image = Properties.Resources.arti32;
            btnAddEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddEntityButton.Name = "btnAddEntityButton";
            btnAddEntityButton.Size = new System.Drawing.Size(45, 51);
            btnAddEntityButton.Text = "  Add  ";
            btnAddEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddEntityButton.Click += BtnAddEntityButton_Click;
            // 
            // btnEditEntityButton
            // 
            btnEditEntityButton.Image = Properties.Resources.MatReport_32;
            btnEditEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditEntityButton.Name = "btnEditEntityButton";
            btnEditEntityButton.Size = new System.Drawing.Size(43, 51);
            btnEditEntityButton.Text = "  Edit  ";
            btnEditEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEditEntityButton.Click += BtnEditEntityButton_Click;
            // 
            // btnDeleteEntityButton
            // 
            btnDeleteEntityButton.Image = Properties.Resources.eksi32;
            btnDeleteEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteEntityButton.Name = "btnDeleteEntityButton";
            btnDeleteEntityButton.Size = new System.Drawing.Size(50, 51);
            btnDeleteEntityButton.Text = " Delete ";
            btnDeleteEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteEntityButton.Click += BtnDeleteEntityButton_Click;
            // 
            // btnZoomEntityButton
            // 
            btnZoomEntityButton.Image = Properties.Resources.View32;
            btnZoomEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnZoomEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnZoomEntityButton.Name = "btnZoomEntityButton";
            btnZoomEntityButton.Size = new System.Drawing.Size(55, 51);
            btnZoomEntityButton.Text = "  Zoom  ";
            btnZoomEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnZoomEntityButton.Click += BtnZoomEntityButton_Click;
            // 
            // btnSetAll
            // 
            btnSetAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnEBFontTo, btnEBWidthTo, btnEBHeightTo, btnEBPriceTo, btnEBTaxRateTo, btnSetUpperCase, btnSetToLowerCase, btnSetSentenceCase, btnSetAllForeColourTo, btnSetAllBackColourTo, btnSetAllBackColourToTransparent, btnChangeDistributionForEB });
            btnSetAll.Image = Properties.Resources.disli32;
            btnSetAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSetAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSetAll.Name = "btnSetAll";
            btnSetAll.Size = new System.Drawing.Size(68, 51);
            btnSetAll.Text = " SET ALL ";
            btnSetAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnEBFontTo
            // 
            btnEBFontTo.Name = "btnEBFontTo";
            btnEBFontTo.Size = new System.Drawing.Size(216, 22);
            btnEBFontTo.Text = "Font To";
            btnEBFontTo.Click += BtnEBFontTo_Click;
            // 
            // btnEBWidthTo
            // 
            btnEBWidthTo.Name = "btnEBWidthTo";
            btnEBWidthTo.Size = new System.Drawing.Size(216, 22);
            btnEBWidthTo.Text = "Width To";
            btnEBWidthTo.Click += BtnEBWidthTo_Click;
            // 
            // btnEBHeightTo
            // 
            btnEBHeightTo.Name = "btnEBHeightTo";
            btnEBHeightTo.Size = new System.Drawing.Size(216, 22);
            btnEBHeightTo.Text = "Height To";
            btnEBHeightTo.Click += BtnEBHeightTo_Click;
            // 
            // btnEBPriceTo
            // 
            btnEBPriceTo.Name = "btnEBPriceTo";
            btnEBPriceTo.Size = new System.Drawing.Size(216, 22);
            btnEBPriceTo.Text = "Price To";
            btnEBPriceTo.Click += BtnEBPriceTo_Click;
            // 
            // btnEBTaxRateTo
            // 
            btnEBTaxRateTo.Name = "btnEBTaxRateTo";
            btnEBTaxRateTo.Size = new System.Drawing.Size(216, 22);
            btnEBTaxRateTo.Text = "Tax Rate To";
            btnEBTaxRateTo.Click += BtnEBTaxRateTo_Click;
            // 
            // btnSetUpperCase
            // 
            btnSetUpperCase.Name = "btnSetUpperCase";
            btnSetUpperCase.Size = new System.Drawing.Size(216, 22);
            btnSetUpperCase.Text = "Set To UPPER CASE";
            btnSetUpperCase.Click += BtnSetUpperCase_Click;
            // 
            // btnSetToLowerCase
            // 
            btnSetToLowerCase.Name = "btnSetToLowerCase";
            btnSetToLowerCase.Size = new System.Drawing.Size(216, 22);
            btnSetToLowerCase.Text = "Set To lower case";
            btnSetToLowerCase.Click += BtnSetToLowerCase_Click;
            // 
            // btnSetSentenceCase
            // 
            btnSetSentenceCase.Name = "btnSetSentenceCase";
            btnSetSentenceCase.Size = new System.Drawing.Size(216, 22);
            btnSetSentenceCase.Text = "Set To Sentence Case";
            btnSetSentenceCase.Click += BtnSetSentenceCase_Click;
            // 
            // btnSetAllForeColourTo
            // 
            btnSetAllForeColourTo.Name = "btnSetAllForeColourTo";
            btnSetAllForeColourTo.Size = new System.Drawing.Size(216, 22);
            btnSetAllForeColourTo.Text = "ForeColour To";
            btnSetAllForeColourTo.Click += BtnSetAllForeColourTo_Click;
            // 
            // btnSetAllBackColourTo
            // 
            btnSetAllBackColourTo.Name = "btnSetAllBackColourTo";
            btnSetAllBackColourTo.Size = new System.Drawing.Size(216, 22);
            btnSetAllBackColourTo.Text = "BackColour To";
            btnSetAllBackColourTo.Click += BtnSetAllBackColourTo_Click;
            // 
            // btnSetAllBackColourToTransparent
            // 
            btnSetAllBackColourToTransparent.Name = "btnSetAllBackColourToTransparent";
            btnSetAllBackColourToTransparent.Size = new System.Drawing.Size(216, 22);
            btnSetAllBackColourToTransparent.Text = "BackColour To Transparent";
            btnSetAllBackColourToTransparent.Click += BtnSetAllBackColourToTransparent_Click;
            // 
            // btnChangeDistributionForEB
            // 
            btnChangeDistributionForEB.Name = "btnChangeDistributionForEB";
            btnChangeDistributionForEB.Size = new System.Drawing.Size(216, 22);
            btnChangeDistributionForEB.Text = "Distribution To";
            btnChangeDistributionForEB.Click += BtnChangeDistributionForEB_Click;
            // 
            // btnMoveToEntity
            // 
            btnMoveToEntity.Image = Properties.Resources.Curve;
            btnMoveToEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnMoveToEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMoveToEntity.Name = "btnMoveToEntity";
            btnMoveToEntity.Size = new System.Drawing.Size(57, 51);
            btnMoveToEntity.Text = "Move To";
            btnMoveToEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnMoveToEntity.Click += BtnMoveToEntity_Click;
            // 
            // btnReOrder
            // 
            btnReOrder.Image = Properties.Resources.ExpandHeight32;
            btnReOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReOrder.Name = "btnReOrder";
            btnReOrder.Size = new System.Drawing.Size(54, 51);
            btnReOrder.Text = "ReOrder";
            btnReOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReOrder.Click += BtnReOrder_Click;
            // 
            // btnDuplicate
            // 
            btnDuplicate.Image = Properties.Resources.WindowCascade;
            btnDuplicate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDuplicate.Name = "btnDuplicate";
            btnDuplicate.Size = new System.Drawing.Size(61, 51);
            btnDuplicate.Text = "Duplicate";
            btnDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDuplicate.Click += BtnDuplicate_Click;
            // 
            // btnConvertToStockItem
            // 
            btnConvertToStockItem.Image = Properties.Resources.DBDestination32;
            btnConvertToStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnConvertToStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnConvertToStockItem.Name = "btnConvertToStockItem";
            btnConvertToStockItem.Size = new System.Drawing.Size(128, 51);
            btnConvertToStockItem.Text = "Convert To Stock Item";
            btnConvertToStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnConvertToStockItem.Click += BtnConvertToStockItem_Click;
            // 
            // btnEntityButtonRowHeight
            // 
            btnEntityButtonRowHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnEntityButtonRowHeight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnEntityButtonRowHeight25, btnEntityButtonRowHeight50, btnEntityButtonRowHeight100, btnEntityButtonRowHeight150, btnEntityButtonRowHeight200 });
            btnEntityButtonRowHeight.Image = (System.Drawing.Image)resources.GetObject("btnEntityButtonRowHeight.Image");
            btnEntityButtonRowHeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEntityButtonRowHeight.Name = "btnEntityButtonRowHeight";
            btnEntityButtonRowHeight.Size = new System.Drawing.Size(82, 51);
            btnEntityButtonRowHeight.Text = "Row Height";
            // 
            // btnEntityButtonRowHeight25
            // 
            btnEntityButtonRowHeight25.Name = "btnEntityButtonRowHeight25";
            btnEntityButtonRowHeight25.Size = new System.Drawing.Size(160, 22);
            btnEntityButtonRowHeight25.Tag = "25";
            btnEntityButtonRowHeight25.Text = "Small (25)";
            btnEntityButtonRowHeight25.Click += btnEntityButtonRowHeight_Click;
            // 
            // btnEntityButtonRowHeight50
            // 
            btnEntityButtonRowHeight50.Name = "btnEntityButtonRowHeight50";
            btnEntityButtonRowHeight50.Size = new System.Drawing.Size(160, 22);
            btnEntityButtonRowHeight50.Tag = "50";
            btnEntityButtonRowHeight50.Text = "Medium (50)";
            btnEntityButtonRowHeight50.Click += btnEntityButtonRowHeight_Click;
            // 
            // btnEntityButtonRowHeight100
            // 
            btnEntityButtonRowHeight100.Name = "btnEntityButtonRowHeight100";
            btnEntityButtonRowHeight100.Size = new System.Drawing.Size(160, 22);
            btnEntityButtonRowHeight100.Tag = "100";
            btnEntityButtonRowHeight100.Text = "Large (100)";
            btnEntityButtonRowHeight100.Click += btnEntityButtonRowHeight_Click;
            // 
            // btnEntityButtonRowHeight150
            // 
            btnEntityButtonRowHeight150.Name = "btnEntityButtonRowHeight150";
            btnEntityButtonRowHeight150.Size = new System.Drawing.Size(160, 22);
            btnEntityButtonRowHeight150.Tag = "150";
            btnEntityButtonRowHeight150.Text = "Extra Large (150)";
            btnEntityButtonRowHeight150.Click += btnEntityButtonRowHeight_Click;
            // 
            // btnEntityButtonRowHeight200
            // 
            btnEntityButtonRowHeight200.Name = "btnEntityButtonRowHeight200";
            btnEntityButtonRowHeight200.Size = new System.Drawing.Size(160, 22);
            btnEntityButtonRowHeight200.Tag = "200";
            btnEntityButtonRowHeight200.Text = "Maximum (200)";
            btnEntityButtonRowHeight200.Click += btnEntityButtonRowHeight_Click;
            // 
            // tsSortCategoryItem
            // 
            tsSortCategoryItem.AutoSize = false;
            tsSortCategoryItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSortCategoryItem.Image = Properties.Resources.updown;
            tsSortCategoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSortCategoryItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSortCategoryItem.Name = "tsSortCategoryItem";
            tsSortCategoryItem.Size = new System.Drawing.Size(60, 51);
            tsSortCategoryItem.Text = "toolStripButton1";
            tsSortCategoryItem.Click += tsSortCategoryItem_Click;
            // 
            // tsMoveUpCategoryItem
            // 
            tsMoveUpCategoryItem.AutoSize = false;
            tsMoveUpCategoryItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUpCategoryItem.Image = Properties.Resources.up2;
            tsMoveUpCategoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUpCategoryItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUpCategoryItem.Name = "tsMoveUpCategoryItem";
            tsMoveUpCategoryItem.Size = new System.Drawing.Size(60, 51);
            tsMoveUpCategoryItem.Text = "toolStripButton1";
            tsMoveUpCategoryItem.Click += tsMoveUpCategoryItem_Click;
            // 
            // tsMoveDownCategoryItem
            // 
            tsMoveDownCategoryItem.AutoSize = false;
            tsMoveDownCategoryItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDownCategoryItem.Image = Properties.Resources.down2;
            tsMoveDownCategoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDownCategoryItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDownCategoryItem.Name = "tsMoveDownCategoryItem";
            tsMoveDownCategoryItem.Size = new System.Drawing.Size(60, 51);
            tsMoveDownCategoryItem.Text = "toolStripButton1";
            tsMoveDownCategoryItem.Click += tsMoveDownCategoryItem_Click;
            // 
            // expanderMIddle
            // 
            expanderMIddle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expanderMIddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expanderMIddle.Caption = "";
            expanderMIddle.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expanderMIddle.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            expanderMIddle.CaptionForeColor = System.Drawing.Color.White;
            expanderMIddle.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            expanderMIddle.ColourFixed = System.Drawing.Color.Salmon;
            expanderMIddle.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expanderMIddle.Dock = System.Windows.Forms.DockStyle.Left;
            expanderMIddle.ExpandableControl = pnlLeft;
            expanderMIddle.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expanderMIddle.Expanded = true;
            expanderMIddle.Fixed = false;
            expanderMIddle.Location = new System.Drawing.Point(1555, 3);
            expanderMIddle.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expanderMIddle.LockButtonSize = new System.Drawing.Size(13, 74);
            expanderMIddle.LockButtonVisible = false;
            expanderMIddle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expanderMIddle.MinimumSize = new System.Drawing.Size(6, 5);
            expanderMIddle.Name = "expanderMIddle";
            expanderMIddle.Size = new System.Drawing.Size(23, 725);
            expanderMIddle.TabIndex = 7;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(pnlLeftBottom);
            pnlLeft.Controls.Add(expanderLeft);
            pnlLeft.Controls.Add(pnlLeftTop);
            pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeft.Location = new System.Drawing.Point(4, 3);
            pnlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new System.Drawing.Size(1551, 725);
            pnlLeft.TabIndex = 6;
            // 
            // pnlLeftBottom
            // 
            pnlLeftBottom.Controls.Add(dgvCategory);
            pnlLeftBottom.Controls.Add(barEntity);
            pnlLeftBottom.Controls.Add(pnlEntitySample);
            pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLeftBottom.Location = new System.Drawing.Point(0, 329);
            pnlLeftBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlLeftBottom.Name = "pnlLeftBottom";
            pnlLeftBottom.Size = new System.Drawing.Size(1551, 396);
            pnlLeftBottom.TabIndex = 2;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowDrop = true;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToOrderColumns = true;
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.BackgroundColor = System.Drawing.Color.White;
            dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { categoryNameDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, entityTypeDataGridViewTextBoxColumn, distributionNameDataGridViewTextBoxColumn, fontDataGridViewTextBoxColumn, dOrderDataGridViewTextBoxColumn });
            dgvCategory.DataSource = categoryBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle21;
            dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategory.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvCategory.Location = new System.Drawing.Point(0, 54);
            dgvCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 25;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle22;
            dgvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new System.Drawing.Size(1551, 230);
            dgvCategory.TabIndex = 4;
            dgvCategory.CellDoubleClick += DgvEntity_CellDoubleClick;
            dgvCategory.SelectionChanged += DgvEntity_SelectionChanged;
            dgvCategory.DragDrop += DgvEntity_DragDrop;
            dgvCategory.DragOver += Dgv_DragOver;
            dgvCategory.MouseDown += Dgv_MouseDown;
            dgvCategory.MouseMove += Dgv_MouseMove;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Width";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // entityTypeDataGridViewTextBoxColumn
            // 
            entityTypeDataGridViewTextBoxColumn.DataPropertyName = "CategoryType";
            entityTypeDataGridViewTextBoxColumn.HeaderText = "Category Type";
            entityTypeDataGridViewTextBoxColumn.Name = "entityTypeDataGridViewTextBoxColumn";
            entityTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // distributionNameDataGridViewTextBoxColumn
            // 
            distributionNameDataGridViewTextBoxColumn.DataPropertyName = "DistributionName";
            distributionNameDataGridViewTextBoxColumn.HeaderText = "DistributionName";
            distributionNameDataGridViewTextBoxColumn.Name = "distributionNameDataGridViewTextBoxColumn";
            distributionNameDataGridViewTextBoxColumn.ReadOnly = true;
            distributionNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fontDataGridViewTextBoxColumn
            // 
            fontDataGridViewTextBoxColumn.DataPropertyName = "Font";
            fontDataGridViewTextBoxColumn.HeaderText = "Font";
            fontDataGridViewTextBoxColumn.Name = "fontDataGridViewTextBoxColumn";
            fontDataGridViewTextBoxColumn.ReadOnly = true;
            fontDataGridViewTextBoxColumn.Width = 150;
            // 
            // dOrderDataGridViewTextBoxColumn
            // 
            dOrderDataGridViewTextBoxColumn.DataPropertyName = "DOrder";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dOrderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            dOrderDataGridViewTextBoxColumn.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn.Name = "dOrderDataGridViewTextBoxColumn";
            dOrderDataGridViewTextBoxColumn.Width = 70;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // barEntity
            // 
            barEntity.Enabled = false;
            barEntity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddEntity, btnEditEntity, btnDeleteEntity, btnReOrderEntityList, btnZoomEntity, tsSortCategory, tsMoveUpCategory, tsMoveDownCategory });
            barEntity.Location = new System.Drawing.Point(0, 0);
            barEntity.Name = "barEntity";
            barEntity.Size = new System.Drawing.Size(1551, 54);
            barEntity.TabIndex = 1;
            barEntity.Text = "toolStrip1";
            // 
            // btnAddEntity
            // 
            btnAddEntity.AutoSize = false;
            btnAddEntity.Image = Properties.Resources.arti32;
            btnAddEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddEntity.Name = "btnAddEntity";
            btnAddEntity.Size = new System.Drawing.Size(45, 51);
            btnAddEntity.Text = "Add";
            btnAddEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddEntity.Click += BtnAddEntity_Click;
            // 
            // btnEditEntity
            // 
            btnEditEntity.AutoSize = false;
            btnEditEntity.Image = Properties.Resources.MatReport_32;
            btnEditEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditEntity.Name = "btnEditEntity";
            btnEditEntity.Size = new System.Drawing.Size(45, 51);
            btnEditEntity.Text = "Edit";
            btnEditEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEditEntity.Click += BtnEditEntity_Click;
            // 
            // btnDeleteEntity
            // 
            btnDeleteEntity.AutoSize = false;
            btnDeleteEntity.Image = Properties.Resources.eksi32;
            btnDeleteEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteEntity.Name = "btnDeleteEntity";
            btnDeleteEntity.Size = new System.Drawing.Size(45, 51);
            btnDeleteEntity.Text = "Delete";
            btnDeleteEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteEntity.Click += BtnDeleteEntity_Click;
            // 
            // btnReOrderEntityList
            // 
            btnReOrderEntityList.Image = Properties.Resources.ExpandHeight32;
            btnReOrderEntityList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReOrderEntityList.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReOrderEntityList.Name = "btnReOrderEntityList";
            btnReOrderEntityList.Size = new System.Drawing.Size(54, 51);
            btnReOrderEntityList.Text = "ReOrder";
            btnReOrderEntityList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReOrderEntityList.Click += BtnReOrderEntityList_Click;
            // 
            // btnZoomEntity
            // 
            btnZoomEntity.Image = Properties.Resources.View32;
            btnZoomEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnZoomEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnZoomEntity.Name = "btnZoomEntity";
            btnZoomEntity.Size = new System.Drawing.Size(55, 51);
            btnZoomEntity.Text = "  Zoom  ";
            btnZoomEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnZoomEntity.Click += BtnZoomEntity_Click;
            // 
            // tsSortCategory
            // 
            tsSortCategory.AutoSize = false;
            tsSortCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSortCategory.Image = Properties.Resources.updown;
            tsSortCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSortCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSortCategory.Name = "tsSortCategory";
            tsSortCategory.Size = new System.Drawing.Size(60, 51);
            tsSortCategory.Text = "toolStripButton1";
            tsSortCategory.Click += tsSortCategory_Click;
            // 
            // tsMoveUpCategory
            // 
            tsMoveUpCategory.AutoSize = false;
            tsMoveUpCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUpCategory.Image = Properties.Resources.up2;
            tsMoveUpCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUpCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUpCategory.Name = "tsMoveUpCategory";
            tsMoveUpCategory.Size = new System.Drawing.Size(60, 51);
            tsMoveUpCategory.Text = "toolStripButton1";
            tsMoveUpCategory.Click += tsMoveUpCategory_Click;
            // 
            // tsMoveDownCategory
            // 
            tsMoveDownCategory.AutoSize = false;
            tsMoveDownCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDownCategory.Image = Properties.Resources.down2;
            tsMoveDownCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDownCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDownCategory.Name = "tsMoveDownCategory";
            tsMoveDownCategory.Size = new System.Drawing.Size(60, 51);
            tsMoveDownCategory.Text = "toolStripButton1";
            tsMoveDownCategory.Click += tsMoveDownCategory_Click;
            // 
            // pnlEntitySample
            // 
            pnlEntitySample.BackColor = System.Drawing.Color.White;
            pnlEntitySample.Controls.Add(btnEntitySample);
            pnlEntitySample.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlEntitySample.Location = new System.Drawing.Point(0, 284);
            pnlEntitySample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlEntitySample.Name = "pnlEntitySample";
            pnlEntitySample.Size = new System.Drawing.Size(1551, 112);
            pnlEntitySample.TabIndex = 3;
            // 
            // btnEntitySample
            // 
            btnEntitySample.BackColor = System.Drawing.Color.White;
            btnEntitySample.Dock = System.Windows.Forms.DockStyle.Left;
            btnEntitySample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntitySample.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnEntitySample.Location = new System.Drawing.Point(0, 0);
            btnEntitySample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEntitySample.Name = "btnEntitySample";
            btnEntitySample.Size = new System.Drawing.Size(163, 112);
            btnEntitySample.TabIndex = 10;
            btnEntitySample.UseVisualStyleBackColor = false;
            // 
            // expanderLeft
            // 
            expanderLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expanderLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expanderLeft.Caption = "";
            expanderLeft.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expanderLeft.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            expanderLeft.CaptionForeColor = System.Drawing.Color.White;
            expanderLeft.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            expanderLeft.ColourFixed = System.Drawing.Color.Salmon;
            expanderLeft.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expanderLeft.Dock = System.Windows.Forms.DockStyle.Top;
            expanderLeft.ExpandableControl = pnlLeftTop;
            expanderLeft.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expanderLeft.Expanded = true;
            expanderLeft.Fixed = false;
            expanderLeft.Location = new System.Drawing.Point(0, 306);
            expanderLeft.LockButtonDock = System.Windows.Forms.DockStyle.Left;
            expanderLeft.LockButtonSize = new System.Drawing.Size(37, 28);
            expanderLeft.LockButtonVisible = false;
            expanderLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expanderLeft.MinimumSize = new System.Drawing.Size(6, 5);
            expanderLeft.Name = "expanderLeft";
            expanderLeft.Size = new System.Drawing.Size(1551, 23);
            expanderLeft.TabIndex = 1;
            // 
            // pnlLeftTop
            // 
            pnlLeftTop.Controls.Add(dgvMenu);
            pnlLeftTop.Controls.Add(barMenu);
            pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            pnlLeftTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlLeftTop.Name = "pnlLeftTop";
            pnlLeftTop.Size = new System.Drawing.Size(1551, 306);
            pnlLeftTop.TabIndex = 0;
            // 
            // barMenu
            // 
            barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddMenu, btnEditMenu, btnDeleteMenu, btnReloadMenu, btnSaveMenu, mnuSetAsDefaultMenu, btnPrintMenu, btnLoadMenu, btnBackupMenu, btnZoomMenu, btnExportStockManager, btnImportStockManager, btnSaveDBImagesToFolder, btnLoadMenuList, btnCreateDummyMenu, btnExportMenuAsJson, btnImportMenuFromJSON, tsSortMenu, tsMoveUpMenu, tsMoveDownMenu });
            barMenu.Location = new System.Drawing.Point(0, 0);
            barMenu.Name = "barMenu";
            barMenu.Size = new System.Drawing.Size(1551, 54);
            barMenu.TabIndex = 0;
            barMenu.Text = "toolStrip1";
            // 
            // btnAddMenu
            // 
            btnAddMenu.AutoSize = false;
            btnAddMenu.Image = Properties.Resources.arti32;
            btnAddMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new System.Drawing.Size(70, 51);
            btnAddMenu.Text = "New Menu";
            btnAddMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddMenu.Click += BtnAddMenu_Click;
            // 
            // btnEditMenu
            // 
            btnEditMenu.AutoSize = false;
            btnEditMenu.Image = Properties.Resources.MatReport_32;
            btnEditMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditMenu.Name = "btnEditMenu";
            btnEditMenu.Size = new System.Drawing.Size(60, 51);
            btnEditMenu.Text = "  Edit  ";
            btnEditMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEditMenu.Click += BtnEditMenu_Click;
            // 
            // btnDeleteMenu
            // 
            btnDeleteMenu.AutoSize = false;
            btnDeleteMenu.Image = Properties.Resources.eksi32;
            btnDeleteMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteMenu.Name = "btnDeleteMenu";
            btnDeleteMenu.Size = new System.Drawing.Size(60, 51);
            btnDeleteMenu.Text = "Delete";
            btnDeleteMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteMenu.Click += BtnDeleteMenu_Click;
            // 
            // btnReloadMenu
            // 
            btnReloadMenu.AutoSize = false;
            btnReloadMenu.Image = Properties.Resources.Refresh_2;
            btnReloadMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReloadMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReloadMenu.Name = "btnReloadMenu";
            btnReloadMenu.Size = new System.Drawing.Size(60, 51);
            btnReloadMenu.Text = "Reload";
            btnReloadMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReloadMenu.ToolTipText = "Reload Menu";
            btnReloadMenu.Click += btnReloadMenu_Click;
            // 
            // btnSaveMenu
            // 
            btnSaveMenu.AutoSize = false;
            btnSaveMenu.Image = Properties.Resources.save;
            btnSaveMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSaveMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSaveMenu.Name = "btnSaveMenu";
            btnSaveMenu.Size = new System.Drawing.Size(60, 51);
            btnSaveMenu.Text = "Save";
            btnSaveMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveMenu.ToolTipText = "Save Menu";
            btnSaveMenu.Click += btnSaveMenu_Click;
            // 
            // mnuSetAsDefaultMenu
            // 
            mnuSetAsDefaultMenu.Image = Properties.Resources.tickgreen;
            mnuSetAsDefaultMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            mnuSetAsDefaultMenu.Name = "mnuSetAsDefaultMenu";
            mnuSetAsDefaultMenu.Size = new System.Drawing.Size(68, 51);
            mnuSetAsDefaultMenu.Text = "Set Default";
            mnuSetAsDefaultMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            mnuSetAsDefaultMenu.Click += mnuSetAsDefaultMenu_Click;
            // 
            // btnPrintMenu
            // 
            btnPrintMenu.AutoSize = false;
            btnPrintMenu.Image = Properties.Resources.Printer32;
            btnPrintMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPrintMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPrintMenu.Name = "btnPrintMenu";
            btnPrintMenu.Size = new System.Drawing.Size(60, 51);
            btnPrintMenu.Text = " Print ";
            btnPrintMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPrintMenu.Click += BtnPrintMenu_Click;
            // 
            // btnLoadMenu
            // 
            btnLoadMenu.Image = Properties.Resources.Paste232;
            btnLoadMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoadMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadMenu.Name = "btnLoadMenu";
            btnLoadMenu.Size = new System.Drawing.Size(79, 51);
            btnLoadMenu.Text = "Load Backup";
            btnLoadMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadMenu.Click += BtnLoadMenu_Click;
            // 
            // btnBackupMenu
            // 
            btnBackupMenu.AutoSize = false;
            btnBackupMenu.Image = Properties.Resources.disket32;
            btnBackupMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnBackupMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnBackupMenu.Name = "btnBackupMenu";
            btnBackupMenu.Size = new System.Drawing.Size(60, 51);
            btnBackupMenu.Text = "Backup";
            btnBackupMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnBackupMenu.Click += BtnBackupMenu_Click;
            // 
            // btnZoomMenu
            // 
            btnZoomMenu.AutoSize = false;
            btnZoomMenu.Image = Properties.Resources.View32;
            btnZoomMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnZoomMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnZoomMenu.Name = "btnZoomMenu";
            btnZoomMenu.Size = new System.Drawing.Size(60, 51);
            btnZoomMenu.Text = "Zoom";
            btnZoomMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnZoomMenu.Click += BtnZoomMenu_Click;
            // 
            // btnExportStockManager
            // 
            btnExportStockManager.Image = Properties.Resources.DBToFolder32;
            btnExportStockManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportStockManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportStockManager.Name = "btnExportStockManager";
            btnExportStockManager.Size = new System.Drawing.Size(64, 51);
            btnExportStockManager.Text = "Export SM";
            btnExportStockManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportStockManager.Click += BtnExportStockManager_Click;
            // 
            // btnImportStockManager
            // 
            btnImportStockManager.Image = Properties.Resources.FolderToDB32;
            btnImportStockManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportStockManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportStockManager.Name = "btnImportStockManager";
            btnImportStockManager.Size = new System.Drawing.Size(67, 51);
            btnImportStockManager.Text = "Import SM";
            btnImportStockManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportStockManager.Click += BtnImportStockManager_Click;
            // 
            // btnSaveDBImagesToFolder
            // 
            btnSaveDBImagesToFolder.Image = Properties.Resources.Camescope;
            btnSaveDBImagesToFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSaveDBImagesToFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSaveDBImagesToFolder.Name = "btnSaveDBImagesToFolder";
            btnSaveDBImagesToFolder.Size = new System.Drawing.Size(85, 51);
            btnSaveDBImagesToFolder.Text = "Export Images";
            btnSaveDBImagesToFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSaveDBImagesToFolder.ToolTipText = "Export Images Into File";
            btnSaveDBImagesToFolder.Click += BtnSaveDBImagesToFolder_Click;
            // 
            // btnLoadMenuList
            // 
            btnLoadMenuList.Image = Properties.Resources.Lightning;
            btnLoadMenuList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoadMenuList.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadMenuList.Name = "btnLoadMenuList";
            btnLoadMenuList.Size = new System.Drawing.Size(84, 51);
            btnLoadMenuList.Text = "Load Menu(s)";
            btnLoadMenuList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadMenuList.Click += BtnLoadMenuList_Click;
            // 
            // btnCreateDummyMenu
            // 
            btnCreateDummyMenu.Image = Properties.Resources.uzgun32;
            btnCreateDummyMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCreateDummyMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCreateDummyMenu.Name = "btnCreateDummyMenu";
            btnCreateDummyMenu.Size = new System.Drawing.Size(88, 51);
            btnCreateDummyMenu.Text = "Dummy Menu";
            btnCreateDummyMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCreateDummyMenu.Click += btnCreateDummyMenu_Click;
            // 
            // btnExportMenuAsJson
            // 
            btnExportMenuAsJson.AutoSize = false;
            btnExportMenuAsJson.Image = Properties.Resources.SquareArrowRightExpander32;
            btnExportMenuAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportMenuAsJson.Name = "btnExportMenuAsJson";
            btnExportMenuAsJson.Size = new System.Drawing.Size(60, 51);
            btnExportMenuAsJson.Text = "Export J";
            btnExportMenuAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportMenuAsJson.Click += btnExportMenuAsJson_Click;
            // 
            // btnImportMenuFromJSON
            // 
            btnImportMenuFromJSON.AutoSize = false;
            btnImportMenuFromJSON.Image = Properties.Resources.SquareArrowLeftNarrower32;
            btnImportMenuFromJSON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportMenuFromJSON.Name = "btnImportMenuFromJSON";
            btnImportMenuFromJSON.Size = new System.Drawing.Size(60, 51);
            btnImportMenuFromJSON.Text = "Import J";
            btnImportMenuFromJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportMenuFromJSON.Click += btnImportMenuFromJSON_Click;
            // 
            // tsSortMenu
            // 
            tsSortMenu.AutoSize = false;
            tsSortMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSortMenu.Image = Properties.Resources.updown;
            tsSortMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSortMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSortMenu.Name = "tsSortMenu";
            tsSortMenu.Size = new System.Drawing.Size(60, 51);
            tsSortMenu.Text = "toolStripButton1";
            tsSortMenu.Click += tsSortMenu_Click;
            // 
            // tsMoveUpMenu
            // 
            tsMoveUpMenu.AutoSize = false;
            tsMoveUpMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUpMenu.Image = Properties.Resources.up2;
            tsMoveUpMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUpMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUpMenu.Name = "tsMoveUpMenu";
            tsMoveUpMenu.Size = new System.Drawing.Size(60, 51);
            tsMoveUpMenu.Text = "toolStripButton1";
            tsMoveUpMenu.Click += tsMoveUpMenu_Click;
            // 
            // tsMoveDownMenu
            // 
            tsMoveDownMenu.AutoSize = false;
            tsMoveDownMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDownMenu.Image = Properties.Resources.down2;
            tsMoveDownMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDownMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDownMenu.Name = "tsMoveDownMenu";
            tsMoveDownMenu.Size = new System.Drawing.Size(60, 51);
            tsMoveDownMenu.Text = "toolStripButton1";
            tsMoveDownMenu.Click += tsMoveDownMenu_Click;
            // 
            // tabSearchCategoryItems
            // 
            tabSearchCategoryItems.Controls.Add(dgvSearchResults);
            tabSearchCategoryItems.Controls.Add(pnlSearchImagePanel);
            tabSearchCategoryItems.Controls.Add(barSearchCategoryItems);
            tabSearchCategoryItems.Location = new System.Drawing.Point(4, 34);
            tabSearchCategoryItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSearchCategoryItems.Name = "tabSearchCategoryItems";
            tabSearchCategoryItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSearchCategoryItems.Size = new System.Drawing.Size(3175, 731);
            tabSearchCategoryItems.TabIndex = 4;
            tabSearchCategoryItems.Text = "SEARCH CATEGORY ITEMS";
            tabSearchCategoryItems.UseVisualStyleBackColor = true;
            // 
            // barSearchCategoryItems
            // 
            barSearchCategoryItems.Enabled = false;
            barSearchCategoryItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { txtSearchCategoryButtons, btnSearchCategoryButtons, chkAllMenuSearch, lblSearchResults });
            barSearchCategoryItems.Location = new System.Drawing.Point(4, 3);
            barSearchCategoryItems.Name = "barSearchCategoryItems";
            barSearchCategoryItems.Size = new System.Drawing.Size(3167, 39);
            barSearchCategoryItems.TabIndex = 0;
            barSearchCategoryItems.Text = "toolStrip1";
            // 
            // txtSearchCategoryButtons
            // 
            txtSearchCategoryButtons.AutoSize = false;
            txtSearchCategoryButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearchCategoryButtons.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearchCategoryButtons.Name = "txtSearchCategoryButtons";
            txtSearchCategoryButtons.Size = new System.Drawing.Size(233, 29);
            txtSearchCategoryButtons.KeyDown += TxtSearchCategoryButtons_KeyDown;
            // 
            // btnSearchCategoryButtons
            // 
            btnSearchCategoryButtons.Image = Properties.Resources.QuestionGreen;
            btnSearchCategoryButtons.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSearchCategoryButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSearchCategoryButtons.Name = "btnSearchCategoryButtons";
            btnSearchCategoryButtons.Size = new System.Drawing.Size(78, 36);
            btnSearchCategoryButtons.Text = "Search";
            btnSearchCategoryButtons.Click += BtnSearchCategoryButtons_Click;
            // 
            // chkAllMenuSearch
            // 
            chkAllMenuSearch.CheckOnClick = true;
            chkAllMenuSearch.Image = Properties.Resources.Unchecked;
            chkAllMenuSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            chkAllMenuSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            chkAllMenuSearch.Name = "chkAllMenuSearch";
            chkAllMenuSearch.Size = new System.Drawing.Size(104, 36);
            chkAllMenuSearch.Text = "All Menu(s)";
            chkAllMenuSearch.CheckedChanged += chkAllMenuSearch_CheckedChanged;
            // 
            // lblSearchResults
            // 
            lblSearchResults.Name = "lblSearchResults";
            lblSearchResults.Size = new System.Drawing.Size(21, 36);
            lblSearchResults.Text = "(0)";
            // 
            // entityButtonExtendedBindingSource
            // 
            entityButtonExtendedBindingSource.DataSource = typeof(EntityButtonExtended);
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CategoryType";
            dataGridViewTextBoxColumn2.HeaderText = "CategoryType";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "QuantityType";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn8.HeaderText = "QType";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "QuantityType";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn9.HeaderText = "QType";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "QuantityType";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewTextBoxColumn10.HeaderText = "QType";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "CategoryType";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewTextBoxColumn11.HeaderText = "CategoryType";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Visible = false;
            dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "CategoryType";
            dataGridViewTextBoxColumn12.HeaderText = "CategoryType";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Visible = false;
            dataGridViewTextBoxColumn12.Width = 75;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "QuantityType";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewTextBoxColumn14.HeaderText = "QType";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "QuantityType";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewTextBoxColumn15.HeaderText = "QType";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "QuantityType";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewTextBoxColumn16.HeaderText = "QType";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.ToolTipText = "Direct Sale Price";
            dataGridViewTextBoxColumn16.Visible = false;
            dataGridViewTextBoxColumn16.Width = 80;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "CategoryType";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "N2";
            dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle30;
            dataGridViewTextBoxColumn17.HeaderText = "CategoryType";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.ToolTipText = "InHouse Price";
            dataGridViewTextBoxColumn17.Visible = false;
            dataGridViewTextBoxColumn17.Width = 75;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "QuantityType";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewTextBoxColumn18.HeaderText = "QType";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.ToolTipText = "Take Away Price";
            dataGridViewTextBoxColumn18.Visible = false;
            dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "DeliveryPrice";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle32;
            dataGridViewTextBoxColumn19.HeaderText = "DL Price";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.ToolTipText = "Delivery Price";
            dataGridViewTextBoxColumn19.Width = 75;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle33;
            dataGridViewTextBoxColumn20.HeaderText = "Width";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Visible = false;
            dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewTextBoxColumn21.HeaderText = "Height";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Visible = false;
            dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "DirectSaleTaxPercent";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.Format = "N2";
            dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewTextBoxColumn22.HeaderText = "DS Tax%";
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            dataGridViewTextBoxColumn22.ToolTipText = "Direct Sale Tax";
            dataGridViewTextBoxColumn22.Width = 80;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.DataPropertyName = "InHouseTaxPercent";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Format = "N2";
            dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle36;
            dataGridViewTextBoxColumn23.HeaderText = "IH Tax%";
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.ReadOnly = true;
            dataGridViewTextBoxColumn23.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn23.Width = 80;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.DataPropertyName = "TakeAwayTaxPercent";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Format = "N2";
            dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle37;
            dataGridViewTextBoxColumn24.HeaderText = "TA Tax%";
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            dataGridViewTextBoxColumn24.ReadOnly = true;
            dataGridViewTextBoxColumn24.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn24.Width = 80;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.DataPropertyName = "DeliveryTaxPercent";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Format = "N2";
            dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle38;
            dataGridViewTextBoxColumn25.HeaderText = "DL Tax%";
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            dataGridViewTextBoxColumn25.ReadOnly = true;
            dataGridViewTextBoxColumn25.ToolTipText = "Delivery Tax";
            dataGridViewTextBoxColumn25.Width = 80;
            // 
            // dataGridViewTextBoxColumn26
            // 
            dataGridViewTextBoxColumn26.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Format = "N2";
            dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle39;
            dataGridViewTextBoxColumn26.HeaderText = "DO";
            dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            dataGridViewTextBoxColumn26.ReadOnly = true;
            dataGridViewTextBoxColumn26.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            dataGridViewTextBoxColumn27.DataPropertyName = "FFamily";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Format = "N2";
            dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle40;
            dataGridViewTextBoxColumn27.HeaderText = "Font";
            dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            dataGridViewTextBoxColumn27.ReadOnly = true;
            dataGridViewTextBoxColumn27.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn27.Width = 75;
            // 
            // dataGridViewTextBoxColumn28
            // 
            dataGridViewTextBoxColumn28.DataPropertyName = "FSize";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Format = "N2";
            dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle41;
            dataGridViewTextBoxColumn28.HeaderText = "FSize";
            dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            dataGridViewTextBoxColumn28.ReadOnly = true;
            dataGridViewTextBoxColumn28.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn28.Width = 75;
            // 
            // dataGridViewTextBoxColumn29
            // 
            dataGridViewTextBoxColumn29.DataPropertyName = "FStyle";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Format = "N2";
            dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle42;
            dataGridViewTextBoxColumn29.HeaderText = "FStyle";
            dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            dataGridViewTextBoxColumn29.ReadOnly = true;
            dataGridViewTextBoxColumn29.ToolTipText = "Delivery Tax";
            dataGridViewTextBoxColumn29.Width = 75;
            // 
            // dataGridViewTextBoxColumn30
            // 
            dataGridViewTextBoxColumn30.DataPropertyName = "DistributionName";
            dataGridViewTextBoxColumn30.HeaderText = "Distribution";
            dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            dataGridViewTextBoxColumn30.ReadOnly = true;
            dataGridViewTextBoxColumn30.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn30.Width = 50;
            // 
            // dataGridViewTextBoxColumn31
            // 
            dataGridViewTextBoxColumn31.DataPropertyName = "IID";
            dataGridViewTextBoxColumn31.HeaderText = "IID";
            dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            dataGridViewTextBoxColumn31.ReadOnly = true;
            dataGridViewTextBoxColumn31.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn31.Visible = false;
            dataGridViewTextBoxColumn31.Width = 50;
            // 
            // dataGridViewTextBoxColumn32
            // 
            dataGridViewTextBoxColumn32.DataPropertyName = "PanelColor";
            dataGridViewTextBoxColumn32.HeaderText = "PanelColor";
            dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            dataGridViewTextBoxColumn32.ReadOnly = true;
            dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            dataGridViewTextBoxColumn33.DataPropertyName = "FStyle";
            dataGridViewTextBoxColumn33.HeaderText = "FStyle";
            dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            dataGridViewTextBoxColumn33.ReadOnly = true;
            dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            dataGridViewTextBoxColumn34.DataPropertyName = "EntityName";
            dataGridViewTextBoxColumn34.HeaderText = "Category Name";
            dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            dataGridViewTextBoxColumn34.ReadOnly = true;
            dataGridViewTextBoxColumn34.Visible = false;
            dataGridViewTextBoxColumn34.Width = 150;
            // 
            // dataGridViewTextBoxColumn35
            // 
            dataGridViewTextBoxColumn35.DataPropertyName = "ButtonHeight";
            dataGridViewTextBoxColumn35.HeaderText = "Height";
            dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            dataGridViewTextBoxColumn35.ReadOnly = true;
            dataGridViewTextBoxColumn35.Width = 50;
            // 
            // dataGridViewTextBoxColumn36
            // 
            dataGridViewTextBoxColumn36.DataPropertyName = "ButtonWidth";
            dataGridViewTextBoxColumn36.HeaderText = "Width";
            dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            dataGridViewTextBoxColumn36.ReadOnly = true;
            dataGridViewTextBoxColumn36.Width = 50;
            // 
            // dataGridViewTextBoxColumn37
            // 
            dataGridViewTextBoxColumn37.DataPropertyName = "CategoryType";
            dataGridViewTextBoxColumn37.HeaderText = "CategoryType";
            dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            dataGridViewTextBoxColumn37.ReadOnly = true;
            dataGridViewTextBoxColumn37.Visible = false;
            dataGridViewTextBoxColumn37.Width = 50;
            // 
            // dataGridViewTextBoxColumn38
            // 
            dataGridViewTextBoxColumn38.DataPropertyName = "DistributionName";
            dataGridViewTextBoxColumn38.HeaderText = "Distribution";
            dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            dataGridViewTextBoxColumn38.ReadOnly = true;
            dataGridViewTextBoxColumn38.Visible = false;
            // 
            // dataGridViewTextBoxColumn39
            // 
            dataGridViewTextBoxColumn39.DataPropertyName = "FFamily";
            dataGridViewTextBoxColumn39.HeaderText = "Font";
            dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            dataGridViewTextBoxColumn39.ReadOnly = true;
            dataGridViewTextBoxColumn39.Width = 75;
            // 
            // dataGridViewTextBoxColumn40
            // 
            dataGridViewTextBoxColumn40.DataPropertyName = "FSize";
            dataGridViewTextBoxColumn40.HeaderText = "FSize";
            dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            dataGridViewTextBoxColumn40.ReadOnly = true;
            dataGridViewTextBoxColumn40.Width = 75;
            // 
            // dataGridViewTextBoxColumn41
            // 
            dataGridViewTextBoxColumn41.DataPropertyName = "DisplayOrder";
            dataGridViewTextBoxColumn41.HeaderText = "DO";
            dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            dataGridViewTextBoxColumn41.ReadOnly = true;
            dataGridViewTextBoxColumn41.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn41.Width = 50;
            // 
            // dataGridViewTextBoxColumn42
            // 
            dataGridViewTextBoxColumn42.DataPropertyName = "IID";
            dataGridViewTextBoxColumn42.HeaderText = "IID";
            dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            dataGridViewTextBoxColumn42.ReadOnly = true;
            dataGridViewTextBoxColumn42.Visible = false;
            // 
            // dataGridViewTextBoxColumn43
            // 
            dataGridViewTextBoxColumn43.DataPropertyName = "MenuName";
            dataGridViewTextBoxColumn43.HeaderText = "Menu";
            dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            dataGridViewTextBoxColumn43.ReadOnly = true;
            dataGridViewTextBoxColumn43.Width = 200;
            // 
            // dataGridViewTextBoxColumn44
            // 
            dataGridViewTextBoxColumn44.DataPropertyName = "IID";
            dataGridViewTextBoxColumn44.HeaderText = "IID";
            dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            dataGridViewTextBoxColumn44.ReadOnly = true;
            dataGridViewTextBoxColumn44.Visible = false;
            // 
            // dataGridViewTextBoxColumn45
            // 
            dataGridViewTextBoxColumn45.DataPropertyName = "EntityButtonName";
            dataGridViewTextBoxColumn45.HeaderText = "EntityButtonName";
            dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            dataGridViewTextBoxColumn45.ReadOnly = true;
            dataGridViewTextBoxColumn45.Width = 150;
            // 
            // dataGridViewTextBoxColumn46
            // 
            dataGridViewTextBoxColumn46.DataPropertyName = "EntityName";
            dataGridViewTextBoxColumn46.HeaderText = "EntityName";
            dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            dataGridViewTextBoxColumn46.ReadOnly = true;
            dataGridViewTextBoxColumn46.Width = 150;
            // 
            // dataGridViewTextBoxColumn47
            // 
            dataGridViewTextBoxColumn47.DataPropertyName = "QuantityType";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn47.DefaultCellStyle = dataGridViewCellStyle43;
            dataGridViewTextBoxColumn47.HeaderText = "QType";
            dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            dataGridViewTextBoxColumn47.Visible = false;
            dataGridViewTextBoxColumn47.Width = 80;
            // 
            // dataGridViewTextBoxColumn48
            // 
            dataGridViewTextBoxColumn48.DataPropertyName = "CategoryType";
            dataGridViewTextBoxColumn48.HeaderText = "CategoryType";
            dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            dataGridViewTextBoxColumn48.ReadOnly = true;
            dataGridViewTextBoxColumn48.Visible = false;
            // 
            // entityButtonBindingSource
            // 
            entityButtonBindingSource.DataSource = typeof(CategoryItem);
            // 
            // FrmMenuEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(3183, 781);
            Controls.Add(tabMain);
            Controls.Add(pnlBottom);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmMenuEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DTRM SIMPLE MENU EDITOR";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMenuEditor_Load;
            KeyDown += FrmMenuEditor_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)theMenuBindingSource).EndInit();
            popEntityButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonSearchResultBindingSource).EndInit();
            pnlSearchImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxSearchItem).EndInit();
            tabMain.ResumeLayout(false);
            tabMenus.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRightBottom.ResumeLayout(false);
            pnlRightBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonStockItemLookUpBindingSource).EndInit();
            pnlEBPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxEBPicture).EndInit();
            barStockUsage.ResumeLayout(false);
            barStockUsage.PerformLayout();
            pnlRightTop.ResumeLayout(false);
            pnlRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryItemBindingSource).EndInit();
            barEntityButton.ResumeLayout(false);
            barEntityButton.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeftBottom.ResumeLayout(false);
            pnlLeftBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            barEntity.ResumeLayout(false);
            barEntity.PerformLayout();
            pnlEntitySample.ResumeLayout(false);
            pnlLeftTop.ResumeLayout(false);
            pnlLeftTop.PerformLayout();
            barMenu.ResumeLayout(false);
            barMenu.PerformLayout();
            tabSearchCategoryItems.ResumeLayout(false);
            tabSearchCategoryItems.PerformLayout();
            barSearchCategoryItems.ResumeLayout(false);
            barSearchCategoryItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entityButtonExtendedBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.BindingSource entityButtonBindingSource;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;        
        private System.Windows.Forms.BindingSource entityButtonStockItemLookUpBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ContextMenuStrip popEntityButton;
        private System.Windows.Forms.ToolStripMenuItem popEBAddNew;
        private System.Windows.Forms.ToolStripMenuItem popEBEdit;
        private System.Windows.Forms.ToolStripMenuItem popEBDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem popEBSetFont;
        private System.Windows.Forms.ToolStripMenuItem popEBSetWidth;
        private System.Windows.Forms.ToolStripMenuItem popEBSetHeight;
        private System.Windows.Forms.ToolStripMenuItem popEBSetPrice;
        private System.Windows.Forms.ToolStripMenuItem popEBSetTaxRate;
        private System.Windows.Forms.ToolStripMenuItem popEBSetToUpperCase;
        private System.Windows.Forms.ToolStripMenuItem popEBSetToLowercase;
        private System.Windows.Forms.ToolStripMenuItem popEBMoveTo;
        private System.Windows.Forms.ToolStripMenuItem popEBReOrder;
        private System.Windows.Forms.ToolStripMenuItem popEBDuplicate;
        private System.Windows.Forms.ToolStripMenuItem popEBConvertToStockItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripMenuItem popSetAllForeColourTo;
        private System.Windows.Forms.ToolStripMenuItem popSetAllBackColourTo;
        private System.Windows.Forms.ToolStripMenuItem popSetAllBackColourToTransparent;
        private System.Windows.Forms.ToolStripMenuItem popSetAllDistributionTo;
        private System.Windows.Forms.BindingSource entityButtonExtendedBindingSource;
        private System.Windows.Forms.ToolStripMenuItem popSetSentenceCase;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Panel pnlSearchImagePanel;
        private System.Windows.Forms.PictureBox pBoxSearchItem;
        private System.Windows.Forms.BindingSource entityButtonSearchResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonNameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityNameSearch;
        private System.Windows.Forms.DataGridViewImageColumn colDisplayImageSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMenus;
        private System.Windows.Forms.ToolStrip barMenu;
        private System.Windows.Forms.ToolStripButton btnLoadMenuList;
        private System.Windows.Forms.ToolStripButton btnAddMenu;
        private System.Windows.Forms.ToolStripButton btnEditMenu;
        private System.Windows.Forms.ToolStripButton btnDeleteMenu;
        private System.Windows.Forms.ToolStripButton btnZoomMenu;
        private System.Windows.Forms.ToolStripButton btnBackupMenu;
        private System.Windows.Forms.ToolStripButton btnPrintMenu;
        private System.Windows.Forms.ToolStripButton btnExportStockManager;
        private System.Windows.Forms.ToolStripButton btnImportStockManager;
        private System.Windows.Forms.ToolStripButton btnSaveDBImagesToFolder;
        private System.Windows.Forms.TabPage tabSearchCategoryItems;
        private System.Windows.Forms.ToolStrip barSearchCategoryItems;
        private System.Windows.Forms.ToolStripTextBox txtSearchCategoryButtons;
        private System.Windows.Forms.ToolStripButton btnSearchCategoryButtons;
        private System.Windows.Forms.ToolStripButton chkAllMenuSearch;
        private System.Windows.Forms.ToolStripLabel lblSearchResults;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel pnlEntitySample;
        private System.Windows.Forms.Button btnEntitySample;
        private System.Windows.Forms.ToolStrip barEntity;
        private System.Windows.Forms.ToolStripButton btnAddEntity;
        private System.Windows.Forms.ToolStripButton btnEditEntity;
        private System.Windows.Forms.ToolStripButton btnDeleteEntity;
        private System.Windows.Forms.ToolStripButton btnZoomEntity;
        private System.Windows.Forms.ToolStripButton btnReOrderEntityList;
        private System.Windows.Forms.DataGridView dgvCategoryItem;
        private System.Windows.Forms.ToolStrip barEntityButton;
        private System.Windows.Forms.ToolStripButton btnAddEntityButton;
        private System.Windows.Forms.ToolStripButton btnEditEntityButton;
        private System.Windows.Forms.ToolStripButton btnDeleteEntityButton;
        private System.Windows.Forms.ToolStripButton btnZoomEntityButton;
        private System.Windows.Forms.ToolStripDropDownButton btnSetAll;
        private System.Windows.Forms.ToolStripMenuItem btnEBFontTo;
        private System.Windows.Forms.ToolStripMenuItem btnEBWidthTo;
        private System.Windows.Forms.ToolStripMenuItem btnEBHeightTo;
        private System.Windows.Forms.ToolStripMenuItem btnEBPriceTo;
        private System.Windows.Forms.ToolStripMenuItem btnEBTaxRateTo;
        private System.Windows.Forms.ToolStripMenuItem btnSetUpperCase;
        private System.Windows.Forms.ToolStripMenuItem btnSetToLowerCase;
        private System.Windows.Forms.ToolStripMenuItem btnSetSentenceCase;
        private System.Windows.Forms.ToolStripMenuItem btnSetAllForeColourTo;
        private System.Windows.Forms.ToolStripMenuItem btnSetAllBackColourTo;
        private System.Windows.Forms.ToolStripMenuItem btnSetAllBackColourToTransparent;
        private System.Windows.Forms.ToolStripMenuItem btnChangeDistributionForEB;
        private System.Windows.Forms.ToolStripButton btnMoveToEntity;
        private System.Windows.Forms.ToolStripButton btnReOrder;
        private System.Windows.Forms.ToolStripButton btnDuplicate;
        private System.Windows.Forms.ToolStripButton btnConvertToStockItem;
        private System.Windows.Forms.ToolStripDropDownButton btnEntityButtonRowHeight;
        private System.Windows.Forms.ToolStripMenuItem btnEntityButtonRowHeight25;
        private System.Windows.Forms.ToolStripMenuItem btnEntityButtonRowHeight50;
        private System.Windows.Forms.ToolStripMenuItem btnEntityButtonRowHeight100;
        private System.Windows.Forms.ToolStripMenuItem btnEntityButtonRowHeight150;
        private System.Windows.Forms.ToolStripMenuItem btnEntityButtonRowHeight200;
        private System.Windows.Forms.DataGridView dgvStockItems;
        private System.Windows.Forms.Panel pnlEBPicture;
        private System.Windows.Forms.PictureBox pboxEBPicture;
        private System.Windows.Forms.Button btnEBSample;
        private System.Windows.Forms.ToolStrip barStockUsage;
        private System.Windows.Forms.ToolStripButton btnAddStockItem;
        private System.Windows.Forms.ToolStripButton btnEditStockItem;
        private System.Windows.Forms.ToolStripButton btnDeleteStockItem;
        private System.Windows.Forms.ToolStripButton btnZoomStockUsage;
        private System.Windows.Forms.ToolStripButton btnReorderStockUsage;
        private System.Windows.Forms.ToolStripButton btnCopyStockUsageItems;
        private System.Windows.Forms.ToolStripButton btnPasteStockUsageItems;
        private System.Windows.Forms.ToolStripButton btnPasteSpecialStockUsageItems;
        private System.Windows.Forms.ToolStripLabel lblImageSize;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlRightBottom;
        private PosLibrary.Expander expanderRight;
        private System.Windows.Forms.Panel pnlRightTop;
        private PosLibrary.Expander expanderMIddle;
        private System.Windows.Forms.Panel pnlLeftBottom;
        private PosLibrary.Expander expanderLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.ToolStripButton btnCreateDummyMenu;
        private System.Windows.Forms.ToolStripButton mnuSetAsDefaultMenu;
        private System.Windows.Forms.ToolStripButton btnLoadMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockUsageIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityTypeAsString;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBSItemDisplayOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnQuantityToComment;
        private System.Windows.Forms.ToolStripButton btnExportMenuAsJson;
        private System.Windows.Forms.ToolStripButton btnImportMenuFromJSON;
        private System.Windows.Forms.BindingSource theMenuBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource categoryItemBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn colEBDisplayImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBDistributionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBFont;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBDirectSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBInHousePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBTakeAwayPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBDeliveryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBDirectSaleTaxPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBInHouseTaxPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBTakeAwayTaxPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBDeliveryTaxPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBDisplayOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActiveMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOrder;
        private System.Windows.Forms.ToolStripButton tsSortMenu;
        private System.Windows.Forms.ToolStripButton tsMoveUpMenu;
        private System.Windows.Forms.ToolStripButton tsMoveDownMenu;
        private System.Windows.Forms.ToolStripButton tsSortStockItem;
        private System.Windows.Forms.ToolStripButton tsMoveUpStockItem;
        private System.Windows.Forms.ToolStripButton tsMoveDownStockItem;
        private System.Windows.Forms.ToolStripButton tsSortCategoryItem;
        private System.Windows.Forms.ToolStripButton tsMoveUpCategoryItem;
        private System.Windows.Forms.ToolStripButton tsMoveDownCategoryItem;
        private System.Windows.Forms.ToolStripButton tsSortCategory;
        private System.Windows.Forms.ToolStripButton tsMoveUpCategory;
        private System.Windows.Forms.ToolStripButton tsMoveDownCategory;
        private System.Windows.Forms.ToolStripButton btnSaveMenu;
        private System.Windows.Forms.ToolStripButton btnReloadMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
    }
}

