using System;
using System.Collections.Generic;

namespace DTRMNS {
    public enum BackupNodeTypes {
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

    public class DatabaseBackup {
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

        public List<Menu> menuList { get; set; }

        public StockManager stockManager { get; set; }


        public List<Order> orderList { get; set; }
        public List<Order> xorderList { get; set; }
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
        public DatabaseBackup() {
            customerList = new List<Customer>();
            userList = new List<User>();
            printerList = new List<ApplicationPrinter>();
            tableGroupList = new List<TableGroup>();
            tableList = new List<Table>();
            menuList = new List<Menu>();

            orderList = new List<Order>();
            xorderList = new List<Order>();
            kitchenOrderList = new List<KitchenOrder>();
            debugList = new List<Debug>();
            imageList = new List<GenericImage>();
        }
        public int ItemCount() {
            return customerList.Count + userList.Count + printerList.Count +
                 tableGroupList.Count + tableList.Count + menuList.Count +
                stockManager.Suppliers.Count + stockManager.EBStockItemLookups.Count + stockManager.StockItems.Count +
                orderList.Count + xorderList.Count + kitchenOrderList.Count + debugList.Count + imageList.Count;
        }

    }

    public struct DatabaseBackupOptions {
        public bool blnCustomers { get; set; }
        public bool blnUsers { get; set; }
        public bool blnPrinters { get; set; }
        public bool blnTables { get; set; }
        public bool blnMenus { get; set; }
        public bool blnStock { get; set; }

        public bool blnLuv { get; set; }
        public bool blnCurrentSession { get; set; }
        public bool blnOrders { get; set; }
        public bool blnXOrders { get; set; }
        public bool blnKitchenOrders { get; set; }
        public bool blnDebugInformation { get; set; }
        public bool blnImages { get; set; }

        public DatabaseBackupOptions Reset() {
            blnCustomers = blnUsers = blnPrinters = blnTables = blnMenus = blnStock = 
                blnLuv = blnCurrentSession = blnOrders = blnXOrders = 
                blnKitchenOrders = blnDebugInformation = blnImages = false;
            return this;
        }
        public void ResetAll() {
            blnCustomers = blnUsers = blnPrinters = blnTables = blnMenus = blnStock = 
                blnLuv= blnCurrentSession = blnOrders = blnXOrders= 
                blnKitchenOrders = blnDebugInformation= blnImages = false;
        }
    }
}
