using BSLayer;
namespace BSLayer {
    partial class ctlBozukPara {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label46 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblKurus = new System.Windows.Forms.Label();
            this.btnTane = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(212, 14);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(22, 24);
            this.label46.TabIndex = 41;
            this.label46.Text = "=";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(81, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 24);
            this.label23.TabIndex = 40;
            this.label23.Text = "X";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKurus
            // 
            this.lblKurus.BackColor = System.Drawing.Color.Transparent;
            this.lblKurus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKurus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblKurus.Location = new System.Drawing.Point(105, 14);
            this.lblKurus.Name = "lblKurus";
            this.lblKurus.Size = new System.Drawing.Size(101, 24);
            this.lblKurus.TabIndex = 38;
            this.lblKurus.Text = "0.01";
            this.lblKurus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTane
            // 
            this.btnTane.AutoEllipsis = true;
            this.btnTane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTane.BackgroundImage = global::BSLayer.Properties.Resources.shadow;
            this.btnTane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTane.FlatAppearance.BorderSize = 0;
            this.btnTane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTane.Font = new System.Drawing.Font("Arial", 16F);
            this.btnTane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTane.Location = new System.Drawing.Point(3, 3);
            this.btnTane.Name = "btnTane";
            this.btnTane.Size = new System.Drawing.Size(69, 44);
            this.btnTane.TabIndex = 39;
            this.btnTane.Tag = "0.01";
            this.btnTane.Text = "0";
            this.btnTane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTane.UseVisualStyleBackColor = false;
            this.btnTane.Click += new System.EventHandler(this.btnTane_Click);
            // 
            // btnValue
            // 
            this.btnValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnValue.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.shadow));
            this.btnValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
            this.btnValue.Font = new System.Drawing.Font("Arial", 16F);
            this.btnValue.Location = new System.Drawing.Point(240, 3);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(140, 44);
            this.btnValue.TabIndex = 42;
            this.btnValue.Text = "0.00";
            this.btnValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctlBozukPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnTane);
            this.Controls.Add(this.lblKurus);
            this.Name = "ctlBozukPara";
            this.Size = new System.Drawing.Size(383, 50);
            this.Load += new System.EventHandler(this.ctlBozukPara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblKurus;
        private System.Windows.Forms.Button btnTane;
        private System.Windows.Forms.Label btnValue;
    }
}
