using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DTRMNS;

using POSLayer.Models;
using POSLayer.Repository.IRepository;
using POSLayer.Library;
using System.Threading.Tasks;

namespace DTRMSimpleBackOffice{
    /// <summary>
    /// Summary description for frmTables.
    /// </summary>
    public class frmTablesEditor : Form{

        IRepository<Salon> repoSalon;
        IRepository<Masa> repoTable;


        private Salon selectedSalon;
        private Panel pnlTables;
        private TableButton selectedTable;

        private int posx;
        private int posy;
        private Control ctrl;
        private FlowLayoutPanel pnlSalons;

        private int offsetx;
        private int offsety;
        private Panel lineHorizontal;
        private Panel lineVertical;
        private ToolStrip barTable;
        private ToolStripButton cmdAddTable;
        private ToolStripButton cmdEdit;
        private ToolStripButton cmdDelete;
        private ToolStripButton cmdSaveTable;
        private ToolStripButton cmdWidthIncrease;
        private ToolStripButton cmdWidthDecrease;
        private ToolStripButton cmdHeightIncrease;
        private ToolStripButton cmdHeightDecrease;
        private ToolStripButton cmdCancel;
        private ToolStripButton cmdShowHideSalonBar;
        private ToolStripButton cmdReloadTables;
        private ToolStripLabel lblTableInfo;
        private ToolStrip barSalon;
        private ToolStripButton cmdAddSalon;
        private ToolStripButton cmdEditSalon;
        private ToolStripButton cmdDeleteSalon;
        private ToolStripButton cmdExtendWidthOfSalon;
        private ToolStripButton cmdStrechWidthOfSalon;
        private ToolStripButton cmdExpandHeightOfSalon;
        private ToolStripButton cmdStrechHeightOfSalon;
        private ToolStripButton cmdReloadSalons;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        public frmTablesEditor() {
            InitializeComponent();

            repoSalon = ServiceHelper.GetService<IRepository<Salon>>();
            repoTable = ServiceHelper.GetService<IRepository<Masa>>();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablesEditor));
            pnlSalons = new FlowLayoutPanel();
            pnlTables = new Panel();
            lineVertical = new Panel();
            lineHorizontal = new Panel();
            barTable = new ToolStrip();
            cmdAddTable = new ToolStripButton();
            cmdEdit = new ToolStripButton();
            cmdDelete = new ToolStripButton();
            cmdSaveTable = new ToolStripButton();
            cmdWidthIncrease = new ToolStripButton();
            cmdWidthDecrease = new ToolStripButton();
            cmdHeightIncrease = new ToolStripButton();
            cmdHeightDecrease = new ToolStripButton();
            cmdCancel = new ToolStripButton();
            cmdShowHideSalonBar = new ToolStripButton();
            cmdReloadTables = new ToolStripButton();
            lblTableInfo = new ToolStripLabel();
            barSalon = new ToolStrip();
            cmdAddSalon = new ToolStripButton();
            cmdEditSalon = new ToolStripButton();
            cmdDeleteSalon = new ToolStripButton();
            cmdExtendWidthOfSalon = new ToolStripButton();
            cmdStrechWidthOfSalon = new ToolStripButton();
            cmdExpandHeightOfSalon = new ToolStripButton();
            cmdStrechHeightOfSalon = new ToolStripButton();
            cmdReloadSalons = new ToolStripButton();
            pnlTables.SuspendLayout();
            barTable.SuspendLayout();
            barSalon.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSalons
            // 
            pnlSalons.BackColor = Color.Black;
            pnlSalons.BorderStyle = BorderStyle.FixedSingle;
            pnlSalons.Dock = DockStyle.Top;
            pnlSalons.Location = new Point(0, 54);
            pnlSalons.Margin = new Padding(0);
            pnlSalons.Name = "pnlSalons";
            pnlSalons.Padding = new Padding(2);
            pnlSalons.Size = new Size(1170, 62);
            pnlSalons.TabIndex = 17;
            // 
            // pnlTables
            // 
            pnlTables.AllowDrop = true;
            pnlTables.BackColor = Color.Black;
            pnlTables.Controls.Add(lineVertical);
            pnlTables.Controls.Add(lineHorizontal);
            pnlTables.Dock = DockStyle.Fill;
            pnlTables.Location = new Point(0, 185);
            pnlTables.Name = "pnlTables";
            pnlTables.Size = new Size(1170, 609);
            pnlTables.TabIndex = 19;
            pnlTables.Click += pnlTables_Click;
            pnlTables.DragDrop += pnlTables_DragDrop;
            pnlTables.DragEnter += pnlTables_DragEnter;
            pnlTables.DragOver += pnlTables_DragOver;
            pnlTables.MouseUp += pnlTables_MouseUp;
            // 
            // lineVertical
            // 
            lineVertical.BackColor = Color.Silver;
            lineVertical.ForeColor = Color.Yellow;
            lineVertical.Location = new Point(300, 0);
            lineVertical.Name = "lineVertical";
            lineVertical.Size = new Size(10, 300);
            lineVertical.TabIndex = 1;
            lineVertical.Text = "line1";
            // 
            // lineHorizontal
            // 
            lineHorizontal.BackColor = Color.Silver;
            lineHorizontal.ForeColor = Color.Yellow;
            lineHorizontal.Location = new Point(0, 300);
            lineHorizontal.Name = "lineHorizontal";
            lineHorizontal.Size = new Size(300, 10);
            lineHorizontal.TabIndex = 0;
            lineHorizontal.Text = "line1";
            // 
            // barTable
            // 
            barTable.Items.AddRange(new ToolStripItem[] { cmdAddTable, cmdEdit, cmdDelete, cmdSaveTable, cmdWidthIncrease, cmdWidthDecrease, cmdHeightIncrease, cmdHeightDecrease, cmdCancel, cmdShowHideSalonBar, cmdReloadTables, lblTableInfo });
            barTable.Location = new Point(0, 116);
            barTable.Name = "barTable";
            barTable.Size = new Size(1170, 69);
            barTable.TabIndex = 51;
            barTable.Text = "toolStrip1";
            // 
            // cmdAddTable
            // 
            cmdAddTable.Image = Properties.Resources.arti32;
            cmdAddTable.ImageScaling = ToolStripItemImageScaling.None;
            cmdAddTable.ImageTransparentColor = Color.Magenta;
            cmdAddTable.Name = "cmdAddTable";
            cmdAddTable.Size = new Size(64, 66);
            cmdAddTable.Text = "Add Table";
            cmdAddTable.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdAddTable.Click += btnAddTable_Click;
            // 
            // cmdEdit
            // 
            cmdEdit.Image = Properties.Resources.MatReport_32;
            cmdEdit.ImageScaling = ToolStripItemImageScaling.None;
            cmdEdit.ImageTransparentColor = Color.Magenta;
            cmdEdit.Name = "cmdEdit";
            cmdEdit.Size = new Size(62, 66);
            cmdEdit.Text = "Edit Table";
            cmdEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdEdit.Click += btnEditTable_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Image = Properties.Resources.eksi32;
            cmdDelete.ImageScaling = ToolStripItemImageScaling.None;
            cmdDelete.ImageTransparentColor = Color.Magenta;
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(75, 66);
            cmdDelete.Text = "Delete Table";
            cmdDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdDelete.Click += btnDeleteTable_Click;
            // 
            // cmdSaveTable
            // 
            cmdSaveTable.Image = Properties.Resources.disket32;
            cmdSaveTable.ImageScaling = ToolStripItemImageScaling.None;
            cmdSaveTable.ImageTransparentColor = Color.Magenta;
            cmdSaveTable.Name = "cmdSaveTable";
            cmdSaveTable.Size = new Size(66, 66);
            cmdSaveTable.Text = "Save Table";
            cmdSaveTable.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdSaveTable.Click += btnUpdateTable_Click;
            // 
            // cmdWidthIncrease
            // 
            cmdWidthIncrease.Image = Properties.Resources.SquareArrowRightExpander32;
            cmdWidthIncrease.ImageScaling = ToolStripItemImageScaling.None;
            cmdWidthIncrease.ImageTransparentColor = Color.Magenta;
            cmdWidthIncrease.Name = "cmdWidthIncrease";
            cmdWidthIncrease.Size = new Size(84, 66);
            cmdWidthIncrease.Text = "Expand Width";
            cmdWidthIncrease.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdWidthIncrease.Click += btnWidthIncrease_Click;
            // 
            // cmdWidthDecrease
            // 
            cmdWidthDecrease.Image = Properties.Resources.SquareArrowLeftNarrower32;
            cmdWidthDecrease.ImageScaling = ToolStripItemImageScaling.None;
            cmdWidthDecrease.ImageTransparentColor = Color.Magenta;
            cmdWidthDecrease.Name = "cmdWidthDecrease";
            cmdWidthDecrease.Size = new Size(79, 66);
            cmdWidthDecrease.Text = "Strech Width";
            cmdWidthDecrease.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdWidthDecrease.Click += btnWidthDecrease_Click;
            // 
            // cmdHeightIncrease
            // 
            cmdHeightIncrease.Image = Properties.Resources.SquareArrowDownExpander32;
            cmdHeightIncrease.ImageScaling = ToolStripItemImageScaling.None;
            cmdHeightIncrease.ImageTransparentColor = Color.Magenta;
            cmdHeightIncrease.Name = "cmdHeightIncrease";
            cmdHeightIncrease.Size = new Size(88, 66);
            cmdHeightIncrease.Text = "Expand Height";
            cmdHeightIncrease.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdHeightIncrease.Click += btnHeightIncrease_Click;
            // 
            // cmdHeightDecrease
            // 
            cmdHeightDecrease.Image = Properties.Resources.SquareArrowUpNarrower32;
            cmdHeightDecrease.ImageScaling = ToolStripItemImageScaling.None;
            cmdHeightDecrease.ImageTransparentColor = Color.Magenta;
            cmdHeightDecrease.Name = "cmdHeightDecrease";
            cmdHeightDecrease.Size = new Size(83, 66);
            cmdHeightDecrease.Text = "Strech Height";
            cmdHeightDecrease.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdHeightDecrease.Click += btnHeightDecrease_Click;
            // 
            // cmdCancel
            // 
            cmdCancel.Image = Properties.Resources.Cancel;
            cmdCancel.ImageScaling = ToolStripItemImageScaling.None;
            cmdCancel.ImageTransparentColor = Color.Magenta;
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(40, 66);
            cmdCancel.Text = "Close";
            cmdCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // cmdShowHideSalonBar
            // 
            cmdShowHideSalonBar.Image = Properties.Resources.eye32;
            cmdShowHideSalonBar.ImageScaling = ToolStripItemImageScaling.None;
            cmdShowHideSalonBar.ImageTransparentColor = Color.Magenta;
            cmdShowHideSalonBar.Name = "cmdShowHideSalonBar";
            cmdShowHideSalonBar.Size = new Size(73, 66);
            cmdShowHideSalonBar.Text = "Show/HIde \r\nSalon Bar";
            cmdShowHideSalonBar.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdShowHideSalonBar.Click += btnShowHideSalonBar_Click;
            // 
            // cmdReloadTables
            // 
            cmdReloadTables.Image = Properties.Resources.Reload_32;
            cmdReloadTables.ImageScaling = ToolStripItemImageScaling.None;
            cmdReloadTables.ImageTransparentColor = Color.Magenta;
            cmdReloadTables.Name = "cmdReloadTables";
            cmdReloadTables.Size = new Size(87, 66);
            cmdReloadTables.Text = "ReDraw Tables";
            cmdReloadTables.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdReloadTables.Click += btnReloadTables_Click;
            // 
            // lblTableInfo
            // 
            lblTableInfo.Name = "lblTableInfo";
            lblTableInfo.Size = new Size(0, 66);
            // 
            // barSalon
            // 
            barSalon.Items.AddRange(new ToolStripItem[] { cmdAddSalon, cmdEditSalon, cmdDeleteSalon, cmdExtendWidthOfSalon, cmdStrechWidthOfSalon, cmdExpandHeightOfSalon, cmdStrechHeightOfSalon, cmdReloadSalons });
            barSalon.Location = new Point(0, 0);
            barSalon.Name = "barSalon";
            barSalon.Size = new Size(1170, 54);
            barSalon.TabIndex = 52;
            barSalon.Text = "toolStrip1";
            // 
            // cmdAddSalon
            // 
            cmdAddSalon.Image = Properties.Resources.arti32;
            cmdAddSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdAddSalon.ImageTransparentColor = Color.Magenta;
            cmdAddSalon.Name = "cmdAddSalon";
            cmdAddSalon.Size = new Size(65, 51);
            cmdAddSalon.Text = "Add Salon";
            cmdAddSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdAddSalon.Click += btnAddSalon_Click;
            // 
            // cmdEditSalon
            // 
            cmdEditSalon.Image = Properties.Resources.MatReport_32;
            cmdEditSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdEditSalon.ImageTransparentColor = Color.Magenta;
            cmdEditSalon.Name = "cmdEditSalon";
            cmdEditSalon.Size = new Size(63, 51);
            cmdEditSalon.Text = "Edit Salon";
            cmdEditSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdEditSalon.Click += btnEditSalon_Click;
            // 
            // cmdDeleteSalon
            // 
            cmdDeleteSalon.Image = Properties.Resources.eksi32;
            cmdDeleteSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdDeleteSalon.ImageTransparentColor = Color.Magenta;
            cmdDeleteSalon.Name = "cmdDeleteSalon";
            cmdDeleteSalon.Size = new Size(76, 51);
            cmdDeleteSalon.Text = "Delete Salon";
            cmdDeleteSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdDeleteSalon.Click += btnDeleteSalon_Click;
            // 
            // cmdExtendWidthOfSalon
            // 
            cmdExtendWidthOfSalon.Image = Properties.Resources.SquareArrowRightExpander32;
            cmdExtendWidthOfSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdExtendWidthOfSalon.ImageTransparentColor = Color.Magenta;
            cmdExtendWidthOfSalon.Name = "cmdExtendWidthOfSalon";
            cmdExtendWidthOfSalon.Size = new Size(84, 51);
            cmdExtendWidthOfSalon.Text = "Expand Width";
            cmdExtendWidthOfSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdExtendWidthOfSalon.Click += btnExpandWidhtOfSalon_Click;
            // 
            // cmdStrechWidthOfSalon
            // 
            cmdStrechWidthOfSalon.Image = Properties.Resources.SquareArrowLeftNarrower32;
            cmdStrechWidthOfSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdStrechWidthOfSalon.ImageTransparentColor = Color.Magenta;
            cmdStrechWidthOfSalon.Name = "cmdStrechWidthOfSalon";
            cmdStrechWidthOfSalon.Size = new Size(79, 51);
            cmdStrechWidthOfSalon.Text = "Strech Width";
            cmdStrechWidthOfSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdStrechWidthOfSalon.Click += btnStrechWidthOfSalon_Click;
            // 
            // cmdExpandHeightOfSalon
            // 
            cmdExpandHeightOfSalon.Image = Properties.Resources.SquareArrowDownExpander32;
            cmdExpandHeightOfSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdExpandHeightOfSalon.ImageTransparentColor = Color.Magenta;
            cmdExpandHeightOfSalon.Name = "cmdExpandHeightOfSalon";
            cmdExpandHeightOfSalon.Size = new Size(88, 51);
            cmdExpandHeightOfSalon.Text = "Expand Height";
            cmdExpandHeightOfSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdExpandHeightOfSalon.Click += btnExpandHeightOfSalon_Click;
            // 
            // cmdStrechHeightOfSalon
            // 
            cmdStrechHeightOfSalon.Image = Properties.Resources.SquareArrowUpNarrower32;
            cmdStrechHeightOfSalon.ImageScaling = ToolStripItemImageScaling.None;
            cmdStrechHeightOfSalon.ImageTransparentColor = Color.Magenta;
            cmdStrechHeightOfSalon.Name = "cmdStrechHeightOfSalon";
            cmdStrechHeightOfSalon.Size = new Size(83, 51);
            cmdStrechHeightOfSalon.Text = "Strech Height";
            cmdStrechHeightOfSalon.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdStrechHeightOfSalon.Click += btnStrechHeightOfSalon_Click;
            // 
            // cmdReloadSalons
            // 
            cmdReloadSalons.Image = Properties.Resources.Refresh_2;
            cmdReloadSalons.ImageScaling = ToolStripItemImageScaling.None;
            cmdReloadSalons.ImageTransparentColor = Color.Magenta;
            cmdReloadSalons.Name = "cmdReloadSalons";
            cmdReloadSalons.Size = new Size(47, 51);
            cmdReloadSalons.Text = "Reload";
            cmdReloadSalons.TextImageRelation = TextImageRelation.ImageAboveText;
            cmdReloadSalons.Click += cmdReloadSalons_Click;
            // 
            // frmTablesEditor
            // 
            AutoScroll = true;
            ClientSize = new Size(1170, 794);
            Controls.Add(pnlTables);
            Controls.Add(barTable);
            Controls.Add(pnlSalons);
            Controls.Add(barSalon);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTablesEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TABLE EDITOR";
            WindowState = FormWindowState.Maximized;
            Load += frmTablesEditor_Load;
            pnlTables.ResumeLayout(false);
            barTable.ResumeLayout(false);
            barTable.PerformLayout();
            barSalon.ResumeLayout(false);
            barSalon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        private async void frmTablesEditor_Load(object sender, System.EventArgs e) {
          await  LoadSalons();

            //Adjust canvas size to maximum ctltable area - this works if office used on the same computer as DTRM
            //pnlTables.Width = Screen.PrimaryScreen.WorkingArea.Width - 410;
            //pnlTables.Height = Screen.PrimaryScreen.WorkingArea.Height - 180;


        }

        private async Task LoadTables() {
            if (selectedSalon == null)
                return;

            pnlTables.Controls.Clear();

            Panel pnl = new Panel();
            pnl.BackColor = Color.FromArgb(selectedSalon.SalonColour);
            pnl.Width = selectedSalon.Width;
            pnl.Height = selectedSalon.Height;

            pnlTables.Controls.Add(pnl);

            List<Masa> tablelist =await repoTable.GetListByField("SalonIID",selectedSalon.IID);

            TableButton tb;

            Panel lineHorizontal = new Panel();
            lineHorizontal.Size = new Size(selectedSalon.Width, 5);
            lineHorizontal.Location = new Point(0, selectedSalon.Height);
            lineHorizontal.BackColor = Color.Silver;
            pnl.Controls.Add(lineHorizontal);

            Panel lineVertical = new Panel();
            lineVertical.Size = new Size(5, selectedSalon.Height);
            lineVertical.Location = new Point(selectedSalon.Width, 0);
            lineVertical.BackColor = Color.Silver;
            pnl.Controls.Add(lineVertical);

            foreach (Masa table in tablelist)
            {
                tb = new TableButton()
                {
                    Table = table
                };
                //this is required because designer make the changes to defaultname not the tablename
                tb.Text = table.DefaultName;
                tb.Location = new Point(table.XLocation, table.YLocation);
                tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
                tb.Size = new Size(table.Width, table.Height);
                tb.FlatStyle = FlatStyle.Flat;
                tb.FlatAppearance.BorderColor = Color.Yellow;
                tb.FlatAppearance.BorderSize = 0;
                tb.BackColor = Color.DarkGreen;
                tb.ForeColor = Color.White;
                
                pnl.Controls.Add(tb);
            }
           

            selectedTable = null;


        }
     
        private async Task SaveSelectedTable() {
            if (selectedTable != null) {
                Masa table = await repoTable.Get(selectedTable.Table.IID);
                if (table != null) {
                    table.TableCovers = 1;
                    table.XLocation = selectedTable.Location.X;
                    table.YLocation = selectedTable.Location.Y;
                    table.Width = selectedTable.Width;
                    table.Height = selectedTable.Height;
                    await repoTable.Save(table);

                    posx = 0;
                    posy = 0;
                }
            }
            else
                MessageBox.Show("failed to save");
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            Close();
        }



        #region "DRAG DROP EVENTS"
        //bool blnDragging = false;
        private void pnlTables_DragDrop(object sender, DragEventArgs e) {
           
            if (this.posx == 0 || this.posy == 0)
                return;
            Point clientp = this.pnlTables.PointToClient(new Point(e.X, e.Y));
            int x = clientp.X - offsetx;
            int y = clientp.Y - offsety;
            if ((x + ctrl.Width > selectedSalon.Width) || (y + ctrl.Height > selectedSalon.Height))
                return;

            ctrl.SetBounds(x,y, ctrl.Width, ctrl.Height);

            if (selectedTable == null)
                selectedTable = (TableButton)ctrl;
            else
                btnUpdateTable_Click(null, null);
        }

        private void pnlTables_DragEnter(object sender, DragEventArgs e) {
            
            if ((e.X + ctrl.Width >= selectedSalon.Width) || (e.Y + ctrl.Height >= selectedSalon.Height))
                return;
            e.Effect = DragDropEffects.Move;
        }

        private void pnlTables_DragOver(object sender, DragEventArgs e) {
            Point clientp = this.pnlTables.PointToClient(new Point(e.X, e.Y));
            this.posx = clientp.X;
            this.posy = clientp.Y;

            int x = clientp.X - offsetx;
            int y = clientp.Y - offsety;
            if ((x + ctrl.Width >= selectedSalon.Width) || (y + ctrl.Height >= selectedSalon.Height))
                return;
            
            ctrl.SetBounds(x, y, ctrl.Width, ctrl.Height);
        }

        private void Table_MouseDown(object sender, MouseEventArgs e) {
            if (this.selectedTable != null)
                selectedTable.FlatAppearance.BorderSize = 0;
            selectedTable = (TableButton) sender;
            selectedTable.FlatAppearance.BorderSize = 1;

            if (e.Button == MouseButtons.Right) {
                btnEditTable_Click(sender, e);
            }
            else {
                ctrl = (Control) sender;

                offsetx = e.X;
                offsety = e.Y;
                DoDragDrop(ctrl, DragDropEffects.Move);
                UpdateTableInfo();
            }
        }

        #endregion

        #region RESIZE TABLE DIMENSIONS
        private void UpdateTableInfo() {
            if (selectedTable != null)
                lblTableInfo.Text = selectedTable.Text + ", X=" + selectedTable.Location.X + ", Y=" + selectedTable.Location.Y + ", Width=" + selectedTable.Width + ", Height=" + selectedTable.Height;
            else
                lblTableInfo.Text = "";
        }
        private void btnWidthIncrease_Click(object sender, EventArgs e) {
            if (selectedTable == null)
                return;
            if (selectedTable.Width < pnlTables.Width - selectedTable.Location.X)
                selectedTable.Width += 10;
            UpdateTableInfo();
            SaveSelectedTable();
        }

        private void btnWidthDecrease_Click(object sender, EventArgs e) {
            if (selectedTable == null)
                return;
            if (selectedTable.Width > 40)
                selectedTable.Width -= 10;
            UpdateTableInfo();
            SaveSelectedTable();
        }

        private void btnHeightIncrease_Click(object sender, EventArgs e) {
            if (selectedTable == null)
                return;
            if (selectedTable.Height < pnlTables.Height - selectedTable.Location.Y)
                selectedTable.Height += 10;
            UpdateTableInfo();
            SaveSelectedTable();
        }

        private void btnHeightDecrease_Click(object sender, EventArgs e) {
            if (selectedTable == null)
                return;
            if (selectedTable.Height > 40)
                selectedTable.Height -= 10;
            UpdateTableInfo();
            SaveSelectedTable();
        }

        #endregion

        private async void btnAddTable_Click(object sender, System.EventArgs e) {
            Masa tb = new Masa();
            tb.SalonIID = selectedSalon.IID;
            await repoTable.Save(tb);
           await LoadTables();
        }
        
        private async void btnEditTable_Click(object sender, EventArgs e) {
            if (selectedTable == null)
                return;
            
            Masa table = await repoTable.Get(selectedTable.Table.IID);

            frmTable frm = new frmTable(table);
            if (frm.ShowDialog() == DialogResult.OK) {
               await  LoadTables();
            }
        }

        private async void btnUpdateTable_Click(object sender, System.EventArgs e) {
            if (selectedTable != null) {
              await  SaveSelectedTable();
                //SaveSelectedTable();
                //LoadTables();
            }
        }

        private async void btnDeleteTable_Click(object sender, EventArgs e) {
            if (selectedTable != null) {
                if (
                    MessageBox.Show("This will delete the table\nDo you want to continue", "Delete Table",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                  await repoTable.Delete(selectedTable.Table.IID);
                  await  LoadTables();
                }
            }
        }


        #region SALON BUTTON FUNCTIONS
        private async void btnAddSalon_Click(object sender, EventArgs e) {
            frmSalon frm = new frmSalon(new Salon());
            if (frm.ShowDialog() == DialogResult.OK) {
                if (await repoSalon.Save(frm.salon) != null)
                  await  LoadSalons();
            }            
        }

        private async Task LoadSalons() {
            pnlSalons.Controls.Clear();
            pnlTables.Controls.Clear();

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
                btn.Text = salon.SalonName; // dt.Rows[i]["SalonName"].ToString();
                btn.Tag = salon; // dt.Rows[i]["IID"].ToString();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = Color.Red;
                btn.MouseDown += salonBtn_MouseDown;

                pnlSalons.Controls.Add(btn);
                btn.Dock = DockStyle.Top;
            }
            bool chk = false;
            for (int i = 0; i < pnlSalons.Controls.Count; i++) {
                RadioButton rb = (RadioButton) pnlSalons.Controls[i];
                if (rb.Checked) {
                    chk = true;
                    break;
                }
            }
            if (!chk && pnlSalons.Controls.Count > 0)
                ((RadioButton) pnlSalons.Controls[0]).Checked = true;
        }

        private void salonBtn_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                btnEditSalon_Click(sender,e);
        }

        private async void SalonButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rb = (RadioButton) sender;
            if (rb.Checked) {
                //UnloadTableDetails(false);
                selectedSalon = (Salon)rb.Tag;
              await  LoadTables();
            }
        }


        private async void btnEditSalon_Click(object sender, EventArgs e) {
            // TableSalon tg = bslayer.GetTableSalon(selectedSalon.);
            if (selectedSalon == null)
                return;
            frmSalon frm = new frmSalon(selectedSalon);
            if (frm.ShowDialog() == DialogResult.OK) {
                
              await  LoadSalons();
            }
        }

        private async void btnDeleteSalon_Click(object sender, EventArgs e) {
            if (selectedSalon == null)
                return;
            if (
                MessageBox.Show("This will delete the salon and all it's tables.\nDo you want to continue", "Delete Table Salon",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                await repoSalon.Delete(selectedSalon);
               await LoadSalons();
            }
        }

        #endregion

        private void btnShowHideSalonBar_Click(object sender, EventArgs e) {
            barSalon.Visible = pnlSalons.Visible = !barSalon.Visible;

        }

        private void pnlTables_MouseUp(object sender, MouseEventArgs e) {
       
        }

        private async void btnExpandWidhtOfSalon_Click(object sender, EventArgs e) {
            if (selectedSalon != null) {
                selectedSalon.Width += 50;
                lineVertical.Left += 50;
               await repoSalon.Save(selectedSalon);
              await  LoadTables();
            }
        }

        private async void btnStrechWidthOfSalon_Click(object sender, EventArgs e) {
            if (selectedSalon != null && selectedSalon.Width >= 100) {
                selectedSalon.Width -= 50;
                lineVertical.Left -= 50;
                await repoSalon.Save(selectedSalon);
                await LoadTables();
            }
        }

        private async void btnExpandHeightOfSalon_Click(object sender, EventArgs e) {
            if (selectedSalon != null) {
                selectedSalon.Height += 50;
                lineHorizontal.Top += 50;
                await repoSalon.Delete(selectedSalon);
               await LoadTables();
            }
        }

        private async void btnStrechHeightOfSalon_Click(object sender, EventArgs e) {
            if (selectedSalon != null && selectedSalon.Height >= 100) {
                selectedSalon.Height -= 50;
                lineHorizontal.Top -= 50;
                await repoSalon.Save(selectedSalon);
               await LoadTables();
            }
        }

        private async void btnReloadTables_Click(object sender, EventArgs e) {
          await  LoadTables();
        }

        private void pnlTables_Click(object sender, EventArgs e) {
            if (selectedTable != null) {
                selectedTable.FlatAppearance.BorderSize = 0;
                selectedTable = null;
            }
        }


        private async void cmdReloadSalons_Click(object sender, EventArgs e) {
         await   LoadSalons();
        }
    }
}
