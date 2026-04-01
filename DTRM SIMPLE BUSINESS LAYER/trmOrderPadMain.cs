using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PosLibrary;
using System.IO;
using DTRMNS.Forms;
using POSLayer.Library;
using System.Threading.Tasks;
using POSLayer.Models;
using POSWinFormLayer;
using Microsoft.Extensions.DependencyInjection;
using DTRMNS.Controls;
using POSLayer.Repository.IRepository;
using POSLayer.Views;
using System.Linq;


//using System.ServiceModel;
//using System.ServiceModel.Description;

namespace DTRMNS
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class trmOrderPadMain : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;

        readonly IServiceProvider sp;
        PosConfig config;
        public DTRMSimpleBusiness bslayer;
        IRepository<TheMenu> repoMenu;
        IRepository<Order> repoOrder;
        IRepository<Bonus> repoBonus;
        IRepository<Distribution> repoDistribution;


        private Button btnDone;
        private Button btnPrintCashFinalPayment;
        private Button btnPrintCashFinalPaymentWithReceipt;
        private Button button7;
        private Button button9;
        private Button button8;
        private Button button10;
        private Panel pnlSubTotal;
        private Button button94;
        private Button button93;
        private Button button107;
        private Button btnC;
        private Button button61;
        private Button button58;
        private Button button57;
        private Button button89;
        private Button button86;
        private Button button75;
        private Button button95;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button12;
        private Label lblMoneyBack;
        private Label lblPayedIn;
        private Label lblOrderTotal;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlcizgi;
        private Button btnHideSubTotal;
        private Panel pnlStandardDisplay;
        private Panel pnlDisplay;
        private Form Locker;
        private Button btnCashDrawer;
        private UPEntity pnlSpecial;

        private FlowLayoutPanel pnlTop;
        private Button cmdCancel;
        private Button cmdTables;
        private Button cmdTakeAway;
        private Button cmdDelivery;
        private Button cmdDirectSale;

        private FlowLayoutPanel pnlOrderPad;

        public bool blnInternetDeamonPrinting;
        private Button btnPrintCardFinalPayment;
        private Button btnPrintCardFinalPaymentWithReceipt;
        public bool blnStoreListDeamonPrinting;
        private Button btnSubTotalCashWR;
        private Button btnSubTotalCash;
        private Button btnSubTotalFullAmount;

        private bool blnPadOpenning;
        private FlowLayoutPanel pnlPendingOrders;
        private Timer tmrHoldingOrders;

        private InterfaceHolder OUI;

        private bool blnLoadingHoldingOrders;

        private bool blnLockable;


        //public ServiceHost httpServiceHost;
        private Panel pnlHolder;
        public bool blnHttpServiceRunning;
        private Button btnPrint;
        private OrderDisplay OrderScreen;
        private bool blnAlreadyHolding;
        private Timer tmrScreenSaverTrigger;

        private DateTime KitchenModified;
        private MenuStrip mnuFunctions;
        private ToolStripMenuItem mnuOrders;
        private ToolStripMenuItem mnuViewBars;
        private ToolStripMenuItem mnuReports;
        private ToolStripMenuItem mnuLock;
        private ToolStripMenuItem mnuSum;
        private ToolStripMenuItem mnuReprintReport;
        private ToolStripMenuItem mnuSelectBonusPlan;
        private ToolStripMenuItem mnuPrintForKitchen;
        private ToolStripMenuItem mnuPrintAsInvoice;
        private ToolStripMenuItem mnuCustomer;
        private ToolStripMenuItem mnuPad;
        private ToolStripMenuItem mnuResetKitchenOrders;
        private ToolStripMenuItem mnuShoppingList;
        private ToolStripMenuItem mnuSupplierPurchaseList;
        private ToolStripMenuItem mnuPrintStockUsageReport;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuDrawerCalculator;
        private ToolStripMenuItem mnuReloadMenu;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuOrientation;
        private Button btnHoldOrder;
        private Button btnHoldAndReceipt;
        private ContextMenuStrip popHold;
        private ToolStripMenuItem btnHoldOrange;
        private ToolStripMenuItem btnHoldGreen;
        private ToolStripMenuItem btnHoldYellow;
        private ToolStripMenuItem btnHoldBlue;
        private ToolStripMenuItem btnHoldPink;
        private ContextMenuStrip popHoldAndPrint;
        private ToolStripMenuItem btnHoldAndReceiptOrange;
        private ToolStripMenuItem btnHoldAndReceiptGreen;
        private ToolStripMenuItem btnHoldAndReceiptYellow;
        private ToolStripMenuItem btnHoldAndReceiptBlue;
        private ToolStripMenuItem btnHoldAndReceiptPink;
        private ToolStripMenuItem mnuAdmin;
        private ToolStripMenuItem mnuStock;
        private ToolStripMenuItem mnuKitchen;
        private ToolStripMenuItem mnuDebug;
        private ToolStripMenuItem mnuChangeMenu;
        private ToolStripMenuItem mnuShrinkOrderDisplay;
        private TableLayoutPanel pnlMoneyActions;
        private Timer tmrHoldOrderAutoClose;
        private Button btnExpandShrinkHoldButtonDetails;
        private Controls.ctlBonus pnlBonus;
        private Button btnPrintOnlineFinalPaymentWithReceipt;
        private Button btnPrintOnlineFinalPayment;
        private Button button1;
        private TableLayoutPanel pnlSubMoneyActions;
        private Panel panel1;
        private ToolStripMenuItem mnuSupervisorReport;
        private bool Hold_Order_Display_Summary;

        public trmOrderPadMain()
        {
            InitializeComponent();
        }
        public trmOrderPadMain(IServiceProvider _sp, PosConfig configAsService, DTRMSimpleBusiness bslayer, IRepository<TheMenu> _repoMenu,
            IRepository<Order> _repoOrder, IRepository<Bonus> _repoBonus, IRepository<Distribution> _repoDistribution, Form Locker, bool blnLockable)
        {
            sp = _sp;
            config = configAsService;
            this.bslayer = bslayer;
            repoMenu = _repoMenu;
            repoOrder = _repoOrder;
            repoBonus = _repoBonus;
            repoDistribution = _repoDistribution;

            InitializeComponent();

            this.Locker = Locker;
            this.blnLockable = blnLockable;

            mnuLock.Enabled = blnLockable;
            this.Show();


        }
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            //This only happens once            
            RefreshUserInterface();

            DoInitialThings();

            try
            {
                tmrHoldingOrders.Interval = (config.Hold_Orders_Reload_Seconds * 1000);
            } catch
            {

            }
            bslayer.maxHeight = this.Height;

            if (config.Screen_Saver_Capture_Mouse_Down_Event ||
                config.Screen_Saver_Capture_Mouse_Move_Event)
                RegisterMouseMoveOrDown(this);
        }


        private void RegisterMouseMoveOrDown(Control control)
        {
            if (config.Screen_Saver_Capture_Mouse_Down_Event ||
                config.Screen_Saver_Capture_Mouse_Move_Event)
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (config.Screen_Saver_Capture_Mouse_Down_Event)
                        ctrl.MouseDown += CaptureMouseDown;

                    if (config.Screen_Saver_Capture_Mouse_Move_Event)
                        ctrl.MouseMove += CaptureMouseMove;

                    RegisterMouseMoveOrDown(ctrl);
                }
            }
        }


        public void DoInitialThings()
        {
            //This can be called for every login action
            mnuOptions.Visible = bslayer.LoggedUser.IsSuperUserOrMore();
            mnuReprintReport.Visible = mnuReloadMenu.Visible = mnuSupervisorReport.Visible = bslayer.LoggedUser.IsManagerOrMore();

            if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.None)
                btnDone.Dock = DockStyle.Fill;


            //This function already calls loadpending orders
            UnloadOrder();

            tmrHoldingOrders.Enabled = config.Hold_Order_Available;

            pnlDisplay.Width = config.DisplayWidth;
            OrderScreen.SplitDisplayHeight = config.SplitDisplayHeight;




        }
        public async void RefreshUserInterface()
        {
            try
            {
                if (OrderScreen.bslayer == null)
                    OrderScreen.AttachBusinessLayer();
                await LoadUserInterface();
                await LoadViewBars();
                await LoadSupplierList();
                //LoadMenuList();
                if (config.Display_Session_Bonus)
                    await LoadBonusSchemes();


                #region Adjust individual hold button height
                foreach (ToolStripMenuItem item in popHold.Items)
                {
                    item.Height = config.HoldButtonItemsHeight;
                }
                popHold.Height = config.HoldButtonItemsHeight * 5 + 5;

                foreach (ToolStripMenuItem item in popHoldAndPrint.Items)
                {
                    item.Height = config.HoldButtonItemsHeight;
                }
                popHoldAndPrint.Height = config.HoldButtonItemsHeight * 5 + 5;
                #endregion

                #region Money Panel and Panel Button Settings
                pnlMoneyActions.Height = config.MoneyActionPanelHeight;




                //now we know how many buttons on first column
                //List<Button> col_1_btns = new List<Button>();
                //if (config.Table_Orders_Allowed)
                //    col_1_btns.Add(btnDone);
                //if (config.Cash_Drawer_Void_Open_Allowed)
                //    col_1_btns.Add(btnCashDrawer);
                //if (config.Sub_Total_Panel_Visible)
                //    col_1_btns.Add(btnSubTotal);
                //if (config.Print_Invoice_Button_Visible)
                //    col_1_btns.Add(btnPrint);

                //int firstRowSpan = 12 / col_1_btns.Count;
                //for (int i = 0; i < col_1_btns.Count; i++) {
                //    pnlMoneyActions.SetRow(col_1_btns[i], i);
                //    pnlMoneyActions.SetRowSpan(col_1_btns[i], firstRowSpan);
                //}



                pnlMoneyActions.SetRow(btnDone, config.DoneButtonRow);
                pnlMoneyActions.SetRowSpan(btnDone, config.DoneButtonRowSpan);

                pnlMoneyActions.SetRow(btnCashDrawer, config.CashDrawerButtonRow);
                pnlMoneyActions.SetRowSpan(btnCashDrawer, config.CashDrawerButtonRowSpan);

                //pnlMoneyActions.SetRow(btnSubTotal, config.SubTotalButtonRow);
                //pnlMoneyActions.SetRowSpan(btnSubTotal, config.SubTotalButtonRowSpan);

                pnlMoneyActions.SetRow(btnPrint, config.PrintButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrint, config.PrintButtonRowSpan);



                pnlMoneyActions.SetRow(btnHoldOrder, config.HoldOrderButtonRow);
                pnlMoneyActions.SetRowSpan(btnHoldOrder, config.HoldOrderButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCashFinalPayment, config.CashButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCashFinalPayment, config.CashButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCashFinalPayment, config.CashButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCashFinalPayment, config.CashButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCardFinalPayment, config.CardButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCardFinalPayment, config.CardButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCardFinalPayment, config.CardButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCardFinalPayment, config.CardButtonRowSpan);



                pnlMoneyActions.SetRow(btnHoldAndReceipt, config.HoldAndPrintOrderButtonRow);
                pnlMoneyActions.SetRowSpan(btnHoldAndReceipt, config.HoldAndPrintOrderButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCashFinalPaymentWithReceipt, config.CashAndPrintButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCashFinalPaymentWithReceipt, config.CashAndPrintButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCashFinalPaymentWithReceipt, config.CashAndPrintButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCashFinalPaymentWithReceipt, config.CashAndPrintButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCardFinalPaymentWithReceipt, config.CardAndPrintButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCardFinalPaymentWithReceipt, config.CardAndPrintButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCardFinalPaymentWithReceipt, config.CardAndPrintButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCardFinalPaymentWithReceipt, config.CardAndPrintButtonRowSpan);
                pnlMoneyActions.Padding = new Padding(0, 0, 20, 10);
                #endregion


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void mnuChangeMenu_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            frmMenuSelector frm = ActivatorUtilities.CreateInstance< frmMenuSelector>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                config.ActiveMenuIID = frm.SelectedMenuIID;
                UF.SaveConfig(config);
                bslayer.ActiveMenu =await bslayer.GetActiveMenu(true, true);
                await LoadUserInterface();
            }
        }

        //private void LoadMenuList() {
        //    mnuChangeMenu.DropDownItems.Clear();

        //    List<FMenu> menuList = bslayer.GetMenuListDB();

        //    foreach (FMenu fm in menuList) {
        //        ToolStripMenuItem btn = new ToolStripMenuItem();
        //        btn.Tag = fm.IID;
        //        btn.Text = fm.MenuName.ToUpper();
        //        btn.Click += MenuSelect_Click;
        //        mnuChangeMenu.DropDownItems.Add(btn);
        //    }
        //}

        private async void MenuSelect_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            string menuIID = btn.Tag.ToString();

            config.ActiveMenuIID = menuIID;

            UF.SaveConfig(config);
            bslayer.ActiveMenu =await bslayer.GetActiveMenu(true, true);
            await LoadUserInterface();
            //RefreshUserInterface();
        }

        private async Task LoadViewBars()
        {
            List<Distribution> theList = await repoDistribution.GetListByField("MenuIID", config.ActiveMenuIID);
            foreach (Distribution distro in theList)
            {
                ToolStripMenuItem btn = new ToolStripMenuItem();
                btn.Image = global::DTRMNS.Properties.Resources.chef64;
                btn.Tag = distro;
                btn.Text = distro.DistributionName;
                btn.Click += ViewBar_Click;
                mnuViewBars.DropDownItems.Add(btn);
            }
        }
        private void ViewBar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;              
            Distribution distribution = (Distribution)btn.Tag;
            frmKitchenSingleDisplay frm = ActivatorUtilities.CreateInstance< frmKitchenSingleDisplay>(ServiceHelper.Services, distribution, true, true);
            frm.ShowDialog();

        }

        private async Task LoadBonusSchemes()
        {
            pnlBonus.Activate();
            List<Bonus> theList = await repoBonus.GetAllAsync();
            mnuSelectBonusPlan.DropDownItems.Clear();
            foreach (Bonus bon in theList)
            {
                ToolStripMenuItem btn = new ToolStripMenuItem();
                btn.Image = global::DTRMNS.Properties.Resources.Bonus48;
                btn.Tag = bon.IID;
                btn.Text = bon.PlanName;
                btn.Click += BonusScheme_Click;
                mnuSelectBonusPlan.DropDownItems.Add(btn);
            }

            //If Bonus Scheme Auto Selected
            if (bslayer.currentBonusScheme != null)
                mnuSelectBonusPlan.Text = bslayer.currentBonusScheme.PlanName + " (or Change)";

        }
        private async void BonusScheme_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            string bonusIID = btn.Tag.ToString();

            bslayer.currentBonusScheme = await repoBonus.Get(bonusIID);
            mnuSelectBonusPlan.Text = bslayer.currentBonusScheme.PlanName + " (or Change)";
            pnlBonus.UpdateBonusDisplay();

        }

        private void Lock()
        {
            if (blnLockable)
            {
                this.Hide();
                this.Enabled = false;
                DetachPanel();  //To prevent any admin panel visibility
                Locker.Show();
            }
        }

        /// <summary>ok
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //bslayer.CDGoodbye();
                //bslayer.UnsetDisplayPort();
                //bslayer = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trmOrderPadMain));
            popHold = new ContextMenuStrip(components);
            btnHoldPink = new ToolStripMenuItem();
            btnHoldBlue = new ToolStripMenuItem();
            btnHoldYellow = new ToolStripMenuItem();
            btnHoldGreen = new ToolStripMenuItem();
            btnHoldOrange = new ToolStripMenuItem();
            popHoldAndPrint = new ContextMenuStrip(components);
            btnHoldAndReceiptPink = new ToolStripMenuItem();
            btnHoldAndReceiptBlue = new ToolStripMenuItem();
            btnHoldAndReceiptYellow = new ToolStripMenuItem();
            btnHoldAndReceiptGreen = new ToolStripMenuItem();
            btnHoldAndReceiptOrange = new ToolStripMenuItem();
            pnlStandardDisplay = new Panel();
            OrderScreen = ActivatorUtilities.CreateInstance<OrderDisplay>(sp);
            pnlMoneyActions = new TableLayoutPanel();
            btnPrintOnlineFinalPaymentWithReceipt = new Button();
            btnPrintOnlineFinalPayment = new Button();
            btnPrint = new Button();
            btnDone = new Button();
            btnCashDrawer = new Button();
            btnPrintCardFinalPaymentWithReceipt = new Button();
            btnPrintCashFinalPaymentWithReceipt = new Button();
            btnPrintCardFinalPayment = new Button();
            btnPrintCashFinalPayment = new Button();
            btnHoldAndReceipt = new Button();
            btnHoldOrder = new Button();
            pnlBonus = ActivatorUtilities.CreateInstance<ctlBonus>(sp);
            pnlSubTotal = new Panel();
            pnlSubMoneyActions = new TableLayoutPanel();
            button1 = new Button();
            btnSubTotalCash = new Button();
            btnSubTotalFullAmount = new Button();
            btnSubTotalCashWR = new Button();
            btnHideSubTotal = new Button();
            button61 = new Button();
            button89 = new Button();
            button58 = new Button();
            button12 = new Button();
            button6 = new Button();
            button3 = new Button();
            button5 = new Button();
            button57 = new Button();
            button86 = new Button();
            button75 = new Button();
            button4 = new Button();
            button95 = new Button();
            button94 = new Button();
            button93 = new Button();
            button107 = new Button();
            btnC = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pnlcizgi = new Panel();
            lblPayedIn = new Label();
            label2 = new Label();
            lblMoneyBack = new Label();
            label3 = new Label();
            lblOrderTotal = new Label();
            pnlDisplay = new Panel();
            pnlTop = new FlowLayoutPanel();
            cmdDirectSale = new Button();
            cmdTables = new Button();
            cmdTakeAway = new Button();
            cmdDelivery = new Button();
            mnuFunctions = new MenuStrip();
            mnuTools = new ToolStripMenuItem();
            mnuOrders = new ToolStripMenuItem();
            mnuShrinkOrderDisplay = new ToolStripMenuItem();
            mnuKitchen = new ToolStripMenuItem();
            mnuViewBars = new ToolStripMenuItem();
            mnuPrintForKitchen = new ToolStripMenuItem();
            mnuResetKitchenOrders = new ToolStripMenuItem();
            mnuReports = new ToolStripMenuItem();
            mnuLock = new ToolStripMenuItem();
            mnuSum = new ToolStripMenuItem();
            mnuSelectBonusPlan = new ToolStripMenuItem();
            mnuCustomer = new ToolStripMenuItem();
            mnuAdmin = new ToolStripMenuItem();
            mnuDebug = new ToolStripMenuItem();
            mnuReprintReport = new ToolStripMenuItem();
            mnuSupervisorReport = new ToolStripMenuItem();
            mnuChangeMenu = new ToolStripMenuItem();
            mnuReloadMenu = new ToolStripMenuItem();
            mnuOptions = new ToolStripMenuItem();
            mnuPrintAsInvoice = new ToolStripMenuItem();
            mnuOrientation = new ToolStripMenuItem();
            mnuPad = new ToolStripMenuItem();
            mnuDrawerCalculator = new ToolStripMenuItem();
            mnuStock = new ToolStripMenuItem();
            mnuShoppingList = new ToolStripMenuItem();
            mnuSupplierPurchaseList = new ToolStripMenuItem();
            mnuPrintStockUsageReport = new ToolStripMenuItem();
            cmdCancel = new Button();
            btnExpandShrinkHoldButtonDetails = new Button();
            pnlOrderPad = new FlowLayoutPanel();
            pnlPendingOrders = new FlowLayoutPanel();
            tmrHoldingOrders = new Timer(components);
            pnlHolder = new Panel();
            tmrScreenSaverTrigger = new Timer(components);
            tmrHoldOrderAutoClose = new Timer(components);
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            button10 = new Button();
            popHold.SuspendLayout();
            popHoldAndPrint.SuspendLayout();
            pnlStandardDisplay.SuspendLayout();
            pnlMoneyActions.SuspendLayout();
            pnlSubTotal.SuspendLayout();
            pnlSubMoneyActions.SuspendLayout();
            panel1.SuspendLayout();
            pnlDisplay.SuspendLayout();
            pnlTop.SuspendLayout();
            mnuFunctions.SuspendLayout();
            SuspendLayout();
            // 
            // popHold
            // 
            popHold.AutoSize = false;
            popHold.Items.AddRange(new ToolStripItem[] { btnHoldPink, btnHoldBlue, btnHoldYellow, btnHoldGreen, btnHoldOrange });
            popHold.Name = "popHold";
            popHold.Size = new Size(100, 494);
            // 
            // btnHoldPink
            // 
            btnHoldPink.AutoSize = false;
            btnHoldPink.BackColor = Color.Black;
            btnHoldPink.BackgroundImage = Properties.Resources.PClip64;
            btnHoldPink.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldPink.Name = "btnHoldPink";
            btnHoldPink.Size = new Size(98, 98);
            btnHoldPink.Tag = "Pink";
            btnHoldPink.Click += btnHoldOrder_Click;
            // 
            // btnHoldBlue
            // 
            btnHoldBlue.AutoSize = false;
            btnHoldBlue.BackColor = Color.Black;
            btnHoldBlue.BackgroundImage = Properties.Resources.PClipBlue64;
            btnHoldBlue.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldBlue.Name = "btnHoldBlue";
            btnHoldBlue.Size = new Size(98, 98);
            btnHoldBlue.Tag = "Blue";
            btnHoldBlue.Click += btnHoldOrder_Click;
            // 
            // btnHoldYellow
            // 
            btnHoldYellow.AutoSize = false;
            btnHoldYellow.BackColor = Color.Black;
            btnHoldYellow.BackgroundImage = Properties.Resources.PClipYellow64;
            btnHoldYellow.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldYellow.Name = "btnHoldYellow";
            btnHoldYellow.Size = new Size(98, 98);
            btnHoldYellow.Tag = "Yellow";
            btnHoldYellow.Click += btnHoldOrder_Click;
            // 
            // btnHoldGreen
            // 
            btnHoldGreen.AutoSize = false;
            btnHoldGreen.BackColor = Color.Black;
            btnHoldGreen.BackgroundImage = Properties.Resources.PClipGreen64;
            btnHoldGreen.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldGreen.Name = "btnHoldGreen";
            btnHoldGreen.Size = new Size(98, 98);
            btnHoldGreen.Tag = "Green";
            btnHoldGreen.Click += btnHoldOrder_Click;
            // 
            // btnHoldOrange
            // 
            btnHoldOrange.AutoSize = false;
            btnHoldOrange.BackColor = Color.Black;
            btnHoldOrange.BackgroundImage = Properties.Resources.PClipOrange64;
            btnHoldOrange.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldOrange.Name = "btnHoldOrange";
            btnHoldOrange.Size = new Size(98, 98);
            btnHoldOrange.Tag = "Orange";
            btnHoldOrange.Click += btnHoldOrder_Click;
            // 
            // popHoldAndPrint
            // 
            popHoldAndPrint.AutoSize = false;
            popHoldAndPrint.Items.AddRange(new ToolStripItem[] { btnHoldAndReceiptPink, btnHoldAndReceiptBlue, btnHoldAndReceiptYellow, btnHoldAndReceiptGreen, btnHoldAndReceiptOrange });
            popHoldAndPrint.Name = "popHold";
            popHoldAndPrint.Size = new Size(100, 494);
            // 
            // btnHoldAndReceiptPink
            // 
            btnHoldAndReceiptPink.AutoSize = false;
            btnHoldAndReceiptPink.BackColor = Color.Black;
            btnHoldAndReceiptPink.BackgroundImage = Properties.Resources.PClip64;
            btnHoldAndReceiptPink.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldAndReceiptPink.Image = (Image)resources.GetObject("btnHoldAndReceiptPink.Image");
            btnHoldAndReceiptPink.ImageScaling = ToolStripItemImageScaling.None;
            btnHoldAndReceiptPink.Name = "btnHoldAndReceiptPink";
            btnHoldAndReceiptPink.Size = new Size(98, 98);
            btnHoldAndReceiptPink.Tag = "Pink";
            btnHoldAndReceiptPink.Click += btnHoldAndReceipt_Click;
            // 
            // btnHoldAndReceiptBlue
            // 
            btnHoldAndReceiptBlue.AutoSize = false;
            btnHoldAndReceiptBlue.BackColor = Color.Black;
            btnHoldAndReceiptBlue.BackgroundImage = Properties.Resources.PClipBlue64;
            btnHoldAndReceiptBlue.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldAndReceiptBlue.Image = (Image)resources.GetObject("btnHoldAndReceiptBlue.Image");
            btnHoldAndReceiptBlue.ImageScaling = ToolStripItemImageScaling.None;
            btnHoldAndReceiptBlue.Name = "btnHoldAndReceiptBlue";
            btnHoldAndReceiptBlue.Size = new Size(98, 98);
            btnHoldAndReceiptBlue.Tag = "Blue";
            btnHoldAndReceiptBlue.Click += btnHoldAndReceipt_Click;
            // 
            // btnHoldAndReceiptYellow
            // 
            btnHoldAndReceiptYellow.AutoSize = false;
            btnHoldAndReceiptYellow.BackColor = Color.Black;
            btnHoldAndReceiptYellow.BackgroundImage = Properties.Resources.PClipYellow64;
            btnHoldAndReceiptYellow.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldAndReceiptYellow.Image = (Image)resources.GetObject("btnHoldAndReceiptYellow.Image");
            btnHoldAndReceiptYellow.ImageScaling = ToolStripItemImageScaling.None;
            btnHoldAndReceiptYellow.Name = "btnHoldAndReceiptYellow";
            btnHoldAndReceiptYellow.Size = new Size(98, 98);
            btnHoldAndReceiptYellow.Tag = "Yellow";
            btnHoldAndReceiptYellow.Click += btnHoldAndReceipt_Click;
            // 
            // btnHoldAndReceiptGreen
            // 
            btnHoldAndReceiptGreen.AutoSize = false;
            btnHoldAndReceiptGreen.BackColor = Color.Black;
            btnHoldAndReceiptGreen.BackgroundImage = Properties.Resources.PClipGreen64;
            btnHoldAndReceiptGreen.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldAndReceiptGreen.Image = (Image)resources.GetObject("btnHoldAndReceiptGreen.Image");
            btnHoldAndReceiptGreen.ImageScaling = ToolStripItemImageScaling.None;
            btnHoldAndReceiptGreen.Name = "btnHoldAndReceiptGreen";
            btnHoldAndReceiptGreen.Size = new Size(98, 98);
            btnHoldAndReceiptGreen.Tag = "Green";
            btnHoldAndReceiptGreen.Click += btnHoldAndReceipt_Click;
            // 
            // btnHoldAndReceiptOrange
            // 
            btnHoldAndReceiptOrange.AutoSize = false;
            btnHoldAndReceiptOrange.BackColor = Color.Black;
            btnHoldAndReceiptOrange.BackgroundImage = Properties.Resources.PClipOrange64;
            btnHoldAndReceiptOrange.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldAndReceiptOrange.Image = (Image)resources.GetObject("btnHoldAndReceiptOrange.Image");
            btnHoldAndReceiptOrange.ImageScaling = ToolStripItemImageScaling.None;
            btnHoldAndReceiptOrange.Name = "btnHoldAndReceiptOrange";
            btnHoldAndReceiptOrange.Size = new Size(98, 98);
            btnHoldAndReceiptOrange.Tag = "Orange";
            btnHoldAndReceiptOrange.Click += btnHoldAndReceipt_Click;
            // 
            // pnlStandardDisplay
            // 
            pnlStandardDisplay.BackColor = Color.Maroon;
            pnlStandardDisplay.Controls.Add(OrderScreen);
            pnlStandardDisplay.Controls.Add(pnlMoneyActions);
            pnlStandardDisplay.Controls.Add(pnlBonus);
            pnlStandardDisplay.Dock = DockStyle.Fill;
            pnlStandardDisplay.ForeColor = SystemColors.ControlText;
            pnlStandardDisplay.Location = new Point(0, 0);
            pnlStandardDisplay.Margin = new Padding(4, 3, 4, 3);
            pnlStandardDisplay.Name = "pnlStandardDisplay";
            pnlStandardDisplay.Size = new Size(366, 898);
            pnlStandardDisplay.TabIndex = 22;
            // 
            // OrderScreen
            // 
            OrderScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OrderScreen.BackColor = Color.FromArgb(192, 192, 0);
            OrderScreen.Cursor = Cursors.Hand;
            OrderScreen.Dock = DockStyle.Fill;
            OrderScreen.Location = new Point(0, 25);
            OrderScreen.Margin = new Padding(4, 3, 4, 3);
            OrderScreen.Name = "OrderScreen";
            OrderScreen.OrderToDisplay = null;
            OrderScreen.OrderToSplit = null;
            OrderScreen.Size = new Size(366, 613);
            OrderScreen.SplitDisplayHeight = 315;
            OrderScreen.TabIndex = 20;
            OrderScreen.DisplayOccured += OrderScreen_DisplayOccured;
            OrderScreen.TopItemDeleted += OrderScreen_TopItemDeleted;
            OrderScreen.SplitStarting += OrderScreen_SplitStarting;
            OrderScreen.SplitContinuing += OrderScreen_SplitContinuing;
            OrderScreen.SplitEnding += OrderScreen_SplitEnding;
            OrderScreen.ZeroItemsLeft += OrderScreen_ZeroItemsLeft;
            OrderScreen.Click += OrderScreen_Click;
            // 
            // pnlMoneyActions
            // 
            pnlMoneyActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMoneyActions.BackColor = Color.Black;
            pnlMoneyActions.ColumnCount = 3;
            pnlMoneyActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlMoneyActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlMoneyActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlMoneyActions.Controls.Add(btnPrintOnlineFinalPaymentWithReceipt, 1, 10);
            pnlMoneyActions.Controls.Add(btnPrintOnlineFinalPayment, 0, 10);
            pnlMoneyActions.Controls.Add(btnPrint, 0, 8);
            pnlMoneyActions.Controls.Add(btnDone, 0, 0);
            pnlMoneyActions.Controls.Add(btnCashDrawer, 0, 4);
            pnlMoneyActions.Controls.Add(btnPrintCardFinalPaymentWithReceipt, 2, 8);
            pnlMoneyActions.Controls.Add(btnPrintCashFinalPaymentWithReceipt, 2, 4);
            pnlMoneyActions.Controls.Add(btnPrintCardFinalPayment, 1, 8);
            pnlMoneyActions.Controls.Add(btnPrintCashFinalPayment, 1, 4);
            pnlMoneyActions.Controls.Add(btnHoldAndReceipt, 2, 0);
            pnlMoneyActions.Controls.Add(btnHoldOrder, 1, 0);
            pnlMoneyActions.Dock = DockStyle.Bottom;
            pnlMoneyActions.Location = new Point(0, 638);
            pnlMoneyActions.Margin = new Padding(4, 3, 4, 3);
            pnlMoneyActions.MinimumSize = new Size(330, 260);
            pnlMoneyActions.Name = "pnlMoneyActions";
            pnlMoneyActions.Padding = new Padding(0, 0, 5, 0);
            pnlMoneyActions.RowCount = 12;
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 7.94223833F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.66426F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            pnlMoneyActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            pnlMoneyActions.Size = new Size(366, 260);
            pnlMoneyActions.TabIndex = 22;
            // 
            // btnPrintOnlineFinalPaymentWithReceipt
            // 
            btnPrintOnlineFinalPaymentWithReceipt.AutoEllipsis = true;
            btnPrintOnlineFinalPaymentWithReceipt.BackColor = Color.Black;
            btnPrintOnlineFinalPaymentWithReceipt.BackgroundImage = Properties.Resources.web;
            btnPrintOnlineFinalPaymentWithReceipt.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintOnlineFinalPaymentWithReceipt.Dock = DockStyle.Fill;
            btnPrintOnlineFinalPaymentWithReceipt.FlatAppearance.BorderColor = Color.White;
            btnPrintOnlineFinalPaymentWithReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintOnlineFinalPaymentWithReceipt.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintOnlineFinalPaymentWithReceipt.ForeColor = Color.FromArgb(0, 0, 0);
            btnPrintOnlineFinalPaymentWithReceipt.Image = Properties.Resources.Print32;
            btnPrintOnlineFinalPaymentWithReceipt.ImageAlign = ContentAlignment.TopRight;
            btnPrintOnlineFinalPaymentWithReceipt.ImeMode = ImeMode.NoControl;
            btnPrintOnlineFinalPaymentWithReceipt.Location = new Point(244, 213);
            btnPrintOnlineFinalPaymentWithReceipt.Margin = new Padding(4, 3, 4, 3);
            btnPrintOnlineFinalPaymentWithReceipt.Name = "btnPrintOnlineFinalPaymentWithReceipt";
            pnlMoneyActions.SetRowSpan(btnPrintOnlineFinalPaymentWithReceipt, 2);
            btnPrintOnlineFinalPaymentWithReceipt.Size = new Size(113, 44);
            btnPrintOnlineFinalPaymentWithReceipt.TabIndex = 54;
            btnPrintOnlineFinalPaymentWithReceipt.TabStop = false;
            btnPrintOnlineFinalPaymentWithReceipt.UseVisualStyleBackColor = false;
            btnPrintOnlineFinalPaymentWithReceipt.Click += btnPrintOnlineFinalPaymentWithReceipt_Click;
            // 
            // btnPrintOnlineFinalPayment
            // 
            btnPrintOnlineFinalPayment.AutoSize = true;
            btnPrintOnlineFinalPayment.BackColor = Color.Black;
            btnPrintOnlineFinalPayment.BackgroundImage = Properties.Resources.web;
            btnPrintOnlineFinalPayment.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintOnlineFinalPayment.Dock = DockStyle.Fill;
            btnPrintOnlineFinalPayment.FlatAppearance.BorderColor = Color.White;
            btnPrintOnlineFinalPayment.FlatStyle = FlatStyle.Flat;
            btnPrintOnlineFinalPayment.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintOnlineFinalPayment.ForeColor = Color.FromArgb(0, 0, 0);
            btnPrintOnlineFinalPayment.ImeMode = ImeMode.NoControl;
            btnPrintOnlineFinalPayment.Location = new Point(124, 213);
            btnPrintOnlineFinalPayment.Margin = new Padding(4, 3, 4, 3);
            btnPrintOnlineFinalPayment.Name = "btnPrintOnlineFinalPayment";
            pnlMoneyActions.SetRowSpan(btnPrintOnlineFinalPayment, 2);
            btnPrintOnlineFinalPayment.Size = new Size(112, 44);
            btnPrintOnlineFinalPayment.TabIndex = 53;
            btnPrintOnlineFinalPayment.TabStop = false;
            btnPrintOnlineFinalPayment.UseVisualStyleBackColor = false;
            btnPrintOnlineFinalPayment.Click += btnPrintOnlineFinalPaymentNoReceipt_Click;
            // 
            // btnPrint
            // 
            btnPrint.AutoEllipsis = true;
            btnPrint.BackColor = Color.Black;
            btnPrint.BackgroundImageLayout = ImageLayout.None;
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.FlatAppearance.BorderColor = Color.White;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Image = Properties.Resources.Print32;
            btnPrint.ImeMode = ImeMode.NoControl;
            btnPrint.Location = new Point(4, 171);
            btnPrint.Margin = new Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            pnlMoneyActions.SetRowSpan(btnPrint, 4);
            btnPrint.Size = new Size(112, 86);
            btnPrint.TabIndex = 34;
            btnPrint.TabStop = false;
            btnPrint.Text = "\r\nPRINT";
            btnPrint.TextAlign = ContentAlignment.BottomCenter;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnDone
            // 
            btnDone.AutoEllipsis = true;
            btnDone.BackColor = Color.Black;
            btnDone.BackgroundImage = Properties.Resources.okay;
            btnDone.BackgroundImageLayout = ImageLayout.Zoom;
            btnDone.Dock = DockStyle.Fill;
            btnDone.FlatAppearance.BorderColor = Color.White;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnDone.ForeColor = Color.White;
            btnDone.ImeMode = ImeMode.NoControl;
            btnDone.Location = new Point(4, 3);
            btnDone.Margin = new Padding(4, 3, 4, 3);
            btnDone.Name = "btnDone";
            pnlMoneyActions.SetRowSpan(btnDone, 4);
            btnDone.Size = new Size(112, 77);
            btnDone.TabIndex = 23;
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Visible = false;
            btnDone.Click += btnDone_Click;
            // 
            // btnCashDrawer
            // 
            btnCashDrawer.AutoEllipsis = true;
            btnCashDrawer.BackColor = Color.Black;
            btnCashDrawer.BackgroundImageLayout = ImageLayout.Center;
            btnCashDrawer.Dock = DockStyle.Fill;
            btnCashDrawer.FlatAppearance.BorderColor = Color.White;
            btnCashDrawer.FlatStyle = FlatStyle.Flat;
            btnCashDrawer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCashDrawer.ForeColor = Color.White;
            btnCashDrawer.Image = Properties.Resources.Lightning;
            btnCashDrawer.ImeMode = ImeMode.NoControl;
            btnCashDrawer.Location = new Point(4, 86);
            btnCashDrawer.Margin = new Padding(4, 3, 4, 3);
            btnCashDrawer.Name = "btnCashDrawer";
            pnlMoneyActions.SetRowSpan(btnCashDrawer, 4);
            btnCashDrawer.Size = new Size(112, 79);
            btnCashDrawer.TabIndex = 36;
            btnCashDrawer.Text = "CASH DRAWER";
            btnCashDrawer.TextAlign = ContentAlignment.BottomCenter;
            btnCashDrawer.UseVisualStyleBackColor = false;
            btnCashDrawer.Click += btnFault_Click;
            // 
            // btnPrintCardFinalPaymentWithReceipt
            // 
            btnPrintCardFinalPaymentWithReceipt.AutoEllipsis = true;
            btnPrintCardFinalPaymentWithReceipt.BackColor = Color.Black;
            btnPrintCardFinalPaymentWithReceipt.BackgroundImage = Properties.Resources.pin64;
            btnPrintCardFinalPaymentWithReceipt.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintCardFinalPaymentWithReceipt.Dock = DockStyle.Fill;
            btnPrintCardFinalPaymentWithReceipt.FlatAppearance.BorderColor = Color.White;
            btnPrintCardFinalPaymentWithReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintCardFinalPaymentWithReceipt.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintCardFinalPaymentWithReceipt.ForeColor = Color.FromArgb(0, 0, 0);
            btnPrintCardFinalPaymentWithReceipt.Image = Properties.Resources.Print32;
            btnPrintCardFinalPaymentWithReceipt.ImageAlign = ContentAlignment.TopRight;
            btnPrintCardFinalPaymentWithReceipt.ImeMode = ImeMode.NoControl;
            btnPrintCardFinalPaymentWithReceipt.Location = new Point(244, 171);
            btnPrintCardFinalPaymentWithReceipt.Margin = new Padding(4, 3, 4, 3);
            btnPrintCardFinalPaymentWithReceipt.Name = "btnPrintCardFinalPaymentWithReceipt";
            pnlMoneyActions.SetRowSpan(btnPrintCardFinalPaymentWithReceipt, 2);
            btnPrintCardFinalPaymentWithReceipt.Size = new Size(113, 36);
            btnPrintCardFinalPaymentWithReceipt.TabIndex = 40;
            btnPrintCardFinalPaymentWithReceipt.TabStop = false;
            btnPrintCardFinalPaymentWithReceipt.UseVisualStyleBackColor = false;
            btnPrintCardFinalPaymentWithReceipt.Click += btnPrintCardFinalPaymentWithReceipt_Click;
            // 
            // btnPrintCashFinalPaymentWithReceipt
            // 
            btnPrintCashFinalPaymentWithReceipt.AutoSize = true;
            btnPrintCashFinalPaymentWithReceipt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrintCashFinalPaymentWithReceipt.BackColor = Color.Black;
            btnPrintCashFinalPaymentWithReceipt.BackgroundImage = Properties.Resources.Euro;
            btnPrintCashFinalPaymentWithReceipt.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintCashFinalPaymentWithReceipt.Dock = DockStyle.Fill;
            btnPrintCashFinalPaymentWithReceipt.FlatAppearance.BorderColor = Color.White;
            btnPrintCashFinalPaymentWithReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintCashFinalPaymentWithReceipt.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintCashFinalPaymentWithReceipt.ForeColor = Color.FromArgb(0, 0, 0);
            btnPrintCashFinalPaymentWithReceipt.Image = Properties.Resources.Print32;
            btnPrintCashFinalPaymentWithReceipt.ImageAlign = ContentAlignment.TopRight;
            btnPrintCashFinalPaymentWithReceipt.ImeMode = ImeMode.NoControl;
            btnPrintCashFinalPaymentWithReceipt.Location = new Point(244, 86);
            btnPrintCashFinalPaymentWithReceipt.Margin = new Padding(4, 3, 4, 3);
            btnPrintCashFinalPaymentWithReceipt.Name = "btnPrintCashFinalPaymentWithReceipt";
            pnlMoneyActions.SetRowSpan(btnPrintCashFinalPaymentWithReceipt, 4);
            btnPrintCashFinalPaymentWithReceipt.Size = new Size(113, 79);
            btnPrintCashFinalPaymentWithReceipt.TabIndex = 34;
            btnPrintCashFinalPaymentWithReceipt.TabStop = false;
            btnPrintCashFinalPaymentWithReceipt.UseVisualStyleBackColor = false;
            btnPrintCashFinalPaymentWithReceipt.Click += btnPrintCashFinalPaymentWithReceipt_Click;
            // 
            // btnPrintCardFinalPayment
            // 
            btnPrintCardFinalPayment.AutoSize = true;
            btnPrintCardFinalPayment.BackColor = Color.Black;
            btnPrintCardFinalPayment.BackgroundImage = Properties.Resources.pin64;
            btnPrintCardFinalPayment.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintCardFinalPayment.Dock = DockStyle.Fill;
            btnPrintCardFinalPayment.FlatAppearance.BorderColor = Color.White;
            btnPrintCardFinalPayment.FlatStyle = FlatStyle.Flat;
            btnPrintCardFinalPayment.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintCardFinalPayment.ForeColor = Color.FromArgb(0, 0, 0);
            btnPrintCardFinalPayment.ImeMode = ImeMode.NoControl;
            btnPrintCardFinalPayment.Location = new Point(124, 171);
            btnPrintCardFinalPayment.Margin = new Padding(4, 3, 4, 3);
            btnPrintCardFinalPayment.Name = "btnPrintCardFinalPayment";
            pnlMoneyActions.SetRowSpan(btnPrintCardFinalPayment, 2);
            btnPrintCardFinalPayment.Size = new Size(112, 36);
            btnPrintCardFinalPayment.TabIndex = 38;
            btnPrintCardFinalPayment.TabStop = false;
            btnPrintCardFinalPayment.UseVisualStyleBackColor = false;
            btnPrintCardFinalPayment.Click += btnPrintCardFinalPaymentNoReceipt_Click;
            // 
            // btnPrintCashFinalPayment
            // 
            btnPrintCashFinalPayment.AutoSize = true;
            btnPrintCashFinalPayment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrintCashFinalPayment.BackColor = Color.Black;
            btnPrintCashFinalPayment.BackgroundImage = Properties.Resources.Euro;
            btnPrintCashFinalPayment.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintCashFinalPayment.Dock = DockStyle.Fill;
            btnPrintCashFinalPayment.FlatAppearance.BorderColor = Color.White;
            btnPrintCashFinalPayment.FlatStyle = FlatStyle.Flat;
            btnPrintCashFinalPayment.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintCashFinalPayment.ForeColor = Color.FromArgb(0, 0, 0);
            btnPrintCashFinalPayment.ImeMode = ImeMode.NoControl;
            btnPrintCashFinalPayment.Location = new Point(124, 86);
            btnPrintCashFinalPayment.Margin = new Padding(4, 3, 4, 3);
            btnPrintCashFinalPayment.Name = "btnPrintCashFinalPayment";
            pnlMoneyActions.SetRowSpan(btnPrintCashFinalPayment, 4);
            btnPrintCashFinalPayment.Size = new Size(112, 79);
            btnPrintCashFinalPayment.TabIndex = 31;
            btnPrintCashFinalPayment.TabStop = false;
            btnPrintCashFinalPayment.UseVisualStyleBackColor = false;
            btnPrintCashFinalPayment.Click += btnPrintCashFinalPaymentNoReceipt_Click;
            // 
            // btnHoldAndReceipt
            // 
            btnHoldAndReceipt.BackgroundImage = Properties.Resources.PClip64;
            btnHoldAndReceipt.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldAndReceipt.ContextMenuStrip = popHoldAndPrint;
            btnHoldAndReceipt.Dock = DockStyle.Fill;
            btnHoldAndReceipt.FlatStyle = FlatStyle.Flat;
            btnHoldAndReceipt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHoldAndReceipt.ForeColor = Color.White;
            btnHoldAndReceipt.ImageAlign = ContentAlignment.BottomLeft;
            btnHoldAndReceipt.ImeMode = ImeMode.NoControl;
            btnHoldAndReceipt.Location = new Point(244, 3);
            btnHoldAndReceipt.Margin = new Padding(4, 3, 4, 3);
            btnHoldAndReceipt.Name = "btnHoldAndReceipt";
            pnlMoneyActions.SetRowSpan(btnHoldAndReceipt, 4);
            btnHoldAndReceipt.Size = new Size(113, 77);
            btnHoldAndReceipt.TabIndex = 52;
            btnHoldAndReceipt.Text = "HOLD PRINT";
            btnHoldAndReceipt.UseVisualStyleBackColor = true;
            btnHoldAndReceipt.Click += btnHoldAndPrint_Click;
            // 
            // btnHoldOrder
            // 
            btnHoldOrder.BackgroundImage = Properties.Resources.PClip64;
            btnHoldOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoldOrder.ContextMenuStrip = popHold;
            btnHoldOrder.Dock = DockStyle.Fill;
            btnHoldOrder.FlatStyle = FlatStyle.Flat;
            btnHoldOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHoldOrder.ForeColor = Color.White;
            btnHoldOrder.ImeMode = ImeMode.NoControl;
            btnHoldOrder.Location = new Point(124, 3);
            btnHoldOrder.Margin = new Padding(4, 3, 4, 3);
            btnHoldOrder.Name = "btnHoldOrder";
            pnlMoneyActions.SetRowSpan(btnHoldOrder, 4);
            btnHoldOrder.Size = new Size(112, 77);
            btnHoldOrder.TabIndex = 0;
            btnHoldOrder.Text = "HOLD";
            btnHoldOrder.UseVisualStyleBackColor = true;
            btnHoldOrder.Click += btnHold_Click;
            // 
            // pnlBonus
            // 
            pnlBonus.AutoSize = true;
            pnlBonus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlBonus.BackColor = Color.Black;
            pnlBonus.ControlBackColor = Color.Black;
            pnlBonus.ControlFont = new Font("Microsoft Sans Serif", 12F);
            pnlBonus.ControlForeColor = Color.White;
            pnlBonus.Dock = DockStyle.Top;
            pnlBonus.EnableAutoUpdate = true;
            pnlBonus.Font = new Font("Microsoft Sans Serif", 12F);
            pnlBonus.ForeColor = Color.White;
            pnlBonus.Location = new Point(0, 0);
            pnlBonus.Margin = new Padding(5);
            pnlBonus.MinimumSize = new Size(259, 25);
            pnlBonus.Name = "pnlBonus";
            pnlBonus.Padding = new Padding(4, 0, 4, 0);
            pnlBonus.ProgressBarWidth = 267;
            pnlBonus.Size = new Size(366, 25);
            pnlBonus.TabIndex = 21;
            pnlBonus.Visible = false;
            pnlBonus.Click += pnlBonus_Click;
            // 
            // pnlSubTotal
            // 
            pnlSubTotal.BackColor = Color.Transparent;
            pnlSubTotal.Controls.Add(pnlSubMoneyActions);
            pnlSubTotal.Controls.Add(panel1);
            pnlSubTotal.Dock = DockStyle.Fill;
            pnlSubTotal.ForeColor = Color.White;
            pnlSubTotal.Location = new Point(0, 0);
            pnlSubTotal.Margin = new Padding(4, 3, 4, 3);
            pnlSubTotal.Name = "pnlSubTotal";
            pnlSubTotal.Size = new Size(366, 898);
            pnlSubTotal.TabIndex = 21;
            // 
            // pnlSubMoneyActions
            // 
            pnlSubMoneyActions.ColumnCount = 3;
            pnlSubMoneyActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlSubMoneyActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlSubMoneyActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlSubMoneyActions.Controls.Add(button1, 2, 5);
            pnlSubMoneyActions.Controls.Add(btnSubTotalCash, 1, 6);
            pnlSubMoneyActions.Controls.Add(btnSubTotalFullAmount, 2, 3);
            pnlSubMoneyActions.Controls.Add(btnSubTotalCashWR, 2, 6);
            pnlSubMoneyActions.Controls.Add(btnHideSubTotal, 0, 6);
            pnlSubMoneyActions.Controls.Add(button61, 0, 0);
            pnlSubMoneyActions.Controls.Add(button89, 0, 1);
            pnlSubMoneyActions.Controls.Add(button58, 1, 0);
            pnlSubMoneyActions.Controls.Add(button12, 2, 4);
            pnlSubMoneyActions.Controls.Add(button6, 1, 5);
            pnlSubMoneyActions.Controls.Add(button3, 0, 5);
            pnlSubMoneyActions.Controls.Add(button5, 1, 4);
            pnlSubMoneyActions.Controls.Add(button57, 2, 0);
            pnlSubMoneyActions.Controls.Add(button86, 1, 1);
            pnlSubMoneyActions.Controls.Add(button75, 2, 1);
            pnlSubMoneyActions.Controls.Add(button4, 0, 4);
            pnlSubMoneyActions.Controls.Add(button95, 0, 2);
            pnlSubMoneyActions.Controls.Add(button94, 1, 2);
            pnlSubMoneyActions.Controls.Add(button93, 2, 2);
            pnlSubMoneyActions.Controls.Add(button107, 0, 3);
            pnlSubMoneyActions.Controls.Add(btnC, 1, 3);
            pnlSubMoneyActions.Dock = DockStyle.Fill;
            pnlSubMoneyActions.Location = new Point(0, 185);
            pnlSubMoneyActions.Margin = new Padding(4, 3, 4, 3);
            pnlSubMoneyActions.Name = "pnlSubMoneyActions";
            pnlSubMoneyActions.RowCount = 7;
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 12.82051F));
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 12.82051F));
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 12.82051F));
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 12.82051F));
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 12.82051F));
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 12.82051F));
            pnlSubMoneyActions.RowStyles.Add(new RowStyle(SizeType.Percent, 23.07693F));
            pnlSubMoneyActions.Size = new Size(366, 713);
            pnlSubMoneyActions.TabIndex = 167;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 0, 0);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(256, 461);
            button1.Margin = new Padding(12, 6, 12, 6);
            button1.Name = "button1";
            button1.Size = new Size(98, 79);
            button1.TabIndex = 168;
            button1.Text = "100";
            button1.UseVisualStyleBackColor = false;
            button1.Click += KeyHandleBig;
            // 
            // btnSubTotalCash
            // 
            btnSubTotalCash.AutoEllipsis = true;
            btnSubTotalCash.BackColor = Color.Black;
            btnSubTotalCash.BackgroundImage = Properties.Resources.Euro;
            btnSubTotalCash.BackgroundImageLayout = ImageLayout.Zoom;
            btnSubTotalCash.Dock = DockStyle.Fill;
            btnSubTotalCash.FlatAppearance.BorderColor = Color.White;
            btnSubTotalCash.FlatStyle = FlatStyle.Flat;
            btnSubTotalCash.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSubTotalCash.ForeColor = Color.FromArgb(0, 0, 0);
            btnSubTotalCash.ImeMode = ImeMode.NoControl;
            btnSubTotalCash.Location = new Point(128, 552);
            btnSubTotalCash.Margin = new Padding(6);
            btnSubTotalCash.Name = "btnSubTotalCash";
            btnSubTotalCash.Size = new Size(110, 155);
            btnSubTotalCash.TabIndex = 159;
            btnSubTotalCash.TabStop = false;
            btnSubTotalCash.UseVisualStyleBackColor = false;
            btnSubTotalCash.Click += btnSubTotalCash_Click;
            // 
            // btnSubTotalFullAmount
            // 
            btnSubTotalFullAmount.AutoEllipsis = true;
            btnSubTotalFullAmount.BackColor = Color.FromArgb(0, 192, 0);
            btnSubTotalFullAmount.BackgroundImage = Properties.Resources.shadow;
            btnSubTotalFullAmount.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubTotalFullAmount.Dock = DockStyle.Fill;
            btnSubTotalFullAmount.FlatAppearance.BorderSize = 0;
            btnSubTotalFullAmount.FlatStyle = FlatStyle.Flat;
            btnSubTotalFullAmount.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSubTotalFullAmount.ForeColor = Color.FromArgb(0, 0, 0);
            btnSubTotalFullAmount.ImeMode = ImeMode.NoControl;
            btnSubTotalFullAmount.Location = new Point(256, 279);
            btnSubTotalFullAmount.Margin = new Padding(12, 6, 12, 6);
            btnSubTotalFullAmount.Name = "btnSubTotalFullAmount";
            btnSubTotalFullAmount.Size = new Size(98, 79);
            btnSubTotalFullAmount.TabIndex = 164;
            btnSubTotalFullAmount.Text = "Full Amount";
            btnSubTotalFullAmount.UseVisualStyleBackColor = false;
            btnSubTotalFullAmount.Click += btnSubTotalFullAmount_Click;
            // 
            // btnSubTotalCashWR
            // 
            btnSubTotalCashWR.AutoEllipsis = true;
            btnSubTotalCashWR.BackColor = Color.Black;
            btnSubTotalCashWR.BackgroundImage = Properties.Resources.Euro;
            btnSubTotalCashWR.BackgroundImageLayout = ImageLayout.Zoom;
            btnSubTotalCashWR.Dock = DockStyle.Fill;
            btnSubTotalCashWR.FlatAppearance.BorderColor = Color.White;
            btnSubTotalCashWR.FlatStyle = FlatStyle.Flat;
            btnSubTotalCashWR.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSubTotalCashWR.ForeColor = Color.FromArgb(0, 0, 0);
            btnSubTotalCashWR.Image = Properties.Resources.Print32;
            btnSubTotalCashWR.ImageAlign = ContentAlignment.MiddleRight;
            btnSubTotalCashWR.ImeMode = ImeMode.NoControl;
            btnSubTotalCashWR.Location = new Point(250, 552);
            btnSubTotalCashWR.Margin = new Padding(6);
            btnSubTotalCashWR.Name = "btnSubTotalCashWR";
            btnSubTotalCashWR.Size = new Size(110, 155);
            btnSubTotalCashWR.TabIndex = 160;
            btnSubTotalCashWR.TabStop = false;
            btnSubTotalCashWR.UseVisualStyleBackColor = false;
            btnSubTotalCashWR.Click += btnSubTotalCashWR_Click;
            // 
            // btnHideSubTotal
            // 
            btnHideSubTotal.AutoEllipsis = true;
            btnHideSubTotal.BackColor = Color.Black;
            btnHideSubTotal.BackgroundImage = Properties.Resources.Delete;
            btnHideSubTotal.BackgroundImageLayout = ImageLayout.Zoom;
            btnHideSubTotal.Dock = DockStyle.Fill;
            btnHideSubTotal.FlatAppearance.BorderColor = Color.White;
            btnHideSubTotal.FlatStyle = FlatStyle.Flat;
            btnHideSubTotal.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnHideSubTotal.ForeColor = Color.White;
            btnHideSubTotal.ImeMode = ImeMode.NoControl;
            btnHideSubTotal.Location = new Point(6, 552);
            btnHideSubTotal.Margin = new Padding(6);
            btnHideSubTotal.Name = "btnHideSubTotal";
            btnHideSubTotal.Size = new Size(110, 155);
            btnHideSubTotal.TabIndex = 157;
            btnHideSubTotal.TextAlign = ContentAlignment.BottomCenter;
            btnHideSubTotal.UseVisualStyleBackColor = false;
            btnHideSubTotal.Click += btnHideSubTotal_Click;
            // 
            // button61
            // 
            button61.AutoEllipsis = true;
            button61.BackColor = Color.FromArgb(128, 128, 255);
            button61.BackgroundImage = (Image)resources.GetObject("button61.BackgroundImage");
            button61.BackgroundImageLayout = ImageLayout.Stretch;
            button61.Dock = DockStyle.Fill;
            button61.FlatAppearance.BorderSize = 0;
            button61.FlatStyle = FlatStyle.Flat;
            button61.Font = new Font("Arial", 26F, FontStyle.Bold);
            button61.ForeColor = Color.FromArgb(0, 0, 0);
            button61.ImeMode = ImeMode.NoControl;
            button61.Location = new Point(12, 6);
            button61.Margin = new Padding(12, 6, 12, 6);
            button61.Name = "button61";
            button61.Size = new Size(98, 79);
            button61.TabIndex = 117;
            button61.Text = "7";
            button61.UseVisualStyleBackColor = false;
            button61.Click += KeyHandle;
            // 
            // button89
            // 
            button89.AutoEllipsis = true;
            button89.BackColor = Color.FromArgb(128, 128, 255);
            button89.BackgroundImage = (Image)resources.GetObject("button89.BackgroundImage");
            button89.BackgroundImageLayout = ImageLayout.Stretch;
            button89.Dock = DockStyle.Fill;
            button89.FlatAppearance.BorderSize = 0;
            button89.FlatStyle = FlatStyle.Flat;
            button89.Font = new Font("Arial", 26F, FontStyle.Bold);
            button89.ForeColor = Color.FromArgb(0, 0, 0);
            button89.ImeMode = ImeMode.NoControl;
            button89.Location = new Point(12, 97);
            button89.Margin = new Padding(12, 6, 12, 6);
            button89.Name = "button89";
            button89.Size = new Size(98, 79);
            button89.TabIndex = 120;
            button89.Text = "4";
            button89.UseVisualStyleBackColor = false;
            button89.Click += KeyHandle;
            // 
            // button58
            // 
            button58.AutoEllipsis = true;
            button58.BackColor = Color.FromArgb(128, 128, 255);
            button58.BackgroundImage = (Image)resources.GetObject("button58.BackgroundImage");
            button58.BackgroundImageLayout = ImageLayout.Stretch;
            button58.Dock = DockStyle.Fill;
            button58.FlatAppearance.BorderSize = 0;
            button58.FlatStyle = FlatStyle.Flat;
            button58.Font = new Font("Arial", 26F, FontStyle.Bold);
            button58.ForeColor = Color.FromArgb(0, 0, 0);
            button58.ImeMode = ImeMode.NoControl;
            button58.Location = new Point(134, 6);
            button58.Margin = new Padding(12, 6, 12, 6);
            button58.Name = "button58";
            button58.Size = new Size(98, 79);
            button58.TabIndex = 118;
            button58.Text = "8";
            button58.UseVisualStyleBackColor = false;
            button58.Click += KeyHandle;
            // 
            // button12
            // 
            button12.AutoEllipsis = true;
            button12.BackColor = Color.FromArgb(255, 128, 0);
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.Dock = DockStyle.Fill;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            button12.ForeColor = Color.FromArgb(0, 0, 0);
            button12.ImeMode = ImeMode.NoControl;
            button12.Location = new Point(256, 370);
            button12.Margin = new Padding(12, 6, 12, 6);
            button12.Name = "button12";
            button12.Size = new Size(98, 79);
            button12.TabIndex = 144;
            button12.Text = "20";
            button12.UseVisualStyleBackColor = false;
            button12.Click += KeyHandleBig;
            // 
            // button6
            // 
            button6.AutoEllipsis = true;
            button6.BackColor = Color.FromArgb(255, 128, 0);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(0, 0, 0);
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(134, 461);
            button6.Margin = new Padding(12, 6, 12, 6);
            button6.Name = "button6";
            button6.Size = new Size(98, 79);
            button6.TabIndex = 148;
            button6.Text = "50";
            button6.UseVisualStyleBackColor = false;
            button6.Click += KeyHandleBig;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 0, 0);
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(12, 461);
            button3.Margin = new Padding(12, 6, 12, 6);
            button3.Name = "button3";
            button3.Size = new Size(98, 79);
            button3.TabIndex = 147;
            button3.Text = "40";
            button3.UseVisualStyleBackColor = false;
            button3.Click += KeyHandleBig;
            // 
            // button5
            // 
            button5.AutoEllipsis = true;
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(0, 0, 0);
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(134, 370);
            button5.Margin = new Padding(12, 6, 12, 6);
            button5.Name = "button5";
            button5.Size = new Size(98, 79);
            button5.TabIndex = 141;
            button5.Text = "10";
            button5.UseVisualStyleBackColor = false;
            button5.Click += KeyHandleBig;
            // 
            // button57
            // 
            button57.AutoEllipsis = true;
            button57.BackColor = Color.FromArgb(128, 128, 255);
            button57.BackgroundImage = (Image)resources.GetObject("button57.BackgroundImage");
            button57.BackgroundImageLayout = ImageLayout.Stretch;
            button57.Dock = DockStyle.Fill;
            button57.FlatAppearance.BorderSize = 0;
            button57.FlatStyle = FlatStyle.Flat;
            button57.Font = new Font("Arial", 26F, FontStyle.Bold);
            button57.ForeColor = Color.FromArgb(0, 0, 0);
            button57.ImeMode = ImeMode.NoControl;
            button57.Location = new Point(256, 6);
            button57.Margin = new Padding(12, 6, 12, 6);
            button57.Name = "button57";
            button57.Size = new Size(98, 79);
            button57.TabIndex = 119;
            button57.Text = "9";
            button57.UseVisualStyleBackColor = false;
            button57.Click += KeyHandle;
            // 
            // button86
            // 
            button86.AutoEllipsis = true;
            button86.BackColor = Color.FromArgb(128, 128, 255);
            button86.BackgroundImage = (Image)resources.GetObject("button86.BackgroundImage");
            button86.BackgroundImageLayout = ImageLayout.Stretch;
            button86.Dock = DockStyle.Fill;
            button86.FlatAppearance.BorderSize = 0;
            button86.FlatStyle = FlatStyle.Flat;
            button86.Font = new Font("Arial", 26F, FontStyle.Bold);
            button86.ForeColor = Color.FromArgb(0, 0, 0);
            button86.ImeMode = ImeMode.NoControl;
            button86.Location = new Point(134, 97);
            button86.Margin = new Padding(12, 6, 12, 6);
            button86.Name = "button86";
            button86.Size = new Size(98, 79);
            button86.TabIndex = 121;
            button86.Text = "5";
            button86.UseVisualStyleBackColor = false;
            button86.Click += KeyHandle;
            // 
            // button75
            // 
            button75.AutoEllipsis = true;
            button75.BackColor = Color.FromArgb(128, 128, 255);
            button75.BackgroundImage = (Image)resources.GetObject("button75.BackgroundImage");
            button75.BackgroundImageLayout = ImageLayout.Stretch;
            button75.Dock = DockStyle.Fill;
            button75.FlatAppearance.BorderSize = 0;
            button75.FlatStyle = FlatStyle.Flat;
            button75.Font = new Font("Arial", 26F, FontStyle.Bold);
            button75.ForeColor = Color.FromArgb(0, 0, 0);
            button75.ImeMode = ImeMode.NoControl;
            button75.Location = new Point(256, 97);
            button75.Margin = new Padding(12, 6, 12, 6);
            button75.Name = "button75";
            button75.Size = new Size(98, 79);
            button75.TabIndex = 122;
            button75.Text = "6";
            button75.UseVisualStyleBackColor = false;
            button75.Click += KeyHandle;
            // 
            // button4
            // 
            button4.AutoEllipsis = true;
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 21.75F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 0, 0);
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(12, 370);
            button4.Margin = new Padding(12, 6, 12, 6);
            button4.Name = "button4";
            button4.Size = new Size(98, 79);
            button4.TabIndex = 142;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = false;
            button4.Click += KeyHandleBig;
            // 
            // button95
            // 
            button95.AutoEllipsis = true;
            button95.BackColor = Color.FromArgb(128, 128, 255);
            button95.BackgroundImage = (Image)resources.GetObject("button95.BackgroundImage");
            button95.BackgroundImageLayout = ImageLayout.Stretch;
            button95.Dock = DockStyle.Fill;
            button95.FlatAppearance.BorderSize = 0;
            button95.FlatStyle = FlatStyle.Flat;
            button95.Font = new Font("Arial", 26F, FontStyle.Bold);
            button95.ForeColor = Color.FromArgb(0, 0, 0);
            button95.ImeMode = ImeMode.NoControl;
            button95.Location = new Point(12, 188);
            button95.Margin = new Padding(12, 6, 12, 6);
            button95.Name = "button95";
            button95.Size = new Size(98, 79);
            button95.TabIndex = 123;
            button95.Text = "1";
            button95.UseVisualStyleBackColor = false;
            button95.Click += KeyHandle;
            // 
            // button94
            // 
            button94.AutoEllipsis = true;
            button94.BackColor = Color.FromArgb(128, 128, 255);
            button94.BackgroundImage = (Image)resources.GetObject("button94.BackgroundImage");
            button94.BackgroundImageLayout = ImageLayout.Stretch;
            button94.Dock = DockStyle.Fill;
            button94.FlatAppearance.BorderSize = 0;
            button94.FlatStyle = FlatStyle.Flat;
            button94.Font = new Font("Arial", 26F, FontStyle.Bold);
            button94.ForeColor = Color.FromArgb(0, 0, 0);
            button94.ImeMode = ImeMode.NoControl;
            button94.Location = new Point(134, 188);
            button94.Margin = new Padding(12, 6, 12, 6);
            button94.Name = "button94";
            button94.Size = new Size(98, 79);
            button94.TabIndex = 124;
            button94.Text = "2";
            button94.UseVisualStyleBackColor = false;
            button94.Click += KeyHandle;
            // 
            // button93
            // 
            button93.AutoEllipsis = true;
            button93.BackColor = Color.FromArgb(128, 128, 255);
            button93.BackgroundImage = (Image)resources.GetObject("button93.BackgroundImage");
            button93.BackgroundImageLayout = ImageLayout.Stretch;
            button93.Dock = DockStyle.Fill;
            button93.FlatAppearance.BorderSize = 0;
            button93.FlatStyle = FlatStyle.Flat;
            button93.Font = new Font("Arial", 26F, FontStyle.Bold);
            button93.ForeColor = Color.FromArgb(0, 0, 0);
            button93.ImeMode = ImeMode.NoControl;
            button93.Location = new Point(256, 188);
            button93.Margin = new Padding(12, 6, 12, 6);
            button93.Name = "button93";
            button93.Size = new Size(98, 79);
            button93.TabIndex = 125;
            button93.Text = "3";
            button93.UseVisualStyleBackColor = false;
            button93.Click += KeyHandle;
            // 
            // button107
            // 
            button107.AutoEllipsis = true;
            button107.BackColor = Color.FromArgb(128, 128, 255);
            button107.BackgroundImage = (Image)resources.GetObject("button107.BackgroundImage");
            button107.BackgroundImageLayout = ImageLayout.Stretch;
            button107.Dock = DockStyle.Fill;
            button107.FlatAppearance.BorderSize = 0;
            button107.FlatStyle = FlatStyle.Flat;
            button107.Font = new Font("Arial", 26F, FontStyle.Bold);
            button107.ForeColor = Color.FromArgb(0, 0, 0);
            button107.ImeMode = ImeMode.NoControl;
            button107.Location = new Point(12, 279);
            button107.Margin = new Padding(12, 6, 12, 6);
            button107.Name = "button107";
            button107.Size = new Size(98, 79);
            button107.TabIndex = 126;
            button107.Text = "0";
            button107.UseVisualStyleBackColor = false;
            button107.Click += KeyHandle;
            // 
            // btnC
            // 
            btnC.AutoEllipsis = true;
            btnC.BackColor = Color.Red;
            btnC.BackgroundImage = Properties.Resources.shadow;
            btnC.BackgroundImageLayout = ImageLayout.Stretch;
            btnC.Dock = DockStyle.Fill;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnC.ForeColor = Color.FromArgb(0, 0, 0);
            btnC.ImeMode = ImeMode.NoControl;
            btnC.Location = new Point(134, 279);
            btnC.Margin = new Padding(12, 6, 12, 6);
            btnC.Name = "btnC";
            btnC.Size = new Size(98, 79);
            btnC.TabIndex = 127;
            btnC.Text = "CLEAR";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnSubTotalClear_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnlcizgi);
            panel1.Controls.Add(lblPayedIn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblMoneyBack);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblOrderTotal);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 185);
            panel1.TabIndex = 168;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(63, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 38);
            label1.TabIndex = 150;
            label1.Text = "ORDER TOTAL";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlcizgi
            // 
            pnlcizgi.BackColor = Color.White;
            pnlcizgi.ForeColor = Color.White;
            pnlcizgi.Location = new Point(63, 119);
            pnlcizgi.Margin = new Padding(4, 3, 4, 3);
            pnlcizgi.Name = "pnlcizgi";
            pnlcizgi.Size = new Size(227, 2);
            pnlcizgi.TabIndex = 149;
            // 
            // lblPayedIn
            // 
            lblPayedIn.BackColor = Color.Transparent;
            lblPayedIn.Font = new Font("Arial", 18F);
            lblPayedIn.ForeColor = Color.White;
            lblPayedIn.ImeMode = ImeMode.NoControl;
            lblPayedIn.Location = new Point(141, 74);
            lblPayedIn.Margin = new Padding(4, 0, 4, 0);
            lblPayedIn.Name = "lblPayedIn";
            lblPayedIn.Size = new Size(147, 38);
            lblPayedIn.TabIndex = 154;
            lblPayedIn.Text = "0.00";
            lblPayedIn.TextAlign = ContentAlignment.MiddleRight;
            lblPayedIn.TextChanged += lblPayedIn_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(63, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 38);
            label2.TabIndex = 151;
            label2.Text = "PAYED IN";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMoneyBack
            // 
            lblMoneyBack.BackColor = Color.Transparent;
            lblMoneyBack.Font = new Font("Arial", 18F);
            lblMoneyBack.ForeColor = Color.White;
            lblMoneyBack.ImeMode = ImeMode.NoControl;
            lblMoneyBack.Location = new Point(169, 140);
            lblMoneyBack.Margin = new Padding(4, 0, 4, 0);
            lblMoneyBack.Name = "lblMoneyBack";
            lblMoneyBack.Size = new Size(120, 38);
            lblMoneyBack.TabIndex = 155;
            lblMoneyBack.Text = "0.00";
            lblMoneyBack.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(63, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 152;
            label3.Text = "MONEY BACK";
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.BackColor = Color.Transparent;
            lblOrderTotal.Font = new Font("Arial", 18F);
            lblOrderTotal.ForeColor = Color.White;
            lblOrderTotal.ImeMode = ImeMode.NoControl;
            lblOrderTotal.Location = new Point(175, 23);
            lblOrderTotal.Margin = new Padding(4, 0, 4, 0);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(113, 38);
            lblOrderTotal.TabIndex = 153;
            lblOrderTotal.Text = "0.00";
            lblOrderTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.Black;
            pnlDisplay.Controls.Add(pnlStandardDisplay);
            pnlDisplay.Controls.Add(pnlSubTotal);
            pnlDisplay.Dock = DockStyle.Right;
            pnlDisplay.Location = new Point(648, 0);
            pnlDisplay.Margin = new Padding(0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(366, 898);
            pnlDisplay.TabIndex = 28;
            // 
            // pnlTop
            // 
            pnlTop.AutoSize = true;
            pnlTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTop.BackColor = Color.Transparent;
            pnlTop.Controls.Add(cmdDirectSale);
            pnlTop.Controls.Add(cmdTables);
            pnlTop.Controls.Add(cmdTakeAway);
            pnlTop.Controls.Add(cmdDelivery);
            pnlTop.Controls.Add(mnuFunctions);
            pnlTop.Controls.Add(cmdCancel);
            pnlTop.Controls.Add(btnExpandShrinkHoldButtonDetails);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.ForeColor = Color.Black;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(0);
            pnlTop.MinimumSize = new Size(0, 83);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(648, 157);
            pnlTop.TabIndex = 44;
            // 
            // cmdDirectSale
            // 
            cmdDirectSale.AutoEllipsis = true;
            cmdDirectSale.BackColor = Color.RoyalBlue;
            cmdDirectSale.BackgroundImageLayout = ImageLayout.Stretch;
            cmdDirectSale.FlatAppearance.BorderSize = 0;
            cmdDirectSale.FlatStyle = FlatStyle.Flat;
            cmdDirectSale.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdDirectSale.ForeColor = Color.FromArgb(0, 0, 0);
            cmdDirectSale.ImeMode = ImeMode.NoControl;
            cmdDirectSale.Location = new Point(6, 3);
            cmdDirectSale.Margin = new Padding(6, 3, 1, 1);
            cmdDirectSale.Name = "cmdDirectSale";
            cmdDirectSale.Size = new Size(107, 75);
            cmdDirectSale.TabIndex = 20;
            cmdDirectSale.Text = "Direct Sale";
            cmdDirectSale.UseVisualStyleBackColor = false;
            cmdDirectSale.Click += cmdDirectSale_Click;
            // 
            // cmdTables
            // 
            cmdTables.AutoEllipsis = true;
            cmdTables.BackColor = Color.RoyalBlue;
            cmdTables.BackgroundImageLayout = ImageLayout.Stretch;
            cmdTables.FlatAppearance.BorderSize = 0;
            cmdTables.FlatStyle = FlatStyle.Flat;
            cmdTables.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdTables.ForeColor = Color.FromArgb(0, 0, 0);
            cmdTables.ImeMode = ImeMode.NoControl;
            cmdTables.Location = new Point(115, 3);
            cmdTables.Margin = new Padding(1, 3, 1, 1);
            cmdTables.Name = "cmdTables";
            cmdTables.Size = new Size(105, 75);
            cmdTables.TabIndex = 19;
            cmdTables.Text = "Tables";
            cmdTables.UseVisualStyleBackColor = false;
            cmdTables.Click += cmdTables_Click;
            // 
            // cmdTakeAway
            // 
            cmdTakeAway.AutoEllipsis = true;
            cmdTakeAway.BackColor = Color.RoyalBlue;
            cmdTakeAway.BackgroundImageLayout = ImageLayout.Stretch;
            cmdTakeAway.FlatAppearance.BorderSize = 0;
            cmdTakeAway.FlatStyle = FlatStyle.Flat;
            cmdTakeAway.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdTakeAway.ForeColor = Color.FromArgb(0, 0, 0);
            cmdTakeAway.ImeMode = ImeMode.NoControl;
            cmdTakeAway.Location = new Point(222, 3);
            cmdTakeAway.Margin = new Padding(1, 3, 1, 1);
            cmdTakeAway.Name = "cmdTakeAway";
            cmdTakeAway.Size = new Size(105, 75);
            cmdTakeAway.TabIndex = 18;
            cmdTakeAway.Text = "Take Away B";
            cmdTakeAway.UseVisualStyleBackColor = false;
            cmdTakeAway.Click += cmdTakeAway_Click;
            // 
            // cmdDelivery
            // 
            cmdDelivery.AutoEllipsis = true;
            cmdDelivery.BackColor = Color.RoyalBlue;
            cmdDelivery.BackgroundImageLayout = ImageLayout.Stretch;
            cmdDelivery.FlatAppearance.BorderSize = 0;
            cmdDelivery.FlatStyle = FlatStyle.Flat;
            cmdDelivery.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdDelivery.ForeColor = Color.FromArgb(0, 0, 0);
            cmdDelivery.ImeMode = ImeMode.NoControl;
            cmdDelivery.Location = new Point(329, 3);
            cmdDelivery.Margin = new Padding(1, 3, 1, 1);
            cmdDelivery.Name = "cmdDelivery";
            cmdDelivery.Size = new Size(105, 75);
            cmdDelivery.TabIndex = 17;
            cmdDelivery.Text = "Delivery";
            cmdDelivery.UseVisualStyleBackColor = false;
            cmdDelivery.Click += cmdDelivery_Click;
            // 
            // mnuFunctions
            // 
            mnuFunctions.BackColor = Color.Black;
            mnuFunctions.Dock = DockStyle.None;
            mnuFunctions.Items.AddRange(new ToolStripItem[] { mnuTools });
            mnuFunctions.Location = new Point(435, 0);
            mnuFunctions.Name = "mnuFunctions";
            mnuFunctions.Padding = new Padding(7, 2, 0, 2);
            mnuFunctions.Size = new Size(211, 68);
            mnuFunctions.TabIndex = 31;
            mnuFunctions.Text = "menuStrip1";
            // 
            // mnuTools
            // 
            mnuTools.AutoSize = false;
            mnuTools.BackgroundImage = Properties.Resources.Tools32;
            mnuTools.BackgroundImageLayout = ImageLayout.Center;
            mnuTools.DropDownItems.AddRange(new ToolStripItem[] { mnuOrders, mnuShrinkOrderDisplay, mnuKitchen, mnuReports, mnuLock, mnuSum, mnuSelectBonusPlan, mnuCustomer, mnuAdmin, mnuStock });
            mnuTools.Font = new Font("Segoe UI", 14F);
            mnuTools.ImageScaling = ToolStripItemImageScaling.None;
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new Size(82, 64);
            mnuTools.Click += btnTools_Click;
            // 
            // mnuOrders
            // 
            mnuOrders.Image = Properties.Resources.Cart32;
            mnuOrders.ImageScaling = ToolStripItemImageScaling.None;
            mnuOrders.Name = "mnuOrders";
            mnuOrders.Size = new Size(285, 54);
            mnuOrders.Text = "ORDER LIST TOTAL";
            mnuOrders.Click += cmdOrders_Click;
            // 
            // mnuShrinkOrderDisplay
            // 
            mnuShrinkOrderDisplay.Image = Properties.Resources.Curve;
            mnuShrinkOrderDisplay.ImageScaling = ToolStripItemImageScaling.None;
            mnuShrinkOrderDisplay.Name = "mnuShrinkOrderDisplay";
            mnuShrinkOrderDisplay.Size = new Size(285, 54);
            mnuShrinkOrderDisplay.Text = "Shrink Order";
            mnuShrinkOrderDisplay.Click += mnuShrinkOrderDisplay_Click;
            // 
            // mnuKitchen
            // 
            mnuKitchen.DropDownItems.AddRange(new ToolStripItem[] { mnuViewBars, mnuPrintForKitchen, mnuResetKitchenOrders });
            mnuKitchen.Image = Properties.Resources.chef32;
            mnuKitchen.ImageScaling = ToolStripItemImageScaling.None;
            mnuKitchen.Name = "mnuKitchen";
            mnuKitchen.Size = new Size(285, 54);
            mnuKitchen.Text = "KITCHEN";
            // 
            // mnuViewBars
            // 
            mnuViewBars.Image = Properties.Resources.chefdouble48;
            mnuViewBars.ImageScaling = ToolStripItemImageScaling.None;
            mnuViewBars.Name = "mnuViewBars";
            mnuViewBars.Size = new Size(330, 70);
            mnuViewBars.Text = "VIEW KITCHEN ORDERS";
            // 
            // mnuPrintForKitchen
            // 
            mnuPrintForKitchen.Image = Properties.Resources.chef32;
            mnuPrintForKitchen.ImageScaling = ToolStripItemImageScaling.None;
            mnuPrintForKitchen.Name = "mnuPrintForKitchen";
            mnuPrintForKitchen.Size = new Size(330, 70);
            mnuPrintForKitchen.Text = "PRINT FOR KITCHEN";
            mnuPrintForKitchen.Click += tsPrintForKitchen_Click;
            // 
            // mnuResetKitchenOrders
            // 
            mnuResetKitchenOrders.Image = Properties.Resources.Redo64;
            mnuResetKitchenOrders.ImageScaling = ToolStripItemImageScaling.None;
            mnuResetKitchenOrders.Name = "mnuResetKitchenOrders";
            mnuResetKitchenOrders.Size = new Size(330, 70);
            mnuResetKitchenOrders.Text = "RESET KITCHEN ORDER";
            mnuResetKitchenOrders.Click += btnResetKitchenOrders_Click;
            // 
            // mnuReports
            // 
            mnuReports.Image = Properties.Resources.report48;
            mnuReports.ImageScaling = ToolStripItemImageScaling.None;
            mnuReports.Name = "mnuReports";
            mnuReports.Size = new Size(285, 54);
            mnuReports.Text = "PRINT REPORT";
            mnuReports.Click += cmdReports_Click;
            // 
            // mnuLock
            // 
            mnuLock.Image = Properties.Resources.lock32;
            mnuLock.ImageScaling = ToolStripItemImageScaling.None;
            mnuLock.Name = "mnuLock";
            mnuLock.Size = new Size(285, 54);
            mnuLock.Text = "LOCK SCREEN";
            mnuLock.Click += cmdLock_Click;
            // 
            // mnuSum
            // 
            mnuSum.Image = Properties.Resources.Sigma32;
            mnuSum.ImageScaling = ToolStripItemImageScaling.None;
            mnuSum.Name = "mnuSum";
            mnuSum.Size = new Size(285, 54);
            mnuSum.Text = "0.00";
            // 
            // mnuSelectBonusPlan
            // 
            mnuSelectBonusPlan.Image = Properties.Resources.Bonus48;
            mnuSelectBonusPlan.ImageScaling = ToolStripItemImageScaling.None;
            mnuSelectBonusPlan.Name = "mnuSelectBonusPlan";
            mnuSelectBonusPlan.Size = new Size(285, 54);
            mnuSelectBonusPlan.Text = "SELECT TIPS PLAN";
            // 
            // mnuCustomer
            // 
            mnuCustomer.Image = Properties.Resources.customers32;
            mnuCustomer.ImageScaling = ToolStripItemImageScaling.None;
            mnuCustomer.Name = "mnuCustomer";
            mnuCustomer.Size = new Size(285, 54);
            mnuCustomer.Text = "CUSTOMER DETAILS";
            mnuCustomer.Click += cmdCustomer_Click;
            // 
            // mnuAdmin
            // 
            mnuAdmin.DropDownItems.AddRange(new ToolStripItem[] { mnuDebug, mnuReprintReport, mnuSupervisorReport, mnuChangeMenu, mnuReloadMenu, mnuOptions, mnuPrintAsInvoice, mnuOrientation, mnuPad, mnuDrawerCalculator });
            mnuAdmin.Image = Properties.Resources.Tools32;
            mnuAdmin.ImageScaling = ToolStripItemImageScaling.None;
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new Size(285, 54);
            mnuAdmin.Text = "ADMINISTRATOR";
            // 
            // mnuDebug
            // 
            mnuDebug.Image = Properties.Resources.ComputerDisconnected32;
            mnuDebug.ImageScaling = ToolStripItemImageScaling.None;
            mnuDebug.Name = "mnuDebug";
            mnuDebug.Size = new Size(401, 54);
            mnuDebug.Text = "DEBUG";
            mnuDebug.Click += mnuDebug_Click;
            // 
            // mnuReprintReport
            // 
            mnuReprintReport.Image = Properties.Resources.reportold48;
            mnuReprintReport.ImageScaling = ToolStripItemImageScaling.None;
            mnuReprintReport.Name = "mnuReprintReport";
            mnuReprintReport.Size = new Size(401, 54);
            mnuReprintReport.Text = "REPRINT REPORT";
            mnuReprintReport.Visible = false;
            mnuReprintReport.Click += btnReprintReport_Click;
            // 
            // mnuSupervisorReport
            // 
            mnuSupervisorReport.Image = Properties.Resources.BlueMan32;
            mnuSupervisorReport.ImageScaling = ToolStripItemImageScaling.None;
            mnuSupervisorReport.Name = "mnuSupervisorReport";
            mnuSupervisorReport.Size = new Size(401, 54);
            mnuSupervisorReport.Text = "SUPERVISOR REPORT";
            mnuSupervisorReport.Click += mnuSupervisorReport_Click;
            // 
            // mnuChangeMenu
            // 
            mnuChangeMenu.Image = Properties.Resources.Duplicate1;
            mnuChangeMenu.ImageScaling = ToolStripItemImageScaling.None;
            mnuChangeMenu.Name = "mnuChangeMenu";
            mnuChangeMenu.Size = new Size(401, 54);
            mnuChangeMenu.Text = "CHANGE MENU";
            mnuChangeMenu.Click += mnuChangeMenu_Click;
            // 
            // mnuReloadMenu
            // 
            mnuReloadMenu.Image = Properties.Resources.Redo48;
            mnuReloadMenu.ImageScaling = ToolStripItemImageScaling.None;
            mnuReloadMenu.Name = "mnuReloadMenu";
            mnuReloadMenu.Size = new Size(401, 54);
            mnuReloadMenu.Text = "RELOAD USER INTERFACE (MENU)";
            mnuReloadMenu.Click += tsReloadMenu_Click;
            // 
            // mnuOptions
            // 
            mnuOptions.Image = Properties.Resources.disli48;
            mnuOptions.ImageScaling = ToolStripItemImageScaling.None;
            mnuOptions.Name = "mnuOptions";
            mnuOptions.Size = new Size(401, 54);
            mnuOptions.Text = "SYSTEM  CONFIGURATION";
            mnuOptions.Click += btnOptions_Click;
            // 
            // mnuPrintAsInvoice
            // 
            mnuPrintAsInvoice.Image = Properties.Resources.Receipt32;
            mnuPrintAsInvoice.ImageScaling = ToolStripItemImageScaling.None;
            mnuPrintAsInvoice.Name = "mnuPrintAsInvoice";
            mnuPrintAsInvoice.Size = new Size(401, 54);
            mnuPrintAsInvoice.Text = "PRINT AS INVOICE";
            mnuPrintAsInvoice.Click += btnPrintAsInvoice_Click;
            // 
            // mnuOrientation
            // 
            mnuOrientation.Image = Properties.Resources.ExpandHeight48;
            mnuOrientation.ImageScaling = ToolStripItemImageScaling.None;
            mnuOrientation.Name = "mnuOrientation";
            mnuOrientation.Size = new Size(401, 54);
            mnuOrientation.Text = "CHANGE ORIENTATION";
            mnuOrientation.Click += btnOrientation_Click;
            // 
            // mnuPad
            // 
            mnuPad.Image = Properties.Resources.pad32;
            mnuPad.ImageScaling = ToolStripItemImageScaling.None;
            mnuPad.Name = "mnuPad";
            mnuPad.Size = new Size(401, 54);
            mnuPad.Text = "FREE PAD";
            mnuPad.Click += cmdPad_Click;
            // 
            // mnuDrawerCalculator
            // 
            mnuDrawerCalculator.Image = Properties.Resources.CalculatorNice32;
            mnuDrawerCalculator.ImageScaling = ToolStripItemImageScaling.None;
            mnuDrawerCalculator.Name = "mnuDrawerCalculator";
            mnuDrawerCalculator.Size = new Size(401, 54);
            mnuDrawerCalculator.Text = "MONEY COUNTER";
            mnuDrawerCalculator.Click += btnDrawerCalculator_Click;
            // 
            // mnuStock
            // 
            mnuStock.DropDownItems.AddRange(new ToolStripItem[] { mnuShoppingList, mnuSupplierPurchaseList, mnuPrintStockUsageReport });
            mnuStock.Image = Properties.Resources.trolly32;
            mnuStock.ImageScaling = ToolStripItemImageScaling.None;
            mnuStock.Name = "mnuStock";
            mnuStock.Size = new Size(285, 54);
            mnuStock.Text = "STOCK";
            // 
            // mnuShoppingList
            // 
            mnuShoppingList.Image = Properties.Resources.trolly48;
            mnuShoppingList.ImageScaling = ToolStripItemImageScaling.None;
            mnuShoppingList.Name = "mnuShoppingList";
            mnuShoppingList.Size = new Size(403, 70);
            mnuShoppingList.Text = "SHOPPING LIST";
            mnuShoppingList.Click += btnShoppingList_Click;
            // 
            // mnuSupplierPurchaseList
            // 
            mnuSupplierPurchaseList.Image = Properties.Resources.Print;
            mnuSupplierPurchaseList.ImageScaling = ToolStripItemImageScaling.None;
            mnuSupplierPurchaseList.Name = "mnuSupplierPurchaseList";
            mnuSupplierPurchaseList.Size = new Size(403, 70);
            mnuSupplierPurchaseList.Text = "PRINT SUPPLIER SHOPPING LIST";
            mnuSupplierPurchaseList.Click += btnSupplierPurchaseList_Click;
            // 
            // mnuPrintStockUsageReport
            // 
            mnuPrintStockUsageReport.Image = Properties.Resources.Print;
            mnuPrintStockUsageReport.ImageScaling = ToolStripItemImageScaling.None;
            mnuPrintStockUsageReport.Name = "mnuPrintStockUsageReport";
            mnuPrintStockUsageReport.Size = new Size(403, 70);
            mnuPrintStockUsageReport.Text = "PRINT ALL SHOPPING LIST";
            mnuPrintStockUsageReport.Visible = false;
            mnuPrintStockUsageReport.Click += btnPrintStockUsageReport_Click;
            // 
            // cmdCancel
            // 
            cmdCancel.BackColor = Color.Black;
            cmdCancel.BackgroundImage = Properties.Resources.Delete;
            cmdCancel.BackgroundImageLayout = ImageLayout.Stretch;
            cmdCancel.FlatAppearance.BorderColor = Color.White;
            cmdCancel.FlatAppearance.BorderSize = 0;
            cmdCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            cmdCancel.ForeColor = Color.White;
            cmdCancel.ImeMode = ImeMode.NoControl;
            cmdCancel.Location = new Point(1, 82);
            cmdCancel.Margin = new Padding(1, 3, 1, 1);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(111, 74);
            cmdCancel.TabIndex = 16;
            cmdCancel.TextAlign = ContentAlignment.MiddleRight;
            cmdCancel.UseVisualStyleBackColor = false;
            cmdCancel.Click += cmdCancel_Click;
            // 
            // btnExpandShrinkHoldButtonDetails
            // 
            btnExpandShrinkHoldButtonDetails.BackColor = Color.Black;
            btnExpandShrinkHoldButtonDetails.BackgroundImage = Properties.Resources.SquareArrowDownExpander48;
            btnExpandShrinkHoldButtonDetails.BackgroundImageLayout = ImageLayout.Center;
            btnExpandShrinkHoldButtonDetails.FlatAppearance.BorderColor = Color.White;
            btnExpandShrinkHoldButtonDetails.FlatAppearance.BorderSize = 0;
            btnExpandShrinkHoldButtonDetails.FlatStyle = FlatStyle.Flat;
            btnExpandShrinkHoldButtonDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnExpandShrinkHoldButtonDetails.ForeColor = Color.White;
            btnExpandShrinkHoldButtonDetails.ImeMode = ImeMode.NoControl;
            btnExpandShrinkHoldButtonDetails.Location = new Point(114, 82);
            btnExpandShrinkHoldButtonDetails.Margin = new Padding(1, 3, 1, 1);
            btnExpandShrinkHoldButtonDetails.Name = "btnExpandShrinkHoldButtonDetails";
            btnExpandShrinkHoldButtonDetails.Size = new Size(89, 74);
            btnExpandShrinkHoldButtonDetails.TabIndex = 33;
            btnExpandShrinkHoldButtonDetails.TextAlign = ContentAlignment.MiddleRight;
            btnExpandShrinkHoldButtonDetails.UseVisualStyleBackColor = false;
            btnExpandShrinkHoldButtonDetails.Click += btnExpandShrinkHoldButtonDetails_Click;
            // 
            // pnlOrderPad
            // 
            pnlOrderPad.AutoSize = true;
            pnlOrderPad.BackColor = Color.Transparent;
            pnlOrderPad.Dock = DockStyle.Top;
            pnlOrderPad.Location = new Point(0, 226);
            pnlOrderPad.Margin = new Padding(4, 3, 4, 3);
            pnlOrderPad.Name = "pnlOrderPad";
            pnlOrderPad.Padding = new Padding(9, 0, 0, 0);
            pnlOrderPad.Size = new Size(648, 0);
            pnlOrderPad.TabIndex = 45;
            pnlOrderPad.Visible = false;
            // 
            // pnlPendingOrders
            // 
            pnlPendingOrders.AutoSize = true;
            pnlPendingOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlPendingOrders.BackColor = Color.Black;
            pnlPendingOrders.Dock = DockStyle.Top;
            pnlPendingOrders.Location = new Point(0, 157);
            pnlPendingOrders.Margin = new Padding(4, 3, 4, 3);
            pnlPendingOrders.MinimumSize = new Size(0, 69);
            pnlPendingOrders.Name = "pnlPendingOrders";
            pnlPendingOrders.Size = new Size(648, 69);
            pnlPendingOrders.TabIndex = 47;
            // 
            // tmrHoldingOrders
            // 
            tmrHoldingOrders.Interval = 5000;
            tmrHoldingOrders.Tick += tmrHoldingOrders_Tick;
            // 
            // pnlHolder
            // 
            pnlHolder.BackColor = Color.Transparent;
            pnlHolder.BackgroundImageLayout = ImageLayout.Zoom;
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(0, 226);
            pnlHolder.Margin = new Padding(4, 3, 4, 3);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(648, 672);
            pnlHolder.TabIndex = 48;
            // 
            // tmrScreenSaverTrigger
            // 
            tmrScreenSaverTrigger.Interval = 1000;
            tmrScreenSaverTrigger.Tick += tmrScreenSaverTrigger_Tick;
            // 
            // tmrHoldOrderAutoClose
            // 
            tmrHoldOrderAutoClose.Interval = 1000;
            tmrHoldOrderAutoClose.Tick += tmrHoldOrderAutoClose_Tick;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.AutoEllipsis = true;
            button7.BackColor = Color.FromArgb(128, 128, 255);
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Black;
            button7.ImeMode = ImeMode.NoControl;
            button7.Location = new Point(4, 634);
            button7.Name = "button7";
            button7.Size = new Size(148, 38);
            button7.TabIndex = 133;
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.AutoEllipsis = true;
            button9.BackColor = Color.FromArgb(128, 128, 255);
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Black;
            button9.ImeMode = ImeMode.NoControl;
            button9.Location = new Point(159, 634);
            button9.Name = "button9";
            button9.Size = new Size(148, 38);
            button9.TabIndex = 135;
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.AutoEllipsis = true;
            button8.BackColor = Color.FromArgb(128, 128, 255);
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Black;
            button8.ImeMode = ImeMode.NoControl;
            button8.Location = new Point(4, 679);
            button8.Name = "button8";
            button8.Size = new Size(148, 38);
            button8.TabIndex = 134;
            button8.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.None;
            button10.AutoEllipsis = true;
            button10.BackColor = Color.FromArgb(128, 128, 255);
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.Black;
            button10.ImeMode = ImeMode.NoControl;
            button10.Location = new Point(159, 679);
            button10.Name = "button10";
            button10.Size = new Size(148, 38);
            button10.TabIndex = 150;
            button10.UseVisualStyleBackColor = false;
            // 
            // trmOrderPadMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(1024, 898);
            ControlBox = false;
            Controls.Add(pnlHolder);
            Controls.Add(pnlOrderPad);
            Controls.Add(pnlPendingOrders);
            Controls.Add(pnlTop);
            Controls.Add(pnlDisplay);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = mnuFunctions;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "trmOrderPadMain";
            Padding = new Padding(0, 0, 10, 0);
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
            FormClosing += trmOrderPadMain_FormClosing;
            Load += frmMain_Load;
            Shown += trmOrderPadMain_Shown;
            KeyPress += trmOrderPadMain_KeyPress;
            MouseDown += trmOrderPadMain_MouseDown;
            MouseMove += trmOrderPadMain_MouseMove;
            popHold.ResumeLayout(false);
            popHoldAndPrint.ResumeLayout(false);
            pnlStandardDisplay.ResumeLayout(false);
            pnlStandardDisplay.PerformLayout();
            pnlMoneyActions.ResumeLayout(false);
            pnlMoneyActions.PerformLayout();
            pnlSubTotal.ResumeLayout(false);
            pnlSubMoneyActions.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlDisplay.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            mnuFunctions.ResumeLayout(false);
            mnuFunctions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        #region "USER INTERFACE RELATED"
        public async Task LoadUserInterface()
        {
            //Set close/cancel order button properties
            cmdCancel.Size = new Size(config.Cancel_Button_Width, cmdCancel.Size.Height);
            UFWin.SetBackgroundImageForButton(cmdCancel, config.Cancel_Button_Image, Properties.Resources.Delete, ImageLayout.Center);
            UFWin.SetBackgroundColour(cmdCancel, config.Cancel_Button_BackColour);
            cmdCancel.FlatStyle = config.Cancel_Button_Show_Borders ? FlatStyle.Standard : FlatStyle.Flat;

            cmdDirectSale.Text = config.Direct_Sale_Order_Button_Text;
            cmdDirectSale.Size = new Size(config.Direct_Sale_Button_Width, cmdDirectSale.Size.Height);

            cmdTables.Text = config.Table_Orders_Button_Text;
            cmdTables.Size = new Size(config.Table_Orders_Button_Width, cmdTables.Size.Height);
            cmdTakeAway.Text = config.TakeAway_Orders_Button_Text;
            cmdDelivery.Text = config.Delivery_Orders_Button_Text;

            if (cmdTakeAway.Visible)
                cmdTakeAway.Size = new Size(config.TakeAway_Orders_Button_Width, cmdTakeAway.Size.Height);
            if (cmdDelivery.Visible)
                cmdDelivery.Size = new Size(config.Delivery_Orders_Button_Width, cmdDelivery.Size.Height);

            pnlPendingOrders.Visible = config.Hold_Order_Available;

            btnCashDrawer.Text = bslayer.shop.VoidText;
            if (OUI == null)
                OUI = new InterfaceHolder("orderpad");
            OUI.Panels.Clear();

            pnlOrderPad.Controls.Clear();

            //if (!string.IsNullOrEmpty(config.ActiveMenuIID))
            //{
            //    //MessageBox.Show("Active Menu cannot be found, please set it manually from options window");
            //    //frmMenuSelector frm = new frmMenuSelector(bslayer);
            //    //if (frm.ShowDialog() == DialogResult.OK)
            //    //{
            //    //    config.ActiveMenuIID = frm.SelectedMenuIID;
            //    //    UF.SaveConfig(config);
            //    //    bslayer.ActiveMenu = bslayer.GetActiveMenu(true, true);
            //    //}
            //}

            bslayer.ActiveMenu = await repoMenu.GetByField("IsActiveMenu", true);

            if (bslayer.ActiveMenu == null)
            {
                MessageBox.Show("Active Menu cannot be found, please set it manually from options window");
            } else
            {
                //bslayer.ActiveMenu = bslayer.GetActiveMenu(false, false);
                //if (bslayer.ActiveMenu == null)
                //{
                //    MessageBox.Show("Please create and assign Default Menu to system.");
                //    this.Close();
                //}


                for (int i = 0; i < bslayer.ActiveMenu.categories.Count; i++)
                {
                    UPEntity upe = ActivatorUtilities.CreateInstance<UPEntity>(bslayer.sp, (Category)bslayer.ActiveMenu.categories[i], null);
                    upe.DoneEventHandler = new GenericFunctionCallReturnBool(this.DoneEventHandlerFunction);
                    upe.Name = "upentity";
                    OUI.Panels.Add(upe);

                    RadioButton btn = new RadioButton();
                    btn.Appearance = Appearance.Button;
                    btn.Text = upe.entity.CategoryName;
                    btn.Click += new EventHandler(OrderPadButton_Click);
                    btn.BackColor = Color.FromArgb(upe.entity.BgColour);
                    btn.ForeColor = Color.FromArgb(upe.entity.FgColour);

                    try
                    {
                        btn.Font = new Font(upe.entity.FFamily, (float)upe.entity.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), upe.entity.FStyle));
                    } catch
                    {
                        btn.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Tag = i;  //associated index 
                    btn.Padding = new System.Windows.Forms.Padding(2);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Size = new Size(upe.entity.Width, upe.entity.Height);


                    pnlOrderPad.Controls.Add(btn);

                    if (((Category)bslayer.ActiveMenu.categories[i]).CategoryType == CategoryTypes.SpecialCategory)
                        pnlSpecial = upe;
                }
            }
            pnlOrderPad.BackColor = UF.ThemeBackColour;
            //OrderScreen = OrderScreen;
        }
        public void OrderPadButton_Click(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            OUI.SelectedIndex = int.Parse(btn.Tag.ToString());
            OUI.SelectedPanel.UIEButtonsPanel.VerticalScroll.Value = 0;
            AttachPanel(OUI.SelectedPanel);

        }



        private void DisplayWorkArea(bool blnShow)
        {
            if (blnShow)
            {
                if (!blnPadOpenning)
                    AttachPanel(OUI.SelectedPanel);
            } else
                DetachPanel();
            pnlOrderPad.Visible = blnShow;
            //btnExpandShrinkMoneyPanel.Visible = blnShow;
        }

        private void tabOrderUserInterface_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CloseOrderItemEntityInteraction();
        }
        public void CloseOrderItemEntityInteraction()
        {
            for (int i = 0; i < OUI.Panels.Count; i++)
            {
                try
                {
                    OUI.Panels[i].EventProcessor();
                } catch { }
            }
        }


        #endregion

        #region "DYNAMIC ORDER RELATED FUNCTIONS"
        public void EnsureCompulsoryExtras()
        {
            //New solution
            if (pnlSpecial != null)
            {
                for (int i = 0; i < pnlSpecial.UIEButtons.Count; i++)
                {
                    UPEntityButton upeb = (UPEntityButton)pnlSpecial.UIEButtons[i];
                    if (PosLibrary.DRNumeric.IsBitSet(upeb.entitybutton.AvailableFor, (int)bslayer.AttachedOrder.OrderType) &&
                        upeb.entitybutton.Compulsary == 1)
                    {
                        bool blnExist = false;
                        //Check if this compulsary item exist in the order
                        for (int x = 0; x < bslayer.AttachedOrder.items.Count; x++)
                        {
                            OrderItem oi = (OrderItem)bslayer.AttachedOrder.items[x];
                            if (oi.EntityButtonIID == upeb.entitybutton.IID)
                            {
                                blnExist = true;
                                break;
                            }
                        }
                        if (!blnExist)
                            upeb.ClickTheButton();
                    }
                }
            }
        }


        public void LoadAttachedOrder()
        {

            //Ensure AttachedOrder Username 
            if (string.IsNullOrEmpty(bslayer.AttachedOrder.Waiter))
                bslayer.AttachedOrder.Waiter = bslayer.LoggedUser.UserName;

            //if (config.Customer_Display_Type != CustomerDisplayTypes.NONE)
            //    bslayer.CDSendMessage("TOTAL" + DRFormat.Space(config.Customer_Display_Text_Length - 9) + "0.00", CDAreas.All);


            //attach order to the screen and display the order
            OrderScreen.OrderToDisplay = bslayer.AttachedOrder;
            // OrderScreen.bslayer = bslayer;
            OrderScreen.Display();

            if (bslayer.AttachedOrder.Status == StatusFlags.DONE ||
                (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale)) // && config.Hold_Orders_New_Items_Add_Seperately))
                bslayer.StepableOrderItemGroupIID = POSLayer.Library.ShortGuid.NewDateBasedGuid2(); // ShortGuid.NewGuid().ToString();
            else
            {
                if (bslayer.AttachedOrder.Status == StatusFlags.NEW && bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
                    bslayer.StepableOrderItemGroupIID = POSLayer.Library.ShortGuid.NewDateBasedGuid2();
                else
                    bslayer.StepableOrderItemGroupIID = bslayer.AttachedOrder.IID;
            }


            bslayer.SetKitchenOrderModifiedStateForAttachedOrder(true);

            DetachPanel();
            DisplayWorkArea(true);

            bslayer.OnOrderLoaded();

        }

        public void UnloadOrder()
        {
            foreach (UPEntity upe in OUI.Panels)
                upe.Reset();

            if (bslayer.AttachedOrder != null)
            {
                bslayer.SetKitchenOrderModifiedStateForAttachedOrder(false);

                bslayer.ReturnOrder(bslayer.AttachedOrder);
                if (bslayer.AttachedOrder.Status == StatusFlags.NEW)
                    bslayer.DeleteOrder(bslayer.AttachedOrder.IID);
                bslayer.AttachedOrder = null;

            }

            DetachPanel();
            OUI.SelectedIndex = 0;

            try
            {
                if (pnlOrderPad.Controls.Count > 0)
                    ((RadioButton)pnlOrderPad.Controls[0]).Checked = true;
            } catch { }

            //Hide toolbar and user interface tab
            DisplayWorkArea(false);
            pnlTop.Enabled = true;

            bslayer.StepableOrderItemGroupIID = "";

            //ShowAutoOrderType
            switch (config.Auto_Order_Type)
            {
                case OrderTypes.InHouse:
                    ctlTables tpanel = ActivatorUtilities.CreateInstance<ctlTables>(sp, new GenericFunctionCall(DetachPanel),
                        new GenericEventHandler(btnTableButton_Click), new GenericEventHandler(btnDirectTable_Click));
                    AttachPanel(tpanel);
                    break;
                case OrderTypes.Pad:
                    cmdPad_Click(null, EventArgs.Empty);
                    break;
                default:
                    break;
            }
            //End of ShowAutoOrderType


            OrderScreen.OrderToDisplay = null;
            OrderScreen.Display();

            LoadPendingOrders();

            ResetScreenLock();

            bool bonusVisible = bslayer.LoggedUser.AccessLevel > AccessLevels.User ? true : IsBonusVisible();

            if (config.Display_Session_Bonus && bonusVisible)
            {
                pnlBonus.Visible = bonusVisible;
                pnlBonus.UpdateBonusDisplay();
            }

            pnlBonus.Visible = bonusVisible;

            bslayer.OnOrderUnloaded();
        }

        public bool IsBonusVisible()
        {
            //return true;
            try
            {
                if (bslayer.currentBonusScheme == null)
                {
                    return false;
                }

                if (!bslayer.currentBonusScheme.WithinRange(DateTime.Now.TimeOfDay))
                    return false;
                else if (bslayer.currentBonusScheme.WithinInvisibleRange(DateTime.Now.TimeOfDay))
                {
                    return false;
                } else
                {
                    return true;
                }
            } catch
            {
                return false;
            }
        }



        public bool SafelyPackTheOrder(POSLayer.Library.StatusFlags NewOrderStatus, bool blnLoadingNew)
        {
            bool blnHaveItemsToPrint = false;
            bool blnNewInHouseOrder = false;
            bool blnPrintableOldInHouseOrder = false;
            bool blnPrintableOtherOrderType = false;
            bool blnOldInHouseOrder = false;
            bool blnOrderHasMultipleOrderGroupIID = false;

            if (bslayer.AttachedOrder != null)
            {
                blnNewInHouseOrder = (bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.InHouse && bslayer.AttachedOrder.Status == POSLayer.Library.StatusFlags.NEW);// bslayer.OldOpennedOrder == null);

                blnPrintableOldInHouseOrder = (bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.InHouse && bslayer.AttachedOrder.HasItemsForKitchen());  //bslayer.AttachedOrder.Subtract(bslayer.OldOpennedOrder).items.Count > 0);
                blnPrintableOtherOrderType = bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.TakeAwayB;
                blnOldInHouseOrder = bslayer.AttachedOrder.Status == POSLayer.Library.StatusFlags.DONE;  // bslayer.OldOpennedOrder != null;
                blnOrderHasMultipleOrderGroupIID = bslayer.AttachedOrder.HasMultipleOrderGroupIID();
                blnHaveItemsToPrint = blnNewInHouseOrder || blnPrintableOldInHouseOrder || blnPrintableOtherOrderType || blnOrderHasMultipleOrderGroupIID;
            }

            if (bslayer.AttachedOrder == null)
            {
                //bslayer.OldOpennedOrder = null;
                return true;
            } else
            {

                PrepDialogReturnTypes prepResult = PrepDialogReturnTypes.Cancel;

                //Signals beingModified to false for all orders, that means kitchen order will be free
                try
                {
                    bslayer.SetKitchenOrderModifiedStateForAttachedOrder(false);
                } catch (Exception ex)
                {
                    bslayer.SaveDebug("189 : " + ex.Message);
                }

                if ((blnNewInHouseOrder || blnOldInHouseOrder || blnPrintableOldInHouseOrder || blnOrderHasMultipleOrderGroupIID) && (config.Table_Orders_Display_Kitchen_Orders || config.Table_Orders_Kitchen_Receipt_Count > 0))
                {
                    //if ((blnNewInHouseOrder || blnPrintableOldInHouseOrder) && config.Display_Kitchen_Orders) {
                    //This is where you call CreateKitchenOrderForInHouseOrder / if prep denied/cancelled go back

                    POSLayer.Models.KitchenOrder korder = null;

                    POSLayer.Models.Order order = bslayer.AttachedOrder.GetOrderWithKitchenableItems();
                    if (order.items.Count == 0)
                        bslayer.DeleteKitchenOrdersForOrder(bslayer.AttachedOrder.IID);
                    else
                    {
                        prepResult = bslayer.CreateKitchenOrderForOrder(order, korder).Result;
                        if (prepResult == PrepDialogReturnTypes.Cancel)
                            return false;
                    }

                    if (bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.InHouse && config.Table_Orders_Always_Shrinked)
                        bslayer.AttachedOrder.ShrinkOrder();

                }

                if (blnHaveItemsToPrint)
                {

                    bslayer.AttachedOrder.Status = NewOrderStatus;
                    if (blnPrintableOtherOrderType)
                    {
                        return this.CompleteAttachedOrder(2, true, false, false);
                    }
                    //bslayer.OldOpennedOrder = null;
                    UnloadOrder();
                    return true;

                } else
                {
                    if (bslayer.AttachedOrder.items.Count > 0)
                    {
                        bslayer.AttachedOrder.Status = UF.UpdateStatus(bslayer.AttachedOrder.Status, NewOrderStatus, true);
                        if (bslayer.AttachedOrder.Status == POSLayer.Library.StatusFlags.UNKNOWN ||
                            bslayer.AttachedOrder.Status == POSLayer.Library.StatusFlags.NEW)
                        {
                            bslayer.DeleteOrder(bslayer.AttachedOrder.IID);
                            bslayer.AttachedOrder = null;
                        } else
                            bslayer.SaveOrder(bslayer.AttachedOrder);
                        UnloadOrder();
                    } else if (bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.InHouse)
                    {
                        UnloadOrder();
                    } else
                        UnloadOrder();
                }
                return true;
            }
        }

        #region CUSTOMER PANEL HANDLERS
        public bool ShowCustomerDialog(bool blnEnsureContinuation, int NumberOfCopy, bool blnArchive, bool blnPrintLocal, bool blnEnforceDeliveryArchive)
        {
            if (blnEnsureContinuation)
                AttachPanel(ActivatorUtilities.CreateInstance<ctlCustomer>(ServiceHelper.Services, new GenericFunctionCall(DetachCustomerPanel), new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive));
            else
                AttachPanel(ActivatorUtilities.CreateInstance<ctlCustomer>(ServiceHelper.Services, new GenericFunctionCall(DetachCustomerPanel), null, NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive));
            return false;
        }
        public void DetachCustomerPanel()
        {
            DetachPanel();
            OrderScreen.Display();
        }
        public bool EnsureCustomer(bool blnShowMessage)
        {
            if (!bslayer.AttachedOrder.IsCustomerDetailsRequired)
                return true;

            if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery ||
                bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB || bslayer.AttachedOrder.OrderType == OrderTypes.InternetTakeAway)
            {

                if (bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB || bslayer.AttachedOrder.OrderType == OrderTypes.InternetTakeAway)
                {
                    if ((bslayer.AttachedOrder.Customer.CName.Trim()) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer name is missing !");
                        return false;
                    }
                    if ((bslayer.AttachedOrder.Customer.Tel + bslayer.AttachedOrder.Customer.Email) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer must have at least one phone number or an email address");
                        return false;
                    }
                } else if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery)
                {
                    if ((bslayer.AttachedOrder.Customer.CName) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Name missing ");
                        return false;
                    }
                    if ((bslayer.AttachedOrder.Customer.Tel.Trim() + bslayer.AttachedOrder.Customer.Email.Trim()) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer must have at least one phone number or an email address");
                        return false;
                    }
                    if (bslayer.AttachedOrder.Customer.Address.Trim() == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer must have an address");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion





        public bool CompleteAttachedOrder(int NumberOfCopy, bool blnArchive, bool blnPrintLocal,
            bool blnEnforceDeliveryArchive)
        {
            string OrderIID = "";
            string SelectedPrinterIID = "";

            if (bslayer.AttachedOrder != null)
            {
                OrderIID = bslayer.AttachedOrder.IID; //Get a copy of the order IID

                if (!EnsureCustomer(false))
                {
                    if (!ShowCustomerDialog(true, NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive))
                        return false;
                }

                if (!EnsureTable() && OrderScreen.SplitStatus != SplittingStatus.Splitting)
                {
                    MessageBox.Show("Table is not allocated");
                    return false;
                }


                if (blnArchive)
                {
                    if (bslayer.AttachedOrder.Payment == PaymentMethods.Unknown)
                    {
                        switch (bslayer.AttachedOrder.OrderType)
                        {
                            case OrderTypes.DirectSale:
                                if (config.Direct_Sale_Auto_Payment_Mehtod == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(ActivatorUtilities.CreateInstance<ctlPayment>(sp, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                                break;
                            case OrderTypes.InHouse:
                                if (config.Table_Orders_Auto_Payment_Method == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(ActivatorUtilities.CreateInstance<ctlPayment>(sp, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;


                                break;
                            case OrderTypes.TakeAwayB:
                                if (config.TakeAway_Orders_Auto_Payment_Method == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(ActivatorUtilities.CreateInstance<ctlPayment>(sp, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                                break;
                            case OrderTypes.Delivery:
                                if (config.Delivery_Orders_Auto_Payment_Method == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(ActivatorUtilities.CreateInstance<ctlPayment>(sp, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                                break;
                        }
                    }

                }

                if (blnPrintLocal)
                {
                    //Select Receipt Printer	Delivery Or TakeAwayB printer
                    if (bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB ||
                        bslayer.AttachedOrder.OrderType == OrderTypes.InternetTakeAway)
                    {
                        try
                        {
                            SelectedPrinterIID = bslayer.GetPrinterForOrderType(OrderTypes.TakeAwayB).Result.IID;
                        } catch
                        {
                        }
                    }

                    if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery ||
                        bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery)
                    {
                        try
                        {
                            SelectedPrinterIID = bslayer.GetPrinterForOrderType(OrderTypes.Delivery).Result.IID;
                        } catch
                        {
                        }
                    }

                    if (SelectedPrinterIID == null || SelectedPrinterIID == "")
                    {
                        List<Printer> PrinterList = bslayer.GetReceiptPrinterList().Result;
                        if (PrinterList.Count == 0)
                        {
                            MessageBox.Show("There is no receipt printer in the system, please assign a receipt printer");
                            return false;
                        } else if (PrinterList.Count == 1)
                        {
                            SelectedPrinterIID = PrinterList[0].IID;
                        } else
                        {
                            if (blnPrintLocal && config.DTClientLocalReceiptPrinterIID != "" &&
                                config.DTClientLocalReceiptPrinterIID != null)
                                SelectedPrinterIID = config.DTClientLocalReceiptPrinterIID;
                            else
                            {
                                //show receipt printer list
                                trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
                                if (fsp.ShowDialog() == DialogResult.OK)
                                    SelectedPrinterIID = fsp.ReturnValue;
                                else
                                    return false;
                                fsp = null;
                            }
                        }
                    }
                } else
                    SelectedPrinterIID = null;

                if (NumberOfCopy > 0)
                {
                    bslayer.AttachedOrder.blnPrinted = bslayer.PrintEntireOrder(bslayer.AttachedOrder, true, true,
                        NumberOfCopy, SelectedPrinterIID).Result;
                    if (config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(bslayer.GetPrinterForClient(SelectedPrinterIID).Result.NetworkName);

                }

                if (blnArchive)
                {
                    if (!config.Table_Orders_Always_Shrinked)
                        bslayer.AttachedOrder.ShrinkOrder();

                    bslayer.AttachedOrder.OrderDate = DateTime.Now;
                    bslayer.AttachedOrder.Status = StatusFlags.COMPLETED;
                }
                if (OrderScreen.SplitStatus == SplittingStatus.Splitting)
                {
                    bslayer.SaveOrder(bslayer.AttachedOrder);
                    OrderScreen.FinaliseSplit();
                }

                //inhouse order still attached to primary table 

                bool blnTableTransferRequired = false;
                string sourceTableIID = "";
                string targetTableIID = "";
                if (bslayer.AttachedOrder != null)
                {
                    if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
                    {
                        if (bslayer.IsPrimaryTable(bslayer.AttachedOrder.TableIID).Result)
                        {
                            if (bslayer.HasSubTables(bslayer.AttachedOrder.TableIID).Result)
                            {
                                blnTableTransferRequired = true;
                                targetTableIID = bslayer.AttachedOrder.TableIID;
                                sourceTableIID = bslayer.GetFirstSubTableIID(targetTableIID);
                            }
                        }
                    }
                }


                if (config.TakeAway_Orders_Display_Kitchen_Orders && bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.TakeAwayB)
                    bslayer.CreateKitchenOrderForTakeAwayAndDeliveryOrder(bslayer.AttachedOrder);

                if (config.Delivery_Orders_Display_Kitchen_Orders && bslayer.AttachedOrder.OrderType == POSLayer.Library.OrderTypes.Delivery)
                    bslayer.CreateKitchenOrderForTakeAwayAndDeliveryOrder(bslayer.AttachedOrder);


                //This is the final place for inhouse order to remove from the system
                //if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse) {
                //    bslayer.DeleteKitchenOrdersForOrder(bslayer.AttachedOrder.IID);
                //}
                UnloadOrder();



                if (blnTableTransferRequired)
                    bslayer.MoveTable(sourceTableIID, targetTableIID, false);
                //now you can transfer first subtable order to primary table

                ResetScreenLock();

            }
            return true;
        }

        #endregion

        #region "RIGHT SIDE ACTION BUTTON HANDLERS"
        //THIS IS DONE BUTTON function it is called by a  delegate function
        public bool DoneEventHandlerFunction()
        {
            if (bslayer.AttachedOrder != null)
            {
                if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB ||
                    bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery || bslayer.AttachedOrder.OrderType == OrderTypes.InternetTakeAway)
                    return false;
                if (SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, false))
                {
                    return true;
                } else
                    return false;
            }
            return false;
        }

        private void PrintFinalPayment(PaymentMethods paymentMethod, bool withReceipt)
        {

            if (bslayer.AttachedOrder != null)
            {
                double total = bslayer.AttachedOrder.GetFullTotal();
                if (total == 0)
                    return;
                if (total > 0 && (bslayer.AttachedOrder.OrderType != OrderTypes.Delivery))
                    bslayer.OpenCashDrawer(false);

                bslayer.AttachedOrder.Payment = paymentMethod;

                switch (bslayer.AttachedOrder.OrderType)
                {
                    case OrderTypes.DirectSale:
                        if (withReceipt)
                            this.CompleteAttachedOrder(config.Direct_Sale_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(0, true, false, false);
                        break;
                    case OrderTypes.InHouse:
                        if (withReceipt)
                            this.CompleteAttachedOrder(config.Table_Orders_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(0, true, false, false);


                        break;
                    case OrderTypes.TakeAwayB:

                        if (withReceipt)
                            this.CompleteAttachedOrder(config.TakeAway_Orders_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(config.TakeAway_Orders_Receipt_Count, true, true, false);
                        break;
                    case OrderTypes.Delivery:

                        if (withReceipt)
                            this.CompleteAttachedOrder(config.Delivery_Orders_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(config.Delivery_Orders_Receipt_Count, true, true, false);
                        break;
                    default:
                        this.CompleteAttachedOrder(2, true, true, false);
                        break;
                }
                bslayer.SetKitchenModified();
                tmrHoldingOrders_Tick(null, null);
            }
        }


        #endregion

        #region "TABLE RELATED"

        private void btnTableButton_Click(object sender, EventArgs e)
        {
            if (bslayer.HasSubTables(((TableButton)sender).IID).Result)
            {
                //Display SubTables selection panel
                frmSubTableSelector frm = ActivatorUtilities.CreateInstance<frmSubTableSelector>(sp, ((TableButton)sender).IID,
                    new GenericEventHandler(btnActualTableButton_Click));
                if (frm.ShowDialog() == DialogResult.Cancel)
                    cmdTables_Click(null, null);
            } else
            {
                btnActualTableButton_Click(sender, e);
            }
        }

        private async void btnActualTableButton_Click(object sender, EventArgs e)
        {

            Table table = await bslayer.BarrowTable(((TableButton)sender).IID);
            if (table == null)
            {
                MessageBox.Show("Table Currently Busy, cannot be allocated");
                return;
            } else
            {
                bslayer.AttachedOrder = table.AttachedOrder;
                LoadAttachedOrder();
            }
        }

        private async void btnDirectTable_Click(object tableIID, EventArgs e)
        {

            Table table = await bslayer.BarrowTable(tableIID.ToString());
            if (table == null)
            {
                MessageBox.Show("Table Currently Busy, cannot be allocated");
                return;
            } else
            {
                bslayer.AttachedOrder = table.AttachedOrder;
                LoadAttachedOrder();
            }
        }

        public bool EnsureTable()
        {
            if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
            {
                if (bslayer.AttachedOrder.TableIID == null || bslayer.AttachedOrder.TableIID == "")
                    return false;
            }
            return true;
        }
        #endregion

        #region "PANEL FUNCTIONS"
        public void AttachPanel(Control ctrl)
        {
            pnlOrderPad.Visible = (ctrl.Name == "upentity");

            try
            {
                pnlHolder.Controls.Clear();
            } catch { }
            if (pnlHolder.Dock != DockStyle.Fill)
                pnlHolder.Dock = DockStyle.Fill;
            if (!pnlHolder.Visible)
                pnlHolder.Visible = true;
            pnlHolder.Controls.Add(ctrl);
            if (!ctrl.Visible)
                ctrl.Visible = true;
            if (ctrl.Dock != DockStyle.Fill)
                ctrl.Dock = DockStyle.Fill;
        }

        public void DetachPanel()
        {
            try
            {
                pnlHolder.Controls.Clear();
            } catch { }

            if (bslayer.AttachedOrder != null)
                AttachPanel(OUI.SelectedPanel);
        }
        #endregion


        private POSLayer.Library.ViewTypes OrderTypeToViewType(POSLayer.Library.OrderTypes otype)
        {
            switch (otype)
            {
                case POSLayer.Library.OrderTypes.DirectSale:
                    return POSLayer.Library.ViewTypes.DirectSaleOrderView;
                case POSLayer.Library.OrderTypes.InHouse:
                    return POSLayer.Library.ViewTypes.InHouseOrderView;
                case POSLayer.Library.OrderTypes.TakeAwayB:
                    return POSLayer.Library.ViewTypes.TakeAwayOrderView;
                case POSLayer.Library.OrderTypes.Delivery:
                    return POSLayer.Library.ViewTypes.DeliveryOrderView;
                case POSLayer.Library.OrderTypes.InternetDelivery:
                    return POSLayer.Library.ViewTypes.InternetDeliveryView;
                case POSLayer.Library.OrderTypes.InternetTakeAway:
                    return POSLayer.Library.ViewTypes.InternetTakeAwayView;
                default:
                    return POSLayer.Library.ViewTypes.Unknown;
            }

        }

        private void HandleActionPanelView(ViewTypes view)
        {
            bool blnHasOrder = (bslayer.AttachedOrder != null);

            int OrderTypeCount = 0;

            //SetAllowedOrderTypeButtons
            if (config != null)
            {
                cmdDirectSale.Visible = config.Direct_Sale_Allowed;
                cmdTables.Visible = config.Table_Orders_Allowed;
                cmdTakeAway.Visible = config.TakeAway_Orders_Allowed;
                cmdDelivery.Visible = config.Delivery_Orders_Allowed;

                OrderTypeCount += config.Direct_Sale_Allowed ? 1 : 0;
                OrderTypeCount += config.Table_Orders_Allowed ? 1 : 0;
                OrderTypeCount += config.TakeAway_Orders_Allowed ? 1 : 0;
                OrderTypeCount += config.Delivery_Orders_Allowed ? 1 : 0;
            }

            //DisplayTopBar
            try
            {
                mnuCustomer.Visible = blnHasOrder && bslayer.AttachedOrder.IsCustomerDetailsRequired;
            } catch { }

            mnuPad.Enabled = config.Pad_Allowed;

            mnuOrders.Visible = false;
            mnuReports.Visible = false;

            mnuPrintForKitchen.Visible = blnHasOrder && (bslayer.AttachedOrder.OrderType != OrderTypes.DirectSale);
            btnPrint.Visible = blnHasOrder && !string.IsNullOrEmpty(config.DTClientLocalReceiptPrinterIID);

            mnuReloadMenu.Visible = !blnHasOrder && bslayer.LoggedUser.IsManagerOrMore();

            mnuPad.Enabled = bslayer.HasPadItems() && config.Pad_Allowed;

            bool blnOrderHasItems = false;
            if (bslayer.AttachedOrder != null)
                blnOrderHasItems = bslayer.AttachedOrder.items.Count > 0;
            switch (view)
            {
                case ViewTypes.UnloadedOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    btnHoldAndReceipt.Visible = btnHoldAndReceipt.Visible = false;

                    //Third Row
                    //btnSubTotal.Visible = false;
                    btnPrintCashFinalPaymentWithReceipt.Visible = false;
                    btnPrintCardFinalPaymentWithReceipt.Visible = false;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = false;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = false;
                    btnPrintCardFinalPayment.Visible = false;
                    btnPrintOnlineFinalPayment.Visible = false;

                    mnuOrders.Visible = config.Order_Reloads_Allowed || (((int)bslayer.LoggedUser.AccessLevel) > (int)AccessLevels.User);
                    mnuReports.Visible = config.Standard_Users_Can_Produce_Reports || (((int)bslayer.LoggedUser.AccessLevel) > (int)AccessLevels.User);
                    //cmdLastOrder.Visible = config.Last_Order_Reload_Allowed || (((int)bslayer.LoggedUser.AccessLevel) > (int)AccessLevels.User);

                    ArrangeSubTotalPanel(false);
                    break;
                #endregion
                case ViewTypes.DirectSaleOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = (config.Hold_Order_Available &&
                        (bslayer.AttachedOrder != null) &&
                        (bslayer.AttachedOrder.items.Count > 0));

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash_And_Print && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card_And_Print && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online_And_Print && blnOrderHasItems;
                    //Forth Row

                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.InHouseOrderView:
                    #region
                    //First Row
                    btnDone.Visible = blnOrderHasItems;
                    if (OrderScreen.SplitStatus == SplittingStatus.Splitting)
                        btnDone.Visible = false;

                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged && config.Print_Invoice_Button_Visible;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);

                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged && config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    // btnSubTotal.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged && config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    //Forth Row
                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    break;
                #endregion
                case ViewTypes.TakeAwayOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    //Forth Row

                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.DeliveryOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.SplitView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = ((bslayer.AttachedOrder != null) &&
                       (bslayer.AttachedOrder.items.Count > 0) && config.Hold_Order_Available);

                    //Second Row
                    mnuDrawerCalculator.Visible = false;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = false;

                    //Third Row
                    //btnSubTotal.Visible = true;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && true;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && true;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && true;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && true;
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && true;
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && true;
                    break;
                #endregion
                case ViewTypes.SubTotalView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = false;

                    //Third Row
                    //btnSubTotal.Visible = false;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && false;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && false;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && false;
                    //Forth Row

                    btnPrintCashFinalPayment.Visible = false;
                    btnPrintCardFinalPayment.Visible = false;
                    btnPrintOnlineFinalPayment.Visible = false;
                    break;
                #endregion
                case ViewTypes.InternetTakeAwayView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.InternetDeliveryView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    // btnChequePaymentWithReceipt.Visible = blnOrderHasItems && config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                default:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = config.Cash_Drawer_Void_Open_Allowed && (config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    // btnChequePaymentWithReceipt.Visible = false;

                    //Third Row
                    //btnSubTotal.Visible = false;
                    btnPrintCashFinalPaymentWithReceipt.Visible = false;
                    btnPrintCardFinalPaymentWithReceipt.Visible = false;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = false;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = false;
                    btnPrintCardFinalPayment.Visible = false;
                    btnPrintOnlineFinalPayment.Visible = false;
                    break;
                    #endregion
            }

            //Can not change the order
            if (bslayer.AttachedOrder != null && (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED))
            {
                btnDone.Visible = btnHoldOrder.Visible = btnHoldAndReceipt.Visible =
                   btnPrintCashFinalPayment.Visible = btnPrintCashFinalPaymentWithReceipt.Visible =
                   btnPrintCardFinalPayment.Visible = btnPrintCardFinalPaymentWithReceipt.Visible =
                   btnPrintOnlineFinalPayment.Visible = btnPrintOnlineFinalPaymentWithReceipt.Visible = false;


            }


        }

        private void trmOrderPadMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrHoldingOrders.Enabled = false;
        }



        #region ORDER TYPE BUTTON HANDLERS

        private void cmdDirectSale_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new Order(POSLayer.Library.OrderTypes.DirectSale);
                bslayer.AttachedOrder.ServiceChargeRate = bslayer.shop.ServiceChargeRate;
                bslayer.AttachedOrder.ServiceChargeTaxRate = bslayer.shop.ServiceChargeTaxRate;

                EnsureCompulsoryExtras();
                LoadAttachedOrder();
            } else
            {
                if (config.DebugMode)
                    bslayer.SaveDebug("safely pack order on direct sale click failed");
            }
        }

        private void cmdTables_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, true))
            {
                ctlTables tpanel = ActivatorUtilities.CreateInstance<ctlTables>(sp, new GenericFunctionCall(DetachPanel),
                    new GenericEventHandler(btnTableButton_Click), new GenericEventHandler(btnDirectTable_Click));
                AttachPanel(tpanel);
            }
        }

        private void CreateAndLoadInHouseOrder()
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new POSLayer.Models.Order(POSLayer.Library.OrderTypes.InHouse, bslayer.shop.ServiceChargeRate, bslayer.shop.ServiceChargeTaxRate);
                LoadAttachedOrder();
            }
        }

        private async void cmdTakeAway_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new Order(OrderTypes.TakeAwayB, bslayer.shop.ServiceChargeRate, bslayer.shop.ServiceChargeTaxRate);
                EnsureCompulsoryExtras();
                LoadAttachedOrder();
            }
        }

        private async void cmdDelivery_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(StatusFlags.DONE, true))
            {

                bslayer.AttachedOrder = new POSLayer.Models.Order(OrderTypes.Delivery, bslayer.shop.ServiceChargeRate, bslayer.shop.ServiceChargeTaxRate);
                EnsureCompulsoryExtras();
                LoadAttachedOrder();
            }
        }

        private async void cmdCancel_Click(object sender, EventArgs e)
        {
            if (OrderScreen.SplitStatus == SplittingStatus.Splitting)
                OrderScreen.AbortSplit();

            if (bslayer.AttachedOrder == null)
                DetachPanel();
            else
            {
                bslayer.SetKitchenOrderModifiedStateForAttachedOrder(false);


                //MessageBox.Show(bslayer.AttachedOrder.Status.ToString());
                switch (bslayer.AttachedOrder.Status)
                {
                    case POSLayer.Library.StatusFlags.NEW:
                    case POSLayer.Library.StatusFlags.UNKNOWN:
                    case POSLayer.Library.StatusFlags.VOID:
                        bslayer.DeleteOrder(bslayer.AttachedOrder.IID);
                        bslayer.AttachedOrder = null;
                        UnloadOrder();
                        return;
                    case POSLayer.Library.StatusFlags.DONE:
                        string tableIID = bslayer.AttachedOrder.TableIID;
                        bslayer.AttachedOrder = null;
                        UnloadOrder();
                        Table table = await bslayer.GetTable(tableIID);
                        if (table != null)
                        {
                            table.LockedClientIP = "";
                            bslayer.SaveTable(table);
                        }
                        return;
                    case POSLayer.Library.StatusFlags.PENDING:
                    case POSLayer.Library.StatusFlags.COMPLETED:
                    case POSLayer.Library.StatusFlags.ARCHIVED:
                        bslayer.AttachedOrder = null;
                        UnloadOrder();
                        return;

                }
            }
        }

        #endregion

        #region TOP FUNCTION BUTTON HANDLERS
        #region OWL MENU
        private void btnOwl_PopupOpen(object sender, EventArgs e)
        {
            try
            {
                mnuSum.Visible = config.Display_Session_Total_On_Menu || bslayer.LoggedUser.IsManagerOrMore();
                mnuSelectBonusPlan.Visible = config.Display_Session_Bonus || bslayer.LoggedUser.IsManagerOrMore();
                mnuReprintReport.Visible = (config.Preserve_Previous_Report && bslayer.imgReportSnapShot != null && bslayer.LoggedUser.IsManagerOrMore());

                mnuSum.Text = bslayer.GetCurrentSessionXSum().ToString("c2");

                mnuLock.Enabled = (bslayer.AttachedOrder == null);
            } catch
            {
                float blank = 0;
                mnuSum.Text = blank.ToString("c2");
            }
        }

        private void cmdOrders_Click(object sender, EventArgs e)
        {
            if (config.Order_Reloads_Allowed || (bslayer.LoggedUser.AccessLevel != AccessLevels.User))
            {
                if (bslayer.AttachedOrder != null)
                {
                    if (!this.SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, true))
                        return;
                }
                ctlOrders fo = ActivatorUtilities.CreateInstance<ctlOrders>(sp, new GenericFunctionCall(UnloadOrder),
                    new GenericFunctionCall(LoadAttachedOrder),
                    new GenericFunctionCall(DetachPanel),
                    new PassControl(AttachPanel),
                    new RemoteCompleteAttachedOrder(CompleteAttachedOrder));

                AttachPanel(fo);
            }
        }

        private async void cmdReports_Click(object sender, EventArgs e)
        {

            if (!bslayer.HasCurrentSessionCompletedOrders())
            {
                MessageBox.Show("There is no completed orders for this session!!");
                return;
            }


            if (!config.This_Terminal_Can_Produce_Reports)
            {
                MessageBox.Show("This unit is not configured to generate reports!\nPlease contact system administrator or try another unit");
                return;
            }

            if (bslayer.AttachedOrder != null)
            {
                MessageBox.Show("System has active order, Please complete the order before report procedure!!");
                return;
            }

            bool blnHasActiveHoldOrders = bslayer.HasActiveHoldOrders();

            if (config.No_Hold_Orders_Allowed_During_Report && blnHasActiveHoldOrders)
            {
                MessageBox.Show("You must cash out HOLD Orders before report!!!");
                return;
            }

            bool blnHasActiveTableOrders = bslayer.HasActiveTableOrders();

            if (config.No_Table_Orders_Allowed_During_Report && blnHasActiveTableOrders)
            {
                MessageBox.Show("You must cash out Table Orders before report!!!");
                return;
            }

            bool blnZReport = bslayer.WillReportEndUpAs_Z_Report(await bslayer.GetCurrentSession());
            if (blnZReport && (blnHasActiveHoldOrders || blnHasActiveTableOrders))
            {
                MessageBox.Show("Printing report will auto produce Z report, YOU MUST CASHOUT ALL ORDERS before proceed!!!!");
                return;
            }


            if (config.Payments_Can_Be_Made_By_Card || config.Payments_Can_Be_Made_By_Card_And_Print)
            {
                bool blnPrint = false;
                if (!blnZReport)
                {
                    if (config.X_Pin_Machine_Report_Required)
                        blnPrint = true;
                    else
                        blnPrint = false;
                } else
                {
                    if (config.Z_Pin_Machine_Report_Required)
                        blnPrint = true;
                    else
                        blnPrint = false;
                }
                if (blnPrint)
                {
                    frmPinZWarning frm = new frmPinZWarning(bslayer, await bslayer.GetOrdersTotalForPaymentMethod(bslayer.shop.CurrentSessionIID, PaymentMethods.Card));
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }


            bslayer.CleanKitchenOrdersHasNoParentOrder();


            //There should be no panel visible specifically OrderList panel
            DetachPanel();

            Report report = bslayer.GetReport(ReportFormatTypes.XReport);

            trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
            if (fsp.ShowDialog() == DialogResult.OK)
            {

                bslayer.OpenCashDrawer(false);

                if (report.RequireCashDrawTotal)
                {
                    //RequireCashDrawTotal before printing report                        
                    TrmDrawerCount frmDrawer = ActivatorUtilities.CreateInstance<TrmDrawerCount>(ServiceHelper.Services, bslayer);
                    if (frmDrawer.ShowDialog() != DialogResult.OK)
                    {
                        goto bypass;
                    }
                }

                //"Courier New"
                await bslayer.PrintReport(ReportFormatTypes.XReport, bslayer.shop.CurrentSessionIID, fsp.ReturnValue, false);

                await bslayer.OpenCashDrawer(false);
            bypass:
                if (config.Force_Receipt_Printer_To_Cut)
                    DRShell.SendCutCommandToUSBPrinter(bslayer.GetPrinterForClient(fsp.ReturnValue).Result.NetworkName);

            } else
                return;


        }
        private void cmdLock_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            Lock();
        }

        private void btnReprintReport_Click(object sender, EventArgs e)
        {
            if (bslayer.imgReportSnapShot != null)
            {
                trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
                if (fsp.ShowDialog() == DialogResult.OK)
                {
                    bslayer.PrintImage(bslayer.imgReportSnapShot, bslayer.GetPrinterForClient(fsp.ReturnValue).Result.NetworkName);
                }
            }
        }

        private void mnuSupervisorReport_Click(object sender, EventArgs e)
        {
            frmLog frm = new frmLog(bslayer);
            frm.ShowDialog();
        }
        #endregion

        #region SMILEY MENU
        private async void tsPrintForKitchen_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
            {
                await bslayer.PrintForKitchen(bslayer.AttachedOrder.IID);
            }
        }
        private void btnPrintAsInvoice_Click(object sender, System.EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
            {
                if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse && bslayer.AttachedOrder.Status != StatusFlags.NEW)
                    this.CompleteAttachedOrder(1, false, true, false);
                else
                    return;
            }
        }
        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomerDialog(false, 0, false, false, false);
        }

        private void cmdPad_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder == null)
            {
                if (config.Order_Pad_Default_Order_Type == POSLayer.Library.OrderTypes.InHouse)
                {
                    ctlTables tpanel = ActivatorUtilities.CreateInstance<ctlTables>(sp, new GenericFunctionCall(DetachPanel), new GenericEventHandler(btnTableButton_Click), new GenericEventHandler(btnDirectTable_Click));
                    AttachPanel(tpanel);
                    return;
                } else
                {
                    bslayer.AttachedOrder = new POSLayer.Models.Order(config.Order_Pad_Default_Order_Type);
                    EnsureCompulsoryExtras();
                    blnPadOpenning = true;
                    LoadAttachedOrder();
                    AttachPanel(ActivatorUtilities.CreateInstance<ctlNumberPad>(sp, new GenericFunctionCall(DetachPanel)));
                    blnPadOpenning = false;
                }
            } else
            {
                AttachPanel(ActivatorUtilities.CreateInstance<ctlNumberPad>(sp, new GenericFunctionCall(DetachPanel)));
            }
        }
        #endregion

        #region TOOLS MENU
        private void btnDrawerCalculator_Click(object sender, EventArgs e)
        {
            TrmDrawerCount frm = new TrmDrawerCount(bslayer, true);
            frm.ShowDialog();
        }
        private void tsReloadMenu_Click(object sender, EventArgs e)
        {
            //ensure order closed  if any open already
            SafelyPackTheOrder(POSLayer.Library.StatusFlags.DONE, true);
            bslayer.GetActiveMenu(true, true);
            RefreshUserInterface();
        }
        #region SERVICE HANDLERS
        //private void btnService_Click(object sender, EventArgs e) {
        //    if (config.ServiceEnabled && config.ServiceLocalPort > 2000 && config.ServiceLocalPort < 49000) {
        //        //Service operation can be handled

        //        //Now check if service is open
        //        if (blnHttpServiceRunning) {
        //            StopHttpService();
        //        } else {
        //            StopHttpService();
        //            StartHttpService();
        //        }

        //    } else {
        //        //Server operation must be configured in options first
        //        MessageBox.Show("Server settings should be configured");
        //    }
        //}



        //public bool StartHttpService() {
        //    if (config.ServiceEnabled) {
        //        if (config.ServiceLocalPort > 2000 && config.ServiceLocalPort < 49000) {
        //            try {
        //                Uri serviceUri = new Uri("http://localhost:" + config.ServiceLocalPort.ToString());

        //                // Create the ServiceHost.
        //                httpServiceHost = null;
        //                httpServiceHost = new ServiceHost(typeof(SimpleBusinessService), serviceUri);
        //                httpServiceHost.Opened += host_Opened;
        //                httpServiceHost.Closed += host_Closed;


        //                // Enable metadata publishing.
        //                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
        //                smb.HttpGetEnabled = true;
        //                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
        //                httpServiceHost.Description.Behaviors.Add(smb);


        //                // Open the ServiceHost to start listening for messages. Since
        //                // no endpoints are explicitly configured, the runtime will create
        //                // one endpoint per base address for each service contract implemented
        //                // by the service.
        //                httpServiceHost.Open();


        //                return true;
        //            } catch (Exception ex) {
        //                string test = ex.Message;
        //                MessageBox.Show("Failed to start Mobile Service");
        //                return false;
        //            }
        //        }
        //    }
        //    return true;

        //}

        //public bool StopHttpService() {
        //    try {
        //        httpServiceHost.Close();

        //        return true;
        //    } catch {
        //        return false;
        //    }
        //}

        //public void host_Closed(object sender, EventArgs e) {
        //    blnHttpServiceRunning = false;
        //    mnuService.Image = Properties.Resources.RedNuke48;
        //}

        //public void host_Opened(object sender, EventArgs e) {
        //    blnHttpServiceRunning = true;
        //    mnuService.Image = Properties.Resources.GreenNuke48;
        //}

        #endregion

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmConfig frm = ActivatorUtilities.CreateInstance<frmConfig>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Some changes may require application restart to take effect, Please restart the application as soon as possible to ensure smooth operation");
                Environment.Exit(0);
            }
        }

        #endregion

        #endregion

        #region ACTION PANEL BUTTON HANDLERS
        private void btnDone_Click(object sender, System.EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
            {
                if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery ||
                    bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB || bslayer.AttachedOrder.OrderType == OrderTypes.InternetTakeAway)
                    return;
                else
                {
                    if (DoneEventHandlerFunction())
                        ResetScreenLock();
                    else
                        return;
                }
            }
        }
        private void btnFault_Click(object sender, EventArgs e)
        {
            if (config.Cash_Drawer_Void_Open_Allowed)
                bslayer.OpenCashDrawer(true);
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && !string.IsNullOrEmpty(config.DTClientLocalReceiptPrinterIID))
            {
                if (bslayer.AttachedOrder != null)
                {
                    await bslayer.PrintEntireOrder(bslayer.AttachedOrder, true, false, 1,
                        config.DTClientLocalReceiptPrinterIID);
                    if (config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(
                            bslayer.GetPrinterForClient(config.DTClientLocalReceiptPrinterIID).Result.NetworkName);
                }
            }
        }

        private void btnHoldOrder_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
            {
                if (pnlPendingOrders.Controls.Count < config.Hold_Order_Maximum_Allowed)
                {
                    ToolStripMenuItem btn = (ToolStripMenuItem)sender;
                    if (btn == null)
                        UnloadOrder();
                    else
                    {
                        //Direct Sale
                        //NEW        => Pending , Save , Unload
                        //COMPLETED  => prevent adding items, Dont Respond to hold
                        //PENDING    => Pending, Save, Unload
                        if (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale && (bslayer.AttachedOrder.Status == StatusFlags.NEW || bslayer.AttachedOrder.Status == StatusFlags.PENDING))
                        {
                            blnAlreadyHolding = (OrderScreen.SplitStatus == SplittingStatus.Splitting);
                            DoHolding(btn.Tag.ToString(), false);
                        }
                    }
                } else
                {
                    MessageBox.Show("TOO MANY ORDERS ON HOLD.\r\nCASH SOME OF THEM BEFORE HOLDING !!!");
                }
            }
        }
        private void btnHoldAndReceipt_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
            {
                if (pnlPendingOrders.Controls.Count < config.Hold_Order_Maximum_Allowed)
                {
                    ToolStripMenuItem btn = (ToolStripMenuItem)sender;
                    if (btn == null)
                        UnloadOrder();
                    else
                        DoHolding(btn.Tag.ToString(), true);
                } else
                {
                    MessageBox.Show("TOO MANY ORDERS ON HOLD.\r\nCASH SOME OF THEM BEFORE HOLDING !!!");
                }
            }
        }
        private void btnPrintCashFinalPaymentNoReceipt_Click(object sender, System.EventArgs e)
        {
            // if (bslayer.AttachedOrder != null) {

            lblOrderTotal.Text = bslayer.AttachedOrder.GetFullTotal().ToString("c");
            ArrangeSubTotalPanel(true);

            if (bslayer.AttachedOrder.MoneyPaid == 0)
            {
                return;
            }
            PrintFinalPayment(PaymentMethods.Cash, false);
        }
        private void btnPrintCashFinalPaymentWithReceipt_Click(object sender, System.EventArgs e)
        {
            lblOrderTotal.Text = bslayer.AttachedOrder.GetFullTotal().ToString("c");
            ArrangeSubTotalPanel(true);

            if (bslayer.AttachedOrder.MoneyPaid == 0)
            {
                return;
            }
            PrintFinalPayment(PaymentMethods.Cash, true);
        }
        private void btnPrintCardFinalPaymentNoReceipt_Click(object sender, System.EventArgs e)
        {
            frmConfirmCardPayment frm = new frmConfirmCardPayment();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrintFinalPayment(PaymentMethods.Card, false);
            }
        }

        private void btnPrintCardFinalPaymentWithReceipt_Click(object sender, System.EventArgs e)
        {
            frmConfirmCardPayment frm = new frmConfirmCardPayment();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrintFinalPayment(PaymentMethods.Card, true);
            }
        }

        private void btnPrintOnlineFinalPaymentNoReceipt_Click(object sender, System.EventArgs e)
        {
            frmConfirmOnlinePayment frm = new frmConfirmOnlinePayment();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrintFinalPayment(PaymentMethods.Online, false);
            }
        }
        private void btnPrintOnlineFinalPaymentWithReceipt_Click(object sender, System.EventArgs e)
        {
            frmConfirmOnlinePayment frm = new frmConfirmOnlinePayment();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrintFinalPayment(PaymentMethods.Online, true);
            }
        }

        #region SUB TOTAL PANEL HANDLERS
        private void KeyHandle(object sender, System.EventArgs e)
        {
            float pi = 0f;
            string pitext = this.lblPayedIn.Text;

            pi = float.Parse(lblPayedIn.Text, System.Globalization.NumberStyles.Any) * 10;
            pi = pi + float.Parse(((Button)sender).Text, System.Globalization.NumberStyles.Any) / 100;
            lblPayedIn.Text = pi.ToString("n");
        }
        private void btnSubTotalFullAmount_Click(object sender, EventArgs e)
        {
            float m = 0f;
            lblPayedIn.Text = bslayer.AttachedOrder.GetFullTotal().ToString("c");
            lblMoneyBack.Text = m.ToString();
        }

        private void btnSubTotalClear_Click(object sender, System.EventArgs e)
        {
            float m = 0f;
            lblPayedIn.Text = m.ToString();
            lblMoneyBack.Text = m.ToString();
        }

        private void KeyHandleBig(object sender, System.EventArgs e)
        {
            float pi = 0f;
            string pitext = this.lblPayedIn.Text;

            pi = float.Parse(pitext, System.Globalization.NumberStyles.Any) + float.Parse(((Button)sender).Text, System.Globalization.NumberStyles.Any);
            lblPayedIn.Text = pi.ToString("c");
        }
        private void btnHideSubTotal_Click(object sender, System.EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                bslayer.AttachedOrder.MoneyPaid = 0f;

            ArrangeSubTotalPanel(false);
        }

        private void btnSubTotalCash_Click(object sender, EventArgs e)
        {
            if (EnsureSubTotalValuesCorrect())
            {
                ArrangeSubTotalPanel(false);
                OrderScreen.DisplayChangeGiven();
                PrintFinalPayment(PaymentMethods.Cash, false);
            }
        }
        private void btnSubTotalCashWR_Click(object sender, EventArgs e)
        {
            if (EnsureSubTotalValuesCorrect())
            {
                ArrangeSubTotalPanel(false);
                OrderScreen.DisplayChangeGiven();
                PrintFinalPayment(PaymentMethods.Cash, true);
            }
        }

        private void btnSubTotalCard_Click(object sender, EventArgs e)
        {
            if (EnsureSubTotalValuesCorrect())
            {
                ArrangeSubTotalPanel(false);
                PrintFinalPayment(PaymentMethods.Card, false);
            }
        }

        private void btnSubTotalCardWR_Click(object sender, EventArgs e)
        {
            if (EnsureSubTotalValuesCorrect())
            {
                ArrangeSubTotalPanel(false);
                PrintFinalPayment(PaymentMethods.Card, true);
            }
        }
        #region SUB TOTAL PANEL RELATED FUNCTIONS
        private void lblPayedIn_TextChanged(object sender, EventArgs e)
        {
            float ot = 0f;
            float pi = 0f;
            float mb = 0f;
            try
            {
                ot = float.Parse(this.lblOrderTotal.Text, System.Globalization.NumberStyles.Any);
            } catch
            {
                ot = 0f;
            }
            try
            {
                pi = float.Parse(this.lblPayedIn.Text, System.Globalization.NumberStyles.Any);
            } catch
            {
                pi = 0f;
            }
            mb = (ot - pi) * -1;

            lblMoneyBack.Text = mb.ToString("c");
        }
        private bool EnsureSubTotalValuesCorrect()
        {
            if (this.lblPayedIn.Text == "")
                return false;
            if (float.Parse(this.lblPayedIn.Text, System.Globalization.NumberStyles.Any) == 0)
                return false;

            if (float.Parse(this.lblMoneyBack.Text, System.Globalization.NumberStyles.Any) < 0)
                return false;

            bslayer.AttachedOrder.MoneyPaid = float.Parse(this.lblPayedIn.Text, System.Globalization.NumberStyles.Any);
            return true;
        }
        private void ArrangeSubTotalPanel(bool blnShow)
        {
            float m = 0f;
            lblPayedIn.Text = m.ToString();
            lblMoneyBack.Text = m.ToString();

            if (blnShow)
            {
                btnSubTotalCash.Visible = config.Payments_Can_Be_Made_By_Cash;
                btnSubTotalCashWR.Visible = config.Payments_Can_Be_Made_By_Cash;

                //btnSubTotalCard.Visible = config.Payments_Can_Be_Made_By_Card;
                //btnSubTotalCardWR.Visible = config.Payments_Can_Be_Made_By_Card;

                pnlSubTotal.BringToFront();
                OrderScreen.SendToBack();
            } else
            {
                pnlSubTotal.SendToBack();
                OrderScreen.BringToFront();
            }

            pnlMoneyActions.Enabled = !blnShow;

        }
        #endregion
        #endregion

        #endregion

        #region ORDER SCREEN HANDLERS
        private void OrderScreen_Click(object sender, System.EventArgs e)
        {
            if (OrderScreen.HasSelection())
            {
                OrderItem oi = bslayer.AttachedOrder.items.Where(x => x.IID == OrderScreen.SelectedItemIID).FirstOrDefault();
                if (oi == null)
                    return;

                string EntityIID = oi.EntityIID;
                for (int i = 0; i < OUI.Panels.Count; i++)
                {
                    UPEntity ui = OUI.Panels[i];
                    if (ui.IID == EntityIID)
                    {

                        OUI.SelectedIndex = i;
                        AttachPanel(OUI.SelectedPanel);

                        ui.OrderGroupIID = oi.OrderGroupIID;

                    }
                }
            }
        }
        private void OrderScreen_DisplayOccured()
        {
            if (bslayer.AttachedOrder == null)
                HandleActionPanelView(ViewTypes.UnloadedOrderView);
            else
            {
                if (bslayer.AttachedOrder.Status == StatusFlags.PENDING && config.Hold_Order_Auto_Close)
                {
                    TickCounterForHoldOrderToClose = 0;
                }
                HandleActionPanelView(OrderTypeToViewType(bslayer.AttachedOrder.OrderType));

            }
        }
        #region SPLIT HANDLERS
        private void OrderScreen_SplitStarting()
        {
            OrderTypes currentlySplittingOrderType = bslayer.AttachedOrder.OrderType;
            DoHolding(bslayer.AttachedOrder.Reference, false);

            switch (currentlySplittingOrderType)
            {
                case OrderTypes.DirectSale:
                    cmdDirectSale_Click(null, null);
                    break;
                case OrderTypes.InHouse:
                    CreateAndLoadInHouseOrder();
                    break;
            }

            tmrHoldingOrders_Tick(null, null);
        }

        private void OrderScreen_SplitEnding()
        {
            UnloadOrder();
        }

        private void OrderScreen_SplitContinuing()
        {
            if (bslayer.AttachedOrder == null)
                cmdDirectSale_Click(null, null);

            tmrHoldingOrders_Tick(null, null);
        }
        #endregion

        private void OrderScreen_TopItemDeleted()
        {
            if (bslayer.AttachedOrder != null)
                EnsureCompulsoryExtras();
        }
        private void OrderScreen_ZeroItemsLeft()
        {
            if (bslayer.AttachedOrder != null)
            {
                foreach (UPEntity upe in OUI.Panels)
                    upe.Reset();
                bslayer.DeleteRelatedKitchenOrderForceFully(bslayer.AttachedOrder.IID);
                bslayer.SetKitchenModified();
                UnloadOrder();
            }
        }
        #endregion

        #region PENDING PANEL HANDLERS
        private async void LoadPendingOrders()
        {
            if (blnLoadingHoldingOrders || bslayer.AttachedOrder != null)
                return;
            blnLoadingHoldingOrders = true;
            pnlPendingOrders.Controls.Clear();

            Font btnPriceFont = new Font("Arial", config.Hold_Button_Price_Font_Size, FontStyle.Bold);

            List<OrdersView> porders = await repoOrder.GetOrdersView();

            List<OrdersView> pendingOrders = (await repoOrder.GetOrdersView())
                .Where(x => x.Payment == PaymentMethods.Unknown && x.Status == StatusFlags.PENDING && x.SessionIID == bslayer.shop.CurrentSessionIID).ToList();

            //DataTable dt = bslayer.GetDataTable("select IID from OrdersView Where payment = 0 and Status = " + (int)StatusFlags.PENDING + " and SessionIID = '" + bslayer.GetCurrentSessionIID() + "'");

            foreach (var porder in pendingOrders)
            {
                Order order = await repoOrder.Get(porder.IID); // bslayer.GetOrder(dt.Rows[i]["IID"].ToString());
                ctlHoldButtonExtendable btn;
                if (Hold_Order_Display_Summary)
                {
                    btn = new ctlHoldButtonExtendable(config.Hold_Button_Maximum_Extended_Width,
                        config.Hold_Button_Maximum_Extended_Height);
                    btn.ItemsText = order.GetAllOrderItemsText(false);

                } else
                {
                    btn = new ctlHoldButtonExtendable(config.Hold_Button_Maximum_Shrunk_Width,
                        config.Hold_Button_Maximum_Shrunk_Height);

                }
                btn.Tag = order;


                double OrderFullTotal = order.GetFullTotal();
                btn.Text = OrderFullTotal.ToString("n2");
                btn.PriceText = OrderFullTotal.ToString("n2");


                try
                {
                    Color paperClipColour = Color.FromName(order.Reference);
                    switch (order.Reference)
                    {
                        case "Yellow":
                            btn.ControlBackColor = btn.BackColor = Color.Yellow;
                            break;
                        case "Blue":
                            btn.ControlBackColor = btn.BackColor = Color.DeepSkyBlue;
                            break;
                        case "Green":
                            btn.ControlBackColor = btn.BackColor = Color.Lime;
                            break;
                        case "Orange":
                            btn.ControlBackColor = btn.BackColor = Color.Orange;
                            break;
                        case "Pink":
                            btn.ControlBackColor = btn.BackColor = Color.Fuchsia;
                            break;
                        default:
                            btn.ControlBackColor = btn.BackColor = Color.White;
                            break;
                    }
                } catch (Exception ex)
                {
                    btn.ControlBackColor = btn.BackColor = Color.Gray;
                    bslayer.SaveDebug("LoadingPendingOrders " + ex.Message);
                }

                btn.PriceTextFont = btnPriceFont;
                btn.BackgroundImage = Properties.Resources.shadow;
                btn.BackgroundImageLayout = ImageLayout.Stretch;



                btn.ButtonClick += new EventHandler(pendingOrder_Click);
                pnlPendingOrders.Controls.Add(btn);
            }


            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    Order order = await bslayer.GetOrder(dt.Rows[i]["IID"].ToString());
            //    ctlHoldButtonExtendable btn;
            //    if (Hold_Order_Display_Summary)
            //    {
            //        btn = new ctlHoldButtonExtendable(config.Hold_Button_Maximum_Extended_Width,
            //            config.Hold_Button_Maximum_Extended_Height);
            //        btn.ItemsText = order.GetAllOrderItemsText(false);

            //    } else
            //    {
            //        btn = new ctlHoldButtonExtendable(config.Hold_Button_Maximum_Shrunk_Width,
            //            config.Hold_Button_Maximum_Shrunk_Height);

            //    }
            //    btn.Tag = order;


            //    double OrderFullTotal = order.GetFullTotal();
            //    btn.Text = OrderFullTotal.ToString("n2");
            //    btn.PriceText = OrderFullTotal.ToString("n2");


            //    try
            //    {
            //        Color paperClipColour = Color.FromName(order.Reference);
            //        switch (order.Reference)
            //        {
            //            case "Yellow":
            //                btn.ControlBackColor = btn.BackColor = Color.Yellow;
            //                break;
            //            case "Blue":
            //                btn.ControlBackColor = btn.BackColor = Color.DeepSkyBlue;
            //                break;
            //            case "Green":
            //                btn.ControlBackColor = btn.BackColor = Color.Lime;
            //                break;
            //            case "Orange":
            //                btn.ControlBackColor = btn.BackColor = Color.Orange;
            //                break;
            //            case "Pink":
            //                btn.ControlBackColor = btn.BackColor = Color.Fuchsia;
            //                break;
            //            default:
            //                btn.ControlBackColor = btn.BackColor = Color.White;
            //                break;
            //        }
            //    } catch (Exception ex)
            //    {
            //        btn.ControlBackColor = btn.BackColor = Color.Gray;
            //        bslayer.SaveDebug("LoadingPendingOrders " + ex.Message);
            //    }

            //    btn.PriceTextFont = btnPriceFont;
            //    btn.BackgroundImage = Properties.Resources.shadow;
            //    btn.BackgroundImageLayout = ImageLayout.Stretch;

            //    if (order.Buzzer == "buzz")
            //    {
            //        // btn.BackColor = Color.Magenta;
            //    } else if (order.Buzzer == "fuzz")
            //    {
            //        // btn.BackColor = Color.Yellow;
            //    } else
            //    {
            //        //btn.BackColor = Color.Cyan;
            //    }

            //    btn.ButtonClick += new EventHandler(pendingOrder_Click);
            //    pnlPendingOrders.Controls.Add(btn);
            //}

            blnLoadingHoldingOrders = false;
        }

        private async void pendingOrder_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
                return;
            btnHoldOrder_Click(null, null);

            Order order;
            ctlHoldButtonExtendable btn = (sender as ctlHoldButtonExtendable);
            order = await bslayer.GetOrder((btn.Tag as Order).IID);
            btn.Tag = order;


            bslayer.AttachedOrder = order;

            //12345
            if (config.Hold_Order_Print_in_Kitchen || config.Hold_Order_Display_in_Kitchen)
            {
                bslayer.SetKitchenOrderModifiedStateForAttachedOrder(true);
            }

            LoadAttachedOrder();
            OrderScreen.SplitStatus = SplittingStatus.Normal;

            if (config.Hold_Order_Auto_Close)
            {
                TickCounterForHoldOrderToClose = 0;
            }
            tmrHoldOrderAutoClose.Enabled = config.Hold_Order_Auto_Close;
        }

        private int TickCounterForHoldOrderToClose;
        private void tmrHoldOrderAutoClose_Tick(object sender, EventArgs e)
        {
            if (TickCounterForHoldOrderToClose > config.Hold_Order_Auto_Close_Seconds)
            {
                if (bslayer.AttachedOrder?.Status == StatusFlags.PENDING)
                {
                    UnloadOrder();
                    TickCounterForHoldOrderToClose = 0;
                    tmrHoldOrderAutoClose.Enabled = false;
                    return;
                }

            }
            TickCounterForHoldOrderToClose++;
        }

        private void tmrHoldingOrders_Tick(object sender, EventArgs e)
        {
            if (blnLoadingHoldingOrders)
                return;
            else
            {
                try
                {
                    DateTime theNewKitchenModified = bslayer.GetKitchenModified();

                    if (theNewKitchenModified > KitchenModified)
                    {
                        KitchenModified = theNewKitchenModified;
                        LoadPendingOrders();
                    }
                } catch
                {
                }
            }
        }

        private async void DoHolding(string ColorName, bool blnPrint)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
            {
                if (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED ||
                    bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED)
                {
                    if (blnPrint)
                        bslayer.PrintReceipt(bslayer.AttachedOrder.IID, await bslayer.GetDefaultReceiptPrinter(), 1);
                    UnloadOrder();
                    return;
                }


                if (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale)
                {
                    PrepDialogReturnTypes prepDialogResult = PrepDialogReturnTypes.Hold;
                    try
                    {

                        bslayer.AttachedOrder.Reference = ColorName;

                        //This is where we create kitchen order
                        if ((config.Hold_Order_Display_in_Kitchen || config.Hold_Order_Print_in_Kitchen) && (OrderScreen.SplitStatus != SplittingStatus.Splitting))
                        {
                            prepDialogResult = await HandleKitchenOrderForDirectSale();
                            if (prepDialogResult == PrepDialogReturnTypes.Cancel)
                                return;
                        }

                    } catch
                    {
                    }

                    //This section is to ensure Holded order is splitted and will be hold again 
                    //That means : 3 item holded order can become 2 item holded and 1 item holded 2 different order
                    if (OrderScreen.SplitStatus == SplittingStatus.Splitting && OrderScreen.OrderToSplit.Status == StatusFlags.PENDING && !blnPrint)
                        prepDialogResult = PrepDialogReturnTypes.Hold;
                    if (OrderScreen.SplitStatus == SplittingStatus.Splitting && OrderScreen.OrderToSplit.Status == StatusFlags.PENDING && blnPrint)
                        prepDialogResult = PrepDialogReturnTypes.HoldAndPrint;

                    switch (prepDialogResult)
                    {
                        case PrepDialogReturnTypes.Hold:
                            //case PrepDialogReturnTypes.HoldNotPaid:
                            bslayer.AttachedOrder.Status = StatusFlags.PENDING;
                            break;
                        case PrepDialogReturnTypes.HoldAndPrint:
                            bslayer.AttachedOrder.Status = StatusFlags.PENDING;
                            blnPrint = true;
                            break;
                        case PrepDialogReturnTypes.Cash:
                            bslayer.AttachedOrder.Status = StatusFlags.COMPLETED;
                            bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                            break;
                        case PrepDialogReturnTypes.CashAndPrint:
                            bslayer.AttachedOrder.Status = StatusFlags.COMPLETED;
                            bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                            blnPrint = true;
                            break;
                    }

                }

                if (bslayer.AttachedOrder.HasMultipleOrderGroupIID())
                    bslayer.AttachedOrder.ShrinkOrder();

                if (blnPrint)
                {
                    //bslayer.SetKitchenOrderModifiedStateForAttachedOrder(false);
                    this.CompleteAttachedOrder(1, false, true, false);
                } else
                {
                    if (blnAlreadyHolding)
                    {
                        OrderScreen.FinaliseSplit();
                        blnAlreadyHolding = false;
                    }
                    UnloadOrder();
                }
                if (!config.Hold_Order_Available)
                    tmrHoldingOrders_Tick(null, null);
            }
        }


        private async Task<PrepDialogReturnTypes> HandleKitchenOrderForDirectSale()
        {
            PrepDialogReturnTypes prepResult = PrepDialogReturnTypes.Hold;

            Order order = bslayer.AttachedOrder.GetOrderWithKitchenableItems();
            if (order.items.Count == 0)
                bslayer.DeleteKitchenOrdersForOrder(bslayer.AttachedOrder.IID);
            else
            {
                KitchenOrder korder = null;
                prepResult = await bslayer.CreateKitchenOrderForOrder(order, korder);
                if (prepResult == PrepDialogReturnTypes.Cancel)
                    return PrepDialogReturnTypes.Cancel;
            }

            if (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale)
                bslayer.AttachedOrder.ShrinkOrder();

            return prepResult;
        }

        #endregion


        public void ShowAsSubWindow()
        {
            mnuLock.Visible = mnuOptions.Visible = false;
        }

        private async void btnPrintStockUsageReport_Click(object sender, EventArgs e)
        {
            trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
            if (fsp.ShowDialog() == DialogResult.OK)
            {
                bslayer.PrintStockUsage(await bslayer.GetPrinterForClient(fsp.ReturnValue));
            }
        }

        int screenLockCounter = 0;
        private void tmrScreenSaverTrigger_Tick(object sender, EventArgs e)
        {
            if (this.IsMdiChild)
            {
                if (this.ParentForm.ActiveMdiChild == this)
                {

                } else
                {
                    //form active mdi child bile degil
                    screenLockCounter = 0;
                    return;
                }
            } else
            {
                if (Form.ActiveForm != this)
                {
                    screenLockCounter = 0;
                    return;
                }
            }
            if (config.Screen_Lock_Method != ScreenLockTypes.None)
            {
                if (bslayer.AttachedOrder == null)
                    screenLockCounter++;
                else
                    screenLockCounter = 0;

                if (config.Screen_Lock_Method == ScreenLockTypes.ScreenSaverLock)
                {


                    if (screenLockCounter >= config.Seconds_Before_ScreenLock)
                    {
                        //screensaver directory doesnt' exist disable this functionality
                        if (!Directory.Exists(config.Screen_Saver_Image_Folder))
                        {
                            //this.Close();
                            tmrScreenSaverTrigger.Enabled = false;
                            return;
                        }

                        tmrScreenSaverTrigger.Enabled = false;
                        screenLockCounter = 0;
                        frmScreenSaver frm = ActivatorUtilities.CreateInstance<frmScreenSaver>(sp);
                        frm.ShowDialog();
                        tmrScreenSaverTrigger.Enabled = true;
                    }
                } else if (config.Screen_Lock_Method == ScreenLockTypes.WindowsScreenSaverLock)
                {
                    if (screenLockCounter >= config.Seconds_Before_ScreenLock)
                    {
                        DRUF.TurnOnSS();
                        tmrScreenSaverTrigger.Enabled = false;
                        screenLockCounter = 0;
                    }

                } else if (config.Screen_Lock_Method == ScreenLockTypes.PinLock)
                {
                    if (screenLockCounter >= config.Seconds_Before_ScreenLock)
                    {
                        cmdLock_Click(null, null);
                        tmrScreenSaverTrigger.Enabled = false;
                        screenLockCounter = 0;
                    }
                } else
                {

                }
            }
        }

        /// <summary>
        /// Resets screen lock counter and activates screen lock timer if any kind of screen lock is required for this terminal
        /// </summary>
        private void ResetScreenLock()
        {
            if (config.Screen_Lock_Method == ScreenLockTypes.None)
            {
                //Screen Lock not required

                tmrScreenSaverTrigger.Enabled = false;
            } else
            {
                if (blnLockable)
                    tmrScreenSaverTrigger.Enabled = true;
            }
            screenLockCounter = 0;
        }

        private void btnResetKitchenOrders_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
            {
                bslayer.DeleteRelatedKitchenOrderForceFully(bslayer.AttachedOrder.IID);
                bslayer.SetKitchenModified();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplierPurchaseList_Click(object sender, EventArgs e)
        {
            if (mnuSupplierPurchaseList.DropDownItems.Count > 0)
            {
                //Load suppliers
                List<string> theList = bslayer.GetSupplierIIDListWhichHasOrderableStockItems();


                foreach (ToolStripMenuItem item in mnuSupplierPurchaseList.DropDownItems)
                {
                    if (theList.Find(x => x == item.Tag.ToString()) != null)
                        item.Image = global::DTRMNS.Properties.Resources.trolly48;
                    else
                        item.Image = null; // global::DTRMNS.Properties.Resources.happy2_48;
                }

            }
        }

        private async Task LoadSupplierList()
        {
            mnuSupplierPurchaseList.DropDownItems.Clear();
            List<Supplier> suppliers = await bslayer.GetAllSuppliersAsList();
            foreach (var supp in suppliers)
            {
                ToolStripMenuItem btn = new ToolStripMenuItem();
                btn.Text = supp.SupplierName;
                btn.Tag = supp.IID;
                //btn.Image = global::DTRMNS.Properties.Resources.trolly48;
                btn.Click += btnSupplier_Click;

                mnuSupplierPurchaseList.DropDownItems.Add(btn);
            }
        }

        private async void btnSupplier_Click(object sender, EventArgs e)
        {
            trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
            if (fsp.ShowDialog() == DialogResult.OK)
            {
                ToolStripMenuItem btn = ((ToolStripMenuItem)sender);
                string supplierIID = btn.Tag.ToString();
                bslayer.PrintStockUsage(await bslayer.GetPrinterForClient(fsp.ReturnValue), await bslayer.GetStockItemUsageBySupplier(supplierIID, true), btn.Text);
            }

        }


        private void trmOrderPadMain_Shown(object sender, EventArgs e)
        {
            AdjustOrientation();
        }
        private void AdjustOrientation()
        {
            switch (config.OrderPad_Orientation)
            {
                case OrientationTypes.Portrait:
                    pnlDisplay.BringToFront();
                    pnlHolder.BringToFront();
                    break;
                case OrientationTypes.Landscape:
                    pnlDisplay.SendToBack();
                    break;
                default:
                    pnlDisplay.SendToBack();
                    break;
            }

        }

        private void btnPortraitMode_Click(object sender, EventArgs e)
        {
            pnlDisplay.BringToFront();
            pnlHolder.BringToFront();
        }

        private void btnOrientation_Click(object sender, EventArgs e)
        {
            if (config.OrderPad_Orientation == OrientationTypes.Landscape)
            {
                config.OrderPad_Orientation = OrientationTypes.Portrait;
            } else
            {
                config.OrderPad_Orientation = OrientationTypes.Landscape;
            }
            AdjustOrientation();
            UF.SaveConfig(config);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            switch (config.OrderPad_Orientation)
            {
                case OrientationTypes.Portrait:
                    this.mnuOrientation.Image = global::DTRMNS.Properties.Resources.ExpandWidth48;
                    break;
                case OrientationTypes.Landscape:
                    this.mnuOrientation.Image = global::DTRMNS.Properties.Resources.ExpandHeight48;

                    break;
                default:
                    this.mnuOrientation.Image = global::DTRMNS.Properties.Resources.ExpandHeight48;
                    break;
            }


        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            frmStockUsagePad frm = ActivatorUtilities.CreateInstance<frmStockUsagePad>(sp);
            if (this.ParentForm == null)
                frm.ShowDialog();
            else
            {
                // frm.ParentForm = this.ParentForm;
                frm.MdiParent = this.ParentForm;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
            }
        }



        #region SCREEN SAVER FUNCTIONS
        private void trmOrderPadMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            screenLockCounter = 0;
        }


        private void trmOrderPadMain_MouseDown(object sender, MouseEventArgs e)
        {
            screenLockCounter = 0;
        }

        private void trmOrderPadMain_MouseMove(object sender, MouseEventArgs e)
        {
            //screenLockCounter = 0;
        }

        /// <summary>
        /// Notifies the main form that there is a mouse down event happenned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaptureMouseMove(object sender, MouseEventArgs e)
        {
            //Control control = (Control)sender;
            //Point screenPoint = control.PointToScreen(new Point(e.X, e.Y));
            //Point formPoint = PointToClient(screenPoint);
            //MouseEventArgs args = new MouseEventArgs(e.Button, e.Clicks,
            //    formPoint.X, formPoint.Y, e.Delta);
            //OnMouseMove(args);
            OnMouseMove(null);
        }
        private void CaptureMouseDown(object sender, MouseEventArgs e)
        {
            //Control control = (Control)sender;
            //Point screenPoint = control.PointToScreen(new Point(e.X, e.Y));
            //Point formPoint = PointToClient(screenPoint);
            //MouseEventArgs args = new MouseEventArgs(e.Button, e.Clicks,
            //    formPoint.X, formPoint.Y, e.Delta);
            //OnMouseDown(args);
            OnMouseDown(null);
        }
        #endregion


        private void pnlBonus_Click(object sender, EventArgs e)
        {
            pnlBonus.UpdateBonusDisplay();
        }

        public void ConfigChanged()
        {
            try
            {
                config = UF.GetConfig();
                pnlBonus.UpdateBonusDisplay();
            } catch
            {

            }
        }


        private void btnHold_Click(object sender, EventArgs e)
        {
            popHold.Show(btnHoldOrder, new Point(-2, (popHold.Height) * -1));
        }
        private void btnHoldAndPrint_Click(object sender, EventArgs e)
        {
            popHoldAndPrint.Show(btnHoldAndReceipt, new Point(-2, (popHoldAndPrint.Height) * -1));
        }

        private void mnuDebug_Click(object sender, EventArgs e)
        {
            frmDump frm = new frmDump(bslayer);
            frm.ShowDialog();
        }

        private void mnuShrinkOrderDisplay_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
            {
                bslayer.AttachedOrder.ShrinkOrder();
                OrderScreen.Display();
            }
            //config.Table_Orders_Always_Shrinked = !config.Table_Orders_Always_Shrinked;
            // OrderScreen.Display();
        }


        private void btnExpandShrinkHoldButtonDetails_Click(object sender, EventArgs e)
        {
            Hold_Order_Display_Summary = !Hold_Order_Display_Summary;
            // tmrHoldingOrders_Tick(null, null);            
            LoadPendingOrders();
        }

    }
}