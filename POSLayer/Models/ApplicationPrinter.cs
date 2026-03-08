using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class ApplicationPrinter :BaseClass
{

    public string? ApplicationName { get; set; }

    public int? PrinterType { get; set; }

    public int AdminOnly { get; set; }
}
