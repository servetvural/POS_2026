using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMSimpleBackOffice {
    public partial class frmDistribution : Form
    {
        PosConfig config;
        IRepository<TheMenu> repoMenu;
        IRepository<Distribution> repoDistribution;
        IRepository<Printer> repoPrinter;
        private DTRMSimpleBusiness bslayer;
        public Distribution distribution;

        private BindingSource _printerSource = new BindingSource();

        public frmDistribution(PosConfig configAsService, IRepository<TheMenu> _repoMenu, IRepository<Distribution> _repoDistribution,
            IRepository<Printer> _repoPrinter, DTRMSimpleBusiness bslayer, Distribution _distribution)
        {
            InitializeComponent();
            config = configAsService;
            repoMenu = _repoMenu;
            repoDistribution = _repoDistribution;
            repoPrinter = _repoPrinter;
            this.bslayer = bslayer;
            this.distribution = _distribution;
        }
        private void frmDistribution_Load(object sender, EventArgs e)
        {
            LoadMenuList();
            LoadPrinterCombos();
            LoadDistribution();     
        }

        private async void LoadPrinterCombos()
        {
            try
            {
                cmbPrimaryPrinter.DataSource = (await repoPrinter.GetAllAsync()).ToBindingList<Printer>();
            } catch { }

        }

        private async void LoadDistribution()
        {
            if (distribution.IID != null)
                distribution = await repoDistribution.Get(distribution.IID, "Menu,printers");
            txtPrintableCategoryName.Text = distribution.DistributionName;

            _printerSource.DataSource = distribution.printers.ToBindingList();
            dgv.DataSource = _printerSource;
        }

        private async void LoadMenuList()
        {
            cmbMenu.DataSource = (await bslayer.GetMenuList()).ToBindingList();
            try
            {
                cmbMenu.SelectedValue = distribution.MenuIID;
            } catch
            {
                cmbMenu.SelectedValue = config.ActiveMenuIID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            distribution.DistributionName = txtPrintableCategoryName.Text;

            if (distribution.DistributionName.Trim().Length == 0)
                return;

            distribution.MenuIID = cmbMenu.SelectedValue.ToString();

            //try {
            //    distributionType.PrinterIID = cmbPrimaryPrinter.SelectedValue.ToString();
            //} catch {
            //    distributionType.PrinterIID = "";
            //}           

            if (await repoDistribution.Save(distribution) != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }    else
            {
                MessageBox.Show("Failed To Save");
            }
        }

        private async void btnNewPrinter_Click(object sender, EventArgs e)
        {

            string newPrinterIID = cmbPrimaryPrinter.SelectedValue.ToString();
            if (distribution.printers.Any(x => x.IID == newPrinterIID))
            {
                MessageBox.Show("Printer Already Added");
            }                                             else
            {
                Printer newPrinter = await repoPrinter.Get(newPrinterIID);
               // distribution.printers.Add(newPrinter);
                if (await repoDistribution.AddPrinterToDistribution(distribution.IID, newPrinterIID))
                {
                    _printerSource.Add(newPrinter);
                    //distribution.printers = (await repoDistribution.Get(distribution.IID, "printers")).printers;
                }
            }
            //frmPrinters frm = ActivatorUtilities.CreateInstance<frmPrinters>(ServiceHelper.Services, true);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadPrinterCombos();
            //}
        }

        private async void btnDeletePrinter_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Printer printerToDelete = distribution.printers.Where(x => x.IID == dgv.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();

                if (printerToDelete != null)
                {
                    if (_printerSource.Current is Printer selectedPrinter)
                    {
                        // 1. Remove from the UI list (the BindingList)
                        _printerSource.RemoveCurrent();
                        await repoDistribution.RemovePrinterFromDistribution(distribution.IID, printerToDelete.IID);
                    }
                       // distribution.printers.Remove(printerToDelete);
                    
                }
               // await bslayer.DeleteDistribution(dgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
