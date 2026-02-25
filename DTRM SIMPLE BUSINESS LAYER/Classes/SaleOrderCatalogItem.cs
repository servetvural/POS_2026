using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTRMNS {

    [System.Serializable]
    public class SaleOrderCatalogItem
    {
        private string _IID;
        private string _StockIID;
        private string _POCatalogIID;
        private string _Barcode;
        private string _ItemName;
        private float _Price;
        private string _StockUnit;
        private string _MinQuantity;
        private string _MaxQuantity;
        private string _SuggQuantity;
        private string _HeaderIID;
        private int _DisplayOrder;

        public SaleOrderCatalogItem()
        {
            IID = Guid.NewGuid().ToString();
            _StockIID = "";
            _POCatalogIID = "";
            _Barcode = "";
            _ItemName = "";
            _Price = 0f;
            _StockUnit = "";
            _MinQuantity = "Any";
            _MaxQuantity = "Any";
            _SuggQuantity = "Any";
            _HeaderIID = "";
            _DisplayOrder = 0;
        }
        public SaleOrderCatalogItem(DataRow dr)
        {
            IID = dr["IID"].ToString();
            StockIID = dr["StockIID"].ToString();
            POCatalogIID = dr["POCatalogIID"].ToString();
            Barcode = dr["Barcode"].ToString();
            ItemName = dr["ItemName"].ToString();
            Price = float.Parse(dr["Price"].ToString());
            StockUnit = dr["StockUnit"].ToString();
            MinQuantity = dr["MinQuantity"].ToString();
            MaxQuantity = dr["MaxQuantity"].ToString();
            SuggQuantity = dr["SuggQuantity"].ToString();
            HeaderIID = dr["HeaderIID"].ToString();
            DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
        }
        public string IID { get { return _IID; } set { _IID = value; } }
        public string StockIID { get { return _StockIID; } set { _StockIID = value; } }
        public string POCatalogIID { get { return _POCatalogIID; } set { _POCatalogIID = value; } }
        public string Barcode { get { return _Barcode; } set { _Barcode = value; } }
        public string ItemName { get { return _ItemName; } set { _ItemName = value; } }
        public float Price { get { return _Price; } set { _Price = value; } }
        public string StockUnit { get { return _StockUnit; } set { _StockUnit = value; } }
        public string MinQuantity { get { return _MinQuantity; } set { _MinQuantity = value; } }
        public string MaxQuantity { get { return _MaxQuantity; } set { _MaxQuantity = value; } }
        public string SuggQuantity { get { return _SuggQuantity; } set { _SuggQuantity = value; } }
        public string HeaderIID { get { return _HeaderIID; } set { _HeaderIID = value; } }
        public int DisplayOrder { get { return _DisplayOrder; } set { _DisplayOrder = value; } }
    }

}
