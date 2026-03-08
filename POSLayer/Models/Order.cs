using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Order  : BaseClass
{
    public string? TableIID { get; set; }

    public string? TableName { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? Covers { get; set; }

    public OrderTypes OrderType { get; set; }

    public PaymentMethods Payment { get; set; }

    public string? CustomerIID { get; set; }

    public string? SessionIID { get; set; }

    public StatusFlags Status { get; set; }

    public string? LockedClientIp { get; set; }

    public string Instruction { get; set; } = null!;

    public decimal MoneyPaid { get; set; }

    public string? PaymentFlag { get; set; }

    public string? Cname { get; set; }

    public string? Postcode { get; set; }

    public string? Address { get; set; }

    public string? Buzzer { get; set; }

    public string? Town { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? UserName { get; set; }

    public string? Reference { get; set; }

    public double ServiceChargeRate { get; set; }

    public double ServiceChargeTaxRate { get; set; }
}
