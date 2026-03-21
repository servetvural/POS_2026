using System;
using System.Collections.Generic;

using POSLayer.Models;

namespace POSLayer.Views;

public partial class XordersView : BaseClass
{
    public string? TableIID { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? Covers { get; set; }

    public int? OrderType { get; set; }

    public int? Payment { get; set; }

    public string? CustomerIID { get; set; }

    public string? SessionIID { get; set; }

    public int? Status { get; set; }

    public string? LockedClientIp { get; set; }

    public string Instruction { get; set; } = null!;

    public decimal MoneyPaid { get; set; }

    public string? TableName { get; set; }

    public string? Cname { get; set; }

    public string? Postcode { get; set; }

    public string? Address { get; set; }

    public string? Buzzer { get; set; }

    public string? Town { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? UserName { get; set; }

    public int? ItemCount { get; set; }

    public string? CustomerDetails { get; set; }

    public string? PaymentFlag { get; set; }

    public string? Reference { get; set; }

    public double? CalculatedValue { get; set; }

    public double? CalculatedVat { get; set; }

    public double? CalculatedExVatValue { get; set; }

    public double? ServiceCharge { get; set; }

    public double? ServiceChargeTax { get; set; }
}
