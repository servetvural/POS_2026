using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Distribution : BaseClass
{
    public string Name { get; set; } = string.Empty;

    public string? PrinterIID { get; set; } = string.Empty;

    public Printer? Printer { get; set; }


    public string MenuIID { get; set; } = string.Empty;
    public TheMenu? Menu { get; set; }
  
}
