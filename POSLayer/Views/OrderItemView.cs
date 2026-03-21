using System;
using System.Collections.Generic;

using POSLayer.Models;

namespace POSLayer.Views;

public partial class OrderItemView   : BaseClass
{
    public string EntityIID { get; set; } = null!;

    public string? EntityName { get; set; }

    public int? EntityDisplayOrder { get; set; }

    public string? OrderItemText { get; set; }

    public double Quantity { get; set; }

    public decimal? Price { get; set; }

    public string? OrderGroupIID { get; set; }

    public string? EntityButtonIID { get; set; }

    public string? DistributionIID { get; set; }

    public string? ParentOrderIID { get; set; }

    public int ItemType { get; set; }

    public int DisplayOrder { get; set; }
    public double TaxPercent { get; set; }

    public string? SessionIID { get; set; }

    public double? Total { get; set; }

    public double CompletedQuantity { get; set; }
}
