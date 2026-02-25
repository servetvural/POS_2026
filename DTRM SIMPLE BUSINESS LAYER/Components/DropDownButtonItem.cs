using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class DropDownButtonItem : DropDownButton {        

        public DropDownButtonItem() {
            InitializeComponent();
        }

        private void DropDownButtonItem_Click(object sender, EventArgs e) {
            //if (ParentButton != null)
            //    ParentButton.OnAnyItemClick(this, e);
        }
    }
}
