using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSLayer {
    public partial class frmTextViewer : Form {
        private string textToView;
        public frmTextViewer(string textToView) {
            InitializeComponent();
            this.textToView = textToView;
        }

        private void frmXMLViewer_Load(object sender, EventArgs e) {
            rtb.Text = textToView;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
