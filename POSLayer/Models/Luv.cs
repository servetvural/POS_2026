using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace POSLayer.Models;

public partial class Luv    : BaseClass 
{
    #region 10.Shop Details

    [CategoryAttribute("10.Shop Details"), DisplayName("Name of this shop")]
    public string ShopName { get; set; } = "New Shop";

    [CategoryAttribute("10.Shop Details"), DisplayName("Address of this shop")]
    public string ShopAddress { get; set; } = string.Empty;

    [CategoryAttribute("10.Shop Details"), DisplayName("Phone number")]
    public string Tel1 { get; set; } = string.Empty;
    [CategoryAttribute("10.Shop Details"), DisplayName("Phone number")]
    public string Tel2 { get; set; } = string.Empty;
    [CategoryAttribute("10.Shop Details"), DisplayName("Fax number")]
    public string Fax { get; set; } = string.Empty;
    [CategoryAttribute("10.Shop Details"), DisplayName("Tax number")]
    public string Vat { get; set; } = string.Empty;


    [CategoryAttribute("10.Shop Details"), DisplayName("Purchase related email address")]
    public string PurchaseEmail { get; set; } = string.Empty;
    [CategoryAttribute("10.Shop Details"), DisplayName("Orders related email address")]
    public string OrdersEmail { get; set; } = string.Empty;
    [CategoryAttribute("10.Shop Details"), DisplayName("Report related email address")]
    public string ReportEmail { get; set; } = string.Empty;
    [CategoryAttribute("10.Shop Details"), DisplayName("General notification email address")]
    public string NotificationEmail { get; set; } = string.Empty;

    #endregion


    #region 11.Miscellaneous
    [CategoryAttribute("11.Miscellaneous"), ReadOnlyAttribute(true), DisplayName("Unique ID for the current session")]
    public string CurrentSessionIID { get; set; }

    [CategoryAttribute("11.Miscellaneous"), ReadOnlyAttribute(true), DisplayName("Current session's start date and time")]
    public DateTime SessionStartDateTime { get; set; } = DateTime.Now;

    [CategoryAttribute("11.Miscellaneous"), DisplayName("Text of the button which opens the cash drawer if any attached")]
    public string VoidText { get; set; } = "VOID";

    [CategoryAttribute("11.Miscellaneous"), DisplayName("Default tax rate for newly created categories in the menu")]
    public double DefaultTaxRate { get; set; } = 0.0f;

    [CategoryAttribute("11.Miscellaneous"), DisplayName("Service Charge Rate"), DescriptionAttribute("Service Charge Rate for each order"), DefaultValue(0.0f)]
    public double ServiceChargeRate { get; set; } = 0.0f;

    [CategoryAttribute("11.Miscellaneous"), DisplayName("Service Charge Tax Rate"), DescriptionAttribute("Tax rate of the Service Charge"), DefaultValue(0.0f)]
    public double ServiceChargeTaxRate { get; set; } = 0.0f;

    #endregion



    #region HEADER FOOTER 12.Texts
    [CategoryAttribute("12.Texts"), DisplayName("Header text for the receipts")]
    public string ReceiptHeader { get; set; } = string.Empty;
    [CategoryAttribute("12.Texts"), DisplayName("Foor text for the receipts")]
    public string ReceiptFooter { get; set; } = string.Empty;

    [CategoryAttribute("12.Texts"), DisplayName("Header text for kitchen slips")]
    public string KitchenHeader { get; set; } = string.Empty;
    [CategoryAttribute("12.Texts"), DisplayName("Footer text for kitchen slips")]
    public string KitchenFooter { get; set; } = string.Empty;


    [CategoryAttribute("12.Texts"),DisplayName("Header text for daily report")]
    public string ReportHeader { get; set; } = string.Empty;
    [CategoryAttribute("12.Texts"), DisplayName("Footer text for daily report")]
    public string ReportFooter { get; set; } = string.Empty;
    #endregion


    #region SMTP 
    [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp Server IP Address or Domain Name"), DisplayName("Outgoing email server web address")]
    public string SmtpServer { get; set; } = string.Empty;
    [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp From Email")]
    public string SmtpEmailAddress { get; set; } = string.Empty;
    [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp From Label")]
    public string SmtpFromLabel { get; set; } = string.Empty;
    [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Probably the email address of the smtp user")]
    public string SmtpAccountName { get; set; } = string.Empty;
    [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp Password"), PasswordPropertyText(true)]
    public string SmtpPassword { get; set; } = string.Empty;
    #endregion



    [Browsable(false)]
    public string CustomerKey { get; set; } = string.Empty;
    [Browsable(false)]
    public string CustomerPassword { get; set; } = string.Empty;


    public int MdfFileVersion { get; set; }

    public DateTime KitchenModified { get; set; }

   

 

  
   



  
}
