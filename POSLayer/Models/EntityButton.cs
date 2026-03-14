using System;
using System.Collections.Generic;
using System.Drawing;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class EntityButton : BaseClass
{
    public string? EntityButtonName { get; set; }
    public int DisplayOrder { get; set; }
    public int ButtonColor { get; set; } = SystemColors.Control.ToArgb();
    public int ForeColor { get; set; } = Color.Black.ToArgb();
    public EntityButtonTypes ButtonType { get; set; } = EntityButtonTypes.SimpleItem;
    public int? AvailableFor { get; set; } = (int)AvailabilityTypes.All;
    public string ParentEntityIID { get; set; } = string.Empty;
    public string ParentMenuIID { get; set; } = string.Empty;
    public int Compulsary { get; set; }
    public string Barcode { get; set; } = string.Empty;
    public double DirectSaleTaxPercent { get; set; }
    public double InHouseTaxPercent { get; set; }
    public double TakeAwayTaxPercent { get; set; }
    public double DeliveryTaxPercent { get; set; }
    public PadFlags PadFlag { get; set; } = PadFlags.EBOnly;

    public string DistributionIID { get; set; } = string.Empty;
    public double DirectSalePrice { get; set; }
    public double InHousePrice { get; set; }
    public double TakeAwayPrice { get; set; }
    public double DeliveryPrice { get; set; }

    public int ButtonWidth { get; set; } = 50;
    public int ButtonHeight { get; set; } = 50;
    public string FFamily { get; set; } = "Arial";
    public double FSize { get; set; } = 10;
    public string FStyle { get; set; } = "Regular";
    public bool WithImage { get; set; }




    public EntityButton Clone()
    {
        EntityButton eb = new EntityButton()
        {
            IID = IID,
            EntityButtonName = EntityButtonName,
            DisplayOrder = DisplayOrder,
            ButtonColor = ButtonColor,
            ForeColor = ForeColor,
            ButtonType = ButtonType,
            AvailableFor = AvailableFor,
            ParentEntityIID = ParentEntityIID,
            ParentMenuIID = ParentMenuIID,
            Compulsary = Compulsary,
            Barcode = Barcode,
            DirectSaleTaxPercent = DirectSaleTaxPercent,
            InHouseTaxPercent = InHouseTaxPercent,
            TakeAwayTaxPercent = TakeAwayTaxPercent,
            DeliveryTaxPercent = DeliveryTaxPercent,
            PadFlag = PadFlag,

            DistributionIID = DistributionIID,
            DirectSalePrice = DirectSalePrice,
            InHousePrice = InHousePrice,
            TakeAwayPrice = TakeAwayPrice,
            DeliveryPrice = DeliveryPrice,

            ButtonWidth = ButtonWidth,
            ButtonHeight = ButtonHeight,
            //ImageFileName = ImageFileName,

            FFamily = FFamily,
            FSize = FSize,
            FStyle = FStyle,
        };

        return eb;

    }

    /// <summary>
    /// Same EntityButton with different IID
    /// </summary>
    /// <returns></returns>
    public EntityButton Duplicate()
    {
        EntityButton eb = Clone();
        eb.IID = ShortGuid.NewGuid().ToString();
        return eb;
    }



    public double GetPrice(POSLayer.Library.OrderTypes orderType)
    {
        switch (orderType)
        {
            case POSLayer.Library.OrderTypes.DirectSale:
                return DirectSalePrice;
            case POSLayer.Library.OrderTypes.InHouse:
                return InHousePrice;
            case POSLayer.Library.OrderTypes.TakeAwayB:
                return TakeAwayPrice;
            case POSLayer.Library.OrderTypes.InternetTakeAway:
                return TakeAwayPrice;
            case POSLayer.Library.OrderTypes.Delivery:
                return DeliveryPrice;
            case POSLayer.Library.OrderTypes.InternetDelivery:
                return DeliveryPrice;
            default:
                return 0f;
        }
    }
    public double GetTaxRate(POSLayer.Library.OrderTypes orderType)
    {
        switch (orderType)
        {
            case POSLayer.Library.OrderTypes.DirectSale:
                return DirectSaleTaxPercent;
            case POSLayer.Library.OrderTypes.InHouse:
                return InHouseTaxPercent;
            case POSLayer.Library.OrderTypes.TakeAwayB:
                return TakeAwayTaxPercent;
            case POSLayer.Library.OrderTypes.InternetTakeAway:
                return TakeAwayTaxPercent;
            case POSLayer.Library.OrderTypes.Delivery:
                return DeliveryTaxPercent;
            case POSLayer.Library.OrderTypes.InternetDelivery:
                return DeliveryTaxPercent;
            default:
                return 0f;
        }
    }
}

public class EntityButtonSearchResult
{
    public string IID { get; set; }
    public string EntityButtonName { get; set; }
    public string EntityName { get; set; }
    public Image DisplayImage { get; set; }

    public EntityButtonSearchResult()
    {

    }
}

