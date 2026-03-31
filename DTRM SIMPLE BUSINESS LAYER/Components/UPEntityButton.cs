using System;
using System.Windows.Forms;
using System.Drawing;
using PosLibrary;

using POSLayer.Library;
using POSLayer.Models;

using POSWinFormLayer;

namespace DTRMNS {
    /// <summary>
    /// Summary description for EntityTemplateItem.
    /// </summary>
    public class UPEntityButton : Button {
        PosConfig config;
        public string IID;
        public CategoryItem entitybutton;
        public string PrintLabel;
        public CategoryItemTypes ButtonType;
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
        public UPEntityButton(PosConfig configAsService, DTRMSimpleBusiness bs, UPEntity ParentUPEntity, CategoryItem entitybutton) {
            
            config = configAsService;
            //new button type construction

            if (entitybutton.ButtonType == CategoryItemTypes.SpaceButton) {
                BackgroundImage = null;
                entitybutton.ItemName = "";
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
                this.Font = new Font(entitybutton.FFamily, (float)entitybutton.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), entitybutton.FStyle));
            }
            catch {
            }

            this.Click += new System.EventHandler(this.UIEBEventHandler);
            this.Size = new System.Drawing.Size(entitybutton.Width, entitybutton.Height);
            this.Text = entitybutton.ItemName;
            this.PrintLabel = entitybutton.ItemName;
            this.BackColor = Color.FromArgb(entitybutton.BgColor);
            this.ForeColor = Color.FromArgb(entitybutton.FgColor);
            this.ButtonType = entitybutton.ButtonType;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            try {
                if (entitybutton.ButtonDisplayStyle == ButtonDisplayStyles.Image || entitybutton.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText) {
                    this.Image = UFWin.ByteArrayToImage( bs.GetGenericImage(entitybutton.IID).Result.DisplayImage); //   Image.FromFile(entitybutton.ImageFileName);
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

            UPEntityButton geb = this;
            if (geb.entitybutton.ButtonType == CategoryItemTypes.SpaceButton)
                return;

            if (bslayer.AttachedOrder == null)
            {
                if (config.DebugMode)
                    bslayer.SaveDebug("EB Handle bslayer.AttachedOrder is null");
                return;
            }

            if (bslayer.AttachedOrder.Status == StatusFlags.COMPLETED || bslayer.AttachedOrder.Status == StatusFlags.ARCHIVED)
            {
                if (config.DebugMode)
                    bslayer.SaveDebug("EB Handle order status completed or archived");
                return;
            }

            //CHECK if EB is applicable to CurrentOrderType
            if (!IsEBApplicableToOrderType(bslayer, geb))
            {
                if (config.DebugMode)
                    bslayer.SaveDebug("EB Handle 125");
                return;
            }

            //HANDLE Extra, Disco , ManagerDisco BUTTON
            if (HandleExtraDiscoManagerItems(bslayer, geb))
            {
                if (config.DebugMode)
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
            oiNew.DOrder = geb.entitybutton.DOrder;
            oiNew.EntityName = geb.ParentUIE.entity.CategoryName;
            oiNew.EntityDisplayOrder = geb.ParentUIE.entity.DOrder;
            oiNew.TaxPercent = bslayer.GetEBTaxPercent(geb.entitybutton);


            //UnParented Item - No SizeBar  (Simple or Complex)  Exp= GB or Chicken Wings
            oiNew.OrderIID = bslayer.AttachedOrder.IID;

            //This is true if OrderItemStepable conditions are meet.
            bool blnDisplaySeperately = (bslayer.AttachedOrder.OrderType == OrderTypes.InHouse &&
                                         bslayer.AttachedOrder.Status == StatusFlags.DONE || bslayer.AttachedOrder.Status == StatusFlags.NEW) ||
                                        (bslayer.AttachedOrder.OrderType == OrderTypes.DirectSale);// &&
                                                                                                   //bslayer.config.Hold_Orders_New_Items_Add_Seperately); // && bslayer.config.Table_Order_Items_Stepable;
            if (blnDisplaySeperately)
                oiNew.OrderGroupIID = bslayer.StepableOrderItemGroupIID;
            else
                oiNew.OrderGroupIID = bslayer.AttachedOrder.IID;

            //--if Item has no subitems  Exp = GB			[Find Existing and increment]
            OrderItem incItem = bslayer.AttachedOrder.GetIncrementableItem(geb.IID, geb.entitybutton.DistributionIID, bslayer.StepableOrderItemGroupIID);

            if (incItem == null)
            {
                if (oiNew.Quantity >= 0)
                    bslayer.AttachedOrder.AddOrderItem(oiNew); //202#
            } else
            {
                if (oiNew.Quantity < 0)
                    incItem.Decrement();
                else
                {
                    incItem.Quantity++;
                }
                bslayer.AttachedOrder.blnItemsChanged = true;
            }
        bypass:
            //DISPLAY order
            bslayer.OnDisplayOrder();
        }

        private double GetEBRelatedPrice(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            return geb.entitybutton.GetPrice(bslayer.AttachedOrder.OrderType);
        }

        private bool HandleExtraDiscoManagerItems(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            if (geb.ButtonType == CategoryItemTypes.AmountAddition || geb.ButtonType == CategoryItemTypes.AmountDeduction ||
               geb.ButtonType == CategoryItemTypes.PercentAddition || geb.ButtonType == CategoryItemTypes.PercentDeduction ||
               geb.ButtonType == CategoryItemTypes.CustomAddition || geb.ButtonType == CategoryItemTypes.CustomDeduction)
            {

                TrmGetValue fgv = null;

                //Extra and discount management
                double exprice = 0f;

                switch (geb.ButtonType)
                {
                    case CategoryItemTypes.AmountAddition:
                        exprice = GetEBRelatedPrice(bslayer, geb);
                        break;
                    case CategoryItemTypes.AmountDeduction:
                        exprice = GetEBRelatedPrice(bslayer, geb);
                        break;
                    case CategoryItemTypes.PercentAddition:
                        exprice = bslayer.AttachedOrder.GetFullTotal() * (GetEBRelatedPrice(bslayer, geb) / 100);
                        break;
                    case CategoryItemTypes.PercentDeduction:
                        exprice = -1 * (bslayer.AttachedOrder.GetFullTotal() * (GetEBRelatedPrice(bslayer, geb) / 100));
                        break;
                    case CategoryItemTypes.CustomAddition:
                        fgv = new TrmGetValue(NumberModes.FloatMode);
                        if (fgv.ShowDialog() == DialogResult.OK)
                            exprice = fgv.ReturnValue;
                        else
                            return true;
                        break;
                    case CategoryItemTypes.CustomDeduction:
                        fgv = new TrmGetValue(NumberModes.FloatMode);
                        if (fgv.ShowDialog() == DialogResult.OK)
                            exprice = System.Math.Abs(fgv.ReturnValue) * -1;
                        else
                            return true;
                        break;
                }

                bslayer.AttachedOrder.AddOrderItem(geb.ParentUIE.IID, POSLayer.Library.ShortGuid.NewDateBasedGuid2(), 1,
                   exprice, geb.IID, geb.PrintLabel, geb.ParentUIE.entity.DistributionIID,
                    UF.EBTypeToOrderItemType(geb.ButtonType), geb.entitybutton.DOrder, geb.ParentUIE.entity.CategoryName,
                   geb.ParentUIE.entity.DOrder, bslayer.GetEBTaxPercent(geb.entitybutton));

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
