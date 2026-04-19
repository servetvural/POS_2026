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

    public string? LockedClientIP { get; set; } 

    public DateTime? LockedUntil { get; set; }

    //public string? OrderIID { get; set; }

    //public virtual Order? Order { get; set; }

    public ButtonShapeTypes Shape { get; set; }
    public int XLocation { get; set; }

    public int YLocation { get; set; }

    public int Width { get; set; } = 150;

    public int Height { get; set; } = 50;

    public string? SalonIID { get; set; }

    public string? DefaultName { get; set; } = "Table ?";

    [NotMapped]
    public string KitchenOrderNumber { get; set; }

    //[NotMapped]
    // public Order AttachedOrder { get; set; }

    public List<Order> orders { get; set; } = new();

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
           SalonIID = SalonIID,
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

    public bool HasActiveOrder=> orders.Any(x => x.Status == StatusFlags.Done);
    public Order AttachedOrder=> orders.FirstOrDefault(x => x.Status == StatusFlags.New || x.Status == StatusFlags.Done);
   
}
