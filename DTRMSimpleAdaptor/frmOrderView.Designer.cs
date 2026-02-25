namespace DTRMSimpleAdaptor {
    partial class frmOrderView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewDataConnector = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDBExportToCsv = new System.Windows.Forms.Button();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewDataConnector)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.colOrderDate,
            this.colOrderItems,
            this.CalculatedValue});
            this.dgv.DataSource = this.ordersViewDataConnector;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 51);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 20;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(485, 650);
            this.dgv.TabIndex = 5;
            // 
            // IID
            // 
            this.IID.DataPropertyName = "IID";
            this.IID.HeaderText = "IID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "dd MMM yy HH:mm";
            this.colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderDate.HeaderText = "Date / Time";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            this.colOrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderDate.Width = 120;
            // 
            // colOrderItems
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrderItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderItems.HeaderText = "Order Items";
            this.colOrderItems.Name = "colOrderItems";
            this.colOrderItems.ReadOnly = true;
            this.colOrderItems.Width = 250;
            // 
            // CalculatedValue
            // 
            this.CalculatedValue.DataPropertyName = "CalculatedValue";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.CalculatedValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.CalculatedValue.HeaderText = "TOTAL";
            this.CalculatedValue.Name = "CalculatedValue";
            this.CalculatedValue.ReadOnly = true;
            this.CalculatedValue.Width = 75;
            // 
            // ordersViewDataConnector
            // 
            this.ordersViewDataConnector.DataSource = typeof(DTRMNS.OrdersView);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDBExportToCsv);
            this.panel1.Controls.Add(this.lblOrderTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeleteOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 51);
            this.panel1.TabIndex = 6;
            // 
            // btnDBExportToCsv
            // 
            this.btnDBExportToCsv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDBExportToCsv.Image = global::DTRMSimpleAdaptor.Properties.Resources.Export32;
            this.btnDBExportToCsv.Location = new System.Drawing.Point(330, 6);
            this.btnDBExportToCsv.Name = "btnDBExportToCsv";
            this.btnDBExportToCsv.Size = new System.Drawing.Size(143, 38);
            this.btnDBExportToCsv.TabIndex = 9;
            this.btnDBExportToCsv.Text = "SpreadSheet";
            this.btnDBExportToCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDBExportToCsv.UseVisualStyleBackColor = true;
            this.btnDBExportToCsv.Click += new System.EventHandler(this.BtnDBExportToCsv_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BackColor = System.Drawing.Color.White;
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderTotal.Location = new System.Drawing.Point(193, 15);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(100, 25);
            this.lblOrderTotal.TabIndex = 8;
            this.lblOrderTotal.Text = "0.00";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(147, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrders.Location = new System.Drawing.Point(6, 10);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(123, 30);
            this.btnDeleteOrders.TabIndex = 0;
            this.btnDeleteOrders.Text = "Delete Order(s)";
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            this.btnDeleteOrders.Click += new System.EventHandler(this.BtnDeleteOrders_Click);
            // 
            // frmOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 701);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.FrmOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewDataConnector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ordersViewDataConnector;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnDBExportToCsv;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculatedValue;
    }
}