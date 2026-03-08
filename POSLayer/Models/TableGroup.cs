using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TableGroup        : BaseClass
{
    public string GroupName { get; set; } = null!;
    public int DisplayOrder { get; set; }
    public int Width { get; set; }

    public int Height { get; set; }
}
