using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Data;
using DTRMNS;

namespace MobilePad
{
    public partial class OrderPad : System.Web.UI.Page
    {
        protected DTRMBusiness dtrm;

        protected string SelectedEntityIID;
        protected Entity SelectedEntity;

        protected string SelectedSILButtonIID;
        protected EntityButton SelectedSILButton;

        protected string SelectedCILButtonIID;
        protected EntityButton SelectedCILButton;

        protected string SelectedOrderItemIID;
        protected OrderItem SelectedOrderItem;


        protected WebSettings webs;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ENTITY SECTION
            dtrm = (DTRMBusiness)Session["DTRM"];
            webs = (WebSettings)Session["WEBS"];


            // If page is not being loaded in response to postback
            if (!Page.IsPostBack)
            {
                Page.Title = dtrm.LoggedUser.UserName;
                lblStore.Text = dtrm.LoggedUser.UserName;
                //LoadHoldOrdersForUser();
                LoadEntityList();

                DisplayOrder();


            }
            

        }

        #region HOLD ORDERS
        protected void LoadHoldOrdersForUser()
        {
            if (dtrm.AttachedOrder != null)
                dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where UserName = '" + dtrm.LoggedUser.UserName + "' and IID <> '" + dtrm.AttachedOrder.IID + "' and Payment = 0");
            else
                dlHoldOrders.DataSource = dtrm.GetDataTable("Select IID, CalculatedValue from OrdersView Where UserName = '" + dtrm.LoggedUser.UserName + "' and Payment = 0");
            dlHoldOrders.DataBind();
        }
        
        protected void dlHoldOrders_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (dtrm.AttachedOrder != null && dtrm.AttachedOrder.items.Count > 0)
                return;
            
            string OrderIID = e.CommandArgument.ToString();
            UnLoadSILButtons();
            dtrm.AttachedOrder = dtrm.GetOrder(OrderIID);
            DisplayOrder();
        }

        #endregion


        #region "ENTITY LIST"
        protected void LoadEntityList()
        {

            dlEntityList.DataSource = dtrm.GetDataTable("Select IID, EntityName from Entity where entitytype = 0 and WebVisible = 1 and ParentCatalogIID = '" + dtrm.config.CurrentCatalogIID + "' order by DisplayOrder");
            dlEntityList.DataBind();
        }
        protected void dlEntityList_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
        {
            dlEntityList.SelectedIndex = e.Item.ItemIndex;

            //SelectedEntityIID = ((Label)e.Item.FindControl("EIID")).Text;
            SelectedEntityIID = e.CommandArgument.ToString();
            SelectedEntity = dtrm.GetEntityDB(SelectedEntityIID);
            Session["SelectedEntity"] = SelectedEntity;


            ////UnloadCIL();

            if (SelectedEntity.sizebar == null)
            {

                LoadSILButtons();
            }
            else
            {
                UnLoadSILButtons();
            }
        }
        #endregion



        #region "SIL  BUTTONS"
        protected void LoadSILButtons()
        {
            UnLoadSILButtons();
            DataTable dt = CreateDataTableSpecial();
            for (int i = 0; i < SelectedEntity.Buttons.Count; i++)
            {
                EntityButton eb = (EntityButton)SelectedEntity.Buttons[i];
                if (eb.ButtonType != EntityButtonTypes.NewLine)
                {
                    //||
                    //UF.IsBitSet(eb.AvailableFor, (int)AvailabilityTypes.Delivery) )) {					
                    string[] eblist = { eb.IID, eb.EntityButtonName };
                   
                    AddRow(dt, eblist);
                }
            }
            dlSIL.DataSource = dt;
            dlSIL.DataBind();
        }

        //private string ToKnownColor(int colorInt)
        //{
        //    Color c = Color.FromArgb(colorInt);
        //    return c.ToKnownColor().ToString();
        //}
        //private String ToHex(int colorInt) 
        //{
        //    Color c = Color.FromArgb(colorInt);
        //    return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        //}
        //private String HexConverter(System.Drawing.Color c)
        //{
        //    return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        //}
        protected void UnLoadSILButtons()
        {
            DataTable dt = CreateDataTableSpecial();
            dlSIL.DataSource = dt;
            dlSIL.DataBind();
        }

        protected void dlEntityButtons_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
        {
            dlSIL.SelectedIndex = e.Item.ItemIndex;
            ////UnloadCIL();

            //DTRMWebNS.Division d = null;
            EnsureSelectedEntity();
            //EnsureSelectedSILButton();

            SelectedSILButtonIID = e.CommandArgument.ToString();
            SelectedSILButton = SelectedEntity.GetEntityButton(SelectedSILButtonIID);

            //Set selected Order Item
            EnsureSelectedOrderItem();

            OrderItem oi = null;

            int Quantity = 1;


            if (dtrm.AttachedOrder == null)
            {
                Order order = new Order();
                order.OrderType = OrderTypes.DirectSale;
                order.UserName = dtrm.LoggedUser.UserName;
                dtrm.AttachedOrder = order;
            }

            if (SelectedSILButton.ButtonType == EntityButtonTypes.SimpleItem && /*SelectedSILButton.ParentEntityButtonIID == "" &&*/ SelectedSILButton.items.Count == 0)
            {
                OrderItem IncrementableItem = null;
                for (int c = 0; c < dtrm.AttachedOrder.items.Count; c++)
                {
                    IncrementableItem = (OrderItem)dtrm.AttachedOrder.items[c];
                    if (IncrementableItem.EntityButtonIID == SelectedSILButtonIID && IncrementableItem.GlobalTypeIID == SelectedEntity.GlobalTypeIID)
                        break;
                    else
                        IncrementableItem = null;
                }

                if (IncrementableItem == null)
                    dtrm.AttachedOrder.AddOrderItem("", SelectedEntityIID,
                       "" /*LoadedOrderItem.OrderGroupIID*/, "0", "0", "", Quantity, 1f,
                       UF.GetRelatedPrice(SelectedOrderItem, SelectedEntity, SelectedSILButton, dtrm.AttachedOrder), SelectedSILButtonIID, "" + SelectedSILButton.EntityButtonName,
                               true, 0, SelectedEntity.GlobalTypeIID, "", OrderItemTypes.NormalOrderItem, SelectedSILButton.dorder,
                               SelectedEntity.EntityName, SelectedEntity.dorder, "", dtrm.GetEBTaxPercent(SelectedSILButton), "", "", "", "");
                else
                    IncrementableItem.Increment();
            }
            else
            {
                //this is a top complex button
                if (SelectedSILButton.ButtonType == EntityButtonTypes.ComplexItem && SelectedSILButton.PEBIID == "")
                {   // SelectedOrderItem == null) { // &&  en.IID == null)
                    oi = new OrderItem("", dtrm.AttachedOrder.IID, SelectedEntityIID,
                    Guid.NewGuid().ToString(), "0", "0", "", Quantity, 1f, UF.GetRelatedPrice(SelectedOrderItem, SelectedEntity, SelectedSILButton, dtrm.AttachedOrder), SelectedSILButtonIID,
                    "" + SelectedSILButton.EntityButtonName, true, 0, SelectedEntity.GlobalTypeIID, "", OrderItemTypes.NormalOrderItem, SelectedSILButton.dorder,
                    SelectedEntity.EntityName, SelectedEntity.dorder, "", dtrm.GetEBTaxPercent(SelectedSILButton), "", "", "", "");

                    dtrm.AttachedOrder.AddOrderItem(oi);
                }
                else
                {
                    oi = new OrderItem("", dtrm.AttachedOrder.IID, SelectedEntityIID,
                       SelectedOrderItem.OrderGroupIID, "0", "0", "", Quantity, 1f, UF.GetRelatedPrice(SelectedOrderItem, SelectedEntity, SelectedSILButton, dtrm.AttachedOrder), SelectedSILButtonIID,
                       "" + SelectedSILButton.EntityButtonName, true, 0, SelectedEntity.GlobalTypeIID, "", OrderItemTypes.NormalOrderItem, SelectedSILButton.dorder,
                       SelectedEntity.EntityName, SelectedEntity.dorder, "", dtrm.GetEBTaxPercent(SelectedSILButton), "", "", "", "");

                    SelectedOrderItem.AddSubItem(oi);
                }
            }


            //if (SelectedSILButton.ButtonType == EntityButtonTypes.ComplexItem) {
            //    SelectedOrderItem = oi;
            //    LoadCIL(SelectedSILButton);
            //}

            DisplayOrder();
            if (SelectedEntity.sizebar == null)
            {
                if (oi != null)
                    SelectTopOrderItem(oi.IID);
            }
        }
        #endregion

        #region "CIL BUTTONS"
        ////protected void LoadCIL(EntityButton peb) {
        ////    UnloadCIL();
        ////    DataTable dt = CreateDataTableSpecial();
        ////    for (int i = 0; i < peb.items.Count; i++) {
        ////        EntityButton eb = (EntityButton)peb.items[i];
        ////        if (eb.ButtonType != EntityButtonTypes.NewLine) {
        ////            string[] eblist = { eb.IID, eb.EntityButtonName };
        ////            AddRow(dt, eblist);
        ////        }
        ////    }
        ////    dlCIL.DataSource = dt;
        ////    dlCIL.DataBind();
        ////}
        ////protected void UnloadCIL() {
        ////    DataTable dt = CreateDataTableSpecial();
        ////    dlCIL.DataSource = dt;
        ////    dlCIL.DataBind();
        ////}
        ////protected void dlCIL_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e) {
        ////    dlCIL.SelectedIndex = e.Item.ItemIndex;

        ////    EnsureSelectedEntity();
        ////    EnsureSelectedSILButton();
        ////    EnsureSelectedCILButton();

        ////    EnsureSelectedOrderItem();

        ////    OrderItem oi = null;

        ////    //peb = en.GetEntityButton(lvi.SubItems[3].Text);
        ////    //eb = (EntityButton)peb.GetItem(lvi.SubItems[1].Text);

        ////    if (SelectedCILButton.ButtonType == EntityButtonTypes.ComplexItem) {
        ////        //MessageBox.Show("This is a complex item");
        ////        return;
        ////    }

        ////    //if there is a size bar then OrderGroupIID is created already
        ////    if (SelectedEntity.sizebar != null) {

        ////    } else {

        ////            ///CILLIFIED
        ////            oi = new OrderItem(SelectedOrderItem.IID, dtrm.AttachedOrder.IID, SelectedEntity.IID,
        ////               SelectedOrderItem.OrderGroupIID, "0", "0", "", 1, 1f,
        ////               UF.GetRelatedPrice(SelectedOrderItem, SelectedEntity, SelectedCILButton, dtrm.AttachedOrder), SelectedCILButton.IID,
        ////               SelectedCILButton.EntityButtonName, false, 0, SelectedEntity.GlobalTypeIID,
        ////               "", OrderItemTypes.NormalOrderItem, 0,
        ////               SelectedEntity.GlobalTypeIID, SelectedEntity.dorder, "", dtrm.GetEBTaxPercent(SelectedCILButton), "", "", "", "");

        ////            SelectedOrderItem.AddSubItem(oi);

        ////    }
        ////    if (SelectedCILButton.ButtonType == EntityButtonTypes.ComplexItem) {
        ////        this.SelectedOrderItem = oi;
        ////        LoadCIL(SelectedCILButton);
        ////    }



        ////    DisplayOrder();
        ////}
        #endregion

        #region "ORDER DISPLAY"
        protected DataTable CreateDataTableForDisplay()
        {
            DataTable dt = new DataTable();
            DataColumn col;

            for (int i = 0; i < 14; i++)
            {
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ReadOnly = false;
                dt.Columns.Add(col);
            }

            dt.Columns[0].ColumnName = "IID";
            dt.Columns[1].ColumnName = "ParentOrderIID";
            dt.Columns[2].ColumnName = "EntityIID";
            dt.Columns[3].ColumnName = "TopItem";
            dt.Columns[4].ColumnName = "Quantity";
            dt.Columns[5].ColumnName = "OrderItemText";
            dt.Columns[6].ColumnName = "CalculationRatio";
            dt.Columns[7].ColumnName = "Price";
            dt.Columns[8].ColumnName = "CalculatedValue";
            dt.Columns[9].ColumnName = "OrderGroupIID";
            dt.Columns[10].ColumnName = "SizeBarItemIID";
            dt.Columns[11].ColumnName = "DivisionalOrderGroupIID";
            dt.Columns[12].ColumnName = "DivisionText";
            dt.Columns[13].ColumnName = "EntityButtonIID";

            return dt;
        }

        protected void AddRowForDisplay(DataTable dt, string[] s)
        {
            DataRow row = dt.NewRow();

            row["IID"] = s[0];
            row["ParentOrderIID"] = s[1];
            row["EntityIID"] = s[2];
            row["TopItem"] = s[3];
            row["Quantity"] = s[4];
            row["OrderItemText"] = s[5];
            row["CalculationRatio"] = s[6];
            row["Price"] = s[7];
            row["CalculatedValue"] = s[8];
            row["OrderGroupIID"] = s[9];
            row["SizeBarItemIID"] = s[10];
            row["DivisionalOrderGroupIID"] = s[11];
            row["DivisionText"] = s[12];
            row["EntityButtonIID"] = s[13];

            dt.Rows.Add(row);
        }

        public void DisplayOrder()
        {
            DataTable dt = CreateDataTableForDisplay();

            if (dtrm.AttachedOrder != null)
            {
                string[] arr = null;
                OrderItem oi;
                float SingleTotal = 0f;
                float SubTotal = 0f;
                float OrderTotal = 0f;

                int TopItemRowNumber = 0;

                for (int i = 0; i < dtrm.AttachedOrder.items.Count; i++)
                {
                    //Display Top Item
                    oi = (OrderItem)dtrm.AttachedOrder.items[i];
                    SingleTotal = oi.Price;

                    arr = new String[14]{oi.IID, oi.ParentOrderIID, oi.EntityIID, oi.TopItem.ToString(), oi.Quantity.ToString(),
											oi.GetOrderItemText() ,
											/*oi.GetOrderItemText() + " (" +  ((FoodType)this.FoodTypeList.GetItem(oi.FoodTypeIID)).FoodTypeShortName + ")", */
											oi.CalculationRatio.ToString(), oi.Price.ToString("c"), 
											oi.items.Count > 0?oi.Price.ToString("c"): oi.GetCalculatedValue().ToString("c"), 
											oi.OrderGroupIID, oi.SizeBarItemIID, 
											oi.DivisionalOrderGroupIID, oi.DivisionText, oi.EntityButtonIID};

                    AddRowForDisplay(dt, arr);
                    TopItemRowNumber = dt.Rows.Count - 1;

                    //Display this top item's sub items
                    for (int x = 0; x < oi.items.Count; x++)
                    {
                        OrderItem si = (OrderItem)oi.items[x];
                        SingleTotal += si.GetCalculatedValue();

                        //Dont display quantity in sub items
                        arr = new String[14]{si.IID, oi.ParentOrderIID, si.EntityIID, si.TopItem.ToString(), "",  //si.Quantity.ToString(),
												"&nbsp;&nbsp;&nbsp;" + si.GetOrderItemText(), si.CalculationRatio.ToString(), si.Price.ToString("c"), 
												/*si.GetCalculatedValue().ToString("c")*/ "", si.OrderGroupIID, si.SizeBarItemIID, 
												si.DivisionalOrderGroupIID, si.DivisionText, si.EntityButtonIID};

                        AddRowForDisplay(dt, arr);
                    }

                    SubTotal = SingleTotal * oi.Quantity;
                    dt.Rows[TopItemRowNumber]["CalculatedValue"] = SubTotal.ToString("c");
                    OrderTotal += SubTotal;
                }
                if (dt.Rows.Count > 0)
                {
                    ////					Extra extra;
                    ////					float DiscountValue;
                    ////					string extraIID ="";
                    ////					for (int i=0; i < AttachedOrder.ExtraItems.Count; i++) {
                    ////						extra = (Extra)AttachedOrder.ExtraItems[i];
                    ////						if (extra.Required)
                    ////							extraIID = "";
                    ////						else
                    ////							extraIID = extra.IID;
                    ////
                    ////						switch (extra.ExtraType) {
                    ////							case ExtraTypes.AmountAddition:
                    ////								arr = new string[14]{extraIID,"","","","", extra.ExtraName ,"","", extra.Amount.ToString("c"),"","","","",""};
                    ////								OrderTotal += extra.Amount;							
                    ////								break;
                    ////							case ExtraTypes.AmountDeduction:
                    ////								arr = new string[14]{extraIID,"","","","", extra.ExtraName ,"","", "- " + extra.Amount.ToString("c"),"","","","",""};
                    ////								OrderTotal -= extra.Amount;														
                    ////								break;
                    ////							case ExtraTypes.PercentAddition:
                    ////								DiscountValue = UF.Round2((OrderTotal /100) * extra.Percent, 0.01m,false);
                    ////								arr = new string[14]{extraIID,"","","","", extra.ExtraName + "  " + extra.Percent.ToString() + "%","","", DiscountValue.ToString("c"),"","","","",""};
                    ////								OrderTotal += DiscountValue;
                    ////								break;
                    ////							case ExtraTypes.PercentDeduction:
                    ////								DiscountValue = UF.Round2((OrderTotal /100) * extra.Percent, 0.01m,false) * -1;
                    ////								arr = new string[14]{extraIID,"","","","", extra.ExtraName + "  " + extra.Percent.ToString() + "%","","", DiscountValue.ToString("c"),"","","","",""};
                    ////								OrderTotal += DiscountValue;
                    ////								break;
                    ////							case ExtraTypes.Manager:							
                    ////								arr = new string[14]{extraIID,"","","","", extra.ExtraName ,"","",  extra.Amount.ToString("c"),"","","","",""};
                    ////								OrderTotal += extra.Amount;
                    ////								break;
                    ////							default:
                    ////								break;
                    ////						}
                    ////						AddRowForDisplay(dt,arr);
                    ////					}

                    arr = new string[14] { "", "", "", "", "", "  ORDER TOTAL", "", "", OrderTotal.ToString("c"), "", "", "", "", "" };
                    AddRowForDisplay(dt, arr);

                    btnPlus.Visible = btnMinus.Visible = btnDelete.Visible = true;
                    btnCashPayment.Visible = btnHold.Visible = true;

                }
                else {
                     btnPlus.Visible = btnMinus.Visible = btnDelete.Visible = false;
                    btnCashPayment.Visible = btnHold.Visible = false;
                }

                dgDisplay.DataSource = dt;
                dgDisplay.DataBind();

               
                    
            }
            else
            {
                dgDisplay.DataSource = null;
                dgDisplay.DataBind();
                btnPlus.Visible = btnMinus.Visible = btnDelete.Visible = false;
                btnCashPayment.Visible = btnHold.Visible = false;
            }
            LoadHoldOrdersForUser();
        }

        protected void dgDisplay_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            try
            {
                if (e.Item.ItemIndex == dgDisplay.Items.Count - 1)
                    return;
            }
            catch
            {
            }
            int oldSelectedIndex = dgDisplay.SelectedIndex;
            dgDisplay.SelectedIndex = e.Item.ItemIndex;

            SelectedOrderItem = dtrm.AttachedOrder.GetOrderItem(dgDisplay.Items[dgDisplay.SelectedIndex].Cells[0].Text);

            if (SelectedOrderItem == null || (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem))
                dgDisplay.SelectedIndex = oldSelectedIndex;
            else
            {
                SelectedEntityIID = SelectedOrderItem.EntityIID;
                SelectedEntity = dtrm.GetEntityDB(SelectedEntityIID);
                Session["SelectedEntity"] = SelectedEntity;
                LoadSILButtons();
                ////if (SelectedEntity.sizebar == null)
                ////    LoadCIL(dtrm.GetEntityButtonDB(SelectedOrderItem.EntityButtonIID));
                ////else
                ////    UnloadCIL();

                if (e.CommandName == "plus1")
                {
                    btnPlus1_Click(null, null);
                }
                else if (e.CommandName == "minus1")
                {
                    btnMinus1_Click(null, null);
                }
                else if (e.CommandName == "delete")
                {
                    btnDeleteItem_Click(null, null);
                }
                else if (e.CommandName == "clone")
                {
                    btnClone_Click(null, null);
                }
            }
        }


        #endregion

        #region "BUTTON HANDLERS"
        protected void btnPlus1_Click(object sender, System.EventArgs e)
        {
            EnsureSelectedOrderItem();
            if (SelectedOrderItem != null)
            {
                if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
                    return;
                SelectedOrderItem.Quantity++;
                DisplayOrder();
            }
        }

        protected void btnMinus1_Click(object sender, System.EventArgs e)
        {
            EnsureSelectedOrderItem();
            if (SelectedOrderItem != null)
            {
                if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
                    return;
                if (SelectedOrderItem.Quantity > 1)
                    SelectedOrderItem.Quantity--;
                else
                {
                    dtrm.AttachedOrder.DeleteOrderItem(SelectedOrderItem.IID);
                    dgDisplay.SelectedIndex = -1;
                    SelectedOrderItem = null;
                }
                DisplayOrder();
            }
        }

        protected void btnDeleteItem_Click(object sender, System.EventArgs e)
        {
            EnsureSelectedOrderItem();
            if (SelectedOrderItem != null)
            {
                if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
                    return;
                if (SelectedOrderItem.TopItem)
                {
                    dtrm.AttachedOrder.DeleteOrderItem(SelectedOrderItem.IID);
                    dgDisplay.SelectedIndex = -1;
                    SelectedOrderItem = null;
                }
                else
                    dtrm.AttachedOrder.GetTopOrderItem(SelectedOrderItem.OrderGroupIID).DeleteSubItem(SelectedOrderItem.IID);
                DisplayOrder();
            }
        }

        protected void btnClone_Click(object sender, System.EventArgs e)
        {
            EnsureSelectedOrderItem();
            if (SelectedOrderItem != null)
            {
                if (SelectedOrderItem.ItemType != OrderItemTypes.NormalOrderItem)
                    return;
                if (SelectedOrderItem.TopItem)
                    dtrm.AttachedOrder.items.Add(SelectedOrderItem.Clone());
                DisplayOrder();
            }
        }


        protected void btnCashPayment_Click(object sender, EventArgs e)
        {
            if (dtrm.AttachedOrder != null)
            {
               // float total = dtrm.AttachedOrder.GetTotal();

                if (dtrm.AttachedOrder.items.Count > 0)
                {
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
        

        protected void EnsureCompulsoryExtras()
        {
            //////DataTable dt = dtrm.GetEntitiesByType(dtrm.config.CurrentCatalogIID, EntityTypes.SpecialEntity);
            //////if (dt.Rows.Count > 0) {
            //////    for (int x = dtrm.AttachedOrder.items.Count; x > 0; x--)
            //////        if (((OrderItem)dtrm.AttachedOrder.items[x - 1]).ItemType != OrderItemTypes.NormalOrderItem)
            //////            dtrm.AttachedOrder.items.RemoveAt(x - 1);

            //////    Entity en = dtrm.GetEntityDB(dt.Rows[0]["IID"].ToString());
            //////    DataTable dteb = dtrm.GetEntityButtonsForEntityDB(en.IID);
            //////    for (int i = 0; i < dteb.Rows.Count; i++) {
            //////        EntityButton eb = dtrm.GetEntityButtonDB(dteb.Rows[i]["IID"].ToString());
            //////        if (UF.IsBitSet((int)eb.AvailableFor, (int)dtrm.AttachedOrder.OrderType) && eb.Compulsary == 1) {
            //////            if (!dtrm.AttachedOrder.IsItemExist(eb.IID)) {
            //////                //Extra and discount management
            //////                switch (eb.ButtonType) {
            //////                    case EntityButtonTypes.AmountAddition:
            //////                        dtrm.AttachedOrder.AddOrderItem("", en.IID,
            //////                           "", "", "", "", 1, 1, UF.GetRelatedPrice(SelectedOrderItem, en, eb, dtrm.AttachedOrder), eb.IID, eb.EntityButtonName, true,
            //////                                 0, en.GlobalTypeIID, "", OrderItemTypes.AmountAddition, eb.dorder,
            //////                                 en.EntityName, en.dorder, "", dtrm.GetEBTaxPercent(eb), "", "", "", "");
            //////                        break;
            //////                    case EntityButtonTypes.AmountDeduction:
            //////                        dtrm.AttachedOrder.AddOrderItem("", en.IID,
            //////                           "", "", "", "", 1, 1, UF.GetRelatedPrice(SelectedOrderItem, en, eb, dtrm.AttachedOrder), eb.IID, eb.EntityButtonName, true,
            //////                                 0, en.GlobalTypeIID, "", OrderItemTypes.AmountDeduction, eb.dorder,
            //////                                 en.EntityName, en.dorder, "", dtrm.GetEBTaxPercent(eb), "", "", "", "");
            //////                        break;
            //////                    case EntityButtonTypes.PercentAddition:
            //////                        if (!dtrm.AttachedOrder.IsItemExist(eb.IID)) {
            //////                            dtrm.AttachedOrder.AddOrderItem("", en.IID,
            //////                               "", "", "", "", 1, 1, dtrm.AttachedOrder.GetTotal() * (UF.GetRelatedPrice(SelectedOrderItem, en, eb, dtrm.AttachedOrder) / 100), eb.IID, eb.EntityButtonName, true,
            //////                                      0, en.GlobalTypeIID, "", OrderItemTypes.PercentAddition, eb.dorder,
            //////                                      en.EntityName, en.dorder, "", dtrm.GetEBTaxPercent(eb), "", "", "", "");
            //////                        }
            //////                        break;
            //////                    case EntityButtonTypes.PercentDeduction:
            //////                        if (!dtrm.AttachedOrder.IsItemExist(eb.IID)) {
            //////                            dtrm.AttachedOrder.AddOrderItem("", en.IID,
            //////                               "", "", "", "", 1, 1, -1 * (dtrm.AttachedOrder.GetTotal() * (UF.GetRelatedPrice(SelectedOrderItem, en, eb, dtrm.AttachedOrder) / 100)), eb.IID, eb.EntityButtonName, true,
            //////                                      0, en.GlobalTypeIID, "", OrderItemTypes.PercentDeduction, eb.dorder,
            //////                                      en.EntityName, en.dorder, "", dtrm.GetEBTaxPercent(eb), "", "", "", "");
            //////                        }
            //////                        break;
            //////                }
            //////            }
            //////        }
            //////    }
            //////}
        }

        protected DataTable CreateDataTableSpecial()
        {
            DataTable dt = new DataTable();
            DataColumn col;

            for (int i = 0; i < 2; i++)
            {
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ReadOnly = false;
                dt.Columns.Add(col);
            }
            dt.Columns[0].ColumnName = "IID";
            dt.Columns[1].ColumnName = "ButtonText";
            return dt;
        }
        protected void AddRow(DataTable dt, string[] s)
        {
            DataRow row = dt.NewRow();
            row["IID"] = (string)s[0];
            row["ButtonText"] = (string)s[1];
            dt.Rows.Add(row);
        }
        protected void EnsureSelectedEntity()
        {
            SelectedEntity = (Entity)Session["SelectedEntity"];
            SelectedEntityIID = SelectedEntity.IID;
        }


        
        protected void EnsureSelectedCILButton()
        {
            //////SelectedCILButtonIID = ((Label)dlCIL.SelectedItem.FindControl("CILBIID")).Text;
            //////SelectedCILButton = (EntityButton)SelectedSILButton.GetItem(SelectedCILButtonIID);
        }
        protected void EnsureSelectedOrderItem()
        {
            if (dgDisplay.SelectedIndex >= 0)
            {
                SelectedOrderItem = dtrm.AttachedOrder.GetOrderItem(dgDisplay.SelectedItem.Cells[0].Text);
            }
            else
            {

            }
        }
        protected void SelectTopOrderItem(string IID)
        {
            for (int i = 0; i < dgDisplay.Items.Count; i++)
            {
                if (dgDisplay.Items[i].Cells[0].Text == IID)
                    dgDisplay.SelectedIndex = i;
            }
        }
        public bool IsIID(object n)
        {
            return (n.ToString().Trim().Length > 2);
        }
        public bool IsZero(object n)
        {
            return (n.ToString() == "0");
        }
        public bool ToBool(object n)
        {
            return (n.ToString() == "" ? false : bool.Parse(n.ToString()));
        }
        #endregion

        protected void btnHold_Click(object sender, EventArgs e)
        {
            if (dtrm.AttachedOrder != null)
            {
                //float total = dtrm.AttachedOrder.GetTotal();

                if (dtrm.AttachedOrder.items.Count > 0)
                {
                    //dtrm.AttachedOrder.Payment = PaymentMethods.Cash;
                    //dtrm.AttachedOrder.Status = StatusFlags.COMPLETED;
                    dtrm.SaveOrder(dtrm.AttachedOrder);
                    dtrm.AttachedOrder = null;
                    UnLoadSILButtons();
                    DisplayOrder();
                }

            }
        }

       



    }
}