using System.Collections.Generic;

namespace DTRMNS {
    [System.Xml.Serialization.XmlInclude(typeof(SessionData))]
    [System.Xml.Serialization.XmlInclude(typeof(OrderItem))]
    [System.Xml.Serialization.XmlInclude(typeof(Order))]
    [System.Serializable]
    public class SessionFamily
    {
        public SessionData sessionData { get; set; }
        public List<Order> Orders { get; set; }
        public SessionFamily()
        {
        }
    }
}
