using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer
{

    public partial class frmSupplier : Form
    {
        IRepository<Supplier> repoSupplier;
        public Supplier supplier;

        public frmSupplier()
        {
            InitializeComponent();
        }
        public frmSupplier(IRepository<Supplier> _repoSupplier, Supplier supplier = null)
        {
            InitializeComponent();
            repoSupplier = _repoSupplier;
            this.supplier = supplier ?? new Supplier();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }
        private void LoadSupplier()
        {
            txtSupplierName.Text = supplier.SupplierName;
            txtTel.Text = supplier.Tel;
            txtAddress.Text = supplier.Address;
            txtEmail1.Text = supplier.Email1;
            txtEmail2.Text = supplier.Email2;
            txtwhatsup.Text = supplier.Whatsup;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text.Length > 0)
            {
                supplier.SupplierName = txtSupplierName.Text;
                supplier.Tel = txtTel.Text;
                supplier.Address = txtAddress.Text;
                supplier.Email1 = txtEmail1.Text;
                supplier.Email2 = txtEmail2.Text;
                supplier.Whatsup = txtwhatsup.Text;
                if (await repoSupplier.Save(supplier) != null)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
