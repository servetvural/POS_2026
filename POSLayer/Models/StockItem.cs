using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class StockItem : BaseClass
{
    public string StockName { get; set; }

    public QuantityTypes QuantityType { get; set; }

    public QuantityTypes OrderType { get; set; }

    public int Conversion { get; set; }

    public string? SupplierIID { get; set; }

    public Supplier? Supplier { get; set; }

    public string? SupplierName => Supplier?.SupplierName;


    public double UsedQuantity { get; set; }


    public List<StockItemUsage> stockUsages { get; set; } = new();

    public List<RecipeItem> recipes { get; set; } = new();

}
