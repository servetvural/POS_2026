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

    public string SupplierIID { get; set; } 

    public string SupplierName { get; set; }

    public double UsedQuantity { get; set; }

}
