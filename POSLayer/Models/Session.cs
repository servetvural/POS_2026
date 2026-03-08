using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Session      : BaseClass
{
    public DateTime StartDate { get; set; }

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

    public double X1total { get; set; }

    public double X2total { get; set; }

    public double X3total { get; set; }
}
