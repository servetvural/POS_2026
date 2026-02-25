namespace DTRMSimpleBackOffice {
    partial class frmImageEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnLargeIcon = new System.Windows.Forms.ToolStripButton();
            this.btnSmallIcon = new System.Windows.Forms.ToolStripButton();
            this.btnListView = new System.Windows.Forms.ToolStripButton();
            this.btnTileView = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveWords = new System.Windows.Forms.ToolStripButton();
            this.btnFitinDimensions = new System.Windows.Forms.ToolStripButton();
            this.btnSentenceCase = new System.Windows.Forms.ToolStripButton();
            this.lblProcess = new System.Windows.Forms.ToolStripLabel();
            this.btnReplace = new System.Windows.Forms.ToolStripButton();
            this.ilLocal = new System.Windows.Forms.ImageList(this.components);
            this.wbLocal = new System.Windows.Forms.WebBrowser();
            this.lvwImages = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.expander1 = new PosLibrary.Expander();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnLargeIcon,
            this.btnSmallIcon,
            this.btnListView,
            this.btnTileView,
            this.btnReload,
            this.btnRemoveWords,
            this.btnFitinDimensions,
            this.btnSentenceCase,
            this.lblProcess,
            this.btnReplace});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::DTRMSimpleBackOffice.Properties.Resources.FolderOpen_32;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(36, 36);
            this.btnOpen.Text = "toolStripButton1";
            this.btnOpen.ToolTipText = "Open Directory";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnLargeIcon
            // 
            this.btnLargeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLargeIcon.Image = global::DTRMSimpleBackOffice.Properties.Resources.ViewLargeIcons;
            this.btnLargeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLargeIcon.Name = "btnLargeIcon";
            this.btnLargeIcon.Size = new System.Drawing.Size(36, 36);
            this.btnLargeIcon.Text = "toolStripButton2";
            this.btnLargeIcon.ToolTipText = "Large Icon View";
            this.btnLargeIcon.Click += new System.EventHandler(this.btnLargeIcon_Click);
            // 
            // btnSmallIcon
            // 
            this.btnSmallIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSmallIcon.Image = global::DTRMSimpleBackOffice.Properties.Resources.ViewSmallIcons;
            this.btnSmallIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSmallIcon.Name = "btnSmallIcon";
            this.btnSmallIcon.Size = new System.Drawing.Size(36, 36);
            this.btnSmallIcon.Text = "toolStripButton3";
            this.btnSmallIcon.ToolTipText = "Small Icon View";
            this.btnSmallIcon.Click += new System.EventHandler(this.btnSmallIcon_Click);
            // 
            // btnListView
            // 
            this.btnListView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnListView.Image = global::DTRMSimpleBackOffice.Properties.Resources.ViewList;
            this.btnListView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(36, 36);
            this.btnListView.Text = "toolStripButton4";
            this.btnListView.ToolTipText = "List View";
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnTileView
            // 
            this.btnTileView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTileView.Image = global::DTRMSimpleBackOffice.Properties.Resources.ViewDetails;
            this.btnTileView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTileView.Name = "btnTileView";
            this.btnTileView.Size = new System.Drawing.Size(36, 36);
            this.btnTileView.Text = "toolStripButton5";
            this.btnTileView.ToolTipText = "Tile View";
            this.btnTileView.Click += new System.EventHandler(this.btnTileView_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = global::DTRMSimpleBackOffice.Properties.Resources.Refresh_2;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(36, 36);
            this.btnReload.Text = "toolStripButton1";
            this.btnReload.ToolTipText = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRemoveWords
            // 
            this.btnRemoveWords.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnRemoveWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveWords.Name = "btnRemoveWords";
            this.btnRemoveWords.Size = new System.Drawing.Size(123, 36);
            this.btnRemoveWords.Text = "Remove Words";
            this.btnRemoveWords.Click += new System.EventHandler(this.btnRemoveWords_Click);
            // 
            // btnFitinDimensions
            // 
            this.btnFitinDimensions.Image = global::DTRMSimpleBackOffice.Properties.Resources.Move;
            this.btnFitinDimensions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitinDimensions.Name = "btnFitinDimensions";
            this.btnFitinDimensions.Size = new System.Drawing.Size(134, 36);
            this.btnFitinDimensions.Text = "Fit in Dimensions";
            this.btnFitinDimensions.Click += new System.EventHandler(this.btnFitinDimensions_Click);
            // 
            // btnSentenceCase
            // 
            this.btnSentenceCase.Image = global::DTRMSimpleBackOffice.Properties.Resources.Abc;
            this.btnSentenceCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSentenceCase.Name = "btnSentenceCase";
            this.btnSentenceCase.Size = new System.Drawing.Size(119, 36);
            this.btnSentenceCase.Text = "Sentence Case";
            this.btnSentenceCase.ToolTipText = "Sentence Case";
            this.btnSentenceCase.Click += new System.EventHandler(this.btnSentenceCase_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(19, 36);
            this.lblProcess.Text = "aa";
            // 
            // btnReplace
            // 
            this.btnReplace.Image = global::DTRMSimpleBackOffice.Properties.Resources.Refresh_Blue;
            this.btnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(84, 36);
            this.btnReplace.Text = "Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // ilLocal
            // 
            this.ilLocal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLocal.ImageStream")));
            this.ilLocal.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLocal.Images.SetKeyName(0, "directory");
            // 
            // wbLocal
            // 
            this.wbLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbLocal.Location = new System.Drawing.Point(356, 39);
            this.wbLocal.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLocal.Name = "wbLocal";
            this.wbLocal.Size = new System.Drawing.Size(411, 458);
            this.wbLocal.TabIndex = 2;
            // 
            // lvwImages
            // 
            this.lvwImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwImages.HideSelection = false;
            this.lvwImages.LargeImageList = this.ilLocal;
            this.lvwImages.Location = new System.Drawing.Point(0, 39);
            this.lvwImages.MinimumSize = new System.Drawing.Size(300, 0);
            this.lvwImages.Name = "lvwImages";
            this.lvwImages.Size = new System.Drawing.Size(327, 458);
            this.lvwImages.StateImageList = this.ilLocal;
            this.lvwImages.TabIndex = 2;
            this.lvwImages.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDirectory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(767, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDirectory
            // 
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(0, 17);
            // 
            // expander1
            // 
            this.expander1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.expander1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expander1.ColourFixed = System.Drawing.Color.Salmon;
            this.expander1.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            this.expander1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expander1.ExpandableControl = this.lvwImages;
            this.expander1.Expanded = true;
            this.expander1.Fixed = false;
            this.expander1.Location = new System.Drawing.Point(327, 39);
            this.expander1.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            this.expander1.LockButtonSize = new System.Drawing.Size(27, 64);
            this.expander1.LockButtonVisible = true;
            this.expander1.MinimumSize = new System.Drawing.Size(5, 5);
            this.expander1.Name = "expander1";
            this.expander1.Size = new System.Drawing.Size(29, 458);
            this.expander1.TabIndex = 5;
            // 
            // frmImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 519);
            this.Controls.Add(this.wbLocal);
            this.Controls.Add(this.expander1);
            this.Controls.Add(this.lvwImages);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImageEditor";
            this.Text = "Image Editor";
            this.Load += new System.EventHandler(this.frmImageEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnLargeIcon;
        private System.Windows.Forms.ToolStripButton btnSmallIcon;
        private System.Windows.Forms.ToolStripButton btnListView;
        private System.Windows.Forms.ToolStripButton btnTileView;
        private System.Windows.Forms.ImageList ilLocal;
        private System.Windows.Forms.WebBrowser wbLocal;
        private System.Windows.Forms.ToolStripButton btnRemoveWords;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDirectory;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnFitinDimensions;
        private System.Windows.Forms.ToolStripLabel lblProcess;
        private System.Windows.Forms.ToolStripButton btnSentenceCase;
        private System.Windows.Forms.ToolStripButton btnReplace;
        private System.Windows.Forms.ListView lvwImages;
        private PosLibrary.Expander expander1;
    }
}