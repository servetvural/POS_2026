using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace BSLayer.Forms
{
    public partial class frmLog : Form
    {
        IRepository<LogItem> repoLogItem;

        private BindingSource _logSource = new BindingSource();

        public frmLog()
        {
            InitializeComponent();
        }

        private async void frmLog_Load(object sender, EventArgs e)
        {
            await LoadLogs();
        }

        private async Task LoadLogs()
        {
            _logSource.DataSource = await repoLogItem.GetAllAsync();
            dgvLog.DataSource = _logSource;
            await ProcessData();
        }

        async Task ProcessData()
        {
            List<LogItem> logItems = await repoLogItem.GetAllAsync();
            lblStatus.Text = _logSource.Count.ToString() + " Delete, Total of = " + logItems.Sum(x => x.Total).ToString("c2");
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadLogs();
        }

        private async void btnClearAll_Click(object sender, EventArgs e)
        {
            if (dgvLog.Rows.Count > 0)
            {
                if (MessageBox.Show("Delete ALL Log Entries ??") == DialogResult.OK)
                {
                    await repoLogItem.DeleteAll();
                    await LoadLogs();
                }
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                btnDeleteSelected.Enabled = true;
            }
        }

        private async void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Delete Selected Log Entries ??") == DialogResult.OK)
                {
                    List<LogItem> logItems = dgvLog.SelectedRows.Cast<DataGridViewRow>()
                             .Select(row => row.DataBoundItem as LogItem)
                             .Where(item => item != null)
                             .ToList();
                    await repoLogItem.DeleteRange(logItems);
                    await LoadLogs();
                }
            }
        }

        private void btnViewLogEntry_Click(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                LogItem log = dgvLog.SelectedRows[0].DataBoundItem as LogItem;
                frmTextViewer frm = new frmTextViewer(log.OrderContent + log.ToSimpleString());
                frm.ShowDialog();

            }
        }
    }
}
