using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTRMNS {
    [System.Serializable]
    public class SaleOrderItem
    {
        private string _IID;
        private string _StockIID;
        private string _SaleOrderIID;
        private string _Barcode;
        private float _Quantity;
        private string _StockUnit;
        private string _ItemName;
        private float _Price;
        public SaleOrderItem()
        {
            IID = Guid.NewGuid().ToString();
        }

        public SaleOrderItem(DataRow dr)
        {
            IID = dr["IID"].ToString();
            StockIID = dr["StockIID"].ToString();
            SaleOrderIID = dr["SaleOrderIID"].ToString();
            Barcode = dr["Barcode"].ToString();
            Quantity = float.Parse(dr["Quantity"].ToString());
            StockUnit = dr["StockUnit"].ToString();
            ItemName = dr["ItemName"].ToString();
            Price = float.Parse(dr["Price"].ToString(), System.Globalization.NumberStyles.Any);
        }

        public string IID { get { return _IID; } set { _IID = value; } }
        public string StockIID { get { return _StockIID; } set { _StockIID = value; } }
        public string SaleOrderIID { get { return _SaleOrderIID; } set { _SaleOrderIID = value; } }
        public string Barcode { get { return _Barcode; } set { _Barcode = value; } }
        public float Quantity { get { return _Quantity; } set { _Quantity = value; } }
        public string StockUnit { get { return _StockUnit; } set { _StockUnit = value; } }
        public string ItemName { get { return _ItemName; } set { _ItemName = value; } }
        public float Price { get { return _Price; } set { _Price = value; } }

    }

}
