using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;
using POSLayer.Models;

namespace POSLayer.Views;

public partial class StockItemUsage : BaseClass
{
    public string StockItemIID { get; set; } = null!;

    public double SessionQuantity { get; set; }
    public double XSessionQuantity { get; set; }
    public double PreviousQuantity { get; set; }
    public double TotalQuantity { get { return SessionQuantity + PreviousQuantity + XSessionQuantity; } }
    public QuantityTypes QuantityType { get; set; }
    public string? StockName { get; set; }
    public int Conversion { get; set; }
    public double OrderableQuantity { get { return (int)Math.Floor(OrderableFloatQuantity); } }
    public QuantityTypes OrderableType { get; set; }
    public double OrderableFloatQuantity { get { return TotalQuantity / Conversion; } }
    public double BalanceQuantity { get { return TotalQuantity - (OrderableQuantity * Conversion); } }
    public string SupplierIID { get; set; } = null!;
    public string? SupplierName { get; set; }
    public string? Comment { get; set; }

    [NotMapped]
    public string QuantityTypeAsString { get; set; }
    [NotMapped]
    public string OrderableTypeAsString { get; set; }






}
