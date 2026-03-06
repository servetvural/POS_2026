using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Distribution
{
    public string Iid { get; set; } = null!;

    public string? DistributionName { get; set; }

    public string? ShortName { get; set; }

    public string? PrinterIid { get; set; }

    public int DisplayOrder { get; set; }

    public string? ParentMenuIid { get; set; }
}
