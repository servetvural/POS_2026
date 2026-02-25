namespace DTRMNS { 
    public class UndoItem {
        private string _IID;
        public string IID { get { return _IID; } set { _IID = value; } }
        public int Quantity { get; set; }
        public bool blnConverted { get; set; }

        public UndoItem() {
            blnConverted = true;
        }

        //public UndoItem(string IID, int Quantity) {
        //    this.IID = IID;
        //    this.Quantity = Quantity;
        //}
        public UndoItem(string IID, int Quantity, bool blnConverted) {
            this.IID = IID;
            this.Quantity = Quantity;
            this.blnConverted = blnConverted;
        }

    }
}
