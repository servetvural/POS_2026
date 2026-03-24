using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    partial class frmDistribution {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribution));
            txtPrintableCategoryName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            applicationPrinterBindingSource = new System.Windows.Forms.BindingSource(components);
            label4 = new System.Windows.Forms.Label();
            cmbPrimaryPrinter = new System.Windows.Forms.ComboBox();
            cmbMenu = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            btnNewPrinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)applicationPrinterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtPrintableCategoryName
            // 
            txtPrintableCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            txtPrintableCategoryName.Location = new System.Drawing.Point(38, 38);
            txtPrintableCategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPrintableCategoryName.Name = "txtPrintableCategoryName";
            txtPrintableCategoryName.Size = new System.Drawing.Size(327, 29);
            txtPrintableCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Distribution Name";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(234, 257);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(132, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(38, 257);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(132, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // applicationPrinterBindingSource
            // 
            applicationPrinterBindingSource.DataSource = typeof(Printer);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Arial", 9.75F);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(38, 85);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 16);
            label4.TabIndex = 151;
            label4.Text = "Printer";
            // 
            // cmbPrimaryPrinter
            // 
            cmbPrimaryPrinter.DataSource = applicationPrinterBindingSource;
            cmbPrimaryPrinter.DisplayMember = "ApplicationName";
            cmbPrimaryPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPrimaryPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbPrimaryPrinter.FormattingEnabled = true;
            cmbPrimaryPrinter.Location = new System.Drawing.Point(38, 104);
            cmbPrimaryPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbPrimaryPrinter.Name = "cmbPrimaryPrinter";
            cmbPrimaryPrinter.Size = new System.Drawing.Size(327, 32);
            cmbPrimaryPrinter.TabIndex = 153;
            cmbPrimaryPrinter.ValueMember = "IID";
            // 
            // cmbMenu
            // 
            cmbMenu.DisplayMember = "MenuName";
            cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            cmbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new System.Drawing.Point(38, 181);
            cmbMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new System.Drawing.Size(327, 32);
            cmbMenu.TabIndex = 154;
            cmbMenu.ValueMember = "IID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Arial", 9.75F);
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(38, 159);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 16);
            label3.TabIndex = 155;
            label3.Text = "Menu";
            // 
            // btnNewPrinter
            // 
            btnNewPrinter.BackgroundImage = Properties.Resources.arti32;
            btnNewPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNewPrinter.Location = new System.Drawing.Point(382, 104);
            btnNewPrinter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewPrinter.Name = "btnNewPrinter";
            btnNewPrinter.Size = new System.Drawing.Size(37, 37);
            btnNewPrinter.TabIndex = 156;
            btnNewPrinter.UseVisualStyleBackColor = true;
            btnNewPrinter.Click += btnNewPrinter_Click;
            // 
            // frmDistribution
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(433, 331);
            ControlBox = false;
            Controls.Add(btnNewPrinter);
            Controls.Add(label3);
            Controls.Add(cmbMenu);
            Controls.Add(label4);
            Controls.Add(cmbPrimaryPrinter);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(txtPrintableCategoryName);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDistribution";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DISTRIBUTION  TYPE (PRINTER)";
            Load += frmDistribution_Load;
            ((System.ComponentModel.ISupportInitialize)applicationPrinterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrintableCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource applicationPrinterBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrimaryPrinter;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewPrinter;
    }
}