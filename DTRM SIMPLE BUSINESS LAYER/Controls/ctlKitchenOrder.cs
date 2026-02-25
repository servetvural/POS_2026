using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PosLibrary;

namespace DTRMNS {
    public partial class ctlKitchenOrder : UserControl {
        public DTRMSimpleBusiness bslayer;
        public KitchenOrder korder;
        public bool blnWaiting;
        public double singleResponseTime = 0;
        public double totalSeconds;
        public List<Distribution> terminalTypeList;
        public bool blnDisplayDetails;

        public bool blnBeingAltered;

        Font mainFont;// = new Font("Arial", bslayer.config.Kitchen_Large_Font_Size, FontStyle.Bold);
        Font subFont; // = new Font("Arial", bslayer.config.Kitchen_Small_Font_Size, FontStyle.Regular);
        Font detailFont; // = new Font("Arial", bslayer.config.Kitchen_Detail_Font_Size, FontStyle.Regular);

        public event KitchenEventHandler OrderCompleteRequested;
        public void OnOrderCompleted(KitchenOrder kitchenOrder) {
            OrderCompleteRequested?.Invoke(kitchenOrder);
        }

        public event SimpleStringEventHandler OrderDeleteRequested;
        public void OnOrderDeleteRequested(string korderIID) {
            OrderDeleteRequested?.Invoke(korderIID);
        }


        public ctlKitchenOrder() {
            InitializeComponent();
        }
        public ctlKitchenOrder(DTRMSimpleBusiness bslayer, KitchenOrder korder, List<Distribution> terminalTypeList, bool blnWaiting,bool blnDisplayDetails) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.korder = korder;
            this.Name = korder.IID;
            this.terminalTypeList = terminalTypeList;
            this.blnWaiting = blnWaiting;
            this.blnDisplayDetails = blnDisplayDetails;
            pBar.Maximum = bslayer.config.Kitchen_Prep_Bad_Time;
            pBar.Value = 0;
            pBar.Visible = false;

            mainFont = new Font("Arial", bslayer.config.Kitchen_Large_Font_Size, FontStyle.Bold);
            subFont = new Font("Arial", bslayer.config.Kitchen_Small_Font_Size, FontStyle.Regular);
            detailFont = new Font("Arial", bslayer.config.Kitchen_Detail_Font_Size, FontStyle.Regular);

            
           
        }
        

        private void CtlKitchenOrder_Load(object sender, EventArgs e) {
            if (bslayer != null && korder != null)
                LoadKitchenOrder();
        }

        public void Reload(KitchenOrder korder) {
            this.korder = korder;
            Reset();
            LoadKitchenOrder();
        }

        public void PnlMainSetAutoSize(bool blnWhat) {
            pnlMain.AutoSize = blnWhat;
        }


        private void LoadKitchenOrder() {
          
            try {
               // SuspendLayout();
                //Disable or Enable the button which does "Mark as Completed" or "Delete"
                //blnBeingAltered = !korder.Modified;
                //btnDone.Visible = !korder.BeingModified;
                
                if (blnWaiting) {
                    if (korder.BeingModified)
                        btnDone.Image = Properties.Resources.exclamationtri32;
                    else
                        btnDone.Image = Properties.Resources.right32;
                    lblTime.Font = subFont;
                    totalSeconds = DateTime.Now.Subtract(korder.CreatedDateTime).TotalSeconds;
                    //chkTime.Text = korder.CreatedDateTime.ToString("HH:mm:ss") + " | " + UF.secondsToMinutes(totalSeconds);
                    lblTime.Text = DRUF.secondsToMinutes(DateTime.Now.Subtract(korder.CreatedDateTime).TotalSeconds);
                } else {
                    btnDone.Image = Properties.Resources.Cancel;
                    lblTime.Font = subFont;
                    singleResponseTime = korder.CompletedDateTime.Subtract(korder.CreatedDateTime).TotalSeconds;
                    //chkTime.Text = korder.CreatedDateTime.ToString("HH:mm:ss") + " | " +
                    //    korder.CompletedDateTime.ToString("HH:mm:ss") + " | " + UF.secondsToMinutes(singleResponseTime);
                    lblTime.Text = korder.CreatedDateTime.ToString("HH:mm:ss") + " | " + DRUF.secondsToMinutes(singleResponseTime);
                }

                //lblTime.Height = lblTime.Font.Height;


                btnDone.Font = mainFont;
                btnDone.Text = korder.OrderNo.ToString();

                switch (korder.OrderType) {
                    case OrderTypes.DirectSale:
                        pnlColor.BackColor = Color.FromName(korder.Reference);
                        break;
                    case OrderTypes.InHouse:
                        pnlColor.BackColor = Color.White;
                        lblReference.Text = korder.Reference;
                        lblReference.BackColor = Color.Yellow;
                        break;
                    case OrderTypes.TakeAwayB:
                        pnlColor.BackColor = Color.White;
                        lblReference.Text = korder.Reference;
                        lblReference.BackColor = Color.Yellow;
                        break;
                    case OrderTypes.Delivery:
                        pnlColor.BackColor = Color.White;
                        lblReference.Text = korder.Reference;
                        lblReference.BackColor = Color.Yellow;
                        break;

                }
                

                korder.ReorderForDistributionList(terminalTypeList, false);
                bool blnExpand = false;
                for (int i = 0; i < korder.items.Count; i++) {
                    int step = 0;
                    try {
                        KitchenOrderItem koi = korder.items[i];
                        step = 1;
                        ctlKitchenOrderItem ctlkoi = new ctlKitchenOrderItem();
                        ctlkoi.ActiveLabel.Text = "";
                        ctlkoi.DetailLabel.Text = "";
                        step = 2;

                        if (koi.Status == KitchenOrderStatusTypes.Completed)
                            ctlkoi.ActiveLabel.TextAlign = ContentAlignment.MiddleRight;
                        else
                            ctlkoi.ActiveLabel.TextAlign = ContentAlignment.MiddleLeft;

                        step = 3;

                        if (blnWaiting && (terminalTypeList.Find(x => x.IID == koi.DistributionIID) != null) && koi.Status == KitchenOrderStatusTypes.Waiting)
                            ctlkoi.ActiveLabel.Font = mainFont;
                        else {
                            ctlkoi.ActiveLabel.Font = subFont;
                            ctlkoi.ActiveLabel.TextAlign = ContentAlignment.MiddleRight;
                        }
                        step = 4; 

                        ctlkoi.Tag = koi;

                        step = 5;
                        ctlkoi.ActiveLabel.Text += koi.Quantity + "  " + koi.ItemText;
                        if (koi.Status == KitchenOrderStatusTypes.Completed) {
                            ctlkoi.ActiveLabel.Text = "      " + ctlkoi.ActiveLabel.Text + "       ";
                            ctlkoi.ActiveLabel.Image = Properties.Resources.okay24;
                            ctlkoi.ActiveLabel.ImageAlign = ContentAlignment.MiddleRight;
                            ctlkoi.PBox.Visible = false;
                            ctlkoi.DetailLabel.Visible = false;
                            pnlButtons.Height = 0;
                            step = 6;
                        } else {
                            if (blnDisplayDetails && (terminalTypeList.Find(x => x.IID == koi.DistributionIID) != null)) {
                                GenericImage prepImage = bslayer.GetEntityButtonPrepImage(koi.EntityButtonIID);
                                if (prepImage != null) {
                                    ctlkoi.PBox.Visible = true;
                                    ctlkoi.DetailLabel.Visible = true;
                                    ctlkoi.PBox.BackgroundImage = prepImage.DisplayImage;
                                    ctlkoi.DetailLabel.Text = prepImage.ExtraText;
                                    ctlkoi.DetailLabel.Font = detailFont;
                                    ctlkoi.bslayer = bslayer;
                                    ctlkoi.korderitem = koi;
                                    ctlkoi.ShowFullScreen = bslayer.config.Display_Kitchen_FullScreen_on_Display;
                                    blnExpand = true;
                                    step = 7;
                                }
                            }
                            ctlkoi.AutoSize = false;
                            step = 8;
                            if (blnExpand) {
                                ctlkoi.Height = ctlkoi.ActiveLabel.Font.Height + ctlkoi.DetailLabel.Height + 10;
                                step = 9;
                                if (bslayer.config.Kitchen_Can_Print)
                                    pnlButtons.Height = 64;
                                blnExpand = false;
                                step = 10; 
                            } else {
                                ctlkoi.Height = ctlkoi.ActiveLabel.Font.Height + 3;
                                //ctlkoi.ActiveLabel.TextAlign = ContentAlignment.TopLeft;
                                pnlButtons.Height = 0;
                                step = 11;
                            }
                        }
                        step = 12;
                        ctlkoi.Dock = DockStyle.Top;
                        pnlMain.Controls.Add(ctlkoi);
                        ctlkoi.Click += Ctlkoi_Click;
                        step = 13;
                                                
                    } catch (Exception ex) {
                        bslayer.SaveDebug("ctlKitchenOrder step value lien 205 : " + step.ToString());
                        bslayer.SaveDebug("ctlKitchenOrder LoadKitchenOrder 1 " + ex.Message + " ===Stack Trace =" + ex.StackTrace);
                    }               
                
                }

            } catch (Exception ex) {
                bslayer.SaveDebug("ctlKitchenOrder  LoadKitchenOrder 2 " + ex.Message);
            }

          //  ResumeLayout();
        }

        public void Flash(bool blnflash) {
            tmrMain.Enabled = blnflash;
        }

        private void Ctlkoi_Click(object sender, EventArgs e) {
            blnDisplayDetails = !blnDisplayDetails;
            Reload(korder);
        }

        public void Reset() {
            try {
                pnlMain.Controls.Clear();
                pnlColor.BackColor = Color.Black;
                lblTime.Text = "00";
                btnDone.Image = Properties.Resources.right32;
                btnDone.Text = "";
                totalSeconds = 0;
                singleResponseTime = 0;
            } catch (Exception ex) {
                bslayer.SaveDebug("ctlKitchenOrder Reset " + ex.Message);
            }
        }

        private void BtnDone_Click(object sender, EventArgs e) {

            if (blnWaiting) {
                korder.BeingModified = bslayer.IsKitchenOrderBeingModified(korder.IID);
                if (!korder.BeingModified) {
                    MarkOrderItemsAsCompletedAsRequestedQuantity();
                    OrderCompleteRequested(korder);
                    tmrMain.Enabled = false;
                } else {
                    //btnDone.Image = Properties.Resources.exclamationtri32;
                }
            }else {
                OrderDeleteRequested(korder.IID);
            }
        }


        private void MarkOrderItemsAsCompletedAsRequestedQuantity() {
            if (bslayer.config.DebugMode) 
                bslayer.OnImmediateDebugOccured("MarkOrderItemsAsCompletedAsRequestedQuantity Starting @ " + DateTime.Now.ToLongTimeString());

            korder.CompletedDateTime = DateTime.Parse(bslayer.db.GetDataTable("Select getdate()").Rows[0][0].ToString());
            Order relatedOrder = bslayer.GetOrder(korder.OrderIID);
            if (relatedOrder == null) {
                foreach (KitchenOrderItem item in korder.items) {
                    item.Status = KitchenOrderStatusTypes.Completed;
                }
                bslayer.SaveKitchenOrder(korder);

            } else {
                foreach (KitchenOrderItem item in korder.items) {
                    if (blnWaiting && (terminalTypeList.Find(x => x.IID == item.DistributionIID) != null) && item.Status == KitchenOrderStatusTypes.Waiting) {
                        
                        OrderItem oitem = relatedOrder.items.Find(x => x.EntityButtonIID == item.EntityButtonIID);
                        if (oitem != null)
                            oitem.CompletedQuantity += item.Quantity;
                        item.Status = KitchenOrderStatusTypes.Completed;
                    }                    
                }

                bslayer.SaveOrder(relatedOrder);
                if (bslayer.config.DebugMode) 
                    bslayer.OnImmediateDebugOccured("Saved Order Done @ " + DateTime.Now.ToLongTimeString());

                bslayer.SaveKitchenOrder(korder);
                if (bslayer.config.DebugMode)
                    bslayer.OnImmediateDebugOccured("Saved Kitchen Order Done @ " + DateTime.Now.ToLongTimeString());
                
            }

            
        }

        private void PnlColor_Click(object sender, EventArgs e) {
                    
        }

        private void TmrMain_Tick(object sender, EventArgs e) {
            if (blnWaiting) {
                
                double waitingtime = DateTime.Now.Subtract(korder.CreatedDateTime).TotalSeconds;
                if (waitingtime > (double)bslayer.config.Kitchen_Prep_Bad_Time) {
                    if (btnDone.BackColor == Color.Black) {
                        btnDone.BackColor = Color.Red;                        
                    } else
                        btnDone.BackColor = Color.Black;                   
                }
                lblTime.Text = DRUF.secondsToMinutes(waitingtime);

                //This section for progress Bar if visible
                if (bslayer.config.Kitchen_Show_Progress_Bar)
                {
                    pBar.Visible = true;
                    if (waitingtime > (double)bslayer.config.Kitchen_Prep_Bad_Time)
                    {
                        pBar.Value = pBar.Maximum;
                        pBar.BackColor = Color.Red;
                    }
                    else
                    {
                        pBar.BackColor = Color.ForestGreen;
                        if (waitingtime < pBar.Maximum)
                            pBar.Value += 1;
                        else
                            pBar.Value = pBar.Maximum;
                    }
                }
                else
                    pBar.Visible = false;
                ////

                pnlPayment.Visible = !bslayer.isOrderPaid(korder.OrderIID);
            }         
        }

        private void BtnPrint_Click(object sender, EventArgs e) {
            ApplicationPrinter ap = bslayer.GetDefaultReceiptPrinter();  
            if (ap == null)
                return;

            bslayer.PrintForKitchen(korder, ap);
        }

        private void BtnPrintAsReceipt_Click(object sender, EventArgs e) {
            ApplicationPrinter ap = bslayer.GetDefaultReceiptPrinter(); 
            if (ap == null)
                return;

            bslayer.PrintReceipt(korder.OrderIID, ap, 1);
        }

        private void BtnPrintWithDetails_Click(object sender, EventArgs e) {
            ApplicationPrinter ap = bslayer.GetDefaultReceiptPrinter();
            if (ap == null)
                return;

            bslayer.PrintForKitchen(korder, ap, true);
        }

        private void btnFullScreen_Click(object sender, EventArgs e) {
            
        }
    }
}
