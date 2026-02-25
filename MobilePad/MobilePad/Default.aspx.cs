using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;
using DTRMNS;

namespace MobilePad
{
    public partial class Default : System.Web.UI.Page
    {
        protected DTRMSimpleBusiness dtrm;
        protected WebSettings webs;

        protected void Page_Load(object sender, EventArgs e)
        {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            webs = (WebSettings)Session["WEBS"];
            if (!this.Page.IsPostBack)
            {
                LoadDynamics();
            }

        }
        protected void LoadDynamics()
        {
            Page.Title = webs.StoreHeader;
        }

        protected void btnLogin_Click(object sender, System.EventArgs e)
        {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            webs = (WebSettings)Session["WEBS"];
            lblDebug.Text = webs.CurrentCatalogIID;

            User user = dtrm.GetUserByPassword(txtPassword.Text);

            if (user == null)
                lblMessage.Text = "Login failed";
            else
            {
                try
                {
                    if (user.UserPassword == txtPassword.Text.Trim())
                    {

                        //Context.User.Identity.Name = customer.IID;
                        // Set Client Authentication Cookie
                        FormsAuthentication.SetAuthCookie(user.IID, false);
                        Session.Timeout = 30;
                        dtrm.LoggedUser = user;

                        Response.Redirect("OrderPadSimple.aspx");
                        //FormsAuthentication.RedirectFromLoginPage(customer.IID, true, "OrderPad.aspx");
                    }
                    else
                        lblMessage.Text = "Login failed";
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    user = null;
                    lblMessage.Text = "Login failed";
                }
            }
            txtPassword.Text = "";
        }



        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            lblMessage.Text = "";
        }
    }
}