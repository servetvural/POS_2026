using System.ComponentModel;

namespace WinLayer {
    public class EntityButtonSpecial : System.Windows.Forms.Button {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PrintableTypeIID { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
