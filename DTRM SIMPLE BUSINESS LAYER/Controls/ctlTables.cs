using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using PosLibrary;

using POSLayer.Library;
using POSLayer.Models;
using System.Threading.Tasks;


namespace DTRMNS {
    public partial class ctlTables : UserControl{
        private GenericFunctionCall CloseFunction;
        private GenericEventHandler ButtonClickHandler;
        private GenericEventHandler DirectButtonClickHandler;
        private DTRMNS.DTRMSimpleBusiness bslayer;
        private bool blnChangeOrderType;
        //private frmMain MainForm;
        private TableButton SourceTable;
        // private CustomEventHandler CloseOrderItemEntityInteractionEvent;

        private GenericFunctionCall CloseOrderItemEntityInteractionEvent;

        private string SelectedGroup;

        public ctlTables() {
            InitializeComponent();
        }

        public ctlTables(DTRMNS.DTRMSimpleBusiness bs, GenericFunctionCall CloseFunction,
            GenericEventHandler ButtonClickHandler, GenericEventHandler DirectButtonClickHandler) {
            InitializeComponent();
            bslayer = bs;
            this.CloseFunction = CloseFunction;
            this.ButtonClickHandler = ButtonClickHandler;
            this.DirectButtonClickHandler = DirectButtonClickHandler;
        }

        public ctlTables(DTRMNS.DTRMSimpleBusiness bs, GenericFunctionCall CloseFunction,
            GenericEventHandler ButtonClickHandler, bool blnChangeOrderType,
            GenericFunctionCall CloseOrderItemEntityInteraction) {
            InitializeComponent();
            bslayer = bs;
            this.CloseFunction = CloseFunction;
            this.ButtonClickHandler = ButtonClickHandler;
            this.blnChangeOrderType = blnChangeOrderType;
            //this.MainForm = MainForm;
            this.CloseOrderItemEntityInteractionEvent = CloseOrderItemEntityInteraction;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            CloseFunction();
        }

        private async void LoadTables() {
            List<Table> tablelist =await bslayer.GetTableList(SelectedGroup);

            pnlTables.Controls.Clear();
            //pnlTables.BackColor = Color.AliceBlue;

            Table table;
            string locker = "";
            for (int i = 0; i < tablelist.Count; i++) {
                table = tablelist[i];

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();

                btn.Text = table.TableName + (table.KitchenOrderNumber != "" ? "\n.. " + table.KitchenOrderNumber + " .." : "");
                btn.IID = table.IID;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (locker.Length > 0) {
                    btn.BackColor = Color.DarkBlue; //bslayer.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                    btn.ForeColor = Color.White; // bslayer.config.Table_Busy_Text_Color;
                }
                else {
                    if (table.HasActiveOrder()) {
                        btn.BackColor = Color.DarkRed; // bslayer.config.Table_Full_Back_Color; //  Color.DarkRed;
                        btn.ForeColor = Color.White; // bslayer.config.Table_Full_Text_Color;
                    }
                    else {
                        btn.BackColor = Color.DarkGreen;
                            // bslayer.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                        btn.ForeColor = Color.White; // bslayer.config.Table_Free_Text_Color;

                        if (btn.Text != table.DefaultName) {
                            table.TableName = table.DefaultName;
                            bslayer.SaveTable(table);
                            btn.Text = table.DefaultName;
                        }

                    }
                }
                btn.Location = new Point(table.XLocation, table.YLocation);

                //btn.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\Table.png");
                //btn.BackgroundImageLayout = ImageLayout.Stretch;

                btn.Size = new Size(table.Width, table.Height);
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Shape = table.Shape;
                btn.TableType = table.TableType;
                btn.Click += new System.EventHandler(this.btnQuickTableButton_Click);
                pnlTables.Controls.Add(btn);
                locker = "";
            }
        }

        private async void btnQuickTableButton_Click(object sender, EventArgs e) {
            if (chkChangeTable.Checked) {
                if (SourceTable == null) {
                    //Identify Source Table
                    SourceTable = (TableButton) sender;

                    return;
                }
                else {
                    bool blnLeaveSubTables = false;
                    if (SourceTable.IsPrimary) {
                        if (await bslayer.HasSubTables(SourceTable.IID)) {
                            blnLeaveSubTables = MessageBox.Show("Do you want to move sub tables as well?",
                                                    "Move ALL",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button2) == DialogResult.No;
                        }
                    }
                    bslayer.MoveTable(SourceTable.IID, ((TableButton)sender).IID,blnLeaveSubTables);

                    chkChangeTable.Checked = false;
                    LoadTables();
                    return;
                }
            }
            if (chkAddSubTable.Checked) {
                Table table =await bslayer.GetTable(((TableButton) sender).IID);
                Table subTable = null;
                if (table.HasActiveOrder()) {
                    subTable =await bslayer.AddSubTable(table.IID);
                    DirectButtonClickHandler(subTable.IID, e);
                   
                } else
                    ButtonClickHandler(sender, e);
                CloseFunction();
                //directly load the newly created sub table would be better
                return;
            }

            if (chkPrintOrder.Checked) {
                if (!string.IsNullOrEmpty(bslayer.config.DTClientLocalReceiptPrinterIID)) {
                    TableButton tableButton = (TableButton) sender;
                    bool blnPrinted = false;
                    if (await bslayer.HasSubTables(tableButton.IID)) {
                        List<Table> tablelist =await bslayer.GetTableAndSubTables(tableButton.IID);
                        for (int i = 0; i < tablelist.Count; i++) {
                                blnPrinted =await bslayer.PrintEntireOrder(tablelist[i].AttachedOrder, true, false, 1,
                                    bslayer.config.DTClientLocalReceiptPrinterIID);
                        }
                    }
                    else {
                        Table table =await bslayer.BarrowTable(tableButton.IID);
                        if (table.AttachedOrder != null) {
                            blnPrinted =await bslayer.PrintEntireOrder(table.AttachedOrder, true, false, 1,
                                bslayer.config.DTClientLocalReceiptPrinterIID);
                        }
                    }
                    if (blnPrinted && bslayer.config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(
                            bslayer.GetPrinterForClient(bslayer.config.DTClientLocalReceiptPrinterIID).Result.NetworkName);
                }
            }

            if (blnChangeOrderType) {
                Table table =await bslayer.GetTable(((TableButton) sender).IID);
                if (table.CurrentOrderIID != null && table.CurrentOrderIID != "")
                    MessageBox.Show("Table already has an order");
                else {
                    //Delete the incoming new order with the newly allocated table
                   await bslayer.DeleteOrderOnly(table.AttachedOrder);
                    //Dispatch this order to this table
                    table.AttachedOrder = bslayer.AttachedOrder;
                    table.CurrentOrderIID = bslayer.AttachedOrder.IID;
                    bslayer.SaveTable(table);
                    //Dispatch newly allocated table to this order
                    bslayer.AttachedOrder.TableIID = table.IID;
                    bslayer.AttachedOrder.Status = StatusFlags.DONE;
                    bslayer.AttachedOrder.Title = "T " + table.TableName + " C " + table.TableCovers.ToString();
                    HandlePriceChange(OrderTypes.InHouse);
                    bslayer.OnDisplayOrder();
                }
                return;
            }
            if (chkUnlockTable.Checked) {
                UnlockTable(((TableButton) sender).IID);
                chkUnlockTable.Checked = false;
                LoadTables();
            }
            else if (chkRenameTable.Checked) {
                RenameTable(((TableButton) sender).IID);
                chkRenameTable.Checked = false;
                LoadTables();
            }
            //else if (chkRemoveOrderLock.Checked) {
            //    RemoveOrderLockFromTable(((TableButton) sender).IID);
            //    chkRemoveOrderLock.Checked = false;
            //    LoadTables();
            //}
            else if (chkSplitTable.Checked) {
                SourceTable = (TableButton) sender;

                Table STable =await bslayer.GetTable(SourceTable.IID);
                if (String.IsNullOrEmpty(STable.CurrentOrderIID)) {

                    //No Order on this table to split so abort process
                    chkSplitTable.Checked = false;
                    return;
                }
                else {
                    //Now properly barrowtable for system lock, so no one can do any operation on it
                    STable =await bslayer.BarrowTable(SourceTable.IID);
                    frmTableSplitter frm = new frmTableSplitter(bslayer, STable);
                    frm.ShowDialog();

                    //STable.DetachOrder();
                    //STable.CurrentOrderIID = "";
                    //STable.AttachedOrder = null;
                    bslayer.ReturnTable(STable);
                }
                chkSplitTable.Checked = false;
                LoadTables();
            }
            else {
                ButtonClickHandler(sender, e);
                //CloseFunction();
            }
        }


        private void HandlePriceChange(POSLayer.Library.OrderTypes RequestedType) {
            //switch (DTRMSimpleBusiness.MessageBoxDT("Do you want all item prices to be changed ?", "CHANGE PRICES", DialogTypes.YesNoCancel)) {
            //   case DialogResult.Yes:
            //Close tabpages to ensure the last open top order item having completed effect
            //MainForm.CloseOrderItemEntityInteraction();
            CloseOrderItemEntityInteractionEvent();

            //Do recalculation
            bslayer.RePriceOrderForOrderType(bslayer.AttachedOrder, RequestedType);
            bslayer.ReTaxOrderForOrderType(bslayer.AttachedOrder, RequestedType);
            bslayer.AttachedOrder.OrderType = RequestedType;
            CloseFunction();
            ////      break;
            ////   case DialogResult.No:
            ////      //Close tabpages to ensure the last open top order item having completed effect
            ////      MainForm.CloseOrderItemEntityInteraction();

            ////      bslayer.AttachedOrder.OrderType = RequestedType;
            ////      CloseFunction();
            ////      break;
            ////   case DialogResult.Cancel:
            ////      break;
            ////}

        }

        private void ctlTables_Load(object sender, EventArgs e) {
          LoadGroups();
      }
  

       //private void RemoveOrderLockFromTable(string TableIID) {
       //    DialogResult whattodo = MessageBox.Show(this, "You are about to REMOVE ORDER from the table.\n" +
       //    "Are you sure you want to continue ?",
       //    "TABLE ORDER REMOVE WARNING", MessageBoxButtons.YesNo);
       //    switch (whattodo) {
       //        case DialogResult.Yes:
       //            Table table = bslayer.GetTable(TableIID);
       //            if (table != null) {
       //                Order Xorder = bslayer.GetOrder(table.CurrentOrderIID);
       //                if (Xorder != null) {
       //                    Xorder.TableIID = "";
       //                    Xorder.TableName = "";
       //                    bslayer.SaveOrder(Xorder);
       //                }
       //                table.CurrentOrderIID = "";
       //                bslayer.SaveTable(table);
       //            }
       //            this.LoadTables();
       //            break;
       //        case DialogResult.No:
       //            return;
       //        default:
       //            break;
       //    }
       //}
  
      private async void UnlockTable(string TableIID) {         
         DialogResult whattodo = MessageBox.Show(this, "You are about to unlock the table.\n" +
            "If any orderpad is amending this table or its order, its changes will not be updated!\n" +
            "Are you sure you want to continue ?",
            "TABLE UNLOCK WARNING", MessageBoxButtons.YesNo);
         switch (whattodo) {
            case DialogResult.Yes:
               Table table =await bslayer.GetTable(TableIID);
               if (table != null) {
                  table.LockedClientIP = "";
                  bslayer.SaveTable(table);
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
         if (chkChangeTable.Checked) {
            chkChangeTable.BackColor = Color.Yellow;
            SourceTable = null;
         }
         else
             chkChangeTable.BackColor = Color.Gold;
      }

       //private void chkRemoveOrderLock_CheckedChanged(object sender, EventArgs e) {
       //    if (chkRemoveOrderLock.Checked)
       //        chkRemoveOrderLock.BackColor = Color.Yellow;
       //    else
       //        chkRemoveOrderLock.BackColor = Color.ForestGreen;
       //}

       private void LoadGroups() {
           pnlGroups.Controls.Clear();

           DataTable dt = bslayer.GetAllTableGroups();
           for (int i = 0; i < dt.Rows.Count; i++) {
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
           for (int i = 0; i < pnlGroups.Controls.Count; i++) {
                RadioButton rb = ( RadioButton)pnlGroups.Controls[i];
               if (rb.Checked) {
                   chk = true;
                   break;
               }
           }
           if (!chk && pnlGroups.Controls.Count > 0)
               (( RadioButton)pnlGroups.Controls[0]).Checked = true;
       }

       private void GroupButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rb = ( RadioButton)sender;
           if (rb.Checked) {
               rb.FlatAppearance.BorderSize = 1;
               SelectedGroup = rb.Tag.ToString();
               LoadTables();
           } else
               rb.FlatAppearance.BorderSize = 0;
       }


       private async void RenameTable(string TableIID) {
           Table table = await bslayer.GetTable(TableIID);
           if (table != null) {
               trmInput frm = new trmInput(table.TableName);
               if (frm.ShowDialog() == DialogResult.OK) {
                   table.TableName = frm.input;
                   bslayer.SaveTable(table);
               }
           }
       }

       private void chkRenameTable_CheckedChanged(object sender, EventArgs e) {
           if (chkRenameTable.Checked)
               chkRenameTable.BackColor = Color.Yellow;
           else
               chkRenameTable.BackColor = Color.Fuchsia;
       }
   }
}
