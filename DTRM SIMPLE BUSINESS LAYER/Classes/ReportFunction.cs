using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTRMNS {

    [System.Serializable]
    public class ReportFunction {
        public string IID { get; set; }
        public string FunctionName { get; set; }
        public string FunctionDescription { get; set; }
        public string FriendlyName { get; set; }

        public ReportFunction() {
        }
        public ReportFunction(string IID, string FunctionName) {
            this.IID = IID;
            this.FunctionName = FunctionName;
            this.FunctionDescription = "";
            this.FriendlyName = "";
        }
        public ReportFunction(string IID, string FunctionName, string FunctionDescription, string FriendlyName) {
            this.IID = IID;
            this.FunctionName = FunctionName;
            this.FunctionDescription = FunctionDescription;
            this.FriendlyName = FriendlyName;
        }
        public ReportFunction(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                FunctionName = dt.Rows[0]["FunctionName"].ToString();
                FunctionDescription = dt.Rows[0]["FunctionDescription"].ToString();
                FriendlyName = dt.Rows[0]["FriendlyName"].ToString();
            }
        }

    }

}
