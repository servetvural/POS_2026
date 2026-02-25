using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Configuration;

namespace MobilePad
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started 
            //Establish Local Connection [website]
            DTRMNS.DTRMConfig config = new DTRMNS.DTRMConfig();

            //config.Shop_Name = ConfigurationManager.AppSettings["Shop_Name"];
            config.Database_Instance = ConfigurationManager.AppSettings["Database_Instance"];
            config.Database_Name = ConfigurationManager.AppSettings["Database_Name"];
            config.Database_User_Name = ConfigurationManager.AppSettings["Database_User_Name"];
            config.Database_Password = ConfigurationManager.AppSettings["Database_Password"];
            //config.CurrentCatalogIID = ConfigurationManager.AppSettings["CurrentCatalogIID"];

            config.Application_Type = DTRMNS.ApplicationTypes.ThinClient;
            

            DTRMNS.DTRMSimpleBusiness bslayer = new DTRMNS.DTRMSimpleBusiness(config);

            DTRMNS.WebSettings webs = bslayer.GetWebsiteConfig();
            bslayer.config.CurrentCatalogIID = webs.CurrentCatalogIID;
            Session.Add("DTRM", bslayer);
            Session.Add("WEBS", webs);


            //Establish Remote Connection [Shop which is monitoring the web]
            ////DTRMNS.DTRMConfig Remoteconfig = new DTRMNS.DTRMConfig();
            ////Remoteconfig.Shop_Name = ConfigurationManager.AppSettings["Shop_Name"];
            ////Remoteconfig.Database_Instance = webs.ShopDataSource;
            ////Remoteconfig.Database_Name = webs.ShopDBCatalog;
            ////Remoteconfig.Database_User_Name = webs.ShopDBUserName;
            ////Remoteconfig.Database_Password = webs.ShopDBPassword;
            ////DTRMNS.DTRMSimpleBusiness Remotebslayer = new DTRMNS.DTRMSimpleBusiness(Remoteconfig, false, false);
            ////if (Remotebslayer.IsDBAvailable()) {
            ////    Session.Add("RemoteDTRM", Remotebslayer);
            ////}
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
            FormsAuthentication.SignOut();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}