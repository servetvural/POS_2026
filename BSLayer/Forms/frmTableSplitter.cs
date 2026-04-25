using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace BSLayer
{
    public partial class frmTableSplitter : Form
    {
        private Masa rootTable;
        private Masa SourceTable;
        private Masa TargetTable;

        public frmTableSplitter(Masa SourceTable)
        {
            InitializeComponent();
            odSourceTable.AttachBusinessLayer();
            odTargetTable.AttachBusinessLayer();
            this.SourceTable = SourceTable;
            rootTable = SourceTable;

            //If there is no subtable for this sourcetable create the first subtable and load it eventually
            
                btnAddTargetTable_Click(null, null);
            
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
                if (SourceTable.AttachedOrder != null && SourceTable.AttachedOrder.Status < StatusFlags.Done)
                    SourceTable.AttachedOrder.Status = StatusFlags.Done;
                DTRMSimpleBusiness.Instance.ReturnTable(SourceTable);
            }

            if (TargetTable != null)
            {
                if (TargetTable.AttachedOrder != null && TargetTable.AttachedOrder.Status < StatusFlags.Done)
                    TargetTable.AttachedOrder.Status = StatusFlags.Done;
                DTRMSimpleBusiness.Instance.ReturnTable(TargetTable);
            }

            this.DialogResult = DialogResult.Cancel;
            Close();
        }





        private async Task LoadSourcePanel()
        {
            List<Masa> tablelist = await DTRMSimpleBusiness.Instance.GetTableAndSubTables(rootTable.IID);

            pnlSourceTables.Controls.Clear();

            Masa table;
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
                    btn.Table = table;
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    if (locker.Length > 0)
                    {
                        btn.BackColor = Color.DarkBlue; // DTRMSimpleBusiness.Instance.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                        btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Busy_Text_Color;
                    } else
                    {
                        if (table.HasActiveOrder)
                        {
                            btn.BackColor = Color.DarkRed; //  DTRMSimpleBusiness.Instance.config.Table_Full_Back_Color; //  Color.DarkRed;
                            btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Full_Text_Color;
                        } else
                        {
                            btn.BackColor = Color.DarkGreen;
                            //  DTRMSimpleBusiness.Instance.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                            btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Free_Text_Color;
                        }
                    }
                    //btn.Location = new Point(table.XLocation, table.YLocation);
                    btn.Size = new Size(108, 70);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
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
            //SourceTable =  DTRMSimpleBusiness.Instance.GetTable(((TableButton)sender).IID);


            SourceTable = await DTRMSimpleBusiness.Instance.BarrowTable(((TableButton)sender).Table.IID);
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
            //odSourceTable.OrderToDisplay = SourceTable.AttachedOrder;
            //odSourceTable.Display();
            //lblSourceTableName.Text = SourceTable.TableName;
        }

        private async void UnloadSourceTable()
        {
            //if (odSourceTable.OrderToDisplay != null)
            //{
            //    odSourceTable.OrderToDisplay.LockedClientIP = "";
            //    await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);
            //}
            //odSourceTable.OrderToDisplay = null;
            //odSourceTable.Display();
            //lblSourceTableName.Text = "";
            //DTRMSimpleBusiness.Instance.ReturnTable(SourceTable);
            //SourceTable = null;
        }

        private async void btnChangeTableSource_Click(object sender, EventArgs e)
        {
            frmTableSelector frm = new frmTableSelector();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (SourceTable != null)
                    UnloadSourceTable();
                SourceTable = await DTRMSimpleBusiness.Instance.BarrowTable(frm.SelectedTableButton.Table.IID);
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
            frmTableSelector frm = new frmTableSelector();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (TargetTable != null)
                    UnloadTargetTable();
                TargetTable = await DTRMSimpleBusiness.Instance.BarrowTable(frm.SelectedTableButton.Table.IID);

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
            List<Masa> tablelist = await DTRMSimpleBusiness.Instance.GetTableAndSubTables(rootTable.IID);

            pnlTargetTables.Controls.Clear();

            Masa table;
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
                    btn.Table = table;
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    if (locker.Length > 0)
                    {
                        btn.BackColor = Color.DarkBlue; // DTRMSimpleBusiness.Instance.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                        btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Busy_Text_Color;
                    } else
                    {
                        if (table.HasActiveOrder)
                        {
                            btn.BackColor = Color.DarkRed; //  DTRMSimpleBusiness.Instance.config.Table_Full_Back_Color; //  Color.DarkRed;
                            btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Full_Text_Color;
                        } else
                        {
                            btn.BackColor = Color.DarkGreen;
                            //  DTRMSimpleBusiness.Instance.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                            btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Free_Text_Color;
                        }
                    }
                    //btn.Location = new Point(table.XLocation, table.YLocation);
                    btn.Size = new Size(108, 70);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
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
            //TargetTable =  DTRMSimpleBusiness.Instance.GetTable(((TableButton) sender).IID);

            TargetTable = await DTRMSimpleBusiness.Instance.BarrowTable(((TableButton)sender).Table.IID);
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
            //odTargetTable.OrderToDisplay = TargetTable.AttachedOrder;
            //odTargetTable.Display();
            //lblTargetTableName.Text = TargetTable.TableName;
        }

        private async Task UnloadTargetTable()
        {
            //if (odTargetTable.OrderToDisplay != null)
            //{
            //    odTargetTable.OrderToDisplay.LockedClientIP = "";
            //    await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);
            //}

            //odTargetTable.OrderToDisplay = null;
            //odTargetTable.Display();
            //lblTargetTableName.Text = "";
            //await DTRMSimpleBusiness.Instance.ReturnTable(TargetTable);
            //TargetTable = null;
        }

        private async void btnAddTargetTable_Click(object sender, EventArgs e)
        {
            //if (SourceTable != null)
            //{
            //    Table mainTable = await  DTRMSimpleBusiness.Instance.GetParentTable(SourceTable.IID);
            //    TargetTable = mainTable.CreateSubTable();
            //    TargetTable.TableName = await  DTRMSimpleBusiness.Instance.GenerateSubTableName(mainTable);
            //     DTRMSimpleBusiness.Instance.SaveTable(TargetTable);
            //    //This is required to ensure new order attach to TargetTable
            //    TargetTable = await  DTRMSimpleBusiness.Instance.BarrowTable(TargetTable.IID);
            //    LoadTargetTable();
            //    await LoadSourcePanel();
            //    await LoadTargetPanel();
            //}
        }





        private async void btnSourceToTarget_1_Click(object sender, EventArgs e)
        {
            //if (SourceTable != null  && SourceTable.AttachedOrder != null &&
            //    SourceTable.AttachedOrder.Items.Count == 1)
            //    return;

            //if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            //{
            //    if (!string.IsNullOrEmpty(odSourceTable.SelectedItemIID))
            //    {
            //        //SplitOrder  to  DisplayOrder

            //        //Get Select listview item
            //        string IID = odSourceTable.SelectedItemIID;

            //        //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
            //        POSLayer.Models.OrderItem oiNew = odSourceTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
            //        oiNew.Quantity = 1;
            //        oiNew.OrderIID = odTargetTable.OrderToDisplay.IID;

            //        //Drop 1 from ordertosplit and save
            //        if (!odSourceTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Decrement())
            //            odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);

            //        //Add new item to ordertodisplay and save
            //        odTargetTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);

            //        odSourceTable.Display();
            //        odTargetTable.Display();
            //    }
            //}
        }

        private async void btnSourceToTarget_X_Click(object sender, EventArgs e)
        {
            //if (SourceTable != null && SourceTable.AttachedOrder != null &&
            //    SourceTable.AttachedOrder.Items.Count == 1)
            //    return;
            //if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            //{
            //    if (!string.IsNullOrEmpty(odSourceTable.SelectedItemIID))
            //    {
            //        //SplitOrder  to  DisplayOrder

            //        //Get Select listview item
            //        string IID = odSourceTable.SelectedItemIID;

            //        //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
            //        POSLayer.Models.OrderItem oiNew = odSourceTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
            //        if (oiNew.Quantity > 1)
            //        {
            //            frmNumericInput frm = new frmNumericInput();
            //            if (frm.ShowDialog() == DialogResult.OK)
            //            {
            //                if (frm.SelectedValue > oiNew.Quantity)
            //                    return;
            //                else
            //                    oiNew.Quantity = frm.SelectedValue;
            //            } else
            //                return;
            //        } else
            //            oiNew.Quantity = 1;

            //        oiNew.OrderIID = odTargetTable.OrderToDisplay.IID;

            //        //Drop 1 from ordertosplit and save
            //        if (!odSourceTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Decrement((int)oiNew.Quantity))
            //            odSourceTable.OrderToDisplay.DeleteOrderItem(IID);

            //        //Ensure no zero quantity item left
            //        try
            //        {
            //            OrderItem testItem = odSourceTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault();
            //            if (testItem != null)
            //            {
            //                if (testItem.Quantity == 0)
            //                    odSourceTable.OrderToDisplay.DeleteOrderItem(testItem.IID);
            //            }
            //        } catch { }

            //        await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);

            //        //Add new item to ordertodisplay and save
            //        odTargetTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);

            //        odSourceTable.Display();
            //        odTargetTable.Display();
            //    }
            //}
        }

        private async void btnSourceToTarget_ALL_Click(object sender, EventArgs e)
        {
            //if (SourceTable != null && SourceTable.AttachedOrder != null &&
            //    SourceTable.AttachedOrder.Items.Count == 1)
            //    return;

            //if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            //{
            //    if (!string.IsNullOrEmpty(odSourceTable.SelectedItemIID))
            //    {
            //        //SplitOrder  to  DisplayOrder

            //        //Get Select listview item
            //        string IID = odSourceTable.SelectedItemIID;

            //        //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
            //        POSLayer.Models.OrderItem oiNew = odSourceTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
            //        //Because it is all
            //        //oiNew.Quantity = 1;
            //        oiNew.OrderIID = odTargetTable.OrderToDisplay.IID;

            //        //Drop 1 from ordertosplit and save
            //        odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
            //        //if (!odSourceTable.OrderToDisplay.GetOrderItem(IID).Decrement((int)oiNew.Quantity))
            //        //    odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);

            //        //Add new item to ordertodisplay and save
            //        odTargetTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);

            //        odSourceTable.Display();
            //        odTargetTable.Display();
            //    }
            //}
        }


        private async void btnTargetToSource_1_Click(object sender, EventArgs e)
        {
            //if (TargetTable != null && TargetTable.AttachedOrder != null &&
            //    TargetTable.AttachedOrder.Items.Count == 1)
            //    return;

            //if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            //{
            //    if (!string.IsNullOrEmpty(odTargetTable.SelectedItemIID))
            //    {
            //        //SplitOrder  to  DisplayOrder

            //        //Get Select listview item
            //        string IID = odTargetTable.SelectedItemIID;

            //        //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
            //        POSLayer.Models.OrderItem oiNew = odTargetTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
            //        oiNew.Quantity = 1;
            //        oiNew.OrderIID = odSourceTable.OrderToDisplay.IID;

            //        //Drop 1 from ordertosplit and save
            //        if (!odTargetTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Decrement())
            //            odTargetTable.OrderToDisplay.DeleteOrderItem(IID);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);

            //        //Add new item to ordertodisplay and save
            //        odSourceTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);

            //        odSourceTable.Display();
            //        odTargetTable.Display();
            //    }
            //}




        }

        private async void btnTargetToSource_X_Click(object sender, EventArgs e)
        {
            //if (TargetTable != null  && TargetTable.AttachedOrder != null &&
            //   TargetTable.AttachedOrder.Items.Count == 1)
            //    return;

            //if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            //{
            //    if (!string.IsNullOrEmpty(odTargetTable.SelectedItemIID))
            //    {
            //        //SplitOrder  to  DisplayOrder

            //        //Get Select listview item
            //        string IID = odTargetTable.SelectedItemIID;

            //        //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
            //        POSLayer.Models.OrderItem oiNew = odTargetTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
            //        if (oiNew.Quantity > 1)
            //        {
            //            frmNumericInput frm = new frmNumericInput();
            //            if (frm.ShowDialog() == DialogResult.OK)
            //            {
            //                if (frm.SelectedValue > oiNew.Quantity)
            //                    return;
            //                else
            //                    oiNew.Quantity = frm.SelectedValue;
            //            } else
            //                return;
            //        } else
            //            oiNew.Quantity = 1;

            //        oiNew.OrderIID = odSourceTable.OrderToDisplay.IID;

            //        //Drop 1 from ordertosplit and save
            //        if (!odTargetTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Decrement((int)oiNew.Quantity))
            //            odTargetTable.OrderToDisplay.DeleteOrderItem(IID);

            //        //Ensure no zero quantity item left
            //        try
            //        {
            //            POSLayer.Models.OrderItem testItem = odTargetTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault();
            //            if (testItem != null)
            //            {
            //                if (testItem.Quantity == 0)
            //                    odTargetTable.OrderToDisplay.DeleteOrderItem(testItem.IID);
            //            }
            //        } catch { }


            //        await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);

            //        //Add new item to ordertodisplay and save
            //        odSourceTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);

            //        odSourceTable.Display();
            //        odTargetTable.Display();
            //    }
            //}
        }

        private async void btnTargetToSource_ALL_Click(object sender, EventArgs e)
        {
            //if (TargetTable != null  && TargetTable.AttachedOrder != null &&
            //   TargetTable.AttachedOrder.Items.Count == 1)
            //    return;

            //if (SourceTable != null && TargetTable != null && odSourceTable.OrderToDisplay != null && odTargetTable.OrderToDisplay != null)
            //{
            //    if (!string.IsNullOrEmpty(odTargetTable.SelectedItemIID))
            //    {
            //        //SplitOrder  to  DisplayOrder

            //        //Get Select listview item
            //        string IID = odTargetTable.SelectedItemIID;

            //        //Get copy of orderitem and set quantity 1 and parent order IID to new order iid
            //        POSLayer.Models.OrderItem oiNew = odTargetTable.OrderToDisplay.Items.Where(x => x.IID == IID).FirstOrDefault().Clone(false);
            //        //Because it is all
            //        //oiNew.Quantity = 1;
            //        oiNew.OrderIID = odSourceTable.OrderToDisplay.IID;

            //        //Drop 1 from ordertosplit and save
            //        odTargetTable.OrderToDisplay.DeleteOrderItem(IID);
            //        //if (!odSourceTable.OrderToDisplay.GetOrderItem(IID).Decrement((int)oiNew.Quantity))
            //        //    odSourceTable.OrderToDisplay.DeleteOrderItem(IID);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odTargetTable.OrderToDisplay);

            //        //Add new item to ordertodisplay and save
            //        odSourceTable.OrderToDisplay.AddIncrementOrderItem(oiNew);
            //        await DTRMSimpleBusiness.Instance.SaveOrder(odSourceTable.OrderToDisplay);

            //        odSourceTable.Display();
            //        odTargetTable.Display();
            //    }
            //}
        }

        private async void btnChangeTargetTableName_Click(object sender, EventArgs e)
        {
            //if (odTargetTable.OrderToDisplay != null)
            //{

            //    trmInput frm = new trmInput(TargetTable.TableName);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        TargetTable.TableName = frm.input;
            //        if (TargetTable.AttachedOrder != null)
            //            TargetTable.AttachedOrder.Table?.TableName = TargetTable.TableName;
            //        await DTRMSimpleBusiness.Instance.SaveTable(TargetTable);

            //        LoadTargetTable();
            //        await LoadTargetPanel();
            //        await LoadSourcePanel();
            //    }

            //}
        }
    }
}
