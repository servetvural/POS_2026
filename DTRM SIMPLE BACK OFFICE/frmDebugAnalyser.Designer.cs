namespace DTRMSimpleBackOffice {
    partial class frmDebugAnalyser {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebugAnalyser));
            this.dgvDebug = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoadAllDebug = new System.Windows.Forms.ToolStripButton();
            this.btnAscending = new System.Windows.Forms.ToolStripButton();
            this.btnDescending = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteSelectedDebugs = new System.Windows.Forms.ToolStripButton();
            this.btnClearAllDebugInformation = new System.Windows.Forms.ToolStripButton();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.txtDebugDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDebug
            // 
            this.dgvDebug.AllowUserToAddRows = false;
            this.dgvDebug.AllowUserToDeleteRows = false;
            this.dgvDebug.AutoGenerateColumns = false;
            this.dgvDebug.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colDateTime,
            this.colData});
            this.dgvDebug.DataSource = this.debugBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebug.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDebug.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDebug.Location = new System.Drawing.Point(0, 39);
            this.dgvDebug.Name = "dgvDebug";
            this.dgvDebug.ReadOnly = true;
            this.dgvDebug.RowHeadersWidth = 20;
            this.dgvDebug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebug.Size = new System.Drawing.Size(960, 319);
            this.dgvDebug.TabIndex = 0;
            this.dgvDebug.SelectionChanged += new System.EventHandler(this.dgvDebug_SelectionChanged);
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "DebugNo";
            this.colNumber.HeaderText = "DebugNo";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "EventDateTime";
            this.colDateTime.HeaderText = "EventDateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 200;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "Data";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 1000;
            // 
            // debugBindingSource
            // 
            this.debugBindingSource.DataSource = typeof(DTRMNS.Debug);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadAllDebug,
            this.btnAscending,
            this.btnDescending,
            this.btnDeleteSelectedDebugs,
            this.btnClearAllDebugInformation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadAllDebug
            // 
            this.btnLoadAllDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadAllDebug.Image = global::DTRMSimpleBackOffice.Properties.Resources.DBSource32;
            this.btnLoadAllDebug.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadAllDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadAllDebug.Name = "btnLoadAllDebug";
            this.btnLoadAllDebug.Size = new System.Drawing.Size(36, 36);
            this.btnLoadAllDebug.Text = "Load Debug Info";
            this.btnLoadAllDebug.Click += new System.EventHandler(this.btnLoadAllDebug_Click);
            // 
            // btnAscending
            // 
            this.btnAscending.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAscending.Image = global::DTRMSimpleBackOffice.Properties.Resources.arrow_down32;
            this.btnAscending.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAscending.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAscending.Name = "btnAscending";
            this.btnAscending.Size = new System.Drawing.Size(36, 36);
            this.btnAscending.Text = "Ascending Order";
            this.btnAscending.Click += new System.EventHandler(this.btnAscending_Click);
            // 
            // btnDescending
            // 
            this.btnDescending.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDescending.Image = global::DTRMSimpleBackOffice.Properties.Resources.arrow_up32;
            this.btnDescending.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDescending.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(36, 36);
            this.btnDescending.Text = "Descending Order";
            this.btnDescending.Click += new System.EventHandler(this.btnDescending_Click);
            // 
            // btnDeleteSelectedDebugs
            // 
            this.btnDeleteSelectedDebugs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedDebugs.ForeColor = System.Drawing.Color.Blue;
            this.btnDeleteSelectedDebugs.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnDeleteSelectedDebugs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteSelectedDebugs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSelectedDebugs.Name = "btnDeleteSelectedDebugs";
            this.btnDeleteSelectedDebugs.Size = new System.Drawing.Size(36, 36);
            this.btnDeleteSelectedDebugs.Text = "1";
            this.btnDeleteSelectedDebugs.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeleteSelectedDebugs.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnDeleteSelectedDebugs.ToolTipText = "Delete Selected Debugs";
            this.btnDeleteSelectedDebugs.Click += new System.EventHandler(this.btnDeleteSelectedDebugs_Click);
            // 
            // btnClearAllDebugInformation
            // 
            this.btnClearAllDebugInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearAllDebugInformation.Image = global::DTRMSimpleBackOffice.Properties.Resources.Cancel;
            this.btnClearAllDebugInformation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClearAllDebugInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAllDebugInformation.Name = "btnClearAllDebugInformation";
            this.btnClearAllDebugInformation.Size = new System.Drawing.Size(36, 36);
            this.btnClearAllDebugInformation.Text = "Clear All Debug Information";
            this.btnClearAllDebugInformation.Click += new System.EventHandler(this.btnClearAllDebugInformation_Click);
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.ExpandableControl = this.dgvDebug;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 358);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(960, 10);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 2;
            this.expandableSplitter1.TabStop = false;
            // 
            // txtDebugDetails
            // 
            // 
            // 
            // 
            this.txtDebugDetails.Border.Class = "TextBoxBorder";
            this.txtDebugDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDebugDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDebugDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDebugDetails.Location = new System.Drawing.Point(0, 368);
            this.txtDebugDetails.Multiline = true;
            this.txtDebugDetails.Name = "txtDebugDetails";
            this.txtDebugDetails.PreventEnterBeep = true;
            this.txtDebugDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebugDetails.Size = new System.Drawing.Size(960, 115);
            this.txtDebugDetails.TabIndex = 3;
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter2.ExpandableControl = this.txtDebugDetails;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(0, 483);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(960, 10);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 4;
            this.expandableSplitter2.TabStop = false;
            // 
            // frmDebugAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 709);
            this.Controls.Add(this.expandableSplitter2);
            this.Controls.Add(this.txtDebugDetails);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.dgvDebug);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDebugAnalyser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DEBUG ANALYSER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDebugAnalyser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDebug;
        private System.Windows.Forms.BindingSource debugBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadAllDebug;
        private System.Windows.Forms.ToolStripButton btnAscending;
        private System.Windows.Forms.ToolStripButton btnDescending;
        private System.Windows.Forms.ToolStripButton btnDeleteSelectedDebugs;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDebugDetails;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.ToolStripButton btnClearAllDebugInformation;
    }
}