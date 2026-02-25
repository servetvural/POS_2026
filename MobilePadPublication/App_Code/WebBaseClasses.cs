using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilePad.App_Code
{
    /// <summary>
    /// Summary description for EntityList
    /// </summary>
    public class EntityList
    {
        private string loIID;
        private string loEntityName;
        public EntityList() { }
        public string IID { get { return loIID; } set { loIID = value; } }
        public string EntityName { get { return loEntityName; } set { loEntityName = value; } }
    }

}