using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class UncompletedOrdersSessionSum
{
    public string? SessionIid { get; set; }

    public double? GrossSessionTotalUncompleted { get; set; }
}
