using System.Data;
using PosLibrary;


namespace DTRMNS {

    [System.Serializable]
    public class StockItem {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string StockName { get; set; }
        public QuantityTypes QuantityType { get; set; }
        public QuantityTypes OrderType { get; set; }
        public int Conversion { get; set; }
        public string SupplierIID { get; set; }
        public string SupplierName { get; set; }
        public float UsedQuantity { get; set; }

        public StockItem() {

        }

        public StockItem(string StockName) {
            this.StockName = StockName;
        }

        public StockItem(DataTable dt) {
            _IID = dt.Rows[0]["IID"].ToString();
            StockName = dt.Rows[0]["StockName"].ToString();
            QuantityType = (QuantityTypes)int.Parse(dt.Rows[0]["QuantityType"].ToString());
            OrderType = (QuantityTypes)int.Parse(dt.Rows[0]["OrderType"].ToString());
            Conversion = int.Parse(dt.Rows[0]["Conversion"].ToString());
            UsedQuantity = float.Parse(dt.Rows[0]["UsedQuantity"].ToString());

            SupplierIID = dt.Rows[0]["SupplierIID"].ToString();
            try {
                
                SupplierName = dt.Rows[0]["SupplierName"].ToString();
            } catch { }

        }

        public StockItem(DataRow dr) {
            _IID = dr["IID"].ToString();
            StockName = dr["StockName"].ToString();
            QuantityType = (QuantityTypes)int.Parse(dr["QuantityType"].ToString());
            OrderType = (QuantityTypes)int.Parse(dr["OrderType"].ToString());
            Conversion = int.Parse(dr["Conversion"].ToString());
            UsedQuantity = float.Parse(dr["UsedQuantity"].ToString());
            SupplierIID = dr["SupplierIID"].ToString();
            try {
                SupplierName = dr["SupplierName"].ToString();
            } catch { }

        }
        


    }
}
