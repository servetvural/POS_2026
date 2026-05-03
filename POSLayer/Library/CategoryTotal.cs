using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Library;

public  class CategoryTotal
{
    public string CategoryIID { get; set; }
    public string CategoryName { get; set; }
    public double TotalQuantity { get; set; }
    public double TotalValue { get; set; }
}
