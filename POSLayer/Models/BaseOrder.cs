using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Pkcs;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class BaseOrder : BaseClass
{
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string? SessionIID { get; set; }
    public Session? Session { get; set; }

    public string? TableIID { get; set; }
    public virtual Masa? Table { get; set; }


    public string? CustomerIID { get; set; }
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

    public string? PaymentFlag { get; set; } = string.Empty;
    public string? Reference { get; set; } = string.Empty;
    public double ServiceChargeRate { get; set; }
    public double ServiceChargeTaxRate { get; set; }



    public virtual List<BaseOrderItem> Items { get; set; } = new();

    [NotMapped]
    public string Title { get; set; } = string.Empty;

    [NotMapped]
    public bool blnPrinted { get; set; }
    [NotMapped]
    public int RequestCount { get; set; }
    [NotMapped]
    public bool blnItemsChanged { get; set; }




    public double ItemTotal => Items.Sum(x => x.Total);
    public double ItemTotalVat => Items.Sum(x => x.TotalVat);
    public double ItemTotalExVat => Items.Sum(x => x.TotalExVat);
    public double ServiceCharge => ItemTotalExVat * ServiceChargeRate / 100;
    public double ServiceChargeTax => ServiceCharge * ServiceChargeTaxRate / 100;

    public double Total => ItemTotal + ServiceCharge;
    public double MoneyPaid { get; set; }
    public double Balance => Total - MoneyPaid;
    public bool isPaid => Total > 0 && Balance == 0;


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
