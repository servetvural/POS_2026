using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class UncompletedOrdersSessionSum     : BaseClass
{
    public string? SessionIID { get; set; }

    public double? GrossSessionTotalUncompleted { get; set; }
}
