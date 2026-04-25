using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer {
    public partial class frmMenuSelector : Form {
        IRepository<TheMenu> repoMenu;

        public string SelectedMenuIID;
        public frmMenuSelector(IRepository<TheMenu> _repoMenu) {
            InitializeComponent();
            repoMenu = _repoMenu;
        }

        private async void frmMenuSelector_Load(object sender, EventArgs e) {
            await LoadMenuList();
        }

        private async Task LoadMenuList() {
            dgv.DataSource = await repoMenu.GetAllAsync();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) {
            SelectedMenuIID = (dgv.SelectedRows[0].DataBoundItem as TheMenu).IID; 
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
