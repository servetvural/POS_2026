using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace POSOffice
{
    public partial class frmSalon : Form
    {

        IRepository<Salon> repoSalon;

        public Salon salon;
        public frmSalon()
        {
            InitializeComponent();
        }
        public frmSalon(Salon salon)
        {
            InitializeComponent();
            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();

            this.salon = salon;
        }
        private void frmTableGroup_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }

        private void LoadGroup()
        {
            txtGroupName.Text = salon.SalonName;
            btnSalonColor.BackColor = Color.FromArgb(salon.SalonColour);
            txtGroupWidth.Text = salon.Width.ToString();
            txtGroupHeight.Text = salon.Height.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Length > 0)
            {
                salon.SalonName = txtGroupName.Text;
                salon.SalonColour = btnSalonColor.BackColor.ToArgb();
                salon.Width = int.Parse(txtGroupWidth.Text);
                salon.Height = int.Parse(txtGroupHeight.Text);
                if (await repoSalon.Save(salon) != null)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnWidthPlus_Click(object sender, EventArgs e)
        {
            txtGroupWidth.Text += txtGroupWidth.Increment;
        }

        private void btnWidthMinus_Click(object sender, EventArgs e)
        {
            txtGroupWidth.DecrementValue();
        }

        private void btnHeightPlus_Click(object sender, EventArgs e)
        {
            txtGroupHeight.IncrementValue();
        }

        private void btnHeightMinus_Click(object sender, EventArgs e)
        {
            txtGroupHeight.DecrementValue();
        }

        private void btnSalonColor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ColorDialog cdlg = new ColorDialog
            {
                Color = btn.BackColor
            };
            cdlg.ShowDialog();
            btn.BackColor = cdlg.Color;

            salon.SalonColour = btnSalonColor.BackColor.ToArgb();
        }
    }
}
