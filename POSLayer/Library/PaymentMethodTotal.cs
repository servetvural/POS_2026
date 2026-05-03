using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Library;

public class PaymentMethodTotal
{
    public PaymentMethods method { get; set; }
    public double TotalValue { get; set; }
}
