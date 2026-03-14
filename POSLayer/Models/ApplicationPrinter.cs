using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class ApplicationPrinter :BaseClass
{
    public bool DeliveryPrinter { get; set; }
    public bool TakeAwayPrinter { get; set; }
    public bool AdminOnly { get; set; }
    public string? ClientIID { get; set; }
    public string NetworkName { get; set; }    =string.Empty;
    public string ApplicationName { get; set; } = string.Empty;
    public PrinterTypes PrinterType { get; set; }
    public string PrinterTypeAsString { get; set; }     = string.Empty;
}
