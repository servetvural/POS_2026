using POSLayer.Models;
using POSLayer.Views;

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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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
            dgvDatabase = new System.Windows.Forms.DataGridView();
            dbIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDBStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDBEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grossSessionTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sessionViewBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvOrders = new System.Windows.Forms.DataGridView();
            colOrderIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCalculatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ordersViewBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvOrderItems = new System.Windows.Forms.DataGridView();
            colItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coloiTaxPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coloiTaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderItemBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvSessionAllOrderItems = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvArchive = new System.Windows.Forms.DataGridView();
            colArcIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colArcStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colArcEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cellArchivedGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlOrderItems = new System.Windows.Forms.Panel();
            toolStrip2 = new System.Windows.Forms.ToolStrip();
            btnAddOrderItem = new System.Windows.Forms.ToolStripButton();
            btnIncrementOrderItem = new System.Windows.Forms.ToolStripButton();
            btnDecrementOrderItem = new System.Windows.Forms.ToolStripButton();
            btnDeleteItem = new System.Windows.Forms.ToolStripButton();
            lblOrderTotal = new System.Windows.Forms.ToolStripLabel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnDeleteOrderItems = new System.Windows.Forms.ToolStripButton();
            expOrderItems = new PosLibrary.Expander();
            pnlOrders = new System.Windows.Forms.Panel();
            pnl3661 = new System.Windows.Forms.Panel();
            btnLoadSelectables = new System.Windows.Forms.Button();
            cmbRange = new System.Windows.Forms.ComboBox();
            sRangeBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSil = new System.Windows.Forms.Button();
            tsSessionOrders = new System.Windows.Forms.ToolStrip();
            chkLoadOrders = new System.Windows.Forms.ToolStripButton();
            btnChangePaymentMethodForOrder = new System.Windows.Forms.ToolStripButton();
            btnDuplicateOrders = new System.Windows.Forms.ToolStripButton();
            btnDeleteOrder = new System.Windows.Forms.ToolStripButton();
            lblTotal = new System.Windows.Forms.ToolStripLabel();
            lblCash = new System.Windows.Forms.ToolStripLabel();
            lblCard = new System.Windows.Forms.ToolStripLabel();
            expOrders = new PosLibrary.Expander();
            pnlItemsGrouped = new System.Windows.Forms.Panel();
            tsGroupedItems = new System.Windows.Forms.ToolStrip();
            btnGroupExport = new System.Windows.Forms.ToolStripButton();
            btnGroupEmail = new System.Windows.Forms.ToolStripButton();
            btnGroupPrint = new System.Windows.Forms.ToolStripButton();
            chkLoadAllItems = new System.Windows.Forms.ToolStripButton();
            expItemsGrouped = new PosLibrary.Expander();
            pnlSessions = new System.Windows.Forms.Panel();
            tsSessions2 = new System.Windows.Forms.ToolStrip();
            btnSessionDBExport = new System.Windows.Forms.ToolStripButton();
            btnSessionDBEmail = new System.Windows.Forms.ToolStripButton();
            btnSessionDBPrint = new System.Windows.Forms.ToolStripButton();
            tsSessions = new System.Windows.Forms.ToolStrip();
            btnSessionDBReload = new System.Windows.Forms.ToolStripButton();
            btnArchiveSessions = new System.Windows.Forms.ToolStripButton();
            btnPrintReport = new System.Windows.Forms.ToolStripButton();
            chkDynamicSessionTotals = new System.Windows.Forms.ToolStripButton();
            lblAllSessionTotal = new System.Windows.Forms.ToolStripLabel();
            expSessions = new PosLibrary.Expander();
            pnlArchivedSessions = new System.Windows.Forms.Panel();
            tsArchivedSessions = new System.Windows.Forms.ToolStrip();
            btnSessionARCExport = new System.Windows.Forms.ToolStripButton();
            btnSessionARCEmail = new System.Windows.Forms.ToolStripButton();
            btnSessionARCPrint = new System.Windows.Forms.ToolStripButton();
            btnSessionARCReload = new System.Windows.Forms.ToolStripButton();
            btnLoadSessions = new System.Windows.Forms.ToolStripButton();
            lblArchivedSelectedTotal = new System.Windows.Forms.ToolStripLabel();
            expArchivedSessions = new PosLibrary.Expander();
            barMain = new System.Windows.Forms.ToolStrip();
            btnReload = new System.Windows.Forms.ToolStripButton();
            btnGenerateTaxReport = new System.Windows.Forms.ToolStripButton();
            btnEmailTaxReport = new System.Windows.Forms.ToolStripButton();
            btnLoadSessionsFromDirectory = new System.Windows.Forms.ToolStripButton();
            btnArchiveSessionToSpecialDirectory = new System.Windows.Forms.ToolStripButton();
            btnEnsureSessionData = new System.Windows.Forms.ToolStripButton();
            btnCheck = new System.Windows.Forms.ToolStripButton();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSessionAllOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            pnlOrderItems.SuspendLayout();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnl3661.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sRangeBindingSource).BeginInit();
            tsSessionOrders.SuspendLayout();
            pnlItemsGrouped.SuspendLayout();
            tsGroupedItems.SuspendLayout();
            pnlSessions.SuspendLayout();
            tsSessions2.SuspendLayout();
            tsSessions.SuspendLayout();
            pnlArchivedSessions.SuspendLayout();
            tsArchivedSessions.SuspendLayout();
            barMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatabase
            // 
            dgvDatabase.AllowUserToAddRows = false;
            dgvDatabase.AllowUserToDeleteRows = false;
            dgvDatabase.AllowUserToResizeRows = false;
            dgvDatabase.AutoGenerateColumns = false;
            dgvDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dbIID, colDBStartDate, colDBEndDate, grossSessionTotalDataGridViewTextBoxColumn });
            dgvDatabase.DataSource = sessionViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDatabase.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDatabase.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvDatabase.Location = new System.Drawing.Point(0, 54);
            dgvDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvDatabase.Name = "dgvDatabase";
            dgvDatabase.ReadOnly = true;
            dgvDatabase.RowHeadersWidth = 20;
            dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDatabase.Size = new System.Drawing.Size(470, 355);
            dgvDatabase.TabIndex = 1;
            dgvDatabase.SelectionChanged += dgvDatabase_SelectionChanged;
            // 
            // dbIID
            // 
            dbIID.DataPropertyName = "IID";
            dbIID.HeaderText = "IID";
            dbIID.Name = "dbIID";
            dbIID.ReadOnly = true;
            dbIID.Visible = false;
            dbIID.Width = 5;
            // 
            // colDBStartDate
            // 
            colDBStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colDBStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            colDBStartDate.HeaderText = "Session Start @";
            colDBStartDate.Name = "colDBStartDate";
            colDBStartDate.ReadOnly = true;
            colDBStartDate.Width = 150;
            // 
            // colDBEndDate
            // 
            colDBEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colDBEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            colDBEndDate.HeaderText = "Session End @";
            colDBEndDate.Name = "colDBEndDate";
            colDBEndDate.ReadOnly = true;
            colDBEndDate.Width = 150;
            // 
            // grossSessionTotalDataGridViewTextBoxColumn
            // 
            grossSessionTotalDataGridViewTextBoxColumn.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            grossSessionTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            grossSessionTotalDataGridViewTextBoxColumn.HeaderText = "Gross Total";
            grossSessionTotalDataGridViewTextBoxColumn.Name = "grossSessionTotalDataGridViewTextBoxColumn";
            grossSessionTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionViewBindingSource
            // 
            sessionViewBindingSource.DataSource = typeof(SessionView);
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOrderIID, orderDateDataGridViewTextBoxColumn, colPaymentMethod, colCalculatedValue });
            dgvOrders.DataSource = ordersViewBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle7;
            dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrders.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrders.Location = new System.Drawing.Point(0, 88);
            dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 25;
            dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new System.Drawing.Size(670, 375);
            dgvOrders.TabIndex = 71;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // colOrderIID
            // 
            colOrderIID.DataPropertyName = "IID";
            colOrderIID.HeaderText = "IID";
            colOrderIID.Name = "colOrderIID";
            colOrderIID.ReadOnly = true;
            colOrderIID.Visible = false;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MMM/yy HH:mm:ss";
            dataGridViewCellStyle5.NullValue = null;
            orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.DataPropertyName = "Payment";
            colPaymentMethod.HeaderText = "Pymt";
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            colPaymentMethod.Width = 40;
            // 
            // colCalculatedValue
            // 
            colCalculatedValue.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            colCalculatedValue.DefaultCellStyle = dataGridViewCellStyle6;
            colCalculatedValue.HeaderText = "Total";
            colCalculatedValue.Name = "colCalculatedValue";
            colCalculatedValue.ReadOnly = true;
            colCalculatedValue.Width = 60;
            // 
            // ordersViewBindingSource
            // 
            ordersViewBindingSource.DataSource = typeof(OrdersView);
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colItemIID, Quantity, OrderItemText, coloiTaxPercent, coloiTaxValue, Price, Column1 });
            dgvOrderItems.DataSource = orderItemBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle13;
            dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrderItems.Location = new System.Drawing.Point(0, 54);
            dgvOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 25;
            dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new System.Drawing.Size(370, 409);
            dgvOrderItems.TabIndex = 0;
            // 
            // colItemIID
            // 
            colItemIID.DataPropertyName = "IID";
            colItemIID.HeaderText = "IID";
            colItemIID.Name = "colItemIID";
            colItemIID.ReadOnly = true;
            colItemIID.Visible = false;
            colItemIID.Width = 5;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle8;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 60;
            // 
            // OrderItemText
            // 
            OrderItemText.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            OrderItemText.DefaultCellStyle = dataGridViewCellStyle9;
            OrderItemText.HeaderText = "Item";
            OrderItemText.Name = "OrderItemText";
            OrderItemText.ReadOnly = true;
            OrderItemText.Width = 200;
            // 
            // coloiTaxPercent
            // 
            coloiTaxPercent.DataPropertyName = "TaxPercent";
            coloiTaxPercent.HeaderText = "%";
            coloiTaxPercent.Name = "coloiTaxPercent";
            coloiTaxPercent.ReadOnly = true;
            coloiTaxPercent.Width = 50;
            // 
            // coloiTaxValue
            // 
            coloiTaxValue.DataPropertyName = "TaxValue";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            coloiTaxValue.DefaultCellStyle = dataGridViewCellStyle10;
            coloiTaxValue.HeaderText = "Tax";
            coloiTaxValue.Name = "coloiTaxValue";
            coloiTaxValue.ReadOnly = true;
            coloiTaxValue.Width = 60;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle11;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 60;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Total";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            Column1.DefaultCellStyle = dataGridViewCellStyle12;
            Column1.HeaderText = "Total";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 60;
            // 
            // orderItemBindingSource
            // 
            orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // dgvSessionAllOrderItems
            // 
            dgvSessionAllOrderItems.AllowUserToAddRows = false;
            dgvSessionAllOrderItems.AllowUserToDeleteRows = false;
            dgvSessionAllOrderItems.AutoGenerateColumns = false;
            dgvSessionAllOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvSessionAllOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSessionAllOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvSessionAllOrderItems.DataSource = orderItemBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvSessionAllOrderItems.DefaultCellStyle = dataGridViewCellStyle18;
            dgvSessionAllOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSessionAllOrderItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvSessionAllOrderItems.Location = new System.Drawing.Point(0, 54);
            dgvSessionAllOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvSessionAllOrderItems.Name = "dgvSessionAllOrderItems";
            dgvSessionAllOrderItems.ReadOnly = true;
            dgvSessionAllOrderItems.RowHeadersWidth = 25;
            dgvSessionAllOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSessionAllOrderItems.Size = new System.Drawing.Size(300, 409);
            dgvSessionAllOrderItems.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IID";
            dataGridViewTextBoxColumn1.HeaderText = "IID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn3.HeaderText = "Item";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.AllowUserToResizeRows = false;
            dgvArchive.AutoGenerateColumns = false;
            dgvArchive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colArcIID, colArcStartDate, colArcEndDate, cellArchivedGrossTotal });
            dgvArchive.DataSource = sessionViewBindingSource;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle22;
            dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvArchive.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvArchive.Location = new System.Drawing.Point(0, 54);
            dgvArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.RowHeadersWidth = 20;
            dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.Size = new System.Drawing.Size(400, 409);
            dgvArchive.TabIndex = 2;
            dgvArchive.SelectionChanged += dgvArchive_SelectionChanged;
            // 
            // colArcIID
            // 
            colArcIID.DataPropertyName = "IID";
            colArcIID.HeaderText = "IID";
            colArcIID.Name = "colArcIID";
            colArcIID.ReadOnly = true;
            colArcIID.Visible = false;
            colArcIID.Width = 5;
            // 
            // colArcStartDate
            // 
            colArcStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colArcStartDate.DefaultCellStyle = dataGridViewCellStyle19;
            colArcStartDate.HeaderText = "Session Start @";
            colArcStartDate.Name = "colArcStartDate";
            colArcStartDate.ReadOnly = true;
            colArcStartDate.Width = 150;
            // 
            // colArcEndDate
            // 
            colArcEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Format = "dd/MM/yyyy ddd HH:mm:ss";
            colArcEndDate.DefaultCellStyle = dataGridViewCellStyle20;
            colArcEndDate.HeaderText = "Session End @";
            colArcEndDate.Name = "colArcEndDate";
            colArcEndDate.ReadOnly = true;
            colArcEndDate.Width = 150;
            // 
            // cellArchivedGrossTotal
            // 
            cellArchivedGrossTotal.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = "0";
            cellArchivedGrossTotal.DefaultCellStyle = dataGridViewCellStyle21;
            cellArchivedGrossTotal.HeaderText = "Gross Total";
            cellArchivedGrossTotal.Name = "cellArchivedGrossTotal";
            cellArchivedGrossTotal.ReadOnly = true;
            // 
            // pnlOrderItems
            // 
            pnlOrderItems.Controls.Add(dgvOrderItems);
            pnlOrderItems.Controls.Add(toolStrip2);
            pnlOrderItems.Controls.Add(toolStrip1);
            pnlOrderItems.Controls.Add(expOrderItems);
            pnlOrderItems.Dock = System.Windows.Forms.DockStyle.Left;
            pnlOrderItems.Location = new System.Drawing.Point(1630, 54);
            pnlOrderItems.MinimumSize = new System.Drawing.Size(20, 0);
            pnlOrderItems.Name = "pnlOrderItems";
            pnlOrderItems.Size = new System.Drawing.Size(400, 463);
            pnlOrderItems.TabIndex = 77;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddOrderItem, btnIncrementOrderItem, btnDecrementOrderItem, btnDeleteItem, lblOrderTotal });
            toolStrip2.Location = new System.Drawing.Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(370, 54);
            toolStrip2.TabIndex = 77;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAddOrderItem
            // 
            btnAddOrderItem.Image = Properties.Resources.arti32;
            btnAddOrderItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAddOrderItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAddOrderItem.Name = "btnAddOrderItem";
            btnAddOrderItem.Size = new System.Drawing.Size(60, 51);
            btnAddOrderItem.Text = "Add Item";
            btnAddOrderItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAddOrderItem.Click += btnAddOrderItem_Click;
            // 
            // btnIncrementOrderItem
            // 
            btnIncrementOrderItem.Image = Properties.Resources.arrow_up32;
            btnIncrementOrderItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnIncrementOrderItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnIncrementOrderItem.Name = "btnIncrementOrderItem";
            btnIncrementOrderItem.Size = new System.Drawing.Size(65, 51);
            btnIncrementOrderItem.Text = "Increment";
            btnIncrementOrderItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnIncrementOrderItem.Click += btnIncrementOrderItem_Click;
            // 
            // btnDecrementOrderItem
            // 
            btnDecrementOrderItem.Image = Properties.Resources.arrow_down32;
            btnDecrementOrderItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDecrementOrderItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDecrementOrderItem.Name = "btnDecrementOrderItem";
            btnDecrementOrderItem.Size = new System.Drawing.Size(69, 51);
            btnDecrementOrderItem.Text = "Decrement";
            btnDecrementOrderItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDecrementOrderItem.Click += btnDecrementOrderItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Image = Properties.Resources.eksi32;
            btnDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new System.Drawing.Size(71, 51);
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblOrderTotal.Image = Properties.Resources.Sigma32;
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new System.Drawing.Size(42, 51);
            lblOrderTotal.Text = "Total";
            lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblOrderTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnDeleteOrderItems });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(437, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.Visible = false;
            // 
            // btnDeleteOrderItems
            // 
            btnDeleteOrderItems.Image = Properties.Resources.Cancel;
            btnDeleteOrderItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteOrderItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteOrderItems.Name = "btnDeleteOrderItems";
            btnDeleteOrderItems.Size = new System.Drawing.Size(114, 51);
            btnDeleteOrderItems.Text = "Delete OrderItem(s)";
            btnDeleteOrderItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expOrderItems
            // 
            expOrderItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expOrderItems.Caption = "Order Items";
            expOrderItems.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expOrderItems.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            expOrderItems.CaptionForeColor = System.Drawing.Color.White;
            expOrderItems.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            expOrderItems.ColourFixed = System.Drawing.Color.Salmon;
            expOrderItems.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expOrderItems.Dock = System.Windows.Forms.DockStyle.Right;
            expOrderItems.ExpandableControl = pnlOrderItems;
            expOrderItems.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expOrderItems.Expanded = true;
            expOrderItems.Fixed = false;
            expOrderItems.Location = new System.Drawing.Point(370, 0);
            expOrderItems.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expOrderItems.LockButtonSize = new System.Drawing.Size(28, 32);
            expOrderItems.LockButtonVisible = false;
            expOrderItems.MinimumSize = new System.Drawing.Size(5, 5);
            expOrderItems.Name = "expOrderItems";
            expOrderItems.Size = new System.Drawing.Size(30, 463);
            expOrderItems.TabIndex = 76;
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(dgvOrders);
            pnlOrders.Controls.Add(pnl3661);
            pnlOrders.Controls.Add(tsSessionOrders);
            pnlOrders.Controls.Add(expOrders);
            pnlOrders.Dock = System.Windows.Forms.DockStyle.Left;
            pnlOrders.Location = new System.Drawing.Point(930, 54);
            pnlOrders.MinimumSize = new System.Drawing.Size(20, 200);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new System.Drawing.Size(700, 463);
            pnlOrders.TabIndex = 74;
            // 
            // pnl3661
            // 
            pnl3661.Controls.Add(btnLoadSelectables);
            pnl3661.Controls.Add(cmbRange);
            pnl3661.Controls.Add(btnSil);
            pnl3661.Dock = System.Windows.Forms.DockStyle.Top;
            pnl3661.Location = new System.Drawing.Point(0, 54);
            pnl3661.Name = "pnl3661";
            pnl3661.Size = new System.Drawing.Size(670, 34);
            pnl3661.TabIndex = 75;
            pnl3661.Visible = false;
            // 
            // btnLoadSelectables
            // 
            btnLoadSelectables.Location = new System.Drawing.Point(3, 3);
            btnLoadSelectables.Name = "btnLoadSelectables";
            btnLoadSelectables.Size = new System.Drawing.Size(39, 27);
            btnLoadSelectables.TabIndex = 5;
            btnLoadSelectables.Text = "L";
            btnLoadSelectables.UseVisualStyleBackColor = true;
            btnLoadSelectables.Click += btnLoadSelectables_Click;
            // 
            // cmbRange
            // 
            cmbRange.DataSource = sRangeBindingSource;
            cmbRange.DisplayMember = "DisplayValue";
            cmbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRange.FormattingEnabled = true;
            cmbRange.Location = new System.Drawing.Point(93, 3);
            cmbRange.Name = "cmbRange";
            cmbRange.Size = new System.Drawing.Size(242, 25);
            cmbRange.TabIndex = 4;
            cmbRange.ValueMember = "ItemGap";
            cmbRange.SelectedValueChanged += cmbRange_SelectedValueChanged;
            // 
            // sRangeBindingSource
            // 
            sRangeBindingSource.DataSource = typeof(SRange);
            // 
            // btnSil
            // 
            btnSil.Location = new System.Drawing.Point(48, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(39, 27);
            btnSil.TabIndex = 1;
            btnSil.Text = "S";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += tsSil_Click;
            // 
            // tsSessionOrders
            // 
            tsSessionOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { chkLoadOrders, btnChangePaymentMethodForOrder, btnDuplicateOrders, btnDeleteOrder, lblTotal, lblCash, lblCard });
            tsSessionOrders.Location = new System.Drawing.Point(0, 0);
            tsSessionOrders.Name = "tsSessionOrders";
            tsSessionOrders.Size = new System.Drawing.Size(670, 54);
            tsSessionOrders.TabIndex = 0;
            tsSessionOrders.Text = "toolStrip2";
            // 
            // chkLoadOrders
            // 
            chkLoadOrders.CheckOnClick = true;
            chkLoadOrders.Image = Properties.Resources.Unchecked;
            chkLoadOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            chkLoadOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            chkLoadOrders.Name = "chkLoadOrders";
            chkLoadOrders.Size = new System.Drawing.Size(75, 51);
            chkLoadOrders.Text = "Load Orders";
            chkLoadOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            chkLoadOrders.CheckedChanged += chkLoadOrders_CheckedChanged;
            // 
            // btnChangePaymentMethodForOrder
            // 
            btnChangePaymentMethodForOrder.Image = Properties.Resources.QuestionGreen;
            btnChangePaymentMethodForOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnChangePaymentMethodForOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnChangePaymentMethodForOrder.Name = "btnChangePaymentMethodForOrder";
            btnChangePaymentMethodForOrder.Size = new System.Drawing.Size(58, 51);
            btnChangePaymentMethodForOrder.Text = "Payment";
            btnChangePaymentMethodForOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnChangePaymentMethodForOrder.Click += btnChangePaymentMethodForOrder_Click;
            // 
            // btnDuplicateOrders
            // 
            btnDuplicateOrders.Image = Properties.Resources.Duplicate;
            btnDuplicateOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDuplicateOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDuplicateOrders.Name = "btnDuplicateOrders";
            btnDuplicateOrders.Size = new System.Drawing.Size(61, 51);
            btnDuplicateOrders.Text = "Duplicate";
            btnDuplicateOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDuplicateOrders.Visible = false;
            btnDuplicateOrders.Click += btnDuplicateOrders_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Image = Properties.Resources.Cancel;
            btnDeleteOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDeleteOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new System.Drawing.Size(90, 51);
            btnDeleteOrder.Text = "Delete Order(s)";
            btnDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDeleteOrder.Visible = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTotal.Image = Properties.Resources.Sigma32;
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTotal.Size = new System.Drawing.Size(52, 51);
            lblTotal.Text = "Total";
            lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblCash
            // 
            lblCash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCash.Image = Properties.Resources.cash32;
            lblCash.Name = "lblCash";
            lblCash.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCash.Size = new System.Drawing.Size(50, 51);
            lblCash.Text = "Cash";
            lblCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblCard
            // 
            lblCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCard.Image = Properties.Resources.card32;
            lblCard.Name = "lblCard";
            lblCard.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCard.Size = new System.Drawing.Size(51, 51);
            lblCard.Text = "Card";
            lblCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expOrders
            // 
            expOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expOrders.Caption = "Orders";
            expOrders.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expOrders.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            expOrders.CaptionForeColor = System.Drawing.Color.White;
            expOrders.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            expOrders.ColourFixed = System.Drawing.Color.Salmon;
            expOrders.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expOrders.Dock = System.Windows.Forms.DockStyle.Right;
            expOrders.ExpandableControl = pnlOrders;
            expOrders.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expOrders.Expanded = true;
            expOrders.Fixed = false;
            expOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            expOrders.Location = new System.Drawing.Point(670, 0);
            expOrders.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expOrders.LockButtonSize = new System.Drawing.Size(28, 32);
            expOrders.LockButtonVisible = false;
            expOrders.MinimumSize = new System.Drawing.Size(5, 18);
            expOrders.Name = "expOrders";
            expOrders.Size = new System.Drawing.Size(30, 463);
            expOrders.TabIndex = 75;
            // 
            // pnlItemsGrouped
            // 
            pnlItemsGrouped.Controls.Add(dgvSessionAllOrderItems);
            pnlItemsGrouped.Controls.Add(tsGroupedItems);
            pnlItemsGrouped.Controls.Add(expItemsGrouped);
            pnlItemsGrouped.Dock = System.Windows.Forms.DockStyle.Left;
            pnlItemsGrouped.Location = new System.Drawing.Point(2030, 54);
            pnlItemsGrouped.Name = "pnlItemsGrouped";
            pnlItemsGrouped.Size = new System.Drawing.Size(330, 463);
            pnlItemsGrouped.TabIndex = 2;
            // 
            // tsGroupedItems
            // 
            tsGroupedItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnGroupExport, btnGroupEmail, btnGroupPrint, chkLoadAllItems });
            tsGroupedItems.Location = new System.Drawing.Point(0, 0);
            tsGroupedItems.Name = "tsGroupedItems";
            tsGroupedItems.Size = new System.Drawing.Size(300, 54);
            tsGroupedItems.TabIndex = 0;
            tsGroupedItems.Text = "toolStrip1";
            // 
            // btnGroupExport
            // 
            btnGroupExport.Image = Properties.Resources.Export32;
            btnGroupExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnGroupExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnGroupExport.Name = "btnGroupExport";
            btnGroupExport.Size = new System.Drawing.Size(56, 51);
            btnGroupExport.Text = "  Export  ";
            btnGroupExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnGroupExport.Click += btnGroupExport_Click;
            // 
            // btnGroupEmail
            // 
            btnGroupEmail.Image = Properties.Resources.mektup32;
            btnGroupEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnGroupEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnGroupEmail.Name = "btnGroupEmail";
            btnGroupEmail.Size = new System.Drawing.Size(52, 51);
            btnGroupEmail.Text = "  Email  ";
            btnGroupEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnGroupEmail.Click += btnGroupEmail_Click;
            // 
            // btnGroupPrint
            // 
            btnGroupPrint.Image = Properties.Resources.Printer32;
            btnGroupPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnGroupPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnGroupPrint.Name = "btnGroupPrint";
            btnGroupPrint.Size = new System.Drawing.Size(48, 51);
            btnGroupPrint.Text = "  Print  ";
            btnGroupPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnGroupPrint.Click += btnGroupPrint_Click;
            // 
            // chkLoadAllItems
            // 
            chkLoadAllItems.CheckOnClick = true;
            chkLoadAllItems.Image = Properties.Resources.Unchecked;
            chkLoadAllItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            chkLoadAllItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            chkLoadAllItems.Name = "chkLoadAllItems";
            chkLoadAllItems.Size = new System.Drawing.Size(69, 51);
            chkLoadAllItems.Text = "Load Items";
            chkLoadAllItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            chkLoadAllItems.CheckedChanged += chkLoadAllItems_CheckedChanged;
            // 
            // expItemsGrouped
            // 
            expItemsGrouped.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expItemsGrouped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expItemsGrouped.Caption = "Session ALL Items Grouped";
            expItemsGrouped.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expItemsGrouped.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            expItemsGrouped.CaptionForeColor = System.Drawing.Color.White;
            expItemsGrouped.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            expItemsGrouped.ColourFixed = System.Drawing.Color.Salmon;
            expItemsGrouped.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expItemsGrouped.Dock = System.Windows.Forms.DockStyle.Right;
            expItemsGrouped.ExpandableControl = pnlItemsGrouped;
            expItemsGrouped.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expItemsGrouped.Expanded = true;
            expItemsGrouped.Fixed = false;
            expItemsGrouped.Location = new System.Drawing.Point(300, 0);
            expItemsGrouped.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expItemsGrouped.LockButtonSize = new System.Drawing.Size(28, 32);
            expItemsGrouped.LockButtonVisible = false;
            expItemsGrouped.MinimumSize = new System.Drawing.Size(5, 5);
            expItemsGrouped.Name = "expItemsGrouped";
            expItemsGrouped.Size = new System.Drawing.Size(30, 463);
            expItemsGrouped.TabIndex = 2;
            // 
            // pnlSessions
            // 
            pnlSessions.Controls.Add(dgvDatabase);
            pnlSessions.Controls.Add(tsSessions2);
            pnlSessions.Controls.Add(tsSessions);
            pnlSessions.Controls.Add(expSessions);
            pnlSessions.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSessions.Location = new System.Drawing.Point(430, 54);
            pnlSessions.MinimumSize = new System.Drawing.Size(20, 0);
            pnlSessions.Name = "pnlSessions";
            pnlSessions.Size = new System.Drawing.Size(500, 463);
            pnlSessions.TabIndex = 72;
            // 
            // tsSessions2
            // 
            tsSessions2.Dock = System.Windows.Forms.DockStyle.Bottom;
            tsSessions2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionDBExport, btnSessionDBEmail, btnSessionDBPrint });
            tsSessions2.Location = new System.Drawing.Point(0, 409);
            tsSessions2.Name = "tsSessions2";
            tsSessions2.Size = new System.Drawing.Size(470, 54);
            tsSessions2.TabIndex = 74;
            tsSessions2.Text = "toolStrip2";
            // 
            // btnSessionDBExport
            // 
            btnSessionDBExport.Image = Properties.Resources.Export32;
            btnSessionDBExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionDBExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionDBExport.Name = "btnSessionDBExport";
            btnSessionDBExport.Size = new System.Drawing.Size(108, 51);
            btnSessionDBExport.Text = "Export All Sessions";
            btnSessionDBExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionDBExport.Click += btnSessionDBExport_Click;
            // 
            // btnSessionDBEmail
            // 
            btnSessionDBEmail.Image = Properties.Resources.mektup32;
            btnSessionDBEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionDBEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionDBEmail.Name = "btnSessionDBEmail";
            btnSessionDBEmail.Size = new System.Drawing.Size(104, 51);
            btnSessionDBEmail.Text = "Email All Sessions";
            btnSessionDBEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionDBEmail.Click += btnSessionDBEmail_Click;
            // 
            // btnSessionDBPrint
            // 
            btnSessionDBPrint.Image = Properties.Resources.Printer32;
            btnSessionDBPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionDBPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionDBPrint.Name = "btnSessionDBPrint";
            btnSessionDBPrint.Size = new System.Drawing.Size(73, 51);
            btnSessionDBPrint.Text = "Print As List";
            btnSessionDBPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionDBPrint.Click += btnSessionDBPrint_Click;
            // 
            // tsSessions
            // 
            tsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionDBReload, btnArchiveSessions, btnPrintReport, chkDynamicSessionTotals, lblAllSessionTotal });
            tsSessions.Location = new System.Drawing.Point(0, 0);
            tsSessions.Name = "tsSessions";
            tsSessions.Size = new System.Drawing.Size(470, 54);
            tsSessions.TabIndex = 0;
            tsSessions.Text = "toolStrip1";
            // 
            // btnSessionDBReload
            // 
            btnSessionDBReload.Image = Properties.Resources.Reload_32;
            btnSessionDBReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionDBReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionDBReload.Name = "btnSessionDBReload";
            btnSessionDBReload.Size = new System.Drawing.Size(94, 51);
            btnSessionDBReload.Text = "Reload Sessions";
            btnSessionDBReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionDBReload.Click += btnSessionDBReload_Click;
            // 
            // btnArchiveSessions
            // 
            btnArchiveSessions.Image = Properties.Resources.DBToFolder32;
            btnArchiveSessions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnArchiveSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnArchiveSessions.Name = "btnArchiveSessions";
            btnArchiveSessions.Size = new System.Drawing.Size(98, 51);
            btnArchiveSessions.Text = "Archive Sessions";
            btnArchiveSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnArchiveSessions.Click += btnArchiveSessions_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Image = Properties.Resources.Printer32;
            btnPrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new System.Drawing.Size(97, 51);
            btnPrintReport.Text = "Print Z Report(s)";
            btnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // chkDynamicSessionTotals
            // 
            chkDynamicSessionTotals.CheckOnClick = true;
            chkDynamicSessionTotals.Image = Properties.Resources.Unchecked;
            chkDynamicSessionTotals.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            chkDynamicSessionTotals.ImageTransparentColor = System.Drawing.Color.Magenta;
            chkDynamicSessionTotals.Name = "chkDynamicSessionTotals";
            chkDynamicSessionTotals.Size = new System.Drawing.Size(92, 51);
            chkDynamicSessionTotals.Text = "Dynamic Totals";
            chkDynamicSessionTotals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            chkDynamicSessionTotals.Click += chkDynamicSessionTotals_Click;
            // 
            // lblAllSessionTotal
            // 
            lblAllSessionTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAllSessionTotal.Image = Properties.Resources.Sigma32;
            lblAllSessionTotal.Name = "lblAllSessionTotal";
            lblAllSessionTotal.Size = new System.Drawing.Size(42, 51);
            lblAllSessionTotal.Text = "Total";
            lblAllSessionTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lblAllSessionTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expSessions
            // 
            expSessions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expSessions.Caption = "Sessions";
            expSessions.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expSessions.CaptionFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            expSessions.CaptionForeColor = System.Drawing.Color.White;
            expSessions.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            expSessions.ColourFixed = System.Drawing.Color.Salmon;
            expSessions.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expSessions.Dock = System.Windows.Forms.DockStyle.Right;
            expSessions.ExpandableControl = pnlSessions;
            expSessions.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expSessions.Expanded = true;
            expSessions.Fixed = false;
            expSessions.Location = new System.Drawing.Point(470, 0);
            expSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            expSessions.LockButtonVisible = false;
            expSessions.MinimumSize = new System.Drawing.Size(20, 5);
            expSessions.Name = "expSessions";
            expSessions.Size = new System.Drawing.Size(30, 463);
            expSessions.TabIndex = 73;
            // 
            // pnlArchivedSessions
            // 
            pnlArchivedSessions.Controls.Add(dgvArchive);
            pnlArchivedSessions.Controls.Add(tsArchivedSessions);
            pnlArchivedSessions.Controls.Add(expArchivedSessions);
            pnlArchivedSessions.Dock = System.Windows.Forms.DockStyle.Left;
            pnlArchivedSessions.Location = new System.Drawing.Point(0, 54);
            pnlArchivedSessions.MinimumSize = new System.Drawing.Size(20, 0);
            pnlArchivedSessions.Name = "pnlArchivedSessions";
            pnlArchivedSessions.Size = new System.Drawing.Size(430, 463);
            pnlArchivedSessions.TabIndex = 3;
            // 
            // tsArchivedSessions
            // 
            tsArchivedSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionARCExport, btnSessionARCEmail, btnSessionARCPrint, btnSessionARCReload, btnLoadSessions, lblArchivedSelectedTotal });
            tsArchivedSessions.Location = new System.Drawing.Point(0, 0);
            tsArchivedSessions.Name = "tsArchivedSessions";
            tsArchivedSessions.Size = new System.Drawing.Size(400, 54);
            tsArchivedSessions.TabIndex = 0;
            tsArchivedSessions.Text = "toolStrip1";
            // 
            // btnSessionARCExport
            // 
            btnSessionARCExport.Image = Properties.Resources.Export32;
            btnSessionARCExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionARCExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionARCExport.Name = "btnSessionARCExport";
            btnSessionARCExport.Size = new System.Drawing.Size(56, 51);
            btnSessionARCExport.Text = "  Export  ";
            btnSessionARCExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionARCExport.Click += btnSessionARCExport_Click;
            // 
            // btnSessionARCEmail
            // 
            btnSessionARCEmail.Image = Properties.Resources.mektup32;
            btnSessionARCEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionARCEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionARCEmail.Name = "btnSessionARCEmail";
            btnSessionARCEmail.Size = new System.Drawing.Size(52, 51);
            btnSessionARCEmail.Text = "  Email  ";
            btnSessionARCEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionARCEmail.Click += btnSessionARCEmail_Click;
            // 
            // btnSessionARCPrint
            // 
            btnSessionARCPrint.Image = Properties.Resources.Printer32;
            btnSessionARCPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionARCPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionARCPrint.Name = "btnSessionARCPrint";
            btnSessionARCPrint.Size = new System.Drawing.Size(48, 51);
            btnSessionARCPrint.Text = "  Print  ";
            btnSessionARCPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionARCPrint.Click += btnSessionARCPrint_Click;
            // 
            // btnSessionARCReload
            // 
            btnSessionARCReload.Image = Properties.Resources.Reload_32;
            btnSessionARCReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSessionARCReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSessionARCReload.Name = "btnSessionARCReload";
            btnSessionARCReload.Size = new System.Drawing.Size(47, 51);
            btnSessionARCReload.Text = "Reload";
            btnSessionARCReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSessionARCReload.Click += btnSessionARCReload_Click;
            // 
            // btnLoadSessions
            // 
            btnLoadSessions.Image = Properties.Resources.FolderToDB32;
            btnLoadSessions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoadSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadSessions.Name = "btnLoadSessions";
            btnLoadSessions.Size = new System.Drawing.Size(84, 51);
            btnLoadSessions.Text = "Load Sessions";
            btnLoadSessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadSessions.Click += btnLoadSessions_Click;
            // 
            // lblArchivedSelectedTotal
            // 
            lblArchivedSelectedTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblArchivedSelectedTotal.Image = Properties.Resources.Sigma32;
            lblArchivedSelectedTotal.Name = "lblArchivedSelectedTotal";
            lblArchivedSelectedTotal.Size = new System.Drawing.Size(42, 51);
            lblArchivedSelectedTotal.Text = "Total";
            lblArchivedSelectedTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // expArchivedSessions
            // 
            expArchivedSessions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expArchivedSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expArchivedSessions.Caption = "Archived Sessions";
            expArchivedSessions.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expArchivedSessions.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            expArchivedSessions.CaptionForeColor = System.Drawing.Color.White;
            expArchivedSessions.CaptionOrientation = System.Windows.Forms.Orientation.Vertical;
            expArchivedSessions.ColourFixed = System.Drawing.Color.Salmon;
            expArchivedSessions.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expArchivedSessions.Dock = System.Windows.Forms.DockStyle.Right;
            expArchivedSessions.ExpandableControl = pnlArchivedSessions;
            expArchivedSessions.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expArchivedSessions.Expanded = true;
            expArchivedSessions.Fixed = false;
            expArchivedSessions.Location = new System.Drawing.Point(400, 0);
            expArchivedSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expArchivedSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            expArchivedSessions.LockButtonVisible = false;
            expArchivedSessions.MinimumSize = new System.Drawing.Size(5, 5);
            expArchivedSessions.Name = "expArchivedSessions";
            expArchivedSessions.Size = new System.Drawing.Size(30, 463);
            expArchivedSessions.TabIndex = 3;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnReload, btnGenerateTaxReport, btnEmailTaxReport, btnLoadSessionsFromDirectory, btnArchiveSessionToSpecialDirectory, btnEnsureSessionData, btnCheck });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(2528, 54);
            barMain.TabIndex = 13;
            barMain.Text = "toolStrip1";
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Reload_32;
            btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(47, 51);
            btnReload.Text = "Reload";
            btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReload.Click += btnReload_Click;
            // 
            // btnGenerateTaxReport
            // 
            btnGenerateTaxReport.Image = Properties.Resources.documan_cizgili32;
            btnGenerateTaxReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnGenerateTaxReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnGenerateTaxReport.Name = "btnGenerateTaxReport";
            btnGenerateTaxReport.Size = new System.Drawing.Size(102, 51);
            btnGenerateTaxReport.Text = "Export Tax Report";
            btnGenerateTaxReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnGenerateTaxReport.Click += btnGenerateTaxReport_Click;
            // 
            // btnEmailTaxReport
            // 
            btnEmailTaxReport.Image = Properties.Resources.mektup32;
            btnEmailTaxReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEmailTaxReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEmailTaxReport.Name = "btnEmailTaxReport";
            btnEmailTaxReport.Size = new System.Drawing.Size(98, 51);
            btnEmailTaxReport.Text = "Email Tax Report";
            btnEmailTaxReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEmailTaxReport.Click += btnEmailTaxReport_Click;
            // 
            // btnLoadSessionsFromDirectory
            // 
            btnLoadSessionsFromDirectory.Image = Properties.Resources.FolderToDBPlus32;
            btnLoadSessionsFromDirectory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnLoadSessionsFromDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLoadSessionsFromDirectory.Name = "btnLoadSessionsFromDirectory";
            btnLoadSessionsFromDirectory.Size = new System.Drawing.Size(119, 51);
            btnLoadSessionsFromDirectory.Text = "Load From Directory";
            btnLoadSessionsFromDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLoadSessionsFromDirectory.Click += btnLoadSessionsFromDirectory_Click;
            // 
            // btnArchiveSessionToSpecialDirectory
            // 
            btnArchiveSessionToSpecialDirectory.Image = Properties.Resources.DBToFolderPlus32;
            btnArchiveSessionToSpecialDirectory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnArchiveSessionToSpecialDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnArchiveSessionToSpecialDirectory.Name = "btnArchiveSessionToSpecialDirectory";
            btnArchiveSessionToSpecialDirectory.Size = new System.Drawing.Size(118, 51);
            btnArchiveSessionToSpecialDirectory.Text = "Archive To Directory";
            btnArchiveSessionToSpecialDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnArchiveSessionToSpecialDirectory.Click += btnArchiveSessionToSpecialDirectory_Click;
            // 
            // btnEnsureSessionData
            // 
            btnEnsureSessionData.Image = Properties.Resources.tickgreen;
            btnEnsureSessionData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEnsureSessionData.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEnsureSessionData.Name = "btnEnsureSessionData";
            btnEnsureSessionData.Size = new System.Drawing.Size(115, 51);
            btnEnsureSessionData.Text = "Ensure Session Data";
            btnEnsureSessionData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCheck
            // 
            btnCheck.AutoSize = false;
            btnCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new System.Drawing.Size(50, 51);
            btnCheck.Text = "toolStripButton2";
            btnCheck.Click += btnCheck_Click;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = null;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewTextBoxColumn7.HeaderText = "Item";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewTextBoxColumn8.HeaderText = "Price";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "IID";
            dataGridViewTextBoxColumn9.HeaderText = "IID";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "IID";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.Format = "dd/MM/yyyy ddd HH:mm:ss";
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewTextBoxColumn10.HeaderText = "IID";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "OrderDate";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.Format = "F";
            dataGridViewCellStyle27.NullValue = null;
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewTextBoxColumn11.HeaderText = "OrderDate";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = null;
            dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewTextBoxColumn12.HeaderText = "Total";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "IID";
            dataGridViewTextBoxColumn13.HeaderText = "IID";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "Quantity";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewTextBoxColumn14.HeaderText = "Quantity";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle30;
            dataGridViewTextBoxColumn15.HeaderText = "Item";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "Price";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "N2";
            dataGridViewCellStyle31.NullValue = null;
            dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewTextBoxColumn16.HeaderText = "Price";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Width = 60;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Total";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewCellStyle32.NullValue = null;
            dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle32;
            dataGridViewTextBoxColumn17.HeaderText = "Total";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Visible = false;
            dataGridViewTextBoxColumn17.Width = 60;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "IID";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.Format = "N2";
            dataGridViewCellStyle33.NullValue = null;
            dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle33;
            dataGridViewTextBoxColumn18.HeaderText = "IID";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Visible = false;
            dataGridViewTextBoxColumn18.Width = 60;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "StartDate";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.Format = "dd/MM/yyyy ddd HH:mm:ss";
            dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewTextBoxColumn19.HeaderText = "Session Start @";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.Visible = false;
            dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "EndDate";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.Format = "dd/MM/yyyy ddd HH:mm:ss";
            dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewTextBoxColumn20.HeaderText = "Session End @";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "GrossSessionTotal";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N2";
            dataGridViewCellStyle36.NullValue = "0";
            dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle36;
            dataGridViewTextBoxColumn21.HeaderText = "Gross Total";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            dataGridViewTextBoxColumn21.Width = 200;
            // 
            // frmSessionReports
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2528, 517);
            Controls.Add(pnlItemsGrouped);
            Controls.Add(pnlOrderItems);
            Controls.Add(pnlOrders);
            Controls.Add(pnlSessions);
            Controls.Add(pnlArchivedSessions);
            Controls.Add(barMain);
            Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmSessionReports";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Session Reports";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmSessionReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSessionAllOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            pnlOrderItems.ResumeLayout(false);
            pnlOrderItems.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnl3661.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sRangeBindingSource).EndInit();
            tsSessionOrders.ResumeLayout(false);
            tsSessionOrders.PerformLayout();
            pnlItemsGrouped.ResumeLayout(false);
            pnlItemsGrouped.PerformLayout();
            tsGroupedItems.ResumeLayout(false);
            tsGroupedItems.PerformLayout();
            pnlSessions.ResumeLayout(false);
            pnlSessions.PerformLayout();
            tsSessions2.ResumeLayout(false);
            tsSessions2.PerformLayout();
            tsSessions.ResumeLayout(false);
            tsSessions.PerformLayout();
            pnlArchivedSessions.ResumeLayout(false);
            pnlArchivedSessions.PerformLayout();
            tsArchivedSessions.ResumeLayout(false);
            tsArchivedSessions.PerformLayout();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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