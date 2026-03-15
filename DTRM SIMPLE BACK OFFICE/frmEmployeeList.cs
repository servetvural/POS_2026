using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Newtonsoft.Json;

using POSLayer.Library;
using POSLayer.Models;

//using POSLayer.Models;
using POSLayer.Repository.IRepository;

using POSWinFormLayer;

namespace DTRMSimpleBackOffice {
    public partial class frmEmployeeList : Form {

        private DTRMSimpleBusiness bslayer;
        public POSLayer.Models.Employee SelectedEmployee;
        //  PosDbContext dbContext;
        IRepository<POSLayer.Models.Employee> repoEmployee;

        public frmEmployeeList(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
            // dbContext = ServiceHelper.GetService<PosDbContext>();
            repoEmployee = ServiceHelper.GetRepository<POSLayer.Models.Employee>();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e) {
            LoadEmployees();
        }

        private async void LoadEmployees() {
            lvwEmployee.Items.Clear();
            //List<POSLayer.Models.Employee> employees = await repoEmployee.GetAllAsync(); 
            List<Employee> employees=await bslayer.GetAllEmployeeList();

            imgList.Images.Clear();
            foreach (Employee employee in employees)
            {
                GenericImage gim =await bslayer.GetGenericImage(employee.IID);
                System.Drawing.Image imgProfil = null;
                if (gim == null)
                {
                    imgProfil = Properties.Resources.BlueMan32;
                } else
                {
                    imgProfil = gim.DisplayImage.ToImage();
                }

                imgList.Images.RemoveByKey(employee.IID);
                imgList.Images.Add(employee.IID, imgProfil);
                ListViewItem lvi = new ListViewItem(employee.EmployeeName + " " + employee.Rate.ToString("c2"));
                lvi.ImageKey = employee.IID;
                lvi.SubItems.Add(employee.EmployeeName);
                lvi.SubItems.Add(employee.Rate.ToString("c2"));
                lvi.SubItems.Add(employee.Shortable.ToString());

                lvwEmployee.Items.Add(lvi);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e) {
            frmEmployee frm = new frmEmployee(bslayer, new Employee());
            if (frm.ShowDialog() == DialogResult.OK)
                btnReload_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            //if (lvwEmployee.SelectedItems.Count > 0) {
            //    ListViewItem lvi = lvwEmployee.SelectedItems[0];
            //    Employee employee = bslayer.GetEmployee(lvi.ImageKey);
            //    frmEmployee frm = new frmEmployee(bslayer, employee);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //        btnReload_Click(sender, e);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lvwEmployee.SelectedItems.Count > 0) {
                if (MessageBox.Show("This will delete Employee from Database. Sure??", "Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                    ListViewItem lvi = lvwEmployee.SelectedItems[0];
                    bslayer.DeleteEmployee(lvi.ImageKey);
                        btnReload_Click(sender, e);
                }


            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e) {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit_Click(null, null);
        }

        private void btnReload_Click(object sender, EventArgs e) {
            LoadEmployees();
        }


        private void btnLargeIcon_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(120, 120);
            lvwEmployee.View = View.LargeIcon;
            LoadEmployees();
        }

        private void btnSmallIcon_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(60, 60);
            lvwEmployee.View = View.SmallIcon;
            LoadEmployees();
        }

        private void btnDetails_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(50, 50);
            lvwEmployee.View = View.Details;
            lvwEmployee.Columns[0].Width = 56;
            LoadEmployees();
        }

        private void btnList_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(60, 60);
            lvwEmployee.View = View.List;
            LoadEmployees();
        }

        private void btnTile_Click(object sender, EventArgs e) {
            imgList.ImageSize = new Size(60, 60);
            lvwEmployee.View = View.Tile;
            LoadEmployees();
        }

        private void lvwEmployee_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvwEmployee.SelectedItems.Count > 0) {
                btnEdit_Click(null, null);
            }
        }

        private void btnExportAsJson_Click(object sender, EventArgs e)
        {
            //List<Employee> employeeList = bslayer.GetAllEmployeeList();
            //using (SaveFileDialog sfd = new SaveFileDialog())
            //{
            //    sfd.Filter = "JSON Files (*.json)|";
            //    sfd.FileName = "Employee List.json";
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        if (sfd.FileName != null && sfd.FileName != "")
            //        {

                        
            //            var jsonString = JsonConvert.SerializeObject(employeeList,Formatting.Indented);
            //            if (UF.SaveTextFile(sfd.FileName, jsonString))
            //                MessageBox.Show("Saved Employee List");
            //            else
            //                MessageBox.Show("Failed to Save Employee List");
            //        }
            //    }
            //}
        }

        private void btnImportFromJson_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog sfd = new OpenFileDialog())
            //{
            //    sfd.Filter = "JSON Files (*.json)|";
            //   // sfd.FileName = "Employee List";
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        if (sfd.FileName != null && sfd.FileName != "")
            //        {
            //            string content = UF.GetTextFile(sfd.FileName);
            //            if (!string.IsNullOrEmpty(content))
            //            {
            //                List<Employee> employeeList = JsonConvert.DeserializeObject<List<Employee>>(content);
            //                foreach (Employee employee in employeeList)
            //                {
            //                    bslayer.SaveEmployee(employee);
            //                }
            //                MessageBox.Show("Saved Employee List");
            //            } else
            //            {
            //                MessageBox.Show("Failed to Get Employee List");
            //            }
            //            LoadEmployees();
            //        }
            //    }
            //}
        }
    }
}
