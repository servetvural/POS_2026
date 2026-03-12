using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class Entity : BaseClass
{
    public string EntityName { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public int BackColour { get; set; } = SystemColors.Control.ToArgb();
    public int ForeColour { get; set; } = SystemColors.ControlText.ToArgb();
    public int ButtonHeight { get; set; } = 64;
    public int ButtonWidth { get; set; } = 64;

    public string ParentMenuIID { get; set; } = string.Empty;
    public List<EntityButton> Buttons { get; set; } = new();

    public EntityTypes EntityType { get; set; } = EntityTypes.NormalEntity;

    public string DistributionIID { get; set; }       = string.Empty;

    public string DistributionName { get; set; }     = string.Empty;

    public string FFamily { get; set; } = "Arial";

    public double FSize { get; set; } = 10f;

    public string FStyle { get; set; } = "Bold";

    
    public Entity Clone()
    {
        Entity en = new Entity();
        en.IID = IID;
        en.EntityName = EntityName;
        en.DisplayOrder = DisplayOrder;
        en.BackColour = BackColour;
        en.ForeColour = ForeColour;
        en.ButtonHeight = ButtonHeight;
        en.ButtonWidth = ButtonWidth;
        en.ParentMenuIID = ParentMenuIID;
        en.EntityType = EntityType;
        en.DistributionIID = DistributionIID;
        en.DistributionName = DistributionName;
        en.FFamily = FFamily;
        en.FSize = FSize;
        en.FStyle = FStyle;

        //Clone Buttons
        for (int i = 0; i < Buttons.Count; i++)
            en.Buttons.Add(((EntityButton)Buttons[i]).Clone());

        return en;
    }
    public Entity Duplicate()
    {
        Entity en = new Entity()
        {
            EntityName = EntityName,
            DisplayOrder = DisplayOrder,
            BackColour = BackColour,
            ForeColour = ForeColour,
            ButtonHeight = ButtonHeight,
            ButtonWidth = ButtonWidth,
            ParentMenuIID = ParentMenuIID,
            EntityType = EntityType,
            DistributionIID = DistributionIID,
            DistributionName = DistributionName,
            FFamily = FFamily,
            FSize = FSize,
            FStyle = FStyle,
        };
        //Clone Buttons
        for (int i = 0; i < Buttons.Count; i++)
            en.Buttons.Add(((EntityButton)Buttons[i]).Duplicate());

        return en;
    }


    public EntityButton GetEntityButton(string EntityButtonId)
    {
        int i = GetButtonIndex(EntityButtonId);
        if (i >= 0)
            return (EntityButton)Buttons[i];
        else
            return null;
    }

    public void AddButton(EntityButton button)
    {
        Buttons.Add(button);
    }

    public void DeleteButton(string ButtonId)
    {
        int i = GetButtonIndex(ButtonId);
        if (i >= 0)
            Buttons.RemoveAt(i);
    }
    public int GetButtonIndex(string ButtonId)
    {
        EntityButton button;
        for (int i = 0; i < Buttons.Count; i++)
        {
            button = (EntityButton)Buttons[i];
            if (button.IID == ButtonId)
                return i;
        }
        return -1;
    }
    public void MoveButtonUp(string ButtonIID)
    {
        int CurrentIndex = this.GetButtonIndex(ButtonIID);
        int UpIndex = CurrentIndex - 1;
        EntityButton eb;
        if (CurrentIndex > 0)
        {
            eb = (EntityButton)this.Buttons[CurrentIndex];   //Get Copy of active button
            Buttons[CurrentIndex] = (EntityButton)Buttons[UpIndex];  //move button from above to 1 down
            Buttons[UpIndex] = eb; //put copy of the active button to upper location
        }
    }
    public void MoveButtonDown(string ButtonIID)
    {
        int CurrentIndex = this.GetButtonIndex(ButtonIID);
        int DownIndex = CurrentIndex + 1;
        EntityButton eb;
        if (DownIndex <= Buttons.Count)
        {
            eb = (EntityButton)this.Buttons[CurrentIndex];   //Get Copy of active button
            Buttons[CurrentIndex] = (EntityButton)Buttons[DownIndex];  //move button from below to 1 up
            Buttons[DownIndex] = eb; //put copy of the active button to lower location
        }
    }
    public void DuplicateButton(string ButtonIID)
    {
        int SourceButtonIndex = this.GetButtonIndex(ButtonIID);
        EntityButton eb = this.GetEntityButton(ButtonIID);
        EntityButton db = eb.Duplicate();
        this.Buttons.Insert(SourceButtonIndex + 1, db);
    }

    public double GetItemPrice(string ItemIID, OrderTypes orderType)
    {
        EntityButton eb;

        for (int i = 0; i < Buttons.Count; i++)
        {
            eb = (EntityButton)Buttons[i];
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

        EntityButton eb = Buttons.Where(x => x.IID == ItemIID).FirstOrDefault(); // Find(delegate (EntityButton btn) { return btn.IID == ItemIID; });
        if (eb != null)
            return eb.GetTaxRate(orderType);

        //now check size bar 
        return 0f;

    }
}
