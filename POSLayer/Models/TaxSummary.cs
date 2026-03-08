using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TaxSummary    : BaseClass
{
    public string? SessionIID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double TaxPercent { get; set; }

    public double? GrossTotal { get; set; }

    public double? NetTaxValue { get; set; }

    public double? TotalNoTax { get; set; }

    public int? Payment { get; set; }
}
