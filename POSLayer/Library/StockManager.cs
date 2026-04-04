using System;
using System.Collections.Generic;
using System.Text;

using POSLayer.Models;

namespace POSLayer.Library;

/// <summary>
/// This Class Contains the entire stockItem collection (Supplier, StockItem, EntityButtonStockItemLookup, Images]
/// </summary>   
//[System.Xml.Serialization.XmlInclude(typeof(Bitmap))]
//[System.Xml.Serialization.XmlInclude(typeof(Image))]
[System.Serializable]
public class StockManager
{
    public string Reference { get; set; }
    public List<StockItem> StockItems { get; set; }
    public List<Supplier> Suppliers { get; set; }
    public List<RecipeItem> Recipes { get; set; }

}
