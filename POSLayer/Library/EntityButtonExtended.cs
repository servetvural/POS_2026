using System.Drawing;

using POSLayer.Models;

namespace POSLayer.Library;

[System.Serializable]
public class EntityButtonExtended :BaseClass
{
    public string EntityButtonName { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public int ButtonColor { get; set; } = SystemColors.Control.ToArgb();
    public int ForeColor { get; set; } = Color.Black.ToArgb();
    public CategoryItemTypes ButtonType { get; set; } = CategoryItemTypes.SimpleItem;
    public int AvailableFor { get; set; } = (int)AvailabilityTypes.All;
    public string PEIID { get; set; }      =string.Empty;
    public string ParentMenuIID { get; set; }
    public int Compulsary { get; set; }
    public string Barcode { get; set; }   = string.Empty;
    public float DirectSaleTaxPercent { get; set; }
    public float InHouseTaxPercent { get; set; }
    public float TakeAwayTaxPercent { get; set; }
    public float DeliveryTaxPercent { get; set; }
    public PadFlags PadFlag { get; set; } = PadFlags.EBOnly;

    public string DistributionIID { get; set; }   = string.Empty;

    public float DirectSalePrice { get; set; }
    public float InHousePrice { get; set; }
    public float TakeAwayPrice { get; set; }
    public float DeliveryPrice { get; set; }

    public int ButtonWidth { get; set; } = 50;
    public int ButtonHeight { get; set; } = 50;

    public string FFamily { get; set; } = "Arial";
    public float FSize { get; set; } = 10;
    public string FStyle { get; set; } = "Regular";

    public string Font { get { return FFamily + " " + FSize + " " + FStyle; } }
    public bool WithImage { get; set; }

    public string DistributionName { get; set; }

    public byte[] DisplayImage { get; set; }
}
