using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class XOrderItem : BaseClass
{
    public string? OrderIID { get; set; }
    public XOrder? Order { get; set; } // Navigation Property

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

    public OrderItem ToOrderItem()
    {
        OrderItem Item = new OrderItem()
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
        return Item;
    }
}
