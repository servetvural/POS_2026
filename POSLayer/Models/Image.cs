using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Image
{
    public string ReferenceIid { get; set; } = null!;

    public byte[]? DisplayImage { get; set; }

    public string ExtraText { get; set; } = null!;

    public string? ImageFileName { get; set; }
}
