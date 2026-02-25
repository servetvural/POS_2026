using System.Data;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class Distribution 
    {
        private string _IID=ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } } 
        public string DistributionName { get; set; }
        public string ShortName { get; set; }
        public string PrinterIID { get; set; }
        public string ParentMenuIID { get; set; }
        public int DisplayOrder { get; set; }

        public Distribution()
        {
            this.DistributionName = "";
            this.ShortName = "";
            this.PrinterIID = "";
            this.ParentMenuIID = "";
        }
        public Distribution(DataRow dr)
        {
            if (dr != null)
            {
                IID = dr["IID"].ToString();
                DistributionName = dr["DistributionName"].ToString();
                ShortName = dr["ShortName"].ToString();
                PrinterIID = dr["PrinterIID"].ToString();
                ParentMenuIID = dr["ParentMenuIID"].ToString();
                DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
            }
        }
        public Distribution(string DistributionName, string PrinterIID)
        {
            this.DistributionName = DistributionName;
            this.ShortName = "";
            this.PrinterIID = PrinterIID;
            this.ParentMenuIID = "";
        }
        private Distribution(string IID, string DistributionName, string ShortName, string PrinterIID,
            string ParentMenuIID, int DisplayOrder)
        {
            this.IID = IID;
            this.DistributionName = DistributionName;
            this.ShortName = ShortName;
            this.PrinterIID =PrinterIID;
            this.ParentMenuIID = ParentMenuIID;
            this.DisplayOrder = DisplayOrder;
        }

        public void ChangePrinterName(string PrinterIID)
        {
            this.PrinterIID = PrinterIID;
        }
        public void Update(string DistributionName, string ShortName, string PrinterIID,string ParentMenuIID, int DisplayOrder)
        {
            this.DistributionName = DistributionName;
            this.ShortName = ShortName;
            this.PrinterIID = PrinterIID;
            this.ParentMenuIID = ParentMenuIID;
            this.DisplayOrder = DisplayOrder;
        }

        public void Update(Distribution distribution)
        {
            this.DistributionName = distribution.DistributionName;
            this.PrinterIID = distribution.PrinterIID;
        }
        public Distribution Clone()
        {
            return new Distribution(this.IID, this.DistributionName, this.ShortName, this.PrinterIID, this.ParentMenuIID, this.DisplayOrder);
        }
       
    }

}
