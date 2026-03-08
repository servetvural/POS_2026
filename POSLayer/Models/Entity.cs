using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Entity : BaseClass
{
    public string? EntityName { get; set; }
    public int DisplayOrder { get; set; }
    public int? BackColour { get; set; }

    public int? ButtonHeight { get; set; }

    public int? ButtonWidth { get; set; }

    public string? ParentMenuIID { get; set; }

    public int EntityType { get; set; }

    public string? DistributionIID { get; set; }

    public string? DistributionName { get; set; }

    public string? Ffamily { get; set; }

    public double? Fsize { get; set; }

    public string? Fstyle { get; set; }

    public int ForeColour { get; set; }
}
