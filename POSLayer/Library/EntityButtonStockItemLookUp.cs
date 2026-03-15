using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Models;

namespace POSLayer.Library;

public partial class EntityButtonStockItemLookUp : BaseClass
{

    public string EntityButtonIID { get; set; } = null!;

    public string StockItemIID { get; set; } = null!;

    public QuantityTypes QuantityType { get; set; }

    public double Quantity { get; set; }
    public int DisplayOrder { get; set; }
    public string Comment { get; set; } = string.Empty;

    [NotMapped]
    public string StockName { get; set; }
    [NotMapped]
    public string QuantityTypeAsString { get; set; }

    public EntityButtonStockItemLookUp()
    {

    }

    public EntityButtonStockItemLookUp(string IID, string EntityButtonIID, string StockItemIID, QuantityTypes QuantityType, float Quantity, int DisplayOrder, string Comment)
    {
        this.IID = IID;
        this.EntityButtonIID = EntityButtonIID;
        this.StockItemIID = StockItemIID;
        this.QuantityType = QuantityType;
        this.Quantity = Quantity;
        this.DisplayOrder = DisplayOrder;
        this.Comment = Comment;
    }
    public EntityButtonStockItemLookUp(string IID, string EntityButtonIID, string StockItemIID, int QuantityType, float Quantity, int DisplayOrder, string Comment)
    {
        this.IID = IID;
        this.EntityButtonIID = EntityButtonIID;
        this.StockItemIID = StockItemIID;
        this.QuantityType = (QuantityTypes)QuantityType;
        this.Quantity = Quantity;
        this.DisplayOrder = DisplayOrder;
        this.Comment = Comment;
    }

    public EntityButtonStockItemLookUp Duplicate(string DuplicateEntityButtonIID)
    {
        return  new EntityButtonStockItemLookUp()
        {
            EntityButtonIID = DuplicateEntityButtonIID,
            StockItemIID = StockItemIID,
            QuantityType = (QuantityTypes)QuantityType,
            Quantity = Quantity,
            DisplayOrder = DisplayOrder,
            Comment = Comment,
        };
    }
}
