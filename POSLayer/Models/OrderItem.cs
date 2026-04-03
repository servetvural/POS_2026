

using POSLayer.Library;

namespace POSLayer.Models;

public partial class OrderItem   : BaseOrderItem
{
    public OrderItem()
    {
    }

    public OrderItem(string OrderIID, string EntityIID, string OrderGroupIID,
    double Quantity, double SizeButtonOrEntityButtonPrice, string EntityButtonIID, string OrderItemText,
     string distributioniid, OrderItemTypes ItemType, int DOrder,
       string EntityName, int EntityDisplayOrder, double TaxPercent)
    {
        this.OrderIID = OrderIID;
        this.EntityIID = EntityIID;
        this.OrderItemText = OrderItemText;
        this.Quantity = Quantity;
        this.Price = SizeButtonOrEntityButtonPrice;
        this.OrderGroupIID = OrderGroupIID;

        this.EntityButtonIID = EntityButtonIID;
        this.DistributionIID = distributioniid;
        this.ItemType = ItemType;
        this.DOrder = DOrder;

        this.EntityName = EntityName;
        this.EntityDisplayOrder = EntityDisplayOrder;
        this.TaxPercent = TaxPercent;
    }

    public OrderItem Clone(bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(this.OrderIID, this.EntityIID,
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.EntityButtonIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.DOrder, this.EntityName, this.EntityDisplayOrder,
            this.TaxPercent);
        oi.CompletedQuantity = this.CompletedQuantity;
        return oi;
    }
    public OrderItem Duplicate(string newParentOrderIID, bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(newParentOrderIID, this.EntityIID,
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.EntityButtonIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.DOrder, this.EntityName, this.EntityDisplayOrder,
            this.TaxPercent);
        oi.CompletedQuantity = this.CompletedQuantity;
        return oi;
    }
    //public void Increment()
    //{
    //    this.Quantity++;
    //}
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
}
