using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Library;

public class OrderItemSummary
{
    public double Quantity { get; set; } 
    public string? OrderItemText { get; set; }
    public double Price { get; set; }
    public double Total { get; set; }
}
