using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DTRMNS {

    [System.Serializable]
    public class Client {
        private string _IID = Guid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }

        private string _ClientName = "Client Name";
        public string ClientName { get { return _ClientName; } set { _ClientName = value; } }

        public Client() {

        }
        public Client(string IID, string ClientName) {
            this.IID = IID;
            this.ClientName = ClientName;
        }
        public Client(string ClientName) {
            this.ClientName = ClientName;
        }

        public Client(DataRow dr)
        {
            if (dr != null)
            {
                IID = dr["IID"].ToString();
                ClientName = dr["ClientName"].ToString();
            }
        }
        public Client(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                IID = dt.Rows[0]["IID"].ToString();
                ClientName = dt.Rows[0]["ClientName"].ToString();
            }
        }
    }
}
