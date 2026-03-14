
using POSLayer.Models;

namespace POSLayer.Library;

public class POSLayerBackup
{
    public List<FoodMenu> menus { get; set; } = new List<FoodMenu>();
    public List<ApplicationPrinter> printers { get; set; } = new List<ApplicationPrinter>();
    public List<Employee> employees { get; set; } = new List<Employee>();
    public List<Supplier> suppliers { get; set; } = new List<Supplier>();
    public List<StockItem> stockItems { get; set; } = new List<StockItem>();
    public List<Bonus> bonuslist { get; set; } = new List<Bonus>();
    public List<EntityButtonStockItemLookUp> stockItemLookups { get; set; } = new List<EntityButtonStockItemLookUp>();

}
