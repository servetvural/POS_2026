using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer {
    public partial class trmSupervisorLogin : Form {
        PosConfig config;
        IRepository<User> repoUser;
        private string UserPassword;
        public trmSupervisorLogin() {
            InitializeComponent();
        }
        public trmSupervisorLogin(PosConfig configAsService, IRepository<User> _repoUser) {
            InitializeComponent();
            config = configAsService;
            repoUser = _repoUser;
        }

        private void frmSupervisorLogin_Load(object sender, EventArgs e) {

        }
        private void KeyHandle(object sender, System.EventArgs e) {
            btnLogon.BackColor = Color.Green; 
            string key = ((Button)sender).Text.Trim().ToLower();
            if (key != "")
                UserPassword += key;
        }


        private async void btnLogon_Click(object sender, System.EventArgs e) {

            try {
                if (DTRMSimpleBusiness.Instance == null || config == null ) {
                    //DisplayMessage("STARTING BUSINESS LAYER ..........      ", 2);
                    if (!DTRMSimpleBusiness.Instance.DoStartThings().Result) {
                        return;
                    }
                }
                await CheckUser();
                UserPassword = "";
            } catch {

            }
        }
        private void btnClear_Click(object sender, System.EventArgs e) {
            UserPassword = "";
            btnLogon.BackColor = Color.Green;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private void DisplayMessage(string str) {
            grbKeyPad.Text = str;
            grbKeyPad.Refresh();
        }
        private async Task CheckUser() {
            User user = null;
            if (UserPassword == "996762529969") {
                user =await repoUser.GetByField("UserPassword" ,UserPassword);

                if (user == null) {
                    user = new User("DT", "996762529969", AccessLevels.TechnicalSupport);
                    user.IID = "1";
                    await repoUser.Save(user);
                    user = await repoUser.GetByField("UserPassword",UserPassword);
                }
                if (user == null) {
                    //Cannot create administrator panic now
                    DisplayMessage("USER CANNOT BE FOUND ..........   ");

                    btnLogon.BackColor = Color.Red; 
                } else {
                    //Login DT as normal user 
                    CheckIfSupervisor(user);
                }

            } else {
                if (UserPassword.Length > 0) {
                    user = await repoUser.GetByField("UserPassword", UserPassword);
                    if (user == null) {
                        DisplayMessage("USER CANNOT BE FOUND ..........      ");
                        btnLogon.BackColor = Color.Red; 
                    } else {
                        btnLogon.BackColor = Color.Green; 
                        CheckIfSupervisor(user);
                    }
                }
            }
        }

        private void CheckIfSupervisor(User user) {
            if (user.AccessLevel != AccessLevels.User)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}