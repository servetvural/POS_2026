using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using DTRMNS;

using System.Net;
using System.Net.Sockets;

using DronaxLibrary;
using DronaxLibrary.DBSpace;
using DronaxLibrary.Forms;
using System.IO;

namespace DTRMClientNS {
    /// <summary>
    /// Summary description for frmKeyboard.
    /// </summary>
    public class trmLock : System.Windows.Forms.Form {
        private Button button98;
        private Button button71;
        private Button button29;
        private Button button26;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button20;
        private Button button31;
        private Button button32;

        private Button btnClear;
        private Button btnLogon;

        private DTRMNS.DTRMSimpleBusiness bslayer;

        private bool blnValidUser;
        private Button btnExit;
        private trmOrderPadMain OrderPad;
        private DevComponents.DotNetBar.Controls.ProgressBarX pBar;
        private System.Windows.Forms.PictureBox LogoBox;

        private int LogoCount;

        private Panel panel1;
        private Label lblNotify;
        private Label lblSaat;
        private Timer tmrSaat;
        private DevComponents.DotNetBar.Keyboard.TouchKeyboard keyboard;
        private TextBox txtUserPassword;
        private IContainer components;
        private Panel pnlAlign;
        private int LoginCounter;
        
       // #endregion

        public trmLock() {
            InitializeComponent();
            txtUserPassword.Text = "";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trmLock));
            this.pBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button98 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNotify = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button71 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.btnLogon = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.keyboard = new DevComponents.DotNetBar.Keyboard.TouchKeyboard();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.pnlAlign = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.pnlAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar
            // 
            // 
            // 
            // 
            this.pBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pBar.Location = new System.Drawing.Point(17, 475);
            this.pBar.MarqueeAnimationSpeed = 30;
            this.pBar.Maximum = 10;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(328, 12);
            this.pBar.TabIndex = 92;
            this.pBar.Text = "progressBarX1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button98);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblNotify);
            this.panel1.Controls.Add(this.button32);
            this.panel1.Controls.Add(this.pBar);
            this.panel1.Controls.Add(this.button31);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button71);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button29);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Location = new System.Drawing.Point(190, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 496);
            this.panel1.TabIndex = 0;
            // 
            // button98
            // 
            this.button98.AutoEllipsis = true;
            this.button98.BackColor = System.Drawing.Color.Black;
            this.button98.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button98.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button98.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button98.ForeColor = System.Drawing.Color.White;
            this.button98.Location = new System.Drawing.Point(132, 5);
            this.button98.Name = "button98";
            this.button98.Size = new System.Drawing.Size(100, 100);
            this.button98.TabIndex = 2;
            this.button98.TabStop = false;
            this.button98.Text = "8";
            this.button98.UseVisualStyleBackColor = false;
            this.button98.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btnClear
            // 
            this.btnClear.AutoEllipsis = true;
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.BackgroundImage = global::DTRMClientNS.Properties.Resources.shadow;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(245, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 100);
            this.btnClear.TabIndex = 11;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNotify
            // 
            this.lblNotify.ForeColor = System.Drawing.Color.White;
            this.lblNotify.Location = new System.Drawing.Point(16, 455);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(331, 17);
            this.lblNotify.TabIndex = 93;
            this.lblNotify.Text = "LOGIN  YOUR  KEY";
            // 
            // button32
            // 
            this.button32.AutoEllipsis = true;
            this.button32.BackColor = System.Drawing.Color.Black;
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(132, 228);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 100);
            this.button32.TabIndex = 8;
            this.button32.TabStop = false;
            this.button32.Text = "2";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button31
            // 
            this.button31.AutoEllipsis = true;
            this.button31.BackColor = System.Drawing.Color.Black;
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(245, 228);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 100);
            this.button31.TabIndex = 9;
            this.button31.TabStop = false;
            this.button31.Text = "3";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button22
            // 
            this.button22.AutoEllipsis = true;
            this.button22.BackColor = System.Drawing.Color.Black;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(245, 116);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 100);
            this.button22.TabIndex = 6;
            this.button22.TabStop = false;
            this.button22.Text = "6";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button20
            // 
            this.button20.AutoEllipsis = true;
            this.button20.BackColor = System.Drawing.Color.Black;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(17, 5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 100);
            this.button20.TabIndex = 1;
            this.button20.TabStop = false;
            this.button20.Text = "7";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button71
            // 
            this.button71.AutoEllipsis = true;
            this.button71.BackColor = System.Drawing.Color.Black;
            this.button71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button71.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button71.ForeColor = System.Drawing.Color.White;
            this.button71.Location = new System.Drawing.Point(17, 340);
            this.button71.Name = "button71";
            this.button71.Size = new System.Drawing.Size(100, 100);
            this.button71.TabIndex = 10;
            this.button71.TabStop = false;
            this.button71.Text = "0";
            this.button71.UseVisualStyleBackColor = false;
            this.button71.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button23
            // 
            this.button23.AutoEllipsis = true;
            this.button23.BackColor = System.Drawing.Color.Black;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(245, 5);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 100);
            this.button23.TabIndex = 3;
            this.button23.TabStop = false;
            this.button23.Text = "9";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button29
            // 
            this.button29.AutoEllipsis = true;
            this.button29.BackColor = System.Drawing.Color.Black;
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(17, 228);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(100, 100);
            this.button29.TabIndex = 7;
            this.button29.TabStop = false;
            this.button29.Text = "1";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button24
            // 
            this.button24.AutoEllipsis = true;
            this.button24.BackColor = System.Drawing.Color.Black;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(132, 116);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 100);
            this.button24.TabIndex = 5;
            this.button24.TabStop = false;
            this.button24.Text = "5";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button26
            // 
            this.button26.AutoEllipsis = true;
            this.button26.BackColor = System.Drawing.Color.Black;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(17, 116);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 100);
            this.button26.TabIndex = 4;
            this.button26.TabStop = false;
            this.button26.Text = "4";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.KeyHandle);
            // 
            // lblSaat
            // 
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(190, 702);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(362, 36);
            this.lblSaat.TabIndex = 97;
            this.lblSaat.Text = "00:00:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // btnLogon
            // 
            this.btnLogon.AutoEllipsis = true;
            this.btnLogon.BackColor = System.Drawing.Color.Black;
            this.btnLogon.BackgroundImage = global::DTRMClientNS.Properties.Resources.LOGIN;
            this.btnLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogon.FlatAppearance.BorderSize = 0;
            this.btnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new System.Drawing.Point(580, 529);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(128, 128);
            this.btnLogon.TabIndex = 1;
            this.btnLogon.TabStop = false;
            this.btnLogon.Text = "LOGON";
            this.btnLogon.UseVisualStyleBackColor = false;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::DTRMClientNS.Properties.Resources.Dronax;
            this.LogoBox.Location = new System.Drawing.Point(304, 6);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(130, 125);
            this.LogoBox.TabIndex = 88;
            this.LogoBox.TabStop = false;
            this.LogoBox.DoubleClick += new System.EventHandler(this.LogoBox_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.AutoEllipsis = true;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImage = global::DTRMClientNS.Properties.Resources.LOGOUT;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(16, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 128);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "LOGOUT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // keyboard
            // 
            this.keyboard.FloatingLocation = new System.Drawing.Point(0, 0);
            this.keyboard.FloatingSize = new System.Drawing.Size(1024, 250);
            this.keyboard.Location = new System.Drawing.Point(0, 0);
            this.keyboard.Size = new System.Drawing.Size(740, 250);
            this.keyboard.Text = "";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.Black;
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtUserPassword.ForeColor = System.Drawing.Color.White;
            this.txtUserPassword.Location = new System.Drawing.Point(207, 144);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.ReadOnly = true;
            this.txtUserPassword.Size = new System.Drawing.Size(330, 43);
            this.txtUserPassword.TabIndex = 98;
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlAlign
            // 
            this.pnlAlign.Controls.Add(this.LogoBox);
            this.pnlAlign.Controls.Add(this.txtUserPassword);
            this.pnlAlign.Controls.Add(this.btnExit);
            this.pnlAlign.Controls.Add(this.lblSaat);
            this.pnlAlign.Controls.Add(this.panel1);
            this.pnlAlign.Controls.Add(this.btnLogon);
            this.pnlAlign.Location = new System.Drawing.Point(150, 0);
            this.pnlAlign.Name = "pnlAlign";
            this.pnlAlign.Size = new System.Drawing.Size(724, 742);
            this.pnlAlign.TabIndex = 99;
            // 
            // trmLock
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1022, 766);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAlign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trmLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmLock_Closing);
            this.Load += new System.EventHandler(this.frmLock_Load);
            this.Shown += new System.EventHandler(this.frmLock_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.pnlAlign.ResumeLayout(false);
            this.pnlAlign.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void frmLock_Load(object sender, System.EventArgs e) {
            Process[] pList = Process.GetProcessesByName("DTRMClient");
            if (pList.GetLength(0) > 1) {
                for (int i = 0; i < pList.Length; i++)
                    pList[i].Kill();
            }

            //LicenceTypes LicenceType = UF.ValidateLicence();
            //switch (LicenceType) {
            //    case LicenceTypes.None:
            //        Application.Exit();
            //        break;
            //    case LicenceTypes.Evaluation:
            //        //Lock some features
            //        break;
            //    case LicenceTypes.Valid:
            //        //Ok to go ahead
            //        break;
            //    case LicenceTypes.ValidAdvanced:
            //        //Enable extra features
            //        break;
            //    default:
            //        Application.Exit();
            //        break;
            //}
            ResetProgress();

            try {
                if (bslayer != null)
                    if (bslayer.config != null)
                        this.WindowState = bslayer.config.Lock_Screen_Window_Format;
                    else
                        this.WindowState = UF.GetConfig().Lock_Screen_Window_Format;
                else
                    this.WindowState = UF.GetConfig().Lock_Screen_Window_Format;
            } catch {

            }
            this.TopMost = false;
            pnlAlign.Left = (int)((this.Width - pnlAlign.Width) / 2);
        }
        private void frmLock_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = !blnValidUser;
        }

        #region "KEY HANDLERS"
        private void KeyHandle(object sender, System.EventArgs e) {
            ResetLogonButton();
            string key = ((Button)sender).Text.Trim().ToLower();
            if (key != "")
                txtUserPassword.Text += key;
        }
        private void btnClear_Click(object sender, System.EventArgs e) {
            LogoCount = 0;
            DisplayMessage("LOGIN YOUR KEY", 3);
            txtUserPassword.Clear();
            ResetLogonButton();
            pBar.Value = 0;
            pBar.Maximum = 1;          
        }       

        public void ShowProgress(int step) {
            if (step <= 0)
                pBar.Value = 0;
            else {
                if ((pBar.Value + step) > pBar.Maximum)
                    pBar.Maximum = pBar.Value + step + (int)((step + pBar.Value) * 0.2);
                pBar.Value = pBar.Value + step;
            }
        }

        private void DisplayMessage(string str, int progress) {
            if (progress > 0)
                ShowProgress(progress);
            lblNotify.Text = str;
            lblNotify.Refresh();
        }

        private bool ValidateConfiguration() {
            try {
                DisplayMessage("VALIDATING CONFIGURATION........   ", 2);
                bslayer = new DTRMSimpleBusiness();
                bslayer.config = UF.GetConfig();


                    //Validate Client IP
                    if (bslayer.config.Terminal_Name.Trim() == "") {
 
                            DisplayMessage("VALIDATION ERROR 1", 2);
                            return false;
                
                    }
                    DisplayMessage("DB SERVER IP VALID, CHECKING DB CONNECTION  .....", 2);

                    if (!bslayer.EstablishDatabaseConnection()) {

                            DisplayMessage("VALIDATION ERROR 3", 2);
                            return false;
   
                    }
                    DisplayMessage("DB SERVER AND CONNECTION ARE VALID.....", 2);
                    return true;
            } catch {
                    return false;
            }
        }

        
        private void btnLogon_Click(object sender, System.EventArgs e) {
            this.TopMost = false;
            bslayer = new DTRMSimpleBusiness();
            if (!bslayer.CheckNecessaryInstallationsAndFiles())
                return;
            this.TopMost = true;
            bslayer = null;

            if (txtUserPassword.Text.Length == 0)
                return;

            StartAgain:
            pBar.Value = 0;
           
            try {
                if (bslayer == null || bslayer.config == null || bslayer.db == null) {
                    if (ValidateConfiguration()) {
                        DisplayMessage("CHECKING DATABASE UPDATES.............        ", 2);
                        bslayer.CheckAndUpdateDatabaseVersion(true);

                        DisplayMessage("STARTING BUSINESS LAYER ..........      ", 2);
                        if (!bslayer.DoStartThings()) {
                            DisplayMessage("Cannot Start Business Layer", 2);
                            return;
                        }
                        if (bslayer.DisplayPort == null) {
                            if (bslayer.HasCustomerDisplay()) {
                                bslayer.CDSetCommandMode();
                                bslayer.CDSetCharacterSet();
                            }
                        }
                        DisplayMessage("CREATING ORDER PAD ..........      ", 3);
                        if (OrderPad == null)
                            OrderPad = new trmOrderPadMain(bslayer, this, true);
                        DisplayMessage("CHECKING USER INFORMATION  ..........      ", 4);
                        try {
                            DisplayMessage("INITIATING REPORT MODULE  ..........      ", 4);

                        }
                        catch {
                        }
                    }
                    else {
                            goto StartAgain;
                    }
                }         
                CheckUser();
                txtUserPassword.Clear();
            } catch {
                
            }
            tmrSaat.Enabled = false;
        }
        #endregion

        public void ResetProgress() {
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
                }
                else
                {
                    ResetLogonButton();
                    blnValidUser = true;
                    LoginUser(user);
                }
            }
        }

        private void LoginUser(User user) {
            DisplayMessage("LOGIN YOUR KEY", 3);
            this.Hide();
            

            bslayer.CDSetCommandMode();
            if (bslayer.AttachedOrder == null) {
                if (bslayer.config.Customer_Display_Unit_Connected_To_COM != SerialPortTypes.NONE)
                    bslayer.CDWelcome();

            } else
                bslayer.CDOrderTotal(CDAreas.All);

            txtUserPassword.Clear();
            bslayer.LoggedUser = user.Clone();
            OrderPad.bslayer = bslayer;
            OrderPad.Enabled = true;
            
            OrderPad.Show();
            if (LoginCounter > 0)
                OrderPad.DoInitialThings();
            LoginCounter++;
            bslayer.OnDisplayOrder();  
        }

        private void ShowFailedLogon() {
            btnLogon.Text = "FAILED";
        }
        private void ResetLogonButton() {
            btnLogon.Text = "LOGON";
        }

        #region "PANIC FUNCTIONS"

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

  
        
        #endregion



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


        public void ShowKeyboard() {
            DRProcess.ShowKeyboard();
        }       


        private void tmrSaat_Tick(object sender, EventArgs e) {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmLock_Shown(object sender, EventArgs e) {
            ResetProgress();
        }

        private void LogoBox_DoubleClick(object sender, EventArgs e) {
            this.TopMost = false;
            frmConfig frm = new frmConfig(null);
            if (frm.ShowDialog() == DialogResult.OK)
                UF.SaveConfig(frm.config);
        }
    }
}
