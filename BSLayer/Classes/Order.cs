using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using PosLibrary;
using Newtonsoft.Json;

namespace DTRMNS {
    [System.Xml.Serialization.XmlInclude(typeof(OrderItem))]
    [System.Serializable]
    public class Order
    {
        private string _IID= ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }

        private List<OrderItem> _items = new List<OrderItem>();
        public List<OrderItem> items { get { return _items; } set { _items = value; } }

        private string _Title;
        public string Title { get { return _Title; } set { _Title = value; } } 
         
        public string TableIID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Covers { get; set; }
        public OrderTypes OrderType { get; set; }
        public StatusFlags Status { get; set; }
        public bool blnPrinted { get; set; }
        public string CustomerIID { get; set; }
        public PaymentMethods Payment { get; set; }
        public string PaymentFlag { get; set; }
        public int RequestCount { get; set; }
        public string LockedClientIP { get; set; }
        public string SessionIID { get; set; }
        public string Instruction { get; set; }
        public float MoneyPaid { get; set; }

        public string TableName { get; set; }
        public string CName { get; set; }
        public string PostCode { get; set; }
        public string Buzzer { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Reference { get; set; }

        public bool blnItemsChanged { get; set; }

        public float ServiceChargeRate { get; set; }
        public float ServiceChargeTaxRate { get; set; }

        public Order()
        {
            TableIID = "";
            OrderDate = DateTime.Now;
            Covers = 1;
            OrderType = OrderTypes.InHouse;
            Status = StatusFlags.NEW;
            blnPrinted = false;
            CustomerIID = "";
            Payment = PaymentMethods.Unknown;
            PaymentFlag = "";
            RequestCount = 0;
            LockedClientIP = "";
            SessionIID = "";
            Instruction = "";
            MoneyPaid = 0f;
            //IsCustomerRequired = false;

            TableName = "";
            CName = "";
            PostCode = "";
            Buzzer = "";
            Address = "";
            Town = "";
            Tel = "";
            Mobile = "";
            Email = "";
            UserName = "";
            Reference = "";
        }


        public Order(OrderTypes OrderType)
        {
            TableIID = "";
            OrderDate = DateTime.Now;
            Covers = 1;
            Status = StatusFlags.NEW;
            blnPrinted = false;
            Payment = PaymentMethods.Unknown;
            PaymentFlag = "";
            RequestCount = 0;
            this.OrderType = OrderType;
            LockedClientIP = "";
            SessionIID = "";
            Instruction = "";
            MoneyPaid = 0f;
            CustomerIID = "";
            TableName = "";
            CName = "";
            PostCode = "";
            Buzzer = "";
            Address = "";
            Town = "";
            Tel = "";
            Mobile = "";
            Email = "";
            UserName = "";
            Reference = "";

        }
        public Order(OrderTypes OrderType, float ServiceChargeRate, float ServiceChargeTaxRate) : this (OrderType) {
            this.ServiceChargeRate = ServiceChargeRate;
            this.ServiceChargeTaxRate = ServiceChargeTaxRate;
        }
        public Order(DataTable dt)
        {
            string test = "";
            if (dt != null)
            {
                try
                {
                    this.IID = dt.Rows[0]["IID"].ToString();
                    this.TableIID = dt.Rows[0]["TableIID"].ToString();
                    this.OrderDate = DateTime.Parse(dt.Rows[0]["OrderDate"].ToString());
                    this.Covers = int.Parse(dt.Rows[0]["Covers"].ToString());
                    this.OrderType = (OrderTypes)int.Parse(dt.Rows[0]["OrderType"].ToString());
                    this.Payment = (PaymentMethods)int.Parse(dt.Rows[0]["Payment"].ToString());
                    this.CustomerIID = dt.Rows[0]["CustomerIID"].ToString();
                    this.SessionIID = dt.Rows[0]["SessionIID"].ToString();
                    this.Status = (StatusFlags)int.Parse(dt.Rows[0]["Status"].ToString());
                    this.Instruction = dt.Rows[0]["Instruction"].ToString();
                    this.MoneyPaid = float.Parse(dt.Rows[0]["MoneyPaid"].ToString());

                    TableName = dt.Rows[0]["TableName"].ToString();
                    CName = dt.Rows[0]["CName"].ToString();
                    PostCode = dt.Rows[0]["PostCode"].ToString();
                    Buzzer = dt.Rows[0]["Buzzer"].ToString();
                    Address = dt.Rows[0]["Address"].ToString();
                    Town = dt.Rows[0]["Town"].ToString();
                    Tel = dt.Rows[0]["Tel"].ToString();
                    Mobile = dt.Rows[0]["Mobile"].ToString();
                    Email = dt.Rows[0]["Email"].ToString();

                    PaymentFlag = dt.Rows[0]["PaymentFlag"].ToString();

                    UserName = dt.Rows[0]["UserName"].ToString();
                    Reference = dt.Rows[0]["Reference"].ToString();

                    ServiceChargeRate = float.Parse(dt.Rows[0]["ServiceChargeRate"].ToString());
                    ServiceChargeTaxRate = float.Parse(dt.Rows[0]["ServiceChargeTaxRate"].ToString());
                    //Others
                    blnPrinted = false;

                    RequestCount = 0;
                    LockedClientIP = "";
                }
                catch (Exception ex)
                {
                    test = ex.Message;
                }
            }
        }
        public Order(DataRow dr) {
            string test = "";
            if (dr != null) {
                try {
                    this.IID = dr["IID"].ToString();
                    this.TableIID = dr["TableIID"].ToString();
                    this.OrderDate = DateTime.Parse(dr["OrderDate"].ToString());
                    this.Covers = int.Parse(dr["Covers"].ToString());
                    this.OrderType = (OrderTypes)int.Parse(dr["OrderType"].ToString());
                    this.Payment = (PaymentMethods)int.Parse(dr["Payment"].ToString());
                    this.CustomerIID = dr["CustomerIID"].ToString();
                    this.SessionIID = dr["SessionIID"].ToString();
                    this.Status = (StatusFlags)int.Parse(dr["Status"].ToString());
                    this.Instruction = dr["Instruction"].ToString();
                    this.MoneyPaid = float.Parse(dr["MoneyPaid"].ToString());

                    TableName = dr["TableName"].ToString();
                    CName = dr["CName"].ToString();
                    PostCode = dr["PostCode"].ToString();
                    Buzzer = dr["Buzzer"].ToString();
                    Address = dr["Address"].ToString();
                    Town = dr["Town"].ToString();
                    Tel = dr["Tel"].ToString();
                    Mobile = dr["Mobile"].ToString();
                    Email = dr["Email"].ToString();

                    PaymentFlag = dr["PaymentFlag"].ToString();

                    UserName = dr["UserName"].ToString();
                    Reference = dr["Reference"].ToString();

                    ServiceChargeRate = float.Parse(dr["ServiceChargeRate"].ToString());
                    ServiceChargeTaxRate = float.Parse(dr["ServiceChargeTaxRate"].ToString());
                    //Others
                    blnPrinted = false;

                    RequestCount = 0;
                    LockedClientIP = "";
                } catch (Exception ex) {
                    test = ex.Message;
                }
            }
        }

        public float GetFullTotal() {
            return GetTaxIncludedItemTotal() + GetServiceCharge();
        }

        /// <summary>
        /// Tax Inclusive Item Total
        /// </summary>
        /// <returns></returns>
        public float GetTaxIncludedItemTotal() 
        {
            float Total = 0f;
            for (int i = 0; i < items.Count; i++)
            {
                Total += ((OrderItem)items[i]).Total;
            }
            return Total;
        }

        /// <summary>
        /// Total of All Items with Taxes
        /// </summary>
        /// <returns></returns>
        public float GetItemTaxTotal() {
            float VatTotal = 0f;
            foreach (OrderItem item in items) {
                VatTotal += item.TaxValue;                
            }
            return VatTotal;
        }

        /// <summary>
        /// Total of All items without taxes
        /// </summary>
        /// <returns></returns>
        public float GetTaxExcludedItemTotal() {
            float Total = 0f;
            foreach (OrderItem item in items) {
                Total += item.Total - item.TaxValue;
            }
            return Total;
        }
        
        public float GetServiceCharge() {
            return GetTaxExcludedItemTotal() * ServiceChargeRate / 100;
        }

        public float GetServiceChargeTax() {
            return GetServiceCharge() * ServiceChargeTaxRate / 100;
        }
        

        public void SetTable(string TableIID)
        {
            this.TableIID = TableIID;
        }
        public bool HasTableAttached()
        {
            if (this.OrderType == OrderTypes.InHouse)
                return TableIID.Trim().Length > 0;
            else
                return false;
        }

        /// <summary>
        /// Will add all the items of the given order to this order
        /// </summary>
        /// <param name="norder"></param>
        /// <returns></returns>
        public bool MergeOrder(Order norder)
        {
            for (int i = 0; i < norder.items.Count; i++)
            {
                OrderItem oi = (OrderItem)norder.items[i];
                oi.ParentOrderIID = this.IID;
                this.AddIncrementOrderItem(oi);
                //this.AddOrderItem(oi);
            }
            return true;
        }

        public bool ShrinkOrder() {
            List<OrderItem> shrinkableItems = new List<OrderItem>();
            for (int i = 0; i < items.Count; i++) {
                if (items[i].OrderGroupIID != IID)
                    shrinkableItems.Add(items[i]);
            }
            OrderItem incItem = null;
            for (int i = 0; i < shrinkableItems.Count; i++) {
                incItem = GetIncrementableItem(shrinkableItems[i].EntityButtonIID, shrinkableItems[i].DistributionIID, IID);
                if (incItem != null) {
                    incItem.Quantity += shrinkableItems[i].Quantity;
                    shrinkableItems[i].Quantity = 0;
                    incItem.CompletedQuantity += shrinkableItems[i].CompletedQuantity;
                }
                else
                    shrinkableItems[i].OrderGroupIID = IID;
            }

            
            for (int i = items.Count -1; i >= 0; i--) {
                if (items[i].Quantity == 0)
                    items.RemoveAt(i);
                
            }

            string ordergroupshrunkguid = ShortGuid.NewDateBasedGuid(OrderDate);
            for (int i = 0; i < items.Count; i++) {
                items[i].OrderGroupIID = ordergroupshrunkguid;
            }

            return true;
        }

        public Order ShrinkOrder(Order order) {
            List<OrderItem> shrinkableItems = new List<OrderItem>();
            for (int i = 0; i < order.items.Count; i++) {
                if (order.items[i].OrderGroupIID != IID)
                    shrinkableItems.Add(order.items[i]);
            }
            OrderItem incItem = null;
            for (int i = 0; i < shrinkableItems.Count; i++) {
                incItem = order.GetIncrementableItem(shrinkableItems[i].EntityButtonIID, shrinkableItems[i].DistributionIID, order.IID);
                if (incItem != null) {
                    incItem.Quantity += shrinkableItems[i].Quantity;
                    shrinkableItems[i].Quantity = 0;
                    incItem.CompletedQuantity += shrinkableItems[i].CompletedQuantity;
                } else
                    shrinkableItems[i].OrderGroupIID = IID;
            }

            for (int i = order.items.Count - 1; i >= 0; i--) {
                if (order.items[i].Quantity == 0)
                    order.items.RemoveAt(i);
            }

            return order;
        }

        public bool HasMultipleOrderGroupIID() {
            string OrderGroupIID = "";
            int count = 0;
            foreach (OrderItem item in items) {
                if (item.OrderGroupIID != OrderGroupIID) {
                    count++;
                    OrderGroupIID = item.OrderGroupIID;
                    if (count > 1)
                        return true;
                }
            }
            return count > 1;
        }


        public Order Subtract(Order givenOrder) {
            Order duplicateOrder = Clone(false);
            //duplicateOrder.items.Clear();

            foreach (OrderItem existingItem in items) {
               OrderItem givenOrderItem = givenOrder.items.Find(x=> x.EntityButtonIID == existingItem.EntityButtonIID);
               if (givenOrderItem == null) {
                    //new item doesn't exist in old order so put all of it to result order
                    duplicateOrder.items.Add(existingItem.Clone(false));
               } else {
                   //new item exist in old order 

                   if (givenOrderItem.Quantity < existingItem.Quantity) {
                       //but new item quantity is more now
                       OrderItem tempItem = existingItem.Clone(false);
                       tempItem.Quantity = existingItem.Quantity - givenOrderItem.Quantity;
                        duplicateOrder.items.Add(tempItem);
                   }
               }
            }
            return duplicateOrder;
        }


        public bool HasItemsForKitchen() {
            foreach (OrderItem item in items) {
                if (item.CompletedQuantity < item.Quantity)
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Gets the order excluding completed items
        /// </summary>
        /// <returns></returns>
        public Order GetOrderWithKitchenableItems() {
            Order ShrunkOrder = ShrinkOrder(this.Clone(true));
            
            Order duplicateOrder = Clone(false);
            
            foreach (OrderItem existingItem in ShrunkOrder.items) {
                //If this item needs to be prepared or printed in the kitchen
                if (existingItem.CompletedQuantity < existingItem.Quantity) {
                    OrderItem newItem = existingItem.Clone(false);
                    newItem.Quantity = existingItem.Quantity - existingItem.CompletedQuantity;
                    duplicateOrder.items.Add(newItem);
                }
            }

            return duplicateOrder;
            //if (duplicateOrder.items.Count > 0)
            //    return duplicateOrder;
            //else
                //return null;

        }





        public Order Clone() {
            Order order = new Order();
            order.IID = IID;
            order.TableIID = TableIID;
            order.OrderDate = OrderDate;
            order.Covers = Covers;
            order.OrderType = OrderType;
            order.Status = Status;
            order.blnPrinted = blnPrinted;
            order.CustomerIID = CustomerIID;
            order.Payment = Payment;
            order.PaymentFlag = PaymentFlag;
            order.RequestCount = RequestCount;
            order.LockedClientIP = LockedClientIP;
            order.SessionIID = SessionIID;
            order.Instruction = Instruction;
            order.MoneyPaid = MoneyPaid;

            order.TableName = TableName;
            order.CName = CName;
            order.PostCode = PostCode;
            order.Buzzer = Buzzer;
            order.Address = Address;
            order.Town = Town;
            order.Tel = Tel;
            order.Mobile = Mobile;
            order.Email = Email;
            order.UserName = UserName;
            order.Reference = Reference;

            order.ServiceChargeRate = ServiceChargeRate;
            order.ServiceChargeTaxRate = ServiceChargeTaxRate;

           
            foreach (OrderItem item in items) {
                order.items.Add(item.Clone(false));
            }
            return order;
        }

        public Order Clone(bool blnIncludeItems) {
            Order order = new Order();
            order.IID = IID;
            order.TableIID = TableIID;
            order.OrderDate = OrderDate;
            order.Covers = Covers;
            order.OrderType = OrderType;
            order.Status = Status;
            order.blnPrinted = blnPrinted;
            order.CustomerIID = CustomerIID;
            order.Payment = Payment;
            order.PaymentFlag = PaymentFlag;
            order.RequestCount = RequestCount;
            order.LockedClientIP = LockedClientIP;
            order.SessionIID = SessionIID;
            order.Instruction = Instruction;
            order.MoneyPaid = MoneyPaid;

            order.TableName = TableName;
            order.CName = CName;
            order.PostCode = PostCode;
            order.Buzzer = Buzzer;
            order.Address = Address;
            order.Town = Town;
            order.Tel = Tel;
            order.Mobile = Mobile;
            order.Email = Email;
            order.UserName = UserName;
            order.Reference = Reference;

            order.ServiceChargeRate = ServiceChargeRate;
            order.ServiceChargeTaxRate = ServiceChargeTaxRate;

            if (blnIncludeItems) {
                foreach (OrderItem item in items) {
                    order.items.Add(item.Clone(false));
                }
            }
            return order;
        }


        public Order Duplicate(int secondDifference)
        {
            Order order = new Order();
            // order.IID = IID;
            // order.TableIID = TableIID;
            order.OrderDate = OrderDate.AddSeconds(secondDifference);
            order.Covers = Covers;
            order.OrderType = OrderType;
            order.Status = Status;
            order.blnPrinted = blnPrinted;
            order.CustomerIID = CustomerIID;
            order.Payment = Payment;
            order.PaymentFlag = PaymentFlag;
            order.RequestCount = RequestCount;
            order.LockedClientIP = LockedClientIP;
            order.SessionIID = SessionIID;
            order.Instruction = Instruction;
            order.MoneyPaid = MoneyPaid;

            order.TableName = TableName;
            order.CName = CName;
            order.PostCode = PostCode;
            order.Buzzer = Buzzer;
            order.Address = Address;
            order.Town = Town;
            order.Tel = Tel;
            order.Mobile = Mobile;
            order.Email = Email;
            order.UserName = UserName;
            order.Reference = Reference;

            order.ServiceChargeRate = ServiceChargeRate;
            order.ServiceChargeTaxRate = ServiceChargeTaxRate;

            foreach (OrderItem item in items)
            {
                order.items.Add(item.Duplicate(order.IID,true));
            }

            return order;
        }


        /// <summary>
        /// Returns OrderGroupIID at all times, if non exist cReates a new one and returns it
        /// </summary>
        /// <param name="ParentOrderItemIID"></param>
        /// <param name="EntityIID"></param>
        /// <param name="OrderGroupIID"></param>
        /// <param name="SizeBarItemIID"></param>
        /// <param name="DivisionalOrderGroupIID"></param>
        /// <param name="DivisionText"></param>
        /// <param name="Quantity"></param>
        /// <param name="CalculationRatio"></param>
        /// <param name="SizeButtonOrEntityButtonPrice"></param>
        /// <param name="EntityButtonIID"></param>
        /// <param name="OrderItemText"></param>
        /// <param name="TopItem"></param>
        /// <param name="DivisionalDisplayOrder"></param>
        /// <param name="distributioniid"></param>
        /// <param name="Instruction"></param>
        /// <param name="ItemType"></param>
        /// <param name="dorder"></param>
        /// <param name="EntityName"></param>
        /// <param name="SBButtonText"></param>
        /// <param name="EntityDisplayOrder"></param>
        /// <param name="SizeBarIID"></param>
        /// <param name="TaxPercent"></param>
        /// <param name="DistributionName"></param>
        /// <returns></returns>
        public string AddOrderItem(string EntityIID, string OrderGroupIID,
           float Quantity, float Price, string EntityButtonIID, string OrderItemText, string distributioniid,
           OrderItemTypes ItemType, int dorder, string EntityName, int EntityDisplayOrder, float TaxPercent) {

            OrderItem oi = new OrderItem(this.IID, EntityIID, OrderGroupIID, Quantity,
                Price, EntityButtonIID, OrderItemText,
               distributioniid, ItemType, dorder,
               EntityName, EntityDisplayOrder, TaxPercent);

            //Add this at the end of the list as top item
            oi.OrderGroupIID = ShortGuid.NewGuid().ToString();
            items.Add(oi);
            blnItemsChanged = true;
            return oi.OrderGroupIID;
        }
        public string AddOrderItem(OrderItem oi) {
            //Add this at the end of the list as top item
            //oi.OrderGroupIID = ShortGuid.NewGuid().ToString();
            items.Add(oi);
            blnItemsChanged = true;
            return oi.OrderGroupIID;
        }
        public void CancelOrderItem(string OrderGroupIID)
        {
            for (int i = 0; i < items.Count; i++)
            {
                OrderItem oi = (OrderItem)items[i];
                if (oi.OrderGroupIID == OrderGroupIID)
                {
                    items.Remove(oi);
                    i--;
                }
            }
        }

        public OrderItem GetOrderItem(string OrderItemIID)
        {
            return items.Find(x => x.IID == OrderItemIID);
            
        }

        

        public void DeleteOrderItem(string OrderItemIID)
        {
            if (OrderItemIID != null && OrderItemIID != "")
            {
                foreach (OrderItem item in items) {
                    if (item.IID == OrderItemIID) {
                        items.Remove(item);
                        blnItemsChanged = true;
                        return;
                    }
                }               
            }
        }
        public void VoidOrderItem(string OrderItemIID)
        {
            try {
                OrderItem oi = GetOrderItem(OrderItemIID);
                if (!oi.OrderItemText.StartsWith("**VOID**"))
                    oi.OrderItemText = "**VOID** " + oi.OrderItemText;
            } catch { }
        }

        public void AddIncrementOrderItem(OrderItem newItem) {
            OrderItem incrementableItem = GetIncrementableItem(newItem.EntityButtonIID, newItem.DistributionIID, newItem.OrderGroupIID);
            if (incrementableItem == null)
                AddOrderItem(newItem);
            else
                incrementableItem.Quantity += newItem.Quantity;
        }

        public OrderItem GetIncrementableItem(string EntityButtonIID, string DistributionIID,string OrderGroupIID)
        {
            return items.Find(x => x.EntityButtonIID == EntityButtonIID && x.DistributionIID == DistributionIID && x.OrderGroupIID == OrderGroupIID);
        }
        public void IncrementOrderItem(string OrderItemIID)
        {
            try {
                this.GetOrderItem(OrderItemIID).Increment();
                blnItemsChanged = true;
            } catch { }
        }
        public void CloneOrderItem(string OrderItemIID)
        {
            try {
                items.Add(GetOrderItem(OrderItemIID).Clone(true));
                blnItemsChanged = true;
            } catch { }
           
        }

        public void DecrementOrderItem(string OrderItemIID)
        {
            if (OrderItemIID == "")
                return;
            OrderItem oi = this.GetOrderItem(OrderItemIID);
            if (!oi.Decrement())
                this.DeleteOrderItem(oi.IID);
            blnItemsChanged = true;
        }

        public void SetBusy(string ClientIP)
        {
            LockedClientIP = ClientIP;
        }

        public bool IsBusy(string ClientIP)
        {
            if (this.LockedClientIP == "" || this.LockedClientIP == null || this.LockedClientIP == ClientIP)
                return false;
            else
                return true;
        }

        public string GetAllOrderItemsText(bool AddPrice = true) {
            string str = "";
            foreach (OrderItem item in items) {
                string itemtext = (item.OrderItemText.Length > 13) ? item.OrderItemText.Substring(0, 12) : item.OrderItemText;
                if (AddPrice)
                    str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10) + "{2,5:N2}", item.Quantity, itemtext, item.Total) + "\r\n";
                else 
                    str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10), item.Quantity, itemtext) + "\r\n";
            }
            
            return str;
        }

        public ArrayList GetOrderAsArrayList()
        {
            ArrayList lines = new ArrayList();

            OrderItem oi;
            float OrderTotal = 0f;


            switch (OrderType)
            {
                case OrderTypes.DirectSale:
                    lines.Add(new List<string>(new string[] { UserName + " @ " + UF.GetOrderTypeAsText(OrderType) }));
                    break;
                case OrderTypes.InHouse:
                    lines.Add(new List<string>(new string[] { UserName + " @ " + this.TableName }));
                    break;
                case OrderTypes.InternetTakeAway:
                case OrderTypes.TakeAwayB:
                    lines.Add(new List<string>(new string[] { UserName + " @ " + UF.GetOrderTypeAsText(OrderType) }));
                    lines.Add(new List<string>(new string[] { "------------------------" }));
                    lines.Add(new List<string>(new string[] { "Customer : " + CName }));
                    lines.Add(new List<string>(new string[] { "Tel : " + Tel }));
                    lines.Add(new List<string>(new string[] { "Mobile : " + Mobile }));
                    break;
                case OrderTypes.Delivery:
                case OrderTypes.InternetDelivery:
                    lines.Add(new List<string>(new string[] { UserName + " @ " + UF.GetOrderTypeAsText(OrderType) }));
                    lines.Add(new List<string>(new string[] { "------------------------" }));
                    lines.Add(new List<string>(new string[] { "Customer : " + CName }));
                    lines.Add(new List<string>(new string[] { "Address : " + Address }));
                    lines.Add(new List<string>(new string[] { "Buzzer : " + Buzzer }));
                    lines.Add(new List<string>(new string[] { "Postcode : " + PostCode }));
                    lines.Add(new List<string>(new string[] { "Tel : " + Tel }));
                    lines.Add(new List<string>(new string[] { "Mobile : " + Mobile }));
                    lines.Add(new List<string>(new string[] { "Town : " + Town }));
                    break;
                default:
                    lines.Add(new List<string>(new string[] { UserName + " @ " + UF.GetOrderTypeAsText(OrderType) }));
                    break;
            }
            lines.Add(new List<string>(new string[] { "------------------------" }));


            for (int i = 0; i < items.Count; i++)
            {

                //Display Top Item
                oi = (OrderItem)items[i];
                lines.Add(new List<string>(new string[] {oi.Quantity.ToString("f0"),oi.OrderItemText, oi.Total.ToString("c")}));


            }

            OrderTotal = GetFullTotal();
            lines.Add(new List<string>(new string[] { "------------------------" }));
            lines.Add(new List<string>(new string[] { "Order Total : " + OrderTotal.ToString("c") }));

            return lines;
        }

        public string GetOrderAsText(string columnDelimeter, string lineDelimeter)
        {
            string text = "";
            ArrayList lines = GetOrderAsArrayList();
            for (int i = 0; i < lines.Count; i++)
            {
                List<string> singleLine = (List<string>)lines[i];
                for (int x = 0; x < singleLine.Count; x++)
                {
                    text += singleLine[x] + columnDelimeter;
                }
                text += lineDelimeter;
            }
            return text;
        }
        public string CreateKitchenOrderText(string columnDelimeter, string lineDelimeter) {
            string text = "";
            for (int i = 0; i < items.Count; i++) {
                OrderItem oi = (OrderItem)items[i];
                text += oi.DistributionIID + columnDelimeter +  oi.Quantity.ToString("f0") + columnDelimeter + oi.OrderItemText + lineDelimeter;
            }
            //if (blnShowTime) {
            //    text += "\r\n" + DateTime.Now.ToString("HH:mm:ss");
            //}
            return text;
        }
        public string GetOrderAsSimpleText()
        {
            return GetOrderAsText("\t", "\r\n");
        }

        public string GetOrderAsHtml()
        {
            return GetOrderAsText("&nbsp;&nbsp;&nbsp;&nbsp;", "<br>");
        }

        public bool IsCustomerDetailsRequired {
            get {
                switch (OrderType) {
                    case OrderTypes.Delivery:
                    case OrderTypes.InternetDelivery:
                    case OrderTypes.InternetTakeAway:
                    case OrderTypes.TakeAwayB:
                        return true;
                    case OrderTypes.Unknown:
                    case OrderTypes.Pad:
                    case OrderTypes.InHouse:
                    case OrderTypes.DirectSale:
                        return false;
                    default:
                        return false;
                }
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public string ToSimpleString()
        {
            string content ="Orginial ORDER @   " +  OrderDate.ToString() + "   Total= " + GetFullTotal().ToString("N2").PadLeft(10, ' ') + "   Reference = " + Reference +  Environment.NewLine;
            foreach (var item in items)
            {
                content +="  "  +  item.ToSimpleString() + Environment.NewLine;
            }
            return content;                
        }

    }

}
