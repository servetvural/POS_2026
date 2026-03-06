using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class DistributionView
{
    public string Iid { get; set; } = null!;

    public string? DistributionName { get; set; }

    public string? ShortName { get; set; }

    public int DisplayOrder { get; set; }

    public string? ParentMenuIid { get; set; }

    public string? MenuName { get; set; }

    public string? PrinterIid { get; set; }

    public string? PrinterNetworkName { get; set; }
}
