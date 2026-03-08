using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Debug    : BaseClass
{
    public int DebugNo { get; set; }

    public DateTime EventDateTime { get; set; }

    public string Data { get; set; } = null!;
}
