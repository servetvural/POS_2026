using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Table : BaseClass
{
    public int Number { get; set; }

    public string TableName { get; set; } = "Table ?";

    public int TableCovers { get; set; } = 1;

    public string LockedClientIP { get; set; } = string.Empty;

    public string CurrentOrderIID { get; set; } = string.Empty;

    public TableTypes TableType { get; set; } = TableTypes.TemporaryTable;
    public int DisplayOrder { get; set; }
    public int XLocation { get; set; }

    public int YLocation { get; set; }

    public int Width { get; set; } = 150;

    public int Height { get; set; } = 50;

    public string? GroupIID { get; set; } = "0";

    public string? ParentTableIID { get; set; }

    public ButtonShapeTypes Shape { get; set; }

    public string? DefaultName { get; set; } = "Table ?";
    public bool isPrimary { get { return TableType == TableTypes.StaticTable; } }

    [NotMapped]
    public string KitchenOrderNumber { get; set; }

    [NotMapped]
    public Order AttachedOrder { get; set; }


    public Table Clone()
    {
       return new Table() {
            IID = IID,
            TableName = TableName,
            TableCovers = TableCovers,
            TableType = TableType,
            LockedClientIP = LockedClientIP,
            CurrentOrderIID = CurrentOrderIID,
           XLocation = XLocation,
           YLocation = YLocation,
            Width = Width,
            Height = Height,
            GroupIID = GroupIID,
            ParentTableIID = ParentTableIID,
            Shape = Shape,
        };
    }

    public Table CreateSubTable()
    {
        return new Table()
        {
            ParentTableIID = IID,
            TableCovers = TableCovers,
            TableType = TableTypes.TemporaryTable,
            TableName = TableName,
            Shape = Shape
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
        if (string.IsNullOrEmpty(this.CurrentOrderIID))
            return false;
        else
            return true;
    }
    public void AttachOrder(Order order)
    {
        this.AttachedOrder = order;
    }
    public void DetachOrder()
    {
        this.AttachedOrder = null;
    }

}
