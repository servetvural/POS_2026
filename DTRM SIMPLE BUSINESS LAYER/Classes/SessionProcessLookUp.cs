using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using DronaxLibrary.DBSpace;

namespace DTRMNS {
    [System.Serializable]
    public class SessionProcessLookUp : INotifyPropertyChanged {

        private string _EntityButtonIID = "";
        private string _ParentCatalogIID = "";
        private int _ProcessValue = 0;

        //Property for EntityButtonIID
        public string EntityButtonIID {
            get { return _EntityButtonIID; }
            set { _EntityButtonIID = value; this.NotifyPropertyChanged("EntityButtonIID"); }
        }

        //Property for ParentCatalogIID
        public string ParentCatalogIID {
            get { return _ParentCatalogIID; }
            set { _ParentCatalogIID = value; this.NotifyPropertyChanged("ParentCatalogIID"); }
        }

        //Property for ProcessValue
        public int ProcessValue {
            get { return _ProcessValue; }
            set { _ProcessValue = value; this.NotifyPropertyChanged("ProcessValue"); }
        }


        //Default Constructor	
        public SessionProcessLookUp() {

        }

        //Parameterized constructor	
        public SessionProcessLookUp(string EntityButtonIID, string ParentCatalogIID, int ProcessValue) {
            _EntityButtonIID = EntityButtonIID;
            _ParentCatalogIID = ParentCatalogIID;
            _ProcessValue = ProcessValue;

        }

        public SessionProcessLookUp(DataTable dt) {
            _EntityButtonIID = dt.Rows[0]["EntityButtonIID"].ToString();
            _ParentCatalogIID = dt.Rows[0]["ParentCatalogIID"].ToString();
            _ProcessValue = int.Parse(dt.Rows[0]["ProcessValue"].ToString());

        }

        public SessionProcessLookUp(DataRow dr) {
            _EntityButtonIID = dr["EntityButtonIID"].ToString();
            _ParentCatalogIID = dr["ParentCatalogIID"].ToString();
            _ProcessValue = int.Parse(dr["ProcessValue"].ToString());

        }
        public bool Delete(DB db) {
            return db.RunQuery("DeleteSessionProcessLookUp " +
            "'" + _EntityButtonIID.Replace("'", "''") + "'");
        }
        public bool Save(DB db) {
            return db.RunQuery("SaveSessionProcessLookUp " +
        "'" + _EntityButtonIID.Replace("'", "''") + "','" + _ParentCatalogIID.Replace("'", "''") + "','" + _ProcessValue + "'");
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string PropertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

    }

    [System.Serializable]
    public class SessionProcessLookUpView : INotifyPropertyChanged {

        private string _EntityButtonIID = "";
        private string _ParentCatalogIID = "";
        private int _ProcessValue = 0;
        private string _EntityButtonName = "";
        private string _ParentEntityIID = "";
        private string _EntityName = "";

        //Property for EntityButtonIID
        public string EntityButtonIID {
            get { return _EntityButtonIID; }
            set { _EntityButtonIID = value; this.NotifyPropertyChanged("EntityButtonIID"); }
        }

        //Property for ParentCatalogIID
        public string ParentCatalogIID {
            get { return _ParentCatalogIID; }
            set { _ParentCatalogIID = value; this.NotifyPropertyChanged("ParentCatalogIID"); }
        }

        //Property for ProcessValue
        public int ProcessValue {
            get { return _ProcessValue; }
            set { _ProcessValue = value; this.NotifyPropertyChanged("ProcessValue"); }
        }

        //Property for EntityButtonName
        public string EntityButtonName {
            get { return _EntityButtonName; }
            set { _EntityButtonName = value; this.NotifyPropertyChanged("EntityButtonName"); }
        }

        //Property for ParentEntityIID
        public string ParentEntityIID {
            get { return _ParentEntityIID; }
            set { _ParentEntityIID = value; this.NotifyPropertyChanged("ParentEntityIID"); }
        }

        //Property for EntityName
        public string EntityName {
            get { return _EntityName; }
            set { _EntityName = value; this.NotifyPropertyChanged("EntityName"); }
        }


        //Default Constructor	
        public SessionProcessLookUpView() {

        }

        //Parameterized constructor	
        public SessionProcessLookUpView(string EntityButtonIID, string ParentCatalogIID, int ProcessValue, string EntityButtonName, string ParentEntityIID, string EntityName) {
            _EntityButtonIID = EntityButtonIID;
            _ParentCatalogIID = ParentCatalogIID;
            _ProcessValue = ProcessValue;
            _EntityButtonName = EntityButtonName;
            _ParentEntityIID = ParentEntityIID;
            _EntityName = EntityName;

        }

        public SessionProcessLookUpView(DataTable dt) {
            _EntityButtonIID = dt.Rows[0]["EntityButtonIID"].ToString();
            _ParentCatalogIID = dt.Rows[0]["ParentCatalogIID"].ToString();
            _ProcessValue = int.Parse(dt.Rows[0]["ProcessValue"].ToString());
            _EntityButtonName = dt.Rows[0]["EntityButtonName"].ToString();
            _ParentEntityIID = dt.Rows[0]["ParentEntityIID"].ToString();
            _EntityName = dt.Rows[0]["EntityName"].ToString();

        }

        public SessionProcessLookUpView(DataRow dr) {
            _EntityButtonIID = dr["EntityButtonIID"].ToString();
            _ParentCatalogIID = dr["ParentCatalogIID"].ToString();
            _ProcessValue = int.Parse(dr["ProcessValue"].ToString());
            _EntityButtonName = dr["EntityButtonName"].ToString();
            _ParentEntityIID = dr["ParentEntityIID"].ToString();
            _EntityName = dr["EntityName"].ToString();

        }
        public SessionProcessLookUp GetSessionProcessLookUp() {
            return new SessionProcessLookUp(_EntityButtonIID, _ParentCatalogIID, _ProcessValue);
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string PropertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

    }
}
