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
    public partial class Header : System.Web.UI.UserControl
    {


        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSale_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderPadSimple.aspx", true);
            
        }

        protected void btnLastOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

        protected void btnTables_Click(object sender, EventArgs e) {
            Response.Redirect("Tables.aspx");
        }
    }
}