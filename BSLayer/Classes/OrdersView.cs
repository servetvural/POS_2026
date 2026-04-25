using System.Data;

using POSLayer.Library;

namespace DTRMNS {

    public class OrdersView {
        public string IID { get; set; }
        public string TableIID { get; set; }
        public string OrderDate { get; set; }
        public int Covers { get; set; }
        public string OrderType { get; set; }
        public string OrderTypeName { get; set; }
        public string Payment { get; set; }
        public string PaymentMethodName { get; set; }
        public string CustomerIID { get; set; }
        public string SessionIID { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
        public string LockedClientIP { get; set; }
        public string Instruction { get; set; }
       
        public float MoneyPaid { get; set; }
        public string TableName { get; set; }
        public string CName { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public string Buzzer { get; set; }
        public string Town { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string ItemCount { get; set; }
        public string CustomerDetails { get; set; }        
        public string PaymentFlag { get; set; }
        public string Reference { get; set; }
        public int KitchenOrderNo { get; set; }
        public float CalculatedValue { get; set; }
        public float CalculatedVat { get; set; }
        public float CalculatedExVatValue { get; set; }       
        public float ServiceCharge { get; set; }
        public float ServiceChargeTax { get; set; }

        public string OrderItemsDetailed { get; set; }

        public OrdersView() { }


        public OrdersView(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                TableIID = dt.Rows[0]["TableIID"].ToString();
                OrderDate = dt.Rows[0]["OrderDate"].ToString();
                Covers = int.Parse(dt.Rows[0]["Covers"].ToString());
                OrderType = dt.Rows[0]["OrderType"].ToString();
                OrderTypeName = ((OrderTypes)int.Parse(OrderType)).ToString();
                Payment = dt.Rows[0]["Payment"].ToString();
                PaymentMethodName = ((PaymentMethods)int.Parse(Payment)).ToString();
                CustomerIID = dt.Rows[0]["CustomerIID"].ToString();
                SessionIID = dt.Rows[0]["SessionIID"].ToString();
                Status = dt.Rows[0]["Status"].ToString();
                StatusName = ((StatusFlags)int.Parse(Status)).ToString();
                LockedClientIP = dt.Rows[0]["LockedClientIP"].ToString();
                Instruction = dt.Rows[0]["Instruction"].ToString();
                
                MoneyPaid = float.Parse(dt.Rows[0]["MoneyPaid"].ToString());
                TableName = dt.Rows[0]["TableName"].ToString();
                CName = dt.Rows[0]["CName"].ToString();
                Postcode = dt.Rows[0]["Postcode"].ToString();
                Address = dt.Rows[0]["Address"].ToString();
                Buzzer = dt.Rows[0]["Buzzer"].ToString();
                Town = dt.Rows[0]["Town"].ToString();
                Tel = dt.Rows[0]["Tel"].ToString();
                Mobile = dt.Rows[0]["Mobile"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                UserName = dt.Rows[0]["UserName"].ToString();
                ItemCount = dt.Rows[0]["ItemCount"].ToString();
                CustomerDetails = dt.Rows[0]["CustomerDetails"].ToString();
                PaymentFlag = dt.Rows[0]["PaymentFlag"].ToString();
                Reference = dt.Rows[0]["Reference"].ToString();
                CalculatedValue = float.Parse(dt.Rows[0]["CalculatedValue"].ToString());
                CalculatedVat = float.Parse( dt.Rows[0]["CalculatedVat"].ToString());
                CalculatedExVatValue = float.Parse(dt.Rows[0]["CalculatedExVatValue"].ToString());
                ServiceCharge = float.Parse(dt.Rows[0]["ServiceCharge"].ToString());
                ServiceChargeTax = float.Parse(dt.Rows[0]["ServiceChargeTax"].ToString());
                try {
                    KitchenOrderNo = int.Parse(dt.Rows[0]["KitchenOrderNo"].ToString());
                } catch {

                }
            }
        }

        public OrdersView(DataRow dr) {

            if (dr != null) {
                IID = dr["IID"].ToString();
                TableIID = dr["TableIID"].ToString();
                OrderDate = dr["OrderDate"].ToString();
                Covers = int.Parse(dr["Covers"].ToString());
                OrderType = dr["OrderType"].ToString();
                OrderTypeName = ((OrderTypes)int.Parse(OrderType)).ToString();
                Payment = dr["Payment"].ToString();
                PaymentMethodName = ((PaymentMethods)int.Parse(Payment)).ToString();
                CustomerIID = dr["CustomerIID"].ToString();
                SessionIID = dr["SessionIID"].ToString();
                Status = dr["Status"].ToString();
                StatusName = ((StatusFlags)int.Parse(Status)).ToString();
                LockedClientIP = dr["LockedClientIP"].ToString();
                Instruction = dr["Instruction"].ToString();

                MoneyPaid = float.Parse(dr["MoneyPaid"].ToString());
                TableName = dr["TableName"].ToString();
                CName = dr["CName"].ToString();
                Postcode = dr["Postcode"].ToString();
                Address = dr["Address"].ToString();
                Buzzer = dr["Buzzer"].ToString();
                Town = dr["Town"].ToString();
                Tel = dr["Tel"].ToString();
                Mobile = dr["Mobile"].ToString();
                Email = dr["Email"].ToString();
                UserName = dr["UserName"].ToString();
                ItemCount = dr["ItemCount"].ToString();
                CustomerDetails = dr["CustomerDetails"].ToString();
                PaymentFlag = dr["PaymentFlag"].ToString();
                Reference = dr["Reference"].ToString();
                CalculatedValue = float.Parse(dr["CalculatedValue"].ToString());
                CalculatedVat = float.Parse(dr["CalculatedVat"].ToString());
                CalculatedExVatValue = float.Parse(dr["CalculatedExVatValue"].ToString());
                ServiceCharge = float.Parse(dr["ServiceCharge"].ToString());
                ServiceChargeTax = float.Parse(dr["ServiceChargeTax"].ToString());
                try {
                    KitchenOrderNo = int.Parse(dr["KitchenOrderNo"].ToString());
                }
                catch {

                }
            }
        }

        public double GetServiceCharge(float rate) {
            return  CalculatedValue * rate / 100;            
        }
    }
}
