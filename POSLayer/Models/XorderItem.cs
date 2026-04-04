using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class XOrderItem : BaseOrderItem
{
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
