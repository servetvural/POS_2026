using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class EntityButton : BaseClass
{

    public string? EntityButtonName { get; set; }
    public int DisplayOrder { get; set; }
    public int? ButtonColor { get; set; }

    public int? ForeColor { get; set; }

    public int? ButtonType { get; set; }

    public int? AvailableFor { get; set; }

    public string? ParentEntityIID { get; set; }

    public string? ParentMenuIID { get; set; }

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

    public string FFamily { get; set; } = null!;

    public double FSize { get; set; }

    public string FStyle { get; set; } = null!;

    public string DistributionIID { get; set; } = null!;

    public int WithImage { get; set; }




    public EntityButton Clone()
    {
        EntityButton eb = new EntityButton();
        eb.IID = this.IID;
        eb.EntityButtonName = this.EntityButtonName;
        eb.DisplayOrder = this.DisplayOrder;
        eb.ButtonColor = this.ButtonColor;
        eb.ForeColor = this.ForeColor;
        eb.ButtonType = this.ButtonType;
        eb.AvailableFor = this.AvailableFor;
        eb.ParentEntityIID = this.ParentEntityIID;
        eb.ParentMenuIID = this.ParentMenuIID;
        eb.Compulsary = this.Compulsary;
        eb.Barcode = this.Barcode;
        eb.DirectSaleTaxPercent = this.DirectSaleTaxPercent;
        eb.InHouseTaxPercent = this.InHouseTaxPercent;
        eb.TakeAwayTaxPercent = this.TakeAwayTaxPercent;
        eb.DeliveryTaxPercent = this.DeliveryTaxPercent;
        eb.PadFlag = this.PadFlag;

        eb.DistributionIID = this.DistributionIID;
        eb.DirectSalePrice = this.DirectSalePrice;
        eb.InHousePrice = this.InHousePrice;
        eb.TakeAwayPrice = this.TakeAwayPrice;
        eb.DeliveryPrice = this.DeliveryPrice;

        eb.ButtonWidth = this.ButtonWidth;
        eb.ButtonHeight = this.ButtonHeight;
        //eb.ImageFileName = this.ImageFileName;

        eb.FFamily = this.FFamily;
        eb.FSize = this.FSize;
        eb.FStyle = this.FStyle;

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



    public double GetPrice(OrderTypes orderType)
    {
        switch (orderType)
        {
            case OrderTypes.DirectSale:
                return DirectSalePrice;
            case OrderTypes.InHouse:
                return InHousePrice;
            case OrderTypes.TakeAwayB:
                return TakeAwayPrice;
            case OrderTypes.InternetTakeAway:
                return TakeAwayPrice;
            case OrderTypes.Delivery:
                return DeliveryPrice;
            case OrderTypes.InternetDelivery:
                return DeliveryPrice;
            default:
                return 0f;
        }
    }
    public double GetTaxRate(OrderTypes orderType)
    {
        switch (orderType)
        {
            case OrderTypes.DirectSale:
                return DirectSaleTaxPercent;
            case OrderTypes.InHouse:
                return InHouseTaxPercent;
            case OrderTypes.TakeAwayB:
                return TakeAwayTaxPercent;
            case OrderTypes.InternetTakeAway:
                return TakeAwayTaxPercent;
            case OrderTypes.Delivery:
                return DeliveryTaxPercent;
            case OrderTypes.InternetDelivery:
                return DeliveryTaxPercent;
            default:
                return 0f;
        }
    }
}
