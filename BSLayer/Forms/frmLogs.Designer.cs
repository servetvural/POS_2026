using POSLayer.Models;

namespace BSLayer.Forms
{
    partial class frmLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewLogEntry = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.logItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClose.Image = global::BSLayer.Properties.Resources.Cancel;
            this.btnClose.Location = new System.Drawing.Point(924, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 56);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "     CLOSE";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.Image = global::BSLayer.Properties.Resources.Refresh_2;
            this.btnReload.Location = new System.Drawing.Point(10, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(130, 56);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "RELOAD ALL";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewLogEntry);
            this.panel1.Controls.Add(this.btnDeleteSelected);
            this.panel1.Controls.Add(this.btnFullScreen);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1095, 76);
            this.panel1.TabIndex = 5;
            // 
            // btnViewLogEntry
            // 
            this.btnViewLogEntry.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewLogEntry.Image = global::BSLayer.Properties.Resources.eye32;
            this.btnViewLogEntry.Location = new System.Drawing.Point(540, 10);
            this.btnViewLogEntry.Name = "btnViewLogEntry";
            this.btnViewLogEntry.Size = new System.Drawing.Size(137, 56);
            this.btnViewLogEntry.TabIndex = 8;
            this.btnViewLogEntry.Text = "VIEW LOG DETAILS";
            this.btnViewLogEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewLogEntry.UseVisualStyleBackColor = true;
            this.btnViewLogEntry.Click += new System.EventHandler(this.btnViewLogEntry_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteSelected.Image = global::BSLayer.Properties.Resources.Recycle_Bin;
            this.btnDeleteSelected.Location = new System.Drawing.Point(417, 10);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(123, 56);
            this.btnDeleteSelected.TabIndex = 7;
            this.btnDeleteSelected.Text = "DELETE \r\nSELECTED";
            this.btnDeleteSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFullScreen.Image = global::BSLayer.Properties.Resources.fullscreen;
            this.btnFullScreen.Location = new System.Drawing.Point(265, 10);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(152, 56);
            this.btnFullScreen.TabIndex = 6;
            this.btnFullScreen.Text = "FULL SCREEN";
            this.btnFullScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearAll.Image = global::BSLayer.Properties.Resources.Recycle_Bin;
            this.btnClearAll.Location = new System.Drawing.Point(140, 10);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(125, 56);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoGenerateColumns = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventDateTime,
            this.IID,
            this.OrderItemText,
            this.Quantity,
            this.Price,
            this.Total,
            this.Reason,
            this.ComputerName,
            this.OrderContent,
            this.Reference});
            this.dgvLog.DataSource = this.logItemBindingSource;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersWidth = 20;
            this.dgvLog.RowTemplate.Height = 30;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(1095, 455);
            this.dgvLog.TabIndex = 6;
            this.dgvLog.SelectionChanged += new System.EventHandler(this.dgvLog_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 30);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 25);
            this.lblStatus.Text = "STATUS";
            // 
            // logItemBindingSource
            // 
            this.logItemBindingSource.DataSource = typeof(LogItem);
            // 
            // EventDateTime
            // 
            this.EventDateTime.DataPropertyName = "EventDateTime";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.EventDateTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.EventDateTime.HeaderText = "EventDateTime";
            this.EventDateTime.Name = "EventDateTime";
            this.EventDateTime.ReadOnly = true;
            this.EventDateTime.Width = 200;
            // 
            // IID
            // 
            this.IID.DataPropertyName = "IID";
            this.IID.HeaderText = "IID";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Visible = false;
            this.IID.Width = 5;
            // 
            // OrderItemText
            // 
            this.OrderItemText.DataPropertyName = "OrderItemText";
            this.OrderItemText.HeaderText = "OrderItemText";
            this.OrderItemText.Name = "OrderItemText";
            this.OrderItemText.ReadOnly = true;
            this.OrderItemText.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Reason.DefaultCellStyle = dataGridViewCellStyle4;
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 150;
            // 
            // ComputerName
            // 
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "Terminal";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.ReadOnly = true;
            this.ComputerName.Width = 150;
            // 
            // OrderContent
            // 
            this.OrderContent.DataPropertyName = "OrderContent";
            this.OrderContent.HeaderText = "Order Content";
            this.OrderContent.Name = "OrderContent";
            this.OrderContent.ReadOnly = true;
            this.OrderContent.Visible = false;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 130;
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 561);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supervisor Log";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.BindingSource logItemBindingSource;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnViewLogEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
    }
}