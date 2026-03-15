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

namespace DTRMNS.Forms
{
    public partial class frmLog : Form
    {
        private DTRMSimpleBusiness bslayer;

        private DataTable dt;
        public frmLog(DTRMSimpleBusiness bslayer)
        {
            InitializeComponent();
            this.bslayer = bslayer;
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            dgvLog.DataSource = null;
            dt = bslayer.GetAllLogItems();  
            ProcessData();
            dgvLog.DataSource = dt;
           
        }

        void ProcessData()
        {
            float total = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += float.Parse(dt.Rows[i]["Total"].ToString());
            }

            lblStatus.Text = dt.Rows.Count.ToString() + " Delete, Total of = " + total.ToString("c2");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (dgvLog.Rows.Count > 0)
            {
                if (MessageBox.Show("Delete ALL Log Entries ??") == DialogResult.OK)
                {
                    bslayer.DeleteAllLogItems();
                    LoadLogs();
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

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Delete Selected Log Entries ??") == DialogResult.OK)
                {
                    List<string> IIDList = new List<string>();
                    for (int i = 0; i < dgvLog.SelectedRows.Count; i++)
                    {
                        IIDList.Add(dgvLog.SelectedRows[i].Cells["IID"].Value.ToString());
                    }
                    bslayer.DeleteLogItems(IIDList);
                    LoadLogs();
                }
            }
        }

        private void btnViewLogEntry_Click(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                LogItem log = new LogItem()
                {
                    IID = dgvLog.SelectedRows[0].Cells["IID"].Value.ToString(),
                   OrderItemText= dgvLog.SelectedRows[0].Cells["OrderItemText"].Value.ToString(),
                   Quantity = double.Parse( dgvLog.SelectedRows[0].Cells["Quantity"].Value.ToString()),
                   Price =double.Parse( dgvLog.SelectedRows[0].Cells["Price"].Value.ToString()),
                   Reason = dgvLog.SelectedRows[0].Cells["Reason"].Value.ToString(),
                   EventDateTime =DateTime.Parse(  dgvLog.SelectedRows[0].Cells["EventDateTime"].Value.ToString()),
                  ComputerName=  dgvLog.SelectedRows[0].Cells["ComputerName"].Value.ToString(),
                   OrderContent = dgvLog.SelectedRows[0].Cells["OrderContent"].Value.ToString(),
                  Reference =  dgvLog.SelectedRows[0].Cells["Reference"].Value.ToString()
            };

                //string OrderContent = dgvLog.SelectedRows[0].Cells["OrderContent"].Value.ToString();

                frmTextViewer frm = new frmTextViewer(log.OrderContent + log.ToSimpleString());
                frm.ShowDialog();
                
            }
        }
    }
}
