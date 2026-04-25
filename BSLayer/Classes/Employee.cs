using System.Data;
using PosLibrary.DBSpace;
using PosLibrary;

namespace DTRMNS {

    [System.Serializable]
    public class Employee {
        private string _IID = ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string EmployeeName { get; set; }
        public float Rate { get; set; }

        public bool Shortable { get; set; }
        public Employee() {
        }
        public Employee(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                EmployeeName = dt.Rows[0]["EmployeeName"].ToString();
                Rate = float.Parse(dt.Rows[0]["Rate"].ToString());
                Shortable = (int.Parse(dt.Rows[0]["Shortable"].ToString()) == 0 ? false : true);
            }
        }
        public Employee(DataRow dr) {

            IID = dr["IID"].ToString();
            EmployeeName = dr["EmployeeName"].ToString();
            Rate = float.Parse(dr["Rate"].ToString());
            Shortable = (int.Parse(dr["Shortable"].ToString()) == 0 ? false : true);
        }

        public bool Delete(DB db) {
            return db.RunQuery("DeleteEmployee '" + IID + "'");
        }
        public bool Save(DB db) {
            return db.RunQuery("SaveEmployee '" + IID + "','" + EmployeeName + "','" + Rate + "'," + db.BoolToInt(Shortable));
        }
    }

}
