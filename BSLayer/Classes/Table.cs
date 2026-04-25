using System.Data;
using PosLibrary;

namespace DTRMNS {

    [System.Serializable]
    public class Table 
    {
        private string _IID=ShortGuid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } }
        public string TableName { get; set; }
        public int TableCovers { get; set; }
        public string LockedClientIP { get; set; }
        public string CurrentOrderIID { get; set; }                         
        public TableTypes TableType { get; set; }
        public POSLayer.Models.Order AttachedOrder { get; set; }
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string GroupIID { get; set; }
        public string ParentTableIID { get; set; } = "";
        public bool isPrimary { get { return TableType == TableTypes.StaticTable; } }

        private int _Number;
        public int Number { get { return _Number; } set { _Number = value; } }

        public ButtonShapeTypes Shape { get; set; }
        public string DefaultName { get; set; }

        public string KitchenOrderNumber { get; set; }

        public Table()
        {
            TableName = "Table ?";
            TableCovers = 1;
            LockedClientIP = "";
            CurrentOrderIID = "";
            TableType = TableTypes.TemporaryTable;
            AttachedOrder = null;
            XLocation = 0;
            YLocation = 0;
            Width = 100;
            Height = 50;
            GroupIID = "0";
            DefaultName = "Table ?";
        }
        public Table(string TableName, int TableCovers)
        {
            this.TableName = TableName;
            this.TableCovers = TableCovers;
            LockedClientIP = "";
            CurrentOrderIID = "";
            this.TableType = TableTypes.TemporaryTable;
            AttachedOrder = null;
            XLocation = 0;
            YLocation = 0;
            Width = 100;
            Height = 50;
            GroupIID = "0";
        }
        public Table(string IID, string TableName, int TableCovers)
        {
            this.IID = IID;
            this.TableName = TableName;
            this.TableCovers = TableCovers;
            LockedClientIP = "";
            CurrentOrderIID = "";
            this.TableType = TableTypes.TemporaryTable;
            AttachedOrder = null;
            XLocation = 0;
            YLocation = 0;
            Width = 100;
            Height = 50;
            GroupIID = "0";
        }
        public Table(string IID, string TableName, int TableCovers, TableTypes TableType)
        {
            this.IID = IID;
            this.TableName = TableName;
            this.TableCovers = TableCovers;
            LockedClientIP = "";
            CurrentOrderIID = "";
            GroupIID = "0";
            this.TableType = TableType;
            AttachedOrder = null;
        }
        public Table(string IID, string TableName, int TableCovers, TableTypes TableType, string LockedClientIP, string CurrentOrderIID, int XLocation, int YLocation, int Width, int Height)
        {
            this.IID = IID;
            this.TableName = TableName;
            this.TableCovers = TableCovers;
            this.LockedClientIP = LockedClientIP;
            this.CurrentOrderIID = CurrentOrderIID;
            this.TableType = TableType;
            this.AttachedOrder = null;
            this.XLocation = XLocation;
            this.YLocation = YLocation;
            this.Width = Width;
            this.Height = Height;
        }
        public Table(DataRow dr)
        {
            if (dr != null)
            {
                this.IID = dr["IID"].ToString();
                this.Number = int.Parse(dr["Number"].ToString());
                this.TableName = dr["TableName"].ToString();
                this.TableCovers = int.Parse(dr["TableCovers"].ToString());
                this.LockedClientIP = dr["LockedClientIP"].ToString();
                this.CurrentOrderIID = dr["CurrentOrderIID"].ToString();
                this.TableType = (TableTypes)int.Parse(dr["TableType"].ToString());
                this.AttachedOrder = null;
                this.XLocation = int.Parse(dr["XLocation"].ToString());
                this.YLocation = int.Parse(dr["YLocation"].ToString());
                this.Width = int.Parse(dr["Width"].ToString());
                this.Height = int.Parse(dr["Height"].ToString());
                this.GroupIID = dr["GroupIID"].ToString();
                this.ParentTableIID = dr["ParentTableIID"].ToString();
                this.Shape = (ButtonShapeTypes)int.Parse(dr["Shape"].ToString());
                this.DefaultName = dr["DefaultName"].ToString();

                try {
                    if (dr["KitchenOrderNumber"] != null)
                        KitchenOrderNumber = dr["KitchenOrderNumber"].ToString();
                } catch {
                    KitchenOrderNumber = "";
                }
            }
        }
        public void Update(string TableName, int TableCovers)
        {
            this.TableName = TableName;
            this.TableCovers = TableCovers;
        }
        public void Update(Table table)
        {
            this.TableName = table.TableName;
            this.TableCovers = table.TableCovers;
            this.LockedClientIP = table.LockedClientIP;
            this.CurrentOrderIID = table.CurrentOrderIID;
            this.TableType = table.TableType;
            this.Shape = table.Shape;
        }
        public Table Clone()
        {
            Table t = new Table(this.IID, this.TableName, this.TableCovers, this.TableType, this.LockedClientIP, this.CurrentOrderIID, this.XLocation, this.YLocation, this.Width, this.Height);
            t.GroupIID = this.GroupIID;
            t.ParentTableIID = this.ParentTableIID;
            t.Shape = this.Shape;


            return t;
        }

        public Table CreateSubTable() {
            Table subTable = new Table();
            subTable.ParentTableIID = this.IID;
            subTable.TableCovers = this.TableCovers;
            subTable.TableType = TableTypes.TemporaryTable;
            subTable.TableName = this.TableName;
            subTable.Shape = this.Shape;
            return subTable;
        }
        public void Lock(string ClientIP)
        {
            LockedClientIP = ClientIP;
        }
        public bool IsBusy(string ClientIP)
        {
            if (string.IsNullOrEmpty(this.LockedClientIP))
                return false;
            else
            {
                if (this.LockedClientIP == ClientIP)
                    return false;
                else
                    return true;
            }
        }
        
        public bool HasActiveOrder()
        {
            if (string.IsNullOrEmpty(this.CurrentOrderIID))
                return false;
            else
                return true;
        }
        public void AttachOrder(Order order)
        {
            this.AttachedOrder = order;
        }
        public void DetachOrder()
        {
            this.AttachedOrder = null;
        }
    }

}
