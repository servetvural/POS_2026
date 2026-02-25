using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTRMNS {

    [System.Serializable]
    public class Invoice
    {
        private string _IID;
        private string _CustomerIID;
        private int _InvoiceNumber;
        private DateTime _InvoiceDate;
        private float _SubTotal;
        private float _VatRate;
        private float _Vat;
        private float _Total;
        private string _Notes;

        public Invoice()
        {
            IID = Guid.NewGuid().ToString();
        }
        public Invoice(DataRow dr)
        {
            IID = dr["IID"].ToString();
            CustomerIID = dr["CustomerIID"].ToString();
            InvoiceNumber = int.Parse(dr["InvoiceNumber"].ToString());
            InvoiceDate = (DateTime)dr["InvoiceDate"];
            SubTotal = float.Parse(dr["SubTotal"].ToString(), System.Globalization.NumberStyles.Any);
            VatRate = float.Parse(dr["VatRate"].ToString(), System.Globalization.NumberStyles.Any);
            Vat = float.Parse(dr["Vat"].ToString(), System.Globalization.NumberStyles.Any);
            Total = float.Parse(dr["Total"].ToString(), System.Globalization.NumberStyles.Any);
            Notes = dr["Notes"].ToString();
        }
        public string IID { get { return _IID; } set { _IID = value; } }
        public string CustomerIID { get { return _CustomerIID; } set { _CustomerIID = value; } }
        public int InvoiceNumber { get { return _InvoiceNumber; } set { _InvoiceNumber = value; } }
        public DateTime InvoiceDate { get { return _InvoiceDate; } set { _InvoiceDate = value; } }
        public float SubTotal { get { return _SubTotal; } set { _SubTotal = value; } }
        public float VatRate { get { return _VatRate; } set { _VatRate = value; } }
        public float Vat { get { return _Vat; } set { _Vat = value; } }
        public float Total { get { return _Total; } set { _Total = value; } }
        public string Notes { get { return _Notes; } set { _Notes = value; } }
    }

}
