

using POSLayer.Library;

namespace POSLayer.Models;

public partial class OrderItem   : BaseOrderItem
{
    public OrderItem()
    {
    }

    public OrderItem(string OrderIID,  string OrderGroupIID,
    double Quantity, double SizeButtonOrEntityButtonPrice, string CategoryItemIID, string OrderItemText,
     string distributioniid, OrderItemTypes ItemType, int DOrder,
       int CategoryDisplayOrder, double TaxPercent)
    {
        this.OrderIID = OrderIID;
        this.OrderItemText = OrderItemText;
        this.Quantity = Quantity;
        this.Price = SizeButtonOrEntityButtonPrice;
        this.OrderGroupIID = OrderGroupIID;

        this.CategoryItemIID = CategoryItemIID;
        this.DistributionIID = distributioniid;
        this.ItemType = ItemType;
        this.DOrder = DOrder;

        this.CategoryDisplayOrder = CategoryDisplayOrder;
        this.TaxPercent = TaxPercent;
    }

    public XOrderItem ToXOrderItem()
    {
        XOrderItem xItem = new XOrderItem()
        {
            IID = this.IID,
            DOrder = this.DOrder,
            OrderIID = this.OrderIID,
            CategoryItemIID = this.CategoryItemIID,
            DistributionIID = this.DistributionIID,
            CategoryDisplayOrder = this.CategoryDisplayOrder,
            OrderItemText = this.OrderItemText,
            Quantity = this.Quantity,
            Price = this.Price,
            OrderGroupIID = this.OrderGroupIID,
            ItemType = this.ItemType,
            TaxPercent = this.TaxPercent,
            CompletedQuantity = this.CompletedQuantity
        };
        return xItem;
    }

    public OrderItem Clone(bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(this.OrderIID, 
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.CategoryItemIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.DOrder,  this.CategoryDisplayOrder,
            this.TaxPercent);
        oi.CompletedQuantity = this.CompletedQuantity;
        return oi;
    }
    public OrderItem Duplicate(string newParentOrderIID, bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(newParentOrderIID, 
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.CategoryItemIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.DOrder,  this.CategoryDisplayOrder,
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
