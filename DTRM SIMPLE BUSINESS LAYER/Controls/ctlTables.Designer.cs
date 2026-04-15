using DTRMNS;
namespace DTRMNS {
   partial class ctlTables {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlButtons = new System.Windows.Forms.Panel();
            chkPrintOrder = new System.Windows.Forms.CheckBox();
            chkAddSubTable = new System.Windows.Forms.CheckBox();
            chkSplitTable = new System.Windows.Forms.CheckBox();
            chkRenameTable = new System.Windows.Forms.CheckBox();
            chkChangeTable = new System.Windows.Forms.CheckBox();
            btnClose = new System.Windows.Forms.Button();
            chkUnlockTable = new System.Windows.Forms.CheckBox();
            pnlTables = new System.Windows.Forms.Panel();
            pnlSalons = new System.Windows.Forms.FlowLayoutPanel();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = System.Drawing.Color.Black;
            pnlButtons.Controls.Add(chkPrintOrder);
            pnlButtons.Controls.Add(chkAddSubTable);
            pnlButtons.Controls.Add(chkSplitTable);
            pnlButtons.Controls.Add(chkRenameTable);
            pnlButtons.Controls.Add(chkChangeTable);
            pnlButtons.Controls.Add(btnClose);
            pnlButtons.Controls.Add(chkUnlockTable);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            pnlButtons.Location = new System.Drawing.Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new System.Windows.Forms.Padding(5);
            pnlButtons.Size = new System.Drawing.Size(717, 60);
            pnlButtons.TabIndex = 0;
            // 
            // chkPrintOrder
            // 
            chkPrintOrder.Appearance = System.Windows.Forms.Appearance.Button;
            chkPrintOrder.AutoEllipsis = true;
            chkPrintOrder.BackColor = System.Drawing.Color.Fuchsia;
            chkPrintOrder.FlatAppearance.BorderSize = 0;
            chkPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkPrintOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            chkPrintOrder.ForeColor = System.Drawing.Color.White;
            chkPrintOrder.Image = Properties.Resources.Print32;
            chkPrintOrder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            chkPrintOrder.Location = new System.Drawing.Point(486, 5);
            chkPrintOrder.Name = "chkPrintOrder";
            chkPrintOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkPrintOrder.Size = new System.Drawing.Size(90, 50);
            chkPrintOrder.TabIndex = 14;
            chkPrintOrder.Text = "PRINT\r\nORDER";
            chkPrintOrder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            chkPrintOrder.UseVisualStyleBackColor = false;
            // 
            // chkAddSubTable
            // 
            chkAddSubTable.Appearance = System.Windows.Forms.Appearance.Button;
            chkAddSubTable.AutoEllipsis = true;
            chkAddSubTable.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            chkAddSubTable.FlatAppearance.BorderSize = 0;
            chkAddSubTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkAddSubTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            chkAddSubTable.ForeColor = System.Drawing.Color.White;
            chkAddSubTable.Image = Properties.Resources.arti32;
            chkAddSubTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            chkAddSubTable.Location = new System.Drawing.Point(390, 5);
            chkAddSubTable.Name = "chkAddSubTable";
            chkAddSubTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkAddSubTable.Size = new System.Drawing.Size(90, 50);
            chkAddSubTable.TabIndex = 13;
            chkAddSubTable.Text = "ADD\r\nORDER";
            chkAddSubTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            chkAddSubTable.UseVisualStyleBackColor = false;
            // 
            // chkSplitTable
            // 
            chkSplitTable.Appearance = System.Windows.Forms.Appearance.Button;
            chkSplitTable.AutoEllipsis = true;
            chkSplitTable.BackColor = System.Drawing.Color.DarkRed;
            chkSplitTable.FlatAppearance.BorderSize = 0;
            chkSplitTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkSplitTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            chkSplitTable.ForeColor = System.Drawing.Color.White;
            chkSplitTable.Image = Properties.Resources.Split32Down;
            chkSplitTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            chkSplitTable.Location = new System.Drawing.Point(294, 5);
            chkSplitTable.Name = "chkSplitTable";
            chkSplitTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkSplitTable.Size = new System.Drawing.Size(90, 50);
            chkSplitTable.TabIndex = 12;
            chkSplitTable.Text = "SPLIT\r\nORDER";
            chkSplitTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            chkSplitTable.UseVisualStyleBackColor = false;
            // 
            // chkRenameTable
            // 
            chkRenameTable.Appearance = System.Windows.Forms.Appearance.Button;
            chkRenameTable.AutoEllipsis = true;
            chkRenameTable.BackColor = System.Drawing.Color.Fuchsia;
            chkRenameTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chkRenameTable.FlatAppearance.BorderSize = 0;
            chkRenameTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkRenameTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            chkRenameTable.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            chkRenameTable.Image = Properties.Resources.bottom_left;
            chkRenameTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            chkRenameTable.Location = new System.Drawing.Point(198, 5);
            chkRenameTable.Name = "chkRenameTable";
            chkRenameTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkRenameTable.Size = new System.Drawing.Size(90, 50);
            chkRenameTable.TabIndex = 11;
            chkRenameTable.Text = "TABLE\r\nRENAME";
            chkRenameTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            chkRenameTable.UseVisualStyleBackColor = false;
            chkRenameTable.CheckedChanged += chkRenameTable_CheckedChanged;
            // 
            // chkChangeTable
            // 
            chkChangeTable.Appearance = System.Windows.Forms.Appearance.Button;
            chkChangeTable.AutoEllipsis = true;
            chkChangeTable.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            chkChangeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chkChangeTable.FlatAppearance.BorderSize = 0;
            chkChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkChangeTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            chkChangeTable.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            chkChangeTable.Image = Properties.Resources.ActionRedo;
            chkChangeTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            chkChangeTable.Location = new System.Drawing.Point(102, 5);
            chkChangeTable.Name = "chkChangeTable";
            chkChangeTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkChangeTable.Size = new System.Drawing.Size(90, 50);
            chkChangeTable.TabIndex = 5;
            chkChangeTable.Text = "MOVE\r\nTABLE";
            chkChangeTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            chkChangeTable.UseVisualStyleBackColor = false;
            chkChangeTable.CheckedChanged += chkChangeTable_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.BackColor = System.Drawing.Color.Black;
            btnClose.BackgroundImage = Properties.Resources.Cancel;
            btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(632, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(80, 50);
            btnClose.TabIndex = 0;
            btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // chkUnlockTable
            // 
            chkUnlockTable.Appearance = System.Windows.Forms.Appearance.Button;
            chkUnlockTable.AutoEllipsis = true;
            chkUnlockTable.BackColor = System.Drawing.Color.Green;
            chkUnlockTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chkUnlockTable.Dock = System.Windows.Forms.DockStyle.Left;
            chkUnlockTable.FlatAppearance.BorderSize = 0;
            chkUnlockTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkUnlockTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            chkUnlockTable.ForeColor = System.Drawing.Color.White;
            chkUnlockTable.Image = Properties.Resources.Link;
            chkUnlockTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            chkUnlockTable.Location = new System.Drawing.Point(5, 5);
            chkUnlockTable.Name = "chkUnlockTable";
            chkUnlockTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            chkUnlockTable.Size = new System.Drawing.Size(90, 50);
            chkUnlockTable.TabIndex = 4;
            chkUnlockTable.Text = "TABLE\r\nUNLOCK";
            chkUnlockTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            chkUnlockTable.UseVisualStyleBackColor = false;
            chkUnlockTable.CheckedChanged += chkUnlockTable_CheckedChanged;
            // 
            // pnlTables
            // 
            pnlTables.BackColor = System.Drawing.Color.Black;
            pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTables.Location = new System.Drawing.Point(110, 60);
            pnlTables.Name = "pnlTables";
            pnlTables.Size = new System.Drawing.Size(607, 476);
            pnlTables.TabIndex = 1;
            // 
            // pnlSalons
            // 
            pnlSalons.BackColor = System.Drawing.Color.Black;
            pnlSalons.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSalons.Location = new System.Drawing.Point(0, 60);
            pnlSalons.Name = "pnlSalons";
            pnlSalons.Padding = new System.Windows.Forms.Padding(10);
            pnlSalons.Size = new System.Drawing.Size(110, 476);
            pnlSalons.TabIndex = 2;
            // 
            // ctlTables
            // 
            Controls.Add(pnlTables);
            Controls.Add(pnlSalons);
            Controls.Add(pnlButtons);
            Name = "ctlTables";
            Size = new System.Drawing.Size(717, 536);
            Load += ctlTables_Load;
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.CheckBox chkUnlockTable;
      private System.Windows.Forms.Panel pnlTables;
      private System.Windows.Forms.CheckBox chkChangeTable;
       private System.Windows.Forms.FlowLayoutPanel pnlSalons;
       private System.Windows.Forms.CheckBox chkRenameTable;
        private System.Windows.Forms.CheckBox chkSplitTable;
        private System.Windows.Forms.CheckBox chkAddSubTable;
        private System.Windows.Forms.CheckBox chkPrintOrder;
    }
}
