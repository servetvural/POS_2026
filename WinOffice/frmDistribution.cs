using System;
using System.Linq;
using System.Windows.Forms;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinOffice
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
            IRepository<Printer> _repoPrinter,Distribution _distribution)
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
            intOrder.Value = distribution.DOrder;
            distribution.DistributionPrinters.ReOrder();


            _printerSource.DataSource = distribution.DistributionPrinters; //.ToList().ToBindingList();


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
            distribution.DOrder = (int)intOrder.Value;

            if (distribution.DistributionName.Trim().Length == 0)
            {
                MessageBox.Show("Distribution Name Required");
                return;
            }
               if ( cmbMenu.SelectedValue == null)
            {
                MessageBox.Show("Menu is not Selected");
                return;
            }

            distribution.MenuIID = cmbMenu.SelectedValue.ToString();

            if (await repoDistribution.SaveTree(distribution) != null)
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
            if (cmbPrimaryPrinter.SelectedValue == null)
                return;

            if (distribution.IID.IsNullOrEmpty())
            {
                MessageBox.Show("Distribution must be saved before adding any printer to it.");
                return;
            }

            string newPrinterIID = cmbPrimaryPrinter.SelectedValue.ToString();
            if (distribution.DistributionPrinters.Any(x => x.PrinterIID == newPrinterIID))
            {
                MessageBox.Show("Printer Already Added");
            } else
            {
                distribution.DistributionPrinters.ReOrder();
                DistributionPrinter dprinter = await repoDistributionPrinter.Save(new DistributionPrinter()
                {
                    PrinterIID = newPrinterIID,
                    DistributionIID = distribution.IID,
                    DOrder = distribution.DistributionPrinters.Count() + 1
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
                DistributionPrinter distprinterToDelete = (DistributionPrinter)dgv.SelectedRows[0].DataBoundItem;

                if (distprinterToDelete != null)
                {
                    _printerSource.List.Remove(distprinterToDelete);
                    distribution.DistributionPrinters.ReOrder();
                    await repoDistributionPrinter.Delete(distprinterToDelete.IID);
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (!distribution.DistributionPrinters.IsNullOrEmpty() && dgv.SelectedRows.Count > 0)
            {
                DistributionPrinter distPrinterToMoveUp = (DistributionPrinter)dgv.SelectedRows[0].DataBoundItem;
                distribution.DistributionPrinters.MoveUp(distPrinterToMoveUp);
                 _printerSource.DataSource = distribution.DistributionPrinters.ToBindingList();
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (!distribution.DistributionPrinters.IsNullOrEmpty() && dgv.SelectedRows.Count > 0)
            {
                DistributionPrinter distPrinterToMoveDown = (DistributionPrinter)dgv.SelectedRows[0].DataBoundItem;
                distribution.DistributionPrinters.MoveDown(distPrinterToMoveDown);
                _printerSource.DataSource = distribution.DistributionPrinters.ToBindingList();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (!distribution.DistributionPrinters.IsNullOrEmpty())
            {
                _printerSource.DataSource = distribution.DistributionPrinters.ReOrder().ToBindingList();
            }
        }
    }
}
