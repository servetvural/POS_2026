using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace DTRMNS {

    [System.Xml.Serialization.XmlInclude(typeof(SaleOrderCatalog))]
    [System.Xml.Serialization.XmlInclude(typeof(SaleOrderCatalogItem))]
    [System.Serializable]
    public class SaleOrderCatalog
    {
        private string _IID;
        private string _CatalogName;
        private DateTime _ValidFrom;
        private DateTime _ExpiryDate;
        private string _COName;
        private string _COAddress;
        private string _COTel;
        private string _COFax;
        private string _COEmail;
        private string _COWebsite;
        public ArrayList Items;

        public SaleOrderCatalog()
        {
            IID = Guid.NewGuid().ToString();
            Items = new ArrayList();
        }
        public SaleOrderCatalog(DataRow dr)
        {
            Items = new ArrayList();
            IID = dr["IID"].ToString();
            CatalogName = dr["CatalogName"].ToString();
            ValidFrom = (DateTime)dr["ValidFrom"];
            ExpiryDate = (DateTime)dr["ExpiryDate"];
            COName = dr["COName"].ToString();
            COAddress = dr["COAddress"].ToString();
            COTel = dr["COTel"].ToString();
            COFax = dr["COFax"].ToString();
            COEmail = dr["COEmail"].ToString();
            COWebsite = dr["COWebsite"].ToString();
        }
        public string IID { get { return _IID; } set { _IID = value; } }
        public string CatalogName { get { return _CatalogName; } set { _CatalogName = value; } }
        public DateTime ValidFrom { get { return _ValidFrom; } set { _ValidFrom = value; } }
        public DateTime ExpiryDate { get { return _ExpiryDate; } set { _ExpiryDate = value; } }
        public string COName { get { return _COName; } set { _COName = value; } }
        public string COAddress { get { return _COAddress; } set { _COAddress = value; } }
        public string COTel { get { return _COTel; } set { _COTel = value; } }
        public string COFax { get { return _COFax; } set { _COFax = value; } }
        public string COEmail { get { return _COEmail; } set { _COEmail = value; } }
        public string COWebsite { get { return _COWebsite; } set { _COWebsite = value; } }
    }

}
