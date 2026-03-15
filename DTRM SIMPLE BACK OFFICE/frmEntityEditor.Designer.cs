using POSLayer.Models;

namespace DTRMSimpleBackOffice {
   partial class frmEntityEditor {
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
      private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cmbEntityType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntityForeColour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.btnEntityPanelBackColor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDistribution = new System.Windows.Forms.ComboBox();
            this.globalTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.incDisplayOrder = new PosLibrary.IntegerTextBox();
            this.btnForceDistributionToAllButtons = new System.Windows.Forms.Button();
            this.incHeight = new PosLibrary.IntegerTextBox();
            this.incWidth = new PosLibrary.IntegerTextBox();
            this.btnMinusWidth = new System.Windows.Forms.Button();
            this.btnPlusWidth = new System.Windows.Forms.Button();
            this.btnMInusHeight = new System.Windows.Forms.Button();
            this.btnPlusHeight = new System.Windows.Forms.Button();
            this.btnMinusOrder = new System.Windows.Forms.Button();
            this.btnPlusOrder = new System.Windows.Forms.Button();
            this.btnNewDistribution = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.globalTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEntityType
            // 
            this.cmbEntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEntityType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbEntityType.FormattingEnabled = true;
            this.cmbEntityType.Items.AddRange(new object[] {
            "Normal Category",
            "Extra & Disco"});
            this.cmbEntityType.Location = new System.Drawing.Point(27, 156);
            this.cmbEntityType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cmbEntityType.Name = "cmbEntityType";
            this.cmbEntityType.Size = new System.Drawing.Size(220, 28);
            this.cmbEntityType.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Category Type";
            // 
            // btnEntityForeColour
            // 
            this.btnEntityForeColour.FlatAppearance.BorderSize = 0;
            this.btnEntityForeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEntityForeColour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntityForeColour.Location = new System.Drawing.Point(569, 87);
            this.btnEntityForeColour.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btnEntityForeColour.Name = "btnEntityForeColour";
            this.btnEntityForeColour.Size = new System.Drawing.Size(129, 35);
            this.btnEntityForeColour.TabIndex = 35;
            this.btnEntityForeColour.Text = "Panel Fore Colour";
            this.btnEntityForeColour.UseVisualStyleBackColor = false;
            this.btnEntityForeColour.Click += new System.EventHandler(this.btnEntityForeColour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Category Name";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtEntityName.Location = new System.Drawing.Point(27, 39);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(221, 26);
            this.txtEntityName.TabIndex = 28;
            this.txtEntityName.Click += new System.EventHandler(this.txtEntityName_Click);
            // 
            // btnEntityPanelBackColor
            // 
            this.btnEntityPanelBackColor.FlatAppearance.BorderSize = 0;
            this.btnEntityPanelBackColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntityPanelBackColor.Location = new System.Drawing.Point(569, 30);
            this.btnEntityPanelBackColor.Name = "btnEntityPanelBackColor";
            this.btnEntityPanelBackColor.Size = new System.Drawing.Size(129, 35);
            this.btnEntityPanelBackColor.TabIndex = 32;
            this.btnEntityPanelBackColor.Text = "Panel Back Color";
            this.btnEntityPanelBackColor.UseVisualStyleBackColor = false;
            this.btnEntityPanelBackColor.Click += new System.EventHandler(this.btnEntityPanelColor_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(396, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 48);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "CANCEL";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.Location = new System.Drawing.Point(573, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 48);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(27, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Distribution";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFont.Location = new System.Drawing.Point(27, 196);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 80;
            this.lblFont.Text = "Font";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.Control;
            this.btnFont.FlatAppearance.BorderSize = 0;
            this.btnFont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFont.Location = new System.Drawing.Point(27, 212);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(220, 30);
            this.btnFont.TabIndex = 81;
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(315, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Button Width";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(315, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Button Height";
            // 
            // cmbDistribution
            // 
            this.cmbDistribution.DataSource = this.globalTypeBindingSource;
            this.cmbDistribution.DisplayMember = "DistributionName";
            this.cmbDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDistribution.FormattingEnabled = true;
            this.cmbDistribution.Location = new System.Drawing.Point(27, 94);
            this.cmbDistribution.Name = "cmbDistribution";
            this.cmbDistribution.Size = new System.Drawing.Size(220, 28);
            this.cmbDistribution.TabIndex = 99;
            this.cmbDistribution.ValueMember = "IID";
            // 
            // globalTypeBindingSource
            // 
            this.globalTypeBindingSource.DataSource = typeof(Distribution);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(315, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 102;
            this.label20.Text = "Display Order";
            // 
            // incDisplayOrder
            // 
            this.incDisplayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incDisplayOrder.Increment = 1;
            this.incDisplayOrder.Location = new System.Drawing.Point(315, 36);
            this.incDisplayOrder.MaxValue = 1000;
            this.incDisplayOrder.MinValue = 0;
            this.incDisplayOrder.Name = "incDisplayOrder";
            this.incDisplayOrder.Size = new System.Drawing.Size(80, 26);
            this.incDisplayOrder.TabIndex = 101;
            this.incDisplayOrder.Text = "0";
            this.incDisplayOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incDisplayOrder.Value = 0;
            // 
            // btnForceDistributionToAllButtons
            // 
            this.btnForceDistributionToAllButtons.Location = new System.Drawing.Point(318, 199);
            this.btnForceDistributionToAllButtons.Name = "btnForceDistributionToAllButtons";
            this.btnForceDistributionToAllButtons.Size = new System.Drawing.Size(215, 43);
            this.btnForceDistributionToAllButtons.TabIndex = 103;
            this.btnForceDistributionToAllButtons.Text = "FORCE ALL BUTTONS HAVE THE SAME DISTRIBUTION";
            this.btnForceDistributionToAllButtons.UseVisualStyleBackColor = true;
            this.btnForceDistributionToAllButtons.Click += new System.EventHandler(this.btnForceDistributionToAllButtons_Click);
            // 
            // incHeight
            // 
            this.incHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incHeight.Increment = 1;
            this.incHeight.Location = new System.Drawing.Point(315, 93);
            this.incHeight.MaxValue = 1000;
            this.incHeight.MinValue = 0;
            this.incHeight.Name = "incHeight";
            this.incHeight.Size = new System.Drawing.Size(80, 26);
            this.incHeight.TabIndex = 105;
            this.incHeight.Text = "0";
            this.incHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incHeight.Value = 0;
            // 
            // incWidth
            // 
            this.incWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incWidth.Increment = 1;
            this.incWidth.Location = new System.Drawing.Point(315, 155);
            this.incWidth.MaxValue = 500;
            this.incWidth.MinValue = 20;
            this.incWidth.Name = "incWidth";
            this.incWidth.Size = new System.Drawing.Size(80, 26);
            this.incWidth.TabIndex = 106;
            this.incWidth.Text = "20";
            this.incWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incWidth.Value = 20;
            // 
            // btnMinusWidth
            // 
            this.btnMinusWidth.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMinusWidth.Location = new System.Drawing.Point(473, 149);
            this.btnMinusWidth.Name = "btnMinusWidth";
            this.btnMinusWidth.Size = new System.Drawing.Size(60, 35);
            this.btnMinusWidth.TabIndex = 108;
            this.btnMinusWidth.UseVisualStyleBackColor = true;
            this.btnMinusWidth.Click += new System.EventHandler(this.btnMinusWidth_Click);
            // 
            // btnPlusWidth
            // 
            this.btnPlusWidth.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusWidth.Location = new System.Drawing.Point(407, 149);
            this.btnPlusWidth.Name = "btnPlusWidth";
            this.btnPlusWidth.Size = new System.Drawing.Size(60, 35);
            this.btnPlusWidth.TabIndex = 107;
            this.btnPlusWidth.UseVisualStyleBackColor = true;
            this.btnPlusWidth.Click += new System.EventHandler(this.btnPlusWidth_Click);
            // 
            // btnMInusHeight
            // 
            this.btnMInusHeight.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMInusHeight.Location = new System.Drawing.Point(473, 87);
            this.btnMInusHeight.Name = "btnMInusHeight";
            this.btnMInusHeight.Size = new System.Drawing.Size(60, 35);
            this.btnMInusHeight.TabIndex = 110;
            this.btnMInusHeight.UseVisualStyleBackColor = true;
            this.btnMInusHeight.Click += new System.EventHandler(this.btnMInusHeight_Click);
            // 
            // btnPlusHeight
            // 
            this.btnPlusHeight.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusHeight.Location = new System.Drawing.Point(407, 87);
            this.btnPlusHeight.Name = "btnPlusHeight";
            this.btnPlusHeight.Size = new System.Drawing.Size(60, 35);
            this.btnPlusHeight.TabIndex = 109;
            this.btnPlusHeight.UseVisualStyleBackColor = true;
            this.btnPlusHeight.Click += new System.EventHandler(this.btnPlusHeight_Click);
            // 
            // btnMinusOrder
            // 
            this.btnMinusOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.eksi32;
            this.btnMinusOrder.Location = new System.Drawing.Point(473, 30);
            this.btnMinusOrder.Name = "btnMinusOrder";
            this.btnMinusOrder.Size = new System.Drawing.Size(60, 35);
            this.btnMinusOrder.TabIndex = 112;
            this.btnMinusOrder.UseVisualStyleBackColor = true;
            this.btnMinusOrder.Click += new System.EventHandler(this.btnMinusOrder_Click);
            // 
            // btnPlusOrder
            // 
            this.btnPlusOrder.Image = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnPlusOrder.Location = new System.Drawing.Point(407, 30);
            this.btnPlusOrder.Name = "btnPlusOrder";
            this.btnPlusOrder.Size = new System.Drawing.Size(60, 35);
            this.btnPlusOrder.TabIndex = 111;
            this.btnPlusOrder.UseVisualStyleBackColor = true;
            this.btnPlusOrder.Click += new System.EventHandler(this.btnPlusOrder_Click);
            // 
            // btnNewDistribution
            // 
            this.btnNewDistribution.BackgroundImage = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnNewDistribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewDistribution.Location = new System.Drawing.Point(252, 94);
            this.btnNewDistribution.Name = "btnNewDistribution";
            this.btnNewDistribution.Size = new System.Drawing.Size(28, 28);
            this.btnNewDistribution.TabIndex = 113;
            this.btnNewDistribution.UseVisualStyleBackColor = true;
            this.btnNewDistribution.Click += new System.EventHandler(this.btnNewDistribution_Click);
            // 
            // frmEntityEditor
            // 
            this.ClientSize = new System.Drawing.Size(729, 338);
            this.ControlBox = false;
            this.Controls.Add(this.btnNewDistribution);
            this.Controls.Add(this.btnForceDistributionToAllButtons);
            this.Controls.Add(this.btnMinusOrder);
            this.Controls.Add(this.btnPlusOrder);
            this.Controls.Add(this.btnMInusHeight);
            this.Controls.Add(this.btnPlusHeight);
            this.Controls.Add(this.btnMinusWidth);
            this.Controls.Add(this.btnPlusWidth);
            this.Controls.Add(this.incWidth);
            this.Controls.Add(this.incHeight);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.incDisplayOrder);
            this.Controls.Add(this.cmbDistribution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEntityPanelBackColor);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEntityForeColour);
            this.Controls.Add(this.cmbEntityType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEntityEditor";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CATEGORY  EDITOR";
            this.Load += new System.EventHandler(this.frmCategoryEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.globalTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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