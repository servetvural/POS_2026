using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Collections.Generic;

using POSLayer.Library;
using POSLayer.Models;
using System.Threading.Tasks;
using POSWinFormLayer;
using POSLayer.Views;
using POSLayer.Repository.IRepository;

namespace DTRMNS
{
    /// <summary>
    /// Summary description for frmOrders.
    /// </summary>
    public class ctlOrders : UserControl
    {
        PosConfig config;

        private System.Windows.Forms.Panel panel1;
        private Button btnLoadOrder;
        private Button btnDeleteOrder;

        private DTRMNS.DTRMSimpleBusiness bslayer;
        private Button btnUnsetPaymentMethod;
        private DataGridView dgv;
        private BindingSource ordersViewDataConnector;
        private Label lblTotal;
        private Button btnPrintReceipt;
        private System.ComponentModel.IContainer components;

        //This events required to call functions in frmMain
        public GenericFunctionCall UnloadOrderEvent;
        public GenericFunctionCall LoadAttachedOrderEvent;
        public GenericFunctionCall DetachPanelEvent;
        public PassControl PassControlEvent;
        private Panel panel2;
        private Button btnViewCustomerOrTable;
        private VScrollBar vScroll;
        public RemoteCompleteAttachedOrder CompleteAttachedOrderEvent;
        private Button btnChangePaymentMethod;
        private DataGridViewTextBoxColumn IID;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn CustomerDetails;
        private DataGridViewTextBoxColumn colOrderItemsDetailed;
        private DataGridViewTextBoxColumn StatusName;
        private DataGridViewTextBoxColumn OrderTypeName;
        private DataGridViewTextBoxColumn PaymentMethodName;
        private DataGridViewTextBoxColumn PaymentFlag;
        private DataGridViewTextBoxColumn CalculatedValue;
        private DataGridViewTextBoxColumn KitchenOrderNo;

        //private UtilityLibrary UF;
        private List<int> rowheights;
        public ctlOrders(PosConfig configAsService, DTRMSimpleBusiness bslayer)
        {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
        }

        public ctlOrders(PosConfig configAsService, DTRMSimpleBusiness bslayer, GenericFunctionCall UnloadOrder,
            GenericFunctionCall LoadAttachedOrder,
            GenericFunctionCall DetachPanel,
            PassControl AttachPanel,
            RemoteCompleteAttachedOrder CompleteAttachedOrder)
        {

            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            UnloadOrderEvent = UnloadOrder;
            LoadAttachedOrderEvent = LoadAttachedOrder;
            DetachPanelEvent = DetachPanel;
            PassControlEvent = AttachPanel;
            CompleteAttachedOrderEvent = CompleteAttachedOrder;

        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePaymentMethod = new System.Windows.Forms.Button();
            this.btnViewCustomerOrTable = new System.Windows.Forms.Button();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnUnsetPaymentMethod = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScroll = new System.Windows.Forms.VScrollBar();
            this.colOrderItemsDetailed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitchenOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewDataConnector = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewDataConnector)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnChangePaymentMethod);
            this.panel1.Controls.Add(this.btnViewCustomerOrTable);
            this.panel1.Controls.Add(this.btnLoadOrder);
            this.panel1.Controls.Add(this.btnPrintReceipt);
            this.panel1.Controls.Add(this.btnUnsetPaymentMethod);
            this.panel1.Controls.Add(this.btnDeleteOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(947, 60);
            this.panel1.TabIndex = 2;
            // 
            // btnChangePaymentMethod
            // 
            this.btnChangePaymentMethod.AutoEllipsis = true;
            this.btnChangePaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChangePaymentMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePaymentMethod.FlatAppearance.BorderSize = 0;
            this.btnChangePaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePaymentMethod.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnChangePaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChangePaymentMethod.Location = new System.Drawing.Point(324, 4);
            this.btnChangePaymentMethod.Name = "btnChangePaymentMethod";
            this.btnChangePaymentMethod.Size = new System.Drawing.Size(100, 50);
            this.btnChangePaymentMethod.TabIndex = 21;
            this.btnChangePaymentMethod.Text = "PAY";
            this.btnChangePaymentMethod.UseVisualStyleBackColor = false;
            this.btnChangePaymentMethod.Click += new System.EventHandler(this.btnChangePaymentMethod_Click);
            // 
            // btnViewCustomerOrTable
            // 
            this.btnViewCustomerOrTable.AutoEllipsis = true;
            this.btnViewCustomerOrTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnViewCustomerOrTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewCustomerOrTable.FlatAppearance.BorderSize = 0;
            this.btnViewCustomerOrTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomerOrTable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomerOrTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnViewCustomerOrTable.Location = new System.Drawing.Point(104, 4);
            this.btnViewCustomerOrTable.Name = "btnViewCustomerOrTable";
            this.btnViewCustomerOrTable.Size = new System.Drawing.Size(58, 50);
            this.btnViewCustomerOrTable.TabIndex = 20;
            this.btnViewCustomerOrTable.Text = "CUST / TABLE";
            this.btnViewCustomerOrTable.UseVisualStyleBackColor = false;
            this.btnViewCustomerOrTable.Click += new System.EventHandler(this.btnViewCustomerOrTable_Click);
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.AutoEllipsis = true;
            this.btnLoadOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadOrder.FlatAppearance.BorderSize = 0;
            this.btnLoadOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadOrder.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnLoadOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadOrder.Location = new System.Drawing.Point(574, 4);
            this.btnLoadOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(100, 50);
            this.btnLoadOrder.TabIndex = 10;
            this.btnLoadOrder.TabStop = false;
            this.btnLoadOrder.Text = "LOAD";
            this.btnLoadOrder.UseVisualStyleBackColor = false;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.AutoEllipsis = true;
            this.btnPrintReceipt.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPrintReceipt.BackgroundImage = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrintReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location = new System.Drawing.Point(447, 4);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrintReceipt.Size = new System.Drawing.Size(100, 50);
            this.btnPrintReceipt.TabIndex = 19;
            this.btnPrintReceipt.Text = " PRINT RECEIPT";
            this.btnPrintReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnUnsetPaymentMethod
            // 
            this.btnUnsetPaymentMethod.AutoEllipsis = true;
            this.btnUnsetPaymentMethod.BackColor = System.Drawing.Color.Red;
            this.btnUnsetPaymentMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnsetPaymentMethod.FlatAppearance.BorderSize = 0;
            this.btnUnsetPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnsetPaymentMethod.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnUnsetPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.btnUnsetPaymentMethod.Location = new System.Drawing.Point(186, 4);
            this.btnUnsetPaymentMethod.Name = "btnUnsetPaymentMethod";
            this.btnUnsetPaymentMethod.Size = new System.Drawing.Size(113, 50);
            this.btnUnsetPaymentMethod.TabIndex = 17;
            this.btnUnsetPaymentMethod.Text = "NOT PAID";
            this.btnUnsetPaymentMethod.UseVisualStyleBackColor = false;
            this.btnUnsetPaymentMethod.Click += new System.EventHandler(this.btnUnsetPaymentMethod_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.AutoEllipsis = true;
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteOrder.Location = new System.Drawing.Point(6, 4);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 50);
            this.btnDeleteOrder.TabIndex = 13;
            this.btnDeleteOrder.TabStop = false;
            this.btnDeleteOrder.Text = "VOID";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Visible = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Black;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.colOrderDate,
            this.CustomerDetails,
            this.colOrderItemsDetailed,
            this.StatusName,
            this.OrderTypeName,
            this.PaymentMethodName,
            this.PaymentFlag,
            this.CalculatedValue,
            this.KitchenOrderNo});
            this.dgv.DataSource = this.ordersViewDataConnector;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 87);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 20;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(864, 518);
            this.dgv.TabIndex = 4;
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgv.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(0, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(947, 27);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 20);
            this.panel2.TabIndex = 12;
            // 
            // vScroll
            // 
            this.vScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScroll.Location = new System.Drawing.Point(864, 87);
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(83, 518);
            this.vScroll.TabIndex = 13;
            this.vScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScroll_Scroll);
            // 
            // colOrderItemsDetailed
            // 
            this.colOrderItemsDetailed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderItemsDetailed.DataPropertyName = "OrderItemsDetailed";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderItemsDetailed.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderItemsDetailed.HeaderText = "Order Items";
            this.colOrderItemsDetailed.Name = "colOrderItemsDetailed";
            this.colOrderItemsDetailed.ReadOnly = true;
            this.colOrderItemsDetailed.Width = 170;
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusName.DefaultCellStyle = dataGridViewCellStyle3;
            this.StatusName.HeaderText = "Status";
            this.StatusName.Name = "StatusName";
            this.StatusName.ReadOnly = true;
            this.StatusName.Width = 90;
            // 
            // OrderTypeName
            // 
            this.OrderTypeName.DataPropertyName = "OrderTypeName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeName.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrderTypeName.HeaderText = "Order Type";
            this.OrderTypeName.Name = "OrderTypeName";
            this.OrderTypeName.ReadOnly = true;
            this.OrderTypeName.Width = 90;
            // 
            // PaymentMethodName
            // 
            this.PaymentMethodName.DataPropertyName = "PaymentMethodName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodName.DefaultCellStyle = dataGridViewCellStyle5;
            this.PaymentMethodName.HeaderText = "Payment";
            this.PaymentMethodName.Name = "PaymentMethodName";
            this.PaymentMethodName.ReadOnly = true;
            this.PaymentMethodName.Width = 70;
            // 
            // PaymentFlag
            // 
            this.PaymentFlag.DataPropertyName = "PaymentFlag";
            this.PaymentFlag.HeaderText = "Payment Flag";
            this.PaymentFlag.Name = "PaymentFlag";
            this.PaymentFlag.ReadOnly = true;
            this.PaymentFlag.Visible = false;
            // 
            // KitchenOrderNo
            // 
            this.KitchenOrderNo.DataPropertyName = "KitchenOrderNo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KitchenOrderNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.KitchenOrderNo.HeaderText = "KOrd #";
            this.KitchenOrderNo.Name = "KitchenOrderNo";
            this.KitchenOrderNo.ReadOnly = true;
            this.KitchenOrderNo.Width = 60;
            // 
            // IID
            // 
            this.IID.DataPropertyName = "IID";
            this.IID.HeaderText = "IID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "dd MMM yy HH:mm";
            this.colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderDate.HeaderText = "Date / Time";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            this.colOrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderDate.Width = 120;
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.DataPropertyName = "CustomerDetails";
            this.CustomerDetails.HeaderText = "Cust/Table";
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.ReadOnly = true;
            this.CustomerDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDetails.Visible = false;
            this.CustomerDetails.Width = 70;
            // 
            // CalculatedValue
            // 
            this.CalculatedValue.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.CalculatedValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.CalculatedValue.HeaderText = "TOTAL";
            this.CalculatedValue.Name = "CalculatedValue";
            this.CalculatedValue.ReadOnly = true;
            this.CalculatedValue.Width = 75;
            // 
            // ordersViewDataConnector
            // 
            this.ordersViewDataConnector.DataSource = typeof(OrdersView);
            // 
            // ctlOrders
            // 
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.vScroll);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctlOrders";
            this.Size = new System.Drawing.Size(947, 625);
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewDataConnector)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void frmOrders_Load(object sender, System.EventArgs e)
        {
            if (bslayer.LoggedUser.AccessLevel != AccessLevels.User && bslayer.LoggedUser.AccessLevel != AccessLevels.Manager)
                btnDeleteOrder.Visible = true;
            lblTotal.Visible = !(bslayer.LoggedUser.AccessLevel == AccessLevels.User && !config.Standard_Users_Can_See_Session_Totals);
            btnUnsetPaymentMethod.Visible = !(bslayer.LoggedUser.AccessLevel == AccessLevels.User);
            LoadOrders(true);
        }

        private async Task LoadOrders(bool blnViewAllOrders)
        {
            try
            {
                DataTable dt = bslayer.GetAllOrdersForSessionDateOrderly(bslayer.shop.CurrentSessionIID, OrderByTypes.Descending);
                //Add columns here

                dt.Columns.Add("OrderItemsDetailed");
                dt.Columns.Add("StatusName");
                dt.Columns.Add("OrderTypeName");
                dt.Columns.Add("PaymentMethodName");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["StatusName"] = ((StatusFlags)int.Parse(dt.Rows[i]["Status"].ToString())).ToString();
                    dt.Rows[i]["OrderTypeName"] = ((OrderTypes)int.Parse(dt.Rows[i]["OrderType"].ToString())).ToString();
                    dt.Rows[i]["PaymentMethodName"] = ((PaymentMethods)int.Parse(dt.Rows[i]["Payment"].ToString())).ToString();
                }

                int maxdetailed = dt.Rows.Count > config.Order_List_Detailed_Orders_Max_Counter ? config.Order_List_Detailed_Orders_Max_Counter : dt.Rows.Count;
                rowheights = new List<int>();
                for (int i = 0; i < maxdetailed; i++)
                {
                    Order order = await bslayer.GetOrder(dt.Rows[i]["IID"].ToString());
                    dt.Rows[i]["OrderItemsDetailed"] = order.GetAllOrderItemsText();
                    rowheights.Add(order.Items.Count * 15 + 7);
                }
                dgv.DataSource = dt;


                string currentSessionIID = bslayer.shop.CurrentSessionIID;
                double cashTotal = bslayer.GetSessionPaymentSum(currentSessionIID, PaymentMethods.Cash);
                double cardTotal = bslayer.GetSessionPaymentSum(currentSessionIID, PaymentMethods.Card);
                double unpaidTotal = bslayer.GetSessionOrderSum(currentSessionIID) - cashTotal - cardTotal;

                lblTotal.Text = "Session Total : " + bslayer.GetCurrentSessionXSum().ToString("c") +
                    "  Cash= " + cashTotal.ToString("c") +
                    " ,Card= " + cardTotal.ToString("c") +
                    " ,Unpaid= " + unpaidTotal.ToString("c");




                vScroll.Maximum = dgv.RowCount;

            } catch (Exception ex)
            {
                string str = ex.Message;
            }
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DetachPanelEvent();
        }

        private void btnLoadOrder_Click(object sender, System.EventArgs e)
        {
            LoadSelectedOrder();
        }

        private async void LoadSelectedOrder()
        {
            string SelectedIID = "";
            Table table = null;
            if (dgv.SelectedRows.Count > 0)
            {
                SelectedIID = dgv.SelectedRows[0].Cells["IID"].Value.ToString();
                Order order = await bslayer.GetOrder(SelectedIID);
                if (order.OrderType == OrderTypes.InHouse)
                {
                    if (order.Status == StatusFlags.COMPLETED)
                    {
                        table = new Table()
                        {
                            TableName = "Temp" + order.IID,
                            TableCovers = order.Covers
                        };
                        order.TableIID = table.IID;
                        await bslayer.SaveOrder(order);
                        table.LockedClientIP = config.Terminal_Name;
                        table.AttachOrder(order);
                        table.CurrentOrderIID = order.IID;

                        bslayer.SaveTable(table);
                        await bslayer.BarrowTable(table.IID);
                    } else
                    {
                        table = await bslayer.BarrowTable(order.TableIID);
                    }
                    if (table == null)
                    {
                        MessageBox.Show("Order cannot be openned");
                        return;
                    } else
                    {
                        bslayer.AttachedOrder = table.AttachedOrder;
                        LoadAttachedOrderEvent();
                        DetachPanelEvent();
                    }
                } else
                {
                    order = await bslayer.BarrowOrder(order.IID, config.Terminal_Name);
                    bslayer.AttachedOrder = order;
                    LoadAttachedOrderEvent();
                    DetachPanelEvent();

                }
            }
        }

        private void btnDeleteOrder_Click(object sender, System.EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                    bslayer.DeleteOrder(dgv.SelectedRows[i].Cells["IID"].Value.ToString());
                LoadOrders(true);
            }
        }



        private void lvOrders_DoubleClick(object sender, System.EventArgs e)
        {
            LoadSelectedOrder();
        }



        private async void btnUnsetPaymentMethod_Click(object sender, EventArgs e)
        {
            string SelectedIID = "";
            if (dgv.SelectedRows.Count > 0)
            {
                SelectedIID = dgv.SelectedRows[0].Cells["IID"].Value.ToString();
                Order order = await bslayer.BarrowOrder(SelectedIID, config.Terminal_Name);

                if (order != null)
                {
                    order.Payment = PaymentMethods.NotPaid;
                    order.PaymentFlag = "";
                    await bslayer.SaveOrder(order);
                    await LoadOrders(true);
                }
            }
        }

        private async void chkDeliveryOrdersOnly_CheckedChanged(object sender, EventArgs e)
        {
            await LoadOrders(true);
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadSelectedOrder();
        }

        private async void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Order order = await bslayer.GetOrder(dgv.SelectedRows[0].Cells["IID"].Value.ToString());
                Printer printer = await bslayer.GetPrinterForOrderType(order.OrderType);
                if (printer != null)
                    bslayer.PrintReceipt(order.IID, printer, 1);
                else
                {
                    trmPrinterSelector trm = new trmPrinterSelector(bslayer, PrinterTypes.Receipt);
                    if (trm.ShowDialog() == DialogResult.OK)
                        bslayer.PrintReceipt(order.IID, trm.SelectedPrinter, 1);

                }

            }
        }



        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < rowheights.Count)
                dgv.Rows[e.RowIndex].Height = rowheights[e.RowIndex];
        }

        private void btnViewCustomerOrTable_Click(object sender, EventArgs e)
        {
            dgv.Columns["CustomerDetails"].Visible = !dgv.Columns["CustomerDetails"].Visible;
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue >= 0)
                dgv.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            vScroll.Value = e.NewValue;
        }

        private async void btnChangePaymentMethod_Click(object sender, EventArgs e)
        {
            string SelectedIID = "";
            if (dgv.SelectedRows.Count > 0)
            {
                SelectedIID = dgv.SelectedRows[0].Cells["IID"].Value.ToString();
                Order order = await bslayer.GetOrder(SelectedIID);
                if (order.OrderType == OrderTypes.InHouse)
                {
                    MessageBox.Show("IN HOUSE orders must be loaded in to the system to complete.");
                    return;
                }
                bslayer.AttachedOrder = await bslayer.BarrowOrder(SelectedIID, config.Terminal_Name);

                if (bslayer.AttachedOrder != null)
                {
                    if (((int)bslayer.AttachedOrder.Status) < ((int)StatusFlags.ARCHIVED))
                    {
                        if (bslayer.AttachedOrder.Payment == PaymentMethods.NotPaid)
                        {
                            PassControlEvent(new ctlPayment(new GenericFunctionCall(DetachPanelEvent),
                                new RemoteCompleteAttachedOrder(CompleteAttachedOrderEvent),
                                0, true, false, true));

                            return;
                        }
                        bslayer.AttachedOrder.Status = POSLayer.Library.StatusFlags.COMPLETED;
                       await bslayer.SaveOrder(bslayer.AttachedOrder);
                        UnloadOrderEvent();
                        PassControlEvent(this);
                        await LoadOrders(true);
                    }
                }
            }
        }
    }
}
