#region File Header
//
//      FILE:   LicenseInstallForm.cs.
//
//    AUTHOR:   Grant Frisken
//
// COPYRIGHT:   Copyright 2004 
//              Infralution
//              6 Bruce St 
//              Mitcham Australia
//
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Infralution.Licensing
{
	/// <summary>
	/// Provides a basic form for installing Infralution Encrypted Licenses that can be extended or modified using 
	/// visual inheritance
	/// </summary>
	/// <seealso cref="EncryptedLicenseProvider"/>
#if PUBLIC_LICENSE_CLASS  // if true allows class to be visible outside library  
    public
#endif
    class LicenseInstallForm : System.Windows.Forms.Form
	{
        #region Member Variables

        /// <summary>The OK Button</summary>
        protected Button okButton;

        /// <summary>Displays the main message of the form</summary>
        protected System.Windows.Forms.Label msgLabel;

        /// <summary>Displays text to the left of the LicenseKey entry box</summary>
        protected System.Windows.Forms.Label keyLabel;
 
        /// <summary>Provides link to company website</summary>
        protected System.Windows.Forms.LinkLabel linkLabel;

        /// <summary>Displays text to the left of the website link</summary>
        protected System.Windows.Forms.Label linkLabelLabel;

        /// <summary>Allows the user to enter a license key for the product</summary>
        protected System.Windows.Forms.TextBox keyText;
 
        /// <summary>Label containing the message title displayed for invalid keys</summary>
        protected System.Windows.Forms.Label invalidKeyTitle;

        /// <summary>Label containing the message text displayed for invalid keys</summary>
        protected System.Windows.Forms.Label invalidKeyMsg;

        /// <summary>Label containing the message title displayed when an error occurs while installing a key</summary>
        protected System.Windows.Forms.Label errorTitle;

        /// <summary>Label containing the message text displayed when an error occurs while installing a key</summary>
        protected System.Windows.Forms.Label errorMsg;

        /// <summary>The license installed by the form (if any)</summary>
        private EncryptedLicense _license;

        private System.ComponentModel.Container components = null;
 
        /// <summary>The license provider to use to install the license</summary>
        private EncryptedLicenseProvider _licenseProvider;

        /// <summary>The type being licensed (if any)</summary>
        private System.Type _licenseType;

        /// <summary>The license file to use (if not licensing a type)</summary>
        private string _licenseFile;

 
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseInstallForm));
            this.okButton = new Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabelLabel = new System.Windows.Forms.Label();
            this.invalidKeyTitle = new System.Windows.Forms.Label();
            this.invalidKeyMsg = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.errorTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(338, 104);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 24);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.OnOkButtonClick);
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.msgLabel.BackColor = System.Drawing.Color.Transparent;
            this.msgLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.msgLabel.Location = new System.Drawing.Point(16, 8);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(402, 64);
            this.msgLabel.TabIndex = 1;
            this.msgLabel.Text = resources.GetString("msgLabel.Text");
            // 
            // keyText
            // 
            this.keyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.keyText.Location = new System.Drawing.Point(104, 72);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(314, 20);
            this.keyText.TabIndex = 2;
            // 
            // keyLabel
            // 
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.keyLabel.Location = new System.Drawing.Point(19, 74);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(77, 16);
            this.keyLabel.TabIndex = 3;
            this.keyLabel.Text = "License Key";
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 100);
            this.linkLabel.Location = new System.Drawing.Point(104, 112);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(18, 17);
            this.linkLabel.TabIndex = 4;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "{0}";
            this.linkLabel.UseCompatibleTextRendering = true;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelLabel
            // 
            this.linkLabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabelLabel.Location = new System.Drawing.Point(19, 112);
            this.linkLabelLabel.Name = "linkLabelLabel";
            this.linkLabelLabel.Size = new System.Drawing.Size(77, 16);
            this.linkLabelLabel.TabIndex = 5;
            this.linkLabelLabel.Text = "Visit us at:";
            this.linkLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invalidKeyTitle
            // 
            this.invalidKeyTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invalidKeyTitle.Location = new System.Drawing.Point(8, 160);
            this.invalidKeyTitle.Name = "invalidKeyTitle";
            this.invalidKeyTitle.Size = new System.Drawing.Size(224, 16);
            this.invalidKeyTitle.TabIndex = 6;
            this.invalidKeyTitle.Text = "Invalid License Key";
            // 
            // invalidKeyMsg
            // 
            this.invalidKeyMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invalidKeyMsg.Location = new System.Drawing.Point(8, 176);
            this.invalidKeyMsg.Name = "invalidKeyMsg";
            this.invalidKeyMsg.Size = new System.Drawing.Size(328, 40);
            this.invalidKeyMsg.TabIndex = 7;
            this.invalidKeyMsg.Text = "The key entered was not a valid license key for this product.";
            // 
            // errorMsg
            // 
            this.errorMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorMsg.Location = new System.Drawing.Point(8, 232);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(328, 40);
            this.errorMsg.TabIndex = 9;
            this.errorMsg.Text = "An error occurred while installing the license.  Ensure you have sufficient privi" +
                "leges to install the license.";
            // 
            // errorTitle
            // 
            this.errorTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorTitle.Location = new System.Drawing.Point(8, 216);
            this.errorTitle.Name = "errorTitle";
            this.errorTitle.Size = new System.Drawing.Size(224, 16);
            this.errorTitle.TabIndex = 10;
            this.errorTitle.Text = "License Install Error";
            // 
            // LicenseInstallForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(436, 142);
            this.Controls.Add(this.errorTitle);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.invalidKeyMsg);
            this.Controls.Add(this.invalidKeyTitle);
            this.Controls.Add(this.linkLabelLabel);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 176);
            this.Name = "LicenseInstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install {0} License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Public Interface

        /// <summary>
        /// Initialize a new instance of the form
        /// </summary>
        public LicenseInstallForm()
		{
			InitializeComponent();
		}

        /// <summary>
        /// The license provider to use to install the license
        /// </summary>
        /// <remarks>
        /// This allows you to set a license provider other than the default 
        /// (<see cref="EncryptedLicenseProvider"/>).
        /// </remarks>
        public EncryptedLicenseProvider LicenseProvider
        {
            get 
            {
                if (_licenseProvider == null)
                    _licenseProvider = this.GetLicenseProvider();
                return _licenseProvider; 
            }
            set { _licenseProvider = value; }
        }

        /// <summary>
        /// The type of the component/control being licensed (if any)
        /// </summary>
        /// <remarks>
        /// Set this if you are licensing a component or control.  If you are licensing an
        /// application set the <see cref="LicenseFile"/> property instead.
        /// </remarks>
        public Type TypeToLicense
        {
            get { return _licenseType; }
            set { _licenseType = value; }
        }

        /// <summary>
        /// The name of the license file to use when licensing an application
        /// </summary>
        /// <remarks>
        /// Set this if you are licensing an application.  If you are licensing a component
        /// or control then you should set the <see cref="TypeToLicense"/> property instead.
        /// </remarks>
        /// <seealso cref="EncryptedLicenseProvider.InstallLicense(string, string)"/>
        public string LicenseFile
        {
            get { return _licenseFile; }
            set { _licenseFile = value; }
        }

        /// <summary>
        /// The license installed by this form (if any)
        /// </summary>
        public EncryptedLicense InstalledLicense
        {
            get { return _license; }
        }

        /// <summary>
        /// Should the license key value accept multiple lines
        /// </summary>
        /// <remarks>
        /// Set this to true if you want to allow multiline keys to be able to be pasted
        /// into the key field
        /// </remarks>
        public bool AllowMultilineKeys
        {
            get { return keyText.Multiline; }
            set { keyText.Multiline = value; }
        }

        /// <summary>
        /// Display the InstallLicense Dialog for licensing a component or control
        /// </summary>
        /// <param name="productName">The name of the product being licensed</param>
        /// <param name="companyWebsite">The company website</param>
        /// <param name="typeToLicense">The type of the component being licensed</param>
        /// <returns>The newly installed license (if any)</returns>
        /// <remarks>
        /// Use this method to display the dialog to install a license for a component or control type
        /// </remarks>
        public EncryptedLicense ShowDialog(string productName, string companyWebsite, Type typeToLicense)
        {
            if (typeToLicense == null) throw new ArgumentNullException("typeToLicense");

            this.Text = string.Format(Text, productName);
            msgLabel.Text = string.Format(msgLabel.Text, productName);
            linkLabel.Text = companyWebsite;
            _licenseType = typeToLicense;
            this.ShowDialog();
            return _license;
        }

        /// <summary>
        /// Display the InstallLicense Dialog for licensing an application
        /// </summary>
        /// <param name="productName">The name of the product being licensed</param>
        /// <param name="companyWebsite">The company website</param>
        /// <param name="licenseFile">The name of the license file</param>
        /// <returns>The newly installed license (if any)</returns>
        /// <remarks>
        /// Use this method to display the dialog to install a license for an application
        /// </remarks>
        public EncryptedLicense ShowDialog(string productName, string companyWebsite, string licenseFile)
        {
            if (licenseFile == null) throw new ArgumentNullException("licenseFile");

            this.Text = string.Format(Text, productName);
            msgLabel.Text = string.Format(msgLabel.Text, productName);
            linkLabel.Text = companyWebsite;
            _licenseFile = licenseFile;
            this.ShowDialog();
            return _license;
        }

        #endregion

        #region Local Methods and Overrides

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        /// <summary>
        /// Return the license provider to use
        /// </summary>
        /// <returns>The license provider to use for installing licensing</returns>
        protected virtual EncryptedLicenseProvider GetLicenseProvider()
        {
            return new EncryptedLicenseProvider();
        }

        /// <summary>
        /// Install the license key entered by the user
        /// </summary>
        /// <param name="key">The key to install</param>
        /// <returns>True if the license was installed successfully</returns>
        protected virtual bool InstallLicenseKey(string key)
        {
            try
            {
                if (_licenseType == null)
                    _license = LicenseProvider.InstallLicense(_licenseFile, key); 
                else
                    _license = LicenseProvider.InstallLicense(_licenseType, key);
                if (_license == null)
                {
                    MessageBox.Show(invalidKeyMsg.Text, invalidKeyTitle.Text, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (_license != null);
            }
            catch 
            {
                MessageBox.Show(errorMsg.Text, errorTitle.Text, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// Handle Click event for the OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnOkButtonClick(object sender, System.EventArgs e)
        {

            if (keyText.Text == null || keyText.Text.Trim().Length == 0)
            {
                this.Close();
            }
            else 
            {
                if (InstallLicenseKey(keyText.Text))
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Handle click on the link label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void linkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            string address = @"http://" + linkLabel.Text;
            linkLabel.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(address);      
            }
            catch {}
        }

        #endregion


	}
}
