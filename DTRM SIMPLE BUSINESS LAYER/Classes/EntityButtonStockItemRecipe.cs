using System.Data;

namespace DTRMNS {
    [System.Serializable]
    public class EntityButtonStockItemRecipe {  
        public string EntityButtonIID { get; set; }
        public string StockItemIID { get; set; }
        public QuantityTypes QuantityType { get; set; }
        public int Quantity { get; set; }
        public string StockName { get; set; }
        public string EntityButtonName { get; set; }
        public string ParentMenuIID { get; set; }


        //Default Constructor	
        public EntityButtonStockItemRecipe() {

        }

        //Parameterized constructor	
        //public EntityButtonStockItemRecipe(string EntityButtonIID, string StockItemIID, QuantityTypes QuantityType, int Quantity) {
        //    this.EntityButtonIID = EntityButtonIID;
        //    this.StockItemIID = StockItemIID;
        //    this.QuantityType = QuantityType;
        //    this.Quantity = Quantity;
        //}
        //public EntityButtonStockItemRecipe(string EntityButtonIID, string StockItemIID, int QuantityType, int Quantity) {
        //    this.EntityButtonIID = EntityButtonIID;
        //    this.StockItemIID = StockItemIID;
        //    this.QuantityType = (QuantityTypes)QuantityType;
        //    this.Quantity = Quantity;
        //}

        public EntityButtonStockItemRecipe(DataTable dt) {
            EntityButtonIID = dt.Rows[0]["EntityButtonIID"].ToString();
            StockItemIID = dt.Rows[0]["StockItemIID"].ToString();
            QuantityType = (QuantityTypes)int.Parse(dt.Rows[0]["QuantityType"].ToString());
            Quantity = int.Parse(dt.Rows[0]["Quantity"].ToString());
            try {
                StockName = dt.Rows[0]["StockName"].ToString();
            } catch { }
            EntityButtonName = dt.Rows[0]["EntityButtonName"].ToString();
            ParentMenuIID = dt.Rows[0]["ParentMenuIID"].ToString();
        }

        public EntityButtonStockItemRecipe(DataRow dr) {
            EntityButtonIID = dr["EntityButtonIID"].ToString();
            StockItemIID = dr["StockItemIID"].ToString();
            QuantityType = (QuantityTypes)int.Parse(dr["QuantityType"].ToString());
            Quantity = int.Parse(dr["Quantity"].ToString());
            try {
                StockName = dr["StockName"].ToString();
            } catch { }
            EntityButtonName = dr["EntityButtonName"].ToString();
            ParentMenuIID = dr["ParentMenuIID"].ToString();
        }
        

    }
}
