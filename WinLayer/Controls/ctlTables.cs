using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer
{
    public partial class ctlTables : UserControl
    {
        PosConfig config;
        IRepository<Masa> repoTable;
        IRepository<Salon> repoSalon;
        IRepository<Order> repoOrder;

        private GenericFunctionCallAsync CloseFunction;
        private GenericEventHandlerAsync ButtonClickHandler;
        private GenericEventHandlerAsync DirectButtonClickHandler;
        private bool blnChangeOrderType;
        private TableButton SourceTable;

        Salon selectedSalon;

        private GenericFunctionCallAsync CloseOrderItemEntityInteractionEvent;

        public ctlTables()
        {
            InitializeComponent();
            config = ServiceHelper.GetService<PosConfig>();             
            repoTable =ServiceHelper.GetService<IRepository<Masa>>();
            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();
            repoOrder = ServiceHelper.GetService<IRepository<Order>>();
        }

        public ctlTables(GenericFunctionCallAsync CloseFunction,
            GenericEventHandlerAsync ButtonClickHandler, GenericEventHandlerAsync DirectButtonClickHandler)
        {
            InitializeComponent();
            this.CloseFunction = CloseFunction;
            this.ButtonClickHandler = ButtonClickHandler;
            this.DirectButtonClickHandler = DirectButtonClickHandler;
            config = ServiceHelper.GetService<PosConfig>();
            repoTable = ServiceHelper.GetService<IRepository<Masa>>();
            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();
            repoOrder = ServiceHelper.GetService<IRepository<Order>>();
        }

        public ctlTables(GenericFunctionCallAsync CloseFunction,
            GenericEventHandlerAsync ButtonClickHandler, bool blnChangeOrderType,
            GenericFunctionCallAsync CloseOrderItemEntityInteraction)
        {
            InitializeComponent();
            this.CloseFunction = CloseFunction;
            this.ButtonClickHandler = ButtonClickHandler;
            this.blnChangeOrderType = blnChangeOrderType;
            this.CloseOrderItemEntityInteractionEvent = CloseOrderItemEntityInteraction;
            config = ServiceHelper.GetService<PosConfig>();
            repoTable = ServiceHelper.GetService<IRepository<Masa>>();
            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();
            repoOrder = ServiceHelper.GetService<IRepository<Order>>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseFunction();
        }

        private async Task LoadTables()
        {
            List<Masa> tablelist = await repoTable.GetAllTablesWithActiveOrders(selectedSalon.IID);

            pnlTables.Controls.Clear();
            pnlTables.BackColor = Color.FromArgb(selectedSalon.SalonColour);

            string locker = "";
            foreach (Masa table in tablelist)
            {                        

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();

                Order order = table.orders.FirstOrDefault();
                btn.Text = table.TableName + "\n" + (order?.Total.ToString("c2"));
                btn.Table = table;
                btn.Font = new Font("Arial", 14, FontStyle.Bold);
                if (locker.Length > 0)
                {
                    btn.BackColor = Color.DarkBlue;
                    btn.ForeColor = Color.White;
                } else
                {
                    if (table.HasActiveOrder)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    } else
                    {
                        btn.BackColor = Color.Green;
                        btn.ForeColor = Color.White;

                        if (btn.Text != table.DefaultName)
                        {
                            table.TableName = table.DefaultName;
                            await repoTable.Save(table);
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
                    
                    TableButton tb = sender as TableButton;
                    if (tb.Table != null && tb.Table.orders.Count > 0)
                    {
                        SourceTable = tb;
                        return;
                    }
                } else
                {
                    TableButton tb = sender as TableButton;
                    if (SourceTable != null && tb.Table != null && (tb.Table.orders == null || tb.Table.orders.Count == 0))
                    {
                        Order order = SourceTable.Table.orders.FirstOrDefault();
                        if (order != null)
                        {
                            order.TableIID = tb.Table.IID;
                            await repoOrder.Save(order);
                            chkChangeTable.Checked = false;
                            await LoadTables();
                            return;
                        }
                    }
                   // await BSLayer.Instance.MoveTable(SourceTable.IID, ((TableButton)sender).IID);
                }
            }

            //if (chkPrintOrder.Checked)
            //{
            //    if (!string.IsNullOrEmpty(config.DTClientLocalReceiptPrinterIID))
            //    {
            //        TableButton tableButton = (TableButton)sender;
            //        bool blnPrinted = false;

            //        Masa table = await BSLayer.Instance.BarrowTable(tableButton.IID);
            //        if (table.AttachedOrder != null)
            //        {
            //            blnPrinted = await BSLayer.Instance.PrintEntireOrder(table.AttachedOrder, true, false, 1,
            //                config.DTClientLocalReceiptPrinterIID);
            //        }

            //        if (blnPrinted && config.Force_Receipt_Printer_To_Cut)
            //            DRShell.SendCutCommandToUSBPrinter(
            //                 BSLayer.Instance.GetPrinterForClient(config.DTClientLocalReceiptPrinterIID).Result.NetworkName);
            //    }
            //}

            //if (blnChangeOrderType)
            //{
            //    Masa table = (sender as TableButton).Table; // await repoTable.Get((sender as TableButton).IID);
            //    if (table.Order != null)
            //        MessageBox.Show("Table already has an order");
            //    else
            //    {
            //        //Delete the incoming new order with the newly allocated table
            //        await BSLayer.Instance.DeleteOrderOnly(table.AttachedOrder);
            //        //Dispatch this order to this table
            //        table.AttachedOrder = BSLayer.Instance.AttachedOrder;
            //        await BSLayer.Instance.SaveTable(table);
            //        //Dispatch newly allocated table to this order
            //        BSLayer.Instance.AttachedOrder.TableIID = table.IID;
            //        BSLayer.Instance.AttachedOrder.Status = StatusFlags.Done;
            //        BSLayer.Instance.AttachedOrder.Title = "T " + table.TableName + " C " + table.TableCovers.ToString();
            //        HandlePriceChange(OrderTypes.Sitin);
            //        BSLayer.Instance.OnDisplayOrder();
            //    }
            //    return;
            //}
            //if (chkUnlockTable.Checked)
            //{
            //    UnlockTable(((TableButton)sender).IID);
            //    chkUnlockTable.Checked = false;
            //    LoadTables();
            //} else if (chkRenameTable.Checked)
            //{
            //    RenameTable(((TableButton)sender).IID);
            //    chkRenameTable.Checked = false;
            //    LoadTables();
            //} else if (chkSplitTable.Checked)
            //{
            //    SourceTable = (TableButton)sender;

            //    Masa STable = await repoTable.Get(SourceTable.IID);
            //    if (STable.Order == null)
            //    {

            //        //No Order on this table to split so abort process
            //        chkSplitTable.Checked = false;
            //        return;
            //    } else
            //    {
            //        //Now properly barrowtable for system lock, so no one can do any operation on it
            //        STable = await BSLayer.Instance.BarrowTable(SourceTable.IID);
            //        frmTableSplitter frm = new frmTableSplitter(STable);
            //        frm.ShowDialog();

            //        BSLayer.Instance.ReturnTable(STable);
            //    }
            //    chkSplitTable.Checked = false;
            //    LoadTables();
            //} else
            //{
                ButtonClickHandler(sender, e);
                //CloseFunction();
            //}
        }


        private void HandlePriceChange(POSLayer.Library.OrderTypes RequestedType)
        {
            //switch (BSLayer.MessageBoxDT("Do you want all item prices to be changed ?", "CHANGE PRICES", DialogTypes.YesNoCancel)) {
            //   case DialogResult.Yes:
            //Close tabpages to ensure the last open top order item having completed effect
            //MainForm.CloseOrderItemEntityInteraction();
            CloseOrderItemEntityInteractionEvent();

            //Do recalculation
             BSLayer.Instance.RePriceOrderForOrderType( BSLayer.Instance.AttachedOrder, RequestedType);
             BSLayer.Instance.ReTaxOrderForOrderType( BSLayer.Instance.AttachedOrder, RequestedType);
             BSLayer.Instance.AttachedOrder.OrderType = RequestedType;
            CloseFunction();

        }

        private async void ctlTables_Load(object sender, EventArgs e)
        {
           await LoadSalons();
        }

        private async void UnlockTable(string TableIID)
        {
            //DialogResult whattodo = MessageBox.Show(this, "You are about to unlock the table.\n" +
            //   "If any orderpad is amending this table or its order, its changes will not be updated!\n" +
            //   "Are you sure you want to continue ?",
            //   "TABLE UNLOCK WARNING", MessageBoxButtons.YesNo);
            //switch (whattodo)
            //{
            //    case DialogResult.Yes:
            //        Masa table = await  BSLayer.Instance.GetTable(TableIID);
            //        if (table != null)
            //        {
            //            table.LockedClientIP = "";
            //             BSLayer.Instance.SaveTable(table);
            //        }
            //        this.LoadTables();
            //        break;
            //    case DialogResult.No:
            //        return;
            //    default:
            //        break;
            //}
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

        private async Task LoadSalons()
        {
            pnlSalons.Controls.Clear();

            List<Salon> salons = await repoSalon.GetAllAsync();

            foreach (var salon in salons)
            {

                RadioButton btn = new RadioButton();
                btn.Appearance = Appearance.Button;
                btn.CheckedChanged += new EventHandler(SalonButton_CheckedChanged);
                btn.BackColor = Color.Green;
                //btn.BackgroundImage = Properties.Resources.shadow;
                //btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.MinimumSize = new Size(90, 50);
                btn.AutoSize = true;
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.Text = salon.SalonName;
                btn.Tag = salon.IID;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.Yellow;
                btn.Margin = new Padding(5);

                pnlSalons.Controls.Add(btn);
                btn.Dock = DockStyle.Top;
            }
            bool chk = false;
            for (int i = 0; i < pnlSalons.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)pnlSalons.Controls[i];
                if (rb.Checked)
                {
                    chk = true;
                    break;
                }
            }
            if (!chk && pnlSalons.Controls.Count > 0)
                ((RadioButton)pnlSalons.Controls[0]).Checked = true;
        }

        private async void SalonButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                rb.FlatAppearance.BorderSize = 1;
                selectedSalon = await repoSalon.Get(rb.Tag.ToString());
                LoadTables();
            } else
                rb.FlatAppearance.BorderSize = 0;
        }


        private async void RenameTable(string TableIID)
        {
            Masa table = await repoTable.Get(TableIID);
            if (table != null)
            {
                trmInput frm = new trmInput(table.TableName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    table.TableName = frm.input;
                    await repoTable.Save(table);
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
