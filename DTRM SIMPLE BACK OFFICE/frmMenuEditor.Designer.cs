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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEditor));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvMenu = new System.Windows.Forms.DataGridView();
            colMenuIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsActiveMenu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            DOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _menuSourceDesign = new System.Windows.Forms.BindingSource(components);
            dgvCategory = new System.Windows.Forms.DataGridView();
            _categorySourceDesign = new System.Windows.Forms.BindingSource(components);
            barEntity = new System.Windows.Forms.ToolStrip();
            btnAddEntity = new System.Windows.Forms.ToolStripButton();
            btnEditEntity = new System.Windows.Forms.ToolStripButton();
            btnDeleteEntity = new System.Windows.Forms.ToolStripButton();
            tsSortCategory = new System.Windows.Forms.ToolStripButton();
            tsMoveUpCategory = new System.Windows.Forms.ToolStripButton();
            tsMoveDownCategory = new System.Windows.Forms.ToolStripButton();
            btnCategoryItems = new System.Windows.Forms.ToolStripButton();
            btnCategorySample = new System.Windows.Forms.ToolStripButton();
            barMenu = new System.Windows.Forms.ToolStrip();
            btnAddMenu = new System.Windows.Forms.ToolStripButton();
            btnEditMenu = new System.Windows.Forms.ToolStripButton();
            btnDeleteMenu = new System.Windows.Forms.ToolStripButton();
            btnReloadMenu = new System.Windows.Forms.ToolStripButton();
            mnuSetAsDefaultMenu = new System.Windows.Forms.ToolStripButton();
            btnPrintMenu = new System.Windows.Forms.ToolStripButton();
            btnLoadMenu = new System.Windows.Forms.ToolStripButton();
            btnBackupMenu = new System.Windows.Forms.ToolStripButton();
            btnExportStockManager = new System.Windows.Forms.ToolStripButton();
            btnImportStockManager = new System.Windows.Forms.ToolStripButton();
            btnSaveDBImagesToFolder = new System.Windows.Forms.ToolStripButton();
            btnExportMenuAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportMenuFromJSON = new System.Windows.Forms.ToolStripButton();
            tsSortMenu = new System.Windows.Forms.ToolStripButton();
            tsMoveUpMenu = new System.Windows.Forms.ToolStripButton();
            tsMoveDownMenu = new System.Windows.Forms.ToolStripButton();
            btnClose = new System.Windows.Forms.ToolStripButton();
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
            mainContainer = new System.Windows.Forms.SplitContainer();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CategoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistributionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Font = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ButtonDisplayStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TextAlign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TextImageRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ImageAlign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_menuSourceDesign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_categorySourceDesign).BeginInit();
            barEntity.SuspendLayout();
            barMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            mainContainer.Panel2.SuspendLayout();
            mainContainer.SuspendLayout();
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
            dgvMenu.DataSource = _menuSourceDesign;
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
            dgvMenu.Size = new System.Drawing.Size(1575, 213);
            dgvMenu.TabIndex = 1;
            dgvMenu.CellDoubleClick += dgvMenu_CellDoubleClick;
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
            IsActiveMenu.DataPropertyName = "IsActive";
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
            // _menuSourceDesign
            // 
            _menuSourceDesign.DataSource = typeof(TheMenu);
            _menuSourceDesign.Sort = "DOrder";
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
            dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, CategoryType, widthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, DistributionName, Font, dOrderDataGridViewTextBoxColumn, ButtonDisplayStyle, TextAlign, TextImageRelation, ImageAlign });
            dgvCategory.DataSource = _categorySourceDesign;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategory.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvCategory.Location = new System.Drawing.Point(0, 54);
            dgvCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 25;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new System.Drawing.Size(1575, 622);
            dgvCategory.TabIndex = 4;
            dgvCategory.CellDoubleClick += DgvEntity_CellDoubleClick;
            dgvCategory.SelectionChanged += DgvEntity_SelectionChanged;
            // 
            // _categorySourceDesign
            // 
            _categorySourceDesign.DataSource = typeof(Category);
            _categorySourceDesign.Sort = "DOrder";
            // 
            // barEntity
            // 
            barEntity.Enabled = false;
            barEntity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddEntity, btnEditEntity, btnDeleteEntity, tsSortCategory, tsMoveUpCategory, tsMoveDownCategory, btnCategoryItems, btnCategorySample });
            barEntity.Location = new System.Drawing.Point(0, 0);
            barEntity.Name = "barEntity";
            barEntity.Size = new System.Drawing.Size(1575, 54);
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
            btnAddEntity.Size = new System.Drawing.Size(80, 51);
            btnAddEntity.Text = "New Category";
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
            btnEditEntity.Size = new System.Drawing.Size(60, 51);
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
            btnDeleteEntity.Size = new System.Drawing.Size(60, 51);
            btnDeleteEntity.Text = "Delete";
            btnDeleteEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteEntity.Click += BtnDeleteEntity_Click;
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
            // btnCategoryItems
            // 
            btnCategoryItems.Image = Properties.Resources.tree;
            btnCategoryItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnCategoryItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCategoryItems.Name = "btnCategoryItems";
            btnCategoryItems.Size = new System.Drawing.Size(123, 51);
            btnCategoryItems.Text = "Category Items";
            btnCategoryItems.Click += btnCategoryItems_Click;
            // 
            // btnCategorySample
            // 
            btnCategorySample.AutoSize = false;
            btnCategorySample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnCategorySample.Image = (System.Drawing.Image)resources.GetObject("btnCategorySample.Image");
            btnCategorySample.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCategorySample.Name = "btnCategorySample";
            btnCategorySample.Size = new System.Drawing.Size(100, 51);
            btnCategorySample.Text = "Sample";
            btnCategorySample.Paint += btnCategorySample_Paint;
            // 
            // barMenu
            // 
            barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddMenu, btnEditMenu, btnDeleteMenu, btnReloadMenu, mnuSetAsDefaultMenu, btnPrintMenu, btnLoadMenu, btnBackupMenu, btnExportStockManager, btnImportStockManager, btnSaveDBImagesToFolder, btnExportMenuAsJson, btnImportMenuFromJSON, tsSortMenu, tsMoveUpMenu, tsMoveDownMenu, btnClose });
            barMenu.Location = new System.Drawing.Point(0, 0);
            barMenu.Name = "barMenu";
            barMenu.Size = new System.Drawing.Size(1575, 54);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn8.HeaderText = "QType";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "QuantityType";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn10.HeaderText = "QType";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "CategoryType";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn14.HeaderText = "QType";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "QuantityType";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn15.HeaderText = "QType";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "QuantityType";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn19.HeaderText = "DL Price";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.ToolTipText = "Delivery Price";
            dataGridViewTextBoxColumn19.Width = 75;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "ButtonWidth";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn20.HeaderText = "Width";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Visible = false;
            dataGridViewTextBoxColumn20.Width = 50;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "ButtonHeight";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn21.HeaderText = "Height";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Visible = false;
            dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "DirectSaleTaxPercent";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn22.HeaderText = "DS Tax%";
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            dataGridViewTextBoxColumn22.ToolTipText = "Direct Sale Tax";
            dataGridViewTextBoxColumn22.Width = 80;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.DataPropertyName = "InHouseTaxPercent";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn23.HeaderText = "IH Tax%";
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.ReadOnly = true;
            dataGridViewTextBoxColumn23.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn23.Width = 80;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.DataPropertyName = "TakeAwayTaxPercent";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn24.HeaderText = "TA Tax%";
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            dataGridViewTextBoxColumn24.ReadOnly = true;
            dataGridViewTextBoxColumn24.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn24.Width = 80;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.DataPropertyName = "DeliveryTaxPercent";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn25.HeaderText = "DL Tax%";
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            dataGridViewTextBoxColumn25.ReadOnly = true;
            dataGridViewTextBoxColumn25.ToolTipText = "Delivery Tax";
            dataGridViewTextBoxColumn25.Width = 80;
            // 
            // dataGridViewTextBoxColumn26
            // 
            dataGridViewTextBoxColumn26.DataPropertyName = "DisplayOrder";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewTextBoxColumn26.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn26.HeaderText = "DO";
            dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            dataGridViewTextBoxColumn26.ReadOnly = true;
            dataGridViewTextBoxColumn26.ToolTipText = "Display Order";
            dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            dataGridViewTextBoxColumn27.DataPropertyName = "FFamily";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewTextBoxColumn27.HeaderText = "Font";
            dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            dataGridViewTextBoxColumn27.ReadOnly = true;
            dataGridViewTextBoxColumn27.ToolTipText = "InHouse Tax";
            dataGridViewTextBoxColumn27.Width = 75;
            // 
            // dataGridViewTextBoxColumn28
            // 
            dataGridViewTextBoxColumn28.DataPropertyName = "FSize";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewTextBoxColumn28.HeaderText = "FSize";
            dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            dataGridViewTextBoxColumn28.ReadOnly = true;
            dataGridViewTextBoxColumn28.ToolTipText = "TakeAway Tax";
            dataGridViewTextBoxColumn28.Width = 75;
            // 
            // dataGridViewTextBoxColumn29
            // 
            dataGridViewTextBoxColumn29.DataPropertyName = "FStyle";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle27;
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
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn47.DefaultCellStyle = dataGridViewCellStyle28;
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
            // mainContainer
            // 
            mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainContainer.Location = new System.Drawing.Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.Controls.Add(dgvMenu);
            mainContainer.Panel1.Controls.Add(barMenu);
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.Controls.Add(dgvCategory);
            mainContainer.Panel2.Controls.Add(barEntity);
            mainContainer.Size = new System.Drawing.Size(1575, 963);
            mainContainer.SplitterDistance = 267;
            mainContainer.SplitterWidth = 20;
            mainContainer.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "CategoryName";
            Column1.HeaderText = "Category Name";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // CategoryType
            // 
            CategoryType.DataPropertyName = "CategoryType";
            CategoryType.HeaderText = "Category Type";
            CategoryType.Name = "CategoryType";
            CategoryType.Width = 150;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            widthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            widthDataGridViewTextBoxColumn.HeaderText = "Width";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.Width = 70;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            heightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.Width = 70;
            // 
            // DistributionName
            // 
            DistributionName.DataPropertyName = "DistributionName";
            DistributionName.HeaderText = "Distribution";
            DistributionName.Name = "DistributionName";
            DistributionName.ReadOnly = true;
            DistributionName.Width = 200;
            // 
            // Font
            // 
            Font.DataPropertyName = "Font";
            Font.HeaderText = "Font";
            Font.Name = "Font";
            Font.ReadOnly = true;
            Font.Width = 200;
            // 
            // dOrderDataGridViewTextBoxColumn
            // 
            dOrderDataGridViewTextBoxColumn.DataPropertyName = "DOrder";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dOrderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            dOrderDataGridViewTextBoxColumn.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn.Name = "dOrderDataGridViewTextBoxColumn";
            dOrderDataGridViewTextBoxColumn.Width = 70;
            // 
            // ButtonDisplayStyle
            // 
            ButtonDisplayStyle.DataPropertyName = "ButtonDisplayStyle";
            ButtonDisplayStyle.HeaderText = "ButtonDisplayStyle";
            ButtonDisplayStyle.Name = "ButtonDisplayStyle";
            ButtonDisplayStyle.Width = 120;
            // 
            // TextAlign
            // 
            TextAlign.DataPropertyName = "TextAlign";
            TextAlign.HeaderText = "TextAlign";
            TextAlign.Name = "TextAlign";
            // 
            // TextImageRelation
            // 
            TextImageRelation.DataPropertyName = "TextImageRelation";
            TextImageRelation.HeaderText = "TextImageRelation";
            TextImageRelation.Name = "TextImageRelation";
            TextImageRelation.Width = 120;
            // 
            // ImageAlign
            // 
            ImageAlign.DataPropertyName = "ImageAlign";
            ImageAlign.HeaderText = "ImageAlign";
            ImageAlign.Name = "ImageAlign";
            // 
            // FrmMenuEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1575, 963);
            Controls.Add(mainContainer);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmMenuEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DTRM SIMPLE MENU EDITOR";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMenuEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)_menuSourceDesign).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)_categorySourceDesign).EndInit();
            barEntity.ResumeLayout(false);
            barEntity.PerformLayout();
            barMenu.ResumeLayout(false);
            barMenu.PerformLayout();
            mainContainer.Panel1.ResumeLayout(false);
            mainContainer.Panel1.PerformLayout();
            mainContainer.Panel2.ResumeLayout(false);
            mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
            mainContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;        
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.ToolStrip barMenu;
        private System.Windows.Forms.ToolStripButton btnAddMenu;
        private System.Windows.Forms.ToolStripButton btnEditMenu;
        private System.Windows.Forms.ToolStripButton btnDeleteMenu;
        private System.Windows.Forms.ToolStripButton btnBackupMenu;
        private System.Windows.Forms.ToolStripButton btnPrintMenu;
        private System.Windows.Forms.ToolStripButton btnExportStockManager;
        private System.Windows.Forms.ToolStripButton btnImportStockManager;
        private System.Windows.Forms.ToolStripButton btnSaveDBImagesToFolder;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.ToolStrip barEntity;
        private System.Windows.Forms.ToolStripButton btnAddEntity;
        private System.Windows.Forms.ToolStripButton btnEditEntity;
        private System.Windows.Forms.ToolStripButton btnDeleteEntity;
        private System.Windows.Forms.Panel pnlLeft;
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
        private System.Windows.Forms.ToolStripButton mnuSetAsDefaultMenu;
        private System.Windows.Forms.ToolStripButton btnLoadMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnExportMenuAsJson;
        private System.Windows.Forms.ToolStripButton btnImportMenuFromJSON;
        private System.Windows.Forms.BindingSource _menuSourceDesign;
        private System.Windows.Forms.BindingSource _categorySourceDesign;
        private System.Windows.Forms.ToolStripButton tsSortMenu;
        private System.Windows.Forms.ToolStripButton tsMoveUpMenu;
        private System.Windows.Forms.ToolStripButton tsMoveDownMenu;
        private System.Windows.Forms.ToolStripButton tsSortCategory;
        private System.Windows.Forms.ToolStripButton tsMoveUpCategory;
        private System.Windows.Forms.ToolStripButton tsMoveDownCategory;
        private System.Windows.Forms.ToolStripButton btnReloadMenu;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ToolStripButton btnCategoryItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActiveMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOrder;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnCategorySample;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistributionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Font;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ButtonDisplayStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextAlign;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextImageRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageAlign;
    }
}

