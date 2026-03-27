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

namespace DTRMSimpleBackOffice
{
    public partial class frmDistribution : Form
    {
        PosConfig config;
        IRepository<TheMenu> repoMenu;
        IRepository<Distribution> repoDistribution;
        IRepository<DistributionPrinter> repoDistributionPrinter;
        IRepository<Printer> repoPrinter;
        public Distribution distribution;

        private BindingSource _printerSource = new BindingSource();

        public frmDistribution(PosConfig configAsService, IRepository<TheMenu> _repoMenu, IRepository<Distribution> _repoDistribution,
            IRepository<DistributionPrinter> _repoDistributionPrinter,
            IRepository<Printer> _repoPrinter, DTRMSimpleBusiness bslayer, Distribution _distribution)
        {
            InitializeComponent();
            config = configAsService;
            repoMenu = _repoMenu;
            repoDistribution = _repoDistribution;
            repoDistributionPrinter = _repoDistributionPrinter;
            repoPrinter = _repoPrinter;
            distribution = _distribution;
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
                distribution = await repoDistribution.Get(distribution.IID, "Menu,DistributionPrinters.Printer");
            txtPrintableCategoryName.Text = distribution.DistributionName;

            _printerSource.DataSource = distribution.DistributionPrinters.ToBindingList();
            dgv.DataSource = _printerSource;
        }

        private async void LoadMenuList()
        {
            cmbMenu.DataSource = (await repoMenu.GetAllAsync()).ToBindingList();
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

            if (await repoDistribution.Save(distribution) != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Failed To Save");
            }
        }

        private async void btnNewPrinter_Click(object sender, EventArgs e)
        {

            string newPrinterIID = cmbPrimaryPrinter.SelectedValue.ToString();
            if (distribution.DistributionPrinters.Any(x => x.PrinterIID == newPrinterIID))
            {
                MessageBox.Show("Printer Already Added");
            } else
            {
                DistributionPrinter dprinter = await repoDistributionPrinter.Save(new DistributionPrinter()
                {
                    PrinterIID = newPrinterIID,
                    DistributionIID = distribution.IID,
                    DOrder = distribution.DistributionPrinters.Count()
                }, "Printer");
                if (dprinter != null)
                {
                    _printerSource.Add(dprinter);
                }
            }
        }

        private async void btnDeletePrinter_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DistributionPrinter distprinterToDelete = distribution.DistributionPrinters.Where(x => x.IID == dgv.SelectedRows[0].Cells["colIID"].Value.ToString()).FirstOrDefault();

                if (distprinterToDelete != null)
                {
                    _printerSource.List.Remove(distprinterToDelete);
                    await repoDistributionPrinter.Delete(distprinterToDelete.IID);
                }
            }
        }
    }
}
