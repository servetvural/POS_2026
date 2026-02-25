using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DTRMNS {
    public class ReportFunctionNameList {
        public List<string> Items = new List<string>();

        public ReportFunctionNameList() {
        }

        public ReportFunctionNameList(DataTable dt) {
            for (int i = 0; i < dt.Rows.Count; i++) 
                Items.Add(dt.Rows[i]["FunctionName"].ToString());                
        }

        public bool Exist(string FunctionName) {
            return Items.Exists(delegate(string param) { return param == FunctionName; });
        }
        
    }
}
