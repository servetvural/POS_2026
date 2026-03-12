using System;
using System.Collections.Generic;
using System.Xml;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class OrderItem   : BaseClass
{
    public string EntityIID { get; set; } = null!;

    public string? EntityName { get; set; }

    public int EntityDisplayOrder { get; set; }

    public string? OrderItemText { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public string? OrderGroupIID { get; set; }

    public string? EntityButtonIID { get; set; }

    public string? DistributionIID { get; set; }

    public string? ParentOrderIID { get; set; }

    public OrderItemTypes ItemType { get; set; }

    public int DisplayOrder { get; set; }

    public double TaxPercent { get; set; }

    public double CompletedQuantity { get; set; }

    public double TaxValue
    {
        get
        {
            return (float)Math.Round((Quantity * Price * TaxPercent) / (100 + TaxPercent), 2);
        }
    }
    public double Total { get { return Price * Quantity; } }


    public OrderItem()
    {
        ParentOrderIID = "";
        EntityIID = "";
        OrderItemText = "";

        Quantity = 1;

        Price = 0f;
        OrderGroupIID = "";    //each pizza is belong to a single group
        EntityButtonIID = "";                               //identify mushroom, cactus etc

        DistributionIID = "";
        ItemType = OrderItemTypes.NormalOrderItem;

        EntityName = "";
    }

    public OrderItem(string ParentOrderIID, string EntityIID, string OrderGroupIID,
    double Quantity, double SizeButtonOrEntityButtonPrice, string EntityButtonIID, string OrderItemText,
     string distributioniid, OrderItemTypes ItemType, int dorder,
       string EntityName, int EntityDisplayOrder, double TaxPercent)
    {

        this.ParentOrderIID = ParentOrderIID;
        this.EntityIID = EntityIID;
        this.OrderItemText = OrderItemText;
        this.Quantity = Quantity;
        this.Price = SizeButtonOrEntityButtonPrice;
        this.OrderGroupIID = OrderGroupIID;

        this.EntityButtonIID = EntityButtonIID;
        this.DistributionIID = distributioniid;
        this.ItemType = ItemType;
        this.DisplayOrder = dorder;

        this.EntityName = EntityName;
        this.EntityDisplayOrder = EntityDisplayOrder;
        this.TaxPercent = TaxPercent;

    }

    public OrderItem Clone(bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(this.ParentOrderIID, this.EntityIID,
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.EntityButtonIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.DisplayOrder, this.EntityName, this.EntityDisplayOrder,
            this.TaxPercent);
        oi.CompletedQuantity = this.CompletedQuantity;
        return oi;
    }
    public OrderItem Duplicate(string newParentOrderIID, bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(newParentOrderIID, this.EntityIID,
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.EntityButtonIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.DisplayOrder, this.EntityName, this.EntityDisplayOrder,
            this.TaxPercent);
        oi.CompletedQuantity = this.CompletedQuantity;
        return oi;
    }
    public void Increment()
    {
        this.Quantity++;
    }
    public bool Decrement()
    {
        if (this.Quantity > 1)
        {
            this.Quantity--;
            return true;
        } else
            return false;
    }
    public bool Decrement(int howmany)
    {
        if (howmany > this.Quantity)
            return false;
        if (howmany <= this.Quantity)
        {
            this.Quantity -= howmany;
            return true;
        }
        return false;
    }

    //public override string ToString()
    //{
    //    return JsonConvert.SerializeObject(this, Formatting.Indented);
    //}
    public string ToSimpleString()
    {
        return Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(25, ' ') +
            Price.ToString("N2").PadLeft(10, ' ') + Total.ToString("N2").PadLeft(10, ' ');
    }
}
