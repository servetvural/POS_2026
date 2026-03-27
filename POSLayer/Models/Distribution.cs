using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.IdentityModel.Tokens;

namespace POSLayer.Models;

public partial class Distribution : BaseClass
{
    public string DistributionName { get; set; } = string.Empty;
    //public string? PrinterIID { get; set; } = string.Empty;
    //public Printer? Printer { get; set; }
    public string MenuIID { get; set; } = string.Empty;
    public TheMenu? Menu { get; set; }

    [NotMapped]
    public string? MenuNameReadOnly
    {
        get
        {
            return Menu?.MenuName ?? "";
        }
    }

    //[NotMapped]
    //public List<Printer> printers { get; set; } = new();

  
    //public string FlatPrinterList { 
    //    get
    //    {
    //        if (!printers.Any())
    //            return string.Empty;
    //        else
    //        {
    //            return string.Join(", ", printers.Select(x => x.ApplicationName));
    //        }
    //    }
    //}


    public List<DistributionPrinter> DistributionPrinters { get; set; } = new();

    [NotMapped]
    public string FlatPrinterList => string.Join(", ",
        DistributionPrinters
            .OrderBy(x => x.DOrder)
            .Select(x => x.Printer?.ApplicationName ?? "Unknown"));

}
