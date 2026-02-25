using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTRMNS;

namespace DTRMSimpleBackOffice {
    public partial class frmDistribution : Form {
        private DTRMSimpleBusiness bslayer;
        public Distribution distributionType;

        public frmDistribution() {
            InitializeComponent();
        }
        public frmDistribution(DTRMSimpleBusiness bslayer, Distribution distributionType) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.distributionType = distributionType;
        }
        private void frmDistribution_Load(object sender, EventArgs e) {
            LoadMenuList();
            LoadDistribution();
            LoadPrinterCombos();
        }

        private void LoadPrinterCombos() {
            try {
                cmbPrimaryPrinter.DataSource = bslayer.GetPrinterListDB();
                cmbPrimaryPrinter.SelectedValue = distributionType.PrinterIID;
            } catch { }
            
        }

        private void LoadDistribution() {
            txtPrintableCategoryName.Text = distributionType.DistributionName;
            txtPrintableCategoryShortName.Text = distributionType.ShortName;
        }

        private void LoadMenuList() {
            cmbMenu.DataSource = bslayer.GetMenuList();
            try {
                cmbMenu.SelectedValue = distributionType.ParentMenuIID;
            } catch {
                cmbMenu.SelectedValue = bslayer.config.ActiveMenuIID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            
            distributionType.DistributionName = txtPrintableCategoryName.Text;

            if (distributionType.DistributionName.Trim().Length == 0)
                return;

            distributionType.ShortName = txtPrintableCategoryShortName.Text;
            distributionType.ParentMenuIID = cmbMenu.SelectedValue.ToString();

            try {
                distributionType.PrinterIID = cmbPrimaryPrinter.SelectedValue.ToString();
            } catch {
                distributionType.PrinterIID = "";
            }           

            bslayer.SaveDistribution(distributionType);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnNewPrinter_Click(object sender, EventArgs e) {
            frmPrinters frm = new frmPrinters(bslayer,true);
            if (frm.ShowDialog() == DialogResult.OK) {
                LoadPrinterCombos();
            }
        }
    }
}
