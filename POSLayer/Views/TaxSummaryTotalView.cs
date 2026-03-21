using System;
using System.Collections.Generic;

using POSLayer.Library;
using POSLayer.Models;

namespace POSLayer.Views;

public partial class TaxSummaryTotalView 
{
    public double TaxPercent { get; set; }
    public double GrossTotalSum { get; set; }
    public double NetTaxValueSum { get; set; }
    public double TotalNoTax { get; set; }
    public PaymentMethods Payment { get; set; }
}
