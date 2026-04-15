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
using System.Linq;

namespace DTRMNS
{
    /// <summary>
    /// Summary description for frmOrders.
    /// </summary>
    public class ctlOrders : UserControl
    {
        PosConfig config;
        IRepository<Order> repoOrder;
        IRepository<Masa> repoTable;

        private System.Windows.Forms.Panel panel1;
        private Button btnLoadOrder;
        private Button btnDeleteOrder;
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
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colOrderItemsDetailed;
        private DataGridViewTextBoxColumn StatusName;
        private DataGridViewTextBoxColumn OrderTypeName;
        private DataGridViewTextBoxColumn PaymentMethodName;

        //private UtilityLibrary UF;
        private List<int> rowheights;
        public ctlOrders(PosConfig configAsService, IRepository<Order> _repoOrder)
        {
            InitializeComponent();
            config = configAsService;
            repoOrder = _repoOrder;
        }

        public ctlOrders(PosConfig configAsService, IRepository<Order> _repoOrder, IRepository<Masa> _repoTable, GenericFunctionCall UnloadOrder,
            GenericFunctionCall LoadAttachedOrder,
            GenericFunctionCall DetachPanel,
            PassControl AttachPanel,
            RemoteCompleteAttachedOrder CompleteAttachedOrder)
        {

            InitializeComponent();
            config = configAsService;
            repoOrder = _repoOrder;
            repoTable = _repoTable;

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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnChangePaymentMethod = new Button();
            btnViewCustomerOrTable = new Button();
            btnLoadOrder = new Button();
            btnPrintReceipt = new Button();
            btnUnsetPaymentMethod = new Button();
            btnDeleteOrder = new Button();
            dgv = new DataGridView();
            colOrderDate = new DataGridViewTextBoxColumn();
            colOrderItemsDetailed = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            OrderTypeName = new DataGridViewTextBoxColumn();
            PaymentMethodName = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            ordersViewDataConnector = new BindingSource(components);
            lblTotal = new Label();
            panel2 = new Panel();
            vScroll = new VScrollBar();
            panel1.SuspendLayout();
            ((ISupportInitialize)dgv).BeginInit();
            ((ISupportInitialize)orderBindingSource).BeginInit();
            ((ISupportInitialize)ordersViewDataConnector).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(btnChangePaymentMethod);
            panel1.Controls.Add(btnViewCustomerOrTable);
            panel1.Controls.Add(btnLoadOrder);
            panel1.Controls.Add(btnPrintReceipt);
            panel1.Controls.Add(btnUnsetPaymentMethod);
            panel1.Controls.Add(btnDeleteOrder);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new System.Drawing.Size(947, 60);
            panel1.TabIndex = 2;
            // 
            // btnChangePaymentMethod
            // 
            btnChangePaymentMethod.AutoEllipsis = true;
            btnChangePaymentMethod.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnChangePaymentMethod.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangePaymentMethod.FlatAppearance.BorderSize = 0;
            btnChangePaymentMethod.FlatStyle = FlatStyle.Flat;
            btnChangePaymentMethod.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            btnChangePaymentMethod.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnChangePaymentMethod.Location = new System.Drawing.Point(324, 4);
            btnChangePaymentMethod.Name = "btnChangePaymentMethod";
            btnChangePaymentMethod.Size = new System.Drawing.Size(100, 50);
            btnChangePaymentMethod.TabIndex = 21;
            btnChangePaymentMethod.Text = "PAY";
            btnChangePaymentMethod.UseVisualStyleBackColor = false;
            btnChangePaymentMethod.Click += btnChangePaymentMethod_Click;
            // 
            // btnViewCustomerOrTable
            // 
            btnViewCustomerOrTable.AutoEllipsis = true;
            btnViewCustomerOrTable.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            btnViewCustomerOrTable.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewCustomerOrTable.FlatAppearance.BorderSize = 0;
            btnViewCustomerOrTable.FlatStyle = FlatStyle.Flat;
            btnViewCustomerOrTable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnViewCustomerOrTable.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnViewCustomerOrTable.Location = new System.Drawing.Point(104, 4);
            btnViewCustomerOrTable.Name = "btnViewCustomerOrTable";
            btnViewCustomerOrTable.Size = new System.Drawing.Size(58, 50);
            btnViewCustomerOrTable.TabIndex = 20;
            btnViewCustomerOrTable.Text = "CUST / TABLE";
            btnViewCustomerOrTable.UseVisualStyleBackColor = false;
            btnViewCustomerOrTable.Click += btnViewCustomerOrTable_Click;
            // 
            // btnLoadOrder
            // 
            btnLoadOrder.AutoEllipsis = true;
            btnLoadOrder.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnLoadOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoadOrder.FlatAppearance.BorderSize = 0;
            btnLoadOrder.FlatStyle = FlatStyle.Flat;
            btnLoadOrder.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            btnLoadOrder.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnLoadOrder.Location = new System.Drawing.Point(574, 4);
            btnLoadOrder.Margin = new Padding(0);
            btnLoadOrder.Name = "btnLoadOrder";
            btnLoadOrder.Size = new System.Drawing.Size(100, 50);
            btnLoadOrder.TabIndex = 10;
            btnLoadOrder.TabStop = false;
            btnLoadOrder.Text = "LOAD";
            btnLoadOrder.UseVisualStyleBackColor = false;
            btnLoadOrder.Click += btnLoadOrder_Click;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.AutoEllipsis = true;
            btnPrintReceipt.BackColor = System.Drawing.Color.Fuchsia;
            btnPrintReceipt.BackgroundImage = Properties.Resources.Print32;
            btnPrintReceipt.BackgroundImageLayout = ImageLayout.None;
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            btnPrintReceipt.Location = new System.Drawing.Point(447, 4);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.RightToLeft = RightToLeft.Yes;
            btnPrintReceipt.Size = new System.Drawing.Size(100, 50);
            btnPrintReceipt.TabIndex = 19;
            btnPrintReceipt.Text = " PRINT RECEIPT";
            btnPrintReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // btnUnsetPaymentMethod
            // 
            btnUnsetPaymentMethod.AutoEllipsis = true;
            btnUnsetPaymentMethod.BackColor = System.Drawing.Color.Red;
            btnUnsetPaymentMethod.BackgroundImageLayout = ImageLayout.Stretch;
            btnUnsetPaymentMethod.FlatAppearance.BorderSize = 0;
            btnUnsetPaymentMethod.FlatStyle = FlatStyle.Flat;
            btnUnsetPaymentMethod.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            btnUnsetPaymentMethod.ForeColor = System.Drawing.Color.White;
            btnUnsetPaymentMethod.Location = new System.Drawing.Point(186, 4);
            btnUnsetPaymentMethod.Name = "btnUnsetPaymentMethod";
            btnUnsetPaymentMethod.Size = new System.Drawing.Size(113, 50);
            btnUnsetPaymentMethod.TabIndex = 17;
            btnUnsetPaymentMethod.Text = "NOT PAID";
            btnUnsetPaymentMethod.UseVisualStyleBackColor = false;
            btnUnsetPaymentMethod.Click += btnUnsetPaymentMethod_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.AutoEllipsis = true;
            btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            btnDeleteOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteOrder.FlatAppearance.BorderSize = 0;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            btnDeleteOrder.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnDeleteOrder.Location = new System.Drawing.Point(6, 4);
            btnDeleteOrder.Margin = new Padding(0);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new System.Drawing.Size(75, 50);
            btnDeleteOrder.TabIndex = 13;
            btnDeleteOrder.TabStop = false;
            btnDeleteOrder.Text = "VOID";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Visible = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.Black;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colOrderDate, colOrderItemsDetailed, StatusName, OrderTypeName, PaymentMethodName });
            dgv.DataSource = orderBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle6;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgv.Location = new System.Drawing.Point(0, 87);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 20;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgv.RowTemplate.Height = 30;
            dgv.RowTemplate.Resizable = DataGridViewTriState.True;
            dgv.ScrollBars = ScrollBars.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(864, 518);
            dgv.TabIndex = 4;
            dgv.CellMouseDoubleClick += dgv_CellMouseDoubleClick;
            dgv.CellPainting += dgv_CellPainting;
            dgv.RowPrePaint += dgv_RowPrePaint;
            dgv.Scroll += dgv_Scroll;
            // 
            // colOrderDate
            // 
            colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Format = "dd MMM yy HH:mm";
            colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            colOrderDate.HeaderText = "Date / Time";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            colOrderDate.Resizable = DataGridViewTriState.True;
            colOrderDate.Width = 150;
            // 
            // colOrderItemsDetailed
            // 
            colOrderItemsDetailed.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colOrderItemsDetailed.DataPropertyName = "AllOrderItemsTextWithPrice";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            colOrderItemsDetailed.DefaultCellStyle = dataGridViewCellStyle2;
            colOrderItemsDetailed.HeaderText = "Order Items";
            colOrderItemsDetailed.Name = "colOrderItemsDetailed";
            colOrderItemsDetailed.ReadOnly = true;
            colOrderItemsDetailed.Width = 300;
            // 
            // StatusName
            // 
            StatusName.DataPropertyName = "Status";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StatusName.DefaultCellStyle = dataGridViewCellStyle3;
            StatusName.HeaderText = "Status";
            StatusName.Name = "StatusName";
            StatusName.ReadOnly = true;
            StatusName.Width = 120;
            // 
            // OrderTypeName
            // 
            OrderTypeName.DataPropertyName = "OrderType";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            OrderTypeName.DefaultCellStyle = dataGridViewCellStyle4;
            OrderTypeName.HeaderText = "Order Type";
            OrderTypeName.Name = "OrderTypeName";
            OrderTypeName.ReadOnly = true;
            OrderTypeName.Width = 120;
            // 
            // PaymentMethodName
            // 
            PaymentMethodName.DataPropertyName = "Payment";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PaymentMethodName.DefaultCellStyle = dataGridViewCellStyle5;
            PaymentMethodName.HeaderText = "Payment";
            PaymentMethodName.Name = "PaymentMethodName";
            PaymentMethodName.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // ordersViewDataConnector
            // 
            ordersViewDataConnector.DataSource = typeof(OrdersView);
            // 
            // lblTotal
            // 
            lblTotal.BackColor = System.Drawing.Color.Black;
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(0, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(947, 27);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 605);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(947, 20);
            panel2.TabIndex = 12;
            // 
            // vScroll
            // 
            vScroll.Dock = DockStyle.Right;
            vScroll.Location = new System.Drawing.Point(864, 87);
            vScroll.Name = "vScroll";
            vScroll.Size = new System.Drawing.Size(83, 518);
            vScroll.TabIndex = 13;
            vScroll.Scroll += vScroll_Scroll;
            // 
            // ctlOrders
            // 
            Controls.Add(dgv);
            Controls.Add(vScroll);
            Controls.Add(lblTotal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "ctlOrders";
            Size = new System.Drawing.Size(947, 625);
            Load += frmOrders_Load;
            panel1.ResumeLayout(false);
            ((ISupportInitialize)dgv).EndInit();
            ((ISupportInitialize)orderBindingSource).EndInit();
            ((ISupportInitialize)ordersViewDataConnector).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private async void frmOrders_Load(object sender, System.EventArgs e)
        {
            if (DTRMSimpleBusiness.Instance.LoggedUser.AccessLevel != AccessLevels.User && DTRMSimpleBusiness.Instance.LoggedUser.AccessLevel != AccessLevels.Manager)
                btnDeleteOrder.Visible = true;
            lblTotal.Visible = !(DTRMSimpleBusiness.Instance.LoggedUser.AccessLevel == AccessLevels.User && !config.Standard_Users_Can_See_Session_Totals);
            btnUnsetPaymentMethod.Visible = !(DTRMSimpleBusiness.Instance.LoggedUser.AccessLevel == AccessLevels.User);
            await LoadOrders(true);
        }

        private async Task LoadOrders(bool blnViewAllOrders)
        {
            try
            {
                List<Order> orders = await repoOrder.GetListByField("SessionIID", DTRMSimpleBusiness.Instance.shop.CurrentSessionIID, "Items", "OrderDate");

                //DataTable dt =  DTRMSimpleBusiness.Instance.GetAllOrdersForSessionDateOrderly( DTRMSimpleBusiness.Instance.shop.CurrentSessionIID, OrderByTypes.Descending);


                //dt.Columns.Add("OrderItemsDetailed");
                //dt.Columns.Add("StatusName");
                //dt.Columns.Add("OrderTypeName");
                //dt.Columns.Add("PaymentMethodName");
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    dt.Rows[i]["StatusName"] = ((StatusFlags)int.Parse(dt.Rows[i]["Status"].ToString())).ToString();
                //    dt.Rows[i]["OrderTypeName"] = ((OrderTypes)int.Parse(dt.Rows[i]["OrderType"].ToString())).ToString();
                //    dt.Rows[i]["PaymentMethodName"] = ((PaymentMethods)int.Parse(dt.Rows[i]["Payment"].ToString())).ToString();
                //}

                //int maxdetailed = orders.Count > config.Order_List_Detailed_Orders_Max_Counter ? config.Order_List_Detailed_Orders_Max_Counter : orders.Count;
                //rowheights = new List<int>();
                //for (int i = 0; i < maxdetailed; i++)
                //{
                //    Order order = await  DTRMSimpleBusiness.Instance.GetOrder(dt.Rows[i]["IID"].ToString());
                //    dt.Rows[i]["OrderItemsDetailed"] = order.GetAllOrderItemsText();
                //    rowheights.Add(order.Items.Count * 15 + 7);
                //}
                dgv.DataSource = orders;


                // string currentSessionIID =  DTRMSimpleBusiness.Instance.shop.CurrentSessionIID;
                double cashTotal = orders.Where(x => x.Payment == PaymentMethods.Cash).Sum(x => x.Total); //   DTRMSimpleBusiness.Instance.GetSessionPaymentSum(currentSessionIID, PaymentMethods.Cash);
                double cardTotal = orders.Where(x => x.Payment == PaymentMethods.Card).Sum(x => x.Total); //  DTRMSimpleBusiness.Instance.GetSessionPaymentSum(currentSessionIID, PaymentMethods.Card);
                double unpaidTotal = orders.Sum(x => x.Balance); //  DTRMSimpleBusiness.Instance.GetSessionOrderSum(currentSessionIID) - cashTotal - cardTotal;

                //lblTotal.Text = "Session Total : " +  DTRMSimpleBusiness.Instance.GetCurrentSessionXSum().ToString("c") +
                //    "  Cash= " + cashTotal.ToString("c") +
                //    " ,Card= " + cardTotal.ToString("c") +
                //    " ,Unpaid= " + unpaidTotal.ToString("c");

                lblTotal.Text = "Session Total : " + orders.Sum(x => x.Total).ToString("c") +
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
            Masa table = null;
            if (dgv.SelectedRows.Count > 0)
            {
               // SelectedIID = dgv.SelectedRows[0].Cells["IID"].Value.ToString();
                Order order = dgv.SelectedRows[0].DataBoundItem as Order; // await DTRMSimpleBusiness.Instance.GetOrder(SelectedIID);
                if (order.OrderType == OrderTypes.Sitin)
                {
                    if (order.Status == StatusFlags.Completed)
                    {
                        //table = new Masa()
                        //{
                        //    TableName = "Temp" + order.IID,
                        //    TableCovers = order.Covers
                        //};
                        //order.TableIID = table.IID;
                        //await repoOrder.Save(order); // DTRMSimpleBusiness.Instance.SaveOrder(order);
                        //table.LockedClientIP = config.Terminal_Name;
                        //table.AttachOrder(order);

                        //await repoTable.Save(table); // DTRMSimpleBusiness.Instance.SaveTable(table);
                        //await DTRMSimpleBusiness.Instance.BarrowTable(table.IID);
                    } else
                    {
                        table = await DTRMSimpleBusiness.Instance.BarrowTable(order.TableIID);
                    }
                    if (table == null)
                    {
                        MessageBox.Show("Order cannot be openned");
                        return;
                    } else
                    {
                        DTRMSimpleBusiness.Instance.AttachedOrder = table.AttachedOrder;
                        LoadAttachedOrderEvent();
                        DetachPanelEvent();
                    }
                } else
                {
                    order = await DTRMSimpleBusiness.Instance.BarrowOrder(order.IID, config.Terminal_Name);
                    DTRMSimpleBusiness.Instance.AttachedOrder = order;
                    LoadAttachedOrderEvent();
                    DetachPanelEvent();

                }
            }
        }

        private async void btnDeleteOrder_Click(object sender, System.EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                    await DTRMSimpleBusiness.Instance.DeleteOrder(dgv.SelectedRows[i].Cells["IID"].Value.ToString());
                await LoadOrders(true);
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
                Order order = await DTRMSimpleBusiness.Instance.BarrowOrder(SelectedIID, config.Terminal_Name);

                if (order != null)
                {
                    order.Payment = PaymentMethods.NotPaid;
                    order.PaymentFlag = "";
                    await DTRMSimpleBusiness.Instance.SaveOrder(order);
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
                Order order = await DTRMSimpleBusiness.Instance.GetOrder(dgv.SelectedRows[0].Cells["IID"].Value.ToString());
                Printer printer = await DTRMSimpleBusiness.Instance.GetPrinterForOrderType(order.OrderType);
                if (printer != null)
                    DTRMSimpleBusiness.Instance.PrintReceipt(order.IID, printer, 1);
                else
                {
                    trmPrinterSelector trm = new trmPrinterSelector(PrinterTypes.Receipt);
                    if (trm.ShowDialog() == DialogResult.OK)
                        DTRMSimpleBusiness.Instance.PrintReceipt(order.IID, trm.SelectedPrinter, 1);

                }

            }
        }



        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex < 5 && e.RowIndex >= 0)
            //{
            //    Order order = (dgv.Rows[e.RowIndex].DataBoundItem as Order);

            //    dgv.Rows[e.RowIndex].Height = order.Items.Count * 20 + 10;
            //}
            
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 5 && e.RowIndex >= 0)
            {
                Order order = (dgv.Rows[e.RowIndex].DataBoundItem as Order);

                dgv.Rows[e.RowIndex].Height = order.Items.Count * 20 + 10;
            }

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
                Order order = await DTRMSimpleBusiness.Instance.GetOrder(SelectedIID);
                if (order.OrderType == OrderTypes.Sitin)
                {
                    MessageBox.Show("IN HOUSE orders must be loaded in to the system to complete.");
                    return;
                }
                DTRMSimpleBusiness.Instance.AttachedOrder = await DTRMSimpleBusiness.Instance.BarrowOrder(SelectedIID, config.Terminal_Name);

                if (DTRMSimpleBusiness.Instance.AttachedOrder != null)
                {
                    if (((int)DTRMSimpleBusiness.Instance.AttachedOrder.Status) < ((int)StatusFlags.Archived))
                    {
                        if (DTRMSimpleBusiness.Instance.AttachedOrder.Payment == PaymentMethods.NotPaid)
                        {
                            PassControlEvent(new ctlPayment(new GenericFunctionCall(DetachPanelEvent),
                                new RemoteCompleteAttachedOrder(CompleteAttachedOrderEvent),
                                0, true, false, true));

                            return;
                        }
                        DTRMSimpleBusiness.Instance.AttachedOrder.Status = POSLayer.Library.StatusFlags.Completed;
                        await DTRMSimpleBusiness.Instance.SaveOrder(DTRMSimpleBusiness.Instance.AttachedOrder);
                        UnloadOrderEvent();
                        PassControlEvent(this);
                        await LoadOrders(true);
                    }
                }
            }
        }

        
    }
}
