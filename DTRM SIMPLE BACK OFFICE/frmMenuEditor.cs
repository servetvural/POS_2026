using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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


namespace DTRMSimpleBackOffice
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
        IRepository<Bonus> repoBonus;

        private DTRMSimpleBusiness bslayer;

        private BindingSource _menuSource = new BindingSource();
        private BindingSource _categorySource = new BindingSource();

        TheMenu selectedMenu;

        public FrmMenuEditor(PosConfig configAsService, IRepository<TheMenu> _repoMenu,
            IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem,
            IRepository<Printer> _repoPrinter,
                   IRepository<Employee> _repoEmployee, IRepository<Supplier> _repoSupplier,
                   IRepository<StockItem> _repoStockItem, IRepository<Bonus> _repoBonus,
            DTRMSimpleBusiness bslayer)
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
        }
        private async void FrmMenuEditor_Load(object sender, EventArgs e)
        {
            await LoadMenuList();
        }

        #region MENU FUNCTIONS
        private async Task LoadMenuList()
        {
            BindingList<TheMenu> menuList = new BindingList<TheMenu>(await repoMenu.GetAllAsync("categories, categories.Distribution"));

            foreach (var menu in menuList)
            {
                menu.categories.ReOrder().ToBindingList();
            }

            dgvMenu.AutoGenerateColumns = false;
            dgvCategory.AutoGenerateColumns = false;

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
                menus = await bslayer.GetAllMenuList(),
                printers = await bslayer.GetAllPrinters(),
                employees = await bslayer.GetAllEmployeeList(),
                suppliers = await bslayer.GetAllSuppliersAsList(),
                stockItems = await bslayer.GetAllStockItemsList(),
                stockItemLookups = await bslayer.GetAllEntityButtonStockItemLookUps(),
                bonuslist = await bslayer.GetAllBonusList()
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
                            if (bslayer.SaveAllStockItemLookups(backup.stockItemLookups))
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
                        bslayer.PrintPriceList(((TheMenu)dgvMenu.SelectedRows[0].DataBoundItem).IID, frm.SelectedPrinterIID);
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
                    await bslayer.DeleteEntityDB(((Category)dgvCategory.SelectedRows[0].DataBoundItem).IID);
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
                StockManager sm = await bslayer.GetStockManager();
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

                    if (await bslayer.SaveStockManager(sm))
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
                    if (await bslayer.ExportDatabaseImagesIntoFolder(dinfo.FullName))
                        MessageBox.Show("Completed");
                    else
                        MessageBox.Show("Completed with Errors");
                }
            }
        }

        private DataGridView dgvSource;
        private Rectangle dragBox;
        private int rowIndexSource;
        private int rowIndexDestination;

        private void Dgv_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBox != Rectangle.Empty && !dragBox.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    //  DragDropEffects dropEffect =
                    ((DataGridView)sender).DoDragDrop(((DataGridView)sender).Rows[rowIndexSource], DragDropEffects.Move);
                }
            }
        }

        private void Dgv_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexSource = ((DataGridView)sender).HitTest(e.X, e.Y).RowIndex;
            if (rowIndexSource != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being at the center of the rectangle.
                dragBox = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                dgvSource = ((DataGridView)sender);
            } else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBox = Rectangle.Empty;
        }

        private void Dgv_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            if (dgvSource != (DataGridView)sender)
                e.Effect = DragDropEffects.None;
        }



        private async void DgvEntity_DragDrop(object sender, DragEventArgs e)
        {
            if (dgvSource != (DataGridView)sender)
                return;

            // The mouse locations are relative to the screen, so they must be converted to client coordinates.
            Point clientPoint = ((DataGridView)sender).PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexDestination = ((DataGridView)sender).HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                //DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                // MessageBox.Show("From : " + rowIndexSource + ",  To : " + rowIndexDestination);
                //call the methods to change the order now

                //dropped on
                int don = rowIndexDestination;
                //being dropped on
                int bdon = rowIndexSource;
                bool blnArdisik;

                //target doesn't exist
                if (don == -1)
                    return;


                //always set bdon to don value on upward or downward movements
                bslayer.SetEntityDisplayOrder(dgvCategory.Rows[bdon].Cells["colEntityIID"].Value.ToString(), don);


                if (bdon < don)
                {
                    //Moving downwards
                    blnArdisik = bdon + 1 == don;

                    if (blnArdisik)
                    {
                        //Just swap
                        bslayer.SetEntityDisplayOrder(dgvCategory.Rows[don].Cells["colEntityIID"].Value.ToString(), bdon);


                    } else
                    {
                        bslayer.SetEntityDisplayOrder(dgvCategory.Rows[don].Cells["colEntityIID"].Value.ToString(), don - 1);
                        //arayi doldur
                        for (int i = bdon + 1; i < don; i++)
                            bslayer.SetEntityDisplayOrder(dgvCategory.Rows[i].Cells["colEntityIID"].Value.ToString(), i - 1);
                    }
                } else
                {
                    //Moving upwards
                    blnArdisik = don + 1 == bdon;

                    if (blnArdisik)
                    {
                        //Just swap
                        bslayer.SetEntityDisplayOrder(dgvCategory.Rows[don].Cells["colEntityIID"].Value.ToString(), bdon);
                    } else
                    {
                        bslayer.SetEntityDisplayOrder(dgvCategory.Rows[don].Cells["colEntityIID"].Value.ToString(), don + 1);
                        //arayi doldur
                        for (int i = don + 1; i < bdon; i++)
                            bslayer.SetEntityDisplayOrder(dgvCategory.Rows[i].Cells["colEntityIID"].Value.ToString(), i + 1);
                    }
                }

                await LoadMenuList();
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
                TheMenu menu = await bslayer.GetMenuDB(dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString());
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
                            await bslayer.SaveMenuDB(fm);

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
    }
}
