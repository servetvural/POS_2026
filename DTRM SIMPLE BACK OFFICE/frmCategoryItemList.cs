using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

using PosLibrary;
using PosLibrary.Forms;

using POSWinFormLayer;


namespace DTRMSimpleBackOffice
{
    public partial class frmCategoryItemList : Form
    {
        PosConfig config;
        IRepository<TheMenu> repoMenu;
        IRepository<Category> repoCategory;
        IRepository<CategoryItem> repoCategoryItem;
        IRepository<Printer> repoPrinter;
        IRepository<Employee> repoEmployee;
        IRepository<Supplier> repoSupplier;
        IRepository<StockItem> repoStockItem;
        IRepository<Bonus> repoBonus;

        private DTRMSimpleBusiness bslayer;


        Category category;
        private BindingSource _categoryItemSource = new BindingSource();
        private BindingSource _stockItemSource = new BindingSource();

        CategoryItem selectedCategoryItem;

        public frmCategoryItemList(PosConfig configAsService, IRepository<TheMenu> _repoMenu,
            IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem,
            IRepository<Printer> _repoPrinter,
                   IRepository<Employee> _repoEmployee, IRepository<Supplier> _repoSupplier,
                   IRepository<StockItem> _repoStockItem, IRepository<Bonus> _repoBonus,
            DTRMSimpleBusiness bslayer, Category _category)
        {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            repoMenu = _repoMenu;
            repoCategory = _repoCategory;
            repoCategoryItem = _repoCategoryItem;
            repoPrinter = _repoPrinter;
            repoEmployee = _repoEmployee;
            repoSupplier = _repoSupplier;
            repoStockItem = _repoStockItem;
            repoBonus = _repoBonus;

            category = _category;

            Thread.CurrentThread.CurrentUICulture = bslayer.GetUICulture();
        }
        private async void FrmMenuEditor_Load(object sender, EventArgs e)
        {
            if (category == null || category.IID == null)
                this.Close();
            else
                await LoadCategoryItems();
        }

        async Task LoadCategoryItems()
        {
            dgvCategoryItem.AutoGenerateColumns = false;

            await FormatCategorItemGrid();

            category = await repoCategory.Get(category.IID, "Distribution, Items, Items.Distribution");

            _categoryItemSource.DataSource = category.Items.ReOrder().ToBindingList();
            // _categoryItemSource.Sort = "DOrder ASC";
            dgvCategoryItem.DataSource = _categoryItemSource;

            lblCategory.Text = "Category : " + category.CategoryName;
        }

        #region CATEGORY ITEM FUNCTIONS    

        private async void btnAddCategoryItem_Click(object sender, EventArgs e)
        {
            using (frmCategoryItemUpsert frm = ActivatorUtilities.CreateInstance<frmCategoryItemUpsert>(ServiceHelper.Services, new CategoryItem() { CategoryIID = category.IID }))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    await LoadCategoryItems();
                }
            }
        }

        private async void btnEditCategoryItem_Click(object sender, EventArgs e)
        {
            if (selectedCategoryItem != null)
            {
                using (frmCategoryItemUpsert frm = ActivatorUtilities.CreateInstance<frmCategoryItemUpsert>(ServiceHelper.Services, selectedCategoryItem))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadCategoryItems();
                    }
                }
            }
        }

        private async void btnDeleteCategoryItem_Click(object sender, EventArgs e)
        {
            if (selectedCategoryItem != null)
            {
                if (MessageBox.Show("This will Delete all sub entity buttons of this button.\nDo you want to continue?",
                    "Delete Entity Button", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    await repoCategoryItem.Delete(selectedCategoryItem.IID);
                    await LoadCategoryItems();
                }
            }
        }
        private void dgvCategoryItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditCategoryItem_Click(null, null);
        }
        private void dgvCategoryItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                selectedCategoryItem = _categoryItemSource.Current as CategoryItem;
                DisplaySampleCategoryItemButton();
            } else
                selectedCategoryItem = null;
        }

        private async void DisplaySampleCategoryItemButton()
        {
            if (selectedCategoryItem != null)
            {
                btnCategoryItemSample.Width = selectedCategoryItem.Width;
                btnCategoryItemSample.Text = selectedCategoryItem.ItemName;
                btnCategoryItemSample.Font = new Font(category.FFamily, (float)selectedCategoryItem.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), category.FStyle));
                btnCategoryItemSample.BackColor = Color.FromArgb(selectedCategoryItem.BgColor);
                btnCategoryItemSample.ForeColor = Color.FromArgb(selectedCategoryItem.FgColor);

                btnCategoryItemSample.DisplayStyle = (ToolStripItemDisplayStyle)selectedCategoryItem.ButtonDisplayStyle;
                btnCategoryItemSample.TextAlign = (ContentAlignment)selectedCategoryItem.TextAlign;
                btnCategoryItemSample.ImageAlign = (ContentAlignment)selectedCategoryItem.ImageAlign;
                btnCategoryItemSample.TextImageRelation = (TextImageRelation)selectedCategoryItem.TextImageRelation;

                if (selectedCategoryItem.ButtonDisplayStyle == ButtonDisplayStyles.Image || selectedCategoryItem.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText)
                {
                    GenericImage gim = await bslayer.GetGenericImage(selectedCategoryItem.IID);
                    if (gim != null && gim.DisplayImage != null)
                    {
                        Image btnImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                        btnCategoryItemSample.Image = UFWin.ReSizeImageTo(btnImage, btnCategoryItemSample.Height - 5, btnCategoryItemSample.Height - 5);
                        btnCategoryItemSample.ImageScaling = ToolStripItemImageScaling.None;
                    } else
                    {
                        btnCategoryItemSample.Image = null;
                    }
                } else
                {
                    btnCategoryItemSample.Image = null;
                }
            }
        }
        private void btnCategoryItemSample_Paint(object sender, PaintEventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            // Draw a solid red border around the button's content area
            ControlPaint.DrawBorder(e.Graphics, btn.ContentRectangle,
                Color.Red, ButtonBorderStyle.Solid);
        }


        #endregion


        private async void BtnEBFontTo_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                using (FontDialog fd = new FontDialog())
                {
                    fd.Font = new Font("Arial", 10, FontStyle.Bold);
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                        foreach (var item in selectedItems)
                        {
                            item.FFamily = fd.Font.FontFamily.Name;
                            item.FSize = fd.Font.Size;
                            item.FStyle = fd.Font.Style.ToString();
                            await repoCategoryItem.Save(item);
                        }
                        await LoadCategoryItems();
                    }
                }
            }
        }

        private async void BtnEBWidthTo_Click(object sender, EventArgs e)
        {
            using (frmInputForm frm = new frmInputForm("100"))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int val = 0;
                    if (int.TryParse(frm.InputValue, out val))
                    {
                        var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                        foreach (var item in selectedItems)
                        {
                            item.Width = val;
                            await repoCategoryItem.Save(item);
                        }
                        await LoadCategoryItems();
                    }
                }
            }
        }

        private async void BtnEBHeightTo_Click(object sender, EventArgs e)
        {
            using (frmInputForm frm = new frmInputForm("100"))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int val = 0;
                    if (int.TryParse(frm.InputValue, out val))
                    {
                        var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                        foreach (var item in selectedItems)
                        {
                            item.Height = val;
                            await repoCategoryItem.Save(item);
                        }
                        await LoadCategoryItems();
                    }
                }
            }
        }

        private async void BtnEBPriceTo_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                CategoryItem firsteb = await bslayer.GetJustEntityButton(dgvCategoryItem.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString());
                using (frmInputForm frm = new frmInputForm(firsteb.SalePrice.ToString()))
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        float val = 0;
                        if (float.TryParse(frm.InputValue, out val))
                        {
                            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                            foreach (var item in selectedItems)
                            {
                                item.SalePrice = val;
                                item.SitinPrice = val;
                                item.TaPrice = val;
                                item.DPrice = val;
                                await repoCategoryItem.Save(item);
                            }
                            await LoadCategoryItems();
                        }
                    }
                }
            }
        }

        private async void BtnEBTaxRateTo_Click(object sender, EventArgs e)
        {
            using (frmInputForm frm = new frmInputForm("100"))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    float val = 0;
                    if (float.TryParse(frm.InputValue, out val))
                    {
                        var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                        foreach (var item in selectedItems)
                        {
                            item.SaleTax = val;
                            item.SitinTax = val;
                            item.TaTax = val;
                            item.DTax = val;
                            await repoCategoryItem.Save(item);
                        }
                        await LoadCategoryItems();
                    }
                }
            }
        }

        private async void BtnMoveToEntity_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                using (frmCategorySelector frm = ActivatorUtilities.CreateInstance<frmCategorySelector>(ServiceHelper.Services, category.MenuIID))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                        foreach (var item in selectedItems)
                        {
                            item.CategoryIID = frm.SelectedCategoryIID;
                            await repoCategoryItem.Save(item);
                        }
                        await LoadCategoryItems();
                    }
                }
            }
        }



        private async void BtnDuplicate_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                bool blnDuplicateStockItems = (MessageBox.Show("Do you want to duplicate stock items as well?",
                    "DUPLICATE STOCK ITEMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes);

                var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                foreach (var item in selectedItems)
                {
                    CategoryItem duplicated = item.Duplicate();
                    duplicated.ItemName = "";
                    duplicated = await repoCategoryItem.Save(duplicated);
                    if (blnDuplicateStockItems)
                    {

                    }
                }

                await LoadCategoryItems();

                //    for (int i = 0; i < dgvCategoryItem.SelectedRows.Count; i++)
                //{

                //    CategoryItem eb = await bslayer.GetJustEntityButton(dgvCategoryItem.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                //    CategoryItem eb2 = eb.Duplicate();

                //    eb2.ItemName = "";
                //    if (await bslayer.SaveJustEntityButton(eb2))
                //    {
                //        if (blnDuplicateStockItems)
                //        {
                //            List<EntityButtonStockItemLookUp> lookupList = await bslayer.GetStockItemsForEB(eb.IID);
                //            foreach (var lookup in lookupList)
                //            {
                //                EntityButtonStockItemLookUp newlookup = lookup.Duplicate(eb2.IID);
                //                await bslayer.SaveEntityButtonStockItemLookUp(newlookup);
                //            }
                //            //DataTable dt = bslayer.GetStockItemsForEB(eb.IID);
                //            //for (int s = 0; s < dt.Rows.Count; s++) {
                //            //    EntityButtonStockItemLookUp lookup = new EntityButtonStockItemLookUp(dt.Rows[s]) {
                //            //        EntityButtonIID = eb2.IID
                //            //    };

                //            //    bslayer.SaveEntityButtonStockItemLookUp(lookup.Duplicate(eb2.IID));
                //            //}
                //        }
                //    }
                //}
            }
        }

        private async void LoadStockItems()
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                string selEBIID = dgvCategoryItem.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
                CategoryItem eb = await bslayer.GetJustEntityButton(selEBIID);

                try
                {
                    btnEBSample.Font = new Font(eb.FFamily, (float)eb.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), eb.FStyle));
                    pnlEBPicture.Width = eb.Width;
                    btnEBSample.Height = eb.Height;
                    btnEBSample.BackColor = Color.FromArgb(eb.BgColor);
                    btnEBSample.ForeColor = Color.FromArgb(eb.FgColor);
                    btnEBSample.Text = eb.ItemName;
                } catch
                {
                }

                GenericImage gim = await bslayer.GetGenericImage(selEBIID);
                if (gim == null)
                    pboxEBPicture.Image = null;
                else
                {
                    if (eb.ButtonDisplayStyle == ButtonDisplayStyles.Image || eb.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText)
                    {
                        pboxEBPicture.Image = UFWin.ByteArrayToImage(gim.DisplayImage);
                        lblImageSize.Text = gim.ImageSizeinKB.ToString() + " KB";
                    } else
                    {
                        pboxEBPicture.Image = null;
                    }
                }
                if (eb.ButtonDisplayStyle == ButtonDisplayStyles.Image || eb.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText)
                {

                    if (gim != null && gim.DisplayImage != null)
                    {
                        btnEBSample.Image = UFWin.ByteArrayToImage(gim.DisplayImage);
                        btnEBSample.ImageAlign = ContentAlignment.TopCenter;
                        btnEBSample.TextAlign = ContentAlignment.BottomCenter;
                    }
                } else
                {
                    btnEBSample.TextAlign = ContentAlignment.MiddleCenter;
                    btnEBSample.Image = null;
                }

                //   DataTable dt = UF.StringifyEnumInDataTable(await bslayer.GetStockItemsForEB(selEBIID), "QuantityType", "QuantityTypeAsString", typeof(QuantityTypes));
                dgvStockItems.DataSource = await bslayer.GetStockItemsForEB(selEBIID);
            }
        }

        private async void BtnAddStockItem_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                using (frmEntityButtonStockItemLookUp frm = new frmEntityButtonStockItemLookUp(bslayer, await bslayer.GetJustEntityButton(dgvCategoryItem.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString())))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadStockItems();
                }
            }
        }

        private async void BtnEditStockItem_Click(object sender, EventArgs e)
        {
            if (dgvStockItems.SelectedRows.Count > 0)
            {
                string IID = dgvStockItems.SelectedRows[0].Cells["colStockUsageIID"].Value.ToString();

                using (frmEntityButtonStockItemLookUp frm = new frmEntityButtonStockItemLookUp(bslayer, await bslayer.GetEntityButtonStockItemLookUp(IID)))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadStockItems();
                }
            }
        }

        private async void BtnDeleteStockItem_Click(object sender, EventArgs e)
        {
            if (dgvStockItems.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvStockItems.SelectedRows.Count; i++)
                {
                    string IID = dgvStockItems.SelectedRows[0].Cells["colStockUsageIID"].Value.ToString();
                    await bslayer.DeleteEntityButtonStockItemLookUp(IID);
                }
                LoadStockItems();
            }
        }


        private void DgvStockItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditStockItem_Click(null, null);
        }

        private async void BtnConvertToStockItem_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvCategoryItem.SelectedRows.Count; i++)
                {
                    CategoryItem eb = await bslayer.GetJustEntityButton(dgvCategoryItem.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                    StockItem si = new StockItem()
                    {
                        StockName = eb.ItemName
                    };
                    bslayer.SaveStockItem(si);
                }

            }
        }

        private void FrmMenuEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                BtnAddStockItem_Click(null, null);
        }

        private async void BtnExportStockManager_Click(object sender, EventArgs e)
        {
            //if (dgvMenu.SelectedRows.Count > 0)
            //{
            //    StockManager sm = await bslayer.GetStockManager();
            //    sm.Reference = "Stock Manager for " + " Bunu duzeltmek lazim " + DateTime.Now.ToString("dd MM yyyy");
            //    using (SaveFileDialog sfd = new SaveFileDialog())
            //    {
            //        sfd.Filter = "DTRM files (*.xml)|";
            //        sfd.FileName = sm.Reference;
            //        sfd.ShowDialog();
            //        if (sfd.FileName != null && sfd.FileName != "")
            //        {
            //            if (DRFile.XmlSerialize(sfd.FileName + ".xml", sm, typeof(StockManager), false))
            //                MessageBox.Show("Menu Stock Manager saved");
            //            else
            //                MessageBox.Show("Menu Stock Manager cannot be saved");
            //        }
            //    }
            //}
        }

        private async void BtnImportStockManager_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    ofd.ShowDialog();
            //    if (ofd.FileName != "")
            //    {
            //        StockManager sm;
            //        try
            //        {
            //            sm = (StockManager)DRFile.XmlDeSerialize(ofd.FileName, typeof(StockManager), false);
            //        } catch (Exception ex)
            //        {
            //            MessageBox.Show("Menu Stock Manager cannot be imported =" + ex.Message);
            //            return;
            //        }

            //        if (await bslayer.SaveStockManager(sm))
            //            LoadMenuList();
            //    }
            //}
        }

        private async void BtnSaveDBImagesToFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.ShowNewFolderButton = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dinfo = new DirectoryInfo(dlg.SelectedPath);
                    if (await bslayer.ExportDatabaseImagesIntoFolder(dinfo.FullName))
                        MessageBox.Show("Completed");
                    else
                        MessageBox.Show("Completed with Errors");
                }
            }
        }

        private async void BtnSetUpperCase_Click(object sender, EventArgs e)
        {
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.ItemName = item.ItemName.ToUpper();
                await repoCategoryItem.Save(item);
            }
            await LoadCategoryItems();

        }

        private async void BtnSetSentenceCase_Click(object sender, EventArgs e)
        {
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.ItemName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.ItemName);
            }
            await LoadCategoryItems();
        }


        private async void BtnSetToLowerCase_Click(object sender, EventArgs e)
        {
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.ItemName = item.ItemName.ToLower();
                await repoCategoryItem.Save(item);
            }
            await LoadCategoryItems();
        }

        private async void BtnSetAllForeColourTo_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdlg = new ColorDialog())
            {
                if (cdlg.ShowDialog() == DialogResult.OK)
                {
                    int selectedColor = cdlg.Color.ToArgb();
                    var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                    foreach (var item in selectedItems)
                    {
                        item.FgColor = selectedColor;
                        await repoCategoryItem.Save(item);
                    }
                    await LoadCategoryItems();
                }
            }
        }

        private async void BtnSetAllBackColourTo_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdlg = new ColorDialog())
            {
                if (cdlg.ShowDialog() == DialogResult.OK)
                {
                    int selectedColor = cdlg.Color.ToArgb();
                    var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                    foreach (var item in selectedItems)
                    {
                        item.BgColor = selectedColor;
                        await repoCategoryItem.Save(item);
                    }
                    await LoadCategoryItems();
                }
            }
        }

        private async void BtnSetAllBackColourToTransparent_Click(object sender, EventArgs e)
        {
            int selectedColor = Color.Transparent.ToArgb();
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.BgColor = selectedColor;
                await repoCategoryItem.Save(item);
            }
            await LoadCategoryItems();
        }

        private async void BtnChangeDistributionForEB_Click(object sender, EventArgs e)
        {
            using (frmDistributionSelector frm = ActivatorUtilities.CreateInstance<frmDistributionSelector>(ServiceHelper.Services, false, null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Distribution distribution = frm.selectedDistributions?.First();
                    if (distribution != null)
                    {
                        var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                        foreach (var item in selectedItems)
                        {
                            item.DistributionIID = distribution.IID;
                            await repoCategoryItem.Save(item);
                        }
                        await LoadCategoryItems();
                    }
                }
            }
        }







        private void BtnSearchCategoryButtons_Click(object sender, EventArgs e)
        {
            //if (txtSearchCategoryButtons.Text.Trim().Length == 0)
            //    return;


            //if (dgvMenu.Rows.Count > 0)
            //{

            //    string MenuIID = dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString();

            //    ((DataGridViewImageColumn)dgvSearchResults.Columns[columnName: "colDisplayImageSearch"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            //    ((DataGridViewImageColumn)dgvSearchResults.Columns[columnName: "colDisplayImageSearch"]).DefaultCellStyle.NullValue = null;

            //    string menustring = chkAllMenuSearch.Checked ? "" : " and Entity.ParentMenuIID = '" + MenuIID + "' ";

            //    dgvSearchResults.DataSource = bslayer.GetDataTable("SELECT EntityButton.IID, EntityButton.EntityButtonName, Entity.EntityName, Images.DisplayImage " +
            //                    "FROM Images RIGHT OUTER JOIN EntityButton ON Images.ReferenceIID = dbo.EntityButton.IID LEFT OUTER JOIN " +
            //                    " Entity ON EntityButton.ParentEntityIID = Entity.IID WHERE(EntityButton.EntityButtonName LIKE '%" + txtSearchCategoryButtons.Text + "%') " +
            //                    menustring + " ORDER BY EntityButton.EntityButtonName ");

            //    lblSearchResults.Text = "(" + dgvSearchResults.Rows.Count.ToString() + ")";
            //}
        }





        private void ChkAllMenuSearch_Click(object sender, EventArgs e)
        {
            BtnSearchCategoryButtons_Click(null, null);
        }

        private void chkIncludeCategoryItemDetails_CheckedChanged(object sender, EventArgs e)
        {
        }




        private async void btnEntityButtonRowHeight_Click(object sender, EventArgs e)
        {
            int rowheight = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            dgvCategoryItem.RowTemplate.Height = rowheight;
            await LoadCategoryItems();
        }



        private void pboxEBPicture_DoubleClick(object sender, EventArgs e)
        {
            if (pboxEBPicture.Image != null)
            {
                frmImageDialog frm = new frmImageDialog(pboxEBPicture.Image);
                frm.ShowDialog();
            }
        }


        private async void btnQuantityToComment_Click(object sender, EventArgs e)
        {
            if (dgvStockItems.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvStockItems.SelectedRows.Count; i++)
                {
                    string IID = dgvStockItems.SelectedRows[i].Cells["colStockUsageIID"].Value.ToString();

                    EntityButtonStockItemLookUp item = await bslayer.GetEntityButtonStockItemLookUp(IID);
                    item.Comment = item.Quantity + " " + item.QuantityType + item.Comment;

                    await bslayer.SaveEntityButtonStockItemLookUp(item);

                }
                LoadStockItems();
            }
        }






        private async void tsSortCategoryItem_Click(object sender, EventArgs e)
        {

            await repoCategoryItem.SortByField("CategoryIID", category.IID);
            await LoadCategoryItems();
        }

        private async void tsMoveUpCategoryItem_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                await repoCategoryItem.MoveUpByField((CategoryItem)dgvCategoryItem.SelectedRows[0].DataBoundItem, "CategoryIID", category.IID);
                await LoadCategoryItems();
            }
        }

        private async void tsMoveDownCategoryItem_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                await repoCategoryItem.MoveDownByField((CategoryItem)dgvCategoryItem.SelectedRows[0].DataBoundItem, "CategoryIID", category.IID);
                await LoadCategoryItems();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        async Task FormatCategorItemGrid() 
        {
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ItemName").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 200; c.HeaderText = "Category Item"; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ButtonType").ToList().ForEach(c => {  c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName.Contains("Price") || c.DataPropertyName.Contains("Tax")).ToList().ForEach(c => { c.DefaultCellStyle.Format = "N2"; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "PadFlag").ToList().ForEach(c => {  c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DistributionName").ToList().ForEach(c => { c.Width = 150; c.HeaderText = "Distribution"; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Width").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter ; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Height").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Font").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ButtonDisplayStyle").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "TextImageRelation").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ImageAlign").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "TextAlign").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DOrder").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            
        }
    }
}
