using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Context;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

using PosLibrary;

using POSWinFormLayer;


namespace POSOffice
{
    public enum ViewModes { User, Accountant, MenuEditor, Owner };
    public partial class frmOffice : Form
    {
        PosDbContext context;
        PosConfig config;
        IRepository<TheMenu> repoMenu;
        IRepository<User> repoUser;

        bool blnConnectedToDatabase;

        private ConnectionStatus conStatus;
        private ViewModes viewMode = ViewModes.User;

        //public frmOffice(IServiceProvider _sp, PosConfig configAsService, IRepository<TheMenu> _repoMenu,
        //    IRepository<User> _repoUser, IFormFactory formFactory)
        public frmOffice()
        {
            InitializeComponent();

            context = ServiceHelper.GetService<PosDbContext>();
            if (context.Database.CanConnect())
            {   
                //Initialize Database
                var initializer = ServiceHelper.GetService<DbInitializer>();
                initializer.InitializeDatabase();

                config = ServiceHelper.GetService<PosConfig>();
                repoMenu = ServiceHelper.GetRepository<TheMenu>();
                repoUser = ServiceHelper.GetRepository<User>();
                blnConnectedToDatabase = true;
            }


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
               // var context = ServiceHelper.GetService<PosDbContext>();

                if (await context.Database.CanConnectAsync())
                {
                    if (!blnConnectedToDatabase)
                    {        
                        //Initialize Database
                        var initializer = ServiceHelper.GetService<DbInitializer>();
                        initializer.InitializeDatabase();

                        config = ServiceHelper.GetService<PosConfig>();
                        repoMenu = ServiceHelper.GetRepository<TheMenu>();
                        repoUser = ServiceHelper.GetRepository<User>();
                    }                    


                    frmPassword frmpswd = new frmPassword("Database : " + (blnLocalDatabase ? "localhost" : config.Database_Instance));
                    if (frmpswd.ShowDialog() == DialogResult.OK)
                    {
                        DTRMSimpleBusiness.Instance.LoggedUser = await repoUser.GetByField("UserPassword", frmpswd.Password);
                        if (DTRMSimpleBusiness.Instance.LoggedUser == null)
                        { return; }

                        if (DTRMSimpleBusiness.Instance.LoggedUser.IsManagerOrMore())
                        {
                            ConnectActions(true);

                            //Identify connection type
                            if (blnLocalDatabase)
                            {
                                conStatus = DTRMSimpleBusiness.Instance.OfficeConnectionStatus = ConnectionStatus.ConnectedLocally;
                                btnPrinters.Enabled = true;
                                btnDisconnect.Image = Properties.Resources.ConnectedLocal32;
                            } else
                            {
                                //remote connection
                                conStatus = DTRMSimpleBusiness.Instance.OfficeConnectionStatus = ConnectionStatus.ConnectedRemotely;
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
                } else
                {
                    MessageBox.Show("Failed to Connect Database");
                    return;
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
                        DTRMSimpleBusiness.Instance.OfficeConnectionStatus = ConnectionStatus.Disconnected;
                        DTRMSimpleBusiness.Instance.LoggedUser = null;
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
                        btnViewDump.Enabled = true;
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


                        btnQuickReports.Enabled =
                        btnOrderPad.Enabled = true;
                        btnViewDump.Enabled = true;
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
                        btnViewDump.Enabled = true;
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


                        btnQuickReports.Enabled = true;
                        btnOrderPad.Enabled = true;
                        btnViewDump.Enabled = true;
                        btnReports.Enabled = true;
                        btnSessionAnalysis.Enabled = true;

                        break;
                }
            } else
            {

                btnMenu.Enabled =
                btnDistributions.Enabled =
                btnUserEditor.Enabled =
                btnPrinters.Enabled =
                btnSuppliers.Enabled =
                btnStockItemList.Enabled =
                btnImageList.Enabled =
                btnBonusList.Enabled =
                btnEmployees.Enabled =
                btnDisplay.Enabled =
                btnStockUsage.Enabled =
                btnKassaCalculator.Enabled =
                btnQuickReports.Enabled =
                btnOrderPad.Enabled =
                btnViewDump.Enabled =
                btnReports.Enabled =
                btnSessionAnalysis.Enabled = false;
            }

            if (!blnState)
            {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenuEditor frm = ActivatorUtilities.CreateInstance<FrmMenuEditor>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDistributions_Click(object sender, EventArgs e)
        {
            frmDistributionList frm = ActivatorUtilities.CreateInstance<frmDistributionList>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnUserEditor_Click(object sender, EventArgs e)
        {
            frmUserList frm = ActivatorUtilities.CreateInstance<frmUserList>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPrinters_Click(object sender, EventArgs e)
        {
            frmPrinters frm = ActivatorUtilities.CreateInstance<frmPrinters>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmCurrentSessionDisplay frm = ActivatorUtilities.CreateInstance<frmCurrentSessionDisplay>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void btnSessionReports_Click(object sender, EventArgs e)
        {
            frmSessionReports frm =new frmSessionReports();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSupplierList frm = ActivatorUtilities.CreateInstance<frmSupplierList>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnStockItemList_Click(object sender, EventArgs e)
        {
            frmStockItemList frm = ActivatorUtilities.CreateInstance<frmStockItemList>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void btnStockUsage_Click(object sender, EventArgs e)
        {
            frmStockItemUsage frm = new frmStockItemUsage();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnImageList_Click(object sender, EventArgs e)
        {
            frmImageList frm = ActivatorUtilities.CreateInstance<frmImageList>(ServiceHelper.Services, false);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSessionAnalysis_Click(object sender, EventArgs e)
        {
            frmSessionAnalysis frm = ActivatorUtilities.CreateInstance<frmSessionAnalysis>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //frmConfig frm = new frmConfig(bslayer);
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }


        private async void btnDatabaseBackup_Click(object sender, EventArgs e)
        {
            DatabaseBackupOptions backupOptions = new DatabaseBackupOptions();
            backupOptions.includeCustomers = backupOptions.includeImages = backupOptions.includePrinters = backupOptions.includeStock =
                backupOptions.includeTables = backupOptions.includeUsers = true;

            DatabaseBackup backup = await DTRMSimpleBusiness.Instance.GetDatabaseBackup(backupOptions);
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
            frmBonusList frm = ActivatorUtilities.CreateInstance<frmBonusList>(ServiceHelper.Services);
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
            frmEmployeeList frm = ActivatorUtilities.CreateInstance<frmEmployeeList>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKassaCalculator_Click(object sender, EventArgs e)
        {
            var frm = ActivatorUtilities.CreateInstance<frmKassaCalculator>(ServiceHelper.Services);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuViewDumpTool_Click(object sender, EventArgs e)
        {
            frmDump frm = new frmDump();
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

        private async void btnOrderPad_Click(object sender, EventArgs e)
        {
            if (config.ActiveMenuIID == null)
            {
                MessageBox.Show("Create and/or Select Default Menu");
                return;
            }

            TheMenu activeMenu = await repoMenu.Get(config.ActiveMenuIID);
            if (activeMenu == null)
            {
                MessageBox.Show("Create and/or Select Default Menu");
                return;
            }

            trmOrderPadMain frm = ActivatorUtilities.CreateInstance<trmOrderPadMain>(ServiceHelper.Services, new Form(), false);
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

        private void btnTables_Click(object sender, EventArgs e)
        {
            frmTablesEditor frm = new frmTablesEditor();
            frm.MdiParent = this;
            frm.Show(); 
        }
    }
}
