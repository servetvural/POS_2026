using System;
using System.Collections.Generic;
using System.Text;
using DronaxLibrary.DBSpace;
using System.Data;

namespace DTRMNS {
    public class PrintQueueItem
    {
        private string _IID;
        private string _OrderIID;
        private DateTime _TimeStampMark;

        public string IID { get { return _IID; } set { _IID = value; } }
        public string OrderIID { get { return _OrderIID; } set { _OrderIID = value; } }
        public DateTime TimeStampMark { get { return _TimeStampMark; } set { _TimeStampMark = value; } }


        public PrintQueueItem()
        {
            _IID = Guid.NewGuid().ToString();
            _OrderIID = "";
            _TimeStampMark = DateTime.Now;
        }
        public PrintQueueItem(string OrderIID)
        {
            _IID = Guid.NewGuid().ToString();
            _OrderIID = OrderIID;
            _TimeStampMark = DateTime.Now;
        }
        public PrintQueueItem(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                _IID = dt.Rows[0]["IID"].ToString();
                _OrderIID = dt.Rows[0]["OrderIID"].ToString();
                _TimeStampMark = DateTime.Parse(dt.Rows[0]["TimeStampMark"].ToString());
            }
        }
        public PrintQueueItem(DataRow dr)
        {
            _IID = dr["IID"].ToString();
            _OrderIID = dr["OrderIID"].ToString();
            _TimeStampMark = DateTime.Parse(dr["TimeStampMark"].ToString());
        }
        public bool Delete(DB db)
        {
            return db.RunQuery("DeletePrintQueueItem " +
            "'" + _IID.Replace("'", "''") + "'");
        }
        public bool Save(DB db)
        {
            return db.RunQuery("SavePrintQueueItem " +
                "'" + _IID.Replace("'", "''") + "','" + _OrderIID.Replace("'", "''") + "','" + db.DatetimeToMSSqlDatetime(_TimeStampMark) + "'");
        }
    }

}
