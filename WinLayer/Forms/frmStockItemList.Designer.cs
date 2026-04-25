using POSLayer.Models;

namespace WinLayer {
    partial class frmStockItemList {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockItemList));
            dgv = new System.Windows.Forms.DataGridView();
            stockNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            conversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            popGrid = new System.Windows.Forms.ContextMenuStrip(components);
            popQuantityType = new System.Windows.Forms.ToolStripMenuItem();
            popOrderType = new System.Windows.Forms.ToolStripMenuItem();
            conversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            popSupplier = new System.Windows.Forms.ToolStripMenuItem();
            stockItemBindingSource = new System.Windows.Forms.BindingSource(components);
            supplierBindingSource = new System.Windows.Forms.BindingSource(components);
            cmbSuppliers = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            chkIncludeSupplierInPrint = new System.Windows.Forms.CheckBox();
            rbSingle = new System.Windows.Forms.RadioButton();
            rbAll = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            btnSelect = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            dgvUsage = new System.Windows.Forms.DataGridView();
            entityButtonStockItemRecipeBindingSource = new System.Windows.Forms.BindingSource(components);
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            pBox = new System.Windows.Forms.PictureBox();
            vScrolldgv = new System.Windows.Forms.VScrollBar();
            vScrolldgvUsage = new System.Windows.Forms.VScrollBar();
            barMain = new System.Windows.Forms.ToolStrip();
            cmdAdd = new System.Windows.Forms.ToolStripButton();
            cmdEdit = new System.Windows.Forms.ToolStripButton();
            cmdDelete = new System.Windows.Forms.ToolStripButton();
            cmdReload = new System.Windows.Forms.ToolStripButton();
            cmdPrint = new System.Windows.Forms.ToolStripButton();
            cmdExportAsCsv = new System.Windows.Forms.ToolStripButton();
            txtSearch = new System.Windows.Forms.ToolStripTextBox();
            cmdSearch = new System.Windows.Forms.ToolStripButton();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            tsSort = new System.Windows.Forms.ToolStripButton();
            tsMoveUp = new System.Windows.Forms.ToolStripButton();
            tsMoveDown = new System.Windows.Forms.ToolStripButton();
            btnSample = new System.Windows.Forms.ToolStripButton();
            stockItemUsageBindingSource = new System.Windows.Forms.BindingSource(components);
            stockItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sessionQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            xSessionQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            previousQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderableFloatQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dOrderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            popGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonStockItemRecipeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            barMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockItemUsageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stockNameDataGridViewTextBoxColumn, quantityTypeDataGridViewTextBoxColumn, orderTypeDataGridViewTextBoxColumn, conversionDataGridViewTextBoxColumn, usedQuantityDataGridViewTextBoxColumn, supplierNameDataGridViewTextBoxColumn, dOrderDataGridViewTextBoxColumn });
            dgv.ContextMenuStrip = popGrid;
            dgv.DataSource = stockItemBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgv.Location = new System.Drawing.Point(0, 0);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgv.RowTemplate.Height = 50;
            dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(994, 374);
            dgv.TabIndex = 5;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            dgv.Scroll += dgv_Scroll;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // stockNameDataGridViewTextBoxColumn
            // 
            stockNameDataGridViewTextBoxColumn.DataPropertyName = "StockName";
            stockNameDataGridViewTextBoxColumn.HeaderText = "StockName";
            stockNameDataGridViewTextBoxColumn.Name = "stockNameDataGridViewTextBoxColumn";
            stockNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityTypeDataGridViewTextBoxColumn
            // 
            quantityTypeDataGridViewTextBoxColumn.DataPropertyName = "QuantityType";
            quantityTypeDataGridViewTextBoxColumn.HeaderText = "QuantityType";
            quantityTypeDataGridViewTextBoxColumn.Name = "quantityTypeDataGridViewTextBoxColumn";
            quantityTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType";
            orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            orderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conversionDataGridViewTextBoxColumn
            // 
            conversionDataGridViewTextBoxColumn.DataPropertyName = "Conversion";
            conversionDataGridViewTextBoxColumn.HeaderText = "Conversion";
            conversionDataGridViewTextBoxColumn.Name = "conversionDataGridViewTextBoxColumn";
            conversionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usedQuantityDataGridViewTextBoxColumn
            // 
            usedQuantityDataGridViewTextBoxColumn.DataPropertyName = "UsedQuantity";
            usedQuantityDataGridViewTextBoxColumn.HeaderText = "UsedQuantity";
            usedQuantityDataGridViewTextBoxColumn.Name = "usedQuantityDataGridViewTextBoxColumn";
            usedQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOrderDataGridViewTextBoxColumn
            // 
            dOrderDataGridViewTextBoxColumn.DataPropertyName = "DOrder";
            dOrderDataGridViewTextBoxColumn.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn.Name = "dOrderDataGridViewTextBoxColumn";
            dOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // popGrid
            // 
            popGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { popQuantityType, popOrderType, conversionToolStripMenuItem, popSupplier });
            popGrid.Name = "contextMenuStrip1";
            popGrid.Size = new System.Drawing.Size(184, 92);
            // 
            // popQuantityType
            // 
            popQuantityType.Name = "popQuantityType";
            popQuantityType.Size = new System.Drawing.Size(183, 22);
            popQuantityType.Tag = "0";
            popQuantityType.Text = "Quantity Type";
            // 
            // popOrderType
            // 
            popOrderType.Name = "popOrderType";
            popOrderType.Size = new System.Drawing.Size(183, 22);
            popOrderType.Text = "Order Type";
            // 
            // conversionToolStripMenuItem
            // 
            conversionToolStripMenuItem.Name = "conversionToolStripMenuItem";
            conversionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            conversionToolStripMenuItem.Text = "Set Conversion Ratio";
            conversionToolStripMenuItem.Click += conversionToolStripMenuItem_Click;
            // 
            // popSupplier
            // 
            popSupplier.Name = "popSupplier";
            popSupplier.Size = new System.Drawing.Size(183, 22);
            popSupplier.Text = "Set Supplier";
            // 
            // stockItemBindingSource
            // 
            stockItemBindingSource.DataSource = typeof(StockItem);
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Supplier);
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.DataSource = supplierBindingSource;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new System.Drawing.Point(309, 17);
            cmbSuppliers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new System.Drawing.Size(241, 33);
            cmbSuppliers.TabIndex = 0;
            cmbSuppliers.ValueMember = "IID";
            cmbSuppliers.Visible = false;
            cmbSuppliers.SelectionChangeCommitted += cmbSuppliers_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIncludeSupplierInPrint);
            groupBox1.Controls.Add(rbSingle);
            groupBox1.Controls.Add(cmbSuppliers);
            groupBox1.Controls.Add(rbAll);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 54);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(1154, 65);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // chkIncludeSupplierInPrint
            // 
            chkIncludeSupplierInPrint.Appearance = System.Windows.Forms.Appearance.Button;
            chkIncludeSupplierInPrint.Location = new System.Drawing.Point(569, 17);
            chkIncludeSupplierInPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkIncludeSupplierInPrint.Name = "chkIncludeSupplierInPrint";
            chkIncludeSupplierInPrint.Size = new System.Drawing.Size(155, 38);
            chkIncludeSupplierInPrint.TabIndex = 2;
            chkIncludeSupplierInPrint.Text = "INC. SUPP. TO PRINT";
            chkIncludeSupplierInPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkIncludeSupplierInPrint.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            rbSingle.Appearance = System.Windows.Forms.Appearance.Button;
            rbSingle.Location = new System.Drawing.Point(166, 17);
            rbSingle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbSingle.Name = "rbSingle";
            rbSingle.Size = new System.Drawing.Size(126, 38);
            rbSingle.TabIndex = 1;
            rbSingle.Text = "ONE SUPPLIER";
            rbSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            rbAll.Appearance = System.Windows.Forms.Appearance.Button;
            rbAll.Checked = true;
            rbAll.Location = new System.Drawing.Point(19, 17);
            rbAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbAll.Name = "rbAll";
            rbAll.Size = new System.Drawing.Size(126, 38);
            rbAll.TabIndex = 0;
            rbAll.TabStop = true;
            rbAll.Text = "ALL SUPPLIERS";
            rbAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 681);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12);
            panel1.Size = new System.Drawing.Size(1154, 81);
            panel1.TabIndex = 46;
            // 
            // btnSelect
            // 
            btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSelect.Location = new System.Drawing.Point(704, 12);
            btnSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(146, 57);
            btnSelect.TabIndex = 44;
            btnSelect.Text = "SELECT";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Location = new System.Drawing.Point(850, 12);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(146, 57);
            btnClose.TabIndex = 42;
            btnClose.Text = "CANCEL";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Location = new System.Drawing.Point(996, 12);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(146, 57);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            // 
            // dgvUsage
            // 
            dgvUsage.AllowUserToAddRows = false;
            dgvUsage.AllowUserToDeleteRows = false;
            dgvUsage.AutoGenerateColumns = false;
            dgvUsage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stockItemNameDataGridViewTextBoxColumn, categoryItemNameDataGridViewTextBoxColumn, sessionQuantityDataGridViewTextBoxColumn, xSessionQuantityDataGridViewTextBoxColumn, previousQuantityDataGridViewTextBoxColumn, totalQuantityDataGridViewTextBoxColumn, orderableQuantityDataGridViewTextBoxColumn, orderableFloatQuantityDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, dOrderDataGridViewTextBoxColumn1 });
            dgvUsage.ContextMenuStrip = popGrid;
            dgvUsage.DataSource = stockItemUsageBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvUsage.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsage.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvUsage.Location = new System.Drawing.Point(0, 0);
            dgvUsage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvUsage.MultiSelect = false;
            dgvUsage.Name = "dgvUsage";
            dgvUsage.ReadOnly = true;
            dgvUsage.RowHeadersWidth = 25;
            dgvUsage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvUsage.RowTemplate.Height = 40;
            dgvUsage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dgvUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsage.Size = new System.Drawing.Size(1094, 142);
            dgvUsage.TabIndex = 47;
            dgvUsage.CellDoubleClick += dgvUsage_CellDoubleClick;
            dgvUsage.Scroll += dgvUsage_Scroll;
            // 
            // entityButtonStockItemRecipeBindingSource
            // 
            entityButtonStockItemRecipeBindingSource.DataSource = typeof(RecipeItem);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 119);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgv);
            splitContainer1.Panel1.Controls.Add(pBox);
            splitContainer1.Panel1.Controls.Add(vScrolldgv);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvUsage);
            splitContainer1.Panel2.Controls.Add(vScrolldgvUsage);
            splitContainer1.Panel2MinSize = 100;
            splitContainer1.Size = new System.Drawing.Size(1154, 562);
            splitContainer1.SplitterDistance = 374;
            splitContainer1.SplitterWidth = 46;
            splitContainer1.TabIndex = 48;
            // 
            // pBox
            // 
            pBox.BackColor = System.Drawing.SystemColors.Window;
            pBox.Dock = System.Windows.Forms.DockStyle.Right;
            pBox.Location = new System.Drawing.Point(994, 0);
            pBox.Name = "pBox";
            pBox.Size = new System.Drawing.Size(100, 374);
            pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pBox.TabIndex = 0;
            pBox.TabStop = false;
            pBox.Visible = false;
            // 
            // vScrolldgv
            // 
            vScrolldgv.Dock = System.Windows.Forms.DockStyle.Right;
            vScrolldgv.Location = new System.Drawing.Point(1094, 0);
            vScrolldgv.Name = "vScrolldgv";
            vScrolldgv.Size = new System.Drawing.Size(60, 374);
            vScrolldgv.TabIndex = 6;
            vScrolldgv.Scroll += vScrolldgv_Scroll;
            // 
            // vScrolldgvUsage
            // 
            vScrolldgvUsage.Dock = System.Windows.Forms.DockStyle.Right;
            vScrolldgvUsage.Location = new System.Drawing.Point(1094, 0);
            vScrolldgvUsage.Name = "vScrolldgvUsage";
            vScrolldgvUsage.Size = new System.Drawing.Size(60, 142);
            vScrolldgvUsage.TabIndex = 48;
            vScrolldgvUsage.Scroll += vScrolldgvUsage_Scroll;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cmdAdd, cmdEdit, cmdDelete, cmdReload, cmdPrint, cmdExportAsCsv, txtSearch, cmdSearch, btnExportAsJson, btnImportFromJson, tsSort, tsMoveUp, tsMoveDown, btnSample });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(1154, 54);
            barMain.TabIndex = 49;
            barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            cmdAdd.Image = Properties.Resources.arti32;
            cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new System.Drawing.Size(60, 51);
            cmdAdd.Text = "Add New";
            cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdAdd.Click += btnAdd_Click;
            // 
            // cmdEdit
            // 
            cmdEdit.Image = Properties.Resources.MatReport_32;
            cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdEdit.Name = "cmdEdit";
            cmdEdit.Size = new System.Drawing.Size(49, 51);
            cmdEdit.Text = "   Edit   ";
            cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdEdit.Click += btnEdit_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Image = Properties.Resources.eksi32;
            cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new System.Drawing.Size(65, 51);
            cmdDelete.Text = "    Delete   ";
            cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdDelete.Click += btnDelete_Click;
            // 
            // cmdReload
            // 
            cmdReload.Image = Properties.Resources.Reload_32;
            cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdReload.Name = "cmdReload";
            cmdReload.Size = new System.Drawing.Size(71, 51);
            cmdReload.Text = "    Reload    ";
            cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdReload.Click += btnRefresh_Click;
            // 
            // cmdPrint
            // 
            cmdPrint.Image = Properties.Resources.Print32;
            cmdPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdPrint.Name = "cmdPrint";
            cmdPrint.Size = new System.Drawing.Size(57, 51);
            cmdPrint.Text = "    Print   ";
            cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdPrint.Click += btnPrint_Click;
            // 
            // cmdExportAsCsv
            // 
            cmdExportAsCsv.Image = Properties.Resources.Export32;
            cmdExportAsCsv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdExportAsCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdExportAsCsv.Name = "cmdExportAsCsv";
            cmdExportAsCsv.Size = new System.Drawing.Size(82, 51);
            cmdExportAsCsv.Text = "Export As Csv";
            cmdExportAsCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdExportAsCsv.Click += btnExportAsCsv_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(233, 54);
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // cmdSearch
            // 
            cmdSearch.Image = Properties.Resources.View32;
            cmdSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdSearch.Name = "cmdSearch";
            cmdSearch.Size = new System.Drawing.Size(61, 51);
            cmdSearch.Text = "  Search   ";
            cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdSearch.Click += btnSearch_Click;
            // 
            // btnExportAsJson
            // 
            btnExportAsJson.Image = Properties.Resources.SquareArrowRightExpander32;
            btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportAsJson.Name = "btnExportAsJson";
            btnExportAsJson.Size = new System.Drawing.Size(75, 51);
            btnExportAsJson.Text = "JSON Export";
            btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportAsJson.Click += btnExportAsJson_Click;
            // 
            // btnImportFromJson
            // 
            btnImportFromJson.Image = Properties.Resources.SquareArrowLeftNarrower32;
            btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportFromJson.Name = "btnImportFromJson";
            btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            btnImportFromJson.Text = "JSON Import";
            btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportFromJson.Click += btnImportFromJson_Click;
            // 
            // tsSort
            // 
            tsSort.AutoSize = false;
            tsSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSort.Image = Properties.Resources.updown;
            tsSort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSort.Name = "tsSort";
            tsSort.Size = new System.Drawing.Size(60, 51);
            tsSort.Text = "toolStripButton1";
            tsSort.Click += tsSort_Click;
            // 
            // tsMoveUp
            // 
            tsMoveUp.AutoSize = false;
            tsMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveUp.Image = Properties.Resources.up2;
            tsMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveUp.Name = "tsMoveUp";
            tsMoveUp.Size = new System.Drawing.Size(60, 51);
            tsMoveUp.Text = "toolStripButton1";
            tsMoveUp.Click += tsMoveUp_Click;
            // 
            // tsMoveDown
            // 
            tsMoveDown.AutoSize = false;
            tsMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsMoveDown.Image = Properties.Resources.down2;
            tsMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMoveDown.Name = "tsMoveDown";
            tsMoveDown.Size = new System.Drawing.Size(60, 51);
            tsMoveDown.Text = "toolStripButton1";
            tsMoveDown.Click += tsMoveDown_Click;
            // 
            // btnSample
            // 
            btnSample.AutoSize = false;
            btnSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSample.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSample.Name = "btnSample";
            btnSample.Size = new System.Drawing.Size(60, 51);
            btnSample.Text = "Selected Stock Item Image";
            btnSample.Click += btnSample_Click;
            btnSample.Paint += btnSample_Paint;
            // 
            // stockItemUsageBindingSource
            // 
            stockItemUsageBindingSource.DataSource = typeof(StockItemUsage);
            // 
            // stockItemNameDataGridViewTextBoxColumn
            // 
            stockItemNameDataGridViewTextBoxColumn.DataPropertyName = "StockItemName";
            stockItemNameDataGridViewTextBoxColumn.HeaderText = "StockItemName";
            stockItemNameDataGridViewTextBoxColumn.Name = "stockItemNameDataGridViewTextBoxColumn";
            stockItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryItemNameDataGridViewTextBoxColumn
            // 
            categoryItemNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryItemName";
            categoryItemNameDataGridViewTextBoxColumn.HeaderText = "CategoryItemName";
            categoryItemNameDataGridViewTextBoxColumn.Name = "categoryItemNameDataGridViewTextBoxColumn";
            categoryItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionQuantityDataGridViewTextBoxColumn
            // 
            sessionQuantityDataGridViewTextBoxColumn.DataPropertyName = "SessionQuantity";
            sessionQuantityDataGridViewTextBoxColumn.HeaderText = "SessionQuantity";
            sessionQuantityDataGridViewTextBoxColumn.Name = "sessionQuantityDataGridViewTextBoxColumn";
            sessionQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xSessionQuantityDataGridViewTextBoxColumn
            // 
            xSessionQuantityDataGridViewTextBoxColumn.DataPropertyName = "XSessionQuantity";
            xSessionQuantityDataGridViewTextBoxColumn.HeaderText = "XSessionQuantity";
            xSessionQuantityDataGridViewTextBoxColumn.Name = "xSessionQuantityDataGridViewTextBoxColumn";
            xSessionQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previousQuantityDataGridViewTextBoxColumn
            // 
            previousQuantityDataGridViewTextBoxColumn.DataPropertyName = "PreviousQuantity";
            previousQuantityDataGridViewTextBoxColumn.HeaderText = "PreviousQuantity";
            previousQuantityDataGridViewTextBoxColumn.Name = "previousQuantityDataGridViewTextBoxColumn";
            previousQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQuantityDataGridViewTextBoxColumn
            // 
            totalQuantityDataGridViewTextBoxColumn.DataPropertyName = "TotalQuantity";
            totalQuantityDataGridViewTextBoxColumn.HeaderText = "TotalQuantity";
            totalQuantityDataGridViewTextBoxColumn.Name = "totalQuantityDataGridViewTextBoxColumn";
            totalQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderableQuantityDataGridViewTextBoxColumn
            // 
            orderableQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderableQuantity";
            orderableQuantityDataGridViewTextBoxColumn.HeaderText = "OrderableQuantity";
            orderableQuantityDataGridViewTextBoxColumn.Name = "orderableQuantityDataGridViewTextBoxColumn";
            orderableQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderableFloatQuantityDataGridViewTextBoxColumn
            // 
            orderableFloatQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderableFloatQuantity";
            orderableFloatQuantityDataGridViewTextBoxColumn.HeaderText = "OrderableFloatQuantity";
            orderableFloatQuantityDataGridViewTextBoxColumn.Name = "orderableFloatQuantityDataGridViewTextBoxColumn";
            orderableFloatQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOrderDataGridViewTextBoxColumn1
            // 
            dOrderDataGridViewTextBoxColumn1.DataPropertyName = "DOrder";
            dOrderDataGridViewTextBoxColumn1.HeaderText = "DOrder";
            dOrderDataGridViewTextBoxColumn1.Name = "dOrderDataGridViewTextBoxColumn1";
            dOrderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmStockItemList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1154, 762);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox1);
            Controls.Add(barMain);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmStockItemList";
            Text = "STOCK ITEMS";
            Load += frmStockItemList_Load;
            KeyDown += frmStockItemList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            popGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stockItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsage).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonStockItemRecipeBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockItemUsageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip popGrid;
        private System.Windows.Forms.ToolStripMenuItem popQuantityType;
        private System.Windows.Forms.ToolStripMenuItem popSupplier;
        private System.Windows.Forms.ToolStripMenuItem popOrderType;
        private System.Windows.Forms.ToolStripMenuItem conversionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.VScrollBar vScrolldgv;
        private System.Windows.Forms.VScrollBar vScrolldgvUsage;
        private System.Windows.Forms.CheckBox chkIncludeSupplierInPrint;
        private System.Windows.Forms.BindingSource entityButtonStockItemRecipeBindingSource;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripButton cmdReload;
        private System.Windows.Forms.ToolStripButton cmdPrint;
        private System.Windows.Forms.ToolStripButton cmdExportAsCsv;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton cmdSearch;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
        private System.Windows.Forms.ToolStripButton btnSample;
        private System.Windows.Forms.BindingSource stockItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.ToolStripButton tsMoveDown;
        private System.Windows.Forms.ToolStripButton tsMoveUp;
        private System.Windows.Forms.ToolStripButton tsSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSessionQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderableFloatQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOrderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource stockItemUsageBindingSource;
    }
}