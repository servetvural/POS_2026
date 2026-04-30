using System.ComponentModel;

namespace WinLayer {
    public class CategoryItemSpecial : System.Windows.Forms.Button {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PrintableTypeIID { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string EntityName { get; set; }
        //public string EntityButtonName { get; set; }

        public CategoryItemSpecial() {
            PrintableTypeIID = "";
            EntityName = "";
        }
        public CategoryItemSpecial(string EntityName, string PrintableTypeIID) {
            this.EntityName = EntityName;
            this.PrintableTypeIID = PrintableTypeIID;
        }
    }
}
