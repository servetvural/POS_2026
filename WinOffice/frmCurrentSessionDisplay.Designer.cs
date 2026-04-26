using WinLayer.Controls;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Views;

namespace WinOffice {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentSessionDisplay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblUnpaidTotal = new System.Windows.Forms.Label();
            lblX3Total = new System.Windows.Forms.Label();
            lblX3TotalLabel = new System.Windows.Forms.Label();
            lblX1Total = new System.Windows.Forms.Label();
            lblX2Total = new System.Windows.Forms.Label();
            lblX1TotalLabel = new System.Windows.Forms.Label();
            lblX2TotalLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            lblGrossTotal = new System.Windows.Forms.Label();
            lblSessionStartDateTime = new System.Windows.Forms.Label();
            dgvOrders = new System.Windows.Forms.DataGridView();
            orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderBindingSource = new System.Windows.Forms.BindingSource(components);
            dgvOrderItems = new System.Windows.Forms.DataGridView();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderItemBindingSource = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tmrSeconds = new System.Windows.Forms.Timer(components);
            pnlInformation = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            barMain = new System.Windows.Forms.ToolStrip();
            cmdInterval = new System.Windows.Forms.ToolStripDropDownButton();
            stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            secondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            pBar2 = new System.Windows.Forms.ToolStripProgressBar();
            cmdGetSales = new System.Windows.Forms.ToolStripButton();
            cmdNotifyWithSound = new System.Windows.Forms.ToolStripButton();
            cmdPrintReport = new System.Windows.Forms.ToolStripButton();
            cmdViewReceipt = new System.Windows.Forms.ToolStripButton();
            expander1 = new WinLayer.Expander();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            dgvStockUsage = new System.Windows.Forms.DataGridView();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            QuantityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stockItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            recipeUsageBindingSource = new System.Windows.Forms.BindingSource(components);
            label7 = new System.Windows.Forms.Label();
            dgvOrderItemSummary = new System.Windows.Forms.DataGridView();
            orderItemSummaryBindingSource = new System.Windows.Forms.BindingSource(components);
            label8 = new System.Windows.Forms.Label();
            quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderItemTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).BeginInit();
            pnlInformation.SuspendLayout();
            barMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockUsage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeUsageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItemSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemSummaryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(15, 407);
            label5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(142, 19);
            label5.TabIndex = 72;
            label5.Text = "BONUS SCHEME";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(15, 188);
            label4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(126, 19);
            label4.TabIndex = 69;
            label4.Text = "UNPAID TOTAL";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnpaidTotal
            // 
            lblUnpaidTotal.BackColor = System.Drawing.Color.Transparent;
            lblUnpaidTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            lblUnpaidTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            lblUnpaidTotal.Location = new System.Drawing.Point(174, 183);
            lblUnpaidTotal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            lblUnpaidTotal.Name = "lblUnpaidTotal";
            lblUnpaidTotal.Size = new System.Drawing.Size(152, 30);
            lblUnpaidTotal.TabIndex = 70;
            lblUnpaidTotal.Text = "0.00";
            lblUnpaidTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX3Total
            // 
            lblX3Total.BackColor = System.Drawing.Color.Transparent;
            lblX3Total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            lblX3Total.ForeColor = System.Drawing.SystemColors.ControlText;
            lblX3Total.Location = new System.Drawing.Point(174, 346);
            lblX3Total.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            lblX3Total.Name = "lblX3Total";
            lblX3Total.Size = new System.Drawing.Size(152, 30);
            lblX3Total.TabIndex = 68;
            lblX3Total.Text = "0.00";
            lblX3Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX3TotalLabel
            // 
            lblX3TotalLabel.AutoSize = true;
            lblX3TotalLabel.BackColor = System.Drawing.Color.Transparent;
            lblX3TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            lblX3TotalLabel.Location = new System.Drawing.Point(15, 351);
            lblX3TotalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            lblX3TotalLabel.Name = "lblX3TotalLabel";
            lblX3TotalLabel.Size = new System.Drawing.Size(100, 19);
            lblX3TotalLabel.TabIndex = 67;
            lblX3TotalLabel.Text = "X3 TOPLAM";
            lblX3TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX1Total
            // 
            lblX1Total.BackColor = System.Drawing.Color.Transparent;
            lblX1Total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            lblX1Total.ForeColor = System.Drawing.SystemColors.ControlText;
            lblX1Total.Location = new System.Drawing.Point(174, 238);
            lblX1Total.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            lblX1Total.Name = "lblX1Total";
            lblX1Total.Size = new System.Drawing.Size(152, 30);
            lblX1Total.TabIndex = 64;
            lblX1Total.Text = "0.00";
            lblX1Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX2Total
            // 
            lblX2Total.BackColor = System.Drawing.Color.Transparent;
            lblX2Total.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            lblX2Total.ForeColor = System.Drawing.SystemColors.ControlText;
            lblX2Total.Location = new System.Drawing.Point(174, 292);
            lblX2Total.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            lblX2Total.Name = "lblX2Total";
            lblX2Total.Size = new System.Drawing.Size(152, 30);
            lblX2Total.TabIndex = 66;
            lblX2Total.Text = "0.00";
            lblX2Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX1TotalLabel
            // 
            lblX1TotalLabel.AutoSize = true;
            lblX1TotalLabel.BackColor = System.Drawing.Color.Transparent;
            lblX1TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            lblX1TotalLabel.Location = new System.Drawing.Point(15, 242);
            lblX1TotalLabel.Margin = new System.Windows.Forms.Padding(0, 3, 4, 1);
            lblX1TotalLabel.Name = "lblX1TotalLabel";
            lblX1TotalLabel.Size = new System.Drawing.Size(85, 19);
            lblX1TotalLabel.TabIndex = 63;
            lblX1TotalLabel.Text = "X1 TOTAL";
            lblX1TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX2TotalLabel
            // 
            lblX2TotalLabel.AutoSize = true;
            lblX2TotalLabel.BackColor = System.Drawing.Color.Transparent;
            lblX2TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            lblX2TotalLabel.Location = new System.Drawing.Point(15, 297);
            lblX2TotalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            lblX2TotalLabel.Name = "lblX2TotalLabel";
            lblX2TotalLabel.Size = new System.Drawing.Size(85, 19);
            lblX2TotalLabel.TabIndex = 65;
            lblX2TotalLabel.Text = "X2 TOTAL";
            lblX2TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(15, 44);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 19);
            label1.TabIndex = 49;
            label1.Text = "START DATE && TIME";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            label13.ForeColor = System.Drawing.SystemColors.ControlText;
            label13.Location = new System.Drawing.Point(15, 134);
            label13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(123, 19);
            label13.TabIndex = 55;
            label13.Text = "GROSS TOTAL";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrossTotal
            // 
            lblGrossTotal.BackColor = System.Drawing.Color.Transparent;
            lblGrossTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            lblGrossTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            lblGrossTotal.Location = new System.Drawing.Point(174, 129);
            lblGrossTotal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            lblGrossTotal.Name = "lblGrossTotal";
            lblGrossTotal.Size = new System.Drawing.Size(152, 30);
            lblGrossTotal.TabIndex = 56;
            lblGrossTotal.Text = "0.00";
            lblGrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSessionStartDateTime
            // 
            lblSessionStartDateTime.BackColor = System.Drawing.Color.Transparent;
            lblSessionStartDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSessionStartDateTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            lblSessionStartDateTime.ForeColor = System.Drawing.SystemColors.ControlText;
            lblSessionStartDateTime.Location = new System.Drawing.Point(14, 69);
            lblSessionStartDateTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 2);
            lblSessionStartDateTime.Name = "lblSessionStartDateTime";
            lblSessionStartDateTime.Size = new System.Drawing.Size(312, 39);
            lblSessionStartDateTime.TabIndex = 50;
            lblSessionStartDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.BackgroundColor = System.Drawing.Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderDateDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn1 });
            dgvOrders.DataSource = orderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrders.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrders.Location = new System.Drawing.Point(0, 29);
            dgvOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 25;
            dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new System.Drawing.Size(529, 338);
            dgvOrders.TabIndex = 71;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "c2";
            totalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.ReadOnly = true;
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
            dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, OrderItemText, priceDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dgvOrderItems.DataSource = orderItemBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle5;
            dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrderItems.Location = new System.Drawing.Point(0, 29);
            dgvOrderItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 25;
            dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new System.Drawing.Size(529, 319);
            dgvOrderItems.TabIndex = 0;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 80;
            // 
            // OrderItemText
            // 
            OrderItemText.DataPropertyName = "OrderItemText";
            OrderItemText.HeaderText = "Order Item";
            OrderItemText.Name = "OrderItemText";
            OrderItemText.ReadOnly = true;
            OrderItemText.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "c2";
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "c2";
            totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderItemBindingSource
            // 
            orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(529, 29);
            label2.TabIndex = 72;
            label2.Text = "ORDERS";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(529, 29);
            label3.TabIndex = 73;
            label3.Text = "ORDER ITEMS";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSeconds
            // 
            tmrSeconds.Interval = 1000;
            tmrSeconds.Tick += tmrSeconds_Tick;
            // 
            // pnlInformation
            // 
            pnlInformation.BackColor = System.Drawing.Color.AliceBlue;
            pnlInformation.Controls.Add(label6);
            pnlInformation.Controls.Add(label5);
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(lblSessionStartDateTime);
            pnlInformation.Controls.Add(label4);
            pnlInformation.Controls.Add(lblGrossTotal);
            pnlInformation.Controls.Add(lblUnpaidTotal);
            pnlInformation.Controls.Add(label13);
            pnlInformation.Controls.Add(lblX3Total);
            pnlInformation.Controls.Add(lblX2TotalLabel);
            pnlInformation.Controls.Add(lblX3TotalLabel);
            pnlInformation.Controls.Add(lblX1TotalLabel);
            pnlInformation.Controls.Add(lblX1Total);
            pnlInformation.Controls.Add(lblX2Total);
            pnlInformation.Dock = System.Windows.Forms.DockStyle.Left;
            pnlInformation.Location = new System.Drawing.Point(0, 62);
            pnlInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlInformation.MinimumSize = new System.Drawing.Size(350, 0);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new System.Drawing.Size(358, 735);
            pnlInformation.TabIndex = 73;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.White;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(358, 33);
            label6.TabIndex = 73;
            label6.Text = "ACTIVE SESSION DATA";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cmdInterval, pBar2, cmdGetSales, cmdNotifyWithSound, cmdPrintReport, cmdViewReceipt });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(1455, 62);
            barMain.TabIndex = 74;
            barMain.Text = "toolStrip1";
            // 
            // cmdInterval
            // 
            cmdInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { stopToolStripMenuItem, secondsToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            cmdInterval.Image = Properties.Resources.Clock;
            cmdInterval.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdInterval.Name = "cmdInterval";
            cmdInterval.Size = new System.Drawing.Size(110, 59);
            cmdInterval.Text = "Status (Timer)";
            cmdInterval.DropDownItemClicked += cmdInterval_DropDownItemClicked;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            stopToolStripMenuItem.Tag = "0";
            stopToolStripMenuItem.Text = "Stopped";
            // 
            // secondsToolStripMenuItem
            // 
            secondsToolStripMenuItem.Name = "secondsToolStripMenuItem";
            secondsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            secondsToolStripMenuItem.Tag = "5000";
            secondsToolStripMenuItem.Text = "5 Seconds";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem1.Tag = "10000";
            toolStripMenuItem1.Text = "10 Seconds";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem2.Tag = "30000";
            toolStripMenuItem2.Text = "30 Seconds";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem3.Tag = "60000";
            toolStripMenuItem3.Text = "1 Minute";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            toolStripMenuItem4.Tag = "300000";
            toolStripMenuItem4.Text = "5 Minutes";
            // 
            // pBar2
            // 
            pBar2.Name = "pBar2";
            pBar2.Size = new System.Drawing.Size(117, 59);
            // 
            // cmdGetSales
            // 
            cmdGetSales.Image = Properties.Resources.Lightning;
            cmdGetSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdGetSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdGetSales.Name = "cmdGetSales";
            cmdGetSales.Size = new System.Drawing.Size(58, 59);
            cmdGetSales.Text = "Get Sales";
            cmdGetSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdGetSales.Click += btnGetSales_Click;
            // 
            // cmdNotifyWithSound
            // 
            cmdNotifyWithSound.Checked = true;
            cmdNotifyWithSound.CheckOnClick = true;
            cmdNotifyWithSound.CheckState = System.Windows.Forms.CheckState.Checked;
            cmdNotifyWithSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            cmdNotifyWithSound.Image = (System.Drawing.Image)resources.GetObject("cmdNotifyWithSound.Image");
            cmdNotifyWithSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdNotifyWithSound.Name = "cmdNotifyWithSound";
            cmdNotifyWithSound.Size = new System.Drawing.Size(109, 59);
            cmdNotifyWithSound.Text = "Notify With Sound";
            // 
            // cmdPrintReport
            // 
            cmdPrintReport.Image = Properties.Resources.Printer32;
            cmdPrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdPrintReport.Name = "cmdPrintReport";
            cmdPrintReport.Size = new System.Drawing.Size(78, 59);
            cmdPrintReport.Text = "Print Receipt";
            cmdPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdPrintReport.Click += btnPrintReport_Click;
            // 
            // cmdViewReceipt
            // 
            cmdViewReceipt.Image = Properties.Resources.Glasses32;
            cmdViewReceipt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            cmdViewReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmdViewReceipt.Name = "cmdViewReceipt";
            cmdViewReceipt.Size = new System.Drawing.Size(78, 59);
            cmdViewReceipt.Text = "View Receipt";
            cmdViewReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            cmdViewReceipt.Click += btnViewReceipt_Click;
            // 
            // expander1
            // 
            expander1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expander1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expander1.Caption = "";
            expander1.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expander1.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            expander1.CaptionForeColor = System.Drawing.Color.White;
            expander1.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            expander1.ColourFixed = System.Drawing.Color.Salmon;
            expander1.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expander1.Dock = System.Windows.Forms.DockStyle.Left;
            expander1.ExpandableControl = pnlInformation;
            expander1.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expander1.Expanded = true;
            expander1.Fixed = false;
            expander1.Location = new System.Drawing.Point(358, 62);
            expander1.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expander1.LockButtonSize = new System.Drawing.Size(23, 74);
            expander1.LockButtonVisible = true;
            expander1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expander1.MinimumSize = new System.Drawing.Size(6, 5);
            expander1.Name = "expander1";
            expander1.Size = new System.Drawing.Size(25, 735);
            expander1.TabIndex = 77;
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
            splitContainer1.Panel1.Controls.Add(dgvOrders);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvOrderItems);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new System.Drawing.Size(529, 735);
            splitContainer1.SplitterDistance = 367;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 79;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(383, 62);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new System.Drawing.Size(1072, 735);
            splitContainer2.SplitterDistance = 529;
            splitContainer2.SplitterWidth = 20;
            splitContainer2.TabIndex = 80;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dgvStockUsage);
            splitContainer3.Panel1.Controls.Add(label7);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(dgvOrderItemSummary);
            splitContainer3.Panel2.Controls.Add(label8);
            splitContainer3.Size = new System.Drawing.Size(523, 735);
            splitContainer3.SplitterDistance = 367;
            splitContainer3.SplitterWidth = 20;
            splitContainer3.TabIndex = 75;
            // 
            // dgvStockUsage
            // 
            dgvStockUsage.AllowUserToAddRows = false;
            dgvStockUsage.AllowUserToDeleteRows = false;
            dgvStockUsage.AutoGenerateColumns = false;
            dgvStockUsage.BackgroundColor = System.Drawing.Color.White;
            dgvStockUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Quantity, QuantityType, stockItemNameDataGridViewTextBoxColumn });
            dgvStockUsage.DataSource = recipeUsageBindingSource;
            dgvStockUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStockUsage.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvStockUsage.Location = new System.Drawing.Point(0, 29);
            dgvStockUsage.MultiSelect = false;
            dgvStockUsage.Name = "dgvStockUsage";
            dgvStockUsage.ReadOnly = true;
            dgvStockUsage.RowHeadersWidth = 25;
            dgvStockUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStockUsage.Size = new System.Drawing.Size(523, 338);
            dgvStockUsage.TabIndex = 74;
            dgvStockUsage.CellContentClick += dgvStockUsage_CellContentClick;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 70;
            // 
            // QuantityType
            // 
            QuantityType.DataPropertyName = "QuantityType";
            QuantityType.HeaderText = "Measure";
            QuantityType.Name = "QuantityType";
            QuantityType.ReadOnly = true;
            // 
            // stockItemNameDataGridViewTextBoxColumn
            // 
            stockItemNameDataGridViewTextBoxColumn.DataPropertyName = "StockItemName";
            stockItemNameDataGridViewTextBoxColumn.HeaderText = "Stock Item";
            stockItemNameDataGridViewTextBoxColumn.Name = "stockItemNameDataGridViewTextBoxColumn";
            stockItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            stockItemNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // recipeUsageBindingSource
            // 
            recipeUsageBindingSource.DataSource = typeof(RecipeUsage);
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.White;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.Dock = System.Windows.Forms.DockStyle.Top;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(0, 0);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(523, 29);
            label7.TabIndex = 73;
            label7.Text = "STOCK USAGE";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrderItemSummary
            // 
            dgvOrderItemSummary.AllowUserToAddRows = false;
            dgvOrderItemSummary.AllowUserToDeleteRows = false;
            dgvOrderItemSummary.AutoGenerateColumns = false;
            dgvOrderItemSummary.BackgroundColor = System.Drawing.Color.White;
            dgvOrderItemSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItemSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { quantityDataGridViewTextBoxColumn1, orderItemTextDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn2 });
            dgvOrderItemSummary.DataSource = orderItemSummaryBindingSource;
            dgvOrderItemSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrderItemSummary.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvOrderItemSummary.Location = new System.Drawing.Point(0, 29);
            dgvOrderItemSummary.MultiSelect = false;
            dgvOrderItemSummary.Name = "dgvOrderItemSummary";
            dgvOrderItemSummary.ReadOnly = true;
            dgvOrderItemSummary.RowHeadersWidth = 25;
            dgvOrderItemSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItemSummary.Size = new System.Drawing.Size(523, 319);
            dgvOrderItemSummary.TabIndex = 75;
            // 
            // orderItemSummaryBindingSource
            // 
            orderItemSummaryBindingSource.DataSource = typeof(OrderItemSummary);
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.White;
            label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label8.Dock = System.Windows.Forms.DockStyle.Top;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(0, 0);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(523, 29);
            label8.TabIndex = 74;
            label8.Text = "ORDER ITEM SUMMARY";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            quantityDataGridViewTextBoxColumn1.Width = 70;
            // 
            // orderItemTextDataGridViewTextBoxColumn
            // 
            orderItemTextDataGridViewTextBoxColumn.DataPropertyName = "OrderItemText";
            orderItemTextDataGridViewTextBoxColumn.HeaderText = "OrderItemText";
            orderItemTextDataGridViewTextBoxColumn.Name = "orderItemTextDataGridViewTextBoxColumn";
            orderItemTextDataGridViewTextBoxColumn.ReadOnly = true;
            orderItemTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.ReadOnly = true;
            priceDataGridViewTextBoxColumn1.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn2
            // 
            totalDataGridViewTextBoxColumn2.DataPropertyName = "Total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            totalDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            totalDataGridViewTextBoxColumn2.HeaderText = "Total";
            totalDataGridViewTextBoxColumn2.Name = "totalDataGridViewTextBoxColumn2";
            totalDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmCurrentSessionDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1455, 797);
            Controls.Add(splitContainer2);
            Controls.Add(expander1);
            Controls.Add(pnlInformation);
            Controls.Add(barMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmCurrentSessionDisplay";
            Text = "CURRENT SESSION DISPLAY";
            Load += frmCurrentSessionDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).EndInit();
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockUsage).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeUsageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItemSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemSummaryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGrossTotal;
        private System.Windows.Forms.Label lblSessionStartDateTime;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderItems;
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
        private WinLayer.Controls.ctlBonus pnlBonus;
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
        private WinLayer.Expander expander1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvStockUsage;
        private System.Windows.Forms.BindingSource recipeUsageBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvOrderItemSummary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemSummaryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
    }
}