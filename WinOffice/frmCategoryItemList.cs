using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using PosLibrary.Forms;
using WinLayer;


namespace WinOffice
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
        IRepository<RecipeItem> repoRecipe;
        IRepository<GenericImage> repoImage;

        Category category;
        private BindingSource _categoryItemSource = new BindingSource();
        private BindingSource _recipeSource = new BindingSource();

        CategoryItem selectedCategoryItem;
        RecipeItem selectedRecipeItem;

        public frmCategoryItemList(PosConfig configAsService, IRepository<TheMenu> _repoMenu,
            IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem,
            IRepository<Printer> _repoPrinter,
                   IRepository<Employee> _repoEmployee, IRepository<Supplier> _repoSupplier,
                   IRepository<StockItem> _repoStockItem, IRepository<Bonus> _repoBonus, IRepository<RecipeItem> _repoRecipe,
                   IRepository<GenericImage> _repoImage, Category _category)
        {
            InitializeComponent();
            config = configAsService;
            repoMenu = _repoMenu;
            repoCategory = _repoCategory;
            repoCategoryItem = _repoCategoryItem;
            repoPrinter = _repoPrinter;
            repoEmployee = _repoEmployee;
            repoSupplier = _repoSupplier;
            repoStockItem = _repoStockItem;
            repoBonus = _repoBonus;
            repoRecipe = _repoRecipe;
            repoImage = _repoImage;

            category = _category;

            Thread.CurrentThread.CurrentUICulture = BSLayer.Instance.GetUICulture();
        }
        private async void FrmMenuEditor_Load(object sender, EventArgs e)
        {
            if (category == null || category.IID == null)
                this.Close();
            else
                await LoadCategoryItems();
        }

        #region CATEGORY ITEM FUNCTIONS    
        async Task LoadCategoryItems()
        {
            dgvCategoryItem.AutoGenerateColumns = false;
            dgvRecipe.AutoGenerateColumns = false;

            await FormatCategorItemGrid();
            await FormatRecipeGrid();

            category = await repoCategory.Get(category.IID, "Distribution, Items, Items.Distribution");

            _categoryItemSource.DataSource = category.Items.ReOrder().ToBindingList();
            // _categoryItemSource.Sort = "DOrder ASC";
            dgvCategoryItem.DataSource = _categoryItemSource;

            lblCategory.Text = "Category : " + category.CategoryName;
        }

        private async void btnAddCategoryItem_Click(object sender, EventArgs e)
        {
            using (frmCategoryItemUpsert frm = ActivatorUtilities.CreateInstance<frmCategoryItemUpsert>(ServiceHelper.Services, new CategoryItem() { CategoryIID = category.IID, DOrder = dgvCategoryItem.Rows.Count + 1 }))
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
        private async void dgvCategoryItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                selectedCategoryItem = _categoryItemSource.Current as CategoryItem;
                DisplaySampleCategoryItemButton();
                await LoadRecipeItems();
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
                    GenericImage gim = await repoImage.GetByField("ReferenceIID", selectedCategoryItem.IID);
                    if (gim != null && gim.DisplayImage != null)
                    {
                        Image btnImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                        pboxEBPicture.Image = btnImage;
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


        #region TOOLBAR BUTTON FUNCTIONS

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
                if (frm.ShowDialog() == DialogResult.OK)
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
                if (frm.ShowDialog() == DialogResult.OK)
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
                var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();

                using (frmInputForm frm = new frmInputForm(selectedItems.First().SalePrice.ToString()))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        double val = 0;
                        if (double.TryParse(frm.InputValue, out val))
                        {
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
                        await repoRecipe.GetListByField("CategoryItemIID", item.IID).ContinueWith(async t =>
                        {
                            List<RecipeItem> recipes = t.Result;
                            foreach (var recipe in recipes)
                            {
                                RecipeItem newRecipe = recipe.Duplicate();
                                newRecipe.CategoryItemIID = duplicated.IID;
                                await repoRecipe.Save(newRecipe);
                            }
                        });
                    }
                }
                await LoadCategoryItems();
            }
        }
        #endregion



        private async void BtnConvertToStockItem_Click(object sender, EventArgs e)
        {
            if (dgvCategoryItem.SelectedRows.Count > 0)
            {
                var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
                foreach (var item in selectedItems)
                {
                    await repoStockItem.Save(new StockItem()
                    {
                        StockName = item.ItemName
                    });
                }
            }
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
                    if (await BSLayer.Instance.ExportDatabaseImagesIntoFolder(dinfo.FullName))
                        MessageBox.Show("Completed");
                    else
                        MessageBox.Show("Completed with Errors");
                }
            }
        }

        private async void btnSetUpperCase_Click(object sender, EventArgs e)
        {
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.ItemName = item.ItemName.ToUpper();
                await repoCategoryItem.Save(item);
            }
            await LoadCategoryItems();

        }

        private async void btnSetSentenceCase_Click(object sender, EventArgs e)
        {
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.ItemName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.ItemName);
                await repoCategoryItem.Save(item);
            }
            await LoadCategoryItems();
        }


        private async void btnSetToLowerCase_Click(object sender, EventArgs e)
        {
            var selectedItems = dgvCategoryItem.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as CategoryItem).ToList();
            foreach (var item in selectedItems)
            {
                item.ItemName = item.ItemName.ToLower();
                await repoCategoryItem.Save(item);
            }
            await LoadCategoryItems();
        }

        private async void btnSetAllForeColourTo_Click(object sender, EventArgs e)
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

        private async void btnSetAllBackColourTo_Click(object sender, EventArgs e)
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

        private async void btnSetAllBackColourToTransparent_Click(object sender, EventArgs e)
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

        private async void btnChangeDistribution_Click(object sender, EventArgs e)
        {
            using (frmDistributionSelector frm = new frmDistributionSelector(null, category.MenuIID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Distribution distribution = frm.distribution;
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









        private async void btnEntityButtonRowHeight_Click(object sender, EventArgs e)
        {
            int rowheight = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            dgvCategoryItem.RowTemplate.Height = rowheight;
            await LoadCategoryItems();
        }

        private async void btnGridFontSize_Click(object sender, EventArgs e)
        {
            int fontsize = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            Font newFont = new Font(dgvCategoryItem.Font.FontFamily, fontsize, dgvCategoryItem.Font.Style);
            dgvCategoryItem.DefaultCellStyle.Font = newFont;
            dgvCategoryItem.ColumnHeadersDefaultCellStyle.Font = newFont;
            // await LoadCategoryItems();
        }


        private void pboxEBPicture_DoubleClick(object sender, EventArgs e)
        {
            if (pboxEBPicture.Image != null)
            {
                frmImageDialog frm = new frmImageDialog(pboxEBPicture.Image);
                frm.ShowDialog();
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
        async Task FormatCategorItemGrid()
        {
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ItemName").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 200; c.HeaderText = "Category Item"; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ButtonType").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName.Contains("Price")).ToList().ForEach(c => { c.Width = 70;c.DefaultCellStyle.BackColor = Color.AliceBlue; c.DefaultCellStyle.Format = "N2"; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName.Contains("Tax")).ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.BackColor = Color.LemonChiffon; c.DefaultCellStyle.Format = "N2"; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "PadFlag").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DistributionName").ToList().ForEach(c => { c.Width = 150; c.HeaderText = "Distribution"; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Width").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Height").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Font").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ButtonDisplayStyle").ToList().ForEach(c => { c.Width = 120; c.DefaultCellStyle.BackColor = Color.Bisque; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "TextImageRelation").ToList().ForEach(c => { c.Width = 120; c.DefaultCellStyle.BackColor = Color.Bisque; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ImageAlign").ToList().ForEach(c => { c.Width = 120; c.DefaultCellStyle.BackColor = Color.Bisque; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "TextAlign").ToList().ForEach(c => { c.Width = 120; c.DefaultCellStyle.BackColor = Color.Bisque; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategoryItem.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DOrder").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });


        }



        #region RECIPE ITEM FUNCTIONS

        private async Task LoadRecipeItems()
        {
            if (selectedCategoryItem != null)
            {
                _recipeSource.DataSource = (await repoRecipe.GetListByField("CategoryItemIID", selectedCategoryItem.IID, "StockItem")).ToBindingList();
                dgvRecipe.DataSource = _recipeSource;
            }
        }
        private void dgvRecipe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecipe.SelectedRows.Count > 0)
            {
                selectedRecipeItem = (RecipeItem)dgvRecipe.SelectedRows[0].DataBoundItem;
            } else
            {
                selectedRecipeItem = null;
            }
        }
        private async void btnAddRecipeItem_Click(object sender, EventArgs e)
        {
            if (selectedCategoryItem != null)
            {
                using (frmRecipe frm = ActivatorUtilities.CreateInstance<frmRecipe>(ServiceHelper.Services, selectedCategoryItem, dgvRecipe.Rows.Count + 1))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        await LoadRecipeItems();
                }
            }
        }
        private async void btnEditRecipeItem_Click(object sender, EventArgs e)
        {
            if (selectedRecipeItem != null)
            {
                using (frmRecipe frm = ActivatorUtilities.CreateInstance<frmRecipe>(ServiceHelper.Services, (RecipeItem)dgvRecipe.SelectedRows[0].DataBoundItem))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        await LoadRecipeItems();
                }
            }
        }
        private void dgvRecipeItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditRecipeItem_Click(null, null);
        }
        private async void btnDeleteRecipeItem_Click(object sender, EventArgs e)
        {
            if (selectedRecipeItem != null)
            {
                await repoRecipe.Delete(selectedRecipeItem.IID);
                await repoRecipe.SortByField("CategoryItemIID", selectedCategoryItem.IID);
                await LoadRecipeItems();
            }
        }

        List<RecipeItem> copiedRecipeItems = new List<RecipeItem>();
        private void btnCopyRecipeItems_Click(object sender, EventArgs e)
        {
            copiedRecipeItems = dgvRecipe.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as RecipeItem).ToList();
        }

        private async void btnPasteRecipeItems_Click(object sender, EventArgs e)
        {
            if (!copiedRecipeItems.IsNullOrEmpty() && selectedCategoryItem != null)
            {
                foreach (var recipe in copiedRecipeItems)
                {
                    RecipeItem newRecipe = recipe.Duplicate();
                    newRecipe.CategoryItemIID = selectedCategoryItem.IID;
                    await repoRecipe.Save(newRecipe);
                }
                await LoadRecipeItems();
            }
        }

        private async void btnQuantityToComment_Click(object sender, EventArgs e)
        {
            if (selectedRecipeItem != null)
            {
                selectedRecipeItem.Comment = selectedRecipeItem.Quantity + " " + selectedRecipeItem.QuantityType + selectedRecipeItem.Comment;
                await repoRecipe.Save(selectedRecipeItem);
                await LoadRecipeItems();
            }
        }


        private async void tsSortRecipeItem_Click(object sender, EventArgs e)
        {
            await repoRecipe.SortByField("CategoryItemIID", selectedCategoryItem.IID);
            await LoadRecipeItems();
        }

        private async void tsMoveUpRecipeItem_Click(object sender, EventArgs e)
        {
            if (selectedCategoryItem != null)
            {
                await repoRecipe.MoveUpByField((RecipeItem)dgvRecipe.SelectedRows[0].DataBoundItem, "CategoryItemIID", selectedCategoryItem.IID);
                await LoadRecipeItems();
            }
        }

        private async void tsMoveDownRecipeItem_Click(object sender, EventArgs e)
        {
            if (selectedCategoryItem != null)
            {
                await repoRecipe.MoveDownByField((RecipeItem)dgvRecipe.SelectedRows[0].DataBoundItem, "CategoryItemIID", selectedCategoryItem.IID);
                await LoadRecipeItems();
            }
        }




        async Task FormatRecipeGrid()
        {
            dgvRecipe.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "RecipeText").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 200; c.HeaderText = "Recipe Item Text"; });
            dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "StockItemName").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 200; c.HeaderText = "Stock Item Name"; });
            // dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "CategoryItemName").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 200; c.HeaderText = "Category Item Name"; });
            dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Quantity").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Format = "N2"; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "QuantityType").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DOrder").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvRecipe.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Comment").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 800; c.HeaderText = "Comment"; });


        }

        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}
