using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class XorderItem
{
    public string Iid { get; set; } = null!;

    public string EntityIid { get; set; } = null!;

    public string? EntityName { get; set; }

    public int? EntityDisplayOrder { get; set; }

    public string? OrderItemText { get; set; }

    public double Quantity { get; set; }

    public decimal? Price { get; set; }

    public string? OrderGroupIid { get; set; }

    public string? EntityButtonIid { get; set; }

    public string? DistributionIid { get; set; }

    public string? ParentOrderIid { get; set; }

    public int ItemType { get; set; }

    public int DisplayOrder { get; set; }

    public double TaxPercent { get; set; }

    public double CompletedQuantity { get; set; }
}
