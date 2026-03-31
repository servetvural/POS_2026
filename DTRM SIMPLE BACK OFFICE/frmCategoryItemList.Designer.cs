using POSLayer.Library;
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmCategoryItemList {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryItemList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            popCategoryItem = new System.Windows.Forms.ContextMenuStrip(components);
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
            dgvStockItems = new System.Windows.Forms.DataGridView();
            colStockUsageIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEBIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            QuantityTypeAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityButtonStockItemLookUpBindingSource = new System.Windows.Forms.BindingSource(components);
            pnlEBPicture = new System.Windows.Forms.Panel();
            pboxEBPicture = new System.Windows.Forms.PictureBox();
            btnEBSample = new System.Windows.Forms.Button();
            barStockUsage = new System.Windows.Forms.ToolStrip();
            btnAddStockItem = new System.Windows.Forms.ToolStripButton();
            btnEditStockItem = new System.Windows.Forms.ToolStripButton();
            btnDeleteStockItem = new System.Windows.Forms.ToolStripButton();
            btnCopyStockUsageItems = new System.Windows.Forms.ToolStripButton();
            btnPasteStockUsageItems = new System.Windows.Forms.ToolStripButton();
            btnPasteSpecialStockUsageItems = new System.Windows.Forms.ToolStripButton();
            lblImageSize = new System.Windows.Forms.ToolStripLabel();
            btnQuantityToComment = new System.Windows.Forms.ToolStripButton();
            tsSortStockItem = new System.Windows.Forms.ToolStripButton();
            tsMoveUpStockItem = new System.Windows.Forms.ToolStripButton();
            tsMoveDownStockItem = new System.Windows.Forms.ToolStripButton();
            dgvCategoryItem = new System.Windows.Forms.DataGridView();
            itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saleTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sitinTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            padFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            distributionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sitinPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonDisplayStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textAlignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textImageRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            imageAlignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _categoryItemSourceDesign = new System.Windows.Forms.BindingSource(components);
            barEntityButton = new System.Windows.Forms.ToolStrip();
            btnAddEntityButton = new System.Windows.Forms.ToolStripButton();
            btnEditEntityButton = new System.Windows.Forms.ToolStripButton();
            btnDeleteEntityButton = new System.Windows.Forms.ToolStripButton();
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
            btnClose = new System.Windows.Forms.ToolStripButton();
            btnCategoryItemSample = new System.Windows.Forms.ToolStripButton();
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            panel1 = new System.Windows.Forms.Panel();
            lblCategory = new System.Windows.Forms.Label();
            popCategoryItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonStockItemLookUpBindingSource).BeginInit();
            pnlEBPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxEBPicture).BeginInit();
            barStockUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_categoryItemSourceDesign).BeginInit();
            barEntityButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entityButtonExtendedBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // popCategoryItem
            // 
            popCategoryItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { popEBAddNew, popEBEdit, popEBDelete, toolStripMenuItem1, popEBSetFont, popEBSetWidth, popEBSetHeight, popEBSetPrice, popEBSetTaxRate, popEBSetToUpperCase, popEBSetToLowercase, popSetSentenceCase, popEBMoveTo, popEBReOrder, popEBDuplicate, popEBConvertToStockItem, popSetAllForeColourTo, popSetAllBackColourTo, popSetAllBackColourToTransparent, popSetAllDistributionTo });
            popCategoryItem.Name = "popEntityButton";
            popCategoryItem.Size = new System.Drawing.Size(236, 428);
            // 
            // popEBAddNew
            // 
            popEBAddNew.Name = "popEBAddNew";
            popEBAddNew.Size = new System.Drawing.Size(235, 22);
            popEBAddNew.Text = "Add New";
            popEBAddNew.Click += btnAddCategoryItem_Click;
            // 
            // popEBEdit
            // 
            popEBEdit.Name = "popEBEdit";
            popEBEdit.Size = new System.Drawing.Size(235, 22);
            popEBEdit.Text = "Edit";
            popEBEdit.Click += btnEditCategoryItem_Click;
            // 
            // popEBDelete
            // 
            popEBDelete.Name = "popEBDelete";
            popEBDelete.Size = new System.Drawing.Size(235, 22);
            popEBDelete.Text = "Delete";
            popEBDelete.Click += btnDeleteCategoryItem_Click;
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
            // dgvStockItems
            // 
            dgvStockItems.AllowDrop = true;
            dgvStockItems.AllowUserToAddRows = false;
            dgvStockItems.AllowUserToDeleteRows = false;
            dgvStockItems.AutoGenerateColumns = false;
            dgvStockItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvStockItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvStockItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStockUsageIID, colEBIID, colStockItemIID, Quantity, QuantityTypeAsString, StockName, Comment });
            dgvStockItems.DataSource = entityButtonStockItemLookUpBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvStockItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStockItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvStockItems.Location = new System.Drawing.Point(163, 54);
            dgvStockItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvStockItems.Name = "dgvStockItems";
            dgvStockItems.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvStockItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvStockItems.RowHeadersWidth = 25;
            dgvStockItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvStockItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStockItems.Size = new System.Drawing.Size(858, 307);
            dgvStockItems.TabIndex = 11;
            dgvStockItems.CellDoubleClick += DgvStockItems_CellDoubleClick;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle2;
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
            // pnlEBPicture
            // 
            pnlEBPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            pnlEBPicture.Controls.Add(pboxEBPicture);
            pnlEBPicture.Controls.Add(btnEBSample);
            pnlEBPicture.Dock = System.Windows.Forms.DockStyle.Left;
            pnlEBPicture.Location = new System.Drawing.Point(0, 54);
            pnlEBPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlEBPicture.Name = "pnlEBPicture";
            pnlEBPicture.Size = new System.Drawing.Size(163, 307);
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
            pboxEBPicture.Size = new System.Drawing.Size(163, 122);
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
            barStockUsage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddStockItem, btnEditStockItem, btnDeleteStockItem, btnCopyStockUsageItems, btnPasteStockUsageItems, btnPasteSpecialStockUsageItems, lblImageSize, btnQuantityToComment, tsSortStockItem, tsMoveUpStockItem, tsMoveDownStockItem });
            barStockUsage.Location = new System.Drawing.Point(0, 0);
            barStockUsage.Name = "barStockUsage";
            barStockUsage.Size = new System.Drawing.Size(1021, 54);
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
            // btnCopyStockUsageItems
            // 
            btnCopyStockUsageItems.Image = Properties.Resources.WindowCascade;
            btnCopyStockUsageItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCopyStockUsageItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyStockUsageItems.Name = "btnCopyStockUsageItems";
            btnCopyStockUsageItems.Size = new System.Drawing.Size(71, 51);
            btnCopyStockUsageItems.Text = "Copy Items";
            btnCopyStockUsageItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // dgvCategoryItem
            // 
            dgvCategoryItem.AllowDrop = true;
            dgvCategoryItem.AllowUserToAddRows = false;
            dgvCategoryItem.AllowUserToDeleteRows = false;
            dgvCategoryItem.AllowUserToOrderColumns = true;
            dgvCategoryItem.AutoGenerateColumns = false;
            dgvCategoryItem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvCategoryItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { itemNameDataGridViewTextBoxColumn, buttonTypeDataGridViewTextBoxColumn, saleTaxDataGridViewTextBoxColumn, sitinTaxDataGridViewTextBoxColumn, taTaxDataGridViewTextBoxColumn, dTaxDataGridViewTextBoxColumn, padFlagDataGridViewTextBoxColumn, distributionNameDataGridViewTextBoxColumn, salePriceDataGridViewTextBoxColumn, sitinPriceDataGridViewTextBoxColumn, taPriceDataGridViewTextBoxColumn, dPriceDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, fontDataGridViewTextBoxColumn, buttonDisplayStyleDataGridViewTextBoxColumn, textAlignDataGridViewTextBoxColumn, textImageRelationDataGridViewTextBoxColumn, imageAlignDataGridViewTextBoxColumn, dOrderDataGridViewTextBoxColumn });
            dgvCategoryItem.ContextMenuStrip = popCategoryItem;
            dgvCategoryItem.DataSource = _categoryItemSourceDesign;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategoryItem.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCategoryItem.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategoryItem.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvCategoryItem.Location = new System.Drawing.Point(0, 78);
            dgvCategoryItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvCategoryItem.Name = "dgvCategoryItem";
            dgvCategoryItem.ReadOnly = true;
            dgvCategoryItem.RowHeadersWidth = 25;
            dgvCategoryItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvCategoryItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgvCategoryItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryItem.Size = new System.Drawing.Size(1021, 536);
            dgvCategoryItem.TabIndex = 0;
            dgvCategoryItem.CellDoubleClick += dgvCategoryItem_CellDoubleClick;
            dgvCategoryItem.SelectionChanged += dgvCategoryItem_SelectionChanged;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonTypeDataGridViewTextBoxColumn
            // 
            buttonTypeDataGridViewTextBoxColumn.DataPropertyName = "ButtonType";
            buttonTypeDataGridViewTextBoxColumn.HeaderText = "ButtonType";
            buttonTypeDataGridViewTextBoxColumn.Name = "buttonTypeDataGridViewTextBoxColumn";
            buttonTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleTaxDataGridViewTextBoxColumn
            // 
            saleTaxDataGridViewTextBoxColumn.DataPropertyName = "SaleTax";
            saleTaxDataGridViewTextBoxColumn.HeaderText = "SaleTax";
            saleTaxDataGridViewTextBoxColumn.Name = "saleTaxDataGridViewTextBoxColumn";
            saleTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sitinTaxDataGridViewTextBoxColumn
            // 
            sitinTaxDataGridViewTextBoxColumn.DataPropertyName = "SitinTax";
            sitinTaxDataGridViewTextBoxColumn.HeaderText = "SitinTax";
            sitinTaxDataGridViewTextBoxColumn.Name = "sitinTaxDataGridViewTextBoxColumn";
            sitinTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taTaxDataGridViewTextBoxColumn
            // 
            taTaxDataGridViewTextBoxColumn.DataPropertyName = "TaTax";
            taTaxDataGridViewTextBoxColumn.HeaderText = "TaTax";
            taTaxDataGridViewTextBoxColumn.Name = "taTaxDataGridViewTextBoxColumn";
            taTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTaxDataGridViewTextBoxColumn
            // 
            dTaxDataGridViewTextBoxColumn.DataPropertyName = "DTax";
            dTaxDataGridViewTextBoxColumn.HeaderText = "DTax";
            dTaxDataGridViewTextBoxColumn.Name = "dTaxDataGridViewTextBoxColumn";
            dTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // padFlagDataGridViewTextBoxColumn
            // 
            padFlagDataGridViewTextBoxColumn.DataPropertyName = "PadFlag";
            padFlagDataGridViewTextBoxColumn.HeaderText = "PadFlag";
            padFlagDataGridViewTextBoxColumn.Name = "padFlagDataGridViewTextBoxColumn";
            padFlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distributionNameDataGridViewTextBoxColumn
            // 
            distributionNameDataGridViewTextBoxColumn.DataPropertyName = "DistributionName";
            distributionNameDataGridViewTextBoxColumn.HeaderText = "DistributionName";
            distributionNameDataGridViewTextBoxColumn.Name = "distributionNameDataGridViewTextBoxColumn";
            distributionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sitinPriceDataGridViewTextBoxColumn
            // 
            sitinPriceDataGridViewTextBoxColumn.DataPropertyName = "SitinPrice";
            sitinPriceDataGridViewTextBoxColumn.HeaderText = "SitinPrice";
            sitinPriceDataGridViewTextBoxColumn.Name = "sitinPriceDataGridViewTextBoxColumn";
            sitinPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taPriceDataGridViewTextBoxColumn
            // 
            taPriceDataGridViewTextBoxColumn.DataPropertyName = "TaPrice";
            taPriceDataGridViewTextBoxColumn.HeaderText = "TaPrice";
            taPriceDataGridViewTextBoxColumn.Name = "taPriceDataGridViewTextBoxColumn";
            taPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dPriceDataGridViewTextBoxColumn
            // 
            dPriceDataGridViewTextBoxColumn.DataPropertyName = "DPrice";
            dPriceDataGridViewTextBoxColumn.HeaderText = "DPrice";
            dPriceDataGridViewTextBoxColumn.Name = "dPriceDataGridViewTextBoxColumn";
            dPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Width";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fontDataGridViewTextBoxColumn
            // 
            fontDataGridViewTextBoxColumn.DataPropertyName = "Font";
            fontDataGridViewTextBoxColumn.HeaderText = "Font";
            fontDataGridViewTextBoxColumn.Name = "fontDataGridViewTextBoxColumn";
            fontDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonDisplayStyleDataGridViewTextBoxColumn
            // 
            buttonDisplayStyleDataGridViewTextBoxColumn.DataPropertyName = "ButtonDisplayStyle";
            buttonDisplayStyleDataGridViewTextBoxColumn.HeaderText = "ButtonDisplayStyle";
            buttonDisplayStyleDataGridViewTextBoxColumn.Name = "buttonDisplayStyleDataGridViewTextBoxColumn";
            buttonDisplayStyleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textAlignDataGridViewTextBoxColumn
            // 
            textAlignDataGridViewTextBoxColumn.DataPropertyName = "TextAlign";
            textAlignDataGridViewTextBoxColumn.HeaderText = "TextAlign";
            textAlignDataGridViewTextBoxColumn.Name = "textAlignDataGridViewTextBoxColumn";
            textAlignDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textImageRelationDataGridViewTextBoxColumn
            // 
            textImageRelationDataGridViewTextBoxColumn.DataPropertyName = "TextImageRelation";
            textImageRelationDataGridViewTextBoxColumn.HeaderText = "TextImageRelation";
            textImageRelationDataGridViewTextBoxColumn.Name = "textImageRelationDataGridViewTextBoxColumn";
            textImageRelationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageAlignDataGridViewTextBoxColumn
            // 
            imageAlignDataGridViewTextBoxColumn.DataPropertyName = "ImageAlign";
            imageAlignDataGridViewTextBoxColumn.HeaderText = "ImageAlign";
            imageAlignDataGridViewTextBoxColumn.Name = "imageAlignDataGridViewTextBoxColumn";
            imageAlignDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOrderDataGridViewTextBoxColumn
            // 
            dOrderDataGridViewTextBoxColumn.DataPropertyName = "DOrder";
            dOrderDataGridViewTextBoxColumn.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn.Name = "dOrderDataGridViewTextBoxColumn";
            dOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _categoryItemSourceDesign
            // 
            _categoryItemSourceDesign.DataSource = typeof(CategoryItem);
            // 
            // barEntityButton
            // 
            barEntityButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddEntityButton, btnEditEntityButton, btnDeleteEntityButton, btnSetAll, btnMoveToEntity, btnDuplicate, btnConvertToStockItem, btnEntityButtonRowHeight, tsSortCategoryItem, tsMoveUpCategoryItem, tsMoveDownCategoryItem, btnClose, btnCategoryItemSample });
            barEntityButton.Location = new System.Drawing.Point(0, 0);
            barEntityButton.Name = "barEntityButton";
            barEntityButton.Size = new System.Drawing.Size(1021, 54);
            barEntityButton.TabIndex = 0;
            barEntityButton.Text = "toolStrip1";
            // 
            // btnAddEntityButton
            // 
            btnAddEntityButton.AutoSize = false;
            btnAddEntityButton.Image = Properties.Resources.arti32;
            btnAddEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddEntityButton.Name = "btnAddEntityButton";
            btnAddEntityButton.Size = new System.Drawing.Size(60, 51);
            btnAddEntityButton.Text = "  Add  ";
            btnAddEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddEntityButton.Click += btnAddCategoryItem_Click;
            // 
            // btnEditEntityButton
            // 
            btnEditEntityButton.AutoSize = false;
            btnEditEntityButton.Image = Properties.Resources.MatReport_32;
            btnEditEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditEntityButton.Name = "btnEditEntityButton";
            btnEditEntityButton.Size = new System.Drawing.Size(60, 51);
            btnEditEntityButton.Text = "  Edit  ";
            btnEditEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEditEntityButton.Click += btnEditCategoryItem_Click;
            // 
            // btnDeleteEntityButton
            // 
            btnDeleteEntityButton.AutoSize = false;
            btnDeleteEntityButton.Image = Properties.Resources.eksi32;
            btnDeleteEntityButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteEntityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteEntityButton.Name = "btnDeleteEntityButton";
            btnDeleteEntityButton.Size = new System.Drawing.Size(60, 51);
            btnDeleteEntityButton.Text = " Delete ";
            btnDeleteEntityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteEntityButton.Click += btnDeleteCategoryItem_Click;
            // 
            // btnSetAll
            // 
            btnSetAll.AutoSize = false;
            btnSetAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnEBFontTo, btnEBWidthTo, btnEBHeightTo, btnEBPriceTo, btnEBTaxRateTo, btnSetUpperCase, btnSetToLowerCase, btnSetSentenceCase, btnSetAllForeColourTo, btnSetAllBackColourTo, btnSetAllBackColourToTransparent, btnChangeDistributionForEB });
            btnSetAll.Image = Properties.Resources.disli32;
            btnSetAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSetAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSetAll.Name = "btnSetAll";
            btnSetAll.Size = new System.Drawing.Size(80, 51);
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
            btnMoveToEntity.AutoSize = false;
            btnMoveToEntity.Image = Properties.Resources.Curve;
            btnMoveToEntity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnMoveToEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMoveToEntity.Name = "btnMoveToEntity";
            btnMoveToEntity.Size = new System.Drawing.Size(60, 51);
            btnMoveToEntity.Text = "Move To";
            btnMoveToEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnMoveToEntity.Click += BtnMoveToEntity_Click;
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
            // btnClose
            // 
            btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose.AutoSize = false;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(60, 51);
            btnClose.Text = "Close";
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose.Click += btnClose_Click;
            // 
            // btnCategoryItemSample
            // 
            btnCategoryItemSample.AutoSize = false;
            btnCategoryItemSample.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCategoryItemSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCategoryItemSample.Name = "btnCategoryItemSample";
            btnCategoryItemSample.Size = new System.Drawing.Size(100, 51);
            btnCategoryItemSample.Text = "Sample";
            btnCategoryItemSample.Paint += btnCategoryItemSample_Paint;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn8.HeaderText = "QType";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "QuantityType";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn10.HeaderText = "QType";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "CategoryType";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn14.HeaderText = "QType";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "QuantityType";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn15.HeaderText = "QType";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "QuantityType";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn19.HeaderText = "DL Price";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.ToolTipText = "Delivery Price";
            dataGridViewTextBoxColumn19.Width = 75;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn20.HeaderText = "Width";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Visible = false;
            dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn21.HeaderText = "Height";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Visible = false;
            dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "DirectSaleTaxPercent";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn22.HeaderText = "DS Tax%";
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            dataGridViewTextBoxColumn22.ToolTipText = "Direct Sale Tax";
            dataGridViewTextBoxColumn22.Width = 80;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.DataPropertyName = "InHouseTaxPercent";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn23.HeaderText = "IH Tax%";
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.ReadOnly = true;
            dataGridViewTextBoxColumn23.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn23.Width = 80;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.DataPropertyName = "TakeAwayTaxPercent";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn24.HeaderText = "TA Tax%";
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            dataGridViewTextBoxColumn24.ReadOnly = true;
            dataGridViewTextBoxColumn24.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn24.Width = 80;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.DataPropertyName = "DeliveryTaxPercent";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn25.HeaderText = "DL Tax%";
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            dataGridViewTextBoxColumn25.ReadOnly = true;
            dataGridViewTextBoxColumn25.ToolTipText = "Delivery Tax";
            dataGridViewTextBoxColumn25.Width = 80;
            // 
            // dataGridViewTextBoxColumn26
            // 
            dataGridViewTextBoxColumn26.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn26.HeaderText = "DO";
            dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            dataGridViewTextBoxColumn26.ReadOnly = true;
            dataGridViewTextBoxColumn26.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            dataGridViewTextBoxColumn27.DataPropertyName = "FFamily";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn27.HeaderText = "Font";
            dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            dataGridViewTextBoxColumn27.ReadOnly = true;
            dataGridViewTextBoxColumn27.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn27.Width = 75;
            // 
            // dataGridViewTextBoxColumn28
            // 
            dataGridViewTextBoxColumn28.DataPropertyName = "FSize";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn28.HeaderText = "FSize";
            dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            dataGridViewTextBoxColumn28.ReadOnly = true;
            dataGridViewTextBoxColumn28.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn28.Width = 75;
            // 
            // dataGridViewTextBoxColumn29
            // 
            dataGridViewTextBoxColumn29.DataPropertyName = "FStyle";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle25;
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
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn47.DefaultCellStyle = dataGridViewCellStyle26;
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
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvCategoryItem);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(barEntityButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvStockItems);
            splitContainer1.Panel2.Controls.Add(pnlEBPicture);
            splitContainer1.Panel2.Controls.Add(barStockUsage);
            splitContainer1.Size = new System.Drawing.Size(1021, 995);
            splitContainer1.SplitterDistance = 614;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCategory);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1021, 24);
            panel1.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = System.Windows.Forms.DockStyle.Left;
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblCategory.Location = new System.Drawing.Point(0, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(129, 21);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category Not Set";
            // 
            // frmCategoryItemList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1021, 995);
            Controls.Add(splitContainer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmCategoryItemList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "CATEGORY EDITOR";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMenuEditor_Load;
            KeyDown += FrmMenuEditor_KeyDown;
            popCategoryItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonStockItemLookUpBindingSource).EndInit();
            pnlEBPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxEBPicture).EndInit();
            barStockUsage.ResumeLayout(false);
            barStockUsage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)_categoryItemSourceDesign).EndInit();
            barEntityButton.ResumeLayout(false);
            barEntityButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entityButtonExtendedBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource entityButtonBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource entityButtonSearchResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridView dgvCategoryItem;
        private System.Windows.Forms.ToolStrip barEntityButton;
        private System.Windows.Forms.ToolStripButton btnAddEntityButton;
        private System.Windows.Forms.ToolStripButton btnEditEntityButton;
        private System.Windows.Forms.ToolStripButton btnDeleteEntityButton;
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
        private System.Windows.Forms.ToolStripButton btnCopyStockUsageItems;
        private System.Windows.Forms.ToolStripButton btnPasteStockUsageItems;
        private System.Windows.Forms.ToolStripButton btnPasteSpecialStockUsageItems;
        private System.Windows.Forms.ToolStripLabel lblImageSize;
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
        private System.Windows.Forms.BindingSource theMenuBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ToolStripButton tsSortStockItem;
        private System.Windows.Forms.ToolStripButton tsMoveUpStockItem;
        private System.Windows.Forms.ToolStripButton tsMoveDownStockItem;
        private System.Windows.Forms.ToolStripButton tsSortCategoryItem;
        private System.Windows.Forms.ToolStripButton tsMoveUpCategoryItem;
        private System.Windows.Forms.ToolStripButton tsMoveDownCategoryItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ContextMenuStrip popCategoryItem;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnCategoryItemSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitinTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitinPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonDisplayStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textAlignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textImageRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageAlignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryItemBindingSource;
        private System.Windows.Forms.BindingSource _categoryItemSourceDesign;
    }
}

