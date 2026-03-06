using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class EntityButtonStockItemRecipe
{
    public string? StockName { get; set; }

    public string? EntityButtonName { get; set; }

    public string EntityButtonIid { get; set; } = null!;

    public string StockItemIid { get; set; } = null!;

    public int QuantityType { get; set; }

    public double Quantity { get; set; }

    public string? ParentMenuIid { get; set; }
}
