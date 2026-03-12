using System.Windows.Forms;

namespace DTRMNS {
    public partial class ctlPrep : UserControl {
        DTRMSimpleBusiness bslayer;
        KitchenOrder korder;

        public ctlPrep() {
            InitializeComponent();
        }
        public void Initilise(DTRMSimpleBusiness bslayer, KitchenOrder korder) {
            this.bslayer = bslayer;
            this.korder = korder;
            LoadKitchenOrder();
        }

        private void LoadKitchenOrder() {
            dgv.DataSource = korder.items;

            for (int i=0; i < korder.items.Count; i++) {
                if (korder.items[i].Status == KitchenOrderStatusTypes.Completed)
                    dgv.Rows[i].Cells[4].Value = (System.Drawing.Image)Properties.Resources.okay;
            }

           
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell cellTick = dgv.Rows[e.RowIndex].Cells[4] as DataGridViewImageCell;
            KitchenOrderItem koi = (KitchenOrderItem)korder.items[e.RowIndex];
            POSLayer.Models.OrderItem oi = null;

            switch (e.ColumnIndex)
            {
                case 5:
                    //Large All                    
                    if (koi.Modified == ModificationFlag.None && koi.Status == KitchenOrderStatusTypes.Waiting && koi.Quantity > 1)
                    {
                        int lq = koi.Quantity / 2;
                        int sq = koi.Quantity % 2;
                        if (sq > 0)
                            koi.ItemText = "(" + lq + " Large + " + sq + ") " + koi.ItemText;
                        else
                            koi.ItemText = "(" + lq + " Large) " + koi.ItemText;
                        dgv.Rows[e.RowIndex].Cells["colItemText"].Value = koi.ItemText;
                        dgv.Refresh();
                        //koi.Modified = ModificationFlag.Completed;
                        //koi.ModifiedQuantity = koi.Quantity;

                        oi = bslayer.AttachedOrder.items.Find(x => x.EntityButtonIID == koi.EntityButtonIID);
                        oi.OrderItemText = koi.ItemText;
                        bslayer.SaveOrderItem(oi);
                    }
                    break;
                case 6:
                    //Large qty
                    if (koi.Modified == ModificationFlag.None && koi.Status == KitchenOrderStatusTypes.Waiting && koi.Quantity > 1)
                    {
                        frmNumericInput frm = new frmNumericInput();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            
                            int lq = koi.Quantity / 2;
                            int sq = koi.Quantity % 2;
                            if (frm.SelectedValue > lq)
                                break;
                            else
                            {
                                if (frm.SelectedValue * 2 < koi.Quantity)
                                    koi.ItemText = "(" + frm.SelectedValue + " Large + " + (koi.Quantity - (frm.SelectedValue * 2)) + ") " + koi.ItemText;
                                else
                                    koi.ItemText = "(" + frm.SelectedValue + " Large) " + koi.ItemText;
                                dgv.Rows[e.RowIndex].Cells["colItemText"].Value = koi.ItemText;
                                dgv.Refresh();
                                //koi.Modified = ModificationFlag.Completed;
                                //koi.ModifiedQuantity = koi.Quantity;

                                oi = bslayer.AttachedOrder.items.Find(x => x.EntityButtonIID == koi.EntityButtonIID);
                                oi.OrderItemText = koi.ItemText;
                                bslayer.SaveOrderItem(oi);
                            }
                        }
                    }
                    break;
                case 7:
                    //Variables
                    if (koi.Modified != ModificationFlag.Completed && koi.Status == KitchenOrderStatusTypes.Waiting && koi.Quantity > 0) { 
                    //if ( koi.Status == KitchenOrderStatusTypes.Waiting && koi.Quantity > 0) {
                        /* Here add custom variable Text*/
                        frmVariables frm = new frmVariables(bslayer, koi);
                        
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            dgv.Rows[e.RowIndex].Cells["colItemText"].Value = koi.ItemText.Replace("&&","&");
                            dgv.Refresh();

                            //OrderItem oi = bslayer.AttachedOrder.items.Find(x => x.EntityButtonIID == koi.EntityButtonIID);
                            //oi.OrderItemText = koi.ItemText;
                            //bslayer.SaveOrderItem(oi);
                        }
                    }
                    break;
                case 8:
                    //Cancel
                    koi.ItemText = bslayer.GetJustEntityButton(koi.EntityButtonIID).EntityButtonName;
                    koi.Modified = ModificationFlag.None;
                    koi.ModifiedQuantity = 0;
                    dgv.Rows[e.RowIndex].Cells["colItemText"].Value = koi.ItemText;
                    dgv.Refresh();

                    oi = bslayer.AttachedOrder.items.Find(x => x.EntityButtonIID == koi.EntityButtonIID);
                    oi.OrderItemText = koi.ItemText;
                    bslayer.SaveOrderItem(oi);
                    break;
                default:

                    if ( koi.Status == KitchenOrderStatusTypes.Waiting)
                    {
                        koi.Status = KitchenOrderStatusTypes.Completed;
                        cellTick.Value = (System.Drawing.Image)Properties.Resources.okay;
                    } else
                    {
                        koi.Status = KitchenOrderStatusTypes.Waiting;
                        cellTick.Value = (System.Drawing.Image)Properties.Resources.chef64;
                    }
                    break;
            }
        }




        public void ChangeStatus() {
            KitchenOrderStatusTypes orderStatus = korder.GetStatus();
            KitchenOrderStatusTypes newStatus = KitchenOrderStatusTypes.Waiting;
            switch (orderStatus) {
                case KitchenOrderStatusTypes.Waiting:
                case KitchenOrderStatusTypes.PartialyCompleted:
                    newStatus = KitchenOrderStatusTypes.Completed;
                    break;
                case KitchenOrderStatusTypes.Completed:
                    newStatus = KitchenOrderStatusTypes.Waiting;
                    break;
                default:
                    newStatus = KitchenOrderStatusTypes.Completed;
                    break;
            }


           

            for (int i = 0; i < dgv.Rows.Count; i++) {
                DataGridViewImageCell cellTick = dgv.Rows[i].Cells[4] as DataGridViewImageCell;
                KitchenOrderItem koi = (KitchenOrderItem)korder.items[i];
                koi.Status = newStatus;

                if (newStatus== KitchenOrderStatusTypes.Completed)                     
                    cellTick.Value = (System.Drawing.Image)Properties.Resources.okay;
                else
                    cellTick.Value = (System.Drawing.Image)Properties.Resources.chef64;
                
            }
        }
    }
}
