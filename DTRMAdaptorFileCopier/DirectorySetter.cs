using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DTRMSimpleAdaptor {
    [Serializable]
    public class DirectorySetter {

        private string _AppDirectory = "";
        public string AppDirectory { get { return _AppDirectory; } set { _AppDirectory = value; } }

        private string _SessionDirectory = "";
        public string SessionDirectory { get { return _SessionDirectory; } set { _SessionDirectory = value; } }

        private string _ReportDirectory = "";
        public string ReportDirectory { get { return _ReportDirectory; } set { _ReportDirectory = value; } }

        public DirectorySetter() {

        }
        public DirectorySetter(string AppDirectory) {
            this.AppDirectory = AppDirectory;
            this.SessionDirectory = AppDirectory + "\\Sessions";
            this.ReportDirectory = AppDirectory + "\\Reports";
        }
        public DirectorySetter(string AppDirectory, string SessionDirectory, string ReportDirectory) {
            this.AppDirectory = AppDirectory;
            this.SessionDirectory = SessionDirectory;
            this.ReportDirectory = ReportDirectory;
        }
    }
}

