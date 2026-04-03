using DTRMSimpleBackOffice.Properties;

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
            dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _recipeItemBindingSource = new System.Windows.Forms.BindingSource(components);
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
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            panel1 = new System.Windows.Forms.Panel();
            lblCategory = new System.Windows.Forms.Label();
            popCategoryItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_recipeItemBindingSource).BeginInit();
            pnlEBPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxEBPicture).BeginInit();
            barStockUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_categoryItemSourceDesign).BeginInit();
            barEntityButton.SuspendLayout();
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
            dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn32, dataGridViewTextBoxColumn24, dataGridViewTextBoxColumn28, dataGridViewTextBoxColumn29, dataGridViewTextBoxColumn30, dataGridViewTextBoxColumn34 });
            dgvRecipe.DataSource = _recipeItemBindingSource;
            dgvRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRecipe.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvRecipe.Location = new System.Drawing.Point(163, 54);
            dgvRecipe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvRecipe.Name = "dgvRecipe";
            dgvRecipe.ReadOnly = true;
            dgvRecipe.RowHeadersWidth = 25;
            dgvRecipe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRecipe.Size = new System.Drawing.Size(828, 124);
            dgvRecipe.TabIndex = 11;
            dgvRecipe.CellDoubleClick += dgvRecipeItems_CellDoubleClick;
            dgvRecipe.SelectionChanged += dgvRecipe_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn32
            // 
            dataGridViewTextBoxColumn32.DataPropertyName = "RecipeText";
            dataGridViewTextBoxColumn32.HeaderText = "RecipeText";
            dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.DataPropertyName = "StockItemName";
            dataGridViewTextBoxColumn24.HeaderText = "StockItemName";
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            dataGridViewTextBoxColumn28.DataPropertyName = "QuantityType";
            dataGridViewTextBoxColumn28.HeaderText = "QuantityType";
            dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            dataGridViewTextBoxColumn29.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn29.HeaderText = "Quantity";
            dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            dataGridViewTextBoxColumn30.DataPropertyName = "Comment";
            dataGridViewTextBoxColumn30.HeaderText = "Comment";
            dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            dataGridViewTextBoxColumn34.DataPropertyName = "DOrder";
            dataGridViewTextBoxColumn34.HeaderText = "DOrder";
            dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // _recipeItemBindingSource
            // 
            _recipeItemBindingSource.DataSource = typeof(RecipeItem);
            // 
            // pnlEBPicture
            // 
            pnlEBPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            pnlEBPicture.Controls.Add(pboxEBPicture);
            pnlEBPicture.Dock = System.Windows.Forms.DockStyle.Left;
            pnlEBPicture.Location = new System.Drawing.Point(0, 54);
            pnlEBPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlEBPicture.Name = "pnlEBPicture";
            pnlEBPicture.Size = new System.Drawing.Size(163, 124);
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
            pboxEBPicture.Size = new System.Drawing.Size(163, 124);
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
            barStockUsage.Size = new System.Drawing.Size(991, 54);
            barStockUsage.TabIndex = 1;
            barStockUsage.Text = "toolStrip1";
            // 
            // btnAddRecipeItem
            // 
            btnAddRecipeItem.AutoSize = false;
            btnAddRecipeItem.Image = Resources.arti32;
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
            btnEditStockItem.Image = Resources.MatReport_32;
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
            btnDeleteStockItem.Image = Resources.eksi32;
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
            btnCopyRecipeItems.Image = Resources.WindowCascade;
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
            btnPasteRecipeItems.Image = Resources.Paste232;
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
            btnQuantityToComment.Image = Resources.comment;
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
            tsSortRecipeItem.Image = Resources.updown;
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
            tsMoveUpRecipeItem.Image = Resources.up2;
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
            tsMoveDownRecipeItem.Image = Resources.down2;
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
            dgvCategoryItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn21 });
            dgvCategoryItem.ContextMenuStrip = popCategoryItem;
            dgvCategoryItem.DataSource = _categoryItemSourceDesign;
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
            dgvCategoryItem.Size = new System.Drawing.Size(991, 239);
            dgvCategoryItem.TabIndex = 0;
            dgvCategoryItem.CellDoubleClick += dgvCategoryItem_CellDoubleClick;
            dgvCategoryItem.SelectionChanged += dgvCategoryItem_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            dataGridViewTextBoxColumn1.HeaderText = "ItemName";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ButtonType";
            dataGridViewTextBoxColumn2.HeaderText = "ButtonType";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "SalePrice";
            dataGridViewTextBoxColumn9.HeaderText = "SalePrice";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "SitinPrice";
            dataGridViewTextBoxColumn10.HeaderText = "SitinPrice";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "TaPrice";
            dataGridViewTextBoxColumn11.HeaderText = "TaPrice";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "DPrice";
            dataGridViewTextBoxColumn12.HeaderText = "DPrice";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "PadFlag";
            dataGridViewTextBoxColumn7.HeaderText = "PadFlag";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "DistributionName";
            dataGridViewTextBoxColumn8.HeaderText = "DistributionName";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SaleTax";
            dataGridViewTextBoxColumn3.HeaderText = "SaleTax";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "SitinTax";
            dataGridViewTextBoxColumn4.HeaderText = "SitinTax";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "TaTax";
            dataGridViewTextBoxColumn5.HeaderText = "TaTax";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "DTax";
            dataGridViewTextBoxColumn6.HeaderText = "DTax";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Width";
            dataGridViewTextBoxColumn13.HeaderText = "Width";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "Height";
            dataGridViewTextBoxColumn14.HeaderText = "Height";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "Font";
            dataGridViewTextBoxColumn15.HeaderText = "Font";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "ButtonDisplayStyle";
            dataGridViewTextBoxColumn16.HeaderText = "ButtonDisplayStyle";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "TextAlign";
            dataGridViewTextBoxColumn17.HeaderText = "TextAlign";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "TextImageRelation";
            dataGridViewTextBoxColumn18.HeaderText = "TextImageRelation";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "ImageAlign";
            dataGridViewTextBoxColumn19.HeaderText = "ImageAlign";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "DOrder";
            dataGridViewTextBoxColumn21.HeaderText = "DOrder";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
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
            barEntityButton.Size = new System.Drawing.Size(991, 54);
            barEntityButton.TabIndex = 0;
            barEntityButton.Text = "toolStrip1";
            // 
            // btnAddEntityButton
            // 
            btnAddEntityButton.AutoSize = false;
            btnAddEntityButton.Image = Resources.arti32;
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
            btnEditEntityButton.Image = Resources.MatReport_32;
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
            btnDeleteEntityButton.Image = Resources.eksi32;
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
            btnSetAll.Image = Resources.disli32;
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
            btnMoveToEntity.Image = Resources.Curve;
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
            btnDuplicate.Image = Resources.WindowCascade;
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
            btnConvertToStockItem.Image = Resources.DBDestination32;
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
            tsSortCategoryItem.Image = Resources.updown;
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
            tsMoveUpCategoryItem.Image = Resources.up2;
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
            tsMoveDownCategoryItem.Image = Resources.down2;
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
            btnClose.Image = Resources.Cancel;
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
            splitContainer1.Size = new System.Drawing.Size(991, 515);
            splitContainer1.SplitterDistance = 317;
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
            panel1.Size = new System.Drawing.Size(991, 24);
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
            ClientSize = new System.Drawing.Size(991, 515);
            Controls.Add(splitContainer1);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmCategoryItemList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "CATEGORY EDITOR";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMenuEditor_Load;
            popCategoryItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)_recipeItemBindingSource).EndInit();
            pnlEBPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxEBPicture).EndInit();
            barStockUsage.ResumeLayout(false);
            barStockUsage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)_categoryItemSourceDesign).EndInit();
            barEntityButton.ResumeLayout(false);
            barEntityButton.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem popSetAllForeColourTo;
        private System.Windows.Forms.ToolStripMenuItem popSetAllBackColourTo;
        private System.Windows.Forms.ToolStripMenuItem popSetAllBackColourToTransparent;
        private System.Windows.Forms.ToolStripMenuItem popSetAllDistributionTo;
        private System.Windows.Forms.ToolStripMenuItem popSetSentenceCase;
        private System.Windows.Forms.BindingSource entityButtonSearchResultBindingSource;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitinPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitinTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buttonDisplayStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textAlignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textImageRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageAlignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryItemIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeItemTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource recipeItemBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource _categoryItemSourceDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.BindingSource _recipeItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}

