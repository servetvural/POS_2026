using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Category : BaseClass
{
    public string Name { get; set; } = string.Empty;
    public int BgColour { get; set; } = SystemColors.Control.ToArgb();
    public int FgColour { get; set; } = SystemColors.ControlText.ToArgb();
    public int Height { get; set; } = 64;
    public int Width { get; set; } = 64;
    public EntityTypes EntityType { get; set; } = EntityTypes.NormalEntity;

    public string MenuIID { get; set; } = string.Empty;
    public TheMenu? Menu { get; set; }
    public List<CategoryItem> Items { get; set; } = new();      

    public string? DistributionIID { get; set; } 
   // public Distribution? Distribution { get; set; }

    public string FFamily { get; set; } = "Arial";

    public double FSize { get; set; } = 10f;

    public string FStyle { get; set; } = "Bold";


    public CategoryItem GetEntityButton(string EntityButtonId)
    {
        int i = GetButtonIndex(EntityButtonId);
        if (i >= 0)
            return (CategoryItem)Items[i];
        else
            return null;
    }

    public int GetButtonIndex(string ButtonId)
    {
        CategoryItem button;
        for (int i = 0; i < Items.Count; i++)
        {
            button = (CategoryItem)Items[i];
            if (button.IID == ButtonId)
                return i;
        }
        return -1;
    }

    public double GetItemPrice(string ItemIID, OrderTypes orderType)
    {
        CategoryItem eb;

        for (int i = 0; i < Items.Count; i++)
        {
            eb = (CategoryItem)Items[i];
            if (eb.IID == ItemIID)
                return eb.GetPrice(orderType);
        }

        //now check size bar 
        return 0f;
    }

    public double GetItemTaxRate(string ItemIID, OrderTypes orderType)
    {
        //if SizeIID != 0 then this item created by one of the SizeBarButton's otherwise by one of the entity buttons
        //Either SizeIID (SizeBarButton IID) or ItemIID (EntityButtonIID) should be checked

        CategoryItem eb = Items.Where(x => x.IID == ItemIID).FirstOrDefault(); // Find(delegate (EntityButton btn) { return btn.IID == ItemIID; });
        if (eb != null)
            return eb.GetTaxRate(orderType);

        //now check size bar 
        return 0f;

    }
}
