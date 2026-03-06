using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class KitchenOrderItem
{
    public string Iid { get; set; } = null!;

    public int Quantity { get; set; }

    public string ItemText { get; set; } = null!;

    public string KitchenOrderIid { get; set; } = null!;

    public string DistributionIid { get; set; } = null!;

    public string EntityButtonIid { get; set; } = null!;

    public int Status { get; set; }
}
