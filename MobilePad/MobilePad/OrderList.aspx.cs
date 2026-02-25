using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using DTRMNS;

namespace MobilePad
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected DTRMSimpleBusiness dtrm;

        protected void Page_Load(object sender, EventArgs e)
        {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            LoadOrderList(false);
        }

        private void LoadOrderList(bool blnAll)
        {
            string scoope = "";
            if (blnAll)
                scoope = "";
            else
                scoope = " TOP 5 ";
            DataTable dt = dtrm.db.GetDataTable("Select " + scoope + " IID, OrderDate , CalculatedValue from OrdersView where UserName = '" + dtrm.LoggedUser.UserName + "' order by OrderDate desc");
            lblMessage.Text = scoope;

            dlOrders.DataSource = dt;
            dlOrders.DataBind();
        }

        protected void dlOrders_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (dtrm.AttachedOrder == null) {
                dtrm.AttachedOrder = new Order(OrderTypes.DirectSale);
                dtrm.AttachedOrder.UserName = dtrm.LoggedUser.UserName;

                //indicate additional items put into order
                dtrm.AttachedOrder.Buzzer = "fuzz";
                Session["DTRM"] = dtrm;
                //dtrm.SaveOrder(dtrm.AttachedOrder);
            }

            if (dtrm.AttachedOrder.items.Count == 0 || dtrm.AttachedOrder.Status == StatusFlags.COMPLETED)
            {

                dlOrders.SelectedIndex = e.Item.ItemIndex;
                string OrderIID = ((Label)e.Item.FindControl("OrderIID")).Text;
                dtrm.AttachedOrder = dtrm.GetOrder(OrderIID);
                dtrm.AttachedOrder.Buzzer = "fuzz";
                Session["DTRM"] = dtrm;
                Response.Redirect("OrderPadSimple.aspx");
            }
            else
            {
                lblMessage.Text = "You must cash out or closed the order";
            }
        }

        protected void btnScoope_Click(object sender, EventArgs e)
        {
            if (btnScoope.Text == "ALL ORDERS")
            {
                LoadOrderList(true);
                btnScoope.Text = "LAST 5 ORDERS";
            }
            else
            {
                LoadOrderList(false);
                btnScoope.Text = "ALL ORDERS";
            }
        }
    }
}