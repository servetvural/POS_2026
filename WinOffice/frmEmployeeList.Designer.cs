using POSLayer.Models;

namespace WinOffice {
    partial class frmEmployeeList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdEdit = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.cmdReload = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lvwEmployee = new System.Windows.Forms.ListView();
            this.colImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colShortable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDelete,
            this.cmdReload,
            this.btnView,
            this.btnExportAsJson,
            this.btnImportFromJson});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(968, 54);
            this.barMain.TabIndex = 48;
            this.barMain.Text = "toolStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::WinOffice.Properties.Resources.arti32;
            this.cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(60, 51);
            this.cmdAdd.Text = "Add New";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Image = global::WinOffice.Properties.Resources.MatReport_32;
            this.cmdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(36, 51);
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Image = global::WinOffice.Properties.Resources.eksi32;
            this.cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(44, 51);
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Image = global::WinOffice.Properties.Resources.Reload_32;
            this.cmdReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(47, 51);
            this.cmdReload.Text = "Reload";
            this.cmdReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnView
            // 
            this.btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLargeIcon,
            this.btnSmallIcon,
            this.btnDetails,
            this.btnList,
            this.btnTile});
            this.btnView.Image = global::WinOffice.Properties.Resources.eye32;
            this.btnView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 51);
            this.btnView.Text = "View";
            // 
            // btnLargeIcon
            // 
            this.btnLargeIcon.Name = "btnLargeIcon";
            this.btnLargeIcon.Size = new System.Drawing.Size(157, 22);
            this.btnLargeIcon.Text = "Large Icon View";
            this.btnLargeIcon.Click += new System.EventHandler(this.btnLargeIcon_Click);
            // 
            // btnSmallIcon
            // 
            this.btnSmallIcon.Name = "btnSmallIcon";
            this.btnSmallIcon.Size = new System.Drawing.Size(157, 22);
            this.btnSmallIcon.Text = "Small Icon View";
            this.btnSmallIcon.Click += new System.EventHandler(this.btnSmallIcon_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(157, 22);
            this.btnDetails.Text = "Details View ";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnList
            // 
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(157, 22);
            this.btnList.Text = "List View";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnTile
            // 
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(157, 22);
            this.btnTile.Text = "Tile View";
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // btnExportAsJson
            // 
            this.btnExportAsJson.Image = global::WinOffice.Properties.Resources.SquareArrowRightExpander32;
            this.btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportAsJson.Name = "btnExportAsJson";
            this.btnExportAsJson.Size = new System.Drawing.Size(75, 51);
            this.btnExportAsJson.Text = "JSON Export";
            this.btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportAsJson.Click += new System.EventHandler(this.btnExportAsJson_Click);
            // 
            // btnImportFromJson
            // 
            this.btnImportFromJson.Image = global::WinOffice.Properties.Resources.SquareArrowLeftNarrower32;
            this.btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromJson.Name = "btnImportFromJson";
            this.btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            this.btnImportFromJson.Text = "JSON Import";
            this.btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportFromJson.Click += new System.EventHandler(this.btnImportFromJson_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 587);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(968, 70);
            this.panel1.TabIndex = 49;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(708, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "CANCEL";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelect.Location = new System.Drawing.Point(833, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 50);
            this.btnSelect.TabIndex = 43;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImage,
            this.colEmployeeName,
            this.colRate,
            this.colShortable});
            this.lvwEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEmployee.HideSelection = false;
            this.lvwEmployee.LargeImageList = this.imgList;
            this.lvwEmployee.Location = new System.Drawing.Point(0, 54);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.Size = new System.Drawing.Size(968, 533);
            this.lvwEmployee.SmallImageList = this.imgList;
            this.lvwEmployee.TabIndex = 51;
            this.lvwEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwEmployee_MouseDoubleClick);
            // 
            // colImage
            // 
            this.colImage.Text = "";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Text = "Employee";
            this.colEmployeeName.Width = 300;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            this.colRate.Width = 100;
            // 
            // colShortable
            // 
            this.colShortable.Text = "Shortable";
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(50, 50);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Employee);
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 657);
            this.Controls.Add(this.lvwEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barMain);
            this.Name = "frmEmployeeList";
            this.Text = "EMPLOYEE LIST";
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton cmdAdd;
        private System.Windows.Forms.ToolStripButton cmdEdit;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripButton cmdReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ListView lvwEmployee;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ToolStripDropDownButton btnView;
        private System.Windows.Forms.ToolStripMenuItem btnLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem btnSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem btnDetails;
        private System.Windows.Forms.ToolStripMenuItem btnList;
        private System.Windows.Forms.ToolStripMenuItem btnTile;
        private System.Windows.Forms.ColumnHeader colImage;
        private System.Windows.Forms.ColumnHeader colEmployeeName;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colShortable;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
    }
}