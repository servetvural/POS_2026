using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTRMNS;

using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMSimpleBackOffice {
    public partial class frmEntityEditor : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        public Category en;

        //public frmEntityEditor() {
        //    InitializeComponent();
        //}

        public frmEntityEditor(PosConfig configAsService, DTRMSimpleBusiness bslayer, Category en)
        {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            this.en = en;
        }
        private void frmCategoryEditor_Load(object sender, EventArgs e) {
            LoadDistributions();
            LoadEntity();
        }

        private async void LoadDistributions() {

            if (en.MenuIID == null || en.MenuIID == "")
                cmbDistribution.DataSource =(await bslayer.GetAllDistributionsForMenu(config.ActiveMenuIID)).ToBindingList();
            else
                cmbDistribution.DataSource = (await bslayer.GetAllDistributionsForMenu(en.MenuIID)).ToBindingList();

        }

        private void LoadEntity() {
            if (en != null) {
                txtEntityName.Text = en.CategoryName;
                btnEntityPanelBackColor.BackColor = Color.FromArgb(en.BgColour);
                try {
                    btnEntityForeColour.BackColor = Color.FromArgb(en.FgColour);
                }
                catch { }
                incWidth.Value = en.Width;
                incHeight.Value = en.Height;


                cmbEntityType.SelectedIndex = (int)en.EntityType;
                if (en.DistributionIID != null)
                {
                    try
                    {
                        cmbDistribution.SelectedValue = en.DistributionIID;
                    } catch { }
                }

                btnFont.Text = en.FFamily + "," + en.FSize.ToString() + "," + en.FStyle;
                incDisplayOrder.Text = en.DOrder.ToString();
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
                en.CategoryName = txtEntityName.Text;
                en.BgColour = btnEntityPanelBackColor.BackColor.ToArgb();
                en.FgColour = btnEntityForeColour.BackColor.ToArgb();
                en.Width = incWidth.Value;
                en.Height = incHeight.Value;
                //en.TaxPercent = float.Parse(txtTaxPercent.Text, bslayer.GetDBCulture());
                en.EntityType = (EntityTypes)cmbEntityType.SelectedIndex;

                if (cmbDistribution.SelectedIndex < 0) {
                    MessageBox.Show("Printable Category must be supplied!");
                    return;
                }
                en.DOrder = (int)incDisplayOrder.Value;

                en.DistributionIID = cmbDistribution.SelectedValue.ToString(); 
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
            foreach (CategoryItem btn in en.Items) {
                btn.SaleTax = rate;
                btn.SitinTax = rate;
                btn.TaTax = rate;
                btn.DTax = rate;
            }
        }

  
        private void btnEntityForeColour_Click(object sender, EventArgs e) {
            ColorDialog cdlg = new ColorDialog();
            cdlg.Color = ((Button)sender).BackColor;
            cdlg.ShowDialog();
            ((Button)sender).BackColor = cdlg.Color;
            en.FgColour = cdlg.Color.ToArgb();             
        }

        private async void btnForceDistributionToAllButtons_Click(object sender, EventArgs e) {
            try {
                string gtypeIID = cmbDistribution.SelectedValue.ToString(); //((Distribution)cmbPrintableCategoy.SelectedItem).IID;
                                                                                //en.DistributionName = cmbPrintableCategoy.Text; //((Distribution)cmbPrintableCategoy.SelectedItem).DistributionName;
                if (await bslayer.RunQuery("Update EntityButton set DistributionIID = '" + gtypeIID + "' where parentEntityIID ='" + en.IID + "'")) {
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
            frmDistribution frm = ActivatorUtilities.CreateInstance< frmDistribution>(ServiceHelper.Services, new Distribution());
            if (frm.ShowDialog() == DialogResult.OK) {
                LoadDistributions();
            }
        }
    }
}