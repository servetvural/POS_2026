using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class TableGroup
{
    public string Iid { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }
}
