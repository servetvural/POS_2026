using System;
using System.Collections.Generic;
using System.Text;

using POSLayer.Models;

namespace POSLayer.Library;

public enum BackupNodeTypes
{
    UnknownNode,
    RootNode,
    HeaderNode,
    CustomerHeaderNode,
    CustomerNode,
    UserHeaderNode,
    UserNode,
    PrinterHeaderNode,
    ApplicationPrinterNode,
    LuvNode,
    SessionNode,
    TableHeaderNode,
    TableGroupNode,
    TableNode,
    MenuHeaderNode,
    MenuNode,
    EntityNode,
    EntityButtonNode,
    DistributionNode,
    StockManagerNode,
    SupplierNode,
    StockItemNode,
    OrderHeaderNode,
    OrderNode,
    OrderItemNode,
    XOrderHeaderNode,
    XOrderNode,
    XOrderItemNode,
    KOrderHeaderNode,
    KOrderNode,
    KOrderItemNode,
    DebugHeaderNode,
    DebugNode,
    ImageHeaderNode,
    ImageNode
}

public class DatabaseBackup
{
    //Customer List
    public List<Customer> customerList { get; set; }

    //User List
    public List<User> userList { get; set; }

    //Printer List
    public List<ApplicationPrinter> printerList { get; set; }

    //Global Settings
    public POSLayer.Models.Luv luv { get; set; }
    public SessionData currentSession { get; set; }

    //Table Layout
    public List<TableGroup> tableGroupList { get; set; }
    public List<Table> tableList { get; set; }

    public List<FoodMenu> menuList { get; set; }

    public StockManager stockManager { get; set; }                  


    public List<Order> orderList { get; set; }
    public List<XOrder> xorderList { get; set; }
    public List<KitchenOrder> kitchenOrderList { get; set; }
    public List<Debug> debugList { get; set; }


    public List<GenericImage> imageList { get; set; }


    /// <summary>
    /// There should be none of these items in the database
    /// =======================
    /// OrderItem
    /// Orders
    /// XOrderItem
    /// XOrders
    /// KitchenOrderItem
    /// KitchenOrders
    /// </summary>        
    public DatabaseBackup()
    {
        customerList = new List<Customer>();
        userList = new List<User>();
        printerList = new List<ApplicationPrinter>();
        tableGroupList = new List<TableGroup>();
        tableList = new List<Table>();
        menuList = new List<FoodMenu>();

        orderList = new List<Order>();
        xorderList = new List<XOrder>();
        kitchenOrderList = new List<KitchenOrder>();
        debugList = new List<Debug>();
        imageList = new List<GenericImage>();
    }
    public int ItemCount()
    {
        return customerList.Count + userList.Count + printerList.Count +
             tableGroupList.Count + tableList.Count + menuList.Count +
            stockManager.Suppliers.Count + stockManager.EBStockItemLookups.Count + stockManager.StockItems.Count +
            orderList.Count + xorderList.Count + kitchenOrderList.Count + debugList.Count + imageList.Count;
    }

}

public struct DatabaseBackupOptions
{
    public bool includeCustomers { get; set; }
    public bool includeUsers { get; set; }
    public bool includePrinters { get; set; }
    public bool includeTables { get; set; }
    public bool includeMenus { get; set; }
    public bool includeStock { get; set; }

    public bool includeLuv { get; set; }
    public bool includeCurrentSession { get; set; }
    public bool includeOrders { get; set; }
    public bool includeXOrders { get; set; }
    public bool includeKitchenOrders { get; set; }
    public bool includeDebugInformation { get; set; }
    public bool includeImages { get; set; }

    public DatabaseBackupOptions Reset()
    {
        includeCustomers = includeUsers = includePrinters = includeTables = includeMenus = includeStock =
            includeLuv = includeCurrentSession = includeOrders = includeXOrders =
            includeKitchenOrders = includeDebugInformation = includeImages = false;
        return this;
    }
    public void ResetAll()
    {
        includeCustomers = includeUsers = includePrinters = includeTables = includeMenus = includeStock =
            includeLuv = includeCurrentSession = includeOrders = includeXOrders =
            includeKitchenOrders = includeDebugInformation = includeImages = false;
    }
}