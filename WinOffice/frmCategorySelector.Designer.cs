using POSLayer.Models;

namespace WinOffice {
    partial class frmCategorySelector {
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
            dgvCategory = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            btnSelect = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            categoryBindingSource = new System.Windows.Forms.BindingSource(components);
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.BackgroundColor = System.Drawing.Color.White;
            dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dgvCategory.DataSource = categoryBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategory.GridColor = System.Drawing.Color.FromArgb(208, 215, 229);
            dgvCategory.Location = new System.Drawing.Point(0, 0);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidth = 25;
            dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new System.Drawing.Size(383, 424);
            dgvCategory.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 424);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(383, 73);
            panel1.TabIndex = 3;
            // 
            // btnSelect
            // 
            btnSelect.Location = new System.Drawing.Point(279, 15);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(80, 39);
            btnSelect.TabIndex = 66;
            btnSelect.Text = "SELECT";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(182, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, 39);
            btnCancel.TabIndex = 67;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // Column1
            // 
            Column1.DataPropertyName = "CategoryName";
            Column1.HeaderText = "Category";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 300;
            // 
            // frmCategorySelector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(383, 497);
            ControlBox = false;
            Controls.Add(dgvCategory);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "frmCategorySelector";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Select Category";
            Load += frmEntitySelector_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn entityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}