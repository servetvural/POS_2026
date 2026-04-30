using System;
using System.Diagnostics;
using System.Windows.Forms;
using WinLayer;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMClientNS
{
    public partial class FrmLock : Form
    {
        PosConfig config;
        IRepository<User> repoUser;
        private trmOrderPadMain OrderPad;

        public FrmLock(PosConfig configAsService,  IRepository<User> _repoUser)
        {
            InitializeComponent();
            config = configAsService;
            repoUser = _repoUser;

            txtUserPassword.Text = "";
        }

        private void FrmLock_Load(object sender, EventArgs e)
        {
            Process[] pList = Process.GetProcessesByName("PosTerminal");
            if (pList.GetLength(0) > 1)
            {
                for (int i = 0; i < pList.Length; i++)
                    pList[i].Kill();
            }

            if (config.IsValid())
            {

                try
                {
                    if (ServiceHelper.Services != null && BSLayer.Instance != null)
                        if (config != null)
                            this.WindowState = FormWindowState.Normal; 
                        else
                            this.WindowState = (FormWindowState)UF.GetConfig().Lock_Screen_Window_Format;
                    else
                        this.WindowState = (FormWindowState)UF.GetConfig().Lock_Screen_Window_Format;
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
            txtUserPassword.Clear();
            ResetLogonButton();
        }

        private async void BtnLogon_Click(object sender, System.EventArgs e)
        {
            this.TopMost = false;

            if (txtUserPassword.Text.Length == 0)
                return;

            User user = await repoUser.GetByField("UserPassword", txtUserPassword.Text);
            if (user == null)
            {
                txtUserPassword.Clear();
                return; 
            } else
            {
                BSLayer.Instance.LoggedUser = user;
                this.Hide();

                txtUserPassword.Clear();

                if (OrderPad == null)
                    OrderPad = ActivatorUtilities.CreateInstance< trmOrderPadMain>(ServiceHelper.Services, this, true);
            }

            
            tmrSaat.Enabled = false;
        }
        #endregion

        private void ResetLogonButton()
        {
            btnLogon.Text = "LOGON";
        }

        #region "PANIC FUNCTIONS"

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TmrSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
        private void LogoBox_DoubleClick(object sender, EventArgs e)
        {
            this.TopMost = false;
            frmConfig frm = ActivatorUtilities.CreateInstance< frmConfig>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Saved Restart Application");
                Environment.Exit(0);
            }
        }

        #endregion
    }
}
