namespace WinLayer {
    partial class frmSubTableSelector {
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
            this.pnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkChangeTableName = new System.Windows.Forms.CheckBox();
            this.btnAddSubTable = new System.Windows.Forms.Button();
            this.chkChangeTable = new System.Windows.Forms.CheckBox();
            this.btnPrintAllTables = new System.Windows.Forms.Button();
            this.btnJoinAllTables = new System.Windows.Forms.Button();
            this.chkPrintTableOrder = new System.Windows.Forms.CheckBox();
            this.chkJoin2Table = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnlTables
            // 
            this.pnlTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTables.Location = new System.Drawing.Point(30, 23);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Padding = new System.Windows.Forms.Padding(20);
            this.pnlTables.Size = new System.Drawing.Size(721, 336);
            this.pnlTables.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.BackgroundImage = global::WinLayer.Properties.Resources.CLOSEBig;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(661, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 80);
            this.btnClose.TabIndex = 51;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkChangeTableName
            // 
            this.chkChangeTableName.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChangeTableName.AutoEllipsis = true;
            this.chkChangeTableName.BackColor = System.Drawing.Color.Green;
            this.chkChangeTableName.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.chkChangeTableName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkChangeTableName.FlatAppearance.BorderSize = 0;
            this.chkChangeTableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkChangeTableName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.chkChangeTableName.ForeColor = System.Drawing.Color.White;
            this.chkChangeTableName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkChangeTableName.Location = new System.Drawing.Point(30, 376);
            this.chkChangeTableName.Name = "chkChangeTableName";
            this.chkChangeTableName.Size = new System.Drawing.Size(90, 80);
            this.chkChangeTableName.TabIndex = 52;
            this.chkChangeTableName.Text = "CHANGE TABLE NAME";
            this.chkChangeTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkChangeTableName.UseVisualStyleBackColor = false;
            // 
            // btnAddSubTable
            // 
            this.btnAddSubTable.AutoEllipsis = true;
            this.btnAddSubTable.BackColor = System.Drawing.Color.Green;
            this.btnAddSubTable.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnAddSubTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSubTable.FlatAppearance.BorderSize = 0;
            this.btnAddSubTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubTable.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddSubTable.ForeColor = System.Drawing.Color.White;
            this.btnAddSubTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddSubTable.Location = new System.Drawing.Point(135, 376);
            this.btnAddSubTable.Name = "btnAddSubTable";
            this.btnAddSubTable.Size = new System.Drawing.Size(90, 80);
            this.btnAddSubTable.TabIndex = 53;
            this.btnAddSubTable.TabStop = false;
            this.btnAddSubTable.Text = "ADD\r\nTABLE";
            this.btnAddSubTable.UseVisualStyleBackColor = false;
            // 
            // chkChangeTable
            // 
            this.chkChangeTable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChangeTable.AutoEllipsis = true;
            this.chkChangeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkChangeTable.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.chkChangeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkChangeTable.FlatAppearance.BorderSize = 0;
            this.chkChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkChangeTable.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.chkChangeTable.ForeColor = System.Drawing.Color.White;
            this.chkChangeTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkChangeTable.Location = new System.Drawing.Point(240, 376);
            this.chkChangeTable.Name = "chkChangeTable";
            this.chkChangeTable.Size = new System.Drawing.Size(90, 80);
            this.chkChangeTable.TabIndex = 54;
            this.chkChangeTable.Text = "MOVE\r\nTABLE";
            this.chkChangeTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkChangeTable.UseVisualStyleBackColor = false;
            // 
            // btnPrintAllTables
            // 
            this.btnPrintAllTables.AutoEllipsis = true;
            this.btnPrintAllTables.BackColor = System.Drawing.Color.Purple;
            this.btnPrintAllTables.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnPrintAllTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintAllTables.FlatAppearance.BorderSize = 0;
            this.btnPrintAllTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAllTables.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrintAllTables.ForeColor = System.Drawing.Color.White;
            this.btnPrintAllTables.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintAllTables.Location = new System.Drawing.Point(135, 473);
            this.btnPrintAllTables.Name = "btnPrintAllTables";
            this.btnPrintAllTables.Size = new System.Drawing.Size(90, 80);
            this.btnPrintAllTables.TabIndex = 55;
            this.btnPrintAllTables.TabStop = false;
            this.btnPrintAllTables.Text = "PRINT ALL TABLES";
            this.btnPrintAllTables.UseVisualStyleBackColor = false;
            // 
            // btnJoinAllTables
            // 
            this.btnJoinAllTables.AutoEllipsis = true;
            this.btnJoinAllTables.BackColor = System.Drawing.Color.Blue;
            this.btnJoinAllTables.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnJoinAllTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoinAllTables.FlatAppearance.BorderSize = 0;
            this.btnJoinAllTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinAllTables.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnJoinAllTables.ForeColor = System.Drawing.Color.White;
            this.btnJoinAllTables.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnJoinAllTables.Location = new System.Drawing.Point(555, 376);
            this.btnJoinAllTables.Name = "btnJoinAllTables";
            this.btnJoinAllTables.Size = new System.Drawing.Size(90, 80);
            this.btnJoinAllTables.TabIndex = 56;
            this.btnJoinAllTables.TabStop = false;
            this.btnJoinAllTables.Text = "JOIN \r\nALL \r\nTABLES";
            this.btnJoinAllTables.UseVisualStyleBackColor = false;
            this.btnJoinAllTables.Click += new System.EventHandler(this.btnJoinAllTables_Click);
            // 
            // chkPrintTableOrder
            // 
            this.chkPrintTableOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrintTableOrder.AutoEllipsis = true;
            this.chkPrintTableOrder.BackColor = System.Drawing.Color.Fuchsia;
            this.chkPrintTableOrder.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.chkPrintTableOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkPrintTableOrder.FlatAppearance.BorderSize = 0;
            this.chkPrintTableOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrintTableOrder.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.chkPrintTableOrder.ForeColor = System.Drawing.Color.White;
            this.chkPrintTableOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPrintTableOrder.Location = new System.Drawing.Point(30, 473);
            this.chkPrintTableOrder.Name = "chkPrintTableOrder";
            this.chkPrintTableOrder.Size = new System.Drawing.Size(90, 80);
            this.chkPrintTableOrder.TabIndex = 58;
            this.chkPrintTableOrder.Text = "PRINT TABLE ORDER";
            this.chkPrintTableOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrintTableOrder.UseVisualStyleBackColor = false;
            // 
            // chkJoin2Table
            // 
            this.chkJoin2Table.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkJoin2Table.AutoEllipsis = true;
            this.chkJoin2Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkJoin2Table.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.chkJoin2Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkJoin2Table.FlatAppearance.BorderSize = 0;
            this.chkJoin2Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkJoin2Table.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.chkJoin2Table.ForeColor = System.Drawing.Color.White;
            this.chkJoin2Table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkJoin2Table.Location = new System.Drawing.Point(450, 376);
            this.chkJoin2Table.Name = "chkJoin2Table";
            this.chkJoin2Table.Size = new System.Drawing.Size(90, 80);
            this.chkJoin2Table.TabIndex = 59;
            this.chkJoin2Table.Text = "JOIN TABLE";
            this.chkJoin2Table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkJoin2Table.UseVisualStyleBackColor = false;
            // 
            // frmSubTableSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(778, 575);
            this.Controls.Add(this.chkJoin2Table);
            this.Controls.Add(this.chkPrintTableOrder);
            this.Controls.Add(this.btnJoinAllTables);
            this.Controls.Add(this.btnPrintAllTables);
            this.Controls.Add(this.chkChangeTable);
            this.Controls.Add(this.btnAddSubTable);
            this.Controls.Add(this.chkChangeTableName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubTableSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubTableSelector";
            this.Load += new System.EventHandler(this.frmSubTableSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTables;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkChangeTableName;
        private System.Windows.Forms.Button btnAddSubTable;
        private System.Windows.Forms.CheckBox chkChangeTable;
        private System.Windows.Forms.Button btnPrintAllTables;
        private System.Windows.Forms.Button btnJoinAllTables;
        private System.Windows.Forms.CheckBox chkPrintTableOrder;
        private System.Windows.Forms.CheckBox chkJoin2Table;
    }
}