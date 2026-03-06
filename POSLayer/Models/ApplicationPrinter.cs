using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class ApplicationPrinter
{
    public string Iid { get; set; } = null!;

    public string? ApplicationName { get; set; }

    public int? PrinterType { get; set; }

    public int AdminOnly { get; set; }
}
