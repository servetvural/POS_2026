using System;
using System.Collections.Generic;

using POSLayer.Models;

namespace POSLayer.Views;

public partial class DistributionView : BaseClass
{

    public string? DistributionName { get; set; }

    public string? MenuIID { get; set; }

    public string? MenuName { get; set; }

    public string? PrinterIID { get; set; }

    public string? PrinterName { get; set; }
    public string? PrinterNetworkName { get; set; }
}
