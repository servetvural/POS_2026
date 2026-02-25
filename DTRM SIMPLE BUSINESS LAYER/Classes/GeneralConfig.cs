using System;
using System.Collections.Generic;
using System.Text;

namespace DTRMNS {
    [System.Serializable]
    public class GeneralConfig
    {
        public string DefaultCompanyIID;
        public string DefaultWareHouseIID;
        public GeneralConfig()
        {
            DefaultCompanyIID = "";
            DefaultWareHouseIID = "";
        }
    }
}
