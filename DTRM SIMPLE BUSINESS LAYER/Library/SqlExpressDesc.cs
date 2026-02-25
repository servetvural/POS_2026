using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTRMNS.Library {
    public class SqlExpressDesc {
        public string IP { get; set; }
        public string ServerName { get; set; }
        public OSTypes osType { get; set; }
        public string Version { get; set; }
        public bool isDefault { get; set; }
        public string FullName { get { return IP + "\\" + ServerName; } }
        public SqlExpressDesc() {

        }
        public SqlExpressDesc(string ServerName) {
            this.ServerName = ServerName;
        }
        public override string ToString() {
            return ServerName + ", " + osType.ToString() + ", " + Version + ", " + (isDefault ? "Default" : "Instance");
        }

    }
}
