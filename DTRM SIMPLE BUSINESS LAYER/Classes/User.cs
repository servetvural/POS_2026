using System;
using System.Data;
using System.ComponentModel;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class User 
    {
        private string _IID=ShortGuid.NewGuid().ToString();
        [ReadOnly(true), CategoryAttribute("User Details"), DescriptionAttribute("Displayed User Name")]
        public string IID { get { return _IID; } set { _IID = value; } } 
        
        private string _UserName;
        [CategoryAttribute("User Details"), DescriptionAttribute("Displayed User Name")]
        public string UserName { get { return _UserName; } set { _UserName = value; } }

        private string _UserPassword;
        [CategoryAttribute("User Details"), DescriptionAttribute("User Password to Login to system")]
        public string UserPassword { get { return _UserPassword; } set { _UserPassword = value; } }

        private AccessLevels _AccessLevel;
        [CategoryAttribute("User Details"), DescriptionAttribute("User's Level of Access to the system")]
        public AccessLevels AccessLevel { get { return _AccessLevel; } set { _AccessLevel = value; } }


        public string AccessLevelAsString { get; set; }

        public User()
        {
            UserName = "unknown";
            UserPassword = "";
            AccessLevel = AccessLevels.User;            
        }
        public User(string UserName, string UserPassword, AccessLevels AccessLevel)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.AccessLevel = AccessLevel;
        }
        public User(string IID, string UserName, string UserPassword, AccessLevels AccessLevel)
        {
            this.IID = IID;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.AccessLevel = AccessLevel;
        }
        public User(DataRow dr)
        {
            if (dr != null)
            {
                this.IID = dr["IID"].ToString();
                this.UserName = dr["UserName"].ToString();
                this.UserPassword = dr["UserPassword"].ToString();
                this.AccessLevel = (AccessLevels)int.Parse(dr["AccessLevel"].ToString());
            }
        }      
        
        public User Clone()
        {
            return new User(this.IID, this.UserName, this.UserPassword, this.AccessLevel);
        }
        //User, Manager, SuperUser, TechnicalSupport
        public bool IsManagerOrMore() {
            return ((int)AccessLevel >= (int)AccessLevels.Manager);
        }
        public bool IsSuperUserOrMore() {
            return ((int)AccessLevel >= (int)AccessLevels.SuperUser);
        }
        public bool IsTechnicalOrMore() {
            return ((int)AccessLevel >= (int)AccessLevels.TechnicalSupport);
        }
    }

}
