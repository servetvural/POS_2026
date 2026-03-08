using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class LogItem : BaseClass
{
    public string? OrderItemText { get; set; }

    public double Quantity { get; set; }

    public decimal Price { get; set; }

    public string? Reason { get; set; }

    public DateTime EventDateTime { get; set; }

    public string? ComputerName { get; set; }

    public string? OrderContent { get; set; }

    public string? Reference { get; set; }
}
