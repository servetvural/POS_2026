using System;
using System.Collections.Generic;

using POSLayer.Models;

namespace POSLayer.Views;

public partial class PrinterView : BaseClass
{

    public string? ApplicationName { get; set; }

    public int? PrinterType { get; set; }

    public string ClientIID { get; set; } = null!;

    public string NetworkName { get; set; } = null!;

    public int DeliveryPrinter { get; set; }

    public int TakeAwayPrinter { get; set; }

    public int AdminOnly { get; set; }
}
