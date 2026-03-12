using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class KitchenOrder : BaseClass
{
    public string Reference { get; set; } = string.Empty;

    public DateTime CreatedDateTime { get; set; }

    public string OrderIID { get; set; } = null!;

    public DateTime CompletedDateTime { get; set; }

    public KitchenOrderStatusTypes Status { get; set; }

    public int OrderNo { get; set; }

    public int BeingModified { get; set; }

    public OrderTypes OrderType { get; set; }

    public List<KitchenOrderItem> items { get; set; }


    public KitchenOrder()
    {

        CreatedDateTime = DateTime.Now;
        CompletedDateTime = DateTime.Now;
        items = new List<KitchenOrderItem>();
    }
    public void ReorderForDistributionIID(string DistributionIID, bool blnAscending)
    {
        List<KitchenOrderItem> theNewList = new List<KitchenOrderItem>();
        for (int i = 0; i < items.Count; i++)
        {
            if (blnAscending)
            {
                if (items[i].DistributionIID == DistributionIID)
                    theNewList.Insert(0, items[i]);
                else
                    theNewList.Add(items[i]);
            } else
            {
                if (items[i].DistributionIID != DistributionIID)
                    theNewList.Insert(0, items[i]);
                else
                    theNewList.Add(items[i]);
            }
        }
        items = theNewList;
    }

    public void ReorderForDistributionList(List<Distribution> distributionList, bool blnAscending)
    {
        List<KitchenOrderItem> theNewList = new List<KitchenOrderItem>();
        for (int i = 0; i < items.Count; i++)
        {
            if (blnAscending)
            {

                if (distributionList.Find(x => x.IID == items[i].DistributionIID) != null)
                    theNewList.Insert(0, items[i]);
                else
                    theNewList.Add(items[i]);
            } else
            {
                if (distributionList.Find(x => x.IID == items[i].DistributionIID) == null)
                    theNewList.Insert(0, items[i]);
                else
                    theNewList.Add(items[i]);
            }
        }
        items = theNewList;
    }

    public KitchenOrderStatusTypes GetStatus()
    {
        bool blnCompleted = false;
        bool blnWaiting = false;


        //if (Status == KitchenOrderStatusTypes.WaitingToBePaid)
        //    return KitchenOrderStatusTypes.WaitingToBePaid;

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Status == KitchenOrderStatusTypes.Completed)
                blnCompleted = true;
            if (items[i].Status == KitchenOrderStatusTypes.Waiting)
                blnWaiting = true;
        }
        if (blnWaiting && blnCompleted)
            return KitchenOrderStatusTypes.PartialyCompleted;
        if (blnWaiting && !blnCompleted)
            return KitchenOrderStatusTypes.Waiting;
        if (!blnWaiting && blnCompleted)
            return KitchenOrderStatusTypes.Completed;

        return KitchenOrderStatusTypes.Waiting;

    }
    public bool IsAllItemsWaiting()
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Status != KitchenOrderStatusTypes.Waiting)
                return false;
        }
        return true;

    }
    public bool HasWaitingItem(List<Distribution> distributionList)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (distributionList.Find(x => x.IID == items[i].DistributionIID) != null && items[i].Status == KitchenOrderStatusTypes.Waiting)
                return true;
        }
        return false;
    }
    public bool IsRelative(string DistributionIID)
    {
        return items.Find(x => x.DistributionIID == DistributionIID) != null;
    }

    public bool IsRelative(List<Distribution> thelist)
    {
        for (int i = 0; i < thelist.Count; i++)
        {
            if (IsRelative(thelist[i].IID))
                return true;
        }
        return false;
    }
    public List<string> GetDistributionIIDList()
    {
        List<string> theList = new List<string>();
        for (int i = 0; i < items.Count; i++)
        {
            if (theList.Find(x => x == items[i].DistributionIID) == null)
                theList.Add(items[i].DistributionIID);
        }
        return theList;
    }

    public string GetTimeString(bool blnIncludeNow)
    {
        if (Status == KitchenOrderStatusTypes.Completed)
        {
            double singleResponseTime = CompletedDateTime.Subtract(CreatedDateTime).TotalSeconds;
            return CreatedDateTime.ToString("HH:mm:ss") + " | " +
                CompletedDateTime.ToString("HH:mm:ss") + " | " + UF.secondsToMinutes(singleResponseTime);
        } else
        {
            double totalSeconds = DateTime.Now.Subtract(CreatedDateTime).TotalSeconds;
            return CreatedDateTime.ToString("HH:mm:ss") + (blnIncludeNow ? " | " + UF.secondsToMinutes(totalSeconds) : "");
        }

    }
}
