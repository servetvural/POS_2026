using POSLayer.Library;

namespace POSLayer.Models;

public partial class Recipe : BaseClass
{
    public string? StockItemIID { get; set; }
    public StockItem? StockItem { get; set; }
    public string? StockItemName => StockItem?.StockName;

    public string? CategoryItemIID { get; set; }
    public CategoryItem? CategoryItem { get; set; }
    public string? CategoryItemName => CategoryItem?.ItemName;

    public QuantityTypes QuantityType { get; set; }
    public Double Quantity { get; set; }
    public string? Comment { get; set; }
    public string? FreeItemText { get; set; }
    public string? RecipeText =>  FreeItemText + StockItem?.StockName;




    public Recipe Duplicate()
    {
          return new Recipe()
          {
              StockItemIID = StockItemIID,
              CategoryItemIID = CategoryItemIID,
              QuantityType = QuantityType,
              Quantity = Quantity,
              Comment = Comment,
              FreeItemText = FreeItemText ,
              DOrder =DOrder
          };
    }
}
