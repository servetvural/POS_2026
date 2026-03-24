using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using POSLayer.Library;
using POSLayer.Models;

using PosLibrary;
using PosLibrary.DBSpace;

using POSWinFormLayer;
using POSLayer.Repository.IRepository;


namespace DTRMSimpleBackOffice
{
    public enum ViewModes { User, Accountant, MenuEditor, Owner };
    public partial class frmOffice : Form
    {
        readonly IServiceProvider sp;
        PosConfig config;

        private ConnectionStatus conStatus;
        private DTRMSimpleBusiness bslayer;
        private ViewModes viewMode = ViewModes.User;

        readonly  IRepository<User> repoUser;

        public frmOffice(IServiceProvider _sp, PosConfig configAsService, DTRMSimpleBusiness _bslayer, IRepository<User> _repoUser,  IFormFactory formFactory)
        {
            InitializeComponent();
            sp = _sp;
            config = configAsService;
            bslayer = _bslayer;
            repoUser = _repoUser;
           // bslayer.config = configAsService;
            if (!string.IsNullOrEmpty(Program.UserType))
            {
                if (!Enum.TryParse<ViewModes>(Program.UserType, true, out viewMode))
                    viewMode = ViewModes.User;
            }
            this.Text += " as " + viewMode.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckTabHeight();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            bool blnLocalDatabase = false;

            if (conStatus == ConnectionStatus.Disconnected)
            {
                if (await repoUser.IsDatabaseExist())
                {
                    frmPassword frmpswd = ActivatorUtilities.CreateInstance<frmPassword>(sp, "Database : " + (blnLocalDatabase ? "localhost" : config.Database_Instance));
                    if (frmpswd.ShowDialog() == DialogResult.OK)
                    {
                        User user = await repoUser.GetByField("UserPassword", frmpswd.Password);
                        if (user == null) { return; }

                        if (user.IsManagerOrMore())
                        {

                            ConnectActions(true);

                            //Identify connection type
                            if (blnLocalDatabase)
                            {
                                conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedLocally;
                                btnPrinters.Enabled = true;
                                btnDisconnect.Image = Properties.Resources.ConnectedLocal32;
                            } else
                            {
                                //remote connection
                                conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedRemotely;
                                //btnPrinters.Enabled = false;
                                btnDisconnect.Image = Properties.Resources.ConnectedRemote32;
                            }

                            btnConnect.Visible = false;
                            btnDisconnect.Visible = true;

                            lblStatus.Text = conStatus.ToString() + " : " +
                                             "Instanse/IP: " + config.Database_Instance + ", " +
                                             "Database: " + config.Database_Name + ", " +
                                             "User : " + config.Database_User_Name;

                            this.Refresh();

                        }
                    } else
                    {
                        //MessageBox.Show("Failed to Login");
                    }
                }                
            }
        }            



        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            switch (conStatus)
            {
                case ConnectionStatus.ConnectedLocally:
                case ConnectionStatus.ConnectedRemotely:

                    conStatus = ConnectionStatus.Disconnected;
                    try
                    {
                        bslayer.OfficeConnectionStatus = ConnectionStatus.Disconnected;
                    } catch { }
                    ConnectActions(false);

                    btnConnect.Visible = true;
                    btnDisconnect.Visible = false;
                    btnPrinters.Enabled = false;
                    lblStatus.Text = "";
                    this.Refresh();
                    break;
            }
        }

        private void ConnectActions(bool blnState)
        {
            if (blnState)
            {
                switch (viewMode)
                {
                    case ViewModes.User:
                        // btnMenu.Enabled = true;
                        // btnDistributions.Enabled = true;
                        // btnUserEditor.Enabled = true;
                        // btnPrinters.Enabled = true;
                        // btnSuppliers.Enabled = true;
                        // btnStockItemList.Enabled = true;
                        // btnImageList.Enabled = true;
                        //btnBonusList.Enabled = true;
                        //btnEmployees.Enabled = true;


                        // btnDisplay.Enabled = true;
                        //btnStockUsage.Enabled = true;
                        btnKassaCalculator.Enabled = true;


                        //btnQuickReports.Enabled = btnQuickReports.Visible = true;
                        btnOrderPad.Enabled = true;
                        btnOrderPad.Visible = true;
                        btnViewDump.Enabled = true;
                        btnViewDump.Visible = true;
                        //  btnReports.Enabled = true;
                        // btnReports.Visible = true;
                        //  btnSessionAnalysis.Enabled = true;
                        //  btnSessionAnalysis.Visible = true;
                        break;
                    case ViewModes.Accountant:
                        //btnMenu.Enabled = true;
                        //btnDistributions.Enabled = true;
                        //btnUserEditor.Enabled = true;
                        btnPrinters.Enabled = true;
                        btnSuppliers.Enabled = true;
                        btnStockItemList.Enabled = true;
                        // btnImageList.Enabled = true;
                        // btnBonusList.Enabled = true;
                        // btnEmployees.Enabled = true;


                        btnDisplay.Enabled = true;
                        btnStockUsage.Enabled = true;
                        btnKassaCalculator.Enabled = true;


                        btnQuickReports.Enabled = btnQuickReports.Visible = true;
                        btnOrderPad.Enabled = true;
                        btnOrderPad.Visible = true;
                        btnViewDump.Enabled = true;
                        btnViewDump.Visible = true;
                        // btnReports.Enabled = true;
                        // btnReports.Visible = true;
                        // btnSessionAnalysis.Enabled = true;
                        // btnSessionAnalysis.Visible = true;
                        break;
                    case ViewModes.MenuEditor:
                        btnMenu.Enabled = true;
                        btnDistributions.Enabled = true;
                        // btnUserEditor.Enabled = true;
                        btnPrinters.Enabled = true;
                        btnSuppliers.Enabled = true;
                        btnStockItemList.Enabled = true;
                        btnImageList.Enabled = true;
                        btnBonusList.Enabled = true;
                        btnEmployees.Enabled = true;


                        btnDisplay.Enabled = true;
                        btnStockUsage.Enabled = true;
                        btnKassaCalculator.Enabled = true;


                        //  btnQuickReports.Enabled = btnQuickReports.Visible = true;
                        btnOrderPad.Enabled = true;
                        btnOrderPad.Visible = true;
                        btnViewDump.Enabled = true;
                        btnViewDump.Visible = true;
                        //   btnReports.Enabled = true;
                        //  btnReports.Visible = true;
                        //  btnSessionAnalysis.Enabled = true;
                        //  btnSessionAnalysis.Visible = true;

                        break;
                    case ViewModes.Owner:
                        btnMenu.Enabled = true;
                        btnDistributions.Enabled = true;
                        btnUserEditor.Enabled = true;
                        btnPrinters.Enabled = true;
                        btnSuppliers.Enabled = true;
                        btnStockItemList.Enabled = true;
                        btnImageList.Enabled = true;
                        btnBonusList.Enabled = true;
                        btnEmployees.Enabled = true;


                        btnDisplay.Enabled = true;
                        btnStockUsage.Enabled = true;
                        btnKassaCalculator.Enabled = true;


                        btnQuickReports.Enabled = btnQuickReports.Visible = true;
                        btnOrderPad.Enabled = true;
                        btnOrderPad.Visible = true;
                        btnViewDump.Enabled = true;
                        btnViewDump.Visible = true;
                        btnReports.Enabled = true;
                        btnReports.Visible = true;
                        btnSessionAnalysis.Enabled = true;
                        btnSessionAnalysis.Visible = true;

                        break;
                }
            } else
            {

                btnMenu.Enabled = btnMenu.Visible =
                btnDistributions.Enabled = btnDistributions.Visible =
                btnUserEditor.Enabled = btnUserEditor.Visible =
                btnPrinters.Enabled = btnPrinters.Visible =
                btnSuppliers.Enabled = btnSuppliers.Visible =
                btnStockItemList.Enabled = btnStockItemList.Visible =
                btnImageList.Enabled = btnImageList.Visible =
                btnBonusList.Enabled = btnBonusList.Visible =
                btnEmployees.Enabled = btnEmployees.Visible =
                btnDisplay.Enabled = btnDisplay.Visible =
                btnStockUsage.Enabled = btnStockUsage.Visible =
                btnKassaCalculator.Enabled = btnKassaCalculator.Visible =
                btnQuickReports.Enabled = btnQuickReports.Visible =
                btnOrderPad.Enabled = btnOrderPad.Visible =
                btnViewDump.Enabled = btnViewDump.Visible =
                btnReports.Enabled = btnReports.Visible =
                btnSessionAnalysis.Enabled = btnSessionAnalysis.Visible = false;
            }

            if (!blnState)
            {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenuEditor frm = ActivatorUtilities.CreateInstance<FrmMenuEditor>(sp);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDistributions_Click(object sender, EventArgs e)
        {
            frmDistributionList frm = ActivatorUtilities.CreateInstance <frmDistributionList>(sp);
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnUserEditor_Click(object sender, EventArgs e)
        {
            frmUserEditor frm = ActivatorUtilities.CreateInstance<frmUserEditor>(sp);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPrinters_Click(object sender, EventArgs e)
        {
            frmPrinters frm = ActivatorUtilities.CreateInstance<frmPrinters>(sp);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmCurrentSessionDisplay frm = ActivatorUtilities.CreateInstance<frmCurrentSessionDisplay>(sp);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void btnSessionReports_Click(object sender, EventArgs e)
        {
            frmSessionReports frm = ActivatorUtilities.CreateInstance < frmSessionReports>(sp);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSupplierList frm = ActivatorUtilities.CreateInstance < frmSupplierList>(sp);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnStockItemList_Click(object sender, EventArgs e)
        {
            frmStockItemList frm = ActivatorUtilities.CreateInstance<frmStockItemList>(sp);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void btnStockUsage_Click(object sender, EventArgs e)
        {
            frmStockItemUsage frm = ActivatorUtilities.CreateInstance<frmStockItemUsage>(sp);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnImageList_Click(object sender, EventArgs e)
        {
            frmImageList frm = ActivatorUtilities.CreateInstance<frmImageList>(sp, false);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSessionAnalysis_Click(object sender, EventArgs e)
        {
            frmSessionAnalysis frm = ActivatorUtilities.CreateInstance<frmSessionAnalysis>(sp);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //frmConfig frm = new frmConfig(bslayer);
            frmConfig frm = ActivatorUtilities.CreateInstance<frmConfig>(sp); 
            frm.Show();
        }


        private async void btnDatabaseBackup_Click(object sender, EventArgs e)
        {
            DatabaseBackupOptions backupOptions = new DatabaseBackupOptions();
            backupOptions.includeCustomers = backupOptions.includeImages = backupOptions.includePrinters = backupOptions.includeStock =
                backupOptions.includeTables = backupOptions.includeUsers = true;

            DatabaseBackup backup = await bslayer.GetDatabaseBackup(backupOptions);
            if (backup != null)
            {
                DRFile.XmlSerialize(Path.Combine("DatabaseBackup\\", "Database Backup on " +
                    DateTime.Now.ToString("dd MMM yyyy HH mm") + ".xml"), backup, typeof(DatabaseBackup), true);
            }
        }

        private void btnDebugAnalyser_Click(object sender, EventArgs e)
        {
            //frmDebugAnalyser frm = new frmDebugAnalyser(bslayer);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void btnBonusList_Click(object sender, EventArgs e)
        {
            frmBonusList frm = new frmBonusList(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frmScreenSaver frm = new frmScreenSaver();
            frm.Show();
        }



        private void btnDatabaseAdministrator_Click(object sender, EventArgs e)
        {
            //frmDatabaseAdmin frm = new frmDatabaseAdmin();
            //frm.Show();
        }

        private void frmOffice_MdiChildActivate(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else
            {

                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.MouseClick += MdiTabPage_MouseClick;
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tp.ImageIndex = 0;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible)
                    tabForms.Visible = true;

            }
        }

        private void MdiTabPage_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
            if (e.X > 0 && e.Y > 0 && e.X < 16 && e.Y < 25)
            {
                //close the form
                ((sender as TabPage).Tag as Form).Close();
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void tabForms_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabForms.TabPages.Count; i++)
            {
                Rectangle r = tabForms.GetTabRect(i);
                if (r.Contains(e.Location))
                {
                    if (e.Location.X > r.X && e.Location.X < (r.X + tabForms.ImageList.ImageSize.Width + 6) && e.Location.Y < r.Height)
                    {
                        (tabForms.TabPages[i].Tag as Form).Close();
                    }
                }
            }


        }

        private void tabForms_ControlAdded(object sender, ControlEventArgs e)
        {
            CheckTabHeight();
        }

        private void tabForms_ControlRemoved(object sender, ControlEventArgs e)
        {
            CheckTabHeight();
        }
        private void CheckTabHeight()
        {
            if (tabForms.TabPages.Count > 0)
                tabForms.Height = 25;
            else
                tabForms.Height = 0;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployeeList frm = new frmEmployeeList(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKassaCalculator_Click(object sender, EventArgs e)
        {
            //frmKassaCalculator frm = new frmKassaCalculator();
            //frm.MdiParent = this;
            //frm.Show();
            var frm = ActivatorUtilities.CreateInstance<frmKassaCalculator>(sp);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuViewDumpTool_Click(object sender, EventArgs e)
        {
            frmDump frm = new frmDump(bslayer);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuickReports_Click(object sender, EventArgs e)
        {
            frmSessionReportsQuick frm = new frmSessionReportsQuick();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnOrderPad_Click(object sender, EventArgs e)
        {
            if (!bslayer.IsMenuExist(config.ActiveMenuIID))
            {
                MessageBox.Show("Create and/or Select Default Menu");
                return;
            }


            trmOrderPadMain frm = ActivatorUtilities.CreateInstance< trmOrderPadMain>(sp, null, true);
            frm.Text = "Order Pad";
            frm.ControlBox = true;
            frm.MinimizeBox = true;
            frm.MaximizeBox = true;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.Sizable;
            frm.MdiParent = this;
            frm.Show();
            //Hide certain menu items
            frm.ShowAsSubWindow();
        }

        private void btnCloseAllWindows_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
