using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class StockItemUsage : BaseClass
{
    public string? StockItemIID { get; set; }
    public StockItem? StockItem { get; set; }
    public string? StockItemName => StockItem?.StockName;

    public string? CategoryItemIID { get; set; }
    public CategoryItem? CategoryItem { get; set; }
    public string? CategoryItemName => CategoryItem?.ItemName;

    //public string? SupplierIID { get; set; }
    //public Supplier? Supplier { get; set; }
    //public string? SupplierName => Supplier?.SupplierName;



    //public QuantityTypes QuantityType { get; set; }



    public double SessionQuantity { get; set; }
    public double XSessionQuantity { get; set; }
    public double PreviousQuantity { get; set; }
    public double TotalQuantity => SessionQuantity + PreviousQuantity + XSessionQuantity;


   // public int Conversion { get; set; }
    public double OrderableQuantity => (int)Math.Floor(OrderableFloatQuantity);
    //public QuantityTypes OrderableType { get; set; }
    public double OrderableFloatQuantity=> TotalQuantity / StockItem.Conversion; 
    //public double BalanceQuantity { get { return TotalQuantity - (OrderableQuantity * Conversion); } }
   

        public string? Comment { get; set; }

    //[NotMapped]
    //public string QuantityTypeAsString { get; set; }
    //[NotMapped]
    //public string OrderableTypeAsString { get; set; }






}
