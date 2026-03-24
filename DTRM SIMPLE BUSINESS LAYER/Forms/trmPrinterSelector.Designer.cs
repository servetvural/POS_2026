using POSLayer.Models;

namespace DTRMNS {
   partial class trmPrinterSelector {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
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
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
          this.btnClose = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
          this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.ApplicationName = new System.Windows.Forms.DataGridViewButtonColumn();
          this.NetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.ApplicationPrinterDataConnector = new System.Windows.Forms.BindingSource(this.components);
          this.panel1 = new System.Windows.Forms.Panel();
          ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.ApplicationPrinterDataConnector)).BeginInit();
          this.panel1.SuspendLayout();
          this.SuspendLayout();
          // 
          // btnClose
          // 
          this.btnClose.AutoEllipsis = true;
          this.btnClose.BackColor = System.Drawing.Color.Black;
          this.btnClose.BackgroundImage = global::DTRMNS.Properties.Resources.CLOSEBig;
          this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
          this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
          this.btnClose.FlatAppearance.BorderSize = 0;
          this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnClose.ForeColor = System.Drawing.Color.White;
          this.btnClose.Location = new System.Drawing.Point(361, 5);
          this.btnClose.Name = "btnClose";
          this.btnClose.Size = new System.Drawing.Size(93, 60);
          this.btnClose.TabIndex = 0;
          this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.btnClose.UseVisualStyleBackColor = false;
          this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
          // 
          // dgv
          // 
          this.dgv.AllowUserToAddRows = false;
          this.dgv.AllowUserToDeleteRows = false;
          this.dgv.AllowUserToResizeRows = false;
          this.dgv.AutoGenerateColumns = false;
          this.dgv.BackgroundColor = System.Drawing.Color.Black;
          this.dgv.ColumnHeadersVisible = false;
          this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.ApplicationName,
            this.NetworkName});
          this.dgv.DataSource = this.ApplicationPrinterDataConnector;
          dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
          dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
          dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
          dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
          dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
          dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
          this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
          this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
          this.dgv.Location = new System.Drawing.Point(10, 80);
          this.dgv.Name = "dgv";
          this.dgv.ReadOnly = true;
          this.dgv.RowHeadersVisible = false;
          this.dgv.RowTemplate.Height = 30;
          this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
          this.dgv.Size = new System.Drawing.Size(459, 410);
          this.dgv.TabIndex = 1;
          this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
          // 
          // IID
          // 
          this.IID.DataPropertyName = "IID";
          this.IID.HeaderText = "IID";
          this.IID.Name = "IID";
          this.IID.ReadOnly = true;
          this.IID.Visible = false;
          // 
          // ApplicationName
          // 
          this.ApplicationName.DataPropertyName = "ApplicationName";
          this.ApplicationName.DefaultCellStyle = dataGridViewCellStyle1;
          this.ApplicationName.HeaderText = "ApplicationName";
          this.ApplicationName.Name = "ApplicationName";
          this.ApplicationName.ReadOnly = true;
          this.ApplicationName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
          this.ApplicationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
          this.ApplicationName.Width = 150;
          // 
          // NetworkName
          // 
          this.NetworkName.DataPropertyName = "NetworkName";
          this.NetworkName.HeaderText = "NetworkName";
          this.NetworkName.Name = "NetworkName";
          this.NetworkName.ReadOnly = true;
          this.NetworkName.Width = 300;
          // 
          // ApplicationPrinterDataConnector
          // 
          this.ApplicationPrinterDataConnector.DataSource = typeof(Printer);
          // 
          // panel1
          // 
          this.panel1.BackColor = System.Drawing.Color.Black;
          this.panel1.Controls.Add(this.btnClose);
          this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
          this.panel1.Location = new System.Drawing.Point(10, 10);
          this.panel1.Name = "panel1";
          this.panel1.Padding = new System.Windows.Forms.Padding(5);
          this.panel1.Size = new System.Drawing.Size(459, 70);
          this.panel1.TabIndex = 2;
          // 
          // trmPrinterSelector
          // 
          this.ClientSize = new System.Drawing.Size(479, 500);
          this.ControlBox = false;
          this.Controls.Add(this.dgv);
          this.Controls.Add(this.panel1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.Name = "trmPrinterSelector";
          this.Padding = new System.Windows.Forms.Padding(10);
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "SELECT  PRINTER";
          this.Load += new System.EventHandler(this.frmPrinterSelector_Load);
          ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.ApplicationPrinterDataConnector)).EndInit();
          this.panel1.ResumeLayout(false);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.DataGridView dgv;
      private System.Windows.Forms.BindingSource ApplicationPrinterDataConnector;      
       private System.Windows.Forms.DataGridViewTextBoxColumn IID;
       private System.Windows.Forms.DataGridViewButtonColumn ApplicationName;
       private System.Windows.Forms.DataGridViewTextBoxColumn NetworkName;
       private System.Windows.Forms.Panel panel1;
   }
}