using System;
using System.Windows.Forms;

using PosLibrary;
using DTRMNS;
using System.Diagnostics;

namespace DTRMClientNS
{
    public partial class FrmLock : Form
    {
        private DTRMNS.DTRMSimpleBusiness bslayer;
        private trmOrderPadMain OrderPad;
        private int LoginCounter;

        public FrmLock()
        {
            InitializeComponent();
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

            if (bslayer == null || bslayer.config == null)
            {
                if (!ValidateConfiguration())
                {
                    Application.Exit();
                }
            } else
            {


                try
                {
                    if (bslayer != null)
                        if (bslayer.config != null)
                            this.WindowState = bslayer.config.Lock_Screen_Window_Format;
                        else
                            this.WindowState = UF.GetConfig().Lock_Screen_Window_Format;
                    else
                        this.WindowState = UF.GetConfig().Lock_Screen_Window_Format;
                } catch
                {

                }
                this.TopMost = false;
                pnlAlign.Left = (int)((this.Width - pnlAlign.Width) / 2);
            }
        }

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

        private bool ValidateConfiguration()
        {
            try
            {
                if (UF.GetConfig() == null)
                {
                    LogoBox_DoubleClick(null, null);
                    if (UF.GetConfig() == null)
                    {
                        MessageBox.Show("CONFIGURATION ERROR, PLEASE CONFIGURE THE APPLICATION FIRST.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return false;
                    }
                }

                DisplayMessage("VALIDATING CONFIGURATION........   ", 2);
                bslayer = new DTRMSimpleBusiness
                {
                    config = UF.GetConfig()
                };


                //Validate Client IP
                if (bslayer.config.Terminal_Name.Trim() == "")
                {

                    DisplayMessage("VALIDATION ERROR 1", 2);
                    return false;

                }
                DisplayMessage("DB SERVER IP VALID, CHECKING DB CONNECTION  .....", 2);

                if (!bslayer.EstablishDatabaseConnection())
                {
                    if (MessageBox.Show("Check Database Connection Error : \r\n" + bslayer.DBConnectionError + "\r\n\r\nExit Application??", "Database Connection Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        Application.Exit();
                    DisplayMessage("VALIDATION ERROR 3 " + bslayer.DBConnectionError, 2);
                    return false;

                }
                DisplayMessage("DB SERVER AND CONNECTION ARE VALID.....", 2);
                return true;

            } catch
            {
                return false;
            }
        }


        private void BtnLogon_Click(object sender, System.EventArgs e)
        {
            this.TopMost = false;
            bslayer = new DTRMSimpleBusiness();
            //if (!bslayer.CheckNecessaryInstallationsAndFiles())
            //    return;
            this.TopMost = true;
            bslayer = null;

            if (txtUserPassword.Text.Length == 0)
                return;

        StartAgain:
            pBar.Value = 0;

            try
            {
                if (bslayer == null || bslayer.config == null || bslayer.db == null)
                {
                    if (ValidateConfiguration())
                    {
                        //DisplayMessage("CHECKING DATABASE UPDATES.............        ", 2);
                        //bslayer.CheckAndUpdateDatabaseVersion();

                        DisplayMessage("STARTING BUSINESS LAYER ..........      ", 2);
                        if (!bslayer.DoStartThings())
                        {
                            DisplayMessage("Cannot Start Business Layer", 2);
                            return;
                        }
                        //if (bslayer.DisplayPort == null) {
                        //    if (bslayer.HasCustomerDisplay()) {
                        //        bslayer.CDSetCommandMode();
                        //        bslayer.CDSetCharacterSet();
                        //    }
                        //}
                        DisplayMessage("CREATING ORDER PAD ..........      ", 3);
                        // if (OrderPad == null)
                        OrderPad = new trmOrderPadMain(bslayer, this, true);
                        DisplayMessage("CHECKING USER INFORMATION  ..........      ", 4);
                        try
                        {
                            DisplayMessage("INITIATING REPORT MODULE  ..........      ", 4);

                        } catch
                        {
                        }
                    } else
                    {
                        goto StartAgain;
                    }
                }
                CheckUser();
                txtUserPassword.Clear();
            } catch
            {

            }
            tmrSaat.Enabled = false;
        }
        #endregion

        public void ResetProgress()
        {
            pBar.Value = 0;
            tmrSaat.Enabled = true;
        }

        private void CheckUser()
        {
            User user = null;
            bslayer.EnsureRequiredUsers();

            if (txtUserPassword.Text.Length > 0)
            {
                user = bslayer.GetUserByPassword(txtUserPassword.Text);
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


            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(bslayer.config.Terminal_Currency_Culture);

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
            //Close();
            Application.Exit();
        }

        //private void TestConnection() {
        //    TcpClient tcpClient = new TcpClient();
        //    IPAddress ip = IPAddress.Parse(txtDBServerIP.Text.Trim());
        //    int port = int.Parse(txtDBPort.Text.Trim());

        //    tcpClient.BeginConnect(ip, port, new AsyncCallback(ConnectCallback), tcpClient);
        //    txtResult.AppendText("Attempting to connect to the database.....\r\n");
        //}

        //// The following method is called when each asynchronous operation completes.
        //private void ConnectCallback(IAsyncResult result) {
        //    TcpClient tcpClient = (TcpClient)result.AsyncState;

        //    if (InvokeRequired)
        //        Invoke(new AsyncCallBack(ConnectCallback), new object[] { result });
        //    else {

        //        if (result.IsCompleted) {
        //            if (tcpClient.Connected)
        //                txtResult.AppendText("Connected Successfully.\r\n");
        //            else
        //                txtResult.AppendText("Failed To Connect.!!\r\n");
        //        } else
        //            txtResult.AppendText("%");
        //    }
        //}


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
            frmConfig frm = new frmConfig(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (UF.SaveConfig(frm.config))
                {
                    if (bslayer != null)
                        bslayer.config = frm.config;

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
