using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class EntityButtonStockItemRecipe   : BaseClass
{
    public string? StockName { get; set; }

    public string? EntityButtonName { get; set; }

    public string EntityButtonIID { get; set; } = null!;

    public string StockItemIID { get; set; } = null!;

    public int QuantityType { get; set; }

    public double Quantity { get; set; }

    public string? ParentMenuIID { get; set; }
}
