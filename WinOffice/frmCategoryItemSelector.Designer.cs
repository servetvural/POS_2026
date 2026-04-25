
using POSLayer.Models;

namespace WinOffice {
    partial class frmCategoryItemSelector {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            btnSelect = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            dgvEntityButton = new System.Windows.Forms.DataGridView();
            colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            entityButtonBindingSource = new System.Windows.Forms.BindingSource(components);
            txtFilter = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntityButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSelect);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 496);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(10);
            panel1.Size = new System.Drawing.Size(371, 73);
            panel1.TabIndex = 4;
            // 
            // btnSelect
            // 
            btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            btnSelect.Image = Properties.Resources.tickgreen;
            btnSelect.Location = new System.Drawing.Point(249, 10);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(112, 53);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "SELECT";
            btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            btnCancel.Image = Properties.Resources.Cancel;
            btnCancel.Location = new System.Drawing.Point(10, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(112, 53);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "CANCEL";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvEntityButton
            // 
            dgvEntityButton.AllowUserToAddRows = false;
            dgvEntityButton.AllowUserToDeleteRows = false;
            dgvEntityButton.AutoGenerateColumns = false;
            dgvEntityButton.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvEntityButton.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntityButton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntityButton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colIID });
            dgvEntityButton.DataSource = entityButtonBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvEntityButton.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEntityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEntityButton.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvEntityButton.Location = new System.Drawing.Point(0, 23);
            dgvEntityButton.Name = "dgvEntityButton";
            dgvEntityButton.ReadOnly = true;
            dgvEntityButton.RowHeadersWidth = 25;
            dgvEntityButton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEntityButton.Size = new System.Drawing.Size(371, 473);
            dgvEntityButton.TabIndex = 1;
            dgvEntityButton.CellDoubleClick += dgvEntityButton_CellDoubleClick;
            // 
            // colIID
            // 
            colIID.DataPropertyName = "IID";
            colIID.HeaderText = "IID";
            colIID.Name = "colIID";
            colIID.ReadOnly = true;
            colIID.Visible = false;
            // 
            // entityButtonBindingSource
            // 
            entityButtonBindingSource.DataSource = typeof(CategoryItem);
            // 
            // txtFilter
            // 
            txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            txtFilter.Location = new System.Drawing.Point(0, 0);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(371, 23);
            txtFilter.TabIndex = 0;
            txtFilter.KeyDown += txtFilter_KeyDown;
            // 
            // frmCategoryItemSelector
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(371, 569);
            ControlBox = false;
            Controls.Add(dgvEntityButton);
            Controls.Add(txtFilter);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "frmCategoryItemSelector";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Select Category Item";
            Load += frmEntityButtonSelector_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntityButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityButtonBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvEntityButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityButtonName;
        private System.Windows.Forms.BindingSource entityButtonBindingSource;
        private System.Windows.Forms.TextBox txtFilter;
    }
}