using POSLayer.Models;
using POSLayer.Views;

namespace WinOffice {
    partial class frmSessionAnalysis {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionAnalysis));
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSessions = new System.Windows.Forms.TabPage();
            this.tsSessions = new System.Windows.Forms.ToolStrip();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.tabAnalysis = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tsOrders = new System.Windows.Forms.ToolStrip();
            this.btnShowOrderItemsAndStockUsage = new System.Windows.Forms.ToolStripButton();
            this.btnSelectAllOrders = new System.Windows.Forms.ToolStripButton();
            this.chkShowOrderitemandStockUsage = new System.Windows.Forms.ToolStripButton();
            this.lblOrderTotal = new System.Windows.Forms.ToolStripLabel();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntityButtonIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsOrderItems = new System.Windows.Forms.ToolStrip();
            this.btnOrderItemPrint = new System.Windows.Forms.ToolStripButton();
            this.lblOrderItemTotal = new System.Windows.Forms.ToolStripLabel();
            this.dgvStockItems = new System.Windows.Forms.DataGridView();
            this.tsStockItems = new System.Windows.Forms.ToolStrip();
            this.btnSuppliers = new System.Windows.Forms.ToolStripDropDownButton();
            this.rbAllSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.rbSingleSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSuppliers = new System.Windows.Forms.ToolStripComboBox();
            this.chkOrderableOnly = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.chkReportFormat = new System.Windows.Forms.ToolStripButton();
            this.tabXOrders = new System.Windows.Forms.TabPage();
            this.dgvXOrders = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblXOrderTotals = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSessionTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colOrderIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockItemUsageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colXOrderIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXOrderCalculatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXOrderCalculatedVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXOrderCalculatedExVatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXOrderServiceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXOrderServiceChargeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colStockItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsedQuantityTypeLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderableFloatQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderableIntQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderableQuantityTypeLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabSessions.SuspendLayout();
            this.tsSessions.SuspendLayout();
            this.tabAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tsOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.tsOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItems)).BeginInit();
            this.tsStockItems.SuspendLayout();
            this.tabXOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXOrders)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemUsageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.AllowUserToAddRows = false;
            this.dgvDatabase.AllowUserToDeleteRows = false;
            this.dgvDatabase.AllowUserToResizeRows = false;
            this.dgvDatabase.AutoGenerateColumns = false;
            this.dgvDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbIID,
            this.colDBStartDate,
            this.colDBEndDate,
            this.grossSessionTotalDataGridViewTextBoxColumn});
            this.dgvDatabase.DataSource = this.sessionViewBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabase.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatabase.Location = new System.Drawing.Point(3, 57);
            this.dgvDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabase.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatabase.RowHeadersWidth = 20;
            this.dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabase.Size = new System.Drawing.Size(850, 457);
            this.dgvDatabase.TabIndex = 75;
            this.dgvDatabase.SelectionChanged += new System.EventHandler(this.dgvDatabase_SelectionChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderIID,
            this.orderDateDataGridViewTextBoxColumn,
            this.colOrderSum});
            this.dgvOrders.DataSource = this.ordersViewBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 54);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 25;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(241, 197);
            this.dgvOrders.TabIndex = 72;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order Qty Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSessions);
            this.tabMain.Controls.Add(this.tabAnalysis);
            this.tabMain.Controls.Add(this.tabXOrders);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(140, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(864, 555);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 9;
            // 
            // tabSessions
            // 
            this.tabSessions.Controls.Add(this.dgvDatabase);
            this.tabSessions.Controls.Add(this.tsSessions);
            this.tabSessions.Location = new System.Drawing.Point(4, 34);
            this.tabSessions.Name = "tabSessions";
            this.tabSessions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessions.Size = new System.Drawing.Size(856, 517);
            this.tabSessions.TabIndex = 3;
            this.tabSessions.Text = "SESSIONS";
            this.tabSessions.UseVisualStyleBackColor = true;
            // 
            // tsSessions
            // 
            this.tsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload});
            this.tsSessions.Location = new System.Drawing.Point(3, 3);
            this.tsSessions.Name = "tsSessions";
            this.tsSessions.Size = new System.Drawing.Size(850, 54);
            this.tsSessions.TabIndex = 0;
            this.tsSessions.Text = "toolStrip1";
            // 
            // btnReload
            // 
            this.btnReload.Image = global::WinOffice.Properties.Resources.Reload_32;
            this.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(65, 51);
            this.btnReload.Text = "   Reload   ";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tabAnalysis
            // 
            this.tabAnalysis.Controls.Add(this.splitContainer1);
            this.tabAnalysis.Location = new System.Drawing.Point(4, 34);
            this.tabAnalysis.Name = "tabAnalysis";
            this.tabAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalysis.Size = new System.Drawing.Size(856, 517);
            this.tabAnalysis.TabIndex = 2;
            this.tabAnalysis.Text = "ORDERS";
            this.tabAnalysis.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvStockItems);
            this.splitContainer1.Panel2.Controls.Add(this.tsStockItems);
            this.splitContainer1.Size = new System.Drawing.Size(850, 511);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.SplitterWidth = 12;
            this.splitContainer1.TabIndex = 73;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvOrders);
            this.splitContainer2.Panel1.Controls.Add(this.tsOrders);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvOrderItems);
            this.splitContainer2.Panel2.Controls.Add(this.tsOrderItems);
            this.splitContainer2.Size = new System.Drawing.Size(241, 511);
            this.splitContainer2.SplitterDistance = 251;
            this.splitContainer2.SplitterWidth = 18;
            this.splitContainer2.TabIndex = 0;
            // 
            // tsOrders
            // 
            this.tsOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowOrderItemsAndStockUsage,
            this.btnSelectAllOrders,
            this.chkShowOrderitemandStockUsage,
            this.lblOrderTotal});
            this.tsOrders.Location = new System.Drawing.Point(0, 0);
            this.tsOrders.Name = "tsOrders";
            this.tsOrders.Size = new System.Drawing.Size(241, 54);
            this.tsOrders.TabIndex = 0;
            this.tsOrders.Text = "toolStrip1";
            // 
            // btnShowOrderItemsAndStockUsage
            // 
            this.btnShowOrderItemsAndStockUsage.Image = global::WinOffice.Properties.Resources.Reload_32;
            this.btnShowOrderItemsAndStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowOrderItemsAndStockUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowOrderItemsAndStockUsage.Name = "btnShowOrderItemsAndStockUsage";
            this.btnShowOrderItemsAndStockUsage.Size = new System.Drawing.Size(85, 51);
            this.btnShowOrderItemsAndStockUsage.Text = "SHOW USAGE";
            this.btnShowOrderItemsAndStockUsage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowOrderItemsAndStockUsage.Click += new System.EventHandler(this.btnShowOrderItemsAndStockUsage_Click);
            // 
            // btnSelectAllOrders
            // 
            this.btnSelectAllOrders.Image = global::WinOffice.Properties.Resources.Hash32;
            this.btnSelectAllOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSelectAllOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAllOrders.Name = "btnSelectAllOrders";
            this.btnSelectAllOrders.Size = new System.Drawing.Size(72, 51);
            this.btnSelectAllOrders.Text = "SELECT ALL";
            this.btnSelectAllOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelectAllOrders.Click += new System.EventHandler(this.btnSelectAllOrders_Click);
            // 
            // chkShowOrderitemandStockUsage
            // 
            this.chkShowOrderitemandStockUsage.CheckOnClick = true;
            this.chkShowOrderitemandStockUsage.Image = global::WinOffice.Properties.Resources.Unchecked;
            this.chkShowOrderitemandStockUsage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkShowOrderitemandStockUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkShowOrderitemandStockUsage.Name = "chkShowOrderitemandStockUsage";
            this.chkShowOrderitemandStockUsage.Size = new System.Drawing.Size(79, 51);
            this.chkShowOrderitemandStockUsage.Text = "SHOW AUTO";
            this.chkShowOrderitemandStockUsage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkShowOrderitemandStockUsage.CheckedChanged += new System.EventHandler(this.chkShowOrderitemandStockUsage_CheckedChanged);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(28, 15);
            this.lblOrderTotal.Text = "0.00";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.AutoGenerateColumns = false;
            this.dgvOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemIID,
            this.Quantity,
            this.OrderItemText,
            this.Price,
            this.colOrderItemTotal,
            this.colEntityButtonIID});
            this.dgvOrderItems.DataSource = this.orderItemBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrderItems.Location = new System.Drawing.Point(0, 54);
            this.dgvOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersWidth = 25;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(241, 188);
            this.dgvOrderItems.TabIndex = 2;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle10;
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 40;
            // 
            // OrderItemText
            // 
            this.OrderItemText.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OrderItemText.DefaultCellStyle = dataGridViewCellStyle11;
            this.OrderItemText.HeaderText = "Item";
            this.OrderItemText.Name = "OrderItemText";
            this.OrderItemText.ReadOnly = true;
            this.OrderItemText.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle12;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // colOrderItemTotal
            // 
            this.colOrderItemTotal.DataPropertyName = "Total";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.colOrderItemTotal.DefaultCellStyle = dataGridViewCellStyle13;
            this.colOrderItemTotal.HeaderText = "Total";
            this.colOrderItemTotal.Name = "colOrderItemTotal";
            this.colOrderItemTotal.ReadOnly = true;
            this.colOrderItemTotal.Width = 60;
            // 
            // colEntityButtonIID
            // 
            this.colEntityButtonIID.DataPropertyName = "EntityButtonIID";
            this.colEntityButtonIID.HeaderText = "EntityButtonIID";
            this.colEntityButtonIID.Name = "colEntityButtonIID";
            this.colEntityButtonIID.ReadOnly = true;
            this.colEntityButtonIID.Visible = false;
            // 
            // tsOrderItems
            // 
            this.tsOrderItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOrderItemPrint,
            this.lblOrderItemTotal});
            this.tsOrderItems.Location = new System.Drawing.Point(0, 0);
            this.tsOrderItems.Name = "tsOrderItems";
            this.tsOrderItems.Size = new System.Drawing.Size(241, 54);
            this.tsOrderItems.TabIndex = 1;
            this.tsOrderItems.Text = "toolStrip1";
            // 
            // btnOrderItemPrint
            // 
            this.btnOrderItemPrint.Image = global::WinOffice.Properties.Resources.Printer32;
            this.btnOrderItemPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOrderItemPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrderItemPrint.Name = "btnOrderItemPrint";
            this.btnOrderItemPrint.Size = new System.Drawing.Size(54, 51);
            this.btnOrderItemPrint.Text = "   Print   ";
            this.btnOrderItemPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblOrderItemTotal
            // 
            this.lblOrderItemTotal.Name = "lblOrderItemTotal";
            this.lblOrderItemTotal.Size = new System.Drawing.Size(28, 51);
            this.lblOrderItemTotal.Text = "0.00";
            // 
            // dgvStockItems
            // 
            this.dgvStockItems.AllowUserToAddRows = false;
            this.dgvStockItems.AllowUserToDeleteRows = false;
            this.dgvStockItems.AutoGenerateColumns = false;
            this.dgvStockItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockItemIID,
            this.stockNameDataGridViewTextBoxColumn,
            this.colUsedQuantity,
            this.colUsedQuantityTypeLabel,
            this.colOrderableFloatQuantity,
            this.colOrderableIntQuantity,
            this.colOrderableQuantityTypeLabel,
            this.colConversion,
            this.SupplierIID,
            this.SupplierName});
            this.dgvStockItems.DataSource = this.stockItemUsageBindingSource;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockItems.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStockItems.Location = new System.Drawing.Point(0, 54);
            this.dgvStockItems.Name = "dgvStockItems";
            this.dgvStockItems.ReadOnly = true;
            this.dgvStockItems.RowHeadersWidth = 25;
            this.dgvStockItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockItems.Size = new System.Drawing.Size(597, 457);
            this.dgvStockItems.TabIndex = 7;
            // 
            // tsStockItems
            // 
            this.tsStockItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSuppliers,
            this.cmbSuppliers,
            this.chkOrderableOnly,
            this.toolStripButton1,
            this.toolStripButton2,
            this.chkReportFormat});
            this.tsStockItems.Location = new System.Drawing.Point(0, 0);
            this.tsStockItems.Name = "tsStockItems";
            this.tsStockItems.Size = new System.Drawing.Size(597, 54);
            this.tsStockItems.TabIndex = 1;
            this.tsStockItems.Text = "toolStrip1";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rbAllSuppliers,
            this.rbSingleSupplier});
            this.btnSuppliers.Image = global::WinOffice.Properties.Resources.MultiPeople2;
            this.btnSuppliers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(100, 51);
            this.btnSuppliers.Text = "Suppliers";
            // 
            // rbAllSuppliers
            // 
            this.rbAllSuppliers.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rbAllSuppliers.Checked = true;
            this.rbAllSuppliers.CheckOnClick = true;
            this.rbAllSuppliers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbAllSuppliers.Name = "rbAllSuppliers";
            this.rbAllSuppliers.Size = new System.Drawing.Size(152, 22);
            this.rbAllSuppliers.Text = "All Suppliers";
            // 
            // rbSingleSupplier
            // 
            this.rbSingleSupplier.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rbSingleSupplier.CheckOnClick = true;
            this.rbSingleSupplier.Name = "rbSingleSupplier";
            this.rbSingleSupplier.Size = new System.Drawing.Size(152, 22);
            this.rbSingleSupplier.Text = "Single Supplier";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.AutoSize = false;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(200, 23);
            this.cmbSuppliers.Visible = false;
            // 
            // chkOrderableOnly
            // 
            this.chkOrderableOnly.CheckOnClick = true;
            this.chkOrderableOnly.Image = global::WinOffice.Properties.Resources.Unchecked;
            this.chkOrderableOnly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkOrderableOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkOrderableOnly.Name = "chkOrderableOnly";
            this.chkOrderableOnly.Size = new System.Drawing.Size(91, 51);
            this.chkOrderableOnly.Text = "Orderable Only";
            this.chkOrderableOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WinOffice.Properties.Resources.RefreshGreen;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 51);
            this.toolStripButton1.Text = "  Reload  ";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WinOffice.Properties.Resources.Printer32;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 51);
            this.toolStripButton2.Text = "   Print   ";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // chkReportFormat
            // 
            this.chkReportFormat.CheckOnClick = true;
            this.chkReportFormat.Image = global::WinOffice.Properties.Resources.Unchecked;
            this.chkReportFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkReportFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkReportFormat.Name = "chkReportFormat";
            this.chkReportFormat.Size = new System.Drawing.Size(87, 51);
            this.chkReportFormat.Text = "Report Format";
            this.chkReportFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabXOrders
            // 
            this.tabXOrders.Controls.Add(this.dgvXOrders);
            this.tabXOrders.Controls.Add(this.statusStrip1);
            this.tabXOrders.Location = new System.Drawing.Point(4, 34);
            this.tabXOrders.Name = "tabXOrders";
            this.tabXOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabXOrders.Size = new System.Drawing.Size(856, 517);
            this.tabXOrders.TabIndex = 4;
            this.tabXOrders.Text = "X-ORDERS";
            this.tabXOrders.UseVisualStyleBackColor = true;
            // 
            // dgvXOrders
            // 
            this.dgvXOrders.AllowUserToAddRows = false;
            this.dgvXOrders.AllowUserToDeleteRows = false;
            this.dgvXOrders.AutoGenerateColumns = false;
            this.dgvXOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvXOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colXOrderIID,
            this.orderDateDataGridViewTextBoxColumn1,
            this.colXOrderCalculatedValue,
            this.colXOrderCalculatedVat,
            this.colXOrderCalculatedExVatValue,
            this.colXOrderServiceCharge,
            this.colXOrderServiceChargeTax});
            this.dgvXOrders.DataSource = this.ordersViewBindingSource1;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXOrders.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvXOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvXOrders.Name = "dgvXOrders";
            this.dgvXOrders.ReadOnly = true;
            this.dgvXOrders.RowHeadersWidth = 25;
            this.dgvXOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXOrders.Size = new System.Drawing.Size(850, 485);
            this.dgvXOrders.TabIndex = 0;
            this.dgvXOrders.DataSourceChanged += new System.EventHandler(this.dgvXOrders_DataSourceChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblXOrderTotals});
            this.statusStrip1.Location = new System.Drawing.Point(3, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblXOrderTotals
            // 
            this.lblXOrderTotals.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblXOrderTotals.Name = "lblXOrderTotals";
            this.lblXOrderTotals.Size = new System.Drawing.Size(40, 21);
            this.lblXOrderTotals.Text = "0.00";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderableType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order Qty Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dbIID
            // 
            this.dbIID.DataPropertyName = "IID";
            this.dbIID.HeaderText = "IID";
            this.dbIID.Name = "dbIID";
            this.dbIID.ReadOnly = true;
            this.dbIID.Visible = false;
            // 
            // colDBStartDate
            // 
            this.colDBStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colDBStartDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDBStartDate.HeaderText = "Session Start @";
            this.colDBStartDate.Name = "colDBStartDate";
            this.colDBStartDate.ReadOnly = true;
            this.colDBStartDate.Width = 150;
            // 
            // colDBEndDate
            // 
            this.colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colDBEndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDBEndDate.HeaderText = "Session End @";
            this.colDBEndDate.Name = "colDBEndDate";
            this.colDBEndDate.ReadOnly = true;
            this.colDBEndDate.Width = 150;
            // 
            // grossSessionTotalDataGridViewTextBoxColumn
            // 
            this.grossSessionTotalDataGridViewTextBoxColumn.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.grossSessionTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.grossSessionTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            this.grossSessionTotalDataGridViewTextBoxColumn.Name = "grossSessionTotalDataGridViewTextBoxColumn";
            this.grossSessionTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionViewBindingSource
            // 
            this.sessionViewBindingSource.DataSource = typeof(SessionView);
            // 
            // colOrderIID
            // 
            this.colOrderIID.DataPropertyName = "IID";
            this.colOrderIID.HeaderText = "IID";
            this.colOrderIID.Name = "colOrderIID";
            this.colOrderIID.ReadOnly = true;
            this.colOrderIID.Visible = false;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "F";
            dataGridViewCellStyle7.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // colOrderSum
            // 
            this.colOrderSum.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.colOrderSum.DefaultCellStyle = dataGridViewCellStyle8;
            this.colOrderSum.HeaderText = "Total";
            this.colOrderSum.Name = "colOrderSum";
            this.colOrderSum.ReadOnly = true;
            this.colOrderSum.Width = 60;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataSource = typeof(OrdersView);
            // 
            // colItemIID
            // 
            this.colItemIID.DataPropertyName = "IID";
            this.colItemIID.HeaderText = "IID";
            this.colItemIID.Name = "colItemIID";
            this.colItemIID.ReadOnly = true;
            this.colItemIID.Visible = false;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // stockItemUsageBindingSource
            // 
            this.stockItemUsageBindingSource.DataSource = typeof(StockItemUsage);
            // 
            // colXOrderIID
            // 
            this.colXOrderIID.DataPropertyName = "IID";
            this.colXOrderIID.HeaderText = "IID";
            this.colXOrderIID.Name = "colXOrderIID";
            this.colXOrderIID.ReadOnly = true;
            this.colXOrderIID.Visible = false;
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "F";
            dataGridViewCellStyle26.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle26;
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            this.orderDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn1.Width = 200;
            // 
            // colXOrderCalculatedValue
            // 
            this.colXOrderCalculatedValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colXOrderCalculatedValue.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "c2";
            this.colXOrderCalculatedValue.DefaultCellStyle = dataGridViewCellStyle27;
            this.colXOrderCalculatedValue.HeaderText = "Total";
            this.colXOrderCalculatedValue.Name = "colXOrderCalculatedValue";
            this.colXOrderCalculatedValue.ReadOnly = true;
            this.colXOrderCalculatedValue.Width = 56;
            // 
            // colXOrderCalculatedVat
            // 
            this.colXOrderCalculatedVat.DataPropertyName = "CalculatedVat";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "c2";
            this.colXOrderCalculatedVat.DefaultCellStyle = dataGridViewCellStyle28;
            this.colXOrderCalculatedVat.HeaderText = "Tax";
            this.colXOrderCalculatedVat.Name = "colXOrderCalculatedVat";
            this.colXOrderCalculatedVat.ReadOnly = true;
            // 
            // colXOrderCalculatedExVatValue
            // 
            this.colXOrderCalculatedExVatValue.DataPropertyName = "CalculatedExVatValue";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "c2";
            this.colXOrderCalculatedExVatValue.DefaultCellStyle = dataGridViewCellStyle29;
            this.colXOrderCalculatedExVatValue.HeaderText = "Wout Tax";
            this.colXOrderCalculatedExVatValue.Name = "colXOrderCalculatedExVatValue";
            this.colXOrderCalculatedExVatValue.ReadOnly = true;
            // 
            // colXOrderServiceCharge
            // 
            this.colXOrderServiceCharge.DataPropertyName = "ServiceCharge";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "c2";
            this.colXOrderServiceCharge.DefaultCellStyle = dataGridViewCellStyle30;
            this.colXOrderServiceCharge.HeaderText = "Service Charge";
            this.colXOrderServiceCharge.Name = "colXOrderServiceCharge";
            this.colXOrderServiceCharge.ReadOnly = true;
            this.colXOrderServiceCharge.Width = 120;
            // 
            // colXOrderServiceChargeTax
            // 
            this.colXOrderServiceChargeTax.DataPropertyName = "ServiceChargeTax";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "c2";
            this.colXOrderServiceChargeTax.DefaultCellStyle = dataGridViewCellStyle31;
            this.colXOrderServiceChargeTax.HeaderText = "Service Charge Tax";
            this.colXOrderServiceChargeTax.Name = "colXOrderServiceChargeTax";
            this.colXOrderServiceChargeTax.ReadOnly = true;
            this.colXOrderServiceChargeTax.Width = 140;
            // 
            // ordersViewBindingSource1
            // 
            this.ordersViewBindingSource1.DataSource = typeof(OrdersView);
            // 
            // stockItemBindingSource
            // 
            this.stockItemBindingSource.DataSource = typeof(StockItem);
            // 
            // colStockItemIID
            // 
            this.colStockItemIID.DataPropertyName = "StockItemIID";
            this.colStockItemIID.HeaderText = "StockItemIID";
            this.colStockItemIID.Name = "colStockItemIID";
            this.colStockItemIID.ReadOnly = true;
            this.colStockItemIID.Visible = false;
            // 
            // stockNameDataGridViewTextBoxColumn
            // 
            this.stockNameDataGridViewTextBoxColumn.DataPropertyName = "StockName";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.stockNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.stockNameDataGridViewTextBoxColumn.HeaderText = "StockName";
            this.stockNameDataGridViewTextBoxColumn.Name = "stockNameDataGridViewTextBoxColumn";
            this.stockNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // colUsedQuantity
            // 
            this.colUsedQuantity.DataPropertyName = "SessionQuantity";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUsedQuantity.DefaultCellStyle = dataGridViewCellStyle17;
            this.colUsedQuantity.HeaderText = "Used Qty";
            this.colUsedQuantity.Name = "colUsedQuantity";
            this.colUsedQuantity.ReadOnly = true;
            this.colUsedQuantity.Width = 80;
            // 
            // colUsedQuantityTypeLabel
            // 
            this.colUsedQuantityTypeLabel.DataPropertyName = "QuantityTypeAsString";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUsedQuantityTypeLabel.DefaultCellStyle = dataGridViewCellStyle18;
            this.colUsedQuantityTypeLabel.HeaderText = "Used Type";
            this.colUsedQuantityTypeLabel.Name = "colUsedQuantityTypeLabel";
            this.colUsedQuantityTypeLabel.ReadOnly = true;
            this.colUsedQuantityTypeLabel.Width = 90;
            // 
            // colOrderableFloatQuantity
            // 
            this.colOrderableFloatQuantity.DataPropertyName = "OrderableFloatQuantity";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N3";
            dataGridViewCellStyle19.NullValue = null;
            this.colOrderableFloatQuantity.DefaultCellStyle = dataGridViewCellStyle19;
            this.colOrderableFloatQuantity.HeaderText = "Order Qty";
            this.colOrderableFloatQuantity.Name = "colOrderableFloatQuantity";
            this.colOrderableFloatQuantity.ReadOnly = true;
            this.colOrderableFloatQuantity.Width = 80;
            // 
            // colOrderableIntQuantity
            // 
            this.colOrderableIntQuantity.DataPropertyName = "OrderableQuantity";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            this.colOrderableIntQuantity.DefaultCellStyle = dataGridViewCellStyle20;
            this.colOrderableIntQuantity.HeaderText = "Order Qty";
            this.colOrderableIntQuantity.Name = "colOrderableIntQuantity";
            this.colOrderableIntQuantity.ReadOnly = true;
            this.colOrderableIntQuantity.Visible = false;
            this.colOrderableIntQuantity.Width = 50;
            // 
            // colOrderableQuantityTypeLabel
            // 
            this.colOrderableQuantityTypeLabel.DataPropertyName = "OrderableTypeAsString";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOrderableQuantityTypeLabel.DefaultCellStyle = dataGridViewCellStyle21;
            this.colOrderableQuantityTypeLabel.HeaderText = "Order Type";
            this.colOrderableQuantityTypeLabel.Name = "colOrderableQuantityTypeLabel";
            this.colOrderableQuantityTypeLabel.ReadOnly = true;
            this.colOrderableQuantityTypeLabel.Width = 80;
            // 
            // colConversion
            // 
            this.colConversion.DataPropertyName = "Conversion";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            dataGridViewCellStyle22.NullValue = null;
            this.colConversion.DefaultCellStyle = dataGridViewCellStyle22;
            this.colConversion.HeaderText = "Conversion";
            this.colConversion.Name = "colConversion";
            this.colConversion.ReadOnly = true;
            // 
            // SupplierIID
            // 
            this.SupplierIID.DataPropertyName = "SupplierIID";
            this.SupplierIID.HeaderText = "SupplierIID";
            this.SupplierIID.Name = "SupplierIID";
            this.SupplierIID.ReadOnly = true;
            this.SupplierIID.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SupplierName.DefaultCellStyle = dataGridViewCellStyle23;
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 80;
            // 
            // frmSessionAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 555);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSessionAnalysis";
            this.Text = "SESSION & STOCK ANALYSIS  ....";
            this.Load += new System.EventHandler(this.frmSessionAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabSessions.ResumeLayout(false);
            this.tabSessions.PerformLayout();
            this.tsSessions.ResumeLayout(false);
            this.tsSessions.PerformLayout();
            this.tabAnalysis.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tsOrders.ResumeLayout(false);
            this.tsOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.tsOrderItems.ResumeLayout(false);
            this.tsOrderItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockItems)).EndInit();
            this.tsStockItems.ResumeLayout(false);
            this.tsStockItems.PerformLayout();
            this.tabXOrders.ResumeLayout(false);
            this.tabXOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXOrders)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemUsageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sessionViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSessionTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource stockItemBindingSource;
        private System.Windows.Forms.BindingSource stockItemUsageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAnalysis;
        private System.Windows.Forms.TabPage tabSessions;
        private System.Windows.Forms.ToolStrip tsOrders;
        private System.Windows.Forms.ToolStripButton btnShowOrderItemsAndStockUsage;
        private System.Windows.Forms.ToolStripButton btnSelectAllOrders;
        private System.Windows.Forms.ToolStripButton chkShowOrderitemandStockUsage;
        private System.Windows.Forms.ToolStripLabel lblOrderTotal;
        private System.Windows.Forms.ToolStrip tsSessions;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderItemTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonIID;
        private System.Windows.Forms.ToolStrip tsOrderItems;
        private System.Windows.Forms.ToolStripButton btnOrderItemPrint;
        private System.Windows.Forms.ToolStripLabel lblOrderItemTotal;
        private System.Windows.Forms.DataGridView dgvStockItems;
        private System.Windows.Forms.ToolStrip tsStockItems;
        private System.Windows.Forms.ToolStripDropDownButton btnSuppliers;
        private System.Windows.Forms.ToolStripMenuItem rbAllSuppliers;
        private System.Windows.Forms.ToolStripMenuItem rbSingleSupplier;
        private System.Windows.Forms.ToolStripComboBox cmbSuppliers;
        private System.Windows.Forms.ToolStripButton chkOrderableOnly;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton chkReportFormat;
        private System.Windows.Forms.TabPage tabXOrders;
        private System.Windows.Forms.DataGridView dgvXOrders;
        private System.Windows.Forms.BindingSource ordersViewBindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblXOrderTotals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXOrderIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXOrderCalculatedValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXOrderCalculatedVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXOrderCalculatedExVatValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXOrderServiceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXOrderServiceChargeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsedQuantityTypeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderableFloatQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderableIntQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderableQuantityTypeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}