using System;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class frmBackupOptions : Form {
        public DatabaseBackupOptions options;

        public frmBackupOptions() {
            InitializeComponent();
        }

        private void frmBackupOptions_Load(object sender, EventArgs e) {
            options = new DatabaseBackupOptions();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            options.blnCustomers = chkCustomers.Checked;
            options.blnUsers = chkUsers.Checked;
            options.blnPrinters = chkPrinters.Checked;
            options.blnTables = chkTables.Checked;
            options.blnMenus = chkMenus.Checked;
            options.blnStock = chkStock.Checked;

            options.blnLuv = chkLuv.Checked;
            options.blnCurrentSession = chkCurrentSession.Checked;
            options.blnOrders = chkOrders.Checked;
            options.blnXOrders = chkXOrders.Checked;
            options.blnKitchenOrders = chkKitchenOrders.Checked;
            options.blnDebugInformation = chkXOrders.Checked;
            options.blnImages = chkImages.Checked;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        public void SetCaption(string str) {
            this.Text = str;
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e) {
            chkCustomers.Checked = chkUsers.Checked = chkPrinters.Checked = chkTables.Checked = chkMenus.Checked =
            chkStock.Checked = chkLuv.Checked = chkCurrentSession.Checked = chkOrders.Checked = chkXOrders.Checked =
             chkKitchenOrders.Checked = chkXOrders.Checked = chkImages.Checked = chkAll.Checked;
        }
    }
}
