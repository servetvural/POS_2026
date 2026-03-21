using POSLayer.Models;

namespace POSLayer.Library;

public class SessionDataShort : BaseClass
{
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public double GrossSessionTotal { get; set; }
    public double X1Total { get; set;  }
    public double X2Total { get; set; }
    public double X3Total { get; set; }

}
