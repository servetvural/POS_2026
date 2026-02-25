using System;
using System.Data;
using PosLibrary;

namespace DTRMNS {

    [System.Serializable]
    public class SessionData 
    {
        public string SessionIID { get; set; }
        public DateTime SessionStartDateTime { get; set; }
        public DateTime SessionEndDateTime { get; set; }
        public float GrossSessionTotal { get; set; }
        public float GrossSessionTotalUncompleted { get; set; }

        public float peny1 { get; set; }
        public float peny2 { get; set; }
        public float peny5 { get; set; }
        public float peny10 { get; set; }
        public float peny20 { get; set; }
        public float peny50 { get; set; }
        public float pound1 { get; set; }
        public float pound2 { get; set; }
        public float pound5 { get; set; }
        public float pound10 { get; set; }
        public float pound20 { get; set; }
        public float pound50 { get; set; }
        public float pound100 { get; set; }
        public float pound200 { get; set; }
        public float pound500 { get; set; }
        public float pound1000 { get; set; }
        public float CashTotal { get; set; }
        public float CardTotal { get; set; }
        public float OnlineTotal { get; set; }

        public float X1Total { get; set; }
        public float X2Total { get; set; }
        public float X3Total { get; set; }
        


        //Functional
        public float NetPaidTotal { get { return GrossSessionTotal - GrossSessionTotalUncompleted; } }

        public SessionData()
        {
            SessionIID = ShortGuid.NewGuid().ToString();
            DateTime dtnow = DateTime.Now;
            SessionStartDateTime = dtnow;
            SessionEndDateTime = dtnow;
            GrossSessionTotal = 0f;
        }
        public SessionData(DataRow dr) {
            Load(dr);
        }

        private void Load(DataRow dr) { 
            SessionIID = dr["IID"].ToString();
            SessionStartDateTime = DateTime.Parse(dr["StartDate"].ToString());
            try {
                SessionEndDateTime = DateTime.Parse(dr["EndDate"].ToString());
            } catch {

            }
            GrossSessionTotal = float.Parse(dr["GrossSessionTotal"].ToString());
            try {
                GrossSessionTotalUncompleted = float.Parse(dr["GrossSessionTotalUncompleted"].ToString());
            } catch { }

            peny1 = float.Parse(dr["peny1"].ToString());
            peny2 = float.Parse(dr["peny2"].ToString());
            peny5 = float.Parse(dr["peny5"].ToString());
            peny10 = float.Parse(dr["peny10"].ToString());
            peny20 = float.Parse(dr["peny20"].ToString());
            peny50 = float.Parse(dr["peny50"].ToString());
            pound1 = float.Parse(dr["pound1"].ToString());
            pound2 = float.Parse(dr["pound2"].ToString());
            pound5 = float.Parse(dr["pound5"].ToString());
            pound10 = float.Parse(dr["pound10"].ToString());
            pound20 = float.Parse(dr["pound20"].ToString());
            pound50 = float.Parse(dr["pound50"].ToString());
            pound100 = float.Parse(dr["pound100"].ToString());
            pound200 = float.Parse(dr["pound200"].ToString());
            pound500 = float.Parse(dr["pound500"].ToString());
            pound1000 = float.Parse(dr["pound1000"].ToString());

            CashTotal = float.Parse(dr["CashTotal"].ToString());
            CardTotal = float.Parse(dr["CardTotal"].ToString());
            OnlineTotal = float.Parse(dr["OnlineTotal"].ToString());

            X1Total = float.Parse(dr["X1Total"].ToString());
            X2Total = float.Parse(dr["X2Total"].ToString());
            X3Total = float.Parse(dr["X3Total"].ToString());
                     

        }

        public SessionData(DataTable dt) {
            Load(dt.Rows[0]);
        }
    }

}
