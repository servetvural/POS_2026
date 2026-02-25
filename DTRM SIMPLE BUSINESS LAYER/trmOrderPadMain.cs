using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PosLibrary;
using System.IO;
using DTRMNS.Forms;


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

        public DTRMNS.DTRMSimpleBusiness bslayer;
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
        private ToolStripMenuItem mnuDump;
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
        private ToolStripMenuItem mnuReportArchive;
        private bool Hold_Order_Display_Summary;

        public trmOrderPadMain()
        {
            InitializeComponent();
        }
        public trmOrderPadMain(DTRMSimpleBusiness bslayer, Form Locker, bool blnLockable)
        {
            InitializeComponent();
            this.bslayer = bslayer;
            this.Locker = Locker;
            this.blnLockable = blnLockable;

            mnuLock.Enabled = blnLockable;



        }
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            //if (!bslayer.IsMenuExist(bslayer.config.ActiveMenuIID)) {
            //    MessageBox.Show("Create and/or Select Default Menu");                
            //}



            //if (bslayer.config.ActiveMenuIID == "") {
            //    frmMenuSelector frm = new frmMenuSelector(bslayer);
            //    if (frm.ShowDialog() == DialogResult.OK) {
            //        bslayer.config.ActiveMenuIID = frm.SelectedMenuIID;
            //        UF.SaveConfig(bslayer.config);
            //        bslayer.ActiveMenu = bslayer.GetActiveMenu(true, true);
            //    }

            //    //bslayer.config.ActiveMenuIID = bslayer.GetFirstMenuIID();
            //    //if (bslayer.config.ActiveMenuIID != "") {
            //    //    UF.SaveConfig(bslayer.config);
            //    //    bslayer.GetActiveMenu(false, true);
            //    //}
            //}



            //This only happens once            
            RefreshUserInterface();

            DoInitialThings();

            try
            {
                tmrHoldingOrders.Interval = (bslayer.config.Hold_Orders_Reload_Seconds * 1000);
            } catch
            {

            }
            //if (bslayer.config.ServiceAutoStart && bslayer.config.ServiceEnabled && bslayer.config.ServiceLocalPort > 2000 && bslayer.config.ServiceLocalPort < 49000 && this.Locker != null)
            //    StartHttpService();
            bslayer.maxHeight = this.Height;
            // LoadAndDisplayLogo();

            if (bslayer.config.Screen_Saver_Capture_Mouse_Down_Event ||
                bslayer.config.Screen_Saver_Capture_Mouse_Move_Event)
                RegisterMouseMoveOrDown(this);
        }


        private void RegisterMouseMoveOrDown(Control control)
        {
            if (bslayer.config.Screen_Saver_Capture_Mouse_Down_Event ||
                bslayer.config.Screen_Saver_Capture_Mouse_Move_Event)
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (bslayer.config.Screen_Saver_Capture_Mouse_Down_Event)
                        ctrl.MouseDown += CaptureMouseDown;

                    if (bslayer.config.Screen_Saver_Capture_Mouse_Move_Event)
                        ctrl.MouseMove += CaptureMouseMove;

                    RegisterMouseMoveOrDown(ctrl);
                }
            }
        }


        public void DoInitialThings()
        {
            //This can be called for every login action
            mnuOptions.Visible = bslayer.LoggedUser.IsSuperUserOrMore();
            mnuReprintReport.Visible = mnuReloadMenu.Visible   = mnuSupervisorReport.Visible = bslayer.LoggedUser.IsManagerOrMore();

            if (bslayer.config.Attached_Cash_Drawer_Type == CashDrawerTypes.None)
                btnDone.Dock = DockStyle.Fill;


            //This function already calls loadpending orders
            UnloadOrder();

            tmrHoldingOrders.Enabled = bslayer.config.Hold_Order_Available;

            pnlDisplay.Width = bslayer.config.DisplayWidth;
            OrderScreen.SplitDisplayHeight = bslayer.config.SplitDisplayHeight;




        }
        public void RefreshUserInterface()
        {
            try
            {
                if (OrderScreen.bslayer == null)
                    OrderScreen.AttachBusinessLayer(bslayer);
                LoadUserInterface();
                LoadViewBars();
                LoadSupplierList();
                //LoadMenuList();
                if (bslayer.config.Display_Session_Bonus)
                    LoadBonusSchemes();


                #region Adjust individual hold button height
                foreach (ToolStripMenuItem item in popHold.Items)
                {
                    item.Height = bslayer.config.HoldButtonItemsHeight;
                }
                popHold.Height = bslayer.config.HoldButtonItemsHeight * 5 + 5;

                foreach (ToolStripMenuItem item in popHoldAndPrint.Items)
                {
                    item.Height = bslayer.config.HoldButtonItemsHeight;
                }
                popHoldAndPrint.Height = bslayer.config.HoldButtonItemsHeight * 5 + 5;
                #endregion

                #region Money Panel and Panel Button Settings
                pnlMoneyActions.Height = bslayer.config.MoneyActionPanelHeight;




                //now we know how many buttons on first column
                //List<Button> col_1_btns = new List<Button>();
                //if (bslayer.config.Table_Orders_Allowed)
                //    col_1_btns.Add(btnDone);
                //if (bslayer.config.Cash_Drawer_Void_Open_Allowed)
                //    col_1_btns.Add(btnCashDrawer);
                //if (bslayer.config.Sub_Total_Panel_Visible)
                //    col_1_btns.Add(btnSubTotal);
                //if (bslayer.config.Print_Invoice_Button_Visible)
                //    col_1_btns.Add(btnPrint);

                //int firstRowSpan = 12 / col_1_btns.Count;
                //for (int i = 0; i < col_1_btns.Count; i++) {
                //    pnlMoneyActions.SetRow(col_1_btns[i], i);
                //    pnlMoneyActions.SetRowSpan(col_1_btns[i], firstRowSpan);
                //}



                pnlMoneyActions.SetRow(btnDone, bslayer.config.DoneButtonRow);
                pnlMoneyActions.SetRowSpan(btnDone, bslayer.config.DoneButtonRowSpan);

                pnlMoneyActions.SetRow(btnCashDrawer, bslayer.config.CashDrawerButtonRow);
                pnlMoneyActions.SetRowSpan(btnCashDrawer, bslayer.config.CashDrawerButtonRowSpan);

                //pnlMoneyActions.SetRow(btnSubTotal, bslayer.config.SubTotalButtonRow);
                //pnlMoneyActions.SetRowSpan(btnSubTotal, bslayer.config.SubTotalButtonRowSpan);

                pnlMoneyActions.SetRow(btnPrint, bslayer.config.PrintButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrint, bslayer.config.PrintButtonRowSpan);



                pnlMoneyActions.SetRow(btnHoldOrder, bslayer.config.HoldOrderButtonRow);
                pnlMoneyActions.SetRowSpan(btnHoldOrder, bslayer.config.HoldOrderButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCashFinalPayment, bslayer.config.CashButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCashFinalPayment, bslayer.config.CashButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCashFinalPayment, bslayer.config.CashButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCashFinalPayment, bslayer.config.CashButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCardFinalPayment, bslayer.config.CardButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCardFinalPayment, bslayer.config.CardButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCardFinalPayment, bslayer.config.CardButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCardFinalPayment, bslayer.config.CardButtonRowSpan);



                pnlMoneyActions.SetRow(btnHoldAndReceipt, bslayer.config.HoldAndPrintOrderButtonRow);
                pnlMoneyActions.SetRowSpan(btnHoldAndReceipt, bslayer.config.HoldAndPrintOrderButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCashFinalPaymentWithReceipt, bslayer.config.CashAndPrintButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCashFinalPaymentWithReceipt, bslayer.config.CashAndPrintButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCashFinalPaymentWithReceipt, bslayer.config.CashAndPrintButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCashFinalPaymentWithReceipt, bslayer.config.CashAndPrintButtonRowSpan);

                pnlMoneyActions.SetColumn(btnPrintCardFinalPaymentWithReceipt, bslayer.config.CardAndPrintButtonColumn);
                pnlMoneyActions.SetColumnSpan(btnPrintCardFinalPaymentWithReceipt, bslayer.config.CardAndPrintButtonColumnSpan);
                pnlMoneyActions.SetRow(btnPrintCardFinalPaymentWithReceipt, bslayer.config.CardAndPrintButtonRow);
                pnlMoneyActions.SetRowSpan(btnPrintCardFinalPaymentWithReceipt, bslayer.config.CardAndPrintButtonRowSpan);
                #endregion


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuChangeMenu_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            frmMenuSelector frm = new frmMenuSelector(bslayer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bslayer.config.ActiveMenuIID = frm.SelectedMenuIID;
                UF.SaveConfig(bslayer.config);
                bslayer.ActiveMenu = bslayer.GetActiveMenu(true, true);
                LoadUserInterface();
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

        private void MenuSelect_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            string menuIID = btn.Tag.ToString();

            bslayer.config.ActiveMenuIID = menuIID;

            UF.SaveConfig(bslayer.config);
            bslayer.ActiveMenu = bslayer.GetActiveMenu(true, true);
            LoadUserInterface();
            //RefreshUserInterface();
        }

        private void LoadViewBars()
        {
            List<Distribution> theList = bslayer.GetDistributionList(bslayer.config.ActiveMenuIID);
            foreach (Distribution gt in theList)
            {
                ToolStripMenuItem btn = new ToolStripMenuItem();
                btn.Image = global::DTRMNS.Properties.Resources.chef64;
                btn.Tag = gt.IID;
                btn.Text = gt.DistributionName;
                btn.Click += ViewBar_Click;
                mnuViewBars.DropDownItems.Add(btn);
            }
        }
        private void ViewBar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            string gIID = btn.Tag.ToString();

            frmKitchenSingleDisplay frm = new frmKitchenSingleDisplay(bslayer, gIID, true, true);
            frm.ShowDialog();

        }

        private void LoadBonusSchemes()
        {
            pnlBonus.Activate(bslayer);
            List<Bonus> theList = bslayer.GetAllBonusList();
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
        private void BonusScheme_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            string bonusIID = btn.Tag.ToString();

            bslayer.currentBonusScheme = bslayer.GetBonus(bonusIID);
            mnuSelectBonusPlan.Text = bslayer.currentBonusScheme.PlanName + " (or Change)";
            pnlBonus.UpdateBonusDisplay();

        }

        private void Lock()
        {
            if (blnLockable)
            {
                this.Hide();
                this.Enabled = false;
                //if (bslayer.config.Customer_Display_Type != CustomerDisplayTypes.NONE)
                //    bslayer.CDSendMessage("SYSTEM LOCKED", CDAreas.All);
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trmOrderPadMain));
            this.popHold = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHoldPink = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.popHoldAndPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHoldAndReceiptPink = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldAndReceiptBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldAndReceiptYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldAndReceiptGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoldAndReceiptOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStandardDisplay = new System.Windows.Forms.Panel();
            this.OrderScreen = new DTRMNS.OrderDisplay();
            this.pnlMoneyActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintOnlineFinalPaymentWithReceipt = new System.Windows.Forms.Button();
            this.btnPrintOnlineFinalPayment = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCashDrawer = new System.Windows.Forms.Button();
            this.btnPrintCardFinalPaymentWithReceipt = new System.Windows.Forms.Button();
            this.btnPrintCashFinalPaymentWithReceipt = new System.Windows.Forms.Button();
            this.btnPrintCardFinalPayment = new System.Windows.Forms.Button();
            this.btnPrintCashFinalPayment = new System.Windows.Forms.Button();
            this.btnHoldAndReceipt = new System.Windows.Forms.Button();
            this.btnHoldOrder = new System.Windows.Forms.Button();
            this.pnlBonus = new DTRMNS.Controls.ctlBonus();
            this.pnlSubTotal = new System.Windows.Forms.Panel();
            this.pnlSubMoneyActions = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubTotalCash = new System.Windows.Forms.Button();
            this.btnSubTotalFullAmount = new System.Windows.Forms.Button();
            this.btnSubTotalCashWR = new System.Windows.Forms.Button();
            this.btnHideSubTotal = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button89 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button86 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button95 = new System.Windows.Forms.Button();
            this.button94 = new System.Windows.Forms.Button();
            this.button93 = new System.Windows.Forms.Button();
            this.button107 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlcizgi = new System.Windows.Forms.Panel();
            this.lblPayedIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoneyBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdDirectSale = new System.Windows.Forms.Button();
            this.cmdTables = new System.Windows.Forms.Button();
            this.cmdTakeAway = new System.Windows.Forms.Button();
            this.cmdDelivery = new System.Windows.Forms.Button();
            this.mnuFunctions = new System.Windows.Forms.MenuStrip();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShrinkOrderDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKitchen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewBars = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintForKitchen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetKitchenOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSum = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectBonusPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReprintReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupervisorReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReloadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintAsInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDump = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrientation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawerCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShoppingList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplierPurchaseList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintStockUsageReport = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.btnExpandShrinkHoldButtonDetails = new System.Windows.Forms.Button();
            this.pnlOrderPad = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPendingOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrHoldingOrders = new System.Windows.Forms.Timer(this.components);
            this.pnlHolder = new System.Windows.Forms.Panel();
            this.tmrScreenSaverTrigger = new System.Windows.Forms.Timer(this.components);
            this.tmrHoldOrderAutoClose = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.popHold.SuspendLayout();
            this.popHoldAndPrint.SuspendLayout();
            this.pnlStandardDisplay.SuspendLayout();
            this.pnlMoneyActions.SuspendLayout();
            this.pnlSubTotal.SuspendLayout();
            this.pnlSubMoneyActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.mnuFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // popHold
            // 
            this.popHold.AutoSize = false;
            this.popHold.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHoldPink,
            this.btnHoldBlue,
            this.btnHoldYellow,
            this.btnHoldGreen,
            this.btnHoldOrange});
            this.popHold.Name = "popHold";
            this.popHold.Size = new System.Drawing.Size(100, 494);
            // 
            // btnHoldPink
            // 
            this.btnHoldPink.AutoSize = false;
            this.btnHoldPink.BackColor = System.Drawing.Color.Black;
            this.btnHoldPink.BackgroundImage = global::DTRMNS.Properties.Resources.PClip64;
            this.btnHoldPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldPink.Name = "btnHoldPink";
            this.btnHoldPink.Size = new System.Drawing.Size(98, 98);
            this.btnHoldPink.Tag = "Pink";
            this.btnHoldPink.Click += new System.EventHandler(this.btnHoldOrder_Click);
            // 
            // btnHoldBlue
            // 
            this.btnHoldBlue.AutoSize = false;
            this.btnHoldBlue.BackColor = System.Drawing.Color.Black;
            this.btnHoldBlue.BackgroundImage = global::DTRMNS.Properties.Resources.PClipBlue64;
            this.btnHoldBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldBlue.Name = "btnHoldBlue";
            this.btnHoldBlue.Size = new System.Drawing.Size(98, 98);
            this.btnHoldBlue.Tag = "Blue";
            this.btnHoldBlue.Click += new System.EventHandler(this.btnHoldOrder_Click);
            // 
            // btnHoldYellow
            // 
            this.btnHoldYellow.AutoSize = false;
            this.btnHoldYellow.BackColor = System.Drawing.Color.Black;
            this.btnHoldYellow.BackgroundImage = global::DTRMNS.Properties.Resources.PClipYellow64;
            this.btnHoldYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldYellow.Name = "btnHoldYellow";
            this.btnHoldYellow.Size = new System.Drawing.Size(98, 98);
            this.btnHoldYellow.Tag = "Yellow";
            this.btnHoldYellow.Click += new System.EventHandler(this.btnHoldOrder_Click);
            // 
            // btnHoldGreen
            // 
            this.btnHoldGreen.AutoSize = false;
            this.btnHoldGreen.BackColor = System.Drawing.Color.Black;
            this.btnHoldGreen.BackgroundImage = global::DTRMNS.Properties.Resources.PClipGreen64;
            this.btnHoldGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldGreen.Name = "btnHoldGreen";
            this.btnHoldGreen.Size = new System.Drawing.Size(98, 98);
            this.btnHoldGreen.Tag = "Green";
            this.btnHoldGreen.Click += new System.EventHandler(this.btnHoldOrder_Click);
            // 
            // btnHoldOrange
            // 
            this.btnHoldOrange.AutoSize = false;
            this.btnHoldOrange.BackColor = System.Drawing.Color.Black;
            this.btnHoldOrange.BackgroundImage = global::DTRMNS.Properties.Resources.PClipOrange64;
            this.btnHoldOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldOrange.Name = "btnHoldOrange";
            this.btnHoldOrange.Size = new System.Drawing.Size(98, 98);
            this.btnHoldOrange.Tag = "Orange";
            this.btnHoldOrange.Click += new System.EventHandler(this.btnHoldOrder_Click);
            // 
            // popHoldAndPrint
            // 
            this.popHoldAndPrint.AutoSize = false;
            this.popHoldAndPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHoldAndReceiptPink,
            this.btnHoldAndReceiptBlue,
            this.btnHoldAndReceiptYellow,
            this.btnHoldAndReceiptGreen,
            this.btnHoldAndReceiptOrange});
            this.popHoldAndPrint.Name = "popHold";
            this.popHoldAndPrint.Size = new System.Drawing.Size(100, 494);
            // 
            // btnHoldAndReceiptPink
            // 
            this.btnHoldAndReceiptPink.AutoSize = false;
            this.btnHoldAndReceiptPink.BackColor = System.Drawing.Color.Black;
            this.btnHoldAndReceiptPink.BackgroundImage = global::DTRMNS.Properties.Resources.PClip64;
            this.btnHoldAndReceiptPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldAndReceiptPink.Image = ((System.Drawing.Image)(resources.GetObject("btnHoldAndReceiptPink.Image")));
            this.btnHoldAndReceiptPink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoldAndReceiptPink.Name = "btnHoldAndReceiptPink";
            this.btnHoldAndReceiptPink.Size = new System.Drawing.Size(98, 98);
            this.btnHoldAndReceiptPink.Tag = "Pink";
            this.btnHoldAndReceiptPink.Click += new System.EventHandler(this.btnHoldAndReceipt_Click);
            // 
            // btnHoldAndReceiptBlue
            // 
            this.btnHoldAndReceiptBlue.AutoSize = false;
            this.btnHoldAndReceiptBlue.BackColor = System.Drawing.Color.Black;
            this.btnHoldAndReceiptBlue.BackgroundImage = global::DTRMNS.Properties.Resources.PClipBlue64;
            this.btnHoldAndReceiptBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldAndReceiptBlue.Image = ((System.Drawing.Image)(resources.GetObject("btnHoldAndReceiptBlue.Image")));
            this.btnHoldAndReceiptBlue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoldAndReceiptBlue.Name = "btnHoldAndReceiptBlue";
            this.btnHoldAndReceiptBlue.Size = new System.Drawing.Size(98, 98);
            this.btnHoldAndReceiptBlue.Tag = "Blue";
            this.btnHoldAndReceiptBlue.Click += new System.EventHandler(this.btnHoldAndReceipt_Click);
            // 
            // btnHoldAndReceiptYellow
            // 
            this.btnHoldAndReceiptYellow.AutoSize = false;
            this.btnHoldAndReceiptYellow.BackColor = System.Drawing.Color.Black;
            this.btnHoldAndReceiptYellow.BackgroundImage = global::DTRMNS.Properties.Resources.PClipYellow64;
            this.btnHoldAndReceiptYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldAndReceiptYellow.Image = ((System.Drawing.Image)(resources.GetObject("btnHoldAndReceiptYellow.Image")));
            this.btnHoldAndReceiptYellow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoldAndReceiptYellow.Name = "btnHoldAndReceiptYellow";
            this.btnHoldAndReceiptYellow.Size = new System.Drawing.Size(98, 98);
            this.btnHoldAndReceiptYellow.Tag = "Yellow";
            this.btnHoldAndReceiptYellow.Click += new System.EventHandler(this.btnHoldAndReceipt_Click);
            // 
            // btnHoldAndReceiptGreen
            // 
            this.btnHoldAndReceiptGreen.AutoSize = false;
            this.btnHoldAndReceiptGreen.BackColor = System.Drawing.Color.Black;
            this.btnHoldAndReceiptGreen.BackgroundImage = global::DTRMNS.Properties.Resources.PClipGreen64;
            this.btnHoldAndReceiptGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldAndReceiptGreen.Image = ((System.Drawing.Image)(resources.GetObject("btnHoldAndReceiptGreen.Image")));
            this.btnHoldAndReceiptGreen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoldAndReceiptGreen.Name = "btnHoldAndReceiptGreen";
            this.btnHoldAndReceiptGreen.Size = new System.Drawing.Size(98, 98);
            this.btnHoldAndReceiptGreen.Tag = "Green";
            this.btnHoldAndReceiptGreen.Click += new System.EventHandler(this.btnHoldAndReceipt_Click);
            // 
            // btnHoldAndReceiptOrange
            // 
            this.btnHoldAndReceiptOrange.AutoSize = false;
            this.btnHoldAndReceiptOrange.BackColor = System.Drawing.Color.Black;
            this.btnHoldAndReceiptOrange.BackgroundImage = global::DTRMNS.Properties.Resources.PClipOrange64;
            this.btnHoldAndReceiptOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldAndReceiptOrange.Image = ((System.Drawing.Image)(resources.GetObject("btnHoldAndReceiptOrange.Image")));
            this.btnHoldAndReceiptOrange.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoldAndReceiptOrange.Name = "btnHoldAndReceiptOrange";
            this.btnHoldAndReceiptOrange.Size = new System.Drawing.Size(98, 98);
            this.btnHoldAndReceiptOrange.Tag = "Orange";
            this.btnHoldAndReceiptOrange.Click += new System.EventHandler(this.btnHoldAndReceipt_Click);
            // 
            // pnlStandardDisplay
            // 
            this.pnlStandardDisplay.BackColor = System.Drawing.Color.Maroon;
            this.pnlStandardDisplay.Controls.Add(this.OrderScreen);
            this.pnlStandardDisplay.Controls.Add(this.pnlMoneyActions);
            this.pnlStandardDisplay.Controls.Add(this.pnlBonus);
            this.pnlStandardDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStandardDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlStandardDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlStandardDisplay.Name = "pnlStandardDisplay";
            this.pnlStandardDisplay.Size = new System.Drawing.Size(314, 778);
            this.pnlStandardDisplay.TabIndex = 22;
            // 
            // OrderScreen
            // 
            this.OrderScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OrderScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderScreen.Location = new System.Drawing.Point(0, 22);
            this.OrderScreen.Name = "OrderScreen";
            this.OrderScreen.OrderToDisplay = null;
            this.OrderScreen.OrderToSplit = null;
            this.OrderScreen.Size = new System.Drawing.Size(314, 516);
            this.OrderScreen.SplitDisplayHeight = 315;
            this.OrderScreen.TabIndex = 20;
            this.OrderScreen.DisplayOccured += new DTRMNS.GenericFunctionCall(this.OrderScreen_DisplayOccured);
            this.OrderScreen.TopItemDeleted += new DTRMNS.GenericFunctionCall(this.OrderScreen_TopItemDeleted);
            this.OrderScreen.SplitStarting += new DTRMNS.GenericFunctionCall(this.OrderScreen_SplitStarting);
            this.OrderScreen.SplitContinuing += new DTRMNS.GenericFunctionCall(this.OrderScreen_SplitContinuing);
            this.OrderScreen.SplitEnding += new DTRMNS.GenericFunctionCall(this.OrderScreen_SplitEnding);
            this.OrderScreen.ZeroItemsLeft += new DTRMNS.GenericFunctionCall(this.OrderScreen_ZeroItemsLeft);
            this.OrderScreen.Click += new System.EventHandler(this.OrderScreen_Click);
            // 
            // pnlMoneyActions
            // 
            this.pnlMoneyActions.BackColor = System.Drawing.Color.Black;
            this.pnlMoneyActions.ColumnCount = 3;
            this.pnlMoneyActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMoneyActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMoneyActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlMoneyActions.Controls.Add(this.btnPrintOnlineFinalPaymentWithReceipt, 1, 10);
            this.pnlMoneyActions.Controls.Add(this.btnPrintOnlineFinalPayment, 0, 10);
            this.pnlMoneyActions.Controls.Add(this.btnPrint, 0, 8);
            this.pnlMoneyActions.Controls.Add(this.btnDone, 0, 0);
            this.pnlMoneyActions.Controls.Add(this.btnCashDrawer, 0, 4);
            this.pnlMoneyActions.Controls.Add(this.btnPrintCardFinalPaymentWithReceipt, 2, 8);
            this.pnlMoneyActions.Controls.Add(this.btnPrintCashFinalPaymentWithReceipt, 2, 4);
            this.pnlMoneyActions.Controls.Add(this.btnPrintCardFinalPayment, 1, 8);
            this.pnlMoneyActions.Controls.Add(this.btnPrintCashFinalPayment, 1, 4);
            this.pnlMoneyActions.Controls.Add(this.btnHoldAndReceipt, 2, 0);
            this.pnlMoneyActions.Controls.Add(this.btnHoldOrder, 1, 0);
            this.pnlMoneyActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMoneyActions.Location = new System.Drawing.Point(0, 538);
            this.pnlMoneyActions.MinimumSize = new System.Drawing.Size(300, 180);
            this.pnlMoneyActions.Name = "pnlMoneyActions";
            this.pnlMoneyActions.RowCount = 12;
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.pnlMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMoneyActions.Size = new System.Drawing.Size(314, 240);
            this.pnlMoneyActions.TabIndex = 22;
            // 
            // btnPrintOnlineFinalPaymentWithReceipt
            // 
            this.btnPrintOnlineFinalPaymentWithReceipt.AutoEllipsis = true;
            this.btnPrintOnlineFinalPaymentWithReceipt.BackColor = System.Drawing.Color.Black;
            this.btnPrintOnlineFinalPaymentWithReceipt.BackgroundImage = global::DTRMNS.Properties.Resources.web;
            this.btnPrintOnlineFinalPaymentWithReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintOnlineFinalPaymentWithReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintOnlineFinalPaymentWithReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintOnlineFinalPaymentWithReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOnlineFinalPaymentWithReceipt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintOnlineFinalPaymentWithReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintOnlineFinalPaymentWithReceipt.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrintOnlineFinalPaymentWithReceipt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPrintOnlineFinalPaymentWithReceipt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintOnlineFinalPaymentWithReceipt.Location = new System.Drawing.Point(211, 203);
            this.btnPrintOnlineFinalPaymentWithReceipt.Name = "btnPrintOnlineFinalPaymentWithReceipt";
            this.pnlMoneyActions.SetRowSpan(this.btnPrintOnlineFinalPaymentWithReceipt, 2);
            this.btnPrintOnlineFinalPaymentWithReceipt.Size = new System.Drawing.Size(100, 34);
            this.btnPrintOnlineFinalPaymentWithReceipt.TabIndex = 54;
            this.btnPrintOnlineFinalPaymentWithReceipt.TabStop = false;
            this.btnPrintOnlineFinalPaymentWithReceipt.UseVisualStyleBackColor = false;
            this.btnPrintOnlineFinalPaymentWithReceipt.Click += new System.EventHandler(this.btnPrintOnlineFinalPaymentWithReceipt_Click);
            // 
            // btnPrintOnlineFinalPayment
            // 
            this.btnPrintOnlineFinalPayment.AutoSize = true;
            this.btnPrintOnlineFinalPayment.BackColor = System.Drawing.Color.Black;
            this.btnPrintOnlineFinalPayment.BackgroundImage = global::DTRMNS.Properties.Resources.web;
            this.btnPrintOnlineFinalPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintOnlineFinalPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintOnlineFinalPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintOnlineFinalPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOnlineFinalPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintOnlineFinalPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintOnlineFinalPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintOnlineFinalPayment.Location = new System.Drawing.Point(107, 203);
            this.btnPrintOnlineFinalPayment.Name = "btnPrintOnlineFinalPayment";
            this.pnlMoneyActions.SetRowSpan(this.btnPrintOnlineFinalPayment, 2);
            this.btnPrintOnlineFinalPayment.Size = new System.Drawing.Size(98, 34);
            this.btnPrintOnlineFinalPayment.TabIndex = 53;
            this.btnPrintOnlineFinalPayment.TabStop = false;
            this.btnPrintOnlineFinalPayment.UseVisualStyleBackColor = false;
            this.btnPrintOnlineFinalPayment.Click += new System.EventHandler(this.btnPrintOnlineFinalPaymentNoReceipt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoEllipsis = true;
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrint.Location = new System.Drawing.Point(3, 163);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMoneyActions.SetRowSpan(this.btnPrint, 4);
            this.btnPrint.Size = new System.Drawing.Size(98, 74);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "\r\nPRINT";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDone
            // 
            this.btnDone.AutoEllipsis = true;
            this.btnDone.BackColor = System.Drawing.Color.Black;
            this.btnDone.BackgroundImage = global::DTRMNS.Properties.Resources.okay;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone.Location = new System.Drawing.Point(3, 3);
            this.btnDone.Name = "btnDone";
            this.pnlMoneyActions.SetRowSpan(this.btnDone, 4);
            this.btnDone.Size = new System.Drawing.Size(98, 74);
            this.btnDone.TabIndex = 23;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCashDrawer
            // 
            this.btnCashDrawer.AutoEllipsis = true;
            this.btnCashDrawer.BackColor = System.Drawing.Color.Black;
            this.btnCashDrawer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCashDrawer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCashDrawer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCashDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashDrawer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCashDrawer.ForeColor = System.Drawing.Color.White;
            this.btnCashDrawer.Image = global::DTRMNS.Properties.Resources.Lightning;
            this.btnCashDrawer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCashDrawer.Location = new System.Drawing.Point(3, 83);
            this.btnCashDrawer.Name = "btnCashDrawer";
            this.pnlMoneyActions.SetRowSpan(this.btnCashDrawer, 4);
            this.btnCashDrawer.Size = new System.Drawing.Size(98, 74);
            this.btnCashDrawer.TabIndex = 36;
            this.btnCashDrawer.Text = "CASH DRAWER";
            this.btnCashDrawer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashDrawer.UseVisualStyleBackColor = false;
            this.btnCashDrawer.Click += new System.EventHandler(this.btnFault_Click);
            // 
            // btnPrintCardFinalPaymentWithReceipt
            // 
            this.btnPrintCardFinalPaymentWithReceipt.AutoEllipsis = true;
            this.btnPrintCardFinalPaymentWithReceipt.BackColor = System.Drawing.Color.Black;
            this.btnPrintCardFinalPaymentWithReceipt.BackgroundImage = global::DTRMNS.Properties.Resources.pin64;
            this.btnPrintCardFinalPaymentWithReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintCardFinalPaymentWithReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintCardFinalPaymentWithReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintCardFinalPaymentWithReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCardFinalPaymentWithReceipt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintCardFinalPaymentWithReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintCardFinalPaymentWithReceipt.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrintCardFinalPaymentWithReceipt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPrintCardFinalPaymentWithReceipt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintCardFinalPaymentWithReceipt.Location = new System.Drawing.Point(211, 163);
            this.btnPrintCardFinalPaymentWithReceipt.Name = "btnPrintCardFinalPaymentWithReceipt";
            this.pnlMoneyActions.SetRowSpan(this.btnPrintCardFinalPaymentWithReceipt, 2);
            this.btnPrintCardFinalPaymentWithReceipt.Size = new System.Drawing.Size(100, 34);
            this.btnPrintCardFinalPaymentWithReceipt.TabIndex = 40;
            this.btnPrintCardFinalPaymentWithReceipt.TabStop = false;
            this.btnPrintCardFinalPaymentWithReceipt.UseVisualStyleBackColor = false;
            this.btnPrintCardFinalPaymentWithReceipt.Click += new System.EventHandler(this.btnPrintCardFinalPaymentWithReceipt_Click);
            // 
            // btnPrintCashFinalPaymentWithReceipt
            // 
            this.btnPrintCashFinalPaymentWithReceipt.AutoSize = true;
            this.btnPrintCashFinalPaymentWithReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintCashFinalPaymentWithReceipt.BackColor = System.Drawing.Color.Black;
            this.btnPrintCashFinalPaymentWithReceipt.BackgroundImage = global::DTRMNS.Properties.Resources.Euro;
            this.btnPrintCashFinalPaymentWithReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintCashFinalPaymentWithReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintCashFinalPaymentWithReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintCashFinalPaymentWithReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCashFinalPaymentWithReceipt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintCashFinalPaymentWithReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintCashFinalPaymentWithReceipt.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnPrintCashFinalPaymentWithReceipt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPrintCashFinalPaymentWithReceipt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintCashFinalPaymentWithReceipt.Location = new System.Drawing.Point(211, 83);
            this.btnPrintCashFinalPaymentWithReceipt.Name = "btnPrintCashFinalPaymentWithReceipt";
            this.pnlMoneyActions.SetRowSpan(this.btnPrintCashFinalPaymentWithReceipt, 4);
            this.btnPrintCashFinalPaymentWithReceipt.Size = new System.Drawing.Size(100, 74);
            this.btnPrintCashFinalPaymentWithReceipt.TabIndex = 34;
            this.btnPrintCashFinalPaymentWithReceipt.TabStop = false;
            this.btnPrintCashFinalPaymentWithReceipt.UseVisualStyleBackColor = false;
            this.btnPrintCashFinalPaymentWithReceipt.Click += new System.EventHandler(this.btnPrintCashFinalPaymentWithReceipt_Click);
            // 
            // btnPrintCardFinalPayment
            // 
            this.btnPrintCardFinalPayment.AutoSize = true;
            this.btnPrintCardFinalPayment.BackColor = System.Drawing.Color.Black;
            this.btnPrintCardFinalPayment.BackgroundImage = global::DTRMNS.Properties.Resources.pin64;
            this.btnPrintCardFinalPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintCardFinalPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintCardFinalPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintCardFinalPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCardFinalPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintCardFinalPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintCardFinalPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintCardFinalPayment.Location = new System.Drawing.Point(107, 163);
            this.btnPrintCardFinalPayment.Name = "btnPrintCardFinalPayment";
            this.pnlMoneyActions.SetRowSpan(this.btnPrintCardFinalPayment, 2);
            this.btnPrintCardFinalPayment.Size = new System.Drawing.Size(98, 34);
            this.btnPrintCardFinalPayment.TabIndex = 38;
            this.btnPrintCardFinalPayment.TabStop = false;
            this.btnPrintCardFinalPayment.UseVisualStyleBackColor = false;
            this.btnPrintCardFinalPayment.Click += new System.EventHandler(this.btnPrintCardFinalPaymentNoReceipt_Click);
            // 
            // btnPrintCashFinalPayment
            // 
            this.btnPrintCashFinalPayment.AutoSize = true;
            this.btnPrintCashFinalPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintCashFinalPayment.BackColor = System.Drawing.Color.Black;
            this.btnPrintCashFinalPayment.BackgroundImage = global::DTRMNS.Properties.Resources.Euro;
            this.btnPrintCashFinalPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintCashFinalPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintCashFinalPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintCashFinalPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCashFinalPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintCashFinalPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintCashFinalPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintCashFinalPayment.Location = new System.Drawing.Point(107, 83);
            this.btnPrintCashFinalPayment.Name = "btnPrintCashFinalPayment";
            this.pnlMoneyActions.SetRowSpan(this.btnPrintCashFinalPayment, 4);
            this.btnPrintCashFinalPayment.Size = new System.Drawing.Size(98, 74);
            this.btnPrintCashFinalPayment.TabIndex = 31;
            this.btnPrintCashFinalPayment.TabStop = false;
            this.btnPrintCashFinalPayment.UseVisualStyleBackColor = false;
            this.btnPrintCashFinalPayment.Click += new System.EventHandler(this.btnPrintCashFinalPaymentNoReceipt_Click);
            // 
            // btnHoldAndReceipt
            // 
            this.btnHoldAndReceipt.BackgroundImage = global::DTRMNS.Properties.Resources.PClip64;
            this.btnHoldAndReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldAndReceipt.ContextMenuStrip = this.popHoldAndPrint;
            this.btnHoldAndReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoldAndReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoldAndReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoldAndReceipt.ForeColor = System.Drawing.Color.White;
            this.btnHoldAndReceipt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHoldAndReceipt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHoldAndReceipt.Location = new System.Drawing.Point(211, 3);
            this.btnHoldAndReceipt.Name = "btnHoldAndReceipt";
            this.pnlMoneyActions.SetRowSpan(this.btnHoldAndReceipt, 4);
            this.btnHoldAndReceipt.Size = new System.Drawing.Size(100, 74);
            this.btnHoldAndReceipt.TabIndex = 52;
            this.btnHoldAndReceipt.Text = "HOLD PRINT";
            this.btnHoldAndReceipt.UseVisualStyleBackColor = true;
            this.btnHoldAndReceipt.Click += new System.EventHandler(this.btnHoldAndPrint_Click);
            // 
            // btnHoldOrder
            // 
            this.btnHoldOrder.BackgroundImage = global::DTRMNS.Properties.Resources.PClip64;
            this.btnHoldOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoldOrder.ContextMenuStrip = this.popHold;
            this.btnHoldOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoldOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoldOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoldOrder.ForeColor = System.Drawing.Color.White;
            this.btnHoldOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHoldOrder.Location = new System.Drawing.Point(107, 3);
            this.btnHoldOrder.Name = "btnHoldOrder";
            this.pnlMoneyActions.SetRowSpan(this.btnHoldOrder, 4);
            this.btnHoldOrder.Size = new System.Drawing.Size(98, 74);
            this.btnHoldOrder.TabIndex = 0;
            this.btnHoldOrder.Text = "HOLD";
            this.btnHoldOrder.UseVisualStyleBackColor = true;
            this.btnHoldOrder.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // pnlBonus
            // 
            this.pnlBonus.AutoSize = true;
            this.pnlBonus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBonus.BackColor = System.Drawing.Color.Black;
            this.pnlBonus.ControlBackColor = System.Drawing.Color.Black;
            this.pnlBonus.ControlFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlBonus.ControlForeColor = System.Drawing.Color.White;
            this.pnlBonus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBonus.EnableAutoUpdate = true;
            this.pnlBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlBonus.ForeColor = System.Drawing.Color.White;
            this.pnlBonus.Location = new System.Drawing.Point(0, 0);
            this.pnlBonus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBonus.MinimumSize = new System.Drawing.Size(222, 22);
            this.pnlBonus.Name = "pnlBonus";
            this.pnlBonus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlBonus.ProgressBarWidth = 217;
            this.pnlBonus.Size = new System.Drawing.Size(314, 22);
            this.pnlBonus.TabIndex = 21;
            this.pnlBonus.Visible = false;
            this.pnlBonus.Load += new System.EventHandler(this.pnlBonus_Load);
            this.pnlBonus.Click += new System.EventHandler(this.pnlBonus_Click);
            // 
            // pnlSubTotal
            // 
            this.pnlSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubTotal.Controls.Add(this.pnlSubMoneyActions);
            this.pnlSubTotal.Controls.Add(this.panel1);
            this.pnlSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubTotal.ForeColor = System.Drawing.Color.White;
            this.pnlSubTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlSubTotal.Name = "pnlSubTotal";
            this.pnlSubTotal.Size = new System.Drawing.Size(314, 778);
            this.pnlSubTotal.TabIndex = 21;
            // 
            // pnlSubMoneyActions
            // 
            this.pnlSubMoneyActions.ColumnCount = 3;
            this.pnlSubMoneyActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlSubMoneyActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlSubMoneyActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlSubMoneyActions.Controls.Add(this.button1, 2, 5);
            this.pnlSubMoneyActions.Controls.Add(this.btnSubTotalCash, 1, 6);
            this.pnlSubMoneyActions.Controls.Add(this.btnSubTotalFullAmount, 2, 3);
            this.pnlSubMoneyActions.Controls.Add(this.btnSubTotalCashWR, 2, 6);
            this.pnlSubMoneyActions.Controls.Add(this.btnHideSubTotal, 0, 6);
            this.pnlSubMoneyActions.Controls.Add(this.button61, 0, 0);
            this.pnlSubMoneyActions.Controls.Add(this.button89, 0, 1);
            this.pnlSubMoneyActions.Controls.Add(this.button58, 1, 0);
            this.pnlSubMoneyActions.Controls.Add(this.button12, 2, 4);
            this.pnlSubMoneyActions.Controls.Add(this.button6, 1, 5);
            this.pnlSubMoneyActions.Controls.Add(this.button3, 0, 5);
            this.pnlSubMoneyActions.Controls.Add(this.button5, 1, 4);
            this.pnlSubMoneyActions.Controls.Add(this.button57, 2, 0);
            this.pnlSubMoneyActions.Controls.Add(this.button86, 1, 1);
            this.pnlSubMoneyActions.Controls.Add(this.button75, 2, 1);
            this.pnlSubMoneyActions.Controls.Add(this.button4, 0, 4);
            this.pnlSubMoneyActions.Controls.Add(this.button95, 0, 2);
            this.pnlSubMoneyActions.Controls.Add(this.button94, 1, 2);
            this.pnlSubMoneyActions.Controls.Add(this.button93, 2, 2);
            this.pnlSubMoneyActions.Controls.Add(this.button107, 0, 3);
            this.pnlSubMoneyActions.Controls.Add(this.btnC, 1, 3);
            this.pnlSubMoneyActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubMoneyActions.Location = new System.Drawing.Point(0, 160);
            this.pnlSubMoneyActions.Name = "pnlSubMoneyActions";
            this.pnlSubMoneyActions.RowCount = 7;
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.pnlSubMoneyActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07693F));
            this.pnlSubMoneyActions.Size = new System.Drawing.Size(314, 618);
            this.pnlSubMoneyActions.TabIndex = 167;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(218, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 69);
            this.button1.TabIndex = 168;
            this.button1.Text = "100";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.KeyHandleBig);
            // 
            // btnSubTotalCash
            // 
            this.btnSubTotalCash.AutoEllipsis = true;
            this.btnSubTotalCash.BackColor = System.Drawing.Color.Black;
            this.btnSubTotalCash.BackgroundImage = global::DTRMNS.Properties.Resources.Euro;
            this.btnSubTotalCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubTotalCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubTotalCash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubTotalCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTotalCash.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubTotalCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubTotalCash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubTotalCash.Location = new System.Drawing.Point(109, 479);
            this.btnSubTotalCash.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubTotalCash.Name = "btnSubTotalCash";
            this.btnSubTotalCash.Size = new System.Drawing.Size(94, 134);
            this.btnSubTotalCash.TabIndex = 159;
            this.btnSubTotalCash.TabStop = false;
            this.btnSubTotalCash.UseVisualStyleBackColor = false;
            this.btnSubTotalCash.Click += new System.EventHandler(this.btnSubTotalCash_Click);
            // 
            // btnSubTotalFullAmount
            // 
            this.btnSubTotalFullAmount.AutoEllipsis = true;
            this.btnSubTotalFullAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubTotalFullAmount.BackgroundImage = global::DTRMNS.Properties.Resources.shadow;
            this.btnSubTotalFullAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubTotalFullAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubTotalFullAmount.FlatAppearance.BorderSize = 0;
            this.btnSubTotalFullAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTotalFullAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubTotalFullAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubTotalFullAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubTotalFullAmount.Location = new System.Drawing.Point(218, 242);
            this.btnSubTotalFullAmount.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSubTotalFullAmount.Name = "btnSubTotalFullAmount";
            this.btnSubTotalFullAmount.Size = new System.Drawing.Size(86, 69);
            this.btnSubTotalFullAmount.TabIndex = 164;
            this.btnSubTotalFullAmount.Text = "Full Amount";
            this.btnSubTotalFullAmount.UseVisualStyleBackColor = false;
            this.btnSubTotalFullAmount.Click += new System.EventHandler(this.btnSubTotalFullAmount_Click);
            // 
            // btnSubTotalCashWR
            // 
            this.btnSubTotalCashWR.AutoEllipsis = true;
            this.btnSubTotalCashWR.BackColor = System.Drawing.Color.Black;
            this.btnSubTotalCashWR.BackgroundImage = global::DTRMNS.Properties.Resources.Euro;
            this.btnSubTotalCashWR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubTotalCashWR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubTotalCashWR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubTotalCashWR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTotalCashWR.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubTotalCashWR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubTotalCashWR.Image = global::DTRMNS.Properties.Resources.Print32;
            this.btnSubTotalCashWR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubTotalCashWR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubTotalCashWR.Location = new System.Drawing.Point(213, 479);
            this.btnSubTotalCashWR.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubTotalCashWR.Name = "btnSubTotalCashWR";
            this.btnSubTotalCashWR.Size = new System.Drawing.Size(96, 134);
            this.btnSubTotalCashWR.TabIndex = 160;
            this.btnSubTotalCashWR.TabStop = false;
            this.btnSubTotalCashWR.UseVisualStyleBackColor = false;
            this.btnSubTotalCashWR.Click += new System.EventHandler(this.btnSubTotalCashWR_Click);
            // 
            // btnHideSubTotal
            // 
            this.btnHideSubTotal.AutoEllipsis = true;
            this.btnHideSubTotal.BackColor = System.Drawing.Color.Black;
            this.btnHideSubTotal.BackgroundImage = global::DTRMNS.Properties.Resources.Delete;
            this.btnHideSubTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHideSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHideSubTotal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHideSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideSubTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnHideSubTotal.ForeColor = System.Drawing.Color.White;
            this.btnHideSubTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHideSubTotal.Location = new System.Drawing.Point(5, 479);
            this.btnHideSubTotal.Margin = new System.Windows.Forms.Padding(5);
            this.btnHideSubTotal.Name = "btnHideSubTotal";
            this.btnHideSubTotal.Size = new System.Drawing.Size(94, 134);
            this.btnHideSubTotal.TabIndex = 157;
            this.btnHideSubTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHideSubTotal.UseVisualStyleBackColor = false;
            this.btnHideSubTotal.Click += new System.EventHandler(this.btnHideSubTotal_Click);
            // 
            // button61
            // 
            this.button61.AutoEllipsis = true;
            this.button61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button61.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button61.BackgroundImage")));
            this.button61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button61.FlatAppearance.BorderSize = 0;
            this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button61.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button61.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button61.Location = new System.Drawing.Point(10, 5);
            this.button61.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(84, 69);
            this.button61.TabIndex = 117;
            this.button61.Text = "7";
            this.button61.UseVisualStyleBackColor = false;
            this.button61.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button89
            // 
            this.button89.AutoEllipsis = true;
            this.button89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button89.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button89.BackgroundImage")));
            this.button89.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button89.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button89.FlatAppearance.BorderSize = 0;
            this.button89.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button89.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button89.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button89.Location = new System.Drawing.Point(10, 84);
            this.button89.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button89.Name = "button89";
            this.button89.Size = new System.Drawing.Size(84, 69);
            this.button89.TabIndex = 120;
            this.button89.Text = "4";
            this.button89.UseVisualStyleBackColor = false;
            this.button89.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button58
            // 
            this.button58.AutoEllipsis = true;
            this.button58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button58.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button58.BackgroundImage")));
            this.button58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button58.FlatAppearance.BorderSize = 0;
            this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button58.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button58.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button58.Location = new System.Drawing.Point(114, 5);
            this.button58.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(84, 69);
            this.button58.TabIndex = 118;
            this.button58.Text = "8";
            this.button58.UseVisualStyleBackColor = false;
            this.button58.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button12
            // 
            this.button12.AutoEllipsis = true;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button12.Location = new System.Drawing.Point(218, 321);
            this.button12.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 69);
            this.button12.TabIndex = 144;
            this.button12.Text = "20";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.KeyHandleBig);
            // 
            // button6
            // 
            this.button6.AutoEllipsis = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(114, 400);
            this.button6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 69);
            this.button6.TabIndex = 148;
            this.button6.Text = "50";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.KeyHandleBig);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(10, 400);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 69);
            this.button3.TabIndex = 147;
            this.button3.Text = "40";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.KeyHandleBig);
            // 
            // button5
            // 
            this.button5.AutoEllipsis = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(114, 321);
            this.button5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 69);
            this.button5.TabIndex = 141;
            this.button5.Text = "10";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.KeyHandleBig);
            // 
            // button57
            // 
            this.button57.AutoEllipsis = true;
            this.button57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button57.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button57.BackgroundImage")));
            this.button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button57.FlatAppearance.BorderSize = 0;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button57.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button57.Location = new System.Drawing.Point(218, 5);
            this.button57.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(86, 69);
            this.button57.TabIndex = 119;
            this.button57.Text = "9";
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button86
            // 
            this.button86.AutoEllipsis = true;
            this.button86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button86.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button86.BackgroundImage")));
            this.button86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button86.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button86.FlatAppearance.BorderSize = 0;
            this.button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button86.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button86.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button86.Location = new System.Drawing.Point(114, 84);
            this.button86.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(84, 69);
            this.button86.TabIndex = 121;
            this.button86.Text = "5";
            this.button86.UseVisualStyleBackColor = false;
            this.button86.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button75
            // 
            this.button75.AutoEllipsis = true;
            this.button75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button75.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button75.BackgroundImage")));
            this.button75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button75.FlatAppearance.BorderSize = 0;
            this.button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button75.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button75.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button75.Location = new System.Drawing.Point(218, 84);
            this.button75.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(86, 69);
            this.button75.TabIndex = 122;
            this.button75.Text = "6";
            this.button75.UseVisualStyleBackColor = false;
            this.button75.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(10, 321);
            this.button4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 69);
            this.button4.TabIndex = 142;
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.KeyHandleBig);
            // 
            // button95
            // 
            this.button95.AutoEllipsis = true;
            this.button95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button95.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button95.BackgroundImage")));
            this.button95.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button95.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button95.FlatAppearance.BorderSize = 0;
            this.button95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button95.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button95.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button95.Location = new System.Drawing.Point(10, 163);
            this.button95.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(84, 69);
            this.button95.TabIndex = 123;
            this.button95.Text = "1";
            this.button95.UseVisualStyleBackColor = false;
            this.button95.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button94
            // 
            this.button94.AutoEllipsis = true;
            this.button94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button94.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button94.BackgroundImage")));
            this.button94.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button94.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button94.FlatAppearance.BorderSize = 0;
            this.button94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button94.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button94.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button94.Location = new System.Drawing.Point(114, 163);
            this.button94.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button94.Name = "button94";
            this.button94.Size = new System.Drawing.Size(84, 69);
            this.button94.TabIndex = 124;
            this.button94.Text = "2";
            this.button94.UseVisualStyleBackColor = false;
            this.button94.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button93
            // 
            this.button93.AutoEllipsis = true;
            this.button93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button93.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button93.BackgroundImage")));
            this.button93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button93.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button93.FlatAppearance.BorderSize = 0;
            this.button93.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button93.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button93.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button93.Location = new System.Drawing.Point(218, 163);
            this.button93.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button93.Name = "button93";
            this.button93.Size = new System.Drawing.Size(86, 69);
            this.button93.TabIndex = 125;
            this.button93.Text = "3";
            this.button93.UseVisualStyleBackColor = false;
            this.button93.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button107
            // 
            this.button107.AutoEllipsis = true;
            this.button107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button107.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button107.BackgroundImage")));
            this.button107.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button107.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button107.FlatAppearance.BorderSize = 0;
            this.button107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button107.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.button107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button107.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button107.Location = new System.Drawing.Point(10, 242);
            this.button107.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button107.Name = "button107";
            this.button107.Size = new System.Drawing.Size(84, 69);
            this.button107.TabIndex = 126;
            this.button107.Text = "0";
            this.button107.UseVisualStyleBackColor = false;
            this.button107.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btnC
            // 
            this.btnC.AutoEllipsis = true;
            this.btnC.BackColor = System.Drawing.Color.Red;
            this.btnC.BackgroundImage = global::DTRMNS.Properties.Resources.shadow;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnC.Location = new System.Drawing.Point(114, 242);
            this.btnC.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(84, 69);
            this.btnC.TabIndex = 127;
            this.btnC.Text = "CLEAR";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnSubTotalClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlcizgi);
            this.panel1.Controls.Add(this.lblPayedIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMoneyBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblOrderTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 160);
            this.panel1.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 150;
            this.label1.Text = "ORDER TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlcizgi
            // 
            this.pnlcizgi.BackColor = System.Drawing.Color.White;
            this.pnlcizgi.ForeColor = System.Drawing.Color.White;
            this.pnlcizgi.Location = new System.Drawing.Point(54, 103);
            this.pnlcizgi.Name = "pnlcizgi";
            this.pnlcizgi.Size = new System.Drawing.Size(195, 2);
            this.pnlcizgi.TabIndex = 149;
            // 
            // lblPayedIn
            // 
            this.lblPayedIn.BackColor = System.Drawing.Color.Transparent;
            this.lblPayedIn.Font = new System.Drawing.Font("Arial", 18F);
            this.lblPayedIn.ForeColor = System.Drawing.Color.White;
            this.lblPayedIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPayedIn.Location = new System.Drawing.Point(121, 64);
            this.lblPayedIn.Name = "lblPayedIn";
            this.lblPayedIn.Size = new System.Drawing.Size(126, 33);
            this.lblPayedIn.TabIndex = 154;
            this.lblPayedIn.Text = "0.00";
            this.lblPayedIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPayedIn.TextChanged += new System.EventHandler(this.lblPayedIn_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(54, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 33);
            this.label2.TabIndex = 151;
            this.label2.Text = "PAYED IN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMoneyBack
            // 
            this.lblMoneyBack.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyBack.Font = new System.Drawing.Font("Arial", 18F);
            this.lblMoneyBack.ForeColor = System.Drawing.Color.White;
            this.lblMoneyBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMoneyBack.Location = new System.Drawing.Point(145, 121);
            this.lblMoneyBack.Name = "lblMoneyBack";
            this.lblMoneyBack.Size = new System.Drawing.Size(103, 33);
            this.lblMoneyBack.TabIndex = 155;
            this.lblMoneyBack.Text = "0.00";
            this.lblMoneyBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 152;
            this.label3.Text = "MONEY BACK";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTotal.Font = new System.Drawing.Font("Arial", 18F);
            this.lblOrderTotal.ForeColor = System.Drawing.Color.White;
            this.lblOrderTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrderTotal.Location = new System.Drawing.Point(150, 20);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(97, 33);
            this.lblOrderTotal.TabIndex = 153;
            this.lblOrderTotal.Text = "0.00";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Black;
            this.pnlDisplay.Controls.Add(this.pnlStandardDisplay);
            this.pnlDisplay.Controls.Add(this.pnlSubTotal);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDisplay.Location = new System.Drawing.Point(712, 0);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(314, 778);
            this.pnlDisplay.TabIndex = 28;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSize = true;
            this.pnlTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.cmdDirectSale);
            this.pnlTop.Controls.Add(this.cmdTables);
            this.pnlTop.Controls.Add(this.cmdTakeAway);
            this.pnlTop.Controls.Add(this.cmdDelivery);
            this.pnlTop.Controls.Add(this.mnuFunctions);
            this.pnlTop.Controls.Add(this.cmdCancel);
            this.pnlTop.Controls.Add(this.btnExpandShrinkHoldButtonDetails);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.MinimumSize = new System.Drawing.Size(0, 72);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(712, 72);
            this.pnlTop.TabIndex = 44;
            // 
            // cmdDirectSale
            // 
            this.cmdDirectSale.AutoEllipsis = true;
            this.cmdDirectSale.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdDirectSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDirectSale.FlatAppearance.BorderSize = 0;
            this.cmdDirectSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDirectSale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdDirectSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdDirectSale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdDirectSale.Location = new System.Drawing.Point(5, 3);
            this.cmdDirectSale.Margin = new System.Windows.Forms.Padding(5, 3, 1, 1);
            this.cmdDirectSale.Name = "cmdDirectSale";
            this.cmdDirectSale.Size = new System.Drawing.Size(92, 65);
            this.cmdDirectSale.TabIndex = 20;
            this.cmdDirectSale.Text = "Direct Sale";
            this.cmdDirectSale.UseVisualStyleBackColor = false;
            this.cmdDirectSale.Click += new System.EventHandler(this.cmdDirectSale_Click);
            // 
            // cmdTables
            // 
            this.cmdTables.AutoEllipsis = true;
            this.cmdTables.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdTables.FlatAppearance.BorderSize = 0;
            this.cmdTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdTables.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdTables.Location = new System.Drawing.Point(99, 3);
            this.cmdTables.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.cmdTables.Name = "cmdTables";
            this.cmdTables.Size = new System.Drawing.Size(90, 65);
            this.cmdTables.TabIndex = 19;
            this.cmdTables.Text = "Tables";
            this.cmdTables.UseVisualStyleBackColor = false;
            this.cmdTables.Click += new System.EventHandler(this.cmdTables_Click);
            // 
            // cmdTakeAway
            // 
            this.cmdTakeAway.AutoEllipsis = true;
            this.cmdTakeAway.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdTakeAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdTakeAway.FlatAppearance.BorderSize = 0;
            this.cmdTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTakeAway.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdTakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdTakeAway.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdTakeAway.Location = new System.Drawing.Point(191, 3);
            this.cmdTakeAway.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.cmdTakeAway.Name = "cmdTakeAway";
            this.cmdTakeAway.Size = new System.Drawing.Size(90, 65);
            this.cmdTakeAway.TabIndex = 18;
            this.cmdTakeAway.Text = "Take Away B";
            this.cmdTakeAway.UseVisualStyleBackColor = false;
            this.cmdTakeAway.Click += new System.EventHandler(this.cmdTakeAway_Click);
            // 
            // cmdDelivery
            // 
            this.cmdDelivery.AutoEllipsis = true;
            this.cmdDelivery.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdDelivery.FlatAppearance.BorderSize = 0;
            this.cmdDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelivery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdDelivery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdDelivery.Location = new System.Drawing.Point(283, 3);
            this.cmdDelivery.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.cmdDelivery.Name = "cmdDelivery";
            this.cmdDelivery.Size = new System.Drawing.Size(90, 65);
            this.cmdDelivery.TabIndex = 17;
            this.cmdDelivery.Text = "Delivery";
            this.cmdDelivery.UseVisualStyleBackColor = false;
            this.cmdDelivery.Click += new System.EventHandler(this.cmdDelivery_Click);
            // 
            // mnuFunctions
            // 
            this.mnuFunctions.BackColor = System.Drawing.Color.Black;
            this.mnuFunctions.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTools});
            this.mnuFunctions.Location = new System.Drawing.Point(374, 0);
            this.mnuFunctions.Name = "mnuFunctions";
            this.mnuFunctions.Size = new System.Drawing.Size(90, 68);
            this.mnuFunctions.TabIndex = 31;
            this.mnuFunctions.Text = "menuStrip1";
            // 
            // mnuTools
            // 
            this.mnuTools.AutoSize = false;
            this.mnuTools.BackgroundImage = global::DTRMNS.Properties.Resources.Tools32;
            this.mnuTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrders,
            this.mnuShrinkOrderDisplay,
            this.mnuKitchen,
            this.mnuReports,
            this.mnuLock,
            this.mnuSum,
            this.mnuSelectBonusPlan,
            this.mnuCustomer,
            this.mnuAdmin,
            this.mnuStock});
            this.mnuTools.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(82, 64);
            this.mnuTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // mnuOrders
            // 
            this.mnuOrders.Image = global::DTRMNS.Properties.Resources.Cart32;
            this.mnuOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(285, 54);
            this.mnuOrders.Text = "ORDER LIST TOTAL";
            this.mnuOrders.Click += new System.EventHandler(this.cmdOrders_Click);
            // 
            // mnuShrinkOrderDisplay
            // 
            this.mnuShrinkOrderDisplay.Image = global::DTRMNS.Properties.Resources.Curve;
            this.mnuShrinkOrderDisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuShrinkOrderDisplay.Name = "mnuShrinkOrderDisplay";
            this.mnuShrinkOrderDisplay.Size = new System.Drawing.Size(285, 54);
            this.mnuShrinkOrderDisplay.Text = "Shrink Order";
            this.mnuShrinkOrderDisplay.Click += new System.EventHandler(this.mnuShrinkOrderDisplay_Click);
            // 
            // mnuKitchen
            // 
            this.mnuKitchen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewBars,
            this.mnuPrintForKitchen,
            this.mnuResetKitchenOrders});
            this.mnuKitchen.Image = global::DTRMNS.Properties.Resources.chef32;
            this.mnuKitchen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuKitchen.Name = "mnuKitchen";
            this.mnuKitchen.Size = new System.Drawing.Size(285, 54);
            this.mnuKitchen.Text = "KITCHEN";
            // 
            // mnuViewBars
            // 
            this.mnuViewBars.Image = global::DTRMNS.Properties.Resources.chefdouble48;
            this.mnuViewBars.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuViewBars.Name = "mnuViewBars";
            this.mnuViewBars.Size = new System.Drawing.Size(330, 70);
            this.mnuViewBars.Text = "VIEW KITCHEN ORDERS";
            // 
            // mnuPrintForKitchen
            // 
            this.mnuPrintForKitchen.Image = global::DTRMNS.Properties.Resources.chef32;
            this.mnuPrintForKitchen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPrintForKitchen.Name = "mnuPrintForKitchen";
            this.mnuPrintForKitchen.Size = new System.Drawing.Size(330, 70);
            this.mnuPrintForKitchen.Text = "PRINT FOR KITCHEN";
            this.mnuPrintForKitchen.Click += new System.EventHandler(this.tsPrintForKitchen_Click);
            // 
            // mnuResetKitchenOrders
            // 
            this.mnuResetKitchenOrders.Image = global::DTRMNS.Properties.Resources.Redo64;
            this.mnuResetKitchenOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuResetKitchenOrders.Name = "mnuResetKitchenOrders";
            this.mnuResetKitchenOrders.Size = new System.Drawing.Size(330, 70);
            this.mnuResetKitchenOrders.Text = "RESET KITCHEN ORDER";
            this.mnuResetKitchenOrders.Click += new System.EventHandler(this.btnResetKitchenOrders_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.Image = global::DTRMNS.Properties.Resources.report48;
            this.mnuReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(285, 54);
            this.mnuReports.Text = "PRINT REPORT";
            this.mnuReports.Click += new System.EventHandler(this.cmdReports_Click);
            // 
            // mnuLock
            // 
            this.mnuLock.Image = global::DTRMNS.Properties.Resources.lock32;
            this.mnuLock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuLock.Name = "mnuLock";
            this.mnuLock.Size = new System.Drawing.Size(285, 54);
            this.mnuLock.Text = "LOCK SCREEN";
            this.mnuLock.Click += new System.EventHandler(this.cmdLock_Click);
            // 
            // mnuSum
            // 
            this.mnuSum.Image = global::DTRMNS.Properties.Resources.Sigma32;
            this.mnuSum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSum.Name = "mnuSum";
            this.mnuSum.Size = new System.Drawing.Size(285, 54);
            this.mnuSum.Text = "0.00";
            // 
            // mnuSelectBonusPlan
            // 
            this.mnuSelectBonusPlan.Image = global::DTRMNS.Properties.Resources.Bonus48;
            this.mnuSelectBonusPlan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSelectBonusPlan.Name = "mnuSelectBonusPlan";
            this.mnuSelectBonusPlan.Size = new System.Drawing.Size(285, 54);
            this.mnuSelectBonusPlan.Text = "SELECT TIPS PLAN";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Image = global::DTRMNS.Properties.Resources.customers32;
            this.mnuCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(285, 54);
            this.mnuCustomer.Text = "CUSTOMER DETAILS";
            this.mnuCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDebug,
            this.mnuReprintReport,
            this.mnuSupervisorReport,
            this.mnuChangeMenu,
            this.mnuReloadMenu,
            this.mnuOptions,
            this.mnuPrintAsInvoice,
            this.mnuDump,
            this.mnuOrientation,
            this.mnuPad,
            this.mnuDrawerCalculator,
            this.mnuReportArchive});
            this.mnuAdmin.Image = global::DTRMNS.Properties.Resources.Tools32;
            this.mnuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(285, 54);
            this.mnuAdmin.Text = "ADMINISTRATOR";
            // 
            // mnuDebug
            // 
            this.mnuDebug.Image = global::DTRMNS.Properties.Resources.ComputerDisconnected32;
            this.mnuDebug.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDebug.Name = "mnuDebug";
            this.mnuDebug.Size = new System.Drawing.Size(401, 54);
            this.mnuDebug.Text = "DEBUG";
            this.mnuDebug.Click += new System.EventHandler(this.mnuDebug_Click);
            // 
            // mnuReprintReport
            // 
            this.mnuReprintReport.Image = global::DTRMNS.Properties.Resources.reportold48;
            this.mnuReprintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReprintReport.Name = "mnuReprintReport";
            this.mnuReprintReport.Size = new System.Drawing.Size(401, 54);
            this.mnuReprintReport.Text = "REPRINT REPORT";
            this.mnuReprintReport.Visible = false;
            this.mnuReprintReport.Click += new System.EventHandler(this.btnReprintReport_Click);
            // 
            // mnuSupervisorReport
            // 
            this.mnuSupervisorReport.Image = global::DTRMNS.Properties.Resources.BlueMan32;
            this.mnuSupervisorReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSupervisorReport.Name = "mnuSupervisorReport";
            this.mnuSupervisorReport.Size = new System.Drawing.Size(401, 54);
            this.mnuSupervisorReport.Text = "SUPERVISOR REPORT";
            this.mnuSupervisorReport.Click += new System.EventHandler(this.mnuSupervisorReport_Click);
            // 
            // mnuChangeMenu
            // 
            this.mnuChangeMenu.Image = global::DTRMNS.Properties.Resources.Duplicate1;
            this.mnuChangeMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuChangeMenu.Name = "mnuChangeMenu";
            this.mnuChangeMenu.Size = new System.Drawing.Size(401, 54);
            this.mnuChangeMenu.Text = "CHANGE MENU";
            this.mnuChangeMenu.Click += new System.EventHandler(this.mnuChangeMenu_Click);
            // 
            // mnuReloadMenu
            // 
            this.mnuReloadMenu.Image = global::DTRMNS.Properties.Resources.Redo48;
            this.mnuReloadMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReloadMenu.Name = "mnuReloadMenu";
            this.mnuReloadMenu.Size = new System.Drawing.Size(401, 54);
            this.mnuReloadMenu.Text = "RELOAD USER INTERFACE (MENU)";
            this.mnuReloadMenu.Click += new System.EventHandler(this.tsReloadMenu_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Image = global::DTRMNS.Properties.Resources.disli48;
            this.mnuOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(401, 54);
            this.mnuOptions.Text = "SYSTEM  CONFIGURATION";
            this.mnuOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // mnuPrintAsInvoice
            // 
            this.mnuPrintAsInvoice.Image = global::DTRMNS.Properties.Resources.Receipt32;
            this.mnuPrintAsInvoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPrintAsInvoice.Name = "mnuPrintAsInvoice";
            this.mnuPrintAsInvoice.Size = new System.Drawing.Size(401, 54);
            this.mnuPrintAsInvoice.Text = "PRINT AS INVOICE";
            this.mnuPrintAsInvoice.Click += new System.EventHandler(this.btnPrintAsInvoice_Click);
            // 
            // mnuDump
            // 
            this.mnuDump.Image = global::DTRMNS.Properties.Resources.Recycle_Bin;
            this.mnuDump.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDump.Name = "mnuDump";
            this.mnuDump.Size = new System.Drawing.Size(401, 54);
            this.mnuDump.Text = "DUMP STATUS";
            this.mnuDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // mnuOrientation
            // 
            this.mnuOrientation.Image = global::DTRMNS.Properties.Resources.ExpandHeight48;
            this.mnuOrientation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuOrientation.Name = "mnuOrientation";
            this.mnuOrientation.Size = new System.Drawing.Size(401, 54);
            this.mnuOrientation.Text = "CHANGE ORIENTATION";
            this.mnuOrientation.Click += new System.EventHandler(this.btnOrientation_Click);
            // 
            // mnuPad
            // 
            this.mnuPad.Image = global::DTRMNS.Properties.Resources.pad32;
            this.mnuPad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPad.Name = "mnuPad";
            this.mnuPad.Size = new System.Drawing.Size(401, 54);
            this.mnuPad.Text = "FREE PAD";
            this.mnuPad.Click += new System.EventHandler(this.cmdPad_Click);
            // 
            // mnuDrawerCalculator
            // 
            this.mnuDrawerCalculator.Image = global::DTRMNS.Properties.Resources.CalculatorNice32;
            this.mnuDrawerCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuDrawerCalculator.Name = "mnuDrawerCalculator";
            this.mnuDrawerCalculator.Size = new System.Drawing.Size(401, 54);
            this.mnuDrawerCalculator.Text = "MONEY COUNTER";
            this.mnuDrawerCalculator.Click += new System.EventHandler(this.btnDrawerCalculator_Click);
            // 
            // mnuReportArchive
            // 
            this.mnuReportArchive.Image = global::DTRMNS.Properties.Resources.FolderToDB32;
            this.mnuReportArchive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportArchive.Name = "mnuReportArchive";
            this.mnuReportArchive.Size = new System.Drawing.Size(401, 54);
            this.mnuReportArchive.Text = "PREVIOUS REPORTS";
            this.mnuReportArchive.Click += new System.EventHandler(this.mnuReportArchive_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShoppingList,
            this.mnuSupplierPurchaseList,
            this.mnuPrintStockUsageReport});
            this.mnuStock.Image = global::DTRMNS.Properties.Resources.trolly32;
            this.mnuStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(285, 54);
            this.mnuStock.Text = "STOCK";
            // 
            // mnuShoppingList
            // 
            this.mnuShoppingList.Image = global::DTRMNS.Properties.Resources.trolly48;
            this.mnuShoppingList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuShoppingList.Name = "mnuShoppingList";
            this.mnuShoppingList.Size = new System.Drawing.Size(403, 70);
            this.mnuShoppingList.Text = "SHOPPING LIST";
            this.mnuShoppingList.Click += new System.EventHandler(this.btnShoppingList_Click);
            // 
            // mnuSupplierPurchaseList
            // 
            this.mnuSupplierPurchaseList.Image = global::DTRMNS.Properties.Resources.Print;
            this.mnuSupplierPurchaseList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSupplierPurchaseList.Name = "mnuSupplierPurchaseList";
            this.mnuSupplierPurchaseList.Size = new System.Drawing.Size(403, 70);
            this.mnuSupplierPurchaseList.Text = "PRINT SUPPLIER SHOPPING LIST";
            this.mnuSupplierPurchaseList.Click += new System.EventHandler(this.btnSupplierPurchaseList_Click);
            // 
            // mnuPrintStockUsageReport
            // 
            this.mnuPrintStockUsageReport.Image = global::DTRMNS.Properties.Resources.Print;
            this.mnuPrintStockUsageReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPrintStockUsageReport.Name = "mnuPrintStockUsageReport";
            this.mnuPrintStockUsageReport.Size = new System.Drawing.Size(403, 70);
            this.mnuPrintStockUsageReport.Text = "PRINT ALL SHOPPING LIST";
            this.mnuPrintStockUsageReport.Visible = false;
            this.mnuPrintStockUsageReport.Click += new System.EventHandler(this.btnPrintStockUsageReport_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Black;
            this.cmdCancel.BackgroundImage = global::DTRMNS.Properties.Resources.Delete;
            this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdCancel.FlatAppearance.BorderSize = 0;
            this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdCancel.Location = new System.Drawing.Point(465, 3);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(95, 64);
            this.cmdCancel.TabIndex = 16;
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // btnExpandShrinkHoldButtonDetails
            // 
            this.btnExpandShrinkHoldButtonDetails.BackColor = System.Drawing.Color.Black;
            this.btnExpandShrinkHoldButtonDetails.BackgroundImage = global::DTRMNS.Properties.Resources.SquareArrowDownExpander48;
            this.btnExpandShrinkHoldButtonDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpandShrinkHoldButtonDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpandShrinkHoldButtonDetails.FlatAppearance.BorderSize = 0;
            this.btnExpandShrinkHoldButtonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandShrinkHoldButtonDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExpandShrinkHoldButtonDetails.ForeColor = System.Drawing.Color.White;
            this.btnExpandShrinkHoldButtonDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExpandShrinkHoldButtonDetails.Location = new System.Drawing.Point(562, 3);
            this.btnExpandShrinkHoldButtonDetails.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.btnExpandShrinkHoldButtonDetails.Name = "btnExpandShrinkHoldButtonDetails";
            this.btnExpandShrinkHoldButtonDetails.Size = new System.Drawing.Size(76, 64);
            this.btnExpandShrinkHoldButtonDetails.TabIndex = 33;
            this.btnExpandShrinkHoldButtonDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpandShrinkHoldButtonDetails.UseVisualStyleBackColor = false;
            this.btnExpandShrinkHoldButtonDetails.Click += new System.EventHandler(this.btnExpandShrinkHoldButtonDetails_Click);
            // 
            // pnlOrderPad
            // 
            this.pnlOrderPad.AutoSize = true;
            this.pnlOrderPad.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderPad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderPad.Location = new System.Drawing.Point(0, 132);
            this.pnlOrderPad.Name = "pnlOrderPad";
            this.pnlOrderPad.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlOrderPad.Size = new System.Drawing.Size(712, 0);
            this.pnlOrderPad.TabIndex = 45;
            this.pnlOrderPad.Visible = false;
            // 
            // pnlPendingOrders
            // 
            this.pnlPendingOrders.AutoSize = true;
            this.pnlPendingOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPendingOrders.BackColor = System.Drawing.Color.Black;
            this.pnlPendingOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPendingOrders.Location = new System.Drawing.Point(0, 72);
            this.pnlPendingOrders.MinimumSize = new System.Drawing.Size(0, 60);
            this.pnlPendingOrders.Name = "pnlPendingOrders";
            this.pnlPendingOrders.Size = new System.Drawing.Size(712, 60);
            this.pnlPendingOrders.TabIndex = 47;
            // 
            // tmrHoldingOrders
            // 
            this.tmrHoldingOrders.Interval = 5000;
            this.tmrHoldingOrders.Tick += new System.EventHandler(this.tmrHoldingOrders_Tick);
            // 
            // pnlHolder
            // 
            this.pnlHolder.BackColor = System.Drawing.Color.Transparent;
            this.pnlHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHolder.Location = new System.Drawing.Point(0, 132);
            this.pnlHolder.Name = "pnlHolder";
            this.pnlHolder.Size = new System.Drawing.Size(712, 646);
            this.pnlHolder.TabIndex = 48;
            // 
            // tmrScreenSaverTrigger
            // 
            this.tmrScreenSaverTrigger.Interval = 1000;
            this.tmrScreenSaverTrigger.Tick += new System.EventHandler(this.tmrScreenSaverTrigger_Tick);
            // 
            // tmrHoldOrderAutoClose
            // 
            this.tmrHoldOrderAutoClose.Interval = 1000;
            this.tmrHoldOrderAutoClose.Tick += new System.EventHandler(this.tmrHoldOrderAutoClose_Tick);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.AutoEllipsis = true;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(4, 634);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 38);
            this.button7.TabIndex = 133;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.AutoEllipsis = true;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(159, 634);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 38);
            this.button9.TabIndex = 135;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.AutoEllipsis = true;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(4, 679);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 38);
            this.button8.TabIndex = 134;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.AutoEllipsis = true;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(159, 679);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 38);
            this.button10.TabIndex = 150;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // trmOrderPadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1026, 778);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHolder);
            this.Controls.Add(this.pnlOrderPad);
            this.Controls.Add(this.pnlPendingOrders);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuFunctions;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "trmOrderPadMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.trmOrderPadMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.trmOrderPadMain_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trmOrderPadMain_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trmOrderPadMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trmOrderPadMain_MouseMove);
            this.popHold.ResumeLayout(false);
            this.popHoldAndPrint.ResumeLayout(false);
            this.pnlStandardDisplay.ResumeLayout(false);
            this.pnlStandardDisplay.PerformLayout();
            this.pnlMoneyActions.ResumeLayout(false);
            this.pnlMoneyActions.PerformLayout();
            this.pnlSubTotal.ResumeLayout(false);
            this.pnlSubMoneyActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.mnuFunctions.ResumeLayout(false);
            this.mnuFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region "USER INTERFACE RELATED"
        public void LoadUserInterface()
        {
            //Set close/cancel order button properties
            cmdCancel.Size = new Size(bslayer.config.Cancel_Button_Width, cmdCancel.Size.Height);
            UF.SetBackgroundImageForButton(cmdCancel, bslayer.config.Cancel_Button_Image, Properties.Resources.Delete, ImageLayout.Center);
            UF.SetBackgroundColour(cmdCancel, bslayer.config.Cancel_Button_BackColour);
            //UF.SetForegroundColour(cmdCancel, bslayer.config.Cancel_Button_ForeColour);
            cmdCancel.FlatStyle = bslayer.config.Cancel_Button_Show_Borders ? FlatStyle.Standard : FlatStyle.Flat;
            //if (!bslayer.config.Cancel_Button_Show_Borders)
            //    UF.SetForegroundColour(cmdCancel, bslayer.config.Cancel_Button_BackColour);

            cmdDirectSale.Text = bslayer.config.Direct_Sale_Order_Button_Text;
            //cmdDirectSale.Location = new Point(bslayer.config.Direct_Sale_Button_X, cmdDirectSale.Location.Y);
            cmdDirectSale.Size = new Size(bslayer.config.Direct_Sale_Button_Width, cmdDirectSale.Size.Height);

            cmdTables.Text = bslayer.config.Table_Orders_Button_Text;
            cmdTables.Size = new Size(bslayer.config.Table_Orders_Button_Width, cmdTables.Size.Height);
            cmdTakeAway.Text = bslayer.config.TakeAway_Orders_Button_Text;
            cmdDelivery.Text = bslayer.config.Delivery_Orders_Button_Text;

            if (cmdTakeAway.Visible)
                cmdTakeAway.Size = new Size(bslayer.config.TakeAway_Orders_Button_Width, cmdTakeAway.Size.Height);
            if (cmdDelivery.Visible)
                cmdDelivery.Size = new Size(bslayer.config.Delivery_Orders_Button_Width, cmdDelivery.Size.Height);

            pnlPendingOrders.Visible = bslayer.config.Hold_Order_Available;

            btnCashDrawer.Text = bslayer.GetLuv().VoidText;
            if (OUI == null)
                OUI = new InterfaceHolder("orderpad");
            OUI.Panels.Clear();

            pnlOrderPad.Controls.Clear();

            if (bslayer.config.ActiveMenuIID == null || bslayer.config.ActiveMenuIID == "" ||
                !bslayer.IsMenuExist(bslayer.config.ActiveMenuIID))
            {
                //MessageBox.Show("Active Menu cannot be found, please set it manually from options window");
                frmMenuSelector frm = new frmMenuSelector(bslayer);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bslayer.config.ActiveMenuIID = frm.SelectedMenuIID;
                    UF.SaveConfig(bslayer.config);
                    bslayer.ActiveMenu = bslayer.GetActiveMenu(true, true);
                }
            }

            if (bslayer.config.ActiveMenuIID == null || bslayer.config.ActiveMenuIID == "")
            {
                MessageBox.Show("Active Menu cannot be found, please set it manually from options window");
            } else
            {
                bslayer.ActiveMenu = bslayer.GetActiveMenu(false, false);
                if (bslayer.ActiveMenu == null)
                {
                    MessageBox.Show("Please create and assign Default Menu to system.");
                    this.Close();
                }


                for (int i = 0; i < bslayer.ActiveMenu.items.Count; i++)
                {
                    UPEntity upe = new UPEntity(bslayer, (Entity)bslayer.ActiveMenu.items[i], null);
                    upe.DoneEventHandler = new GenericFunctionCallReturnBool(this.DoneEventHandlerFunction);
                    upe.Name = "upentity";
                    OUI.Panels.Add(upe);

                    RadioButton btn = new RadioButton();
                    btn.Appearance = Appearance.Button;
                    btn.Text = upe.entity.EntityName;
                    btn.Click += new EventHandler(OrderPadButton_Click);
                    btn.BackColor = Color.FromArgb(upe.entity.BackColour);
                    btn.ForeColor = Color.FromArgb(upe.entity.ForeColour);

                    try
                    {
                        btn.Font = new Font(upe.entity.FFamily, upe.entity.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), upe.entity.FStyle));
                    } catch
                    {
                        btn.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Tag = i;  //associated index 
                    btn.Padding = new System.Windows.Forms.Padding(2);
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Size = new Size(upe.entity.ButtonWidth, upe.entity.ButtonHeight);


                    pnlOrderPad.Controls.Add(btn);

                    if (((Entity)bslayer.ActiveMenu.items[i]).entityType == EntityTypes.SpecialEntity)
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
            if (bslayer.AttachedOrder.UserName == null || bslayer.AttachedOrder.UserName == "")
                bslayer.AttachedOrder.UserName = bslayer.LoggedUser.UserName;

            //if (bslayer.config.Customer_Display_Type != CustomerDisplayTypes.NONE)
            //    bslayer.CDSendMessage("TOTAL" + DRFormat.Space(bslayer.config.Customer_Display_Text_Length - 9) + "0.00", CDAreas.All);


            //attach order to the screen and display the order
            OrderScreen.OrderToDisplay = bslayer.AttachedOrder;
            // OrderScreen.bslayer = bslayer;
            OrderScreen.Display();

            if (bslayer.AttachedOrder.Status == StatusFlags.DONE ||
                (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale)) // && bslayer.config.Hold_Orders_New_Items_Add_Seperately))
                bslayer.StepableOrderItemGroupIID = ShortGuid.NewDateBasedGuid2(); // ShortGuid.NewGuid().ToString();
            else
            {
                if (bslayer.AttachedOrder.Status == StatusFlags.NEW && bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
                    bslayer.StepableOrderItemGroupIID = ShortGuid.NewDateBasedGuid2();
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
            switch (bslayer.config.Auto_Order_Type)
            {
                case OrderTypes.InHouse:
                    ctlTables tpanel = new ctlTables(bslayer, new GenericFunctionCall(DetachPanel),
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

            bool bonusVisible = bslayer.LoggedUser.AccessLevel > AccessLevels.User?true: IsBonusVisible();

            if (bslayer.config.Display_Session_Bonus && bonusVisible)
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



        public bool SafelyPackTheOrder(StatusFlags NewOrderStatus, bool blnLoadingNew)
        {
            bool blnHaveItemsToPrint = false;
            bool blnNewInHouseOrder = false;
            bool blnPrintableOldInHouseOrder = false;
            bool blnPrintableOtherOrderType = false;
            bool blnOldInHouseOrder = false;
            bool blnOrderHasMultipleOrderGroupIID = false;

            if (bslayer.AttachedOrder != null)
            {
                blnNewInHouseOrder = (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse && bslayer.AttachedOrder.Status == StatusFlags.NEW);// bslayer.OldOpennedOrder == null);

                blnPrintableOldInHouseOrder = (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse && bslayer.AttachedOrder.HasItemsForKitchen());  //bslayer.AttachedOrder.Subtract(bslayer.OldOpennedOrder).items.Count > 0);
                blnPrintableOtherOrderType = bslayer.AttachedOrder.OrderType == OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB;
                blnOldInHouseOrder = bslayer.AttachedOrder.Status == StatusFlags.DONE;  // bslayer.OldOpennedOrder != null;
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

                if ((blnNewInHouseOrder || blnOldInHouseOrder || blnPrintableOldInHouseOrder || blnOrderHasMultipleOrderGroupIID) && (bslayer.config.Table_Orders_Display_Kitchen_Orders || bslayer.config.Table_Orders_Kitchen_Receipt_Count > 0))
                {
                    //if ((blnNewInHouseOrder || blnPrintableOldInHouseOrder) && bslayer.config.Display_Kitchen_Orders) {
                    //This is where you call CreateKitchenOrderForInHouseOrder / if prep denied/cancelled go back

                    KitchenOrder korder = null;

                    Order order = bslayer.AttachedOrder.GetOrderWithKitchenableItems();
                    if (order.items.Count == 0)
                        bslayer.DeleteKitchenOrdersForOrder(bslayer.AttachedOrder.IID);
                    else
                    {
                        prepResult = bslayer.CreateKitchenOrderForOrder(order, out korder);
                        if (prepResult == PrepDialogReturnTypes.Cancel)
                            return false;
                    }

                    //Here print if inhouse order print required and there is something to print
                    //if ((korder != null && korder.items.Count > 0) &&
                    //    (blnNewInHouseOrder || blnOldInHouseOrder) && 
                    //    bslayer.config.Table_Orders_Kitchen_Receipt_Count > 0 ) {
                    //    bslayer.PrintForKitchen(korder); //   bslayer.AttachedOrder, false, true, true, true);
                    //}



                    if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse && bslayer.config.Table_Orders_Always_Shrinked)
                        bslayer.AttachedOrder.ShrinkOrder();

                }

                if (blnHaveItemsToPrint)
                {
                    //if (blnNewInHouseOrder && bslayer.config.Table_Kitchen_Receipt_Count > 0) {
                    //    bslayer.PrintForKitchen(bslayer.AttachedOrder, false, true, true, true);
                    //}

                    //if (blnPrintableOldInHouseOrder && bslayer.config.Table_Orders_Kitchen_Receipt_Count > 0) {
                    //    bslayer.PrintForKitchen(bslayer.AttachedOrder, true, true, true, true);
                    //}


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
                        if (bslayer.AttachedOrder.Status == StatusFlags.UNKNOWN ||
                            bslayer.AttachedOrder.Status == StatusFlags.NEW)
                        {
                            bslayer.DeleteOrder(bslayer.AttachedOrder.IID);
                            bslayer.AttachedOrder = null;
                        } else
                            bslayer.SaveOrder(bslayer.AttachedOrder);
                        UnloadOrder();
                    } else if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
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
                AttachPanel(new ctlCustomer(bslayer, new GenericFunctionCall(DetachCustomerPanel), new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive));
            else
                AttachPanel(new ctlCustomer(bslayer, new GenericFunctionCall(DetachCustomerPanel), null, NumberOfCopy, blnArchive, blnPrintLocal, blnEnforceDeliveryArchive));
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
                    if ((bslayer.AttachedOrder.CName.Trim()) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer name is missing !");
                        return false;
                    }
                    if ((bslayer.AttachedOrder.Tel + bslayer.AttachedOrder.Mobile + bslayer.AttachedOrder.Email) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer must have at least one phone number or an email address");
                        return false;
                    }
                } else if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery || bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery)
                {
                    if ((bslayer.AttachedOrder.CName) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Name missing ");
                        return false;
                    }
                    if ((bslayer.AttachedOrder.Tel.Trim() +
                        bslayer.AttachedOrder.Mobile.Trim() + bslayer.AttachedOrder.Email.Trim()) == "")
                    {
                        if (blnShowMessage)
                            MessageBox.Show("Customer must have at least one phone number or an email address");
                        return false;
                    }
                    if (bslayer.AttachedOrder.Address.Trim() == "")
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
                                if (bslayer.config.Direct_Sale_Auto_Payment_Mehtod == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(new ctlPayment(bslayer, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                                break;
                            case OrderTypes.InHouse:
                                if (bslayer.config.Table_Orders_Auto_Payment_Method == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(new ctlPayment(bslayer, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;


                                break;
                            case OrderTypes.TakeAwayB:
                                if (bslayer.config.TakeAway_Orders_Auto_Payment_Method == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(new ctlPayment(bslayer, new GenericFunctionCall(DetachPanel),
                                        new RemoteCompleteAttachedOrder(CompleteAttachedOrder), NumberOfCopy, blnArchive,
                                        blnPrintLocal, blnEnforceDeliveryArchive));
                                    return false;
                                } else
                                    bslayer.AttachedOrder.Payment = PaymentMethods.Cash;
                                break;
                            case OrderTypes.Delivery:
                                if (bslayer.config.Delivery_Orders_Auto_Payment_Method == AutoPaymentMethods.Selective)
                                {
                                    AttachPanel(new ctlPayment(bslayer, new GenericFunctionCall(DetachPanel),
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
                            SelectedPrinterIID = bslayer.GetPrinterForOrderType(OrderTypes.TakeAwayB).IID;
                        } catch
                        {
                        }
                    }

                    if (bslayer.AttachedOrder.OrderType == OrderTypes.Delivery ||
                        bslayer.AttachedOrder.OrderType == OrderTypes.InternetDelivery)
                    {
                        try
                        {
                            SelectedPrinterIID = bslayer.GetPrinterForOrderType(OrderTypes.Delivery).IID;
                        } catch
                        {
                        }
                    }

                    if (SelectedPrinterIID == null || SelectedPrinterIID == "")
                    {
                        List<ApplicationPrinter> PrinterList = bslayer.GetReceiptPrinterList();
                        if (PrinterList.Count == 0)
                        {
                            MessageBox.Show("There is no receipt printer in the system, please assign a receipt printer");
                            return false;
                        } else if (PrinterList.Count == 1)
                        {
                            SelectedPrinterIID = PrinterList[0].IID;
                        } else
                        {
                            if (blnPrintLocal && bslayer.config.DTClientLocalReceiptPrinterIID != "" &&
                                bslayer.config.DTClientLocalReceiptPrinterIID != null)
                                SelectedPrinterIID = bslayer.config.DTClientLocalReceiptPrinterIID;
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
                        NumberOfCopy, SelectedPrinterIID);
                    if (bslayer.config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(bslayer.GetPrinterForClient(SelectedPrinterIID).NetworkName);

                }

                if (blnArchive)
                {
                    if (!bslayer.config.Table_Orders_Always_Shrinked)
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
                        if (bslayer.IsPrimaryTable(bslayer.AttachedOrder.TableIID))
                        {
                            if (bslayer.HasSubTables(bslayer.AttachedOrder.TableIID))
                            {
                                blnTableTransferRequired = true;
                                targetTableIID = bslayer.AttachedOrder.TableIID;
                                sourceTableIID = bslayer.GetFirstSubTableIID(targetTableIID);
                            }
                        }
                    }
                }


                if (bslayer.config.TakeAway_Orders_Display_Kitchen_Orders && bslayer.AttachedOrder.OrderType == OrderTypes.TakeAwayB)
                    bslayer.CreateKitchenOrderForTakeAwayAndDeliveryOrder(bslayer.AttachedOrder);

                if (bslayer.config.Delivery_Orders_Display_Kitchen_Orders && bslayer.AttachedOrder.OrderType == OrderTypes.Delivery)
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
                if (SafelyPackTheOrder(StatusFlags.DONE, false))
                {
                    //if (bslayer.config.Customer_Display_Type != CustomerDisplayTypes.NONE)
                    //    bslayer.CDSendMessage("KITCHEN REQUEST SENT", CDAreas.All);
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
                float total = bslayer.AttachedOrder.GetFullTotal();
                if (total == 0)
                    return;
                if (total > 0 && (bslayer.AttachedOrder.OrderType != OrderTypes.Delivery))
                    bslayer.OpenCashDrawer(false);

                //if (bslayer.AttachedOrder.MoneyPaid > 0)
                //    bslayer.CDPaymentTotalWithChange();
                //else
                //    bslayer.CDPaymentTotal();

                bslayer.AttachedOrder.Payment = paymentMethod;


                switch (bslayer.AttachedOrder.OrderType)
                {
                    case OrderTypes.DirectSale:
                        if (withReceipt)
                            this.CompleteAttachedOrder(bslayer.config.Direct_Sale_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(0, true, false, false);
                        break;
                    case OrderTypes.InHouse:
                        if (withReceipt)
                            this.CompleteAttachedOrder(bslayer.config.Table_Orders_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(0, true, false, false);


                        break;
                    case OrderTypes.TakeAwayB:

                        if (withReceipt)
                            this.CompleteAttachedOrder(bslayer.config.TakeAway_Orders_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(bslayer.config.TakeAway_Orders_Receipt_Count, true, true, false);
                        break;
                    case OrderTypes.Delivery:

                        if (withReceipt)
                            this.CompleteAttachedOrder(bslayer.config.Delivery_Orders_Receipt_Count, true, true, false);
                        else
                            this.CompleteAttachedOrder(bslayer.config.Delivery_Orders_Receipt_Count, true, true, false);
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
            if (bslayer.HasSubTables(((TableButton)sender).IID))
            {
                //Display SubTables selection panel
                frmSubTableSelector frm = new frmSubTableSelector(bslayer, ((TableButton)sender).IID,
                    new GenericEventHandler(btnActualTableButton_Click));
                if (frm.ShowDialog() == DialogResult.Cancel)
                    cmdTables_Click(null, null);
            } else
            {
                btnActualTableButton_Click(sender, e);
            }
        }

        private void btnActualTableButton_Click(object sender, EventArgs e)
        {

            Table table = bslayer.BarrowTable(((TableButton)sender).IID);
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

        private void btnDirectTable_Click(object tableIID, EventArgs e)
        {

            Table table = bslayer.BarrowTable(tableIID.ToString());
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





        //private void pnlUser_ExpandedChanging(object sender, ExpandedChangeEventArgs e) {
        //    if (bslayer.AttachedOrder == null || bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale ||
        //        bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
        //        e.Cancel = true;
        //}





        private ViewTypes OrderTypeToViewType(OrderTypes otype)
        {
            switch (otype)
            {
                case OrderTypes.DirectSale:
                    return ViewTypes.DirectSaleOrderView;
                case OrderTypes.InHouse:
                    return ViewTypes.InHouseOrderView;
                case OrderTypes.TakeAwayB:
                    return ViewTypes.TakeAwayOrderView;
                case OrderTypes.Delivery:
                    return ViewTypes.DeliveryOrderView;
                case OrderTypes.InternetDelivery:
                    return ViewTypes.InternetDeliveryView;
                case OrderTypes.InternetTakeAway:
                    return ViewTypes.InternetTakeAwayView;
                default:
                    return ViewTypes.Unknown;
            }

        }

        private void HandleActionPanelView(ViewTypes view)
        {
            bool blnHasOrder = (bslayer.AttachedOrder != null);

            int OrderTypeCount = 0;

            //SetAllowedOrderTypeButtons
            if (bslayer.config != null)
            {
                cmdDirectSale.Visible = bslayer.config.Direct_Sale_Allowed;
                cmdTables.Visible = bslayer.config.Table_Orders_Allowed;
                cmdTakeAway.Visible = bslayer.config.TakeAway_Orders_Allowed;
                cmdDelivery.Visible = bslayer.config.Delivery_Orders_Allowed;

                OrderTypeCount += bslayer.config.Direct_Sale_Allowed ? 1 : 0;
                OrderTypeCount += bslayer.config.Table_Orders_Allowed ? 1 : 0;
                OrderTypeCount += bslayer.config.TakeAway_Orders_Allowed ? 1 : 0;
                OrderTypeCount += bslayer.config.Delivery_Orders_Allowed ? 1 : 0;
            }

            //DisplayTopBar
            try
            {
                mnuCustomer.Visible = blnHasOrder && bslayer.AttachedOrder.IsCustomerDetailsRequired;
            } catch { }

            mnuPad.Enabled = bslayer.config.Pad_Allowed;

            mnuOrders.Visible = false;
            mnuReports.Visible = false;

            mnuPrintForKitchen.Visible = blnHasOrder && (bslayer.AttachedOrder.OrderType != OrderTypes.DirectSale);
            btnPrint.Visible = blnHasOrder && !string.IsNullOrEmpty(bslayer.config.DTClientLocalReceiptPrinterIID);

            mnuReloadMenu.Visible = !blnHasOrder && bslayer.LoggedUser.IsManagerOrMore();

            mnuPad.Enabled = bslayer.HasPadItems() && bslayer.config.Pad_Allowed;

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
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
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

                    mnuOrders.Visible = bslayer.config.Order_Reloads_Allowed || (((int)bslayer.LoggedUser.AccessLevel) > (int)AccessLevels.User);
                    mnuReports.Visible = bslayer.config.Standard_Users_Can_Produce_Reports || (((int)bslayer.LoggedUser.AccessLevel) > (int)AccessLevels.User);
                    //cmdLastOrder.Visible = bslayer.config.Last_Order_Reload_Allowed || (((int)bslayer.LoggedUser.AccessLevel) > (int)AccessLevels.User);

                    ArrangeSubTotalPanel(false);
                    break;
                #endregion
                case ViewTypes.DirectSaleOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = (bslayer.config.Hold_Order_Available &&
                        (bslayer.AttachedOrder != null) &&
                        (bslayer.AttachedOrder.items.Count > 0));

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && bslayer.config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && bslayer.config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash_And_Print && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card_And_Print && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online_And_Print && blnOrderHasItems;
                    //Forth Row

                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.InHouseOrderView:
                    #region
                    //First Row
                    btnDone.Visible = blnOrderHasItems;
                    if (OrderScreen.SplitStatus == SplittingStatus.Splitting)
                        btnDone.Visible = false;

                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged && bslayer.config.Print_Invoice_Button_Visible;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);

                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged && bslayer.config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    // btnSubTotal.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged && bslayer.config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    //Forth Row
                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems && (!bslayer.AttachedOrder.blnItemsChanged || OrderScreen.SplitStatus == SplittingStatus.Splitting);
                    break;
                #endregion
                case ViewTypes.TakeAwayOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && bslayer.config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && bslayer.config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    //Forth Row

                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.DeliveryOrderView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && bslayer.config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && bslayer.config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.SplitView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = ((bslayer.AttachedOrder != null) &&
                       (bslayer.AttachedOrder.items.Count > 0) && bslayer.config.Hold_Order_Available);

                    //Second Row
                    mnuDrawerCalculator.Visible = false;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = false;

                    //Third Row
                    //btnSubTotal.Visible = true;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && true;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && true;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && true;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && true;
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && true;
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && true;
                    break;
                #endregion
                case ViewTypes.SubTotalView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = false;

                    //Third Row
                    //btnSubTotal.Visible = false;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && false;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && false;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && false;
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
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    //btnChequePaymentWithReceipt.Visible = blnOrderHasItems && bslayer.config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && bslayer.config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                case ViewTypes.InternetDeliveryView:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = blnOrderHasItems && !bslayer.AttachedOrder.blnItemsChanged;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
                    // btnChequePaymentWithReceipt.Visible = blnOrderHasItems && bslayer.config.Payments_Can_Be_Made_By_Cheque;

                    //Third Row
                    //btnSubTotal.Visible = blnOrderHasItems && bslayer.config.Sub_Total_Panel_Visible;
                    btnPrintCashFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPaymentWithReceipt.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;

                    //Forth Row

                    btnPrintCashFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash && blnOrderHasItems;
                    btnPrintCardFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_By_Card && blnOrderHasItems;
                    btnPrintOnlineFinalPayment.Visible = bslayer.config.Payments_Can_Be_Made_Online && blnOrderHasItems;
                    break;
                #endregion
                default:
                    #region
                    //First Row
                    btnDone.Visible = false;
                    mnuPrintAsInvoice.Visible = false;
                    btnHoldOrder.Visible = btnHoldAndReceipt.Visible = false;

                    //Second Row
                    mnuDrawerCalculator.Visible = bslayer.config.Drawer_Calculator_Visible;
                    btnCashDrawer.Visible = bslayer.config.Cash_Drawer_Void_Open_Allowed && (bslayer.config.Attached_Cash_Drawer_Type != CashDrawerTypes.None);
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
            if (SafelyPackTheOrder(StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new Order(OrderTypes.DirectSale);
                bslayer.AttachedOrder.ServiceChargeRate = bslayer.luv.ServiceChargeRate;
                bslayer.AttachedOrder.ServiceChargeTaxRate = bslayer.luv.ServiceChargeTaxRate;

                EnsureCompulsoryExtras();
                LoadAttachedOrder();
            } else
            {
                if (bslayer.config.DebugMode)
                    bslayer.SaveDebug("safely pack order on direct sale click failed");
            }
        }

        private void cmdTables_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(StatusFlags.DONE, true))
            {
                ctlTables tpanel = new ctlTables(bslayer, new GenericFunctionCall(DetachPanel),
                    new GenericEventHandler(btnTableButton_Click), new GenericEventHandler(btnDirectTable_Click));
                AttachPanel(tpanel);
            }
        }

        private void CreateAndLoadInHouseOrder()
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new Order(OrderTypes.InHouse, bslayer.luv.ServiceChargeRate, bslayer.luv.ServiceChargeTaxRate);
                LoadAttachedOrder();
            }
        }

        private void cmdTakeAway_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new Order(OrderTypes.TakeAwayB, bslayer.luv.ServiceChargeRate, bslayer.luv.ServiceChargeTaxRate);
                EnsureCompulsoryExtras();
                LoadAttachedOrder();
            }
        }

        private void cmdDelivery_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
                return;
            if (SafelyPackTheOrder(StatusFlags.DONE, true))
            {
                bslayer.AttachedOrder = new Order(OrderTypes.Delivery, bslayer.luv.ServiceChargeRate, bslayer.luv.ServiceChargeTaxRate);
                EnsureCompulsoryExtras();
                LoadAttachedOrder();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
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
                    case StatusFlags.NEW:
                    case StatusFlags.UNKNOWN:
                    case StatusFlags.VOID:
                        bslayer.DeleteOrder(bslayer.AttachedOrder.IID);
                        bslayer.AttachedOrder = null;
                        UnloadOrder();
                        return;
                    case StatusFlags.DONE:
                        string tableIID = bslayer.AttachedOrder.TableIID;
                        bslayer.AttachedOrder = null;
                        UnloadOrder();
                        Table table = bslayer.GetTable(tableIID);
                        if (table != null)
                        {
                            table.LockedClientIP = "";
                            bslayer.SaveTable(table);
                        }
                        return;
                    case StatusFlags.PENDING:
                    case StatusFlags.COMPLETED:
                    case StatusFlags.ARCHIVED:
                        bslayer.AttachedOrder = null;
                        UnloadOrder();
                        return;

                }
            }
        }

        ////private void cmdExit_Click(object sender, EventArgs e) {
        ////    try {
        ////        if (bslayer.LoggedUser.AccessLevel == AccessLevels.User)
        ////            return;

        ////        this.Close();
        ////        Application.Exit();
        ////    } catch { }
        ////}



        #endregion

        #region TOP FUNCTION BUTTON HANDLERS
        #region OWL MENU
        private void btnOwl_PopupOpen(object sender, EventArgs e)
        {
            try
            {
                mnuSum.Visible = bslayer.config.Display_Session_Total_On_Menu || bslayer.LoggedUser.IsManagerOrMore();
                mnuSelectBonusPlan.Visible = bslayer.config.Display_Session_Bonus || bslayer.LoggedUser.IsManagerOrMore();
                mnuReprintReport.Visible = (bslayer.config.Preserve_Previous_Report && bslayer.imgReportSnapShot != null && bslayer.LoggedUser.IsManagerOrMore());

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
            if (bslayer.config.Order_Reloads_Allowed || (bslayer.LoggedUser.AccessLevel != AccessLevels.User))
            {
                if (bslayer.AttachedOrder != null)
                {
                    if (!this.SafelyPackTheOrder(StatusFlags.DONE, true))
                        return;
                }
                ctlOrders fo = new ctlOrders(bslayer, new GenericFunctionCall(UnloadOrder),
                    new GenericFunctionCall(LoadAttachedOrder),
                    new GenericFunctionCall(DetachPanel),
                    new PassControl(AttachPanel),
                    new RemoteCompleteAttachedOrder(CompleteAttachedOrder));

                AttachPanel(fo);
            }
        }

        private void cmdReports_Click(object sender, EventArgs e)
        {

            if (!bslayer.HasCurrentSessionCompletedOrders())
            {
                MessageBox.Show("There is no completed orders for this session!!");
                return;
            }


            if (!bslayer.config.This_Terminal_Can_Produce_Reports)
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

            if (bslayer.config.No_Hold_Orders_Allowed_During_Report && blnHasActiveHoldOrders)
            {
                MessageBox.Show("You must cash out HOLD Orders before report!!!");
                return;
            }

            bool blnHasActiveTableOrders = bslayer.HasActiveTableOrders();

            if (bslayer.config.No_Table_Orders_Allowed_During_Report && blnHasActiveTableOrders)
            {
                MessageBox.Show("You must cash out Table Orders before report!!!");
                return;
            }

            bool blnZReport = bslayer.WillReportEndUpAs_Z_Report(bslayer.GetCurrentSession());
            if (blnZReport && (blnHasActiveHoldOrders || blnHasActiveTableOrders))
            {
                MessageBox.Show("Printing report will auto produce Z report, YOU MUST CASHOUT ALL ORDERS before proceed!!!!");
                return;
            }


            if (bslayer.config.Payments_Can_Be_Made_By_Card || bslayer.config.Payments_Can_Be_Made_By_Card_And_Print)
            {
                bool blnPrint = false;
                if (!blnZReport)
                {
                    if (bslayer.config.X_Pin_Machine_Report_Required)
                        blnPrint = true;
                    else
                        blnPrint = false;
                } else
                {
                    if (bslayer.config.Z_Pin_Machine_Report_Required)
                        blnPrint = true;
                    else
                        blnPrint = false;
                }
                if (blnPrint)
                {
                    // SessionData sd = bslayer.GetCurrentSession();

                    frmPinZWarning frm = new frmPinZWarning(bslayer, bslayer.GetOrdersTotalForPaymentMethod(bslayer.GetCurrentSessionIID(), PaymentMethods.Card));
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
                    TrmDrawerCount frmDrawer = new TrmDrawerCount(bslayer);
                    if (frmDrawer.ShowDialog() != DialogResult.OK)
                    {
                        goto bypass;
                    }
                }

                //"Courier New"
                bslayer.PrintReport(ReportFormatTypes.XReport, bslayer.GetCurrentSessionIID(), fsp.ReturnValue, false);

                bslayer.OpenCashDrawer(false);
            bypass:
                if (bslayer.config.Force_Receipt_Printer_To_Cut)
                    DRShell.SendCutCommandToUSBPrinter(bslayer.GetPrinterForClient(fsp.ReturnValue).NetworkName);

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
                    bslayer.PrintImage(bslayer.imgReportSnapShot, bslayer.GetPrinterForClient(fsp.ReturnValue).NetworkName);
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
        private void tsPrintForKitchen_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null)
            {

                //if (bslayer.AttachedOrder.Status == StatusFlags.NEW ||
                //   bslayer.AttachedOrder.Status == StatusFlags.UNKNOWN) {
                //    MessageBox.Show("You must save this order first to print in the kitchen");
                //    return;
                //}
                bslayer.PrintForKitchen(bslayer.AttachedOrder.IID);
                //bslayer.PrintForKitchen(bslayer.AttachedOrder, false, false, false, false);

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
                if (bslayer.config.Order_Pad_Default_Order_Type == OrderTypes.InHouse)
                {
                    ctlTables tpanel = new ctlTables(bslayer, new GenericFunctionCall(DetachPanel), new GenericEventHandler(btnTableButton_Click), new GenericEventHandler(btnDirectTable_Click));
                    AttachPanel(tpanel);
                    return;
                } else
                {
                    bslayer.AttachedOrder = new Order(bslayer.config.Order_Pad_Default_Order_Type);
                    EnsureCompulsoryExtras();
                    blnPadOpenning = true;
                    LoadAttachedOrder();
                    AttachPanel(new ctlNumberPad(bslayer, new GenericFunctionCall(DetachPanel)));
                    blnPadOpenning = false;
                }
            } else
            {
                AttachPanel(new ctlNumberPad(bslayer, new GenericFunctionCall(DetachPanel)));
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
            SafelyPackTheOrder(StatusFlags.DONE, true);
            bslayer.GetActiveMenu(true, true);
            RefreshUserInterface();
        }
        #region SERVICE HANDLERS
        //private void btnService_Click(object sender, EventArgs e) {
        //    if (bslayer.config.ServiceEnabled && bslayer.config.ServiceLocalPort > 2000 && bslayer.config.ServiceLocalPort < 49000) {
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
        //    if (bslayer.config.ServiceEnabled) {
        //        if (bslayer.config.ServiceLocalPort > 2000 && bslayer.config.ServiceLocalPort < 49000) {
        //            try {
        //                Uri serviceUri = new Uri("http://localhost:" + bslayer.config.ServiceLocalPort.ToString());

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
            //AttachPanel(new ctlConfig(bslayer, new GenericFunctionCall(LoadUserInterface), new GenericFunctionCall(DetachPanel)));

            frmConfig frm = new frmConfig(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (UF.SaveConfig(frm.config))
                {
                    if (bslayer != null)
                        bslayer.config = frm.config;
                }
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
                    //if (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse)
                    //    bslayer.AttachedOrder.ShrinkOrder();
                    if (DoneEventHandlerFunction())
                        ResetScreenLock();
                    else
                        return;
                }
            }
        }
        private void btnFault_Click(object sender, EventArgs e)
        {
            if (bslayer.config.Cash_Drawer_Void_Open_Allowed)
                bslayer.OpenCashDrawer(true);
        }
        //private void btnSubTotal_Click(object sender, System.EventArgs e) {
        //    if (bslayer.AttachedOrder != null) {
        //        lblOrderTotal.Text = bslayer.AttachedOrder.GetFullTotal().ToString("c");
        //        ArrangeSubTotalPanel(true);
        //    }
        //}
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && !string.IsNullOrEmpty(bslayer.config.DTClientLocalReceiptPrinterIID))
            {
                if (bslayer.AttachedOrder != null)
                {
                    bslayer.PrintEntireOrder(bslayer.AttachedOrder, true, false, 1,
                        bslayer.config.DTClientLocalReceiptPrinterIID);
                    if (bslayer.config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(
                            bslayer.GetPrinterForClient(bslayer.config.DTClientLocalReceiptPrinterIID).NetworkName);
                }
            }
        }

        private void btnHoldOrder_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
            {
                if (pnlPendingOrders.Controls.Count < bslayer.config.Hold_Order_Maximum_Allowed)
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
                if (pnlPendingOrders.Controls.Count < bslayer.config.Hold_Order_Maximum_Allowed)
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


            //if (EnsureSubTotalValuesCorrect()) {
            //    ArrangeSubTotalPanel(false);
            //    PrintFinalPayment(PaymentMethods.Cash, false);
            //}


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
            lblPayedIn.Text = pi.ToString("n");
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

            lblMoneyBack.Text = mb.ToString("n");
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
                btnSubTotalCash.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash;
                btnSubTotalCashWR.Visible = bslayer.config.Payments_Can_Be_Made_By_Cash;

                //btnSubTotalCard.Visible = bslayer.config.Payments_Can_Be_Made_By_Card;
                //btnSubTotalCardWR.Visible = bslayer.config.Payments_Can_Be_Made_By_Card;

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
                OrderItem oi = bslayer.AttachedOrder.GetOrderItem(OrderScreen.SelectedItemIID);
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
                if (bslayer.AttachedOrder.Status == StatusFlags.PENDING && bslayer.config.Hold_Order_Auto_Close)
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
        private void LoadPendingOrders()
        {
            if (blnLoadingHoldingOrders || bslayer.AttachedOrder != null)
                return;
            blnLoadingHoldingOrders = true;
            pnlPendingOrders.Controls.Clear();

            Font btnPriceFont = new Font("Arial", bslayer.config.Hold_Button_Price_Font_Size, FontStyle.Bold);

            DataTable dt = bslayer.db.GetDataTable("select IID from OrdersView Where payment = 0 and Status = " + (int)StatusFlags.PENDING + " and SessionIID = '" + bslayer.GetCurrentSessionIID() + "'");



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Order order = bslayer.GetOrder(dt.Rows[i]["IID"].ToString());
                ctlHoldButtonExtendable btn;
                if (Hold_Order_Display_Summary)
                {
                    btn = new ctlHoldButtonExtendable(bslayer.config.Hold_Button_Maximum_Extended_Width,
                        bslayer.config.Hold_Button_Maximum_Extended_Height);
                    btn.ItemsText = order.GetAllOrderItemsText(false);

                } else
                {
                    btn = new ctlHoldButtonExtendable(bslayer.config.Hold_Button_Maximum_Shrunk_Width,
                        bslayer.config.Hold_Button_Maximum_Shrunk_Height);

                }
                btn.Tag = order;


                //btn.ItemsCount = order.items.Count;


                float OrderFullTotal = order.GetFullTotal();
                btn.Text = OrderFullTotal.ToString("n2"); // + "\n" + dt.Rows[i]["KitchenOrderNo"].ToString();
                btn.PriceText = OrderFullTotal.ToString("n2");
                //btn.OrderNumber = dt.Rows[i]["KitchenOrderNo"].ToString();
                //btn.TickVisible = !(btn.OrderNumber.Length > 0);


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


                //btn.Size = new Size(bslayer.config.Hold_Button_Maximum_Width, bslayer.config.Hold_Button_Maximum_Height);



                btn.PriceTextFont = btnPriceFont;
                btn.BackgroundImage = Properties.Resources.shadow;
                btn.BackgroundImageLayout = ImageLayout.Stretch;


                if (order.Buzzer == "buzz")
                {
                    // btn.BackColor = Color.Magenta;
                } else if (order.Buzzer == "fuzz")
                {
                    // btn.BackColor = Color.Yellow;
                } else
                {
                    //btn.BackColor = Color.Cyan;
                }



                btn.ButtonClick += new EventHandler(pendingOrder_Click);
                pnlPendingOrders.Controls.Add(btn);
                //}




                //    if (order.Buzzer == "buzz")
                //        btn.BackColor = Color.Magenta;
                //    else if (order.Buzzer == "fuzz")
                //        btn.BackColor = Color.Yellow;
                //    else
                //        btn.BackColor = Color.Cyan;

                //    btn.ButtonClick += new EventHandler(pendingOrder_Click);
                //    pnlPendingOrders.Controls.Add(btn);
                //}
            }
            //if (dt.Rows.Count > 0)
            //    pnlPendingOrders.MinimumSize = new Size(0,60);
            //else
            //    pnlPendingOrders.MinimumSize = new Size(0, 0);

            blnLoadingHoldingOrders = false;
        }

        private void pendingOrder_Click(object sender, EventArgs e)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
                return;
            btnHoldOrder_Click(null, null);

            Order order;
            ctlHoldButtonExtendable btn = (sender as ctlHoldButtonExtendable);
            order = bslayer.GetOrder((btn.Tag as Order).IID);
            btn.Tag = order;


            bslayer.AttachedOrder = order;

            //12345
            if (bslayer.config.Hold_Order_Print_in_Kitchen || bslayer.config.Hold_Order_Display_in_Kitchen)
            {
                bslayer.SetKitchenOrderModifiedStateForAttachedOrder(true);
            }

            LoadAttachedOrder();
            OrderScreen.SplitStatus = SplittingStatus.Normal;

            if (bslayer.config.Hold_Order_Auto_Close)
            {
                TickCounterForHoldOrderToClose = 0;
            }
            tmrHoldOrderAutoClose.Enabled = bslayer.config.Hold_Order_Auto_Close;
        }

        private int TickCounterForHoldOrderToClose;
        private void tmrHoldOrderAutoClose_Tick(object sender, EventArgs e)
        {
            if (TickCounterForHoldOrderToClose > bslayer.config.Hold_Order_Auto_Close_Seconds)
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
                    //if (cmdCancel.Image != null)
                    //    cmdCancel.Image = null;
                } catch
                {
                    string str = "";
                    //if (cmdCancel.Image == null)
                    //    cmdCancel.Image = Properties.Resources.NoDbConnection;
                }
            }
        }

        private void DoHolding(string ColorName, bool blnPrint)
        {
            if (bslayer.AttachedOrder != null && bslayer.AttachedOrder.items.Count > 0)
            {
                if (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED ||
                    bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED)
                {
                    if (blnPrint)
                        bslayer.PrintReceipt(bslayer.AttachedOrder.IID, bslayer.GetDefaultReceiptPrinter(), 1);
                    UnloadOrder();
                    return;
                }

                bslayer.AttachedOrder.Buzzer = "";

                if (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale)
                {
                    PrepDialogReturnTypes prepDialogResult = PrepDialogReturnTypes.Hold;
                    try
                    {

                        bslayer.AttachedOrder.Reference = ColorName;

                        //This is where we create kitchen order
                        if ((bslayer.config.Hold_Order_Display_in_Kitchen || bslayer.config.Hold_Order_Print_in_Kitchen) && (OrderScreen.SplitStatus != SplittingStatus.Splitting))
                        {
                            prepDialogResult = HandleKitchenOrderForDirectSale();
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
                if (!bslayer.config.Hold_Order_Available)
                    tmrHoldingOrders_Tick(null, null);
            }
        }


        private PrepDialogReturnTypes HandleKitchenOrderForDirectSale()
        {
            PrepDialogReturnTypes prepResult = PrepDialogReturnTypes.Hold;

            Order order = bslayer.AttachedOrder.GetOrderWithKitchenableItems();
            if (order.items.Count == 0)
                bslayer.DeleteKitchenOrdersForOrder(bslayer.AttachedOrder.IID);
            else
            {
                KitchenOrder korder = null;
                prepResult = bslayer.CreateKitchenOrderForOrder(order, out korder);
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

        private void btnPrintStockUsageReport_Click(object sender, EventArgs e)
        {
            trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
            if (fsp.ShowDialog() == DialogResult.OK)
            {
                bslayer.PrintStockUsage(bslayer.GetPrinterForClient(fsp.ReturnValue));
            }
        }

        int screenLockCounter = 0;
        private void tmrScreenSaverTrigger_Tick(object sender, EventArgs e)
        {
            if (this.IsMdiChild)
            {
                if (this.ParentForm.ActiveMdiChild == this)
                {
                    //if (Form.ActiveForm != null)
                    //{
                    //    screenLockCounter = 0;
                    //    return;
                    //}

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
            if (bslayer.config.Screen_Lock_Method != ScreenLockTypes.None)
            {
                if (bslayer.AttachedOrder == null)
                    screenLockCounter++;
                else
                    screenLockCounter = 0;

                if (bslayer.config.Screen_Lock_Method == ScreenLockTypes.ScreenSaverLock)
                {


                    if (screenLockCounter >= bslayer.config.Seconds_Before_ScreenLock)
                    {
                        //screensaver directory doesnt' exist disable this functionality
                        if (!Directory.Exists(bslayer.config.Screen_Saver_Image_Folder))
                        {
                            //this.Close();
                            tmrScreenSaverTrigger.Enabled = false;
                            return;
                        }

                        tmrScreenSaverTrigger.Enabled = false;
                        screenLockCounter = 0;
                        frmScreenSaver frm = new frmScreenSaver(bslayer);
                        frm.ShowDialog();
                        tmrScreenSaverTrigger.Enabled = true;
                    }
                } else if (bslayer.config.Screen_Lock_Method == ScreenLockTypes.WindowsScreenSaverLock)
                {
                    if (screenLockCounter >= bslayer.config.Seconds_Before_ScreenLock)
                    {
                        DRUF.TurnOnSS();
                        tmrScreenSaverTrigger.Enabled = false;
                        screenLockCounter = 0;
                    }

                } else if (bslayer.config.Screen_Lock_Method == ScreenLockTypes.PinLock)
                {
                    if (screenLockCounter >= bslayer.config.Seconds_Before_ScreenLock)
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
            if (bslayer.config.Screen_Lock_Method == ScreenLockTypes.None)
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

        private void LoadSupplierList()
        {
            mnuSupplierPurchaseList.DropDownItems.Clear();
            DataTable dt = bslayer.GetAllSuppliers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Supplier supp = new Supplier(dt.Rows[i]);
                ToolStripMenuItem btn = new ToolStripMenuItem();
                btn.Text = supp.SupplierName;
                btn.Tag = supp.IID;
                //btn.Image = global::DTRMNS.Properties.Resources.trolly48;
                btn.Click += btnSupplier_Click;


                mnuSupplierPurchaseList.DropDownItems.Add(btn);
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            trmSelectPrinter fsp = new trmSelectPrinter(bslayer);
            if (fsp.ShowDialog() == DialogResult.OK)
            {
                ToolStripMenuItem btn = ((ToolStripMenuItem)sender);
                string supplierIID = btn.Tag.ToString();
                bslayer.PrintStockUsage(bslayer.GetPrinterForClient(fsp.ReturnValue), bslayer.GetStockItemUsageBySupplier(supplierIID, true), btn.Text);
            }

        }


        private void trmOrderPadMain_Shown(object sender, EventArgs e)
        {
            AdjustOrientation();
        }
        private void AdjustOrientation()
        {
            switch (bslayer.config.OrderPad_Orientation)
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
            if (bslayer.config.OrderPad_Orientation == OrientationTypes.Landscape)
            {
                bslayer.config.OrderPad_Orientation = OrientationTypes.Portrait;
            } else
            {
                bslayer.config.OrderPad_Orientation = OrientationTypes.Landscape;
            }
            AdjustOrientation();
            UF.SaveConfig(bslayer.config);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            switch (bslayer.config.OrderPad_Orientation)
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
            frmStockUsagePad frm = new frmStockUsagePad(bslayer);
            if (this.ParentForm == null)
                frm.ShowDialog();
            else
            {
                // frm.ParentForm = this.ParentForm;
                frm.MdiParent = this.ParentForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void btnOwl_Click(object sender, EventArgs e)
        {

        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            bslayer.SaveDebug(UF.SerializeObject(typeof(DTRMSimpleBusiness), bslayer));

            //System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typeof(DTRMSimpleBusiness));
            //System.IO.StringWriter writer = new System.IO.StringWriter();
            //xser.Serialize(writer, bslayer);
            //bslayer.SaveDebug(writer.ToString());

            //try {
            //    //DRFile.XmlSerialize("\\Dump\\test.xml", "hello world", typeof(string), true);
            //    DRFile.XmlSerialize("\\Dump\\" + DateTime.Now.ToString("dd MMM yyyy HH mm ss") + ".xml", bslayer, typeof(DTRMSimpleBusiness), true);
            //} catch(Exception ex) {
            //    bslayer.SaveDebug("BSLayer Serialization Error : " + ex.Message);
            //}
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

        private void pnlBonus_Load(object sender, EventArgs e)
        {

        }

        private void pnlBonus_Click(object sender, EventArgs e)
        {
            pnlBonus.UpdateBonusDisplay();
        }

        public void ConfigChanged()
        {
            try
            {
                bslayer.config = UF.GetConfig();
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
            //bslayer.config.Table_Orders_Always_Shrinked = !bslayer.config.Table_Orders_Always_Shrinked;
            // OrderScreen.Display();
        }


        private void btnExpandShrinkHoldButtonDetails_Click(object sender, EventArgs e)
        {
            Hold_Order_Display_Summary = !Hold_Order_Display_Summary;
            // tmrHoldingOrders_Tick(null, null);            
            LoadPendingOrders();
        }

        private void mnuReportArchive_Click(object sender, EventArgs e)
        {
            frmReportArchive frm = new frmReportArchive(bslayer);
            frm.ShowDialog();
        }
    }
}