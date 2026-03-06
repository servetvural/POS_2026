using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TaxPercentList
{
    public double TaxPercent { get; set; }

    public string? ParentMenuIid { get; set; }
}
