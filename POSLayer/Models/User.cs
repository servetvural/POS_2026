using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class User
{
    public string Iid { get; set; } = null!;

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public int? AccessLevel { get; set; }
}
