using System.Collections.Generic;

namespace DTRMNS {
    public class SessionOrderList {
        public string SessionIID { get; set; }
        public List<string> OrderList { get; set; }
        public SessionOrderList() {
            SessionIID = "";
            OrderList = new List<string>();
        }
        public SessionOrderList(string SessionIID) {
            this.SessionIID = SessionIID;
            OrderList = new List<string>();
        }
    }
}
