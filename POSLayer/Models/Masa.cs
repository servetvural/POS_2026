using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Masa : BaseClass
{
    public int Number { get; set; }

    public string TableName { get; set; } = "Table ?";

    public int TableCovers { get; set; } = 1;

    public string LockedClientIP { get; set; } = string.Empty;

    //public string? OrderIID { get; set; }
    
    public virtual Order? Order { get; set; }


    public int XLocation { get; set; }

    public int YLocation { get; set; }

    public int Width { get; set; } = 150;

    public int Height { get; set; } = 50;

    public string? GroupIID { get; set; }

    public string? DefaultName { get; set; } = "Table ?";

    [NotMapped]
    public string KitchenOrderNumber { get; set; }

    [NotMapped]
    public Order AttachedOrder { get; set; }


    public Masa Clone()
    {
       return new Masa() {
            IID = IID,
            Number = Number,
            TableCovers = TableCovers,
            LockedClientIP = LockedClientIP,
           XLocation = XLocation,
           YLocation = YLocation,
            Width = Width,
            Height = Height,
            GroupIID = GroupIID,
        };
    }

    public bool IsBusy(string ClientIP)
    {
        if (string.IsNullOrEmpty(this.LockedClientIP))
            return false;
        else
        {
            if (this.LockedClientIP == ClientIP)
                return false;
            else
                return true;
        }
    }

    public bool HasActiveOrder()
    {
        return Order != null;
    }
    public void AttachOrder(Order order)
    {
        Order = order;
    }
    public void DetachOrder()
    {
        Order = null;
    }

}
