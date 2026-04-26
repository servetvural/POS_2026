using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Media;  
using WinLayer;
using POSLayer.Library;
using System.Threading.Tasks;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;
using System.Formats.Asn1;
using System.Collections.Generic;

namespace WinOffice {
    public partial class frmCurrentSessionDisplay : Form
    {
        IRepository<Session> repoSession;
        IRepository<Order> repoOrder;

        private bool blnLoading;
        private Session CurrentSessionData;
        private double oldGrossSessionTotal;
        private double oldGrossSessionTotalUncompleted;

        private int seconds;

        private BindingSource _orderSource = new BindingSource();
        private BindingSource _orderItemSource = new BindingSource();
        private BindingSource _stockUsageSource = new BindingSource();
        private BindingSource _orderItemSummarySource = new BindingSource();
        public frmCurrentSessionDisplay()
        {
            InitializeComponent();
            repoSession = ServiceHelper.GetService<IRepository<Session>>();
            repoOrder = ServiceHelper.GetService<IRepository<Order>>();
        }
        private void frmCurrentSessionDisplay_Load(object sender, EventArgs e)
        {


        }

        private async Task LoadValues()
        {
            if (blnLoading)
                return;

            blnLoading = true;
            //Do loading here
            await UpdateSessionLabels();

            await LoadOrders();

            blnLoading = false;
        }

        private void SoundNotify()
        {
            if (cmdNotifyWithSound.Checked)
                SystemSounds.Hand.Play();
        }

        private async Task LoadOrders()
        {
            BindingList<Order> orders = CurrentSessionData.Orders.ToBindingList(); //new BindingList<Order>(await repoOrder.GetListByField("SessionIID",CurrentSessionData.IID,"Items"));  

            dgvOrders.AutoGenerateColumns = false;
            dgvOrderItems.AutoGenerateColumns = false;

            _orderSource.DataSource = orders;
            _orderSource.Sort = "OrderDate DESC";
            dgvOrders.DataSource = _orderSource;
            _orderItemSource.DataSource = _orderSource;

            _orderItemSource.DataMember = "Items";
            _orderItemSource.Sort = "DOrder DESC";
            dgvOrderItems.DataSource = _orderItemSource;

            List<RecipeUsage> stockUsage = await repoOrder.GetSessionRecipeUsage(BSLayer.Instance.shop.CurrentSessionIID);
            _stockUsageSource.DataSource = stockUsage;
            dgvStockUsage.DataSource = _stockUsageSource;

            List<OrderItemSummary> orderItemSummary = await repoOrder.GetSessionOrderItemSummary(BSLayer.Instance.shop.CurrentSessionIID);
            _orderItemSummarySource.DataSource = orderItemSummary;
            dgvOrderItemSummary.DataSource = _orderItemSummarySource;
        }

        private async void btnGetSales_Click(object sender, EventArgs e)
        {
            await LoadValues();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {

        }

        private DataTable GetOrderItemsForOrderCustom(string OrderIID)
        {
            return BSLayer.Instance.GetDataTable("Select IID,Quantity, OrderItemText,Price, Total from OrderItemView where ParentOrderIID = '" + OrderIID + "' order by DisplayOrder, OrderGroupIID");
        }


        private async Task UpdateSessionLabels()
        {
            //Update session values dynamically
            CurrentSessionData = await repoSession.Get(BSLayer.Instance.shop.CurrentSessionIID, "Orders, Orders.Items");
            int changeCount = 0;

            if (CurrentSessionData != null)
            {
                //if (CurrentSessionData.GrossSessionTotal != oldGrossSessionTotal ||
                //    CurrentSessionData.GrossSessionTotalUncompleted != oldGrossSessionTotalUncompleted )
                //{
                lblSessionStartDateTime.Text = CurrentSessionData.StartDate.ToString("dd/MMM/yy ddd HH:mm");
                double grossSessionTotal = CurrentSessionData.GrossSessionTotalDynamic;
                //if (grossSessionTotal != oldGrossSessionTotal)
                //{
                //    oldGrossSessionTotal = grossSessionTotal;
                //    changeCount++;                        
                //}
                lblGrossTotal.Text = grossSessionTotal.ToString("c2");
                //double grossSessionTotalUncompleted = CurrentSessionData.GrossSessionTotalUncompleted;
                //if (grossSessionTotalUncompleted != oldGrossSessionTotalUncompleted)
                //{
                //    oldGrossSessionTotalUncompleted = grossSessionTotalUncompleted;
                //    changeCount++;
                //}
                lblUnpaidTotal.Text = CurrentSessionData.BalanceDynamic.ToString("c2");
                lblX1Total.Text = CurrentSessionData.X1Total.ToString("c2");
                lblX2Total.Text = CurrentSessionData.X2Total.ToString("c2");
                lblX3Total.Text = CurrentSessionData.X3Total.ToString("c2");



                if (changeCount > 0)
                    SoundNotify();
                //}
            }
        }

        private async void btnPrintReport_Click(object sender, EventArgs e)
        {
            frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
            if (fsp.ShowDialog() == DialogResult.OK)
            {
                await BSLayer.Instance.PrintReport(ReportFormatTypes.YReport, BSLayer.Instance.shop.CurrentSessionIID, fsp.SelectedPrinterIID, true);
            }
        }

        private async void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                string OrderIID = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
                Order order = await BSLayer.Instance.GetOrder(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                frmAppPrinterDialog frm = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BSLayer.Instance.PrintReceipt(order, frm.SelectedPrinter, 1);
                }
            }
        }

        private async void btnViewReceipt_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                string OrderIID = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
                Order order = await BSLayer.Instance.GetOrder(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                Printer printer = await BSLayer.Instance.GetDefaultReceiptPrinter();
                if (printer == null)
                {
                    MessageBox.Show("No printer attached!!");
                    return;
                }
                Bitmap bmp = new Bitmap(300, 1500);
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                Graphics g = Graphics.FromImage(img);
                g.Clear(Color.White);

                int imgHeight = BSLayer.Instance.ViewReceipt(g, order, printer, 1);
                Image imgFinal = UFWin.cropImage(img, new Rectangle(0, 0, 300, imgHeight));

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

        private void cmdInterval_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem tsi = e.ClickedItem;
            seconds = int.Parse(tsi.Tag.ToString());
            if (seconds == 0)
            {
                tmrSeconds.Enabled = false;
                pBar2.Value = 0;
            } else
            {
                tmrSeconds.Enabled = true;
                pnlBonus.Activate();
                LoadValues();
                if (!pnlBonus.EnableAutoUpdate)
                    pnlBonus.UpdateBonusDisplay();
                pBar2.Maximum = seconds / 1000;
                pBar2.Value = 0;
            }
        }

        private void dgvStockUsage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
