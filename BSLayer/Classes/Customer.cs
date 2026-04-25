using System.Data;
using PosLibrary.DBSpace;
using PosLibrary;

namespace DTRMNS {

    [System.Serializable]
    public class Customer {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string CName { get; set; }
        public string CompanyName { get; set; }
        public string PostCode { get; set; }
        public string Buzzer { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string CPassword { get; set; }

        public Customer() {
        }
        public  Customer(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                CName = dt.Rows[0]["CName"].ToString();
                CompanyName = dt.Rows[0]["CompanyName"].ToString();
                PostCode = dt.Rows[0]["PostCode"].ToString();
                Buzzer = dt.Rows[0]["Buzzer"].ToString();
                Address = dt.Rows[0]["Address"].ToString();
                Town = dt.Rows[0]["Town"].ToString();
                Tel = dt.Rows[0]["Tel"].ToString();
                Fax = dt.Rows[0]["Fax"].ToString();
                Mobile = dt.Rows[0]["Mobile"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                CPassword = dt.Rows[0]["CPassword"].ToString();
            }
        }
        public Customer(DataRow dr) {
            
                IID = dr["IID"].ToString();
                CName = dr["CName"].ToString();
                CompanyName = dr["CompanyName"].ToString();
                PostCode = dr["PostCode"].ToString();
                Buzzer = dr["Buzzer"].ToString();
                Address = dr["Address"].ToString();
                Town = dr["Town"].ToString();
                Tel = dr["Tel"].ToString();
                Fax = dr["Fax"].ToString();
                Mobile = dr["Mobile"].ToString();
                Email = dr["Email"].ToString();
                CPassword = dr["CPassword"].ToString();
           
        }

        public bool Delete(DB db) {
            return db.RunQuery("DeleteCustomer '" + IID + "'");
        }
        public bool Save(DB db) {
            return db.RunQuery("SaveCustomer '" + IID + "','" + CName + "','" + CompanyName + "','" +
                  Buzzer + "','" + PostCode + "','" + Address + "','" +
                  Town + "','" + Tel + "','" + Mobile + "','" +
                  Email + "','" + CPassword + "'");
        }
    }

}
