using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Table
{
    public string Iid { get; set; } = null!;

    public int? Number { get; set; }

    public string? TableName { get; set; }

    public int? TableCovers { get; set; }

    public string? LockedClientIp { get; set; }

    public string? CurrentOrderIid { get; set; }

    public int? TableType { get; set; }

    public int DisplayOrder { get; set; }

    public int Xlocation { get; set; }

    public int Ylocation { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public string GroupIid { get; set; } = null!;

    public string ParentTableIid { get; set; } = null!;

    public int Shape { get; set; }

    public string DefaultName { get; set; } = null!;
}
