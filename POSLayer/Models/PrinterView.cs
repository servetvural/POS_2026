using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class PrinterView
{
    public string Iid { get; set; } = null!;

    public string? ApplicationName { get; set; }

    public int? PrinterType { get; set; }

    public string ClientIid { get; set; } = null!;

    public string NetworkName { get; set; } = null!;

    public int DeliveryPrinter { get; set; }

    public int TakeAwayPrinter { get; set; }

    public int AdminOnly { get; set; }
}
