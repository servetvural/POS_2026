using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS
{
    public partial class frmTableSplitter : Form
    {
        private DTRMSimpleBusiness bslayer;

        private Table rootTable;
        private Table SourceTable;
        private Table TargetTable;

        public frmTableSplitter(DTRMSimpleBusiness bslayer, Table SourceTable)
        {
            InitializeComponent();
            this.bslayer = bslayer;
            odSourceTable.AttachBusinessLayer();
            odTargetTable.AttachBusinessLayer();
            this.SourceTable = SourceTable;
            rootTable = SourceTable;

            //If there is no subtable for this sourcetable create the first subtable and load it eventually
            if (!bslayer.HasSubTables(SourceTable.IID).Result)
                btnAddTargetTable_Click(null, null);
            else
            {
                //Load first subtable
                TargetTable = bslayer.GetFirstSubTable(rootTable.IID, true).Result;

            }
        }

        private void frmTableSplitter_Load(object sender, EventArgs e)
        {
            LoadSourceTable();
            LoadSourcePanel();
            LoadTargetTable();
            LoadTargetPanel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (SourceTable != null)
            {
                if (SourceTable.AttachedOrder != null && SourceTable.AttachedOrder.Status < StatusFlags.DONE)
                    SourceTable.AttachedOrder.Status = StatusFlags.DONE;
                bslayer.ReturnTable(SourceTable);
            }

            if (TargetTable != null)
            {
                if (TargetTable.AttachedOrder != null && TargetTable.AttachedOrder.Status < StatusFlags.DONE)
                    TargetTable.AttachedOrder.Status = StatusFlags.DONE;
                bslayer.ReturnTable(TargetTable);
            }

            bslayer.GetRidOfBlankTemporaryTablesForThisTerminalWithNoOrders();
            this.DialogResult = DialogResult.Cancel;
            Close();
        }





        private async Task LoadSourcePanel()
        {
            List<Table> tablelist = await bslayer.GetTableAndSubTables(rootTable.IID);

            pnlSourceTables.Controls.Clear();

            Table table;
            string locker = "";
            string sourceTableIID = "";
            if (SourceTable != null)
                sourceTableIID = SourceTable.IID;

            string targetTableIID = "";
            if (TargetTable != null)
                targetTableIID = TargetTable.IID;

            for (int i = 0; i < tablelist.Count; i++)
            {
                table = tablelist[i];
                if (table.IID != sourceTableIID /*&& table.IID != targetTableIID*/)
                {

                    if (table.LockedClientIP != null && table.LockedClientIP != "")
                        locker = table.LockedClientIP;

                    TableButton btn = new TableButton();
                    btn.Text = table.TableName;
                    btn.IID = table.IID;
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    if (locker.Length > 0)
                    {
                        btn.BackColor = Color.DarkBlue; //bslayer.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                        btn.ForeColor = Color.White; // bslayer.config.Table_Busy_Text_Color;
                    } else
                    {
                        if (table.HasActiveOrder())
                        {
                            btn.BackColor = Color.DarkRed; // bslayer.config.Table_Full_Back_Color; //  Color.DarkRed;
                            btn.ForeColor = Color.White; // bslayer.config.Table_Full_Text_Color;
                        } else
                        {
                            btn.BackColor = Color.DarkGreen;
                            // bslayer.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                            btn.ForeColor = Color.White; // bslayer.config.Table_Free_Text_Color;
                        }
                    }
                    //btn.Location = new Point(table.XLocation, table.YLocation);
                    btn.Size = new Size(108, 70);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Shape = table.Shape;
                    btn.BackgroundImage = Properties.Resources.shadow;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    btn.Click += new System.EventHandler(this.btnSourceTableButton_Click);
                    pnlSourceTables.Controls.Add(btn);
                    locker = "";
                }
            }
        }

        private async void btnSourceTableButton_Click(object sender, EventArgs e)
        {
            //SourceTable = bslayer.GetTable(((TableButton)sender).IID);


            SourceTable = await bslayer.BarrowTable(((TableButton)sender).IID);
            if (SourceTable == null)
            {
                MessageBox.Show("Table Currently Busy, cannot be allocated");
                return;
            }

            if (TargetTable != null)
            {
                if (TargetTable.IID == SourceTable.IID)
                {
                    //Unload target table
                    UnloadTargetTable();
                }
            }
            LoadSourceTable();
            await LoadSourcePanel();
            await LoadTargetPanel();
        }

        private void LoadSourceTable()
        {
            odSourceTable.OrderToDisplay = SourceTable.AttachedOrder;
            odSourceTable.Display();
            lblSourceTableName.Text = SourceTable.TableName;
        }

        private async void UnloadSourceTable()
        {
            if (odSourceTable.OrderToDisplay != null)
            {
                odSourceTable.OrderToDisplay.LockedClientIP = "";
                await bslayer.SaveOrder(odSourceTable.OrderToDisplay);
            }
            odSourceTable.OrderToDisplay = null;
            odSourceTable.Display();
            lblSourceTableName.Text = "";
            bslayer.ReturnTable(SourceTable);
            SourceTable = null;
        }

        private async void btnChangeTableSource_Click(object sender, EventArgs e)
        {
            frmTableSelector frm = new frmTableSelector(bslayer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (SourceTable != null)
                    UnloadSourceTable();
                SourceTable = await bslayer.BarrowTable(frm.SelectedTableButton.IID);
                if (SourceTable == null)
                {
                    MessageBox.Show("Table Currently Busy, cannot be allocated");
                    return;
                }
                if (TargetTable != null)
                {
                    if (TargetTable.IID == SourceTable.IID)
                    {
                        //Unload target table
                        UnloadTargetTable();
                    }
                }

                LoadSourceTable();
                await LoadSourcePanel();
                await LoadTargetPanel();
            }
        }

        private async void btnChangeTableTarget_Click(object sender, EventArgs e)
        {
            frmTableSelector frm = new frmTableSelector(bslayer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (TargetTable != null)
                    UnloadTargetTable();
                TargetTable = await bslayer.BarrowTable(frm.SelectedTableButton.IID);

                if (TargetTable == null)
                {
                    MessageBox.Show("Table Currently Busy, cannot be allocated");
                    return;
                }

                if (SourceTable != null)
                {
                    if (TargetTable.IID == SourceTable.IID)
                    {
                        //Unload source table
                        UnloadSourceTable();
                    }
                }

                LoadTargetTable();
                await LoadTargetPanel();
                await LoadSourcePanel();
            }
        }

        private async Task LoadTargetPanel()
        {
            List<Table> tablelist = await bslayer.GetTableAndSubTables(rootTable.IID);

            pnlTargetTables.Controls.Clear();

            Table table;
            string locker = "";
            string sourceTableIID = "";
            if (SourceTable != null)
                sourceTableIID = SourceTable.IID;

            string targetTableIID = "";
            if (TargetTable != null)
                targetTableIID = TargetTable.IID;

            for (int i = 0; i < tablelist.Count; i++)
            {
                table = tablelist[i];
                if (/*table.IID != sourceTableIID &&*/ table.IID != targetTableIID)
                {

                    if (table.LockedClientIP != null && table.LockedClientIP != "")
                        locker = table.LockedClientIP;

                    TableButton btn = new TableButton();
                    btn.Text = table.TableName;
                    btn.IID = table.IID;
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    if (locker.Length > 0)
                    {
                        btn.BackColor = Color.DarkBlue; //bslayer.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                        btn.ForeColor = Color.White; // bslayer.config.Table_Busy_Text_Color;
                    } else
                    {
                        if (table.HasActiveOrder())
                        {
                            btn.BackColor = Color.DarkRed; // bslayer.config.Table_Full_Back_Color; //  Color.DarkRed;
                            btn.ForeColor = Color.White; // bslayer.config.Table_Full_Text_Color;
                        } else
                        {
                            btn.BackColor = Color.DarkGreen;
                            // bslayer.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                            btn.ForeColor = Color.White; // bslayer.config.Table_Free_Text_Color;
                        }
                    }
                    //btn.Location = new Point(table.XLocation, table.YLocation);
                    btn.Size = new Size(108, 70);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Shape = table.Shape;
                    btn.BackgroundImage = Properties.Resources.shadow;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    btn.Click += new System.EventHandler(this.btnTargetTableButton_Click);
                    pnlTargetTables.Controls.Add(btn);
                    locker = "";
                }
            }
        }

        private async void btnTargetTableButton_Click(object sender, EventArgs e)
        {
            //TargetTable = bslayer.GetTable(((TableButton) sender).IID);

            TargetTable = await bslayer.BarrowTable(((TableButton)sender).IID);
            if (TargetTable == null)
            {
                MessageBox.Show("Table Currently Busy, cannot be allocated");
                return;
            }

            if (SourceTable != null)
            {
                if (TargetTable.IID == SourceTable.IID)
                {
                    //Unload source table
                    UnloadSourceTable();

                }
            }
            LoadTargetTable();
            await LoadTargetPanel();
            await LoadSourcePanel();
        }

        private void LoadTargetTable()
        {
            odTargetTable.OrderToDisplay = TargetTable.AttachedOrder;
            odTargetTable.Display();
            lblTargetTableName.Text = TargetTable.TableName;
        }

        private async Task UnloadTargetTable()
        {
            if (odTargetTable.OrderToDisplay != null)
            {
                odTargetTable.OrderToDisplay.LockedClientIP = "";
                await bslayer.SaveOrder(odTargetTable.OrderToDisplay);
            }

            odTargetTable.OrderToDisplay = null;
            odTargetTable.Display();
            lblTargetTableName.Text = "";
            bslayer.ReturnTable(TargetTable);
            TargetTable = null;
        }

        private async void btnAddTargetTable_Click(object sender, EventArgs e)
        {
            if (SourceTable != null)
            {
                Table mainTable = await bslayer.GetParentTable(SourceTable.IID);
                TargetTable = mainTable.CreateSubTable();
                TargetTable.TableName = await bslayer.GenerateSubTableName(mainTable);
                bslayer.SaveTable(TargetTable);
                //This is required to ensure new order attach to TargetTable
                TargetTable = await bslayer.BarrowTable(TargetTable.IID);
                LoadTargetTable();
                await LoadSourcePanel();
                await LoadTargetPanel();
            }
        }





        private async void btnSourceToTarget_1_Click(object sender, EventArgs e)
        {
            if (SourceTable != null && SourceTable.isPrimary && SourceTable.AttachedOrder != null &&
                SourceTable.AttachedOrder.items.Count == 1)
                return;

            if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            {
                if (!string.IsNullOrEmpty(odSourceTable.SelectedItemIID))
                {
                    //SplitOrder  to  DisplayOrder

                    //Get Select listview item
                    string IID = odSourceTable.SelectedItemIID;

                    //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                    POSLayer.Models.OrderItem oiNew = odSourceTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
                    oiNew.Quantity = 1;
                    oiNew.OrderIID = odTargetTable.OrderToDisplay.IID;

                    //Drop 1 from ordertosplit and save
                    if (!odSourceTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Decrement())
                        odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
                    await bslayer.SaveOrder(odSourceTable.OrderToDisplay);

                    //Add new item to ordertodisplay and save
                    odTargetTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
                    await bslayer.SaveOrder(odTargetTable.OrderToDisplay);

                    odSourceTable.Display();
                    odTargetTable.Display();
                }
            }
        }

        private async void btnSourceToTarget_X_Click(object sender, EventArgs e)
        {
            if (SourceTable != null && SourceTable.isPrimary && SourceTable.AttachedOrder != null &&
                SourceTable.AttachedOrder.items.Count == 1)
                return;
            if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            {
                if (!string.IsNullOrEmpty(odSourceTable.SelectedItemIID))
                {
                    //SplitOrder  to  DisplayOrder

                    //Get Select listview item
                    string IID = odSourceTable.SelectedItemIID;

                    //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                    POSLayer.Models.OrderItem oiNew = odSourceTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
                    if (oiNew.Quantity > 1)
                    {
                        frmNumericInput frm = new frmNumericInput();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (frm.SelectedValue > oiNew.Quantity)
                                return;
                            else
                                oiNew.Quantity = frm.SelectedValue;
                        } else
                            return;
                    } else
                        oiNew.Quantity = 1;

                    oiNew.OrderIID = odTargetTable.OrderToDisplay.IID;

                    //Drop 1 from ordertosplit and save
                    if (!odSourceTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Decrement((int)oiNew.Quantity))
                        odSourceTable.OrderToDisplay.DeleteOrderItem(IID);

                    //Ensure no zero quantity item left
                    try
                    {
                        OrderItem testItem = odSourceTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault();
                        if (testItem != null)
                        {
                            if (testItem.Quantity == 0)
                                odSourceTable.OrderToDisplay.DeleteOrderItem(testItem.IID);
                        }
                    } catch { }

                    await bslayer.SaveOrder(odSourceTable.OrderToDisplay);

                    //Add new item to ordertodisplay and save
                    odTargetTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
                    await bslayer.SaveOrder(odTargetTable.OrderToDisplay);

                    odSourceTable.Display();
                    odTargetTable.Display();
                }
            }
        }

        private async void btnSourceToTarget_ALL_Click(object sender, EventArgs e)
        {
            if (SourceTable != null && SourceTable.isPrimary && SourceTable.AttachedOrder != null &&
                SourceTable.AttachedOrder.items.Count == 1)
                return;

            if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            {
                if (!string.IsNullOrEmpty(odSourceTable.SelectedItemIID))
                {
                    //SplitOrder  to  DisplayOrder

                    //Get Select listview item
                    string IID = odSourceTable.SelectedItemIID;

                    //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                    POSLayer.Models.OrderItem oiNew = odSourceTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
                    //Because it is all
                    //oiNew.Quantity = 1;
                    oiNew.OrderIID = odTargetTable.OrderToDisplay.IID;

                    //Drop 1 from ordertosplit and save
                    odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
                    //if (!odSourceTable.OrderToDisplay.GetOrderItem(IID).Decrement((int)oiNew.Quantity))
                    //    odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
                    await bslayer.SaveOrder(odSourceTable.OrderToDisplay);

                    //Add new item to ordertodisplay and save
                    odTargetTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
                    await bslayer.SaveOrder(odTargetTable.OrderToDisplay);

                    odSourceTable.Display();
                    odTargetTable.Display();
                }
            }
        }


        private async void btnTargetToSource_1_Click(object sender, EventArgs e)
        {
            if (TargetTable != null && TargetTable.isPrimary && TargetTable.AttachedOrder != null &&
                TargetTable.AttachedOrder.items.Count == 1)
                return;

            if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            {
                if (!string.IsNullOrEmpty(odTargetTable.SelectedItemIID))
                {
                    //SplitOrder  to  DisplayOrder

                    //Get Select listview item
                    string IID = odTargetTable.SelectedItemIID;

                    //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                    POSLayer.Models.OrderItem oiNew = odTargetTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
                    oiNew.Quantity = 1;
                    oiNew.OrderIID = odSourceTable.OrderToDisplay.IID;

                    //Drop 1 from ordertosplit and save
                    if (!odTargetTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Decrement())
                        odTargetTable.OrderToDisplay.DeleteOrderItem(IID);
                    await bslayer.SaveOrder(odTargetTable.OrderToDisplay);

                    //Add new item to ordertodisplay and save
                    odSourceTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
                    await bslayer.SaveOrder(odSourceTable.OrderToDisplay);

                    odSourceTable.Display();
                    odTargetTable.Display();
                }
            }




        }

        private async void btnTargetToSource_X_Click(object sender, EventArgs e)
        {
            if (TargetTable != null && TargetTable.isPrimary && TargetTable.AttachedOrder != null &&
               TargetTable.AttachedOrder.items.Count == 1)
                return;

            if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            {
                if (!string.IsNullOrEmpty(odTargetTable.SelectedItemIID))
                {
                    //SplitOrder  to  DisplayOrder

                    //Get Select listview item
                    string IID = odTargetTable.SelectedItemIID;

                    //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                    POSLayer.Models.OrderItem oiNew = odTargetTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
                    if (oiNew.Quantity > 1)
                    {
                        frmNumericInput frm = new frmNumericInput();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            if (frm.SelectedValue > oiNew.Quantity)
                                return;
                            else
                                oiNew.Quantity = frm.SelectedValue;
                        } else
                            return;
                    } else
                        oiNew.Quantity = 1;

                    oiNew.OrderIID = odSourceTable.OrderToDisplay.IID;

                    //Drop 1 from ordertosplit and save
                    if (!odTargetTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Decrement((int)oiNew.Quantity))
                        odTargetTable.OrderToDisplay.DeleteOrderItem(IID);

                    //Ensure no zero quantity item left
                    try
                    {
                        POSLayer.Models.OrderItem testItem = odTargetTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault();
                        if (testItem != null)
                        {
                            if (testItem.Quantity == 0)
                                odTargetTable.OrderToDisplay.DeleteOrderItem(testItem.IID);
                        }
                    } catch { }


                    await bslayer.SaveOrder(odTargetTable.OrderToDisplay);

                    //Add new item to ordertodisplay and save
                    odSourceTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
                    await bslayer.SaveOrder(odSourceTable.OrderToDisplay);

                    odSourceTable.Display();
                    odTargetTable.Display();
                }
            }
        }

        private async void btnTargetToSource_ALL_Click(object sender, EventArgs e)
        {
            if (TargetTable != null && TargetTable.isPrimary && TargetTable.AttachedOrder != null &&
               TargetTable.AttachedOrder.items.Count == 1)
                return;

            if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            {
                if (!string.IsNullOrEmpty(odTargetTable.SelectedItemIID))
                {
                    //SplitOrder  to  DisplayOrder

                    //Get Select listview item
                    string IID = odTargetTable.SelectedItemIID;

                    //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
                    POSLayer.Models.OrderItem oiNew = odTargetTable.OrderToDisplay.items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
                    //Because it is all
                    //oiNew.Quantity = 1;
                    oiNew.OrderIID = odSourceTable.OrderToDisplay.IID;

                    //Drop 1 from ordertosplit and save
                    odTargetTable.OrderToDisplay.DeleteOrderItem(IID);
                    //if (!odSourceTable.OrderToDisplay.GetOrderItem(IID).Decrement((int)oiNew.Quantity))
                    //    odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
                    await bslayer.SaveOrder(odTargetTable.OrderToDisplay);

                    //Add new item to ordertodisplay and save
                    odSourceTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
                    await bslayer.SaveOrder(odSourceTable.OrderToDisplay);

                    odSourceTable.Display();
                    odTargetTable.Display();
                }
            }
        }

        private async void btnChangeTargetTableName_Click(object sender, EventArgs e)
        {
            if (odTargetTable.OrderToDisplay != null)
            {

                trmInput frm = new trmInput(TargetTable.TableName);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    TargetTable.TableName = frm.input;
                    if (TargetTable.AttachedOrder != null)
                        TargetTable.AttachedOrder.TableName = TargetTable.TableName;
                    bslayer.SaveTable(TargetTable);

                    LoadTargetTable();
                    await LoadTargetPanel();
                    await LoadSourcePanel();
                }

            }
        }
    }
}
