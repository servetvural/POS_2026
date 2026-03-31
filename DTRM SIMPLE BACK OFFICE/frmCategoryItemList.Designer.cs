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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryItemList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dgvRecipe = new System.Windows.Forms.DataGridView();
            recipeTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stockItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            recipeBindingSource = new System.Windows.Forms.BindingSource(components);
            entityButtonStockItemLookUpBindingSource = new System.Windows.Forms.BindingSource(components);
            pnlEBPicture = new System.Windows.Forms.Panel();
            pboxEBPicture = new System.Windows.Forms.PictureBox();
            barStockUsage = new System.Windows.Forms.ToolStrip();
            btnAddRecipeItem = new System.Windows.Forms.ToolStripButton();
            btnEditStockItem = new System.Windows.Forms.ToolStripButton();
            btnDeleteStockItem = new System.Windows.Forms.ToolStripButton();
            btnCopyRecipeItems = new System.Windows.Forms.ToolStripButton();
            btnPasteRecipeItems = new System.Windows.Forms.ToolStripButton();
            btnQuantityToComment = new System.Windows.Forms.ToolStripButton();
            tsSortRecipeItem = new System.Windows.Forms.ToolStripButton();
            tsMoveUpRecipeItem = new System.Windows.Forms.ToolStripButton();
            tsMoveDownRecipeItem = new System.Windows.Forms.ToolStripButton();
            dgvCategoryItem = new System.Windows.Forms.DataGridView();
            itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            distributionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sitinPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            saleTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sitinTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            padFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonDisplayStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textAlignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textImageRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            imageAlignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)dgvRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
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
            popEBSetToUpperCase.Click += btnSetUpperCase_Click;
            // 
            // popEBSetToLowercase
            // 
            popEBSetToLowercase.Name = "popEBSetToLowercase";
            popEBSetToLowercase.Size = new System.Drawing.Size(235, 22);
            popEBSetToLowercase.Text = "Set To lowercase";
            popEBSetToLowercase.Click += btnSetToLowerCase_Click;
            // 
            // popSetSentenceCase
            // 
            popSetSentenceCase.Name = "popSetSentenceCase";
            popSetSentenceCase.Size = new System.Drawing.Size(235, 22);
            popSetSentenceCase.Text = "Set To Sentence Case";
            popSetSentenceCase.Click += btnSetSentenceCase_Click;
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
            popSetAllForeColourTo.Click += btnSetAllForeColourTo_Click;
            // 
            // popSetAllBackColourTo
            // 
            popSetAllBackColourTo.Name = "popSetAllBackColourTo";
            popSetAllBackColourTo.Size = new System.Drawing.Size(235, 22);
            popSetAllBackColourTo.Text = "Set BackColour";
            popSetAllBackColourTo.Click += btnSetAllBackColourTo_Click;
            // 
            // popSetAllBackColourToTransparent
            // 
            popSetAllBackColourToTransparent.Name = "popSetAllBackColourToTransparent";
            popSetAllBackColourToTransparent.Size = new System.Drawing.Size(235, 22);
            popSetAllBackColourToTransparent.Text = "Set BackColour To Transparent";
            popSetAllBackColourToTransparent.Click += btnSetAllBackColourToTransparent_Click;
            // 
            // popSetAllDistributionTo
            // 
            popSetAllDistributionTo.Name = "popSetAllDistributionTo";
            popSetAllDistributionTo.Size = new System.Drawing.Size(235, 22);
            popSetAllDistributionTo.Text = "Set Distribution";
            popSetAllDistributionTo.Click += btnChangeDistribution_Click;
            // 
            // dgvRecipe
            // 
            dgvRecipe.AllowDrop = true;
            dgvRecipe.AllowUserToAddRows = false;
            dgvRecipe.AllowUserToDeleteRows = false;
            dgvRecipe.AutoGenerateColumns = false;
            dgvRecipe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { recipeTextDataGridViewTextBoxColumn, stockItemNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, quantityTypeDataGridViewTextBoxColumn, dOrderDataGridViewTextBoxColumn1, commentDataGridViewTextBoxColumn });
            dgvRecipe.DataSource = recipeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvRecipe.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRecipe.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvRecipe.Location = new System.Drawing.Point(163, 54);
            dgvRecipe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvRecipe.Name = "dgvRecipe";
            dgvRecipe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRecipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRecipe.RowHeadersWidth = 25;
            dgvRecipe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRecipe.Size = new System.Drawing.Size(1062, 307);
            dgvRecipe.TabIndex = 11;
            dgvRecipe.CellDoubleClick += dgvRecipeItems_CellDoubleClick;
            dgvRecipe.SelectionChanged += dgvRecipe_SelectionChanged;
            // 
            // recipeTextDataGridViewTextBoxColumn
            // 
            recipeTextDataGridViewTextBoxColumn.DataPropertyName = "RecipeText";
            recipeTextDataGridViewTextBoxColumn.HeaderText = "RecipeText";
            recipeTextDataGridViewTextBoxColumn.Name = "recipeTextDataGridViewTextBoxColumn";
            recipeTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockItemNameDataGridViewTextBoxColumn
            // 
            stockItemNameDataGridViewTextBoxColumn.DataPropertyName = "StockItemName";
            stockItemNameDataGridViewTextBoxColumn.HeaderText = "StockItemName";
            stockItemNameDataGridViewTextBoxColumn.Name = "stockItemNameDataGridViewTextBoxColumn";
            stockItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityTypeDataGridViewTextBoxColumn
            // 
            quantityTypeDataGridViewTextBoxColumn.DataPropertyName = "QuantityType";
            quantityTypeDataGridViewTextBoxColumn.HeaderText = "QuantityType";
            quantityTypeDataGridViewTextBoxColumn.Name = "quantityTypeDataGridViewTextBoxColumn";
            quantityTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOrderDataGridViewTextBoxColumn1
            // 
            dOrderDataGridViewTextBoxColumn1.DataPropertyName = "DOrder";
            dOrderDataGridViewTextBoxColumn1.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn1.Name = "dOrderDataGridViewTextBoxColumn1";
            dOrderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Recipe);
            // 
            // pnlEBPicture
            // 
            pnlEBPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            pnlEBPicture.Controls.Add(pboxEBPicture);
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
            pboxEBPicture.Location = new System.Drawing.Point(0, 0);
            pboxEBPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pboxEBPicture.Name = "pboxEBPicture";
            pboxEBPicture.Size = new System.Drawing.Size(163, 307);
            pboxEBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pboxEBPicture.TabIndex = 10;
            pboxEBPicture.TabStop = false;
            pboxEBPicture.DoubleClick += pboxEBPicture_DoubleClick;
            // 
            // barStockUsage
            // 
            barStockUsage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddRecipeItem, btnEditStockItem, btnDeleteStockItem, btnCopyRecipeItems, btnPasteRecipeItems, btnQuantityToComment, tsSortRecipeItem, tsMoveUpRecipeItem, tsMoveDownRecipeItem });
            barStockUsage.Location = new System.Drawing.Point(0, 0);
            barStockUsage.Name = "barStockUsage";
            barStockUsage.Size = new System.Drawing.Size(1225, 54);
            barStockUsage.TabIndex = 1;
            barStockUsage.Text = "toolStrip1";
            // 
            // btnAddRecipeItem
            // 
            btnAddRecipeItem.AutoSize = false;
            btnAddRecipeItem.Image = Properties.Resources.arti32;
            btnAddRecipeItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddRecipeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddRecipeItem.Name = "btnAddRecipeItem";
            btnAddRecipeItem.Size = new System.Drawing.Size(60, 51);
            btnAddRecipeItem.Text = "   Add   ";
            btnAddRecipeItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddRecipeItem.Click += btnAddRecipeItem_Click;
            // 
            // btnEditStockItem
            // 
            btnEditStockItem.AutoSize = false;
            btnEditStockItem.Image = Properties.Resources.MatReport_32;
            btnEditStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEditStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEditStockItem.Name = "btnEditStockItem";
            btnEditStockItem.Size = new System.Drawing.Size(60, 51);
            btnEditStockItem.Text = "  Edit  ";
            btnEditStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEditStockItem.Click += btnEditRecipeItem_Click;
            // 
            // btnDeleteStockItem
            // 
            btnDeleteStockItem.AutoSize = false;
            btnDeleteStockItem.Image = Properties.Resources.eksi32;
            btnDeleteStockItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteStockItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteStockItem.Name = "btnDeleteStockItem";
            btnDeleteStockItem.Size = new System.Drawing.Size(60, 51);
            btnDeleteStockItem.Text = " Delete ";
            btnDeleteStockItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteStockItem.Click += btnDeleteRecipeItem_Click;
            // 
            // btnCopyRecipeItems
            // 
            btnCopyRecipeItems.AutoSize = false;
            btnCopyRecipeItems.Image = Properties.Resources.WindowCascade;
            btnCopyRecipeItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCopyRecipeItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCopyRecipeItems.Name = "btnCopyRecipeItems";
            btnCopyRecipeItems.Size = new System.Drawing.Size(80, 51);
            btnCopyRecipeItems.Text = "Copy Items";
            btnCopyRecipeItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCopyRecipeItems.Click += btnCopyRecipeItems_Click;
            // 
            // btnPasteRecipeItems
            // 
            btnPasteRecipeItems.AutoSize = false;
            btnPasteRecipeItems.Image = Properties.Resources.Paste232;
            btnPasteRecipeItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPasteRecipeItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPasteRecipeItems.Name = "btnPasteRecipeItems";
            btnPasteRecipeItems.Size = new System.Drawing.Size(80, 51);
            btnPasteRecipeItems.Text = "Paste Items";
            btnPasteRecipeItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPasteRecipeItems.Click += btnPasteRecipeItems_Click;
            // 
            // btnQuantityToComment
            // 
            btnQuantityToComment.Image = Properties.Resources.comment;
            btnQuantityToComment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnQuantityToComment.Name = "btnQuantityToComment";
            btnQuantityToComment.Size = new System.Drawing.Size(65, 51);
            btnQuantityToComment.Text = "Comment";
            btnQuantityToComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnQuantityToComment.ToolTipText = "Generate Comment from Quantity";
            btnQuantityToComment.Click += btnQuantityToComment_Click;
            // 
            // tsSortRecipeItem
            // 
            tsSortRecipeItem.AutoSize = false;
            tsSortRecipeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSortRecipeItem.Image = Properties.Resources.updown;
            tsSortRecipeItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSortRecipeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSortRecipeItem.Name = "tsSortRecipeItem";
            tsSortRecipeItem.Size = new System.Drawing.Size(60, 51);
            tsSortRecipeItem.Text = "toolStripButton1";
            tsSortRecipeItem.Click += tsSortRecipeItem_Click;
            // 
            // tsMoveUpRecipeItem
            // 
            tsMoveUpRecipeItem.AutoSize = false;
            tsMoveUpRecipeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUpRecipeItem.Image = Properties.Resources.up2;
            tsMoveUpRecipeItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUpRecipeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUpRecipeItem.Name = "tsMoveUpRecipeItem";
            tsMoveUpRecipeItem.Size = new System.Drawing.Size(60, 51);
            tsMoveUpRecipeItem.Text = "toolStripButton1";
            tsMoveUpRecipeItem.Click += tsMoveUpRecipeItem_Click;
            // 
            // tsMoveDownRecipeItem
            // 
            tsMoveDownRecipeItem.AutoSize = false;
            tsMoveDownRecipeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDownRecipeItem.Image = Properties.Resources.down2;
            tsMoveDownRecipeItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDownRecipeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDownRecipeItem.Name = "tsMoveDownRecipeItem";
            tsMoveDownRecipeItem.Size = new System.Drawing.Size(60, 51);
            tsMoveDownRecipeItem.Text = "toolStripButton1";
            tsMoveDownRecipeItem.Click += tsMoveDownRecipeItem_Click;
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
            dgvCategoryItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { itemNameDataGridViewTextBoxColumn, buttonTypeDataGridViewTextBoxColumn, dOrderDataGridViewTextBoxColumn, distributionNameDataGridViewTextBoxColumn, salePriceDataGridViewTextBoxColumn, sitinPriceDataGridViewTextBoxColumn, taPriceDataGridViewTextBoxColumn, dPriceDataGridViewTextBoxColumn, saleTaxDataGridViewTextBoxColumn, sitinTaxDataGridViewTextBoxColumn, taTaxDataGridViewTextBoxColumn, dTaxDataGridViewTextBoxColumn, padFlagDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, fontDataGridViewTextBoxColumn, buttonDisplayStyleDataGridViewTextBoxColumn, textAlignDataGridViewTextBoxColumn, textImageRelationDataGridViewTextBoxColumn, imageAlignDataGridViewTextBoxColumn });
            dgvCategoryItem.ContextMenuStrip = popCategoryItem;
            dgvCategoryItem.DataSource = _categoryItemSourceDesign;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategoryItem.DefaultCellStyle = dataGridViewCellStyle4;
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
            dgvCategoryItem.Size = new System.Drawing.Size(1225, 536);
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
            // dOrderDataGridViewTextBoxColumn
            // 
            dOrderDataGridViewTextBoxColumn.DataPropertyName = "DOrder";
            dOrderDataGridViewTextBoxColumn.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn.Name = "dOrderDataGridViewTextBoxColumn";
            dOrderDataGridViewTextBoxColumn.ReadOnly = true;
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
            // _categoryItemSourceDesign
            // 
            _categoryItemSourceDesign.DataSource = typeof(CategoryItem);
            // 
            // barEntityButton
            // 
            barEntityButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddEntityButton, btnEditEntityButton, btnDeleteEntityButton, btnSetAll, btnMoveToEntity, btnDuplicate, btnConvertToStockItem, btnEntityButtonRowHeight, tsSortCategoryItem, tsMoveUpCategoryItem, tsMoveDownCategoryItem, btnClose, btnCategoryItemSample });
            barEntityButton.Location = new System.Drawing.Point(0, 0);
            barEntityButton.Name = "barEntityButton";
            barEntityButton.Size = new System.Drawing.Size(1225, 54);
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
            btnEBFontTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEBFontTo.Name = "btnEBFontTo";
            btnEBFontTo.Size = new System.Drawing.Size(303, 30);
            btnEBFontTo.Text = "Font To";
            btnEBFontTo.Click += BtnEBFontTo_Click;
            // 
            // btnEBWidthTo
            // 
            btnEBWidthTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEBWidthTo.Name = "btnEBWidthTo";
            btnEBWidthTo.Size = new System.Drawing.Size(303, 30);
            btnEBWidthTo.Text = "Width To";
            btnEBWidthTo.Click += BtnEBWidthTo_Click;
            // 
            // btnEBHeightTo
            // 
            btnEBHeightTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEBHeightTo.Name = "btnEBHeightTo";
            btnEBHeightTo.Size = new System.Drawing.Size(303, 30);
            btnEBHeightTo.Text = "Height To";
            btnEBHeightTo.Click += BtnEBHeightTo_Click;
            // 
            // btnEBPriceTo
            // 
            btnEBPriceTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEBPriceTo.Name = "btnEBPriceTo";
            btnEBPriceTo.Size = new System.Drawing.Size(303, 30);
            btnEBPriceTo.Text = "Price To";
            btnEBPriceTo.Click += BtnEBPriceTo_Click;
            // 
            // btnEBTaxRateTo
            // 
            btnEBTaxRateTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEBTaxRateTo.Name = "btnEBTaxRateTo";
            btnEBTaxRateTo.Size = new System.Drawing.Size(303, 30);
            btnEBTaxRateTo.Text = "Tax Rate To";
            btnEBTaxRateTo.Click += BtnEBTaxRateTo_Click;
            // 
            // btnSetUpperCase
            // 
            btnSetUpperCase.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSetUpperCase.Name = "btnSetUpperCase";
            btnSetUpperCase.Size = new System.Drawing.Size(303, 30);
            btnSetUpperCase.Text = "Set To UPPER CASE";
            btnSetUpperCase.Click += btnSetUpperCase_Click;
            // 
            // btnSetToLowerCase
            // 
            btnSetToLowerCase.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSetToLowerCase.Name = "btnSetToLowerCase";
            btnSetToLowerCase.Size = new System.Drawing.Size(303, 30);
            btnSetToLowerCase.Text = "Set To lower case";
            btnSetToLowerCase.Click += btnSetToLowerCase_Click;
            // 
            // btnSetSentenceCase
            // 
            btnSetSentenceCase.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSetSentenceCase.Name = "btnSetSentenceCase";
            btnSetSentenceCase.Size = new System.Drawing.Size(303, 30);
            btnSetSentenceCase.Text = "Set To Sentence Case";
            btnSetSentenceCase.Click += btnSetSentenceCase_Click;
            // 
            // btnSetAllForeColourTo
            // 
            btnSetAllForeColourTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSetAllForeColourTo.Name = "btnSetAllForeColourTo";
            btnSetAllForeColourTo.Size = new System.Drawing.Size(303, 30);
            btnSetAllForeColourTo.Text = "ForeColour To";
            btnSetAllForeColourTo.Click += btnSetAllForeColourTo_Click;
            // 
            // btnSetAllBackColourTo
            // 
            btnSetAllBackColourTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSetAllBackColourTo.Name = "btnSetAllBackColourTo";
            btnSetAllBackColourTo.Size = new System.Drawing.Size(303, 30);
            btnSetAllBackColourTo.Text = "BackColour To";
            btnSetAllBackColourTo.Click += btnSetAllBackColourTo_Click;
            // 
            // btnSetAllBackColourToTransparent
            // 
            btnSetAllBackColourToTransparent.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSetAllBackColourToTransparent.Name = "btnSetAllBackColourToTransparent";
            btnSetAllBackColourToTransparent.Size = new System.Drawing.Size(303, 30);
            btnSetAllBackColourToTransparent.Text = "BackColour To Transparent";
            btnSetAllBackColourToTransparent.Click += btnSetAllBackColourToTransparent_Click;
            // 
            // btnChangeDistributionForEB
            // 
            btnChangeDistributionForEB.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnChangeDistributionForEB.Name = "btnChangeDistributionForEB";
            btnChangeDistributionForEB.Size = new System.Drawing.Size(303, 30);
            btnChangeDistributionForEB.Text = "Distribution To";
            btnChangeDistributionForEB.Click += btnChangeDistribution_Click;
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
            btnEntityButtonRowHeight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnEntityButtonRowHeight25, btnEntityButtonRowHeight50, btnEntityButtonRowHeight100, toolStripSeparator1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            btnEntityButtonRowHeight.Image = (System.Drawing.Image)resources.GetObject("btnEntityButtonRowHeight.Image");
            btnEntityButtonRowHeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEntityButtonRowHeight.Name = "btnEntityButtonRowHeight";
            btnEntityButtonRowHeight.Size = new System.Drawing.Size(122, 51);
            btnEntityButtonRowHeight.Text = "Row Height && Font";
            // 
            // btnEntityButtonRowHeight25
            // 
            btnEntityButtonRowHeight25.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEntityButtonRowHeight25.Name = "btnEntityButtonRowHeight25";
            btnEntityButtonRowHeight25.Size = new System.Drawing.Size(265, 30);
            btnEntityButtonRowHeight25.Tag = "25";
            btnEntityButtonRowHeight25.Text = "Small Row Size (25)";
            btnEntityButtonRowHeight25.Click += btnEntityButtonRowHeight_Click;
            // 
            // btnEntityButtonRowHeight50
            // 
            btnEntityButtonRowHeight50.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEntityButtonRowHeight50.Name = "btnEntityButtonRowHeight50";
            btnEntityButtonRowHeight50.Size = new System.Drawing.Size(265, 30);
            btnEntityButtonRowHeight50.Tag = "50";
            btnEntityButtonRowHeight50.Text = "Medium Row Size (50)";
            btnEntityButtonRowHeight50.Click += btnEntityButtonRowHeight_Click;
            // 
            // btnEntityButtonRowHeight100
            // 
            btnEntityButtonRowHeight100.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnEntityButtonRowHeight100.Name = "btnEntityButtonRowHeight100";
            btnEntityButtonRowHeight100.Size = new System.Drawing.Size(265, 30);
            btnEntityButtonRowHeight100.Tag = "100";
            btnEntityButtonRowHeight100.Text = "Large Row Size (100)";
            btnEntityButtonRowHeight100.Click += btnEntityButtonRowHeight_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(262, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 14F);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(265, 30);
            toolStripMenuItem2.Tag = "10";
            toolStripMenuItem2.Text = "Grid Font 10";
            toolStripMenuItem2.Click += btnGridFontSize_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 14F);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(265, 30);
            toolStripMenuItem3.Tag = "14";
            toolStripMenuItem3.Text = "Grid Font 14";
            toolStripMenuItem3.Click += btnGridFontSize_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 14F);
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(265, 30);
            toolStripMenuItem4.Tag = "18";
            toolStripMenuItem4.Text = "Grid Font 18";
            toolStripMenuItem4.Click += btnGridFontSize_Click;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn8.HeaderText = "QType";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "QuantityType";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn10.HeaderText = "QType";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "CategoryType";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTextBoxColumn14.HeaderText = "QType";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "QuantityType";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn15.HeaderText = "QType";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "QuantityType";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn19.HeaderText = "DL Price";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.ToolTipText = "Delivery Price";
            dataGridViewTextBoxColumn19.Width = 75;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn20.HeaderText = "Width";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Visible = false;
            dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn21.HeaderText = "Height";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Visible = false;
            dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "DirectSaleTaxPercent";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn22.HeaderText = "DS Tax%";
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            dataGridViewTextBoxColumn22.ToolTipText = "Direct Sale Tax";
            dataGridViewTextBoxColumn22.Width = 80;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.DataPropertyName = "InHouseTaxPercent";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn23.HeaderText = "IH Tax%";
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.ReadOnly = true;
            dataGridViewTextBoxColumn23.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn23.Width = 80;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.DataPropertyName = "TakeAwayTaxPercent";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn24.HeaderText = "TA Tax%";
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            dataGridViewTextBoxColumn24.ReadOnly = true;
            dataGridViewTextBoxColumn24.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn24.Width = 80;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.DataPropertyName = "DeliveryTaxPercent";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn25.HeaderText = "DL Tax%";
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            dataGridViewTextBoxColumn25.ReadOnly = true;
            dataGridViewTextBoxColumn25.ToolTipText = "Delivery Tax";
            dataGridViewTextBoxColumn25.Width = 80;
            // 
            // dataGridViewTextBoxColumn26
            // 
            dataGridViewTextBoxColumn26.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn26.HeaderText = "DO";
            dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            dataGridViewTextBoxColumn26.ReadOnly = true;
            dataGridViewTextBoxColumn26.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            dataGridViewTextBoxColumn27.DataPropertyName = "FFamily";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn27.HeaderText = "Font";
            dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            dataGridViewTextBoxColumn27.ReadOnly = true;
            dataGridViewTextBoxColumn27.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn27.Width = 75;
            // 
            // dataGridViewTextBoxColumn28
            // 
            dataGridViewTextBoxColumn28.DataPropertyName = "FSize";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn28.HeaderText = "FSize";
            dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            dataGridViewTextBoxColumn28.ReadOnly = true;
            dataGridViewTextBoxColumn28.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn28.Width = 75;
            // 
            // dataGridViewTextBoxColumn29
            // 
            dataGridViewTextBoxColumn29.DataPropertyName = "FStyle";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn47.DefaultCellStyle = dataGridViewCellStyle25;
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
            splitContainer1.Panel2.Controls.Add(dgvRecipe);
            splitContainer1.Panel2.Controls.Add(pnlEBPicture);
            splitContainer1.Panel2.Controls.Add(barStockUsage);
            splitContainer1.Size = new System.Drawing.Size(1225, 995);
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
            panel1.Size = new System.Drawing.Size(1225, 24);
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
            ClientSize = new System.Drawing.Size(1225, 995);
            Controls.Add(splitContainer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmCategoryItemList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "CATEGORY EDITOR";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMenuEditor_Load;
            popCategoryItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.Panel pnlEBPicture;
        private System.Windows.Forms.PictureBox pboxEBPicture;
        private System.Windows.Forms.ToolStrip barStockUsage;
        private System.Windows.Forms.ToolStripButton btnAddRecipeItem;
        private System.Windows.Forms.ToolStripButton btnEditStockItem;
        private System.Windows.Forms.ToolStripButton btnDeleteStockItem;
        private System.Windows.Forms.ToolStripButton btnCopyRecipeItems;
        private System.Windows.Forms.ToolStripButton btnPasteRecipeItems;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colEBSItemDisplayOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnQuantityToComment;
        private System.Windows.Forms.BindingSource theMenuBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ToolStripButton tsSortRecipeItem;
        private System.Windows.Forms.ToolStripButton tsMoveUpRecipeItem;
        private System.Windows.Forms.ToolStripButton tsMoveDownRecipeItem;
        private System.Windows.Forms.ToolStripButton tsSortCategoryItem;
        private System.Windows.Forms.ToolStripButton tsMoveUpCategoryItem;
        private System.Windows.Forms.ToolStripButton tsMoveDownCategoryItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ContextMenuStrip popCategoryItem;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnCategoryItemSample;
        private System.Windows.Forms.BindingSource categoryItemBindingSource;
        private System.Windows.Forms.BindingSource _categoryItemSourceDesign;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compulsaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fFamilyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitinPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitinTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonDisplayStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textAlignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textImageRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageAlignDataGridViewTextBoxColumn;
    }
}

