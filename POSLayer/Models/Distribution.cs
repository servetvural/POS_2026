using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Distribution : BaseClass
{

    public string? DistributionName { get; set; }

    public string? ShortName { get; set; }

    public string? PrinterIID { get; set; }

    public int DisplayOrder { get; set; }

    public string? ParentMenuIID { get; set; }
}
