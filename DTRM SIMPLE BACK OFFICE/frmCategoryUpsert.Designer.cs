using POSLayer.Models;

namespace DTRMSimpleBackOffice {
   partial class frmCategoryUpsert {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
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
            cmbEntityType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            btnEntityForeColour = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtCategoryName = new System.Windows.Forms.TextBox();
            btnEntityPanelBackColor = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblFont = new System.Windows.Forms.Label();
            btnFont = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cmbDistribution = new System.Windows.Forms.ComboBox();
            globalTypeBindingSource = new System.Windows.Forms.BindingSource(components);
            label20 = new System.Windows.Forms.Label();
            incDisplayOrder = new PosLibrary.IntegerTextBox();
            btnForceDistributionToAllButtons = new System.Windows.Forms.Button();
            incHeight = new PosLibrary.IntegerTextBox();
            incWidth = new PosLibrary.IntegerTextBox();
            btnNewDistribution = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnSample = new System.Windows.Forms.ToolStripButton();
            label8 = new System.Windows.Forms.Label();
            cmbTextImageRelation = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            cmbTextAlign = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            cmbImageAlign = new System.Windows.Forms.ComboBox();
            cmbButtonDisplayStyle = new System.Windows.Forms.ComboBox();
            lblImageSize = new System.Windows.Forms.Label();
            btnDeletePrepImage = new System.Windows.Forms.Button();
            btnLoadPrepImageFromDirectory = new System.Windows.Forms.Button();
            pBox = new System.Windows.Forms.PictureBox();
            txtImageFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)globalTypeBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            SuspendLayout();
            // 
            // cmbEntityType
            // 
            cmbEntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEntityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbEntityType.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbEntityType.FormattingEnabled = true;
            cmbEntityType.Items.AddRange(new object[] { "Normal Category", "Extra & Disco" });
            cmbEntityType.Location = new System.Drawing.Point(160, 165);
            cmbEntityType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            cmbEntityType.Name = "cmbEntityType";
            cmbEntityType.Size = new System.Drawing.Size(220, 26);
            cmbEntityType.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(44, 174);
            label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 18);
            label1.TabIndex = 37;
            label1.Text = "Category Type";
            // 
            // btnEntityForeColour
            // 
            btnEntityForeColour.FlatAppearance.BorderSize = 0;
            btnEntityForeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnEntityForeColour.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEntityForeColour.Location = new System.Drawing.Point(160, 404);
            btnEntityForeColour.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            btnEntityForeColour.Name = "btnEntityForeColour";
            btnEntityForeColour.Size = new System.Drawing.Size(80, 30);
            btnEntityForeColour.TabIndex = 35;
            btnEntityForeColour.UseVisualStyleBackColor = true;
            btnEntityForeColour.Click += btnEntityForeColour_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(36, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 18);
            label2.TabIndex = 29;
            label2.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            txtCategoryName.Location = new System.Drawing.Point(160, 38);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new System.Drawing.Size(221, 24);
            txtCategoryName.TabIndex = 28;
            txtCategoryName.Click += txtEntityName_Click;
            txtCategoryName.TextChanged += txtCategoryName_TextChanged;
            // 
            // btnEntityPanelBackColor
            // 
            btnEntityPanelBackColor.FlatAppearance.BorderSize = 0;
            btnEntityPanelBackColor.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEntityPanelBackColor.Location = new System.Drawing.Point(160, 365);
            btnEntityPanelBackColor.Name = "btnEntityPanelBackColor";
            btnEntityPanelBackColor.Size = new System.Drawing.Size(80, 30);
            btnEntityPanelBackColor.TabIndex = 32;
            btnEntityPanelBackColor.UseVisualStyleBackColor = true;
            btnEntityPanelBackColor.Click += btnEntityPanelColor_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Location = new System.Drawing.Point(160, 461);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(137, 48);
            btnClose.TabIndex = 40;
            btnClose.Text = "CANCEL";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Location = new System.Drawing.Point(345, 461);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(125, 48);
            btnSave.TabIndex = 41;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(66, 82);
            label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 18);
            label5.TabIndex = 50;
            label5.Text = "Distribution";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            lblFont.ForeColor = System.Drawing.SystemColors.ControlText;
            lblFont.Location = new System.Drawing.Point(110, 214);
            lblFont.Name = "lblFont";
            lblFont.Size = new System.Drawing.Size(38, 18);
            lblFont.TabIndex = 80;
            lblFont.Text = "Font";
            // 
            // btnFont
            // 
            btnFont.BackColor = System.Drawing.SystemColors.Control;
            btnFont.FlatAppearance.BorderSize = 0;
            btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btnFont.ForeColor = System.Drawing.SystemColors.ControlText;
            btnFont.Location = new System.Drawing.Point(160, 206);
            btnFont.Name = "btnFont";
            btnFont.Size = new System.Drawing.Size(220, 30);
            btnFont.TabIndex = 81;
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(55, 296);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 18);
            label7.TabIndex = 91;
            label7.Text = "Button Width";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(53, 330);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 18);
            label6.TabIndex = 90;
            label6.Text = "Button Height";
            // 
            // cmbDistribution
            // 
            cmbDistribution.DataSource = globalTypeBindingSource;
            cmbDistribution.DisplayMember = "Name";
            cmbDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbDistribution.FormattingEnabled = true;
            cmbDistribution.Location = new System.Drawing.Point(160, 78);
            cmbDistribution.Name = "cmbDistribution";
            cmbDistribution.Size = new System.Drawing.Size(220, 26);
            cmbDistribution.TabIndex = 99;
            cmbDistribution.ValueMember = "IID";
            // 
            // globalTypeBindingSource
            // 
            globalTypeBindingSource.DataSource = typeof(Distribution);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label20.Location = new System.Drawing.Point(50, 254);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(98, 18);
            label20.TabIndex = 102;
            label20.Text = "Display Order";
            // 
            // incDisplayOrder
            // 
            incDisplayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            incDisplayOrder.Increment = 1;
            incDisplayOrder.Location = new System.Drawing.Point(160, 251);
            incDisplayOrder.MaxValue = 1000;
            incDisplayOrder.MinValue = 0;
            incDisplayOrder.Name = "incDisplayOrder";
            incDisplayOrder.Size = new System.Drawing.Size(80, 24);
            incDisplayOrder.TabIndex = 101;
            incDisplayOrder.Text = "0";
            incDisplayOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            incDisplayOrder.Value = 0;
            // 
            // btnForceDistributionToAllButtons
            // 
            btnForceDistributionToAllButtons.Location = new System.Drawing.Point(160, 118);
            btnForceDistributionToAllButtons.Name = "btnForceDistributionToAllButtons";
            btnForceDistributionToAllButtons.Size = new System.Drawing.Size(312, 32);
            btnForceDistributionToAllButtons.TabIndex = 103;
            btnForceDistributionToAllButtons.Text = "Set Category Items For Same Distribution";
            btnForceDistributionToAllButtons.UseVisualStyleBackColor = true;
            btnForceDistributionToAllButtons.Click += btnForceDistributionToAllButtons_Click;
            // 
            // incHeight
            // 
            incHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            incHeight.Increment = 1;
            incHeight.Location = new System.Drawing.Point(160, 326);
            incHeight.MaxValue = 1000;
            incHeight.MinValue = 0;
            incHeight.Name = "incHeight";
            incHeight.Size = new System.Drawing.Size(80, 24);
            incHeight.TabIndex = 105;
            incHeight.Text = "0";
            incHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            incHeight.Value = 0;
            incHeight.ValueChanged += incHeight_ValueChanged;
            // 
            // incWidth
            // 
            incWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            incWidth.Increment = 1;
            incWidth.Location = new System.Drawing.Point(160, 291);
            incWidth.MaxValue = 500;
            incWidth.MinValue = 20;
            incWidth.Name = "incWidth";
            incWidth.Size = new System.Drawing.Size(80, 24);
            incWidth.TabIndex = 106;
            incWidth.Text = "20";
            incWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            incWidth.Value = 20;
            incWidth.ValueChanged += incWidth_ValueChanged;
            // 
            // btnNewDistribution
            // 
            btnNewDistribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNewDistribution.Location = new System.Drawing.Point(392, 75);
            btnNewDistribution.Name = "btnNewDistribution";
            btnNewDistribution.Size = new System.Drawing.Size(80, 28);
            btnNewDistribution.TabIndex = 113;
            btnNewDistribution.Text = "Add New";
            btnNewDistribution.UseVisualStyleBackColor = true;
            btnNewDistribution.Click += btnNewDistribution_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(14, 413);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 18);
            label3.TabIndex = 114;
            label3.Text = "Panel Fore Colour";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(14, 371);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 18);
            label4.TabIndex = 115;
            label4.Text = "Panel Back Color";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnSample });
            toolStrip1.Location = new System.Drawing.Point(659, 356);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(103, 56);
            toolStrip1.TabIndex = 121;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSample
            // 
            btnSample.AutoSize = false;
            btnSample.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSample.Name = "btnSample";
            btnSample.Size = new System.Drawing.Size(100, 53);
            btnSample.Text = "Sample";
            btnSample.Paint += btnSample_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label8.Location = new System.Drawing.Point(514, 310);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(138, 18);
            label8.TabIndex = 132;
            label8.Text = "Text Image Relation";
            // 
            // cmbTextImageRelation
            // 
            cmbTextImageRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTextImageRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbTextImageRelation.FormattingEnabled = true;
            cmbTextImageRelation.Location = new System.Drawing.Point(660, 307);
            cmbTextImageRelation.Name = "cmbTextImageRelation";
            cmbTextImageRelation.Size = new System.Drawing.Size(246, 26);
            cmbTextImageRelation.TabIndex = 131;
            cmbTextImageRelation.SelectionChangeCommitted += cmbTextImageRelation_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label9.Location = new System.Drawing.Point(514, 275);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(71, 18);
            label9.TabIndex = 130;
            label9.Text = "Text Align";
            // 
            // cmbTextAlign
            // 
            cmbTextAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTextAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbTextAlign.FormattingEnabled = true;
            cmbTextAlign.Location = new System.Drawing.Point(659, 272);
            cmbTextAlign.Name = "cmbTextAlign";
            cmbTextAlign.Size = new System.Drawing.Size(246, 26);
            cmbTextAlign.TabIndex = 129;
            cmbTextAlign.SelectionChangeCommitted += cmbTextAlign_SelectionChangeCommitted;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label12.Location = new System.Drawing.Point(514, 240);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(83, 18);
            label12.TabIndex = 128;
            label12.Text = "Image Align";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label11.Location = new System.Drawing.Point(514, 205);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(87, 18);
            label11.TabIndex = 127;
            label11.Text = "Button Style";
            // 
            // cmbImageAlign
            // 
            cmbImageAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbImageAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbImageAlign.FormattingEnabled = true;
            cmbImageAlign.Location = new System.Drawing.Point(659, 237);
            cmbImageAlign.Name = "cmbImageAlign";
            cmbImageAlign.Size = new System.Drawing.Size(246, 26);
            cmbImageAlign.TabIndex = 126;
            cmbImageAlign.SelectionChangeCommitted += cmbImageAlign_SelectionChangeCommitted;
            // 
            // cmbButtonDisplayStyle
            // 
            cmbButtonDisplayStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbButtonDisplayStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbButtonDisplayStyle.FormattingEnabled = true;
            cmbButtonDisplayStyle.Location = new System.Drawing.Point(659, 202);
            cmbButtonDisplayStyle.Name = "cmbButtonDisplayStyle";
            cmbButtonDisplayStyle.Size = new System.Drawing.Size(247, 26);
            cmbButtonDisplayStyle.TabIndex = 125;
            cmbButtonDisplayStyle.SelectionChangeCommitted += cmbButtonDisplayStyle_SelectionChangeCommitted;
            // 
            // lblImageSize
            // 
            lblImageSize.AutoSize = true;
            lblImageSize.Location = new System.Drawing.Point(659, 20);
            lblImageSize.Name = "lblImageSize";
            lblImageSize.Size = new System.Drawing.Size(30, 15);
            lblImageSize.TabIndex = 137;
            lblImageSize.Text = "0 KB";
            // 
            // btnDeletePrepImage
            // 
            btnDeletePrepImage.Image = Properties.Resources.Cancel;
            btnDeletePrepImage.Location = new System.Drawing.Point(786, 96);
            btnDeletePrepImage.Name = "btnDeletePrepImage";
            btnDeletePrepImage.Size = new System.Drawing.Size(48, 48);
            btnDeletePrepImage.TabIndex = 136;
            btnDeletePrepImage.UseVisualStyleBackColor = true;
            btnDeletePrepImage.Click += btnDeletePrepImage_Click;
            // 
            // btnLoadPrepImageFromDirectory
            // 
            btnLoadPrepImageFromDirectory.Image = Properties.Resources.FolderOpen_32;
            btnLoadPrepImageFromDirectory.Location = new System.Drawing.Point(787, 38);
            btnLoadPrepImageFromDirectory.Name = "btnLoadPrepImageFromDirectory";
            btnLoadPrepImageFromDirectory.Size = new System.Drawing.Size(48, 48);
            btnLoadPrepImageFromDirectory.TabIndex = 135;
            btnLoadPrepImageFromDirectory.UseVisualStyleBackColor = true;
            btnLoadPrepImageFromDirectory.Click += btnLoadPrepImageFromDirectory_Click;
            // 
            // pBox
            // 
            pBox.BackColor = System.Drawing.Color.White;
            pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pBox.Location = new System.Drawing.Point(659, 38);
            pBox.Name = "pBox";
            pBox.Size = new System.Drawing.Size(122, 106);
            pBox.TabIndex = 134;
            pBox.TabStop = false;
            pBox.DoubleClick += pBox_DoubleClick;
            // 
            // txtImageFile
            // 
            txtImageFile.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            txtImageFile.Location = new System.Drawing.Point(659, 159);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.ReadOnly = true;
            txtImageFile.Size = new System.Drawing.Size(175, 24);
            txtImageFile.TabIndex = 133;
            // 
            // frmCategoryUpsert
            // 
            ClientSize = new System.Drawing.Size(935, 532);
            ControlBox = false;
            Controls.Add(lblImageSize);
            Controls.Add(btnDeletePrepImage);
            Controls.Add(btnLoadPrepImageFromDirectory);
            Controls.Add(pBox);
            Controls.Add(txtImageFile);
            Controls.Add(label8);
            Controls.Add(cmbTextImageRelation);
            Controls.Add(label9);
            Controls.Add(cmbTextAlign);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cmbImageAlign);
            Controls.Add(cmbButtonDisplayStyle);
            Controls.Add(toolStrip1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnNewDistribution);
            Controls.Add(btnForceDistributionToAllButtons);
            Controls.Add(incWidth);
            Controls.Add(incHeight);
            Controls.Add(label20);
            Controls.Add(incDisplayOrder);
            Controls.Add(cmbDistribution);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(txtCategoryName);
            Controls.Add(label6);
            Controls.Add(btnEntityPanelBackColor);
            Controls.Add(lblFont);
            Controls.Add(btnFont);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnEntityForeColour);
            Controls.Add(cmbEntityType);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmCategoryUpsert";
            Padding = new System.Windows.Forms.Padding(10);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "CATEGORY DETAILS";
            Load += frmCategoryEditor_Load;
            ((System.ComponentModel.ISupportInitialize)globalTypeBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEntityType;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnEntityForeColour;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtCategoryName;
      private System.Windows.Forms.Button btnEntityPanelBackColor;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Label label5;
       private System.Windows.Forms.Label lblFont;
       private System.Windows.Forms.Button btnFont;
       private System.Windows.Forms.Label label7;
       private System.Windows.Forms.Label label6;
       private System.Windows.Forms.ComboBox cmbDistribution;
       private System.Windows.Forms.BindingSource globalTypeBindingSource;
       private System.Windows.Forms.Label label20;
       private PosLibrary.IntegerTextBox incDisplayOrder;
        private System.Windows.Forms.Button btnForceDistributionToAllButtons;
        private PosLibrary.IntegerTextBox incHeight;
        private PosLibrary.IntegerTextBox incWidth;
        private System.Windows.Forms.Button btnNewDistribution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSample;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTextImageRelation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTextAlign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbImageAlign;
        private System.Windows.Forms.ComboBox cmbButtonDisplayStyle;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Button btnDeletePrepImage;
        private System.Windows.Forms.Button btnLoadPrepImageFromDirectory;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.TextBox txtImageFile;
    }
}