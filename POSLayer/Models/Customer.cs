namespace POSLayer.Models;

public partial class Customer   : BaseClass
{
    public string CName { get; set; } =string.Empty;
    public string Postcode { get; set; }     = string.Empty;
    public string Address { get; set; }       = string.Empty;
    public string Town { get; set; }     = string.Empty;
    public string Tel { get; set; }      = string.Empty;
    public string Email { get; set; }    = string.Empty;
    public string CPassword { get; set; } = string.Empty;

    // Navigation property
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
