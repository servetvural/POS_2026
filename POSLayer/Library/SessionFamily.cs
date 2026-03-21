
using POSLayer.Models;

namespace POSLayer.Library;

public class SessionFamily
{
    public SessionData sessionData { get; set; }
    public List<Order> Orders { get; set; }

}