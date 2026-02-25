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
      private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlTables));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.chkPrintOrder = new System.Windows.Forms.CheckBox();
            this.chkAddSubTable = new System.Windows.Forms.CheckBox();
            this.chkSplitTable = new System.Windows.Forms.CheckBox();
            this.chkRenameTable = new System.Windows.Forms.CheckBox();
            this.chkChangeTable = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkUnlockTable = new System.Windows.Forms.CheckBox();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.pnlGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Black;
            this.pnlButtons.Controls.Add(this.chkPrintOrder);
            this.pnlButtons.Controls.Add(this.chkAddSubTable);
            this.pnlButtons.Controls.Add(this.chkSplitTable);
            this.pnlButtons.Controls.Add(this.chkRenameTable);
            this.pnlButtons.Controls.Add(this.chkChangeTable);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.chkUnlockTable);
            resources.ApplyResources(this.pnlButtons, "pnlButtons");
            this.pnlButtons.Name = "pnlButtons";
            // 
            // chkPrintOrder
            // 
            resources.ApplyResources(this.chkPrintOrder, "chkPrintOrder");
            this.chkPrintOrder.AutoEllipsis = true;
            this.chkPrintOrder.BackColor = System.Drawing.Color.Fuchsia;
            this.chkPrintOrder.FlatAppearance.BorderSize = 0;
            this.chkPrintOrder.ForeColor = System.Drawing.Color.White;
            this.chkPrintOrder.Image = global::DTRMNS.Properties.Resources.Print32;
            this.chkPrintOrder.Name = "chkPrintOrder";
            this.chkPrintOrder.UseVisualStyleBackColor = false;
            // 
            // chkAddSubTable
            // 
            resources.ApplyResources(this.chkAddSubTable, "chkAddSubTable");
            this.chkAddSubTable.AutoEllipsis = true;
            this.chkAddSubTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkAddSubTable.FlatAppearance.BorderSize = 0;
            this.chkAddSubTable.ForeColor = System.Drawing.Color.White;
            this.chkAddSubTable.Image = global::DTRMNS.Properties.Resources.arti32;
            this.chkAddSubTable.Name = "chkAddSubTable";
            this.chkAddSubTable.UseVisualStyleBackColor = false;
            // 
            // chkSplitTable
            // 
            resources.ApplyResources(this.chkSplitTable, "chkSplitTable");
            this.chkSplitTable.AutoEllipsis = true;
            this.chkSplitTable.BackColor = System.Drawing.Color.DarkRed;
            this.chkSplitTable.FlatAppearance.BorderSize = 0;
            this.chkSplitTable.ForeColor = System.Drawing.Color.White;
            this.chkSplitTable.Image = global::DTRMNS.Properties.Resources.Split32Down;
            this.chkSplitTable.Name = "chkSplitTable";
            this.chkSplitTable.UseVisualStyleBackColor = false;
            // 
            // chkRenameTable
            // 
            resources.ApplyResources(this.chkRenameTable, "chkRenameTable");
            this.chkRenameTable.AutoEllipsis = true;
            this.chkRenameTable.BackColor = System.Drawing.Color.Fuchsia;
            this.chkRenameTable.FlatAppearance.BorderSize = 0;
            this.chkRenameTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkRenameTable.Image = global::DTRMNS.Properties.Resources.bottom_left;
            this.chkRenameTable.Name = "chkRenameTable";
            this.chkRenameTable.UseVisualStyleBackColor = false;
            this.chkRenameTable.CheckedChanged += new System.EventHandler(this.chkRenameTable_CheckedChanged);
            // 
            // chkChangeTable
            // 
            resources.ApplyResources(this.chkChangeTable, "chkChangeTable");
            this.chkChangeTable.AutoEllipsis = true;
            this.chkChangeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkChangeTable.FlatAppearance.BorderSize = 0;
            this.chkChangeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkChangeTable.Image = global::DTRMNS.Properties.Resources.ActionRedo;
            this.chkChangeTable.Name = "chkChangeTable";
            this.chkChangeTable.UseVisualStyleBackColor = false;
            this.chkChangeTable.CheckedChanged += new System.EventHandler(this.chkChangeTable_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::DTRMNS.Properties.Resources.CLOSEBig;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkUnlockTable
            // 
            resources.ApplyResources(this.chkUnlockTable, "chkUnlockTable");
            this.chkUnlockTable.AutoEllipsis = true;
            this.chkUnlockTable.BackColor = System.Drawing.Color.Green;
            this.chkUnlockTable.FlatAppearance.BorderSize = 0;
            this.chkUnlockTable.ForeColor = System.Drawing.Color.White;
            this.chkUnlockTable.Image = global::DTRMNS.Properties.Resources.Link;
            this.chkUnlockTable.Name = "chkUnlockTable";
            this.chkUnlockTable.UseVisualStyleBackColor = false;
            this.chkUnlockTable.CheckedChanged += new System.EventHandler(this.chkUnlockTable_CheckedChanged);
            // 
            // pnlTables
            // 
            this.pnlTables.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnlTables, "pnlTables");
            this.pnlTables.Name = "pnlTables";
            // 
            // pnlGroups
            // 
            this.pnlGroups.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnlGroups, "pnlGroups");
            this.pnlGroups.Name = "pnlGroups";
            // 
            // ctlTables
            // 
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.pnlGroups);
            this.Controls.Add(this.pnlButtons);
            this.Name = "ctlTables";
            resources.ApplyResources(this, "$this");
            this.Load += new System.EventHandler(this.ctlTables_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnlButtons;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.CheckBox chkUnlockTable;
      private System.Windows.Forms.Panel pnlTables;
      private System.Windows.Forms.CheckBox chkChangeTable;
       private System.Windows.Forms.FlowLayoutPanel pnlGroups;
       private System.Windows.Forms.CheckBox chkRenameTable;
        private System.Windows.Forms.CheckBox chkSplitTable;
        private System.Windows.Forms.CheckBox chkAddSubTable;
        private System.Windows.Forms.CheckBox chkPrintOrder;
    }
}
