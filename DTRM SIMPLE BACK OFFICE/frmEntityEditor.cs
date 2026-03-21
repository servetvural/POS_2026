using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTRMNS;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    public partial class frmEntityEditor : Form {
        private DTRMSimpleBusiness bslayer;
        public Entity en;

        public frmEntityEditor() {
            InitializeComponent();
        }

        public frmEntityEditor(DTRMSimpleBusiness bslayer, Entity en) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.en = en;
        }
        private void frmCategoryEditor_Load(object sender, EventArgs e) {
            LoadDistributions();
            LoadEntity();
        }

        private void LoadDistributions() {
            if (en.ParentMenuIID == null || en.ParentMenuIID == "")
                cmbDistribution.DataSource = bslayer.GetAllDistributionsForMenu(bslayer.config.ActiveMenuIID);
            else 
                cmbDistribution.DataSource = bslayer.GetAllDistributionsForMenu(en.ParentMenuIID);
        }

        private void LoadEntity() {
            if (en != null) {
                txtEntityName.Text = en.EntityName;
                btnEntityPanelBackColor.BackColor = Color.FromArgb(en.BackColour);
                try {
                    btnEntityForeColour.BackColor = Color.FromArgb(en.ForeColour);
                }
                catch { }
                incWidth.Value = en.ButtonWidth;
                incHeight.Value = en.ButtonHeight;


                cmbEntityType.SelectedIndex = (int)en.EntityType;
                try {
                    cmbDistribution.SelectedValue = en.DistributionIID;
                }
                catch { }

                btnFont.Text = en.FFamily + "," + en.FSize.ToString() + "," + en.FStyle;
                incDisplayOrder.Text = en.DisplayOrder.ToString();
            }
        }

        private void btnEntityPanelColor_Click(object sender, EventArgs e) {
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = ((Button)sender).BackColor;
            cdlg.ShowDialog();
            ((Button)sender).BackColor = cdlg.Color;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (en != null) {
                en.EntityName = txtEntityName.Text;
                en.BackColour = btnEntityPanelBackColor.BackColor.ToArgb();
                en.ForeColour = btnEntityForeColour.BackColor.ToArgb();
                en.ButtonWidth = incWidth.Value;
                en.ButtonHeight = incHeight.Value;
                //en.TaxPercent = float.Parse(txtTaxPercent.Text, bslayer.GetDBCulture());
                en.EntityType = (EntityTypes)cmbEntityType.SelectedIndex;

                if (cmbDistribution.SelectedIndex < 0) {
                    MessageBox.Show("Printable Category must be supplied!");
                    return;
                }
                en.DisplayOrder = (int)incDisplayOrder.Value;

                en.DistributionIID = cmbDistribution.SelectedValue.ToString(); //((Distribution)cmbPrintableCategoy.SelectedItem).IID;
                en.DistributionName = cmbDistribution.Text; //((Distribution)cmbPrintableCategoy.SelectedItem).DistributionName;
                bslayer.SaveEntityDB(en);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnFont_Click(object sender, EventArgs e) {
            FontDialog fd = new FontDialog();
            fd.Font = new Font(en.FFamily, (float)en.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), en.FStyle));
            if (fd.ShowDialog() == DialogResult.OK) {
                en.FFamily = fd.Font.FontFamily.Name;
                en.FSize = fd.Font.Size;
                en.FStyle = fd.Font.Style.ToString();
                btnFont.Text = en.FFamily + "," + en.FSize.ToString() +"," + en.FStyle;
            }
        }
        
        private void txtEntityName_Click(object sender, EventArgs e) {
            txtEntityName.SelectAll();
        }
       
        private void SetTaxRate(float rate) {
            foreach (EntityButton btn in en.Buttons) {
                btn.DirectSaleTaxPercent = rate;
                btn.InHouseTaxPercent = rate;
                btn.TakeAwayTaxPercent = rate;
                btn.DeliveryTaxPercent = rate;
            }
        }

  
        private void btnEntityForeColour_Click(object sender, EventArgs e) {
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = ((Button)sender).BackColor;
            cdlg.ShowDialog();
            ((Button)sender).BackColor = cdlg.Color;
            en.ForeColour = cdlg.Color.ToArgb();             
        }

        private void btnForceDistributionToAllButtons_Click(object sender, EventArgs e) {
            try {
                string gtypeIID = cmbDistribution.SelectedValue.ToString(); //((Distribution)cmbPrintableCategoy.SelectedItem).IID;
                                                                                //en.DistributionName = cmbPrintableCategoy.Text; //((Distribution)cmbPrintableCategoy.SelectedItem).DistributionName;
                if (bslayer.RunQuery("Update EntityButton set DistributionIID = '" + gtypeIID + "' where parentEntityIID ='" + en.IID + "'")) {
                    MessageBox.Show("Done");
                }
            } catch {
                MessageBox.Show("Failed");
            }
        }

        private void btnPlusWidth_Click(object sender, EventArgs e) {
            incWidth.IncrementValue();
        }

        private void btnMinusWidth_Click(object sender, EventArgs e) {
            incWidth.DecrementValue();
        }

        private void btnPlusHeight_Click(object sender, EventArgs e) {
            incHeight.IncrementValue();
        }

        private void btnMInusHeight_Click(object sender, EventArgs e) {
            incHeight.DecrementValue();
        }

        private void btnPlusOrder_Click(object sender, EventArgs e) {
            incDisplayOrder.IncrementValue();
        }

        private void btnMinusOrder_Click(object sender, EventArgs e) {
            incDisplayOrder.DecrementValue();
        }

        private void btnNewDistribution_Click(object sender, EventArgs e) {
            frmDistribution frm = new frmDistribution(bslayer, new Distribution());
            if (frm.ShowDialog() == DialogResult.OK) {
                LoadDistributions();
            }
        }
    }
}