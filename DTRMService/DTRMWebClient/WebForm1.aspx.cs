using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace DTRMWebClient {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            DTRMService.DTRMServiceClient client = new DTRMService.DTRMServiceClient("BasicHttpBinding_IDTRMService");
            Label1.Text = client.GetMessage(TextBox1.Text);
        }
    }
}