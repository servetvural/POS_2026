
using WinLayer.Controls;
using System.ComponentModel;
using POSLayer.Models;
using POSLayer.Library;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Repository.IRepository;

namespace WinLayer {
    public partial class ctlKitchenDisplay : UserControl {
        PosConfig config;
        IRepository<KitchenOrder> repoKitchenOrder;

        private bool blnLoadingKitchenOrders;
        private bool blnLoadingCompletedOrders;
        private Distribution distribution;
        private bool blnNeedToShrink;

        private DateTime KitchenModified;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool DisplayClock { get { return lblClock.Visible; }
            set { lblClock.Visible = value; }
        }

        public ctlBonus BonusControl { get { return ctrlBonus; }}

        public event DisplayConfigurationChangeRequiredEvent DisplayTypeWillBeChange;
        public void onDisplayTypeWillBeChange() {
            if (DisplayTypeWillBeChange != null)
                DisplayTypeWillBeChange();
        } 
        
        public event DisplayConfigurationChangeEvent DisplayTypeChanged;
        public void onDisplayTypeChanged(Distribution newdistribution) {
            if (DisplayTypeChanged != null)
                DisplayTypeChanged(newdistribution);
        }

        public event SimpleStringEventHandler OrderDeleted;
        public void onOrderDeleted(string korderIID) {
            if (OrderDeleted != null)
                OrderDeleted(korderIID);
        }

        public event SimpleStringEventHandler OrderCompleted;
        public void onOrderCompleted(string korderIID) {
            if (OrderCompleted != null)
                OrderCompleted(korderIID);
        }

        public ctlKitchenDisplay() {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();
            repoKitchenOrder = ServiceHelper.GetRepository<KitchenOrder>();
            //terminalDistributionList = new List<Distribution>();
        }

        private void ctlKitchenDisplay_Load(object sender, EventArgs e) {

        }
        public async void Initiate( Distribution _distribution, bool CloseVisible) {
            KitchenModified =  BSLayer.Instance.shop.KitchenModified;

            distribution = _distribution; // AddRange(globalTypeIIDList.Split(new char[',']));
             BSLayer.Instance.KitchenRequestOccured += Bslayer_KitchenRequestOccured;
            
            DistributionChanged(distribution);
            btnClose.Visible = CloseVisible;
            tmrMain.Enabled = true;
            lblClock.Text = DateTime.Now.ToLongTimeString();
            await repoKitchenOrder.CleanupKitchenData();
        }

        private void Bslayer_KitchenRequestOccured(KitchenOrder order) {
            if (order.IsRelative(distribution.IID))
                btnReload_Click(null, null);
        }

        private double AddKitchenOrder(KitchenOrder korder, bool blnWaiting) {
            if (BSLayer.Instance == null)
                return -1;

            if (korder == null)
                return -1;
            
            ctlKitchenOrder ctl = ActivatorUtilities.CreateInstance< ctlKitchenOrder>(ServiceHelper.Services, korder,distribution,blnWaiting, false);
            ctl.OrderCompleteRequested += Ctl_OrderCompleteRequested;
            ctl.OrderDeleteRequested += Ctl_OrderDeleteRequested;
            ctl.Dock = DockStyle.Top;


            //pnlKitchenOrders.Controls.ContainsKey
            if (blnWaiting) {
                pnlKitchenOrders.Controls.Add(ctl);
                ctl.BringToFront();

            } else {
                pnlCompletedOrders.Controls.Add(ctl);
            }
            return ctl.singleResponseTime;
        }

        private async void Ctl_OrderDeleteRequested(string IID){
            try {
                if (await repoKitchenOrder.Delete(IID) > 0) {
                    pnlCompletedOrders.Controls.RemoveByKey(IID);
                    OrderDeleted(IID);
                }

                UpdateResponseTime();
            } catch { }
        }

        private void Ctl_OrderCompleteRequested(KitchenOrder korder) {
            blnLoadingCompletedOrders = blnLoadingKitchenOrders = true;
                        
            pnlKitchenOrders.Controls.RemoveByKey(korder.IID);           
            blnLoadingCompletedOrders = blnLoadingKitchenOrders = false;
            AddKitchenOrder(korder, false);

            UpdateResponseTime();
        }

        private void UpdateResponseTime() {
            try {
                double totalResponseTime = 0;
                if (pnlCompletedOrders.Controls.Count == 0)
                    lblResponse.Text = "00s";
                else {
                    foreach (var item in pnlCompletedOrders.Controls) {
                        totalResponseTime += ((ctlKitchenOrder)item).singleResponseTime;
                    }
                    lblResponse.Text = UF.secondsToMinutes(Math.Floor(totalResponseTime / pnlCompletedOrders.Controls.Count));
                }
            } catch (Exception ex) {
                 BSLayer.Instance.SaveDebug("ctlKitchenDisplay UpdateResponseTime " + ex.Message);
            }
        }



        public async void LoadWaitingKitchenOrders() {
            if (BSLayer.Instance == null || distribution == null)
                return;

            if (blnLoadingKitchenOrders)
                return;
            blnLoadingKitchenOrders = true;
            this.DoubleBuffered = true;

            try {
                List<KitchenOrder> orderList =await  BSLayer.Instance.GetKitchenOrdersByStatus(KitchenOrderStatusTypes.Waiting, true, distribution);
                for (int i = 0; i < orderList.Count; i++) {
                    if (orderList[i].OrderType == OrderTypes.Sale && !config.Hold_Order_Display_in_Kitchen)
                        continue;

                    if (orderList[i].OrderType == OrderTypes.Sitin && !config.Table_Orders_Display_Kitchen_Orders)
                        continue;
                    ctlKitchenOrder ctl = (ctlKitchenOrder)pnlKitchenOrders.Controls[orderList[i].IID];

                    if (ctl == null)
                        AddKitchenOrder(orderList[i], true);
                    else {
                        ctl.Reload(orderList[i]);
                    }
                }

                foreach (Control item in pnlKitchenOrders.Controls) {
                    if (item == null)
                        continue;
                    ctlKitchenOrder ctl = (ctlKitchenOrder)item;
                    try {
                        if (orderList.Find(x => x.IID == ctl.korder.IID) == null)
                            pnlKitchenOrders.Controls.Remove(ctl);
                    } catch (Exception exremove) {
                         BSLayer.Instance.SaveDebug("ctlKitchenDisplay LoadWaitingKitchenOrders remove loop " + exremove.Message);
                    }
                }
                //foreach (Control item in pnlKitchenOrders.Controls) {
                //    ((ctlKitchenOrder)item).AutoSize = true;
                //    ((ctlKitchenOrder)item).pnlMainSetAutoSize(true);
                //}
            } catch (Exception ex) {
                 BSLayer.Instance.SaveDebug("ctlKitchenDisplay LoadWaitingKitchenOrders " + ex.Message);
            }

            blnLoadingKitchenOrders = false;
        }


        public async void LoadCompletedOrders() {
            if (BSLayer.Instance == null || distribution == null)
                return;

            if (blnLoadingCompletedOrders)
                return;
            this.DoubleBuffered = true;

            blnLoadingCompletedOrders = true;

            if (blnNeedToShrink)
                btnShrink_Click(null, null);

            //pnlCompletedOrders.Controls.Clear();

            try {
                List<KitchenOrder> orderList =await  BSLayer.Instance.GetKitchenOrdersByStatus(KitchenOrderStatusTypes.Completed, true, distribution);
                double totalResponseTime = 0;

                for (int i = 0; i < orderList.Count; i++) {
                    if (orderList[i].OrderType == OrderTypes.Sale && !config.Hold_Order_Display_in_Kitchen)
                        continue;

                    if (orderList[i].OrderType == OrderTypes.Sitin && !config.Table_Orders_Display_Kitchen_Orders)
                        continue;


                    KitchenOrder korder = orderList[i];
                    switch (korder.Status) {
                        case KitchenOrderStatusTypes.PartialyCompleted:
                            if (!korder.HasWaitingItem(distribution)) {
                                if (pnlCompletedOrders.Controls[korder.IID] == null)
                                    totalResponseTime += AddKitchenOrder(korder, false);
                                else
                                    ((ctlKitchenOrder)pnlCompletedOrders.Controls[korder.IID]).Reload(korder);
                            }
                            break;
                        case KitchenOrderStatusTypes.Completed:
                            if (pnlCompletedOrders.Controls[korder.IID] == null)
                                totalResponseTime += AddKitchenOrder(korder, false);
                            else
                                ((ctlKitchenOrder)pnlCompletedOrders.Controls[korder.IID]).Reload(korder);
                            break;
                    }
                }

                foreach (Control item in pnlCompletedOrders.Controls) {
                    if (item == null)
                        continue;
                    ctlKitchenOrder ctl = (ctlKitchenOrder)item;
                    if (orderList.Find(x => x.IID == ctl.korder.IID) == null) {

                        pnlCompletedOrders.Controls.Remove(ctl);
                    }
                }

                if (orderList.Count > 0)
                    lblResponse.Text = UF.secondsToMinutes(Math.Floor(totalResponseTime / orderList.Count));
                else
                    lblResponse.Text = "0";
           

            blnNeedToShrink = orderList.Count > config.Kitchen_Max_Completed_Order_Count;
            } catch (Exception ex) {
                 BSLayer.Instance.SaveDebug("ctlKitchenDisplay LoadCompletedOrders " + ex.Message);
            }

            blnLoadingCompletedOrders = false;
        }

        private void tmrKitchenOrders_Tick(object sender, EventArgs e) {
            lblClock.Text = DateTime.Now.ToLongTimeString();
            if (blnLoadingCompletedOrders || blnLoadingKitchenOrders)
                return;
            else {
                DateTime theNewKitchenModified =  BSLayer.Instance.shop.KitchenModified;

                if (theNewKitchenModified > KitchenModified) {
                    KitchenModified = theNewKitchenModified;
                    
                    btnReload_Click(null, null);
                }
            }
        }
        public void LoadAll() {
            if (!blnLoadingKitchenOrders)
                LoadWaitingKitchenOrders();
            if (!blnLoadingCompletedOrders)
                LoadCompletedOrders();
        }
        private void btnReload_Click(object sender, EventArgs e) {
            LoadAll();           
        }

        private void btnStationSelector_Click(object sender, EventArgs e) {
            DisplayTypeWillBeChange();
        }

        public void DistributionChanged(Distribution theNewDistribution) {
            lblTerminalType.Text = "";
            distribution = theNewDistribution;

            lblTerminalType.Text += distribution.DistributionName;
            LoadAll();
        }

        private async void btnShrink_Click(object sender, EventArgs e) {
             await ShrinkKitchenOrderList();
            LoadCompletedOrders();
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.ParentForm.Close();
        }

        public void RemoveCompletedOrderQuitely(string korderIID) {
            pnlCompletedOrders.Controls.RemoveByKey(korderIID);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ChangeDistributionVisible { get { return btnStationSelector.Visible; } set { btnStationSelector.Visible = value; } }


        public async Task<bool> ShrinkKitchenOrderList()
        {
            List<KitchenOrder> korderList = await repoKitchenOrder.GetListByField("Status", ((int)KitchenOrderStatusTypes.Completed).ToString());
            if (korderList.Count <= config.Kitchen_Max_Completed_Order_Count)
                return false;

            foreach (var korder in korderList.Skip(config.Kitchen_Max_Completed_Order_Count).ToList())
            {
                if (korder.Status == KitchenOrderStatusTypes.Completed)
                    await repoKitchenOrder.Delete(korder);
            }
            return true;
        }
    }
}
