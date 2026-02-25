using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DronaxLibrary.DBSpace;

namespace DTRMNS {
    [System.Serializable]
    public class RemoteStation {
        private string _IID = Guid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string DataSource { get; set; }
        public string DBCatalog { get; set; }
        public string DBUserName { get; set; }
        public string DBPassword { get; set; }
        public string FriendlyName { get; set; }

        public RemoteStation() {
            DataSource = "";
            DBCatalog = "";
            DBUserName = "";
            DBPassword = "";
            FriendlyName = "Must be supplied";
        }
        public RemoteStation(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            DataSource = dt.Rows[0]["DataSource"].ToString();
            DBCatalog = dt.Rows[0]["DBCatalog"].ToString();
            DBUserName = dt.Rows[0]["DBUserName"].ToString();
            DBPassword = dt.Rows[0]["DBPassword"].ToString();
            FriendlyName = dt.Rows[0]["FriendlyName"].ToString();
        }

        public bool Delete(DB db) {
            return db.RunQuery("DeleteRemoteStation " +
            "'" + IID.Replace("'", "''") + "'");
        }
        public bool Save(DB db) {
            return db.RunQuery("SaveRemoteStation " +
            "'" + IID.Replace("'", "''") + "','" + DataSource.Replace("'", "''") + "','" +
            DBCatalog.Replace("'", "''") + "','" + DBUserName.Replace("'", "''") + "','" +
            DBPassword.Replace("'", "''") + "','" + FriendlyName.Replace("'", "''") + "'");
        }
    }

}
