using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using PosLibrary;

using POSLayer.Library;
using POSLayer.Models;
using System.Threading.Tasks;
using POSLayer.Repository.IRepository;


namespace DTRMNS
{
    public partial class ctlTables : UserControl
    {
        PosConfig config;
        IRepository<Masa> repoTable;

        private GenericFunctionCall CloseFunction;
        private GenericEventHandler ButtonClickHandler;
        private GenericEventHandler DirectButtonClickHandler;
        private bool blnChangeOrderType;
        private TableButton SourceTable;

        private GenericFunctionCall CloseOrderItemEntityInteractionEvent;

        public ctlTables()
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();             
            repoTable =ServiceHelper.GetService<IRepository<Masa>>();
        }

        public ctlTables(GenericFunctionCall CloseFunction,
            GenericEventHandler ButtonClickHandler, GenericEventHandler DirectButtonClickHandler)
        {
            InitializeComponent();
            this.CloseFunction = CloseFunction;
            this.ButtonClickHandler = ButtonClickHandler;
            this.DirectButtonClickHandler = DirectButtonClickHandler;
        }

        public ctlTables(GenericFunctionCall CloseFunction,
            GenericEventHandler ButtonClickHandler, bool blnChangeOrderType,
            GenericFunctionCall CloseOrderItemEntityInteraction)
        {
            InitializeComponent();
            this.CloseFunction = CloseFunction;
            this.ButtonClickHandler = ButtonClickHandler;
            this.blnChangeOrderType = blnChangeOrderType;
            this.CloseOrderItemEntityInteractionEvent = CloseOrderItemEntityInteraction;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseFunction();
        }

        private async void LoadTables()
        {
            List<Masa> tablelist = await repoTable.GetAllAsync();

            pnlTables.Controls.Clear();
            //pnlTables.BackColor = Color.AliceBlue;

            Masa table;
            string locker = "";
            for (int i = 0; i < tablelist.Count; i++)
            {
                table = tablelist[i];

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();

                btn.Text = table.TableName + (table.KitchenOrderNumber != "" ? "\n.. " + table.KitchenOrderNumber + " .." : "");
                btn.IID = table.IID;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (locker.Length > 0)
                {
                    btn.BackColor = Color.DarkBlue;
                    btn.ForeColor = Color.White;
                } else
                {
                    if (table.HasActiveOrder())
                    {
                        btn.BackColor = Color.DarkRed;
                        btn.ForeColor = Color.White;
                    } else
                    {
                        btn.BackColor = Color.DarkGreen;
                        btn.ForeColor = Color.White;

                        if (btn.Text != table.DefaultName)
                        {
                            table.TableName = table.DefaultName;
                             DTRMSimpleBusiness.Instance.SaveTable(table);
                            btn.Text = table.DefaultName;
                        }
                    }
                }
                btn.Location = new Point(table.XLocation, table.YLocation);
                btn.Size = new Size(table.Width, table.Height);
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += new System.EventHandler(this.btnQuickTableButton_Click);
                pnlTables.Controls.Add(btn);
                locker = "";
            }
        }

        private async void btnQuickTableButton_Click(object sender, EventArgs e)
        {
            if (chkChangeTable.Checked)
            {
                if (SourceTable == null)
                {
                    //Identify Source Table
                    SourceTable = sender as TableButton;

                    return;
                } else
                {
                    await DTRMSimpleBusiness.Instance.MoveTable(SourceTable.IID, ((TableButton)sender).IID);

                    chkChangeTable.Checked = false;
                    LoadTables();
                    return;
                }
            }
            
            if (chkPrintOrder.Checked)
            {
                if (!string.IsNullOrEmpty(config.DTClientLocalReceiptPrinterIID))
                {
                    TableButton tableButton = (TableButton)sender;
                    bool blnPrinted = false;

                    Masa table = await DTRMSimpleBusiness.Instance.BarrowTable(tableButton.IID);
                    if (table.AttachedOrder != null)
                    {
                        blnPrinted = await DTRMSimpleBusiness.Instance.PrintEntireOrder(table.AttachedOrder, true, false, 1,
                            config.DTClientLocalReceiptPrinterIID);
                    }

                    if (blnPrinted && config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(
                             DTRMSimpleBusiness.Instance.GetPrinterForClient(config.DTClientLocalReceiptPrinterIID).Result.NetworkName);
                }
            }

            if (blnChangeOrderType)
            {
                Masa table = await repoTable.Get((sender as TableButton).IID);
                if (table.Order != null)
                    MessageBox.Show("Table already has an order");
                else
                {
                    //Delete the incoming new order with the newly allocated table
                    await  DTRMSimpleBusiness.Instance.DeleteOrderOnly(table.AttachedOrder);
                    //Dispatch this order to this table
                    table.AttachedOrder =  DTRMSimpleBusiness.Instance.AttachedOrder;
                    await  DTRMSimpleBusiness.Instance.SaveTable(table);
                    //Dispatch newly allocated table to this order
                     DTRMSimpleBusiness.Instance.AttachedOrder.TableIID = table.IID;
                     DTRMSimpleBusiness.Instance.AttachedOrder.Status = StatusFlags.DONE;
                     DTRMSimpleBusiness.Instance.AttachedOrder.Title = "T " + table.TableName + " C " + table.TableCovers.ToString();
                    HandlePriceChange(OrderTypes.InHouse);
                     DTRMSimpleBusiness.Instance.OnDisplayOrder();
                }
                return;
            }
            if (chkUnlockTable.Checked)
            {
                UnlockTable(((TableButton)sender).IID);
                chkUnlockTable.Checked = false;
                LoadTables();
            } else if (chkRenameTable.Checked)
            {
                RenameTable(((TableButton)sender).IID);
                chkRenameTable.Checked = false;
                LoadTables();
            } else if (chkSplitTable.Checked)
            {
                SourceTable = (TableButton)sender;

                Masa STable = await repoTable.Get(SourceTable.IID);
                if (STable.Order == null)
                {

                    //No Order on this table to split so abort process
                    chkSplitTable.Checked = false;
                    return;
                } else
                {
                    //Now properly barrowtable for system lock, so no one can do any operation on it
                    STable = await  DTRMSimpleBusiness.Instance.BarrowTable(SourceTable.IID);
                    frmTableSplitter frm = new frmTableSplitter( STable);
                    frm.ShowDialog();

                     DTRMSimpleBusiness.Instance.ReturnTable(STable);
                }
                chkSplitTable.Checked = false;
                LoadTables();
            } else
            {
                ButtonClickHandler(sender, e);
                //CloseFunction();
            }
        }


        private void HandlePriceChange(POSLayer.Library.OrderTypes RequestedType)
        {
            //switch (DTRMSimpleBusiness.MessageBoxDT("Do you want all item prices to be changed ?", "CHANGE PRICES", DialogTypes.YesNoCancel)) {
            //   case DialogResult.Yes:
            //Close tabpages to ensure the last open top order item having completed effect
            //MainForm.CloseOrderItemEntityInteraction();
            CloseOrderItemEntityInteractionEvent();

            //Do recalculation
             DTRMSimpleBusiness.Instance.RePriceOrderForOrderType( DTRMSimpleBusiness.Instance.AttachedOrder, RequestedType);
             DTRMSimpleBusiness.Instance.ReTaxOrderForOrderType( DTRMSimpleBusiness.Instance.AttachedOrder, RequestedType);
             DTRMSimpleBusiness.Instance.AttachedOrder.OrderType = RequestedType;
            CloseFunction();

        }

        private void ctlTables_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private async void UnlockTable(string TableIID)
        {
            DialogResult whattodo = MessageBox.Show(this, "You are about to unlock the table.\n" +
               "If any orderpad is amending this table or its order, its changes will not be updated!\n" +
               "Are you sure you want to continue ?",
               "TABLE UNLOCK WARNING", MessageBoxButtons.YesNo);
            switch (whattodo)
            {
                case DialogResult.Yes:
                    Masa table = await  DTRMSimpleBusiness.Instance.GetTable(TableIID);
                    if (table != null)
                    {
                        table.LockedClientIP = "";
                         DTRMSimpleBusiness.Instance.SaveTable(table);
                    }
                    this.LoadTables();
                    break;
                case DialogResult.No:
                    return;
                default:
                    break;
            }
        }

        private void chkUnlockTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnlockTable.Checked)
                chkUnlockTable.BackColor = Color.Yellow;
            else
                chkUnlockTable.BackColor = Color.ForestGreen;
        }

        private void chkChangeTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeTable.Checked)
            {
                chkChangeTable.BackColor = Color.Yellow;
                SourceTable = null;
            } else
                chkChangeTable.BackColor = Color.Gold;
        }

        private void LoadGroups()
        {
            pnlGroups.Controls.Clear();

            DataTable dt =  DTRMSimpleBusiness.Instance.GetAllTableGroups();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RadioButton btn = new RadioButton();
                btn.Appearance = Appearance.Button;
                btn.CheckedChanged += new EventHandler(GroupButton_CheckedChanged);
                btn.BackColor = Color.Green;
                //btn.BackgroundImage = Properties.Resources.shadow;
                //btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.MinimumSize = new Size(90, 50);
                btn.AutoSize = true;
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.Text = dt.Rows[i]["GroupName"].ToString();
                btn.Tag = dt.Rows[i]["IID"].ToString();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.Yellow;

                pnlGroups.Controls.Add(btn);
                btn.Dock = DockStyle.Top;
            }
            bool chk = false;
            for (int i = 0; i < pnlGroups.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)pnlGroups.Controls[i];
                if (rb.Checked)
                {
                    chk = true;
                    break;
                }
            }
            if (!chk && pnlGroups.Controls.Count > 0)
                ((RadioButton)pnlGroups.Controls[0]).Checked = true;
        }

        private void GroupButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                rb.FlatAppearance.BorderSize = 1;
                LoadTables();
            } else
                rb.FlatAppearance.BorderSize = 0;
        }


        private async void RenameTable(string TableIID)
        {
            Masa table = await  DTRMSimpleBusiness.Instance.GetTable(TableIID);
            if (table != null)
            {
                trmInput frm = new trmInput(table.TableName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    table.TableName = frm.input;
                     DTRMSimpleBusiness.Instance.SaveTable(table);
                }
            }
        }

        private void chkRenameTable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRenameTable.Checked)
                chkRenameTable.BackColor = Color.Yellow;
            else
                chkRenameTable.BackColor = Color.Fuchsia;
        }
    }
}
