using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMSimpleBackOffice {
    public partial class frmCategorySelector : Form {
        IRepository<Category> repoCategory;
        private string MenuIID;
        public string SelectedCategoryIID;

        private BindingSource _categorySource = new BindingSource();
        public frmCategorySelector(IRepository<Category> _repoCategory,  string MenuIID) {
            InitializeComponent();
            repoCategory = _repoCategory;
            this.MenuIID = MenuIID;
        }

        private async void frmEntitySelector_Load(object sender, EventArgs e) {
            await LoadCategories();
        }

        private async Task LoadCategories() {
            dgvCategory.AutoGenerateColumns = false;
            _categorySource.DataSource =(await repoCategory.GetListByField("MenuIID", MenuIID)).ReOrder().ToBindingList();
            dgvCategory.DataSource = _categorySource;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (dgvCategory.SelectedRows.Count > 0) {

                SelectedCategoryIID = (_categorySource.Current as Category).IID;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
