using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class UserSale : BaseClass
{
    public string? SessionIID { get; set; }

    public string? UserName { get; set; }

    public double? Total { get; set; }
}
