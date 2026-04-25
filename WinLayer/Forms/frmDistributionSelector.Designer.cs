using POSLayer.Models;

namespace WinLayer {
    partial class frmDistributionSelector {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistributionSelector));
            dgv = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            distributionBindingSource = new System.Windows.Forms.BindingSource(components);
            distributionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)distributionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { distributionNameDataGridViewTextBoxColumn });
            dgv.DataSource = distributionBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgv.Location = new System.Drawing.Point(0, 0);
            dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 25;
            dgv.RowTemplate.Height = 50;
            dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(355, 669);
            dgv.TabIndex = 45;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 669);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12);
            panel1.Size = new System.Drawing.Size(355, 81);
            panel1.TabIndex = 46;
            // 
            // btnClose
            // 
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btnClose.Location = new System.Drawing.Point(15, 12);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(146, 58);
            btnClose.TabIndex = 42;
            btnClose.Text = "CANCEL";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btnSave.Location = new System.Drawing.Point(191, 9);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(146, 58);
            btnSave.TabIndex = 43;
            btnSave.Text = "SELECT / SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // distributionBindingSource
            // 
            distributionBindingSource.DataSource = typeof(Distribution);
            // 
            // distributionNameDataGridViewTextBoxColumn
            // 
            distributionNameDataGridViewTextBoxColumn.DataPropertyName = "DistributionName";
            distributionNameDataGridViewTextBoxColumn.HeaderText = "Distribution  Name";
            distributionNameDataGridViewTextBoxColumn.Name = "distributionNameDataGridViewTextBoxColumn";
            distributionNameDataGridViewTextBoxColumn.ReadOnly = true;
            distributionNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // frmDistributionSelector
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(355, 750);
            ControlBox = false;
            Controls.Add(dgv);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDistributionSelector";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Distributions";
            Load += frmDistributionSelector_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)distributionBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource distributionBindingSource;
    }
}