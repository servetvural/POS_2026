using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Distribution : BaseClass
{

    public string DistributionName { get; set; } = string.Empty;
    public string ShortName { get; set; }        = string.Empty;
    public string PrinterIID { get; set; }       = string.Empty;
    public string ParentMenuIID { get; set; }      = string.Empty;
    public int DisplayOrder { get; set; }


    public Distribution(string DistributionName, string PrinterIID)
    {
        this.DistributionName = DistributionName;
        this.PrinterIID = PrinterIID;
    }
    private Distribution(string IID, string DistributionName, string ShortName, string PrinterIID,
        string ParentMenuIID, int DisplayOrder)
    {
        this.IID = IID;
        this.DistributionName = DistributionName;
        this.ShortName = ShortName;
        this.PrinterIID = PrinterIID;
        this.ParentMenuIID = ParentMenuIID;
        this.DisplayOrder = DisplayOrder;
    }

    public void ChangePrinterName(string PrinterIID)
    {
        this.PrinterIID = PrinterIID;
    }
    public void Update(string DistributionName, string ShortName, string PrinterIID, string ParentMenuIID, int DisplayOrder)
    {
        this.DistributionName = DistributionName;
        this.ShortName = ShortName;
        this.PrinterIID = PrinterIID;
        this.ParentMenuIID = ParentMenuIID;
        this.DisplayOrder = DisplayOrder;
    }

    public void Update(Distribution distribution)
    {
        this.DistributionName = distribution.DistributionName;
        this.PrinterIID = distribution.PrinterIID;
    }
    public Distribution Clone()
    {
        return new Distribution(IID, DistributionName, ShortName, PrinterIID, ParentMenuIID, DisplayOrder);
    }
}
