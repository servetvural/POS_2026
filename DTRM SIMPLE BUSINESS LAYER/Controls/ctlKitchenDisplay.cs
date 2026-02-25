using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PosLibrary;
using DTRMNS.Controls;

namespace DTRMNS {
    public partial class ctlKitchenDisplay : UserControl {
        public DTRMNS.DTRMSimpleBusiness bslayer;


        private bool blnLoadingKitchenOrders;
        private bool blnLoadingCompletedOrders;
        private List<Distribution> terminalDistributionList;
        private bool blnNeedToShrink;

        private DateTime KitchenModified;

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
            terminalDistributionList = new List<Distribution>();
        }

        private void ctlKitchenDisplay_Load(object sender, EventArgs e) {

        }
        public void Initiate(DTRMSimpleBusiness bslayer, List<Distribution> distributionList, bool CloseVisible) {
            KitchenModified = bslayer.GetKitchenModified();

            this.bslayer = bslayer;
            this.terminalDistributionList = distributionList; // AddRange(globalTypeIIDList.Split(new char[',']));
            this.bslayer.KitchenRequestOccured += Bslayer_KitchenRequestOccured;
            
            DistributionChanged(this.terminalDistributionList);
            btnClose.Visible = CloseVisible;
            tmrMain.Enabled = true;
            lblClock.Text = DateTime.Now.ToLongTimeString();
            bslayer.CleanKitchenOrdersHasNoParentOrder();
        }

        private void Bslayer_KitchenRequestOccured(KitchenOrder order) {
            if (order.IsRelative(terminalDistributionList))
                btnReload_Click(null, null);
        }

        private double AddKitchenOrder(KitchenOrder korder, bool blnWaiting) {
            if (bslayer == null)
                return -1;

            if (korder == null)
                return -1;
            
            ctlKitchenOrder ctl = new ctlKitchenOrder(bslayer, korder,terminalDistributionList,blnWaiting, false);
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

        private void Ctl_OrderDeleteRequested(string IID){
            try {
                if (bslayer.DeleteKitchenOrder(IID, false)) {
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
                    lblResponse.Text = DRUF.secondsToMinutes(Math.Floor(totalResponseTime / pnlCompletedOrders.Controls.Count));
                }
            } catch (Exception ex) {
                bslayer.SaveDebug("ctlKitchenDisplay UpdateResponseTime " + ex.Message);
            }
        }



        public void LoadWaitingKitchenOrders() {
            if (bslayer == null || terminalDistributionList == null)
                return;

            if (blnLoadingKitchenOrders)
                return;
            blnLoadingKitchenOrders = true;
            this.DoubleBuffered = true;

            try {
                List<KitchenOrder> orderList = bslayer.GetKitchenOrdersByStatus(KitchenOrderStatusTypes.Waiting, true, terminalDistributionList);
                for (int i = 0; i < orderList.Count; i++) {
                    if (orderList[i].OrderType == OrderTypes.DirectSale && !bslayer.config.Hold_Order_Display_in_Kitchen)
                        continue;

                    if (orderList[i].OrderType == OrderTypes.InHouse && !bslayer.config.Table_Orders_Display_Kitchen_Orders)
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
                        bslayer.SaveDebug("ctlKitchenDisplay LoadWaitingKitchenOrders remove loop " + exremove.Message);
                    }
                }
                //foreach (Control item in pnlKitchenOrders.Controls) {
                //    ((ctlKitchenOrder)item).AutoSize = true;
                //    ((ctlKitchenOrder)item).pnlMainSetAutoSize(true);
                //}
            } catch (Exception ex) {
                bslayer.SaveDebug("ctlKitchenDisplay LoadWaitingKitchenOrders " + ex.Message);
            }

            blnLoadingKitchenOrders = false;
        }


        public void LoadCompletedOrders() {
            if (bslayer == null || terminalDistributionList == null)
                return;

            if (blnLoadingCompletedOrders)
                return;
            this.DoubleBuffered = true;

            blnLoadingCompletedOrders = true;

            if (blnNeedToShrink)
                btnShrink_Click(null, null);

            //pnlCompletedOrders.Controls.Clear();

            try {
                List<KitchenOrder> orderList = bslayer.GetKitchenOrdersByStatus(KitchenOrderStatusTypes.Completed, true, terminalDistributionList);
                double totalResponseTime = 0;

                for (int i = 0; i < orderList.Count; i++) {
                    if (orderList[i].OrderType == OrderTypes.DirectSale && !bslayer.config.Hold_Order_Display_in_Kitchen)
                        continue;

                    if (orderList[i].OrderType == OrderTypes.InHouse && !bslayer.config.Table_Orders_Display_Kitchen_Orders)
                        continue;


                    KitchenOrder korder = orderList[i];
                    switch (korder.Status) {
                        case KitchenOrderStatusTypes.PartialyCompleted:
                            if (!korder.HasWaitingItem(terminalDistributionList)) {
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
                    lblResponse.Text = DRUF.secondsToMinutes(Math.Floor(totalResponseTime / orderList.Count));
                else
                    lblResponse.Text = "0";
           

            blnNeedToShrink = orderList.Count > bslayer.config.Kitchen_Max_Completed_Order_Count;
            } catch (Exception ex) {
                bslayer.SaveDebug("ctlKitchenDisplay LoadCompletedOrders " + ex.Message);
            }

            blnLoadingCompletedOrders = false;
        }

        private void tmrKitchenOrders_Tick(object sender, EventArgs e) {
            lblClock.Text = DateTime.Now.ToLongTimeString();
            if (blnLoadingCompletedOrders || blnLoadingKitchenOrders)
                return;
            else {
                DateTime theNewKitchenModified = bslayer.GetKitchenModified();

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

        public void DistributionChanged(List<Distribution> theNewList) {
            lblTerminalType.Text = "";
            terminalDistributionList = theNewList;
            for (int i =0; i < terminalDistributionList.Count; i++) {
                lblTerminalType.Text += terminalDistributionList[i].DistributionName + ", ";
            }
            if (lblTerminalType.Text.EndsWith(", "))
                lblTerminalType.Text = lblTerminalType.Text.Substring(0, lblTerminalType.Text.Length - 2);
            LoadAll();
        }

        private void btnShrink_Click(object sender, EventArgs e) {
            bslayer.ShrinkKitchenOrderList();
            LoadCompletedOrders();
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.ParentForm.Close();
        }

        public void RemoveCompletedOrderQuitely(string korderIID) {
            pnlCompletedOrders.Controls.RemoveByKey(korderIID);
        }

        public bool ChangeDistributionVisible { get { return btnStationSelector.Visible; } set { btnStationSelector.Visible = value; } }

    }
}
