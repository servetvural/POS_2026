using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using PosLibrary;
using PosLibrary.DBSpace;
using DTRMNS;
using System.Collections.Generic;


namespace DTRMSimpleBackOffice {
    public partial class frmOffice : Form {

        private ConnectionStatus conStatus;

        private DTRMSimpleBusiness bslayer;


        public frmOffice() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
          
            CheckTabHeight();
        }

       


        private void btnConnect_Click(object sender, EventArgs e) {
            bool blnLocalDatabase = false;
            switch (conStatus) {
                case ConnectionStatus.Disconnected:
                TryAgainLocally:
                    if (UF.IsConfigFileExist()) {
                        DTRMConfig config = UF.GetConfig();
                        if (config.Database_Instance == null  |
                            config.Database_User_Name == null || config.Database_Password == null) {
                            frmConfig frm = new frmConfig(null);
                            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                Application.Exit();
                        }
                        bslayer = new DTRMSimpleBusiness(config);
                        
                        if (!bslayer.DBConnectionSuccessful) {
                            if (MessageBox.Show("Check Database Connection Error : \r\n" + bslayer.DBConnectionError + "\r\n\r\nExit Application??", "Database Connection Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                Application.Exit();
                            return;
                        }
                        if (bslayer.DoStartThings()) {
                            blnLocalDatabase = (DRUF.IsLocalIpAddress(config.Database_Instance) || config.Database_Instance == "." );
                            bslayer.EnsureRequiredUsers();
                            
                            frmPassword frmpswd = new frmPassword(bslayer,
                                "Database : " + (blnLocalDatabase ? "localhost" : config.Database_Instance));
                            if (frmpswd.ShowDialog() == DialogResult.OK) {
                                if (bslayer.IsAdmin(frmpswd.Password)) {

                                    ConnectActions(true);

                                    //Identify connection type
                                    if (blnLocalDatabase) {
                                        conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedLocally;
                                        btnPrinters.Enabled = true;
                                        btnDisconnect.Image = Properties.Resources.ConnectedLocal32;
                                    } else {
                                        //remote connection
                                        conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedRemotely;
                                        //btnPrinters.Enabled = false;
                                        btnDisconnect.Image = Properties.Resources.ConnectedRemote32;
                                    }

                                    btnConnect.Visible = false;
                                    btnDisconnect.Visible = true;

                                   // bslayer.EnsureSessionData();

                                        lblStatus.Text = conStatus.ToString() + " : " +
                                                         "Instanse/IP: " + bslayer.config.Database_Instance + ", " +
                                                         "Database: " + bslayer.config.Database_Name + ", " +
                                                         "User : " + bslayer.config.Database_User_Name;
                                        lblConnection.Text = bslayer.config.Database_Instance + "-->" + bslayer.config.Database_Name;
                                    
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
                               // config.Database_Name = db.DatabaseName;
                                config.Database_User_Name = db.UserName;
                                config.Database_Password = db.Password;
                                UF.SaveConfig(config);
                                goto TryAgainLocally;

                            }
                        }
                    } else {
                        frmConfig frm = new frmConfig(null);
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            goto TryAgainLocally;
                        else
                            Application.Exit();
                    }
                    barMain.Refresh();
                    break;

            }
        }



        private void btnDisconnect_Click(object sender, EventArgs e) {
            switch (conStatus) {
                case ConnectionStatus.ConnectedLocally:
                case ConnectionStatus.ConnectedRemotely:

                    conStatus = ConnectionStatus.Disconnected;
                    try {
                        bslayer.OfficeConnectionStatus = DTRMNS.ConnectionStatus.Disconnected;
                    } catch { }
                    ConnectActions(false);

                    btnViewReportSnapShot.Visible = false;
                    btnConnect.Visible = true;
                    btnDisconnect.Visible = false;
                    btnPrinters.Enabled = false;
                    lblStatus.Text = "";
                    lblConnection.Text = "";
                    this.Refresh();
                    break;
            }
        }

        private void ConnectActions(bool blnState) {
            btnMenu.Enabled = btnDistributions.Enabled =
                    btnUserEditor.Enabled = btnPrinters.Enabled = btnSessionReports.Enabled =
                    btnDisplay.Enabled = 
                    btnSuppliers.Enabled = btnStockItemList.Enabled = btnStockUsage.Enabled = btnImageList.Enabled =
                    btnSessionAnalysis.Enabled =  btnBonusList.Enabled = btnEmployees.Enabled = btnKassaCalculator.Enabled = blnState;

            btnViewReportSnapShot.Visible = (bslayer.LoggedUser.IsTechnicalOrMore());

            if (!blnState) {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
                bslayer.config = null;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e) {
            FrmMenuEditor frm = new FrmMenuEditor(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDistributions_Click(object sender, EventArgs e) {
            frmDistributionList frm = new frmDistributionList(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnUserEditor_Click(object sender, EventArgs e) {
            frmUserEditor frm = new frmUserEditor(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPrinters_Click(object sender, EventArgs e) {
            frmPrinters frm = new frmPrinters(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }           

        private void btnDisplay_Click(object sender, EventArgs e) {
            frmCurrentSessionDisplay frm = new frmCurrentSessionDisplay(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void btnSessionReports_Click(object sender, EventArgs e) {
            frmSessionReports frm = new frmSessionReports(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }



        private void btnViewReportSnapShot_Click(object sender, EventArgs e) {
            if (bslayer.imgReportSnapShot != null) {
                frmViewImage frm = new frmViewImage(Image.FromHbitmap(bslayer.imgReportSnapShot.GetHbitmap()));
                frm.Show();
            }
        }


        
       

        private void btnSuppliers_Click(object sender, EventArgs e) {
            frmSupplierList frm = new frmSupplierList(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnStockItemList_Click(object sender, EventArgs e) {
            frmStockItemList frm = new frmStockItemList(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void btnStockUsage_Click(object sender, EventArgs e) {
            frmStockItemUsage frm = new frmStockItemUsage(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnImageList_Click(object sender, EventArgs e) {
            frmImageList frm = new frmImageList(bslayer, false);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSessionAnalysis_Click(object sender, EventArgs e) {
            frmSessionAnalysis frm = new frmSessionAnalysis(bslayer);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            frmConfig frm = new frmConfig(bslayer);
            frm.Show();
        }


        private void btnDatabaseBackup_Click(object sender, EventArgs e) {
            DatabaseBackup backup = new DatabaseBackup();
            DatabaseBackupOptions options = new DatabaseBackupOptions();
            options.blnCustomers = options.blnImages = options.blnPrinters = options.blnStock =
                options.blnTables = options.blnUsers = true;

            if (bslayer.GetDatabaseBackup(ref backup, options)) {
                DRFile.XmlSerialize(Path.Combine("DatabaseBackup\\", "Database Backup on " +
                    DateTime.Now.ToString("dd MMM yyyy HH mm") + ".xml"), backup, typeof(DatabaseBackup), true);
            }
        }

        private void btnDebugAnalyser_Click(object sender, EventArgs e) {
            //frmDebugAnalyser frm = new frmDebugAnalyser(bslayer);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void btnBonusList_Click(object sender, EventArgs e) {
            frmBonusList frm = new frmBonusList(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buttonItem2_Click(object sender, EventArgs e) {
            frmScreenSaver frm = new frmScreenSaver();
            frm.Show();
        }

        private void btnImageEditor_Click(object sender, EventArgs e) {
            frmImageEditor frm = new frmImageEditor(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }


        private void btnDatabaseAdministrator_Click(object sender, EventArgs e) {
            //frmDatabaseAdmin frm = new frmDatabaseAdmin();
            //frm.Show();
        }

        private void frmOffice_MdiChildActivate(object sender, EventArgs e) {

            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else {
                
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, create new tabPage 
                if (this.ActiveMdiChild.Tag == null) {
                    // Add a tabPage to tabControl with child form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.MouseClick += MdiTabPage_MouseClick;
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tp.ImageIndex = 0;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed +=new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;
                
            }
        }

        private void MdiTabPage_MouseClick(object sender, MouseEventArgs e) {
            MessageBox.Show(e.Location.ToString());
            if (e.X > 0 && e.Y > 0 && e.X < 16 && e.Y < 25) {
                //close the form
                ((sender as TabPage).Tag as Form).Close();
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e) {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e) {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void tabForms_MouseClick(object sender, MouseEventArgs e) {
            for (int i=0; i < tabForms.TabPages.Count; i++) {
                Rectangle r = tabForms.GetTabRect(i);
                if (r.Contains(e.Location)) {
                    if (e.Location.X > r.X && e.Location.X < (r.X + tabForms.ImageList.ImageSize.Width + 6) && e.Location.Y < r.Height) {
                        (tabForms.TabPages[i].Tag as Form).Close();
                    }
                }
            }
            
          
        }

        private void tabForms_ControlAdded(object sender, ControlEventArgs e) {            
            CheckTabHeight();
        }

        private void tabForms_ControlRemoved(object sender, ControlEventArgs e) {
            CheckTabHeight();
        }
        private void CheckTabHeight() {
            if (tabForms.TabPages.Count > 0)
                tabForms.Height = 25;
            else
                tabForms.Height = 0;
        }

        private void btnEmployees_Click(object sender, EventArgs e) {
            frmEmployeeList frm = new frmEmployeeList(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKassaCalculator_Click(object sender, EventArgs e) {
            frmKassaCalculator frm = new frmKassaCalculator(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuViewDumpTool_Click(object sender, EventArgs e) {
            frmDump frm = new frmDump(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
