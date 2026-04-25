using System;
using System.Data;

using Newtonsoft.Json;

namespace DTRMNS
{
    [System.Serializable]
    public class LogItem
    {
        public string IID { get; set; } = Guid.NewGuid().ToString().Substring(0, 10);
        public string OrderItemText { get; set; }  = string.Empty;
        public float Quantity { get; set; } = 1;
        public float Price { get; set; }
        public float Total { get { return Price * Quantity; } }

        public string ComputerName { get; set; } = string.Empty;
        public string OrderContent { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime EventDateTime { get; set; } = DateTime.Now;
        public string Reference { get; set; } = string.Empty;

        public LogItem()
        {        
           
        }

        public static LogItem Reconstruct(object sIID, object sOrderItemText, object sQuantity, object sPrice, object sReason,
            object sEventDateTime, object sComputerName, object sOrderContent, object sReference)
        {
            LogItem logItem = new LogItem();
            logItem.IID = sIID.ToString();
            logItem.OrderItemText = sOrderItemText.ToString();
            logItem.Quantity = float.Parse(sQuantity.ToString());
            logItem.Price = float.Parse(sPrice.ToString());
            logItem.Reason = sReason.ToString();
            logItem.EventDateTime = (DateTime)sEventDateTime;
            logItem.ComputerName = sComputerName.ToString();
            logItem.OrderContent = sOrderContent.ToString();
            logItem.Reference = sReference.ToString();
            return logItem;
        }

        public LogItem(DataRow dr)
        {
            if (dr != null)
            {
                this.IID = dr["IID"].ToString();
                this.OrderItemText = dr["OrderItemText"].ToString();
                this.Quantity = float.Parse(dr["Quantity"].ToString());
                this.Price = float.Parse(dr["Price"].ToString());      
                this.Reason = dr["Reason"].ToString();
                this.EventDateTime = DateTime.Parse(dr["EventDateTime"].ToString());
                this.ComputerName = dr["ComputerName"].ToString();
                this.OrderContent = dr["OrderContent"].ToString();
                this.Reference = dr["Reference"].ToString();
            }
        }  
        public LogItem(OrderItem oi, float quantity, string OrderContent, string Reason, string ComputerName, string Reference)
        {
            this.OrderItemText = oi.OrderItemText;
            this.Quantity = quantity;
            this.Price = oi.Price;
            this.Reason = Reason;
            this.EventDateTime = DateTime.Now;
            this.ComputerName = ComputerName;
            this.OrderContent = OrderContent;
            this.Reference = Reference;                                                                     
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public string ToSimpleString()
        {
            return "**** " + Reason + " => " + Quantity.ToString().PadLeft(3, ' ') + "  " + OrderItemText.PadRight(20, ' ') +
                Price.ToString("N2").PadLeft(10, ' ') + Total.ToString("N2").PadLeft(10, ' ') +  "   Reference = "  + Reference.PadRight(12,' ')  + Environment.NewLine;
        }
    }
}