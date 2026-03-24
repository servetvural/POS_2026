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
    public double GetItemPrice(string CategoryIID, string ItemIID, OrderTypes orderType)
    {
        //try
        //{
        //    categories.Where(c => c.IID == CategoryIID).ToList().Where(cb => cb.)
        //}
        Category en;
        for (int i = 0; i < this.categories.Count; i++)
        {
            en = (Category)categories[i];
            if (en.IID == CategoryIID)
                return en.GetItemPrice(ItemIID, orderType);
        }
        return 0f;
    }
    public double GetItemTaxRate(string CategoryIID, string ItemIID, OrderTypes orderType)
    {
        Category en;
        for (int i = 0; i < this.categories.Count; i++)
        {
            en = (Category)categories[i];
            if (en.IID == CategoryIID)
                return en.GetItemTaxRate(ItemIID, orderType);
        }
        return 0f;
    }
}
