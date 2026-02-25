namespace DTRMNS {
    public class EntityButtonSpecial : System.Windows.Forms.Button {
        public string PrintableTypeIID { get; set; }
        //public string EntityIID { get; set; }
        public string EntityName { get; set; }
        //public string EntityButtonName { get; set; }

        public EntityButtonSpecial() {
            PrintableTypeIID = "";
            EntityName = "";
        }
        public EntityButtonSpecial(string EntityName, string PrintableTypeIID) {
            this.EntityName = EntityName;
            this.PrintableTypeIID = PrintableTypeIID;
        }
    }
}
