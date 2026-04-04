using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

using PosLibrary;

namespace DTRMNS
{
    public partial class frmSubTableSelector : Form
    {
        PosConfig config;
        IRepository<Masa> repoTable;

        private string rootTableIID;
        private GenericEventHandler ButtonClickHandler;
        private List<Masa> tablelist;
        private TableButton SourceTable;

        private TableButton sourceMergeTable;

        public frmSubTableSelector(PosConfig configAsService, IRepository<Masa> _repoTable, string rootTableIID, GenericEventHandler ButtonClickHandler)
        {
            InitializeComponent();
            config = configAsService;
            repoTable = _repoTable;

            this.rootTableIID = rootTableIID;
            this.ButtonClickHandler = ButtonClickHandler;

        }

        private void frmSubTableSelector_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            tablelist = DTRMSimpleBusiness.Instance.GetTableAndSubTables(rootTableIID).Result;

            pnlTables.Controls.Clear();

            Masa table;
            string locker = "";
            int busyTableCounter = 0;
            for (int i = 0; i < tablelist.Count; i++)
            {
                table = tablelist[i];

                if (table.LockedClientIP != null && table.LockedClientIP != "")
                    locker = table.LockedClientIP;

                TableButton btn = new TableButton();
                btn.Text = table.TableName;
                btn.IID = table.IID;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                if (locker.Length > 0)
                {
                    btn.BackColor = Color.DarkBlue; // DTRMSimpleBusiness.Instance.config.Table_Busy_Back_Color;  // Color.DarkBlue;
                    btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Busy_Text_Color;
                    busyTableCounter++;
                } else
                {
                    if (table.HasActiveOrder())
                    {
                        btn.BackColor = Color.DarkRed; //  DTRMSimpleBusiness.Instance.config.Table_Full_Back_Color; //  Color.DarkRed;
                        btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Full_Text_Color;
                        busyTableCounter++;
                    } else
                    {
                        btn.BackColor = Color.DarkGreen;
                        //  DTRMSimpleBusiness.Instance.config.Table_Free_Back_Color; // SystemColors.ControlDarkDark;
                        btn.ForeColor = Color.White; //  DTRMSimpleBusiness.Instance.config.Table_Free_Text_Color;
                    }
                }
                btn.Location = new Point(table.XLocation, table.YLocation);
                btn.Size = new Size(150, 90);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.MouseDown += Btn_MouseDown;
                pnlTables.Controls.Add(btn);
                locker = "";
            }
            if (busyTableCounter == 0)
                this.Close();
        }

        private async void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TableButton tableButton = (TableButton)sender;
                Masa table = await DTRMSimpleBusiness.Instance.GetTable(tableButton.IID);                
                    return;                               
            }
        }                      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task btnPrintAllTables_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tablelist.Count; i++)
            {
                if (string.IsNullOrEmpty(config.DTClientLocalReceiptPrinterIID))
                {
                    await DTRMSimpleBusiness.Instance.PrintEntireOrder(tablelist[i].AttachedOrder, true, false, 1, config.DTClientLocalReceiptPrinterIID);
                    if (config.Force_Receipt_Printer_To_Cut)
                        DRShell.SendCutCommandToUSBPrinter(DTRMSimpleBusiness.Instance.GetPrinterForClient(config.DTClientLocalReceiptPrinterIID).Result.NetworkName);
                }
            }
        }

        private async void btnJoinAllTables_Click(object sender, EventArgs e)
        {
            Masa primaryTable = await DTRMSimpleBusiness.Instance.BarrowTable(rootTableIID);
            for (int i = 0; i < tablelist.Count; i++)
            {
                if (tablelist[i].IID != rootTableIID)
                    DTRMSimpleBusiness.Instance.MergeTable(tablelist[i].IID, rootTableIID);
            }
            Close();
        }

    }
}
