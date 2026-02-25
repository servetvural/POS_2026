using System;
using System.Collections.Generic;
using System.Text;

namespace DTRMNS {
    [System.Serializable]
    public class SaleOrderView
    {
        private string _IID;
        private int _SONumber;
        private DateTime _SaleOrderDate;
        private string _CustomerIID;
        private string _CompanyName;
        private string _DeliveryDate;
        private string _InvoiceIID;
        private int _InvoiceNumber;
        private string _InvoiceDate;
        private string _ManagedBy;

        public SaleOrderView() { }
        public string IID { get { return _IID; } set { _IID = value; } }
        public int SONumber { get { return _SONumber; } set { _SONumber = value; } }
        public DateTime SaleOrderDate { get { return _SaleOrderDate; } set { _SaleOrderDate = value; } }
        public string CustomerIID { get { return _CustomerIID; } set { _CustomerIID = value; } }
        public string CompanyName { get { return _CompanyName; } set { _CompanyName = value; } }
        public string DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }
        public string InvoiceIID { get { return _InvoiceIID; } set { _InvoiceIID = value; } }
        public int InvoiceNumber { get { return _InvoiceNumber; } set { _InvoiceNumber = value; } }
        public string InvoiceDate { get { return _InvoiceDate; } set { _InvoiceDate = value; } }
        public string ManagedBy { get { return _ManagedBy; } set { _ManagedBy = value; } }
    }

}
