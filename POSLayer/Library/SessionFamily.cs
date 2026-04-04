
using POSLayer.Models;

namespace POSLayer.Library;

public class SessionFamily
{
    public Session session { get; set; }
    public List<Order> Orders { get; set; }

}