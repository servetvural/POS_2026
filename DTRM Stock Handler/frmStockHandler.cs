using System;
using System.Windows.Forms;
using DTRMNS;
using PosLibrary;
using PosLibrary.DBSpace;

namespace DTRM_Stock_Handler {
    public partial class frmStockHandler : Form {
        private DTRMSimpleBusiness bslayer;

        private ConnectionStatus conStatus;

        public frmStockHandler() {
            InitializeComponent();
        }

        private void frmStockHandler_Load(object sender, EventArgs e) {

        }

        private void mnuConnectDatabase_Click(object sender, EventArgs e) {
            
        }

        private void mnuConnect_Click(object sender, EventArgs e) {
            bool blnLocalDatabase = false;
            switch (conStatus) {
                case ConnectionStatus.Disconnected:
                    TryAgainLocally:
                    if (UF.IsConfigFileExist()) {
                        DTRMConfig config = UF.GetConfig();
                        if (config.Database_Instance == null |
                            config.Database_User_Name == null || config.Database_Password == null) {
                            frmConfig frm = new frmConfig(null);
                            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                Application.Exit();
                        }
                        bslayer = new DTRMSimpleBusiness(config);
                        if (bslayer.DoStartThings()) {
                            blnLocalDatabase = (DRUF.IsLocalIpAddress(config.Database_Instance) ||config.Database_Instance == "." );
                            bslayer.EnsureRequiredUsers();
                            frmPassword frmpswd = new frmPassword(bslayer,
                                "Database : " + (blnLocalDatabase ? "localhost" : config.Database_Instance));
                            if (frmpswd.ShowDialog() == DialogResult.OK) {
                                if (bslayer.IsAdmin(frmpswd.Password)) {

                                    ConnectActions(true);

                                    //Identify connection type
                                    if (blnLocalDatabase) {
                                        conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedLocally;
                                        //btnPrinters.Enabled = true;
                                        mnuDisconnect.Image = Properties.Resources.ConnectedLocal32;
                                    } else {
                                        //remote connection
                                        conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedRemotely;
                                        //btnPrinters.Enabled = false;
                                        mnuDisconnect.Image = Properties.Resources.ConnectedRemote32;
                                    }

                                    mnuConnect.Visible = false;
                                    mnuDisconnect.Visible = true;
                                   
                                        lblStatus.Text = conStatus.ToString() + " : " +
                                                         "Instanse/IP: " + bslayer.config.Database_Instance + ", " +
                                                         "Database: " + bslayer.config.Database_Name + ", " +
                                                         "User : " + bslayer.config.Database_User_Name;
                                    this.Refresh();
                                }
                            }
                        } else {
                            //Local DTRMConfig is not valid handle this
                            PosLibrary.DBSpace.frmDatabaseLogin frm = new frmDatabaseLogin();
                            frm.StartPosition = FormStartPosition.CenterParent;
                            if (frm.ShowDialog() == DialogResult.OK) {
                                DB db = frm.db;
                                config.Database_Instance = db.ServerIP;
                                //config.Database_Name = db.DatabaseName;
                                config.Database_User_Name = db.UserName;
                                config.Database_Password = db.Password;
                                UF.SaveConfig(config);
                                goto TryAgainLocally;

                            }
                        }
                    } else {
                        //UF.SaveConfig(new DTRMConfig());
                        frmConfig frm = new frmConfig(null);
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            goto TryAgainLocally;
                        else
                            Application.Exit();
                    }

                    
                    //bslayer.CheckNecessaryInstallationsAndFiles();

                    ////Login and DB connection completed so check db version
                    //bslayer.CheckAndUpdateDatabaseVersion();
                    break;

            }
        }

        private void mnuDisconnect_Click(object sender, EventArgs e) {
            conStatus = ConnectionStatus.Disconnected;
            try {
                bslayer.OfficeConnectionStatus = DTRMNS.ConnectionStatus.Disconnected;
            } catch { }
            ConnectActions(false);
            
            mnuConnect.Visible = true;
            mnuDisconnect.Visible = false;
            lblStatus.Text = "";
            this.Refresh();

        }

        private void ConnectActions(bool blnState) {
            mnuStockList.Enabled = mnuStockUsage.Enabled = blnState;
            
            if (!blnState) {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
            }
        }

        private void mnuConfig_Click(object sender, EventArgs e) {
            frmConfig frm = new frmConfig(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.Sizable;
            frm.Show();
        }

        private void mnuStockUsage_Click(object sender, EventArgs e) {
            frmStockItemUsage frm = new frmStockItemUsage(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnuStockList_Click(object sender, EventArgs e) {
            frmStockItemList frm = new frmStockItemList(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
