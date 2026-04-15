

using POSLayer.Library;

namespace POSLayer.Models;

public partial class OrderItem   : BaseClass
{

    public string? OrderIID { get; set; }
    public Order? Order { get; set; } // Navigation Property

    public string? CategoryItemIID { get; set; }
    public CategoryItem? CategoryItem { get; set; }


    public string? DistributionIID { get; set; }

    public Distribution? Distribution { get; set; }

    public int CategoryDisplayOrder { get; set; }
    public string? OrderItemText { get; set; }
    public double Quantity { get; set; } = 1;
    public double Price { get; set; }
    public string? OrderGroupIID { get; set; }



    public OrderItemTypes ItemType { get; set; } = OrderItemTypes.NormalOrderItem;
    public double TaxPercent { get; set; }
    public double CompletedQuantity { get; set; }


    public double Total => Math.Round(TotalExVat + TotalVat, 2);
    public double TotalVat => Math.Round((Quantity * Price * TaxPercent) / (100 + TaxPercent), 2);
    public double TotalExVat => Math.Round((Quantity * Price) - (Quantity * Price * TaxPercent) / (100 + TaxPercent), 2);



    public string ToSimpleString()
    {
        return Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(25, ' ') +
            Price.ToString("N2").PadLeft(10, ' ') + Total.ToString("N2").PadLeft(10, ' ');
    }


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
