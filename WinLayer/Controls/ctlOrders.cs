using System.ComponentModel;
using System.Data;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Views;
using POSLayer.Repository.IRepository;

namespace WinLayer
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
        private Label lblTotal;
        private Button btnPrintReceipt;
        private System.ComponentModel.IContainer components;

        //This events required to call functions in frmMain
        public GenericFunctionCallAsync UnloadOrderEvent;
        public GenericFunctionCallAsync LoadAttachedOrderEvent;
        public GenericFunctionCallAsync DetachPanelEvent;
        public PassControl PassControlEvent;
        private Panel panel2;
        private Button btnViewCustomerOrTable;
        private VScrollBar vScroll;
        public RemoteCompleteAttachedOrderAsync CompleteAttachedOrderEvent;
        private Button btnChangePaymentMethod;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colOrderItemsDetailed;
        private DataGridViewTextBoxColumn StatusName;
        private DataGridViewTextBoxColumn OrderTypeName;
        private DataGridViewTextBoxColumn PaymentMethodName;
        private DataGridViewTextBoxColumn Total;

        private List<int> rowheights;
        public ctlOrders(PosConfig configAsService, IRepository<Order> _repoOrder)
        {
            InitializeComponent();
            config = configAsService;
            repoOrder = _repoOrder;
        }

        public ctlOrders(PosConfig configAsService, IRepository<Order> _repoOrder, IRepository<Masa> _repoTable, GenericFunctionCallAsync UnloadOrder,
            GenericFunctionCallAsync LoadAttachedOrder,
            GenericFunctionCallAsync DetachPanel,
            PassControl AttachPanel,
            RemoteCompleteAttachedOrderAsync CompleteAttachedOrder)
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnChangePaymentMethod = new Button();
            btnViewCustomerOrTable = new Button();
            btnLoadOrder = new Button();
            btnPrintReceipt = new Button();
            btnUnsetPaymentMethod = new Button();
            btnDeleteOrder = new Button();
            dgv = new DataGridView();
            orderBindingSource = new BindingSource(components);
            lblTotal = new Label();
            panel2 = new Panel();
            vScroll = new VScrollBar();
            colOrderDate = new DataGridViewTextBoxColumn();
            colOrderItemsDetailed = new DataGridViewTextBoxColumn();
            StatusName = new DataGridViewTextBoxColumn();
            OrderTypeName = new DataGridViewTextBoxColumn();
            PaymentMethodName = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((ISupportInitialize)dgv).BeginInit();
            ((ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnChangePaymentMethod);
            panel1.Controls.Add(btnViewCustomerOrTable);
            panel1.Controls.Add(btnLoadOrder);
            panel1.Controls.Add(btnPrintReceipt);
            panel1.Controls.Add(btnUnsetPaymentMethod);
            panel1.Controls.Add(btnDeleteOrder);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(947, 60);
            panel1.TabIndex = 2;
            // 
            // btnChangePaymentMethod
            // 
            btnChangePaymentMethod.AutoEllipsis = true;
            btnChangePaymentMethod.BackColor = Color.FromArgb(0, 192, 0);
            btnChangePaymentMethod.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangePaymentMethod.FlatAppearance.BorderSize = 0;
            btnChangePaymentMethod.FlatStyle = FlatStyle.Flat;
            btnChangePaymentMethod.Font = new Font("Arial", 16F, FontStyle.Bold);
            btnChangePaymentMethod.ForeColor = Color.FromArgb(0, 0, 0);
            btnChangePaymentMethod.Location = new Point(324, 4);
            btnChangePaymentMethod.Name = "btnChangePaymentMethod";
            btnChangePaymentMethod.Size = new Size(100, 50);
            btnChangePaymentMethod.TabIndex = 21;
            btnChangePaymentMethod.Text = "PAY";
            btnChangePaymentMethod.UseVisualStyleBackColor = false;
            btnChangePaymentMethod.Click += btnChangePaymentMethod_Click;
            // 
            // btnViewCustomerOrTable
            // 
            btnViewCustomerOrTable.AutoEllipsis = true;
            btnViewCustomerOrTable.BackColor = Color.FromArgb(255, 224, 192);
            btnViewCustomerOrTable.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewCustomerOrTable.FlatAppearance.BorderSize = 0;
            btnViewCustomerOrTable.FlatStyle = FlatStyle.Flat;
            btnViewCustomerOrTable.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewCustomerOrTable.ForeColor = Color.FromArgb(0, 0, 0);
            btnViewCustomerOrTable.Location = new Point(104, 4);
            btnViewCustomerOrTable.Name = "btnViewCustomerOrTable";
            btnViewCustomerOrTable.Size = new Size(58, 50);
            btnViewCustomerOrTable.TabIndex = 20;
            btnViewCustomerOrTable.Text = "CUST / TABLE";
            btnViewCustomerOrTable.UseVisualStyleBackColor = false;
            // 
            // btnLoadOrder
            // 
            btnLoadOrder.AutoEllipsis = true;
            btnLoadOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnLoadOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoadOrder.FlatAppearance.BorderSize = 0;
            btnLoadOrder.FlatStyle = FlatStyle.Flat;
            btnLoadOrder.Font = new Font("Arial", 16F, FontStyle.Bold);
            btnLoadOrder.ForeColor = Color.FromArgb(0, 0, 0);
            btnLoadOrder.Location = new Point(574, 4);
            btnLoadOrder.Margin = new Padding(0);
            btnLoadOrder.Name = "btnLoadOrder";
            btnLoadOrder.Size = new Size(100, 50);
            btnLoadOrder.TabIndex = 10;
            btnLoadOrder.TabStop = false;
            btnLoadOrder.Text = "LOAD";
            btnLoadOrder.UseVisualStyleBackColor = false;
            btnLoadOrder.Click += btnLoadOrder_Click;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.AutoEllipsis = true;
            btnPrintReceipt.BackColor = Color.Fuchsia;
            btnPrintReceipt.BackgroundImage = Properties.Resources.Print32;
            btnPrintReceipt.BackgroundImageLayout = ImageLayout.None;
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = Color.White;
            btnPrintReceipt.Location = new Point(447, 4);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.RightToLeft = RightToLeft.Yes;
            btnPrintReceipt.Size = new Size(100, 50);
            btnPrintReceipt.TabIndex = 19;
            btnPrintReceipt.Text = " PRINT RECEIPT";
            btnPrintReceipt.TextAlign = ContentAlignment.MiddleRight;
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // btnUnsetPaymentMethod
            // 
            btnUnsetPaymentMethod.AutoEllipsis = true;
            btnUnsetPaymentMethod.BackColor = Color.Red;
            btnUnsetPaymentMethod.BackgroundImageLayout = ImageLayout.Stretch;
            btnUnsetPaymentMethod.FlatAppearance.BorderSize = 0;
            btnUnsetPaymentMethod.FlatStyle = FlatStyle.Flat;
            btnUnsetPaymentMethod.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnUnsetPaymentMethod.ForeColor = Color.White;
            btnUnsetPaymentMethod.Location = new Point(186, 4);
            btnUnsetPaymentMethod.Name = "btnUnsetPaymentMethod";
            btnUnsetPaymentMethod.Size = new Size(113, 50);
            btnUnsetPaymentMethod.TabIndex = 17;
            btnUnsetPaymentMethod.Text = "NOT PAID";
            btnUnsetPaymentMethod.UseVisualStyleBackColor = false;
            btnUnsetPaymentMethod.Click += btnUnsetPaymentMethod_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.AutoEllipsis = true;
            btnDeleteOrder.BackColor = Color.FromArgb(128, 128, 255);
            btnDeleteOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteOrder.FlatAppearance.BorderSize = 0;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Font = new Font("Arial", 16F, FontStyle.Bold);
            btnDeleteOrder.ForeColor = Color.FromArgb(0, 0, 0);
            btnDeleteOrder.Location = new Point(6, 4);
            btnDeleteOrder.Margin = new Padding(0);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(75, 50);
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
            dgv.BackgroundColor = Color.Black;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colOrderDate, colOrderItemsDetailed, StatusName, OrderTypeName, PaymentMethodName, Total });
            dgv.DataSource = orderBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle7;
            dgv.Dock = DockStyle.Fill;
            dgv.GridColor = Color.FromArgb(208, 215, 229);
            dgv.Location = new Point(0, 87);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 20;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv.RowTemplate.Height = 50;
            dgv.RowTemplate.Resizable = DataGridViewTriState.True;
            dgv.ScrollBars = ScrollBars.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(864, 518);
            dgv.TabIndex = 4;
            dgv.CellMouseDoubleClick += dgv_CellMouseDoubleClick;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Black;
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(0, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(947, 27);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 605);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 20);
            panel2.TabIndex = 12;
            // 
            // vScroll
            // 
            vScroll.Dock = DockStyle.Right;
            vScroll.Location = new Point(864, 87);
            vScroll.Name = "vScroll";
            vScroll.Size = new Size(83, 518);
            vScroll.TabIndex = 13;
            vScroll.Visible = false;
            // 
            // colOrderDate
            // 
            colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Format = "dd MMM yy HH:mm";
            colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            colOrderDate.HeaderText = "Date / Time";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            colOrderDate.Resizable = DataGridViewTriState.True;
            colOrderDate.Width = 120;
            // 
            // colOrderItemsDetailed
            // 
            colOrderItemsDetailed.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colOrderItemsDetailed.DataPropertyName = "AllOrderItemsTextWithPrice";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            colOrderItemsDetailed.DefaultCellStyle = dataGridViewCellStyle2;
            colOrderItemsDetailed.HeaderText = "Order Items";
            colOrderItemsDetailed.Name = "colOrderItemsDetailed";
            colOrderItemsDetailed.ReadOnly = true;
            colOrderItemsDetailed.Width = 200;
            // 
            // StatusName
            // 
            StatusName.DataPropertyName = "Status";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusName.DefaultCellStyle = dataGridViewCellStyle3;
            StatusName.HeaderText = "Status";
            StatusName.Name = "StatusName";
            StatusName.ReadOnly = true;
            // 
            // OrderTypeName
            // 
            OrderTypeName.DataPropertyName = "OrderType";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderTypeName.DefaultCellStyle = dataGridViewCellStyle4;
            OrderTypeName.HeaderText = "Type";
            OrderTypeName.Name = "OrderTypeName";
            OrderTypeName.ReadOnly = true;
            OrderTypeName.Width = 70;
            // 
            // PaymentMethodName
            // 
            PaymentMethodName.DataPropertyName = "Payment";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentMethodName.DefaultCellStyle = dataGridViewCellStyle5;
            PaymentMethodName.HeaderText = "Payment";
            PaymentMethodName.Name = "PaymentMethodName";
            PaymentMethodName.ReadOnly = true;
            PaymentMethodName.Width = 80;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.Format = "N2";
            Total.DefaultCellStyle = dataGridViewCellStyle6;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 70;
            // 
            // ctlOrders
            // 
            Controls.Add(dgv);
            Controls.Add(vScroll);
            Controls.Add(lblTotal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ctlOrders";
            Size = new Size(947, 625);
            Load += frmOrders_Load;
            panel1.ResumeLayout(false);
            ((ISupportInitialize)dgv).EndInit();
            ((ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private async void frmOrders_Load(object sender, System.EventArgs e)
        {
            if (BSLayer.Instance.LoggedUser.AccessLevel != AccessLevels.User && BSLayer.Instance.LoggedUser.AccessLevel != AccessLevels.Manager)
                btnDeleteOrder.Visible = true;
            lblTotal.Visible = !(BSLayer.Instance.LoggedUser.AccessLevel == AccessLevels.User && !config.Standard_Users_Can_See_Session_Totals);
            btnUnsetPaymentMethod.Visible = !(BSLayer.Instance.LoggedUser.AccessLevel == AccessLevels.User);
            await LoadOrders(true);
        }

        private async Task LoadOrders(bool blnViewAllOrders)
        {
            try
            {
                List<Order> orders = await repoOrder.GetListByField("SessionIID", BSLayer.Instance.shop.CurrentSessionIID, "Items", "OrderDate");
                dgv.DataSource = orders;

                double cashTotal = orders.Where(x => x.Payment == PaymentMethods.Cash).Sum(x => x.Total);
                double cardTotal = orders.Where(x => x.Payment == PaymentMethods.Card).Sum(x => x.Total);
                double unpaidTotal = orders.Sum(x => x.Balance);

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
            if (dgv.SelectedRows.Count > 0)
            {
                Order order = dgv.SelectedRows[0].DataBoundItem as Order;
                order = await repoOrder.GetOrderToEditAsync(order.IID, config.Terminal_Name);
                BSLayer.Instance.AttachedOrder = order;
                await LoadAttachedOrderEvent();
                await DetachPanelEvent();
            }
        }

        private async void btnDeleteOrder_Click(object sender, System.EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    Order order = dgv.SelectedRows[i].DataBoundItem as Order;
                    if (order != null)
                        await repoOrder.Delete(order.IID);
                }
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
                Order order = dgv.SelectedRows[0].DataBoundItem as Order;
                if (order != null)
                {
                    order = await repoOrder.GetOrderToEditAsync(order.IID, config.Terminal_Name);
                    if (order != null)
                    {
                        order.Payment = PaymentMethods.NotPaid;
                        order.PaymentFlag = "";
                        await repoOrder.Save(order);
                        await LoadOrders(true);
                    }
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
                Order order = dgv.SelectedRows[0].DataBoundItem as Order;
                Printer printer = await BSLayer.Instance.GetPrinterForOrderType(order.OrderType);
                if (printer != null)
                    BSLayer.Instance.PrintReceipt(order, printer, 1);
                else
                {
                    trmPrinterSelector trm = new trmPrinterSelector(PrinterTypes.Receipt);
                    if (trm.ShowDialog() == DialogResult.OK)
                        BSLayer.Instance.PrintReceipt(order, trm.SelectedPrinter, 1);
                }
            }
        }

        private async void btnChangePaymentMethod_Click(object sender, EventArgs e)
        {
            string SelectedIID = "";
            if (dgv.SelectedRows.Count > 0)
            {
                SelectedIID = dgv.SelectedRows[0].Cells["IID"].Value.ToString();
                Order order = await BSLayer.Instance.GetOrder(SelectedIID);
                if (order.OrderType == OrderTypes.Sitin)
                {
                    MessageBox.Show("IN HOUSE orders must be loaded in to the system to complete.");
                    return;
                }
                BSLayer.Instance.AttachedOrder = await BSLayer.Instance.BarrowOrder(SelectedIID, config.Terminal_Name);

                if (BSLayer.Instance.AttachedOrder != null)
                {
                    if (((int)BSLayer.Instance.AttachedOrder.Status) < ((int)StatusFlags.Archived))
                    {
                        if (BSLayer.Instance.AttachedOrder.Payment == PaymentMethods.NotPaid)
                        {
                            PassControlEvent(new ctlPayment(new GenericFunctionCallAsync(DetachPanelEvent),
                                new RemoteCompleteAttachedOrderAsync(CompleteAttachedOrderEvent),
                                0, true, false, true));

                            return;
                        }
                        BSLayer.Instance.AttachedOrder.Status = POSLayer.Library.StatusFlags.Completed;
                        await BSLayer.Instance.SaveOrder(BSLayer.Instance.AttachedOrder);
                        await UnloadOrderEvent();
                        PassControlEvent(this);
                        await LoadOrders(true);
                    }
                }
            }
        }
    }
}
