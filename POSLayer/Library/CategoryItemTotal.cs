using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Library;

public class CategoryItemTotal
{
    public string CategoryItemIID { get; set; }
    public string CategoryItemName { get; set; }
    public double TotalQuantity { get; set; }
    public double TotalValue { get; set; }
}
