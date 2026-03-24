using POSLayer.Models;

namespace POSLayer.Library;

public class POSLayerBackup
{
    public List<TheMenu> menus { get; set; } = new List<TheMenu>();
    public List<Printer> printers { get; set; } = new List<Printer>();
    public List<Employee> employees { get; set; } = new List<Employee>();
    public List<Supplier> suppliers { get; set; } = new List<Supplier>();
    public List<StockItem> stockItems { get; set; } = new List<StockItem>();
    public List<Bonus> bonuslist { get; set; } = new List<Bonus>();
    public List<EntityButtonStockItemLookUp> stockItemLookups { get; set; } = new List<EntityButtonStockItemLookUp>();

}
