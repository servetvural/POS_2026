using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class StockItem
{
    public string Iid { get; set; } = null!;

    public string StockName { get; set; } = null!;

    public int QuantityType { get; set; }

    public int OrderType { get; set; }

    public int Conversion { get; set; }

    public string SupplierIid { get; set; } = null!;

    public double UsedQuantity { get; set; }
}
