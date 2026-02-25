using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DTRMNS;

namespace MobilePad {
    public partial class HoldOrders : System.Web.UI.UserControl {
        protected DTRMSimpleBusiness dtrm;
        protected void Page_Load(object sender, EventArgs e) {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            LoadHoldOrdersForUser();
        }

        public void LoadHoldOrdersForUser() {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            if (dtrm.AttachedOrder == null) {
                if (dtrm.LoggedUser.IsSuperUserOrMore())  //Load unpaid orders for everybody
                    dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where Payment = 0");
                else  //Load only this user's unpaid orders
                    dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where UserName = '" + dtrm.LoggedUser.UserName + "' and Payment = 0");
            } else {
                if (dtrm.LoggedUser.IsSuperUserOrMore()) //Load unpaid orders for everybody except the current order
                    dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where  IID <> '" + dtrm.AttachedOrder.IID + "' and Payment = 0");
                else //Load only this user's unpaid orders except the current order
                    dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where UserName = '" + dtrm.LoggedUser.UserName + "' and IID <> '" + dtrm.AttachedOrder.IID + "' and Payment = 0");
            }
            dlHoldOrders.DataBind();
        }

        protected void dlHoldOrders_ItemCommand(object source, DataListCommandEventArgs e) {
            //attachedorder null ise ok
            if (dtrm.AttachedOrder == null)
                HandleHoldOrderClick(e.CommandArgument.ToString());
            else {
                //attachedorder not nul ise

                 //status completed  ok  but unload order     //item count == 0 ok
                if (dtrm.AttachedOrder.Status == StatusFlags.COMPLETED || dtrm.AttachedOrder.items.Count == 0) 
                    HandleHoldOrderClick(e.CommandArgument.ToString());
            }


            //if (dtrm.AttachedOrder != null && dtrm.AttachedOrder.items.Count > 0)
            //    return;

            
        }

        protected void HandleHoldOrderClick(string OrderIID) {
            dtrm.AttachedOrder = dtrm.GetOrder(OrderIID);
            dtrm.AttachedOrder.Buzzer = "fuzz";
            Session["DTRM"] = dtrm;
            Response.Redirect("OrderPadSimple.aspx");
        }
        
    }
}