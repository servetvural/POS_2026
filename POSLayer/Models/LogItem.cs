using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml;

namespace POSLayer.Models;

public partial class LogItem : BaseClass
{
    public string? OrderItemText { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public string? Reason { get; set; }

    public DateTime EventDateTime { get; set; }

    public string? ComputerName { get; set; }

    public string? OrderContent { get; set; }

    public string? Reference { get; set; }


    public double Total { get { return Price * Quantity; } }

    public override string ToString()
    {
        return JsonSerializer.Serialize<LogItem>(this, new JsonSerializerOptions() { WriteIndented = true });
    }

    public string ToSimpleString()
    {
        return "**** " + Reason + " => " + Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(20, ' ') +
            Price.ToString("N2").PadLeft(10, ' ') + Total.ToString("N2").PadLeft(10, ' ') + "   Reference = " + Reference.PadRight(12, ' ') + Environment.NewLine;
    }
}
