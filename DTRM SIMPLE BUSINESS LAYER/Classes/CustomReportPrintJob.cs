using System;

namespace DTRMNS {
    public class CustomReportPrintJob
    {
        public ReportFormatTypes ReportType{ get; set; }
        public string PrinterIID { get; set; }
        public string SessionIID { get; set; }
        public DateTime SessionStartDate { get; set; }
        public bool LatePrinting { get; set; }

        public CustomReportPrintJob()
        {
        }
        public CustomReportPrintJob(ReportFormatTypes ReportType, string PrinterIID, string SessionIID, DateTime SessionStartDate, bool LatePrinting)
        {
            this.ReportType = ReportType;
            this.PrinterIID = PrinterIID;
            this.SessionIID = SessionIID;
            this.SessionStartDate = SessionStartDate;
            this.LatePrinting = LatePrinting;
        }
        
    }
}
