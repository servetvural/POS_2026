using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;


namespace DTRMNS
{
    /// <summary>
    /// Summary description for OrderDisplay.
    /// </summary>
    public class OrderDisplay : System.Windows.Forms.UserControl
    {
        PosConfig config;
        IRepository<OrderItem> repoOrderItem;

        private System.Windows.Forms.ColumnHeader IID;
        private System.Windows.Forms.ColumnHeader cOrderItemText;
        private System.Windows.Forms.ColumnHeader cQuantity;
        private System.Windows.Forms.ColumnHeader cTotal;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colOrderItemText;


        private ListView lvwOrder;

        private Panel pnlDown;
        private Label lblScrollDown;

        private Panel pnlCommand;
        private Button btnPlus1;
        private Button btnMinusOne;
        private Button btnDeleteItem;
        private Timer tmrSaat;

        private System.ComponentModel.IContainer components;
        private ImageList ilSmall;
        private Panel pnlTop;
        private Label lblScrollUp;
        private ListView lvwSplittingOrder;
        private ColumnHeader cSplitIID;
        private ColumnHeader cSplitQuantity;
        private ColumnHeader cSplitOrderItemText;
        private ColumnHeader cSplitTotal;
        private Panel pnlSplit;
        private Panel pnlSplitActions;
        private Button btnSplitOneDown;
        private Button btnSplitOneUp;
        private Button btnSplitAllDown;
        private Button btnSplitAllUp;
        private Button btnSplit;
        public bool blnShrinkOrder;


        private Order _OrderToSplit;
        private ColumnHeader cCompletedQuantity;
        private Button btnViewKitchen;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Order OrderToSplit { get { return _OrderToSplit; } set { _OrderToSplit = value; } }

        public SplittingStatus SplitStatus = SplittingStatus.Normal;

        public event GenericFunctionCall DisplayOccured;
        public void OnDisplayOccured()
        {
            if (DisplayOccured != null)
                DisplayOccured();
        }

        public event GenericFunctionCall TopItemDeleted;
        public void OnTopItemDeleted()
        {
            if (TopItemDeleted != null)
                TopItemDeleted();
        }

        public event GenericFunctionCall SplitStarting;
        public void OnSplitStarting()
        {
            if (SplitStarting != null)
                SplitStarting();
        }

        public event GenericFunctionCall SplitContinuing;
        public void OnSplitContinuing()
        {
            if (SplitContinuing != null)
                SplitContinuing();
        }

        public event GenericFunctionCall SplitEnding;
        public void OnSplitEnding()
        {
            if (SplitEnding != null)
                SplitEnding();
        }

        public event GenericFunctionCall ZeroItemsLeft;
        public void OnZeroItemsLeft()
        {
            if (ZeroItemsLeft != null)
                ZeroItemsLeft();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SplitDisplayHeight { get { return pnlSplit.Height; } set { pnlSplit.Height = value; } }

        public OrderDisplay()
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoOrderItem = ServiceHelper.GetService<IRepository<OrderItem>>();
        }

        public void AttachBusinessLayer()
        {
            try
            {
                if (config != null)
                {
                    ilSmall.ImageSize = new Size((int)config.Order_Item_Display_Height, (int)config.Order_Item_Display_Height);
                    DTRMSimpleBusiness.Instance.DisplayOrder += new GenericFunctionCall(Display);
                }
            } catch
            {
                ilSmall.ImageSize = new Size(16, 16);
            }
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

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            IID = new ColumnHeader();
            cQuantity = new ColumnHeader();
            cOrderItemText = new ColumnHeader();
            cTotal = new ColumnHeader();
            colQty = new ColumnHeader();
            colOrderItemText = new ColumnHeader();
            lvwOrder = new ListView();
            cCompletedQuantity = new ColumnHeader();
            ilSmall = new ImageList(components);
            pnlDown = new Panel();
            lblScrollDown = new Label();
            pnlCommand = new Panel();
            btnViewKitchen = new Button();
            btnPlus1 = new Button();
            btnMinusOne = new Button();
            btnDeleteItem = new Button();
            tmrSaat = new Timer(components);
            pnlTop = new Panel();
            btnSplit = new Button();
            lblScrollUp = new Label();
            lvwSplittingOrder = new ListView();
            cSplitIID = new ColumnHeader();
            cSplitQuantity = new ColumnHeader();
            cSplitOrderItemText = new ColumnHeader();
            cSplitTotal = new ColumnHeader();
            pnlSplit = new Panel();
            pnlSplitActions = new Panel();
            btnSplitAllUp = new Button();
            btnSplitAllDown = new Button();
            btnSplitOneUp = new Button();
            btnSplitOneDown = new Button();
            pnlDown.SuspendLayout();
            pnlCommand.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlSplit.SuspendLayout();
            pnlSplitActions.SuspendLayout();
            SuspendLayout();
            // 
            // IID
            // 
            IID.Text = "";
            IID.Width = 0;
            // 
            // cQuantity
            // 
            cQuantity.Text = "";
            cQuantity.Width = 40;
            // 
            // cOrderItemText
            // 
            cOrderItemText.Text = "Order Items";
            cOrderItemText.Width = 230;
            // 
            // cTotal
            // 
            cTotal.Text = "Price";
            cTotal.TextAlign = HorizontalAlignment.Right;
            cTotal.Width = 90;
            // 
            // lvwOrder
            // 
            lvwOrder.BackColor = Color.Black;
            lvwOrder.BackgroundImageTiled = true;
            lvwOrder.BorderStyle = BorderStyle.None;
            lvwOrder.Columns.AddRange(new ColumnHeader[] { IID, cQuantity, cOrderItemText, cTotal, cCompletedQuantity });
            lvwOrder.Dock = DockStyle.Fill;
            lvwOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvwOrder.ForeColor = Color.White;
            lvwOrder.FullRowSelect = true;
            lvwOrder.HeaderStyle = ColumnHeaderStyle.None;
            lvwOrder.Location = new Point(0, 400);
            lvwOrder.MultiSelect = false;
            lvwOrder.Name = "lvwOrder";
            lvwOrder.Size = new Size(400, 291);
            lvwOrder.SmallImageList = ilSmall;
            lvwOrder.TabIndex = 0;
            lvwOrder.UseCompatibleStateImageBehavior = false;
            lvwOrder.View = View.Details;
            lvwOrder.ItemSelectionChanged += lvwOrder_ItemSelectionChanged;
            lvwOrder.SelectedIndexChanged += lvwOrder_SelectedIndexChanged;
            lvwOrder.Click += lvwOrder_Click;
            lvwOrder.Resize += lvwOrder_Resize;
            // 
            // cCompletedQuantity
            // 
            cCompletedQuantity.Text = "";
            cCompletedQuantity.TextAlign = HorizontalAlignment.Right;
            cCompletedQuantity.Width = 0;
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = ColorDepth.Depth16Bit;
            ilSmall.ImageSize = new Size(64, 64);
            ilSmall.TransparentColor = Color.Transparent;
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.Black;
            pnlDown.Controls.Add(lblScrollDown);
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.Location = new Point(0, 691);
            pnlDown.Name = "pnlDown";
            pnlDown.Size = new Size(400, 42);
            pnlDown.TabIndex = 27;
            // 
            // lblScrollDown
            // 
            lblScrollDown.BackColor = Color.Black;
            lblScrollDown.Dock = DockStyle.Fill;
            lblScrollDown.Font = new Font("Arial", 14F);
            lblScrollDown.ForeColor = Color.White;
            lblScrollDown.Location = new Point(0, 0);
            lblScrollDown.Name = "lblScrollDown";
            lblScrollDown.Size = new Size(400, 42);
            lblScrollDown.TabIndex = 0;
            lblScrollDown.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlCommand
            // 
            pnlCommand.BackColor = Color.Black;
            pnlCommand.Controls.Add(btnViewKitchen);
            pnlCommand.Controls.Add(btnPlus1);
            pnlCommand.Controls.Add(btnMinusOne);
            pnlCommand.Controls.Add(btnDeleteItem);
            pnlCommand.Dock = DockStyle.Top;
            pnlCommand.Location = new Point(0, 357);
            pnlCommand.Name = "pnlCommand";
            pnlCommand.Padding = new Padding(0, 4, 0, 0);
            pnlCommand.Size = new Size(400, 43);
            pnlCommand.TabIndex = 28;
            // 
            // btnViewKitchen
            // 
            btnViewKitchen.AutoEllipsis = true;
            btnViewKitchen.BackColor = Color.Black;
            btnViewKitchen.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewKitchen.Dock = DockStyle.Right;
            btnViewKitchen.FlatAppearance.BorderSize = 0;
            btnViewKitchen.FlatStyle = FlatStyle.Flat;
            btnViewKitchen.Font = new Font("Arial", 26F, FontStyle.Bold);
            btnViewKitchen.ForeColor = Color.White;
            btnViewKitchen.Image = Properties.Resources.chef32;
            btnViewKitchen.Location = new Point(330, 4);
            btnViewKitchen.Margin = new Padding(1);
            btnViewKitchen.Name = "btnViewKitchen";
            btnViewKitchen.Size = new Size(70, 39);
            btnViewKitchen.TabIndex = 27;
            btnViewKitchen.UseVisualStyleBackColor = false;
            btnViewKitchen.Click += btnViewKitchen_Click;
            // 
            // btnPlus1
            // 
            btnPlus1.AutoEllipsis = true;
            btnPlus1.BackColor = Color.Black;
            btnPlus1.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlus1.Dock = DockStyle.Left;
            btnPlus1.FlatAppearance.BorderSize = 0;
            btnPlus1.FlatStyle = FlatStyle.Flat;
            btnPlus1.Font = new Font("Arial", 26F, FontStyle.Bold);
            btnPlus1.ForeColor = Color.White;
            btnPlus1.Image = Properties.Resources.arti148;
            btnPlus1.Location = new Point(130, 4);
            btnPlus1.Margin = new Padding(1);
            btnPlus1.Name = "btnPlus1";
            btnPlus1.Size = new Size(70, 39);
            btnPlus1.TabIndex = 26;
            btnPlus1.UseVisualStyleBackColor = false;
            btnPlus1.Click += btnPlus1_Click;
            // 
            // btnMinusOne
            // 
            btnMinusOne.AutoEllipsis = true;
            btnMinusOne.BackColor = Color.Black;
            btnMinusOne.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinusOne.Dock = DockStyle.Left;
            btnMinusOne.FlatAppearance.BorderSize = 0;
            btnMinusOne.FlatStyle = FlatStyle.Flat;
            btnMinusOne.Font = new Font("Arial", 26F, FontStyle.Bold);
            btnMinusOne.ForeColor = Color.White;
            btnMinusOne.Image = Properties.Resources.eksi148;
            btnMinusOne.Location = new Point(60, 4);
            btnMinusOne.Margin = new Padding(1);
            btnMinusOne.Name = "btnMinusOne";
            btnMinusOne.Size = new Size(70, 39);
            btnMinusOne.TabIndex = 25;
            btnMinusOne.UseVisualStyleBackColor = false;
            btnMinusOne.Click += btnMinusOne_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.AutoEllipsis = true;
            btnDeleteItem.BackColor = Color.Black;
            btnDeleteItem.BackgroundImage = Properties.Resources.eksi48;
            btnDeleteItem.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteItem.Dock = DockStyle.Left;
            btnDeleteItem.FlatAppearance.BorderSize = 0;
            btnDeleteItem.FlatStyle = FlatStyle.Flat;
            btnDeleteItem.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDeleteItem.ForeColor = Color.White;
            btnDeleteItem.Location = new Point(0, 4);
            btnDeleteItem.Margin = new Padding(1);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(60, 39);
            btnDeleteItem.TabIndex = 24;
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // tmrSaat
            // 
            tmrSaat.Interval = 1000;
            tmrSaat.Tick += tmrSaat_Tick;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Black;
            pnlTop.Controls.Add(btnSplit);
            pnlTop.Controls.Add(lblScrollUp);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(400, 42);
            pnlTop.TabIndex = 27;
            // 
            // btnSplit
            // 
            btnSplit.AutoEllipsis = true;
            btnSplit.BackColor = Color.Black;
            btnSplit.BackgroundImageLayout = ImageLayout.Stretch;
            btnSplit.Dock = DockStyle.Left;
            btnSplit.FlatAppearance.BorderSize = 0;
            btnSplit.FlatStyle = FlatStyle.Flat;
            btnSplit.Font = new Font("Arial", 26F, FontStyle.Bold);
            btnSplit.ForeColor = Color.White;
            btnSplit.Image = Properties.Resources.Split32Down;
            btnSplit.Location = new Point(0, 0);
            btnSplit.Margin = new Padding(1);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(70, 42);
            btnSplit.TabIndex = 27;
            btnSplit.UseVisualStyleBackColor = false;
            btnSplit.Visible = false;
            btnSplit.Click += btnSplit_Click;
            // 
            // lblScrollUp
            // 
            lblScrollUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScrollUp.ForeColor = Color.White;
            lblScrollUp.Location = new Point(130, 0);
            lblScrollUp.Name = "lblScrollUp";
            lblScrollUp.Size = new Size(190, 42);
            lblScrollUp.TabIndex = 26;
            lblScrollUp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lvwSplittingOrder
            // 
            lvwSplittingOrder.BackColor = Color.Black;
            lvwSplittingOrder.BackgroundImageTiled = true;
            lvwSplittingOrder.BorderStyle = BorderStyle.None;
            lvwSplittingOrder.Columns.AddRange(new ColumnHeader[] { cSplitIID, cSplitQuantity, cSplitOrderItemText, cSplitTotal });
            lvwSplittingOrder.Dock = DockStyle.Fill;
            lvwSplittingOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvwSplittingOrder.ForeColor = Color.White;
            lvwSplittingOrder.FullRowSelect = true;
            lvwSplittingOrder.HeaderStyle = ColumnHeaderStyle.None;
            lvwSplittingOrder.Location = new Point(0, 0);
            lvwSplittingOrder.MultiSelect = false;
            lvwSplittingOrder.Name = "lvwSplittingOrder";
            lvwSplittingOrder.Size = new Size(400, 273);
            lvwSplittingOrder.SmallImageList = ilSmall;
            lvwSplittingOrder.TabIndex = 30;
            lvwSplittingOrder.UseCompatibleStateImageBehavior = false;
            lvwSplittingOrder.View = View.Details;
            lvwSplittingOrder.Resize += lvwSplittingOrder_Resize;
            // 
            // cSplitIID
            // 
            cSplitIID.Text = "";
            cSplitIID.Width = 0;
            // 
            // cSplitQuantity
            // 
            cSplitQuantity.Text = "";
            cSplitQuantity.Width = 40;
            // 
            // cSplitOrderItemText
            // 
            cSplitOrderItemText.Text = "Order Items";
            cSplitOrderItemText.Width = 230;
            // 
            // cSplitTotal
            // 
            cSplitTotal.Text = "Price";
            cSplitTotal.TextAlign = HorizontalAlignment.Right;
            cSplitTotal.Width = 90;
            // 
            // pnlSplit
            // 
            pnlSplit.BackColor = Color.Black;
            pnlSplit.Controls.Add(lvwSplittingOrder);
            pnlSplit.Controls.Add(pnlSplitActions);
            pnlSplit.Dock = DockStyle.Top;
            pnlSplit.Location = new Point(0, 42);
            pnlSplit.Name = "pnlSplit";
            pnlSplit.Size = new Size(400, 315);
            pnlSplit.TabIndex = 31;
            pnlSplit.Visible = false;
            // 
            // pnlSplitActions
            // 
            pnlSplitActions.BackColor = Color.Black;
            pnlSplitActions.Controls.Add(btnSplitAllUp);
            pnlSplitActions.Controls.Add(btnSplitAllDown);
            pnlSplitActions.Controls.Add(btnSplitOneUp);
            pnlSplitActions.Controls.Add(btnSplitOneDown);
            pnlSplitActions.Dock = DockStyle.Bottom;
            pnlSplitActions.Location = new Point(0, 273);
            pnlSplitActions.Name = "pnlSplitActions";
            pnlSplitActions.Size = new Size(400, 42);
            pnlSplitActions.TabIndex = 31;
            // 
            // btnSplitAllUp
            // 
            btnSplitAllUp.BackColor = Color.Black;
            btnSplitAllUp.BackgroundImage = Properties.Resources.BlueMultiUp;
            btnSplitAllUp.BackgroundImageLayout = ImageLayout.Zoom;
            btnSplitAllUp.Dock = DockStyle.Left;
            btnSplitAllUp.FlatStyle = FlatStyle.Flat;
            btnSplitAllUp.Location = new Point(210, 0);
            btnSplitAllUp.Name = "btnSplitAllUp";
            btnSplitAllUp.Size = new Size(70, 42);
            btnSplitAllUp.TabIndex = 0;
            btnSplitAllUp.UseVisualStyleBackColor = false;
            btnSplitAllUp.Click += btnSplitAllUp_Click;
            // 
            // btnSplitAllDown
            // 
            btnSplitAllDown.BackColor = Color.Black;
            btnSplitAllDown.BackgroundImage = Properties.Resources.BlueMultiDown;
            btnSplitAllDown.BackgroundImageLayout = ImageLayout.Zoom;
            btnSplitAllDown.Dock = DockStyle.Left;
            btnSplitAllDown.FlatStyle = FlatStyle.Flat;
            btnSplitAllDown.Location = new Point(140, 0);
            btnSplitAllDown.Name = "btnSplitAllDown";
            btnSplitAllDown.Size = new Size(70, 42);
            btnSplitAllDown.TabIndex = 1;
            btnSplitAllDown.UseVisualStyleBackColor = false;
            btnSplitAllDown.Click += btnSplitAllDown_Click;
            // 
            // btnSplitOneUp
            // 
            btnSplitOneUp.BackColor = Color.Black;
            btnSplitOneUp.BackgroundImage = Properties.Resources.BlueUp;
            btnSplitOneUp.BackgroundImageLayout = ImageLayout.Zoom;
            btnSplitOneUp.Dock = DockStyle.Left;
            btnSplitOneUp.FlatStyle = FlatStyle.Flat;
            btnSplitOneUp.Location = new Point(70, 0);
            btnSplitOneUp.Name = "btnSplitOneUp";
            btnSplitOneUp.Size = new Size(70, 42);
            btnSplitOneUp.TabIndex = 2;
            btnSplitOneUp.UseVisualStyleBackColor = false;
            btnSplitOneUp.Click += btnSplitOneUp_Click;
            // 
            // btnSplitOneDown
            // 
            btnSplitOneDown.BackColor = Color.Black;
            btnSplitOneDown.BackgroundImage = Properties.Resources.BlueDown;
            btnSplitOneDown.BackgroundImageLayout = ImageLayout.Zoom;
            btnSplitOneDown.Dock = DockStyle.Left;
            btnSplitOneDown.FlatStyle = FlatStyle.Flat;
            btnSplitOneDown.Location = new Point(0, 0);
            btnSplitOneDown.Name = "btnSplitOneDown";
            btnSplitOneDown.Size = new Size(70, 42);
            btnSplitOneDown.TabIndex = 3;
            btnSplitOneDown.UseVisualStyleBackColor = false;
            btnSplitOneDown.Click += btnSplitOneDown_Click;
            // 
            // OrderDisplay
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            Controls.Add(lvwOrder);
            Controls.Add(pnlCommand);
            Controls.Add(pnlDown);
            Controls.Add(pnlSplit);
            Controls.Add(pnlTop);
            Cursor = Cursors.Hand;
            Name = "OrderDisplay";
            Size = new Size(400, 733);
            pnlDown.ResumeLayout(false);
            pnlCommand.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlSplit.ResumeLayout(false);
            pnlSplitActions.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        private void DisplaySplittingOrder()
        {
            if (OrderToSplit == null)
                return;
            lvwSplittingOrder.Items.Clear();
            foreach (OrderItem oi in OrderToSplit.Items)
            {
                lvwSplittingOrder.Items.Add(new ListViewItem(new string[] { oi.IID, oi.Quantity.ToString(), oi.OrderItemText, oi.Total.ToString("N2") }));
            }
        }

        public async void Display()
        {
            Color GroupBackColor = Color.LightGray;
            string GroupIID = "";

            btnSplit.Visible = false;

            if (DTRMSimpleBusiness.Instance.AttachedOrder != null)
            {
                btnViewKitchen.Visible = config.Display_Kitchen_Chef_on_Display &&
                    ((DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sale && config.Hold_Order_Available && config.Hold_Order_Display_in_Kitchen) ||
                    (DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sitin && config.Table_Orders_Allowed && config.Table_Orders_Display_Kitchen_Orders));

                cCompletedQuantity.Width = (btnViewKitchen.Visible ? 28 : 0);
            }

            pnlCommand.Height = (DTRMSimpleBusiness.Instance.AttachedOrder != null && DTRMSimpleBusiness.Instance.AttachedOrder.Items.Count > 0) ? 54 : 0;
            string[] arr = null;
            ListViewItem lvi;
            //  OrderItem oi;
            double SingleTotal = 0f;
            double SubTotal = 0f;
            double OrderTotal = 0f;
            bool blnHasSubItems = false;

            Clear(false);

            OnDisplayOccured();

            if (DTRMSimpleBusiness.Instance.AttachedOrder == null && OrderToSplit == null)
                btnSplit.Visible = false;

            if (DTRMSimpleBusiness.Instance.AttachedOrder == null && OrderToSplit != null && OrderToSplit.Items.Count == 0)
            {
                //Now Ordertosplit must be deleted
                await DTRMSimpleBusiness.Instance.DeleteOrder(OrderToSplit.IID);
                OrderToSplit = null;
                SplitStatus = SplittingStatus.Normal;
                btnSplit.Visible = false;
                pnlSplit.Visible = false;
            }

            if (DTRMSimpleBusiness.Instance.AttachedOrder == null)
                return;


            switch (DTRMSimpleBusiness.Instance.AttachedOrder.Status)
            {
                case StatusFlags.New:
                    switch (SplitStatus)
                    {
                        case SplittingStatus.Normal:
                            btnSplit.Image = Properties.Resources.Split32Down;
                            btnSplit.Visible = false; // OrderToDisplay.items.Count > 0;                            
                            pnlSplit.Visible = false;
                            break;
                        case SplittingStatus.Splitting:
                            btnSplit.Image = Properties.Resources.Splitin32Up;
                            btnSplit.Visible = true;
                            pnlSplit.Visible = true;
                            DisplaySplittingOrder();
                            break;
                    }
                    break;
                case StatusFlags.Holding:
                case StatusFlags.Done:
                    switch (SplitStatus)
                    {
                        case SplittingStatus.Normal:
                            btnSplit.Image = Properties.Resources.Split32Down;

                            if (DTRMSimpleBusiness.Instance.AttachedOrder.Items.Count == 1 && DTRMSimpleBusiness.Instance.AttachedOrder.Items[0].Quantity == 1)
                                btnSplit.Visible = false;
                            else
                                btnSplit.Visible = true;

                            pnlSplit.Visible = false;
                            break;
                        case SplittingStatus.Splitting:
                            btnSplit.Image = Properties.Resources.Split32Down;
                            btnSplit.Visible = false;
                            pnlSplit.Visible = false;
                            break;
                    }
                    break;
            }


            string strCompletedQuantity = "";
            //for (int i = 0; i < DTRMSimpleBusiness.Instance.AttachedOrder.Items.Count; i++)
            foreach (var oi in DTRMSimpleBusiness.Instance.AttachedOrder.Items)
            {

                //Display Top Item
                blnHasSubItems = false;
                //oi = (OrderItem)DTRMSimpleBusiness.Instance.AttachedOrder.Items[i];
                SingleTotal = oi.Price * oi.Quantity;


                if ((config.Table_Orders_Display_Kitchen_Orders || config.Table_Orders_Kitchen_Receipt_Count > 0 || config.Hold_Order_Display_in_Kitchen || config.Hold_Order_Print_in_Kitchen) &&
                    (DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sale || DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sitin) &&
                    OrderToSplit == null && (DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.New || DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Done || DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Holding))
                {
                    if (config.Display_Kitchen_Orders_As_Reminders)
                    {
                        strCompletedQuantity = (oi.Quantity - oi.CompletedQuantity < 0 ? 0 : oi.Quantity - oi.CompletedQuantity).ToString("f0");
                        if (strCompletedQuantity == "0")
                            strCompletedQuantity = "";
                    } else
                        strCompletedQuantity = oi.CompletedQuantity.ToString("f0");
                }



                arr = new String[5]{oi.IID, oi.Quantity.ToString("f0"),
                                        oi.OrderItemText ,
                                         oi.Total.ToString("c"),strCompletedQuantity};

                ListViewItem toplvi = new ListViewItem(arr);

                if (OrderToSplit == null)
                {
                    if (DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sitin && !config.Table_Orders_Always_Shrinked)
                    {
                        if (GroupIID != oi.OrderGroupIID)
                        {
                            //Need to change item backcolor
                            GroupIID = oi.OrderGroupIID;
                            GroupBackColor = (GroupBackColor == Color.LightGray) ? Color.DarkGray : Color.LightGray;
                        }

                        toplvi.BackColor = GroupBackColor;
                    } else
                    {
                        if (oi.OrderGroupIID != DTRMSimpleBusiness.Instance.AttachedOrder.IID)
                            toplvi.BackColor = Color.DarkGray;
                    }
                }

                toplvi.Tag = oi;

                lvwOrder.Items.Add(toplvi);



                SubTotal = SingleTotal * oi.Quantity;
                if (blnHasSubItems)
                {
                    toplvi.SubItems[2].Text += " (" + oi.Price.ToString("c") + ")";
                    toplvi.SubItems[3].Text = SingleTotal.ToString("c");
                }

            }
            if (lvwOrder.Items.Count > 0)
            {
                //Add Order's main instruction if  any
                if (DTRMSimpleBusiness.Instance.AttachedOrder.Instruction.Trim().Length > 0)
                {
                    arr = new string[4] { "", "", DTRMSimpleBusiness.Instance.AttachedOrder.Instruction, "" };
                    lvi = new ListViewItem(arr);
                    lvwOrder.Items.Add(lvi);
                }
            }

            OrderTotal = DTRMSimpleBusiness.Instance.AttachedOrder.Total;
            if (DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sitin)
                lblScrollUp.Text = DTRMSimpleBusiness.Instance.LoggedUser.UserName + " @ " + DTRMSimpleBusiness.Instance.AttachedOrder.Table?.TableName;
            else
                lblScrollUp.Text = DTRMSimpleBusiness.Instance.LoggedUser.UserName + " @ " + DTRMSimpleBusiness.Instance.AttachedOrder.OrderType;

            if (config.Order_Screen_Display_Service_Charge)
                pnlDown.Height = 52;
            else
                pnlDown.Height = 42;

            if (DTRMSimpleBusiness.Instance.shop.ServiceChargeRate > 0 && DTRMSimpleBusiness.Instance.AttachedOrder != null)
            {
                lblScrollDown.Text = "";
                if (config.Order_Screen_Display_Service_Charge)
                    lblScrollDown.Text = "Service Charge " + DTRMSimpleBusiness.Instance.AttachedOrder.ServiceCharge.ToString("c") + " " + Environment.NewLine;

                lblScrollDown.Text += "Total " + (OrderTotal).ToString("c") + " ";
            } else
                lblScrollDown.Text = OrderTotal.ToString("c") + " ";

            if (DTRMSimpleBusiness.Instance.AttachedOrder != null && (DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Completed || DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Archived))
            {
                pnlCommand.Visible = btnSplit.Visible = false;
            }

            if (lvwOrder.Columns.Count == 5)
            {
                lvwOrder.Columns[4].Width = 0;
            }
        }

        public async void DisplayChangeGiven()
        {
            if (DTRMSimpleBusiness.Instance.AttachedOrder.MoneyPaid > 0)
            {
                double fullTotal = DTRMSimpleBusiness.Instance.AttachedOrder.Total;
                double servicecharge = DTRMSimpleBusiness.Instance.AttachedOrder.ServiceCharge;

                double paraustu = DTRMSimpleBusiness.Instance.AttachedOrder.MoneyPaid - fullTotal;
                pnlDown.Height = 80;
                if (servicecharge > 0 && config.Order_Screen_Display_Service_Charge)
                    pnlDown.Height = 100;

                lblScrollDown.Text = "";
                if (DTRMSimpleBusiness.Instance.shop.ServiceChargeRate > 0 && config.Order_Screen_Display_Service_Charge)
                    lblScrollDown.Text = "Service Charge " + string.Format("{0,15:0.00}", servicecharge.ToString("c")) + Environment.NewLine;

                lblScrollDown.Text += "Total " + string.Format("{0,15:0.00}", fullTotal.ToString("c")) +
                "\nPaid" + string.Format("{0,15:0.00}", DTRMSimpleBusiness.Instance.AttachedOrder.MoneyPaid.ToString("c")) +
                "\nChange " + string.Format("{0,15:0.00}", paraustu.ToString("c"));

            }
        }

        public void Clear()
        {
            Clear(false);

        }
        private void Clear(bool RaiseEvent)
        {
            tmrSaat.Enabled = true;
            lvwOrder.Items.Clear();

            if (RaiseEvent)
                OnDisplayOccured();
        }
        public bool IsSelectedOrderItemSubItem()
        {
            if (lvwOrder.SelectedItems.Count > 0)
            {
                if (lvwOrder.SelectedItems[0].SubItems[3].Text.ToUpper() == "FALSE")
                    return true;
                else
                    return false;
            }
            return false;
        }

        private void lvwOrder_Click(object sender, System.EventArgs e)
        {
            this.OnClick(e);
        }

        public bool SelectTopItem(string OrderItemIID)
        {
            lvwOrder.SelectedItems.Clear();
            for (int i = 0; i < this.lvwOrder.Items.Count; i++)
            {
                if (lvwOrder.Items[i].Text == OrderItemIID)
                {
                    lvwOrder.Items[i].Selected = true;
                    return true;
                }
            }
            return false;
        }

        private void lvwOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvwOrder.SelectedItems.Count == 0)
            //{
            //    DTRMSimpleBusiness.Instance.AttachedOrder.Items.ForEach(x => x.Selected = false);
            //    return;
            //}
            //ListViewItem lvi = lvwOrder.SelectedItems[0];

            //DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.OrderItemText == (lvi.Tag as OrderItem).OrderItemText).Selected = true;
        }



        private async void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (DTRMSimpleBusiness.Instance.AttachedOrder != null &&
                DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.Completed &&
                DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.Archived &&
                !DTRMSimpleBusiness.Instance.AttachedOrder.Items.Any(x => x.Selected))
                return;

            if (DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.New && config.Deleting_OrderItem_Requires_Supervision && DTRMSimpleBusiness.Instance.LoggedUser.AccessLevel == AccessLevels.User)
            {
                if (!DTRMSimpleBusiness.Instance.ConfirmForSupervision())
                    return;
            }

            OrderItem oi = DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.Selected);


            bool blnTopItem = false;
            //Gets the top item

            if (oi != null && oi.ItemType != OrderItemTypes.NormalOrderItem)
                blnTopItem = true;

            if (config.Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted)
            {
                //check is deletable than delete else return directly
                if (!DTRMSimpleBusiness.Instance.CanDeleteKitchenOrderItemIfPrepared(oi))
                    return;
            }

            DTRMSimpleBusiness.Instance.AttachedOrder.DeleteOrderItem(oi);
            await repoOrderItem.Delete(oi);

            //XXX logdelete
            if (DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.New && config.Log_Deleted_Order_Items)
            {
                try
                {
                    await DTRMSimpleBusiness.Instance.SaveLogItem(new LogItem()
                    {
                        OrderItemText = oi.OrderItemText,
                        Quantity = oi.Quantity,
                        OrderContent = DTRMSimpleBusiness.Instance.AttachedOrder.ToSimpleString(),
                        Reason = "Deleted",
                        ComputerName = config.Terminal_Name,
                        Reference = DTRMSimpleBusiness.Instance.AttachedOrder.Reference
                    });
                } catch (Exception ex)
                {
                    string str = ex.Message;
                }
            }


            if (DTRMSimpleBusiness.Instance.AttachedOrder.Items.Count == 0)
                OnZeroItemsLeft();

            if (blnTopItem)
                OnTopItemDeleted();

            Display();
        }

        private async void btnMinusOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (DTRMSimpleBusiness.Instance.AttachedOrder != null &&
                    DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.Completed &&
                    DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.Archived &&
                    !DTRMSimpleBusiness.Instance.AttachedOrder.Items.Any(x => x.Selected))
                    return;

                OrderItem oi = DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.Selected);

                if (oi != null)
                {
                    if (config.Deleting_OrderItem_Requires_Supervision && DTRMSimpleBusiness.Instance.LoggedUser.AccessLevel == AccessLevels.User)
                    {
                        if (!DTRMSimpleBusiness.Instance.ConfirmForSupervision())
                            return;
                    }

                    if (config.Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted)
                    {
                        //check is deletable than delete else return directly
                        if (!DTRMSimpleBusiness.Instance.CanDeleteKitchenOrderItemIfPrepared(oi))
                            return;
                    }

                    //XXX logdelete
                    if (DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.New && config.Log_Deleted_Order_Items)
                    {
                        try
                        {
                            if (oi != null)
                            {
                                await DTRMSimpleBusiness.Instance.SaveLogItem(new LogItem()
                                {
                                    OrderItemText = oi.OrderItemText,
                                    Quantity = 1,
                                    OrderContent = DTRMSimpleBusiness.Instance.AttachedOrder.ToSimpleString(),
                                    Reason = "Decremented",
                                    ComputerName = config.Terminal_Name,
                                    Reference = DTRMSimpleBusiness.Instance.AttachedOrder.Reference
                                });
                            }
                        } catch (Exception ex)
                        {
                            string str = ex.Message;
                        }
                    }

                    if (oi.Quantity == 1)
                    {
                        await repoOrderItem.Delete(oi);
                        DTRMSimpleBusiness.Instance.AttachedOrder.Items.Remove(oi);
                    } else
                        DTRMSimpleBusiness.Instance.AttachedOrder.DecrementOrderItem(oi);
                    Display();
                    if (DTRMSimpleBusiness.Instance.AttachedOrder.Items.Count == 0)
                        OnZeroItemsLeft();
                }
            } catch
            {
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DTRMSimpleBusiness.Instance.AttachedOrder != null &&
                    DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.Completed &&
                    DTRMSimpleBusiness.Instance.AttachedOrder.Status != StatusFlags.Archived &&
                    DTRMSimpleBusiness.Instance.AttachedOrder.Items.Any(x => x.Selected))
                {
                    OrderItem oi = DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.Selected);
                    DTRMSimpleBusiness.Instance.AttachedOrder.IncrementOrderItem(oi);
                    Display();
                }
            } catch
            {
            }
        }



        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void UpdateClock()
        {
            if (ServiceHelper.Services != null && DTRMSimpleBusiness.Instance != null && DTRMSimpleBusiness.Instance.AttachedOrder == null)
                lblScrollUp.Text = DateTime.Now.ToLongTimeString() + " | " + DTRMSimpleBusiness.Instance?.LoggedUser?.UserName;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (SplitStatus == SplittingStatus.Normal)
            {
                SplitStatus = SplittingStatus.Splitting;
                DoSplit();
            } else
            {
                SplitStatus = SplittingStatus.Normal;
                EndSplit(false, false);

            }
            Display();
        }

        private void DoSplit()
        {
            DTRMSimpleBusiness.Instance.SaveOrder(DTRMSimpleBusiness.Instance.AttachedOrder);
            OrderToSplit = DTRMSimpleBusiness.Instance.AttachedOrder;
            OnSplitStarting();

        }

        private async Task EndSplit(bool blnMerge, bool blnSplitAndHold)
        {
            if (DTRMSimpleBusiness.Instance.AttachedOrder != null)
            {
                if (blnMerge)
                    OrderToSplit.MergeOrder(DTRMSimpleBusiness.Instance.AttachedOrder);
                DTRMSimpleBusiness.Instance.AttachedOrder.ShrinkOrder();
            }

            if (OrderToSplit != null)
                OrderToSplit.ShrinkOrder();

            await DTRMSimpleBusiness.Instance.SaveOrder(OrderToSplit);
            OrderToSplit = null;


            if (OrderToSplit == null)
            {
                btnSplit.Image = Properties.Resources.Split32Down;
                btnSplit.Visible = true;
                pnlSplit.Visible = false;
            }
            if (DTRMSimpleBusiness.Instance.AttachedOrder == null)
                return;

            if (DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.New)
            {
                if (blnSplitAndHold)
                {
                    //This is where you create new order from splitted items and save as holded order

                } else
                {
                    //this is where you just waist the ordertodisplay 
                    await DTRMSimpleBusiness.Instance.DeleteOrder(DTRMSimpleBusiness.Instance.AttachedOrder.IID);
                    DTRMSimpleBusiness.Instance.AttachedOrder = null;
                }
            }
            OnSplitEnding();
            btnSplit.Visible = false;

            SplitStatus = SplittingStatus.Normal;
        }

        public async Task AbortSplit()
        {
            await EndSplit(true, false);
        }


        /// <summary>
        /// This function is called when split completed, just tidy up the view
        /// </summary>
        public async Task FinaliseSplit()
        {
            await EndSplit(false, false);
        }
        private async void btnSplitOneDown_Click(object sender, EventArgs e)
        {
            if (OrderToSplit != null && OrderToSplit.Items.Count == 1 && OrderToSplit.Items[0].Quantity == 1)
                return;
            OnSplitContinuing();
            if (lvwSplittingOrder.SelectedItems.Count > 0)
            {
                //SplitOrder  to  DisplayOrder

                //Get Select listview item
                //string IID = lvwSplittingOrder.SelectedItems[0].Text;
                OrderItem oldItem = OrderToSplit.Items.FirstOrDefault(x => x.Selected);

                //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                OrderItem oiNew = oldItem.Clone(false);
                oiNew.Quantity = 1;
                oiNew.OrderIID = oiNew.OrderGroupIID = DTRMSimpleBusiness.Instance.AttachedOrder.IID;

                //Drop 1 from ordertosplit and save
                if (!oldItem.Decrement())
                    OrderToSplit.DeleteOrderItem(oldItem);
                await DTRMSimpleBusiness.Instance.SaveOrder(OrderToSplit);

                //Add new item to ordertodisplay and save
                DTRMSimpleBusiness.Instance.AttachedOrder.AddOrderItem(oiNew);
                await DTRMSimpleBusiness.Instance.SaveOrder(DTRMSimpleBusiness.Instance.AttachedOrder);

                Display();
            }
            OnSplitContinuing();
        }

        private async void btnSplitOneUp_Click(object sender, EventArgs e)
        {
            OnSplitContinuing();
            if (lvwOrder.SelectedItems.Count > 0)
            {
                //DisplayOrder  to  SplitOrder

                //Get Select listview item
                //string IID = lvwOrder.SelectedItems[0].Text;
                OrderItem oldItem = DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.Selected);

                //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                OrderItem oiNew = oldItem.Clone(false);
                oiNew.Quantity = 1;
                oiNew.OrderIID = oiNew.OrderGroupIID = OrderToSplit.IID;



                //Drop 1 from ordertodisplay and save
                if (!oldItem.Decrement())
                    DTRMSimpleBusiness.Instance.AttachedOrder.DeleteOrderItem(oldItem);
                await DTRMSimpleBusiness.Instance.SaveOrder(DTRMSimpleBusiness.Instance.AttachedOrder);

                //Add new item to ordertosplit and save
                OrderItem oiToIncrement = OrderToSplit.GetIncrementableItem(oiNew.CategoryItemIID, oiNew.DistributionIID, oiNew.OrderGroupIID);
                if (oiToIncrement == null)
                    OrderToSplit.AddOrderItem(oiNew);
                else
                    oiToIncrement.Quantity++;
                await DTRMSimpleBusiness.Instance.SaveOrder(OrderToSplit);

                Display();
            }
            OnSplitContinuing();
        }

        private async void btnSplitAllDown_Click(object sender, EventArgs e)
        {
            if (OrderToSplit != null && OrderToSplit.Items.Count == 1)
                return;
            OnSplitContinuing();
            if (lvwSplittingOrder.SelectedItems.Count > 0)
            {
                // ListViewItem lvi = lvwSplittingOrder.SelectedItems[0];
                OrderItem oi = OrderToSplit.Items.FirstOrDefault(x => x.Selected);
                oi.OrderIID = DTRMSimpleBusiness.Instance.AttachedOrder.IID;
                OrderToSplit.DeleteOrderItem(oi);
                await DTRMSimpleBusiness.Instance.SaveOrder(OrderToSplit);
                DTRMSimpleBusiness.Instance.AttachedOrder.AddOrderItem(oi);
                DTRMSimpleBusiness.Instance.AttachedOrder.ShrinkOrder();
                await DTRMSimpleBusiness.Instance.SaveOrder(DTRMSimpleBusiness.Instance.AttachedOrder);
                Display();
            }
            OnSplitContinuing();
        }

        private async void btnSplitAllUp_Click(object sender, EventArgs e)
        {
            OnSplitContinuing();
            if (lvwOrder.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvwOrder.SelectedItems[0];
                OrderItem oi = DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.Selected);
                oi.OrderIID = oi.OrderGroupIID = OrderToSplit.IID;
                DTRMSimpleBusiness.Instance.AttachedOrder.DeleteOrderItem(oi);
                await DTRMSimpleBusiness.Instance.SaveOrder(DTRMSimpleBusiness.Instance.AttachedOrder);
                OrderToSplit.AddOrderItem(oi);
                OrderToSplit.ShrinkOrder();
                await DTRMSimpleBusiness.Instance.SaveOrder(OrderToSplit);
                Display();
            }
            OnSplitContinuing();

        }

        private void btnViewKitchen_Click(object sender, EventArgs e)
        {
            if (cCompletedQuantity.Width > 0)
                cCompletedQuantity.Width = 0;
            else
                cCompletedQuantity.Width = 28;
        }

        private void lvwOrder_Resize(object sender, EventArgs e)
        {
            cOrderItemText.Width = lvwOrder.Width - cQuantity.Width - cTotal.Width - SystemInformation.VerticalScrollBarWidth;
            lblScrollDown.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth - 5, 0);
        }

        private void lvwSplittingOrder_Resize(object sender, EventArgs e)
        {
            cSplitOrderItemText.Width = lvwSplittingOrder.Width - cSplitQuantity.Width - cSplitTotal.Width - SystemInformation.VerticalScrollBarWidth;
        }

        private void lvwOrder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if ( e.Item.Selected)
            {
                DTRMSimpleBusiness.Instance.AttachedOrder.Items.ForEach(x => x.Selected = false);
                DTRMSimpleBusiness.Instance.AttachedOrder.Items.FirstOrDefault(x => x.OrderItemText == (e.Item.Tag as OrderItem).OrderItemText).Selected = true;
            }
        }
    }
}
