using System.Data;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class Instruct {
        private string _IID;
        public string IID { get { return _IID; } set { _IID = value; } }
        public string Instruction { get; set; }

        public Instruct() {
            IID = ShortGuid.NewGuid().ToString();
            Instruction = "";
        }
        public Instruct(string Instruction) {
            IID = ShortGuid.NewGuid().ToString();
            this.Instruction = Instruction;
        }
        public Instruct(string IID, string Instruction) {
            this.IID = IID;
            this.Instruction = Instruction;
        }

        public Instruct(DataTable dt) {
            if (dt.Rows.Count > 0) {
                IID = dt.Rows[0]["IID"].ToString();
                Instruction = dt.Rows[0]["Instruction"].ToString();
            }
        }
        public Instruct(DataRow dr) {
            if (dr != null) {
                IID = dr["IID"].ToString();
                Instruction = dr["Instruction"].ToString();
            }
        }
    }
}
