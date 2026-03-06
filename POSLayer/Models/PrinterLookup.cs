using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class PrinterLookup
{
    public string PrinterIid { get; set; } = null!;

    public string ClientIid { get; set; } = null!;

    public string? NetworkName { get; set; }

    public int DeliveryPrinter { get; set; }

    public int TakeAwayPrinter { get; set; }
}
