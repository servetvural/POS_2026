using System;
using System.Windows.Forms;
using System.Drawing;
using PosLibrary;

using POSLayer.Library;

namespace DTRMNS {
    /// <summary>
    /// Summary description for EntityTemplateItem.
    /// </summary>
    public class UPEntityButton : Button {

        public string IID;
        public EntityButton entitybutton;
        public string PrintLabel;
        public EntityButtonTypes ButtonType;
        public UPEntity ParentUIE;
        public float Price = 0f;
        private DTRMSimpleBusiness bslayer;

        /// <summary>
        /// Serialized Constructor
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="Parent"></param>
        /// <param name="entitybutton"></param>
        /// <param name="EditorButton"></param>
        public UPEntityButton(DTRMNS.DTRMSimpleBusiness bs, UPEntity ParentUPEntity, EntityButton entitybutton) {
            
            //new button type construction

            if (entitybutton.ButtonType == EntityButtonTypes.SpaceButton) {
                BackgroundImage = null;
                entitybutton.EntityButtonName = "";
                Enabled = false;
            } else {                
                BackgroundImage = Properties.Resources.shadow;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            this.Padding = new System.Windows.Forms.Padding(0);
            bslayer = bs;
            IID = entitybutton.IID;
            this.entitybutton = entitybutton;
            ParentUIE = ParentUPEntity;

            
            try {
                this.Font = new Font(entitybutton.FFamily, entitybutton.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), entitybutton.FStyle));
            }
            catch {
            }

            this.Click += new System.EventHandler(this.UIEBEventHandler);
            this.Size = new System.Drawing.Size(entitybutton.ButtonWidth, entitybutton.ButtonHeight);
            this.Text = entitybutton.EntityButtonName;
            this.PrintLabel = entitybutton.EntityButtonName;
            this.BackColor = Color.FromArgb(entitybutton.ButtonColor);
            this.ForeColor = Color.FromArgb(entitybutton.ForeColor);
            this.ButtonType = entitybutton.ButtonType;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            try {
                if (entitybutton.WithImage) {
                    this.Image = bs.GetImageFromDatabase(entitybutton.IID); //   Image.FromFile(entitybutton.ImageFileName);
                    this.ImageAlign = ContentAlignment.TopCenter;
                    this.TextAlign = ContentAlignment.BottomCenter;
                }
            }
            catch {
            }
           
        }

        public void ClickTheButton() {
            UIEBEventHandler(this, System.EventArgs.Empty);
        }

        #region EVENT HANDLER
        private void UIEBEventHandler(object sender, System.EventArgs e) {
            //UIEventHandler.HanldeEBClick(bslayer, this);


            UPEntityButton geb = this;
            if (geb.entitybutton.ButtonType == EntityButtonTypes.SpaceButton)
                return;

            if (bslayer.AttachedOrder == null)
            {
                if (bslayer.config.DebugMode)
                    bslayer.SaveDebug("EB Handle bslayer.AttachedOrder is null");
                return;
            }

            if (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED)
            {
                if (bslayer.config.DebugMode)
                    bslayer.SaveDebug("EB Handle order status completed or archived");
                return;
            }

            //CHECK if EB is applicable to CurrentOrderType
            if (!IsEBApplicableToOrderType(bslayer, geb))
            {
                if (bslayer.config.DebugMode)
                    bslayer.SaveDebug("EB Handle 125");
                return;
            }

            //HANDLE Extra, Disco , ManagerDisco BUTTON
            if (HandleExtraDiscoManagerItems(bslayer, geb))
            {
                if (bslayer.config.DebugMode)
                    bslayer.SaveDebug("EB Handle 126");
                goto bypass;
            }

            OrderItem oiNew = new OrderItem();
            oiNew.EntityIID = geb.ParentUIE.IID;
            oiNew.Quantity = 1;
            oiNew.Price = GetEBRelatedPrice(bslayer, geb);
            oiNew.EntityButtonIID = geb.IID;
            oiNew.OrderItemText = geb.PrintLabel;
            oiNew.DistributionIID = geb.entitybutton.DistributionIID; //geb.ParentUIE.entity.DistributionIID;
            oiNew.ItemType = OrderItemTypes.NormalOrderItem;
            oiNew.dorder = geb.entitybutton.DisplayOrder;
            oiNew.EntityName = geb.ParentUIE.entity.EntityName;
            oiNew.EntityDisplayOrder = geb.ParentUIE.entity.DisplayOrder;
            oiNew.TaxPercent = bslayer.GetEBTaxPercent(geb.entitybutton);



            //UnParented Item - No SizeBar  (Simple or Complex)  Exp= GB or Chicken Wings
            oiNew.ParentOrderIID = bslayer.AttachedOrder.IID;

            //This is true if OrderItemStepable conditions are meet.
            bool blnDisplaySeperately = (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse &&
                                         bslayer.AttachedOrder.Status == StatusFlags.DONE || bslayer.AttachedOrder.Status == StatusFlags.NEW) ||
                                        (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale);// &&
                                                                                                   //bslayer.config.Hold_Orders_New_Items_Add_Seperately); // && bslayer.config.Table_Order_Items_Stepable;
            if (blnDisplaySeperately)
                oiNew.OrderGroupIID = bslayer.StepableOrderItemGroupIID;
            else
                oiNew.OrderGroupIID = bslayer.AttachedOrder.IID;
            //oiNew.OrderGroupIID = geb.ParentUIE.OrderGroupIID;


            //--if Item has no subitems  Exp = GB			[Find Existing and increment]
            OrderItem incItem = bslayer.AttachedOrder.GetIncrementableItem(geb.IID, geb.entitybutton.DistributionIID, bslayer.StepableOrderItemGroupIID);

            if (incItem == null)
            {
                if (oiNew.Quantity >= 0)
                    //geb.ParentUIE.OrderGroupIID =
                    bslayer.AttachedOrder.AddOrderItem(oiNew); //202#
            } else
            {
                if (oiNew.Quantity < 0)
                    incItem.Decrement();
                else
                {
                    //if (blnDisplaySeperately)
                    //    bslayer.AttachedOrder.AddOrderItem(oiNew);
                    //else 
                    incItem.Increment();
                }

                bslayer.AttachedOrder.blnItemsChanged = true;
            }


            //Display on the customer display
            //if (bslayer.HasCustomerDisplay())
            //{
            //    string prs = GetEBRelatedPrice(bslayer, geb).ToString("f");
            //    string tot = bslayer.AttachedOrder.GetFullTotal().ToString("f");
            //    int spc = bslayer.config.Customer_Display_Text_Length - prs.Length - 3;
            //    if (geb.PrintLabel.Length >= spc)
            //    {
            //        string msg1 = geb.PrintLabel.ToUpper().Substring(0, spc) + DRFormat.Space(3) + prs +
            //           "TOTAL" + DRFormat.Space(bslayer.config.Customer_Display_Text_Length - tot.Length - 5) + tot;
            //        bslayer.CDSendMessage(msg1, CDAreas.All);
            //        //MessageBox.Show(msg1);
            //    } else
            //    {
            //        string pl = geb.PrintLabel.ToUpper() + DRFormat.Space(spc - geb.PrintLabel.Length);
            //        string msg2 = pl + DRFormat.Space(3) + prs +
            //           "TOTAL" + DRFormat.Space(bslayer.config.Customer_Display_Text_Length - tot.Length - 5) + tot;
            //        bslayer.CDSendMessage(msg2, CDAreas.All);
            //        //MessageBox.Show(msg2);
            //    }
            //}
        bypass:
            //DISPLAY order
            bslayer.OnDisplayOrder();
        }

        private float GetEBRelatedPrice(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            return geb.entitybutton.GetPrice(bslayer.AttachedOrder.OrderType);

        }

        private bool HandleExtraDiscoManagerItems(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            if (geb.ButtonType == EntityButtonTypes.AmountAddition || geb.ButtonType == EntityButtonTypes.AmountDeduction ||
               geb.ButtonType == EntityButtonTypes.PercentAddition || geb.ButtonType == EntityButtonTypes.PercentDeduction ||
               geb.ButtonType == EntityButtonTypes.CustomAddition || geb.ButtonType == EntityButtonTypes.CustomDeduction)
            {

                TrmGetValue fgv = null;

                //Extra and discount management
                float exprice = 0f;

                switch (geb.ButtonType)
                {
                    case EntityButtonTypes.AmountAddition:
                        exprice = GetEBRelatedPrice(bslayer, geb);
                        break;
                    case EntityButtonTypes.AmountDeduction:
                        exprice = GetEBRelatedPrice(bslayer, geb);
                        break;
                    case EntityButtonTypes.PercentAddition:
                        exprice = bslayer.AttachedOrder.GetFullTotal() * (GetEBRelatedPrice(bslayer, geb) / 100);
                        break;
                    case EntityButtonTypes.PercentDeduction:
                        exprice = -1 * (bslayer.AttachedOrder.GetFullTotal() * (GetEBRelatedPrice(bslayer, geb) / 100));
                        break;
                    case EntityButtonTypes.CustomAddition:
                        fgv = new TrmGetValue(NumberModes.FloatMode);
                        if (fgv.ShowDialog() == DialogResult.OK)
                            exprice = fgv.ReturnValue;
                        else
                            return true;
                        break;
                    case EntityButtonTypes.CustomDeduction:
                        fgv = new TrmGetValue(NumberModes.FloatMode);
                        if (fgv.ShowDialog() == DialogResult.OK)
                            exprice = System.Math.Abs(fgv.ReturnValue) * -1;
                        else
                            return true;
                        break;
                }

                bslayer.AttachedOrder.AddOrderItem(geb.ParentUIE.IID, ShortGuid.NewDateBasedGuid2(), 1,
                   exprice, geb.IID, geb.PrintLabel, geb.ParentUIE.entity.DistributionIID,
                    UF.EBTypeToOrderItemType(geb.ButtonType), geb.entitybutton.DisplayOrder, geb.ParentUIE.entity.EntityName,
                   geb.ParentUIE.entity.DisplayOrder, bslayer.GetEBTaxPercent(geb.entitybutton));


                //bslayer.AttachedOrder.AddOrderItem(geb.ParentUIE.IID, ShortGuid.NewGuid().ToString(), 1,
                //  exprice, geb.IID, geb.PrintLabel, geb.ParentUIE.entity.DistributionIID,
                //   UF.EBTypeToOrderItemType(geb.ButtonType), geb.entitybutton.DisplayOrder, geb.ParentUIE.entity.EntityName,
                //  geb.ParentUIE.entity.DisplayOrder, bslayer.GetEBTaxPercent(geb.entitybutton));


                //Display on the customer display
                //if (bslayer.HasCustomerDisplay())
                //{
                //    string prs = exprice.ToString("f"); //.Substring(1);
                //    string tot = bslayer.AttachedOrder.GetFullTotal().ToString("f");
                //    int spc = bslayer.config.Customer_Display_Text_Length - prs.Length - 3;
                //    if (geb.PrintLabel.Length >= spc)
                //        bslayer.CDSendMessage(geb.PrintLabel.ToUpper().Substring(0, spc) + DRFormat.Space(3) + prs +
                //           "TOTAL" + DRFormat.Space(bslayer.config.Customer_Display_Text_Length - tot.Length - 5) + tot, CDAreas.All);
                //    else
                //    {
                //        string pl = geb.PrintLabel.ToUpper() + DRFormat.Space(spc - geb.PrintLabel.Length);
                //        bslayer.CDSendMessage(pl + DRFormat.Space(3) + prs +
                //           "TOTAL" + DRFormat.Space(bslayer.config.Customer_Display_Text_Length - tot.Length - 5) + tot, CDAreas.All);
                //    }
                //}

                return true;
            } else
                return false;
        }

        private bool IsEBApplicableToOrderType(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            if (geb.entitybutton.AvailableFor != (int)AvailabilityTypes.All)
            {
                switch (bslayer.AttachedOrder.OrderType)
                {
                    case OrderTypes.DirectSale:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.entitybutton.AvailableFor, (int)AvailabilityTypes.Direct))
                            return false;
                        break;
                    case OrderTypes.InHouse:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.entitybutton.AvailableFor, (int)AvailabilityTypes.InHouse))
                            return false;
                        break;
                    case OrderTypes.Delivery:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.entitybutton.AvailableFor, (int)AvailabilityTypes.Delivery))
                            return false;
                        break;
                    case OrderTypes.TakeAwayB:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.entitybutton.AvailableFor, (int)AvailabilityTypes.TakeAwayB))
                            return false;
                        break;
                    case OrderTypes.InternetTakeAway:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.entitybutton.AvailableFor, (int)AvailabilityTypes.InternetTakeAway))
                            return false;
                        break;
                    case OrderTypes.InternetDelivery:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.entitybutton.AvailableFor, (int)AvailabilityTypes.InternetDelivery))
                            return false;
                        break;
                }
            }
            return true;
        }

        #endregion  
    }
}
