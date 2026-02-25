using System.Data;
using PosLibrary;

namespace DTRMNS {

    [System.Serializable]
    public class ApplicationPrinter  {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }

        public bool DeliveryPrinter { get; set; }
        public bool TakeAwayPrinter { get; set; }
        public bool AdminOnly { get; set; }
        public string ClientIID { get; set; }
        public string NetworkName { get; set; }
        public string ApplicationName { get; set; }
        public PrinterTypes PrinterType { get; set; }

        public string PrinterTypeAsString { get; set; }

        public ApplicationPrinter() {
        }
        public ApplicationPrinter(DataRow dr) {
            if (dr != null) {
                IID = dr["IID"].ToString();
                ClientIID = dr["ClientIID"].ToString();
                NetworkName = dr["NetworkName"].ToString();
                ApplicationName = dr["ApplicationName"].ToString();
                PrinterType = (PrinterTypes)int.Parse(dr["PrinterType"].ToString());
                DeliveryPrinter = (int.Parse(dr["DeliveryPrinter"].ToString()) == 0 ? false : true);
                TakeAwayPrinter = (int.Parse(dr["TakeAwayPrinter"].ToString()) == 0 ? false : true);
                AdminOnly = (int.Parse(dr["AdminOnly"].ToString()) == 0 ? false : true);
            }
        }
        public ApplicationPrinter(string NetworkName) {
            this.NetworkName = NetworkName;
        }
        public ApplicationPrinter(string NetworkName, string ApplicationName) {
            this.NetworkName = NetworkName;
            this.ApplicationName = ApplicationName;
        }
        public ApplicationPrinter(string NetworkName, string ApplicationName, PrinterTypes PrinterType) {
            this.NetworkName = NetworkName;
            this.ApplicationName = ApplicationName;
            this.PrinterType = PrinterType;
        }
        public void Update(string ApplicationName, PrinterTypes PrinterType) {
            this.ApplicationName = ApplicationName;
            this.PrinterType = PrinterType;
        }
    }
}
