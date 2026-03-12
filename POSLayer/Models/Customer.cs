using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Customer   : BaseClass
{

    public string CName { get; set; } =string.Empty;

    public string CompanyName { get; set; }  = string.Empty;  

    public string Postcode { get; set; }     = string.Empty;

    public string Address { get; set; }       = string.Empty;

    public string Buzzer { get; set; }    = string.Empty;

    public string Town { get; set; }     = string.Empty;

    public string Tel { get; set; }      = string.Empty;

    public string Fax { get; set; }       = string.Empty;

    public string Mobile { get; set; }  = string.Empty;

    public string Email { get; set; }    = string.Empty;

    public string CPassword { get; set; } = string.Empty;
}
