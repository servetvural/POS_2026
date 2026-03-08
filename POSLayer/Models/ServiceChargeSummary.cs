using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class ServiceChargeSummary : BaseClass
{
    public string? SessionIID { get; set; }

    public double? ServiceChargeTotal { get; set; }

    public double? ServiceChargeTaxTotal { get; set; }

    public int? Payment { get; set; }
}
