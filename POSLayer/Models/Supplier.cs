using System;
using System.Collections.Generic;

namespace POSLayer.Models;

[System.Serializable]
public partial class Supplier   : BaseClass
{
    public string SupplierName { get; set; } = string.Empty;

    public string Prefix { get; set; }

    public string Tel { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Email1 { get; set; } = string.Empty;

    public string Email2 { get; set; } = string.Empty;

    public string Whatsup { get; set; } = string.Empty;
}
