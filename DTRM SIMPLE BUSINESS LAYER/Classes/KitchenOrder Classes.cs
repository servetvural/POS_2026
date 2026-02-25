using System;
using System.Collections.Generic;
using System.Data;
using PosLibrary;

namespace DTRMNS {
    public class KitchenOrder {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string Reference { get; set; }
        public KitchenOrderStatusTypes Status { get; }
        public DateTime CreatedDateTime { get; set; }
        public string OrderIID { get; set; }
        public DateTime CompletedDateTime { get; set; }
        public List<KitchenOrderItem> items { get; set; }
        public int OrderNo { get; set; }
        public bool BeingModified { get; set; }

        public OrderTypes OrderType { get; set; }
        public KitchenOrder() {

            CreatedDateTime = DateTime.Now;
            CompletedDateTime = DateTime.Now;
            items = new List<KitchenOrderItem>();
        }

        public KitchenOrder(DataTable dt) {
            if (items == null)
                items = new List<KitchenOrderItem>();
            if (dt != null) {
                try {
                    this.IID = dt.Rows[0]["IID"].ToString();
                    this.Reference = dt.Rows[0]["Reference"].ToString();
                    this.CreatedDateTime = DateTime.Parse(dt.Rows[0]["CreatedDateTime"].ToString());
                    this.OrderIID = dt.Rows[0]["OrderIID"].ToString();
                    this.CompletedDateTime = DateTime.Parse(dt.Rows[0]["CompletedDateTime"].ToString());
                    this.Status = (KitchenOrderStatusTypes)int.Parse(dt.Rows[0]["Status"].ToString());
                    this.OrderNo = int.Parse(dt.Rows[0]["OrderNo"].ToString());
                    this.BeingModified = (int.Parse(dt.Rows[0]["BeingModified"].ToString()) == 0 ? false : true);
                    this.OrderType = (OrderTypes)int.Parse(dt.Rows[0]["OrderType"].ToString());

                } catch  {
                }
            }
        }

        public KitchenOrder(DataRow dr) {
            if (items == null)
                items = new List<KitchenOrderItem>();
            if (dr != null) {
                try {
                    this.IID = dr["IID"].ToString();
                    this.Reference = dr["Reference"].ToString();
                    this.CreatedDateTime = DateTime.Parse(dr["CreatedDateTime"].ToString());
                    this.OrderIID = dr["OrderIID"].ToString();
                    this.CompletedDateTime = DateTime.Parse(dr["CompletedDateTime"].ToString());
                    this.Status = (KitchenOrderStatusTypes)int.Parse(dr["Status"].ToString());

                    this.OrderNo = int.Parse(dr["OrderNo"].ToString());
                    this.BeingModified = (int.Parse(dr["BeingModified"].ToString()) == 0 ? false : true);
                    this.OrderType = (OrderTypes)int.Parse(dr["OrderType"].ToString());
                } catch  {
                }
            }
        }

        public void ReorderForDistributionIID(string DistributionIID, bool blnAscending) {
            List<KitchenOrderItem> theNewList = new List<KitchenOrderItem>();
            for (int i=0; i < items.Count; i++) {
                if (blnAscending) {
                    if (items[i].DistributionIID == DistributionIID)
                        theNewList.Insert(0, items[i]);
                    else
                        theNewList.Add(items[i]);
                } else {
                    if (items[i].DistributionIID != DistributionIID)
                        theNewList.Insert(0, items[i]);
                    else
                        theNewList.Add(items[i]);
                }
            }
            items = theNewList;
        }

        public void ReorderForDistributionList(List<Distribution> distributionList, bool blnAscending) {
            List<KitchenOrderItem> theNewList = new List<KitchenOrderItem>();
            for (int i = 0; i < items.Count; i++) {
                if (blnAscending) {
                    
                    if (distributionList.Find(x => x.IID == items[i].DistributionIID) != null)
                        theNewList.Insert(0, items[i]);
                    else
                        theNewList.Add(items[i]);
                } else {
                    if (distributionList.Find(x => x.IID == items[i].DistributionIID) == null)
                        theNewList.Insert(0, items[i]);
                    else
                        theNewList.Add(items[i]);
                }
            }
            items = theNewList;
        }

        public KitchenOrderStatusTypes GetStatus() {
            bool blnCompleted = false;
            bool blnWaiting = false;


            //if (Status == KitchenOrderStatusTypes.WaitingToBePaid)
            //    return KitchenOrderStatusTypes.WaitingToBePaid;

            for (int i=0; i < items.Count; i++) {
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
        public bool IsAllItemsWaiting() {            
            for (int i = 0; i < items.Count; i++) {
                if (items[i].Status != KitchenOrderStatusTypes.Waiting)
                    return false;
            }
            return true;

        }
        public bool HasWaitingItem(List<Distribution> distributionList) {
            for (int i = 0; i < items.Count; i++) {
                if (distributionList.Find(x => x.IID == items[i].DistributionIID) != null && items[i].Status == KitchenOrderStatusTypes.Waiting)
                    return true;
            }
            return false;
        }
        public bool IsRelative(string DistributionIID) {
            return items.Find(x => x.DistributionIID == DistributionIID) != null;
        }

        public bool IsRelative(List<Distribution> thelist) {
            for (int i = 0; i < thelist.Count; i++) {
                if (IsRelative(thelist[i].IID)) 
                    return true;
            }
            return false;
        }
        public List<string> GetDistributionIIDList() {
            List<string> theList = new List<string>();
            for (int i = 0; i < items.Count; i++) {
                if (theList.Find(x => x == items[i].DistributionIID) == null)
                    theList.Add(items[i].DistributionIID);               
            }
            return theList;
        }
        
        public string GetTimeString(bool blnIncludeNow) {
            if (Status == KitchenOrderStatusTypes.Completed) {
                double singleResponseTime = CompletedDateTime.Subtract(CreatedDateTime).TotalSeconds;
                return CreatedDateTime.ToString("HH:mm:ss") + " | " +
                    CompletedDateTime.ToString("HH:mm:ss") + " | " + DRUF.secondsToMinutes(singleResponseTime);
            } else {
                double totalSeconds = DateTime.Now.Subtract(CreatedDateTime).TotalSeconds;
                return CreatedDateTime.ToString("HH:mm:ss") + (blnIncludeNow ? " | " + DRUF.secondsToMinutes(totalSeconds) : "");
            }
           
        }
    }

    public class KitchenOrderItem {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public int Quantity { get; set; }
        public string ItemText { get; set; }
        public string KitchenOrderIID { get; set; }
        public string DistributionIID { get; set; }
        public KitchenOrderStatusTypes Status { get; set; }
        public string EntityButtonIID { get; set; }

        /// <summary>
        /// This property not need to be saved it is used for when sending order to the kitchen 
        /// to prevent over quantity manipulation
        /// </summary>
        public ModificationFlag Modified { get; set; } = ModificationFlag.None;
        /// <summary>
        /// This property not need to be saved it is used for when sending order to the kitchen 
        /// to prevent over quantity manipulation
        /// </summary>
        public int ModifiedQuantity { get; set; }

        public KitchenOrderItem() {
        }

        public KitchenOrderItem(DataTable dt) {
            if (dt != null) {
                try {
                    this.IID = dt.Rows[0]["IID"].ToString();
                    this.Quantity = int.Parse(dt.Rows[0]["Quantity"].ToString());
                    this.ItemText = dt.Rows[0]["ItemText"].ToString();
                    this.KitchenOrderIID = dt.Rows[0]["KitchenOrderIID"].ToString();
                    this.DistributionIID = dt.Rows[0]["DistributionIID"].ToString();
                    try {
                        this.EntityButtonIID = dt.Rows[0]["EntityButtonIID"].ToString();
                    } catch { }
                    this.Status = (KitchenOrderStatusTypes)int.Parse(dt.Rows[0]["Status"].ToString());
                } catch {
                }
            }
        }

        public KitchenOrderItem(DataRow dr) {
            if (dr != null) {
                try {
                    this.IID = dr["IID"].ToString();
                    this.Quantity = int.Parse(dr["Quantity"].ToString());
                    this.ItemText = dr["ItemText"].ToString();
                     this.KitchenOrderIID = dr["KitchenOrderIID"].ToString();
                    this.DistributionIID = dr["DistributionIID"].ToString();
                    try {
                        this.EntityButtonIID = dr["EntityButtonIID"].ToString();
                    } catch { }
                    this.Status = (KitchenOrderStatusTypes)int.Parse(dr["Status"].ToString());
                } catch {
                }
            }
        }
    }
}
