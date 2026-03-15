using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

using PosLibrary;

namespace DTRMNS {
    public partial class frmSubTableSelector : Form{
        private DTRMSimpleBusiness bslayer;
        private string rootTableIID;
        private GenericEventHandler ButtonClickHandler;
        private List<Table> tablelist;
        private TableButton SourceTable;

        private TableButton sourceMergeTable;

        public frmSubTableSelector(DTRMSimpleBusiness bslayer, string rootTableIID, GenericEventHandler ButtonClickHandler) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.rootTableIID = rootTableIID;
            this.ButtonClickHandler = ButtonClickHandler;

        }

        private void frmSubTableSelector_Load(object sender, EventArgs e) {
            LoadTables();
        }

        private void LoadTables() {
            tablelist = bslayer.GetTableAndSubTables(rootTableIID).Result;

            pnlTables.Controls.Clear();

            Table table;
            string locker = "";
            int busyTableCounter = 0;
            for (int i = 0; i < tablelist.Count; i++) {
                table = tablelist[i];

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();
                btn.Text = table.TableName;
                btn.IID = table.IID;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (locker.Length > 0) {
                    btn.BackColor = Color.DarkBlue; //bslayer.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                    btn.ForeColor = Color.White; // bslayer.config.Table_Busy_Text_Color;
                    busyTableCounter++;
                } else {
                    if (table.HasActiveOrder()) {
                        btn.BackColor = Color.DarkRed; // bslayer.config.Table_Full_Back_Color; //  Color.DarkRed;
                        btn.ForeColor = Color.White; // bslayer.config.Table_Full_Text_Color;
                        busyTableCounter++;
                    } else {
                        btn.BackColor = Color.DarkGreen;
                        // bslayer.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                        btn.ForeColor = Color.White; // bslayer.config.Table_Free_Text_Color;
                    }
                }
                btn.Location = new Point(table.XLocation, table.YLocation);
                btn.Size = new Size(150, 90);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Shape = table.Shape;
                btn.TableType = table.TableType;
                btn.Click += new System.EventHandler(this.SubButtonClickHandler);
                btn.MouseDown += Btn_MouseDown;
                pnlTables.Controls.Add(btn);
                locker = "";
            }
            if (busyTableCounter == 0)
                this.Close();
        }

        private async void Btn_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                TableButton tableButton = (TableButton)sender;
                Table table =await bslayer.GetTable(tableButton.IID);
                if (string.IsNullOrEmpty(table.ParentTableIID))
                    return;
                else {
                    trmInput frm = new trmInput(tableButton.Text);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        table.TableName = frm.input;
                        bslayer.SaveTable(table);
                        LoadTables();
                        chkChangeTableName.Checked = false;
                    }
                }
            }

        }

        private async void SubButtonClickHandler(object sender, EventArgs e) {
            if (chkJoin2Table.Checked) {
                if (sourceMergeTable == null) {
                    //Identify Source Table
                    sourceMergeTable = (TableButton) sender;
                    return;
                }
                else {
                    bslayer.MergeTable(sourceMergeTable.IID, ((TableButton)sender).IID);

                    chkJoin2Table.Checked = false;
                    sourceMergeTable = null;
                    LoadTables();
                    return;
                }
            }

            if (chkChangeTable.Checked) {
                if (SourceTable == null) {
                    SourceTable = (TableButton) sender;
                    frmTableSelector frm = new frmTableSelector(bslayer);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        bool blnLeaveSubTables = false;
                        if (SourceTable.IsPrimary) {
                            if (bslayer.HasSubTables(SourceTable.IID).Result) {
                                blnLeaveSubTables = MessageBox.Show("Do you want to move sub tables as well?",
                                                        "Move ALL",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2) == DialogResult.No;
                            }
                        }
                        bslayer.MoveTable(SourceTable.IID, frm.SelectedTableButton.IID, blnLeaveSubTables);

                        chkChangeTable.Checked = false;
                        LoadTables();
                        SourceTable = null;
                        
                        return;
                    }
                }
            }

            if (chkPrintTableOrder.Checked) {
                TableButton tableButton = (TableButton)sender;
                Table table =await bslayer.BarrowTable(tableButton.IID);
                if (table.AttachedOrder != null && string.IsNullOrEmpty(bslayer.config.DTClientLocalReceiptPrinterIID)) { 
                        bslayer.PrintEntireOrder(table.AttachedOrder, true, false, 1,
                            bslayer.config.DTClientLocalReceiptPrinterIID);
                        if (bslayer.config.Force_Receipt_Printer_To_Cut)
                            DRShell.SendCutCommandToUSBPrinter(
                                bslayer.GetPrinterForClient(bslayer.config.DTClientLocalReceiptPrinterIID).NetworkName);
                    
                }
            }

            if (chkChangeTableName.Checked) {
                TableButton tableButton = (TableButton) sender;
                Table table = await bslayer.GetTable(tableButton.IID);
                //if (string.IsNullOrEmpty(table.ParentTableIID))
                //    return;
                //else {
                    trmInput frm = new trmInput(tableButton.Text);
                    if (frm.ShowDialog() == DialogResult.OK) {
                        table.TableName = frm.input;
                        bslayer.SaveTable(table);
                        LoadTables();
                        chkChangeTableName.Checked = false;
                    }
                //}
            }
            else {
                this.Close();
                this.ButtonClickHandler(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            bslayer.GetRidOfBlankTemporaryTablesForThisTerminalWithNoOrders();
            this.Close();
        }

        private void btnAddSubTable_Click(object sender, EventArgs e) {
            if (bslayer.AddSubTableWithTest(rootTableIID).Result)
                LoadTables();
        }

        private void btnPrintAllTables_Click(object sender, EventArgs e) {
            for (int i = 0; i < tablelist.Count; i++) {
                if (string.IsNullOrEmpty(bslayer.config.DTClientLocalReceiptPrinterIID)) {
                    bslayer.PrintEntireOrder(tablelist[i].AttachedOrder, true, false, 1,
                        bslayer.config.DTClientLocalReceiptPrinterIID);
                    if (bslayer.config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(
                            bslayer.GetPrinterForClient(bslayer.config.DTClientLocalReceiptPrinterIID).NetworkName);
                }
            }
        }

        private async Task btnJoinAllTables_Click(object sender, EventArgs e) {
            Table primaryTable =await bslayer.BarrowTable(rootTableIID);
            for (int i = 0; i < tablelist.Count; i++) {
                if (tablelist[i].IID != rootTableIID)
                    bslayer.MergeTable(tablelist[i].IID, rootTableIID);
            }
            Close();
        }

    }
}
