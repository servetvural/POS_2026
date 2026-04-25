using POSLayer.Models;
using POSLayer.Views;

namespace POSOffice {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionReports));
            dgvDatabase = new System.Windows.Forms.DataGridView();
            startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sessionBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvOrders = new System.Windows.Forms.DataGridView();
            orderBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvOrderItems = new System.Windows.Forms.DataGridView();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderItemTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taxPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderItemBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvSessionAllOrderItems = new System.Windows.Forms.DataGridView();
            quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderItemTextDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taxPercentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalVatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvArchive = new System.Windows.Forms.DataGridView();
            startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
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
            dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dgvDatabase.DataSource = sessionBindingSource;
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
            dgvDatabase.Size = new System.Drawing.Size(450, 630);
            dgvDatabase.TabIndex = 1;
            dgvDatabase.SelectionChanged += dgvDatabase_SelectionChanged;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy ddd HH:mm:ss";
            startDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            startDateDataGridViewTextBoxColumn.HeaderText = "Session Start @";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy ddd HH:mm:ss";
            endDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            endDateDataGridViewTextBoxColumn.HeaderText = "Session End @";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // sessionBindingSource
            // 
            sessionBindingSource.DataSource = typeof(Session);
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderDateDataGridViewTextBoxColumn, paymentDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn2 });
            dgvOrders.DataSource = orderBindingSource;
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
            dgvOrders.Size = new System.Drawing.Size(420, 650);
            dgvOrders.TabIndex = 71;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvOrderItems.ColumnHeadersHeight = 25;
            dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, orderItemTextDataGridViewTextBoxColumn, taxPercentDataGridViewTextBoxColumn, totalVatDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn3 });
            dgvOrderItems.DataSource = orderItemBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle12;
            dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrderItems.Location = new System.Drawing.Point(0, 54);
            dgvOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 25;
            dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new System.Drawing.Size(630, 684);
            dgvOrderItems.TabIndex = 0;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderItemTextDataGridViewTextBoxColumn
            // 
            orderItemTextDataGridViewTextBoxColumn.DataPropertyName = "OrderItemText";
            orderItemTextDataGridViewTextBoxColumn.HeaderText = "Order Item";
            orderItemTextDataGridViewTextBoxColumn.Name = "orderItemTextDataGridViewTextBoxColumn";
            orderItemTextDataGridViewTextBoxColumn.ReadOnly = true;
            orderItemTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // taxPercentDataGridViewTextBoxColumn
            // 
            taxPercentDataGridViewTextBoxColumn.DataPropertyName = "TaxPercent";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "\"%\" 0.00";
            taxPercentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            taxPercentDataGridViewTextBoxColumn.HeaderText = "Tax %";
            taxPercentDataGridViewTextBoxColumn.Name = "taxPercentDataGridViewTextBoxColumn";
            taxPercentDataGridViewTextBoxColumn.ReadOnly = true;
            taxPercentDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalVatDataGridViewTextBoxColumn
            // 
            totalVatDataGridViewTextBoxColumn.DataPropertyName = "TotalVat";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            totalVatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            totalVatDataGridViewTextBoxColumn.HeaderText = "Tax";
            totalVatDataGridViewTextBoxColumn.Name = "totalVatDataGridViewTextBoxColumn";
            totalVatDataGridViewTextBoxColumn.ReadOnly = true;
            totalVatDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn3
            // 
            totalDataGridViewTextBoxColumn3.DataPropertyName = "Total";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            totalDataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            totalDataGridViewTextBoxColumn3.HeaderText = "Total";
            totalDataGridViewTextBoxColumn3.Name = "totalDataGridViewTextBoxColumn3";
            totalDataGridViewTextBoxColumn3.ReadOnly = true;
            totalDataGridViewTextBoxColumn3.Width = 80;
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
            dgvSessionAllOrderItems.ColumnHeadersHeight = 25;
            dgvSessionAllOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { quantityDataGridViewTextBoxColumn1, orderItemTextDataGridViewTextBoxColumn1, taxPercentDataGridViewTextBoxColumn1, totalVatDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn4 });
            dgvSessionAllOrderItems.DataSource = orderItemBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvSessionAllOrderItems.DefaultCellStyle = dataGridViewCellStyle17;
            dgvSessionAllOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSessionAllOrderItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvSessionAllOrderItems.Location = new System.Drawing.Point(0, 54);
            dgvSessionAllOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvSessionAllOrderItems.Name = "dgvSessionAllOrderItems";
            dgvSessionAllOrderItems.ReadOnly = true;
            dgvSessionAllOrderItems.RowHeadersWidth = 25;
            dgvSessionAllOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSessionAllOrderItems.Size = new System.Drawing.Size(630, 684);
            dgvSessionAllOrderItems.TabIndex = 1;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Qty";
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            quantityDataGridViewTextBoxColumn1.Width = 50;
            // 
            // orderItemTextDataGridViewTextBoxColumn1
            // 
            orderItemTextDataGridViewTextBoxColumn1.DataPropertyName = "OrderItemText";
            orderItemTextDataGridViewTextBoxColumn1.HeaderText = "Order Item";
            orderItemTextDataGridViewTextBoxColumn1.Name = "orderItemTextDataGridViewTextBoxColumn1";
            orderItemTextDataGridViewTextBoxColumn1.ReadOnly = true;
            orderItemTextDataGridViewTextBoxColumn1.Width = 200;
            // 
            // taxPercentDataGridViewTextBoxColumn1
            // 
            taxPercentDataGridViewTextBoxColumn1.DataPropertyName = "TaxPercent";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "\"%\" 0.00";
            taxPercentDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            taxPercentDataGridViewTextBoxColumn1.HeaderText = "Tax %";
            taxPercentDataGridViewTextBoxColumn1.Name = "taxPercentDataGridViewTextBoxColumn1";
            taxPercentDataGridViewTextBoxColumn1.ReadOnly = true;
            taxPercentDataGridViewTextBoxColumn1.Width = 80;
            // 
            // totalVatDataGridViewTextBoxColumn1
            // 
            totalVatDataGridViewTextBoxColumn1.DataPropertyName = "TotalVat";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            totalVatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            totalVatDataGridViewTextBoxColumn1.HeaderText = "Tax";
            totalVatDataGridViewTextBoxColumn1.Name = "totalVatDataGridViewTextBoxColumn1";
            totalVatDataGridViewTextBoxColumn1.ReadOnly = true;
            totalVatDataGridViewTextBoxColumn1.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.ReadOnly = true;
            priceDataGridViewTextBoxColumn1.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn4
            // 
            totalDataGridViewTextBoxColumn4.DataPropertyName = "Total";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            totalDataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            totalDataGridViewTextBoxColumn4.HeaderText = "Total";
            totalDataGridViewTextBoxColumn4.Name = "totalDataGridViewTextBoxColumn4";
            totalDataGridViewTextBoxColumn4.ReadOnly = true;
            totalDataGridViewTextBoxColumn4.Width = 80;
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.AllowUserToResizeRows = false;
            dgvArchive.AutoGenerateColumns = false;
            dgvArchive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { startDateDataGridViewTextBoxColumn1, endDateDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn1 });
            dgvArchive.DataSource = sessionBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle21;
            dgvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvArchive.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvArchive.Location = new System.Drawing.Point(0, 54);
            dgvArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.RowHeadersWidth = 20;
            dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.Size = new System.Drawing.Size(450, 684);
            dgvArchive.TabIndex = 2;
            dgvArchive.SelectionChanged += dgvArchive_SelectionChanged;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            startDateDataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.Format = "dd/MM/yyyy ddd HH:mm:ss";
            startDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            startDateDataGridViewTextBoxColumn1.HeaderText = "Session Start @";
            startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            startDateDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            startDateDataGridViewTextBoxColumn1.Width = 160;
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.Format = "dd/MM/yyyy ddd HH:mm:ss";
            endDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle19;
            endDateDataGridViewTextBoxColumn1.HeaderText = "Session End @";
            endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            endDateDataGridViewTextBoxColumn1.ReadOnly = true;
            endDateDataGridViewTextBoxColumn1.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            dataGridViewCellStyle20.Format = "N2";
            totalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.ReadOnly = true;
            totalDataGridViewTextBoxColumn1.Width = 80;
            // 
            // pnlOrderItems
            // 
            pnlOrderItems.Controls.Add(dgvOrderItems);
            pnlOrderItems.Controls.Add(toolStrip2);
            pnlOrderItems.Controls.Add(toolStrip1);
            pnlOrderItems.Controls.Add(expOrderItems);
            pnlOrderItems.Dock = System.Windows.Forms.DockStyle.Left;
            pnlOrderItems.Location = new System.Drawing.Point(1410, 54);
            pnlOrderItems.MinimumSize = new System.Drawing.Size(20, 0);
            pnlOrderItems.Name = "pnlOrderItems";
            pnlOrderItems.Size = new System.Drawing.Size(660, 738);
            pnlOrderItems.TabIndex = 77;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddOrderItem, btnIncrementOrderItem, btnDecrementOrderItem, btnDeleteItem, lblOrderTotal });
            toolStrip2.Location = new System.Drawing.Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(630, 54);
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
            expOrderItems.Location = new System.Drawing.Point(630, 0);
            expOrderItems.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expOrderItems.LockButtonSize = new System.Drawing.Size(28, 32);
            expOrderItems.LockButtonVisible = false;
            expOrderItems.MinimumSize = new System.Drawing.Size(5, 5);
            expOrderItems.Name = "expOrderItems";
            expOrderItems.Size = new System.Drawing.Size(30, 738);
            expOrderItems.TabIndex = 76;
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(dgvOrders);
            pnlOrders.Controls.Add(pnl3661);
            pnlOrders.Controls.Add(tsSessionOrders);
            pnlOrders.Controls.Add(expOrders);
            pnlOrders.Dock = System.Windows.Forms.DockStyle.Left;
            pnlOrders.Location = new System.Drawing.Point(960, 54);
            pnlOrders.MinimumSize = new System.Drawing.Size(20, 200);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new System.Drawing.Size(450, 738);
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
            pnl3661.Size = new System.Drawing.Size(420, 34);
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
            tsSessionOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnChangePaymentMethodForOrder, btnDuplicateOrders, btnDeleteOrder, lblTotal, lblCash, lblCard });
            tsSessionOrders.Location = new System.Drawing.Point(0, 0);
            tsSessionOrders.Name = "tsSessionOrders";
            tsSessionOrders.Size = new System.Drawing.Size(420, 54);
            tsSessionOrders.TabIndex = 0;
            tsSessionOrders.Text = "toolStrip2";
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
            expOrders.Location = new System.Drawing.Point(420, 0);
            expOrders.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expOrders.LockButtonSize = new System.Drawing.Size(28, 32);
            expOrders.LockButtonVisible = false;
            expOrders.MinimumSize = new System.Drawing.Size(5, 18);
            expOrders.Name = "expOrders";
            expOrders.Size = new System.Drawing.Size(30, 738);
            expOrders.TabIndex = 75;
            // 
            // pnlItemsGrouped
            // 
            pnlItemsGrouped.Controls.Add(dgvSessionAllOrderItems);
            pnlItemsGrouped.Controls.Add(tsGroupedItems);
            pnlItemsGrouped.Controls.Add(expItemsGrouped);
            pnlItemsGrouped.Dock = System.Windows.Forms.DockStyle.Left;
            pnlItemsGrouped.Location = new System.Drawing.Point(2070, 54);
            pnlItemsGrouped.Name = "pnlItemsGrouped";
            pnlItemsGrouped.Size = new System.Drawing.Size(660, 738);
            pnlItemsGrouped.TabIndex = 2;
            // 
            // tsGroupedItems
            // 
            tsGroupedItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnGroupExport, btnGroupEmail, btnGroupPrint, chkLoadAllItems });
            tsGroupedItems.Location = new System.Drawing.Point(0, 0);
            tsGroupedItems.Name = "tsGroupedItems";
            tsGroupedItems.Size = new System.Drawing.Size(630, 54);
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
            expItemsGrouped.Location = new System.Drawing.Point(630, 0);
            expItemsGrouped.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expItemsGrouped.LockButtonSize = new System.Drawing.Size(28, 32);
            expItemsGrouped.LockButtonVisible = false;
            expItemsGrouped.MinimumSize = new System.Drawing.Size(5, 5);
            expItemsGrouped.Name = "expItemsGrouped";
            expItemsGrouped.Size = new System.Drawing.Size(30, 738);
            expItemsGrouped.TabIndex = 2;
            // 
            // pnlSessions
            // 
            pnlSessions.Controls.Add(dgvDatabase);
            pnlSessions.Controls.Add(tsSessions2);
            pnlSessions.Controls.Add(tsSessions);
            pnlSessions.Controls.Add(expSessions);
            pnlSessions.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSessions.Location = new System.Drawing.Point(480, 54);
            pnlSessions.MinimumSize = new System.Drawing.Size(20, 0);
            pnlSessions.Name = "pnlSessions";
            pnlSessions.Size = new System.Drawing.Size(480, 738);
            pnlSessions.TabIndex = 72;
            // 
            // tsSessions2
            // 
            tsSessions2.Dock = System.Windows.Forms.DockStyle.Bottom;
            tsSessions2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionDBExport, btnSessionDBEmail, btnSessionDBPrint });
            tsSessions2.Location = new System.Drawing.Point(0, 684);
            tsSessions2.Name = "tsSessions2";
            tsSessions2.Size = new System.Drawing.Size(450, 54);
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
            tsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionDBReload, btnArchiveSessions, btnPrintReport, lblAllSessionTotal });
            tsSessions.Location = new System.Drawing.Point(0, 0);
            tsSessions.Name = "tsSessions";
            tsSessions.Size = new System.Drawing.Size(450, 54);
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
            expSessions.Location = new System.Drawing.Point(450, 0);
            expSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            expSessions.LockButtonVisible = false;
            expSessions.MinimumSize = new System.Drawing.Size(20, 5);
            expSessions.Name = "expSessions";
            expSessions.Size = new System.Drawing.Size(30, 738);
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
            pnlArchivedSessions.Size = new System.Drawing.Size(480, 738);
            pnlArchivedSessions.TabIndex = 3;
            // 
            // tsArchivedSessions
            // 
            tsArchivedSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSessionARCExport, btnSessionARCEmail, btnSessionARCPrint, btnSessionARCReload, btnLoadSessions, lblArchivedSelectedTotal });
            tsArchivedSessions.Location = new System.Drawing.Point(0, 0);
            tsArchivedSessions.Name = "tsArchivedSessions";
            tsArchivedSessions.Size = new System.Drawing.Size(450, 54);
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
            expArchivedSessions.Location = new System.Drawing.Point(450, 0);
            expArchivedSessions.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expArchivedSessions.LockButtonSize = new System.Drawing.Size(28, 32);
            expArchivedSessions.LockButtonVisible = false;
            expArchivedSessions.MinimumSize = new System.Drawing.Size(5, 5);
            expArchivedSessions.Name = "expArchivedSessions";
            expArchivedSessions.Size = new System.Drawing.Size(30, 738);
            expArchivedSessions.TabIndex = 3;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnReload, btnGenerateTaxReport, btnEmailTaxReport, btnLoadSessionsFromDirectory, btnArchiveSessionToSpecialDirectory, btnEnsureSessionData, btnCheck });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(2828, 54);
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
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MMM/yy ddd HH:mm:ss";
            orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn2
            // 
            totalDataGridViewTextBoxColumn2.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            totalDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            totalDataGridViewTextBoxColumn2.HeaderText = "Total";
            totalDataGridViewTextBoxColumn2.Name = "totalDataGridViewTextBoxColumn2";
            totalDataGridViewTextBoxColumn2.ReadOnly = true;
            totalDataGridViewTextBoxColumn2.Width = 80;
            // 
            // frmSessionReports
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2828, 792);
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
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
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
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System .Windows.Forms.DataGridView dgvSessionAllOrderItems;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.ToolStrip tsArchivedSessions;
        private System.Windows.Forms.ToolStripButton btnSessionARCExport;
        private System.Windows.Forms.ToolStripButton btnSessionARCEmail;
        private System.Windows.Forms.ToolStripButton btnSessionARCPrint;
        private System.Windows.Forms.ToolStripButton btnSessionARCReload;
        private System.Windows.Forms.ToolStripButton btnLoadSessions;
        private System.Windows.Forms.ToolStripLabel lblArchivedSelectedTotal;
        private System.Windows.Forms.ToolStrip tsSessionOrders;
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
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripButton btnChangePaymentMethodForOrder;
        private System.Windows.Forms.Panel pnl3661;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbRange;
        private System.Windows.Forms.BindingSource sRangeBindingSource;
        private System.Windows.Forms.Button btnLoadSelectables;
        private System.Windows.Forms.ToolStripLabel lblCard;
        private System.Windows.Forms.ToolStripLabel lblCash;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemTextDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
    }
}