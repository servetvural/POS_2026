using POSLayer.Library;

namespace POSLayer.Models;

public partial class BaseOrderItem   : BaseClass
{
    public string OrderIID { get; set; }
    public Order Order { get; set; } // Navigation Property


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

   
    public double CalculatedValue => Math.Round( CalculatedExVat + CalculatedVat,2); 
    public double CalculatedVat=> Math.Round( (Quantity * Price * TaxPercent) / (100 + TaxPercent),2);          
    public double CalculatedExVat => Math.Round( (Quantity * Price ) - ( Quantity * Price * TaxPercent) / (100 + TaxPercent),2);
       

    
    public string ToSimpleString()
    {
        return Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(25, ' ') +
            Price.ToString("N2").PadLeft(10, ' ') + CalculatedValue.ToString("N2").PadLeft(10, ' ');
    }
}
