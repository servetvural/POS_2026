using System;
using System.Collections.Generic;
using System.Text;

namespace DTRMNS {
    public class SimpleEntityButton
    {
        private string _IID = "";
        private string _EntityButtonName = "";
        private int _Total;
        public SimpleEntityButton()
        {
        }
        public string IID { get { return _IID; } set { _IID = value; } }
        public string EntityButtonName { get { return _EntityButtonName; } set { _EntityButtonName = value; } }
        public int Total { get { return _Total; } set { _Total = value; } }
    }

}
