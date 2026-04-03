using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class KitchenOrderItem : BaseClass
{

    public string KitchenOrderIID { get; set; } = null!;
    public KitchenOrder KitchenOrder { get; set; } // Navigation Property

    public int Quantity { get; set; }

    public string ItemText { get; set; } = null!;

   

    public string DistributionIID { get; set; } = null!;

    public string EntityButtonIID { get; set; } = null!;

    public KitchenOrderStatusTypes Status { get; set; }



    /// <summary>
    /// This property not need to be saved it is used for when sending order to the kitchen 
    /// to prevent over quantity manipulation
    /// </summary>
    [NotMapped]
    public ModificationFlag Modified { get; set; } = ModificationFlag.None;
    /// <summary>
    /// This property not need to be saved it is used for when sending order to the kitchen 
    /// to prevent over quantity manipulation
    /// </summary>
    [NotMapped]
    public int ModifiedQuantity { get; set; }

    public KitchenOrderItem()
    {
    }
}
