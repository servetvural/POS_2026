using POSLayer.Library;

namespace POSLayer.Models;

public partial class OrderItem   : BaseClass
{
    public string EntityIID { get; set; } = null!;
    public string? EntityName { get; set; }
    public int EntityDisplayOrder { get; set; }
    public string? OrderItemText { get; set; }
    public double Quantity { get; set; } = 1;
    public double Price { get; set; }
    public string? OrderGroupIID { get; set; }
    public string? EntityButtonIID { get; set; }
    public string? DistributionIID { get; set; }
   
    public OrderItemTypes ItemType { get; set; } = OrderItemTypes.NormalOrderItem;
    public double TaxPercent { get; set; }
    public double CompletedQuantity { get; set; }

    public string OrderIID { get; set; }
    public Order Order { get; set; } // Navigation Property

    public double CalculatedValue => Math.Round( CalculatedExVat + CalculatedVat,2); 
    public double CalculatedVat=> Math.Round( (Quantity * Price * TaxPercent) / (100 + TaxPercent),2);          
    public double CalculatedExVat => Math.Round( (Quantity * Price ) - ( Quantity * Price * TaxPercent) / (100 + TaxPercent),2);
       

    public OrderItem()
    {                 
    }

    public OrderItem(string OrderIID, string EntityIID, string OrderGroupIID,
    double Quantity, double SizeButtonOrEntityButtonPrice, string EntityButtonIID, string OrderItemText,
     string distributioniid, OrderItemTypes ItemType, int dorder,
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
        this.dorder = dorder;

        this.EntityName = EntityName;
        this.EntityDisplayOrder = EntityDisplayOrder;
        this.TaxPercent = TaxPercent;
    }

    public OrderItem Clone(bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(this.OrderIID, this.EntityIID,
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.EntityButtonIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.dorder, this.EntityName, this.EntityDisplayOrder,
            this.TaxPercent);
        oi.CompletedQuantity = this.CompletedQuantity;
        return oi;
    }
    public OrderItem Duplicate(string newParentOrderIID, bool blnNewGroup)
    {
        OrderItem oi = new OrderItem(newParentOrderIID, this.EntityIID,
             blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
             this.Price, this.EntityButtonIID, this.OrderItemText,
             this.DistributionIID, this.ItemType, this.dorder, this.EntityName, this.EntityDisplayOrder,
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
    public string ToSimpleString()
    {
        return Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(25, ' ') +
            Price.ToString("N2").PadLeft(10, ' ') + CalculatedValue.ToString("N2").PadLeft(10, ' ');
    }
}
