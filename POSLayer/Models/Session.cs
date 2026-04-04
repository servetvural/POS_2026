using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSLayer.Models;

public partial class Session      : BaseClass
{
    public string? ShopIID { get; set; }
    public Shop? Shop { get; set; }


    public DateTime StartDate { get; set; } = DateTime.Now;

    public DateTime? EndDate { get; set; }

    public double GrossSessionTotal { get; set; }

    public double Peny1 { get; set; }

    public double Peny2 { get; set; }

    public double Peny5 { get; set; }

    public double Peny10 { get; set; }

    public double Peny20 { get; set; }

    public double Peny50 { get; set; }

    public double Pound1 { get; set; }

    public double Pound2 { get; set; }

    public double Pound5 { get; set; }

    public double Pound10 { get; set; }

    public double Pound20 { get; set; }

    public double Pound50 { get; set; }

    public double Pound100 { get; set; }

    public double Pound200 { get; set; }

    public double Pound500 { get; set; }

    public double Pound1000 { get; set; }

    public double CashTotal { get; set; }

    public double CardTotal { get; set; }

    public double OnlineTotal { get; set; }

    public double X1Total { get; set; }

    public double X2Total { get; set; }

    public double X3Total { get; set; }

    public List<Order> Orders { get; set; } = new();

    public double Total => Orders.Sum(x => x.Total);



    //public double UnCompletedOrdersCalculatedValue => 
    [NotMapped]
    public double GrossSessionTotalUncompleted { get; set; }

}
