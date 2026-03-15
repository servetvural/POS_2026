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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribution));
            this.txtPrintableCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrintableCategoryShortName = new System.Windows.Forms.TextBox();
            this.applicationPrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrimaryPrinter = new System.Windows.Forms.ComboBox();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewPrinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.applicationPrinterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrintableCategoryName
            // 
            this.txtPrintableCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPrintableCategoryName.Location = new System.Drawing.Point(33, 33);
            this.txtPrintableCategoryName.Name = "txtPrintableCategoryName";
            this.txtPrintableCategoryName.Size = new System.Drawing.Size(281, 29);
            this.txtPrintableCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribution Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(33, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Distribution Short Name (2 -3 Letters)";
            // 
            // txtPrintableCategoryShortName
            // 
            this.txtPrintableCategoryShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPrintableCategoryShortName.Location = new System.Drawing.Point(33, 103);
            this.txtPrintableCategoryShortName.Name = "txtPrintableCategoryShortName";
            this.txtPrintableCategoryShortName.Size = new System.Drawing.Size(72, 29);
            this.txtPrintableCategoryShortName.TabIndex = 5;
            // 
            // applicationPrinterBindingSource
            // 
            this.applicationPrinterBindingSource.DataSource = typeof(ApplicationPrinter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(33, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 151;
            this.label4.Text = "Printer";
            // 
            // cmbPrimaryPrinter
            // 
            this.cmbPrimaryPrinter.DataSource = this.applicationPrinterBindingSource;
            this.cmbPrimaryPrinter.DisplayMember = "ApplicationName";
            this.cmbPrimaryPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimaryPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbPrimaryPrinter.FormattingEnabled = true;
            this.cmbPrimaryPrinter.Location = new System.Drawing.Point(33, 173);
            this.cmbPrimaryPrinter.Name = "cmbPrimaryPrinter";
            this.cmbPrimaryPrinter.Size = new System.Drawing.Size(281, 32);
            this.cmbPrimaryPrinter.TabIndex = 153;
            this.cmbPrimaryPrinter.ValueMember = "IID";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DisplayMember = "MenuName";
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(33, 240);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(281, 32);
            this.cmbMenu.TabIndex = 154;
            this.cmbMenu.ValueMember = "IID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(33, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 155;
            this.label3.Text = "Menu";
            // 
            // btnNewPrinter
            // 
            this.btnNewPrinter.BackgroundImage = global::DTRMSimpleBackOffice.Properties.Resources.arti32;
            this.btnNewPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPrinter.Location = new System.Drawing.Point(327, 173);
            this.btnNewPrinter.Name = "btnNewPrinter";
            this.btnNewPrinter.Size = new System.Drawing.Size(32, 32);
            this.btnNewPrinter.TabIndex = 156;
            this.btnNewPrinter.UseVisualStyleBackColor = true;
            this.btnNewPrinter.Click += new System.EventHandler(this.btnNewPrinter_Click);
            // 
            // frmDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btnNewPrinter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPrimaryPrinter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrintableCategoryShortName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrintableCategoryName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDistribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DISTRIBUTION  TYPE (PRINTER)";
            this.Load += new System.EventHandler(this.frmDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationPrinterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrintableCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrintableCategoryShortName;
        private System.Windows.Forms.BindingSource applicationPrinterBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrimaryPrinter;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewPrinter;
    }
}