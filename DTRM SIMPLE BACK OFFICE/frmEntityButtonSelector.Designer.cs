
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmEntityButtonSelector {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvEntityButton = new System.Windows.Forms.DataGridView();
            this.colIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntityButtonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityButtonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntityButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 73);
            this.panel1.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(279, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 39);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(182, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 39);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvEntityButton
            // 
            this.dgvEntityButton.AllowUserToAddRows = false;
            this.dgvEntityButton.AllowUserToDeleteRows = false;
            this.dgvEntityButton.AutoGenerateColumns = false;
            this.dgvEntityButton.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntityButton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntityButton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIID,
            this.colEntityButtonName});
            this.dgvEntityButton.DataSource = this.entityButtonBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntityButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntityButton.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEntityButton.Location = new System.Drawing.Point(0, 23);
            this.dgvEntityButton.Name = "dgvEntityButton";
            this.dgvEntityButton.ReadOnly = true;
            this.dgvEntityButton.RowHeadersWidth = 25;
            this.dgvEntityButton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntityButton.Size = new System.Drawing.Size(371, 473);
            this.dgvEntityButton.TabIndex = 1;
            this.dgvEntityButton.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntityButton_CellDoubleClick);
            // 
            // colIID
            // 
            this.colIID.DataPropertyName = "IID";
            this.colIID.HeaderText = "IID";
            this.colIID.Name = "colIID";
            this.colIID.ReadOnly = true;
            this.colIID.Visible = false;
            // 
            // colEntityButtonName
            // 
            this.colEntityButtonName.DataPropertyName = "EntityButtonName";
            this.colEntityButtonName.HeaderText = "Entity Button";
            this.colEntityButtonName.Name = "colEntityButtonName";
            this.colEntityButtonName.ReadOnly = true;
            this.colEntityButtonName.Width = 300;
            // 
            // entityButtonBindingSource
            // 
            this.entityButtonBindingSource.DataSource = typeof(CategoryItem);
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(371, 23);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // frmEntityButtonSelector
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(371, 569);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEntityButton);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEntityButtonSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Entity Button";
            this.Load += new System.EventHandler(this.frmEntityButtonSelector_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntityButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityButtonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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