using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using POSLayer.Models;

namespace POSLayer.Library;

[System.Serializable]
public class SessionData
{
    public string SessionIID { get; set; }
    public DateTime SessionStartDateTime { get; set; }
    public DateTime? SessionEndDateTime { get; set; }
    public double GrossSessionTotal { get; set; }
    public double GrossSessionTotalUncompleted { get; set; }

    public double peny1 { get; set; }
    public double peny2 { get; set; }
    public double peny5 { get; set; }
    public double peny10 { get; set; }
    public double peny20 { get; set; }
    public double peny50 { get; set; }
    public double pound1 { get; set; }
    public double pound2 { get; set; }
    public double pound5 { get; set; }
    public double pound10 { get; set; }
    public double pound20 { get; set; }
    public double pound50 { get; set; }
    public double pound100 { get; set; }
    public double pound200 { get; set; }
    public double pound500 { get; set; }
    public double pound1000 { get; set; }
    public double CashTotal { get; set; }
    public double CardTotal { get; set; }
    public double OnlineTotal { get; set; }

    public double X1Total { get; set; }
    public double X2Total { get; set; }
    public double X3Total { get; set; }


    


    //Functional
    public double NetPaidTotal { get { return GrossSessionTotal - GrossSessionTotalUncompleted; } }

    public SessionData()
    {
        SessionIID = ShortGuid.NewGuid().ToString();
        DateTime dtnow = DateTime.Now;
        SessionStartDateTime = dtnow;
        SessionEndDateTime = dtnow;
        GrossSessionTotal = 0f;
    }

    public SessionData(Session session)
    {
        SessionIID = session.IID;
        SessionStartDateTime = session.StartDate;
        SessionEndDateTime = session.EndDate;
        GrossSessionTotal = session.GrossSessionTotal;
        //GrossSessionTotalUncompleted = session


        peny1 = session.Peny1;
        peny2 = session.Peny2;
        peny5 = session.Peny5;
        peny10 = session.Peny10;
        peny20 = session.Peny20;
        peny50 = session.Peny50;
        pound1 = session.Pound1;
        pound2 = session.Pound2;
        pound5 = session.Pound5;
        pound10 = session.Pound10;
        pound20 = session.Pound20;
        pound50 = session.Pound50;
        pound100 = session.Pound100;
        pound200 = session.Pound200;
        pound500 = session.Pound500;
        pound1000 = session.Pound1000;

        CashTotal = session.CashTotal;
        CardTotal = session.CardTotal;
        OnlineTotal = session.OnlineTotal;

        X1Total = session.X1total;
        X2Total = session.X2total;
        X3Total = session.X3total;
    }

}
