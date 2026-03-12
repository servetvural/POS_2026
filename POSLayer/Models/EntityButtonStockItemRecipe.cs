using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class EntityButtonStockItemRecipe   : BaseClass
{
    public string? EntityButtonIID { get; set; }
    public string? StockItemIID { get; set; }
    public QuantityTypes QuantityType { get; set; }
    public int Quantity { get; set; }
    public string? StockName { get; set; }
    public string? EntityButtonName { get; set; }
    public string? ParentMenuIID { get; set; }
}
