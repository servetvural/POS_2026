using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TableGroup        : BaseClass
{
    public string GroupName { get; set; } = string.Empty;
    public int Width { get; set; }

    public int Height { get; set; }
}
