using System.Data;
using PosLibrary.DBSpace;
using PosLibrary;

namespace DTRMNS {
    public class TableGroup {
        public string IID { get; set; }
        public string GroupName { get; set; }
        public int DisplayOrder { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public TableGroup() {
            IID = ShortGuid.NewGuid().ToString();
            GroupName = "Unknown";
        }
        public TableGroup(string IID, string GroupName) {
            this.IID = IID;
            this.GroupName = GroupName;
            Width = 300;
            Height = 300;
        }
        public TableGroup(string GroupName) {
            this.IID = ShortGuid.NewGuid().ToString();
            this.GroupName = GroupName;
            Width = 300;
            Height = 300;
        }
        public TableGroup(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            GroupName = dt.Rows[0]["GroupName"].ToString();
            DisplayOrder = int.Parse(dt.Rows[0]["DisplayOrder"].ToString());
            Width = int.Parse(dt.Rows[0]["Width"].ToString());
            Height = int.Parse(dt.Rows[0]["Height"].ToString());
        }
        public TableGroup(DataRow dr) {
            IID = dr["IID"].ToString();
            GroupName = dr["GroupName"].ToString();
            DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
            Width = int.Parse(dr["Width"].ToString());
            Height = int.Parse(dr["Height"].ToString());
        }

        public DataTable GetAllTables(DB db) {
            return db.GetDataTable("GetTablesByGroup '" + IID + "'");
        }
        public bool Delete(DB db) {
            return db.RunQuery("DeleteTableGroup '" + IID + "'");
        }
        public bool Save(DB db) {
            return db.RunQuery("SaveTableGroup " +
            "'" + IID + "','" + GroupName.Replace("'", "''") + "'," + Width + "," + Height);
        }

        public string ToInfoString() {
            return GroupName + ", " + Width + ", " + Height + ", " + DisplayOrder;
        }
    }

}
