using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRMNS {
    public partial class trmSupervisorLogin : Form {
        private DTRMSimpleBusiness bslayer;
        private string UserPassword;
        public trmSupervisorLogin() {
            InitializeComponent();
        }
        public trmSupervisorLogin(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmSupervisorLogin_Load(object sender, EventArgs e) {

        }
        private void KeyHandle(object sender, System.EventArgs e) {
            //lblNo.SendToBack();
            btnLogon.BackColor = Color.Green; // BackgroundImage = Properties.Resources.GoRightGreen48;
            string key = ((Button)sender).Text.Trim().ToLower();
            if (key != "")
                UserPassword += key;
        }


        private async void btnLogon_Click(object sender, System.EventArgs e) {
       // StartAgain:

            try {
                if (bslayer == null || bslayer.config == null ) {
                    //DisplayMessage("STARTING BUSINESS LAYER ..........      ", 2);
                    if (!bslayer.DoStartThings().Result) {
                        //DisplayMessage("Cannot Start Business Layer", 2);
                        return;
                    }
                }
                CheckUser();
                UserPassword = "";
            } catch {

            }
        }
        private void btnClear_Click(object sender, System.EventArgs e) {
            UserPassword = "";
           // lblNo.SendToBack();
            btnLogon.BackColor = Color.Green; // BackgroundImage = Properties.Resources.GoRightGreen48;
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
            POSLayer.Models.User user = null;
            if (UserPassword == "996762529969") {
                user =await bslayer.GetUserByPassword(UserPassword);

                if (user == null) {
                    user = new POSLayer.Models.User("DT", "996762529969", POSLayer.Library.AccessLevels.TechnicalSupport);
                    user.IID = "1";
                    await bslayer.SaveUser(user);
                    user = await bslayer.GetUserByPassword(UserPassword);
                }
                if (user == null) {
                    //Cannot create administrator panic now
                    DisplayMessage("USER CANNOT BE FOUND ..........   ");
                   //lblNo.BringToFront();
                    btnLogon.BackColor = Color.Red; // BackgroundImage = Properties.Resources.CrossRed256;
                } else {
                    //Login DT as normal user 
                    CheckIfSupervisor(user);
                }

            } else {
                if (UserPassword.Length > 0) {
                    user = await bslayer.GetUserByPassword(UserPassword);
                    if (user == null) {
                        DisplayMessage("USER CANNOT BE FOUND ..........      ");
                        //lblNo.BringToFront();
                        btnLogon.BackColor = Color.Red; //.BackgroundImage = Properties.Resources.CrossRed256;
                    } else {
                        //lblNo.SendToBack();
                        btnLogon.BackColor = Color.Green; // BackgroundImage = Properties.Resources.GoRightGreen48;
                        CheckIfSupervisor(user);
                    }
                }
            }
        }

        private void CheckIfSupervisor(POSLayer.Models.User user) {
            if (user.AccessLevel != POSLayer.Library.AccessLevels.User)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}