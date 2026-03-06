using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Customer
{
    public string Iid { get; set; } = null!;

    public string? Cname { get; set; }

    public string? CompanyName { get; set; }

    public string? Postcode { get; set; }

    public string? Address { get; set; }

    public string? Buzzer { get; set; }

    public string? Town { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Cpassword { get; set; }
}
