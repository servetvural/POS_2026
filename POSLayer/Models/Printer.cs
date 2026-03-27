using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Printer : BaseClass
{
    /// <summary>
    /// Easy Name to use in the app
    /// </summary>
    public string ApplicationName { get; set; } = string.Empty;

    /// <summary>
    /// Local, Global
    /// </summary>
    public PrinterVisibilityTypes PrinterVisibility { get; set; }

    /// <summary>
    /// Associated Local Computer, value read from config (Terminal Name)
    /// </summary>
    public string? LocalTerminal { get; set; }

    /// <summary>
    /// Local or Global Mapping Name
    /// </summary>
    public string NetworkName { get; set; } = string.Empty;

    /// <summary>
    ///  Unknown, Kitchen, Receipt, Mutant
    /// </summary>
    public PrinterTypes PrinterType { get; set; }

    /// <summary>
    /// Printer is a dedicated Delivery Printer
    /// </summary>
    public bool DeliveryPrinter { get; set; }

    /// <summary>
    /// Printer is a dedicated TakeAway Printer
    /// </summary>
    public bool TakeAwayPrinter { get; set; }

    /// <summary>
    /// Ensure only admins can see these printers
    /// </summary>
    public bool AdminOnly { get; set; } 
                 



                           
    /// <summary>
    /// Distributions which are using this printer
    /// </summary>
    public List<Distribution> distributions { get; set; } = new();
}
