using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class TheMenu  : BaseClass
{
    public string? MenuName { get; set; }

    public List<Distribution> distributions { get; set; } = new();
    public List<Category> categories { get; set; } = new();

    public bool IsActive { get; set; }

    public string GetMenuFileName()
    {
        return IID + ".xml";
    }
    public double GetItemPrice(string ItemIID, OrderTypes orderType)
    {
        CategoryItem item = categories.SelectMany(c => c.Items).FirstOrDefault(item => item.IID == ItemIID);
        if (item == null)
            return 0;
        
        switch (orderType)
        {
            case OrderTypes.Sale:
                return item.SalePrice;
            case OrderTypes.Sitin:
                return item.SitinPrice;
            case OrderTypes.TakeAway:
            case OrderTypes.InternetTakeAway:
                return item.TaPrice;
            case OrderTypes.Delivery:
            case OrderTypes.InternetDelivery:
                return item.DPrice;
            default:
                return item.SalePrice;
        }

    }
    public double GetItemTaxRate(string CategoryItemIID, OrderTypes orderType)
    {
        CategoryItem item = categories.SelectMany(c => c.Items).FirstOrDefault(item => item.IID == CategoryItemIID);
        if (item == null)
            return 0;

        switch (orderType)
        {
            case OrderTypes.Sale:
                return item.SaleTax;
            case OrderTypes.Sitin:
                return item.SitinTax;
            case OrderTypes.TakeAway:
            case OrderTypes.InternetTakeAway:
                return item.TaTax;
            case OrderTypes.Delivery:
            case OrderTypes.InternetDelivery:
                return item.DTax;
            default:
                return item.SaleTax;
        }
    }
}
