using System.Data;
using PosLibrary;

namespace DTRMNS {

    public class DistributionView {


        public string IID { get; set; }
        public string DistributionName { get; set; }
        public string ShortName { get; set; }
        public string PrinterIID { get; set; }
        public string ParentMenuIID { get; set; }
        public int DisplayOrder { get; set; }
        public string PrinterNetworkName { get; set; }
        public string MenuName { get; set; }

        public DistributionView() {
            IID = ShortGuid.NewGuid().ToString();
            DistributionName = "DISTRIBUTION";
            ShortName = "";
            PrinterIID = "";
            ParentMenuIID = "";
            DisplayOrder = 0;
            PrinterNetworkName = "";
            MenuName = "";
        }
        public DistributionView(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                DistributionName = dt.Rows[0]["DistributionName"].ToString();
                ShortName = dt.Rows[0]["ShortName"].ToString();
                PrinterIID = dt.Rows[0]["PrinterIID"].ToString();
                ParentMenuIID = dt.Rows[0]["ParentMenuIID"].ToString();
                DisplayOrder = int.Parse(dt.Rows[0]["DisplayOrder"].ToString());
                PrinterNetworkName = dt.Rows[0]["PrinterNetworkName"].ToString();
                MenuName = dt.Rows[0]["MenuName"].ToString();
            }
        }
        public DistributionView(DataRow dr) {
            if (dr != null) {
                IID = dr["IID"].ToString();
                DistributionName = dr["DistributionName"].ToString();
                ShortName = dr["ShortName"].ToString();
                PrinterIID = dr["PrinterIID"].ToString();
                ParentMenuIID = dr["ParentMenuIID"].ToString();
                DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
                PrinterNetworkName = dr["PrinterNetworkName"].ToString();
                MenuName = dr["MenuName"].ToString();

            }
        }
    }
}
