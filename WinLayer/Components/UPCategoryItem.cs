using System;
using System.Windows.Forms;
using System.Drawing;
using POSLayer.Library;
using POSLayer.Models;
using WinLayer;
using System.Threading.Tasks;

namespace WinLayer {
    /// <summary>
    /// Summary description for EntityTemplateItem.
    /// </summary>
    public class UPCategoryItem : Button {
        PosConfig config;
        public string IID;
        public CategoryItem categoryItem;
        public string PrintLabel;
        public CategoryItemTypes ButtonType;
        public UPCategory ParentUIE;
        public float Price = 0f;

        /// <summary>
        /// Serialized Constructor
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="Parent"></param>
        /// <param name="entitybutton"></param>
        /// <param name="EditorButton"></param>
        public UPCategoryItem(UPCategory ParentUPEntity, CategoryItem categoryItem) {

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
                        gim = await  BSLayer.Instance.GetGenericImage(categoryItem.IID);
                        if (gim != null)
                            this.Image = UFWin.ReSizeImageTo(UFWin.ToImage(gim.DisplayImage), categoryItem.Height, categoryItem.Height - 10, true);
                        this.Text = "";
                        break;
                    case ButtonDisplayStyles.ImageAndText:
                        gim = await  BSLayer.Instance.GetGenericImage(categoryItem.IID);
                        this.Image = UFWin.ReSizeImageTo(UFWin.ToImage(gim.DisplayImage), categoryItem.Height, categoryItem.Height - 20, true);
                        this.Text = categoryItem.ItemName;
                        break;
                }

                //if (categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.Image || categoryItem.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText) {
                //    this.Image = UFWin.ByteArrayToImage((await  BSLayer.Instance.GetGenericImage(categoryItem.IID))?.DisplayImage); //   Image.FromFile(entitybutton.ImageFileName);
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

            UPCategoryItem geb = this;
            if (geb.categoryItem.ButtonType == CategoryItemTypes.SpaceButton)
                return;

            if ( BSLayer.Instance.AttachedOrder == null)
            {
                if (config.DebugMode)
                   await  BSLayer.Instance.SaveDebug("EB Handle  BSLayer.Instance.AttachedOrder is null");
                return;
            }

            if ( BSLayer.Instance.AttachedOrder.Status == StatusFlags.Completed ||  BSLayer.Instance.AttachedOrder.Status == StatusFlags.Archived)
            {
                if (config.DebugMode)
                   await  BSLayer.Instance.SaveDebug("EB Handle order status completed or archived");
                return;
            }

            //CHECK if EB is applicable to CurrentOrderType
            if (!IsEBApplicableToOrderType(BSLayer.Instance, geb))
            {
                if (config.DebugMode)
                  await   BSLayer.Instance.SaveDebug("EB Handle 125");
                return;
            }

            //HANDLE Extra, Disco , ManagerDisco BUTTON
            if (HandleExtraDiscoManagerItems(BSLayer.Instance, geb))
            {
                if (config.DebugMode)
                   await  BSLayer.Instance.SaveDebug("EB Handle 126");
                goto bypass;
            }

            OrderItem oiNew = new OrderItem();
            oiNew.Quantity = 1;
            oiNew.Price = GetEBRelatedPrice(BSLayer.Instance, geb);
            oiNew.CategoryItemIID = geb.IID;
            oiNew.OrderItemText = geb.PrintLabel;
            oiNew.DistributionIID = geb.categoryItem.DistributionIID; //geb.ParentUIE.entity.DistributionIID;
            oiNew.ItemType = OrderItemTypes.NormalOrderItem;
            oiNew.DOrder = geb.categoryItem.DOrder;
            oiNew.CategoryDisplayOrder = geb.ParentUIE.category.DOrder;
            oiNew.TaxPercent =  BSLayer.Instance.GetEBTaxPercent(geb.categoryItem);


            //UnParented Item - No SizeBar  (Simple or Complex)  Exp= GB or Chicken Wings
            oiNew.OrderIID =  BSLayer.Instance.AttachedOrder.IID;

            //This is true if OrderItemStepable conditions are meet.
            bool blnDisplaySeperately = ( BSLayer.Instance.AttachedOrder.OrderType == OrderTypes.Sitin &&
                                          BSLayer.Instance.AttachedOrder.Status == StatusFlags.Done ||  BSLayer.Instance.AttachedOrder.Status == StatusFlags.New) ||
                                        ( BSLayer.Instance.AttachedOrder.OrderType == OrderTypes.Sale);// &&
                                                                                                   // BSLayer.Instance.config.Hold_Orders_New_Items_Add_Seperately); // &&  BSLayer.Instance.config.Table_Order_Items_Stepable;
            if (blnDisplaySeperately)
                oiNew.OrderGroupIID =  BSLayer.Instance.StepableOrderItemGroupIID;
            else
                oiNew.OrderGroupIID =  BSLayer.Instance.AttachedOrder.IID;

            //--if Item has no subitems  Exp = GB			[Find Existing and increment]
            OrderItem incItem =  BSLayer.Instance.AttachedOrder.GetIncrementableItem(geb.IID, geb.categoryItem.DistributionIID,  BSLayer.Instance.StepableOrderItemGroupIID);

            if (incItem == null)
            {
                if (oiNew.Quantity >= 0)
                     BSLayer.Instance.AttachedOrder.AddOrderItem(oiNew); //202#
            } else
            {
                if (oiNew.Quantity < 0)
                    incItem.Decrement();
                else
                {
                    incItem.Quantity++;
                }
                 BSLayer.Instance.AttachedOrder.blnItemsChanged = true;
            }
        bypass:
            //DISPLAY order
             BSLayer.Instance.OnDisplayOrder();
        }

        private double GetEBRelatedPrice(BSLayer bslayer, UPCategoryItem geb)
        {
            return geb.categoryItem.GetPrice( BSLayer.Instance.AttachedOrder.OrderType);
        }

        private bool HandleExtraDiscoManagerItems(BSLayer bslayer, UPCategoryItem geb)
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
                        exprice =  BSLayer.Instance.AttachedOrder.Total * (GetEBRelatedPrice(bslayer, geb) / 100);
                        break;
                    case CategoryItemTypes.PercentDeduction:
                        exprice = -1 * ( BSLayer.Instance.AttachedOrder.Total * (GetEBRelatedPrice(bslayer, geb) / 100));
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

                 BSLayer.Instance.AttachedOrder.AddOrderItem(POSLayer.Library.ShortGuid.NewDateBasedGuid2(), 1,
                   exprice, geb.IID, geb.PrintLabel, geb.ParentUIE.category.DistributionIID,
                    UF.EBTypeToOrderItemType(geb.ButtonType), geb.categoryItem.DOrder, 
                   geb.ParentUIE.category.DOrder,  BSLayer.Instance.GetEBTaxPercent(geb.categoryItem));

                return true;
            } else
                return false;
        }

        private bool IsEBApplicableToOrderType(BSLayer bslayer, UPCategoryItem geb)
        {
            if (geb.categoryItem.AvailableFor != (int)AvailabilityTypes.All)
            {
                switch ( BSLayer.Instance.AttachedOrder.OrderType)
                {
                    case OrderTypes.Sale:
                        if (!DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.Direct))
                            return false;
                        break;
                    case OrderTypes.Sitin:
                        if (!DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.InHouse))
                            return false;
                        break;
                    case OrderTypes.Delivery:
                        if (!DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.Delivery))
                            return false;
                        break;
                    case OrderTypes.TakeAway:
                        if (!DRNumeric.IsBitSet(geb.categoryItem.AvailableFor, (int)AvailabilityTypes.TakeAway))
                            return false;
                        break;
                }
            }
            return true;
        }

        #endregion  
    }
}
