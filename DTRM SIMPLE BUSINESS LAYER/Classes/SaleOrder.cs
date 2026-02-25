using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace DTRMNS {
    [System.Xml.Serialization.XmlInclude(typeof(SaleOrderItem))]
    [System.Xml.Serialization.XmlInclude(typeof(SaleOrder))]
    [System.Serializable]
    public class SaleOrder
    {
        private string _IID;
        private string _CustomerIID;
        private int _SONumber;
        private DateTime _SaleOrderDate;
        private string _DeliveryDate;
        private string _InvoiceIID;
        private string _ManagedBy;
        public ArrayList Items;

        public SaleOrder()
        {
            Items = new ArrayList();
            IID = Guid.NewGuid().ToString();
            _SaleOrderDate = DateTime.Now;
            _InvoiceIID = "";
            _ManagedBy = "";
            _DeliveryDate = "";
            _SONumber = 0;
        }
        public SaleOrder(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                Items = new ArrayList();
                IID = dt.Rows[0]["IID"].ToString();
                CustomerIID = dt.Rows[0]["CustomerIID"].ToString();
                SONumber = int.Parse(dt.Rows[0]["SONumber"].ToString());
                SaleOrderDate = (DateTime)dt.Rows[0]["SaleOrderDate"];
                DeliveryDate = dt.Rows[0]["DeliveryDate"].ToString();
                InvoiceIID = dt.Rows[0]["InvoiceIID"].ToString();
                ManagedBy = dt.Rows[0]["ManagedBy"].ToString();
            }
        }
        public string IID { get { return _IID; } set { _IID = value; } }
        public string CustomerIID { get { return _CustomerIID; } set { _CustomerIID = value; } }
        public int SONumber { get { return _SONumber; } set { _SONumber = value; } }
        public DateTime SaleOrderDate { get { return _SaleOrderDate; } set { _SaleOrderDate = value; } }
        public string DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }
        public string InvoiceIID { get { return _InvoiceIID; } set { _InvoiceIID = value; } }
        public string ManagedBy { get { return _ManagedBy; } set { _ManagedBy = value; } }
    }

}
