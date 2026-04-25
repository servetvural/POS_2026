using POSLayer.Library;

namespace BSLayer {
    partial class frmPinZWarning {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPinZWarning));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlNumeric1 = new BSLayer.Controls.ctlNumeric();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(175, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "You must get report from the \r\nPIN MACHINE!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.Image = global::BSLayer.Properties.Resources.okay;
            this.btnOk.Location = new System.Drawing.Point(205, 215);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(192, 80);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = global::BSLayer.Properties.Resources.Delete;
            this.btnCancel.Location = new System.Drawing.Point(14, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 80);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 165);
            this.panel1.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Yellow;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.txtCode.ForeColor = System.Drawing.Color.Red;
            this.txtCode.Location = new System.Drawing.Point(205, 137);
            this.txtCode.MaxLength = 8;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(192, 47);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(229, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "PIN Z AMOUNT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctlNumeric1
            // 
            this.ctlNumeric1.BackColor = System.Drawing.Color.Black;
            this.ctlNumeric1.Location = new System.Drawing.Point(444, 19);
            this.ctlNumeric1.Name = "ctlNumeric1";
            this.ctlNumeric1.Size = new System.Drawing.Size(346, 276);
            this.ctlNumeric1.TabIndex = 5;
            this.ctlNumeric1.OutputOccured += new PosLibrary.Delegate_String(this.ctlNumeric1_OutputOccured);
            this.ctlNumeric1.BackspaceClicked += new GenericFunctionCallAsync(this.ctlNumeric1_BackspaceClicked);
            this.ctlNumeric1.EnterClicked += new GenericFunctionCallAsync(this.ctlNumeric1_EnterClicked);
            // 
            // frmPinZWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 314);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.ctlNumeric1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Name = "frmPinZWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private Controls.ctlNumeric ctlNumeric1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
    }
}