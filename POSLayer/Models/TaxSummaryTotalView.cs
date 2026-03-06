using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TaxSummaryTotalView
{
    public double TaxPercent { get; set; }

    public double? GrossTotalSum { get; set; }

    public double? NetTaxValueSum { get; set; }

    public double? TotalNoTax { get; set; }

    public int? Payment { get; set; }
}
