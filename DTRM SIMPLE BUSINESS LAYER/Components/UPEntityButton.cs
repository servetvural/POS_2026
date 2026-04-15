using System;
using System.Windows.Forms;
using System.Drawing;
using PosLibrary;

using POSLayer.Library;
using POSLayer.Models;

using POSWinFormLayer;
using System.Threading.Tasks;

namespace DTRMNS {
    /// <summary>
    /// Summary description for EntityTemplateItem.
    /// </summary>
    public class UPEntityButton : Button {
        PosConfig config;
        public string IID;
        public CategoryItem categoryItem;
        public string PrintLabel;
        public CategoryItemTypes ButtonType;
        public UPEntity ParentUIE;
        public float Price = 0f;

        /// <summary>
        /// Serialized Constructor
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="Parent"></param>
        /// <param name="entitybutton"></param>
        /// <param name="EditorButton"></param>
        public UPEntityButton(UPEntity ParentUPEntity, CategoryItem categoryItem) {

            config = ServiceHelper.GetService<PosConfig>();
            //new button type construction

            if (categoryItem.ButtonType == CategoryItemTypes.SpaceButton) {
                BackgroundImage = null;
                categoryItem.ItemName = "";
                Enabled = false;
            } else {
                BackgroundImage = Properties.Resources.shadow;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            this.Padding = new System.Windows.Forms.Padding(0);
            IID = categoryItem.IID;
            this.categoryItem = categoryItem;
            ParentUIE = ParentUPEntity;

            LoadUI();
        }

        async Task LoadUI() { 
            
            try {
                this.Font = new Font(categoryItem.FFamily, (float)categoryItem.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), categoryItem.FStyle));
            }
            catch {
            }

            this.Click += new System.EventHandler(this.UIEBEventHandler);
            this.Size = new System.Drawing.Size(categoryItem.Width, categoryItem.Height);
            this.Text = categoryItem.ItemName;
            this.PrintLabel = categoryItem.ItemName;
            this.BackColor = Color.FromArgb(categoryItem.BgColor);
            this.ForeColor = Color.FromArgb(categoryItem.FgColor);
            this.ButtonType = categoryItem.ButtonType;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            this.ImageAlign = (ContentAlignment)categoryItem.ImageAlign;
            this.TextAlign = (ContentAlignment)categoryItem.TextAlign;
            this.TextImageRelation = (TextImageRelation)categoryItem.TextImageRelation;
            try {
                GenericImage gim = null;
                switch (categoryItem.ButtonDisplayStyle)
                {
                    case ButtonDisplayStyles.Text:
                        this.Image = null;
                        this.Text = categoryItem.ItemName;
                        break;
                    case ButtonDisplayStyles.Image:
                        gim = await  DTRMSimpleBusiness.Instance.GetGenericImage(categoryItem.IID);
                        if (gim != null)
                            this.Image = UFWin.ReSizeImageTo(UFWin.ToImage(gim.DisplayImage), categoryItem.Height, categoryItem.Height - 10, true);
                        this.Text = "";
                        break;
                    case ButtonDisplayStyles.ImageAndText:
                        gim = await  DTRMSimpleBusiness.Instance.GetGenericImage(categoryItem.IID);
                        this.Image = UFWin.ReSizeImageTo(UFWin.ToImage(gim.DisplayImage), categoryItem.Height, categoryItem.Height - 20, true);
                        this.Text = categoryItem.ItemName;
                        break;
                }

                //if (categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.Image || categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText) {
                //    this.Image = UFWin.ByteArrayToImage((await  DTRMSimpleBusiness.Instance.GetGenericImage(categoryItem.IID))?.DisplayImage); //   Image.FromFile(entitybutton.ImageFileName);
                //    this.ImageAlign = ContentAlignment.TopCenter;
                //    this.TextAlign = ContentAlignment.BottomCenter;
                //}
            }
            catch {
            }             
        }
        public void ClickTheButton() {
            UIEBEventHandler(this, System.EventArgs.Empty);
        }

        #region EVENT HANDLER
        private async void UIEBEventHandler(object sender, System.EventArgs e) {

            UPEntityButton geb = this;
            if (geb.categoryItem.ButtonType == CategoryItemTypes.SpaceButton)
                return;

            if ( DTRMSimpleBusiness.Instance.AttachedOrder == null)
            {
                if (config.DebugMode)
                   await  DTRMSimpleBusiness.Instance.SaveDebug("EB Handle  DTRMSimpleBusiness.Instance.AttachedOrder is null");
                return;
            }

            if ( DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Completed ||  DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Archived)
            {
                if (config.DebugMode)
                   await  DTRMSimpleBusiness.Instance.SaveDebug("EB Handle order status completed or archived");
                return;
            }

            //CHECK if EB is applicable to CurrentOrderType
            if (!IsEBApplicableToOrderType(DTRMSimpleBusiness.Instance, geb))
            {
                if (config.DebugMode)
                  await   DTRMSimpleBusiness.Instance.SaveDebug("EB Handle 125");
                return;
            }

            //HANDLE Extra, Disco , ManagerDisco BUTTON
            if (HandleExtraDiscoManagerItems(DTRMSimpleBusiness.Instance, geb))
            {
                if (config.DebugMode)
                   await  DTRMSimpleBusiness.Instance.SaveDebug("EB Handle 126");
                goto bypass;
            }

            OrderItem oiNew = new OrderItem();
            oiNew.Quantity = 1;
            oiNew.Price = GetEBRelatedPrice(DTRMSimpleBusiness.Instance, geb);
            oiNew.CategoryItemIID = geb.IID;
            oiNew.OrderItemText = geb.PrintLabel;
            oiNew.DistributionIID = geb.categoryItem.DistributionIID; //geb.ParentUIE.entity.DistributionIID;
            oiNew.ItemType = OrderItemTypes.NormalOrderItem;
            oiNew.DOrder = geb.categoryItem.DOrder;
            oiNew.CategoryDisplayOrder = geb.ParentUIE.category.DOrder;
            oiNew.TaxPercent =  DTRMSimpleBusiness.Instance.GetEBTaxPercent(geb.categoryItem);


            //UnParented Item - No SizeBar  (Simple or Complex)  Exp= GB or Chicken Wings
            oiNew.OrderIID =  DTRMSimpleBusiness.Instance.AttachedOrder.IID;

            //This is true if OrderItemStepable conditions are meet.
            bool blnDisplaySeperately = ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sitin &&
                                          DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.Done ||  DTRMSimpleBusiness.Instance.AttachedOrder.Status == StatusFlags.New) ||
                                        ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType == OrderTypes.Sale);// &&
                                                                                                   // DTRMSimpleBusiness.Instance.config.Hold_Orders_New_Items_Add_Seperately); // &&  DTRMSimpleBusiness.Instance.config.Table_Order_Items_Stepable;
            if (blnDisplaySeperately)
                oiNew.OrderGroupIID =  DTRMSimpleBusiness.Instance.StepableOrderItemGroupIID;
            else
                oiNew.OrderGroupIID =  DTRMSimpleBusiness.Instance.AttachedOrder.IID;

            //--if Item has no subitems  Exp = GB			[Find Existing and increment]
            OrderItem incItem =  DTRMSimpleBusiness.Instance.AttachedOrder.GetIncrementableItem(geb.IID, geb.categoryItem.DistributionIID,  DTRMSimpleBusiness.Instance.StepableOrderItemGroupIID);

            if (incItem == null)
            {
                if (oiNew.Quantity >= 0)
                     DTRMSimpleBusiness.Instance.AttachedOrder.AddOrderItem(oiNew); //202#
            } else
            {
                if (oiNew.Quantity < 0)
                    incItem.Decrement();
                else
                {
                    incItem.Quantity++;
                }
                 DTRMSimpleBusiness.Instance.AttachedOrder.blnItemsChanged = true;
            }
        bypass:
            //DISPLAY order
             DTRMSimpleBusiness.Instance.OnDisplayOrder();
        }

        private double GetEBRelatedPrice(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            return geb.categoryItem.GetPrice( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType);
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
                        exprice =  DTRMSimpleBusiness.Instance.AttachedOrder.Total * (GetEBRelatedPrice(bslayer, geb) / 100);
                        break;
                    case CategoryItemTypes.PercentDeduction:
                        exprice = -1 * ( DTRMSimpleBusiness.Instance.AttachedOrder.Total * (GetEBRelatedPrice(bslayer, geb) / 100));
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

                 DTRMSimpleBusiness.Instance.AttachedOrder.AddOrderItem(POSLayer.Library.ShortGuid.NewDateBasedGuid2(), 1,
                   exprice, geb.IID, geb.PrintLabel, geb.ParentUIE.category.DistributionIID,
                    UF.EBTypeToOrderItemType(geb.ButtonType), geb.categoryItem.DOrder, 
                   geb.ParentUIE.category.DOrder,  DTRMSimpleBusiness.Instance.GetEBTaxPercent(geb.categoryItem));

                return true;
            } else
                return false;
        }

        private bool IsEBApplicableToOrderType(DTRMSimpleBusiness bslayer, UPEntityButton geb)
        {
            if (geb.categoryItem.AvailableFor != (int)AvailabilityTypes.All)
            {
                switch ( DTRMSimpleBusiness.Instance.AttachedOrder.OrderType)
                {
                    case OrderTypes.Sale:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.Direct))
                            return false;
                        break;
                    case OrderTypes.Sitin:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.InHouse))
                            return false;
                        break;
                    case OrderTypes.Delivery:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.Delivery))
                            return false;
                        break;
                    case OrderTypes.TakeAway:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.TakeAway))
                            return false;
                        break;
                    case OrderTypes.InternetTakeAway:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.InternetTakeAway))
                            return false;
                        break;
                    case OrderTypes.InternetDelivery:
                        if (!PosLibrary.DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.InternetDelivery))
                            return false;
                        break;
                }
            }
            return true;
        }

        #endregion  
    }
}
