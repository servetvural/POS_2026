using System;
using System.IO;
using System.Windows.Forms;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using POSWinFormLayer;

namespace DTRMSimpleBackOffice {
    public partial class frmEmployee : Form {
        IRepository<Employee> repoEmployee;
        IRepository<GenericImage> repoImage;

        public Employee employee;
        private GenericImage gim;
        public frmEmployee(IRepository<Employee> _repoEmployee, IRepository<GenericImage> _repoImage, Employee employee) {
            InitializeComponent();
            repoEmployee = _repoEmployee;
            repoImage = _repoImage;

            this.employee = employee;
        }

        private void frmEmployee_Load(object sender, EventArgs e) {
            LoadEmployee();
        }

        private void LoadEmployee() {
            if (employee != null) {
                txtEmployeeName.Text = employee.EmployeeName;
                txtRate.Value = (decimal)employee.Rate;
                chkShortable.Checked = employee.Shortable;
                LoadGenericImage();
            }
        }

        private async void LoadGenericImage() {
            try {
                gim = await repoImage.Get(employee.IID);
                if (gim == null) {

                } else {
                    if (gim.DisplayImage != null)
                        pBox.BackgroundImage = gim.DisplayImage.ToImage(); 
                    lblImageSize.Text = gim.ImageSizeinKB + " KB";
                }
            } catch {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (txtEmployeeName.Text.Trim().Length > 0) {
                employee.EmployeeName = txtEmployeeName.Text.Trim();
                employee.Rate = (float)txtRate.Value;
                employee.Shortable = chkShortable.Checked;

                if (await repoEmployee.Save(employee) != null) {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void btnLoadPrepImageFromDirectory_Click(object sender, EventArgs e) {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Button Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK) {
                FileInfo finfo = new FileInfo(dlg.FileName);
               // txtImageFile.Text = finfo.Name;

                System.Drawing.Image img = System.Drawing.Image.FromFile(dlg.FileName);
                pBox.BackgroundImage = img;

                gim = new GenericImage()
                {
                    ReferenceIID = employee.IID,
                    DisplayImage = img.ToByteArray(),
                    ExtraText = "",
                    ImageFileName = finfo.Name
                };
                await repoImage.Save(gim);
            }
        }

        private async void btnDeletePrepImage_Click(object sender, EventArgs e) {
            await repoImage.Delete(employee.IID);
            pBox.BackgroundImage = null;
        }
    }
}
