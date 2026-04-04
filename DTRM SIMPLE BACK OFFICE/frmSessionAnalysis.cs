using System;
using System.Data;
using System.Windows.Forms;

using DTRMNS;

using PosLibrary;

using POSLayer.Library;
using POSLayer.Models;

using Microsoft.Extensions.DependencyInjection;

namespace DTRMSimpleBackOffice
{
    public partial class frmSessionAnalysis : Form
    {
        public frmSessionAnalysis()
        {
            InitializeComponent();
        }

        private void frmSessionAnalysis_Load(object sender, EventArgs e)
        {
            LoadDBSessions();
            LoadSuppliers();
        }

        private void LoadDBSessions()
        {
            if (InvokeRequired)
                Invoke(new DelegateNoParameter(LoadDBSessions), null);
            else
            {
                dgvOrders.DataSource = null;
                dgvOrderItems.DataSource = null;
                dgvDatabase.DataSource = DTRMSimpleBusiness.Instance.GetDataTable("Select IID, StartDate, EndDate, GrossSessionTotal from SessionSum order by StartDate desc");
            }
        }
        private string GetSelectedSessionIIDListSQL()
        {
            string sessionList = "(";
            if (dgvDatabase.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvDatabase.SelectedRows.Count; i++)
                {
                    sessionList += "'" + dgvDatabase.SelectedRows[i].Cells[0].Value.ToString() + "'";
                    if (i < dgvDatabase.SelectedRows.Count - 1)
                        sessionList += ",";
                }
                sessionList += ")";
            } else
                sessionList += ")";
            return sessionList;
        }

        private void LoadOrders()
        {
            if (dgvDatabase.SelectedRows.Count > 0)
            {
                //IID, OrderDate, CalculatedValue
                dgvOrders.DataSource = DTRMSimpleBusiness.Instance.GetDataTable("Select IID, OrderDate, CalculatedValue from OrdersView where SessionIID in " + GetSelectedSessionIIDListSQL() + " order by OrderDate asc");
                dgvOrders_SelectionChanged(null, null);

                dgvXOrders.DataSource = DTRMSimpleBusiness.Instance.GetDataTable("Select * from XOrdersView where SessionIID  in " + GetSelectedSessionIIDListSQL() + " order by OrderDate asc");
            } else
            {
                dgvOrders.DataSource = null;
                dgvXOrders.DataSource = null;
            }
        }

        private string GetSelectedOrderIIDListSQL()
        {
            string orderList = "(";
            if (dgvOrders.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvOrders.SelectedRows.Count; i++)
                {
                    orderList += "'" + dgvOrders.SelectedRows[i].Cells[0].Value.ToString() + "'";
                    if (i < dgvOrders.SelectedRows.Count - 1)
                        orderList += ",";
                }
                orderList += ")";
            } else
                orderList += ")";
            return orderList;
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DisplaySelectedOrderTotal();
                if (chkShowOrderitemandStockUsage.Checked)
                {
                    LoadOrderItemsAndStockUsage();
                }
            }
        }

        private void DisplaySelectedOrderTotal()
        {
            float total = 0.0f;
            for (int i = 0; i < dgvOrders.SelectedRows.Count; i++)
            {
                string value = dgvOrders.SelectedRows[i].Cells["colOrderSum"].Value.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    total += float.Parse(value);
                }
            }
            lblOrderTotal.Text = "Order Total : " + total.ToString("n2");
        }

        private void LoadOrderItemsAndStockUsage()
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                string OrderIIDList = GetSelectedOrderIIDListSQL();
                dgvOrderItems.DataSource = GetOrderItemsForSelectedOrders(OrderIIDList);


                DataTable dt = GetStockUsageForSelectedOrders(OrderIIDList);
                dt = UF.StringifyEnumInDataTable(dt, "OrderableType", "OrderableTypeAsString", typeof(QuantityTypes));
                dt = UF.StringifyEnumInDataTable(dt, "QuantityType", "QuantityTypeAsString", typeof(QuantityTypes));
                dgvStockItems.DataSource = dt;
            }
        }

        private DataTable GetOrderItemsForSelectedOrders(string orderIIDList)
        {
            return DTRMSimpleBusiness.Instance.GetDataTable("Select Sum(Quantity) as Quantity, OrderItemText, Sum(Quantity * Price) as Total,Price, EntityButtonIID from OrderItem where ParentOrderIID in " +
                    orderIIDList + " group by OrderItemText,Price, EntityButtonIID Order by OrderItemText");
        }

        private DataTable GetStockUsageForSelectedOrders(string orderIIDList)
        {
            return DTRMSimpleBusiness.Instance.GetDataTable("SELECT StockItem.IID as StockItemIID,StockItem.StockName,  SUM(OrderItem.Quantity * EntityButtonStockItemLookUp.Quantity) AS SessionQuantity, StockItem.QuantityType, " +
                "StockItem.Conversion, SUM(OrderItem.Quantity * EntityButtonStockItemLookUp.Quantity / StockItem.Conversion) AS OrderableFloatQuantity, " +
                "floor(SUM(OrderItem.Quantity * EntityButtonStockItemLookUp.Quantity / StockItem.Conversion))  as OrderableQuantity, " +
                "StockItem.OrderType as OrderableType, Supplier.IID as SupplierIID, Supplier.SupplierName " +
                "FROM OrderItem INNER JOIN EntityButtonStockItemLookUp ON OrderItem.EntityButtonIID = EntityButtonStockItemLookUp.EntityButtonIID INNER JOIN " +
                "StockItem ON EntityButtonStockItemLookUp.StockItemIID = StockItem.IID INNER JOIN Supplier ON StockItem.SupplierIID = Supplier.IID " +
                "WHERE(OrderItem.ParentOrderIID IN " + orderIIDList + ") " + GetSupplierSql() +
                " GROUP BY StockItem.IID, StockItem.StockName, StockItem.OrderType, StockItem.Conversion, Supplier.IID, Supplier.SupplierName, StockItem.QuantityType " +
                GetOrderableOnlySql() +
                " ORDER BY StockName asc");
        }

        private string GetSupplierSql()
        {
            if (rbSingleSupplier.Checked && cmbSuppliers.SelectedIndex >= 0)
            {
                Supplier selectedSupplier = (Supplier)cmbSuppliers.SelectedItem;
                return " AND SupplierIID = '" + selectedSupplier.IID + "'";
            } else
                return "";
        }
        private string GetOrderableOnlySql()
        {
            if (chkOrderableOnly.Checked)
            {
                return "  having SUM(OrderItem.Quantity * EntityButtonStockItemLookUp.Quantity / StockItem.Conversion) >= 1 ";
            } else
                return "";
        }


        //private string GetSelectedEntityButtonIIDListForOrderItemsSQL() {
        //    string entityButtonIIDList = "(";
        //    if (dgvOrderItems.SelectedRows.Count > 0) {
        //        for (int i = 0; i < dgvOrderItems.SelectedRows.Count; i++) {
        //            entityButtonIIDList += "'" + dgvOrderItems.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString() + "'";
        //            if (i < dgvOrderItems.SelectedRows.Count - 1)
        //                entityButtonIIDList += ",";
        //        }
        //        entityButtonIIDList += ")";
        //    } else
        //        entityButtonIIDList += ")";
        //    return entityButtonIIDList;
        //}


        //private void PopulateRowsForUsageTypes() {
        //    for (int i = 0; i < dgvStockItems.Rows.Count; i++) {
        //        dgvStockItems.Rows[i].Cells["colUsedQuantityTypeLabel"].Value = (QuantityTypes)(int.Parse(dgvStockItems.Rows[i].Cells["colUsedQuantityType"].Value.ToString()));
        //        dgvStockItems.Rows[i].Cells["colOrderableQuantityTypeLabel"].Value = (QuantityTypes)(int.Parse(dgvStockItems.Rows[i].Cells["colOrderableQuantityType"].Value.ToString()));
        //    }
        //}

        private void dgvDatabase_SelectionChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDBSessions();
        }

        private void btnShowOrderItemsAndStockUsage_Click(object sender, EventArgs e)
        {
            LoadOrderItemsAndStockUsage();
        }

        private void dgvStockItems_Sorted(object sender, EventArgs e)
        {
        }

        private void btnSelectAllOrders_Click(object sender, EventArgs e)
        {
            dgvOrders.SelectAll();
        }

        private void dgvOrderItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count > 0)
                DisplayOrderItemTotal();
        }
        private void DisplayOrderItemTotal()
        {
            float total = 0.0f;
            for (int i = 0; i < dgvOrderItems.SelectedRows.Count; i++)
            {
                total += float.Parse(dgvOrderItems.SelectedRows[i].Cells["colOrderItemTotal"].Value.ToString());
            }
            lblOrderItemTotal.Text = "Item Total : " + total.ToString("n2");
        }

        private void LoadSuppliers()
        {
            cmbSuppliers.ComboBox.DisplayMember = "SupplierName";
            cmbSuppliers.Items.AddRange(DTRMSimpleBusiness.Instance.GetAllSuppliersAsList().Result.ToArray());
        }

        private void btnReloadStockItems_Click(object sender, EventArgs e)
        {
            LoadOrderItemsAndStockUsage();
        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderItemsAndStockUsage();
        }

        private void btnPrintStockItems_Click(object sender, EventArgs e)
        {
            if (dgvStockItems.Rows.Count > 0)
            {
                frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                if (fsp.ShowDialog() == DialogResult.OK)
                {
                    DTRMSimpleBusiness.Instance.PrintDataTable(fsp.SelectedPrinter, DRUF.GetDataTableFromGridVisible(dgvStockItems, true, true),
                            "Stock Usage Report", DTRMSimpleBusiness.Instance.GetColumnPrintRatio(dgvStockItems), true);
                }
            }
        }

        private void btnOrderItemPrint_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count > 0)
            {
                frmAppPrinterDialog fsp = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services);
                if (fsp.ShowDialog() == DialogResult.OK)
                {
                    DTRMSimpleBusiness.Instance.PrintDataTable(fsp.SelectedPrinter, DRUF.GetDataTableFromGridVisible(dgvOrderItems, true, true),
                            "Order Item List", DTRMSimpleBusiness.Instance.GetColumnPrintRatio(dgvOrderItems), true);
                }
            }
        }

        private void chkShowOrderitemandStockUsage_CheckedChanged(object sender, EventArgs e)
        {
            chkShowOrderitemandStockUsage.Image = chkShowOrderitemandStockUsage.Checked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
        }

        private void chkOrderableOnly_CheckedChanged(object sender, EventArgs e)
        {
            dgvStockItems.Columns["colOrderableIntQuantity"].Visible = chkOrderableOnly.Checked;
            dgvStockItems.Columns["colOrderableFloatQuantity"].Visible = !chkOrderableOnly.Checked;

            LoadOrderItemsAndStockUsage();
            if (chkOrderableOnly.Checked)
                chkOrderableOnly.Image = Properties.Resources.Checked;
            else
                chkOrderableOnly.Image = Properties.Resources.Unchecked;
        }

        private void chkReportFormat_CheckedChanged(object sender, EventArgs e)
        {
            dgvStockItems.Columns["colUsedQuantity"].Visible =
                dgvStockItems.Columns["colUsedQuantityTypeLabel"].Visible =
          dgvStockItems.Columns["colConversion"].Visible = !chkReportFormat.Checked;
            if (chkReportFormat.Checked)
            {
                chkReportFormat.Image = Properties.Resources.Checked;
            } else
                chkReportFormat.Image = Properties.Resources.Unchecked;
        }

        private void rbSingleSupplier_CheckedChanged(object sender, EventArgs e)
        {
            cmbSuppliers.Visible = rbSingleSupplier.Checked;
            tsStockItems.Refresh();
            if (cmbSuppliers.SelectedIndex >= 0)
                LoadOrderItemsAndStockUsage();
            rbAllSuppliers.Checked = !rbSingleSupplier.Checked;
        }

        private void rbAllSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            rbSingleSupplier.Checked = !rbAllSuppliers.Checked;
        }

        private void DisplayXOrderTotals()
        {
            float total = 0.0f;
            float vat = 0.0f;
            float totalnovat = 0.0f;
            float sctotal = 0.0f;
            float sctaxtotal = 0.0f;

            for (int i = 0; i < dgvXOrders.Rows.Count; i++)
            {
                total += float.Parse(dgvXOrders.Rows[i].Cells["colXOrderCalculatedValue"].Value.ToString());
                vat += float.Parse(dgvXOrders.Rows[i].Cells["colXOrderCalculatedVat"].Value.ToString());
                totalnovat += float.Parse(dgvXOrders.Rows[i].Cells["colXOrderCalculatedExVatValue"].Value.ToString());
                sctotal += float.Parse(dgvXOrders.Rows[i].Cells["colXOrderServiceCharge"].Value.ToString());
                sctaxtotal += float.Parse(dgvXOrders.Rows[i].Cells["colXOrderServiceChargeTax"].Value.ToString());
            }
            if (dgvXOrders.Rows.Count > 0)
                lblXOrderTotals.Text = "Total : " + total.ToString("c2") +
                    "    TaxTotal : " + vat.ToString("c2") +
                    "    TotalNoTax : " + totalnovat.ToString("c2") +
                    "    Service Charge : " + sctotal.ToString("c2") +
                    "    Service Charge Tax : " + sctaxtotal.ToString("c2");
            else
                lblXOrderTotals.Text = "0.00";
        }

        private void dgvXOrders_DataSourceChanged(object sender, EventArgs e)
        {
            DisplayXOrderTotals();
        }
    }
}
