using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer.Forms {
    public partial class frmEmployeeSelector : Form {

        IRepository<Employee> repoEmployee;
        IRepository<GenericImage> repoImage;

        public Employee SelectedEmployee;
        private bool blnPhotos;
        public frmEmployeeSelector() {
            InitializeComponent();
        }
        public frmEmployeeSelector(IRepository<Employee> _repoEmployee, IRepository<GenericImage> _repoImage) {
            InitializeComponent();
            repoEmployee = _repoEmployee;
            repoImage = _repoImage;
        }
        private void frmEmployeeSelector_Load(object sender, EventArgs e) {
            LoadEmployeeList();
        }

        private async void LoadEmployeeList() {
            lvwEmployees.Items.Clear();
            List<Employee> employees = await repoEmployee.GetAllAsync();

            imgList.Images.Clear();
            foreach (Employee employee in employees) {
                if (blnPhotos) {
                    GenericImage gim =await repoImage.Get(employee.IID);
                    Image imgProfil = null;
                    if (gim == null) {
                        imgProfil = Properties.Resources.BlueMan32;
                    } else {
                        imgProfil = gim.DisplayImage.ToImage();
                    }
                    imgList.Images.RemoveByKey(employee.IID);
                    imgList.Images.Add(employee.IID, imgProfil);
                } else {
                    imgList.Images.Add(Properties.Resources.BlueMan32);
                }
               
                ListViewItem lvi = new ListViewItem(employee.EmployeeName);
                if (blnPhotos) {
                    lvi.ImageKey = employee.IID;
                } else {
                    lvi.ImageIndex = 0;
                }
                lvi.Tag = employee.IID;
                lvi.SubItems.Add(employee.EmployeeName);

                lvwEmployees.Items.Add(lvi);
            }
        }


        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSelect_Click(object sender, EventArgs e) {
            if (lvwEmployees.SelectedItems.Count > 0) {
                SelectedEmployee = await repoEmployee.Get(lvwEmployees.SelectedItems[0].Tag.ToString());
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void lvwEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            btnSelect_Click(sender, e);
        }

        private void btnPhotos_Click(object sender, EventArgs e) {
            blnPhotos = !blnPhotos;
            LoadEmployeeList();
        }
    }
}
