using POSLayer.Models;

namespace POSLayer.Library;

public class ShopWrapper
{
    private Shop _shop;
    public ShopWrapper(Shop shop)
    {
        _shop = shop;
    }

    public string Address { get => _shop.Address; set => _shop.Address = value; }
    public string Tel { get => _shop.Tel; set => _shop.Tel = value; }
    public string TaxNumber { get => _shop.TaxNumber; set => _shop.TaxNumber = value; }
    public string PurchaseEmail { get => _shop.PurchaseEmail; set => _shop.PurchaseEmail = value; }
    public string OrdersEmail { get => _shop.OrdersEmail; set => _shop.OrdersEmail = value; }
    public string ReportEmail { get => _shop.ReportEmail; set => _shop.ReportEmail = value; }
    public string NotificationEmail { get => _shop.NotificationEmail; set => _shop.NotificationEmail = value; }

   // public string? CurrentSessionIID  => _shop.CurrentSessionIID;
    private Session? CurrentSession => _shop.CurrentSession;

    public string CurrentSessionData { get
        {
            if (CurrentSession != null)
            {
                return $"Started @ {CurrentSession.StartDate.ToString("dd dddd MMMM yyyy HH:mm:ss")} "; //, Gross Total: {CurrentSession.GrossSessionTotalDynamic}, Balance: {CurrentSession.BalanceDynamic}";

            } else
            {
                return "No active session";
            }
        } 
    }

    public string BonusPlan => _shop?.Bonus?.PlanName ?? "";
    public string CashDrawerText { get => _shop.CashDrawerText; set => _shop.CashDrawerText = value; }
    public double DefaultTaxRate { get => _shop.DefaultTaxRate; set => _shop.DefaultTaxRate = value; }
    public double ServiceChargeRate { get => _shop.ServiceChargeRate; set => _shop.ServiceChargeRate = value; }
    public double ServiceChargeTaxRate { get => _shop.ServiceChargeTaxRate; set => _shop.ServiceChargeTaxRate = value; }


    public string ReceiptHeader { get => _shop.ReceiptHeader; set => _shop.ReceiptHeader = value; }
    public string ReceiptFooter { get => _shop.ReceiptFooter; set => _shop.ReceiptFooter = value; }
    public string KitchenHeader { get => _shop.KitchenHeader; set => _shop.KitchenHeader = value; }
    public string KitchenFooter { get => _shop.KitchenFooter; set => _shop.KitchenFooter = value; }

    public string ReportHeader { get => _shop.ReportHeader; set => _shop.ReportHeader = value; }
    public string ReportFooter { get => _shop.ReportFooter; set => _shop.ReportFooter = value; }

    public string SmtpServer { get => _shop.SmtpServer; set => _shop.SmtpServer = value; }
    public string SmtpEmailAddress { get => _shop.SmtpEmailAddress; set => _shop.SmtpEmailAddress = value; }
    public string SmtpFromLabel { get => _shop.SmtpFromLabel; set => _shop.SmtpFromLabel = value; }
    public string SmtpAccountName { get => _shop.SmtpAccountName; set => _shop.SmtpAccountName = value; }
    public string SmtpPassword { get => _shop.SmtpPassword; set => _shop.SmtpPassword = value; }


    public DateTime KitchenModified   => _shop.KitchenModified; 
}
