using System.Data;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace DTRMNS {

    [System.Serializable]
    public class WebSettings
    {
        /*
         * [Browsable(false)] = to show property or not
         * [ReadOnly(bool)] = possibility to edit property
         * [Category(string)] = groups of property
         * [Description(string)] = property description.It is a hint
         * [DisplayName(string)] = display property
         * [Editor
         * [Editor(typeof(PropertyGridBrowseEditor), typeof(BaseInputEditor)]
         * */

        [Browsable(false)]
        public string IID { get; set; }

        //[Editor(typeof(PropertyGridBrowseEditor), typeof(BaseInputEditor)]


        public string Logo1 { get; set; }
        public string Logo2 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax1 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string PurchaseEmail { get; set; }
        public string OrdersEmail { get; set; }
        public string ReportEmail { get; set; }
        public string NotificationEmail { get; set; }        
        
     
  

        public WebSettings()
        {
            IID = "English";
            Logo1 = "";
            Logo2 = "";
            Tel1 = "";
            Tel2 = "";
            Fax1 = "";
            Email1 = "";
            Email2 = "";
            PurchaseEmail = "";
            OrdersEmail = "";
            ReportEmail = "";
            NotificationEmail = "";
        }
        public WebSettings(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                IID = dt.Rows[0]["IID"].ToString();
                Logo1 = dt.Rows[0]["Logo1"].ToString();
                Logo2 = dt.Rows[0]["Logo2"].ToString();
                Tel1 = dt.Rows[0]["Tel1"].ToString();
                Tel2 = dt.Rows[0]["Tel2"].ToString();
                Fax1 = dt.Rows[0]["Fax1"].ToString();
                Email1 = dt.Rows[0]["Email1"].ToString();
                Email2 = dt.Rows[0]["Email2"].ToString();
                PurchaseEmail = dt.Rows[0]["PurchaseEmail"].ToString();
                OrdersEmail = dt.Rows[0]["OrdersEmail"].ToString();
                ReportEmail = dt.Rows[0]["ReportEmail"].ToString();
                NotificationEmail = dt.Rows[0]["NotificationEmail"].ToString();
                
            }
        }
        


    }

}
