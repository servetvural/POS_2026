using System;
using System.Collections.Generic;
using System.Text;

using POSLayer.Library;

namespace POSLayer.Views;

public class TaxSummary
{      
    public string SessionIID { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public double TaxPercent { get; set; }
    public double TotalNoTax { get; set; }
    public double NetTaxValue { get; set; }
    public double GrossTotal { get; set; }
    public PaymentMethods Payment { get; set; }

}
