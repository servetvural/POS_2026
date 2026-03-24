using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

using PosLibrary;

namespace DTRMClientNS
{
    public partial class FrmLock : Form
    {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        readonly IRepository<User> repoUser;

        private trmOrderPadMain OrderPad;
        private int LoginCounter;

        public FrmLock(PosConfig configAsService, DTRMSimpleBusiness bslayer, IRepository<User> _repoUser)
        {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            repoUser = _repoUser;

            txtUserPassword.Text = "";
        }

        private void FrmLock_Load(object sender, EventArgs e)
        {
            Process[] pList = Process.GetProcessesByName("DTRMClient");
            if (pList.GetLength(0) > 1)
            {
                for (int i = 0; i < pList.Length; i++)
                    pList[i].Kill();
            }

            ResetProgress();


            if (config.IsValid())
            {
               // LoginUser();


                try
                {
                    if (bslayer != null)
                        if (config != null)
                            this.WindowState = FormWindowState.Normal; // (FormWindowState)config.Lock_Screen_Window_Format;
                        else
                            this.WindowState = (FormWindowState)POSLayer.Library.UF.GetConfig().Lock_Screen_Window_Format;
                    else
                        this.WindowState = (FormWindowState)POSLayer.Library.UF.GetConfig().Lock_Screen_Window_Format;
                } catch
                {

                }
                this.TopMost = false;
                pnlAlign.Left = (int)((this.Width - pnlAlign.Width) / 2);
            } else
            {
                if (AskForConfig())
                {
                    Environment.Exit(0);
                }
            }
        }


        private bool AskForConfig()
        {
            frmConfig frm = ActivatorUtilities.CreateInstance<frmConfig>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Saved Restart Application");
                return true;
            } else
            {
                MessageBox.Show("Failed Restart Application");
                return false;
            }
        }


        //async Task<bool> LoginUser()
        //{
        //    if (await repoUser.IsDatabaseExist())
        //    {
        //        frmPassword frmpswd = ActivatorUtilities.CreateInstance<frmPassword>(ServiceHelper.Services, "Database : " + config.Database_Instance);
        //        if (frmpswd.ShowDialog() == DialogResult.OK)
        //        {
        //            User user = await repoUser.GetByField("UserPassword", frmpswd.Password);
        //            if (user == null)
        //            {
        //                return false;
        //            } else
        //            {
        //                return true;
        //            }
        //        } else
        //        {
        //            MessageBox.Show("Failed to Login");
        //            return false;
        //        }
        //    } else
        //        return false;
        //}


        private void FrmLock_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region "KEY HANDLERS"
        private void KeyHandle(object sender, System.EventArgs e)
        {
            ResetLogonButton();
            string key = ((Button)sender).Text.Trim().ToLower();
            if (key != "")
                txtUserPassword.Text += key;
        }
        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            // LogoCount = 0;
            DisplayMessage("LOGIN YOUR KEY", 3);
            txtUserPassword.Clear();
            ResetLogonButton();
            pBar.Value = 0;
            pBar.Maximum = 1;
        }

        public void ShowProgress(int step)
        {
            if (step <= 0)
                pBar.Value = 0;
            else
            {
                if ((pBar.Value + step) > pBar.Maximum)
                    pBar.Maximum = pBar.Value + step + (int)((step + pBar.Value) * 0.2);
                pBar.Value = pBar.Value + step;
            }
        }

        private void DisplayMessage(string str, int progress)
        {
            if (progress > 0)
                ShowProgress(progress);
            lblNotify.Text = str;
            lblNotify.Refresh();
        }

        private async Task<bool> ValidateConfiguration()
        {
            try
            {
                if (POSLayer.Library.UF.GetConfig() == null)
                {
                    LogoBox_DoubleClick(null, null);
                    if (POSLayer.Library.UF.GetConfig() == null)
                    {
                        MessageBox.Show("CONFIGURATION ERROR, PLEASE CONFIGURE THE APPLICATION FIRST.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return false;
                    }
                }

                DisplayMessage("VALIDATING CONFIGURATION........   ", 2);
               
                //Validate Client IP
                if (config.Terminal_Name.Trim() == "")
                {

                    DisplayMessage("VALIDATION ERROR 1", 2);
                    return false;

                }

                DisplayMessage("DB SERVER IP VALID, CHECKING DB CONNECTION  .....", 2);

                //if (await bslayer.EstablishDatabaseConnection())
                //{
                //    if (MessageBox.Show("Check Database Connection Error : \r\n" + bslayer.DBConnectionError + "\r\n\r\nExit Application??", "Database Connection Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //        Application.Exit();
                //    DisplayMessage("VALIDATION ERROR 3 " + bslayer.DBConnectionError, 2);
                //    return false;

                //}
                DisplayMessage("DB SERVER AND CONNECTION ARE VALID.....", 2);
                return true;

            } catch
            {
                return false;
            }
        }


        private async void BtnLogon_Click(object sender, System.EventArgs e)
        {
            this.TopMost = false;

            if (txtUserPassword.Text.Length == 0)
                return;


            pBar.Value = 0;

            User user = await repoUser.GetByField("UserPassword", txtUserPassword.Text);
            if (user == null)
            {
                txtUserPassword.Clear();
                return; 
            } else
            {
                bslayer.LoggedUser = user;
                this.Hide();

                txtUserPassword.Clear();

                if (OrderPad == null)
                    OrderPad = ActivatorUtilities.CreateInstance< trmOrderPadMain>(ServiceHelper.Services, this, true);
            }

            //if (user.IsManagerOrMore())
            //{

            //    ConnectActions(true);

            //    //Identify connection type
            //    if (blnLocalDatabase)
            //    {
            //        conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedLocally;
            //        btnPrinters.Enabled = true;
            //        btnDisconnect.Image = Properties.Resources.ConnectedLocal32;
            //    } else
            //    {
            //        //remote connection
            //        conStatus = bslayer.OfficeConnectionStatus = ConnectionStatus.ConnectedRemotely;
            //        //btnPrinters.Enabled = false;
            //        btnDisconnect.Image = Properties.Resources.ConnectedRemote32;
            //    }

            //    btnConnect.Visible = false;
            //    btnDisconnect.Visible = true;

            //    lblStatus.Text = conStatus.ToString() + " : " +
            //                     "Instanse/IP: " + config.Database_Instance + ", " +
            //                     "Database: " + config.Database_Name + ", " +
            //                     "User : " + config.Database_User_Name;

            //    this.Refresh();

            //}



            //try
            //{
            //    //if (bslayer == null || bslayer.config == null || bslayer.db == null)
            //    //{
            //        if (await ValidateConfiguration())
            //        {
            //            //DisplayMessage("CHECKING DATABASE UPDATES.............        ", 2);
            //            //bslayer.CheckAndUpdateDatabaseVersion();

            //            DisplayMessage("STARTING BUSINESS LAYER ..........      ", 2);
            //            if (!bslayer.DoStartThings().Result)
            //            {
            //                DisplayMessage("Cannot Start Business Layer", 2);
            //                return;
            //            }
            //            //if (bslayer.DisplayPort == null) {
            //            //    if (bslayer.HasCustomerDisplay()) {
            //            //        bslayer.CDSetCommandMode();
            //            //        bslayer.CDSetCharacterSet();
            //            //    }
            //            //}
            //            DisplayMessage("CREATING ORDER PAD ..........      ", 3);
            //            // if (OrderPad == null)
            //            OrderPad = ActivatorUtilities.CreateInstance < trmOrderPadMain>(ServiceHelper.Services, this, true);
            //            DisplayMessage("CHECKING USER INFORMATION  ..........      ", 4);
            //            try
            //            {
            //                DisplayMessage("INITIATING REPORT MODULE  ..........      ", 4);

            //            } catch
            //            {
            //            }
            //        } else
            //        {
            //            goto StartAgain;
            //        }
            //    CheckUser();
            //    txtUserPassword.Clear();
            //} catch
            //{

            //}
            tmrSaat.Enabled = false;
        }
        #endregion

        public void ResetProgress()
        {
            pBar.Value = 0;
            tmrSaat.Enabled = true;
        }

        private async void CheckUser()
        {
            User user = null;
            bslayer.EnsureRequiredUsers();

            if (txtUserPassword.Text.Length > 0)
            {
                user =await bslayer.GetUserByPassword(txtUserPassword.Text);
                if (user == null)
                {
                    DisplayMessage("LOGIN FAILURE ..........      ", 2);
                    ShowFailedLogon();
                } else
                {
                    ResetLogonButton();
                    // blnValidUser = true;
                    LoginUser(user);
                }
            }
        }

        private void LoginUser(User user)
        {
            DisplayMessage("LOGIN YOUR KEY", 3);
            this.Hide();

            txtUserPassword.Clear();
            bslayer.LoggedUser = user.Clone();
            OrderPad.bslayer = bslayer;
            OrderPad.Enabled = true;


            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(config.Terminal_Currency_Culture);

            OrderPad.Show();



            if (LoginCounter > 0)
                OrderPad.DoInitialThings();
            LoginCounter++;
            bslayer.OnDisplayOrder();
        }

        private void ShowFailedLogon()
        {
            btnLogon.Text = "FAILED";
        }
        private void ResetLogonButton()
        {
            btnLogon.Text = "LOGON";
        }

        #region "PANIC FUNCTIONS"

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowKeyboard()
        {
            DRProcess.ShowKeyboard();
        }


        private void TmrSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmLock_Shown(object sender, EventArgs e)
        {
            ResetProgress();
        }

        private void LogoBox_DoubleClick(object sender, EventArgs e)
        {
            this.TopMost = false;
            frmConfig frm = ActivatorUtilities.CreateInstance< frmConfig>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (POSLayer.Library.UF.SaveConfig(frm.config))
                {
                    if (bslayer != null)
                        config = frm.config;

                    if (OrderPad != null)
                        OrderPad.ConfigChanged();
                }
            }
        }



        #endregion

        private void LogoBox_Click(object sender, EventArgs e)
        {

        }
    }
}
