using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using DTRMNS;

namespace MobilePad {
    public partial class Tables : System.Web.UI.Page {

        protected DTRMSimpleBusiness dtrm;

        protected void Page_Load(object sender, EventArgs e) {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            LoadTables();
        }

        private void LoadTables() {
            DataTable dt = dtrm.db.GetDataTable("Select IID, TableName , Number from Tables order by DisplayOrder asc");
            

            dlTables.DataSource = dt;
            dlTables.DataBind();
        }

        protected void dlTables_ItemCommand(object source, DataListCommandEventArgs e) {
            //if (dtrm.AttachedOrder == null) {
            //    dtrm.AttachedOrder = new Order(OrderTypes.DirectSale);
            //    dtrm.AttachedOrder.UserName = dtrm.LoggedUser.UserName;

            //    //indicate additional items put into order
            //    dtrm.AttachedOrder.Buzzer = "fuzz";
            //    Session["DTRM"] = dtrm;
            //    //dtrm.SaveOrder(dtrm.AttachedOrder);
            //}

            //if (dtrm.AttachedOrder.items.Count == 0 || dtrm.AttachedOrder.Status == StatusFlags.COMPLETED) {

            //    dlOrders.SelectedIndex = e.Item.ItemIndex;
            //    string OrderIID = ((Label)e.Item.FindControl("OrderIID")).Text;
            //    dtrm.AttachedOrder = dtrm.GetOrder(OrderIID);
            //    dtrm.AttachedOrder.Buzzer = "fuzz";
            //    Session["DTRM"] = dtrm;
            //    Response.Redirect("OrderPadSimple.aspx");
            //} else {
            //    lblMessage.Text = "You must cash out or closed the order";
            //}
        }
    }
}