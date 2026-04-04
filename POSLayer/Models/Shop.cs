using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace POSLayer.Models;

public partial class Shop    : BaseClass 
{
    #region 10.Shop Details

    public string ShopName { get; set; } = "New Shop";
    public string Address { get; set; } = string.Empty;
    public string Tel { get; set; } = string.Empty;
    public string Vat { get; set; } = string.Empty;
    public string PurchaseEmail { get; set; } = string.Empty;
    public string OrdersEmail { get; set; } = string.Empty;
    public string ReportEmail { get; set; } = string.Empty;
    public string NotificationEmail { get; set; } = string.Empty;

    #endregion


    #region 11.Miscellaneous        
    public string? CurrentSessionIID { get; set; }

    //public DateTime SessionStartDateTime { get; set; } = DateTime.Now;

   //Text of the button which opens the cash drawer if any attached
    public string VoidText { get; set; } = "VOID";

    //Default tax rate for newly created categories in the menu
    public double DefaultTaxRate { get; set; } = 0.0f;

    //Service Charge Rate for each order
    public double ServiceChargeRate { get; set; } = 0.0f;

    //Tax rate of the Service Charge
    public double ServiceChargeTaxRate { get; set; } = 0.0f;

    #endregion



    #region HEADER FOOTER 12.Texts
    public string ReceiptHeader { get; set; } = string.Empty;
    public string ReceiptFooter { get; set; } = string.Empty;

    public string KitchenHeader { get; set; } = string.Empty;
    public string KitchenFooter { get; set; } = string.Empty;


    public string ReportHeader { get; set; } = string.Empty;
    public string ReportFooter { get; set; } = string.Empty;
    #endregion


    #region SMTP 
    public string SmtpServer { get; set; } = string.Empty;
    public string SmtpEmailAddress { get; set; } = string.Empty;
    public string SmtpFromLabel { get; set; } = string.Empty;
    public string SmtpAccountName { get; set; } = string.Empty;
    public string SmtpPassword { get; set; } = string.Empty;
    #endregion


    public DateTime KitchenModified { get; set; }

   

 

  
   



  
}
