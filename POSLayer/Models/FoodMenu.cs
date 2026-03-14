using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class FoodMenu  : BaseClass
{
    public string? MenuName { get; set; }

    public List<Distribution> Distributions { get; set; } = new();
    public List<Entity> items { get; set; } = new();

    public bool IsActiveMenu { get; set; }

    public string GetMenuFileName()
    {
        return IID + ".xml";
    }
    public double GetItemPrice(string EntityIID, string ItemIID, OrderTypes orderType)
    {
        Entity en;
        for (int i = 0; i < this.items.Count; i++)
        {
            en = (Entity)items[i];
            if (en.IID == EntityIID)
                return en.GetItemPrice(ItemIID, orderType);
        }
        return 0f;
    }
    public double GetItemTaxRate(string EntityIID, string ItemIID, OrderTypes orderType)
    {
        Entity en;
        for (int i = 0; i < this.items.Count; i++)
        {
            en = (Entity)items[i];
            if (en.IID == EntityIID)
                return en.GetItemTaxRate(ItemIID, orderType);
        }
        return 0f;
    }
}
