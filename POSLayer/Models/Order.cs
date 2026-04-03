using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Order : BaseOrder
{
    public Order()
    {

    }
    public Order(OrderTypes OrderType)
    {
        this.OrderType = OrderType;
    }
    public Order(OrderTypes OrderType, double ServiceChargeRate, double ServiceChargeTaxRate) : this(OrderType)
    {
        this.ServiceChargeRate = ServiceChargeRate;
        this.ServiceChargeTaxRate = ServiceChargeTaxRate;
    }


    public Order Clone()
    {
        Order order = new()
        {
            IID = IID,
            TableIID = TableIID,
            LastModified = LastModified,
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
            Reference = Reference,

            ServiceChargeRate = ServiceChargeRate,
            ServiceChargeTaxRate = ServiceChargeTaxRate
        };


        foreach (OrderItem item in Items)
        {
            order.Items.Add(item.Clone(false));
        }
        return order;
    }

    public Order Clone(bool blnIncludeItems)
    {
        Order order = new()
        {
            IID = IID,
            TableIID = TableIID,
            LastModified = LastModified,
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
            Reference = Reference,

            ServiceChargeRate = ServiceChargeRate,
            ServiceChargeTaxRate = ServiceChargeTaxRate
        };

        if (blnIncludeItems)
        {
            foreach (OrderItem item in Items)
            {
                order.Items.Add(item.Clone(false));
            }
        }
        return order;
    }


    public Order Duplicate(int secondDifference)
    {
        Order order = new()
        {
            LastModified = LastModified.AddSeconds(secondDifference),
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
            Reference = Reference,

            ServiceChargeRate = ServiceChargeRate,
            ServiceChargeTaxRate = ServiceChargeTaxRate
        };

        foreach (OrderItem item in Items)
        {
            order.Items.Add(item.Duplicate(order.IID, true));
        }

        return order;
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
        for (int i = 0; i < norder.Items.Count; i++)
        {
            OrderItem oi = (OrderItem)norder.Items[i];
            oi.OrderIID = this.IID;
            this.AddIncrementOrderItem(oi);
        }
        return true;
    }

    public bool ShrinkOrder()
    {
        List<OrderItem> shrinkableItems = new List<OrderItem>();
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].OrderGroupIID != IID)
                shrinkableItems.Add(Items[i]);
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

        var toRemove = Items.Where(x => x.Quantity <= 0).ToList();
        foreach (var item in toRemove)
        {
            Items.Remove(item);
        }
        string ordergroupshrunkguid = ShortGuid.NewDateBasedGuid(LastModified);
        foreach (var item in Items)
        {
            item.OrderGroupIID = ordergroupshrunkguid;
        }
        return true;
    }

    public Order ShrinkOrder(Order order)
    {
        List<OrderItem> shrinkableItems = new List<OrderItem>();
        for (int i = 0; i < order.Items.Count; i++)
        {
            if (order.Items[i].OrderGroupIID != IID)
                shrinkableItems.Add(order.Items[i]);
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

        for (int i = order.Items.Count - 1; i >= 0; i--)
        {
            if (order.Items[i].Quantity == 0)
                order.Items.RemoveAt(i);
        }

        return order;
    }

    public bool HasMultipleOrderGroupIID()
    {
        string OrderGroupIID = "";
        int count = 0;
        foreach (OrderItem item in Items)
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

        foreach (OrderItem existingItem in Items)
        {
            OrderItem givenOrderItem = givenOrder.Items.Where(x => x.EntityButtonIID == existingItem.EntityButtonIID).FirstOrDefault();
            if (givenOrderItem == null)
            {
                //new item doesn't exist in old order so put all of it to result order
                duplicateOrder.Items.Add(existingItem.Clone(false));
            } else
            {
                //new item exist in old order 
                if (givenOrderItem.Quantity < existingItem.Quantity)
                {
                    //but new item quantity is more now
                    OrderItem tempItem = existingItem.Clone(false);
                    tempItem.Quantity = existingItem.Quantity - givenOrderItem.Quantity;
                    duplicateOrder.Items.Add(tempItem);
                }
            }
        }
        return duplicateOrder;
    }


    public bool HasItemsForKitchen()
    {
        foreach (OrderItem item in Items)
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

        foreach (OrderItem existingItem in ShrunkOrder.Items)
        {
            //If this item needs to be prepared or printed in the kitchen
            if (existingItem.CompletedQuantity < existingItem.Quantity)
            {
                OrderItem newItem = existingItem.Clone(false);
                newItem.Quantity = existingItem.Quantity - existingItem.CompletedQuantity;
                duplicateOrder.Items.Add(newItem);
            }
        }

        return duplicateOrder;
    }





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
        Items.Add(oi);
        blnItemsChanged = true;
        return oi.OrderGroupIID;
    }
    public string AddOrderItem(OrderItem oi)
    {
        //Add this at the end of the list as top item
        Items.Add(oi);
        blnItemsChanged = true;
        return oi.OrderGroupIID;
    }

    public void DeleteOrderItem(string OrderItemIID)
    {
        if (OrderItemIID != null && OrderItemIID != "")
        {
            foreach (OrderItem item in Items)
            {
                if (item.IID == OrderItemIID)
                {
                    Items.Remove(item);
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
        return Items.Where(x => x.EntityButtonIID == EntityButtonIID && x.DistributionIID == DistributionIID && x.OrderGroupIID == OrderGroupIID).FirstOrDefault();
    }
    public void IncrementOrderItem(string OrderItemIID)
    {
        try
        {
            Items.Where(x => x.IID == OrderItemIID).FirstOrDefault().Quantity++;
            blnItemsChanged = true;
        } catch { }
    }

    public void DecrementOrderItem(string OrderItemIID)
    {
        if (string.IsNullOrEmpty(OrderItemIID))
            return;

        OrderItem oi = Items.Where(x => x.IID == OrderItemIID).FirstOrDefault();
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
        foreach (OrderItem item in Items)
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
}
