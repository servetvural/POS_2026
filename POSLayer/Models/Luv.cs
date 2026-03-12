using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Luv    : BaseClass 
{
    public string? CurrentSessionIID { get; set; }

    public DateTime? SessionStartDateTime { get; set; }

    public string? KitchenHeader { get; set; }

    public string? KitchenFooter { get; set; }

    public string? ReceiptFooter { get; set; }

    public string? ReportFooter { get; set; }

    public string? ReportHeader { get; set; }

    public string? ReceiptHeader { get; set; }

    public string? VoidText { get; set; }

    public float DefaultTaxRate { get; set; }

    public int MdfFileVersion { get; set; }

    public DateTime KitchenModified { get; set; }

    public string? ShopName { get; set; }

    public string? ShopAddress { get; set; }

    public string? Fax { get; set; }

    public string? Vat { get; set; }

    public string? SmtpServer { get; set; }

    public string? SmtpEmailAddress { get; set; }

    public string? SmtpFromLabel { get; set; }

    public string? SmtpAccountName { get; set; }

    public string? SmtpPassword { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? PurchaseEmail { get; set; }

    public string? OrdersEmail { get; set; }

    public string? ReportEmail { get; set; }

    public string? NotificationEmail { get; set; }

    public string? CustomerKey { get; set; }

    public string? CustomerPassword { get; set; }

    public float ServiceChargeRate { get; set; }

    public float ServiceChargeTaxRate { get; set; }
}
