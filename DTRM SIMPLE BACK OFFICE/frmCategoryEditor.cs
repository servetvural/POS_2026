using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTRMNS;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace DTRMSimpleBackOffice {
    public partial class frmCategoryEditor : Form {
        PosConfig config;
        IRepository<Category> repoCategory;
        IRepository<Distribution> repoDistribution;

        public Category category;
        bool blnEdit;
        private BindingSource _distributionSource = new BindingSource();

        public frmCategoryEditor(PosConfig configAsService,IRepository<Category> _repoCategory, IRepository<Distribution> _repoDistribution, Category _category)
        {
            InitializeComponent();
            config = configAsService;
            repoCategory = _repoCategory;
            repoDistribution = _repoDistribution;

            category = _category;
            blnEdit = category.IID != null;
        }
        private async void frmCategoryEditor_Load(object sender, EventArgs e) {
            await LoadDistributions();
            await LoadEntity();
        }

        private async Task LoadDistributions() {

            if (category.MenuIID.IsNullOrEmpty())
                return;
            _distributionSource.DataSource = (await repoDistribution.GetListByField("MenuIID", category.MenuIID)).ToBindingList();
            cmbDistribution.DataSource = _distributionSource;  // (await repoDistribution.GetListByField("MenuIID",category.MenuIID)).ToBindingList<Distribution>();
        }

        private async Task LoadEntity() {
            if (category != null) {
                txtEntityName.Text = category.CategoryName;
                btnEntityPanelBackColor.BackColor = Color.FromArgb(category.BgColour);
                try {
                    btnEntityForeColour.BackColor = Color.FromArgb(category.FgColour);
                }
                catch { }
                incWidth.Value = category.Width;
                incHeight.Value = category.Height;


                cmbEntityType.SelectedIndex = (int)category.CategoryType;
                if (category.DistributionIID != null)
                {
                    try
                    {
                        cmbDistribution.SelectedValue = category.DistributionIID;
                    } catch (Exception ex) {
                        string str = ex.Message;
                    }
                }

                btnFont.Text = category.FFamily + "," + category.FSize.ToString() + "," + category.FStyle;
                incDisplayOrder.Text = category.DOrder.ToString();
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

        private async void btnSave_Click(object sender, EventArgs e) {
            if (category != null) {
                category.CategoryName = txtEntityName.Text;
                category.BgColour = btnEntityPanelBackColor.BackColor.ToArgb();
                category.FgColour = btnEntityForeColour.BackColor.ToArgb();
                category.Width = incWidth.Value;
                category.Height = incHeight.Value;
                category.CategoryType = (CategoryTypes)cmbEntityType.SelectedIndex;

                if (cmbDistribution.SelectedIndex < 0) {
                    MessageBox.Show("Printable Category must be supplied!");
                    return;
                }
                category.DOrder = (int)incDisplayOrder.Value;

                category.DistributionIID = cmbDistribution.SelectedValue.ToString();
                if (await repoCategory.Save(category) != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e) {
            FontDialog fd = new FontDialog();
            fd.Font = new Font(category.FFamily, (float)category.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), category.FStyle));
            if (fd.ShowDialog() == DialogResult.OK) {
                category.FFamily = fd.Font.FontFamily.Name;
                category.FSize = fd.Font.Size;
                category.FStyle = fd.Font.Style.ToString();
                btnFont.Text = category.FFamily + "," + category.FSize.ToString() +"," + category.FStyle;
            }
        }
        
        private void txtEntityName_Click(object sender, EventArgs e) {
            txtEntityName.SelectAll();
        }
       
        private void SetTaxRate(float rate) {
            foreach (CategoryItem btn in category.Items) {
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
            category.FgColour = cdlg.Color.ToArgb();             
        }

        private async void btnForceDistributionToAllButtons_Click(object sender, EventArgs e) {
            if (blnEdit)
            {
                try
                {
                    string distributionIID = cmbDistribution.SelectedValue.ToString();
                    foreach (var item in category.Items)
                    {
                        item.DistributionIID = distributionIID;
                    }
                    //if (await bslayer.RunQuery("Update EntityButton set DistributionIID = '" + gtypeIID + "' where parentEntityIID ='" + category.IID + "'"))
                    //{
                    //    MessageBox.Show("Done");
                    //}
                } catch
                {
                    MessageBox.Show("Failed to Modify Category Items");
                }
            } else
            {
                MessageBox.Show("Category must be saved first.");
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