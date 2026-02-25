using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Data;
using DTRMNS;

namespace MobilePad {
    public partial class OrderPadSimple : System.Web.UI.Page {
        protected DTRMSimpleBusiness dtrm;
        protected Entity SelectedEntity;
        protected EntityButton SelectedSILButton;
        protected OrderItem SelectedOrderItem;

        protected WebSettings webs;
        protected bool blnOrderReadOnly;

        protected void Page_Load(object sender, EventArgs e) {
            //ENTITY SECTION
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            webs = (WebSettings)Session["WEBS"];

            //Order read only
            if (dtrm.AttachedOrder != null && dtrm.AttachedOrder.Status == StatusFlags.COMPLETED)
                blnOrderReadOnly = true;


            // If page is not being loaded in response to postback
            if (!Page.IsPostBack) {
                Page.Title = dtrm.LoggedUser.UserName;
                lblStore.Text = dtrm.LoggedUser.UserName;
                

                if (!blnOrderReadOnly)
                    LoadEntityList();
                DisplayOrder();
            }
            
        }

        #region HOLD ORDERS
        //protected void LoadHoldOrdersForUser() {
        //    if (dtrm.AttachedOrder != null)
        //        dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where UserName = '" + dtrm.LoggedUser.UserName + "' and IID <> '" + dtrm.AttachedOrder.IID + "' and Payment = 0");
        //    else
        //        dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where UserName = '" + dtrm.LoggedUser.UserName + "' and Payment = 0");
        //    dlHoldOrders.DataBind();
        //}

        //protected void dlHoldOrders_ItemCommand(object source, DataListCommandEventArgs e) {
        //    if (dtrm.AttachedOrder != null && dtrm.AttachedOrder.items.Count > 0)
        //        return;

        //    UnLoadSILButtons();
        //    dtrm.AttachedOrder = dtrm.GetOrder(e.CommandArgument.ToString());
        //    DisplayOrder();
        //}
        #endregion


        #region "ENTITY LIST"
        protected void LoadEntityList() {
            dlEntityList.DataSource = dtrm.GetDataTable("Select IID, EntityName from Entity where entitytype = 0 and WebVisible = 1 and ParentCatalogIID = '" + dtrm.config.CurrentCatalogIID + "' order by DisplayOrder");
            dlEntityList.DataBind();
        }
        protected void dlEntityList_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e) {
            dlEntityList.SelectedIndex = e.Item.ItemIndex;

            SelectedEntity = dtrm.GetEntityDB(e.CommandArgument.ToString());
            Session["SelectedEntity"] = SelectedEntity;

            LoadSILButtons();
        }
        #endregion



        #region "SIL  BUTTONS"
        protected void LoadSILButtons() {
            UnLoadSILButtons();
            dlSIL.DataSource = dtrm.GetDataTable("Select IID, EntityButtonName from EntityButton where ParentEntityIID = '" + SelectedEntity.IID + "' order by displayOrder");
            dlSIL.DataBind();
        }

        protected void UnLoadSILButtons() {
            dlSIL.DataSource = null;
            dlSIL.DataBind();
        }

        protected void dlEntityButtons_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e) {
            dlSIL.SelectedIndex = e.Item.ItemIndex;
            EnsureSelectedEntity();

            SelectedSILButton = SelectedEntity.GetEntityButton(e.CommandArgument.ToString());

            EnsureOrder();
            //Set selected Order Item
            EnsureSelectedOrderItem();

            dtrm.AddSimpleTopOrderItemToAttachedOrder(SelectedSILButton.IID, true);
            DisplayOrder();
        }        
        #endregion
        

        #region "ORDER DISPLAY"

        public void DisplayOrder() {
            EnsureOrder();

            DataTable dt = null;

            if (dtrm.AttachedOrder != null) {
                //this is true if order is already saved in the database but this will not happen at all
                // dt = dtrm.GetDataTable("Select IID, Quantity, OrderItemText, (Quantity *Price) as CalculatedValue from OrderItem where ParentOrderIID = '" + dtrm.AttachedOrder.IID + "' order by DisplayOrder");
                dt = dtrm.GetWebDisplayTableForOrder();

            } 
            ArrangeButtons();

            dgDisplay.DataSource = dt;
            dgDisplay.DataBind();
            lblOrderTotal.Text = dtrm.AttachedOrder.GetTotal().ToString("c2");

            

           // LoadHoldOrdersForUser();
        }

        protected void ArrangeButtons() {
            btnPlus.Visible = btnMinus.Visible = btnDelete.Visible = btnCashPayment.Visible = btnHold.Visible = btnCloseOrder.Visible = btnCancel.Visible = false;

            if (dtrm.AttachedOrder != null) {
                bool hasItem = dtrm.AttachedOrder.items.Count > 0;
                switch (dtrm.AttachedOrder.Status) {
                    case StatusFlags.NEW:
                        //All Buttons visible except btnCloseOrder 
                        btnPlus.Visible = btnMinus.Visible = btnDelete.Visible = btnCashPayment.Visible = btnHold.Visible = btnCancel.Visible = hasItem;
                       
                        break;
                    case StatusFlags.PENDING:
                        //All Buttons visible
                        btnPlus.Visible = btnMinus.Visible = btnDelete.Visible = btnCashPayment.Visible = btnHold.Visible = btnCancel.Visible = hasItem;
                        break;
                    case StatusFlags.COMPLETED:
                        //Only btnCloseOrder button visible
                        btnCloseOrder.Visible = true;
                        break;
                    default:
                        break;
                }

            }

        }

        protected void dgDisplay_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
            if (!blnOrderReadOnly) {
                int oldSelectedIndex = dgDisplay.SelectedIndex;
                dgDisplay.SelectedIndex = e.Item.ItemIndex;

                SelectedOrderItem = dtrm.AttachedOrder.GetOrderItem(dgDisplay.Items[dgDisplay.SelectedIndex].Cells[0].Text);

                if (SelectedOrderItem == null || (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem))
                    dgDisplay.SelectedIndex = oldSelectedIndex;
                else {
                    SelectedEntity = dtrm.GetEntityDB(SelectedOrderItem.EntityIID);
                    Session["SelectedEntity"] = SelectedEntity;
                    LoadSILButtons();

                    if (e.CommandName == "plus1") {
                        btnPlus1_Click(null, null);
                    } else if (e.CommandName == "minus1") {
                        btnMinus1_Click(null, null);
                    } else if (e.CommandName == "delete") {
                        btnDeleteItem_Click(null, null);
                    } else if (e.CommandName == "clone") {
                        btnClone_Click(null, null);
                    }
                }
            }
        }
        #endregion

        #region "BUTTON HANDLERS"
        protected void btnPlus1_Click(object sender, System.EventArgs e) {
            EnsureSelectedOrderItem();
            if (SelectedOrderItem != null) {
                if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
                    return;
                SelectedOrderItem.Quantity++;
                DisplayOrder();
            }
        }

        protected void btnMinus1_Click(object sender, System.EventArgs e) {
            EnsureSelectedOrderItem();
            if (SelectedOrderItem != null) {
                if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
                    return;
                if (SelectedOrderItem.Quantity > 1)
                    SelectedOrderItem.Quantity--;
                else {
                    dtrm.AttachedOrder.DeleteOrderItem(SelectedOrderItem.IID);
                    dgDisplay.SelectedIndex = -1;
                    SelectedOrderItem = null;
                }
                DisplayOrder();
            }
        }

        protected void btnDeleteItem_Click(object sender, System.EventArgs e) {
            //EnsureSelectedOrderItem();
            //if (SelectedOrderItem != null) {
            //    if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
            //        return;
            //    if (SelectedOrderItem.TopItem) {
            //        dtrm.AttachedOrder.DeleteOrderItem(SelectedOrderItem.IID);
            //        dgDisplay.SelectedIndex = -1;
            //        SelectedOrderItem = null;
            //    } else
            //        dtrm.AttachedOrder.GetTopOrderItem(SelectedOrderItem.OrderGroupIID).DeleteSubItem(SelectedOrderItem.IID);
            //    DisplayOrder();
            //}
        }

        protected void btnClone_Click(object sender, System.EventArgs e) {
            //EnsureSelectedOrderItem();
            //if (SelectedOrderItem != null) {
            //    if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
            //        return;
            //    if (SelectedOrderItem.TopItem)
            //        dtrm.AttachedOrder.items.Add(SelectedOrderItem.Clone());
            //    DisplayOrder();
            //}
        }


        protected void btnCashPayment_Click(object sender, EventArgs e) {
            if (dtrm.AttachedOrder != null) {
                if (dtrm.AttachedOrder.items.Count > 0) {
                    dtrm.AttachedOrder.Payment = PaymentMethods.Cash;
                    dtrm.AttachedOrder.Status = StatusFlags.COMPLETED;
                    dtrm.SaveOrder(dtrm.AttachedOrder);
                    dtrm.AttachedOrder = null;
                    UnLoadSILButtons();
                    DisplayOrder();
                }
            }
        }
        #endregion

        #region "UTILITY FUNCTIONS"
        protected void EnsureOrder() {
            if (dtrm.AttachedOrder == null) {
                Order order = new Order();
                order.OrderType = OrderTypes.DirectSale;
                order.UserName = dtrm.LoggedUser.UserName;
                order.Buzzer = "buzz";
                dtrm.AttachedOrder = order;
                
            }
        }
        protected void EnsureSelectedEntity() {
            SelectedEntity = (Entity)Session["SelectedEntity"];
        }

        protected void EnsureSelectedOrderItem() {
            if (dgDisplay.SelectedIndex >= 0) {
                SelectedOrderItem = dtrm.AttachedOrder.GetOrderItem(dgDisplay.SelectedItem.Cells[0].Text);
            }
        }

        #endregion

        protected void btnHold_Click(object sender, EventArgs e) {
            if (dtrm.AttachedOrder != null) {
                if (dtrm.AttachedOrder.items.Count > 0) {
                    dtrm.AttachedOrder.Status = StatusFlags.PENDING;
                    dtrm.SaveOrder(dtrm.AttachedOrder);
                    dtrm.AttachedOrder = null;
                    UnLoadSILButtons();
                    DisplayOrder();
                    HoldOrders1.LoadHoldOrdersForUser();
                }

            }
        }

        protected void btnCloseOrder_Click(object sender, EventArgs e) {
            dtrm.AttachedOrder = null;
            Response.Redirect("OrderPadSimple.aspx", true);
        }

        protected void btnCancel_Click(object sender, EventArgs e) {
            if (dtrm.AttachedOrder != null && (dtrm.AttachedOrder.Status == StatusFlags.NEW || dtrm.AttachedOrder.Status == StatusFlags.PENDING)) {
                dtrm.DeleteOrder(dtrm.AttachedOrder.IID);
                dtrm.AttachedOrder = null;
                Response.Redirect("OrderPadSimple.aspx", true);
            }

        }



        protected void btnLogout_Click(object sender, EventArgs e) {
            dtrm.AttachedOrder = null;
            dtrm.LoggedUser = null;
            Response.Redirect("Default.aspx", true);
        }
    }
}