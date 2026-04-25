namespace WinLayer {
    partial class frmBackupOptions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupOptions));
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.chkCustomers = new System.Windows.Forms.CheckBox();
            this.chkMenus = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkPrinters = new System.Windows.Forms.CheckBox();
            this.chkTables = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkLuv = new System.Windows.Forms.CheckBox();
            this.chkCurrentSession = new System.Windows.Forms.CheckBox();
            this.chkOrders = new System.Windows.Forms.CheckBox();
            this.chkXOrders = new System.Windows.Forms.CheckBox();
            this.chkKitchenOrders = new System.Windows.Forms.CheckBox();
            this.chkDebugInformation = new System.Windows.Forms.CheckBox();
            this.chkImages = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Location = new System.Drawing.Point(37, 205);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(237, 17);
            this.chkStock.TabIndex = 12;
            this.chkStock.Text = "INCLUDE STOCK ITEMS AND SUPPLIERS";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // chkCustomers
            // 
            this.chkCustomers.AutoSize = true;
            this.chkCustomers.Location = new System.Drawing.Point(37, 31);
            this.chkCustomers.Name = "chkCustomers";
            this.chkCustomers.Size = new System.Drawing.Size(150, 17);
            this.chkCustomers.TabIndex = 7;
            this.chkCustomers.Text = "INCLUDE   CUSTOMERS";
            this.chkCustomers.UseVisualStyleBackColor = true;
            // 
            // chkMenus
            // 
            this.chkMenus.AutoSize = true;
            this.chkMenus.Location = new System.Drawing.Point(37, 168);
            this.chkMenus.Name = "chkMenus";
            this.chkMenus.Size = new System.Drawing.Size(118, 17);
            this.chkMenus.TabIndex = 11;
            this.chkMenus.Text = "INCLUDE  MENUS";
            this.chkMenus.UseVisualStyleBackColor = true;
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Location = new System.Drawing.Point(37, 64);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(116, 17);
            this.chkUsers.TabIndex = 8;
            this.chkUsers.Text = "INCLUDE  USERS";
            this.chkUsers.UseVisualStyleBackColor = true;
            // 
            // chkPrinters
            // 
            this.chkPrinters.AutoSize = true;
            this.chkPrinters.Location = new System.Drawing.Point(37, 98);
            this.chkPrinters.Name = "chkPrinters";
            this.chkPrinters.Size = new System.Drawing.Size(134, 17);
            this.chkPrinters.TabIndex = 9;
            this.chkPrinters.Text = "INCLUDE  PRINTERS";
            this.chkPrinters.UseVisualStyleBackColor = true;
            // 
            // chkTables
            // 
            this.chkTables.AutoSize = true;
            this.chkTables.Location = new System.Drawing.Point(37, 133);
            this.chkTables.Name = "chkTables";
            this.chkTables.Size = new System.Drawing.Size(120, 17);
            this.chkTables.TabIndex = 10;
            this.chkTables.Text = "INCLUDE  TABLES";
            this.chkTables.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 161;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(275, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 39);
            this.btnCancel.TabIndex = 160;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkLuv
            // 
            this.chkLuv.AutoSize = true;
            this.chkLuv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkLuv.Location = new System.Drawing.Point(330, 31);
            this.chkLuv.Name = "chkLuv";
            this.chkLuv.Size = new System.Drawing.Size(103, 17);
            this.chkLuv.TabIndex = 162;
            this.chkLuv.Text = "INCLUDE   LUV";
            this.chkLuv.UseVisualStyleBackColor = true;
            // 
            // chkCurrentSession
            // 
            this.chkCurrentSession.AutoSize = true;
            this.chkCurrentSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkCurrentSession.Location = new System.Drawing.Point(330, 64);
            this.chkCurrentSession.Name = "chkCurrentSession";
            this.chkCurrentSession.Size = new System.Drawing.Size(188, 17);
            this.chkCurrentSession.TabIndex = 163;
            this.chkCurrentSession.Text = "INCLUDE   CURRENT  SESSION";
            this.chkCurrentSession.UseVisualStyleBackColor = true;
            // 
            // chkOrders
            // 
            this.chkOrders.AutoSize = true;
            this.chkOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkOrders.Location = new System.Drawing.Point(330, 98);
            this.chkOrders.Name = "chkOrders";
            this.chkOrders.Size = new System.Drawing.Size(128, 17);
            this.chkOrders.TabIndex = 164;
            this.chkOrders.Text = "INCLUDE   ORDERS";
            this.chkOrders.UseVisualStyleBackColor = true;
            // 
            // chkXOrders
            // 
            this.chkXOrders.AutoSize = true;
            this.chkXOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkXOrders.Location = new System.Drawing.Point(330, 133);
            this.chkXOrders.Name = "chkXOrders";
            this.chkXOrders.Size = new System.Drawing.Size(138, 17);
            this.chkXOrders.TabIndex = 165;
            this.chkXOrders.Text = "INCLUDE   X-ORDERS";
            this.chkXOrders.UseVisualStyleBackColor = true;
            // 
            // chkKitchenOrders
            // 
            this.chkKitchenOrders.AutoSize = true;
            this.chkKitchenOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkKitchenOrders.Location = new System.Drawing.Point(330, 168);
            this.chkKitchenOrders.Name = "chkKitchenOrders";
            this.chkKitchenOrders.Size = new System.Drawing.Size(181, 17);
            this.chkKitchenOrders.TabIndex = 166;
            this.chkKitchenOrders.Text = "INCLUDE   KITCHEN  ORDERS";
            this.chkKitchenOrders.UseVisualStyleBackColor = true;
            // 
            // chkDebugInformation
            // 
            this.chkDebugInformation.AutoSize = true;
            this.chkDebugInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkDebugInformation.Location = new System.Drawing.Point(330, 205);
            this.chkDebugInformation.Name = "chkDebugInformation";
            this.chkDebugInformation.Size = new System.Drawing.Size(201, 17);
            this.chkDebugInformation.TabIndex = 167;
            this.chkDebugInformation.Text = "INCLUDE   DEBUG  INFORMATION";
            this.chkDebugInformation.UseVisualStyleBackColor = true;
            // 
            // chkImages
            // 
            this.chkImages.AutoSize = true;
            this.chkImages.Location = new System.Drawing.Point(38, 242);
            this.chkImages.Name = "chkImages";
            this.chkImages.Size = new System.Drawing.Size(117, 17);
            this.chkImages.TabIndex = 168;
            this.chkImages.Text = "INCLUDE IMAGES";
            this.chkImages.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.251F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAll.Location = new System.Drawing.Point(330, 242);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(50, 19);
            this.chkAll.TabIndex = 169;
            this.chkAll.Text = "ALL";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // frmBackupOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 407);
            this.ControlBox = false;
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkImages);
            this.Controls.Add(this.chkDebugInformation);
            this.Controls.Add(this.chkKitchenOrders);
            this.Controls.Add(this.chkXOrders);
            this.Controls.Add(this.chkOrders);
            this.Controls.Add(this.chkCurrentSession);
            this.Controls.Add(this.chkLuv);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkStock);
            this.Controls.Add(this.chkCustomers);
            this.Controls.Add(this.chkMenus);
            this.Controls.Add(this.chkUsers);
            this.Controls.Add(this.chkPrinters);
            this.Controls.Add(this.chkTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BACKUP OPTIONS";
            this.Load += new System.EventHandler(this.frmBackupOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.CheckBox chkCustomers;
        private System.Windows.Forms.CheckBox chkMenus;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.CheckBox chkPrinters;
        private System.Windows.Forms.CheckBox chkTables;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkLuv;
        private System.Windows.Forms.CheckBox chkCurrentSession;
        private System.Windows.Forms.CheckBox chkOrders;
        private System.Windows.Forms.CheckBox chkXOrders;
        private System.Windows.Forms.CheckBox chkKitchenOrders;
        private System.Windows.Forms.CheckBox chkDebugInformation;
        private System.Windows.Forms.CheckBox chkImages;
        private System.Windows.Forms.CheckBox chkAll;
    }
}