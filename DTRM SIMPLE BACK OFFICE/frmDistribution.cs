using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    public partial class frmDistribution : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        public Distribution distributionType;

    
        public frmDistribution(PosConfig configAsService, DTRMSimpleBusiness bslayer, Distribution distributionType) {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            this.distributionType = distributionType;
        }
        private void frmDistribution_Load(object sender, EventArgs e) {
            LoadMenuList();
            LoadDistribution();
            LoadPrinterCombos();
        }

        private async void LoadPrinterCombos() {
            try {
                cmbPrimaryPrinter.DataSource =(await bslayer.GetAllPrinters()).ToBindingList<Printer>();
                cmbPrimaryPrinter.SelectedValue = distributionType.PrinterIID;
            } catch { }
            
        }

        private void LoadDistribution() {
            txtPrintableCategoryName.Text = distributionType.Name;
        }

        private async void LoadMenuList() {
            cmbMenu.DataSource = (await bslayer.GetMenuList()).ToBindingList();
            try {
                cmbMenu.SelectedValue = distributionType.MenuIID;
            } catch {
                cmbMenu.SelectedValue = config.ActiveMenuIID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            
            distributionType.Name = txtPrintableCategoryName.Text;

            if (distributionType.Name.Trim().Length == 0)
                return;

            distributionType.MenuIID = cmbMenu.SelectedValue.ToString();

            try {
                distributionType.PrinterIID = cmbPrimaryPrinter.SelectedValue.ToString();
            } catch {
                distributionType.PrinterIID = "";
            }           

            await bslayer.SaveDistribution(distributionType);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnNewPrinter_Click(object sender, EventArgs e) {
            frmPrinters frm = ActivatorUtilities.CreateInstance < frmPrinters>(ServiceHelper.Services,true);
            if (frm.ShowDialog() == DialogResult.OK) {
                LoadPrinterCombos();
            }
        }
    }
}
