using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace DTRMNS {
    public class DTRMLicence {

        public string ReceiptHeader;
        public string ReportHeader;
        public string ShopName;
        public string Address;
        public string Tel;
        public string Fax;
        public string Vat;
        public string SmtpServer;
        public string SmtpEmailAddress;
        public string SmtpFromLabel;
        public string SmtpAccountName;
        public string SmtpPassword;

        public string PopServer;
        public string PopEmailAddress;
        public string PopAccountName;
        public string PopPassword;

        #region "TEMPLATE"
        //Template
        //public DTRMLicence() {
        //    ReceiptHeader = "Template Company\r\n" +
        //        "Template Address\r\n" +
        //        "Template Town\r\n";
        //    ReportHeader = "Template Report Header\r\n" +
        //        "For Template Company\r\n";

        //    ShopName = "Template Shop";
        //    Address = "Template Address";
        //    Tel = "Template Tel";
        //    Fax = "Template Fax";
        //    Vat = "Template Vat";
        //    //LicenceTable = LoadLicence();

        //    SmtpServer = "";
        //    SmtpEmailAddress = "";
        //    SmtpFromLabel = "";
        //    SmtpAccountName = "";
        //    SmtpPassword = "";

        //    PopServer = "";
        //    PopEmailAddress = "";
        //    PopAccountName = "";
        //    PopPassword = "";
        //}
        #endregion
        #region "TEMPLATE"
        //Template
        public DTRMLicence() {
            ReceiptHeader = "Dalyan Camping\r\n" +
                "Kaunos Sokak No:4\r\n" +
                "Dalyan Ortaca Mugla\r\n";
            ReportHeader = "Dalyan Camping\r\n" +
                "\r\n";

            ShopName = "Dalyan Camping";
            Address = "Kaunos Sokak No:4 Dalyan";
            Tel = "0252 284 53 16";
            Fax = "";
            Vat = "Ortaca V.D. 29605876766";
            //LicenceTable = LoadLicence();

            SmtpServer = "";
            SmtpEmailAddress = "";
            SmtpFromLabel = "";
            SmtpAccountName = "";
            SmtpPassword = "";

            PopServer = "";
            PopEmailAddress = "";
            PopAccountName = "";
            PopPassword = "";
        }
        #endregion
        
        ////public DataTable GetLicenceTable() {
        ////    //Create Table 
        ////    DataTable dt = new DataTable("CompanyLicence");

        ////    DataColumn col = new DataColumn();
        ////    col.DataType = System.Type.GetType("System.String");
        ////    col.ColumnName = "ReceiptHeader";
        ////    dt.Columns.Add(col);

        ////    col = new DataColumn();
        ////    col.DataType = System.Type.GetType("System.String");
        ////    col.ColumnName = "ReportHeader";
        ////    dt.Columns.Add(col);
        ////    ////col = new DataColumn();
        ////    ////col.DataType = Type.GetType("System.String");
        ////    ////col.ColumnName = "CatalogName";
        ////    ////dt.Columns.Add(col);
        ////    ////col = new DataColumn();
        ////    ////col.DataType = Type.GetType("System.String");
        ////    ////col.ColumnName = "CatalogFileName";
        ////    ////dt.Columns.Add(col);

        ////    //table ready to load


        ////    DataRow dr = dt.NewRow();
        ////    dr["ReceiptHeader"] = "Hello world company\r\n" +
        ////        "Priorwood Drive\r\n" +
        ////        "Dunfermline\r\n";

        ////    dr["ReportHeader"] = "This is report header\r\n" +
        ////        "For test company\r\n";

        ////    dt.Rows.Add(dr);

        ////    return dt;
        ////}
    }
}
