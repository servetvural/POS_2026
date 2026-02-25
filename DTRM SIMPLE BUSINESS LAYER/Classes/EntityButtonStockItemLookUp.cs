using System.Data;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class EntityButtonStockItemLookUp {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }

        public string EntityButtonIID { get; set; }
        public string StockItemIID { get; set; }
        public QuantityTypes QuantityType { get; set; }
        public float Quantity { get; set; } = 1;
        public string StockName { get; set; }
        public int DisplayOrder { get; set; }
        public string Comment { get; set; }

        public string QuantityTypeAsString { get; set; }

        //Default Constructor	
        public EntityButtonStockItemLookUp() {

        }

        public EntityButtonStockItemLookUp(string EntityButtonIID)
        {
            this.EntityButtonIID = EntityButtonIID;
        }

        //Parameterized constructor	
        public EntityButtonStockItemLookUp(string IID, string EntityButtonIID, string StockItemIID, QuantityTypes QuantityType, float Quantity, int DisplayOrder, string Comment) {
            this.IID = IID;
            this.EntityButtonIID = EntityButtonIID;
            this.StockItemIID = StockItemIID;
            this.QuantityType = QuantityType;
            this.Quantity = Quantity;
            this.DisplayOrder = DisplayOrder;
            this.Comment = Comment;
        }
        public EntityButtonStockItemLookUp(string IID, string EntityButtonIID, string StockItemIID, int QuantityType, float Quantity,int DisplayOrder, string Comment) {
            this.IID = IID;
            this.EntityButtonIID = EntityButtonIID;
            this.StockItemIID = StockItemIID;
            this.QuantityType = (QuantityTypes)QuantityType;
            this.Quantity = Quantity;
            this.DisplayOrder = DisplayOrder;
            this.Comment = Comment;
        }

        public EntityButtonStockItemLookUp(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            EntityButtonIID = dt.Rows[0]["EntityButtonIID"].ToString();
            StockItemIID = dt.Rows[0]["StockItemIID"].ToString();
            QuantityType = (QuantityTypes)int.Parse(dt.Rows[0]["QuantityType"].ToString());
            Quantity = float.Parse(dt.Rows[0]["Quantity"].ToString());
            DisplayOrder = int.Parse(dt.Rows[0]["DisplayOrder"].ToString());
            try {
                StockName = dt.Rows[0]["StockName"].ToString();
            } catch { }
            Comment = dt.Rows[0]["Comment"].ToString();

        }

        public EntityButtonStockItemLookUp(DataRow dr) {
            IID = dr["IID"].ToString();
            EntityButtonIID = dr["EntityButtonIID"].ToString();
            StockItemIID = dr["StockItemIID"].ToString();
            QuantityType = (QuantityTypes)int.Parse(dr["QuantityType"].ToString());
            Quantity = float.Parse(dr["Quantity"].ToString());
            DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
            try {
                StockName = dr["StockName"].ToString();
            } catch { }
            Comment = dr["Comment"].ToString();
        }

        public EntityButtonStockItemLookUp Duplicate(string DuplicateEntityButtonIID)
        {
            EntityButtonStockItemLookUp dup = new EntityButtonStockItemLookUp();
            dup.EntityButtonIID = DuplicateEntityButtonIID;
            dup.StockItemIID = StockItemIID;
            dup.QuantityType = (QuantityTypes)QuantityType;
            dup.Quantity = Quantity;
            dup.DisplayOrder = DisplayOrder;
            dup.Comment = Comment;
            return dup;
        }
        

    }
}
