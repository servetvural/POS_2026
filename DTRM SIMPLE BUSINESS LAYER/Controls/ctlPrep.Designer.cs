using POSLayer.Models;

namespace DTRMNS {
    partial class ctlPrep {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.kitchenOrderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalTypeIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrep = new System.Windows.Forms.DataGridViewImageColumn();
            this.colLarge = new System.Windows.Forms.DataGridViewImageColumn();
            this.colQtyLarge = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVariable = new System.Windows.Forms.DataGridViewImageColumn();
            this.colClear = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenOrderItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Black;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.colItemText,
            this.globalTypeIIDDataGridViewTextBoxColumn,
            this.colPrep,
            this.colLarge,
            this.colQtyLarge,
            this.colVariable,
            this.colClear});
            this.dgv.DataSource = this.kitchenOrderItemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 70;
            this.dgv.Size = new System.Drawing.Size(884, 704);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Prep";
            this.dataGridViewImageColumn1.Image = global::DTRMNS.Properties.Resources.chef64;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Large";
            this.dataGridViewImageColumn2.Image = global::DTRMNS.Properties.Resources.GoLarge;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Qty Large";
            this.dataGridViewImageColumn3.Image = global::DTRMNS.Properties.Resources.GoLargeQty;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Variable";
            this.dataGridViewImageColumn4.Image = global::DTRMNS.Properties.Resources.lego32;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // kitchenOrderItemBindingSource
            // 
            this.kitchenOrderItemBindingSource.DataSource = typeof(KitchenOrderItem);
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            this.iIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // colItemText
            // 
            this.colItemText.DataPropertyName = "ItemText";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemText.DefaultCellStyle = dataGridViewCellStyle1;
            this.colItemText.HeaderText = "ItemText";
            this.colItemText.Name = "colItemText";
            this.colItemText.ReadOnly = true;
            this.colItemText.Width = 300;
            // 
            // globalTypeIIDDataGridViewTextBoxColumn
            // 
            this.globalTypeIIDDataGridViewTextBoxColumn.DataPropertyName = "DistributionIID";
            this.globalTypeIIDDataGridViewTextBoxColumn.HeaderText = "DistributionIID";
            this.globalTypeIIDDataGridViewTextBoxColumn.Name = "globalTypeIIDDataGridViewTextBoxColumn";
            this.globalTypeIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.globalTypeIIDDataGridViewTextBoxColumn.Visible = false;
            this.globalTypeIIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // colPrep
            // 
            this.colPrep.HeaderText = "Prep";
            this.colPrep.Image = global::DTRMNS.Properties.Resources.chef64;
            this.colPrep.Name = "colPrep";
            this.colPrep.ReadOnly = true;
            this.colPrep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colLarge
            // 
            this.colLarge.HeaderText = "Large";
            this.colLarge.Image = global::DTRMNS.Properties.Resources.GoLarge;
            this.colLarge.Name = "colLarge";
            this.colLarge.ReadOnly = true;
            // 
            // colQtyLarge
            // 
            this.colQtyLarge.HeaderText = "Qty Large";
            this.colQtyLarge.Image = global::DTRMNS.Properties.Resources.timeswhat62;
            this.colQtyLarge.Name = "colQtyLarge";
            this.colQtyLarge.ReadOnly = true;
            // 
            // colVariable
            // 
            this.colVariable.HeaderText = "Variable";
            this.colVariable.Image = global::DTRMNS.Properties.Resources.Note_Text;
            this.colVariable.Name = "colVariable";
            this.colVariable.ReadOnly = true;
            // 
            // colClear
            // 
            this.colClear.HeaderText = "Clear";
            this.colClear.Image = global::DTRMNS.Properties.Resources.Cancel;
            this.colClear.Name = "colClear";
            this.colClear.ReadOnly = true;
            this.colClear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ctlPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dgv);
            this.Name = "ctlPrep";
            this.Size = new System.Drawing.Size(884, 704);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenOrderItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource kitchenOrderItemBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemText;
        private System.Windows.Forms.DataGridViewTextBoxColumn globalTypeIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn colPrep;
        private System.Windows.Forms.DataGridViewImageColumn colLarge;
        private System.Windows.Forms.DataGridViewImageColumn colQtyLarge;
        private System.Windows.Forms.DataGridViewImageColumn colVariable;
        private System.Windows.Forms.DataGridViewImageColumn colClear;
    }
}
