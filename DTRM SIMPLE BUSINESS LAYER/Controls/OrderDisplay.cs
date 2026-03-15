using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;


namespace DTRMNS
{
    /// <summary>
    /// Summary description for OrderDisplay.
    /// </summary>
    public class OrderDisplay : System.Windows.Forms.UserControl
    {
        public DTRMNS.DTRMSimpleBusiness bslayer;
        private System.Windows.Forms.ColumnHeader IID;
        private System.Windows.Forms.ColumnHeader OrderItemText;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader CalculatedValue;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colOrderItemText;
        private ListView lvwOrder;
        public string SelectedItemIID;
        private Panel pnlDown;
        private Label lblScrollDown;

        private Panel pnlCommand;
        private Button btnPlus1;
        private Button btnMinusOne;
        private Button btnDeleteItem;
        private Timer tmrSaat;

        //private Order AttachedOrder;
        private System.ComponentModel.IContainer components;
        private ImageList ilSmall;
        private Panel pnlTop;
        private Label lblScrollUp;
        private ListView lvwSplittingOrder;
        private ColumnHeader colSplitIID;
        private ColumnHeader colSplitQuantity;
        private ColumnHeader colSplitOrderItemText;
        private ColumnHeader colSplitCalculatedValue;
        private Panel pnlSplit;
        private Panel pnlSplitActions;
        private Button btnSplitOneDown;
        private Button btnSplitOneUp;
        private Button btnSplitAllDown;
        private Button btnSplitAllUp;
        private Button btnSplit;


        public bool blnShrinkOrder;



        private POSLayer.Models.Order _OrderToDisplay;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public POSLayer.Models.Order OrderToDisplay { get { return _OrderToDisplay; } set { _OrderToDisplay = value; } }

        private POSLayer.Models.Order _OrderToSplit;
        private ColumnHeader colCompletedQuantity;
        private Button btnViewKitchen;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public POSLayer.Models.Order OrderToSplit { get { return _OrderToSplit; } set { _OrderToSplit = value; } }

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

        }

        public void AttachBusinessLayer(DTRMNS.DTRMSimpleBusiness bs)
        {
            bslayer = bs;
            try
            {
                if (bslayer != null)
                {
                    if (bslayer.config != null)
                    {
                        ilSmall.ImageSize = new Size((int)bslayer.config.Order_Item_Display_Height, (int)bslayer.config.Order_Item_Display_Height);
                        bslayer.DisplayOrder += new GenericFunctionCall(Display);
                    }
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
            this.components = new System.ComponentModel.Container();
            this.IID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderItemText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalculatedValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderItemText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.colCompletedQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblScrollDown = new System.Windows.Forms.Label();
            this.pnlCommand = new System.Windows.Forms.Panel();
            this.btnViewKitchen = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnMinusOne = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSplit = new System.Windows.Forms.Button();
            this.lblScrollUp = new System.Windows.Forms.Label();
            this.lvwSplittingOrder = new System.Windows.Forms.ListView();
            this.colSplitIID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSplitQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSplitOrderItemText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSplitCalculatedValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSplit = new System.Windows.Forms.Panel();
            this.pnlSplitActions = new System.Windows.Forms.Panel();
            this.btnSplitAllUp = new System.Windows.Forms.Button();
            this.btnSplitAllDown = new System.Windows.Forms.Button();
            this.btnSplitOneUp = new System.Windows.Forms.Button();
            this.btnSplitOneDown = new System.Windows.Forms.Button();
            this.pnlDown.SuspendLayout();
            this.pnlCommand.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSplit.SuspendLayout();
            this.pnlSplitActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // IID
            // 
            this.IID.Text = "";
            this.IID.Width = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "";
            this.colQuantity.Width = 35;
            // 
            // OrderItemText
            // 
            this.OrderItemText.Text = "Order Items";
            this.OrderItemText.Width = 178;
            // 
            // CalculatedValue
            // 
            this.CalculatedValue.Text = "Price";
            this.CalculatedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalculatedValue.Width = 74;
            // 
            // lvwOrder
            // 
            this.lvwOrder.BackColor = System.Drawing.Color.Black;
            this.lvwOrder.BackgroundImageTiled = true;
            this.lvwOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IID,
            this.colQuantity,
            this.OrderItemText,
            this.CalculatedValue,
            this.colCompletedQuantity});
            this.lvwOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOrder.ForeColor = System.Drawing.Color.White;
            this.lvwOrder.FullRowSelect = true;
            this.lvwOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.Location = new System.Drawing.Point(0, 400);
            this.lvwOrder.MultiSelect = false;
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(320, 291);
            this.lvwOrder.SmallImageList = this.ilSmall;
            this.lvwOrder.TabIndex = 0;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            this.lvwOrder.SelectedIndexChanged += new System.EventHandler(this.lvwOrder_SelectedIndexChanged);
            this.lvwOrder.Click += new System.EventHandler(this.lvwOrder_Click);
            // 
            // colCompletedQuantity
            // 
            this.colCompletedQuantity.Text = "";
            this.colCompletedQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colCompletedQuantity.Width = 28;
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ilSmall.ImageSize = new System.Drawing.Size(64, 64);
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.Black;
            this.pnlDown.Controls.Add(this.lblScrollDown);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 691);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(320, 42);
            this.pnlDown.TabIndex = 27;
            // 
            // lblScrollDown
            // 
            this.lblScrollDown.BackColor = System.Drawing.Color.Black;
            this.lblScrollDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScrollDown.Font = new System.Drawing.Font("Arial", 14F);
            this.lblScrollDown.ForeColor = System.Drawing.Color.White;
            this.lblScrollDown.Location = new System.Drawing.Point(0, 0);
            this.lblScrollDown.Name = "lblScrollDown";
            this.lblScrollDown.Size = new System.Drawing.Size(320, 42);
            this.lblScrollDown.TabIndex = 0;
            this.lblScrollDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCommand
            // 
            this.pnlCommand.BackColor = System.Drawing.Color.Black;
            this.pnlCommand.Controls.Add(this.btnViewKitchen);
            this.pnlCommand.Controls.Add(this.btnPlus1);
            this.pnlCommand.Controls.Add(this.btnMinusOne);
            this.pnlCommand.Controls.Add(this.btnDeleteItem);
            this.pnlCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommand.Location = new System.Drawing.Point(0, 357);
            this.pnlCommand.Name = "pnlCommand";
            this.pnlCommand.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlCommand.Size = new System.Drawing.Size(320, 43);
            this.pnlCommand.TabIndex = 28;
            // 
            // btnViewKitchen
            // 
            this.btnViewKitchen.AutoEllipsis = true;
            this.btnViewKitchen.BackColor = System.Drawing.Color.Black;
            this.btnViewKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewKitchen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnViewKitchen.FlatAppearance.BorderSize = 0;
            this.btnViewKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewKitchen.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.btnViewKitchen.ForeColor = System.Drawing.Color.White;
            this.btnViewKitchen.Image = global::DTRMNS.Properties.Resources.chef32;
            this.btnViewKitchen.Location = new System.Drawing.Point(250, 4);
            this.btnViewKitchen.Margin = new System.Windows.Forms.Padding(1);
            this.btnViewKitchen.Name = "btnViewKitchen";
            this.btnViewKitchen.Size = new System.Drawing.Size(70, 39);
            this.btnViewKitchen.TabIndex = 27;
            this.btnViewKitchen.UseVisualStyleBackColor = false;
            this.btnViewKitchen.Click += new System.EventHandler(this.btnViewKitchen_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.AutoEllipsis = true;
            this.btnPlus1.BackColor = System.Drawing.Color.Black;
            this.btnPlus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlus1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlus1.FlatAppearance.BorderSize = 0;
            this.btnPlus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.btnPlus1.ForeColor = System.Drawing.Color.White;
            this.btnPlus1.Image = global::DTRMNS.Properties.Resources.arti148;
            this.btnPlus1.Location = new System.Drawing.Point(130, 4);
            this.btnPlus1.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(70, 39);
            this.btnPlus1.TabIndex = 26;
            this.btnPlus1.UseVisualStyleBackColor = false;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // btnMinusOne
            // 
            this.btnMinusOne.AutoEllipsis = true;
            this.btnMinusOne.BackColor = System.Drawing.Color.Black;
            this.btnMinusOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinusOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinusOne.FlatAppearance.BorderSize = 0;
            this.btnMinusOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusOne.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.btnMinusOne.ForeColor = System.Drawing.Color.White;
            this.btnMinusOne.Image = global::DTRMNS.Properties.Resources.eksi148;
            this.btnMinusOne.Location = new System.Drawing.Point(60, 4);
            this.btnMinusOne.Margin = new System.Windows.Forms.Padding(1);
            this.btnMinusOne.Name = "btnMinusOne";
            this.btnMinusOne.Size = new System.Drawing.Size(70, 39);
            this.btnMinusOne.TabIndex = 25;
            this.btnMinusOne.UseVisualStyleBackColor = false;
            this.btnMinusOne.Click += new System.EventHandler(this.btnMinusOne_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AutoEllipsis = true;
            this.btnDeleteItem.BackColor = System.Drawing.Color.Black;
            this.btnDeleteItem.BackgroundImage = global::DTRMNS.Properties.Resources.eksi48;
            this.btnDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 4);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(60, 39);
            this.btnDeleteItem.TabIndex = 24;
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.btnSplit);
            this.pnlTop.Controls.Add(this.lblScrollUp);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(320, 42);
            this.pnlTop.TabIndex = 27;
            // 
            // btnSplit
            // 
            this.btnSplit.AutoEllipsis = true;
            this.btnSplit.BackColor = System.Drawing.Color.Black;
            this.btnSplit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSplit.FlatAppearance.BorderSize = 0;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplit.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.btnSplit.ForeColor = System.Drawing.Color.White;
            this.btnSplit.Image = global::DTRMNS.Properties.Resources.Split32Down;
            this.btnSplit.Location = new System.Drawing.Point(0, 0);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(1);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(70, 42);
            this.btnSplit.TabIndex = 27;
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Visible = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // lblScrollUp
            // 
            this.lblScrollUp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrollUp.ForeColor = System.Drawing.Color.White;
            this.lblScrollUp.Location = new System.Drawing.Point(130, 0);
            this.lblScrollUp.Name = "lblScrollUp";
            this.lblScrollUp.Size = new System.Drawing.Size(190, 42);
            this.lblScrollUp.TabIndex = 26;
            this.lblScrollUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwSplittingOrder
            // 
            this.lvwSplittingOrder.BackColor = System.Drawing.Color.Black;
            this.lvwSplittingOrder.BackgroundImageTiled = true;
            this.lvwSplittingOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwSplittingOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSplitIID,
            this.colSplitQuantity,
            this.colSplitOrderItemText,
            this.colSplitCalculatedValue});
            this.lvwSplittingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSplittingOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSplittingOrder.ForeColor = System.Drawing.Color.White;
            this.lvwSplittingOrder.FullRowSelect = true;
            this.lvwSplittingOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwSplittingOrder.HideSelection = false;
            this.lvwSplittingOrder.Location = new System.Drawing.Point(0, 0);
            this.lvwSplittingOrder.MultiSelect = false;
            this.lvwSplittingOrder.Name = "lvwSplittingOrder";
            this.lvwSplittingOrder.Size = new System.Drawing.Size(320, 273);
            this.lvwSplittingOrder.SmallImageList = this.ilSmall;
            this.lvwSplittingOrder.TabIndex = 30;
            this.lvwSplittingOrder.UseCompatibleStateImageBehavior = false;
            this.lvwSplittingOrder.View = System.Windows.Forms.View.Details;
            // 
            // colSplitIID
            // 
            this.colSplitIID.Text = "";
            this.colSplitIID.Width = 0;
            // 
            // colSplitQuantity
            // 
            this.colSplitQuantity.Text = "";
            this.colSplitQuantity.Width = 35;
            // 
            // colSplitOrderItemText
            // 
            this.colSplitOrderItemText.Text = "Order Items";
            this.colSplitOrderItemText.Width = 178;
            // 
            // colSplitCalculatedValue
            // 
            this.colSplitCalculatedValue.Text = "Price";
            this.colSplitCalculatedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSplitCalculatedValue.Width = 74;
            // 
            // pnlSplit
            // 
            this.pnlSplit.BackColor = System.Drawing.Color.Black;
            this.pnlSplit.Controls.Add(this.lvwSplittingOrder);
            this.pnlSplit.Controls.Add(this.pnlSplitActions);
            this.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSplit.Location = new System.Drawing.Point(0, 42);
            this.pnlSplit.Name = "pnlSplit";
            this.pnlSplit.Size = new System.Drawing.Size(320, 315);
            this.pnlSplit.TabIndex = 31;
            this.pnlSplit.Visible = false;
            // 
            // pnlSplitActions
            // 
            this.pnlSplitActions.BackColor = System.Drawing.Color.Black;
            this.pnlSplitActions.Controls.Add(this.btnSplitAllUp);
            this.pnlSplitActions.Controls.Add(this.btnSplitAllDown);
            this.pnlSplitActions.Controls.Add(this.btnSplitOneUp);
            this.pnlSplitActions.Controls.Add(this.btnSplitOneDown);
            this.pnlSplitActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitActions.Location = new System.Drawing.Point(0, 273);
            this.pnlSplitActions.Name = "pnlSplitActions";
            this.pnlSplitActions.Size = new System.Drawing.Size(320, 42);
            this.pnlSplitActions.TabIndex = 31;
            // 
            // btnSplitAllUp
            // 
            this.btnSplitAllUp.BackColor = System.Drawing.Color.Black;
            this.btnSplitAllUp.BackgroundImage = global::DTRMNS.Properties.Resources.BlueMultiUp;
            this.btnSplitAllUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSplitAllUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSplitAllUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitAllUp.Location = new System.Drawing.Point(210, 0);
            this.btnSplitAllUp.Name = "btnSplitAllUp";
            this.btnSplitAllUp.Size = new System.Drawing.Size(70, 42);
            this.btnSplitAllUp.TabIndex = 0;
            this.btnSplitAllUp.UseVisualStyleBackColor = false;
            this.btnSplitAllUp.Click += new System.EventHandler(this.btnSplitAllUp_Click);
            // 
            // btnSplitAllDown
            // 
            this.btnSplitAllDown.BackColor = System.Drawing.Color.Black;
            this.btnSplitAllDown.BackgroundImage = global::DTRMNS.Properties.Resources.BlueMultiDown;
            this.btnSplitAllDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSplitAllDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSplitAllDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitAllDown.Location = new System.Drawing.Point(140, 0);
            this.btnSplitAllDown.Name = "btnSplitAllDown";
            this.btnSplitAllDown.Size = new System.Drawing.Size(70, 42);
            this.btnSplitAllDown.TabIndex = 1;
            this.btnSplitAllDown.UseVisualStyleBackColor = false;
            this.btnSplitAllDown.Click += new System.EventHandler(this.btnSplitAllDown_Click);
            // 
            // btnSplitOneUp
            // 
            this.btnSplitOneUp.BackColor = System.Drawing.Color.Black;
            this.btnSplitOneUp.BackgroundImage = global::DTRMNS.Properties.Resources.BlueUp;
            this.btnSplitOneUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSplitOneUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSplitOneUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitOneUp.Location = new System.Drawing.Point(70, 0);
            this.btnSplitOneUp.Name = "btnSplitOneUp";
            this.btnSplitOneUp.Size = new System.Drawing.Size(70, 42);
            this.btnSplitOneUp.TabIndex = 2;
            this.btnSplitOneUp.UseVisualStyleBackColor = false;
            this.btnSplitOneUp.Click += new System.EventHandler(this.btnSplitOneUp_Click);
            // 
            // btnSplitOneDown
            // 
            this.btnSplitOneDown.BackColor = System.Drawing.Color.Black;
            this.btnSplitOneDown.BackgroundImage = global::DTRMNS.Properties.Resources.BlueDown;
            this.btnSplitOneDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSplitOneDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSplitOneDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitOneDown.Location = new System.Drawing.Point(0, 0);
            this.btnSplitOneDown.Name = "btnSplitOneDown";
            this.btnSplitOneDown.Size = new System.Drawing.Size(70, 42);
            this.btnSplitOneDown.TabIndex = 3;
            this.btnSplitOneDown.UseVisualStyleBackColor = false;
            this.btnSplitOneDown.Click += new System.EventHandler(this.btnSplitOneDown_Click);
            // 
            // OrderDisplay
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.pnlCommand);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlSplit);
            this.Controls.Add(this.pnlTop);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "OrderDisplay";
            this.Size = new System.Drawing.Size(320, 733);
            this.pnlDown.ResumeLayout(false);
            this.pnlCommand.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlSplit.ResumeLayout(false);
            this.pnlSplitActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void DisplaySplittingOrder()
        {
            if (OrderToSplit == null)
                return;
            lvwSplittingOrder.Items.Clear();
            foreach (POSLayer.Models.OrderItem oi in OrderToSplit.items)
            {
                lvwSplittingOrder.Items.Add(new ListViewItem(new string[] { oi.IID, oi.Quantity.ToString(), oi.OrderItemText, oi.Total.ToString("N2") }));
            }
        }


        public void Display()
        {

            Color GroupBackColor = Color.LightGray;
            string GroupIID = "";

            btnSplit.Visible = false;

            if (bslayer.AttachedOrder != null)
            {
                btnViewKitchen.Visible = bslayer.config.Display_Kitchen_Chef_on_Display &&
                    ((bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.DirectSale && bslayer.config.Hold_Order_Available && bslayer.config.Hold_Order_Display_in_Kitchen) ||
                    (bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.InHouse && bslayer.config.Table_Orders_Allowed && bslayer.config.Table_Orders_Display_Kitchen_Orders));

                colCompletedQuantity.Width = (btnViewKitchen.Visible ? 28 : 0);
            }

            pnlCommand.Height = (OrderToDisplay != null && OrderToDisplay.items.Count > 0) ? 54 : 0;
            string[] arr = null;
            ListViewItem lvi;
            OrderItem oi;
            double SingleTotal = 0f;
            double SubTotal = 0f;
            double OrderTotal = 0f;
            bool blnHasSubItems = false;

            Clear(false);

            OnDisplayOccured();

            if (OrderToDisplay == null && OrderToSplit == null)
                btnSplit.Visible = false;

            if (OrderToDisplay == null && OrderToSplit != null && OrderToSplit.items.Count == 0)
            {
                //Now Ordertosplit must be deleted
                bslayer.DeleteOrder(OrderToSplit.IID);
                OrderToSplit = null;
                SplitStatus = SplittingStatus.Normal;
                btnSplit.Visible = false;
                pnlSplit.Visible = false;
            }

            if (OrderToDisplay == null)
                return;


            switch (OrderToDisplay.Status)
            {
                case POSLayer.Library.StatusFlags.NEW:
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
                case POSLayer.Library.StatusFlags.PENDING:
                case POSLayer.Library.StatusFlags.DONE:
                    switch (SplitStatus)
                    {
                        case SplittingStatus.Normal:
                            btnSplit.Image = Properties.Resources.Split32Down;

                            if (OrderToDisplay.items.Count == 1 && OrderToDisplay.items[0].Quantity == 1)
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
            for (int i = 0; i < OrderToDisplay.items.Count; i++)
            {

                //Display Top Item
                blnHasSubItems = false;
                oi = (OrderItem)OrderToDisplay.items[i];
                SingleTotal = oi.Price * oi.Quantity;


                if ((bslayer.config.Table_Orders_Display_Kitchen_Orders || bslayer.config.Table_Orders_Kitchen_Receipt_Count > 0 || bslayer.config.Hold_Order_Display_in_Kitchen || bslayer.config.Hold_Order_Print_in_Kitchen) &&
                    (OrderToDisplay.OrderType == OrderTypes.DirectSale || OrderToDisplay.OrderType == OrderTypes.InHouse) &&
                    OrderToSplit == null && (OrderToDisplay.Status == StatusFlags.NEW || OrderToDisplay.Status == StatusFlags.DONE || OrderToDisplay.Status == StatusFlags.PENDING))
                {
                    if (bslayer.config.Display_Kitchen_Orders_As_Reminders)
                    {
                        strCompletedQuantity = (oi.Quantity - oi.CompletedQuantity < 0 ? 0 : oi.Quantity - oi.CompletedQuantity).ToString("f0");
                        if (strCompletedQuantity == "0")
                            strCompletedQuantity = "";
                    } else
                        strCompletedQuantity = oi.CompletedQuantity.ToString("f0");
                }



                arr = new String[5]{oi.IID, oi.Quantity.ToString("f0"),
                                        oi.OrderItemText + " (" + bslayer.GetDistribution(oi.DistributionIID).Result.ShortName + ")" ,
                                         oi.Total.ToString("c"),strCompletedQuantity};

                ListViewItem toplvi = new ListViewItem(arr);

                if (OrderToSplit == null)
                {
                    if (OrderToDisplay.OrderType == OrderTypes.InHouse && !bslayer.config.Table_Orders_Always_Shrinked)
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
                        if (oi.OrderGroupIID != OrderToDisplay.IID)
                            toplvi.BackColor = Color.DarkGray;
                    }
                }
                //else {
                //    //currently splitting so alternate lvi backcolor
                //    if (oi.OrderGroupIID == OrderToDisplay.IID)
                //        toplvi.BackColor = Color.DarkGray;
                //}

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
                if (OrderToDisplay.Instruction.Trim().Length > 0)
                {
                    arr = new string[4] { "", "", OrderToDisplay.Instruction, "" };
                    lvi = new ListViewItem(arr);
                    lvwOrder.Items.Add(lvi);
                }
            }

            OrderTotal = OrderToDisplay.GetFullTotal();
            if (OrderToDisplay.OrderType == OrderTypes.InHouse)
                lblScrollUp.Text = bslayer.LoggedUser.UserName + " @ " + OrderToDisplay.TableName; // + " Total = " + OrderTotal.ToString("c") + "   ";
            else
                lblScrollUp.Text = bslayer.LoggedUser.UserName + " @ " + UF.GetOrderTypeAsText(OrderToDisplay.OrderType); // +"  /  Total = " + OrderTotal.ToString("c") + "   ";

            if (bslayer.config.Order_Screen_Display_Service_Charge)
                pnlDown.Height = 52;
            else
                pnlDown.Height = 42;

            if (bslayer.luv.ServiceChargeRate > 0 && bslayer.AttachedOrder != null)
            {
                lblScrollDown.Text = "";
                if (bslayer.config.Order_Screen_Display_Service_Charge)
                    lblScrollDown.Text = "Service Charge " + bslayer.AttachedOrder.GetServiceCharge().ToString("c") + " " + Environment.NewLine;

                lblScrollDown.Text += "Total " + (OrderTotal).ToString("c") + " ";
            } else
                lblScrollDown.Text = OrderTotal.ToString("c") + " ";

            if (bslayer.AttachedOrder != null && (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED))
            {
                pnlCommand.Visible = btnSplit.Visible = false;
            }

        }

        public async void DisplayChangeGiven()
        {
            if (OrderToDisplay.MoneyPaid > 0)
            {
                double fullTotal = bslayer.AttachedOrder.GetFullTotal();
                double servicecharge = bslayer.AttachedOrder.GetServiceCharge();

                double paraustu = OrderToDisplay.MoneyPaid - fullTotal;
                pnlDown.Height = 80;
                if (servicecharge > 0 && bslayer.config.Order_Screen_Display_Service_Charge)
                    pnlDown.Height = 100;

                lblScrollDown.Text = "";
                if (bslayer.luv.ServiceChargeRate > 0 && bslayer.config.Order_Screen_Display_Service_Charge)
                    lblScrollDown.Text = "Service Charge " + string.Format("{0,15:0.00}", servicecharge.ToString("c")) + Environment.NewLine;

                lblScrollDown.Text += "Total " + string.Format("{0,15:0.00}", fullTotal.ToString("c")) +
                "\nPaid" + string.Format("{0,15:0.00}", OrderToDisplay.MoneyPaid.ToString("c")) +
                "\nChange " + string.Format("{0,15:0.00}", paraustu.ToString("c"));

            }
        }

        public bool HasSelection()
        {
            return (SelectedItemIID != null && SelectedItemIID != "");
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
            if (lvwOrder.SelectedItems.Count > 0)
                bslayer.SelectedOrderItemIID = SelectedItemIID = lvwOrder.SelectedItems[0].Text;
            else
                bslayer.SelectedOrderItemIID = SelectedItemIID = null;
        }



        private async void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED))
                return;

            //DELETE SUB ROUTINE
            if (OrderToDisplay != null)
            {
                if (HasSelection())
                {
                    if (OrderToDisplay.Status != StatusFlags.NEW && bslayer.config.Deleting_OrderItem_Requires_Supervision && bslayer.LoggedUser.AccessLevel == AccessLevels.User)
                    {
                        if (!bslayer.ConfirmForSupervision())
                            return;
                    }

                    bool blnTopItem = false;
                    //Gets the top item
                    OrderItem oi = OrderToDisplay.items.Find(delegate (OrderItem param)
                    { return param.IID == SelectedItemIID; });
                    if (oi != null && oi.ItemType != OrderItemTypes.NormalOrderItem)
                        blnTopItem = true;

                    if (bslayer.config.Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted)
                    {
                        //check is deletable than delete else return directly
                        if (!bslayer.CanDeleteKitchenOrderItemIfPrepared(oi))
                            return;
                    }

                    OrderToDisplay.DeleteOrderItem(SelectedItemIID);

                    //XXX logdelete
                    if (bslayer.AttachedOrder.Status != StatusFlags.NEW && bslayer.config.Log_Deleted_Order_Items)
                    {
                        try
                        {
                            Order oldOrder = await bslayer.GetOrder(bslayer.AttachedOrder.IID);
                            if (oldOrder != null)
                            {
                                bslayer.SaveLogItem(new LogItem()
                                {
                                    OrderItemText = oi.OrderItemText,
                                    Quantity = oi.Quantity,
                                    OrderContent = oldOrder.ToSimpleString(),
                                    Reason = "Deleted",
                                    ComputerName = bslayer.config.Terminal_Name,
                                    Reference = bslayer.AttachedOrder.Reference
                                });
                            }
                        } catch (Exception ex)
                        {
                            string str = ex.Message;
                        }
                    }


                    if (OrderToDisplay.items.Count == 0)
                        OnZeroItemsLeft();

                    if (blnTopItem)
                        OnTopItemDeleted();

                    Display();
                }
            }
        }

        private async void btnMinusOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (bslayer.AttachedOrder != null && (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED))
                    return;
                if (HasSelection())
                {
                    if (OrderToDisplay != null)
                    {

                        if (bslayer.config.Deleting_OrderItem_Requires_Supervision && bslayer.LoggedUser.AccessLevel == AccessLevels.User)
                        {
                            if (!bslayer.ConfirmForSupervision())
                                return;
                        }

                        if (bslayer.config.Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted)
                        {
                            //check is deletable than delete else return directly
                            if (!bslayer.CanDeleteKitchenOrderItemIfPrepared(OrderToDisplay.GetOrderItem(SelectedItemIID)))
                                return;
                        }

                        //XXX logdelete

                        if (bslayer.AttachedOrder.Status != StatusFlags.NEW && bslayer.config.Log_Deleted_Order_Items)
                        {
                            try
                            {
                                OrderItem oi = OrderToDisplay.GetOrderItem(SelectedItemIID);
                                if (oi != null)
                                {
                                    Order oldOrder = await bslayer.GetOrder(bslayer.AttachedOrder.IID);
                                    if (oldOrder != null)
                                    {
                                        bslayer.SaveLogItem(new LogItem()
                                        {
                                            OrderItemText = oi.OrderItemText,
                                            Quantity = 1,
                                            OrderContent = oldOrder.ToSimpleString(),
                                            Reason = "Decremented",
                                            ComputerName = bslayer.config.Terminal_Name,
                                            Reference = bslayer.AttachedOrder.Reference
                                        });
                                    }
                                }
                            } catch (Exception ex)
                            {
                                string str = ex.Message;
                            }
                        }

                        OrderToDisplay.DecrementOrderItem(SelectedItemIID);
                        Display();
                        if (OrderToDisplay.items.Count == 0)
                            OnZeroItemsLeft();
                    }
                }
            } catch
            {
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bslayer.AttachedOrder != null && (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED))
                    return;

                if (OrderToDisplay != null && HasSelection())
                {
                    OrderToDisplay.IncrementOrderItem(SelectedItemIID);
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
            if (bslayer != null && OrderToDisplay == null)
                lblScrollUp.Text = DateTime.Now.ToLongTimeString() + " | " + bslayer.LoggedUser.UserName;
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
            bslayer.SaveOrder(bslayer.AttachedOrder);
            OrderToSplit = bslayer.AttachedOrder;
            OnSplitStarting();

        }

        private void EndSplit(bool blnMerge, bool blnSplitAndHold)
        {
            if (OrderToDisplay != null)
            {
                if (blnMerge)
                    OrderToSplit.MergeOrder(OrderToDisplay);
                OrderToDisplay.ShrinkOrder();
            }

            if (OrderToSplit != null)
                OrderToSplit.ShrinkOrder();

            bslayer.SaveOrder(OrderToSplit);
            OrderToSplit = null;


            if (OrderToSplit == null)
            {
                btnSplit.Image = Properties.Resources.Split32Down;
                btnSplit.Visible = true;
                pnlSplit.Visible = false;
            }
            if (OrderToDisplay == null)
                return;

            if (OrderToDisplay.Status == StatusFlags.NEW)
            {
                if (blnSplitAndHold)
                {
                    //This is where you create new order from splitted items and save as holded order

                } else
                {
                    //this is where you just waist the ordertodisplay 
                    bslayer.DeleteOrder(OrderToDisplay.IID);
                    bslayer.AttachedOrder = null;
                }
            }
            OnSplitEnding();
            btnSplit.Visible = false;

            SplitStatus = SplittingStatus.Normal;
        }

        public void AbortSplit()
        {
            EndSplit(true, false);
        }


        /// <summary>
        /// This function is called when split completed, just tidy up the view
        /// </summary>
        public void FinaliseSplit()
        {
            EndSplit(false, false);
        }
        private void btnSplitOneDown_Click(object sender, EventArgs e)
        {
            if (OrderToSplit != null && OrderToSplit.items.Count == 1 && OrderToSplit.items[0].Quantity == 1)
                return;
            OnSplitContinuing();
            if (lvwSplittingOrder.SelectedItems.Count > 0)
            {
                //SplitOrder  to  DisplayOrder

                //Get Select listview item
                string IID = lvwSplittingOrder.SelectedItems[0].Text;

                //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                POSLayer.Models.OrderItem oiNew = OrderToSplit.GetOrderItem(IID).Clone(false);
                oiNew.Quantity = 1;
                oiNew.ParentOrderIID = oiNew.OrderGroupIID = OrderToDisplay.IID;

                //Drop 1 from ordertosplit and save
                if (!OrderToSplit.GetOrderItem(IID).Decrement())
                    OrderToSplit.DeleteOrderItem(IID);
                bslayer.SaveOrder(OrderToSplit);

                //Add new item to ordertodisplay and save
                OrderToDisplay.AddOrderItem(oiNew);
                bslayer.SaveOrder(OrderToDisplay);

                Display();
            }
            OnSplitContinuing();
        }

        private void btnSplitOneUp_Click(object sender, EventArgs e)
        {
            OnSplitContinuing();
            if (lvwOrder.SelectedItems.Count > 0)
            {
                //DisplayOrder  to  SplitOrder

                //Get Select listview item
                string IID = lvwOrder.SelectedItems[0].Text;

                //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                POSLayer.Models.OrderItem oiNew = OrderToDisplay.GetOrderItem(IID).Clone(false);
                oiNew.Quantity = 1;
                oiNew.ParentOrderIID = oiNew.OrderGroupIID = OrderToSplit.IID;



                //Drop 1 from ordertodisplay and save
                if (!OrderToDisplay.GetOrderItem(IID).Decrement())
                    OrderToDisplay.DeleteOrderItem(IID);
                bslayer.SaveOrder(OrderToDisplay);

                //Add new item to ordertosplit and save
                POSLayer.Models.OrderItem oiToIncrement = OrderToSplit.GetIncrementableItem(oiNew.EntityButtonIID, oiNew.DistributionIID, oiNew.OrderGroupIID);
                if (oiToIncrement == null)
                    OrderToSplit.AddOrderItem(oiNew);
                else
                    oiToIncrement.Increment();
                bslayer.SaveOrder(OrderToSplit);

                Display();
            }
            OnSplitContinuing();
        }

        private void btnSplitAllDown_Click(object sender, EventArgs e)
        {
            if (OrderToSplit != null && OrderToSplit.items.Count == 1)
                return;
            OnSplitContinuing();
            if (lvwSplittingOrder.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvwSplittingOrder.SelectedItems[0];
                POSLayer.Models.OrderItem oi = OrderToSplit.GetOrderItem(lvi.Text);
                oi.ParentOrderIID = OrderToDisplay.IID;
                OrderToSplit.DeleteOrderItem(oi.IID);
                bslayer.SaveOrder(OrderToSplit);
                OrderToDisplay.AddOrderItem(oi);
                OrderToDisplay.ShrinkOrder();
                bslayer.SaveOrder(OrderToDisplay);
                Display();
            }
            OnSplitContinuing();
        }

        private void btnSplitAllUp_Click(object sender, EventArgs e)
        {
            OnSplitContinuing();
            if (lvwOrder.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvwOrder.SelectedItems[0];
                POSLayer.Models.OrderItem oi = OrderToDisplay.GetOrderItem(lvi.Text);
                oi.ParentOrderIID = oi.OrderGroupIID = OrderToSplit.IID;
                OrderToDisplay.DeleteOrderItem(oi.IID);
                bslayer.SaveOrder(OrderToDisplay);
                OrderToSplit.AddOrderItem(oi);
                OrderToSplit.ShrinkOrder();
                bslayer.SaveOrder(OrderToSplit);
                Display();
            }
            OnSplitContinuing();

        }

        private void btnViewKitchen_Click(object sender, EventArgs e)
        {
            if (colCompletedQuantity.Width > 0)
                colCompletedQuantity.Width = 0;
            else
                colCompletedQuantity.Width = 28;
        }
    }
}
