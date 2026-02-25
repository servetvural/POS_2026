using System;
using System.Drawing;
using System.Windows.Forms;

using DTRMNS;
using DronaxLibrary;

using SharpUpdate;


namespace DTRMSimpleBackOffice{
    public partial class frmVersion : Form{
        private DTRMSimpleBusiness bslayer;
        private ISharpUpdatable iSharpUpdatable;
        private frmOffice mainForm;
        private SharpUpdateXml updatexml;
        private bool blnDebug;

        public frmVersion(DTRMSimpleBusiness bslayer, frmOffice mainForm) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.iSharpUpdatable = (ISharpUpdatable) mainForm;
            this.mainForm = mainForm;
        }

        private void frmVersion_Load(object sender, EventArgs e) {

            LoadVersionData();
            this.Height = pnlOK.Location.Y + pnlOK.Size.Height + 70;
            
        }

        private void CheckApplicationType() {
            if (blnDebug) {
               pnlDatabaseFile.Visible = pnlSQLExpress.Visible = true;
                
                blnDebug = false;
            }
            this.Height = pnlOK.Location.Y + pnlOK.Size.Height + 70;
        }

        private void LoadVersionData() {
            try {
                if (iSharpUpdatable != null) {

                    if (SharpUpdateXml.ExistOnServer(iSharpUpdatable.UpdateXmlLocation))
                        updatexml =
                            (SharpUpdateXml)
                            SharpUpdateXml.Parse(iSharpUpdatable.UpdateXmlLocation, iSharpUpdatable.ApplicationID);

                    if (updatexml != null)
                        txtLatestApplication.Text = updatexml.Version.ToString();
                }
            }
            catch {
            }

            try {
                bool blnNoBslayerConnection = false;
                if (bslayer == null) {
                    bslayer = new DTRMSimpleBusiness();
                    blnNoBslayerConnection = true;
                }

                //Application Panel
                txtInstalledApplication.Text = bslayer.ApplicationVersion;
                if (updatexml == null) {
                    txtLatestApplication.BackColor = Color.Red;
                    lblLatestApplicationLink.Visible = false;
                }
                else {
                    txtLatestApplication.Text = updatexml.Version.ToString();
                    lblLatestApplicationLink.Visible =
                        DRUF.WhichVersionNumberIsBigger(bslayer.ApplicationVersion, updatexml.Version.ToString()) == 2;
                }

                //Dotnet Panel
                float installeddotnet = 0.0f;
                string installeddotnetversionasstring = DRUF.GetInstalledDotNetVersion(ref installeddotnet, false);
                txtInstalledDotNetVersion.Text = installeddotnetversionasstring;
                if (bslayer.RequiredDotNetVersion <= installeddotnet)
                    lblRequriedDotNetLink.Visible = false;
                txtRequiredDotNetVersion.Text = bslayer.RequiredDotNetVersion.ToString();
                if (updatexml == null) {
                    txtLatestDotNetVersion.BackColor = Color.Red;
                    lblLatestDotNetLink.Visible = false;
                }
                else {
                    txtLatestDotNetVersion.Text = updatexml.LatestDotNetVersion;
                    lblLatestDotNetLink.Visible =
                        DRUF.WhichVersionNumberIsBigger(installeddotnetversionasstring, updatexml.LatestDotNetVersion) ==
                        2;
                }

                
                

                


                bool blnUpdateRequired = false;
                bool blnUpdateOptional = false;

                if (!lblRequiredDatabaseFileLink.Visible &&
                    !lblRequiredSqlExpressLink.Visible && !lblRequriedDotNetLink.Visible)
                    blnUpdateOptional = true;
                else
                    blnUpdateRequired = true;

                if (blnUpdateRequired) {
                    lblNote.Text = "Necessary Update Required!\nPlease click on RED links to update your system.";
                    lblNote.ForeColor = Color.Red;
                }

                if (blnUpdateOptional) {
                    lblNote.Text = "No necessary update required !\n";
                    if (lblLatestApplicationLink.Visible || 
                        lblLatestSqlExpressLink.Visible || lblLatestDotNetLink.Visible) {
                        lblNote.Text += "Optional updates available!.\nTo update click on BLUE links.";
                        lblNote.ForeColor = Color.Blue;
                    }
                }


                if (false) {
                    //if (!UF.HasLocalDB()) {
                    //    MessageBox.Show("LocalDB must be installed for this version!");
                    //    System.Diagnostics.Process.Start(updatexml.LocalDbUrl);
                    //    System.Diagnostics.Process.Start("http://www.dronax.com");
                    //    return;
                    //}

                    
                    
                    //if (bslayer.config != null) {
                    //    if ((bslayer.config.Database_Type == DatabaseTypes.LocalDB) && lblRequiredSqlExpressLink.Visible)
                    //        lblRequiredSqlExpressLink.Visible = false;
                    //}
                }

            }
            catch {
                MessageBox.Show("There might be no internet connection.\nPlease check and try again.");
                this.Close();
            }

        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }



        private void lblRequiredLocalDbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(updatexml.LocalDbUrl);
        }

        private void lblRequiredDatabaseFileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            bslayer.CheckAndUpdateDatabaseVersion();
        }

        private void lblRequiredSqlExpressLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(updatexml.SqlExpressUrl);
        }

        private void lblRequriedDotNetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(updatexml.DotNetUrl);
        }


        private void lblLatestApplicationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
               

                if (lblLatestSqlExpressLink.Visible) {
                    MessageBox.Show("You must upgrade SQL SERVER version before application upgrade.");
                    return;
                }

                if (lblLatestDotNetLink.Visible) {
                    MessageBox.Show("You must upgrade .NET Framework version before application upgrade.");
                    return;
                }

                if (
                    MessageBox.Show("Are you sure you want to upgrade the application?\nThis is irreversable action!!!",
                        "APPLICATION UPGRADE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    mainForm.UpdateApplication();
            }
            catch {
                MessageBox.Show("Error");
            }
        }

        private void lblLatestLocalDbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(updatexml.LocalDbUrl);
        }

        private void lblLatestSqlExpressLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(updatexml.SqlExpressUrl);
        }

        private void lblLatestDotNetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(updatexml.DotNetUrl);
        }

        private void btnDebugMode_Click(object sender, EventArgs e) {
            blnDebug = true;
            CheckApplicationType();
        }

        private void cmbApplicationType_SelectionChangeCommitted(object sender, EventArgs e) {   
            CheckApplicationType();
            LoadVersionData();
        }

        private void cmbApplicationType_SelectedIndexChanged(object sender, EventArgs e) {
            //appType = (ApplicationTypes)cmbApplicationType.SelectedIndex;
        }
    }
}
