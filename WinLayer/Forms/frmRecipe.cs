using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer
{
    public partial class frmRecipe : Form
    {
        IRepository<RecipeItem> repoRecipe;
        IRepository<StockItem> repoStockItem;
        IRepository<CategoryItem> repoCategoryItem;

        public RecipeItem recipe;

        public frmRecipe()
        {
            InitializeComponent();
        }
        public frmRecipe(IRepository<RecipeItem> _repoRecipe, IRepository<StockItem> _repoStockItem,
            IRepository<CategoryItem> _repoCategoryItem, CategoryItem _categoryItem, int Order =100)
        {
            InitializeComponent();
            repoRecipe = _repoRecipe;
            repoStockItem = _repoStockItem;
            repoCategoryItem = _repoCategoryItem;

            recipe = new RecipeItem()
            {
                CategoryItem = _categoryItem,
                CategoryItemIID = _categoryItem.IID   ,
                DOrder = Order
            };
        }
        public frmRecipe(IRepository<RecipeItem> _repoRecipe, IRepository<StockItem> _repoStockItem,
           IRepository<CategoryItem> _repoCategoryItem, StockItem _stockItem, int Order = 100)
        {
            InitializeComponent();
            repoRecipe = _repoRecipe;
            repoStockItem = _repoStockItem;
            repoCategoryItem = _repoCategoryItem;

            recipe = new RecipeItem()
            {
                StockItem = _stockItem,
                StockItemIID = _stockItem.IID,
                DOrder = Order
            };
        }
        public frmRecipe(IRepository<RecipeItem> _repoRecipe, IRepository<StockItem> _repoStockItem,
            IRepository<CategoryItem> _repoCategoryItem,  RecipeItem _recipe, int Order = 100)
        {
            InitializeComponent();
            repoRecipe = _repoRecipe;
            repoStockItem = _repoStockItem;
            repoCategoryItem = _repoCategoryItem;

            recipe = _recipe;
            recipe.DOrder.ifZero(Order);
        }
        private async void frmEntityButtonStockItemLookUp_Load(object sender, EventArgs e)
        {
            cmbQuantityType.DataSource = Enum.GetValues(typeof(QuantityTypes));

            if (recipe == null || recipe.IID == null)
            {
                //new recipe being created
                
                if (recipe.CategoryItemIID != null && recipe.CategoryItem == null)
                {
                    recipe.CategoryItem = await repoCategoryItem.Get(recipe.CategoryItem.IID);
                }
                if (recipe.StockItemIID != null && recipe.StockItem == null)
                {
                    recipe.StockItem = await repoStockItem.Get(recipe.StockItem.IID);
                } 
            } else
            {
                //editing existing recipe
                recipe = await repoRecipe.Get(recipe.IID, "StockItem, CategoryItem");
            }

            await LoadRecipe();
        }

        private async Task LoadRecipe()
        {
            txtCategoryItem.Text = recipe.CategoryItem?.ItemName;
            txtStockItem.Text = recipe.StockItem?.StockName;
            txtFreeItemText.Text = recipe.FreeItemText;
            numQuantity.Value = recipe.Quantity;
            cmbQuantityType.SelectedItem = recipe.QuantityType;
            txtDisplayOrder.Value = recipe.DOrder;
            txtComment.Text = recipe.Comment;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (recipe.CategoryItemIID.IsNullOrEmpty())
            {
                MessageBox.Show("Category Item is required.");
                return;
            }

            if (recipe.StockItemIID.IsNullOrEmpty() && txtFreeItemText.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Stock Item or Free Item Text is required.");
                return;
            }

            recipe.FreeItemText = txtFreeItemText.Text;
            recipe.Quantity = (double)numQuantity.Value;
            recipe.QuantityType = recipe.StockItem != null ? recipe.StockItem.QuantityType : QuantityTypes.None;
            recipe.Comment = txtComment.Text;
            recipe.DOrder = txtDisplayOrder.Value;

            recipe.CategoryItem = null;
            recipe.StockItem = null;
            if (await repoRecipe.Save(recipe) != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private async void btnAddStockItem_Click(object sender, EventArgs e)
        {
            frmStockItemList frm = ActivatorUtilities.CreateInstance<frmStockItemList>(ServiceHelper.Services);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                recipe.StockItemIID = frm.selectedStockItem.IID;
                recipe.StockItem = frm.selectedStockItem;
                cmbQuantityType.SelectedItem = recipe.StockItem.QuantityType;
                recipe.QuantityType = recipe.StockItem.QuantityType;
                await LoadRecipe();
            }
        }
        private void btnDeleteStockItem_Click(object sender, EventArgs e)
        {
            recipe.StockItemIID = null;
            recipe.StockItem = null;
        }

        private void frmEntityButtonStockItemLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnAddStockItem_Click(null, null);
            }
        }

    }
}
