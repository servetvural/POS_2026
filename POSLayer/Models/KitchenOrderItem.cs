using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class KitchenOrderItem : BaseClass
{

    public int Quantity { get; set; }

    public string ItemText { get; set; } = null!;

    public string KitchenOrderIID { get; set; } = null!;

    public string DistributionIID { get; set; } = null!;

    public string EntityButtonIID { get; set; } = null!;

    public int Status { get; set; }
}
