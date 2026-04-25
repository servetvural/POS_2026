using System.Collections.Generic;
using System.Drawing;

using POSLayer.Models;

namespace DTRMNS {

    /// <summary>
    /// This Class Contains the entire stockItem collection (Supplier, StockItem, EntityButtonStockItemLookup, Images]
    /// </summary>   
    [System.Xml.Serialization.XmlInclude(typeof(Bitmap))]
    [System.Xml.Serialization.XmlInclude(typeof(Image))]
    [System.Serializable]
    public class StockManager {

        //public string MenuIID { get; set; }
        public string Reference { get; set; }

        private List<StockItem> _StockItems = new List<StockItem>();
        public List<StockItem> StockItems { get { return _StockItems; } set { _StockItems = value; } }

        private List<Supplier> _Suppliers = new List<Supplier>();
        public List<Supplier> Suppliers { get { return _Suppliers; } set { _Suppliers = value; } }

        private List<EntityButtonStockItemLookUp> _EBStockItemLookups = new List<EntityButtonStockItemLookUp>();
        public List<EntityButtonStockItemLookUp> EBStockItemLookups { get { return _EBStockItemLookups; } set { _EBStockItemLookups = value; } }

       
        public StockManager() {

        }

        //public StockManager(string MenuIID) {
        //    this.MenuIID = MenuIID;
        //}
    }
}
