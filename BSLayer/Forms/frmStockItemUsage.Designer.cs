using POSLayer.Models;

namespace BSLayer {
    partial class frmStockItemUsage {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockItemUsage));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colordlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XSessionQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqtylabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockItemUsageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnBoughtAll = new System.Windows.Forms.Button();
            this.chkViewDetails = new System.Windows.Forms.CheckBox();
            this.chkOrderableOnly = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScroll = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdReload = new System.Windows.Forms.ToolStripButton();
            this.cmdPrint = new System.Windows.Forms.ToolStripButton();
            this.cmdExportAsCsv = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.cmdSearch = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemUsageBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.colStockItemIID,
            this.colOrderableQuantity,
            this.colord,
            this.colordlabel,
            this.stockNameDataGridViewTextBoxColumn,
            this.SessionQuantity,
            this.XSessionQuantity,
            this.PreviousQuantity,
            this.TotalQuantity,
            this.colqty,
            this.colqtylabel,
            this.supplierIIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.stockItemUsageBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 101);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 25;
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(940, 496);
            this.dgv.TabIndex = 48;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            this.dgv.Sorted += new System.EventHandler(this.dgv_Sorted);
            // 
            // colStockItemIID
            // 
            this.colStockItemIID.DataPropertyName = "StockItemIID";
            this.colStockItemIID.HeaderText = "StockItemIID";
            this.colStockItemIID.Name = "colStockItemIID";
            this.colStockItemIID.ReadOnly = true;
            this.colStockItemIID.Visible = false;
            // 
            // colOrderableQuantity
            // 
            this.colOrderableQuantity.DataPropertyName = "OrderableQuantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOrderableQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderableQuantity.HeaderText = "Order Qty";
            this.colOrderableQuantity.Name = "colOrderableQuantity";
            this.colOrderableQuantity.ReadOnly = true;
            this.colOrderableQuantity.Width = 50;
            // 
            // colord
            // 
            this.colord.DataPropertyName = "OrderableType";
            this.colord.HeaderText = "Order Type";
            this.colord.Name = "colord";
            this.colord.ReadOnly = true;
            this.colord.Visible = false;
            // 
            // colordlabel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colordlabel.DefaultCellStyle = dataGridViewCellStyle2;
            this.colordlabel.HeaderText = "Order Types";
            this.colordlabel.Name = "colordlabel";
            this.colordlabel.ReadOnly = true;
            this.colordlabel.Width = 60;
            // 
            // stockNameDataGridViewTextBoxColumn
            // 
            this.stockNameDataGridViewTextBoxColumn.DataPropertyName = "StockName";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.stockNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockNameDataGridViewTextBoxColumn.HeaderText = "Stock Item";
            this.stockNameDataGridViewTextBoxColumn.Name = "stockNameDataGridViewTextBoxColumn";
            this.stockNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // SessionQuantity
            // 
            this.SessionQuantity.DataPropertyName = "SessionQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SessionQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.SessionQuantity.HeaderText = "Session Qty";
            this.SessionQuantity.Name = "SessionQuantity";
            this.SessionQuantity.ReadOnly = true;
            this.SessionQuantity.Visible = false;
            this.SessionQuantity.Width = 60;
            // 
            // XSessionQuantity
            // 
            this.XSessionQuantity.DataPropertyName = "XSessionQuantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.XSessionQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.XSessionQuantity.HeaderText = "XSession Qty";
            this.XSessionQuantity.Name = "XSessionQuantity";
            this.XSessionQuantity.ReadOnly = true;
            this.XSessionQuantity.Visible = false;
            this.XSessionQuantity.Width = 60;
            // 
            // PreviousQuantity
            // 
            this.PreviousQuantity.DataPropertyName = "PreviousQuantity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PreviousQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.PreviousQuantity.HeaderText = "Previous Qty";
            this.PreviousQuantity.Name = "PreviousQuantity";
            this.PreviousQuantity.ReadOnly = true;
            this.PreviousQuantity.Visible = false;
            this.PreviousQuantity.Width = 60;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalQuantity.HeaderText = "Total";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            this.TotalQuantity.Visible = false;
            this.TotalQuantity.Width = 60;
            // 
            // colqty
            // 
            this.colqty.DataPropertyName = "QuantityType";
            this.colqty.HeaderText = "Sale Type";
            this.colqty.Name = "colqty";
            this.colqty.ReadOnly = true;
            this.colqty.Visible = false;
            // 
            // colqtylabel
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colqtylabel.DefaultCellStyle = dataGridViewCellStyle8;
            this.colqtylabel.HeaderText = "Sale Types";
            this.colqtylabel.Name = "colqtylabel";
            this.colqtylabel.ReadOnly = true;
            this.colqtylabel.Visible = false;
            this.colqtylabel.Width = 60;
            // 
            // supplierIIDDataGridViewTextBoxColumn
            // 
            this.supplierIIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierIID";
            this.supplierIIDDataGridViewTextBoxColumn.HeaderText = "SupplierIID";
            this.supplierIIDDataGridViewTextBoxColumn.Name = "supplierIIDDataGridViewTextBoxColumn";
            this.supplierIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockItemUsageBindingSource
            // 
            this.stockItemUsageBindingSource.DataSource = typeof(StockItemUsage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSingle);
            this.groupBox1.Controls.Add(this.cmbSuppliers);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(3, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 101);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // rbSingle
            // 
            this.rbSingle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSingle.Location = new System.Drawing.Point(149, 15);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(108, 33);
            this.rbSingle.TabIndex = 1;
            this.rbSingle.Text = "ONE  SUPPLIER";
            this.rbSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DisplayMember = "SupplierName";
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(6, 54);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(247, 33);
            this.cmbSuppliers.TabIndex = 0;
            this.cmbSuppliers.ValueMember = "IID";
            this.cmbSuppliers.Visible = false;
            this.cmbSuppliers.SelectionChangeCommitted += new System.EventHandler(this.cmbSuppliers_SelectionChangeCommitted);
            // 
            // rbAll
            // 
            this.rbAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(7, 15);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(108, 33);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "ALL SUPPLIERS";
            this.rbAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnBoughtAll);
            this.pnlTop.Controls.Add(this.chkViewDetails);
            this.pnlTop.Controls.Add(this.chkOrderableOnly);
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 54);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 47);
            this.pnlTop.TabIndex = 50;
            // 
            // btnBoughtAll
            // 
            this.btnBoughtAll.Image = global::BSLayer.Properties.Resources.Ok_1;
            this.btnBoughtAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoughtAll.Location = new System.Drawing.Point(565, 8);
            this.btnBoughtAll.Name = "btnBoughtAll";
            this.btnBoughtAll.Size = new System.Drawing.Size(134, 33);
            this.btnBoughtAll.TabIndex = 52;
            this.btnBoughtAll.Text = "BOUGHT ALL";
            this.btnBoughtAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoughtAll.UseVisualStyleBackColor = true;
            this.btnBoughtAll.Click += new System.EventHandler(this.btnBoughtAll_Click);
            // 
            // chkViewDetails
            // 
            this.chkViewDetails.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkViewDetails.Location = new System.Drawing.Point(415, 8);
            this.chkViewDetails.Name = "chkViewDetails";
            this.chkViewDetails.Size = new System.Drawing.Size(122, 33);
            this.chkViewDetails.TabIndex = 51;
            this.chkViewDetails.Text = "OTHER DETAILS";
            this.chkViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkViewDetails.UseVisualStyleBackColor = true;
            this.chkViewDetails.CheckedChanged += new System.EventHandler(this.chkViewDetails_CheckedChanged);
            // 
            // chkOrderableOnly
            // 
            this.chkOrderableOnly.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOrderableOnly.Checked = true;
            this.chkOrderableOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOrderableOnly.Location = new System.Drawing.Point(279, 7);
            this.chkOrderableOnly.Name = "chkOrderableOnly";
            this.chkOrderableOnly.Size = new System.Drawing.Size(122, 33);
            this.chkOrderableOnly.TabIndex = 50;
            this.chkOrderableOnly.Text = "ORDERABLE ONLY";
            this.chkOrderableOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOrderableOnly.UseVisualStyleBackColor = true;
            this.chkOrderableOnly.CheckedChanged += new System.EventHandler(this.chkOrderableOnly_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // vScroll
            // 
            this.vScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScroll.Location = new System.Drawing.Point(940, 101);
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(60, 496);
            this.vScroll.TabIndex = 51;
            this.vScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScroll_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 597);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1000, 70);
            this.panel1.TabIndex = 52;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(865, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "CANCEL";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn5.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn8.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn9.HeaderText = "Order Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.cmdPrint,
            this.cmdReload,
            this.cmdExportAsCsv,
            this.btnUndo,
            this.txtSearch,
            this.cmdSearch});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(1000, 54);
            this.barMain.TabIndex = 53;
            this.barMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BSLayer.Properties.Resources.arti32;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 51);
            this.btnAdd.Text = "ADD STOCK";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::BSLayer.Properties.Resources.MatReport_32;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 51);
            this.btnEdit.Text = "EDIT STOCK";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Image = global::BSLayer.Properties.Resources.Reload_32;
            this.cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(67, 51);
            this.cmdReload.Text = "  RELOAD  ";
            this.cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdReload.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Image = global::BSLayer.Properties.Resources.Print32;
            this.cmdPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(55, 51);
            this.cmdPrint.Text = "  PRINT  ";
            this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmdExportAsCsv
            // 
            this.cmdExportAsCsv.Image = global::BSLayer.Properties.Resources.Export32;
            this.cmdExportAsCsv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdExportAsCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExportAsCsv.Name = "cmdExportAsCsv";
            this.cmdExportAsCsv.Size = new System.Drawing.Size(82, 51);
            this.cmdExportAsCsv.Text = "EXPORT  CSV ";
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
            this.cmdSearch.Image = global::BSLayer.Properties.Resources.View32;
            this.cmdSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(55, 51);
            this.cmdSearch.Text = "SEARCH";
            this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = global::BSLayer.Properties.Resources.ActionUndo;
            this.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(57, 51);
            this.btnUndo.Text = "  UNDO  ";
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // frmStockItemUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.vScroll);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockItemUsage";
            this.Text = "SHOPPING LIST";
            this.Load += new System.EventHandler(this.frmStockItemUsage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemUsageBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource stockItemUsageBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.CheckBox chkOrderableOnly;
        private System.Windows.Forms.CheckBox chkViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.VScrollBar vScroll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colordlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn XSessionQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqtylabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnBoughtAll;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton cmdPrint;
        private System.Windows.Forms.ToolStripButton cmdReload;
        private System.Windows.Forms.ToolStripButton cmdExportAsCsv;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton cmdSearch;
    }
}