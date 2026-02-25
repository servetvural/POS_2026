using System;
using System.Data;

namespace DTRMNS {
    public class IIDName {
        public string IID { get; set; }
        public string Name { get; set; }
        public IIDName() {

        }
        public IIDName(string IID, string Name) {
            this.IID = IID;
            this.Name = Name;
        }
        public IIDName(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            Name = dt.Rows[0]["Name"].ToString();
        }
        public IIDName(DataRow dr) {
            IID = dr["IID"].ToString();
            Name = dr["Name"].ToString();
        }
    }


    public class IIDValueDate {
        public string IID { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public IIDValueDate() {

        }
        public IIDValueDate(string IID, float Value) {
            this.IID = IID;
            this.Value = Value;
        }
        public IIDValueDate(string IID, float Value, DateTime Date) {
            this.IID = IID;
            this.Value = Value;
            this.Date = Date;
        }
        public IIDValueDate(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            Value = float.Parse(dt.Rows[0]["Value"].ToString());
            Date = DateTime.Parse(dt.Rows[0]["Date"].ToString());
        }
        public IIDValueDate(DataRow dr) {
            IID = dr["IID"].ToString();
            Value = float.Parse(dr["Value"].ToString());
            Date = DateTime.Parse(dr["Date"].ToString());
        }
    }

    public class IIDDate {
        public string IID { get; set; }
        public DateTime Date { get; set; }
        public IIDDate() {

        }
        public IIDDate(string IID,  DateTime Date) {
            this.IID = IID;
            this.Date = Date;
        }
        public IIDDate(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            Date = DateTime.Parse(dt.Rows[0]["Date"].ToString());
        }
        public IIDDate(DataRow dr) {
            IID = dr["IID"].ToString();
            Date = DateTime.Parse(dr["Date"].ToString());
        }
    }

    public class Debug {      
        public int DebugNo { get; }
        public DateTime EventDateTime { get; set; }
        public string Data { get; set; }

        public Debug() {

        }
        public Debug(DateTime EventDateTime, string Data) {
            this.Data = Data;
            this.EventDateTime = EventDateTime;
        }
        public Debug(DataTable dt) {
            DebugNo = int.Parse(dt.Rows[0]["DebugNo"].ToString());
            Data = dt.Rows[0]["Data"].ToString();
            EventDateTime = DateTime.Parse(dt.Rows[0]["EventDateTime"].ToString());
        }
        public Debug(DataRow dr) {
            DebugNo = int.Parse(dr["DebugNo"].ToString());
            Data = dr["Data"].ToString();
            EventDateTime = DateTime.Parse(dr["EventDateTime"].ToString());
        }
    }
}
