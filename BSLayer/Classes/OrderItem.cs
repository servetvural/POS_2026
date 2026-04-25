using System;
using System.Data;
using PosLibrary;

using Newtonsoft.Json;

namespace DTRMNS {
    [System.Serializable]
    public class OrderItem {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        
        public string ParentOrderIID { get; set; }
        public string EntityIID { get; set; }
        public string OrderItemText { get; set; }

        public float Quantity { get; set; }

        public float Price { get; set; }

        public float Total { get { return Price * Quantity; } }
               

        public string OrderGroupIID { get; set; }	//each pizza is belong to a single group

        public string EntityButtonIID { get; set; }								//identify mushroom, cactus etc


        public string DistributionIID { get; set; }

        public OrderItemTypes ItemType { get; set; }
        public int dorder { get; set; }

        public string EntityName { get; set; }
        public int EntityDisplayOrder { get; set; }
        public float TaxPercent { get; set; }

        public float TaxValue { get {
                return (float)Math.Round((Quantity * Price * TaxPercent) / (100 + TaxPercent), 2);
            } }

        public float CompletedQuantity { get; set; }
        

        //public DateTime ItemDateTime { get; set; }

        public OrderItem() {
            ParentOrderIID = "";
            EntityIID = "";
            OrderItemText = "";

            Quantity = 1;

            Price = 0f;
            OrderGroupIID = "";    //each pizza is belong to a single group
            EntityButtonIID = "";								//identify mushroom, cactus etc

            DistributionIID = "";
            ItemType = OrderItemTypes.NormalOrderItem;

            EntityName = "";
            //ItemDateTime = DateTime.Now;
        }

        public OrderItem(string ParentOrderIID, string EntityIID, string OrderGroupIID,
        float Quantity, float SizeButtonOrEntityButtonPrice, string EntityButtonIID, string OrderItemText,
         string distributioniid, OrderItemTypes ItemType, int dorder,
           string EntityName, int EntityDisplayOrder, float TaxPercent) {

            this.ParentOrderIID = ParentOrderIID;
            this.EntityIID = EntityIID;
            this.OrderItemText = OrderItemText;
            this.Quantity = Quantity;
            this.Price = SizeButtonOrEntityButtonPrice;
            this.OrderGroupIID = OrderGroupIID;

            this.EntityButtonIID = EntityButtonIID;
            this.DistributionIID = distributioniid;
            this.ItemType = ItemType;
            this.dorder = dorder;

            this.EntityName = EntityName;
            this.EntityDisplayOrder = EntityDisplayOrder;
            this.TaxPercent = TaxPercent;
            //try {
            //    this.ItemDateTime = DateTime.Now;
            //} catch {

            //}
        }


        public OrderItem(DataRow dr) {
            if (dr != null) {
                this.IID = dr["IID"].ToString();
                this.EntityIID = dr["EntityIID"].ToString();
                this.OrderItemText = dr["OrderItemText"].ToString();
                this.Quantity = float.Parse(dr["Quantity"].ToString());
                this.Price = float.Parse(dr["Price"].ToString());
                this.OrderGroupIID = dr["OrderGroupIID"].ToString();
                this.EntityButtonIID = dr["EntityButtonIID"].ToString();
                this.DistributionIID = dr["DistributionIID"].ToString();
                this.ParentOrderIID = dr["ParentOrderIID"].ToString();
                this.ItemType = (OrderItemTypes)int.Parse(dr["ItemType"].ToString());
                this.dorder = int.Parse(dr["DisplayOrder"].ToString());

                this.EntityName = dr["EntityName"].ToString();
                this.EntityDisplayOrder = int.Parse(dr["EntityDisplayOrder"].ToString());
                this.TaxPercent = float.Parse(dr["TaxPercent"].ToString());

                this.CompletedQuantity = float.Parse(dr["CompletedQuantity"].ToString());
                //try {
                //    this.ItemDateTime = DateTime.Parse(dr["ItemDateTime"].ToString());
                //} catch {

                //}
            }
        }


        public OrderItem Clone(bool blnNewGroup) {
           OrderItem oi = new OrderItem( this.ParentOrderIID, this.EntityIID,
                blnNewGroup?ShortGuid.NewGuid().ToString():this.OrderGroupIID, this.Quantity,
                this.Price, this.EntityButtonIID, this.OrderItemText,
                this.DistributionIID, this.ItemType, this.dorder, this.EntityName, this.EntityDisplayOrder,
               this.TaxPercent);
            oi.CompletedQuantity = this.CompletedQuantity;
            return oi;
        }
        public OrderItem Duplicate(string newParentOrderIID, bool blnNewGroup)
        {
            OrderItem oi = new OrderItem(newParentOrderIID, this.EntityIID,
                 blnNewGroup ? ShortGuid.NewGuid().ToString() : this.OrderGroupIID, this.Quantity,
                 this.Price, this.EntityButtonIID, this.OrderItemText,
                 this.DistributionIID, this.ItemType, this.dorder, this.EntityName, this.EntityDisplayOrder,
                this.TaxPercent);
            oi.CompletedQuantity = this.CompletedQuantity;
            return oi;
        }
        public void Increment() {
            this.Quantity++;
        }
        public bool Decrement() {
            if (this.Quantity > 1) {
                this.Quantity--;
                return true;
            }
            else 
                return false;
        }
        public bool Decrement(int howmany) {
            if (howmany > this.Quantity)
                return false;
            if (howmany <= this.Quantity) {
                this.Quantity -= howmany;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public string ToSimpleString()
        {
            //return $"{Quantity,10}" + $"{OrderItemText,20}" + $"{Price,10}" + $"{Total,10}"; 
            return Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(25, ' ') + 
                Price.ToString("N2").PadLeft(10, ' ') + Total.ToString("N2").PadLeft(10, ' ');
        }
    }
}
