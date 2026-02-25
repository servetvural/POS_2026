using System.Data;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class Supplier {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string SupplierName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Whatsup { get; set; }

        public Supplier() {

        }

        public Supplier(DataTable dt) {
            if (dt != null) {
                try {
                    this.IID = dt.Rows[0]["IID"].ToString();
                    this.SupplierName = dt.Rows[0]["SupplierName"].ToString();
                    this.Tel = dt.Rows[0]["Tel"].ToString();
                    this.Address = dt.Rows[0]["Address"].ToString();
                    this.Email1 = dt.Rows[0]["Email1"].ToString();
                    this.Email2 = dt.Rows[0]["Email2"].ToString();
                    this.Whatsup = dt.Rows[0]["Whatsup"].ToString();
                } catch {
                }
            }
        }

        public Supplier(DataRow dr) {
            if (dr != null) {
                try {
                    this.IID = dr["IID"].ToString();
                    this.SupplierName = dr["SupplierName"].ToString();
                    this.Tel = dr["Tel"].ToString(); 
                    this.Address = dr["Address"].ToString();
                    this.Email1 = dr["Email1"].ToString();
                    this.Email2 = dr["Email2"].ToString();
                    this.Whatsup = dr["Whatsup"].ToString();
                } catch {
                }
            }
        }

    }
}
