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

        #region "BAROQUE"
        //public DTRMLicence() {
        //    ReceiptHeader = "CAFE JACQUES\r\n" +
        //        "10 GRASSMARKET\n" +
        //        "EDINBURGH\r\n" +
        //        "EH1 2JU\r\n" +
        //        "TEL No: 0131 220 5358\r\n" +
        //        "VAT No:945-7399-69";

        //    ReportHeader = "CAFE JACQUES\r\n" +
        //        "10 GRASSMARKET\n" +
        //        "EDINBURGH\r\n" +
        //        "EH1 2JU\r\n" +
        //        "TEL No: 0131 220 5358\r\n" +
        //        "VAT No:945-7399-69";

        //    ShopName = "CAFE JACQUES";
        //    Address = "10 Grassmarket, Edinburgh\r\n" +
        //        "EH1 2JU";
        //    Tel = "0131 220 5358";
        //    Fax = "";
        //    Vat = "945-7399-69";
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

        #region "CAFE TRUVA SHORE"
        //////Cafe Truva
        ////public DTRMLicence() {
        ////    ReceiptHeader = "CAFE TRUVA\r\n" +
        ////        "77 Shore Leith\n" +
        ////        "EDINBURGH EH6 6RG\r\n" +
        ////        "TEL No: 0131 554 5502\r\n" +
        ////        "VAT No:856-2006-37";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "CAFE TRUVA";
        ////    Address = "77 Shore Leith, Edinburgh\r\n" +
        ////        "EH6 6RG";
        ////    Tel = "0131 554 5502";
        ////    Fax = "";
        ////    Vat = "856-2006-37";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "CAFE TRUVA ROYAL"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "CAFE TRUVA ROYAL\r\n" +
        ////        "251 - 253 CANONGATE\n" +
        ////        "EDINBURGH EH8 8BQ\r\n" +
        ////        "TEL No: 0131 556 95 24\r\n" +
        ////        "VAT No:856-2006-37";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "CAFE TRUVA ROYAL";
        ////    Address = "251 - 253 CANONGATE, EDINBURGH\r\n" +
        ////        "EH8 8BQ";
        ////    Tel = "0131 556 95 24";
        ////    Fax = "";
        ////    Vat = "856-2006-37";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "CAFE TROY"
        //////Cafe Troy
        ////public DTRMLicence() {
        ////    ReceiptHeader = "CAFE TROY\r\n" +
        ////        "15 Jarnac Court\n" +
        ////        "DALKEITH, EH22 1HU\r\n" +
        ////        "TEL No: 0131 663 5234\r\n" +
        ////        "VAT No:847-598-366";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "CAFE TROY";
        ////    Address = "15 Jarnac Court, Dalkeith\r\n" +
        ////        "EH22 1HU";
        ////    Tel = "0131 663 5234";
        ////    Fax = "";
        ////    Vat = "847-598-366";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "FAVORIT CAFE BISTRO"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "FAVORIT CAFE BISTRO\r\n" +
        ////        "19-20 Teviot Place\n" +
        ////        "EDINBURGH EH1 2QZ\r\n" +
        ////        "TEL No: 0131 220 6804\r\n" +
        ////        "VAT No:938-418005";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "FAVORIT CAFE BISTRO";
        ////    Address = "19-20 Teviot Place, Edinburgh\r\n" +
        ////        "EH1 2QZ";
        ////    Tel = "0131 220 6804";
        ////    Fax = "";
        ////    Vat = "938-418005";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "DOUBLE DUTCH CAFE BISTRO"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "DOUBLE DUTCH CAFE BISTRO\r\n" +
        ////        "27-29 Marshall Street\n" +
        ////        "EDINBURGH EH8 9BJ\r\n" +
        ////        "TEL No: 0131 667 99 97\r\n";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "DOUBLE DUTCH CAFE BISTRO";
        ////    Address = "27-29 Marshall Street, Edinburgh\r\n" +
        ////        "EH8 9BJ";
        ////    Tel = "0131 667 99 97";
        ////    Fax = "";
        ////    Vat = "";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion


        #region "MAMMAS GRASSMARKET"
        //////Mammas Grassmarket
        ////public DTRMLicence() {
        ////    ReceiptHeader = "MAMMAS PIZZA COMPANY LTD\r\n" +
        ////        "30 THE GRASSMARKET\n" +
        ////        "EDINBURGH\r\n" +
        ////        "EH1 2JU\r\n" +
        ////        "TEL No: 0131 225 64 64\r\n" +
        ////        "VAT No:634 9474 11";

        ////    ReportHeader = "MAMMAS PIZZA COMPANY LTD\r\n" +
        ////        "30 THE GRASSMARKET\n" +
        ////        "EDINBURGH\r\n" +
        ////        "EH1 2JU\r\n" +
        ////        "TEL No: 0131 225 64 64\r\n" +
        ////        "VAT No: 634 9474 11";

        ////    ShopName = "MAMMAS PIZZA COMPANY LTD";
        ////    Address = "30 THE GRASSMARKET\n" +
        ////        "EDINBURGH\r\n" +
        ////        "EH1 2JU";
        ////    Tel = "0131 225 64 64";
        ////    Fax = "";
        ////    Vat = "634 9474 11";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "mail.btconnect.com";
        ////    SmtpEmailAddress = "mammas@btconnect.com";
        ////    SmtpFromLabel = "Mammas Pizza";
        ////    SmtpAccountName = "mammas@btconnect.com";
        ////    SmtpPassword = "fatmamma1";

        ////    PopServer = "pop3.btconnect.com";
        ////    PopEmailAddress = "mammas@btconnect.com";
        ////    PopAccountName = "mammas@btconnect.com";
        ////    PopPassword = "fatmamma1";
        ////}
        #endregion

        #region "Mammas Bruntsfield"
        //////Mammas Bruntsfield
        //public DTRMLicence() {
        //    ReceiptHeader = "MAMMAS PIZZA COMPANY LTD\r\n" +
        //        "139 Bruntsfield Place\n" +
        //        "EDINBURGH\r\n" +
        //        "EH10 4EB\r\n" +
        //        "TEL No: 0131 229 7008\r\n" +
        //        "VAT No:634 9474 11";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "MAMMAS PIZZA COMPANY LTD";
        //    Address = "139 Bruntsfield Place\n" +
        //        "EDINBURGH\r\n" +
        //         "EH10 4EB";
        //    Tel = "0131 229 7008";
        //    Fax = "";
        //    Vat = "634 9474 11";
        //    //LicenceTable = LoadLicence();

        //    SmtpServer = "mail.btconnect.com";
        //    SmtpEmailAddress = "mammas@btconnect.com";
        //    SmtpFromLabel = "Mammas Pizza";
        //    SmtpAccountName = "mammas@btconnect.com";
        //    SmtpPassword = "fatmamma1";

        //    PopServer = "pop3.btconnect.com";
        //    PopEmailAddress = "mammas@btconnect.com";
        //    PopAccountName = "mammas@btconnect.com";
        //    PopPassword = "fatmamma1";
        //}
        #endregion

        #region "LIA"
        //LIA
        ////public DTRMLicence() {
        ////    ReceiptHeader = "LOST IN AMSTERDAM\r\n" +
        ////        "Lounge Cafe\r\n" +
        ////        "Nieuwendijk 19\r\n" +
        ////        "1012 LZ Amsterdam\r\n" +
        ////        "www.lostinamsterdam.com\r\n";

        ////    ReportHeader = "LOST IN AMSTERDAM\r\n" +
        ////        "Lounge Cafe\r\n" +
        ////        "Nieuwendijk 19\r\n" +
        ////        "1012 LZ Amsterdam\r\n" +
        ////        "www.lostinamsterdam.com\r\n";

        ////    ShopName = "LOST IN AMSTERDAM";
        ////    Address = "Nieuwendijk 19, 1012 LZ Amsterdam";
        ////    Tel = "";
        ////    Fax = "";
        ////    Vat = "";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "Wonder Bar"
        //////Wonderbar
        ////public DTRMLicence() {

        ////    ReceiptHeader = "CAFE WONDERBAR\r\n" +
        ////        "Nieuwendijk 3,1012 LZ\n" +
        ////        "AMSTERDAM";

        ////    ReportHeader = "CAFE WONDERBAR\r\n" +
        ////        "Nieuwendijk 3,1012 LZ\n" +
        ////        "AMSTERDAM";

        ////    ShopName = "CAFE WONDERBAR";
        ////    Address = "Nieuwendijk 3,1012 LZ\r\n" +
        ////        "AMSTERDAM";
        ////    Tel = "";
        ////    Fax = "";
        ////    Vat = "";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "THE SANCTUARY"
        //////The Sanctuary
        ////public DTRMLicence() {
        ////    ReceiptHeader = "THE SANCTUARY\r\n" +
        ////        "16-22 Duke Street\n" +
        ////        "EDINBURGH, EH6 8HQ\r\n" +
        ////        "VAT No:621-114-23";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "THE SANCTUARY";
        ////    Address = "16-22 Duke Street, Edinburgh\r\n" +
        ////        "EH6 8HQ";
        ////    Tel = "";
        ////    Fax = "";
        ////    Vat = "621-114-23";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion

        #region "OLLY BONGOS"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "OLLYBONGOS\r\n" +
        ////        "97-101 MORRISON STREET\n" +
        ////        "EDINBURGH, EH3 8BX\r\n" +
        ////    "Tel : 0131 228 8335\r\n" +
        ////    "VAT No:917-743-992"; 

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "OLLYBONGOS";
        ////    Address = "Morrison Street, Edinburgh\r\n" +
        ////        "EH3 8BX";
        ////    Tel = "0131 228 8335";
        ////    Fax = "";
        ////    Vat = "917-743-992";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "TOPKAPI LIVINGSTON"
        //public DTRMLicence() {
        //    ReceiptHeader = "MARMARIS FISH & CHIPS\r\n" +
        //        "7a Craigshill Shopping Mall\n" +
        //        "CRAIGSHILL, LIVINGSTON, EH54 5DZ\r\n" +
        //    "Tel : 01506 44 44 05";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "MARMARIS FISH & CHIPS";
        //    Address = "7a Craigshill Shopping Mall\r\n" +
        //        "CRAIGSHILL, LIVINGSTON, EH54 5DZ";
        //    Tel = "01506 44 44 05";
        //    Fax = "";
        //    Vat = "";
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
        #region "RAMOS"
        //public DTRMLicence() {
        //    ReceiptHeader = "RAMOS GREEK RESTAURANT\r\n" +
        //        "BISTRO MEZE BAR, GANTEP LIMITED\r\n" +
        //        "Unit 17 & 18 Epicurean Food Hall\r\n" +
        //        "Lower Liffey Street, Dublin 1\r\n" +
        //    "Tel : 01 8726 631";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "RAMOS GREEK RESTAURANT";
        //    Address = "BISTRO MEZE BAR, GANTEP LIMITED\r\n" + 
        //        "Unit 17 & 18 Epicurean Food Hall\r\n" +
        //        "CRAIGSHILL, LIVINGSTON, EH54 5DZ";
        //    Tel = "01 8726 631";
        //    Fax = "";
        //    Vat = "";
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
        #region "DRONAX"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "DRONAX COMPUTERS (UK) LTD\r\n" +
        ////        "101 Morrison Street\n" +
        ////        "EDINBURGH, EH3 8BX";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "DRONAX COMPUTERS (UK) LTD";
        ////    Address = "101 Morrison Street, Edinburgh\r\n" +
        ////        "EH3 8BX";
        ////    Tel = "0131 656 03 77";
        ////    Fax = "0131 656 03 99";
        ////    Vat = "";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "GLENHAS ROYALMILE"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "GLENHAS DELICATESSEN\r\n" +
        ////        "44 RoyalMile\n" +
        ////        "EDINBURGH, EH1 1TB";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "GLENHAS DELI";
        ////    Address = "44 RoyalMile, Edinburgh\r\n" +
        ////        "EH1 1TB";
        ////    Tel = "0131 557 82 73";
        ////    Fax = "";
        ////    Vat = "";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "GLENHAS CANONGATE"
        //public DTRMLicence() {
        //    ReceiptHeader = "CANONGATE CAFE\r\n" +
        //        "274 Canongate, Old Town\n" +
        //        "EDINBURGH, EH8 8AA";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "CANONGATE CAFE";
        //    Address = "274 Canongate, Old Town\r\n" +
        //        "Edinburgh, EH8 8AA";
        //    Tel = "0131 652 35 34";
        //    Fax = "";
        //    Vat = "";
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

        #region "GLENHAS TEVIOT"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "OLLY BONGOS\r\n" +
        ////        "4 Teviot Place, Edinburgh\r\n" +
        ////        "EDINBURGH, EH1 2QZ,\r\n" +
        ////        "VAT No:917-743-992"; ;
        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "GLENHAS CAFE";
        ////    Address = "4 Teviot Place, Edinburgh\r\n" +
        ////        "EH8 8AA\r\n" +
        ////        "VAT 889 132 486\r\n";
        ////    Tel = "0131 225 28 49";
        ////    Fax = "";
        ////    Vat = "917-743-992";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "GLENHAS TEVIOT 2 mehmet"
        //public DTRMLicence() {
        //    ReceiptHeader = "OLLY BONGOS\r\n" +
        //        "4 Teviot Place, Edinburgh\r\n" +
        //        "EDINBURGH, EH1 2QZ,\r\n";
            
        //        //"VAT No:"; ;
        //    ReportHeader = ReceiptHeader;

        //    ShopName = "GLENHAS CAFE";
        //    Address = "4 Teviot Place, Edinburgh\r\n" +
        //        "EH8 8AA\r\n" +
        //        "VAT 889 132 486\r\n";
        //    Tel = "0131 225 28 49";
        //    Fax = "";
        //    Vat = "";
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
        #region "EMPIRES"
        ////public DTRMLicence() {
        ////    ////ReceiptHeader = "EMPIRES\r\n" +
        ////    ////    "Ceramic & Lamp Emporium Cafe\r\n" +
        ////    ////    "24 St.Mary Street\r\n" +
        ////    ////    "EDINBURGH, EH1 1SU\r\n" +
        ////    ////    "TEL No: 0131 466 01 00\r\n" +
        ////    ////    "VAT No: 860 1418 48";

        ////    ////ReportHeader = ReceiptHeader;

        ////    ////ShopName = "EMPIRES CAFE";
        ////    ////Address = "24 St.Mary Street\r\n" +
        ////    ////    "EDINBURGH, EH1 1SU\r\n";
        ////    ////Tel = "0131 466 01 00";
        ////    ////Fax = "";
        ////    ////Vat = "860 1418 48";

        ////    ReceiptHeader = "EMPIRES\r\n" +
        ////       "Ceramic & Lamp Emporium Cafe\r\n" +
        ////       "24 St.Mary Street\r\n" +
        ////       "EDINBURGH, EH1 1SU\r\n" +
        ////       "TEL No: 0131 466 01 00";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "EMPIRES CAFE";
        ////    Address = "24 St.Mary Street\r\n" +
        ////        "EDINBURGH, EH1 1SU\r\n";
        ////    Tel = "0131 466 01 00";
        ////    Fax = "";
        ////    Vat = "";


        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "THE CLOCK"
        //public DTRMLicence() {
        //    ReceiptHeader = "\r\n\r\n\r\n\r\nTHE CLOCK CAFE\r\n" +
        //        "394 MORNINGSIDE ROAD\r\n" +
        //        "EDINBURGH, EH10 5HX\r\n" +
        //        "TEL No: 0131 447 92 87";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "THE CLOCK CAFE";
        //    Address = "394 MORNINGSIDE ROAD\r\n" +
        //        "EDINBURGH, EH10 5HX\r\n";
        //    Tel = "0131 447 92 87";
        //    Fax = "";
        //    Vat = "";
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
        #region "GLENHAS 205 High Street"
        //public DTRMLicence()
        //{
        //    ReceiptHeader = "GLENHAS CAFE\r\n" +
        //        "205 High Street, Royal Mile\r\n" +
        //        "EDINBURGH, EH1 2PS\r\n";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "GLENHAS CAFE";
        //    Address = "205 High Street, Royal Mile\r\n" +
        //        "EDINBURGH, EH1 2PS\r\n";
        //    Tel = "";
        //    Fax = "";
        //    Vat = "";
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
        #region "CAFE 394"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "CAFE 394\r\n" +
        ////        "394 MORNINGSIDE ROAD\r\n" +
        ////        "EDINBURGH, EH10 5HX\r\n" +
        ////        "TEL : (0131) 447 92 87\r\n";
        ////    ReportHeader = "CAFE 394\r\n" +
        ////        "394 MORNINGSIDE ROAD\r\n" +
        ////        "EDINBURGH, EH10 5HX\r\n" +
        ////        "TEL : (0131) 447 92 87\r\n";

        ////    ShopName = "CAFE 394";
        ////    Address = "394 MORNINGSIDE ROAD\r\n" +
        ////        "EDINBURGH, EH10 5HX\r\n";
        ////    Tel = "(0131) 447 92 87";
        ////    Fax = "";
        ////    Vat = "";
        ////    //LicenceTable = LoadLicence();

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "BRIDGES"
        //public DTRMLicence() {
        //    ReceiptHeader = "BRIDGES\r\n" +
        //        "Restaurant & Cafe\r\n" +
        //        "3 - 5 Thames Street\r\n" +
        //        "Kingston Upon Thames\r\n" +
        //        "KT1 1PH\r\n" +
        //        "VAT 527619429\r\n" +
        //        "TEL : 0208 546 44 64\r\n";
        //    ReportHeader = "BRIDGES\r\n" +
        //        "Restaurant & Cafe\r\n" +
        //        "3 - 5 Thames Street\r\n" +
        //        "Kingston Upon Thames\r\n" +
        //        "KT1 1PH\r\n" +
        //        "VAT 527619429\r\n" +
        //        "TEL : 0208 546 44 64\r\n";

        //    ShopName = "BRIDGES";
        //    Address = "3 - 5 Thames Street\r\n" +
        //        "Kingston Upon Thames\r\n" +
        //        "KT1 1PH\r\n";
        //    Tel = "0208 546 44 64";
        //    Fax = "";
        //    Vat = "527619429";
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

        #region DOUCE
        //public DTRMLicence() {
        //    ReceiptHeader = "CAFE  DOUCE  FRANCE\r\n\r\n" +
        //        "251 - 253 CANONGATE\n" +
        //        "EDINBURGH\r\n" +
        //        "EH8 8BQ\r\n" +
        //        "TEL No: 0131 556 95 24\r\n" +
        //        "VAT No:917-743-992";

        //    ReportHeader = "CAFE  DOUCE  FRANCE\r\n\r\n" +
        //        "251 - 253 CANONGATE\n" +
        //        "EDINBURGH\r\n" +
        //        "EH8 8BQ\r\n" +
        //        "TEL No: 0131 556 95 24\r\n" +
        //        "VAT No:917-743-992";

        //    ShopName = "CAFE  DOUCE  FRANCE";
        //    Address = "251- 253 Canongate, Edinburgh\r\n" +
        //        "EH8 8BQ";
        //    Tel = "0131 556 95 24";
        //    Fax = "";
        //    Vat = "";
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
        #region "KAMBER"
        //public DTRMLicence() {
        //    ReceiptHeader = "CAFE RODI\r\n" +
        //        "119 Nicolson Street, Edinburgh\r\n" +
        //        "EDINBURGH, EH8 9ER\r\n" +
        //    "Tel : 0131 667 66 64";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "CAFE RODI";
        //    Address = "119 Nicolson Street, Edinburgh\r\n" +
        //        "EDINBURGH, EH8 9ER";
        //    Tel = "0131 667 66 64";
        //    Fax = "";
        //    Vat = "";

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
        #region "TURQUAZ"
        ////public DTRMLicence() {
        ////    ReceiptHeader = "CAFE TURQUAZ\r\n" +
        ////        "119 Nicolson Street, Edinburgh\r\n" +
        ////        "EDINBURGH, EH8 9ER\r\n" +
        ////    "Tel : 0131 667 66 64";

        ////    ReportHeader = ReceiptHeader;

        ////    ShopName = "CAFE TURQUAZ";
        ////    Address = "119 Nicolson Street, Edinburgh\r\n" +
        ////        "EDINBURGH, EH8 9ER";
        ////    Tel = "0131 667 66 64";
        ////    Fax = "";
        ////    Vat = "";

        ////    SmtpServer = "";
        ////    SmtpEmailAddress = "";
        ////    SmtpFromLabel = "";
        ////    SmtpAccountName = "";
        ////    SmtpPassword = "";

        ////    PopServer = "";
        ////    PopEmailAddress = "";
        ////    PopAccountName = "";
        ////    PopPassword = "";
        ////}
        #endregion
        #region "NEWINGTON CAFE"
        //public DTRMLicence() {
        //    ReceiptHeader = "NEWINGTON COFFEE SHOP\r\n" +
        //        "69 South Clerk Street\r\n" +
        //        "EDINBURGH, EH8 9PP\r\n" +
        //    "Tel : 0131 667 00 44";

        //    ReportHeader = ReceiptHeader;

        //    ShopName = "NEWINGTON COFFEE SHOP";
        //    Address = "69 South Clerk Street\r\n" +
        //        "EDINBURGH, EH8 9PP";
        //    Tel = "0131 667 00 44";
        //    Fax = "";
        //    Vat = "";

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

        #region "DELI CAFE"
        //public DTRMLicence()
        //{
        //    ReceiptHeader = "RICHMOND CAFE\r\n" +
        //        "52 West Richmond Street, Edinburgh\r\n" +
        //        "EDINBURGH, EH8 9DZ\r\n" +
        //        "VAT No: 942-322-249";
        //    ReportHeader = ReceiptHeader;

        //    ShopName = "RICHMOND CAFE";
        //    Address = "52 West Richmond Street, Edinburgh\r\n" +
        //        "EH8 9DZ\r\n" +
        //        "VAT 942-322-249\r\n";
        //    Tel = "";
        //    Fax = "";
        //    Vat = "942-322-249";
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

        #region "AULD JOCK"
        //public DTRMLicence() {
        //    ReceiptHeader = "Auld Jock's Pie Shoppe\r\n" +
        //        "27 George Forth Bridge\r\n" +
        //        "EDINBURGH, EH1 1EN\r\nVAT # : 945 7399 69\r\n";
        //    ReportHeader = ReceiptHeader;

        //    ShopName = "AULD JOCK'S PIE SHOPPE";
        //    Address = "27 George Forth Bridge, Edinburgh\r\n" +
        //        "EH1 1EN\r\n";
        //    Tel = "0131 226 44 49";
        //    Fax = "";
        //    Vat = "945 7399 69";
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
