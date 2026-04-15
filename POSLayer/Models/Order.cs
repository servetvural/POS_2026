using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Order : BaseClass
{
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string? SessionIID { get; set; }
    public Session? Session { get; set; }

    public string? TableIID { get; set; }
    public virtual Masa? Table { get; set; }


    public string? CustomerIID { get; set; }
    public Customer? Customer { get; set; } // Navigation property
    public string? UserIID { get; set; }
    public User? User { get; set; } // Navigation property
    public DateTime LastModified { get; set; } = DateTime.Now;
    public int Covers { get; set; } = 1;
    public OrderTypes OrderType { get; set; } = OrderTypes.Sitin;
    public PaymentMethods Payment { get; set; } = PaymentMethods.NotPaid;
    public StatusFlags Status { get; set; } = StatusFlags.New;
    public string? LockedClientIP { get; set; }
    public DateTime? LockedUntil { get; set; }

    public string Instruction { get; set; } = string.Empty;

    public string? PaymentFlag { get; set; } = string.Empty;
    public string? Reference { get; set; } = string.Empty;
    public double ServiceChargeRate { get; set; }
    public double ServiceChargeTaxRate { get; set; }



    public List<OrderItem> Items { get; set; } = new();

    [NotMapped]
    public string Title { get; set; } = string.Empty;

    [NotMapped]
    public bool blnPrinted { get; set; }
    [NotMapped]
    public int RequestCount { get; set; }
    [NotMapped]
    public bool blnItemsChanged { get; set; }




    public double ItemTotal => Items.Sum(x => x.Total);
    public double ItemTotalVat => Items.Sum(x => x.TotalVat);
    public double ItemTotalExVat => Items.Sum(x => x.TotalExVat);
    public double ServiceCharge => ItemTotalExVat * ServiceChargeRate / 100;
    public double ServiceChargeTax => ServiceCharge * ServiceChargeTaxRate / 100;

    public double Total => ItemTotal + ServiceCharge;
    public double MoneyPaid { get; set; }
    public double Balance => Total - MoneyPaid;
    public bool isPaid => Total > 0 && Balance == 0;


    public string ToSimpleString()
    {
        string content = "Orginial ORDER @   " + LastModified.ToString() + "   Total= " + Total.ToString("N2").PadLeft(10, ' ') + "   Reference = " + Reference + Environment.NewLine;
        foreach (var item in Items)
        {
            content += "  " + item.ToSimpleString() + Environment.NewLine;
        }
        return content;
    }
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


    public XOrder ToXOrder()
    {
        XOrder xorder = new XOrder()
        {
            IID = this.IID,
            DOrder = this.DOrder,
            OrderDate = this.OrderDate,
            SessionIID = this.SessionIID,
            TableIID = this.TableIID,
            CustomerIID = this.CustomerIID,
            UserIID = this.UserIID,
            LastModified = this.LastModified,
            Covers = this.Covers,
            OrderType = this.OrderType,
            Payment = this.Payment,
            Status = this.Status,
            LockedClientIP = this.LockedClientIP,
            Instruction = this.Instruction,
            PaymentFlag = this.PaymentFlag,
            Reference = this.Reference,
            ServiceChargeRate = this.ServiceChargeRate,
            ServiceChargeTaxRate = this.ServiceChargeTaxRate
        };
        foreach (var item in Items)
        {
            xorder.Items.Add(item.ToXOrderItem());
        }
        return xorder;

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
        if (this.OrderType == OrderTypes.Sitin)
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
            incItem = GetIncrementableItem(shrinkableItems[i].CategoryItemIID, shrinkableItems[i].DistributionIID, IID);
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
            incItem = order.GetIncrementableItem(shrinkableItems[i].CategoryItemIID, shrinkableItems[i].DistributionIID, order.IID);
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
            OrderItem givenOrderItem = givenOrder.Items.Where(x => x.CategoryItemIID == existingItem.CategoryItemIID).FirstOrDefault();
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





    public string AddOrderItem(string OrderGroupIID,
       double Quantity, double Price, string CategoryItemIID, string OrderItemText, string distributioniid,
       OrderItemTypes ItemType, int dorder,  int CategoryDisplayOrder, double TaxPercent)
    {

        OrderItem oi = new OrderItem(this.IID, OrderGroupIID, Quantity,
            Price, CategoryItemIID, OrderItemText,
           distributioniid, ItemType, dorder,
            CategoryDisplayOrder, TaxPercent);

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

    public void DeleteOrderItem(OrderItem item)
    {
        if (item != null)
        {
            Items.Remove(item);
            blnItemsChanged = true;
            return;
        }
    }

    public void AddIncrementOrderItem(OrderItem newItem)
    {
        OrderItem incrementableItem = GetIncrementableItem(newItem.CategoryItemIID, newItem.DistributionIID, newItem.OrderGroupIID);
        if (incrementableItem == null)
            AddOrderItem(newItem);
        else
            incrementableItem.Quantity += newItem.Quantity;
    }

    public OrderItem GetIncrementableItem(string CategoryItemIID, string DistributionIID, string OrderGroupIID)
    {
        return Items.Where(x => x.CategoryItemIID == CategoryItemIID && x.DistributionIID == DistributionIID && x.OrderGroupIID == OrderGroupIID).FirstOrDefault();
    }
    public void IncrementOrderItem(OrderItem oi)
    {
        try
        {
            if (oi != null)
            {
                oi.Quantity++;
                blnItemsChanged = true;
            }                                                                                
        } catch { }
    }

    public void DecrementOrderItem(OrderItem item)
    {
        if (item == null)
            return;

        if (!item.Decrement())
            this.DeleteOrderItem(item);
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

    public string AllOrderItemsTextWithPrice
    {         get
        {
            string str = "";
            foreach (OrderItem item in Items)
            {
                string itemtext = (item.OrderItemText.Length > 13) ? item.OrderItemText.Substring(0, 12) : item.OrderItemText;
                
                str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10) + "{2,5:C2}", item.Quantity, itemtext, item.Total) + "\r\n";
                //else
                //    str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10), item.Quantity, itemtext) + "\r\n";
            }

            return str;
        }
    }
    public string AllOrderItemsTextNoPrice
    {
        get
        {
            string str = "";
            foreach (OrderItem item in Items)
            {
                string itemtext = (item.OrderItemText.Length > 13) ? item.OrderItemText.Substring(0, 12) : item.OrderItemText;

                //str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10) + "{2,5:N2}", item.Quantity, itemtext, item.Total) + "\r\n";

                str += String.Format("{0}".PadRight(4) + "{1,-13}".PadRight(10), item.Quantity, itemtext) + "\r\n";
            }

            return str;
        }
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
                case OrderTypes.TakeAway:
                    return true;
                case OrderTypes.Unknown:
                case OrderTypes.Pad:
                case OrderTypes.Sitin:
                case OrderTypes.Sale:
                    return false;
                default:
                    return false;
            }
        }
    }
}
