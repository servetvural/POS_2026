using System;
using System.Windows.Forms;

using POSLayer.Library;

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
            options.includeCustomers = chkCustomers.Checked;
            options.includeUsers = chkUsers.Checked;
            options.includePrinters = chkPrinters.Checked;
            options.includeTables = chkTables.Checked;
            options.includeMenus = chkMenus.Checked;
            options.includeStock = chkStock.Checked;

            options.includeShop = chkLuv.Checked;
            options.includeCurrentSession = chkCurrentSession.Checked;
            options.includeOrders = chkOrders.Checked;
            options.includeXOrders = chkXOrders.Checked;
            options.includeKitchenOrders = chkKitchenOrders.Checked;
            options.includeDebugInformation = chkXOrders.Checked;
            options.includeImages = chkImages.Checked;

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
