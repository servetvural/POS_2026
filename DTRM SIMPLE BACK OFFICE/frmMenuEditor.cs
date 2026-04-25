using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
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


namespace POSOffice
{
    public partial class FrmMenuEditor : Form
    {
        PosConfig config;
        IRepository<TheMenu> repoMenu;
        IRepository<Category> repoCategory;
        IRepository<CategoryItem> repoCategoryItem;
        IRepository<Printer> repoPrinter;
        IRepository<Employee> repoEmployee;
        IRepository<Supplier> repoSupplier;
        IRepository<StockItem> repoStockItem;
        IRepository<RecipeItem> repoRecipe;
        IRepository<Bonus> repoBonus;
        IRepository<GenericImage> repoImage;

        private BindingSource _menuSource = new BindingSource();
        private BindingSource _categorySource = new BindingSource();

        TheMenu selectedMenu;

        public FrmMenuEditor(PosConfig configAsService, IRepository<TheMenu> _repoMenu,
            IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem,
            IRepository<Printer> _repoPrinter,IRepository<Employee> _repoEmployee, IRepository<Supplier> _repoSupplier,
            IRepository<StockItem> _repoStockItem, IRepository<Bonus> _repoBonus, IRepository<GenericImage> _repoImage,
            IRepository<RecipeItem> _repoRecipe)
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
            repoImage = _repoImage;
            repoRecipe = _repoRecipe;
        }
        private async void FrmMenuEditor_Load(object sender, EventArgs e)
        {
            await LoadMenuList();
        }

        #region MENU FUNCTIONS
        private async Task LoadMenuList()
        {
            BindingList<TheMenu> menuList = new BindingList<TheMenu>(await repoMenu.GetAllAsync("categories, categories.Distribution, categories.Items, categories.Items.Distribution"));

            foreach (var menu in menuList)
            {
                menu.categories.ReOrder().ToBindingList();
            }

            dgvMenu.AutoGenerateColumns = false;
            dgvCategory.AutoGenerateColumns = false;

            await FormatCategorGrid();

            // 2. Set up Parent Source
            _menuSource.DataSource = menuList;
            _menuSource.Sort = "DOrder ASC";
            dgvMenu.DataSource = _menuSource;

            // 3. Chain the Child Source to the Parent  'categories' is the property name of the collection inside the Order object
            _categorySource.DataSource = _menuSource;

            _categorySource.DataMember = "categories";
            _categorySource.Sort = "DOrder ASC";
            dgvCategory.DataSource = _categorySource;

            //If there is menu enable entity section
            barEntity.Enabled = dgvMenu.SelectedRows.Count > 0;

        }

        private async void btnReloadMenu_Click(object sender, EventArgs e)
        {
            await LoadMenuList();
        }
        private void DgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                selectedMenu = (TheMenu)dgvMenu.SelectedRows[0].DataBoundItem;
            } else
                selectedMenu = null;
        }

        private async void BtnAddMenu_Click(object sender, EventArgs e)
        {
            using (frmInputForm frm = new frmInputForm("New Menu"))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    TheMenu menu = new TheMenu()
                    {
                        MenuName = frm.InputValue
                    };
                    if (await repoMenu.Save(menu) != null)
                        await LoadMenuList();
                }
            }
        }
        private async void BtnEditMenu_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                using (frmStringInput frm = new frmStringInput("Menu Name", selectedMenu.MenuName))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        selectedMenu.MenuName = frm.text;
                        if (await repoMenu.Save(selectedMenu) != null)
                            await LoadMenuList();
                    }
                }
            }
        }
        private void dgvMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditMenu_Click(null, null);
        }

        private async void BtnDeleteMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will delete the menu: NOT RECOMMENDED");
            if (dgvMenu.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("This will delete the selected Menu (" + selectedMenu.MenuName + "\nAre you sure you want to DELETE???\nYou can only recover this Menu if you backed it up!!!", "MENU DELETION", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    await repoMenu.Delete(selectedMenu.IID);
                    await LoadMenuList();
                }
            }
        }

        private async void BtnBackupMenu_Click(object sender, EventArgs e)
        {
            POSLayerBackup backup = new POSLayerBackup()
            {
                menus = await repoMenu.GetAllAsync(),
                printers = await repoPrinter.GetAllAsync(),
                employees = await repoEmployee.GetAllAsync(),
                suppliers = await repoSupplier.GetAllAsync(),
                stockItems = await repoStockItem.GetAllAsync(),
                recipes = await repoRecipe.GetAllAsync(),
                bonuslist = await repoBonus.GetAllAsync()

                //Get Generic Images 
                // backup.genericImages = bslayer.GetImageLibraryList();
            };
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "backup.json";
                sfd.ShowDialog();

                if (sfd.FileName != null && sfd.FileName != "")
                {
                    var jsonString = JsonConvert.SerializeObject(backup, Formatting.Indented);
                    if (UF.SaveTextFile(sfd.FileName, jsonString))
                        MessageBox.Show("Saved Backup as JSON");
                    else
                        MessageBox.Show("Failed to Save Backup as JSON");
                }
            }
        }

        private async void BtnLoadMenu_Click(object sender, EventArgs e)
        {
            string statusMessage = "";
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                // sfd.FileName = "Printer List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        string content = UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            DTRMBackup backup = JsonConvert.DeserializeObject<DTRMBackup>(content);

                            //Save menus
                            foreach (TheMenu menu in backup.menus)
                            {
                                await repoMenu.SaveTree(menu);
                                statusMessage += menu.MenuName + " Saved " + Environment.NewLine;
                            }

                            //Save printers
                            foreach (Printer printer in backup.printers)
                            {
                                await repoPrinter.Save(printer);
                            }
                            if (backup.printers.Count > 0)
                            {
                                statusMessage += "Printers Saved " + Environment.NewLine;
                            }

                            //Save employees
                            foreach (Employee employee in backup.employees)
                            {
                                await repoEmployee.Save(employee);
                            }
                            if (backup.employees.Count > 0)
                            {
                                statusMessage += "Employees Saved " + Environment.NewLine;
                            }

                            //Save suppliers
                            foreach (Supplier item in backup.suppliers)
                            {
                                await repoSupplier.Save(item);
                            }
                            if (backup.suppliers.Count > 0)
                            {
                                statusMessage += "Suppliers Saved " + Environment.NewLine;
                            }


                            //Save stock items
                            foreach (StockItem item in backup.stockItems)
                            {
                                await repoStockItem.Save(item);
                            }
                            if (backup.stockItems.Count > 0)
                            {
                                statusMessage += "Stock Items Saved " + Environment.NewLine;
                            }

                            //Save stock item lookups
                            if (await DTRMSimpleBusiness.Instance.SaveAllRecipes(backup.recipes))
                            {
                                statusMessage += "Stock Item Lookups Saved " + Environment.NewLine;
                            }


                            //Save bonus items
                            foreach (Bonus item in backup.bonuslist)
                            {
                                await repoBonus.Save(item);
                            }
                            if (backup.bonuslist.Count > 0)
                            {
                                statusMessage += "Bonus List Saved " + Environment.NewLine;
                            }

                            //Save Generic Images 
                            // backup.genericImages = bslayer.GetImageLibraryList();


                            MessageBox.Show(statusMessage);
                        } else
                        {
                            MessageBox.Show("Failed to " + Environment.NewLine + statusMessage);
                        }
                        await LoadMenuList();
                    }
                }
            }

        }
        private void BtnPrintMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to print the entire menu price list.\nDo you want to continue?", "PRINT PRICE LIST", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                using (frmAppPrinterDialog frm = ActivatorUtilities.CreateInstance<frmAppPrinterDialog>(ServiceHelper.Services))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DTRMSimpleBusiness.Instance.PrintPriceList(((TheMenu)dgvMenu.SelectedRows[0].DataBoundItem).IID, frm.SelectedPrinterIID);
                    }
                }
            }
        }
        #endregion



        #region CATEGORY FUNCTIONS
        private void DgvEntity_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                try
                {
                    DisplayCategoryButton();
                } catch
                {

                }
            }
        }
        private async void DisplayCategoryButton()
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                Category category = _categorySource.Current as Category;
                btnCategorySample.Width = category.Width;
                btnCategorySample.Text = category.CategoryName;
                btnCategorySample.Font = new Font(category.FFamily, (float)category.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), category.FStyle));
                btnCategorySample.BackColor = Color.FromArgb(category.BgColour);
                btnCategorySample.ForeColor = Color.FromArgb(category.FgColour);

                btnCategorySample.DisplayStyle = (ToolStripItemDisplayStyle)category.ButtonDisplayStyle;
                btnCategorySample.TextAlign = (ContentAlignment)category.TextAlign;
                btnCategorySample.ImageAlign = (ContentAlignment)category.ImageAlign;
                btnCategorySample.TextImageRelation = (TextImageRelation)category.TextImageRelation;

                if (category.ButtonDisplayStyle == ButtonDisplayStyles.Image || category.ButtonDisplayStyle == ButtonDisplayStyles.ImageAndText)
                {
                    GenericImage gim = await repoImage.GetByField("ReferenceIID", category.IID);
                    if (gim != null && gim.DisplayImage != null)
                    {
                        Image btnImage = UFWin.ByteArrayToImage(gim.DisplayImage);
                        btnCategorySample.Image = UFWin.ReSizeImageTo(btnImage, btnCategorySample.Height - 5, btnCategorySample.Height - 5);
                        btnCategorySample.ImageScaling = ToolStripItemImageScaling.None;
                    } else
                    {
                        btnCategorySample.Image = null;
                    }
                } else
                {
                    btnCategorySample.Image = null;
                }
            }
        }

        private async void BtnAddEntity_Click(object sender, EventArgs e)
        {
            using (frmCategoryUpsert frm = ActivatorUtilities.CreateInstance<frmCategoryUpsert>(ServiceHelper.Services, new Category() { MenuIID = selectedMenu.IID }))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    await LoadMenuList();
                }
            }
        }

        private async void BtnEditEntity_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategory.SelectedRows.Count > 0)
                {
                    using (frmCategoryUpsert frm = ActivatorUtilities.CreateInstance<frmCategoryUpsert>(ServiceHelper.Services, (Category)dgvCategory.SelectedRows[0].DataBoundItem))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            await LoadMenuList();
                        }
                    }
                }
            } catch { }
        }

        private async void BtnDeleteEntity_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("This will delete the entity and all the associated buttons.\nDo you want to continue?", "Delete Entity", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    await repoCategory.Delete((_categorySource.Current as Category).IID);
                    await LoadMenuList();
                }
            }

        }
        private void DgvEntity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditEntity_Click(null, null);
        }
        #endregion





        private async void BtnExportStockManager_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                StockManager sm = await DTRMSimpleBusiness.Instance.GetStockManager();
                sm.Reference = "Stock Manager for " + " Bunu duzeltmek lazim " + DateTime.Now.ToString("dd MM yyyy");
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "DTRM files (*.xml)|";
                    sfd.FileName = sm.Reference;
                    sfd.ShowDialog();
                    if (sfd.FileName != null && sfd.FileName != "")
                    {
                        if (DRFile.XmlSerialize(sfd.FileName + ".xml", sm, typeof(StockManager), false))
                            MessageBox.Show("Menu Stock Manager saved");
                        else
                            MessageBox.Show("Menu Stock Manager cannot be saved");
                    }
                }
            }
        }

        private async void BtnImportStockManager_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    StockManager sm;
                    try
                    {
                        sm = (StockManager)DRFile.XmlDeSerialize(ofd.FileName, typeof(StockManager), false);
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Menu Stock Manager cannot be imported =" + ex.Message);
                        return;
                    }

                    if (await DTRMSimpleBusiness.Instance.SaveStockManager(sm))
                        await LoadMenuList();
                }
            }
        }

        private async void BtnSaveDBImagesToFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.ShowNewFolderButton = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dinfo = new DirectoryInfo(dlg.SelectedPath);
                    if (await DTRMSimpleBusiness.Instance.ExportDatabaseImagesIntoFolder(dinfo.FullName))
                        MessageBox.Show("Completed");
                    else
                        MessageBox.Show("Completed with Errors");
                }
            }
        }

        private async void mnuSetAsDefaultMenu_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                config.ActiveMenuIID = selectedMenu.IID;
                UF.SaveConfig(config);
                await repoMenu.SetMenuIsActive(selectedMenu.IID);

                await LoadMenuList();
            }
        }

        private async void btnExportMenuAsJson_Click(object sender, EventArgs e)
        {

            if (dgvMenu.SelectedRows.Count > 0)
            {
                TheMenu menu = await repoMenu.Get(selectedMenu.IID);
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "JSON Files (*.json)|";
                    sfd.FileName = menu.MenuName + ".json";
                    sfd.ShowDialog();

                    if (sfd.FileName != null && sfd.FileName != "")
                    {
                        var jsonString = JsonConvert.SerializeObject(menu, Formatting.Indented);
                        if (UF.SaveTextFile(sfd.FileName, jsonString))
                            MessageBox.Show("Saved Menu Backup as JSON");
                        else
                            MessageBox.Show("Failed to Save Menu Backup as JSON");
                    }
                }
            }
        }

        private async void btnImportMenuFromJSON_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {
                        string content = UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            TheMenu fm = JsonConvert.DeserializeObject<TheMenu>(content);
                            await repoMenu.SaveTree(fm);

                            MessageBox.Show("Saved Printer List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Printer List");
                        }
                        await LoadMenuList();
                    }
                }
            }

        }

        private async void tsSortMenu_Click(object sender, EventArgs e)
        {
            await repoMenu.Sort();
            await LoadMenuList();
        }

        private async void tsMoveUpMenu_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                await repoMenu.MoveUp(selectedMenu);
                await LoadMenuList();
            }
        }

        private async void tsMoveDownMenu_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                await repoMenu.MoveDown(selectedMenu);
                await LoadMenuList();
            }
        }

        private async void tsSortCategory_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                await repoCategory.SortByField("MenuIID", selectedMenu.IID);
                await LoadMenuList();
            }
        }

        private async void tsMoveUpCategory_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null && dgvCategory.SelectedRows.Count > 0)
            {
                await repoCategory.MoveUpByField((Category)dgvCategory.SelectedRows[0].DataBoundItem, "MenuIID", selectedMenu.IID);
                await LoadMenuList();
            }
        }

        private async void tsMoveDownCategory_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null && dgvCategory.SelectedRows.Count > 0)
            {
                await repoCategory.MoveDownByField((Category)dgvCategory.SelectedRows[0].DataBoundItem, "MenuIID", selectedMenu.IID);
                await LoadMenuList();
            }
        }

        private void btnCategoryItems_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                Category category = (Category)dgvCategory.SelectedRows[0].DataBoundItem;
                using (frmCategoryItemList frm = ActivatorUtilities.CreateInstance<frmCategoryItemList>(ServiceHelper.Services, category))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCategorySample_Paint(object sender, PaintEventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            // Draw a solid red border around the button's content area
            ControlPaint.DrawBorder(e.Graphics, btn.ContentRectangle,
                Color.Black, ButtonBorderStyle.Solid);
        }


        async Task FormatCategorGrid()
        {
            dgvCategory.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "CategoryName").ToList().ForEach(c => { c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft; c.Width = 200; c.HeaderText = "Category Name"; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "CategoryType").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            //dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName.Contains("Price") || c.DataPropertyName.Contains("Tax")).ToList().ForEach(c => { c.DefaultCellStyle.Format = "N2"; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            //dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "PadFlag").ToList().ForEach(c => { c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DistributionName").ToList().ForEach(c => { c.Width = 150; c.HeaderText = "Distribution"; });

            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Width").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Height").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "Font").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ButtonDisplayStyle").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "TextImageRelation").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "ImageAlign").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });
            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "TextAlign").ToList().ForEach(c => { c.Width = 150; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });

            dgvCategory.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == "DOrder").ToList().ForEach(c => { c.Width = 70; c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; });


        }
    }
}
