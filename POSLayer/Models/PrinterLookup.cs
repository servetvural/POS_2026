using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class PrinterLookup : BaseClass
{
    public string PrinterIID { get; set; } = null!;

    public string ClientIID { get; set; } = null!;

    public string? NetworkName { get; set; }

    public int DeliveryPrinter { get; set; }

    public int TakeAwayPrinter { get; set; }
}
