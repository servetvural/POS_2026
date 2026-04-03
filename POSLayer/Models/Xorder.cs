using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class XOrder : BaseOrder
{
    //public string? TableIID { get; set; } = string.Empty;
    //public string? TableName { get; set; } = string.Empty;
    //public DateTime OrderDate { get; set; } = DateTime.Now;
    //public int Covers { get; set; } = 1;
    //public OrderTypes OrderType { get; set; } = OrderTypes.InHouse;
    //public PaymentMethods Payment { get; set; }
    //public string? SessionIID { get; set; } = string.Empty;
    //public StatusFlags Status { get; set; } = StatusFlags.NEW;
    //public string? LockedClientIP { get; set; } = string.Empty;
    //public string Instruction { get; set; } = string.Empty;
    //public double MoneyPaid { get; set; }
    //public string? PaymentFlag { get; set; } = string.Empty;
    //public string? Reference { get; set; } = string.Empty;
    //public double ServiceChargeRate { get; set; }
    //public double ServiceChargeTaxRate { get; set; }

    //public string? Waiter { get; set; }


    //public List<XOrderItem> items { get; set; } = new List<XOrderItem>();

    //public string? CustomerIID { get; set; } = string.Empty;
    //public Customer Customer { get; set; } // Navigation property



    //[NotMapped]
    //public string Title { get; set; } = string.Empty;

    //[NotMapped]
    //public bool blnPrinted { get; set; }
    //[NotMapped]
    //public int RequestCount { get; set; }
    //[NotMapped]
    //public bool blnItemsChanged { get; set; }

}
