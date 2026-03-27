using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Models;

public class DistributionPrinter : BaseClass
{
    public string DistributionIID { get; set; }
    public Distribution Distribution { get; set; }

    public string PrinterIID { get; set; }
    public Printer Printer { get; set; }

    public string PrinterName => Printer?.ApplicationName;

}
