using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DTRMNS {
    public class ReportFunctionNameItem {
        public string FunctionName { get; set; }

        public ReportFunctionNameItem() {
        }
        public ReportFunctionNameItem(string FunctionName) {
            this.FunctionName = FunctionName;
        }
        public ReportFunctionNameItem(DataRow dr) {
            ReportIID = dr["ReportIID"].ToString();
            FunctionName = dr["FunctionName"].ToString();
        }
    }
}
