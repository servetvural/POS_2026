using System;
using System.Data;

namespace DTRMNS {
    public class StockItemUsage {
        public string StockItemIID { get; set; }
        public float SessionQuantity { get; set; }
        public float XSessionQuantity { get; set; }
        public float PreviousQuantity { get; set; }
        public float TotalQuantity { get { return SessionQuantity + PreviousQuantity + XSessionQuantity; } }
        public QuantityTypes QuantityType { get; set; }
        public string StockName { get; set; }
        public int Conversion { get; set; }
        public float OrderableQuantity { get { return (int)Math.Floor(OrderableFloatQuantity); } }
        public QuantityTypes OrderableType { get; set; }
        public float OrderableFloatQuantity { get { return TotalQuantity / Conversion; } }
        public float BalanceQuantity { get { return TotalQuantity - (OrderableQuantity * Conversion); } }
        public string SupplierIID { get; set; }
        public string SupplierName { get; set; }
        public string Comment { get; set; }

        public string QuantityTypeAsString { get; set; }
        public string OrderableTypeAsString { get; set; }

        public StockItemUsage() {

        }

        public StockItemUsage(DataTable dt) {
            StockItemIID = dt.Rows[0]["StockItemIID"].ToString();
            SessionQuantity = float.Parse(dt.Rows[0]["SessionQuantity"].ToString());
            XSessionQuantity = float.Parse(dt.Rows[0]["XSessionQuantity"].ToString());
            PreviousQuantity = float.Parse(dt.Rows[0]["PreviousQuantity"].ToString());            
            QuantityType = (QuantityTypes)int.Parse(dt.Rows[0]["QuantityType"].ToString());
            StockName = dt.Rows[0]["StockName"].ToString();
            Conversion = int.Parse(dt.Rows[0]["Conversion"].ToString());
            OrderableType = (QuantityTypes)int.Parse(dt.Rows[0]["OrderableType"].ToString());
            SupplierIID = dt.Rows[0]["SupplierIID"].ToString();
            SupplierName = dt.Rows[0]["SupplierName"].ToString();
            Comment = dt.Rows[0]["Comment"].ToString();
        }

        public StockItemUsage(DataRow dr) {
            StockItemIID = dr["StockItemIID"].ToString();
            SessionQuantity = float.Parse(dr["SessionQuantity"].ToString());
            XSessionQuantity = float.Parse(dr["XSessionQuantity"].ToString());
            PreviousQuantity = float.Parse(dr["PreviousQuantity"].ToString());
            QuantityType = (QuantityTypes)int.Parse(dr["QuantityType"].ToString());
            StockName = dr["StockName"].ToString();
            Conversion = int.Parse(dr["Conversion"].ToString());
            OrderableType = (QuantityTypes)int.Parse(dr["OrderableType"].ToString());
            SupplierIID = dr["SupplierIID"].ToString();
            SupplierName = dr["SupplierName"].ToString();
            Comment = dr["Comment"].ToString();
        }

    }
}
