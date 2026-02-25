using System.Data;
using System.Drawing;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class EntityButton
    {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }

        public string EntityButtonName { get; set; }   
        public int DisplayOrder { get; set; }
        public int ButtonColor { get; set; }
        public int ForeColor { get; set; }
        public EntityButtonTypes ButtonType { get; set; }
        public int AvailableFor { get; set; }
        public string PEIID { get; set; }
        public string ParentMenuIID { get; set; }
        public int Compulsary { get; set; }
        public string Barcode { get; set; }
        public float DirectSaleTaxPercent { get; set; }
        public float InHouseTaxPercent { get; set; }
        public float TakeAwayTaxPercent { get; set; }
        public float DeliveryTaxPercent { get; set; }
        public PadFlags PadFlag;

        public string DistributionIID { get; set; }

        public float DirectSalePrice { get; set; }
        public float InHousePrice { get; set; }
        public float TakeAwayPrice { get; set; }
        public float DeliveryPrice { get; set; }

        public int ButtonWidth { get; set; }
        public int ButtonHeight { get; set; }
        public string FFamily { get; set; }
        public float FSize { get; set; }
        public string FStyle { get; set; }

        public bool WithImage { get; set; }

        public EntityButton()
        {
            EntityButtonName = "";
            DisplayOrder = 0;
            ButtonColor = SystemColors.Control.ToArgb();
            ForeColor = Color.Black.ToArgb();
            ButtonType = EntityButtonTypes.SimpleItem;
            AvailableFor = (int)AvailabilityTypes.All;
            PEIID = "";
            Compulsary = 0;
            Barcode = "";
            PadFlag = PadFlags.EBOnly;
            ButtonWidth = 50;
            ButtonHeight = 50;

            FFamily = "Arial";
            FSize = 10;
            FStyle = "Regular";
        }
        public EntityButton(DataRow dr)
        {
            if (dr != null) {
                IID = dr["IID"].ToString();
                EntityButtonName = dr["EntityButtonName"].ToString();
                DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
                ButtonColor = int.Parse(dr["ButtonColor"].ToString());
                ForeColor = int.Parse(dr["ForeColor"].ToString());
                ButtonType = (EntityButtonTypes)int.Parse(dr["ButtonType"].ToString());
                AvailableFor = int.Parse(dr["AvailableFor"].ToString());
                PEIID = dr["ParentEntityIID"].ToString();
                ParentMenuIID = dr["ParentMenuIID"].ToString();
                Compulsary = int.Parse(dr["Compulsary"].ToString());
                Barcode = dr["Barcode"].ToString();
                DirectSaleTaxPercent = float.Parse(dr["DirectSaleTaxPercent"].ToString());
                InHouseTaxPercent = float.Parse(dr["InHouseTaxPercent"].ToString());
                TakeAwayTaxPercent = float.Parse(dr["TakeAwayTaxPercent"].ToString());
                DeliveryTaxPercent = float.Parse(dr["DeliveryTaxPercent"].ToString());
                PadFlag = (PadFlags)int.Parse(dr["PadFlag"].ToString());

                DistributionIID = dr["DistributionIID"].ToString();
                DirectSalePrice = float.Parse(dr["DirectSalePrice"].ToString());
                InHousePrice = float.Parse(dr["InHousePrice"].ToString());
                TakeAwayPrice = float.Parse(dr["TakeAwayPrice"].ToString());
                DeliveryPrice = float.Parse(dr["DeliveryPrice"].ToString());

                ButtonWidth = int.Parse(dr["ButtonWidth"].ToString());
                ButtonHeight = int.Parse(dr["ButtonHeight"].ToString());
                //ImageFileName = dr["ImageFileName"].ToString();

                FFamily = dr["FFamily"].ToString();
                FSize = float.Parse(dr["FSize"].ToString());
                FStyle = dr["FStyle"].ToString();
                WithImage = (int.Parse(dr["WithImage"].ToString()) == 0 ? false:true);

                
            }
        }
        public EntityButton Clone()
        {
            EntityButton eb = new EntityButton();
            eb.IID = this.IID;
            eb.EntityButtonName = this.EntityButtonName;
            eb.DisplayOrder = this.DisplayOrder;
            eb.ButtonColor = this.ButtonColor;
            eb.ForeColor = this.ForeColor;
            eb.ButtonType = this.ButtonType;
            eb.AvailableFor = this.AvailableFor;
            eb.PEIID = this.PEIID;
            eb.ParentMenuIID = this.ParentMenuIID;
            eb.Compulsary = this.Compulsary;
            eb.Barcode = this.Barcode;
            eb.DirectSaleTaxPercent = this.DirectSaleTaxPercent;
            eb.InHouseTaxPercent = this.InHouseTaxPercent;
            eb.TakeAwayTaxPercent = this.TakeAwayTaxPercent;
            eb.DeliveryTaxPercent = this.DeliveryTaxPercent;
            eb.PadFlag = this.PadFlag;

            eb.DistributionIID = this.DistributionIID;
            eb.DirectSalePrice = this.DirectSalePrice;
            eb.InHousePrice = this.InHousePrice;
            eb.TakeAwayPrice = this.TakeAwayPrice;
            eb.DeliveryPrice = this.DeliveryPrice;

            eb.ButtonWidth = this.ButtonWidth;
            eb.ButtonHeight = this.ButtonHeight;
            //eb.ImageFileName = this.ImageFileName;

            eb.FFamily = this.FFamily;
            eb.FSize = this.FSize;
            eb.FStyle = this.FStyle;

            return eb;

        }

        /// <summary>
        /// Same EntityButton with different IID
        /// </summary>
        /// <returns></returns>
        public EntityButton Duplicate()
        {
            EntityButton eb = Clone();
            eb.IID = ShortGuid.NewGuid().ToString();
            return eb;
        }
        
        

        public float GetPrice(OrderTypes orderType)
        {
            switch (orderType) {
                case OrderTypes.DirectSale:
                    return DirectSalePrice;
                case OrderTypes.InHouse:
                    return InHousePrice;
                case OrderTypes.TakeAwayB:
                    return TakeAwayPrice;
                case OrderTypes.InternetTakeAway:
                    return TakeAwayPrice;
                case OrderTypes.Delivery:
                    return DeliveryPrice;
                case OrderTypes.InternetDelivery:
                    return DeliveryPrice;
                default:
                    return 0f;
            }
        }
        public float GetTaxRate(OrderTypes orderType) {
            switch (orderType) {
                case OrderTypes.DirectSale:
                    return DirectSaleTaxPercent;
                case OrderTypes.InHouse:
                    return InHouseTaxPercent;
                case OrderTypes.TakeAwayB:
                    return TakeAwayTaxPercent;
                case OrderTypes.InternetTakeAway:
                    return TakeAwayTaxPercent;
                case OrderTypes.Delivery:
                    return DeliveryTaxPercent;
                case OrderTypes.InternetDelivery:
                    return DeliveryTaxPercent;
                default:
                    return 0f;
            }
        }

    }


    public class EntityButtonSearchResult {
        public string IID { get; set; }
        public string EntityButtonName { get; set; }
        public string EntityName { get; set; }
        public Image DisplayImage { get; set; }

        public EntityButtonSearchResult() {

        }
    }



}
