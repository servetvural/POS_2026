using System;
using System.Windows.Forms;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace POSOffice {
    public partial class frmTable : Form {

        IRepository<Masa> repoTable;
        IRepository<Salon> repoSalon;

        public Masa table;
        public Salon salon;

        public frmTable() {
            InitializeComponent();
        }
        public frmTable(  Masa table) {
            InitializeComponent();
            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();   
            repoTable = ServiceHelper.GetService<IRepository<Masa>>();

            this.table = table;
           
        }
        private async void frmTable_Load(object sender, EventArgs e) {
            salon = await repoSalon.Get(table.SalonIID);
            LoadTable();
        }

        private void LoadTable() {
            txtTableName.Text = table.DefaultName;
            txtTableCovers.Text = table.TableCovers.ToString();
            txtXLocation.Text = table.XLocation.ToString();
            txtYLocation.Text = table.YLocation.ToString();
            txtTableWidth.Text = table.Width.ToString();
            txtTableHeight.Text = table.Height.ToString();
            cmbShape.SelectedIndex = (int)table.Shape;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            if (txtTableName.Text.Length > 0) {
                //table.TableName = txtTableName.Text;
                table.DefaultName = txtTableName.Text;
            //    table.TableType = TableTypes.StaticTable;
                table.TableCovers = int.Parse(txtTableCovers.Text);
                table.XLocation = int.Parse(txtXLocation.Text);
                table.YLocation = int.Parse(txtYLocation.Text);
                table.Width = int.Parse(txtTableWidth.Text);
                table.Height = int.Parse(txtTableHeight.Text);
                table.Shape = (ButtonShapeTypes)cmbShape.SelectedIndex;
                if (await repoTable.Save(table) != null)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void txtTableName_KeyDown(object sender, KeyEventArgs e) {

        }

        private void btnCoversPlus_Click(object sender, EventArgs e) {
            txtTableCovers.IncrementValue();
        }

        private void btnCoversMinus_Click(object sender, EventArgs e) {
            txtTableCovers.IncrementValue();
        }

        private void btnXPlus_Click(object sender, EventArgs e) {
            int maxleft = salon.Width - table.Width;
            if ((txtXLocation.Value + txtXLocation.Increment) > maxleft)
                return;
            else
                txtXLocation.IncrementValue();
        }

        private void btnXMinus_Click(object sender, EventArgs e) {
            txtXLocation.DecrementValue();
        }

        private void btnYPlus_Click(object sender, EventArgs e) {
            int maxTop = salon.Height - table.Height;
            if ((txtYLocation.Value + txtYLocation.Increment) > maxTop)
                return;
            else
                txtYLocation.IncrementValue();
        }

        private void btnYMinus_Click(object sender, EventArgs e) {
            txtYLocation.DecrementValue();
        }

        private void btnHPlus_Click(object sender, EventArgs e) {
            int maxHeight = salon.Height - txtYLocation.Value;
            if ((txtTableHeight.Value + txtTableHeight.Increment) > maxHeight)
                return;
            else
                txtTableHeight.IncrementValue();
        }

        private void btnHMinus_Click(object sender, EventArgs e) {
            txtTableHeight.DecrementValue();
        }

        private void btnWPlus_Click(object sender, EventArgs e) {
            int maxWidth = salon.Width - txtXLocation.Value;
            if ((txtTableWidth.Value + txtTableWidth.Increment) > maxWidth)
                return;
            else
                txtTableWidth.IncrementValue();
        }

        private void btnWMInus_Click(object sender, EventArgs e) {
            txtTableWidth.DecrementValue();
        }
    }
}
