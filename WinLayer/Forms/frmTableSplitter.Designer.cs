using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;

namespace WinLayer {
    partial class frmTableSplitter {
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
            this.btnAddSourceTable = new System.Windows.Forms.Button();
            this.btnTargetToSource_ALL = new System.Windows.Forms.Button();
            this.btnTargetToSource_X = new System.Windows.Forms.Button();
            this.btnTargetToSource_1 = new System.Windows.Forms.Button();
            this.btnSourceToTarget_ALL = new System.Windows.Forms.Button();
            this.btnSourceToTarget_X = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSourceToTarget_1 = new System.Windows.Forms.Button();
            this.btnChangeTableSource = new System.Windows.Forms.Button();
            this.btnChangeTableTarget = new System.Windows.Forms.Button();
            this.lblSourceTableName = new System.Windows.Forms.Label();
            this.lblTargetTableName = new System.Windows.Forms.Label();
            this.pnlSourceTables = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTargetTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTargetTable = new System.Windows.Forms.Button();
            this.odTargetTable = ActivatorUtilities.CreateInstance < OrderDisplay>(ServiceHelper.Services);
            this.odSourceTable = ActivatorUtilities.CreateInstance <OrderDisplay>(ServiceHelper.Services);
            this.btnChangeTargetTableName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSourceTable
            // 
            this.btnAddSourceTable.AutoEllipsis = true;
            this.btnAddSourceTable.BackColor = System.Drawing.Color.Green;
            this.btnAddSourceTable.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnAddSourceTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSourceTable.FlatAppearance.BorderSize = 0;
            this.btnAddSourceTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSourceTable.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddSourceTable.ForeColor = System.Drawing.Color.White;
            this.btnAddSourceTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddSourceTable.Location = new System.Drawing.Point(29, 692);
            this.btnAddSourceTable.Name = "btnAddSourceTable";
            this.btnAddSourceTable.Size = new System.Drawing.Size(90, 50);
            this.btnAddSourceTable.TabIndex = 65;
            this.btnAddSourceTable.TabStop = false;
            this.btnAddSourceTable.UseVisualStyleBackColor = false;
            // 
            // btnTargetToSource_ALL
            // 
            this.btnTargetToSource_ALL.AutoEllipsis = true;
            this.btnTargetToSource_ALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTargetToSource_ALL.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnTargetToSource_ALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTargetToSource_ALL.FlatAppearance.BorderSize = 0;
            this.btnTargetToSource_ALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTargetToSource_ALL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnTargetToSource_ALL.ForeColor = System.Drawing.Color.White;
            this.btnTargetToSource_ALL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTargetToSource_ALL.Location = new System.Drawing.Point(470, 546);
            this.btnTargetToSource_ALL.Name = "btnTargetToSource_ALL";
            this.btnTargetToSource_ALL.Size = new System.Drawing.Size(90, 50);
            this.btnTargetToSource_ALL.TabIndex = 56;
            this.btnTargetToSource_ALL.TabStop = false;
            this.btnTargetToSource_ALL.Text = "<<    ALL";
            this.btnTargetToSource_ALL.UseVisualStyleBackColor = false;
            this.btnTargetToSource_ALL.Click += new System.EventHandler(this.btnTargetToSource_ALL_Click);
            // 
            // btnTargetToSource_X
            // 
            this.btnTargetToSource_X.AutoEllipsis = true;
            this.btnTargetToSource_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTargetToSource_X.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnTargetToSource_X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTargetToSource_X.FlatAppearance.BorderSize = 0;
            this.btnTargetToSource_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTargetToSource_X.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnTargetToSource_X.ForeColor = System.Drawing.Color.White;
            this.btnTargetToSource_X.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTargetToSource_X.Location = new System.Drawing.Point(470, 476);
            this.btnTargetToSource_X.Name = "btnTargetToSource_X";
            this.btnTargetToSource_X.Size = new System.Drawing.Size(90, 50);
            this.btnTargetToSource_X.TabIndex = 55;
            this.btnTargetToSource_X.TabStop = false;
            this.btnTargetToSource_X.Text = "<<    x";
            this.btnTargetToSource_X.UseVisualStyleBackColor = false;
            this.btnTargetToSource_X.Click += new System.EventHandler(this.btnTargetToSource_X_Click);
            // 
            // btnTargetToSource_1
            // 
            this.btnTargetToSource_1.AutoEllipsis = true;
            this.btnTargetToSource_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTargetToSource_1.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnTargetToSource_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTargetToSource_1.FlatAppearance.BorderSize = 0;
            this.btnTargetToSource_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTargetToSource_1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnTargetToSource_1.ForeColor = System.Drawing.Color.White;
            this.btnTargetToSource_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTargetToSource_1.Location = new System.Drawing.Point(470, 406);
            this.btnTargetToSource_1.Name = "btnTargetToSource_1";
            this.btnTargetToSource_1.Size = new System.Drawing.Size(90, 50);
            this.btnTargetToSource_1.TabIndex = 54;
            this.btnTargetToSource_1.TabStop = false;
            this.btnTargetToSource_1.Text = "<<    1";
            this.btnTargetToSource_1.UseVisualStyleBackColor = false;
            this.btnTargetToSource_1.Click += new System.EventHandler(this.btnTargetToSource_1_Click);
            // 
            // btnSourceToTarget_ALL
            // 
            this.btnSourceToTarget_ALL.AutoEllipsis = true;
            this.btnSourceToTarget_ALL.BackColor = System.Drawing.Color.Green;
            this.btnSourceToTarget_ALL.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnSourceToTarget_ALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSourceToTarget_ALL.FlatAppearance.BorderSize = 0;
            this.btnSourceToTarget_ALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceToTarget_ALL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSourceToTarget_ALL.ForeColor = System.Drawing.Color.White;
            this.btnSourceToTarget_ALL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSourceToTarget_ALL.Location = new System.Drawing.Point(470, 266);
            this.btnSourceToTarget_ALL.Name = "btnSourceToTarget_ALL";
            this.btnSourceToTarget_ALL.Size = new System.Drawing.Size(90, 50);
            this.btnSourceToTarget_ALL.TabIndex = 53;
            this.btnSourceToTarget_ALL.TabStop = false;
            this.btnSourceToTarget_ALL.Text = "ALL  >>";
            this.btnSourceToTarget_ALL.UseVisualStyleBackColor = false;
            this.btnSourceToTarget_ALL.Click += new System.EventHandler(this.btnSourceToTarget_ALL_Click);
            // 
            // btnSourceToTarget_X
            // 
            this.btnSourceToTarget_X.AutoEllipsis = true;
            this.btnSourceToTarget_X.BackColor = System.Drawing.Color.Green;
            this.btnSourceToTarget_X.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnSourceToTarget_X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSourceToTarget_X.FlatAppearance.BorderSize = 0;
            this.btnSourceToTarget_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceToTarget_X.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnSourceToTarget_X.ForeColor = System.Drawing.Color.White;
            this.btnSourceToTarget_X.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSourceToTarget_X.Location = new System.Drawing.Point(470, 196);
            this.btnSourceToTarget_X.Name = "btnSourceToTarget_X";
            this.btnSourceToTarget_X.Size = new System.Drawing.Size(90, 50);
            this.btnSourceToTarget_X.TabIndex = 52;
            this.btnSourceToTarget_X.TabStop = false;
            this.btnSourceToTarget_X.Text = "X    >>";
            this.btnSourceToTarget_X.UseVisualStyleBackColor = false;
            this.btnSourceToTarget_X.Click += new System.EventHandler(this.btnSourceToTarget_X_Click);
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
            this.btnClose.Location = new System.Drawing.Point(919, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 49;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSourceToTarget_1
            // 
            this.btnSourceToTarget_1.AutoEllipsis = true;
            this.btnSourceToTarget_1.BackColor = System.Drawing.Color.Green;
            this.btnSourceToTarget_1.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnSourceToTarget_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSourceToTarget_1.FlatAppearance.BorderSize = 0;
            this.btnSourceToTarget_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceToTarget_1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSourceToTarget_1.ForeColor = System.Drawing.Color.White;
            this.btnSourceToTarget_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSourceToTarget_1.Location = new System.Drawing.Point(470, 126);
            this.btnSourceToTarget_1.Name = "btnSourceToTarget_1";
            this.btnSourceToTarget_1.Size = new System.Drawing.Size(90, 50);
            this.btnSourceToTarget_1.TabIndex = 4;
            this.btnSourceToTarget_1.TabStop = false;
            this.btnSourceToTarget_1.Text = "1    >>";
            this.btnSourceToTarget_1.UseVisualStyleBackColor = false;
            this.btnSourceToTarget_1.Click += new System.EventHandler(this.btnSourceToTarget_1_Click);
            // 
            // btnChangeTableSource
            // 
            this.btnChangeTableSource.AutoEllipsis = true;
            this.btnChangeTableSource.BackColor = System.Drawing.Color.Green;
            this.btnChangeTableSource.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnChangeTableSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeTableSource.FlatAppearance.BorderSize = 0;
            this.btnChangeTableSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTableSource.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeTableSource.ForeColor = System.Drawing.Color.White;
            this.btnChangeTableSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangeTableSource.Location = new System.Drawing.Point(133, 18);
            this.btnChangeTableSource.Name = "btnChangeTableSource";
            this.btnChangeTableSource.Size = new System.Drawing.Size(148, 50);
            this.btnChangeTableSource.TabIndex = 68;
            this.btnChangeTableSource.TabStop = false;
            this.btnChangeTableSource.Text = "CHANGE TABLE";
            this.btnChangeTableSource.UseVisualStyleBackColor = false;
            this.btnChangeTableSource.Click += new System.EventHandler(this.btnChangeTableSource_Click);
            // 
            // btnChangeTableTarget
            // 
            this.btnChangeTableTarget.AutoEllipsis = true;
            this.btnChangeTableTarget.BackColor = System.Drawing.Color.Green;
            this.btnChangeTableTarget.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnChangeTableTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeTableTarget.FlatAppearance.BorderSize = 0;
            this.btnChangeTableTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTableTarget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeTableTarget.ForeColor = System.Drawing.Color.White;
            this.btnChangeTableTarget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangeTableTarget.Location = new System.Drawing.Point(574, 18);
            this.btnChangeTableTarget.Name = "btnChangeTableTarget";
            this.btnChangeTableTarget.Size = new System.Drawing.Size(148, 50);
            this.btnChangeTableTarget.TabIndex = 69;
            this.btnChangeTableTarget.TabStop = false;
            this.btnChangeTableTarget.Text = "CHANGE TABLE";
            this.btnChangeTableTarget.UseVisualStyleBackColor = false;
            this.btnChangeTableTarget.Click += new System.EventHandler(this.btnChangeTableTarget_Click);
            // 
            // lblSourceTableName
            // 
            this.lblSourceTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSourceTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceTableName.ForeColor = System.Drawing.Color.White;
            this.lblSourceTableName.Location = new System.Drawing.Point(286, 18);
            this.lblSourceTableName.Name = "lblSourceTableName";
            this.lblSourceTableName.Size = new System.Drawing.Size(166, 49);
            this.lblSourceTableName.TabIndex = 70;
            this.lblSourceTableName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTargetTableName
            // 
            this.lblTargetTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetTableName.ForeColor = System.Drawing.Color.White;
            this.lblTargetTableName.Location = new System.Drawing.Point(728, 18);
            this.lblTargetTableName.Name = "lblTargetTableName";
            this.lblTargetTableName.Size = new System.Drawing.Size(166, 49);
            this.lblTargetTableName.TabIndex = 71;
            this.lblTargetTableName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnlSourceTables
            // 
            this.pnlSourceTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSourceTables.Location = new System.Drawing.Point(12, 76);
            this.pnlSourceTables.Name = "pnlSourceTables";
            this.pnlSourceTables.Size = new System.Drawing.Size(116, 600);
            this.pnlSourceTables.TabIndex = 72;
            // 
            // pnlTargetTables
            // 
            this.pnlTargetTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTargetTables.Location = new System.Drawing.Point(899, 76);
            this.pnlTargetTables.Name = "pnlTargetTables";
            this.pnlTargetTables.Size = new System.Drawing.Size(116, 600);
            this.pnlTargetTables.TabIndex = 73;
            // 
            // btnAddTargetTable
            // 
            this.btnAddTargetTable.AutoEllipsis = true;
            this.btnAddTargetTable.BackColor = System.Drawing.Color.Green;
            this.btnAddTargetTable.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnAddTargetTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTargetTable.FlatAppearance.BorderSize = 0;
            this.btnAddTargetTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTargetTable.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddTargetTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTargetTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddTargetTable.Location = new System.Drawing.Point(908, 692);
            this.btnAddTargetTable.Name = "btnAddTargetTable";
            this.btnAddTargetTable.Size = new System.Drawing.Size(90, 50);
            this.btnAddTargetTable.TabIndex = 74;
            this.btnAddTargetTable.TabStop = false;
            this.btnAddTargetTable.Text = "+";
            this.btnAddTargetTable.UseVisualStyleBackColor = false;
            this.btnAddTargetTable.Click += new System.EventHandler(this.btnAddTargetTable_Click);
            // 
            // odTargetTable
            // 
            this.odTargetTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.odTargetTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.odTargetTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odTargetTable.Location = new System.Drawing.Point(574, 76);
            this.odTargetTable.Name = "odTargetTable";
            this.odTargetTable.OrderToSplit = null;
            this.odTargetTable.Size = new System.Drawing.Size(320, 600);
            this.odTargetTable.SplitDisplayHeight = 315;
            this.odTargetTable.TabIndex = 51;
            // 
            // odSourceTable
            // 
            this.odSourceTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.odSourceTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.odSourceTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odSourceTable.Location = new System.Drawing.Point(133, 76);
            this.odSourceTable.Name = "odSourceTable";
            this.odSourceTable.OrderToSplit = null;
            this.odSourceTable.Size = new System.Drawing.Size(320, 600);
            this.odSourceTable.SplitDisplayHeight = 315;
            this.odSourceTable.TabIndex = 50;
            // 
            // btnChangeTargetTableName
            // 
            this.btnChangeTargetTableName.AutoEllipsis = true;
            this.btnChangeTargetTableName.BackColor = System.Drawing.Color.Green;
            this.btnChangeTargetTableName.BackgroundImage = global::WinLayer.Properties.Resources.shadow;
            this.btnChangeTargetTableName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeTargetTableName.FlatAppearance.BorderSize = 0;
            this.btnChangeTargetTableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTargetTableName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeTargetTableName.ForeColor = System.Drawing.Color.White;
            this.btnChangeTargetTableName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangeTargetTableName.Location = new System.Drawing.Point(574, 692);
            this.btnChangeTargetTableName.Name = "btnChangeTargetTableName";
            this.btnChangeTargetTableName.Size = new System.Drawing.Size(121, 50);
            this.btnChangeTargetTableName.TabIndex = 76;
            this.btnChangeTargetTableName.TabStop = false;
            this.btnChangeTargetTableName.Text = "CHANGE TABLE NAME";
            this.btnChangeTargetTableName.UseVisualStyleBackColor = false;
            this.btnChangeTargetTableName.Click += new System.EventHandler(this.btnChangeTargetTableName_Click);
            // 
            // frmTableSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 780);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeTargetTableName);
            this.Controls.Add(this.btnAddTargetTable);
            this.Controls.Add(this.pnlTargetTables);
            this.Controls.Add(this.pnlSourceTables);
            this.Controls.Add(this.lblTargetTableName);
            this.Controls.Add(this.lblSourceTableName);
            this.Controls.Add(this.btnChangeTableTarget);
            this.Controls.Add(this.btnChangeTableSource);
            this.Controls.Add(this.btnAddSourceTable);
            this.Controls.Add(this.btnTargetToSource_ALL);
            this.Controls.Add(this.btnTargetToSource_X);
            this.Controls.Add(this.btnTargetToSource_1);
            this.Controls.Add(this.btnSourceToTarget_ALL);
            this.Controls.Add(this.btnSourceToTarget_X);
            this.Controls.Add(this.odTargetTable);
            this.Controls.Add(this.odSourceTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSourceToTarget_1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableSplitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTableSplitter";
            this.Load += new System.EventHandler(this.frmTableSplitter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSourceToTarget_1;
        private System.Windows.Forms.Button btnClose;
        private OrderDisplay odSourceTable;
        private OrderDisplay odTargetTable;
        private System.Windows.Forms.Button btnSourceToTarget_X;
        private System.Windows.Forms.Button btnSourceToTarget_ALL;
        private System.Windows.Forms.Button btnTargetToSource_1;
        private System.Windows.Forms.Button btnTargetToSource_X;
        private System.Windows.Forms.Button btnTargetToSource_ALL;
        private System.Windows.Forms.Button btnAddSourceTable;
        private System.Windows.Forms.Button btnChangeTableSource;
        private System.Windows.Forms.Button btnChangeTableTarget;
        private System.Windows.Forms.Label lblSourceTableName;
        private System.Windows.Forms.Label lblTargetTableName;
        private System.Windows.Forms.FlowLayoutPanel pnlSourceTables;
        private System.Windows.Forms.FlowLayoutPanel pnlTargetTables;
        private System.Windows.Forms.Button btnAddTargetTable;
        private System.Windows.Forms.Button btnChangeTargetTableName;
    }
}