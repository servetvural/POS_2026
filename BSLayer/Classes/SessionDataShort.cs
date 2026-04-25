using System;
using System.ComponentModel;
using PosLibrary;

namespace DTRMNS {
    [System.Serializable]
    public class SessionDataShort : INotifyPropertyChanged
    {

        private string _IID = ShortGuid.NewGuid().ToString();
        private DateTime _StartDate = DateTime.Now;
        private DateTime _EndDate = DateTime.Now;
        private float _GrossSessionTotal = 0;

        private float _X1Total;
        private float _X2Total;
        private float _X3Total;
      

        //Property for IID
        public string IID
        {
            get { return _IID; }
            set { _IID = value; this.NotifyPropertyChanged("IID"); }
        }

        //Property for StartDate
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; this.NotifyPropertyChanged("StartDate"); }
        }

        //Property for EndDate
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; this.NotifyPropertyChanged("EndDate"); }
        }

        //Property for GrossSessionTotal
        public float GrossSessionTotal
        {
            get { return _GrossSessionTotal; }
            set { _GrossSessionTotal = value; this.NotifyPropertyChanged("GrossSessionTotal"); }
        }
   


        //Property for RefundSum
        public float X1Total {
            get { return _X1Total; }
            set { _X1Total = value; this.NotifyPropertyChanged("X1Total"); }
        }
        //Property for RefundSum
        public float X2Total {
            get { return _X2Total; }
            set { _X2Total = value; this.NotifyPropertyChanged("X2Total"); }
        }
        //Property for RefundSum
        public float X3Total {
            get { return _X3Total; }
            set { _X3Total = value; this.NotifyPropertyChanged("X3Total"); }
        }
            

        //Default Constructor	
        public SessionDataShort()
        {

        }

        //Parameterized constructor	
        public SessionDataShort(string IID, DateTime StartDate, DateTime EndDate, float GrossSessionTotal)
        {
            _IID = IID;
            _StartDate = StartDate;
            _EndDate = EndDate;
            _GrossSessionTotal = GrossSessionTotal;
        }

        //public SessionDataShort(DAtaro

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

    }

}
