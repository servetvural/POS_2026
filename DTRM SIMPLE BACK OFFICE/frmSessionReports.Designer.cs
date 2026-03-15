using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmSessionReports {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionReports));
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.dbIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSessionTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalculatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.colItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloiTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloiTaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSessionAllOrderItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.colArcIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArcEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellArchivedGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrderItems = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddOrderItem = new System.Windows.Forms.ToolStripButton();
            this.btnIncrementOrderItem = new System.Windows.Forms.ToolStripButton();
            this.btnDecrementOrderItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lblOrderTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteOrderItems = new System.Windows.Forms.ToolStripButton();
            this.expOrderItems = new PosLibrary.Expander();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.pnl3661 = new System.Windows.Forms.Panel();
            this.btnLoadSelectables = new System.Windows.Forms.Button();
            this.cmbRange = new System.Windows.Forms.ComboBox();
            this.sRangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.tsSessionOrders = new System.Windows.Forms.ToolStrip();
            this.chkLoadOrders = new System.Windows.Forms.ToolStripButton();
            this.btnChangePaymentMethodForOrder = new System.Windows.Forms.ToolStripButton();
            this.btnDuplicateOrders = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteOrder = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.ToolStripLabel();
            this.lblCash = new System.Windows.Forms.ToolStripLabel();
            this.lblCard = new System.Windows.Forms.ToolStripLabel();
            this.expOrders = new PosLibrary.Expander();
            this.pnlItemsGrouped = new System.Windows.Forms.Panel();
            this.tsGroupedItems = new System.Windows.Forms.ToolStrip();
            this.btnGroupExport = new System.Windows.Forms.ToolStripButton();
            this.btnGroupEmail = new System.Windows.Forms.ToolStripButton();
            this.btnGroupPrint = new System.Windows.Forms.ToolStripButton();
            this.chkLoadAllItems = new System.Windows.Forms.ToolStripButton();
            this.expItemsGrouped = new PosLibrary.Expander();
            this.pnlSessions = new System.Windows.Forms.Panel();
            this.tsSessions2 = new System.Windows.Forms.ToolStrip();
            this.btnSessionDBExport = new System.Windows.Forms.ToolStripButton();
            this.btnSessionDBEmail = new System.Windows.Forms.ToolStripButton();
            this.btnSessionDBPrint = new System.Windows.Forms.ToolStripButton();
            this.tsSessions = new System.Windows.Forms.ToolStrip();
            this.btnSessionDBReload = new System.Windows.Forms.ToolStripButton();
            this.btnArchiveSessions = new System.Windows.Forms.ToolStripButton();
            this.btnPrintReport = new System.Windows.Forms.ToolStripButton();
            this.chkDynamicSessionTotals = new System.Windows.Forms.ToolStripButton();
            this.lblAllSessionTotal = new System.Windows.Forms.ToolStripLabel();
            this.expSessions = new PosLibrary.Expander();
            this.pnlArchivedSessions = new System.Windows.Forms.Panel();
            this.tsArchivedSessions = new System.Windows.Forms.ToolStrip();
            this.btnSessionARCExport = new System.Windows.Forms.ToolStripButton();
            this.btnSessionARCEmail = new System.Windows.Forms.ToolStripButton();
            this.btnSessionARCPrint = new System.Windows.Forms.ToolStripButton();
            this.btnSessionARCReload = new System.Windows.Forms.ToolStripButton();
            this.btnLoadSessions = new System.Windows.Forms.ToolStripButton();
            this.lblArchivedSelectedTotal = new System.Windows.Forms.ToolStripLabel();
            this.expArchivedSessions = new PosLibrary.Expander();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnGenerateTaxReport = new System.Windows.Forms.ToolStripButton();
            this.btnEmailTaxReport = new System.Windows.Forms.ToolStripButton();
            this.btnLoadSessionsFromDirectory = new System.Windows.Forms.ToolStripButton();
            this.btnArchiveSessionToSpecialDirectory = new System.Windows.Forms.ToolStripButton();
            this.btnEnsureSessionData = new System.Windows.Forms.ToolStripButton();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionAllOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            this.pnlOrderItems.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnl3661.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRangeBindingSource)).BeginInit();
            this.tsSessionOrders.SuspendLayout();
            this.pnlItemsGrouped.SuspendLayout();
            this.tsGroupedItems.SuspendLayout();
            this.pnlSessions.SuspendLayout();
            this.tsSessions2.SuspendLayout();
            this.tsSessions.SuspendLayout();
            this.pnlArchivedSessions.SuspendLayout();
            this.tsArchivedSessions.SuspendLayout();
            this.barMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.AllowUserToAddRows = false;
            this.dgvDatabase.AllowUserToDeleteRows = false;
            this.dgvDatabase.AllowUserToResizeRows = false;
            this.dgvDatabase.AutoGenerateColumns = false;
            this.dgvDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbIID,
            this.colDBStartDate,
            this.colDBEndDate,
            this.grossSessionTotalDataGridViewTextBoxColumn});
            this.dgvDatabase.DataSource = this.sessionViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabase.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatabase.Location = new System.Drawing.Point(0, 54);
            this.dgvDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.ReadOnly = true;
            this.dgvDatabase.RowHeadersWidth = 20;
            this.dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabase.Size = new System.Drawing.Size(470, 355);
            this.dgvDatabase.TabIndex = 1;
            this.dgvDatabase.SelectionChanged += new System.EventHandler(this.dgvDatabase_SelectionChanged);
            // 
            // dbIID
            // 
            this.dbIID.DataPropertyName = "IID";
            this.dbIID.HeaderText = "IID";
            this.dbIID.Name = "dbIID";
            this.dbIID.ReadOnly = true;
            this.dbIID.Visible = false;
            this.dbIID.Width = 5;
            // 
            // colDBStartDate
            // 
            this.colDBStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colDBStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDBStartDate.HeaderText = "Session Start @";
            this.colDBStartDate.Name = "colDBStartDate";
            this.colDBStartDate.ReadOnly = true;
            this.colDBStartDate.Width = 150;
            // 
            // colDBEndDate
            // 
            this.colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colDBEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDBEndDate.HeaderText = "Session End @";
            this.colDBEndDate.Name = "colDBEndDate";
            this.colDBEndDate.ReadOnly = true;
            this.colDBEndDate.Width = 150;
            // 
            // grossSessionTotalDataGridViewTextBoxColumn
            // 
            this.grossSessionTotalDataGridViewTextBoxColumn.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.grossSessionTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.grossSessionTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            this.grossSessionTotalDataGridViewTextBoxColumn.Name = "grossSessionTotalDataGridViewTextBoxColumn";
            this.grossSessionTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionViewBindingSource
            // 
            this.sessionViewBindingSource.DataSource = typeof(DTRMNS.SessionView);
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
            this.colPaymentMethod,
            this.colCalculatedValue});
            this.dgvOrders.DataSource = this.ordersViewBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 88);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 25;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(670, 375);
            this.dgvOrders.TabIndex = 71;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MMM/yy HH:mm:ss";
            dataGridViewCellStyle5.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.DataPropertyName = "Payment";
            this.colPaymentMethod.HeaderText = "Pymt";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            this.colPaymentMethod.Width = 40;
            // 
            // colCalculatedValue
            // 
            this.colCalculatedValue.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colCalculatedValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCalculatedValue.HeaderText = "Total";
            this.colCalculatedValue.Name = "colCalculatedValue";
            this.colCalculatedValue.ReadOnly = true;
            this.colCalculatedValue.Width = 60;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataSource = typeof(DTRMNS.OrdersView);
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
            this.coloiTaxPercent,
            this.coloiTaxValue,
            this.Price,
            this.Column1});
            this.dgvOrderItems.DataSource = this.orderItemBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrderItems.Location = new System.Drawing.Point(0, 54);
            this.dgvOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersWidth = 25;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(370, 409);
            this.dgvOrderItems.TabIndex = 0;
            // 
            // colItemIID
            // 
            this.colItemIID.DataPropertyName = "IID";
            this.colItemIID.HeaderText = "IID";
            this.colItemIID.Name = "colItemIID";
            this.colItemIID.ReadOnly = true;
            this.colItemIID.Visible = false;
            this.colItemIID.Width = 5;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 60;
            // 
            // OrderItemText
            // 
            this.OrderItemText.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OrderItemText.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderItemText.HeaderText = "Item";
            this.OrderItemText.Name = "OrderItemText";
            this.OrderItemText.ReadOnly = true;
            this.OrderItemText.Width = 200;
            // 
            // coloiTaxPercent
            // 
            this.coloiTaxPercent.DataPropertyName = "TaxPercent";
            this.coloiTaxPercent.HeaderText = "%";
            this.coloiTaxPercent.Name = "coloiTaxPercent";
            this.coloiTaxPercent.ReadOnly = true;
            this.coloiTaxPercent.Width = 50;
            // 
            // coloiTaxValue
            // 
            this.coloiTaxValue.DataPropertyName = "TaxValue";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.coloiTaxValue.DefaultCellStyle = dataGridViewCellStyle10;
            this.coloiTaxValue.HeaderText = "Tax";
            this.coloiTaxValue.Name = "coloiTaxValue";
            this.coloiTaxValue.ReadOnly = true;
            this.coloiTaxValue.Width = 60;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle11;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Total";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // dgvSessionAllOrderItems
            // 
            this.dgvSessionAllOrderItems.AllowUserToAddRows = false;
            this.dgvSessionAllOrderItems.AllowUserToDeleteRows = false;
            this.dgvSessionAllOrderItems.AutoGenerateColumns = false;
            this.dgvSessionAllOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSessionAllOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionAllOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvSessionAllOrderItems.DataSource = this.orderItemBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSessionAllOrderItems.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSessionAllOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessionAllOrderItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSessionAllOrderItems.Location = new System.Drawing.Point(0, 54);
            this.dgvSessionAllOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSessionAllOrderItems.Name = "dgvSessionAllOrderItems";
            this.dgvSessionAllOrderItems.ReadOnly = true;
            this.dgvSessionAllOrderItems.RowHeadersWidth = 25;
            this.dgvSessionAllOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionAllOrderItems.Size = new System.Drawing.Size(300, 409);
            this.dgvSessionAllOrderItems.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn1.HeaderText = "IID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dgvArchive
            // 
            this.dgvArchive.AllowUserToAddRows = false;
            this.dgvArchive.AllowUserToDeleteRows = false;
            this.dgvArchive.AllowUserToResizeRows = false;
            this.dgvArchive.AutoGenerateColumns = false;
            this.dgvArchive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArcIID,
            this.colArcStartDate,
            this.colArcEndDate,
            this.cellArchivedGrossTotal});
            this.dgvArchive.DataSource = this.sessionViewBindingSource;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArchive.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArchive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvArchive.Location = new System.Drawing.Point(0, 54);
            this.dgvArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.ReadOnly = true;
            this.dgvArchive.RowHeadersWidth = 20;
            this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchive.Size = new System.Drawing.Size(400, 409);
            this.dgvArchive.TabIndex = 2;
            this.dgvArchive.SelectionChanged += new System.EventHandler(this.dgvArchive_SelectionChanged);
            // 
            // colArcIID
            // 
            this.colArcIID.DataPropertyName = "IID";
            this.colArcIID.HeaderText = "IID";
            this.colArcIID.Name = "colArcIID";
            this.colArcIID.ReadOnly = true;
            this.colArcIID.Visible = false;
            this.colArcIID.Width = 5;
            // 
            // colArcStartDate
            // 
            this.colArcStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colArcStartDate.DefaultCellStyle = dataGridViewCellStyle19;
            this.colArcStartDate.HeaderText = "Session Start @";
            this.colArcStartDate.Name = "colArcStartDate";
            this.colArcStartDate.ReadOnly = true;
            this.colArcStartDate.Width = 150;
            // 
            // colArcEndDate
            // 
            this.colArcEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.colArcEndDate.DefaultCellStyle = dataGridViewCellStyle20;
            this.colArcEndDate.HeaderText = "Session End @";
            this.colArcEndDate.Name = "colArcEndDate";
            this.colArcEndDate.ReadOnly = true;
            this.colArcEndDate.Width = 150;
            // 
            // cellArchivedGrossTotal
            // 
            this.cellArchivedGrossTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = "0";
            this.cellArchivedGrossTotal.DefaultCellStyle = dataGridViewCellStyle21;
            this.cellArchivedGrossTotal.HeaderText = "Gross Total";
            this.cellArchivedGrossTotal.Name = "cellArchivedGrossTotal";
            this.cellArchivedGrossTotal.ReadOnly = true;
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.Controls.Add(this.dgvOrderItems);
            this.pnlOrderItems.Controls.Add(this.toolStrip2);
            this.pnlOrderItems.Controls.Add(this.toolStrip1);
            this.pnlOrderItems.Controls.Add(this.expOrderItems);
            this.pnlOrderItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOrderItems.Location = new System.Drawing.Point(1630, 54);
            this.pnlOrderItems.MinimumSize = new System.Drawing.Size(20, 0);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.Size = new System.Drawing.Size(400, 463);
            this.pnlOrderItems.TabIndex = 77;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddOrderItem,
            this.btnIncrementOrderItem,
            this.btnDecrementOrderItem,
            this.btnDeleteItem,
            this.lblOrderTotal});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(370, 54);
            this.toolStrip2.TabIndex = 77;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnAddOrderItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddOrderItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(60, 51);
            this.btnAddOrderItem.Text = "Add Item";
            this.btnAddOrderItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddOrderItem.Click += new System.EventHandler(this.btnAddOrderItem_Click);
            // 
            // btnIncrementOrderItem
            // 
            this.btnIncrementOrderItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.arrow_up32;
            this.btnIncrementOrderItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncrementOrderItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncrementOrderItem.Name = "btnIncrementOrderItem";
            this.btnIncrementOrderItem.Size = new System.Drawing.Size(65, 51);
            this.btnIncrementOrderItem.Text = "Increment";
            this.btnIncrementOrderItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncrementOrderItem.Click += new System.EventHandler(this.btnIncrementOrderItem_Click);
            // 
            // btnDecrementOrderItem
            // 
            this.btnDecrementOrderItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.arrow_down32;
            this.btnDecrementOrderItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDecrementOrderItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDecrementOrderItem.Name = "btnDecrementOrderItem";
            this.btnDecrementOrderItem.Size = new System.Drawing.Size(69, 51);
            this.btnDecrementOrderItem.Text = "Decrement";
            this.btnDecrementOrderItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDecrementOrderItem.Click += new System.EventHandler(this.btnDecrementOrderItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(71, 51);
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderTotal.Image = global::DTRMSimpleBackOffice.Properties.Resources.Sigma32;
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(42, 51);
            this.lblOrderTotal.Text = "Total";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblOrderTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteOrderItems});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // btnDeleteOrderItems
            // 
            this.btnDeleteOrderItems.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeleteOrderItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteOrderItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteOrderItems.Name = "btnDeleteOrderItems";
            this.btnDeleteOrderItems.Size = new System.Drawing.Size(114, 51);
            this.btnDeleteOrderItems.Text = "Delete OrderItem(s)";
            this.btnDeleteOrderItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expOrderItems
            // 
            this.expOrderItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expOrderItems.Caption = "Order Items";
            this.expOrderItems.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expOrderItems.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.expOrderItems.CaptionForeColor = System.Drawing.Color.White;
            this.expOrderItems.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            this.expOrderItems.ColourFixed = System.Drawing.Color.Salmon;
            this.expOrderItems.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expOrderItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.expOrderItems.ExpandableControl = this.pnlOrderItems;
            this.expOrderItems.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expOrderItems.Expanded = true;
            this.expOrderItems.Fixed = false;
            this.expOrderItems.Location = new System.Drawing.Point(370, 0);
            this.expOrderItems.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expOrderItems.LockButtonSize = new System.Drawing.Size(28, 32);
            this.expOrderItems.LockButtonVisible = false;
            this.expOrderItems.MinimumSize = new System.Drawing.Size(5, 5);
            this.expOrderItems.Name = "expOrderItems";
            this.expOrderItems.Size = new System.Drawing.Size(30, 463);
            this.expOrderItems.TabIndex = 76;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.dgvOrders);
            this.pnlOrders.Controls.Add(this.pnl3661);
            this.pnlOrders.Controls.Add(this.tsSessionOrders);
            this.pnlOrders.Controls.Add(this.expOrders);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOrders.Location = new System.Drawing.Point(930, 54);
            this.pnlOrders.MinimumSize = new System.Drawing.Size(20, 200);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(700, 463);
            this.pnlOrders.TabIndex = 74;
            // 
            // pnl3661
            // 
            this.pnl3661.Controls.Add(this.btnLoadSelectables);
            this.pnl3661.Controls.Add(this.cmbRange);
            this.pnl3661.Controls.Add(this.btnSil);
            this.pnl3661.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3661.Location = new System.Drawing.Point(0, 54);
            this.pnl3661.Name = "pnl3661";
            this.pnl3661.Size = new System.Drawing.Size(670, 34);
            this.pnl3661.TabIndex = 75;
            this.pnl3661.Visible = false;
            // 
            // btnLoadSelectables
            // 
            this.btnLoadSelectables.Location = new System.Drawing.Point(3, 3);
            this.btnLoadSelectables.Name = "btnLoadSelectables";
            this.btnLoadSelectables.Size = new System.Drawing.Size(39, 27);
            this.btnLoadSelectables.TabIndex = 5;
            this.btnLoadSelectables.Text = "L";
            this.btnLoadSelectables.UseVisualStyleBackColor = true;
            this.btnLoadSelectables.Click += new System.EventHandler(this.btnLoadSelectables_Click);
            // 
            // cmbRange
            // 
            this.cmbRange.DataSource = this.sRangeBindingSource;
            this.cmbRange.DisplayMember = "DisplayValue";
            this.cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRange.FormattingEnabled = true;
            this.cmbRange.Location = new System.Drawing.Point(93, 3);
            this.cmbRange.Name = "cmbRange";
            this.cmbRange.Size = new System.Drawing.Size(242, 25);
            this.cmbRange.TabIndex = 4;
            this.cmbRange.ValueMember = "ItemGap";
            this.cmbRange.SelectedValueChanged += new System.EventHandler(this.cmbRange_SelectedValueChanged);
            // 
            // sRangeBindingSource
            // 
            this.sRangeBindingSource.DataSource = typeof(DTRMSimpleBackOffice.SRange);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(48, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(39, 27);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "S";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.tsSil_Click);
            // 
            // tsSessionOrders
            // 
            this.tsSessionOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkLoadOrders,
            this.btnChangePaymentMethodForOrder,
            this.btnDuplicateOrders,
            this.btnDeleteOrder,
            this.lblTotal,
            this.lblCash,
            this.lblCard});
            this.tsSessionOrders.Location = new System.Drawing.Point(0, 0);
            this.tsSessionOrders.Name = "tsSessionOrders";
            this.tsSessionOrders.Size = new System.Drawing.Size(670, 54);
            this.tsSessionOrders.TabIndex = 0;
            this.tsSessionOrders.Text = "toolStrip2";
            // 
            // chkLoadOrders
            // 
            this.chkLoadOrders.CheckOnClick = true;
            this.chkLoadOrders.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkLoadOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkLoadOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkLoadOrders.Name = "chkLoadOrders";
            this.chkLoadOrders.Size = new System.Drawing.Size(75, 51);
            this.chkLoadOrders.Text = "Load Orders";
            this.chkLoadOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkLoadOrders.CheckedChanged += new System.EventHandler(this.chkLoadOrders_CheckedChanged);
            // 
            // btnChangePaymentMethodForOrder
            // 
            this.btnChangePaymentMethodForOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.QuestionGreen;
            this.btnChangePaymentMethodForOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChangePaymentMethodForOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangePaymentMethodForOrder.Name = "btnChangePaymentMethodForOrder";
            this.btnChangePaymentMethodForOrder.Size = new System.Drawing.Size(58, 51);
            this.btnChangePaymentMethodForOrder.Text = "Payment";
            this.btnChangePaymentMethodForOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePaymentMethodForOrder.Click += new System.EventHandler(this.btnChangePaymentMethodForOrder_Click);
            // 
            // btnDuplicateOrders
            // 
            this.btnDuplicateOrders.Image = global::DTRMSimpleBackOffice.Properties.Resources.Duplicate;
            this.btnDuplicateOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuplicateOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicateOrders.Name = "btnDuplicateOrders";
            this.btnDuplicateOrders.Size = new System.Drawing.Size(61, 51);
            this.btnDuplicateOrders.Text = "Duplicate";
            this.btnDuplicateOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDuplicateOrders.Visible = false;
            this.btnDuplicateOrders.Click += new System.EventHandler(this.btnDuplicateOrders_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeleteOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(90, 51);
            this.btnDeleteOrder.Text = "Delete Order(s)";
            this.btnDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteOrder.Visible = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Image = global::DTRMSimpleBackOffice.Properties.Resources.Sigma32;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Size = new System.Drawing.Size(52, 51);
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblCash
            // 
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCash.Image = global::DTRMSimpleBackOffice.Properties.Resources.cash32;
            this.lblCash.Name = "lblCash";
            this.lblCash.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCash.Size = new System.Drawing.Size(50, 51);
            this.lblCash.Text = "Cash";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblCard
            // 
            this.lblCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCard.Image = global::DTRMSimpleBackOffice.Properties.Resources.card32;
            this.lblCard.Name = "lblCard";
            this.lblCard.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCard.Size = new System.Drawing.Size(51, 51);
            this.lblCard.Text = "Card";
            this.lblCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expOrders
            // 
            this.expOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expOrders.Caption = "Orders";
            this.expOrders.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expOrders.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.expOrders.CaptionForeColor = System.Drawing.Color.White;
            this.expOrders.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            this.expOrders.ColourFixed = System.Drawing.Color.Salmon;
            this.expOrders.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.expOrders.ExpandableControl = this.pnlOrders;
            this.expOrders.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expOrders.Expanded = true;
            this.expOrders.Fixed = false;
            this.expOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expOrders.Location = new System.Drawing.Point(670, 0);
            this.expOrders.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expOrders.LockButtonSize = new System.Drawing.Size(28, 32);
            this.expOrders.LockButtonVisible = false;
            this.expOrders.MinimumSize = new System.Drawing.Size(5, 18);
            this.expOrders.Name = "expOrders";
            this.expOrders.Size = new System.Drawing.Size(30, 463);
            this.expOrders.TabIndex = 75;
            // 
            // pnlItemsGrouped
            // 
            this.pnlItemsGrouped.Controls.Add(this.dgvSessionAllOrderItems);
            this.pnlItemsGrouped.Controls.Add(this.tsGroupedItems);
            this.pnlItemsGrouped.Controls.Add(this.expItemsGrouped);
            this.pnlItemsGrouped.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlItemsGrouped.Location = new System.Drawing.Point(2030, 54);
            this.pnlItemsGrouped.Name = "pnlItemsGrouped";
            this.pnlItemsGrouped.Size = new System.Drawing.Size(330, 463);
            this.pnlItemsGrouped.TabIndex = 2;
            // 
            // tsGroupedItems
            // 
            this.tsGroupedItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGroupExport,
            this.btnGroupEmail,
            this.btnGroupPrint,
            this.chkLoadAllItems});
            this.tsGroupedItems.Location = new System.Drawing.Point(0, 0);
            this.tsGroupedItems.Name = "tsGroupedItems";
            this.tsGroupedItems.Size = new System.Drawing.Size(300, 54);
            this.tsGroupedItems.TabIndex = 0;
            this.tsGroupedItems.Text = "toolStrip1";
            // 
            // btnGroupExport
            // 
            this.btnGroupExport.Image = global::DTRMSimpleBackOffice.Properties.Resources.Export32;
            this.btnGroupExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGroupExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGroupExport.Name = "btnGroupExport";
            this.btnGroupExport.Size = new System.Drawing.Size(56, 51);
            this.btnGroupExport.Text = "  Export  ";
            this.btnGroupExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGroupExport.Click += new System.EventHandler(this.btnGroupExport_Click);
            // 
            // btnGroupEmail
            // 
            this.btnGroupEmail.Image = global::DTRMSimpleBackOffice.Properties.Resources.mektup32;
            this.btnGroupEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGroupEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGroupEmail.Name = "btnGroupEmail";
            this.btnGroupEmail.Size = new System.Drawing.Size(52, 51);
            this.btnGroupEmail.Text = "  Email  ";
            this.btnGroupEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGroupEmail.Click += new System.EventHandler(this.btnGroupEmail_Click);
            // 
            // btnGroupPrint
            // 
            this.btnGroupPrint.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnGroupPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGroupPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGroupPrint.Name = "btnGroupPrint";
            this.btnGroupPrint.Size = new System.Drawing.Size(48, 51);
            this.btnGroupPrint.Text = "  Print  ";
            this.btnGroupPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGroupPrint.Click += new System.EventHandler(this.btnGroupPrint_Click);
            // 
            // chkLoadAllItems
            // 
            this.chkLoadAllItems.CheckOnClick = true;
            this.chkLoadAllItems.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkLoadAllItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkLoadAllItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkLoadAllItems.Name = "chkLoadAllItems";
            this.chkLoadAllItems.Size = new System.Drawing.Size(69, 51);
            this.chkLoadAllItems.Text = "Load Items";
            this.chkLoadAllItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkLoadAllItems.CheckedChanged += new System.EventHandler(this.chkLoadAllItems_CheckedChanged);
            // 
            // expItemsGrouped
            // 
            this.expItemsGrouped.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expItemsGrouped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expItemsGrouped.Caption = "Session ALL Items Grouped";
            this.expItemsGrouped.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expItemsGrouped.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.expItemsGrouped.CaptionForeColor = System.Drawing.Color.White;
            this.expItemsGrouped.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            this.expItemsGrouped.ColourFixed = System.Drawing.Color.Salmon;
            this.expItemsGrouped.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expItemsGrouped.Dock = System.Windows.Forms.DockStyle.Right;
            this.expItemsGrouped.ExpandableControl = this.pnlItemsGrouped;
            this.expItemsGrouped.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expItemsGrouped.Expanded = true;
            this.expItemsGrouped.Fixed = false;
            this.expItemsGrouped.Location = new System.Drawing.Point(300, 0);
            this.expItemsGrouped.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expItemsGrouped.LockButtonSize = new System.Drawing.Size(28, 32);
            this.expItemsGrouped.LockButtonVisible = false;
            this.expItemsGrouped.MinimumSize = new System.Drawing.Size(5, 5);
            this.expItemsGrouped.Name = "expItemsGrouped";
            this.expItemsGrouped.Size = new System.Drawing.Size(30, 463);
            this.expItemsGrouped.TabIndex = 2;
            // 
            // pnlSessions
            // 
            this.pnlSessions.Controls.Add(this.dgvDatabase);
            this.pnlSessions.Controls.Add(this.tsSessions2);
            this.pnlSessions.Controls.Add(this.tsSessions);
            this.pnlSessions.Controls.Add(this.expSessions);
            this.pnlSessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSessions.Location = new System.Drawing.Point(430, 54);
            this.pnlSessions.MinimumSize = new System.Drawing.Size(20, 0);
            this.pnlSessions.Name = "pnlSessions";
            this.pnlSessions.Size = new System.Drawing.Size(500, 463);
            this.pnlSessions.TabIndex = 72;
            // 
            // tsSessions2
            // 
            this.tsSessions2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSessions2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSessionDBExport,
            this.btnSessionDBEmail,
            this.btnSessionDBPrint});
            this.tsSessions2.Location = new System.Drawing.Point(0, 409);
            this.tsSessions2.Name = "tsSessions2";
            this.tsSessions2.Size = new System.Drawing.Size(470, 54);
            this.tsSessions2.TabIndex = 74;
            this.tsSessions2.Text = "toolStrip2";
            // 
            // btnSessionDBExport
            // 
            this.btnSessionDBExport.Image = global::DTRMSimpleBackOffice.Properties.Resources.Export32;
            this.btnSessionDBExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionDBExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionDBExport.Name = "btnSessionDBExport";
            this.btnSessionDBExport.Size = new System.Drawing.Size(108, 51);
            this.btnSessionDBExport.Text = "Export All Sessions";
            this.btnSessionDBExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionDBExport.Click += new System.EventHandler(this.btnSessionDBExport_Click);
            // 
            // btnSessionDBEmail
            // 
            this.btnSessionDBEmail.Image = global::DTRMSimpleBackOffice.Properties.Resources.mektup32;
            this.btnSessionDBEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionDBEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionDBEmail.Name = "btnSessionDBEmail";
            this.btnSessionDBEmail.Size = new System.Drawing.Size(104, 51);
            this.btnSessionDBEmail.Text = "Email All Sessions";
            this.btnSessionDBEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionDBEmail.Click += new System.EventHandler(this.btnSessionDBEmail_Click);
            // 
            // btnSessionDBPrint
            // 
            this.btnSessionDBPrint.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnSessionDBPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionDBPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionDBPrint.Name = "btnSessionDBPrint";
            this.btnSessionDBPrint.Size = new System.Drawing.Size(73, 51);
            this.btnSessionDBPrint.Text = "Print As List";
            this.btnSessionDBPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionDBPrint.Click += new System.EventHandler(this.btnSessionDBPrint_Click);
            // 
            // tsSessions
            // 
            this.tsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSessionDBReload,
            this.btnArchiveSessions,
            this.btnPrintReport,
            this.chkDynamicSessionTotals,
            this.lblAllSessionTotal});
            this.tsSessions.Location = new System.Drawing.Point(0, 0);
            this.tsSessions.Name = "tsSessions";
            this.tsSessions.Size = new System.Drawing.Size(470, 54);
            this.tsSessions.TabIndex = 0;
            this.tsSessions.Text = "toolStrip1";
            // 
            // btnSessionDBReload
            // 
            this.btnSessionDBReload.Image = global::DTRMSimpleBackOffice.Properties.Resources.Reload_32;
            this.btnSessionDBReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionDBReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionDBReload.Name = "btnSessionDBReload";
            this.btnSessionDBReload.Size = new System.Drawing.Size(94, 51);
            this.btnSessionDBReload.Text = "Reload Sessions";
            this.btnSessionDBReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionDBReload.Click += new System.EventHandler(this.btnSessionDBReload_Click);
            // 
            // btnArchiveSessions
            // 
            this.btnArchiveSessions.Image = global::DTRMSimpleBackOffice.Properties.Resources.DBToFolder32;
            this.btnArchiveSessions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnArchiveSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArchiveSessions.Name = "btnArchiveSessions";
            this.btnArchiveSessions.Size = new System.Drawing.Size(98, 51);
            this.btnArchiveSessions.Text = "Archive Sessions";
            this.btnArchiveSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchiveSessions.Click += new System.EventHandler(this.btnArchiveSessions_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnPrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(97, 51);
            this.btnPrintReport.Text = "Print Z Report(s)";
            this.btnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // chkDynamicSessionTotals
            // 
            this.chkDynamicSessionTotals.CheckOnClick = true;
            this.chkDynamicSessionTotals.Image = global::DTRMSimpleBackOffice.Properties.Resources.Unchecked;
            this.chkDynamicSessionTotals.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chkDynamicSessionTotals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkDynamicSessionTotals.Name = "chkDynamicSessionTotals";
            this.chkDynamicSessionTotals.Size = new System.Drawing.Size(92, 51);
            this.chkDynamicSessionTotals.Text = "Dynamic Totals";
            this.chkDynamicSessionTotals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkDynamicSessionTotals.Click += new System.EventHandler(this.chkDynamicSessionTotals_Click);
            // 
            // lblAllSessionTotal
            // 
            this.lblAllSessionTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAllSessionTotal.Image = global::DTRMSimpleBackOffice.Properties.Resources.Sigma32;
            this.lblAllSessionTotal.Name = "lblAllSessionTotal";
            this.lblAllSessionTotal.Size = new System.Drawing.Size(42, 51);
            this.lblAllSessionTotal.Text = "Total";
            this.lblAllSessionTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblAllSessionTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expSessions
            // 
            this.expSessions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expSessions.Caption = "Sessions";
            this.expSessions.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expSessions.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.expSessions.CaptionForeColor = System.Drawing.Color.White;
            this.expSessions.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            this.expSessions.ColourFixed = System.Drawing.Color.Salmon;
            this.expSessions.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expSessions.Dock = System.Windows.Forms.DockStyle.Right;
            this.expSessions.ExpandableControl = this.pnlSessions;
            this.expSessions.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expSessions.Expanded = true;
            this.expSessions.Fixed = false;
            this.expSessions.Location = new System.Drawing.Point(470, 0);
            this.expSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            this.expSessions.LockButtonVisible = false;
            this.expSessions.MinimumSize = new System.Drawing.Size(20, 5);
            this.expSessions.Name = "expSessions";
            this.expSessions.Size = new System.Drawing.Size(30, 463);
            this.expSessions.TabIndex = 73;
            // 
            // pnlArchivedSessions
            // 
            this.pnlArchivedSessions.Controls.Add(this.dgvArchive);
            this.pnlArchivedSessions.Controls.Add(this.tsArchivedSessions);
            this.pnlArchivedSessions.Controls.Add(this.expArchivedSessions);
            this.pnlArchivedSessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlArchivedSessions.Location = new System.Drawing.Point(0, 54);
            this.pnlArchivedSessions.MinimumSize = new System.Drawing.Size(20, 0);
            this.pnlArchivedSessions.Name = "pnlArchivedSessions";
            this.pnlArchivedSessions.Size = new System.Drawing.Size(430, 463);
            this.pnlArchivedSessions.TabIndex = 3;
            // 
            // tsArchivedSessions
            // 
            this.tsArchivedSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSessionARCExport,
            this.btnSessionARCEmail,
            this.btnSessionARCPrint,
            this.btnSessionARCReload,
            this.btnLoadSessions,
            this.lblArchivedSelectedTotal});
            this.tsArchivedSessions.Location = new System.Drawing.Point(0, 0);
            this.tsArchivedSessions.Name = "tsArchivedSessions";
            this.tsArchivedSessions.Size = new System.Drawing.Size(400, 54);
            this.tsArchivedSessions.TabIndex = 0;
            this.tsArchivedSessions.Text = "toolStrip1";
            // 
            // btnSessionARCExport
            // 
            this.btnSessionARCExport.Image = global::DTRMSimpleBackOffice.Properties.Resources.Export32;
            this.btnSessionARCExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionARCExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionARCExport.Name = "btnSessionARCExport";
            this.btnSessionARCExport.Size = new System.Drawing.Size(56, 51);
            this.btnSessionARCExport.Text = "  Export  ";
            this.btnSessionARCExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionARCExport.Click += new System.EventHandler(this.btnSessionARCExport_Click);
            // 
            // btnSessionARCEmail
            // 
            this.btnSessionARCEmail.Image = global::DTRMSimpleBackOffice.Properties.Resources.mektup32;
            this.btnSessionARCEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionARCEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionARCEmail.Name = "btnSessionARCEmail";
            this.btnSessionARCEmail.Size = new System.Drawing.Size(52, 51);
            this.btnSessionARCEmail.Text = "  Email  ";
            this.btnSessionARCEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionARCEmail.Click += new System.EventHandler(this.btnSessionARCEmail_Click);
            // 
            // btnSessionARCPrint
            // 
            this.btnSessionARCPrint.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.btnSessionARCPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionARCPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionARCPrint.Name = "btnSessionARCPrint";
            this.btnSessionARCPrint.Size = new System.Drawing.Size(48, 51);
            this.btnSessionARCPrint.Text = "  Print  ";
            this.btnSessionARCPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionARCPrint.Click += new System.EventHandler(this.btnSessionARCPrint_Click);
            // 
            // btnSessionARCReload
            // 
            this.btnSessionARCReload.Image = global::DTRMSimpleBackOffice.Properties.Resources.Reload_32;
            this.btnSessionARCReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSessionARCReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSessionARCReload.Name = "btnSessionARCReload";
            this.btnSessionARCReload.Size = new System.Drawing.Size(47, 51);
            this.btnSessionARCReload.Text = "Reload";
            this.btnSessionARCReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSessionARCReload.Click += new System.EventHandler(this.btnSessionARCReload_Click);
            // 
            // btnLoadSessions
            // 
            this.btnLoadSessions.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderToDB32;
            this.btnLoadSessions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadSessions.Name = "btnLoadSessions";
            this.btnLoadSessions.Size = new System.Drawing.Size(84, 51);
            this.btnLoadSessions.Text = "Load Sessions";
            this.btnLoadSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadSessions.Click += new System.EventHandler(this.btnLoadSessions_Click);
            // 
            // lblArchivedSelectedTotal
            // 
            this.lblArchivedSelectedTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArchivedSelectedTotal.Image = global::DTRMSimpleBackOffice.Properties.Resources.Sigma32;
            this.lblArchivedSelectedTotal.Name = "lblArchivedSelectedTotal";
            this.lblArchivedSelectedTotal.Size = new System.Drawing.Size(42, 51);
            this.lblArchivedSelectedTotal.Text = "Total";
            this.lblArchivedSelectedTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expArchivedSessions
            // 
            this.expArchivedSessions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expArchivedSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expArchivedSessions.Caption = "Archived Sessions";
            this.expArchivedSessions.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expArchivedSessions.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expArchivedSessions.CaptionForeColor = System.Drawing.Color.White;
            this.expArchivedSessions.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            this.expArchivedSessions.ColourFixed = System.Drawing.Color.Salmon;
            this.expArchivedSessions.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expArchivedSessions.Dock = System.Windows.Forms.DockStyle.Right;
            this.expArchivedSessions.ExpandableControl = this.pnlArchivedSessions;
            this.expArchivedSessions.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expArchivedSessions.Expanded = true;
            this.expArchivedSessions.Fixed = false;
            this.expArchivedSessions.Location = new System.Drawing.Point(400, 0);
            this.expArchivedSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expArchivedSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            this.expArchivedSessions.LockButtonVisible = false;
            this.expArchivedSessions.MinimumSize = new System.Drawing.Size(5, 5);
            this.expArchivedSessions.Name = "expArchivedSessions";
            this.expArchivedSessions.Size = new System.Drawing.Size(30, 463);
            this.expArchivedSessions.TabIndex = 3;
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload,
            this.btnGenerateTaxReport,
            this.btnEmailTaxReport,
            this.btnLoadSessionsFromDirectory,
            this.btnArchiveSessionToSpecialDirectory,
            this.btnEnsureSessionData,
            this.btnCheck});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(2107, 54);
            this.barMain.TabIndex = 13;
            this.barMain.Text = "toolStrip1";
            // 
            // btnReload
            // 
            this.btnReload.Image = global::DTRMSimpleBackOffice.Properties.Resources.Reload_32;
            this.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(47, 51);
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnGenerateTaxReport
            // 
            this.btnGenerateTaxReport.Image = global::DTRMSimpleBackOffice.Properties.Resources.documan_cizgili32;
            this.btnGenerateTaxReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGenerateTaxReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateTaxReport.Name = "btnGenerateTaxReport";
            this.btnGenerateTaxReport.Size = new System.Drawing.Size(102, 51);
            this.btnGenerateTaxReport.Text = "Export Tax Report";
            this.btnGenerateTaxReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerateTaxReport.Click += new System.EventHandler(this.btnGenerateTaxReport_Click);
            // 
            // btnEmailTaxReport
            // 
            this.btnEmailTaxReport.Image = global::DTRMSimpleBackOffice.Properties.Resources.mektup32;
            this.btnEmailTaxReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmailTaxReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmailTaxReport.Name = "btnEmailTaxReport";
            this.btnEmailTaxReport.Size = new System.Drawing.Size(98, 51);
            this.btnEmailTaxReport.Text = "Email Tax Report";
            this.btnEmailTaxReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmailTaxReport.Click += new System.EventHandler(this.btnEmailTaxReport_Click);
            // 
            // btnLoadSessionsFromDirectory
            // 
            this.btnLoadSessionsFromDirectory.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderToDBPlus32;
            this.btnLoadSessionsFromDirectory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadSessionsFromDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadSessionsFromDirectory.Name = "btnLoadSessionsFromDirectory";
            this.btnLoadSessionsFromDirectory.Size = new System.Drawing.Size(119, 51);
            this.btnLoadSessionsFromDirectory.Text = "Load From Directory";
            this.btnLoadSessionsFromDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoadSessionsFromDirectory.Click += new System.EventHandler(this.btnLoadSessionsFromDirectory_Click);
            // 
            // btnArchiveSessionToSpecialDirectory
            // 
            this.btnArchiveSessionToSpecialDirectory.Image = global::DTRMSimpleBackOffice.Properties.Resources.DBToFolderPlus32;
            this.btnArchiveSessionToSpecialDirectory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnArchiveSessionToSpecialDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArchiveSessionToSpecialDirectory.Name = "btnArchiveSessionToSpecialDirectory";
            this.btnArchiveSessionToSpecialDirectory.Size = new System.Drawing.Size(118, 51);
            this.btnArchiveSessionToSpecialDirectory.Text = "Archive To Directory";
            this.btnArchiveSessionToSpecialDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchiveSessionToSpecialDirectory.Click += new System.EventHandler(this.btnArchiveSessionToSpecialDirectory_Click);
            // 
            // btnEnsureSessionData
            // 
            this.btnEnsureSessionData.Image = global::DTRMSimpleBackOffice.Properties.Resources.tickgreen;
            this.btnEnsureSessionData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEnsureSessionData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnsureSessionData.Name = "btnEnsureSessionData";
            this.btnEnsureSessionData.Size = new System.Drawing.Size(115, 51);
            this.btnEnsureSessionData.Text = "Ensure Session Data";
            this.btnEnsureSessionData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnsureSessionData.Click += new System.EventHandler(this.btnEnsureSessionData_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = false;
            this.btnCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(50, 51);
            this.btnCheck.Text = "toolStripButton2";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn7.HeaderText = "Item";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn9.HeaderText = "IID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IID";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn10.HeaderText = "IID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OrderDate";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.Format = "F";
            dataGridViewCellStyle27.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn11.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn12.HeaderText = "Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn13.HeaderText = "IID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Quantity";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn14.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn15.HeaderText = "Item";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Price";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "N2";
            dataGridViewCellStyle31.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewTextBoxColumn16.HeaderText = "Price";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 60;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Total";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewCellStyle32.NullValue = null;
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewTextBoxColumn17.HeaderText = "Total";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn17.Width = 60;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "IID";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.Format = "N2";
            dataGridViewCellStyle33.NullValue = null;
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewTextBoxColumn18.HeaderText = "IID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 60;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "StartDate";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewTextBoxColumn19.HeaderText = "Session Start @";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "EndDate";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.Format = "dd/MM/yyyy ddd HH:mm:ss";
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewTextBoxColumn20.HeaderText = "Session End @";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N2";
            dataGridViewCellStyle36.NullValue = "0";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewTextBoxColumn21.HeaderText = "Gross Total";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 200;
            // 
            // frmSessionReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2107, 517);
            this.Controls.Add(this.pnlItemsGrouped);
            this.Controls.Add(this.pnlOrderItems);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlSessions);
            this.Controls.Add(this.pnlArchivedSessions);
            this.Controls.Add(this.barMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSessionReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Session Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSessionReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionAllOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            this.pnlOrderItems.ResumeLayout(false);
            this.pnlOrderItems.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnl3661.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sRangeBindingSource)).EndInit();
            this.tsSessionOrders.ResumeLayout(false);
            this.tsSessionOrders.PerformLayout();
            this.pnlItemsGrouped.ResumeLayout(false);
            this.pnlItemsGrouped.PerformLayout();
            this.tsGroupedItems.ResumeLayout(false);
            this.tsGroupedItems.PerformLayout();
            this.pnlSessions.ResumeLayout(false);
            this.pnlSessions.PerformLayout();
            this.tsSessions2.ResumeLayout(false);
            this.tsSessions2.PerformLayout();
            this.tsSessions.ResumeLayout(false);
            this.tsSessions.PerformLayout();
            this.pnlArchivedSessions.ResumeLayout(false);
            this.pnlArchivedSessions.PerformLayout();
            this.tsArchivedSessions.ResumeLayout(false);
            this.tsArchivedSessions.PerformLayout();
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.BindingSource sessionViewBindingSource;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System .Windows.Forms.DataGridView dgvSessionAllOrderItems;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.ToolStrip tsArchivedSessions;
        private System.Windows.Forms.ToolStripButton btnSessionARCExport;
        private System.Windows.Forms.ToolStripButton btnSessionARCEmail;
        private System.Windows.Forms.ToolStripButton btnSessionARCPrint;
        private System.Windows.Forms.ToolStripButton btnSessionARCReload;
        private System.Windows.Forms.ToolStripButton btnLoadSessions;
        private System.Windows.Forms.ToolStripLabel lblArchivedSelectedTotal;
        private System.Windows.Forms.ToolStrip tsSessionOrders;
        private System.Windows.Forms.ToolStripButton chkLoadOrders;
        private System.Windows.Forms.ToolStripButton btnDuplicateOrders;
        private System.Windows.Forms.ToolStripButton btnDeleteOrder;
        private System.Windows.Forms.ToolStripLabel lblTotal;
        private System.Windows.Forms.ToolStrip tsGroupedItems;
        private System.Windows.Forms.ToolStripButton btnGroupExport;
        private System.Windows.Forms.ToolStripButton btnGroupEmail;
        private System.Windows.Forms.ToolStripButton btnGroupPrint;
        private System.Windows.Forms.ToolStripButton chkLoadAllItems;
        private System.Windows.Forms.ToolStrip tsSessions;
        private System.Windows.Forms.ToolStripButton btnSessionDBExport;
        private System.Windows.Forms.ToolStripButton btnSessionDBEmail;
        private System.Windows.Forms.ToolStripButton btnSessionDBPrint;
        private System.Windows.Forms.ToolStripButton btnSessionDBReload;
        private System.Windows.Forms.ToolStripButton btnArchiveSessions;
        private System.Windows.Forms.ToolStripButton btnPrintReport;
        private System.Windows.Forms.ToolStripButton chkDynamicSessionTotals;
        private System.Windows.Forms.ToolStripLabel lblAllSessionTotal;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnGenerateTaxReport;
        private System.Windows.Forms.ToolStripButton btnEmailTaxReport;
        private System.Windows.Forms.ToolStripButton btnLoadSessionsFromDirectory;
        private System.Windows.Forms.ToolStripButton btnArchiveSessionToSpecialDirectory;
        private System.Windows.Forms.ToolStripButton btnEnsureSessionData;
        private System.Windows.Forms.Panel pnlOrders;
        private PosLibrary.Expander expOrders;
        private PosLibrary.Expander expSessions;
        private System.Windows.Forms.Panel pnlSessions;
        private PosLibrary.Expander expOrderItems;
        private System.Windows.Forms.Panel pnlOrderItems;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDeleteOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel pnlArchivedSessions;
        private PosLibrary.Expander expArchivedSessions;
        private System.Windows.Forms.Panel pnlItemsGrouped;
        private PosLibrary.Expander expItemsGrouped;
        private System.Windows.Forms.ToolStrip tsSessions2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddOrderItem;
        private System.Windows.Forms.ToolStripButton btnIncrementOrderItem;
        private System.Windows.Forms.ToolStripButton btnDecrementOrderItem;
        private System.Windows.Forms.ToolStripButton btnDeleteItem;
        private System.Windows.Forms.ToolStripLabel lblOrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArcEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellArchivedGrossTotal;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSessionTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnChangePaymentMethodForOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalculatedValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloiTaxPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloiTaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel pnl3661;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.BindingSource sRangeBindingSource;
        private System.Windows.Forms.Button btnLoadSelectables;
        private System.Windows.Forms.ToolStripLabel lblCard;
        private System.Windows.Forms.ToolStripLabel lblCash;
    }
}