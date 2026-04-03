using System.ComponentModel.DataAnnotations.Schema;
using POSLayer.Library;

namespace POSLayer.Models;

public partial class BaseOrder  : BaseClass
{
    public string? SessionIID { get; set; }
    public Session? Session { get; set; }
    public string? TableIID { get; set; } 
    public Table? Table { get; set; }
    public string? CustomerIID { get; set; } = string.Empty;
    public Customer? Customer { get; set; } // Navigation property
    public string? UserIID { get; set; }
    public User? User { get; set; } // Navigation property
    public DateTime LastModified { get; set; } = DateTime.Now;
    public int Covers { get; set; } = 1;
    public OrderTypes OrderType { get; set; } = OrderTypes.InHouse;
    public PaymentMethods Payment { get; set; } = PaymentMethods.NotPaid;  
    public StatusFlags Status { get; set; } = StatusFlags.NEW;
    public string? LockedClientIP { get; set; } 
    public string Instruction { get; set; } = string.Empty;
    public double MoneyPaid { get; set; }
    public string? PaymentFlag { get; set; }   = string.Empty;   
    public string? Reference { get; set; }   = string.Empty;
    public double ServiceChargeRate { get; set; }
    public double ServiceChargeTaxRate { get; set; }    

    public List<OrderItem> Items { get; set; } = new();

    [NotMapped]
    public string Title { get; set; } = string.Empty;

    [NotMapped]
    public bool blnPrinted { get; set; }
    [NotMapped]
    public int RequestCount { get; set; }
    [NotMapped]
    public bool blnItemsChanged { get; set; }


    
    public double Total=> CalculatedValue + ServiceCharge;
    public double CalculatedValue => Items.Sum(x => x.CalculatedValue);
    public double CalculatedVat  => Items.Sum(x => x.CalculatedVat);
    public double CalculatedExVat   => Items.Sum(x => x.CalculatedExVat);
    public double ServiceCharge   =>CalculatedExVat * ServiceChargeRate / 100;
    public double GetServiceChargeTax=> ServiceCharge * ServiceChargeTaxRate / 100;


   

    public string ToSimpleString()
    {
        string content = "Orginial ORDER @   " + LastModified.ToString() + "   Total= " + Total.ToString("N2").PadLeft(10, ' ') + "   Reference = " + Reference + Environment.NewLine;
        foreach (var item in Items)
        {
            content += "  " + item.ToSimpleString() + Environment.NewLine;
        }
        return content;
    }
}
