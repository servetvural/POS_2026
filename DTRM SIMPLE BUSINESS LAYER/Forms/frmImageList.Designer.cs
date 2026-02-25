namespace DTRMNS {
    partial class frmImageList {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lvwImages = new System.Windows.Forms.ListView();
            this.colImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtraText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dimensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgLoader = new System.ComponentModel.BackgroundWorker();
            this.barMain = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnExportImage = new System.Windows.Forms.ToolStripButton();
            this.btnExportAsXML = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromXML = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXLView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXXLView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetWidthTo = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSetWidth = new System.Windows.Forms.ToolStripTextBox();
            this.mnuSetHeightTo = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSetHeight = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.genericImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.barMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genericImageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnZoom);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1033, 70);
            this.panel1.TabIndex = 46;
            // 
            // btnZoom
            // 
            this.btnZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnZoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoom.Location = new System.Drawing.Point(523, 10);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(125, 50);
            this.btnZoom.TabIndex = 45;
            this.btnZoom.Text = "ZOOM";
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.Location = new System.Drawing.Point(648, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 50);
            this.btnSelect.TabIndex = 44;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(773, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "CANCEL";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.Location = new System.Drawing.Point(898, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(50, 50);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvwImages
            // 
            this.lvwImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImage,
            this.ImageFileName,
            this.ExtraText,
            this.Dimensions,
            this.colWidth,
            this.colHeight,
            this.colSize});
            this.lvwImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwImages.FullRowSelect = true;
            this.lvwImages.GridLines = true;
            this.lvwImages.HideSelection = false;
            this.lvwImages.LargeImageList = this.imgList;
            this.lvwImages.Location = new System.Drawing.Point(0, 54);
            this.lvwImages.Name = "lvwImages";
            this.lvwImages.ShowItemToolTips = true;
            this.lvwImages.Size = new System.Drawing.Size(1033, 463);
            this.lvwImages.SmallImageList = this.imgList;
            this.lvwImages.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwImages.TabIndex = 51;
            this.lvwImages.UseCompatibleStateImageBehavior = false;
            this.lvwImages.View = System.Windows.Forms.View.Tile;
            this.lvwImages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwImages_MouseDoubleClick);
            this.lvwImages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwImages_MouseDown);
            // 
            // colImage
            // 
            this.colImage.Text = "";
            // 
            // ImageFileName
            // 
            this.ImageFileName.Text = "File Name";
            this.ImageFileName.Width = 300;
            // 
            // ExtraText
            // 
            this.ExtraText.Text = "Image Text";
            this.ExtraText.Width = 100;
            // 
            // Dimensions
            // 
            this.Dimensions.Text = "Dimensions";
            this.Dimensions.Width = 100;
            // 
            // colWidth
            // 
            this.colWidth.Text = "Width";
            // 
            // colHeight
            // 
            this.colHeight.Text = "Height";
            // 
            // colSize
            // 
            this.colSize.Text = "Size (KB)";
            // 
            // bgLoader
            // 
            this.bgLoader.WorkerReportsProgress = true;
            this.bgLoader.WorkerSupportsCancellation = true;
            this.bgLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoader_DoWork);
            this.bgLoader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgLoader_ProgressChanged);
            this.bgLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoader_RunWorkerCompleted);
            // 
            // barMain
            // 
            this.barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnReload,
            this.btnExportImage,
            this.btnExportAsXML,
            this.btnImportFromXML,
            this.btnView,
            this.mnuTools,
            this.btnExportAsJson,
            this.btnImportFromJson});
            this.barMain.Location = new System.Drawing.Point(0, 0);
            this.barMain.Name = "barMain";
            this.barMain.Size = new System.Drawing.Size(1033, 54);
            this.barMain.TabIndex = 53;
            this.barMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::DTRMNS.Properties.Resources.arti32;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 51);
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::DTRMNS.Properties.Resources.MatReport_32;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 51);
            this.btnEdit.Text = "Edit Image";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::DTRMNS.Properties.Resources.eksi32;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 51);
            this.btnDelete.Text = "Delete Image";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::DTRMNS.Properties.Resources.Reload_32;
            this.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(71, 51);
            this.btnReload.Text = "    Reload    ";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExportImage
            // 
            this.btnExportImage.Image = global::DTRMNS.Properties.Resources.DBToFolderPlus32;
            this.btnExportImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(81, 51);
            this.btnExportImage.Text = "Export Image";
            this.btnExportImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportImage.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportAsXML
            // 
            this.btnExportAsXML.Image = global::DTRMNS.Properties.Resources.XML32;
            this.btnExportAsXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportAsXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportAsXML.Name = "btnExportAsXML";
            this.btnExportAsXML.Size = new System.Drawing.Size(88, 51);
            this.btnExportAsXML.Text = "Export As XML";
            this.btnExportAsXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportAsXML.Click += new System.EventHandler(this.btnExportAsXML_Click);
            // 
            // btnImportFromXML
            // 
            this.btnImportFromXML.Image = global::DTRMNS.Properties.Resources.XMLGreen32;
            this.btnImportFromXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromXML.Name = "btnImportFromXML";
            this.btnImportFromXML.Size = new System.Drawing.Size(105, 51);
            this.btnImportFromXML.Text = "Import From XML";
            this.btnImportFromXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportFromXML.Click += new System.EventHandler(this.btnImportFromXML_Click);
            // 
            // btnView
            // 
            this.btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLargeIcon,
            this.btnSmallIcon,
            this.btnDetails,
            this.btnList,
            this.btnTile,
            this.btnXLView,
            this.btnXXLView});
            this.btnView.Image = global::DTRMNS.Properties.Resources.eye32;
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
            // btnXLView
            // 
            this.btnXLView.Name = "btnXLView";
            this.btnXLView.Size = new System.Drawing.Size(157, 22);
            this.btnXLView.Text = "XL View";
            this.btnXLView.Click += new System.EventHandler(this.btnXLView_Click);
            // 
            // btnXXLView
            // 
            this.btnXXLView.Name = "btnXXLView";
            this.btnXXLView.Size = new System.Drawing.Size(157, 22);
            this.btnXXLView.Text = "XXL View";
            this.btnXXLView.Click += new System.EventHandler(this.btnXXLView_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetWidthTo,
            this.mnuSetHeightTo,
            this.toolStripMenuItem1});
            this.mnuTools.Image = global::DTRMNS.Properties.Resources.disli32;
            this.mnuTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(78, 54);
            this.mnuTools.Text = "Tools";
            // 
            // mnuSetWidthTo
            // 
            this.mnuSetWidthTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSetWidth});
            this.mnuSetWidthTo.Image = global::DTRMNS.Properties.Resources.ExpandWidth32;
            this.mnuSetWidthTo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSetWidthTo.Name = "mnuSetWidthTo";
            this.mnuSetWidthTo.Size = new System.Drawing.Size(160, 38);
            this.mnuSetWidthTo.Text = "Set Width To";
            // 
            // txtSetWidth
            // 
            this.txtSetWidth.AcceptsReturn = true;
            this.txtSetWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSetWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSetWidth.Name = "txtSetWidth";
            this.txtSetWidth.Size = new System.Drawing.Size(100, 23);
            this.txtSetWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetWidth_KeyDown);
            // 
            // mnuSetHeightTo
            // 
            this.mnuSetHeightTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSetHeight});
            this.mnuSetHeightTo.Image = global::DTRMNS.Properties.Resources.ExpandHeight32;
            this.mnuSetHeightTo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSetHeightTo.Name = "mnuSetHeightTo";
            this.mnuSetHeightTo.Size = new System.Drawing.Size(160, 38);
            this.mnuSetHeightTo.Text = "Set Height To";
            // 
            // txtSetHeight
            // 
            this.txtSetHeight.AcceptsReturn = true;
            this.txtSetHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSetHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSetHeight.Name = "txtSetHeight";
            this.txtSetHeight.Size = new System.Drawing.Size(100, 23);
            this.txtSetHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetHeight_KeyDown);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // btnExportAsJson
            // 
            this.btnExportAsJson.Image = global::DTRMNS.Properties.Resources.SquareArrowRightExpander32;
            this.btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportAsJson.Name = "btnExportAsJson";
            this.btnExportAsJson.Size = new System.Drawing.Size(76, 51);
            this.btnExportAsJson.Text = "JSON Export";
            this.btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportAsJson.Visible = false;
            this.btnExportAsJson.Click += new System.EventHandler(this.btnExportAsJson_Click);
            // 
            // btnImportFromJson
            // 
            this.btnImportFromJson.Image = global::DTRMNS.Properties.Resources.SquareArrowLeftNarrower32;
            this.btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromJson.Name = "btnImportFromJson";
            this.btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            this.btnImportFromJson.Text = "JSON Import";
            this.btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportFromJson.Visible = false;
            this.btnImportFromJson.Click += new System.EventHandler(this.btnImportFromJson_Click);
            // 
            // frmImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 587);
            this.Controls.Add(this.lvwImages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImageList";
            this.Text = "IMAGE LIST";
            this.Load += new System.EventHandler(this.frmImageList_Load);
            this.panel1.ResumeLayout(false);
            this.barMain.ResumeLayout(false);
            this.barMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genericImageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource genericImageBindingSource;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lvwImages;
        private System.Windows.Forms.ColumnHeader ImageFileName;
        private System.Windows.Forms.ColumnHeader ExtraText;
        private System.Windows.Forms.ColumnHeader colImage;
        private System.ComponentModel.BackgroundWorker bgLoader;
        private System.Windows.Forms.ToolStrip barMain;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnExportImage;
        private System.Windows.Forms.ToolStripButton btnExportAsXML;
        private System.Windows.Forms.ToolStripButton btnImportFromXML;
        private System.Windows.Forms.ColumnHeader Dimensions;
        private System.Windows.Forms.ToolStripDropDownButton btnView;
        private System.Windows.Forms.ToolStripMenuItem btnLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem btnSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem btnDetails;
        private System.Windows.Forms.ToolStripMenuItem btnList;
        private System.Windows.Forms.ToolStripMenuItem btnTile;
        private System.Windows.Forms.ColumnHeader colWidth;
        private System.Windows.Forms.ColumnHeader colHeight;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ToolStripMenuItem btnXLView;
        private System.Windows.Forms.ToolStripMenuItem btnXXLView;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuSetWidthTo;
        private System.Windows.Forms.ToolStripTextBox txtSetWidth;
        private System.Windows.Forms.ToolStripMenuItem mnuSetHeightTo;
        private System.Windows.Forms.ToolStripTextBox txtSetHeight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton btnExportAsJson;
        private System.Windows.Forms.ToolStripButton btnImportFromJson;
    }
}