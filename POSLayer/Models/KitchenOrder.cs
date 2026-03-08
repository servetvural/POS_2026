using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class KitchenOrder : BaseClass
{
    public string Reference { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public string OrderIID { get; set; } = null!;

    public DateTime CompletedDateTime { get; set; }

    public int Status { get; set; }

    public int OrderNo { get; set; }

    public int BeingModified { get; set; }

    public int OrderType { get; set; }
}
