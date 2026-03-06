using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class EntityButton
{
    public string Iid { get; set; } = null!;

    public string? EntityButtonName { get; set; }

    public int DisplayOrder { get; set; }

    public int? ButtonColor { get; set; }

    public int? ForeColor { get; set; }

    public int? ButtonType { get; set; }

    public int? AvailableFor { get; set; }

    public string? ParentEntityIid { get; set; }

    public string? ParentMenuIid { get; set; }

    public int Compulsary { get; set; }

    public string? Barcode { get; set; }

    public double DirectSaleTaxPercent { get; set; }

    public double InHouseTaxPercent { get; set; }

    public double TakeAwayTaxPercent { get; set; }

    public double DeliveryTaxPercent { get; set; }

    public int PadFlag { get; set; }

    public double DirectSalePrice { get; set; }

    public double InHousePrice { get; set; }

    public double TakeAwayPrice { get; set; }

    public double DeliveryPrice { get; set; }

    public int ButtonWidth { get; set; }

    public int ButtonHeight { get; set; }

    public string Ffamily { get; set; } = null!;

    public double Fsize { get; set; }

    public string Fstyle { get; set; } = null!;

    public string DistributionIid { get; set; } = null!;

    public int WithImage { get; set; }
}
