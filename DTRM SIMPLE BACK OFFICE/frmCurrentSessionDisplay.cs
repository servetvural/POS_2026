using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using PosLibrary;
using DTRMNS;

using POSLayer.Library;
using System.Threading.Tasks;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace DTRMSimpleBackOffice {
    public partial class frmCurrentSessionDisplay : Form {
        IRepository<Session> repoSession;    

        private bool blnLoading;
        private Session CurrentSessionData;
        private double oldGrossSessionTotal;
        private double oldGrossSessionTotalUncompleted;

        private int seconds;

        public frmCurrentSessionDisplay() {
            InitializeComponent();
        }
        public frmCurrentSessionDisplay(IRepository<Session> _repoSession) {
            InitializeComponent();
            repoSession = _repoSession;
        }
        private void frmCurrentSessionDisplay_Load(object sender, EventArgs e) {
            
            //cmbInterval.SelectedIndex = 0;

        }

        private void LoadValues() {
            if (blnLoading)
                return;

            blnLoading = true;
            //Do loading here
            UpdateSessionLabels();

            LoadOrders();

            blnLoading = false;
        }

        private void SoundNotify() {
            if (cmdNotifyWithSound.Checked)
                SystemSounds.Hand.Play();
        }

        private void LoadOrders() {
            //IID, OrderDate, CalculatedValue
            dgvOrderItems.DataSource = null;
            dgvOrders.DataSource = DTRMSimpleBusiness.Instance.GetDataTable("Select IID, OrderDate, CalculatedValue from OrdersView where SessionIID = '" + 
                CurrentSessionData.IID + "' order by OrderDate desc");
            //dgvOrders_SelectionChanged(null, null);
        }

        private void btnGetSales_Click(object sender, EventArgs e) {
            LoadValues();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e) {
            if (dgvOrders.SelectedRows.Count > 0 ) {
                string OrderIID = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
                dgvOrderItems.DataSource = GetOrderItemsForOrderCustom(OrderIID);
            }
        }

        private DataTable GetOrderItemsForOrderCustom(string OrderIID) {
            return DTRMSimpleBusiness.Instance.GetDataTable("Select IID,Quantity, OrderItemText,Price, Total from OrderItemView where ParentOrderIID = '" + OrderIID + "' order by DisplayOrder, OrderGroupIID");
        }


        private async void UpdateSessionLabels() {
            //Update session values dynamically
            CurrentSessionData = await repoSession.Get(DTRMSimpleBusiness.Instance.shop.CurrentSessionIID);
            int changeCount = 0;
            
            if (CurrentSessionData != null) {
                if (CurrentSessionData.GrossSessionTotal != oldGrossSessionTotal ||
                    CurrentSessionData.GrossSessionTotalUncompleted != oldGrossSessionTotalUncompleted )
                {
                    lblSessionStartDateTime.Text = CurrentSessionData.StartDate.ToString("dd/MMM/yy ddd HH:mm");
                    double grossSessionTotal = CurrentSessionData.GrossSessionTotal;
                    if (grossSessionTotal != oldGrossSessionTotal)
                    {
                        oldGrossSessionTotal = grossSessionTotal;
                        changeCount++;                        
                    }
                    lblGrossTotal.Text = grossSessionTotal.ToString("c2");
                    double grossSessionTotalUncompleted = CurrentSessionData.GrossSessionTotalUncompleted;
                    if (grossSessionTotalUncompleted != oldGrossSessionTotalUncompleted)
                    {
                        oldGrossSessionTotalUncompleted = grossSessionTotalUncompleted;
                        changeCount++;
                    }
                    lblUnpaidTotal.Text = grossSessionTotalUncompleted.ToString("c2");
                    lblX1Total.Text = CurrentSessionData.X1Total.ToString("c2");
                    lblX2Total.Text = CurrentSessionData.X2Total.ToString("c2");
                    lblX3Total.Text = CurrentSessionData.X3Total.ToString("c2");

                    

                    if (changeCount > 0)
                        SoundNotify();
                }
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e) {
             frmAppPrinterDialog fsp =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
             if (fsp.ShowDialog() == DialogResult.OK) {
                DTRMSimpleBusiness.Instance.PrintReport(ReportFormatTypes.YReport, DTRMSimpleBusiness.Instance.shop.CurrentSessionIID, fsp.SelectedPrinterIID, true);
             }
        }

        private async void btnPrintReceipt_Click(object sender, EventArgs e) {
            if (dgvOrders.SelectedRows.Count > 0) {
                string OrderIID = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
                Order order = await DTRMSimpleBusiness.Instance.GetOrder(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                frmAppPrinterDialog frm =  ActivatorUtilities.CreateInstance < frmAppPrinterDialog >(ServiceHelper.Services);
                if (frm.ShowDialog()== System.Windows.Forms.DialogResult.OK) {
                    DTRMSimpleBusiness.Instance.PrintReceipt(OrderIID, frm.SelectedPrinter, 1);
                }
            }
        }

        private async void btnViewReceipt_Click(object sender, EventArgs e) {
            if (dgvOrders.SelectedRows.Count > 0) {
                string OrderIID = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
                Order order = await DTRMSimpleBusiness.Instance.GetOrder(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                Printer printer = await DTRMSimpleBusiness.Instance.GetDefaultReceiptPrinter();
                if (printer == null) {
                    MessageBox.Show("No printer attached!!");
                    return;
                }
                Bitmap bmp = new Bitmap(300, 1500);
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                Graphics g = Graphics.FromImage(img);
                g.Clear(Color.White);

                int imgHeight = DTRMSimpleBusiness.Instance.ViewReceipt(g, OrderIID, printer, 1);
                Image imgFinal = DRUF.cropImage(img, new Rectangle(0, 0, 300, imgHeight));

                frmViewImage frm = new frmViewImage(imgFinal);
                frm.Show();

            }
        }

        
        private void tmrSeconds_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                if (pBar2.Value == pBar2.Maximum)
                {
                    pBar2.Value = 0;
                  //  SoundNotify();
                    LoadValues();
                    if (!pnlBonus.EnableAutoUpdate)
                        pnlBonus.UpdateBonusDisplay();

                } else
                {
                    pBar2.Value++;
                    pBar2.Text = pBar2.Value.ToString();
                }
            }
        }

        private void cmdInterval_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ToolStripItem tsi = e.ClickedItem;
            seconds = int.Parse(tsi.Tag.ToString());
            if (seconds == 0) {
                tmrSeconds.Enabled = false;
                pBar2.Value = 0;
            }
            else {
                tmrSeconds.Enabled = true;
                pnlBonus.Activate();
                LoadValues();
                if (!pnlBonus.EnableAutoUpdate)
                    pnlBonus.UpdateBonusDisplay();
                pBar2.Maximum = seconds / 1000;
                pBar2.Value = 0;
            }
        }
    }
}
