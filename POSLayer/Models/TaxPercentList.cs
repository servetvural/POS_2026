using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TaxPercentList : BaseClass
{
    public double TaxPercent { get; set; }

    public string? ParentMenuIID { get; set; }
}
