using System.ComponentModel.DataAnnotations.Schema;
using POSLayer.Library;

namespace POSLayer.Models;

public partial class Order  : BaseClass
{                
    public string? TableIID { get; set; }   = string.Empty; 
    public string? TableName { get; set; }      = string.Empty;
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public int Covers { get; set; } = 1;
    public OrderTypes OrderType { get; set; } = OrderTypes.InHouse;
    public PaymentMethods Payment { get; set; } = PaymentMethods.Unknown;  
    public string? SessionIID { get; set; }  = string.Empty;
    public StatusFlags Status { get; set; } = StatusFlags.NEW;
    public string? LockedClientIP { get; set; }   = string.Empty;
    public string Instruction { get; set; } = string.Empty;
    public double MoneyPaid { get; set; }
    public string? PaymentFlag { get; set; }   = string.Empty;   
    public string? Reference { get; set; }   = string.Empty;
    public double ServiceChargeRate { get; set; }
    public double ServiceChargeTaxRate { get; set; }

    public string? Waiter { get; set; }


    public List<OrderItem> items { get; set; } = new List<OrderItem>();

    public string? CustomerIID { get; set; } = string.Empty;
    public Customer Customer { get; set; } // Navigation property



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
        return CalculatedValue + ServiceCharge;
    }

    /// <summary>
    /// Tax Inclusive Item Total
    /// </summary>
    /// <returns></returns>
    public double CalculatedValue
    {
        get
        {
            return items.Sum(x => x.CalculatedValue);
        }
    }

    /// <summary>
    /// Total of All Items with Taxes
    /// </summary>
    /// <returns></returns>
    public double CalculatedVat
    {
        get {
            return items.Sum(x => x.CalculatedVat);
        }
    }

    /// <summary>
    /// Total of All items without taxes
    /// </summary>
    /// <returns></returns>
    public double CalculatedExVat
    {
        get
        {
            return items.Sum(x => x.CalculatedExVat);
        }
    }

    public double ServiceCharge
    {
        get
        {
            return CalculatedExVat * ServiceChargeRate / 100;
        }
    }

    public double GetServiceChargeTax()
    {
        return ServiceCharge * ServiceChargeTaxRate / 100;
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
            oi.OrderIID = this.IID;
            this.AddIncrementOrderItem(oi);
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

        var toRemove = items.Where(x => x.Quantity <= 0).ToList();
        foreach (var item in toRemove)
        {
            items.Remove(item);
        }
        string ordergroupshrunkguid = ShortGuid.NewDateBasedGuid(OrderDate);
        foreach (var item in items)
        {
            item.OrderGroupIID = ordergroupshrunkguid;
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
            OrderItem givenOrderItem = givenOrder.items.Where(x => x.EntityButtonIID == existingItem.EntityButtonIID).FirstOrDefault();
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
        items.Add(oi);
        blnItemsChanged = true;
        return oi.OrderGroupIID;
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
        return items.Where(x => x.EntityButtonIID == EntityButtonIID && x.DistributionIID == DistributionIID && x.OrderGroupIID == OrderGroupIID).FirstOrDefault();
    }
    public void IncrementOrderItem(string OrderItemIID)
    {
        try
        {
            items.Where(x => x.IID == OrderItemIID).FirstOrDefault().Quantity++;
            blnItemsChanged = true;
        } catch { }
    }

    public void DecrementOrderItem(string OrderItemIID)
    {
        if (string.IsNullOrEmpty(OrderItemIID))
            return;

        OrderItem oi = items.Where(x => x.IID ==OrderItemIID).FirstOrDefault();
        if (oi == null)
            return;

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
                str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10) + "{2,5:N2}", item.Quantity, itemtext, item.CalculatedValue) + "\r\n";
            else
                str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10), item.Quantity, itemtext) + "\r\n";
        }

        return str;
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
