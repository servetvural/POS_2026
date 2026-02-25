using System.Collections.Generic;
using System.Data;
using System.Drawing;
using PosLibrary;

namespace DTRMNS {
    /// <summary>
    /// This Class Contains a single Menu's entire User Interface, this includes entities, prices, names etc.
    /// </summary>
    [System.Xml.Serialization.XmlInclude(typeof(Entity))]
    [System.Xml.Serialization.XmlInclude(typeof(EntityButton))]
    [System.Xml.Serialization.XmlInclude(typeof(Color))]
    [System.Xml.Serialization.XmlInclude(typeof(KnownColor))]
    [System.Xml.Serialization.XmlInclude(typeof(PrintColors))]
    [System.Xml.Serialization.XmlInclude(typeof(Distribution))] 
    [System.Serializable]
    public class FMenu {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        private List<Distribution> _Distribution = new List<Distribution>();
        public List<Distribution> Distributions { get { return _Distribution; } set { _Distribution = value; } }

        private List<Entity> _items = new List<Entity>();
        public List<Entity> items { get { return _items; } set { _items = value; } }

        //private List<Image> _images = new List<Image>();
        //public List<Image> images { get { return _images; } set { _images = value; } }

        //private List<Supplier> _suppliers = new List<Supplier>();
        //public List<Supplier> suppliers { get { return _suppliers; } set { _suppliers = value; } }

        //private List<StockItem> _stockitems = new List<StockItem>();
        //public List<StockItem> stockitems { get { return _stockitems; } set { _stockitems = value; } }

        //private List<StockItemUsage> _stockitemusages = new List<StockItemUsage>();
        //public List<StockItemUsage> stockitemusages { get { return _stockitemusages; } set { _stockitemusages = value; } }

        public string MenuName { get; set; }

        public bool IsActiveMenu { get; set; }

        public FMenu() {
        }

        public FMenu(string NewMenuName) {
            //this.IID = ShortGuid.NewGuid().ToString();
            this.MenuName = NewMenuName;
        }
        public FMenu(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                MenuName = dt.Rows[0]["MenuName"].ToString();
            }
        }
        public FMenu(DataRow dr) {
            if (dr != null) {
                IID = dr["IID"].ToString();
                MenuName = dr["MenuName"].ToString();
            }
        }
        public string GetMenuFileName() {
            return IID + ".xml";
        }
        public float GetItemPrice(string EntityIID, string ItemIID, OrderTypes orderType) {
            Entity en;
            for (int i = 0; i < this.items.Count; i++) {
                en = (Entity)items[i];
                if (en.IID == EntityIID)
                    return en.GetItemPrice(ItemIID, orderType);
            }
            return 0f;
        }
        public float GetItemTaxRate(string EntityIID, string ItemIID, OrderTypes orderType) {
            Entity en;
            for (int i = 0; i < this.items.Count; i++) {
                en = (Entity)items[i];
                if (en.IID == EntityIID)
                    return en.GetItemTaxRate(ItemIID, orderType);
            }
            return 0f;
        }
    }

}
