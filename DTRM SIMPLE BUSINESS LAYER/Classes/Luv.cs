using System;
using System.Data;
using System.ComponentModel;
using System.ComponentModel.Design;
using PosLibrary;

namespace DTRMNS {

    /*
        * [Browsable(false)] = to show property or not
        * [ReadOnly(bool)] = possibility to edit property
        * [Category(string)] = groups of property
        * [Description(string)] = property description.It is a hint
        * [DisplayName(string)] = display property
        * [Editor
        * [Editor(typeof(PropertyGridBrowseEditor), typeof(BaseInputEditor)]
        * */

    [System.Serializable]
    public class Luv {
        #region 10.Shop Details

        [CategoryAttribute("10.Shop Details"), DisplayName("Name of this shop")]
        public string ShopName { get; set; } = "New Shop";

        [CategoryAttribute("10.Shop Details")]
        [EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Address of this shop")]
        public string ShopAddress { get; set; } = "";

        [CategoryAttribute("10.Shop Details"), DisplayName("Phone number")]
        public string Tel1 { get; set; } = "";
        [CategoryAttribute("10.Shop Details"), DisplayName("Phone number")]
        public string Tel2 { get; set; } = "";
        [CategoryAttribute("10.Shop Details"), DisplayName("Fax number")]
        public string Fax { get; set; } = "";
        [CategoryAttribute("10.Shop Details"), DisplayName("Tax number")]
        public string Vat { get; set; } = "";


        [CategoryAttribute("10.Shop Details"), DisplayName("Purchase related email address")]
        public string PurchaseEmail { get; set; } = "";
        [CategoryAttribute("10.Shop Details"), DisplayName("Orders related email address")]
        public string OrdersEmail { get; set; } = "";
        [CategoryAttribute("10.Shop Details"), DisplayName("Report related email address")]
        public string ReportEmail { get; set; } = "";
        [CategoryAttribute("10.Shop Details"), DisplayName("General notification email address")]
        public string NotificationEmail { get; set; } = "";

        #endregion


        #region 11.Miscellaneous
        [CategoryAttribute("11.Miscellaneous"),ReadOnlyAttribute(true), DisplayName("Unique ID for the current session")]
        public string CurrentSessionIID { get; set; }

        private DateTime _SessionStartDateTime = DateTime.Now;
        [CategoryAttribute("11.Miscellaneous"), ReadOnlyAttribute(true), DisplayName("Current session's start date and time")]
        public DateTime SessionStartDateTime { get { return _SessionStartDateTime; } set { _SessionStartDateTime = value; } }

        [CategoryAttribute("11.Miscellaneous"), DisplayName("Text of the button which opens the cash drawer if any attached")]
        public string VoidText { get; set; } = "VOID";

        [CategoryAttribute("11.Miscellaneous"), DisplayName("Default tax rate for newly created categories in the menu")]
        public float DefaultTaxRate { get; set; } = 0.0f;

        [CategoryAttribute("11.Miscellaneous"), DisplayName("Service Charge Rate"), DescriptionAttribute("Service Charge Rate for each order"), DefaultValue(0.0f)]
        public float ServiceChargeRate { get; set; } = 0.0f;

        [CategoryAttribute("11.Miscellaneous"), DisplayName("Service Charge Tax Rate"), DescriptionAttribute("Tax rate of the Service Charge"), DefaultValue(0.0f)]
        public float ServiceChargeTaxRate { get; set; } = 0.0f;

        #endregion

        #region HEADER FOOTER 12.Texts
        [CategoryAttribute("12.Texts"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Header text for the receipts")]
        public string ReceiptHeader { get; set; } = "";
        [CategoryAttribute("12.Texts"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Foor text for the receipts")]
        public string ReceiptFooter { get; set; } = "";

        [CategoryAttribute("12.Texts"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Header text for kitchen slips")]
        public string KitchenHeader { get; set; } = "";
        [CategoryAttribute("12.Texts"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Footer text for kitchen slips")]
        public string KitchenFooter { get; set; } = "";


        [CategoryAttribute("12.Texts"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Header text for daily report")]
        public string ReportHeader { get; set; } = "";
        [CategoryAttribute("12.Texts"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DisplayName("Footer text for daily report")]
        public string ReportFooter { get; set; } = "";
        #endregion

        #region SMTP 
        [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp Server IP Address or Domain Name"), DisplayName("Outgoing email server web address")]
        public string SmtpServer { get; set; } = "";
        [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp From Email")]
        public string SmtpEmailAddress { get; set; } = "";
        [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp From Label")]
        public string SmtpFromLabel { get; set; } = "";
        [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Probably the email address of the smtp user")]
        public string SmtpAccountName { get; set; } = "";
        [CategoryAttribute("13.SMTP(Outgoing email server) Settings"), DescriptionAttribute("Smtp Password"), PasswordPropertyText(true)]
        public string SmtpPassword { get; set; } = "";
        #endregion


        [Browsable(false)]
        public string CustomerKey { get; set; } = "";
        [Browsable(false)]
        public string CustomerPassword { get; set; } = "";


        public Luv() {

        }

        public Luv(DataTable dt) {
            if (dt.Rows.Count > 0) {
                
                ShopName = dt.Rows[0]["ShopName"].ToString();
                ShopAddress = dt.Rows[0]["ShopAddress"].ToString();
                Tel1 = dt.Rows[0]["Tel1"].ToString();
                Tel2 = dt.Rows[0]["Tel2"].ToString();
                Fax = dt.Rows[0]["Fax"].ToString();
                Vat = dt.Rows[0]["Vat"].ToString();
                
                PurchaseEmail = dt.Rows[0]["PurchaseEmail"].ToString();
                OrdersEmail = dt.Rows[0]["OrdersEmail"].ToString();
                ReportEmail = dt.Rows[0]["ReportEmail"].ToString();
                NotificationEmail = dt.Rows[0]["NotificationEmail"].ToString();

                CurrentSessionIID = dt.Rows[0]["CurrentSessionIID"].ToString();
                SessionStartDateTime = DateTime.Parse(dt.Rows[0]["SessionStartDateTime"].ToString());
                VoidText = dt.Rows[0]["VoidText"].ToString();
                DefaultTaxRate = float.Parse(dt.Rows[0]["DefaultTaxRate"].ToString(), System.Globalization.NumberStyles.Any);
                ServiceChargeRate = float.Parse(dt.Rows[0]["ServiceChargeRate"].ToString(), System.Globalization.NumberStyles.Any);
                ServiceChargeTaxRate = float.Parse(dt.Rows[0]["ServiceChargeTaxRate"].ToString(), System.Globalization.NumberStyles.Any);

                ReceiptHeader = dt.Rows[0]["ReceiptHeader"].ToString();
                ReceiptFooter = dt.Rows[0]["ReceiptFooter"].ToString();
                KitchenHeader = dt.Rows[0]["KitchenHeader"].ToString();
                KitchenFooter = dt.Rows[0]["KitchenFooter"].ToString();
                ReportHeader = dt.Rows[0]["ReportHeader"].ToString();
                ReportFooter = dt.Rows[0]["ReportFooter"].ToString();


                SmtpServer = dt.Rows[0]["SmtpServer"].ToString();
                SmtpEmailAddress = dt.Rows[0]["SmtpEmailAddress"].ToString();
                SmtpFromLabel = dt.Rows[0]["SmtpFromLabel"].ToString();
                SmtpAccountName = dt.Rows[0]["SmtpAccountName"].ToString();
                try {
                    SmtpPassword = DRFormat.Decode(dt.Rows[0]["SmtpPassword"].ToString());
                } catch { }

                CustomerKey = dt.Rows[0]["CustomerKey"].ToString();
                try {
                    CustomerPassword = DRFormat.Decode(dt.Rows[0]["CustomerPassword"].ToString());
                } catch { }
            }
        }
    }
}
