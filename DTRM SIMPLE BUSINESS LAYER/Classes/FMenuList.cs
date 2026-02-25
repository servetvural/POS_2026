using PosLibrary;

namespace DTRMNS {
    public class FMenuList
    {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }

        private string _MenuName = "";
        public string MenuName { get { return _MenuName; } set { _MenuName = value; } }

        public FMenuList() { }
    }
}
