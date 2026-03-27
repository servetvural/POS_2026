using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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


namespace DTRMSimpleBackOffice {
    public partial class FrmMenuEditor : Form {
        PosConfig config;
        private DTRMSimpleBusiness bslayer;
        IRepository<TheMenu> repoMenu;


        private string SelectedMenuIID;

        //public FrmMenuEditor() {
        //    InitializeComponent();
        //}
        public FrmMenuEditor(PosConfig configAsService, DTRMSimpleBusiness bslayer, IRepository<TheMenu> _repoMenu) {
            InitializeComponent();
            config = configAsService;
            this.bslayer = bslayer;
            repoMenu = _repoMenu;
        }
        private void FrmMenuEditor_Load(object sender, EventArgs e) {
            LoadMenuList();
        }


        #region MENU FUNCTIONS
        private async void LoadMenuList() {
            UnloadMenuList();
           // var bindingList = new BindingList<POSLayer.Models.TheMenu>(await bslayer.GetMenuList());
            dgvMenu.DataSource = (await bslayer.GetMenuList()).ToBindingList();
          //If there is menu enable entity section
          barEntity.Enabled = barEntityButton.Enabled = barStockUsage.Enabled = barSearchCategoryItems.Enabled = dgvMenu.SelectedRows.Count > 0;

        }
        private void UnloadMenuList() {
            UnloadEntityList();
            dgvMenu.DataSource = null;

            dgvSearchResults.DataSource = null;
            dgvSearchResults.Refresh();
        }
        private void DgvMenu_SelectionChanged(object sender, EventArgs e) {

            if (dgvMenu.SelectedRows.Count > 0) {
                try {
                    if (dgvMenu.Rows.Count > 0) {
                        ClearSearchResults();
                        dgvEntity.DataSource = null;
                        dgvEntityButton.DataSource = null;
                        dgvStockItems.DataSource = null;

                        SelectedMenuIID = dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString();

                        LoadEntityList();

                    }
                } catch { }
            }
        }

        private void ClearSearchResults() {
            dgvSearchResults.DataSource = null;
            dgvSearchResults.Refresh();
            txtSearchCategoryButtons.Text = "";
        }
        private async void BtnAddMenu_Click(object sender, EventArgs e) {
            using (frmInputForm frm = new frmInputForm("New Menu")) {
                if (frm.ShowDialog() == DialogResult.OK) {
                    TheMenu menu = new TheMenu()
                    {
                        MenuName = frm.InputValue
                    };
                    if (await repoMenu.Save(menu) != null )
                        LoadMenuList();
                }
            }
        }
        private async void BtnEditMenu_Click(object sender, EventArgs e) {
            if (dgvMenu.SelectedRows.Count > 0) {
                POSLayer.Models.TheMenu menu = await bslayer.GetMenuDB(dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString());

                using (frmInputForm frm = new frmInputForm(menu.MenuName)) {
                    if (frm.ShowDialog() == DialogResult.OK) {
                        menu.MenuName = frm.InputValue;
                        if (await repoMenu.Save(menu) != null)
                            LoadMenuList();
                    }
                }
            }
        }

        private async void BtnDeleteMenu_Click(object sender, EventArgs e) {
            MessageBox.Show("This will delete the menu: NOT RECOMMENDED");
            if (SelectedMenuIID != "") {
                if (MessageBox.Show("This will delete the selected Menu (" + dgvMenu.SelectedRows[0].Cells["colMenuName"].Value.ToString() + "\nAre you sure you want to DELETE???\nYou can only recover this Menu if you backed it up!!!", "MENU DELETION", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                   await repoMenu.Delete(SelectedMenuIID);
                    LoadMenuList();
                }
            }
        }

        private async void BtnBackupMenu_Click(object sender, EventArgs e) {
            //if (dgvMenu.SelectedRows.Count > 0) {
            //    FMenu menu = bslayer.GetMenuDB(dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString());
            //    using (SaveFileDialog sfd = new SaveFileDialog()) {
            //        sfd.Filter = "DTRM files (*.xml)|";
            //        sfd.FileName = menu.MenuName;
            //        sfd.ShowDialog();
            //        DirectoryInfo dinfo = null;

            //        if (sfd.FileName != null && sfd.FileName != "") {
            //            FileInfo finfo = new FileInfo(sfd.FileName);
            //            dinfo = finfo.Directory;

            //            if (DRFile.XmlSerialize(sfd.FileName + ".xml", menu, typeof(FMenu), false))
            //                MessageBox.Show("Menu saved");
            //            else
            //                MessageBox.Show("Menu cannot be saved");
            //        }
            //    }
            //}


            POSLayerBackup backup = new POSLayerBackup();

            //Get menus
            backup.menus =await bslayer.GetAllMenuList();
            //if (dgvMenu.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dgvMenu.Rows.Count; i++)
            //    {
            //        backup.menus.Add(bslayer.GetMenuDB(dgvMenu.Rows[0].Cells["colMenuIID"].Value.ToString()));
            //    }
            //}

            //Get printers
            backup.printers = await bslayer.GetAllPrinters();
            //Get employees
            backup.employees = await bslayer.GetAllEmployeeList();
            //Get suppliers
            backup.suppliers = await bslayer.GetAllSuppliersAsList();
            //Get stock items
            backup.stockItems = await bslayer.GetAllStockItemsList();
            //Get stock item lookups
            backup.stockItemLookups = await bslayer.GetAllEntityButtonStockItemLookUps();
            //Get bonus items
            backup.bonuslist = await bslayer.GetAllBonusList();
            //Get Generic Images 
           // backup.genericImages = bslayer.GetImageLibraryList();


            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                sfd.FileName = "backup.json";
                sfd.ShowDialog();

                if (sfd.FileName != null && sfd.FileName != "")
                {
                    var jsonString = JsonConvert.SerializeObject(backup, Formatting.Indented);
                    if (POSLayer.Library.UF.SaveTextFile(sfd.FileName, jsonString))
                        MessageBox.Show("Saved Backup as JSON");
                    else
                        MessageBox.Show("Failed to Save Backup as JSON");
                }
            }
        }

        private void BtnLoadMenu_Click(object sender, EventArgs e) {
            //using (OpenFileDialog ofd = new OpenFileDialog()) {
            //    ofd.ShowDialog();
            //    if (ofd.FileName != "") {
            //        FMenu fm = null;
            //        try {
            //            fm = (FMenu)DRFile.XmlDeSerialize(ofd.FileName, typeof(FMenu), false);
            //        } catch {
            //            MessageBox.Show("Menu cannot be imported");
            //            return;
            //        }

            //        bslayer.SaveMenuDB(fm);
            //        bslayer.SaveMenuA(fm);
            //        LoadMenuList();
            //    }
            //}


            string statusMessage = "";
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|";
                // sfd.FileName = "Printer List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != null && sfd.FileName != "")
                    {

                        string content = POSLayer.Library.UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            POSLayer.Library.DTRMBackup backup = JsonConvert.DeserializeObject<POSLayer.Library.DTRMBackup>(content);

                            //Save menus
                            foreach (POSLayer.Models.TheMenu menu in backup.menus)
                            {
                                bslayer.SaveMenuDB(menu);
                                statusMessage += menu.MenuName + " Saved " + Environment.NewLine;
                            }

                            //Save printers
                            foreach (Printer printer in backup.printers)
                            {
                                bslayer.SavePrinter(printer);
                            }
                            if (backup.printers.Count > 0)
                            {
                                statusMessage +="Printers Saved " + Environment.NewLine;
                            }

                            //Save employees
                            foreach (Employee employee in backup.employees)
                            {
                                bslayer.SaveEmployee(employee);
                            }
                            if (backup.employees.Count > 0)
                            {
                                statusMessage += "Employees Saved " + Environment.NewLine;
                            }


                            //Save suppliers
                            foreach (Supplier item in backup.suppliers)
                            {
                                bslayer.SaveSupplier(item);
                            }
                            if (backup.suppliers.Count > 0)
                            {
                                statusMessage += "Suppliers Saved " + Environment.NewLine;
                            }


                            //Save stock items
                            foreach (StockItem item in backup.stockItems)
                            {
                                bslayer.SaveStockItem(item);
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
                                bslayer.SaveBonus(item);
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
                        LoadMenuList();
                    }
                }
            }

        }
        private void BtnPrintMenu_Click(object sender, EventArgs e) {
            if (MessageBox.Show("You are about to print the entire menu price list.\nDo you want to continue?", "PRINT PRICE LIST", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                using (frmAppPrinterDialog frm = new frmAppPrinterDialog(bslayer)) {
                    if (frm.ShowDialog() == DialogResult.OK) {
                        string catalogIID = dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString();
                        bslayer.PrintPriceList(catalogIID, frm.SelectedPrinterIID);
                    }
                }
            }
        }
        #endregion


        #region ENTITY FUNCTIONS
        private void LoadEntityList() {

            dgvEntity.Columns["colELHeight"].Visible =
                dgvEntity.Columns["colELWidth"].Visible =
                dgvEntity.Columns["colELDistributionName"].Visible =
                dgvEntity.Columns["colELFont"].Visible =
                dgvEntity.Columns["colELDisplayOrder"].Visible = true;
            
            //if (chkIncludeCategoryDetails.Checked)
                dgvEntity.DataSource = bslayer.GetAllEntities(SelectedMenuIID);
            //else
            //    dgvEntity.DataSource = bslayer.GetDataTable("SELECT IID, EntityName FROM Entity WHERE ParentMenuIID = '" + SelectedMenuIID + "' Order By DisplayOrder");

            //If there is entity so enable entity buttons
            //barEntityButton.Enabled = barStockUsage.Enabled = dgvSearchResults.Enabled = dgvEntity.SelectedRows.Count > 0;




        }
        private void UnloadEntityList() {
            dgvEntity.DataSource = null;
            UnloadEntityButtons();

        }
        private void DgvEntity_SelectionChanged(object sender, EventArgs e) {
            if (dgvEntity.SelectedRows.Count > 0) {
                try {
                    string entityIID = dgvEntity.SelectedRows[0].Cells["colEntityIID"].Value.ToString();
                    LoadEntityButtons(entityIID);
                    DisplayEntityButton();

                } catch {
                    pnlEntitySample.Height = 0;

                }
            }
        }
        private async void DisplayEntityButton() {
            if (dgvEntity.SelectedRows.Count > 0) {
                Category entity = await bslayer.GetEntity(dgvEntity.SelectedRows[0].Cells["colEntityIID"].Value.ToString());
                pnlEntitySample.Height = entity.Height;
                btnEntitySample.Height = entity.Height;
                btnEntitySample.Width = entity.Width;
                btnEntitySample.Text = entity.CategoryName;
                btnEntitySample.Font = new Font(entity.FFamily, (float)entity.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), entity.FStyle));
                btnEntitySample.BackColor = Color.FromArgb(entity.BgColour);
                btnEntitySample.ForeColor = Color.FromArgb(entity.FgColour);

            }
        }

        private void BtnAddEntity_Click(object sender, EventArgs e) {               
            using (frmEntityEditor frm = ActivatorUtilities.CreateInstance <frmEntityEditor>(ServiceHelper.Services, new Category() { MenuIID = SelectedMenuIID})) {
                if (frm.ShowDialog() == DialogResult.OK) {
                    LoadEntityList();
                }
            }
        }

        private async void BtnEditEntity_Click(object sender, EventArgs e) {
            try {
                using (frmEntityEditor frm = ActivatorUtilities.CreateInstance < frmEntityEditor>(ServiceHelper.Services,await GetEntity())) {
                    if (frm.ShowDialog() == DialogResult.OK) {
                        LoadEntityList();
                    }
                }
            } catch { }
        }

        private async void BtnDeleteEntity_Click(object sender, EventArgs e) {
            if (dgvEntity.SelectedRows.Count > 0) {
                if (MessageBox.Show("This will delete the entity and all the associated buttons.\nDo you want to continue?", "Delete Entity", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                    Category entity =await GetEntity();
                    await bslayer.DeleteEntityDB(entity.IID);
                    LoadEntityList();
                }
            }

        }
        private void DgvEntity_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            BtnEditEntity_Click(null, null);
        }
        private async Task<Category> GetEntity() {
            try {
                string entityIID = dgvEntity.SelectedRows[0].Cells["colEntityIID"].Value.ToString();
                Category entity =await bslayer.GetEntity(entityIID);
                return entity;
            } catch { }

            return null;
        }
        //private void DgvEntity_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
        //    //if (chkIncludeCategoryDetails.Checked) {
        //    //    if (e.RowIndex >= 0) {
        //    //        switch (e.ColumnIndex) {
        //    //            case 3: //Button Colour
        //    //                try {
        //    //                    e.CellStyle.BackColor = Color.FromArgb(int.Parse(dgvEntity.Rows[e.RowIndex].Cells["PanelColor"].Value.ToString()));
        //    //                    e.CellStyle.ForeColor = Color.FromArgb(int.Parse(dgvEntity.Rows[e.RowIndex].Cells["FStyle"].Value.ToString()));
        //    //                } catch { }
        //    //                break;
        //    //            default:
        //    //                break;

        //    //        }
        //    //    }
        //    //}
        //}
        #endregion


        #region ENTITY BUTTON FUNCTIONS
        private void LoadEntityButtons(string EntityIID) {
            dgvEntityButton.Columns["colEBWidth"].Visible =
                 dgvEntityButton.Columns["colEBHeight"].Visible =
                   dgvEntityButton.Columns["colEBFont"].Visible =
                     dgvEntityButton.Columns["colEBDistributionName"].Visible =
                        dgvEntityButton.Columns["colEBDirectSalePrice"].Visible =
                         dgvEntityButton.Columns["colEBInHousePrice"].Visible =
                          dgvEntityButton.Columns["colEBTakeAwayPrice"].Visible =
                           dgvEntityButton.Columns["colEBDeliveryPrice"].Visible =
                            dgvEntityButton.Columns["colEBDirectSaleTaxPercent"].Visible =
                             dgvEntityButton.Columns["colEBInHouseTaxPercent"].Visible =
                              dgvEntityButton.Columns["colEBTakeAwayTaxPercent"].Visible =
                              dgvEntityButton.Columns["colEBDeliveryTaxPercent"].Visible =
                              dgvEntityButton.Columns["colEBDisplayOrder"].Visible = chkIncludeCategoryItemDetails.Checked;


            if (chkIncludeCategoryItemDetails.Checked) {

                ((DataGridViewImageColumn)dgvEntityButton.Columns[columnName: "colEBDisplayImage"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                ((DataGridViewImageColumn)dgvEntityButton.Columns[columnName: "colEBDisplayImage"]).DefaultCellStyle.NullValue = null;
                ((DataGridViewImageColumn)dgvEntityButton.Columns[columnName: "colEBDisplayImage"]).Visible = true;
                dgvEntityButton.DataSource = bslayer.GetEntityButtonsForEntityDBWithImage(EntityIID);
            } else {
                ((DataGridViewImageColumn)dgvEntityButton.Columns[columnName: "colEBDisplayImage"]).Visible = false;
                dgvEntityButton.DataSource = bslayer.GetDataTable("SELECT EntityButton.IID, EntityButtonName FROM EntityButton LEFT OUTER JOIN Distribution ON EntityButton.DistributionIID = Distribution.IID " +
                         " WHERE ParentEntityIID = '" + EntityIID + "'  Order By EntityButton.DisplayOrder");
            }


        }
        private void UnloadEntityButtons() {
            dgvEntityButton.DataSource = null;
            barEntityButton.Enabled = barStockUsage.Enabled = dgvSearchResults.Enabled = dgvEntity.SelectedRows.Count > 0;
        }

        private async void BtnAddEntityButton_Click(object sender, EventArgs e) {
            CategoryItem ebNew = null;
            if (dgvEntityButton.Rows.Count > 0) {
                CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.Rows[0].Cells["colEntityButtonIID"].Value.ToString());
                ebNew = eb.Duplicate();
                ebNew.ItemName = "";
                ebNew.SalePrice = 0;
                ebNew.SitinPrice = 0;
                ebNew.TaPrice = 0;
                ebNew.DPrice = 0;

            }


            try {
                Category entity =await GetEntity();

                if (ebNew == null) {
                    ebNew = new CategoryItem {
                        ItemName = "New Button",
                        CategoryIID = entity.IID
                    };
                }

                using (FrmEntityButtonsEditor frm = ActivatorUtilities.CreateInstance < FrmEntityButtonsEditor>(ServiceHelper.Services, entity, ebNew)) {

                    if (frm.ShowDialog() == DialogResult.OK) {
                        LoadEntityButtons(entity.IID);
                    }
                }
            } catch { }

        }

        private async void BtnEditEntityButton_Click(object sender, EventArgs e) {
            try {


                string entityButtonIID = dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();

                CategoryItem entityButton =await bslayer.GetJustEntityButton(entityButtonIID);
                using (FrmEntityButtonsEditor frm = ActivatorUtilities.CreateInstance < FrmEntityButtonsEditor>(ServiceHelper.Services, entityButton)) {

                    if (frm.ShowDialog() == DialogResult.OK) {
                        int row = dgvEntityButton.SelectedRows[0].Index;
                        int disprow = dgvEntityButton.FirstDisplayedScrollingRowIndex;

                        LoadEntityButtons(entityButton.CategoryIID);

                        dgvEntityButton.CurrentCell = dgvEntityButton.Rows[row].Cells[3];
                        dgvEntityButton.Rows[row].Selected = true;
                        dgvEntityButton.FirstDisplayedScrollingRowIndex = disprow;
                    }
                }
            } catch { }
        }

        private async void BtnDeleteEntityButton_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                if (MessageBox.Show("This will Delete all sub entity buttons of this button.\nDo you want to continue?",
                    "Delete Entity Button", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                    CategoryItem entityButton =await GetEntityButton();
                    bslayer.DeleteEntityButtonDB(entityButton.IID);
                    LoadEntityButtons(GetEntity().Result.IID);
                }
            }
        }
        private void DgvEntityButton_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            BtnEditEntityButton_Click(null, null);
        }
        private async Task<CategoryItem> GetEntityButton() {
            try {
                string entityButtonIID = dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
                return await bslayer.GetJustEntityButton(entityButtonIID);
            } catch {
                return null;
            }
        }
       
        #endregion


        private async void BtnEBFontTo_Click(object sender, EventArgs e) {
            using (FontDialog fd = new FontDialog()) {
                fd.Font = new Font("Arial", 10, FontStyle.Bold);
                if (fd.ShowDialog() == DialogResult.OK) {
                    for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                        CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                        eb.FFamily = fd.Font.FontFamily.Name;
                        eb.FSize = fd.Font.Size;
                        eb.FStyle = fd.Font.Style.ToString();
                        await bslayer.SaveJustEntityButton(eb);
                    }
                    DgvEntity_SelectionChanged(null, null);
                }
            }
        }


        private async void BtnEBWidthTo_Click(object sender, EventArgs e) {
            using (frmInputForm frm = new frmInputForm("100")) {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    int val = 0;
                    if (int.TryParse(frm.InputValue, out val)) {
                        for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                            CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                            eb.Width = val;
                            await bslayer.SaveJustEntityButton(eb);
                        }
                        DgvEntity_SelectionChanged(null, null);
                    }
                }
            }
        }

        private async void BtnEBHeightTo_Click(object sender, EventArgs e) {
            using (frmInputForm frm = new frmInputForm("100")) {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    int val = 0;
                    if (int.TryParse(frm.InputValue, out val)) {
                        for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                            CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                            eb.Height = val;
                            await bslayer.SaveJustEntityButton(eb);
                        }
                        DgvEntity_SelectionChanged(null, null);
                    }
                }
            }
        }

        private async void BtnEBPriceTo_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                CategoryItem firsteb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString());
                using (frmInputForm frm = new frmInputForm(firsteb.SalePrice.ToString())) {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                        float val = 0;
                        if (float.TryParse(frm.InputValue, out val)) {
                            for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                                CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                                eb.SalePrice = val;
                                eb.SitinPrice = val;
                                eb.TaPrice = val;
                                eb.DPrice = val;
                                await bslayer.SaveJustEntityButton(eb);
                            }
                            DgvEntity_SelectionChanged(null, null);
                        }
                    }
                }
            }
        }

        private async void BtnEBTaxRateTo_Click(object sender, EventArgs e) {
            using (frmInputForm frm = new frmInputForm("100")) {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    float val = 0;
                    if (float.TryParse(frm.InputValue, out val)) {
                        for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                            CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                            eb.SaleTax = val;
                            eb.SitinTax = val;
                            eb.TaTax = val;
                            eb.DTax = val;
                            await bslayer.SaveJustEntityButton(eb);
                        }
                        DgvEntity_SelectionChanged(null, null);
                    }
                }
            }
        }

        private async void BtnMoveToEntity_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                using (frmEntitySelector frm = new frmEntitySelector(bslayer, dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString())) {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                        string menuiid = dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString();
                        for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                            // EntityButton entityButton = GetEntityButton();
                            string ebiid = dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString();
                            CategoryItem entityButton = await bslayer.GetJustEntityButton(ebiid);
                            entityButton.CategoryIID = frm.SelectedEntiyIID;
                            await bslayer.SaveJustEntityButton(entityButton);
                        }
                        DgvEntity_SelectionChanged(null, null);
                    }
                }
            }
        }

        private void BtnReOrder_Click(object sender, EventArgs e) {
            ReOrderEntityButtons();
        }
        private async void ReOrderEntityButtons() {
            for (int i = 0; i < dgvEntityButton.Rows.Count; i++) {
                CategoryItem eb = await bslayer.GetJustEntityButton(dgvEntityButton.Rows[i].Cells["colEntityButtonIID"].Value.ToString());
                eb.DOrder = i;
                await bslayer.SaveJustEntityButton(eb);
            }
            DgvEntity_SelectionChanged(null, null);
        }

        private void ReOrderEntityList() {
            for (int i = 0; i < dgvEntity.Rows.Count; i++) {
                string entityIID = dgvEntity.Rows[i].Cells["colEntityIID"].Value.ToString();
                bslayer.SetEntityDisplayOrder(entityIID, i);
            }
            LoadEntityList();
        }

        private async void BtnDuplicate_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                bool blnDuplicateStockItems = (MessageBox.Show("Do you want to duplicate stock items as well?",
                    "DUPLICATE STOCK ITEMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes);
                for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {

                    CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                    CategoryItem eb2 = eb.Duplicate();

                    eb2.ItemName = "";
                    if (await bslayer.SaveJustEntityButton(eb2)) {
                        if (blnDuplicateStockItems) {
                            List<EntityButtonStockItemLookUp> lookupList = await bslayer.GetStockItemsForEB(eb.IID);
                            foreach (var lookup in lookupList)
                            {
                                EntityButtonStockItemLookUp newlookup = lookup.Duplicate(eb2.IID);
                                await bslayer.SaveEntityButtonStockItemLookUp(newlookup);
                            }
                            //DataTable dt = bslayer.GetStockItemsForEB(eb.IID);
                            //for (int s = 0; s < dt.Rows.Count; s++) {
                            //    EntityButtonStockItemLookUp lookup = new EntityButtonStockItemLookUp(dt.Rows[s]) {
                            //        EntityButtonIID = eb2.IID
                            //    };
                                
                            //    bslayer.SaveEntityButtonStockItemLookUp(lookup.Duplicate(eb2.IID));
                            //}
                        }
                    }
                }
                ReOrderEntityButtons();
            }
        }

       

        private async void LoadStockItems() {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                string selEBIID = dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
                CategoryItem eb = await bslayer.GetJustEntityButton(selEBIID);

                try {
                    btnEBSample.Font = new Font(eb.FFamily, (float)eb.FSize, (FontStyle)Enum.Parse(typeof(FontStyle), eb.FStyle));
                    pnlEBPicture.Width = eb.Width;
                    btnEBSample.Height = eb.Height;
                    btnEBSample.BackColor = Color.FromArgb(eb.BgColor);
                    btnEBSample.ForeColor = Color.FromArgb(eb.FgColor);
                    btnEBSample.Text = eb.ItemName;
                } catch {
                }

                GenericImage gim = await bslayer.GetGenericImage(selEBIID);
                if (gim == null)
                    pboxEBPicture.Image = null;
                else {
                    if (eb.WithImage)
                        pboxEBPicture.Image = null;
                    else {
                        pboxEBPicture.Image =UFWin.ByteArrayToImage( gim.DisplayImage);
                        lblImageSize.Text = gim.ImageSizeinKB.ToString() + " KB";
                        // float sz = gim.GetImageSize();
                    }
                }
                if (eb.WithImage) {

                    if (gim != null && gim.DisplayImage != null) {
                        btnEBSample.Image = UFWin.ByteArrayToImage( gim.DisplayImage);
                        btnEBSample.ImageAlign = ContentAlignment.TopCenter;
                        btnEBSample.TextAlign = ContentAlignment.BottomCenter;
                    }
                } else {
                    btnEBSample.TextAlign = ContentAlignment.MiddleCenter;
                    btnEBSample.Image = null;
                }

               //   DataTable dt = POSLayer.Library.UF.StringifyEnumInDataTable(await bslayer.GetStockItemsForEB(selEBIID), "QuantityType", "QuantityTypeAsString", typeof(POSLayer.Library.QuantityTypes));
                dgvStockItems.DataSource = await bslayer.GetStockItemsForEB(selEBIID);
            }
        }

        private async void BtnAddStockItem_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                using (frmEntityButtonStockItemLookUp frm = new frmEntityButtonStockItemLookUp(bslayer,await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString()))) {
                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadStockItems();
                }
            }
        }

        private async void BtnEditStockItem_Click(object sender, EventArgs e) {
            if (dgvStockItems.SelectedRows.Count > 0) {
                string IID = dgvStockItems.SelectedRows[0].Cells["colStockUsageIID"].Value.ToString();

                using (frmEntityButtonStockItemLookUp frm = new frmEntityButtonStockItemLookUp(bslayer,await bslayer.GetEntityButtonStockItemLookUp(IID))) {
                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadStockItems();
                }
            }
        }

        private async void BtnDeleteStockItem_Click(object sender, EventArgs e) {
            if (dgvStockItems.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvStockItems.SelectedRows.Count; i++) {
                    string IID = dgvStockItems.SelectedRows[0].Cells["colStockUsageIID"].Value.ToString();
                    await bslayer.DeleteEntityButtonStockItemLookUp(IID);
                }
                LoadStockItems();
            }
        }
        private void BtnZoomStockUsage_Click(object sender, EventArgs e) {
             UFWin.ChangeDataGridViewZoom(dgvStockItems);
        }
        private void BtnReorderStockUsage_Click(object sender, EventArgs e) {
            if (dgvStockItems.Rows.Count > 0) {
                for (int i = 0; i < dgvStockItems.Rows.Count; i++) {
                    string IID = dgvStockItems.Rows[i].Cells["colStockUsageIID"].Value.ToString();
                    bslayer.RunQuery("Update EntityButtonStockItemLookUp set DisplayOrder = " + i + " where IID = '" + IID + "'");
                }
                LoadStockItems();
            }
        }




        private void BtnCopyStockUsageItems_Click(object sender, EventArgs e) {
            //if (dgvEntityButton.SelectedRows.Count < 1)
            //    return;
            //                //Copy selected items if any
            //    string sourceEBIID = dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
            //    if (dgvStockItems.SelectedRows.Count > 0) {
            //        List<EntityButtonStockItemLookUp> theList = new List<EntityButtonStockItemLookUp>();
            //        for (int i = 0; i < dgvStockItems.SelectedRows.Count; i++) {
            //            string StockItemIID = dgvStockItems.SelectedRows[i].Cells[1].Value.ToString();
            //            theList.Add(bslayer.GetEntityButtonStockItemLookUp(sourceEBIID, StockItemIID));
            //        }
            //        btnCopyStockUsageItems.Tag = theList;
            //        btnCopyStockUsageItems.Image = Properties.Resources.Paste32;                    
            //    }

        }

        private void PasteStockUsageItems(bool blnKeep) {
            //if (dgvEntityButton.SelectedRows.Count < 1)
            //    return;

            ////Paste selected items if any
            //string destinationEBIID = dgvEntityButton.SelectedRows[0].Cells["colEntityButtonIID"].Value.ToString();
            //if (btnCopyStockUsageItems.Tag != null) {
            //    List<EntityButtonStockItemLookUp> theList =
            //        (List<EntityButtonStockItemLookUp>)btnCopyStockUsageItems.Tag;
            //    for (int i = 0; i < theList.Count; i++) {
            //        EntityButtonStockItemLookUp item = theList[i];
            //        item.EntityButtonIID = destinationEBIID;
            //        bslayer.SaveEntityButtonStockItemLookUp(item);
            //    }

            //    if (!blnKeep) {
            //        btnCopyStockUsageItems.Tag = null;
            //        btnCopyStockUsageItems.Image = Properties.Resources.WindowCascade;
            //    }
            //    LoadStockItems();
            //}
        }

        private void BtnPasteStockUsageItems_Click(object sender, EventArgs e) {
            //PasteStockUsageItems(false);
        }
        private void BtnPasteSpecialStockUsageItems_Click(object sender, EventArgs e) {
            //PasteStockUsageItems(true);
        }

        private void DgvEntityButton_SelectionChanged(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0)
                LoadStockItems();
        }

        private void DgvStockItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            BtnEditStockItem_Click(null, null);
        }

        private async void BtnConvertToStockItem_Click(object sender, EventArgs e) {
            if (dgvEntityButton.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                    CategoryItem eb = await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                    StockItem si = new StockItem()
                    {
                        StockName = eb.ItemName
                    };
                    bslayer.SaveStockItem(si);
                }

            }
        }

        private void FrmMenuEditor_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F3)
                BtnAddStockItem_Click(null, null);
        }

        private async void BtnExportStockManager_Click(object sender, EventArgs e) {
            if (dgvMenu.SelectedRows.Count > 0) {
                StockManager sm = await bslayer.GetStockManager();
                sm.Reference = "Stock Manager for " + " Bunu duzeltmek lazim " + DateTime.Now.ToString("dd MM yyyy");
                using (SaveFileDialog sfd = new SaveFileDialog()) {
                    sfd.Filter = "DTRM files (*.xml)|";
                    sfd.FileName = sm.Reference;
                    sfd.ShowDialog();
                    if (sfd.FileName != null && sfd.FileName != "") {
                        if (DRFile.XmlSerialize(sfd.FileName + ".xml", sm, typeof(StockManager), false))
                            MessageBox.Show("Menu Stock Manager saved");
                        else
                            MessageBox.Show("Menu Stock Manager cannot be saved");
                    }
                }
            }
        }

        private async void BtnImportStockManager_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.ShowDialog();
                if (ofd.FileName != "") {
                    StockManager sm;
                    try {
                        sm = (StockManager)DRFile.XmlDeSerialize(ofd.FileName, typeof(StockManager), false);
                    } catch (Exception ex) {
                        MessageBox.Show("Menu Stock Manager cannot be imported =" + ex.Message);
                        return;
                    }

                    if (await bslayer.SaveStockManager(sm))
                        LoadMenuList();
                }
            }
        }

        private async void BtnSaveDBImagesToFolder_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog()) {
                dlg.ShowNewFolderButton = true;
                if (dlg.ShowDialog() == DialogResult.OK) {
                    DirectoryInfo dinfo = new DirectoryInfo(dlg.SelectedPath);
                    if (await bslayer.ExportDatabaseImagesIntoFolder(dinfo.FullName))
                        MessageBox.Show("Completed");
                    else
                        MessageBox.Show("Completed with Errors");
                }
            }
        }

        private async void BtnSetUpperCase_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                CategoryItem eb = await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                eb.ItemName = eb.ItemName.ToUpper();
                bslayer.SaveJustEntityButton(eb);
            }
            DgvEntity_SelectionChanged(null, null);

        }

        private async void BtnSetSentenceCase_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                eb.ItemName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(eb.ItemName);
                bslayer.SaveJustEntityButton(eb);
            }
            DgvEntity_SelectionChanged(null, null);

        }


        private async void BtnSetToLowerCase_Click(object sender, EventArgs e) {
            for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                CategoryItem eb = await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                eb.ItemName = eb.ItemName.ToLower();
                await bslayer.SaveJustEntityButton(eb);
            }
            DgvEntity_SelectionChanged(null, null);
        }

        private async void BtnSetAllForeColourTo_Click(object sender, EventArgs e) {
            using (ColorDialog cdlg = new ColorDialog()) {
                if (cdlg.ShowDialog() == DialogResult.OK) {
                    int selectedColor = cdlg.Color.ToArgb();

                    for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                        CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                        eb.FgColor = selectedColor;
                       await bslayer.SaveJustEntityButton(eb);
                    }
                    DgvEntity_SelectionChanged(null, null);
                }
            }
        }

        private async void BtnSetAllBackColourTo_Click(object sender, EventArgs e) {
            using (ColorDialog cdlg = new ColorDialog()) {
                if (cdlg.ShowDialog() == DialogResult.OK) {
                    int selectedColor = cdlg.Color.ToArgb();

                    for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                        CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                        eb.BgColor = selectedColor;
                       await bslayer.SaveJustEntityButton(eb);
                    }
                    DgvEntity_SelectionChanged(null, null);
                }
            }
        }

        private async void BtnSetAllBackColourToTransparent_Click(object sender, EventArgs e) {
            int selectedColor = Color.Transparent.ToArgb();

            for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                CategoryItem eb =await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                eb.BgColor = selectedColor;
               await bslayer.SaveJustEntityButton(eb);
            }
            DgvEntity_SelectionChanged(null, null);
        }

        private async void BtnChangeDistributionForEB_Click(object sender, EventArgs e) {
            using (frmDistributionSelector frm = ActivatorUtilities.CreateInstance < frmDistributionSelector>(ServiceHelper.Services, false, null)) {
                if (frm.ShowDialog() == DialogResult.OK) {
                    List<Distribution> theList = frm.selectedDistributions;
                    if (theList.Count > 0) {
                        for (int i = 0; i < dgvEntityButton.SelectedRows.Count; i++) {
                            CategoryItem eb = await bslayer.GetJustEntityButton(dgvEntityButton.SelectedRows[i].Cells["colEntityButtonIID"].Value.ToString());
                            eb.DistributionIID = theList[0].IID;
                            await bslayer.SaveJustEntityButton(eb);
                        }
                        DgvEntity_SelectionChanged(null, null);
                    }
                }
            }
        }

        private void BtnZoomEntity_Click(object sender, EventArgs e) {
            POSWinFormLayer.UFWin.ChangeDataGridViewZoom(dgvEntity);
        }

        private void BtnZoomEntityButton_Click(object sender, EventArgs e) {
            POSWinFormLayer.UFWin.ChangeDataGridViewZoom(dgvEntityButton);
        }



        private void BtnZoomMenu_Click(object sender, EventArgs e) {
            POSWinFormLayer.UFWin.ChangeDataGridViewZoom(dgvMenu);
        }

        private void buttonItem1_Click(object sender, EventArgs e) {
            //DataTable dt = bslayer.GetDataTable("select EntityButtonIID from EntityButtonStockItemLookUp group by EntityButtonIID order by EntityButtonIID");
            //List<string> ebIIDList = new List<string>();
            //for (int i=0; i < dt.Rows.Count; i++) {
            //    ebIIDList.Add(dt.Rows[i][0].ToString());
            //}
            //for (int i = 0; i < ebIIDList.Count; i++) {
            //    string ebIID = ebIIDList[i];
            //    DataTable dtsitable = bslayer.GetDataTable("Select StockItemIID from EntityButtonStockItemLookUp where EntityButtonIID ='" + ebIID + "' order by DisplayOrder");

            //    for (int s = 0; s < dtsitable.Rows.Count; s++) {
            //        string stockItemIID = dtsitable.Rows[s][0].ToString();
            //        bslayer.RunQuery("Update EntityButtonStockItemLookUp set DisplayOrder=" + s + " where EntityButtonIID ='" + ebIID + "' and StockItemIID ='" + stockItemIID + "'");
            //    }

            //    //string str = "";
            //}

            // LoadMenuList();
        }

        private DataGridView dgvSource;
        private Rectangle dragBox;
        private int rowIndexSource;
        private int rowIndexDestination;

        private void Dgv_MouseMove(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBox != Rectangle.Empty && !dragBox.Contains(e.X, e.Y)) {
                    // Proceed with the drag and drop, passing in the list item.                    
                    //  DragDropEffects dropEffect =
                    ((DataGridView)sender).DoDragDrop(((DataGridView)sender).Rows[rowIndexSource], DragDropEffects.Move);
                }
            }
        }

        private void Dgv_MouseDown(object sender, MouseEventArgs e) {
            // Get the index of the item the mouse is below.
            rowIndexSource = ((DataGridView)sender).HitTest(e.X, e.Y).RowIndex;
            if (rowIndexSource != -1) {
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

        private void Dgv_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
            if (dgvSource != (DataGridView)sender)
                e.Effect = DragDropEffects.None;
        }

        private void DgvStockItems_DragDrop(object sender, DragEventArgs e) {
            if (dgvSource != (DataGridView)sender)
                return;

            // The mouse locations are relative to the screen, so they must be converted to client coordinates.
            Point clientPoint = ((DataGridView)sender).PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexDestination = ((DataGridView)sender).HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move) {
                //DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                //MessageBox.Show("From : " + rowIndexSource + ",  To : " + rowIndexDestination);
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
                bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[bdon].Cells["colStockUsageIID"].Value.ToString(), don);


                if (bdon < don) {
                    //Moving downwards
                    blnArdisik = bdon + 1 == don;

                    if (blnArdisik) {
                        //Just swap
                        bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[don].Cells["colStockUsageIID"].Value.ToString(), bdon);

                    } else {
                        bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[don].Cells["colStockUsageIID"].Value.ToString(), don - 1);
                        //arayi doldur
                        for (int i = bdon + 1; i < don; i++)
                            bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[i].Cells["colStockUsageIID"].Value.ToString(), i - 1);
                    }
                } else {
                    //Moving upwards
                    blnArdisik = don + 1 == bdon;

                    if (blnArdisik) {
                        //Just swap
                        bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[don].Cells["colStockUsageIID"].Value.ToString(), bdon);
                    } else {
                        bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[don].Cells["colStockUsageIID"].Value.ToString(), don + 1);
                        //arayi doldur
                        for (int i = don + 1; i < bdon; i++)
                            bslayer.UpdateStockItemLookUpDisplayOrder(dgvStockItems.Rows[i].Cells["colStockUsageIID"].Value.ToString(), i + 1);
                    }
                }

                LoadStockItems();                
            }
        }
        private void DgvEntityButton_DragDrop(object sender, DragEventArgs e) {
            if (dgvSource != (DataGridView)sender)
                return;

            // The mouse locations are relative to the screen, so they must be converted to client coordinates.
            Point clientPoint = ((DataGridView)sender).PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexDestination = ((DataGridView)sender).HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move) {
                //DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                //MessageBox.Show("From : " + rowIndexSource + ",  To : " + rowIndexDestination);
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
                bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[bdon].Cells["colEntityButtonIID"].Value.ToString(), don);


                if (bdon < don) {
                    //Moving downwards
                    blnArdisik = bdon + 1 == don;

                    if (blnArdisik) {
                        //Just swap
                        bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[don].Cells["colEntityButtonIID"].Value.ToString(), bdon);

                    } else {
                        bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[don].Cells["colEntityButtonIID"].Value.ToString(), don - 1);
                        //arayi doldur
                        for (int i = bdon + 1; i < don; i++)
                            bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[i].Cells["colEntityButtonIID"].Value.ToString(), i - 1);
                    }
                } else {
                    //Moving upwards
                    blnArdisik = don + 1 == bdon;

                    if (blnArdisik) {
                        //Just swap
                        bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[don].Cells["colEntityButtonIID"].Value.ToString(), bdon);
                    } else {
                        bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[don].Cells["colEntityButtonIID"].Value.ToString(), don + 1);
                        //arayi doldur
                        for (int i = don + 1; i < bdon; i++)
                            bslayer.SetEntityButtonDisplayOrder(dgvEntityButton.Rows[i].Cells["colEntityButtonIID"].Value.ToString(), i + 1);
                    }
                }
                string entityIID = dgvEntity.SelectedRows[0].Cells["colEntityIID"].Value.ToString();
                LoadEntityButtons(entityIID);
            }
        }

        private void DgvEntity_DragDrop(object sender, DragEventArgs e) {
            if (dgvSource != (DataGridView)sender)
                return;

            // The mouse locations are relative to the screen, so they must be converted to client coordinates.
            Point clientPoint = ((DataGridView)sender).PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexDestination = ((DataGridView)sender).HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move) {
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
                bslayer.SetEntityDisplayOrder(dgvEntity.Rows[bdon].Cells["colEntityIID"].Value.ToString(), don);


                if (bdon < don) {
                    //Moving downwards
                    blnArdisik = bdon + 1 == don;                    

                    if (blnArdisik) {
                        //Just swap
                        bslayer.SetEntityDisplayOrder(dgvEntity.Rows[don].Cells["colEntityIID"].Value.ToString(), bdon);


                    } else {
                        bslayer.SetEntityDisplayOrder(dgvEntity.Rows[don].Cells["colEntityIID"].Value.ToString(), don-1);
                        //arayi doldur
                        for (int i=bdon+1; i <don; i++)
                            bslayer.SetEntityDisplayOrder(dgvEntity.Rows[i].Cells["colEntityIID"].Value.ToString(), i-1);
                    }
                } else {
                    //Moving upwards
                    blnArdisik = don + 1 == bdon;
                    
                    if (blnArdisik) {
                        //Just swap
                        bslayer.SetEntityDisplayOrder(dgvEntity.Rows[don].Cells["colEntityIID"].Value.ToString(), bdon);                        
                    } else {
                        bslayer.SetEntityDisplayOrder(dgvEntity.Rows[don].Cells["colEntityIID"].Value.ToString(), don +1);
                        //arayi doldur
                        for (int i = don + 1; i < bdon; i++)
                            bslayer.SetEntityDisplayOrder(dgvEntity.Rows[i].Cells["colEntityIID"].Value.ToString(), i + 1);
                    }
                }

                LoadEntityList();
            }
        }

        



        private void BtnReOrderEntityList_Click(object sender, EventArgs e) {
            ReOrderEntityList();
        }

        private void BtnSearchCategoryButtons_Click(object sender, EventArgs e) {
            if (txtSearchCategoryButtons.Text.Trim().Length == 0)
                return;


            if (dgvMenu.Rows.Count > 0) {

                string MenuIID = dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString();

                ((DataGridViewImageColumn)dgvSearchResults.Columns[columnName: "colDisplayImageSearch"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                ((DataGridViewImageColumn)dgvSearchResults.Columns[columnName: "colDisplayImageSearch"]).DefaultCellStyle.NullValue = null;

                string menustring = chkAllMenuSearch.Checked ? "" : " and Entity.ParentMenuIID = '" + MenuIID + "' ";

                dgvSearchResults.DataSource = bslayer.GetDataTable("SELECT EntityButton.IID, EntityButton.EntityButtonName, Entity.EntityName, Images.DisplayImage " +
                                "FROM Images RIGHT OUTER JOIN EntityButton ON Images.ReferenceIID = dbo.EntityButton.IID LEFT OUTER JOIN " +
                                " Entity ON EntityButton.ParentEntityIID = Entity.IID WHERE(EntityButton.EntityButtonName LIKE '%" + txtSearchCategoryButtons.Text + "%') " +
                                menustring + " ORDER BY EntityButton.EntityButtonName ");

                lblSearchResults.Text = "(" + dgvSearchResults.Rows.Count.ToString() + ")";
            }
        }

        private async void DgvSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {


                string entityButtonIID = dgvSearchResults.SelectedRows[0].Cells["colIIDSearch"].Value.ToString();

                CategoryItem entityButton =await bslayer.GetJustEntityButton(entityButtonIID);

                using (FrmEntityButtonsEditor frm = ActivatorUtilities.CreateInstance < FrmEntityButtonsEditor>(ServiceHelper.Services, entityButton)) {
                    if (frm.ShowDialog() != DialogResult.OK) return;
                }

            } catch { }
        }

        private void TxtSearchCategoryButtons_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && txtSearchCategoryButtons.Text.Trim().Length > 0) {
                BtnSearchCategoryButtons_Click(null, null);
            }
        }

        private void DgvSearchResults_SelectionChanged(object sender, EventArgs e) {
            try {
                if (dgvSearchResults.Rows.Count > 0) {
                    if (dgvSearchResults.SelectedRows[0].Cells[columnName: "colDisplayImageSearch"].Value is byte[]) {

                        using (var ms = new MemoryStream((byte[])dgvSearchResults.SelectedRows[0].Cells[columnName: "colDisplayImageSearch"].Value)) {
                            pBoxSearchItem.Image = Image.FromStream(ms);
                        }
                    } else
                        pBoxSearchItem.Image = null;
                }
            } catch { }
        }

        private void BtnLoadMenuList_Click(object sender, EventArgs e) {
            LoadMenuList();
        }

        private void ChkAllMenuSearch_Click(object sender, EventArgs e) {
            BtnSearchCategoryButtons_Click(null, null);
        }

        private void chkIncludeCategoryItemDetails_CheckedChanged(object sender, EventArgs e) {
            chkIncludeCategoryItemDetails.Image = chkIncludeCategoryItemDetails.Checked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
            DgvEntity_SelectionChanged(null, null);
        }

        private void chkAllMenuSearch_CheckedChanged(object sender, EventArgs e) {
            chkAllMenuSearch.Image = chkAllMenuSearch.Checked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
            BtnSearchCategoryButtons_Click(null, null);
        }

        private void chkIncludeCategoryDetails_CheckedChanged(object sender, EventArgs e) {
            chkIncludeCategoryDetails.Image = chkIncludeCategoryDetails.Checked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
            try {
                DgvMenu_SelectionChanged(null, null);
            }
            catch { }
        }

        private void btnEntityButtonRowHeight_Click(object sender, EventArgs e) {
            int rowheight = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            dgvEntityButton.RowTemplate.Height = rowheight;
            DgvEntity_SelectionChanged(null, null);
        }

        private void chkShowHideEntityPreview_CheckedChanged(object sender, EventArgs e) {
            chkShowHideEntityPreview.Image = chkShowHideEntityPreview.Checked ? Properties.Resources.Checked : Properties.Resources.Unchecked;
            pnlEntitySample.Visible = chkShowHideEntityPreview.Checked;
        }

        private void pboxEBPicture_DoubleClick(object sender, EventArgs e) {
            if (pboxEBPicture.Image != null) {
                frmImageDialog frm = new frmImageDialog(pboxEBPicture.Image);
                frm.ShowDialog();
            }
        }

        private void btnCreateDummyMenu_Click(object sender, EventArgs e) {
            bslayer.CreateDemoMenu("Dummy Menu");
            LoadMenuList();
        }

        private void mnuSetAsDefaultMenu_Click(object sender, EventArgs e) {
            if (SelectedMenuIID != null && SelectedMenuIID != "") {
                config.ActiveMenuIID = SelectedMenuIID;
                UF.SaveConfig(config);
                bslayer.GetActiveMenu(true, true);
                LoadMenuList();
            }
        }

        private async void btnQuantityToComment_Click(object sender, EventArgs e) {
            if (dgvStockItems.SelectedRows.Count > 0) {
                for (int i = 0; i < dgvStockItems.SelectedRows.Count; i++) {
                    string IID = dgvStockItems.SelectedRows[i].Cells["colStockUsageIID"].Value.ToString();

                    EntityButtonStockItemLookUp item =await bslayer.GetEntityButtonStockItemLookUp(IID);
                    item.Comment = item.Quantity + " " + item.QuantityType + item.Comment;

                   await bslayer.SaveEntityButtonStockItemLookUp(item);
                    
                }
                LoadStockItems();
            }
        }

        private async void btnExportMenuAsJson_Click(object sender, EventArgs e)
        {

            if (dgvMenu.SelectedRows.Count > 0)
            {
                TheMenu menu =await bslayer.GetMenuDB(dgvMenu.SelectedRows[0].Cells["colMenuIID"].Value.ToString());
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "JSON Files (*.json)|";
                    sfd.FileName = menu.MenuName + ".json";
                    sfd.ShowDialog();

                    if (sfd.FileName != null && sfd.FileName != "")
                    {
                        var jsonString = JsonConvert.SerializeObject(menu, Formatting.Indented);
                        if (POSLayer.Library.UF.SaveTextFile(sfd.FileName, jsonString))
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
                        string content = POSLayer.Library.UF.GetTextFile(sfd.FileName);
                        if (!string.IsNullOrEmpty(content))
                        {
                            TheMenu fm = JsonConvert.DeserializeObject<TheMenu>(content);
                            await bslayer.SaveMenuDB(fm);

                            MessageBox.Show("Saved Printer List");
                        } else
                        {
                            MessageBox.Show("Failed to Get Printer List");
                        }
                        LoadMenuList();
                    }
                }
            }

        }
    }
}
