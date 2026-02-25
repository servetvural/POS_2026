using PosLibrary.DRSoftware;
using DTRMNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTRMSimpleBackOffice {
    public partial class frmEmployee : Form {
        private DTRMSimpleBusiness bslayer;
        public Employee employee;
        private GenericImage gim;
        public frmEmployee(DTRMSimpleBusiness bslayer, Employee employee) {
            InitializeComponent();
            this.bslayer = bslayer;
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

        private void LoadGenericImage() {
            try {
                gim = bslayer.GetGenericImage(employee.IID);
                if (gim == null) {
                   // pBox.BackgroundImage = Properties.Resources.BlueMan32;
                } else {
                    if (gim.DisplayImage != null)
                        pBox.BackgroundImage = gim.DisplayImage;
                    lblImageSize.Text = gim.ImageSizeinKB + " KB";
                }
            } catch {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtEmployeeName.Text.Trim().Length > 0) {
                employee.EmployeeName = txtEmployeeName.Text.Trim();
                employee.Rate = (float)txtRate.Value;
                employee.Shortable = chkShortable.Checked;

                if (bslayer.SaveEmployee(employee)) {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnLoadPrepImageFromDirectory_Click(object sender, EventArgs e) {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files | *.*|GIF Images |*.gif|JPG  Images|*.jpg|JPEG Images |*.jpeg|PNG Images|*.png";
            dlg.Multiselect = false;
            dlg.Title = "Button Image / Prep Image";

            if (dlg.ShowDialog() == DialogResult.OK) {
                FileInfo finfo = new FileInfo(dlg.FileName);
               // txtImageFile.Text = finfo.Name;

                Image img = Image.FromFile(dlg.FileName);
                pBox.BackgroundImage = img;

                gim = new GenericImage(employee.IID, img, "", finfo.Name);
                bslayer.SaveGenericImage(gim);
            }
        }

        private void btnDeletePrepImage_Click(object sender, EventArgs e) {
            bslayer.DeletePrepImage(employee.IID);
            pBox.BackgroundImage = null;
        }
    }
}
