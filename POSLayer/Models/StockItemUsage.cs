using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class StockItemUsage    : BaseClass
{
    public string StockItemIID { get; set; } = null!;

    public double? SessionQuantity { get; set; }

    public double PreviousQuantity { get; set; }

    public double? XsessionQuantity { get; set; }

    public double TotalQuantity { get; set; }

    public string StockName { get; set; } = null!;

    public int Conversion { get; set; }

    public double OrderableQuantity { get; set; }

    public int OrderableType { get; set; }

    public string SupplierIID { get; set; } = null!;

    public string? SupplierName { get; set; }

    public int QuantityType { get; set; }

    public string? Comment { get; set; }
}
