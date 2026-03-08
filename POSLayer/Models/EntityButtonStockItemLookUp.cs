using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class EntityButtonStockItemLookUp : BaseClass
{

    public string EntityButtonIID { get; set; } = null!;

    public string StockItemIID { get; set; } = null!;

    public int QuantityType { get; set; }

    public double Quantity { get; set; }
    public int DisplayOrder { get; set; }
    public string Comment { get; set; } = null!;
}
