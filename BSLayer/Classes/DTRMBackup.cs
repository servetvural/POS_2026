using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTRMNS;

public class DTRMBackup
{
    public List<Menu> menus { get; set; } = new List<Menu>();
    public List<ApplicationPrinter> printers { get; set; } = new List<ApplicationPrinter>();
    public List<Employee> employees { get; set; } = new List<Employee>();
    public List<Supplier> suppliers { get; set; } = new List<Supplier>();
    public List<StockItem> stockItems { get; set; } = new List<StockItem>();
    public List<Bonus> bonuslist { get; set; } = new List<Bonus>();
    public List<EntityButtonStockItemLookUp> stockItemLookups { get; set; } = new List<EntityButtonStockItemLookUp>();

}
