namespace POSOffice {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageEditor));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnOpen = new System.Windows.Forms.ToolStripButton();
            btnLargeIcon = new System.Windows.Forms.ToolStripButton();
            btnSmallIcon = new System.Windows.Forms.ToolStripButton();
            btnListView = new System.Windows.Forms.ToolStripButton();
            btnTileView = new System.Windows.Forms.ToolStripButton();
            btnReload = new System.Windows.Forms.ToolStripButton();
            btnRemoveWords = new System.Windows.Forms.ToolStripButton();
            btnFitinDimensions = new System.Windows.Forms.ToolStripButton();
            btnSentenceCase = new System.Windows.Forms.ToolStripButton();
            lblProcess = new System.Windows.Forms.ToolStripLabel();
            btnReplace = new System.Windows.Forms.ToolStripButton();
            ilLocal = new System.Windows.Forms.ImageList(components);
            wbLocal = new System.Windows.Forms.WebBrowser();
            lvwImages = new System.Windows.Forms.ListView();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            expander1 = new PosLibrary.Expander();
            btnClose = new System.Windows.Forms.ToolStripButton();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnOpen, btnLargeIcon, btnSmallIcon, btnListView, btnTileView, btnReload, btnRemoveWords, btnFitinDimensions, btnSentenceCase, btnReplace, lblProcess, btnClose });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(895, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            btnOpen.AutoSize = false;
            btnOpen.Image = Properties.Resources.FolderOpen_32;
            btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(60, 51);
            btnOpen.Text = "Open";
            btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnOpen.ToolTipText = "Open Directory";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLargeIcon
            // 
            btnLargeIcon.AutoSize = false;
            btnLargeIcon.Image = Properties.Resources.ViewLargeIcons;
            btnLargeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLargeIcon.Name = "btnLargeIcon";
            btnLargeIcon.Size = new System.Drawing.Size(60, 51);
            btnLargeIcon.Text = "Large Icon";
            btnLargeIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLargeIcon.ToolTipText = "Large Icon View";
            btnLargeIcon.Click += btnLargeIcon_Click;
            // 
            // btnSmallIcon
            // 
            btnSmallIcon.AutoSize = false;
            btnSmallIcon.Image = Properties.Resources.ViewSmallIcons;
            btnSmallIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSmallIcon.Name = "btnSmallIcon";
            btnSmallIcon.Size = new System.Drawing.Size(60, 51);
            btnSmallIcon.Text = "Small Icon";
            btnSmallIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSmallIcon.ToolTipText = "Small Icon View";
            btnSmallIcon.Click += btnSmallIcon_Click;
            // 
            // btnListView
            // 
            btnListView.AutoSize = false;
            btnListView.Image = Properties.Resources.ViewList;
            btnListView.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnListView.Name = "btnListView";
            btnListView.Size = new System.Drawing.Size(60, 51);
            btnListView.Text = "List View";
            btnListView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnListView.ToolTipText = "List View";
            btnListView.Click += btnListView_Click;
            // 
            // btnTileView
            // 
            btnTileView.AutoSize = false;
            btnTileView.Image = Properties.Resources.ViewDetails;
            btnTileView.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnTileView.Name = "btnTileView";
            btnTileView.Size = new System.Drawing.Size(60, 51);
            btnTileView.Text = "Tile View";
            btnTileView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnTileView.ToolTipText = "Tile View";
            btnTileView.Click += btnTileView_Click;
            // 
            // btnReload
            // 
            btnReload.AutoSize = false;
            btnReload.Image = Properties.Resources.Refresh_2;
            btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(60, 51);
            btnReload.Text = "Reload";
            btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReload.ToolTipText = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // btnRemoveWords
            // 
            btnRemoveWords.Image = Properties.Resources.eksi32;
            btnRemoveWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnRemoveWords.Name = "btnRemoveWords";
            btnRemoveWords.Size = new System.Drawing.Size(91, 51);
            btnRemoveWords.Text = "Remove Words";
            btnRemoveWords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRemoveWords.Click += btnRemoveWords_Click;
            // 
            // btnFitinDimensions
            // 
            btnFitinDimensions.Image = Properties.Resources.Move;
            btnFitinDimensions.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFitinDimensions.Name = "btnFitinDimensions";
            btnFitinDimensions.Size = new System.Drawing.Size(102, 51);
            btnFitinDimensions.Text = "Fit in Dimensions";
            btnFitinDimensions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnFitinDimensions.Click += btnFitinDimensions_Click;
            // 
            // btnSentenceCase
            // 
            btnSentenceCase.Image = Properties.Resources.Abc;
            btnSentenceCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSentenceCase.Name = "btnSentenceCase";
            btnSentenceCase.Size = new System.Drawing.Size(87, 51);
            btnSentenceCase.Text = "Sentence Case";
            btnSentenceCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSentenceCase.ToolTipText = "Sentence Case";
            btnSentenceCase.Click += btnSentenceCase_Click;
            // 
            // lblProcess
            // 
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new System.Drawing.Size(19, 51);
            lblProcess.Text = "aa";
            // 
            // btnReplace
            // 
            btnReplace.Image = Properties.Resources.Refresh_Blue;
            btnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new System.Drawing.Size(52, 51);
            btnReplace.Text = "Replace";
            btnReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnReplace.Click += btnReplace_Click;
            // 
            // ilLocal
            // 
            ilLocal.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ilLocal.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilLocal.ImageStream");
            ilLocal.TransparentColor = System.Drawing.Color.Transparent;
            ilLocal.Images.SetKeyName(0, "directory");
            // 
            // wbLocal
            // 
            wbLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            wbLocal.Location = new System.Drawing.Point(414, 54);
            wbLocal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            wbLocal.MinimumSize = new System.Drawing.Size(23, 23);
            wbLocal.Name = "wbLocal";
            wbLocal.Size = new System.Drawing.Size(481, 523);
            wbLocal.TabIndex = 2;
            // 
            // lvwImages
            // 
            lvwImages.Dock = System.Windows.Forms.DockStyle.Left;
            lvwImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lvwImages.LargeImageList = ilLocal;
            lvwImages.Location = new System.Drawing.Point(0, 54);
            lvwImages.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvwImages.MinimumSize = new System.Drawing.Size(349, 4);
            lvwImages.Name = "lvwImages";
            lvwImages.Size = new System.Drawing.Size(381, 523);
            lvwImages.StateImageList = ilLocal;
            lvwImages.TabIndex = 2;
            lvwImages.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblDirectory });
            statusStrip1.Location = new System.Drawing.Point(0, 577);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(895, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDirectory
            // 
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new System.Drawing.Size(0, 17);
            // 
            // expander1
            // 
            expander1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            expander1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            expander1.Caption = "";
            expander1.CaptionAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            expander1.CaptionFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            expander1.CaptionForeColor = System.Drawing.Color.White;
            expander1.CaptionOrientation = System.Windows.Forms.Orientation.Horizontal;
            expander1.ColourFixed = System.Drawing.Color.Salmon;
            expander1.ColourUnFixed = System.Drawing.SystemColors.ActiveCaption;
            expander1.Dock = System.Windows.Forms.DockStyle.Left;
            expander1.ExpandableControl = lvwImages;
            expander1.ExpandButtonBackColor = System.Drawing.Color.Transparent;
            expander1.Expanded = true;
            expander1.Fixed = false;
            expander1.Location = new System.Drawing.Point(381, 54);
            expander1.LockButtonDock = System.Windows.Forms.DockStyle.Top;
            expander1.LockButtonSize = new System.Drawing.Size(31, 74);
            expander1.LockButtonVisible = true;
            expander1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expander1.MinimumSize = new System.Drawing.Size(6, 5);
            expander1.Name = "expander1";
            expander1.Size = new System.Drawing.Size(33, 523);
            expander1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnClose.AutoSize = false;
            btnClose.Image = Properties.Resources.Cancel;
            btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(60, 51);
            btnClose.Text = "Close";
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmImageEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(895, 599);
            Controls.Add(wbLocal);
            Controls.Add(expander1);
            Controls.Add(lvwImages);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmImageEditor";
            Text = "Image Editor";
            Load += frmImageEditor_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ToolStripButton btnClose;
    }
}