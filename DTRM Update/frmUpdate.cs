using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SharpUpdate;

namespace DTRM_Update {
    public partial class frmUpdate : Form, ISharpUpdatable {
        #region INTERFACE METHODS
        public string ApplicationName {
            get { return "DronaxPOS_Client"; }
        }

        public string ApplicationID {
            get { return "DronaxPOS_Client"; }
        }

        public System.Reflection.Assembly ApplicationAssembly {
            get { return Assembly.GetExecutingAssembly(); }
        }
        
        public Icon ApplicationIcon {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation {
            get { return new Uri("http://www.dronax.com/DronaxPOS/DronaxPOS_Client_Update.xml"); }
        }

        public Form Context {
            get { return this; }
        }
        #endregion

        public void UpdateApplication() {
            try {
                SharpUpdater updater = new SharpUpdate.SharpUpdater(this);
               // MessageBox.Show("SharpUpdater Created");
                updater.DoUpdate();
              //  MessageBox.Show("Do update done");
            } catch (Exception ex) {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        public frmUpdate() {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e) {
           
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateApplication();
        }
    }
}
