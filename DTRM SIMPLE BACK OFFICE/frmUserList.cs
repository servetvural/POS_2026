using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMSimpleBackOffice {
    public partial class frmUserList : Form
    {
        IRepository<User> repoUser;

        private BindingSource _userSource = new BindingSource();
        public frmUserList()
        {
            InitializeComponent();
        }
        public frmUserList(IRepository<User> _repoUser)
        {
            InitializeComponent();
            repoUser = _repoUser;
        }
        private async void frmUserEditor_Load(object sender, EventArgs e)
        {
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            _userSource.DataSource = await repoUser.GetAllAsync();
            dgv.DataSource = _userSource;
        }
        private async void btnAddUser_Click(object sender, System.EventArgs e)
        {
            frmUser frm = ActivatorUtilities.CreateInstance<frmUser>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
                await LoadUsers();
        }
        private async void btnEditUser_Click(object sender, System.EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                frmUser frm = ActivatorUtilities.CreateInstance<frmUser>(ServiceHelper.Services, (User)dgv.SelectedRows[0].DataBoundItem);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadUsers();
            }
        }
        private async void btnDeleteUser_Click(object sender, System.EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoUser.Delete(((User)dgv.SelectedRows[0].DataBoundItem).IID);
                await LoadUsers();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditUser_Click(null, null);
        }

        private async void tsSort_Click(object sender, EventArgs e)
        {
            await repoUser.Sort();
            await LoadUsers();
        }

        private async void tsMoveUp_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoUser.MoveUp((User)dgv.SelectedRows[0].DataBoundItem);
                await LoadUsers();
            }
        }
        private async void tsMoveDown_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                await repoUser.MoveDown((User)dgv.SelectedRows[0].DataBoundItem);
                await LoadUsers();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
