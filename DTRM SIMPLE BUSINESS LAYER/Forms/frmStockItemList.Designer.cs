using POSLayer.Models;
using POSLayer.Views;

namespace DTRMNS {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockItemList));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.popGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popQuantityType = new System.Windows.Forms.ToolStripMenuItem();
            this.popOrderType = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.stockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIncludeSupplierInPrint = new System.Windows.Forms.CheckBox();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvUsage = new System.Windows.Forms.DataGridView();
            this.colEntityButtonIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntityButtonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityTypeLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityButtonStockItemRecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vScrolldgv = new System.Windows.Forms.VScrollBar();
            this.vScrolldgvUsage = new System.Windows.Forms.VScrollBar();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.cmdReload = new System.Windows.Forms.ToolStripButton();
            this.cmdPrint = new System.Windows.Forms.ToolStripButton();
            this.cmdExportAsCsv = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.cmdSearch = new System.Windows.Forms.ToolStripButton();
            this.btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            this.colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqtylabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colordlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.popGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonStockItemRecipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.barMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIID,
            this.StockName,
            this.colqty,
            this.colqtylabel,
            this.colord,
            this.colordlabel,
            this.colConversion,
            this.SupplierName});
            this.dgv.ContextMenuStrip = this.popGrid;
            this.dgv.DataSource = this.stockItemBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.Height = 50;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(865, 320);
            this.dgv.TabIndex = 5;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.Sorted += new System.EventHandler(this.dgv_Sorted);
            // 
            // popGrid
            // 
            this.popGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popQuantityType,
            this.popOrderType,
            this.conversionToolStripMenuItem,
            this.popSupplier});
            this.popGrid.Name = "contextMenuStrip1";
            this.popGrid.Size = new System.Drawing.Size(184, 92);
            // 
            // popQuantityType
            // 
            this.popQuantityType.Name = "popQuantityType";
            this.popQuantityType.Size = new System.Drawing.Size(183, 22);
            this.popQuantityType.Tag = "0";
            this.popQuantityType.Text = "Quantity Type";
            // 
            // popOrderType
            // 
            this.popOrderType.Name = "popOrderType";
            this.popOrderType.Size = new System.Drawing.Size(183, 22);
            this.popOrderType.Text = "Order Type";
            // 
            // conversionToolStripMenuItem
            // 
            this.conversionToolStripMenuItem.Name = "conversionToolStripMenuItem";
            this.conversionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.conversionToolStripMenuItem.Text = "Set Conversion Ratio";
            this.conversionToolStripMenuItem.Click += new System.EventHandler(this.conversionToolStripMenuItem_Click);
            // 
            // popSupplier
            // 
            this.popSupplier.Name = "popSupplier";
            this.popSupplier.Size = new System.Drawing.Size(183, 22);
            this.popSupplier.Text = "Set Supplier";
            // 
            // stockItemBindingSource
            // 
            this.stockItemBindingSource.DataSource = typeof(StockItem);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Supplier);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DataSource = this.supplierBindingSource;
            this.cmbSuppliers.DisplayMember = "SupplierName";
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(265, 15);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(207, 33);
            this.cmbSuppliers.TabIndex = 0;
            this.cmbSuppliers.ValueMember = "IID";
            this.cmbSuppliers.Visible = false;
            this.cmbSuppliers.SelectionChangeCommitted += new System.EventHandler(this.cmbSuppliers_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIncludeSupplierInPrint);
            this.groupBox1.Controls.Add(this.rbSingle);
            this.groupBox1.Controls.Add(this.cmbSuppliers);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkIncludeSupplierInPrint
            // 
            this.chkIncludeSupplierInPrint.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIncludeSupplierInPrint.Location = new System.Drawing.Point(488, 15);
            this.chkIncludeSupplierInPrint.Name = "chkIncludeSupplierInPrint";
            this.chkIncludeSupplierInPrint.Size = new System.Drawing.Size(133, 33);
            this.chkIncludeSupplierInPrint.TabIndex = 2;
            this.chkIncludeSupplierInPrint.Text = "INC. SUPP. TO PRINT";
            this.chkIncludeSupplierInPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIncludeSupplierInPrint.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSingle.Location = new System.Drawing.Point(142, 15);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(108, 33);
            this.rbSingle.TabIndex = 1;
            this.rbSingle.Text = "ONE SUPPLIER";
            this.rbSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(16, 15);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(108, 33);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "ALL SUPPLIERS";
            this.rbAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 590);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(925, 70);
            this.panel1.TabIndex = 46;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.Location = new System.Drawing.Point(540, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 50);
            this.btnSelect.TabIndex = 44;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(665, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "CANCEL";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.Location = new System.Drawing.Point(790, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvUsage
            // 
            this.dgvUsage.AllowUserToAddRows = false;
            this.dgvUsage.AllowUserToDeleteRows = false;
            this.dgvUsage.AutoGenerateColumns = false;
            this.dgvUsage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEntityButtonIID,
            this.colStockItemIID,
            this.colEntityButtonName,
            this.colQuantity,
            this.colQuantityType,
            this.colQuantityTypeLabel});
            this.dgvUsage.ContextMenuStrip = this.popGrid;
            this.dgvUsage.DataSource = this.entityButtonStockItemRecipeBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsage.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsage.Location = new System.Drawing.Point(0, 0);
            this.dgvUsage.MultiSelect = false;
            this.dgvUsage.Name = "dgvUsage";
            this.dgvUsage.ReadOnly = true;
            this.dgvUsage.RowHeadersWidth = 25;
            this.dgvUsage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsage.RowTemplate.Height = 40;
            this.dgvUsage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsage.Size = new System.Drawing.Size(865, 120);
            this.dgvUsage.TabIndex = 47;
            this.dgvUsage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsage_CellDoubleClick);
            this.dgvUsage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvUsage_Scroll);
            this.dgvUsage.Sorted += new System.EventHandler(this.dgvUsage_Sorted);
            // 
            // colEntityButtonIID
            // 
            this.colEntityButtonIID.DataPropertyName = "EntityButtonIID";
            this.colEntityButtonIID.HeaderText = "EntityButtonIID";
            this.colEntityButtonIID.Name = "colEntityButtonIID";
            this.colEntityButtonIID.ReadOnly = true;
            this.colEntityButtonIID.Visible = false;
            // 
            // colStockItemIID
            // 
            this.colStockItemIID.DataPropertyName = "StockItemIID";
            this.colStockItemIID.HeaderText = "StockItemIID";
            this.colStockItemIID.Name = "colStockItemIID";
            this.colStockItemIID.ReadOnly = true;
            this.colStockItemIID.Visible = false;
            // 
            // colEntityButtonName
            // 
            this.colEntityButtonName.DataPropertyName = "EntityButtonName";
            this.colEntityButtonName.HeaderText = "Category Item";
            this.colEntityButtonName.Name = "colEntityButtonName";
            this.colEntityButtonName.ReadOnly = true;
            this.colEntityButtonName.Width = 350;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colQuantityType
            // 
            this.colQuantityType.DataPropertyName = "QuantityType";
            this.colQuantityType.HeaderText = "QuantityType";
            this.colQuantityType.Name = "colQuantityType";
            this.colQuantityType.ReadOnly = true;
            this.colQuantityType.Visible = false;
            // 
            // colQuantityTypeLabel
            // 
            this.colQuantityTypeLabel.HeaderText = "Type";
            this.colQuantityTypeLabel.Name = "colQuantityTypeLabel";
            this.colQuantityTypeLabel.ReadOnly = true;
            // 
            // entityButtonStockItemRecipeBindingSource
            // 
            this.entityButtonStockItemRecipeBindingSource.DataSource = typeof(EntityButtonStockItemRecipe);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 110);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            this.splitContainer1.Panel1.Controls.Add(this.vScrolldgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvUsage);
            this.splitContainer1.Panel2.Controls.Add(this.vScrolldgvUsage);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(925, 480);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.SplitterWidth = 40;
            this.splitContainer1.TabIndex = 48;
            // 
            // vScrolldgv
            // 
            this.vScrolldgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrolldgv.Location = new System.Drawing.Point(865, 0);
            this.vScrolldgv.Name = "vScrolldgv";
            this.vScrolldgv.Size = new System.Drawing.Size(60, 320);
            this.vScrolldgv.TabIndex = 6;
            this.vScrolldgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrolldgv_Scroll);
            // 
            // vScrolldgvUsage
            // 
            this.vScrolldgvUsage.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrolldgvUsage.Location = new System.Drawing.Point(865, 0);
            this.vScrolldgvUsage.Name = "vScrolldgvUsage";
            this.vScrolldgvUsage.Size = new System.Drawing.Size(60, 120);
            this.vScrolldgvUsage.TabIndex = 48;
            this.vScrolldgvUsage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrolldgvUsage_Scroll);
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDelete,
            this.cmdReload,
            this.cmdPrint,
            this.cmdExportAsCsv,
            this.txtSearch,
            this.cmdSearch,
            this.btnExportAsJson,
            this.btnImportFromJson});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(925, 54);
            this.barMain.TabIndex = 49;
            this.barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::DTRMNS.Properties.Resources.arti32;
            this.cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(60, 51);
            this.cmdAdd.Text = "Add New";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::DTRMNS.Properties.Resources.MatReport_32;
            this.cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(49, 51);
            this.cmdEdit.Text = "   Edit   ";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Image = global::DTRMNS.Properties.Resources.eksi32;
            this.cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(65, 51);
            this.cmdDelete.Text = "    Delete   ";
            this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Image = global::DTRMNS.Properties.Resources.Reload_32;
            this.cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(71, 51);
            this.cmdReload.Text = "    Reload    ";
            this.cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdReload.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = global::DTRMNS.Properties.Resources.Print32;
            this.cmdPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(57, 51);
            this.cmdPrint.Text = "    Print   ";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmdExportAsCsv
            // 
            this.cmdExportAsCsv.Image = global::DTRMNS.Properties.Resources.Export32;
            this.cmdExportAsCsv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdExportAsCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExportAsCsv.Name = "cmdExportAsCsv";
            this.cmdExportAsCsv.Size = new System.Drawing.Size(82, 51);
            this.cmdExportAsCsv.Text = "Export As Csv";
            this.cmdExportAsCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdExportAsCsv.Click += new System.EventHandler(this.btnExportAsCsv_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 54);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Image = global::DTRMNS.Properties.Resources.View32;
            this.cmdSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(61, 51);
            this.cmdSearch.Text = "  Search   ";
            this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExportAsJson
            // 
            this.btnExportAsJson.Image = global::DTRMNS.Properties.Resources.SquareArrowRightExpander32;
            this.btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportAsJson.Name = "btnExportAsJson";
            this.btnExportAsJson.Size = new System.Drawing.Size(75, 51);
            this.btnExportAsJson.Text = "JSON Export";
            this.btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportAsJson.Click += new System.EventHandler(this.btnExportAsJson_Click);
            // 
            // btnImportFromJson
            // 
            this.btnImportFromJson.Image = global::DTRMNS.Properties.Resources.SquareArrowLeftNarrower32;
            this.btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromJson.Name = "btnImportFromJson";
            this.btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            this.btnImportFromJson.Text = "JSON Import";
            this.btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportFromJson.Click += new System.EventHandler(this.btnImportFromJson_Click);
            // 
            // colIID
            // 
            this.colIID.DataPropertyName = "IID";
            this.colIID.HeaderText = "IID";
            this.colIID.Name = "colIID";
            this.colIID.ReadOnly = true;
            this.colIID.Visible = false;
            // 
            // StockName
            // 
            this.StockName.DataPropertyName = "StockName";
            this.StockName.HeaderText = "StockName";
            this.StockName.Name = "StockName";
            this.StockName.ReadOnly = true;
            this.StockName.Width = 250;
            // 
            // colqty
            // 
            this.colqty.DataPropertyName = "UsedQuantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colqty.DefaultCellStyle = dataGridViewCellStyle1;
            this.colqty.HeaderText = "Used Qty";
            this.colqty.Name = "colqty";
            this.colqty.ReadOnly = true;
            this.colqty.Width = 50;
            // 
            // colqtylabel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colqtylabel.DefaultCellStyle = dataGridViewCellStyle2;
            this.colqtylabel.HeaderText = "Quantity Type";
            this.colqtylabel.Name = "colqtylabel";
            this.colqtylabel.ReadOnly = true;
            this.colqtylabel.Width = 90;
            // 
            // colord
            // 
            this.colord.DataPropertyName = "OrderType";
            this.colord.HeaderText = "OrderType";
            this.colord.Name = "colord";
            this.colord.ReadOnly = true;
            this.colord.Visible = false;
            // 
            // colordlabel
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colordlabel.DefaultCellStyle = dataGridViewCellStyle3;
            this.colordlabel.HeaderText = "Order Type";
            this.colordlabel.Name = "colordlabel";
            this.colordlabel.ReadOnly = true;
            this.colordlabel.Width = 90;
            // 
            // colConversion
            // 
            this.colConversion.DataPropertyName = "Conversion";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colConversion.DefaultCellStyle = dataGridViewCellStyle4;
            this.colConversion.HeaderText = "Conversion";
            this.colConversion.Name = "colConversion";
            this.colConversion.ReadOnly = true;
            this.colConversion.Width = 65;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SupplierName.DefaultCellStyle = dataGridViewCellStyle5;
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 80;
            // 
            // frmStockItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 660);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmStockItemList";
            this.Text = "STOCK ITEMS";
            this.Load += new System.EventHandler(this.frmStockItemList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockItemList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.popGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonStockItemRecipeBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.BindingSource stockItemBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityTypeLabel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqtylabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colordlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
    }
}