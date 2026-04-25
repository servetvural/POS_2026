using System.Data;
using System.Drawing;
using PosLibrary;

namespace DTRMNS {

    [System.Serializable]
    public class EntityButtonExtended {
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

        public string Font {  get { return FFamily + " " + FSize + " " + FStyle; } }
        public bool WithImage { get; set; }

        public string DistributionName { get; set; }

        public Image DisplayImage { get; set; }

        public EntityButtonExtended() {
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
        public EntityButtonExtended(DataRow dr) {
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
                WithImage = (int.Parse(dr["WithImage"].ToString()) == 0 ? false : true);

                DistributionName = dr["DistributionName"].ToString();

                DisplayImage = UF.ByteArrayToImage(dr["DisplayImage"]);
            }
        }
        

    }

}
