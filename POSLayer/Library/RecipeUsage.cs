using System;
using System.Collections.Generic;
using System.Text;

using POSLayer.Models;

namespace POSLayer.Library;

public class RecipeUsage
{
    public string? IID { get; set; }
    
    public string? StockItemIID { get; set; }
    public string? StockItemName { get; set; }
    public double Quantity { get; set; }
    public QuantityTypes QuantityType { get; set; }
    public string? SupplierPrefix { get; set; }
}
