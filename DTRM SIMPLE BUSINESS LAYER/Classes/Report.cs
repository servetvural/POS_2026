

using POSLayer.Library;

namespace DTRMNS {
    public class Report {
        
        public string ReportName { get; set; }
        public ReportFormatTypes ReportType { get; set; }
        public bool RequireCashDrawTotal { get; set; }
        public bool PrintCategoryReport { get; set; }
        public bool PrintCategoryDetailedReport { get; set; }

        public bool PrintCashOrderList { get; set; }
        public bool PrintCardOrderList { get; set; }
        public bool PrintOnlineOrderList { get; set; }

        public Report() {            
            ReportName = "Unknown";
        }

        public Report(ReportFormatTypes ReportType) {
            if (ReportType == ReportFormatTypes.XReport)
                ReportName = "X REPORT";
            else if (ReportType == ReportFormatTypes.ZReport)
                ReportName = "Z REPORT";
            this.ReportType = ReportType;

        }
    }
}
