using POSLayer.Library;
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class FrmMenuEditor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.colMenuIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActiveMenu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popEntityButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popEBAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.popEBSetFont = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBSetWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBSetHeight = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBSetPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBSetTaxRate = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBSetToUpperCase = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBSetToLowercase = new System.Windows.Forms.ToolStripMenuItem();
            this.popSetSentenceCase = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBReOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.popEBConvertToStockItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popSetAllForeColourTo = new System.Windows.Forms.ToolStripMenuItem();
            this.popSetAllBackColourTo = new System.Windows.Forms.ToolStripMenuItem();
            this.popSetAllBackColourToTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.popSetAllDistributionTo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.colDisplayImageSearch = new System.Windows.Forms.DataGridViewImageColumn();
            this.colIIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntityButtonNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntityNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityButtonSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearchImagePanel = new System.Windows.Forms.Panel();
            this.pBoxSearchItem = new System.Windows.Forms.PictureBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMenus = new System.Windows.Forms.TabPage();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRightBottom = new System.Windows.Forms.Panel();
            this.dgvStockItems = new System.Windows.Forms.DataGridView();
            this.colStockUsageIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityTypeAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBSItemDisplayOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityButtonStockItemLookUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEBPicture = new System.Windows.Forms.Panel();
            this.pboxEBPicture = new System.Windows.Forms.PictureBox();
            this.btnEBSample = new System.Windows.Forms.Button();
            this.barStockUsage = new System.Windows.Forms.ToolStrip();
            this.btnAddStockItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditStockItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteStockItem = new System.Windows.Forms.ToolStripButton();
            this.btnZoomStockUsage = new System.Windows.Forms.ToolStripButton();
            this.btnReorderStockUsage = new System.Windows.Forms.ToolStripButton();
            this.btnCopyStockUsageItems = new System.Windows.Forms.ToolStripButton();
            this.btnPasteStockUsageItems = new System.Windows.Forms.ToolStripButton();
            this.btnPasteSpecialStockUsageItems = new System.Windows.Forms.ToolStripButton();
            this.lblImageSize = new System.Windows.Forms.ToolStripLabel();
            this.btnQuantityToComment = new System.Windows.Forms.ToolStripButton();
            this.expanderRight = new PosLibrary.Expander();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.dgvEntityButton = new System.Windows.Forms.DataGridView();
            this.colEBDisplayImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEntityButtonIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBParentEntityIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBButtonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBDistributionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBFont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBDirectSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBInHousePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBTakeAwayPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBDeliveryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBDirectSaleTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBInHouseTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBTakeAwayTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBDeliveryTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEBDisplayOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityButtonExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barEntityButton = new System.Windows.Forms.ToolStrip();
            this.btnAddEntityButton = new System.Windows.Forms.ToolStripButton();
            this.btnEditEntityButton = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteEntityButton = new System.Windows.Forms.ToolStripButton();
            this.btnZoomEntityButton = new System.Windows.Forms.ToolStripButton();
            this.btnSetAll = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEBFontTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEBWidthTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEBHeightTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEBPriceTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEBTaxRateTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetUpperCase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetToLowerCase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetSentenceCase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetAllForeColourTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetAllBackColourTo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetAllBackColourToTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeDistributionForEB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveToEntity = new System.Windows.Forms.ToolStripButton();
            this.btnReOrder = new System.Windows.Forms.ToolStripButton();
            this.btnDuplicate = new System.Windows.Forms.ToolStripButton();
            this.btnConvertToStockItem = new System.Windows.Forms.ToolStripButton();
            this.chkIncludeCategoryItemDetails = new System.Windows.Forms.ToolStripButton();
            this.btnEntityButtonRowHeight = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEntityButtonRowHeight25 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntityButtonRowHeight50 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntityButtonRowHeight100 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntityButtonRowHeight150 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntityButtonRowHeight200 = new System.Windows.Forms.ToolStripMenuItem();
            this.expanderMIddle = new PosLibrary.Expander();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftBottom = new System.Windows.Forms.Panel();
            this.dgvEntity = new System.Windows.Forms.DataGridView();
            this.colEntityIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colELHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colELWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colELEntityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colELDistributionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colELFont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colELDisplayOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barEntity = new System.Windows.Forms.ToolStrip();
            this.btnAddEntity = new System.Windows.Forms.ToolStripButton();
            this.btnEditEntity = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteEntity = new System.Windows.Forms.ToolStripButton();
            this.chkIncludeCategoryDetails = new System.Windows.Forms.ToolStripButton();
            this.chkShowHideEntityPreview = new System.Windows.Forms.ToolStripButton();
            this.btnReOrderEntityList = new System.Windows.Forms.ToolStripButton();
            this.btnZoomEntity = new System.Windows.Forms.ToolStripButton();
            this.pnlEntitySample = new System.Windows.Forms.Panel();
            this.btnEntitySample = new System.Windows.Forms.Button();
            this.expanderLeft = new PosLibrary.Expander();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.barMenu = new System.Windows.Forms.ToolStrip();
            this.btnAddMenu = new System.Windows.Forms.ToolStripButton();
            this.btnEditMenu = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMenu = new System.Windows.Forms.ToolStripButton();
            this.btnOtherFunctions = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSetAsDefaultMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportStockManager = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportStockManager = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveDBImagesToFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateDummyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportMenuAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportMenuFromJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSearchCategoryItems = new System.Windows.Forms.TabPage();
            this.barSearchCategoryItems = new System.Windows.Forms.ToolStrip();
            this.txtSearchCategoryButtons = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchCategoryButtons = new System.Windows.Forms.ToolStripButton();
            this.chkAllMenuSearch = new System.Windows.Forms.ToolStripButton();
            this.lblSearchResults = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityButtonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            this.popEntityButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonSearchResultBindingSource)).BeginInit();
            this.pnlSearchImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearchItem)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabMenus.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonStockItemLookUpBindingSource)).BeginInit();
            this.pnlEBPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEBPicture)).BeginInit();
            this.barStockUsage.SuspendLayout();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntityButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonExtendedBindingSource)).BeginInit();
            this.barEntityButton.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
            this.barEntity.SuspendLayout();
            this.pnlEntitySample.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            this.barMenu.SuspendLayout();
            this.tabSearchCategoryItems.SuspendLayout();
            this.barSearchCategoryItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMenuIID,
            this.colMenuName,
            this.IsActiveMenu});
            this.dgvMenu.DataSource = this.catalogBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMenu.Location = new System.Drawing.Point(0, 54);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 15;
            this.dgvMenu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(300, 211);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.DgvMenu_SelectionChanged);
            // 
            // colMenuIID
            // 
            this.colMenuIID.DataPropertyName = "IID";
            this.colMenuIID.HeaderText = "IID";
            this.colMenuIID.Name = "colMenuIID";
            this.colMenuIID.ReadOnly = true;
            this.colMenuIID.Visible = false;
            // 
            // colMenuName
            // 
            this.colMenuName.DataPropertyName = "MenuName";
            this.colMenuName.HeaderText = "Menu";
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.ReadOnly = true;
            this.colMenuName.Width = 200;
            // 
            // IsActiveMenu
            // 
            this.IsActiveMenu.DataPropertyName = "IsActiveMenu";
            this.IsActiveMenu.HeaderText = "Current";
            this.IsActiveMenu.Name = "IsActiveMenu";
            this.IsActiveMenu.ReadOnly = true;
            this.IsActiveMenu.Width = 50;
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataSource = typeof(TheMenu);
            // 
            // popEntityButton
            // 
            this.popEntityButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popEBAddNew,
            this.popEBEdit,
            this.popEBDelete,
            this.toolStripMenuItem1,
            this.popEBSetFont,
            this.popEBSetWidth,
            this.popEBSetHeight,
            this.popEBSetPrice,
            this.popEBSetTaxRate,
            this.popEBSetToUpperCase,
            this.popEBSetToLowercase,
            this.popSetSentenceCase,
            this.popEBMoveTo,
            this.popEBReOrder,
            this.popEBDuplicate,
            this.popEBConvertToStockItem,
            this.popSetAllForeColourTo,
            this.popSetAllBackColourTo,
            this.popSetAllBackColourToTransparent,
            this.popSetAllDistributionTo});
            this.popEntityButton.Name = "popEntityButton";
            this.popEntityButton.Size = new System.Drawing.Size(236, 428);
            // 
            // popEBAddNew
            // 
            this.popEBAddNew.Name = "popEBAddNew";
            this.popEBAddNew.Size = new System.Drawing.Size(235, 22);
            this.popEBAddNew.Text = "Add New";
            this.popEBAddNew.Click += new System.EventHandler(this.BtnAddEntityButton_Click);
            // 
            // popEBEdit
            // 
            this.popEBEdit.Name = "popEBEdit";
            this.popEBEdit.Size = new System.Drawing.Size(235, 22);
            this.popEBEdit.Text = "Edit";
            this.popEBEdit.Click += new System.EventHandler(this.BtnEditEntityButton_Click);
            // 
            // popEBDelete
            // 
            this.popEBDelete.Name = "popEBDelete";
            this.popEBDelete.Size = new System.Drawing.Size(235, 22);
            this.popEBDelete.Text = "Delete";
            this.popEBDelete.Click += new System.EventHandler(this.BtnDeleteEntityButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 6);
            // 
            // popEBSetFont
            // 
            this.popEBSetFont.Name = "popEBSetFont";
            this.popEBSetFont.Size = new System.Drawing.Size(235, 22);
            this.popEBSetFont.Text = "Set Font";
            this.popEBSetFont.Click += new System.EventHandler(this.BtnEBFontTo_Click);
            // 
            // popEBSetWidth
            // 
            this.popEBSetWidth.Name = "popEBSetWidth";
            this.popEBSetWidth.Size = new System.Drawing.Size(235, 22);
            this.popEBSetWidth.Text = "Set Width";
            this.popEBSetWidth.Click += new System.EventHandler(this.BtnEBWidthTo_Click);
            // 
            // popEBSetHeight
            // 
            this.popEBSetHeight.Name = "popEBSetHeight";
            this.popEBSetHeight.Size = new System.Drawing.Size(235, 22);
            this.popEBSetHeight.Text = "Set Height";
            this.popEBSetHeight.Click += new System.EventHandler(this.BtnEBHeightTo_Click);
            // 
            // popEBSetPrice
            // 
            this.popEBSetPrice.Name = "popEBSetPrice";
            this.popEBSetPrice.Size = new System.Drawing.Size(235, 22);
            this.popEBSetPrice.Text = "Set Price";
            this.popEBSetPrice.Click += new System.EventHandler(this.BtnEBPriceTo_Click);
            // 
            // popEBSetTaxRate
            // 
            this.popEBSetTaxRate.Name = "popEBSetTaxRate";
            this.popEBSetTaxRate.Size = new System.Drawing.Size(235, 22);
            this.popEBSetTaxRate.Text = "Set Tax Rate";
            this.popEBSetTaxRate.Click += new System.EventHandler(this.BtnEBTaxRateTo_Click);
            // 
            // popEBSetToUpperCase
            // 
            this.popEBSetToUpperCase.Name = "popEBSetToUpperCase";
            this.popEBSetToUpperCase.Size = new System.Drawing.Size(235, 22);
            this.popEBSetToUpperCase.Text = "Set To UPPERCASE";
            this.popEBSetToUpperCase.Click += new System.EventHandler(this.BtnSetUpperCase_Click);
            // 
            // popEBSetToLowercase
            // 
            this.popEBSetToLowercase.Name = "popEBSetToLowercase";
            this.popEBSetToLowercase.Size = new System.Drawing.Size(235, 22);
            this.popEBSetToLowercase.Text = "Set To lowercase";
            this.popEBSetToLowercase.Click += new System.EventHandler(this.BtnSetToLowerCase_Click);
            // 
            // popSetSentenceCase
            // 
            this.popSetSentenceCase.Name = "popSetSentenceCase";
            this.popSetSentenceCase.Size = new System.Drawing.Size(235, 22);
            this.popSetSentenceCase.Text = "Set To Sentence Case";
            this.popSetSentenceCase.Click += new System.EventHandler(this.BtnSetSentenceCase_Click);
            // 
            // popEBMoveTo
            // 
            this.popEBMoveTo.Name = "popEBMoveTo";
            this.popEBMoveTo.Size = new System.Drawing.Size(235, 22);
            this.popEBMoveTo.Text = "Move To Category";
            this.popEBMoveTo.Click += new System.EventHandler(this.BtnMoveToEntity_Click);
            // 
            // popEBReOrder
            // 
            this.popEBReOrder.Name = "popEBReOrder";
            this.popEBReOrder.Size = new System.Drawing.Size(235, 22);
            this.popEBReOrder.Text = "ReOrder";
            this.popEBReOrder.Click += new System.EventHandler(this.BtnReOrder_Click);
            // 
            // popEBDuplicate
            // 
            this.popEBDuplicate.Name = "popEBDuplicate";
            this.popEBDuplicate.Size = new System.Drawing.Size(235, 22);
            this.popEBDuplicate.Text = "Duplicate";
            this.popEBDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // popEBConvertToStockItem
            // 
            this.popEBConvertToStockItem.Name = "popEBConvertToStockItem";
            this.popEBConvertToStockItem.Size = new System.Drawing.Size(235, 22);
            this.popEBConvertToStockItem.Text = "Convert To Stock Item";
            this.popEBConvertToStockItem.Click += new System.EventHandler(this.BtnConvertToStockItem_Click);
            // 
            // popSetAllForeColourTo
            // 
            this.popSetAllForeColourTo.Name = "popSetAllForeColourTo";
            this.popSetAllForeColourTo.Size = new System.Drawing.Size(235, 22);
            this.popSetAllForeColourTo.Text = "Set ForeColour";
            this.popSetAllForeColourTo.Click += new System.EventHandler(this.BtnSetAllForeColourTo_Click);
            // 
            // popSetAllBackColourTo
            // 
            this.popSetAllBackColourTo.Name = "popSetAllBackColourTo";
            this.popSetAllBackColourTo.Size = new System.Drawing.Size(235, 22);
            this.popSetAllBackColourTo.Text = "Set BackColour";
            this.popSetAllBackColourTo.Click += new System.EventHandler(this.BtnSetAllBackColourTo_Click);
            // 
            // popSetAllBackColourToTransparent
            // 
            this.popSetAllBackColourToTransparent.Name = "popSetAllBackColourToTransparent";
            this.popSetAllBackColourToTransparent.Size = new System.Drawing.Size(235, 22);
            this.popSetAllBackColourToTransparent.Text = "Set BackColour To Transparent";
            this.popSetAllBackColourToTransparent.Click += new System.EventHandler(this.BtnSetAllBackColourToTransparent_Click);
            // 
            // popSetAllDistributionTo
            // 
            this.popSetAllDistributionTo.Name = "popSetAllDistributionTo";
            this.popSetAllDistributionTo.Size = new System.Drawing.Size(235, 22);
            this.popSetAllDistributionTo.Text = "Set Distribution";
            this.popSetAllDistributionTo.Click += new System.EventHandler(this.BtnChangeDistributionForEB_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 667);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1585, 10);
            this.pnlBottom.TabIndex = 3;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoGenerateColumns = false;
            this.dgvSearchResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDisplayImageSearch,
            this.colIIDSearch,
            this.colEntityButtonNameSearch,
            this.colEntityNameSearch});
            this.dgvSearchResults.DataSource = this.entityButtonSearchResultBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSearchResults.Location = new System.Drawing.Point(3, 42);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 25;
            this.dgvSearchResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSearchResults.RowTemplate.Height = 40;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(1371, 584);
            this.dgvSearchResults.TabIndex = 1;
            this.dgvSearchResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchResults_CellDoubleClick);
            this.dgvSearchResults.SelectionChanged += new System.EventHandler(this.DgvSearchResults_SelectionChanged);
            // 
            // colDisplayImageSearch
            // 
            this.colDisplayImageSearch.DataPropertyName = "DisplayImage";
            this.colDisplayImageSearch.HeaderText = "Image";
            this.colDisplayImageSearch.Name = "colDisplayImageSearch";
            this.colDisplayImageSearch.ReadOnly = true;
            this.colDisplayImageSearch.Width = 150;
            // 
            // colIIDSearch
            // 
            this.colIIDSearch.DataPropertyName = "IID";
            this.colIIDSearch.HeaderText = "IID";
            this.colIIDSearch.Name = "colIIDSearch";
            this.colIIDSearch.ReadOnly = true;
            this.colIIDSearch.Visible = false;
            // 
            // colEntityButtonNameSearch
            // 
            this.colEntityButtonNameSearch.DataPropertyName = "EntityButtonName";
            this.colEntityButtonNameSearch.HeaderText = "EntityButtonName";
            this.colEntityButtonNameSearch.Name = "colEntityButtonNameSearch";
            this.colEntityButtonNameSearch.ReadOnly = true;
            this.colEntityButtonNameSearch.Width = 150;
            // 
            // colEntityNameSearch
            // 
            this.colEntityNameSearch.DataPropertyName = "EntityName";
            this.colEntityNameSearch.HeaderText = "EntityName";
            this.colEntityNameSearch.Name = "colEntityNameSearch";
            this.colEntityNameSearch.ReadOnly = true;
            this.colEntityNameSearch.Width = 150;
            // 
            // entityButtonSearchResultBindingSource
            // 
            this.entityButtonSearchResultBindingSource.DataSource = typeof(EntityButtonSearchResult);
            // 
            // pnlSearchImagePanel
            // 
            this.pnlSearchImagePanel.BackColor = System.Drawing.Color.White;
            this.pnlSearchImagePanel.Controls.Add(this.pBoxSearchItem);
            this.pnlSearchImagePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSearchImagePanel.Location = new System.Drawing.Point(1374, 42);
            this.pnlSearchImagePanel.Name = "pnlSearchImagePanel";
            this.pnlSearchImagePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSearchImagePanel.Size = new System.Drawing.Size(200, 584);
            this.pnlSearchImagePanel.TabIndex = 2;
            // 
            // pBoxSearchItem
            // 
            this.pBoxSearchItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBoxSearchItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBoxSearchItem.Location = new System.Drawing.Point(0, 10);
            this.pBoxSearchItem.Name = "pBoxSearchItem";
            this.pBoxSearchItem.Size = new System.Drawing.Size(200, 250);
            this.pBoxSearchItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSearchItem.TabIndex = 0;
            this.pBoxSearchItem.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabMenus);
            this.tabMain.Controls.Add(this.tabSearchCategoryItems);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(180, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1585, 667);
            this.tabMain.TabIndex = 13;
            // 
            // tabMenus
            // 
            this.tabMenus.Controls.Add(this.pnlRight);
            this.tabMenus.Controls.Add(this.expanderMIddle);
            this.tabMenus.Controls.Add(this.pnlLeft);
            this.tabMenus.Location = new System.Drawing.Point(4, 34);
            this.tabMenus.Name = "tabMenus";
            this.tabMenus.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenus.Size = new System.Drawing.Size(1577, 629);
            this.tabMenus.TabIndex = 2;
            this.tabMenus.Text = "MENUS";
            this.tabMenus.UseVisualStyleBackColor = true;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRightBottom);
            this.pnlRight.Controls.Add(this.expanderRight);
            this.pnlRight.Controls.Add(this.pnlRightTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(323, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1251, 623);
            this.pnlRight.TabIndex = 8;
            // 
            // pnlRightBottom
            // 
            this.pnlRightBottom.Controls.Add(this.dgvStockItems);
            this.pnlRightBottom.Controls.Add(this.pnlEBPicture);
            this.pnlRightBottom.Controls.Add(this.barStockUsage);
            this.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlRightBottom.Name = "pnlRightBottom";
            this.pnlRightBottom.Size = new System.Drawing.Size(1251, 203);
            this.pnlRightBottom.TabIndex = 2;
            // 
            // dgvStockItems
            // 
            this.dgvStockItems.AllowDrop = true;
            this.dgvStockItems.AllowUserToAddRows = false;
            this.dgvStockItems.AllowUserToDeleteRows = false;
            this.dgvStockItems.AutoGenerateColumns = false;
            this.dgvStockItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStockItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockUsageIID,
            this.colEBIID,
            this.colStockItemIID,
            this.Quantity,
            this.QuantityTypeAsString,
            this.StockName,
            this.Comment,
            this.colEBSItemDisplayOrder});
            this.dgvStockItems.DataSource = this.entityButtonStockItemLookUpBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStockItems.Location = new System.Drawing.Point(140, 54);
            this.dgvStockItems.Name = "dgvStockItems";
            this.dgvStockItems.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStockItems.RowHeadersWidth = 25;
            this.dgvStockItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvStockItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockItems.Size = new System.Drawing.Size(1111, 149);
            this.dgvStockItems.TabIndex = 11;
            this.dgvStockItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockItems_CellDoubleClick);
            this.dgvStockItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvStockItems_DragDrop);
            this.dgvStockItems.DragOver += new System.Windows.Forms.DragEventHandler(this.Dgv_DragOver);
            this.dgvStockItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDown);
            this.dgvStockItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseMove);
            // 
            // colStockUsageIID
            // 
            this.colStockUsageIID.DataPropertyName = "IID";
            this.colStockUsageIID.HeaderText = "IID";
            this.colStockUsageIID.Name = "colStockUsageIID";
            this.colStockUsageIID.ReadOnly = true;
            this.colStockUsageIID.Visible = false;
            this.colStockUsageIID.Width = 5;
            // 
            // colEBIID
            // 
            this.colEBIID.DataPropertyName = "EntityButtonIID";
            this.colEBIID.HeaderText = "EBIID";
            this.colEBIID.Name = "colEBIID";
            this.colEBIID.ReadOnly = true;
            this.colEBIID.Visible = false;
            // 
            // colStockItemIID
            // 
            this.colStockItemIID.DataPropertyName = "StockItemIID";
            this.colStockItemIID.HeaderText = "StockItemIID";
            this.colStockItemIID.Name = "colStockItemIID";
            this.colStockItemIID.ReadOnly = true;
            this.colStockItemIID.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "Stock Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 120;
            // 
            // QuantityTypeAsString
            // 
            this.QuantityTypeAsString.DataPropertyName = "QuantityTypeAsString";
            this.QuantityTypeAsString.HeaderText = "Quantity Type";
            this.QuantityTypeAsString.Name = "QuantityTypeAsString";
            this.QuantityTypeAsString.ReadOnly = true;
            // 
            // StockName
            // 
            this.StockName.DataPropertyName = "StockName";
            this.StockName.HeaderText = "Stock Item";
            this.StockName.Name = "StockName";
            this.StockName.ReadOnly = true;
            this.StockName.Width = 150;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 150;
            // 
            // colEBSItemDisplayOrder
            // 
            this.colEBSItemDisplayOrder.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEBSItemDisplayOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEBSItemDisplayOrder.HeaderText = "Order";
            this.colEBSItemDisplayOrder.Name = "colEBSItemDisplayOrder";
            this.colEBSItemDisplayOrder.ReadOnly = true;
            this.colEBSItemDisplayOrder.ToolTipText = "Display Order";
            this.colEBSItemDisplayOrder.Width = 50;
            // 
            // entityButtonStockItemLookUpBindingSource
            // 
            this.entityButtonStockItemLookUpBindingSource.DataSource = typeof(EntityButtonStockItemLookUp);
            // 
            // pnlEBPicture
            // 
            this.pnlEBPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlEBPicture.Controls.Add(this.pboxEBPicture);
            this.pnlEBPicture.Controls.Add(this.btnEBSample);
            this.pnlEBPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEBPicture.Location = new System.Drawing.Point(0, 54);
            this.pnlEBPicture.Name = "pnlEBPicture";
            this.pnlEBPicture.Size = new System.Drawing.Size(140, 149);
            this.pnlEBPicture.TabIndex = 10;
            // 
            // pboxEBPicture
            // 
            this.pboxEBPicture.BackColor = System.Drawing.Color.White;
            this.pboxEBPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxEBPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pboxEBPicture.Location = new System.Drawing.Point(0, 160);
            this.pboxEBPicture.Name = "pboxEBPicture";
            this.pboxEBPicture.Size = new System.Drawing.Size(140, 0);
            this.pboxEBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEBPicture.TabIndex = 10;
            this.pboxEBPicture.TabStop = false;
            this.pboxEBPicture.DoubleClick += new System.EventHandler(this.pboxEBPicture_DoubleClick);
            // 
            // btnEBSample
            // 
            this.btnEBSample.BackColor = System.Drawing.Color.White;
            this.btnEBSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEBSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEBSample.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEBSample.Location = new System.Drawing.Point(0, 0);
            this.btnEBSample.Name = "btnEBSample";
            this.btnEBSample.Size = new System.Drawing.Size(140, 160);
            this.btnEBSample.TabIndex = 9;
            this.btnEBSample.UseVisualStyleBackColor = false;
            // 
            // barStockUsage
            // 
            this.barStockUsage.Enabled = false;
            this.barStockUsage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStockItem,
            this.btnEditStockItem,
            this.btnDeleteStockItem,
            this.btnZoomStockUsage,
            this.btnReorderStockUsage,
            this.btnCopyStockUsageItems,
            this.btnPasteStockUsageItems,
            this.btnPasteSpecialStockUsageItems,
            this.lblImageSize,
            this.btnQuantityToComment});
            this.barStockUsage.Location = new System.Drawing.Point(0, 0);
            this.barStockUsage.Name = "barStockUsage";
            this.barStockUsage.Size = new System.Drawing.Size(1251, 54);
            this.barStockUsage.TabIndex = 1;
            this.barStockUsage.Text = "toolStrip1";
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnAddStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(51, 51);
            this.btnAddStockItem.Text = "   Add   ";
            this.btnAddStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddStockItem.Click += new System.EventHandler(this.BtnAddStockItem_Click);
            // 
            // btnEditStockItem
            // 
            this.btnEditStockItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.btnEditStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditStockItem.Name = "btnEditStockItem";
            this.btnEditStockItem.Size = new System.Drawing.Size(43, 51);
            this.btnEditStockItem.Text = "  Edit  ";
            this.btnEditStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditStockItem.Click += new System.EventHandler(this.BtnEditStockItem_Click);
            // 
            // btnDeleteStockItem
            // 
            this.btnDeleteStockItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDeleteStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteStockItem.Name = "btnDeleteStockItem";
            this.btnDeleteStockItem.Size = new System.Drawing.Size(50, 51);
            this.btnDeleteStockItem.Text = " Delete ";
            this.btnDeleteStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteStockItem.Click += new System.EventHandler(this.BtnDeleteStockItem_Click);
            // 
            // btnZoomStockUsage
            // 
            this.btnZoomStockUsage.Image = global::DTRMSimpleBackOffice.Properties.Resources.View32;
            this.btnZoomStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomStockUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomStockUsage.Name = "btnZoomStockUsage";
            this.btnZoomStockUsage.Size = new System.Drawing.Size(43, 51);
            this.btnZoomStockUsage.Text = "Zoom";
            this.btnZoomStockUsage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZoomStockUsage.Click += new System.EventHandler(this.BtnZoomStockUsage_Click);
            // 
            // btnReorderStockUsage
            // 
            this.btnReorderStockUsage.Image = global::DTRMSimpleBackOffice.Properties.Resources.ExpandHeight32;
            this.btnReorderStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReorderStockUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReorderStockUsage.Name = "btnReorderStockUsage";
            this.btnReorderStockUsage.Size = new System.Drawing.Size(54, 51);
            this.btnReorderStockUsage.Text = "ReOrder";
            this.btnReorderStockUsage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReorderStockUsage.Click += new System.EventHandler(this.BtnReorderStockUsage_Click);
            // 
            // btnCopyStockUsageItems
            // 
            this.btnCopyStockUsageItems.Image = global::DTRMSimpleBackOffice.Properties.Resources.WindowCascade;
            this.btnCopyStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopyStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyStockUsageItems.Name = "btnCopyStockUsageItems";
            this.btnCopyStockUsageItems.Size = new System.Drawing.Size(71, 51);
            this.btnCopyStockUsageItems.Text = "Copy Items";
            this.btnCopyStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopyStockUsageItems.Click += new System.EventHandler(this.BtnCopyStockUsageItems_Click);
            // 
            // btnPasteStockUsageItems
            // 
            this.btnPasteStockUsageItems.Image = global::DTRMSimpleBackOffice.Properties.Resources.Paste232;
            this.btnPasteStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPasteStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteStockUsageItems.Name = "btnPasteStockUsageItems";
            this.btnPasteStockUsageItems.Size = new System.Drawing.Size(71, 51);
            this.btnPasteStockUsageItems.Text = "Paste Items";
            this.btnPasteStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPasteStockUsageItems.Click += new System.EventHandler(this.BtnPasteStockUsageItems_Click);
            // 
            // btnPasteSpecialStockUsageItems
            // 
            this.btnPasteSpecialStockUsageItems.Image = global::DTRMSimpleBackOffice.Properties.Resources.Paste232;
            this.btnPasteSpecialStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPasteSpecialStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteSpecialStockUsageItems.Name = "btnPasteSpecialStockUsageItems";
            this.btnPasteSpecialStockUsageItems.Size = new System.Drawing.Size(125, 51);
            this.btnPasteSpecialStockUsageItems.Text = "Paste And Keep Items";
            this.btnPasteSpecialStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPasteSpecialStockUsageItems.Click += new System.EventHandler(this.BtnPasteSpecialStockUsageItems_Click);
            // 
            // lblImageSize
            // 
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(24, 51);
            this.lblImageSize.Text = "0x0";
            // 
            // btnQuantityToComment
            // 
            this.btnQuantityToComment.Image = global::DTRMSimpleBackOffice.Properties.Resources.copy_black_24dp1;
            this.btnQuantityToComment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQuantityToComment.Name = "btnQuantityToComment";
            this.btnQuantityToComment.Size = new System.Drawing.Size(63, 51);
            this.btnQuantityToComment.Text = "Q to Com";
            this.btnQuantityToComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuantityToComment.Click += new System.EventHandler(this.btnQuantityToComment_Click);
            // 
            // expanderRight
            // 
            this.expanderRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expanderRight.Caption = "";
            this.expanderRight.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expanderRight.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expanderRight.CaptionForeColor = System.Drawing.Color.White;
            this.expanderRight.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.expanderRight.ColourFixed = System.Drawing.Color.Salmon;
            this.expanderRight.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expanderRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.expanderRight.ExpandableControl = this.pnlRightTop;
            this.expanderRight.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expanderRight.Expanded = true;
            this.expanderRight.Fixed = false;
            this.expanderRight.Location = new System.Drawing.Point(0, 400);
            this.expanderRight.LockButtonDock = System.Windows.Forms.DockStyle.Left;
            this.expanderRight.LockButtonSize = new System.Drawing.Size(32, 18);
            this.expanderRight.LockButtonVisible = false;
            this.expanderRight.MinimumSize = new System.Drawing.Size(5, 5);
            this.expanderRight.Name = "expanderRight";
            this.expanderRight.Size = new System.Drawing.Size(1251, 20);
            this.expanderRight.TabIndex = 1;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.dgvEntityButton);
            this.pnlRightTop.Controls.Add(this.barEntityButton);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(1251, 400);
            this.pnlRightTop.TabIndex = 0;
            // 
            // dgvEntityButton
            // 
            this.dgvEntityButton.AllowDrop = true;
            this.dgvEntityButton.AllowUserToAddRows = false;
            this.dgvEntityButton.AllowUserToDeleteRows = false;
            this.dgvEntityButton.AllowUserToOrderColumns = true;
            this.dgvEntityButton.AutoGenerateColumns = false;
            this.dgvEntityButton.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEntityButton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntityButton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEBDisplayImage,
            this.colEntityButtonIID,
            this.colEBParentEntityIID,
            this.colEBButtonName,
            this.colEBWidth,
            this.colEBHeight,
            this.colEBDistributionName,
            this.colEBFont,
            this.buttonTypeDataGridViewTextBoxColumn,
            this.colEBDirectSalePrice,
            this.colEBInHousePrice,
            this.colEBTakeAwayPrice,
            this.colEBDeliveryPrice,
            this.colEBDirectSaleTaxPercent,
            this.colEBInHouseTaxPercent,
            this.colEBTakeAwayTaxPercent,
            this.colEBDeliveryTaxPercent,
            this.colEBDisplayOrder});
            this.dgvEntityButton.ContextMenuStrip = this.popEntityButton;
            this.dgvEntityButton.DataSource = this.entityButtonExtendedBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntityButton.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEntityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntityButton.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEntityButton.Location = new System.Drawing.Point(0, 54);
            this.dgvEntityButton.Name = "dgvEntityButton";
            this.dgvEntityButton.ReadOnly = true;
            this.dgvEntityButton.RowHeadersWidth = 25;
            this.dgvEntityButton.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvEntityButton.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntityButton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntityButton.Size = new System.Drawing.Size(1251, 346);
            this.dgvEntityButton.TabIndex = 0;
            this.dgvEntityButton.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEntityButton_CellDoubleClick);
            this.dgvEntityButton.SelectionChanged += new System.EventHandler(this.DgvEntityButton_SelectionChanged);
            this.dgvEntityButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvEntityButton_DragDrop);
            this.dgvEntityButton.DragOver += new System.Windows.Forms.DragEventHandler(this.Dgv_DragOver);
            this.dgvEntityButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDown);
            this.dgvEntityButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseMove);
            // 
            // colEBDisplayImage
            // 
            this.colEBDisplayImage.DataPropertyName = "DisplayImage";
            this.colEBDisplayImage.HeaderText = "";
            this.colEBDisplayImage.Name = "colEBDisplayImage";
            this.colEBDisplayImage.ReadOnly = true;
            this.colEBDisplayImage.Width = 80;
            // 
            // colEntityButtonIID
            // 
            this.colEntityButtonIID.DataPropertyName = "IID";
            this.colEntityButtonIID.HeaderText = "IID";
            this.colEntityButtonIID.Name = "colEntityButtonIID";
            this.colEntityButtonIID.ReadOnly = true;
            this.colEntityButtonIID.Visible = false;
            // 
            // colEBParentEntityIID
            // 
            this.colEBParentEntityIID.DataPropertyName = "PEIID";
            this.colEBParentEntityIID.HeaderText = "PEIID";
            this.colEBParentEntityIID.Name = "colEBParentEntityIID";
            this.colEBParentEntityIID.ReadOnly = true;
            this.colEBParentEntityIID.Visible = false;
            // 
            // colEBButtonName
            // 
            this.colEBButtonName.DataPropertyName = "EntityButtonName";
            this.colEBButtonName.HeaderText = "Button";
            this.colEBButtonName.Name = "colEBButtonName";
            this.colEBButtonName.ReadOnly = true;
            this.colEBButtonName.Width = 170;
            // 
            // colEBWidth
            // 
            this.colEBWidth.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0\" px\"";
            this.colEBWidth.DefaultCellStyle = dataGridViewCellStyle8;
            this.colEBWidth.HeaderText = "Width";
            this.colEBWidth.Name = "colEBWidth";
            this.colEBWidth.ReadOnly = true;
            this.colEBWidth.Visible = false;
            this.colEBWidth.Width = 50;
            // 
            // colEBHeight
            // 
            this.colEBHeight.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0\" px\"";
            this.colEBHeight.DefaultCellStyle = dataGridViewCellStyle9;
            this.colEBHeight.HeaderText = "Height";
            this.colEBHeight.Name = "colEBHeight";
            this.colEBHeight.ReadOnly = true;
            this.colEBHeight.Visible = false;
            this.colEBHeight.Width = 50;
            // 
            // colEBDistributionName
            // 
            this.colEBDistributionName.DataPropertyName = "DistributionName";
            this.colEBDistributionName.HeaderText = "Distribution";
            this.colEBDistributionName.Name = "colEBDistributionName";
            this.colEBDistributionName.ReadOnly = true;
            this.colEBDistributionName.Width = 170;
            // 
            // colEBFont
            // 
            this.colEBFont.DataPropertyName = "Font";
            this.colEBFont.HeaderText = "Font";
            this.colEBFont.Name = "colEBFont";
            this.colEBFont.ReadOnly = true;
            // 
            // buttonTypeDataGridViewTextBoxColumn
            // 
            this.buttonTypeDataGridViewTextBoxColumn.DataPropertyName = "ButtonType";
            this.buttonTypeDataGridViewTextBoxColumn.HeaderText = "ButtonType";
            this.buttonTypeDataGridViewTextBoxColumn.Name = "buttonTypeDataGridViewTextBoxColumn";
            this.buttonTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.buttonTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // colEBDirectSalePrice
            // 
            this.colEBDirectSalePrice.DataPropertyName = "DirectSalePrice";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "c2";
            dataGridViewCellStyle10.NullValue = null;
            this.colEBDirectSalePrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.colEBDirectSalePrice.HeaderText = "DS Price";
            this.colEBDirectSalePrice.Name = "colEBDirectSalePrice";
            this.colEBDirectSalePrice.ReadOnly = true;
            this.colEBDirectSalePrice.ToolTipText = "Direct Sale Price";
            this.colEBDirectSalePrice.Width = 75;
            // 
            // colEBInHousePrice
            // 
            this.colEBInHousePrice.DataPropertyName = "InHousePrice";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "c2";
            this.colEBInHousePrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.colEBInHousePrice.HeaderText = "IH Price";
            this.colEBInHousePrice.Name = "colEBInHousePrice";
            this.colEBInHousePrice.ReadOnly = true;
            this.colEBInHousePrice.ToolTipText = "InHouse Price";
            this.colEBInHousePrice.Width = 75;
            // 
            // colEBTakeAwayPrice
            // 
            this.colEBTakeAwayPrice.DataPropertyName = "TakeAwayPrice";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "c2";
            this.colEBTakeAwayPrice.DefaultCellStyle = dataGridViewCellStyle12;
            this.colEBTakeAwayPrice.HeaderText = "TA Price";
            this.colEBTakeAwayPrice.Name = "colEBTakeAwayPrice";
            this.colEBTakeAwayPrice.ReadOnly = true;
            this.colEBTakeAwayPrice.ToolTipText = "Take Away Price";
            this.colEBTakeAwayPrice.Width = 75;
            // 
            // colEBDeliveryPrice
            // 
            this.colEBDeliveryPrice.DataPropertyName = "DeliveryPrice";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "c2";
            this.colEBDeliveryPrice.DefaultCellStyle = dataGridViewCellStyle13;
            this.colEBDeliveryPrice.HeaderText = "DL Price";
            this.colEBDeliveryPrice.Name = "colEBDeliveryPrice";
            this.colEBDeliveryPrice.ReadOnly = true;
            this.colEBDeliveryPrice.ToolTipText = "Delivery Price";
            this.colEBDeliveryPrice.Width = 75;
            // 
            // colEBDirectSaleTaxPercent
            // 
            this.colEBDirectSaleTaxPercent.DataPropertyName = "DirectSaleTaxPercent";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "0\" %\"";
            dataGridViewCellStyle14.NullValue = null;
            this.colEBDirectSaleTaxPercent.DefaultCellStyle = dataGridViewCellStyle14;
            this.colEBDirectSaleTaxPercent.HeaderText = "DS Tax%";
            this.colEBDirectSaleTaxPercent.Name = "colEBDirectSaleTaxPercent";
            this.colEBDirectSaleTaxPercent.ReadOnly = true;
            this.colEBDirectSaleTaxPercent.ToolTipText = "Direct Sale Tax";
            this.colEBDirectSaleTaxPercent.Width = 80;
            // 
            // colEBInHouseTaxPercent
            // 
            this.colEBInHouseTaxPercent.DataPropertyName = "InHouseTaxPercent";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "0\" %\"";
            this.colEBInHouseTaxPercent.DefaultCellStyle = dataGridViewCellStyle15;
            this.colEBInHouseTaxPercent.HeaderText = "IH Tax%";
            this.colEBInHouseTaxPercent.Name = "colEBInHouseTaxPercent";
            this.colEBInHouseTaxPercent.ReadOnly = true;
            this.colEBInHouseTaxPercent.ToolTipText = "InHouse Tax";
            this.colEBInHouseTaxPercent.Width = 80;
            // 
            // colEBTakeAwayTaxPercent
            // 
            this.colEBTakeAwayTaxPercent.DataPropertyName = "TakeAwayTaxPercent";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "0\" %\"";
            this.colEBTakeAwayTaxPercent.DefaultCellStyle = dataGridViewCellStyle16;
            this.colEBTakeAwayTaxPercent.HeaderText = "TA Tax%";
            this.colEBTakeAwayTaxPercent.Name = "colEBTakeAwayTaxPercent";
            this.colEBTakeAwayTaxPercent.ReadOnly = true;
            this.colEBTakeAwayTaxPercent.ToolTipText = "TakeAway Tax";
            this.colEBTakeAwayTaxPercent.Width = 80;
            // 
            // colEBDeliveryTaxPercent
            // 
            this.colEBDeliveryTaxPercent.DataPropertyName = "DeliveryTaxPercent";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "0\" %\"";
            this.colEBDeliveryTaxPercent.DefaultCellStyle = dataGridViewCellStyle17;
            this.colEBDeliveryTaxPercent.HeaderText = "DL Tax%";
            this.colEBDeliveryTaxPercent.Name = "colEBDeliveryTaxPercent";
            this.colEBDeliveryTaxPercent.ReadOnly = true;
            this.colEBDeliveryTaxPercent.ToolTipText = "Delivery Tax";
            this.colEBDeliveryTaxPercent.Width = 80;
            // 
            // colEBDisplayOrder
            // 
            this.colEBDisplayOrder.DataPropertyName = "DisplayOrder";
            this.colEBDisplayOrder.HeaderText = "Order";
            this.colEBDisplayOrder.Name = "colEBDisplayOrder";
            this.colEBDisplayOrder.ReadOnly = true;
            this.colEBDisplayOrder.ToolTipText = "Display Order";
            this.colEBDisplayOrder.Width = 50;
            // 
            // entityButtonExtendedBindingSource
            // 
            this.entityButtonExtendedBindingSource.DataSource = typeof(EntityButtonExtended);
            // 
            // barEntityButton
            // 
            this.barEntityButton.Enabled = false;
            this.barEntityButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEntityButton,
            this.btnEditEntityButton,
            this.btnDeleteEntityButton,
            this.btnZoomEntityButton,
            this.btnSetAll,
            this.btnMoveToEntity,
            this.btnReOrder,
            this.btnDuplicate,
            this.btnConvertToStockItem,
            this.chkIncludeCategoryItemDetails,
            this.btnEntityButtonRowHeight});
            this.barEntityButton.Location = new System.Drawing.Point(0, 0);
            this.barEntityButton.Name = "barEntityButton";
            this.barEntityButton.Size = new System.Drawing.Size(1251, 54);
            this.barEntityButton.TabIndex = 0;
            this.barEntityButton.Text = "toolStrip1";
            // 
            // btnAddEntityButton
            // 
            this.btnAddEntityButton.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnAddEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEntityButton.Name = "btnAddEntityButton";
            this.btnAddEntityButton.Size = new System.Drawing.Size(45, 51);
            this.btnAddEntityButton.Text = "  Add  ";
            this.btnAddEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEntityButton.Click += new System.EventHandler(this.BtnAddEntityButton_Click);
            // 
            // btnEditEntityButton
            // 
            this.btnEditEntityButton.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.btnEditEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEntityButton.Name = "btnEditEntityButton";
            this.btnEditEntityButton.Size = new System.Drawing.Size(43, 51);
            this.btnEditEntityButton.Text = "  Edit  ";
            this.btnEditEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditEntityButton.Click += new System.EventHandler(this.BtnEditEntityButton_Click);
            // 
            // btnDeleteEntityButton
            // 
            this.btnDeleteEntityButton.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDeleteEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteEntityButton.Name = "btnDeleteEntityButton";
            this.btnDeleteEntityButton.Size = new System.Drawing.Size(50, 51);
            this.btnDeleteEntityButton.Text = " Delete ";
            this.btnDeleteEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteEntityButton.Click += new System.EventHandler(this.BtnDeleteEntityButton_Click);
            // 
            // btnZoomEntityButton
            // 
            this.btnZoomEntityButton.Image = global::DTRMSimpleBackOffice.Properties.Resources.View32;
            this.btnZoomEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomEntityButton.Name = "btnZoomEntityButton";
            this.btnZoomEntityButton.Size = new System.Drawing.Size(55, 51);
            this.btnZoomEntityButton.Text = "  Zoom  ";
            this.btnZoomEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZoomEntityButton.Click += new System.EventHandler(this.BtnZoomEntityButton_Click);
            // 
            // btnSetAll
            // 
            this.btnSetAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEBFontTo,
            this.btnEBWidthTo,
            this.btnEBHeightTo,
            this.btnEBPriceTo,
            this.btnEBTaxRateTo,
            this.btnSetUpperCase,
            this.btnSetToLowerCase,
            this.btnSetSentenceCase,
            this.btnSetAllForeColourTo,
            this.btnSetAllBackColourTo,
            this.btnSetAllBackColourToTransparent,
            this.btnChangeDistributionForEB});
            this.btnSetAll.Image = global::DTRMSimpleBackOffice.Properties.Resources.disli32;
            this.btnSetAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSetAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetAll.Name = "btnSetAll";
            this.btnSetAll.Size = new System.Drawing.Size(68, 51);
            this.btnSetAll.Text = " SET ALL ";
            this.btnSetAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnEBFontTo
            // 
            this.btnEBFontTo.Name = "btnEBFontTo";
            this.btnEBFontTo.Size = new System.Drawing.Size(216, 22);
            this.btnEBFontTo.Text = "Font To";
            this.btnEBFontTo.Click += new System.EventHandler(this.BtnEBFontTo_Click);
            // 
            // btnEBWidthTo
            // 
            this.btnEBWidthTo.Name = "btnEBWidthTo";
            this.btnEBWidthTo.Size = new System.Drawing.Size(216, 22);
            this.btnEBWidthTo.Text = "Width To";
            this.btnEBWidthTo.Click += new System.EventHandler(this.BtnEBWidthTo_Click);
            // 
            // btnEBHeightTo
            // 
            this.btnEBHeightTo.Name = "btnEBHeightTo";
            this.btnEBHeightTo.Size = new System.Drawing.Size(216, 22);
            this.btnEBHeightTo.Text = "Height To";
            this.btnEBHeightTo.Click += new System.EventHandler(this.BtnEBHeightTo_Click);
            // 
            // btnEBPriceTo
            // 
            this.btnEBPriceTo.Name = "btnEBPriceTo";
            this.btnEBPriceTo.Size = new System.Drawing.Size(216, 22);
            this.btnEBPriceTo.Text = "Price To";
            this.btnEBPriceTo.Click += new System.EventHandler(this.BtnEBPriceTo_Click);
            // 
            // btnEBTaxRateTo
            // 
            this.btnEBTaxRateTo.Name = "btnEBTaxRateTo";
            this.btnEBTaxRateTo.Size = new System.Drawing.Size(216, 22);
            this.btnEBTaxRateTo.Text = "Tax Rate To";
            this.btnEBTaxRateTo.Click += new System.EventHandler(this.BtnEBTaxRateTo_Click);
            // 
            // btnSetUpperCase
            // 
            this.btnSetUpperCase.Name = "btnSetUpperCase";
            this.btnSetUpperCase.Size = new System.Drawing.Size(216, 22);
            this.btnSetUpperCase.Text = "Set To UPPER CASE";
            this.btnSetUpperCase.Click += new System.EventHandler(this.BtnSetUpperCase_Click);
            // 
            // btnSetToLowerCase
            // 
            this.btnSetToLowerCase.Name = "btnSetToLowerCase";
            this.btnSetToLowerCase.Size = new System.Drawing.Size(216, 22);
            this.btnSetToLowerCase.Text = "Set To lower case";
            this.btnSetToLowerCase.Click += new System.EventHandler(this.BtnSetToLowerCase_Click);
            // 
            // btnSetSentenceCase
            // 
            this.btnSetSentenceCase.Name = "btnSetSentenceCase";
            this.btnSetSentenceCase.Size = new System.Drawing.Size(216, 22);
            this.btnSetSentenceCase.Text = "Set To Sentence Case";
            this.btnSetSentenceCase.Click += new System.EventHandler(this.BtnSetSentenceCase_Click);
            // 
            // btnSetAllForeColourTo
            // 
            this.btnSetAllForeColourTo.Name = "btnSetAllForeColourTo";
            this.btnSetAllForeColourTo.Size = new System.Drawing.Size(216, 22);
            this.btnSetAllForeColourTo.Text = "ForeColour To";
            this.btnSetAllForeColourTo.Click += new System.EventHandler(this.BtnSetAllForeColourTo_Click);
            // 
            // btnSetAllBackColourTo
            // 
            this.btnSetAllBackColourTo.Name = "btnSetAllBackColourTo";
            this.btnSetAllBackColourTo.Size = new System.Drawing.Size(216, 22);
            this.btnSetAllBackColourTo.Text = "BackColour To";
            this.btnSetAllBackColourTo.Click += new System.EventHandler(this.BtnSetAllBackColourTo_Click);
            // 
            // btnSetAllBackColourToTransparent
            // 
            this.btnSetAllBackColourToTransparent.Name = "btnSetAllBackColourToTransparent";
            this.btnSetAllBackColourToTransparent.Size = new System.Drawing.Size(216, 22);
            this.btnSetAllBackColourToTransparent.Text = "BackColour To Transparent";
            this.btnSetAllBackColourToTransparent.Click += new System.EventHandler(this.BtnSetAllBackColourToTransparent_Click);
            // 
            // btnChangeDistributionForEB
            // 
            this.btnChangeDistributionForEB.Name = "btnChangeDistributionForEB";
            this.btnChangeDistributionForEB.Size = new System.Drawing.Size(216, 22);
            this.btnChangeDistributionForEB.Text = "Distribution To";
            this.btnChangeDistributionForEB.Click += new System.EventHandler(this.BtnChangeDistributionForEB_Click);
            // 
            // btnMoveToEntity
            // 
            this.btnMoveToEntity.Image = global::DTRMSimpleBackOffice.Properties.Resources.Curve;
            this.btnMoveToEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMoveToEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveToEntity.Name = "btnMoveToEntity";
            this.btnMoveToEntity.Size = new System.Drawing.Size(57, 51);
            this.btnMoveToEntity.Text = "Move To";
            this.btnMoveToEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoveToEntity.Click += new System.EventHandler(this.BtnMoveToEntity_Click);
            // 
            // btnReOrder
            // 
            this.btnReOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.ExpandHeight32;
            this.btnReOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(54, 51);
            this.btnReOrder.Text = "ReOrder";
            this.btnReOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReOrder.Click += new System.EventHandler(this.BtnReOrder_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Image = global::DTRMSimpleBackOffice.Properties.Resources.WindowCascade;
            this.btnDuplicate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(61, 51);
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // btnConvertToStockItem
            // 
            this.btnConvertToStockItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.DBDestination32;
            this.btnConvertToStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConvertToStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConvertToStockItem.Name = "btnConvertToStockItem";
            this.btnConvertToStockItem.Size = new System.Drawing.Size(128, 51);
            this.btnConvertToStockItem.Text = "Convert To Stock Item";
            this.btnConvertToStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConvertToStockItem.Click += new System.EventHandler(this.BtnConvertToStockItem_Click);
            // 
            // chkIncludeCategoryItemDetails
            // 
            this.chkIncludeCategoryItemDetails.CheckOnClick = true;
            this.chkIncludeCategoryItemDetails.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkIncludeCategoryItemDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkIncludeCategoryItemDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkIncludeCategoryItemDetails.Name = "chkIncludeCategoryItemDetails";
            this.chkIncludeCategoryItemDetails.Size = new System.Drawing.Size(68, 51);
            this.chkIncludeCategoryItemDetails.Text = "Full Details";
            this.chkIncludeCategoryItemDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkIncludeCategoryItemDetails.Click += new System.EventHandler(this.chkIncludeCategoryItemDetails_CheckedChanged);
            // 
            // btnEntityButtonRowHeight
            // 
            this.btnEntityButtonRowHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEntityButtonRowHeight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEntityButtonRowHeight25,
            this.btnEntityButtonRowHeight50,
            this.btnEntityButtonRowHeight100,
            this.btnEntityButtonRowHeight150,
            this.btnEntityButtonRowHeight200});
            this.btnEntityButtonRowHeight.Image = ((System.Drawing.Image)(resources.GetObject("btnEntityButtonRowHeight.Image")));
            this.btnEntityButtonRowHeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntityButtonRowHeight.Name = "btnEntityButtonRowHeight";
            this.btnEntityButtonRowHeight.Size = new System.Drawing.Size(82, 51);
            this.btnEntityButtonRowHeight.Text = "Row Height";
            // 
            // btnEntityButtonRowHeight25
            // 
            this.btnEntityButtonRowHeight25.Name = "btnEntityButtonRowHeight25";
            this.btnEntityButtonRowHeight25.Size = new System.Drawing.Size(160, 22);
            this.btnEntityButtonRowHeight25.Tag = "25";
            this.btnEntityButtonRowHeight25.Text = "Small (25)";
            this.btnEntityButtonRowHeight25.Click += new System.EventHandler(this.btnEntityButtonRowHeight_Click);
            // 
            // btnEntityButtonRowHeight50
            // 
            this.btnEntityButtonRowHeight50.Name = "btnEntityButtonRowHeight50";
            this.btnEntityButtonRowHeight50.Size = new System.Drawing.Size(160, 22);
            this.btnEntityButtonRowHeight50.Tag = "50";
            this.btnEntityButtonRowHeight50.Text = "Medium (50)";
            this.btnEntityButtonRowHeight50.Click += new System.EventHandler(this.btnEntityButtonRowHeight_Click);
            // 
            // btnEntityButtonRowHeight100
            // 
            this.btnEntityButtonRowHeight100.Name = "btnEntityButtonRowHeight100";
            this.btnEntityButtonRowHeight100.Size = new System.Drawing.Size(160, 22);
            this.btnEntityButtonRowHeight100.Tag = "100";
            this.btnEntityButtonRowHeight100.Text = "Large (100)";
            this.btnEntityButtonRowHeight100.Click += new System.EventHandler(this.btnEntityButtonRowHeight_Click);
            // 
            // btnEntityButtonRowHeight150
            // 
            this.btnEntityButtonRowHeight150.Name = "btnEntityButtonRowHeight150";
            this.btnEntityButtonRowHeight150.Size = new System.Drawing.Size(160, 22);
            this.btnEntityButtonRowHeight150.Tag = "150";
            this.btnEntityButtonRowHeight150.Text = "Extra Large (150)";
            this.btnEntityButtonRowHeight150.Click += new System.EventHandler(this.btnEntityButtonRowHeight_Click);
            // 
            // btnEntityButtonRowHeight200
            // 
            this.btnEntityButtonRowHeight200.Name = "btnEntityButtonRowHeight200";
            this.btnEntityButtonRowHeight200.Size = new System.Drawing.Size(160, 22);
            this.btnEntityButtonRowHeight200.Tag = "200";
            this.btnEntityButtonRowHeight200.Text = "Maximum (200)";
            this.btnEntityButtonRowHeight200.Click += new System.EventHandler(this.btnEntityButtonRowHeight_Click);
            // 
            // expanderMIddle
            // 
            this.expanderMIddle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderMIddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expanderMIddle.Caption = "";
            this.expanderMIddle.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expanderMIddle.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expanderMIddle.CaptionForeColor = System.Drawing.Color.White;
            this.expanderMIddle.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.expanderMIddle.ColourFixed = System.Drawing.Color.Salmon;
            this.expanderMIddle.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expanderMIddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.expanderMIddle.ExpandableControl = this.pnlLeft;
            this.expanderMIddle.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expanderMIddle.Expanded = true;
            this.expanderMIddle.Fixed = false;
            this.expanderMIddle.Location = new System.Drawing.Point(303, 3);
            this.expanderMIddle.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expanderMIddle.LockButtonSize = new System.Drawing.Size(18, 64);
            this.expanderMIddle.LockButtonVisible = false;
            this.expanderMIddle.MinimumSize = new System.Drawing.Size(5, 5);
            this.expanderMIddle.Name = "expanderMIddle";
            this.expanderMIddle.Size = new System.Drawing.Size(20, 623);
            this.expanderMIddle.TabIndex = 7;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlLeftBottom);
            this.pnlLeft.Controls.Add(this.expanderLeft);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 623);
            this.pnlLeft.TabIndex = 6;
            // 
            // pnlLeftBottom
            // 
            this.pnlLeftBottom.Controls.Add(this.dgvEntity);
            this.pnlLeftBottom.Controls.Add(this.barEntity);
            this.pnlLeftBottom.Controls.Add(this.pnlEntitySample);
            this.pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftBottom.Location = new System.Drawing.Point(0, 285);
            this.pnlLeftBottom.Name = "pnlLeftBottom";
            this.pnlLeftBottom.Size = new System.Drawing.Size(300, 338);
            this.pnlLeftBottom.TabIndex = 2;
            // 
            // dgvEntity
            // 
            this.dgvEntity.AllowDrop = true;
            this.dgvEntity.AllowUserToAddRows = false;
            this.dgvEntity.AllowUserToDeleteRows = false;
            this.dgvEntity.AllowUserToOrderColumns = true;
            this.dgvEntity.AutoGenerateColumns = false;
            this.dgvEntity.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEntityIID,
            this.PanelColor,
            this.entityNameDataGridViewTextBoxColumn,
            this.colELHeight,
            this.colELWidth,
            this.colELEntityType,
            this.colELDistributionName,
            this.colELFont,
            this.colELDisplayOrder});
            this.dgvEntity.DataSource = this.entityBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntity.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEntity.Location = new System.Drawing.Point(0, 54);
            this.dgvEntity.MultiSelect = false;
            this.dgvEntity.Name = "dgvEntity";
            this.dgvEntity.RowHeadersWidth = 25;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvEntity.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvEntity.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntity.Size = new System.Drawing.Size(300, 187);
            this.dgvEntity.TabIndex = 4;
            this.dgvEntity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEntity_CellDoubleClick);
            this.dgvEntity.SelectionChanged += new System.EventHandler(this.DgvEntity_SelectionChanged);
            this.dgvEntity.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvEntity_DragDrop);
            this.dgvEntity.DragOver += new System.Windows.Forms.DragEventHandler(this.Dgv_DragOver);
            this.dgvEntity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDown);
            this.dgvEntity.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseMove);
            // 
            // colEntityIID
            // 
            this.colEntityIID.DataPropertyName = "IID";
            this.colEntityIID.HeaderText = "IID";
            this.colEntityIID.Name = "colEntityIID";
            this.colEntityIID.ReadOnly = true;
            this.colEntityIID.Visible = false;
            // 
            // PanelColor
            // 
            this.PanelColor.DataPropertyName = "PanelColor";
            this.PanelColor.HeaderText = "PanelColor";
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.ReadOnly = true;
            this.PanelColor.Visible = false;
            // 
            // entityNameDataGridViewTextBoxColumn
            // 
            this.entityNameDataGridViewTextBoxColumn.DataPropertyName = "EntityName";
            this.entityNameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.entityNameDataGridViewTextBoxColumn.Name = "entityNameDataGridViewTextBoxColumn";
            this.entityNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.entityNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // colELHeight
            // 
            this.colELHeight.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle19.Format = "0\" px\"";
            this.colELHeight.DefaultCellStyle = dataGridViewCellStyle19;
            this.colELHeight.HeaderText = "Height";
            this.colELHeight.Name = "colELHeight";
            this.colELHeight.ReadOnly = true;
            this.colELHeight.Width = 60;
            // 
            // colELWidth
            // 
            this.colELWidth.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle20.Format = "0\" px\"";
            this.colELWidth.DefaultCellStyle = dataGridViewCellStyle20;
            this.colELWidth.HeaderText = "Width";
            this.colELWidth.Name = "colELWidth";
            this.colELWidth.ReadOnly = true;
            this.colELWidth.Width = 70;
            // 
            // colELEntityType
            // 
            this.colELEntityType.DataPropertyName = "entityType";
            this.colELEntityType.HeaderText = "entityType";
            this.colELEntityType.Name = "colELEntityType";
            this.colELEntityType.ReadOnly = true;
            this.colELEntityType.Visible = false;
            // 
            // colELDistributionName
            // 
            this.colELDistributionName.DataPropertyName = "DistributionName";
            this.colELDistributionName.HeaderText = "Distribution";
            this.colELDistributionName.Name = "colELDistributionName";
            this.colELDistributionName.ReadOnly = true;
            // 
            // colELFont
            // 
            this.colELFont.DataPropertyName = "Font";
            this.colELFont.HeaderText = "Font";
            this.colELFont.Name = "colELFont";
            this.colELFont.ReadOnly = true;
            this.colELFont.Width = 120;
            // 
            // colELDisplayOrder
            // 
            this.colELDisplayOrder.DataPropertyName = "DisplayOrder";
            this.colELDisplayOrder.HeaderText = "Order";
            this.colELDisplayOrder.Name = "colELDisplayOrder";
            this.colELDisplayOrder.ReadOnly = true;
            this.colELDisplayOrder.ToolTipText = "Display Order";
            this.colELDisplayOrder.Visible = false;
            this.colELDisplayOrder.Width = 50;
            // 
            // entityBindingSource
            // 
            this.entityBindingSource.DataSource = typeof(Category);
            // 
            // barEntity
            // 
            this.barEntity.Enabled = false;
            this.barEntity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEntity,
            this.btnEditEntity,
            this.btnDeleteEntity,
            this.chkIncludeCategoryDetails,
            this.chkShowHideEntityPreview,
            this.btnReOrderEntityList,
            this.btnZoomEntity});
            this.barEntity.Location = new System.Drawing.Point(0, 0);
            this.barEntity.Name = "barEntity";
            this.barEntity.Size = new System.Drawing.Size(300, 54);
            this.barEntity.TabIndex = 1;
            this.barEntity.Text = "toolStrip1";
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.AutoSize = false;
            this.btnAddEntity.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnAddEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(45, 51);
            this.btnAddEntity.Text = "Add";
            this.btnAddEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddEntity.Click += new System.EventHandler(this.BtnAddEntity_Click);
            // 
            // btnEditEntity
            // 
            this.btnEditEntity.AutoSize = false;
            this.btnEditEntity.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.btnEditEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEntity.Name = "btnEditEntity";
            this.btnEditEntity.Size = new System.Drawing.Size(45, 51);
            this.btnEditEntity.Text = "Edit";
            this.btnEditEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditEntity.Click += new System.EventHandler(this.BtnEditEntity_Click);
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.AutoSize = false;
            this.btnDeleteEntity.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDeleteEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.Size = new System.Drawing.Size(45, 51);
            this.btnDeleteEntity.Text = "Delete";
            this.btnDeleteEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteEntity.Click += new System.EventHandler(this.BtnDeleteEntity_Click);
            // 
            // chkIncludeCategoryDetails
            // 
            this.chkIncludeCategoryDetails.CheckOnClick = true;
            this.chkIncludeCategoryDetails.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkIncludeCategoryDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkIncludeCategoryDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkIncludeCategoryDetails.Name = "chkIncludeCategoryDetails";
            this.chkIncludeCategoryDetails.Size = new System.Drawing.Size(68, 51);
            this.chkIncludeCategoryDetails.Text = "Full Details";
            this.chkIncludeCategoryDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkIncludeCategoryDetails.Click += new System.EventHandler(this.chkIncludeCategoryDetails_CheckedChanged);
            // 
            // chkShowHideEntityPreview
            // 
            this.chkShowHideEntityPreview.CheckOnClick = true;
            this.chkShowHideEntityPreview.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkShowHideEntityPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkShowHideEntityPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkShowHideEntityPreview.Name = "chkShowHideEntityPreview";
            this.chkShowHideEntityPreview.Size = new System.Drawing.Size(84, 51);
            this.chkShowHideEntityPreview.Text = "Show Preview";
            this.chkShowHideEntityPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkShowHideEntityPreview.CheckedChanged += new System.EventHandler(this.chkShowHideEntityPreview_CheckedChanged);
            // 
            // btnReOrderEntityList
            // 
            this.btnReOrderEntityList.Image = global::DTRMSimpleBackOffice.Properties.Resources.ExpandHeight32;
            this.btnReOrderEntityList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReOrderEntityList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReOrderEntityList.Name = "btnReOrderEntityList";
            this.btnReOrderEntityList.Size = new System.Drawing.Size(54, 51);
            this.btnReOrderEntityList.Text = "ReOrder";
            this.btnReOrderEntityList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReOrderEntityList.Click += new System.EventHandler(this.BtnReOrderEntityList_Click);
            // 
            // btnZoomEntity
            // 
            this.btnZoomEntity.Image = global::DTRMSimpleBackOffice.Properties.Resources.View32;
            this.btnZoomEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomEntity.Name = "btnZoomEntity";
            this.btnZoomEntity.Size = new System.Drawing.Size(55, 51);
            this.btnZoomEntity.Text = "  Zoom  ";
            this.btnZoomEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZoomEntity.Click += new System.EventHandler(this.BtnZoomEntity_Click);
            // 
            // pnlEntitySample
            // 
            this.pnlEntitySample.BackColor = System.Drawing.Color.White;
            this.pnlEntitySample.Controls.Add(this.btnEntitySample);
            this.pnlEntitySample.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEntitySample.Location = new System.Drawing.Point(0, 241);
            this.pnlEntitySample.Name = "pnlEntitySample";
            this.pnlEntitySample.Size = new System.Drawing.Size(300, 97);
            this.pnlEntitySample.TabIndex = 3;
            this.pnlEntitySample.Visible = false;
            // 
            // btnEntitySample
            // 
            this.btnEntitySample.BackColor = System.Drawing.Color.White;
            this.btnEntitySample.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEntitySample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntitySample.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntitySample.Location = new System.Drawing.Point(0, 0);
            this.btnEntitySample.Name = "btnEntitySample";
            this.btnEntitySample.Size = new System.Drawing.Size(140, 97);
            this.btnEntitySample.TabIndex = 10;
            this.btnEntitySample.UseVisualStyleBackColor = false;
            // 
            // expanderLeft
            // 
            this.expanderLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expanderLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expanderLeft.Caption = "";
            this.expanderLeft.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expanderLeft.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expanderLeft.CaptionForeColor = System.Drawing.Color.White;
            this.expanderLeft.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.expanderLeft.ColourFixed = System.Drawing.Color.Salmon;
            this.expanderLeft.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expanderLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.expanderLeft.ExpandableControl = this.pnlLeftTop;
            this.expanderLeft.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expanderLeft.Expanded = true;
            this.expanderLeft.Fixed = false;
            this.expanderLeft.Location = new System.Drawing.Point(0, 265);
            this.expanderLeft.LockButtonDock = System.Windows.Forms.DockStyle.Left;
            this.expanderLeft.LockButtonSize = new System.Drawing.Size(32, 18);
            this.expanderLeft.LockButtonVisible = false;
            this.expanderLeft.MinimumSize = new System.Drawing.Size(5, 5);
            this.expanderLeft.Name = "expanderLeft";
            this.expanderLeft.Size = new System.Drawing.Size(300, 20);
            this.expanderLeft.TabIndex = 1;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.dgvMenu);
            this.pnlLeftTop.Controls.Add(this.barMenu);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(300, 265);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // barMenu
            // 
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMenu,
            this.btnEditMenu,
            this.btnDeleteMenu,
            this.btnOtherFunctions});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(300, 54);
            this.barMenu.TabIndex = 0;
            this.barMenu.Text = "toolStrip1";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnAddMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(69, 51);
            this.btnAddMenu.Text = "New Menu";
            this.btnAddMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMenu.Click += new System.EventHandler(this.BtnAddMenu_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.MatReport_32;
            this.btnEditMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(43, 51);
            this.btnEditMenu.Text = "  Edit  ";
            this.btnEditMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditMenu.Click += new System.EventHandler(this.BtnEditMenu_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDeleteMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(44, 51);
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteMenu.Click += new System.EventHandler(this.BtnDeleteMenu_Click);
            // 
            // btnOtherFunctions
            // 
            this.btnOtherFunctions.AutoSize = false;
            this.btnOtherFunctions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetAsDefaultMenu,
            this.btnPrintMenu,
            this.btnLoadMenu,
            this.btnBackupMenu,
            this.btnZoomMenu,
            this.btnExportStockManager,
            this.btnImportStockManager,
            this.btnSaveDBImagesToFolder,
            this.btnLoadMenuList,
            this.btnCreateDummyMenu,
            this.btnExportMenuAsJson,
            this.btnImportMenuFromJSON});
            this.btnOtherFunctions.Image = global::DTRMSimpleBackOffice.Properties.Resources.arrow_down32;
            this.btnOtherFunctions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOtherFunctions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOtherFunctions.Name = "btnOtherFunctions";
            this.btnOtherFunctions.Size = new System.Drawing.Size(60, 51);
            this.btnOtherFunctions.Text = "More ....";
            this.btnOtherFunctions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuSetAsDefaultMenu
            // 
            this.mnuSetAsDefaultMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.tickgreen;
            this.mnuSetAsDefaultMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSetAsDefaultMenu.Name = "mnuSetAsDefaultMenu";
            this.mnuSetAsDefaultMenu.Size = new System.Drawing.Size(222, 38);
            this.mnuSetAsDefaultMenu.Text = "Set as Default Menu";
            this.mnuSetAsDefaultMenu.Click += new System.EventHandler(this.mnuSetAsDefaultMenu_Click);
            // 
            // btnPrintMenu
            // 
            this.btnPrintMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnPrintMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintMenu.Name = "btnPrintMenu";
            this.btnPrintMenu.Size = new System.Drawing.Size(222, 38);
            this.btnPrintMenu.Text = " Print ";
            this.btnPrintMenu.Click += new System.EventHandler(this.BtnPrintMenu_Click);
            // 
            // btnLoadMenu
            // 
            this.btnLoadMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.Paste232;
            this.btnLoadMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadMenu.Name = "btnLoadMenu";
            this.btnLoadMenu.Size = new System.Drawing.Size(222, 38);
            this.btnLoadMenu.Text = "Load Entire Backup";
            this.btnLoadMenu.Click += new System.EventHandler(this.BtnLoadMenu_Click);
            // 
            // btnBackupMenu
            // 
            this.btnBackupMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.disket32;
            this.btnBackupMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBackupMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackupMenu.Name = "btnBackupMenu";
            this.btnBackupMenu.Size = new System.Drawing.Size(222, 38);
            this.btnBackupMenu.Text = "Backup";
            this.btnBackupMenu.Click += new System.EventHandler(this.BtnBackupMenu_Click);
            // 
            // btnZoomMenu
            // 
            this.btnZoomMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.View32;
            this.btnZoomMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomMenu.Name = "btnZoomMenu";
            this.btnZoomMenu.Size = new System.Drawing.Size(222, 38);
            this.btnZoomMenu.Text = "Zoom";
            this.btnZoomMenu.Click += new System.EventHandler(this.BtnZoomMenu_Click);
            // 
            // btnExportStockManager
            // 
            this.btnExportStockManager.Image = global::DTRMSimpleBackOffice.Properties.Resources.DBToFolder32;
            this.btnExportStockManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportStockManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportStockManager.Name = "btnExportStockManager";
            this.btnExportStockManager.Size = new System.Drawing.Size(222, 38);
            this.btnExportStockManager.Text = "Export SM";
            this.btnExportStockManager.Click += new System.EventHandler(this.BtnExportStockManager_Click);
            // 
            // btnImportStockManager
            // 
            this.btnImportStockManager.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderToDB32;
            this.btnImportStockManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportStockManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportStockManager.Name = "btnImportStockManager";
            this.btnImportStockManager.Size = new System.Drawing.Size(222, 38);
            this.btnImportStockManager.Text = "Import SM";
            this.btnImportStockManager.Click += new System.EventHandler(this.BtnImportStockManager_Click);
            // 
            // btnSaveDBImagesToFolder
            // 
            this.btnSaveDBImagesToFolder.Image = global::DTRMSimpleBackOffice.Properties.Resources.Camescope;
            this.btnSaveDBImagesToFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveDBImagesToFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDBImagesToFolder.Name = "btnSaveDBImagesToFolder";
            this.btnSaveDBImagesToFolder.Size = new System.Drawing.Size(222, 38);
            this.btnSaveDBImagesToFolder.Text = "Export Images";
            this.btnSaveDBImagesToFolder.ToolTipText = "Export Images Into File";
            this.btnSaveDBImagesToFolder.Click += new System.EventHandler(this.BtnSaveDBImagesToFolder_Click);
            // 
            // btnLoadMenuList
            // 
            this.btnLoadMenuList.Image = global::DTRMSimpleBackOffice.Properties.Resources.Lightning;
            this.btnLoadMenuList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadMenuList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadMenuList.Name = "btnLoadMenuList";
            this.btnLoadMenuList.Size = new System.Drawing.Size(222, 38);
            this.btnLoadMenuList.Text = "Load Menu(s)";
            this.btnLoadMenuList.Click += new System.EventHandler(this.BtnLoadMenuList_Click);
            // 
            // btnCreateDummyMenu
            // 
            this.btnCreateDummyMenu.Image = global::DTRMSimpleBackOffice.Properties.Resources.uzgun32;
            this.btnCreateDummyMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreateDummyMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateDummyMenu.Name = "btnCreateDummyMenu";
            this.btnCreateDummyMenu.Size = new System.Drawing.Size(222, 38);
            this.btnCreateDummyMenu.Text = "Create Dummy Menu";
            this.btnCreateDummyMenu.Click += new System.EventHandler(this.btnCreateDummyMenu_Click);
            // 
            // btnExportMenuAsJson
            // 
            this.btnExportMenuAsJson.Image = global::DTRMSimpleBackOffice.Properties.Resources.SquareArrowRightExpander32;
            this.btnExportMenuAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportMenuAsJson.Name = "btnExportMenuAsJson";
            this.btnExportMenuAsJson.Size = new System.Drawing.Size(222, 38);
            this.btnExportMenuAsJson.Text = "Export Menu As JSON";
            this.btnExportMenuAsJson.Click += new System.EventHandler(this.btnExportMenuAsJson_Click);
            // 
            // btnImportMenuFromJSON
            // 
            this.btnImportMenuFromJSON.Image = global::DTRMSimpleBackOffice.Properties.Resources.SquareArrowLeftNarrower32;
            this.btnImportMenuFromJSON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportMenuFromJSON.Name = "btnImportMenuFromJSON";
            this.btnImportMenuFromJSON.Size = new System.Drawing.Size(222, 38);
            this.btnImportMenuFromJSON.Text = "Import Menu From JSON";
            this.btnImportMenuFromJSON.Click += new System.EventHandler(this.btnImportMenuFromJSON_Click);
            // 
            // tabSearchCategoryItems
            // 
            this.tabSearchCategoryItems.Controls.Add(this.dgvSearchResults);
            this.tabSearchCategoryItems.Controls.Add(this.pnlSearchImagePanel);
            this.tabSearchCategoryItems.Controls.Add(this.barSearchCategoryItems);
            this.tabSearchCategoryItems.Location = new System.Drawing.Point(4, 34);
            this.tabSearchCategoryItems.Name = "tabSearchCategoryItems";
            this.tabSearchCategoryItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchCategoryItems.Size = new System.Drawing.Size(1577, 629);
            this.tabSearchCategoryItems.TabIndex = 4;
            this.tabSearchCategoryItems.Text = "SEARCH CATEGORY ITEMS";
            this.tabSearchCategoryItems.UseVisualStyleBackColor = true;
            // 
            // barSearchCategoryItems
            // 
            this.barSearchCategoryItems.Enabled = false;
            this.barSearchCategoryItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearchCategoryButtons,
            this.btnSearchCategoryButtons,
            this.chkAllMenuSearch,
            this.lblSearchResults});
            this.barSearchCategoryItems.Location = new System.Drawing.Point(3, 3);
            this.barSearchCategoryItems.Name = "barSearchCategoryItems";
            this.barSearchCategoryItems.Size = new System.Drawing.Size(1571, 39);
            this.barSearchCategoryItems.TabIndex = 0;
            this.barSearchCategoryItems.Text = "toolStrip1";
            // 
            // txtSearchCategoryButtons
            // 
            this.txtSearchCategoryButtons.AutoSize = false;
            this.txtSearchCategoryButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCategoryButtons.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchCategoryButtons.Name = "txtSearchCategoryButtons";
            this.txtSearchCategoryButtons.Size = new System.Drawing.Size(200, 29);
            this.txtSearchCategoryButtons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchCategoryButtons_KeyDown);
            // 
            // btnSearchCategoryButtons
            // 
            this.btnSearchCategoryButtons.Image = global::DTRMSimpleBackOffice.Properties.Resources.QuestionGreen;
            this.btnSearchCategoryButtons.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearchCategoryButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchCategoryButtons.Name = "btnSearchCategoryButtons";
            this.btnSearchCategoryButtons.Size = new System.Drawing.Size(78, 36);
            this.btnSearchCategoryButtons.Text = "Search";
            this.btnSearchCategoryButtons.Click += new System.EventHandler(this.BtnSearchCategoryButtons_Click);
            // 
            // chkAllMenuSearch
            // 
            this.chkAllMenuSearch.CheckOnClick = true;
            this.chkAllMenuSearch.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkAllMenuSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkAllMenuSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkAllMenuSearch.Name = "chkAllMenuSearch";
            this.chkAllMenuSearch.Size = new System.Drawing.Size(104, 36);
            this.chkAllMenuSearch.Text = "All Menu(s)";
            this.chkAllMenuSearch.CheckedChanged += new System.EventHandler(this.chkAllMenuSearch_CheckedChanged);
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(21, 36);
            this.lblSearchResults.Text = "(0)";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "entityType";
            this.dataGridViewTextBoxColumn2.HeaderText = "entityType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "QuantityType";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn8.HeaderText = "QType";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QuantityType";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn9.HeaderText = "QType";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.ToolTipText = "Display Order";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QuantityType";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn10.HeaderText = "QType";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "entityType";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn11.HeaderText = "entityType";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "entityType";
            this.dataGridViewTextBoxColumn12.HeaderText = "entityType";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 75;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "QuantityType";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn14.HeaderText = "QType";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "QuantityType";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn15.HeaderText = "QType";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "QuantityType";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn16.HeaderText = "QType";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.ToolTipText = "Direct Sale Price";
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.dataGridViewTextBoxColumn16.Width = 80;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "entityType";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "N2";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn17.HeaderText = "entityType";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.ToolTipText = "InHouse Price";
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn17.Width = 75;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "QuantityType";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewTextBoxColumn18.HeaderText = "QType";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.ToolTipText = "Take Away Price";
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DeliveryPrice";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N2";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewTextBoxColumn19.HeaderText = "DL Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.ToolTipText = "Delivery Price";
            this.dataGridViewTextBoxColumn19.Width = 75;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewTextBoxColumn20.HeaderText = "Width";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            this.dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewTextBoxColumn21.HeaderText = "Height";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "DirectSaleTaxPercent";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.Format = "N2";
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewTextBoxColumn22.HeaderText = "DS Tax%";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.ToolTipText = "Direct Sale Tax";
            this.dataGridViewTextBoxColumn22.Width = 80;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "InHouseTaxPercent";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Format = "N2";
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewTextBoxColumn23.HeaderText = "IH Tax%";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.ToolTipText = "InHouse Tax";
            this.dataGridViewTextBoxColumn23.Width = 80;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "TakeAwayTaxPercent";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Format = "N2";
            this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewTextBoxColumn24.HeaderText = "TA Tax%";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.ToolTipText = "TakeAway Tax";
            this.dataGridViewTextBoxColumn24.Width = 80;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "DeliveryTaxPercent";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Format = "N2";
            this.dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewTextBoxColumn25.HeaderText = "DL Tax%";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.ToolTipText = "Delivery Tax";
            this.dataGridViewTextBoxColumn25.Width = 80;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Format = "N2";
            this.dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewTextBoxColumn26.HeaderText = "DO";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.ToolTipText = "Display Order";
            this.dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "FFamily";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Format = "N2";
            this.dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewTextBoxColumn27.HeaderText = "Font";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.ToolTipText = "InHouse Tax";
            this.dataGridViewTextBoxColumn27.Width = 75;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "FSize";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Format = "N2";
            this.dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewTextBoxColumn28.HeaderText = "FSize";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.ToolTipText = "TakeAway Tax";
            this.dataGridViewTextBoxColumn28.Width = 75;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "FStyle";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Format = "N2";
            this.dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewTextBoxColumn29.HeaderText = "FStyle";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.ToolTipText = "Delivery Tax";
            this.dataGridViewTextBoxColumn29.Width = 75;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "DistributionName";
            this.dataGridViewTextBoxColumn30.HeaderText = "Distribution";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.ToolTipText = "Display Order";
            this.dataGridViewTextBoxColumn30.Width = 50;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn31.HeaderText = "IID";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.ToolTipText = "Display Order";
            this.dataGridViewTextBoxColumn31.Visible = false;
            this.dataGridViewTextBoxColumn31.Width = 50;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "PanelColor";
            this.dataGridViewTextBoxColumn32.HeaderText = "PanelColor";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "FStyle";
            this.dataGridViewTextBoxColumn33.HeaderText = "FStyle";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "EntityName";
            this.dataGridViewTextBoxColumn34.HeaderText = "Category Name";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn34.Width = 150;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "ButtonHeight";
            this.dataGridViewTextBoxColumn35.HeaderText = "Height";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 50;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "ButtonWidth";
            this.dataGridViewTextBoxColumn36.HeaderText = "Width";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Width = 50;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "entityType";
            this.dataGridViewTextBoxColumn37.HeaderText = "entityType";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Visible = false;
            this.dataGridViewTextBoxColumn37.Width = 50;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "DistributionName";
            this.dataGridViewTextBoxColumn38.HeaderText = "Distribution";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Visible = false;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "FFamily";
            this.dataGridViewTextBoxColumn39.HeaderText = "Font";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 75;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "FSize";
            this.dataGridViewTextBoxColumn40.HeaderText = "FSize";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 75;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "DisplayOrder";
            this.dataGridViewTextBoxColumn41.HeaderText = "DO";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.ToolTipText = "Display Order";
            this.dataGridViewTextBoxColumn41.Width = 50;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn42.HeaderText = "IID";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Visible = false;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "MenuName";
            this.dataGridViewTextBoxColumn43.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 200;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn44.HeaderText = "IID";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Visible = false;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "EntityButtonName";
            this.dataGridViewTextBoxColumn45.HeaderText = "EntityButtonName";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Width = 150;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "EntityName";
            this.dataGridViewTextBoxColumn46.HeaderText = "EntityName";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Width = 150;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "QuantityType";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn47.DefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewTextBoxColumn47.HeaderText = "QType";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Visible = false;
            this.dataGridViewTextBoxColumn47.Width = 80;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "entityType";
            this.dataGridViewTextBoxColumn48.HeaderText = "entityType";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Visible = false;
            // 
            // entityButtonBindingSource
            // 
            this.entityButtonBindingSource.DataSource = typeof(CategoryItem);
            // 
            // FrmMenuEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 677);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMenuEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DTRM SIMPLE MENU EDITOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenuEditor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            this.popEntityButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonSearchResultBindingSource)).EndInit();
            this.pnlSearchImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearchItem)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabMenus.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRightBottom.ResumeLayout(false);
            this.pnlRightBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonStockItemLookUpBindingSource)).EndInit();
            this.pnlEBPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxEBPicture)).EndInit();
            this.barStockUsage.ResumeLayout(false);
            this.barStockUsage.PerformLayout();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntityButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonExtendedBindingSource)).EndInit();
            this.barEntityButton.ResumeLayout(false);
            this.barEntityButton.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftBottom.ResumeLayout(false);
            this.pnlLeftBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
            this.barEntity.ResumeLayout(false);
            this.barEntity.PerformLayout();
            this.pnlEntitySample.ResumeLayout(false);
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.tabSearchCategoryItems.ResumeLayout(false);
            this.tabSearchCategoryItems.PerformLayout();
            this.barSearchCategoryItems.ResumeLayout(false);
            this.barSearchCategoryItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.BindingSource entityBindingSource;
        private System.Windows.Forms.BindingSource entityButtonBindingSource;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.BindingSource catalogBindingSource;
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
        private System.Windows.Forms.ToolStripMenuItem btnLoadMenuList;
        private System.Windows.Forms.ToolStripButton btnAddMenu;
        private System.Windows.Forms.ToolStripButton btnEditMenu;
        private System.Windows.Forms.ToolStripButton btnDeleteMenu;
        private System.Windows.Forms.ToolStripMenuItem btnZoomMenu;
        private System.Windows.Forms.ToolStripMenuItem btnBackupMenu;
        private System.Windows.Forms.ToolStripMenuItem btnPrintMenu;
        private System.Windows.Forms.ToolStripMenuItem btnExportStockManager;
        private System.Windows.Forms.ToolStripMenuItem btnImportStockManager;
        private System.Windows.Forms.ToolStripMenuItem btnSaveDBImagesToFolder;
        private System.Windows.Forms.TabPage tabSearchCategoryItems;
        private System.Windows.Forms.ToolStrip barSearchCategoryItems;
        private System.Windows.Forms.ToolStripTextBox txtSearchCategoryButtons;
        private System.Windows.Forms.ToolStripButton btnSearchCategoryButtons;
        private System.Windows.Forms.ToolStripButton chkAllMenuSearch;
        private System.Windows.Forms.ToolStripLabel lblSearchResults;
        private System.Windows.Forms.DataGridView dgvEntity;
        private System.Windows.Forms.Panel pnlEntitySample;
        private System.Windows.Forms.Button btnEntitySample;
        private System.Windows.Forms.ToolStrip barEntity;
        private System.Windows.Forms.ToolStripButton btnAddEntity;
        private System.Windows.Forms.ToolStripButton btnEditEntity;
        private System.Windows.Forms.ToolStripButton btnDeleteEntity;
        private System.Windows.Forms.ToolStripButton btnZoomEntity;
        private System.Windows.Forms.ToolStripButton btnReOrderEntityList;
        private System.Windows.Forms.ToolStripButton chkIncludeCategoryDetails;
        private System.Windows.Forms.ToolStripButton chkShowHideEntityPreview;
        private System.Windows.Forms.DataGridView dgvEntityButton;
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
        private System.Windows.Forms.ToolStripButton chkIncludeCategoryItemDetails;
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
        private System.Windows.Forms.ToolStripMenuItem btnCreateDummyMenu;
        private System.Windows.Forms.ToolStripDropDownButton btnOtherFunctions;
        private System.Windows.Forms.ToolStripMenuItem mnuSetAsDefaultMenu;
        private System.Windows.Forms.ToolStripMenuItem btnLoadMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActiveMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockUsageIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityTypeAsString;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBSItemDisplayOrder;
        private System.Windows.Forms.DataGridViewImageColumn colEBDisplayImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBParentEntityIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBButtonName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colELHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colELWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colELEntityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colELDistributionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colELFont;
        private System.Windows.Forms.DataGridViewTextBoxColumn colELDisplayOrder;
        private System.Windows.Forms.ToolStripButton btnQuantityToComment;
        private System.Windows.Forms.ToolStripMenuItem btnExportMenuAsJson;
        private System.Windows.Forms.ToolStripMenuItem btnImportMenuFromJSON;
    }
}

