namespace WinLayer {
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageList));
            panel1 = new System.Windows.Forms.Panel();
            btnZoom = new System.Windows.Forms.Button();
            btnSelect = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            imgList = new System.Windows.Forms.ImageList(components);
            lvwImages = new System.Windows.Forms.ListView();
            colImage = new System.Windows.Forms.ColumnHeader();
            ImageFileName = new System.Windows.Forms.ColumnHeader();
            ExtraText = new System.Windows.Forms.ColumnHeader();
            Dimensions = new System.Windows.Forms.ColumnHeader();
            colWidth = new System.Windows.Forms.ColumnHeader();
            colHeight = new System.Windows.Forms.ColumnHeader();
            colSize = new System.Windows.Forms.ColumnHeader();
            bgLoader = new System.ComponentModel.BackgroundWorker();
            barMain = new System.Windows.Forms.ToolStrip();
            btnAdd = new System.Windows.Forms.ToolStripButton();
            btnEdit = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            btnReload = new System.Windows.Forms.ToolStripButton();
            btnExportImage = new System.Windows.Forms.ToolStripButton();
            btnExportAsXML = new System.Windows.Forms.ToolStripButton();
            btnImportFromXML = new System.Windows.Forms.ToolStripButton();
            btnView = new System.Windows.Forms.ToolStripDropDownButton();
            btnLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            btnSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            btnDetails = new System.Windows.Forms.ToolStripMenuItem();
            btnList = new System.Windows.Forms.ToolStripMenuItem();
            btnTile = new System.Windows.Forms.ToolStripMenuItem();
            btnXLView = new System.Windows.Forms.ToolStripMenuItem();
            btnXXLView = new System.Windows.Forms.ToolStripMenuItem();
            mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            mnuSetWidthTo = new System.Windows.Forms.ToolStripMenuItem();
            txtSetWidth = new System.Windows.Forms.ToolStripTextBox();
            mnuSetHeightTo = new System.Windows.Forms.ToolStripMenuItem();
            txtSetHeight = new System.Windows.Forms.ToolStripTextBox();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            btnExportAsJson = new System.Windows.Forms.ToolStripButton();
            btnImportFromJson = new System.Windows.Forms.ToolStripButton();
            genericImageBindingSource = new System.Windows.Forms.BindingSource(components);
            btnClose2 = new System.Windows.Forms.ToolStripButton();
            panel1.SuspendLayout();
            barMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)genericImageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnZoom);
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 596);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            panel1.Size = new System.Drawing.Size(965, 81);
            panel1.TabIndex = 46;
            // 
            // btnZoom
            // 
            btnZoom.Dock = System.Windows.Forms.DockStyle.Right;
            btnZoom.FlatAppearance.BorderSize = 0;
            btnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnZoom.ForeColor = System.Drawing.SystemColors.ControlText;
            btnZoom.Image = Properties.Resources.ZoomOut32;
            btnZoom.Location = new System.Drawing.Point(369, 12);
            btnZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new System.Drawing.Size(146, 57);
            btnZoom.TabIndex = 45;
            btnZoom.Text = "ZOOM";
            btnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnZoom.UseVisualStyleBackColor = false;
            btnZoom.Click += btnZoom_Click;
            // 
            // btnSelect
            // 
            btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSelect.Image = Properties.Resources.tickgreen;
            btnSelect.Location = new System.Drawing.Point(515, 12);
            btnSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(146, 57);
            btnSelect.TabIndex = 44;
            btnSelect.Text = "SELECT";
            btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.Location = new System.Drawing.Point(661, 12);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(146, 57);
            btnClose.TabIndex = 42;
            btnClose.Text = "CANCEL";
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Image = Properties.Resources.save32;
            btnSave.Location = new System.Drawing.Point(807, 12);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(146, 57);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // imgList
            // 
            imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imgList.ImageSize = new System.Drawing.Size(50, 50);
            imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvwImages
            // 
            lvwImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colImage, ImageFileName, ExtraText, Dimensions, colWidth, colHeight, colSize });
            lvwImages.Dock = System.Windows.Forms.DockStyle.Fill;
            lvwImages.FullRowSelect = true;
            lvwImages.GridLines = true;
            lvwImages.LargeImageList = imgList;
            lvwImages.Location = new System.Drawing.Point(0, 54);
            lvwImages.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwImages.Name = "lvwImages";
            lvwImages.ShowItemToolTips = true;
            lvwImages.Size = new System.Drawing.Size(965, 542);
            lvwImages.SmallImageList = imgList;
            lvwImages.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvwImages.TabIndex = 51;
            lvwImages.UseCompatibleStateImageBehavior = false;
            lvwImages.View = System.Windows.Forms.View.Tile;
            lvwImages.MouseDoubleClick += lvwImages_MouseDoubleClick;
            lvwImages.MouseDown += lvwImages_MouseDown;
            // 
            // colImage
            // 
            colImage.Text = "";
            // 
            // ImageFileName
            // 
            ImageFileName.Text = "File Name";
            ImageFileName.Width = 300;
            // 
            // ExtraText
            // 
            ExtraText.Text = "Image Text";
            ExtraText.Width = 100;
            // 
            // Dimensions
            // 
            Dimensions.Text = "Dimensions";
            Dimensions.Width = 100;
            // 
            // colWidth
            // 
            colWidth.Text = "Width";
            // 
            // colHeight
            // 
            colHeight.Text = "Height";
            // 
            // colSize
            // 
            colSize.Text = "Size (KB)";
            // 
            // bgLoader
            // 
            bgLoader.WorkerReportsProgress = true;
            bgLoader.WorkerSupportsCancellation = true;
            bgLoader.DoWork += bgLoader_DoWork;
            bgLoader.ProgressChanged += bgLoader_ProgressChanged;
            bgLoader.RunWorkerCompleted += bgLoader_RunWorkerCompleted;
            // 
            // barMain
            // 
            barMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAdd, btnEdit, btnDelete, btnReload, btnExportImage, btnExportAsXML, btnImportFromXML, btnView, mnuTools, btnExportAsJson, btnImportFromJson, btnClose2 });
            barMain.Location = new System.Drawing.Point(0, 0);
            barMain.Name = "barMain";
            barMain.Size = new System.Drawing.Size(965, 54);
            barMain.TabIndex = 53;
            barMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.Image = Properties.Resources.arti32;
            btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(60, 51);
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = false;
            btnEdit.Image = Properties.Resources.MatReport_32;
            btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(60, 51);
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.Image = Properties.Resources.eksi32;
            btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(60, 51);
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReload
            // 
            btnReload.AutoSize = false;
            btnReload.Image = Properties.Resources.Refresh_2;
            btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(60, 51);
            btnReload.Text = "    Reload    ";
            btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReload.Click += btnReload_Click;
            // 
            // btnExportImage
            // 
            btnExportImage.AutoSize = false;
            btnExportImage.Image = Properties.Resources.DBToFolderPlus32;
            btnExportImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportImage.Name = "btnExportImage";
            btnExportImage.Size = new System.Drawing.Size(80, 51);
            btnExportImage.Text = "Export";
            btnExportImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportImage.Click += btnExport_Click;
            // 
            // btnExportAsXML
            // 
            btnExportAsXML.AutoSize = false;
            btnExportAsXML.Image = Properties.Resources.XML32;
            btnExportAsXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportAsXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportAsXML.Name = "btnExportAsXML";
            btnExportAsXML.Size = new System.Drawing.Size(80, 51);
            btnExportAsXML.Text = "Export XML";
            btnExportAsXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportAsXML.Click += btnExportAsXML_Click;
            // 
            // btnImportFromXML
            // 
            btnImportFromXML.AutoSize = false;
            btnImportFromXML.Image = Properties.Resources.XMLGreen32;
            btnImportFromXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportFromXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportFromXML.Name = "btnImportFromXML";
            btnImportFromXML.Size = new System.Drawing.Size(80, 51);
            btnImportFromXML.Text = "Import XML";
            btnImportFromXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportFromXML.Click += btnImportFromXML_Click;
            // 
            // btnView
            // 
            btnView.AutoSize = false;
            btnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnLargeIcon, btnSmallIcon, btnDetails, btnList, btnTile, btnXLView, btnXXLView });
            btnView.Image = Properties.Resources.eye32;
            btnView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(90, 51);
            btnView.Text = "Change View";
            btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLargeIcon
            // 
            btnLargeIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnLargeIcon.Name = "btnLargeIcon";
            btnLargeIcon.Padding = new System.Windows.Forms.Padding(10);
            btnLargeIcon.Size = new System.Drawing.Size(233, 48);
            btnLargeIcon.Text = "Large Icon View";
            btnLargeIcon.Click += btnLargeIcon_Click;
            // 
            // btnSmallIcon
            // 
            btnSmallIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSmallIcon.Name = "btnSmallIcon";
            btnSmallIcon.Padding = new System.Windows.Forms.Padding(10);
            btnSmallIcon.Size = new System.Drawing.Size(233, 48);
            btnSmallIcon.Text = "Small Icon View";
            btnSmallIcon.Click += btnSmallIcon_Click;
            // 
            // btnDetails
            // 
            btnDetails.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnDetails.Name = "btnDetails";
            btnDetails.Padding = new System.Windows.Forms.Padding(10);
            btnDetails.Size = new System.Drawing.Size(233, 48);
            btnDetails.Text = "Details View ";
            btnDetails.Click += btnDetails_Click;
            // 
            // btnList
            // 
            btnList.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnList.Name = "btnList";
            btnList.Padding = new System.Windows.Forms.Padding(10);
            btnList.Size = new System.Drawing.Size(233, 48);
            btnList.Text = "List View";
            btnList.Click += btnList_Click;
            // 
            // btnTile
            // 
            btnTile.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnTile.Name = "btnTile";
            btnTile.Padding = new System.Windows.Forms.Padding(10);
            btnTile.Size = new System.Drawing.Size(233, 48);
            btnTile.Text = "Tile View";
            btnTile.Click += btnTile_Click;
            // 
            // btnXLView
            // 
            btnXLView.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnXLView.Name = "btnXLView";
            btnXLView.Padding = new System.Windows.Forms.Padding(10);
            btnXLView.Size = new System.Drawing.Size(233, 48);
            btnXLView.Text = "XL View";
            btnXLView.Click += btnXLView_Click;
            // 
            // btnXXLView
            // 
            btnXXLView.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnXXLView.Name = "btnXXLView";
            btnXXLView.Padding = new System.Windows.Forms.Padding(10);
            btnXXLView.Size = new System.Drawing.Size(233, 48);
            btnXXLView.Text = "XXL View";
            btnXXLView.Click += btnXXLView_Click;
            // 
            // mnuTools
            // 
            mnuTools.AutoSize = false;
            mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSetWidthTo, mnuSetHeightTo, toolStripMenuItem1 });
            mnuTools.Image = Properties.Resources.disli32;
            mnuTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new System.Drawing.Size(80, 54);
            mnuTools.Text = "Tools";
            mnuTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuSetWidthTo
            // 
            mnuSetWidthTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { txtSetWidth });
            mnuSetWidthTo.Image = Properties.Resources.ExpandWidth32;
            mnuSetWidthTo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            mnuSetWidthTo.Name = "mnuSetWidthTo";
            mnuSetWidthTo.Size = new System.Drawing.Size(196, 38);
            mnuSetWidthTo.Text = "Set Width To";
            // 
            // txtSetWidth
            // 
            txtSetWidth.AcceptsReturn = true;
            txtSetWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSetWidth.Name = "txtSetWidth";
            txtSetWidth.Size = new System.Drawing.Size(100, 23);
            txtSetWidth.KeyDown += txtSetWidth_KeyDown;
            // 
            // mnuSetHeightTo
            // 
            mnuSetHeightTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { txtSetHeight });
            mnuSetHeightTo.Image = Properties.Resources.ExpandHeight32;
            mnuSetHeightTo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            mnuSetHeightTo.Name = "mnuSetHeightTo";
            mnuSetHeightTo.Size = new System.Drawing.Size(196, 38);
            mnuSetHeightTo.Text = "Set Height To";
            // 
            // txtSetHeight
            // 
            txtSetHeight.AcceptsReturn = true;
            txtSetHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSetHeight.Name = "txtSetHeight";
            txtSetHeight.Size = new System.Drawing.Size(100, 23);
            txtSetHeight.KeyDown += txtSetHeight_KeyDown;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // btnExportAsJson
            // 
            btnExportAsJson.Image = Properties.Resources.SquareArrowRightExpander32;
            btnExportAsJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnExportAsJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExportAsJson.Name = "btnExportAsJson";
            btnExportAsJson.Size = new System.Drawing.Size(75, 51);
            btnExportAsJson.Text = "JSON Export";
            btnExportAsJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExportAsJson.Visible = false;
            btnExportAsJson.Click += btnExportAsJson_Click;
            // 
            // btnImportFromJson
            // 
            btnImportFromJson.Image = Properties.Resources.SquareArrowLeftNarrower32;
            btnImportFromJson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnImportFromJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImportFromJson.Name = "btnImportFromJson";
            btnImportFromJson.Size = new System.Drawing.Size(78, 51);
            btnImportFromJson.Text = "JSON Import";
            btnImportFromJson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnImportFromJson.Visible = false;
            btnImportFromJson.Click += btnImportFromJson_Click;
            // 
            // btnClose2
            // 
            btnClose2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose2.AutoSize = false;
            btnClose2.Image = Properties.Resources.Cancel;
            btnClose2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnClose2.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new System.Drawing.Size(60, 51);
            btnClose2.Text = "Close";
            btnClose2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnClose2.Click += btnClose_Click;
            // 
            // frmImageList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(965, 677);
            Controls.Add(lvwImages);
            Controls.Add(panel1);
            Controls.Add(barMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmImageList";
            Text = "Images";
            Load += frmImageList_Load;
            panel1.ResumeLayout(false);
            barMain.ResumeLayout(false);
            barMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)genericImageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ToolStripButton btnClose2;
    }
}