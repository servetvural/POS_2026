using System;
using System.Collections.Generic;
using System.Drawing;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class CategoryItem : BaseClass
{
    public string? CategoryIID { get; set; }
    public Category? Category { get; set; }


    public string ItemName { get; set; }
    public int BgColor { get; set; } = SystemColors.Control.ToArgb();
    public int FgColor { get; set; } = Color.Black.ToArgb();
    public CategoryItemTypes ButtonType { get; set; } = CategoryItemTypes.SimpleItem;
    public int AvailableFor { get; set; } = (int)AvailabilityTypes.All;


    public int Compulsary { get; set; }
    public string Barcode { get; set; } = string.Empty;
    public double SaleTax { get; set; }
    public double SitinTax { get; set; }
    public double TaTax { get; set; }
    public double DTax { get; set; }
    public PadFlags PadFlag { get; set; } = PadFlags.EBOnly;

    public string? DistributionIID { get; set; }
    public Distribution? Distribution { get; set; }

    public string? DistributionName => Distribution?.DistributionName ?? "";

    public double SalePrice { get; set; }
    public double SitinPrice { get; set; }
    public double TaPrice { get; set; }
    public double DPrice { get; set; }

    public int Width { get; set; } = 150;
    public int Height { get; set; } = 50;
    public string FFamily { get; set; } = "Arial";
    public double FSize { get; set; } = 10;
    public string FStyle { get; set; } = "Regular";

    public string Font => FFamily + ", " + FStyle + ", " + FSize;


    public ButtonDisplayStyles ButtonDisplayStyle { get; set; } = ButtonDisplayStyles.Text;
    public ContentAlignmentX TextAlign { get; set; } = ContentAlignmentX.MiddleCenter;
    public TextImageRelationX TextImageRelation { get; set; } = TextImageRelationX.ImageBeforeText;
    public ContentAlignmentX ImageAlign { get; set; } = ContentAlignmentX.MiddleCenter;

    public List<StockItemUsage> stockUsages { get; set; } = new();

    public List<Recipe> recipes { get; set; } = new();

    //public ButtonStyleTypes ItemStyle { get; set; }    // { Text, Image, TextAndImage }
    //public ImagePositionTypes ImagePosition { get; set; } // { Left, Center, Right }

    public CategoryItem Clone()
    {
        CategoryItem eb = new CategoryItem()
        {
            IID = IID,
            ItemName = ItemName,
            DOrder = DOrder,
            BgColor = BgColor,
            FgColor = FgColor,
            ButtonType = ButtonType,
            AvailableFor = AvailableFor,
            CategoryIID = CategoryIID,
            Compulsary = Compulsary,
            Barcode = Barcode,
            SaleTax = SaleTax,
            SitinTax = SitinTax,
            TaTax = TaTax,
            DTax = DTax,
            PadFlag = PadFlag,

            DistributionIID = DistributionIID,
            SalePrice = SalePrice,
            SitinPrice = SitinPrice,
            TaPrice = TaPrice,
            DPrice = DPrice,

            Width = Width,
            Height = Height,
            //ImageFileName = ImageFileName,

            FFamily = FFamily,
            FSize = FSize,
            FStyle = FStyle,

            ButtonDisplayStyle = ButtonDisplayStyle,
            TextAlign = TextAlign,
            TextImageRelation = TextImageRelation,
            ImageAlign = ImageAlign
        };

        return eb;

    }

    /// <summary>
    /// Same EntityButton with different IID
    /// </summary>
    /// <returns></returns>
    public CategoryItem Duplicate()
    {
        CategoryItem eb = Clone();
        eb.IID = null;
        return eb;
    }



    public double GetPrice(POSLayer.Library.OrderTypes orderType)
    {
        switch (orderType)
        {
            case POSLayer.Library.OrderTypes.DirectSale:
                return SalePrice;
            case POSLayer.Library.OrderTypes.InHouse:
                return SitinPrice;
            case POSLayer.Library.OrderTypes.TakeAwayB:
            case POSLayer.Library.OrderTypes.InternetTakeAway:
                return TaPrice;
            case POSLayer.Library.OrderTypes.Delivery:
            case POSLayer.Library.OrderTypes.InternetDelivery:
                return DPrice;
            default:
                return 0f;
        }
    }
    public double GetTaxRate(POSLayer.Library.OrderTypes orderType)
    {
        switch (orderType)
        {
            case POSLayer.Library.OrderTypes.DirectSale:
                return SaleTax;
            case POSLayer.Library.OrderTypes.InHouse:
                return SitinTax;
            case POSLayer.Library.OrderTypes.TakeAwayB:
            case POSLayer.Library.OrderTypes.InternetTakeAway:
                return TaTax;
            case POSLayer.Library.OrderTypes.Delivery:
            case POSLayer.Library.OrderTypes.InternetDelivery:
                return DTax;
            default:
                return 0f;
        }
    }
}


