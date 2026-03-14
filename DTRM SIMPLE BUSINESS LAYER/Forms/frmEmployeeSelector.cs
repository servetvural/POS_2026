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

using POSLayer.Models;

namespace DTRMNS.Forms {
    public partial class frmEmployeeSelector : Form {

        private DTRMSimpleBusiness bslayer;
        public Employee SelectedEmployee;
        private bool blnPhotos;
        public frmEmployeeSelector() {
            InitializeComponent();
        }
        public frmEmployeeSelector(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
        }
        private void frmEmployeeSelector_Load(object sender, EventArgs e) {
            LoadEmployeeList();
        }

        private void LoadEmployeeList() {

        //    lvwEmployees.Items.Clear();
        //    List<Employee> theList = bslayer.GetAllEmployeeList().OrderBy(x => x.EmployeeName).ToList(); 
        //    foreach (Employee emp in theList) {
        //        ListViewItem lvi = new ListViewItem(emp.EmployeeName, 0);
        //        lvi.Tag = emp.IID;
        //        lvwEmployees.Items.Add(lvi);
        //    }
        //    //dgv.DataSource = bslayer.GetAllEmployees();
        //    //dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
        //}

        //private void LoadEmployees() {
            lvwEmployees.Items.Clear();
            List<Employee> employees = bslayer.GetAllEmployeeList();

            imgList.Images.Clear();
            foreach (Employee employee in employees) {
                if (blnPhotos) {
                    GenericImage gim = bslayer.GetGenericImage(employee.IID);
                    Image imgProfil = null;
                    if (gim == null) {
                        imgProfil = Properties.Resources.BlueMan32;
                    } else {
                        imgProfil = gim.DisplayImage;
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
                //lvi.SubItems.Add(employee.Rate.ToString("c2"));

                lvwEmployees.Items.Add(lvi);
            }
        }


        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (lvwEmployees.SelectedItems.Count > 0) {
                SelectedEmployee = bslayer.GetEmployee(lvwEmployees.SelectedItems[0].Tag.ToString());
                this.DialogResult = DialogResult.OK;
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
