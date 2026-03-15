using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;    
using System.Text.Json;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Order  : BaseClass
{
    public List<OrderItem> items { get; set; } = new();
    public string? TableIID { get; set; }   = string.Empty; 

    public string? TableName { get; set; }      = string.Empty;

    public DateTime OrderDate { get; set; } = DateTime.Now;

    public int Covers { get; set; } = 1;

    public OrderTypes OrderType { get; set; } = OrderTypes.InHouse;

    public PaymentMethods Payment { get; set; } = PaymentMethods.Unknown;

    public string? CustomerIID { get; set; } = string.Empty;

    public string? SessionIID { get; set; }  = string.Empty;

    public StatusFlags Status { get; set; } = StatusFlags.NEW;

    public string? LockedClientIP { get; set; }   = string.Empty;

    public string Instruction { get; set; } = string.Empty;

    public double MoneyPaid { get; set; }

    public string? PaymentFlag { get; set; }   = string.Empty;

    public string? CName { get; set; }      = string.Empty;

    public string? Postcode { get; set; }     = string.Empty;

    public string? Address { get; set; }    = string.Empty;

    public string? Buzzer { get; set; }    = string.Empty;

    public string? Town { get; set; }   = string.Empty;

    public string? Tel { get; set; }    = string.Empty;

    public string? Mobile { get; set; }   = string.Empty;

    public string? Email { get; set; }   = string.Empty;

    public string? UserName { get; set; } = string.Empty;

    public string? Reference { get; set; }   = string.Empty;

    public double ServiceChargeRate { get; set; }

    public double ServiceChargeTaxRate { get; set; }

    


    [NotMapped]
    public string Title { get; set; } = string.Empty;

    [NotMapped]
    public bool blnPrinted { get; set; }
    [NotMapped]
    public int RequestCount { get; set; }
    [NotMapped]
    public bool blnItemsChanged { get; set; }


    public Order(OrderTypes OrderType)
    {
        this.OrderType = OrderType;
    }
    public Order(OrderTypes OrderType, double ServiceChargeRate, double ServiceChargeTaxRate) : this(OrderType)
    {
        this.ServiceChargeRate = ServiceChargeRate;
        this.ServiceChargeTaxRate = ServiceChargeTaxRate;
    }

    public double GetFullTotal()
    {
        return GetTaxIncludedItemTotal() + GetServiceCharge();
    }

    /// <summary>
    /// Tax Inclusive Item Total
    /// </summary>
    /// <returns></returns>
    public double GetTaxIncludedItemTotal()
    {
        double Total = 0f;
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
    public double GetItemTaxTotal()
    {
        double VatTotal = 0f;
        foreach (OrderItem item in items)
        {
            VatTotal += item.TaxValue;
        }
        return VatTotal;
    }

    /// <summary>
    /// Total of All items without taxes
    /// </summary>
    /// <returns></returns>
    public double GetTaxExcludedItemTotal()
    {
        double Total = 0f;
        foreach (OrderItem item in items)
        {
            Total += item.Total - item.TaxValue;
        }
        return Total;
    }

    public double GetServiceCharge()
    {
        return GetTaxExcludedItemTotal() * ServiceChargeRate / 100;
    }

    public double GetServiceChargeTax()
    {
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

    public bool ShrinkOrder()
    {
        List<OrderItem> shrinkableItems = new List<OrderItem>();
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].OrderGroupIID != IID)
                shrinkableItems.Add(items[i]);
        }
        OrderItem incItem = null;
        for (int i = 0; i < shrinkableItems.Count; i++)
        {
            incItem = GetIncrementableItem(shrinkableItems[i].EntityButtonIID, shrinkableItems[i].DistributionIID, IID);
            if (incItem != null)
            {
                incItem.Quantity += shrinkableItems[i].Quantity;
                shrinkableItems[i].Quantity = 0;
                incItem.CompletedQuantity += shrinkableItems[i].CompletedQuantity;
            } else
                shrinkableItems[i].OrderGroupIID = IID;
        }


        for (int i = items.Count - 1; i >= 0; i--)
        {
            if (items[i].Quantity == 0)
                items.RemoveAt(i);

        }

        string ordergroupshrunkguid = ShortGuid.NewDateBasedGuid(OrderDate);
        for (int i = 0; i < items.Count; i++)
        {
            items[i].OrderGroupIID = ordergroupshrunkguid;
        }

        return true;
    }

    public Order ShrinkOrder(Order order)
    {
        List<OrderItem> shrinkableItems = new List<OrderItem>();
        for (int i = 0; i < order.items.Count; i++)
        {
            if (order.items[i].OrderGroupIID != IID)
                shrinkableItems.Add(order.items[i]);
        }
        OrderItem incItem = null;
        for (int i = 0; i < shrinkableItems.Count; i++)
        {
            incItem = order.GetIncrementableItem(shrinkableItems[i].EntityButtonIID, shrinkableItems[i].DistributionIID, order.IID);
            if (incItem != null)
            {
                incItem.Quantity += shrinkableItems[i].Quantity;
                shrinkableItems[i].Quantity = 0;
                incItem.CompletedQuantity += shrinkableItems[i].CompletedQuantity;
            } else
                shrinkableItems[i].OrderGroupIID = IID;
        }

        for (int i = order.items.Count - 1; i >= 0; i--)
        {
            if (order.items[i].Quantity == 0)
                order.items.RemoveAt(i);
        }

        return order;
    }

    public bool HasMultipleOrderGroupIID()
    {
        string OrderGroupIID = "";
        int count = 0;
        foreach (OrderItem item in items)
        {
            if (item.OrderGroupIID != OrderGroupIID)
            {
                count++;
                OrderGroupIID = item.OrderGroupIID;
                if (count > 1)
                    return true;
            }
        }
        return count > 1;
    }


    public Order Subtract(Order givenOrder)
    {
        Order duplicateOrder = Clone(false);
        //duplicateOrder.items.Clear();

        foreach (OrderItem existingItem in items)
        {
            OrderItem givenOrderItem = givenOrder.items.Find(x => x.EntityButtonIID == existingItem.EntityButtonIID);
            if (givenOrderItem == null)
            {
                //new item doesn't exist in old order so put all of it to result order
                duplicateOrder.items.Add(existingItem.Clone(false));
            } else
            {
                //new item exist in old order 

                if (givenOrderItem.Quantity < existingItem.Quantity)
                {
                    //but new item quantity is more now
                    OrderItem tempItem = existingItem.Clone(false);
                    tempItem.Quantity = existingItem.Quantity - givenOrderItem.Quantity;
                    duplicateOrder.items.Add(tempItem);
                }
            }
        }
        return duplicateOrder;
    }


    public bool HasItemsForKitchen()
    {
        foreach (OrderItem item in items)
        {
            if (item.CompletedQuantity < item.Quantity)
                return true;
        }
        return false;
    }


    /// <summary>
    /// Gets the order excluding completed items
    /// </summary>
    /// <returns></returns>
    public Order GetOrderWithKitchenableItems()
    {
        Order ShrunkOrder = ShrinkOrder(this.Clone(true));

        Order duplicateOrder = Clone(false);

        foreach (OrderItem existingItem in ShrunkOrder.items)
        {
            //If this item needs to be prepared or printed in the kitchen
            if (existingItem.CompletedQuantity < existingItem.Quantity)
            {
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



    public Order()
    {

    }

    public Order Clone()
    {
        Order order = new()
        {
            IID = IID,
            TableIID = TableIID,
            OrderDate = OrderDate,
            Covers = Covers,
            OrderType = OrderType,
            Status = Status,
            blnPrinted = blnPrinted,
            CustomerIID = CustomerIID,
            Payment = Payment,
            PaymentFlag = PaymentFlag,
            RequestCount = RequestCount,
            LockedClientIP = LockedClientIP,
            SessionIID = SessionIID,
            Instruction = Instruction,
            MoneyPaid = MoneyPaid,

            TableName = TableName,
            CName = CName,
            Postcode = Postcode,
            Buzzer = Buzzer,
            Address = Address,
            Town = Town,
            Tel = Tel,
            Mobile = Mobile,
            Email = Email,
            UserName = UserName,
            Reference = Reference,

            ServiceChargeRate = ServiceChargeRate,
            ServiceChargeTaxRate = ServiceChargeTaxRate
        };


        foreach (OrderItem item in items)
        {
            order.items.Add(item.Clone(false));
        }
        return order;
    }

    public Order Clone(bool blnIncludeItems)
    {
        Order order = new()
        {
            IID = IID,
            TableIID = TableIID,
            OrderDate = OrderDate,
            Covers = Covers,
            OrderType = OrderType,
            Status = Status,
            blnPrinted = blnPrinted,
            CustomerIID = CustomerIID,
            Payment = Payment,
            PaymentFlag = PaymentFlag,
            RequestCount = RequestCount,
            LockedClientIP = LockedClientIP,
            SessionIID = SessionIID,
            Instruction = Instruction,
            MoneyPaid = MoneyPaid,

            TableName = TableName,
            CName = CName,
            Postcode = Postcode,
            Buzzer = Buzzer,
            Address = Address,
            Town = Town,
            Tel = Tel,
            Mobile = Mobile,
            Email = Email,
            UserName = UserName,
            Reference = Reference,

            ServiceChargeRate = ServiceChargeRate,
            ServiceChargeTaxRate = ServiceChargeTaxRate
        };

        if (blnIncludeItems)
        {
            foreach (OrderItem item in items)
            {
                order.items.Add(item.Clone(false));
            }
        }
        return order;
    }


    public Order Duplicate(int secondDifference)
    {
        Order order = new()
        {
            OrderDate = OrderDate.AddSeconds(secondDifference),
            Covers = Covers,
            OrderType = OrderType,
            Status = Status,
            blnPrinted = blnPrinted,
            CustomerIID = CustomerIID,
            Payment = Payment,
            PaymentFlag = PaymentFlag,
            RequestCount = RequestCount,
            LockedClientIP = LockedClientIP,
            SessionIID = SessionIID,
            Instruction = Instruction,
            MoneyPaid = MoneyPaid,

            TableName = TableName,
            CName = CName,
            Postcode = Postcode,
            Buzzer = Buzzer,
            Address = Address,
            Town = Town,
            Tel = Tel,
            Mobile = Mobile,
            Email = Email,
            UserName = UserName,
            Reference = Reference,

            ServiceChargeRate = ServiceChargeRate,
            ServiceChargeTaxRate = ServiceChargeTaxRate
        };

        foreach (OrderItem item in items)
        {
            order.items.Add(item.Duplicate(order.IID, true));
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
       double Quantity, double Price, string EntityButtonIID, string OrderItemText, string distributioniid,
       OrderItemTypes ItemType, int dorder, string EntityName, int EntityDisplayOrder, double TaxPercent)
    {

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
    public string AddOrderItem(OrderItem oi)
    {
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
            foreach (OrderItem item in items)
            {
                if (item.IID == OrderItemIID)
                {
                    items.Remove(item);
                    blnItemsChanged = true;
                    return;
                }
            }
        }
    }
    public void VoidOrderItem(string OrderItemIID)
    {
        try
        {
            OrderItem oi = GetOrderItem(OrderItemIID);
            if (!oi.OrderItemText.StartsWith("**VOID**"))
                oi.OrderItemText = "**VOID** " + oi.OrderItemText;
        } catch { }
    }

    public void AddIncrementOrderItem(OrderItem newItem)
    {
        OrderItem incrementableItem = GetIncrementableItem(newItem.EntityButtonIID, newItem.DistributionIID, newItem.OrderGroupIID);
        if (incrementableItem == null)
            AddOrderItem(newItem);
        else
            incrementableItem.Quantity += newItem.Quantity;
    }

    public OrderItem GetIncrementableItem(string EntityButtonIID, string DistributionIID, string OrderGroupIID)
    {
        return items.Find(x => x.EntityButtonIID == EntityButtonIID && x.DistributionIID == DistributionIID && x.OrderGroupIID == OrderGroupIID);
    }
    public void IncrementOrderItem(string OrderItemIID)
    {
        try
        {
            this.GetOrderItem(OrderItemIID).Increment();
            blnItemsChanged = true;
        } catch { }
    }
    public void CloneOrderItem(string OrderItemIID)
    {
        try
        {
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

    public string GetAllOrderItemsText(bool AddPrice = true)
    {
        string str = "";
        foreach (OrderItem item in items)
        {
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
        double OrderTotal = 0f;


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
                lines.Add(new List<string>(new string[] { "Postcode : " + Postcode }));
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
            lines.Add(new List<string>(new string[] { oi.Quantity.ToString("f0"), oi.OrderItemText, oi.Total.ToString("c") }));


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
    public string CreateKitchenOrderText(string columnDelimeter, string lineDelimeter)
    {
        string text = "";
        for (int i = 0; i < items.Count; i++)
        {
            OrderItem oi = (OrderItem)items[i];
            text += oi.DistributionIID + columnDelimeter + oi.Quantity.ToString("f0") + columnDelimeter + oi.OrderItemText + lineDelimeter;
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

    public bool IsCustomerDetailsRequired
    {
        get
        {
            switch (OrderType)
            {
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

    //public override string ToString()
    //{
    //    return JsonConvert.SerializeObject(this, Formatting.Indented);
    //}

    public string ToSimpleString()
    {
        string content = "Orginial ORDER @   " + OrderDate.ToString() + "   Total= " + GetFullTotal().ToString("N2").PadLeft(10, ' ') + "   Reference = " + Reference + Environment.NewLine;
        foreach (var item in items)
        {
            content += "  " + item.ToSimpleString() + Environment.NewLine;
        }
        return content;
    }
}
