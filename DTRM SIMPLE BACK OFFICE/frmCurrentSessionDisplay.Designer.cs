using POSLayer.Models;
using POSLayer.Views;

namespace DTRMSimpleBackOffice {
    partial class frmCurrentSessionDisplay {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentSessionDisplay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnpaidTotal = new System.Windows.Forms.Label();
            this.lblX3Total = new System.Windows.Forms.Label();
            this.lblX3TotalLabel = new System.Windows.Forms.Label();
            this.lblX1Total = new System.Windows.Forms.Label();
            this.lblX2Total = new System.Windows.Forms.Label();
            this.lblX1TotalLabel = new System.Windows.Forms.Label();
            this.lblX2TotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGrossTotal = new System.Windows.Forms.Label();
            this.lblSessionStartDateTime = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.colItemIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrSeconds = new System.Windows.Forms.Timer(this.components);
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBonus = new DTRMNS.Controls.ctlBonus();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.cmdInterval = new System.Windows.Forms.ToolStripDropDownButton();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.cmdGetSales = new System.Windows.Forms.ToolStripButton();
            this.cmdNotifyWithSound = new System.Windows.Forms.ToolStripButton();
            this.cmdPrintReport = new System.Windows.Forms.ToolStripButton();
            this.cmdViewReceipt = new System.Windows.Forms.ToolStripButton();
            this.pnlOrderItems = new System.Windows.Forms.Panel();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expander2 = new PosLibrary.Expander();
            this.expander1 = new PosLibrary.Expander();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.pnlInformation.SuspendLayout();
            this.barMain.SuspendLayout();
            this.pnlOrderItems.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 72;
            this.label5.Text = "BONUS SCHEME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "UNPAID TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnpaidTotal
            // 
            this.lblUnpaidTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblUnpaidTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnpaidTotal.Location = new System.Drawing.Point(149, 159);
            this.lblUnpaidTotal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblUnpaidTotal.Name = "lblUnpaidTotal";
            this.lblUnpaidTotal.Size = new System.Drawing.Size(130, 26);
            this.lblUnpaidTotal.TabIndex = 70;
            this.lblUnpaidTotal.Text = "0.00";
            this.lblUnpaidTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX3Total
            // 
            this.lblX3Total.BackColor = System.Drawing.Color.Transparent;
            this.lblX3Total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblX3Total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblX3Total.Location = new System.Drawing.Point(149, 300);
            this.lblX3Total.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblX3Total.Name = "lblX3Total";
            this.lblX3Total.Size = new System.Drawing.Size(130, 26);
            this.lblX3Total.TabIndex = 68;
            this.lblX3Total.Text = "0.00";
            this.lblX3Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX3TotalLabel
            // 
            this.lblX3TotalLabel.AutoSize = true;
            this.lblX3TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblX3TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblX3TotalLabel.Location = new System.Drawing.Point(13, 304);
            this.lblX3TotalLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lblX3TotalLabel.Name = "lblX3TotalLabel";
            this.lblX3TotalLabel.Size = new System.Drawing.Size(100, 19);
            this.lblX3TotalLabel.TabIndex = 67;
            this.lblX3TotalLabel.Text = "X3 TOPLAM";
            this.lblX3TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX1Total
            // 
            this.lblX1Total.BackColor = System.Drawing.Color.Transparent;
            this.lblX1Total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblX1Total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblX1Total.Location = new System.Drawing.Point(149, 206);
            this.lblX1Total.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblX1Total.Name = "lblX1Total";
            this.lblX1Total.Size = new System.Drawing.Size(130, 26);
            this.lblX1Total.TabIndex = 64;
            this.lblX1Total.Text = "0.00";
            this.lblX1Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX2Total
            // 
            this.lblX2Total.BackColor = System.Drawing.Color.Transparent;
            this.lblX2Total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblX2Total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblX2Total.Location = new System.Drawing.Point(149, 253);
            this.lblX2Total.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblX2Total.Name = "lblX2Total";
            this.lblX2Total.Size = new System.Drawing.Size(130, 26);
            this.lblX2Total.TabIndex = 66;
            this.lblX2Total.Text = "0.00";
            this.lblX2Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX1TotalLabel
            // 
            this.lblX1TotalLabel.AutoSize = true;
            this.lblX1TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblX1TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblX1TotalLabel.Location = new System.Drawing.Point(13, 210);
            this.lblX1TotalLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 1);
            this.lblX1TotalLabel.Name = "lblX1TotalLabel";
            this.lblX1TotalLabel.Size = new System.Drawing.Size(85, 19);
            this.lblX1TotalLabel.TabIndex = 63;
            this.lblX1TotalLabel.Text = "X1 TOTAL";
            this.lblX1TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX2TotalLabel
            // 
            this.lblX2TotalLabel.AutoSize = true;
            this.lblX2TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblX2TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblX2TotalLabel.Location = new System.Drawing.Point(13, 257);
            this.lblX2TotalLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lblX2TotalLabel.Name = "lblX2TotalLabel";
            this.lblX2TotalLabel.Size = new System.Drawing.Size(85, 19);
            this.lblX2TotalLabel.TabIndex = 65;
            this.lblX2TotalLabel.Text = "X2 TOTAL";
            this.lblX2TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "START DATE && TIME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(13, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 19);
            this.label13.TabIndex = 55;
            this.label13.Text = "GROSS TOTAL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrossTotal
            // 
            this.lblGrossTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrossTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblGrossTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrossTotal.Location = new System.Drawing.Point(149, 112);
            this.lblGrossTotal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblGrossTotal.Name = "lblGrossTotal";
            this.lblGrossTotal.Size = new System.Drawing.Size(130, 26);
            this.lblGrossTotal.TabIndex = 56;
            this.lblGrossTotal.Text = "0.00";
            this.lblGrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSessionStartDateTime
            // 
            this.lblSessionStartDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSessionStartDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSessionStartDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblSessionStartDateTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSessionStartDateTime.Location = new System.Drawing.Point(12, 60);
            this.lblSessionStartDateTime.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblSessionStartDateTime.Name = "lblSessionStartDateTime";
            this.lblSessionStartDateTime.Size = new System.Drawing.Size(268, 34);
            this.lblSessionStartDateTime.TabIndex = 50;
            this.lblSessionStartDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderIID,
            this.orderDateDataGridViewTextBoxColumn,
            this.calculatedValueDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.ordersViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 25);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 25;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(532, 186);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // calculatedValueDataGridViewTextBoxColumn
            // 
            this.calculatedValueDataGridViewTextBoxColumn.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.calculatedValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.calculatedValueDataGridViewTextBoxColumn.HeaderText = "Total";
            this.calculatedValueDataGridViewTextBoxColumn.Name = "calculatedValueDataGridViewTextBoxColumn";
            this.calculatedValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataSource = typeof(OrdersView);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.AutoGenerateColumns = false;
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemIID,
            this.Quantity,
            this.OrderItemText,
            this.Price,
            this.Column1});
            this.dgvOrderItems.DataSource = this.orderItemBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrderItems.Location = new System.Drawing.Point(0, 25);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersWidth = 25;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(532, 380);
            this.dgvOrderItems.TabIndex = 0;
            // 
            // colItemIID
            // 
            this.colItemIID.DataPropertyName = "IID";
            this.colItemIID.HeaderText = "IID";
            this.colItemIID.Name = "colItemIID";
            this.colItemIID.ReadOnly = true;
            this.colItemIID.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 60;
            // 
            // OrderItemText
            // 
            this.OrderItemText.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OrderItemText.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrderItemText.HeaderText = "Item";
            this.OrderItemText.Name = "OrderItemText";
            this.OrderItemText.ReadOnly = true;
            this.OrderItemText.Width = 200;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle6;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "ORDERS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "ORDER ITEMS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSeconds
            // 
            this.tmrSeconds.Interval = 1000;
            this.tmrSeconds.Tick += new System.EventHandler(this.tmrSeconds_Tick);
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlInformation.Controls.Add(this.label6);
            this.pnlInformation.Controls.Add(this.label5);
            this.pnlInformation.Controls.Add(this.label1);
            this.pnlInformation.Controls.Add(this.pnlBonus);
            this.pnlInformation.Controls.Add(this.lblSessionStartDateTime);
            this.pnlInformation.Controls.Add(this.label4);
            this.pnlInformation.Controls.Add(this.lblGrossTotal);
            this.pnlInformation.Controls.Add(this.lblUnpaidTotal);
            this.pnlInformation.Controls.Add(this.label13);
            this.pnlInformation.Controls.Add(this.lblX3Total);
            this.pnlInformation.Controls.Add(this.lblX2TotalLabel);
            this.pnlInformation.Controls.Add(this.lblX3TotalLabel);
            this.pnlInformation.Controls.Add(this.lblX1TotalLabel);
            this.pnlInformation.Controls.Add(this.lblX1Total);
            this.pnlInformation.Controls.Add(this.lblX2Total);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInformation.Location = new System.Drawing.Point(0, 54);
            this.pnlInformation.MinimumSize = new System.Drawing.Size(300, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(307, 637);
            this.pnlInformation.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 29);
            this.label6.TabIndex = 73;
            this.label6.Text = "ACTIVE SESSION DATA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBonus
            // 
            this.pnlBonus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBonus.BackColor = System.Drawing.Color.Transparent;
            this.pnlBonus.ControlBackColor = System.Drawing.Color.Transparent;
            this.pnlBonus.ControlFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.pnlBonus.ControlForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBonus.EnableAutoUpdate = false;
            this.pnlBonus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.pnlBonus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBonus.Location = new System.Drawing.Point(12, 377);
            this.pnlBonus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBonus.MinimumSize = new System.Drawing.Size(200, 18);
            this.pnlBonus.Name = "pnlBonus";
            this.pnlBonus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlBonus.ProgressBarWidth = 143;
            this.pnlBonus.Size = new System.Drawing.Size(267, 24);
            this.pnlBonus.TabIndex = 71;
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdInterval,
            this.pBar2,
            this.cmdGetSales,
            this.cmdNotifyWithSound,
            this.cmdPrintReport,
            this.cmdViewReceipt});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(861, 54);
            this.barMain.TabIndex = 74;
            this.barMain.Text = "toolStrip1";
            // 
            // cmdInterval
            // 
            this.cmdInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.secondsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.cmdInterval.Image = global::DTRMSimpleBackOffice.Properties.Resources.Clock;
            this.cmdInterval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdInterval.Name = "cmdInterval";
            this.cmdInterval.Size = new System.Drawing.Size(110, 51);
            this.cmdInterval.Text = "Status (Timer)";
            this.cmdInterval.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmdInterval_DropDownItemClicked);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stopToolStripMenuItem.Tag = "0";
            this.stopToolStripMenuItem.Text = "Stopped";
            // 
            // secondsToolStripMenuItem
            // 
            this.secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            this.secondsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.secondsToolStripMenuItem.Tag = "5000";
            this.secondsToolStripMenuItem.Text = "5 Seconds";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Tag = "10000";
            this.toolStripMenuItem1.Text = "10 Seconds";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Tag = "30000";
            this.toolStripMenuItem2.Text = "30 Seconds";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem3.Tag = "60000";
            this.toolStripMenuItem3.Text = "1 Minute";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Tag = "300000";
            this.toolStripMenuItem4.Text = "5 Minutes";
            // 
            // pBar2
            // 
            this.pBar2.Name = "pBar2";
            this.pBar2.Size = new System.Drawing.Size(100, 51);
            // 
            // cmdGetSales
            // 
            this.cmdGetSales.Image = global::DTRMSimpleBackOffice.Properties.Resources.Lightning;
            this.cmdGetSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdGetSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGetSales.Name = "cmdGetSales";
            this.cmdGetSales.Size = new System.Drawing.Size(58, 51);
            this.cmdGetSales.Text = "Get Sales";
            this.cmdGetSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdGetSales.Click += new System.EventHandler(this.btnGetSales_Click);
            // 
            // cmdNotifyWithSound
            // 
            this.cmdNotifyWithSound.Checked = true;
            this.cmdNotifyWithSound.CheckOnClick = true;
            this.cmdNotifyWithSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmdNotifyWithSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdNotifyWithSound.Image = ((System.Drawing.Image)(resources.GetObject("cmdNotifyWithSound.Image")));
            this.cmdNotifyWithSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNotifyWithSound.Name = "cmdNotifyWithSound";
            this.cmdNotifyWithSound.Size = new System.Drawing.Size(109, 51);
            this.cmdNotifyWithSound.Text = "Notify With Sound";
            // 
            // cmdPrintReport
            // 
            this.cmdPrintReport.Image = global::DTRMSimpleBackOffice.Properties.Resources.Printer32;
            this.cmdPrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrintReport.Name = "cmdPrintReport";
            this.cmdPrintReport.Size = new System.Drawing.Size(78, 51);
            this.cmdPrintReport.Text = "Print Receipt";
            this.cmdPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // cmdViewReceipt
            // 
            this.cmdViewReceipt.Image = global::DTRMSimpleBackOffice.Properties.Resources.Glasses32;
            this.cmdViewReceipt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdViewReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdViewReceipt.Name = "cmdViewReceipt";
            this.cmdViewReceipt.Size = new System.Drawing.Size(78, 51);
            this.cmdViewReceipt.Text = "View Receipt";
            this.cmdViewReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdViewReceipt.Click += new System.EventHandler(this.btnViewReceipt_Click);
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.Controls.Add(this.dgvOrderItems);
            this.pnlOrderItems.Controls.Add(this.label3);
            this.pnlOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderItems.Location = new System.Drawing.Point(329, 286);
            this.pnlOrderItems.MinimumSize = new System.Drawing.Size(0, 200);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.Size = new System.Drawing.Size(532, 405);
            this.pnlOrderItems.TabIndex = 75;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.dgvOrders);
            this.pnlOrders.Controls.Add(this.label2);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrders.Location = new System.Drawing.Point(329, 54);
            this.pnlOrders.MinimumSize = new System.Drawing.Size(0, 200);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(532, 211);
            this.pnlOrders.TabIndex = 76;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "F";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IID";
            this.dataGridViewTextBoxColumn4.HeaderText = "IID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderItemText";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn6.HeaderText = "Item";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Total";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn8.HeaderText = "Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // expander2
            // 
            this.expander2.BackColor = System.Drawing.Color.Salmon;
            this.expander2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expander2.Caption = "";
            this.expander2.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expander2.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expander2.CaptionForeColor = System.Drawing.Color.White;
            this.expander2.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.expander2.ColourFixed = System.Drawing.Color.Salmon;
            this.expander2.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expander2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expander2.ExpandableControl = this.pnlOrders;
            this.expander2.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expander2.Expanded = true;
            this.expander2.Fixed = true;
            this.expander2.Location = new System.Drawing.Point(329, 265);
            this.expander2.LockButtonDock = System.Windows.Forms.DockStyle.Left;
            this.expander2.LockButtonSize = new System.Drawing.Size(32, 19);
            this.expander2.LockButtonVisible = true;
            this.expander2.MinimumSize = new System.Drawing.Size(5, 5);
            this.expander2.Name = "expander2";
            this.expander2.Size = new System.Drawing.Size(532, 21);
            this.expander2.TabIndex = 78;
            // 
            // expander1
            // 
            this.expander1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expander1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expander1.Caption = "";
            this.expander1.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expander1.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expander1.CaptionForeColor = System.Drawing.Color.White;
            this.expander1.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.expander1.ColourFixed = System.Drawing.Color.Salmon;
            this.expander1.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expander1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expander1.ExpandableControl = this.pnlInformation;
            this.expander1.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            this.expander1.Expanded = true;
            this.expander1.Fixed = false;
            this.expander1.Location = new System.Drawing.Point(307, 54);
            this.expander1.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expander1.LockButtonSize = new System.Drawing.Size(20, 64);
            this.expander1.LockButtonVisible = true;
            this.expander1.MinimumSize = new System.Drawing.Size(5, 5);
            this.expander1.Name = "expander1";
            this.expander1.Size = new System.Drawing.Size(22, 637);
            this.expander1.TabIndex = 77;
            // 
            // frmCurrentSessionDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 691);
            this.Controls.Add(this.pnlOrderItems);
            this.Controls.Add(this.expander2);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.expander1);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.barMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCurrentSessionDisplay";
            this.Text = "CURRENT SESSION DISPLAY";
            this.Load += new System.EventHandler(this.frmCurrentSessionDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.pnlOrderItems.ResumeLayout(false);
            this.pnlOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGrossTotal;
        private System.Windows.Forms.Label lblSessionStartDateTime;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.Label lblX3Total;
        private System.Windows.Forms.Label lblX3TotalLabel;
        private System.Windows.Forms.Label lblX1Total;
        private System.Windows.Forms.Label lblX2Total;
        private System.Windows.Forms.Label lblX1TotalLabel;
        private System.Windows.Forms.Label lblX2TotalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUnpaidTotal;
        private System.Windows.Forms.Timer tmrSeconds;
        private DTRMNS.Controls.ctlBonus pnlBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripDropDownButton cmdInterval;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripProgressBar pBar2;
        private System.Windows.Forms.ToolStripButton cmdGetSales;
        private System.Windows.Forms.ToolStripButton cmdNotifyWithSound;
        private System.Windows.Forms.ToolStripButton cmdPrintReport;
        private System.Windows.Forms.ToolStripButton cmdViewReceipt;
        private System.Windows.Forms.Panel pnlOrderItems;
        private System.Windows.Forms.Panel pnlOrders;
        private PosLibrary.Expander expander1;
        private PosLibrary.Expander expander2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}