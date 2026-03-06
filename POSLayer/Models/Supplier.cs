using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Supplier
{
    public string Iid { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Email1 { get; set; } = null!;

    public string Email2 { get; set; } = null!;

    public string Whatsup { get; set; } = null!;
}
