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
            txtEntityName = new System.Windows.Forms.TextBox();
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
            btnMinusWidth = new System.Windows.Forms.Button();
            btnPlusWidth = new System.Windows.Forms.Button();
            btnMInusHeight = new System.Windows.Forms.Button();
            btnPlusHeight = new System.Windows.Forms.Button();
            btnMinusOrder = new System.Windows.Forms.Button();
            btnPlusOrder = new System.Windows.Forms.Button();
            btnNewDistribution = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)globalTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cmbEntityType
            // 
            cmbEntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEntityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cmbEntityType.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbEntityType.FormattingEnabled = true;
            cmbEntityType.Items.AddRange(new object[] { "Normal Category", "Extra & Disco" });
            cmbEntityType.Location = new System.Drawing.Point(27, 156);
            cmbEntityType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            cmbEntityType.Name = "cmbEntityType";
            cmbEntityType.Size = new System.Drawing.Size(220, 28);
            cmbEntityType.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(27, 139);
            label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 37;
            label1.Text = "Category Type";
            // 
            // btnEntityForeColour
            // 
            btnEntityForeColour.FlatAppearance.BorderSize = 0;
            btnEntityForeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnEntityForeColour.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEntityForeColour.Location = new System.Drawing.Point(569, 87);
            btnEntityForeColour.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            btnEntityForeColour.Name = "btnEntityForeColour";
            btnEntityForeColour.Size = new System.Drawing.Size(129, 35);
            btnEntityForeColour.TabIndex = 35;
            btnEntityForeColour.Text = "Panel Fore Colour";
            btnEntityForeColour.UseVisualStyleBackColor = false;
            btnEntityForeColour.Click += btnEntityForeColour_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(27, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 13);
            label2.TabIndex = 29;
            label2.Text = "Category Name";
            // 
            // txtEntityName
            // 
            txtEntityName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            txtEntityName.Location = new System.Drawing.Point(27, 39);
            txtEntityName.Name = "txtEntityName";
            txtEntityName.Size = new System.Drawing.Size(221, 26);
            txtEntityName.TabIndex = 28;
            txtEntityName.Click += txtEntityName_Click;
            // 
            // btnEntityPanelBackColor
            // 
            btnEntityPanelBackColor.FlatAppearance.BorderSize = 0;
            btnEntityPanelBackColor.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEntityPanelBackColor.Location = new System.Drawing.Point(569, 30);
            btnEntityPanelBackColor.Name = "btnEntityPanelBackColor";
            btnEntityPanelBackColor.Size = new System.Drawing.Size(129, 35);
            btnEntityPanelBackColor.TabIndex = 32;
            btnEntityPanelBackColor.Text = "Panel Back Color";
            btnEntityPanelBackColor.UseVisualStyleBackColor = false;
            btnEntityPanelBackColor.Click += btnEntityPanelColor_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Location = new System.Drawing.Point(396, 263);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(137, 48);
            btnClose.TabIndex = 40;
            btnClose.Text = "CANCEL";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Location = new System.Drawing.Point(573, 263);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(125, 48);
            btnSave.TabIndex = 41;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(27, 77);
            label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 13);
            label5.TabIndex = 50;
            label5.Text = "Distribution";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblFont.ForeColor = System.Drawing.SystemColors.ControlText;
            lblFont.Location = new System.Drawing.Point(27, 196);
            lblFont.Name = "lblFont";
            lblFont.Size = new System.Drawing.Size(28, 13);
            lblFont.TabIndex = 80;
            lblFont.Text = "Font";
            // 
            // btnFont
            // 
            btnFont.BackColor = System.Drawing.SystemColors.Control;
            btnFont.FlatAppearance.BorderSize = 0;
            btnFont.ForeColor = System.Drawing.SystemColors.ControlText;
            btnFont.Location = new System.Drawing.Point(27, 212);
            btnFont.Name = "btnFont";
            btnFont.Size = new System.Drawing.Size(220, 30);
            btnFont.TabIndex = 81;
            btnFont.UseVisualStyleBackColor = false;
            btnFont.Click += btnFont_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(315, 140);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 13);
            label7.TabIndex = 91;
            label7.Text = "Button Width";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(315, 78);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 13);
            label6.TabIndex = 90;
            label6.Text = "Button Height";
            // 
            // cmbDistribution
            // 
            cmbDistribution.DataSource = globalTypeBindingSource;
            cmbDistribution.DisplayMember = "Name";
            cmbDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cmbDistribution.FormattingEnabled = true;
            cmbDistribution.Location = new System.Drawing.Point(27, 94);
            cmbDistribution.Name = "cmbDistribution";
            cmbDistribution.Size = new System.Drawing.Size(220, 28);
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
            label20.Location = new System.Drawing.Point(315, 21);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(78, 15);
            label20.TabIndex = 102;
            label20.Text = "Display Order";
            // 
            // incDisplayOrder
            // 
            incDisplayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            incDisplayOrder.Increment = 1;
            incDisplayOrder.Location = new System.Drawing.Point(315, 36);
            incDisplayOrder.MaxValue = 1000;
            incDisplayOrder.MinValue = 0;
            incDisplayOrder.Name = "incDisplayOrder";
            incDisplayOrder.Size = new System.Drawing.Size(80, 26);
            incDisplayOrder.TabIndex = 101;
            incDisplayOrder.Text = "0";
            incDisplayOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            incDisplayOrder.Value = 0;
            // 
            // btnForceDistributionToAllButtons
            // 
            btnForceDistributionToAllButtons.Location = new System.Drawing.Point(318, 199);
            btnForceDistributionToAllButtons.Name = "btnForceDistributionToAllButtons";
            btnForceDistributionToAllButtons.Size = new System.Drawing.Size(215, 43);
            btnForceDistributionToAllButtons.TabIndex = 103;
            btnForceDistributionToAllButtons.Text = "FORCE ALL BUTTONS HAVE THE SAME DISTRIBUTION";
            btnForceDistributionToAllButtons.UseVisualStyleBackColor = true;
            btnForceDistributionToAllButtons.Click += btnForceDistributionToAllButtons_Click;
            // 
            // incHeight
            // 
            incHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            incHeight.Increment = 1;
            incHeight.Location = new System.Drawing.Point(315, 93);
            incHeight.MaxValue = 1000;
            incHeight.MinValue = 0;
            incHeight.Name = "incHeight";
            incHeight.Size = new System.Drawing.Size(80, 26);
            incHeight.TabIndex = 105;
            incHeight.Text = "0";
            incHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            incHeight.Value = 0;
            // 
            // incWidth
            // 
            incWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            incWidth.Increment = 1;
            incWidth.Location = new System.Drawing.Point(315, 155);
            incWidth.MaxValue = 500;
            incWidth.MinValue = 20;
            incWidth.Name = "incWidth";
            incWidth.Size = new System.Drawing.Size(80, 26);
            incWidth.TabIndex = 106;
            incWidth.Text = "20";
            incWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            incWidth.Value = 20;
            // 
            // btnMinusWidth
            // 
            btnMinusWidth.Image = Properties.Resources.eksi32;
            btnMinusWidth.Location = new System.Drawing.Point(473, 149);
            btnMinusWidth.Name = "btnMinusWidth";
            btnMinusWidth.Size = new System.Drawing.Size(60, 35);
            btnMinusWidth.TabIndex = 108;
            btnMinusWidth.UseVisualStyleBackColor = true;
            btnMinusWidth.Click += btnMinusWidth_Click;
            // 
            // btnPlusWidth
            // 
            btnPlusWidth.Image = Properties.Resources.arti32;
            btnPlusWidth.Location = new System.Drawing.Point(407, 149);
            btnPlusWidth.Name = "btnPlusWidth";
            btnPlusWidth.Size = new System.Drawing.Size(60, 35);
            btnPlusWidth.TabIndex = 107;
            btnPlusWidth.UseVisualStyleBackColor = true;
            btnPlusWidth.Click += btnPlusWidth_Click;
            // 
            // btnMInusHeight
            // 
            btnMInusHeight.Image = Properties.Resources.eksi32;
            btnMInusHeight.Location = new System.Drawing.Point(473, 87);
            btnMInusHeight.Name = "btnMInusHeight";
            btnMInusHeight.Size = new System.Drawing.Size(60, 35);
            btnMInusHeight.TabIndex = 110;
            btnMInusHeight.UseVisualStyleBackColor = true;
            btnMInusHeight.Click += btnMInusHeight_Click;
            // 
            // btnPlusHeight
            // 
            btnPlusHeight.Image = Properties.Resources.arti32;
            btnPlusHeight.Location = new System.Drawing.Point(407, 87);
            btnPlusHeight.Name = "btnPlusHeight";
            btnPlusHeight.Size = new System.Drawing.Size(60, 35);
            btnPlusHeight.TabIndex = 109;
            btnPlusHeight.UseVisualStyleBackColor = true;
            btnPlusHeight.Click += btnPlusHeight_Click;
            // 
            // btnMinusOrder
            // 
            btnMinusOrder.Image = Properties.Resources.eksi32;
            btnMinusOrder.Location = new System.Drawing.Point(473, 30);
            btnMinusOrder.Name = "btnMinusOrder";
            btnMinusOrder.Size = new System.Drawing.Size(60, 35);
            btnMinusOrder.TabIndex = 112;
            btnMinusOrder.UseVisualStyleBackColor = true;
            btnMinusOrder.Click += btnMinusOrder_Click;
            // 
            // btnPlusOrder
            // 
            btnPlusOrder.Image = Properties.Resources.arti32;
            btnPlusOrder.Location = new System.Drawing.Point(407, 30);
            btnPlusOrder.Name = "btnPlusOrder";
            btnPlusOrder.Size = new System.Drawing.Size(60, 35);
            btnPlusOrder.TabIndex = 111;
            btnPlusOrder.UseVisualStyleBackColor = true;
            btnPlusOrder.Click += btnPlusOrder_Click;
            // 
            // btnNewDistribution
            // 
            btnNewDistribution.BackgroundImage = Properties.Resources.arti32;
            btnNewDistribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNewDistribution.Location = new System.Drawing.Point(252, 94);
            btnNewDistribution.Name = "btnNewDistribution";
            btnNewDistribution.Size = new System.Drawing.Size(28, 28);
            btnNewDistribution.TabIndex = 113;
            btnNewDistribution.UseVisualStyleBackColor = true;
            btnNewDistribution.Click += btnNewDistribution_Click;
            // 
            // frmEntityEditor
            // 
            ClientSize = new System.Drawing.Size(729, 338);
            ControlBox = false;
            Controls.Add(btnNewDistribution);
            Controls.Add(btnForceDistributionToAllButtons);
            Controls.Add(btnMinusOrder);
            Controls.Add(btnPlusOrder);
            Controls.Add(btnMInusHeight);
            Controls.Add(btnPlusHeight);
            Controls.Add(btnMinusWidth);
            Controls.Add(btnPlusWidth);
            Controls.Add(incWidth);
            Controls.Add(incHeight);
            Controls.Add(label20);
            Controls.Add(incDisplayOrder);
            Controls.Add(cmbDistribution);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(txtEntityName);
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
            Name = "frmEntityEditor";
            Padding = new System.Windows.Forms.Padding(10);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "CATEGORY  EDITOR";
            Load += frmCategoryEditor_Load;
            ((System.ComponentModel.ISupportInitialize)globalTypeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEntityType;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnEntityForeColour;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtEntityName;
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
        private System.Windows.Forms.Button btnMinusWidth;
        private System.Windows.Forms.Button btnPlusWidth;
        private System.Windows.Forms.Button btnMInusHeight;
        private System.Windows.Forms.Button btnPlusHeight;
        private System.Windows.Forms.Button btnMinusOrder;
        private System.Windows.Forms.Button btnPlusOrder;
        private System.Windows.Forms.Button btnNewDistribution;
    }
}