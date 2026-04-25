using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using System.IO.Ports;
using System.Net.Mail;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;


namespace WinLayer
{
    public class BSLayer
    {
        private PosConfig config { get; set; }
        public Shop shop { get; set; }
        public User LoggedUser { get; set; }
        public Order AttachedOrder { get; set; }
        public TheMenu ActiveMenu { get; set; }
        public ConnectionStatus OfficeConnectionStatus { get; set; } = ConnectionStatus.Disconnected;
        public Bitmap imgReportSnapShot { get; set; }               
        public string StepableOrderItemGroupIID { get; set; } = "";
        public int maxHeight { get; set; }
       // public Bonus currentBonusScheme { get; set; }
        private CultureInfo ci { get; set; }

        public GenericImage printLogo { get; set; }

        public event GenericFunctionCallAsync OrderLoaded;
        public async Task OnOrderLoaded()
        {
            if (this.OrderLoaded != null)
            {
                await this.OrderLoaded.Invoke();
            }
        }

        public event GenericFunctionCallAsync OrderUnloaded;
        public async Task OnOrderUnloaded()
        {
            if (this.OrderUnloaded != null)
            {
                await this.OrderUnloaded.Invoke();
            }
        }

        public event GenericFunctionCallAsync DisplayOrder;
        public async Task OnDisplayOrder()
        {
            if (this.DisplayOrder != null)
            {
                await this.DisplayOrder.Invoke();
            }
        }

        public event KitchenEventHandler KitchenRequestOccured;
        public void OnKitchenRequestOccured(KitchenOrder order)
        {
            KitchenRequestOccured?.Invoke(order);
        }

        public event SimpleStringEventHandler ImmediateDebugOccured;
        public void OnImmediateDebugOccured(string str)
        {
            ImmediateDebugOccured?.Invoke(str);
        }

        // 1. Private static field to hold the single instance
        //private static readonly Lazy<BSLayer> _instance =
        //    new Lazy<BSLayer>(() => new BSLayer());

        private static readonly Lazy<BSLayer> _instance =
        new Lazy<BSLayer>(() => {
            // 1. Check if the ServiceHelper is actually ready
            if (ServiceHelper.Services == null)
            {
                // Return null or throw a custom error that won't crash the UI
                return null;
            }

            return new BSLayer();
        });


        // 2. Public static property to access the instance
        public static BSLayer Instance => _instance.Value;

        // 3. PRIVATE constructor prevents 'new Bslayer()' elsewhere
        private BSLayer()
        {
            config = ServiceHelper.GetService<PosConfig>();
            repoShop = ServiceHelper.GetRepository<Shop>();
            repoSession = ServiceHelper.GetRepository<Session>();
            repoEmployee = ServiceHelper.GetRepository<Employee>();
            repoMenu = ServiceHelper.GetRepository<TheMenu>();
            repoUser = ServiceHelper.GetRepository<User>();
            repoDebug = ServiceHelper.GetRepository<Debug>();
            repoCategory = ServiceHelper.GetRepository<Category>();
            repoCategoryItem = ServiceHelper.GetRepository<CategoryItem>();
            repoRecipeItem = ServiceHelper.GetRepository<RecipeItem>();
            repoDistribution = ServiceHelper.GetRepository<Distribution>();
            repoPrinter = ServiceHelper.GetRepository<Printer>();
            repoDistributionPrinter = ServiceHelper.GetRepository<DistributionPrinter>();
            repoOrder = ServiceHelper.GetRepository<Order>();
            repoOrderItem = ServiceHelper.GetRepository<OrderItem>();
            repoCustomer    = ServiceHelper.GetRepository<Customer>();
            repoBonus = ServiceHelper.GetRepository<Bonus>();
            repoKitchenOrder = ServiceHelper.GetRepository<KitchenOrder>();
            repoKitchenOrderItem = ServiceHelper.GetRepository<KitchenOrderItem>();
            repoTable = ServiceHelper.GetRepository<Masa>();
              repoXOrder = ServiceHelper.GetRepository<XOrder>();
            repoXOrderItem = ServiceHelper.GetRepository<XOrderItem>();
            repoSupplier = ServiceHelper.GetRepository<Supplier>();
               repoStockItem = ServiceHelper.GetRepository<StockItem>();
            repoImage = ServiceHelper.GetRepository<GenericImage>();

            //shop = repoShop.GetFirst().Result;
            InitializeAsync();


        }

        private async Task InitializeAsync()
        {
            try
            {
                shop = await repoShop.GetFirst();
                printLogo = await repoImage.GetByField("ReferenceIID", "Logo1");
            } catch
            {
                    //Handle the case where shop is not found, maybe log an error or set a default value
                    shop = null; // or new Shop() with default values
            }
        }

        IRepository<Shop> repoShop;
        IRepository<Session> repoSession;
        IRepository<Employee> repoEmployee;
        IRepository<TheMenu> repoMenu;
        IRepository<User> repoUser;
        IRepository<Debug> repoDebug;
        IRepository<Category> repoCategory;
        IRepository<CategoryItem> repoCategoryItem;
        IRepository<RecipeItem> repoRecipeItem;
        IRepository<Distribution> repoDistribution;
        IRepository<Printer> repoPrinter;
        IRepository<DistributionPrinter> repoDistributionPrinter;
        IRepository<Order> repoOrder;
        IRepository<OrderItem> repoOrderItem;
        IRepository<Customer> repoCustomer;
        IRepository<Bonus> repoBonus;
        IRepository<KitchenOrder> repoKitchenOrder;
        IRepository<KitchenOrderItem> repoKitchenOrderItem;
        IRepository<Masa> repoTable;
        IRepository<XOrder> repoXOrder;
        IRepository<XOrderItem> repoXOrderItem;
        IRepository<Supplier> repoSupplier;
        IRepository<StockItem> repoStockItem;
        IRepository<StockItemUsage> repoStockItemUsage;
        IRepository<GenericImage> repoImage;

        //private BSLayer(PosConfig configAsService, IRepository<Shop> _repoShop,
        //    IRepository<Session> _repoSession,
        //    IRepository<Employee> _repoEmployee,
        //    IRepository<TheMenu> _repoMenu,
        //    IRepository<User> _repoUser, IRepository<Debug> _repoDebug,
        //    IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem, IRepository<RecipeItem> _repoRecipeItem,
        //    IRepository<Distribution> _repoDistribution, IRepository<Printer> _repoPrinter, IRepository<DistributionPrinter> _repoDistributionPrinter,
        //    IRepository<Order> _repoOrder, IRepository<OrderItem> _repoOrderItem,
        //    IRepository<Customer> _repoCustomer, IRepository<Bonus> _repoBonus,
        //    IRepository<KitchenOrder> _repoKitchenOrder, IRepository<KitchenOrderItem> _repoKitchenOrderItem,
        //    IRepository<Masa> _repoTable,
        //    IRepository<XOrder> _repoXOrder, IRepository<XOrderItem> _repoXOrderItem,
        //    IRepository<Supplier> _repoSupplier, 
        //    IRepository<StockItem> _repoStockItem, IRepository<StockItemUsage> _repoStockItemUsage,
        //    IRepository<GenericImage> _repoImage)
        //{
        //    config = configAsService;
        //    repoShop = _repoShop;
        //    repoSession = _repoSession;
        //    repoEmployee = _repoEmployee;
        //    repoMenu = _repoMenu;
        //    repoUser = _repoUser;
        //    repoDebug = _repoDebug;
        //    repoCategory = _repoCategory;
        //    repoCategoryItem = _repoCategoryItem;
        //    repoRecipeItem = _repoRecipeItem;
        //    repoDistribution = _repoDistribution;
        //    repoPrinter = _repoPrinter;
        //    repoDistributionPrinter = _repoDistributionPrinter;
        //    repoOrder = _repoOrder;
        //    repoOrderItem = _repoOrderItem;
        //    repoCustomer = _repoCustomer;
        //    repoBonus = _repoBonus;
        //    repoKitchenOrder = _repoKitchenOrder;
        //    repoKitchenOrderItem = _repoKitchenOrderItem;
        //    repoTable = _repoTable;
        //    repoXOrder = _repoXOrder;
        //    repoXOrderItem = _repoXOrderItem;
        //    repoSupplier = _repoSupplier;
        //    repoStockItem = _repoStockItem;
        //    repoStockItemUsage = _repoStockItemUsage;

        //    repoImage = _repoImage;

        //    shop = repoShop.GetFirst().Result;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="culture">mesela en-GB</param>
        /// <returns></returns>
        public CultureInfo GetCulture(string culture)
        {
            CultureInfo ci = new CultureInfo(culture);
            ci.NumberFormat.CurrencyDecimalDigits = 2;
            ci.NumberFormat.NumberDecimalDigits = 2;
            return ci;
        }

        public CultureInfo GetDBCulture()
        {
            return GetCulture(config.Database_Currency_Culture);
        }

        public CultureInfo GetUICulture()
        {
            return GetCulture(config.Terminal_Currency_Culture);
        }

        public async Task<bool> DoStartThings()
        {
            try
            {
                shop = await repoShop.Get(config.ShopIID,"Bonus");
                ci = GetDBCulture();
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(config.Terminal_Currency_Culture);
            } catch
            {
                return false;
            }

            if (ActiveMenu == null)
                await GetActiveMenu(false, true);
            await EnsureSession();

            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string sessionDirectoryPath = Path.Combine(appPath, "Sessions");

            DirectoryInfo dinfo = new DirectoryInfo(sessionDirectoryPath);
            //Ensure Session Directory exist
            if (!Directory.Exists(sessionDirectoryPath))
            {
                Directory.CreateDirectory(sessionDirectoryPath);
            }
            return true;
        }


        public void RePriceOrderForOrderType(Order order, OrderTypes orderType)
        {
            TheMenu fm = ActiveMenu;
            OrderItem oi;
            for (int i = 0; i < order.Items.Count; i++)
            {
                oi = (OrderItem)order.Items[i];
                oi.Price = fm.GetItemPrice(oi.CategoryItemIID, orderType);

            }
        }

        public void ReTaxOrderForOrderType(Order order, OrderTypes orderType)
        {
            TheMenu fm = ActiveMenu;
            OrderItem oi;
            for (int i = 0; i < order.Items.Count; i++)
            {
                oi = (OrderItem)order.Items[i];
                oi.TaxPercent = fm.GetItemTaxRate( oi.CategoryItemIID, orderType);
            }
        }


        public DataTable GetDataTable(string sql)
        {
            try
            {
                var dt = new DataTable();
                var connection = repoMenu.GetDBContext().Database.GetDbConnection();

                // Use the context's connection directly
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;

                    // Open connection if it's not already open
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader); // Efficiently fills the DataTable from a DataReader
                    }
                }
                return dt;
            } catch (Exception ex)
            {
                return null;
            } finally
            {
                string str = "";
            }
        }
        public async Task<bool> RunQuery(string sql)
        {
            return await repoMenu.GetDBContext().Database.ExecuteSqlRawAsync(sql) > 0;
        }

        #region "ADMIN FUNCTIONS"


        public async Task<List<double>> GetAllTaxRates()
        {
            return await repoMenu.GetAllTaxRatesForMenu(config.ActiveMenuIID);
            // return GetDataTable("Select * from TaxPercentList where ParentMenuIID = '" + config.ActiveMenuIID + "'");
        }

        public async Task<bool> SetTaxRate(double DBTaxRate, double NewTaxRate)
        {
            return await RunQuery("UpdateTaxRates '" + config.ActiveMenuIID + "'," + DBTaxRate + "," + NewTaxRate);
        }

        #endregion


        #region "ENTITY FUNCTIONS"

        public async Task<TheMenu> GetActiveMenu(bool blnReloadConfig, bool blnReloadMenu)
        {
            if (blnReloadMenu)
            {
                if (blnReloadConfig)
                    config = UF.GetConfig();
                //Get and load active menu 
                if (config.ActiveMenuIID == null || config.ActiveMenuIID == "")
                {
                    string firstMenuIID = await GetFirstMenuIID();
                    if (firstMenuIID != "")
                    {
                        config.ActiveMenuIID = firstMenuIID;
                        UF.SaveConfig(config);
                    }
                }
                if (config.ActiveMenuIID != null && config.ActiveMenuIID != "")
                {
                    try
                    {
                        ActiveMenu = GetMenuDB(config.ActiveMenuIID).Result;
                    } catch
                    {
                        ActiveMenu = null;
                    }
                }
            }
            return ActiveMenu;
        }

        public async Task<string> GetFirstMenuIID()
        {
            TheMenu menu = await repoMenu.GetFirst();
            return menu?.IID ?? "";
        }

        //public async Task<double> GetOrdersTotalForPaymentMethod(string sessionIID, PaymentMethods payment)
        //{
        // //   List<OrdersView> orders = await repoOrder.GetOrdersView();

        //    //DataTable dt = GetDataTable("Select isnull(sum(CalculatedValue),0) as Total from OrdersView where SessionIID = '" + sessionIID + "'  and (OrdersView.Status = 3 or OrdersView.Status = 4) and Payment = " + (int)payment);
        //    //return float.Parse(dt.Rows[0]["Total"].ToString());

        //    return repoSession .Where(x => x.SessionIID == sessionIID && (x.Status == StatusFlags.Completed || x.Status == StatusFlags.Archived) && x.Payment == payment).Sum(x => x.CalculatedValue);
        //}

        public async Task<List<Debug>> GetDebugList()
        {
            return await repoDebug.GetAllAsync();
        }

        public async Task<TheMenu> GetMenuDB(string MenuIID, GenericProgressFunction progress = null, int startfrom = 0)
        {
            TheMenu menu = await repoMenu.Get(MenuIID);
            if (menu != null)
            {
                menu.categories = await repoCategory.GetDBContext().Categories.Where(x => x.MenuIID == MenuIID).ToListAsync();
                for (int i = 0; i < menu.categories.Count; i++)
                {
                    menu.categories[i].Items = await repoCategoryItem.GetDBContext().CategoryItems.Where(x => x.CategoryIID == menu.categories[i].IID).ToListAsync();
                }
                menu.distributions = await repoDistribution.GetDBContext().Distributions.Where(x => x.MenuIID == MenuIID).ToListAsync();

                return menu;
            } else
                return null;
        }



        public async Task<Category> GetEntity(string EntityIID)
        {
            return await repoCategory.Get(EntityIID);
        }

        public double GetEBTaxPercent(CategoryItem eb)
        {
            if (AttachedOrder == null)
                return 0.0f;
            switch (AttachedOrder.OrderType)
            {
                case OrderTypes.Sale:
                    return eb.SaleTax;
                case OrderTypes.Sitin:
                    return eb.SitinTax;
                case OrderTypes.TakeAway:
                    return eb.TaTax;
                case OrderTypes.Delivery:
                    return eb.DTax;
                default:
                    return eb.SaleTax;
            }
        }
        public double GetEBTaxPercentForGenericOrder(Order order, CategoryItem eb)
        {
            if (order == null)
                return 0.0f;
            switch (order.OrderType)
            {
                case OrderTypes.Sale:
                    return eb.SaleTax;
                case OrderTypes.Sitin:
                    return eb.SitinTax;
                case OrderTypes.TakeAway:
                    return eb.TaTax;
                case OrderTypes.Delivery:
                    return eb.DTax;
                default:
                    return eb.SaleTax;
            }
        }
        public async Task<CategoryItem> GetJustEntityButton(string EntityButtonIID)
        {
            return await repoCategoryItem.Get(EntityButtonIID);
            // return new EntityButton(GetDataTable("GetEntityButton", EntityButtonIID).Rows[0]);
        }

        public async Task<List<CategoryItem>> GetEntityButtonsForNumberPad()
        {
            return await repoCategoryItem.GetDBContext().Database.SqlQuery<CategoryItem>($"SELECT EntityButton.*, Entity.DistributionIID, Entity.EntityName FROM EntityButton LEFT OUTER JOIN Entity ON EntityButton.ParentEntityIID = Entity.IID WHERE  EntityButton.PadFlag > 0 and EntityButton.ParentMenuIID = '{config.ActiveMenuIID}' Order by Entitybutton.EntityButtonName").ToListAsync();
        }

        #endregion


        #region "TABLE FUNCTIONS"

        public DataTable GetAllTableGroups()
        {
            return GetDataTable("GetTableGroups");
        }

        public async Task<List<Masa>> GetTableList(string GroupIID)
        {
            return await repoTable.GetListByField("GroupIID", GroupIID);
        }
        public async Task<List<Masa>> GetTableAndSubTables(string TableIID)
        {
            return await repoTable.GetDBContext().Tables.Where(x => x.IID == TableIID).ToListAsync();
        }

        public async Task<Masa> BarrowTable(string TableIID)
        {
            try
            {
                return await repoTable.Get(TableIID, "Order");

                //if (table?.CurrentOrder != null)
                //{
                //    // Access order details
                //    var orderId = table.CurrentOrder.Id;
                //} else
                //{
                //    // Table is empty/available
                //}



                ////Get Table 
                //Table table = await GetTable(TableIID);

                //if (table.IsBusy(config.Terminal_Name))
                //    //if busy return null
                //    return null;
                //else
                //{
                //    if (!string.IsNullOrEmpty(table.OrderIID))
                //    {
                //        //if table has order attached to it
                //        //set table ClientIP(busy), set table OrderIID(occupied) , set order tableIID, set order ClientIP (busy), 
                //        Order order = await GetOrder(table.OrderIID);
                //        order.TableIID = table.IID;
                //        order.LockedClientIP = config.Terminal_Name;
                //        order.Title = "Table " + table.TableName + " C " + order.Covers.ToString();
                //        table.OrderIID = order.IID;
                //        table.LockedClientIP = config.Terminal_Name;
                //        await repoOrder.Save(order);
                //        await repoTable.Save(table);
                //        table.AttachedOrder = order;
                //        return table; //return table
                //    } else
                //    {
                //        //create a new order
                //        Order order = new Order(OrderTypes.Sitin)
                //        {
                //            //order.customer = new Customer();
                //            TableIID = table.IID,
                //            LockedClientIP = config.Terminal_Name
                //        };
                //        order.Title = "Table " + table.TableName + " C " + order.Covers.ToString();
                //        table.OrderIID = order.IID;
                //        table.LockedClientIP = config.Terminal_Name;
                //        await repoOrder.Save(order);
                //        await repoTable.Save(table);
                //        //retun table
                //        table.AttachedOrder = order;
                //        return table;
                //    }
                //}
            } catch
            {
                return null;
            }
        }

        ///Used to return an inhouse order
        public async Task ReturnTable(Masa table)
        {

            if (table.AttachedOrder == null)
            {
                table.LockedClientIP = "";
                table.TableCovers = 1;
                await repoTable.Save(table);
                return;
            }
            if ((int)table.AttachedOrder.Status >= (int)StatusFlags.Completed)
            {
                //unbusy table, delete order details from table
                table.LockedClientIP = "";
                table.TableCovers = 1;
                await repoTable.Save(table);

                //delete table details from order	
                table.AttachedOrder.TableIID = "";
            } else
            {
                if (table.AttachedOrder.Items.Count > 0)
                {
                    //Order still active and has items so unbusy table, save table
                    table.LockedClientIP = "";
                    await repoTable.Save(table);

                    //unbusy order, save order
                    table.AttachedOrder.LockedClientIP = "";
                    await repoOrder.Save(table.AttachedOrder);
                } else
                {
                    //unbusy table, delete order details from table
                    table.LockedClientIP = "";
                    table.TableCovers = 1;
                    await repoTable.Save(table);

                    await DeleteOrderOnly(table.AttachedOrder);
                }
            }
        }

        ///Used to return an inhouse order , this function is ONLY CALLED BY RETURN ORDER
        private async void ReturnTable(Order order)
        {
            Masa table =  await repoTable.Get(order.TableIID);
            if (table == null)
                return;
            if ((int)order.Status >= (int)StatusFlags.Completed)
            {

                //unbusy table, delete order details from table
                table.LockedClientIP = "";
                table.TableCovers = 1;
                await repoTable.Save(table);

                //delete table details from order	
                order.TableIID = null;

                //unbusy order, save order
                order.LockedClientIP = null;
                await repoOrder.Save(order);
            } else
            {
                if (order.Items.Count > 0)
                {
                    //Order still active and has items so unbusy table, save table
                    table.LockedClientIP = "";
                    await repoTable.Save(table);

                    //unbusy order, save order
                    order.LockedClientIP = "";
                    await repoOrder.Save(order);
                } else
                {
                    //unbusy table, delete order details from table
                    table.LockedClientIP = "";
                    table.TableCovers = 1;
                    await repoTable.Save(table);

                    await DeleteOrderOnly(order);
                }
            }
        }


        //public async Task<bool> MoveTable(string sourceTableIID, string targetTableIID)
        //{
        //    bool blnSourcePrimary;
        //    bool blnTargetPrimary;
        //    bool blnTargetEmpty;
        //    bool blnSourceHasSubTables;
        //    bool blnTargetHasSubTables;

        //    Masa sourceTable = await repoTable.Get(sourceTableIID);
        //    if (sourceTable.Order != null)
        //        sourceTable = await BarrowTable(sourceTableIID);
        //    else
        //        return false;
        //    Masa targetTable = await repoTable.Get(targetTableIID);
        //    if (targetTable.HasActiveOrder())
        //        targetTable = await BarrowTable(targetTableIID);
        //    blnTargetEmpty = !targetTable.HasActiveOrder();

        //    Order sourceOrder;
        //    Masa subTargetTable;

        //    if (blnTargetEmpty)
        //    {
        //        ///2-primary(YesSub) => empty primary                     =>primary+sub  primary+sub           OrderTransfer for primary + TableTransfer for sub tables
        //        sourceOrder = MakeOrderFreeFromTable(sourceTable.Order);
        //        sourceTable = MakeTableFreeFromOrder(sourceTable);
        //        AttachOrderToTable(sourceOrder, targetTable);

        //        await ReturnTable(sourceTable);
        //        await ReturnTable(targetTable);

        //        return true;
        //    }
        //    return false;
        //}

        //private Order MakeOrderFreeFromTable(Order order)
        //{
        //    order.TableIID = null;
        //    order.LockedClientIP = null;
        //    return order;
        //}

        private Order AttachOrderToTable(Order order, Masa table)
        {
            order.TableIID = table.IID;
            return order;
        }

        private Masa MakeTableFreeFromOrder(Masa table)
        {
            table.LockedClientIP = "";
            return table;
        }



        /// <summary>
        /// TABLE MERGE ACTION
        /// Source table cannot be primary table (static table)
        /// </summary>
        /// <param name="sourceTableIID"></param>
        /// <param name="targetTableIID"></param>
        /// <returns></returns>
        public async Task<bool> MergeTable(string sourceTableIID, string targetTableIID)
        {
            Masa sourceTable = await BarrowTable(sourceTableIID);

            await ReturnTable(sourceTable);
            return false;


            //Table targetTable = await BarrowTable(targetTableIID);
            //targetTable.AttachedOrder.MergeOrder(sourceTable.AttachedOrder);
            //await repoOrder.Delete(sourceTable.CurrentOrderIID);

            //MakeTableFreeFromOrder(sourceTable);
            //await ReturnTable(targetTable);

            //return true;
        }

        //public async Task<Masa> GetTable(string TableIID)
        //{
        //    return await repoTable.Get(TableIID);
        //    //DataTable dt =await GetDataTable("GetTable", TableIID);
        //    //if (dt.Rows.Count > 0)
        //    //    return new Table(dt.Rows[0]);
        //    //else
        //    //    return null;
        //}


        //public async Task<bool> SaveTable(Masa masa)
        //{
        //    return await repoTable.Save(masa) != null;
        //}


        //public async void FreeTheTable(string TableIID)
        //{
        //    Masa table = await GetTable(TableIID);
        //    if (table != null)
        //    {
        //        Order order = table.Order; // await GetOrder(table.OrderIID);
        //        if (order != null)
        //        {
        //            if (order.Items.Count == 0)
        //                await DeleteOrderOnly(order);
        //            else
        //            {
        //                order.TableIID = "";
        //                order.LockedClientIP = "";
        //                await SaveOrder(order);
        //            }
        //        }

        //        table.LockedClientIP = "";
        //        table.TableCovers = 1;
        //        await SaveTable(table);
        //    }
        //}

        #endregion

        #region "DISTRIBUTION FUNCTIONS"


        public async Task<List<Distribution>> GetAllDistributionsForMenu(string ActiveMenuIID)
        {
            return await repoDistribution.GetListByField("ParentMenuIID", ActiveMenuIID, includeItems: "Printer") ?? new();
        }


        public async Task<Distribution> GetDistribution(string DistributionIID)
        {
            return await repoDistribution.Get(DistributionIID);
            // return new Distribution(GetDataTable("GetDistribution", DistributionIID).Rows[0]);
        }



        #endregion

        #region "ORDER FUNCTIONS"
        public async Task<List<XOrder>> GetXOrderList()
        {
            return await repoXOrder.GetListByField("SessionIID", shop.CurrentSessionIID, OrderByField: "OrderDate");
            //List<Order> xOrderList = new List<Order>();
            //DataTable dt = GetDataTable("SELECT * from XOrders where SessionIID = '" + shop.CurrentSessionIID + "' order by OrderDate");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    xOrderList.Add(GetXOrder(dt.Rows[i]["IID"].ToString()));
            //return xOrderList;
        }
        public async Task<XOrder> GetXOrder(string IID)
        {
            return await repoXOrder.Get(IID, "Items");
            //DataTable dt = GetDataTable("SELECT * from XOrders where IID = '" + IID + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    //create order
            //    Order xorder = new Order(dt);
            //    //add order items
            //    DataTable dtItems = GetDataTable("GetAllXOrderItems", xorder.IID);

            //    for (int i = dtItems.Rows.Count - 1; i >= 0; i--)
            //        xorder.items.Add(new OrderItem(dtItems.Rows[i]));
            //    return xorder;
            //} else
            //    return null;
        }

        public async Task<List<Order>> GetOrderList()
        {
            return await repoOrder.GetListByField("SessionIID", shop.CurrentSessionIID, includeItems: "items", "OrderDate");
            //List<Order> OrderList = new List<Order>();
            //DataTable dt = GetDataTable("GetSessionOrders", shop.CurrentSessionIID);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    OrderList.Add(GetOrder(dt.Rows[i]["IID"].ToString()));
            //return OrderList;
        }

        public DataTable GetSessionOrdersByStatus(StatusFlags InclusiveStatus)
        {
            return GetDataTable("GetSessionOrdersByStatus '" + shop.CurrentSessionIID + "'," +
                                (int)InclusiveStatus);
        }

        public async Task<Order> GetOrder(string IID)
        {
            return await repoOrder.Get(IID);
            //DataTable dt = GetDataTable("GetOrder", IID);
            //if (dt.Rows.Count > 0)
            //{
            //    //create order
            //    Order order = new Order(dt);
            //    //add order items
            //    DataTable dtItems = this.GetAllOrderItems(order.IID);

            //    for (int i = dtItems.Rows.Count - 1; i >= 0; i--)
            //        order.items.Add(this.GetOrderItem(dtItems.Rows[i]["IID"].ToString()));
            //    return order;
            //} else
            //    return null;
        }



        public async Task<bool> SaveOrder(Order order)
        {
            CultureInfo ci = GetDBCulture();
            try
            {
                string OrderIID = order.IID;
                if (order.SessionIID == "" || order.SessionIID == null)
                    order.SessionIID = shop.CurrentSessionIID;

                if (await repoOrder.SaveTree(order) != null)
                    return true;
                else
                    return false;
            } catch
            {
                return false;
            }

        }

        public async Task<bool> DeleteOrder(string OrderIID)
        {
            return await repoOrder.Delete(OrderIID) > 0;
            // return RunQuery("DeleteOrder", OrderIID);
        }

        //This only deletes the order , most likely called from a function which checked the inhouse, 
        //TakeAwayB, delivery possibilities
        //and deleted the table already if any or freed it.
        public async Task DeleteOrderOnly(Order order)
        {
            await repoOrder.Delete(order.IID);
            //if (order != null)
            //{
            //    RunQuery("DeleteOrderItemsForOrder", order.IID);
            //    RunQuery("DeleteOrder", order.IID);
            //}
        }

        public bool ConfirmForSupervision()
        {
            using (trmSupervisorLogin frm = ActivatorUtilities.CreateInstance<trmSupervisorLogin>(ServiceHelper.Services))
            {
                return (frm.ShowDialog() == DialogResult.OK);
            }
        }

        //public async Task<OrderItem> GetOrderItem(string IID)
        //{
        //    return await repoOrderItem.Get(IID);
        //    //DataTable dt = GetDataTable("GetOrderItem", IID);
        //    //if (dt == null)
        //    //    return null;

        //    //return new OrderItem(dt.Rows[0]);
        //}
        public async Task SaveOrderItem(OrderItem oi)
        {
            await repoOrderItem.Save(oi);
        }

        public async Task SaveLogItem(LogItem log)
        {
            try
            {
                CultureInfo ci = GetDBCulture();
                string sql = "SaveLogItem '" + log.IID + "','" + log.OrderItemText + "'," + log.Quantity + ",'" +
                                log.Price.ToString(ci) + "','" + log.Reason.Replace("'", "''") + "'," +
                                DRDateTime.DatetimeToMSSql(log.EventDateTime) + ",'" +
                                log.ComputerName + "','" + log.OrderContent.Replace("'", "''") + "','" + log.Reference + "'";

                await RunQuery(sql);
            } catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
       

        public async Task DeleteLogItems(List<string> IIDList)
        {
            foreach (var IID in IIDList)
            {
                await RunQuery("Delete From LogItems Where IID ='" + IID + "'");
            }
        }
        public async Task DeleteAllLogItems()
        {
            try
            {
                await RunQuery("Delete From LogItems");
            } catch { }
        }

        public async Task ReturnOrder(Order order)
        {
            if (order.OrderType == OrderTypes.Sitin)
                this.ReturnTable(order);
            else
            {
                if (order.Items.Count > 0)
                {
                    order.LockedClientIP = null;
                    order.TableIID = null;
                    await SaveOrder(order);
                } else
                    await DeleteOrder(order.IID);
            }
        }

        public async Task<Order> BarrowOrder(string OrderIID, string ClientIP)
        {
            Order order = await GetOrder(OrderIID);
            if (order.IsBusy(ClientIP))
                return null;
            else
            {
                order.LockedClientIP = ClientIP;
                await SaveOrder(order);
                return order;
            }
        }



        public async Task<List<Order>> GetOrderListForSession(string SessionIID)
        {
            return await repoOrder.GetDBContext().Orders.Where(x => x.SessionIID == SessionIID).Include("items").ToListAsync();
            //List<Order> OrderList = new List<Order>();
            //DataTable dt = GetDataTable("GetSessionOrders", SessionIID);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    OrderList.Add(await GetOrder(dt.Rows[i]["IID"].ToString()));
            //return OrderList;
        }

        #endregion

        public bool SendEmailToCustomRecepient(string ToEmail, string subject, string body, Attachment attachment)
        {
            if (shop == null)
            {
                return false;
            }

            MailMessage msg = new MailMessage(shop.SmtpEmailAddress,
                ToEmail, subject, body);
            if (attachment != null)
                msg.Attachments.Add(attachment);

            SmtpClient smtp = DRSmtp.GetSmtp(shop.SmtpServer, shop.SmtpEmailAddress, shop.SmtpPassword);
            DRSmtp.SendEmail(smtp, msg);
            return true;
        }

        public async Task<bool> SaveDebug(string data)
        {
            return await RunQuery("Insert into Debug (Data) values ('" + data.Replace("'", "''") + "')");
        }

        #region "SERVER PRINTER FUNCTIONS"

        public async Task<List<Printer>> GetPrintersByPrinterType(PrinterTypes PrinterType)
        {
            return await repoPrinter.GetDBContext().Printers.Where(x => x.PrinterType == PrinterType).ToListAsync();
        }

        public async Task<Printer> GetPrinterForClient(string PrinterIID)
        {
            return await repoPrinter.GetDBContext().Printers
                .Where(x => x.IID == PrinterIID && x.LocalTerminal == config.Terminal_Name).FirstOrDefaultAsync();
        }

        public async Task<Printer> GetDefaultReceiptPrinter()
        {
            if (config.TerminalReceiptPrinterIID != null && config.TerminalReceiptPrinterIID != "")
                return await GetPrinterForClient(config.TerminalReceiptPrinterIID);
            else
                return null;
        }

        public async Task<Printer> GetPrinterForOrderType(OrderTypes orderType)
        {
            switch (orderType)
            {
                case OrderTypes.Sale:
                case OrderTypes.Sitin:
                    return await repoPrinter.Get(config.TerminalReceiptPrinterIID);
                case OrderTypes.Delivery:
                    return await repoPrinter.GetDBContext().Printers.Where(x => x.DeliveryPrinter && x.LocalTerminal == config.Terminal_Name).FirstOrDefaultAsync();
                case OrderTypes.TakeAway:
                    return await repoPrinter.GetDBContext().Printers.Where(x => x.TakeAwayPrinter && x.LocalTerminal == config.Terminal_Name).FirstOrDefaultAsync();
                default:
                    return await repoPrinter.Get(config.TerminalReceiptPrinterIID);
            }
        }
        public async Task<List<Distribution>> GetDistributionListForPrinter(string PrinterIID)
        {
            return await repoDistribution.GetDBContext().Distributions
                .Where(d => d.DistributionPrinters.Any(dp => dp.PrinterIID == PrinterIID)).ToListAsync();
        }
        public async Task<List<Printer>> GetReceiptPrinterList()
        {
            return await repoPrinter.GetAllAsync();
        }

        #endregion

        #region "CASH DRAWER"
        public async Task<bool> OpenCashDrawer()
        {
            if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.LocalAttached)
                return OpenLocalCashDrawer();
            else if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.USBPrinterAttached)
                return await OpenLocalUSBPrinterCashDrawer();
            else if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.PrinterAttached)
                return await OpenCashDrawerByPrinter();
            else
                return false;
        }

        public async Task<bool> OpenCashDrawerByPrinter()
        {
            try
            {
                Printer printer = await GetPrinterForClient(config.DtPrinterCashDrawerIID);

                if (printer == null)
                    return false;
                DRShell.SendOpenCashDrawerToPrinter(printer.NetworkName);
                return true;
            } catch
            {
                return false;
            }
        }

        public bool OpenLocalCashDrawer()
        {
            try
            {
                SerialPort comport = new SerialPort(config.Cash_Drawer_Serial_Port.ToString(), 9600, Parity.None, 8,
                    StopBits.Two);

                comport.Open();
                comport.Write("a" + '\x1C');
                comport.Close();
                return true;
            } catch
            {
                return false;
            }
        }

        public async Task<bool> OpenLocalUSBPrinterCashDrawer()
        {
            try
            {
                Printer printer = await GetPrinterForClient(config.DtPrinterCashDrawerIID);

                if (printer == null)
                    return false;
                DRShell.SendOpenCashDrawerToUSBPrinter(printer.NetworkName);
                return true;
            } catch
            {
                return false;
            }
        }
        public async Task EnsureSession()
        {
            if (!await repoSession.Any(shop.CurrentSessionIID))
                await StartNewSession();
        }

        public async Task<Session> GetCurrentSession()
        {
            return await repoSession.Get(shop.CurrentSessionIID);
        }

        #endregion

        #region "PRINT FUNCTIONS"

        public async Task<bool> PrintForKitchen(string orderIID)
        {
            try
            {
                KitchenOrder korder = await GetKitchenOrderForOrder(orderIID);
                if (korder != null)
                {
                    List<Printer> printerList = GetApplicationPrinterList(korder);
                    for (int i = 0; i < printerList.Count; i++)
                    {
                        new ReportGenerator(printerList[i], 2,printLogo).PrintKitchen(korder);
                    }
                }
                return true;
            } catch
            {
                return false;
            }
        }
        public bool PrintForKitchen(KitchenOrder korder)
        {
            try
            {
                if (korder != null)
                {
                    List<Printer> printerList = GetApplicationPrinterList(korder);
                    for (int i = 0; i < printerList.Count; i++)
                    {
                        new ReportGenerator(printerList[i], 2,printLogo).PrintKitchen(korder);
                    }
                }
                return true;
            } catch
            {
                return false;
            }
        }

        public bool PrintForKitchen(KitchenOrder korder, Printer printer, bool blnWithDetail = false)
        {
            try
            {
                return new ReportGenerator(printer).PrintKitchen(korder, blnWithDetail);
            } catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if order has a waiting or completed and related KitchenOrder in the database
        /// </summary>
        /// <param name="orderIID"></param>
        /// <returns></returns>
        public bool HasAnyKitchenOrderInDatabase(string orderIID)
        {
            DataTable dt = GetDataTable("Select count(IID) as howmany from KitchenOrders where OrderIID ='" + orderIID + "'");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        /// <summary>
        /// Checks if KitchenOrder has any wating or partiallycompleted items
        /// </summary>
        /// <param name="korder"></param>
        /// <returns></returns>
        public bool HasAnyNonCompleteItems(KitchenOrder korder)
        {
            foreach (KitchenOrderItem item in korder.Items)
            {
                if (item.Status != KitchenOrderStatusTypes.Completed)
                    return true;
            }
            return false;
        }


        public async Task<PrepDialogReturnTypes> CreateKitchenOrderForOrder(Order order, KitchenOrder korder)
        {
            korder = null;
            PrepDialogReturnTypes prepDialogResult = PrepDialogReturnTypes.Cancel;

            if (AttachedOrder != null)
            {

                //Now Create Kitchen Order To Display
                korder = ConvertOrderToKitchenOrder(order);
                korder.OrderType = order.OrderType;
                if (order.OrderType == OrderTypes.Sitin)
                    korder.Reference = order.Table?.TableName;



                using (frmPrep frm =new frmPrep(korder))
                {
                    frm.ShowDialog();
                    prepDialogResult = frm.prepResult;
                }
                if (prepDialogResult == PrepDialogReturnTypes.Cancel)
                    return PrepDialogReturnTypes.Cancel;

                //if (prepDialogResult == PrepDialogReturnTypes.HoldNotPaid)
                //    korder.SetStatusCustom(KitchenOrderStatusTypes.WaitingToBePaid);

                //check if order has any old kitchen order
                bool blnHasOldKitchenOrder = HasAnyKitchenOrderInDatabase(order.IID);

                //check if any non completed items 
                bool blnHasNonCompleteItems = HasAnyNonCompleteItems(korder);

                //Modify if any existing kitchen order and if allowed

                //Save Kitchen Order if required that is non complete item exist

                bool blnSaved = false;

                if (blnHasOldKitchenOrder)
                {
                    if (blnHasNonCompleteItems)
                    {
                        blnSaved = await ModifyOldKitchenOrder(korder);
                    }
                } else
                {
                    if (blnHasNonCompleteItems)
                        blnSaved = SaveKitchenOrder(korder);
                }

                if (blnSaved)
                {
                    korder.OrderNo = GetKitchenOrderNumber(korder.IID);

                    if (korder.Items.Count > 0)
                    {
                        switch (order.OrderType)
                        {
                            case OrderTypes.Sale:
                                if ((order.Status == StatusFlags.New || order.Status == StatusFlags.Holding) && config.Hold_Order_Print_in_Kitchen)
                                    PrintForKitchen(korder);
                                break;
                            case OrderTypes.Sitin:
                                if (config.Table_Orders_Kitchen_Receipt_Count > 0)
                                    PrintForKitchen(korder);
                                break;
                            default:
                                break;
                        }
                    }
                }

                //this is where you print kitchen order
                OnKitchenRequestOccured(await GetKitchenOrder(korder.IID));
            }
            return prepDialogResult;
        }

        public int GetKitchenOrderNumber(string IID)
        {
            try
            {
                return int.Parse(GetDataTable("Select OrderNo from KitchenOrders where IID = '" + IID + "'").Rows[0]["OrderNo"].ToString());
            } catch
            {
                return 0;
            }
        }


        public bool UpdateCompletedQuantityForRelatedKitchenOrderItem(KitchenOrderItem koi)
        {
            try
            {
                OrderItem oi = AttachedOrder.Items.Find(x => x.CategoryItemIID == koi.CategoryItemIID);
                oi.CompletedQuantity += koi.Quantity;
                //oi.OrderItemText = koi.ItemText;
                SaveOrderItem(oi);
                return true;
            } catch
            {
                return false;
            }
        }
        public async Task<KitchenOrder> GetKitchenOrderForOrder(string orderIID)
        {
            return await repoKitchenOrder.GetDBContext().KitchenOrders.Where(x => x.OrderIID == orderIID).Include("items").FirstOrDefaultAsync();
            //DataTable dt = GetDataTable("Select IID from KitchenOrders where OrderIID ='" + orderIID + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    string IID = dt.Rows[0]["IID"].ToString();
            //    return GetKitchenOrder(IID);
            //} else
            //    return null;
        }

        public async Task DeleteKitchenOrdersForOrder(string orderIID)
        {
            await repoKitchenOrder.GetDBContext().KitchenOrders.Where(x => x.OrderIID == orderIID).ExecuteDeleteAsync();
            //RunQuery("DeleteKitchenOrdersForOrder", orderIID);
        }
        public async Task<bool> ModifyOldKitchenOrder(KitchenOrder newKOrder)
        {
            KitchenOrder oldKitchenOrder = await GetKitchenOrderForOrder(newKOrder.OrderIID);
            if (oldKitchenOrder != null)
            {
                oldKitchenOrder.Items.Clear();
                foreach (KitchenOrderItem item in newKOrder.Items)
                {
                    item.KitchenOrderIID = oldKitchenOrder.IID;
                }
                oldKitchenOrder.Items.AddRange(newKOrder.Items);
                RunQuery("Delete from KitchenOrderItem where KitchenOrderIID = '" + oldKitchenOrder.IID + "'");
                oldKitchenOrder.CreatedDateTime = DateTime.Now;
                oldKitchenOrder.Reference = newKOrder.Reference;
                return SaveKitchenOrder(oldKitchenOrder);
            } else
                return false;
        }

        public async Task<bool> CreateKitchenOrderForTakeAwayAndDeliveryOrder(Order order)
        {
            if (order != null)
            {
                //Now Create Kitchen Order To Display
                KitchenOrder korder = ConvertOrderToKitchenOrder(order);
                korder.OrderType = order.OrderType;
                korder.Reference = order.OrderType.ToString() + "  " + order.Customer.CName;
                SaveKitchenOrder(korder);
                OnKitchenRequestOccured(await GetKitchenOrder(korder.IID));
            }
            return true;
        }

        public async Task<List<Distribution>> GetDistributionList(KitchenOrder korder)
        {
            List<Distribution> theList = new List<Distribution>();
            for (int i = 0; i < korder.Items.Count; i++)
            {
                if (theList.Find(x => x.IID == korder.Items[i].DistributionIID) == null)
                    theList.Add(await GetDistribution(korder.Items[i].DistributionIID));
            }
            return theList;
        }
        public async Task<string> GetDistributionListAsCommaSeperatedSqlString(KitchenOrder korder)
        {
            List<Distribution> theList = await GetDistributionList(korder);
            string str = "";
            for (int i = 0; i < theList.Count; i++)
            {
                str += "'" + theList[i].IID + "',";
            }
            if (str.Length > 0)
                str = str.Substring(0, str.Length - 1);
            return str;
        }
        public async Task<List<Printer>> GetApplicationPrinterList()
        {
            return await repoPrinter.GetAllAsync();
            //string sql = "select* from printerview";
            //DataTable dt = GetDataTable(sql);
            //List<ApplicationPrinter> theList = new List<ApplicationPrinter>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    theList.Add(new ApplicationPrinter(dt.Rows[i]));
            //}
            //return theList;
        }

        public List<Printer> GetApplicationPrinterList(KitchenOrder korder)
        {
            return null;
            //string sql = "select * from printerview where ClientIID = '" + config.Terminal_Name + "' and IID in (select distinct PrinterIID from distribution where IID in (" + GetDistributionListAsCommaSeperatedSqlString(korder) + "))";
            //DataTable dt = GetDataTable(sql);
            //List<ApplicationPrinter> theList = new List<ApplicationPrinter>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    theList.Add(new ApplicationPrinter(dt.Rows[i]));
            //}
            //return theList;
        }

        public async Task<bool> PrintEntireOrder(Order order, bool blnOrderly, bool blnSetPrintFlags, int NumberOfCopy, string SelectedPrinterIID)
        {
            try
            {
                await repoOrder.Save(order);

                if (SelectedPrinterIID != null)
                {
                    PrintReceipt(order, await GetPrinterForClient(SelectedPrinterIID), NumberOfCopy);
                }
                return true;
            } catch
            {
                return false;
            }
        }

        /// NEW PRINT RECEIPT FUNCTIONS /////
        public int PrintReceipt(Order  order, Printer printer, int NumberOfCopy)
        {
            ReportGenerator generator = new ReportGenerator(printer, 2, printLogo);
            generator.PrintReceipt(order);
            return generator.FinalLength;
        }

        public int PrintKassaReport(List<string> report, Printer printer, int NumberOfCopy)
        {
            ReportGenerator generator = new ReportGenerator(printer, 2,printLogo);
            generator.PrintKassaReport(report);
            return generator.FinalLength;
        }


        public int ViewReceipt(Graphics g, Order order, Printer printer, int NumberOfCopy)
        {
            ReportGenerator generator = new ReportGenerator(g, printer, 2,printLogo);
            generator.PrintReceipt(order);
            return generator.FinalLength;
        }

        #endregion

        #region "REPORT FUNCTIONS"
        public DataTable GetReportEntityEBTotals(string SessionIID, string EntityIID)
        {
            return GetDataTable("GetReportEntityEBTotals '" + SessionIID + "','" + EntityIID + "'");
        }

        public DataTable GetReportEntityTotals(string SessionIID)
        {
            return GetDataTable("GetReportEntityTotals '" + SessionIID + "'");
        }
        public DataTable GetReportPaymentTypeTotals(string SessionIID)
        {
            return GetDataTable("GetReportPaymentTypeTotals '" + SessionIID + "'");
        }

        public async Task<bool> PrintReport(ReportFormatTypes reportFormat, string SessionIID, string PrinterIID, bool LatePrinting)
        {
            ReportGenerator generator = new ReportGenerator(await GetPrinterForClient(PrinterIID), 2,printLogo);
            if (LatePrinting)
                return await generator.PrintLateSessionReport(SessionIID, reportFormat);
            else
            {
                bool blnresult = await generator.PrintSessionReport(SessionIID, reportFormat);
                imgReportSnapShot = generator.imgSnapShot;
                return blnresult;
            }
        }

        public async void PrintPriceList(string catalogIID, string PrinterIID)
        {
            try
            {
                ReportGenerator generator = new ReportGenerator(await GetPrinterForClient(PrinterIID), 2,printLogo);
                generator.PrintPriceList(catalogIID);
            } catch
            {
            }
        }

        public async Task<bool> RemoveZeroOrdersOfCurrentSessionAndCreateNewSession()
        {
            try
            {
                Session SessionToArchive = await repoSession.Get(shop.CurrentSessionIID, "Orders");

                //This is a second before where the current session to be archived

                SessionToArchive.Orders.Where(x => x.Status == StatusFlags.Completed).ToList().ForEach(x => x.Status = StatusFlags.Archived);


                //if (await RunQuery($"UPDATE  Orders SET Status = 4 WHERE SessionIID = '{SessionToArchive.IID}' And Status = 3"))
                //{
                    if (await repoSession.Save(SessionToArchive) != null)                { 


                    //Handle start new session things
                    Session session = await GetLatestSession();
                    if (session == null)
                    {
                        await StartNewSession();
                    } else
                    {
                        if (SessionToArchive.IID == session.IID)
                        {
                            SessionToArchive.EndDate = DateTime.Now;
                            await repoSession.Save(SessionToArchive);
                            await StartNewSession();
                        }
                    }
                    return true;
                } else
                    return false;
            } catch
            {
                return false;
            }
        }

        public Report GetReport(ReportFormatTypes reportType)
        {
            Report report = new Report(reportType);
            switch (reportType)
            {
                case ReportFormatTypes.XReport:
                    report.PrintCategoryReport = config.X_Print_Category_Report;
                    report.PrintCategoryDetailedReport = config.X_Print_Category_Detailed_Report;
                    report.PrintCashOrderList = config.X_Print_Cash_Order_List;
                    report.PrintCardOrderList = config.X_Print_Card_Order_List;
                    report.PrintOnlineOrderList = config.X_Print_Online_Order_List;
                    report.RequireCashDrawTotal = config.X_Cash_Drawer_Count_Required;
                    break;
                case ReportFormatTypes.ZReport:
                    report.PrintCategoryReport = config.Z_Print_Category_Report;
                    report.PrintCategoryDetailedReport = config.Z_Print_Category_Detailed_Report;
                    report.PrintCashOrderList = config.Z_Print_Cash_Order_List;
                    report.PrintCardOrderList = config.Z_Print_Card_Order_List;
                    report.PrintOnlineOrderList = config.Z_Print_Online_Order_List;
                    report.RequireCashDrawTotal = config.X_Cash_Drawer_Count_Required;
                    break;
            }

            return report;
        }

        #endregion

        #region "SESSION FUNCTIONS"

        public DataTable GetSessionList()
        {
            return GetDataTable("GetSessionList");
        }

        //public async Task<Session> GetSessionDataDynamic(string SessionIID)
        //{
        //    return await repoSession.Get(SessionIID);
        //}

        //public async Task<bool> SaveSessionData(SessionData ses)
        //{

        //    return await RunQuery("SaveSessionData '" + ses.SessionIID + "'," +
        //                       DRDateTime.DatetimeToMSSql(ses.SessionStartDateTime) +
        //                       "," + DRDateTime.DatetimeToMSSql(ses.SessionEndDateTime) + ",'" +
        //                       ses.GrossSessionTotal.ToString(ci) + "','" +
        //                       ses.X1Total.ToString(ci) + "','" + ses.X2Total.ToString(ci) + "','" + ses.X3Total.ToString(ci) + "'");
        //}

        //public async Task<bool> SaveDrawerSessionData(SessionData ses)
        //{
        //    CultureInfo ci = GetDBCulture();
        //    return await RunQuery("SaveDrawerSessionData '" + ses.SessionIID + "','" + ses.peny1.ToString(ci) +
        //                       "','" + ses.peny2.ToString(ci) +
        //                       "','" + ses.peny5.ToString(ci) +
        //                       "','" + ses.peny10.ToString(ci) +
        //                       "','" + ses.peny20.ToString(ci) +
        //                       "','" + ses.peny50.ToString(ci) +
        //                       "','" + ses.pound1.ToString(ci) +
        //                       "','" + ses.pound2.ToString(ci) +
        //                       "','" + ses.pound5.ToString(ci) +
        //                       "','" + ses.pound10.ToString(ci) +
        //                       "','" + ses.pound20.ToString(ci) +
        //                       "','" + ses.pound50.ToString(ci) +
        //                       "','" + ses.pound100.ToString(ci) +
        //                       "','" + ses.pound200.ToString(ci) +
        //                       "','" + ses.pound500.ToString(ci) +
        //                       "','" + ses.pound1000.ToString(ci) +
        //                       "','" + ses.CashTotal.ToString(ci) +
        //                       "','" + ses.CardTotal.ToString(ci) +
        //                       "','" + ses.OnlineTotal.ToString(ci) + "'");
        //}


        /// <summary>
        /// Determines X1, X2 or X3 will be printed
        /// </summary>
        /// <param name="givenSession"></param>
        /// <returns></returns>
        public int GetAvailableXReportSlot(Session givenSession)
        {
            if (givenSession.X1Total == 0)
                return 1;
            else if (givenSession.X2Total == 0)
                return 2;
            else if (givenSession.X3Total == 0)
                return 3;
            else
                return -1;
        }





        /// <summary>
        /// Determines if printing X report will auto produce Z report
        /// </summary>
        /// <param name="givenSession"></param>
        /// <returns></returns>
        public bool WillReportEndUpAs_Z_Report(Session givenSession)
        {
            int availableXLocation = 0;
            if (givenSession.X1Total == 0)
                availableXLocation = 1;
            else if (givenSession.X2Total == 0)
                availableXLocation = 2;
            else if (givenSession.X3Total == 0)
                availableXLocation = 3;


            return availableXLocation == config.Maximum_XReport_Count;
        }

        public bool Is_Z_ReportTimeNow(Session givenSession)
        {
            if (givenSession.X1Total > 0 && config.Maximum_XReport_Count == 1)
                return true;
            else if (givenSession.X2Total > 0 && config.Maximum_XReport_Count == 2)
                return true;
            else if (givenSession.X3Total > 0 && config.Maximum_XReport_Count == 3)
                return true;
            else
                return false;
        }
        public async Task<bool> RefreshDatabase()
        {
            try
            {
                string logfileName = GetDataTable("Select name from sys.database_files where type_desc = 'LOG'").Rows[0]["name"].ToString();
                return await RunQuery("CHECKPOINT;DBCC SHRINKFILE (N'" + logfileName + "', 1, TRUNCATEONLY);EXEC sp_cycle_errorlog;");
            } catch
            {
                return false;
            }
        }
        public async Task<bool> ArchiveSessionToDirectory(string SessionIID)
        {
            try
            {
                Session session = await repoSession.Get(SessionIID, "Orders, Orders.Items");

                string SessionFileName = DRFile.GenerateFileName(session.StartDate, session.EndDate.Value, "xml");

                if (File.Exists(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName))
                    return false;

                if (session.EndDate == null)
                {
                    session.EndDate = DateTime.Now;
                }
                if (await repoSession.Save(session) != null)
                {
                    if (DRFile.XmlSerialize(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName, session, typeof(Session), false))
                    {
                        //This deletes the session from database all together
                        await repoSession.Delete(SessionIID);
                    }
                    return true;
                } else
                    return false;
            } catch
            {
                return false;
            }
        }


        public async Task<bool> ArchiveSessionToDirectory(string directoryPath, string SessionIID, bool blnDeleteSessionFromDatabase)
        {
            try
            {
                Session session = await repoSession.Get(SessionIID, "Orders, Orders.Items");

                string SessionFileName = DRFile.GenerateFileName(session.StartDate, session.EndDate.Value, "xml");

                if (File.Exists(directoryPath + "\\" + SessionFileName))
                    return false;


                if (session.EndDate == null)
                {
                    session.EndDate = DateTime.Now;
                }
                if (await repoSession.Save(session) != null)
                {
                    if (DRFile.XmlSerialize(directoryPath + "\\" + SessionFileName, session, typeof(Session), false))
                    {
                        //This deletes the session from database all together
                        if (blnDeleteSessionFromDatabase)
                        {
                            await repoSession.Delete(SessionIID);
                        }
                        return true;
                    } else
                        return false;
                }   else 
                    return false;

            } catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }


        public async Task<bool> ReloadSessionFromDirectory(DateTime startDate, DateTime endDate)
        {
            try
            {
                string SessionFileName = DRFile.GenerateFileName(startDate, endDate, "xml");
                Session session =(Session)DRFile.XmlDeSerialize(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName, typeof(Session), false);
                if (await repoSession.Save(session) != null)
                {
                    File.Delete(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName);
                    return true;
                } else
                    return false;
            } catch
            {
                return false;
            }
        }

        public async Task<bool> ReloadSessionFromFile(string filename)
        {
            try
            {
                Session session= (Session)DRFile.XmlDeSerialize(filename, typeof(Session), false);
                if (await repoSession.Save(session) != null)
                {
                    File.Delete(filename);
                    return true;
                } else
                    return false;
            } catch
            {
                return false;
            }
        }



        public async Task<Session> GetLatestSession()
        {
            Session latestSession = await repoSession.GetDBContext().Database.SqlQuery<Session>($"select * from sessions where startdate in ( SELECT  Max(sessions.StartDate) AS Startdate FROM sessions)").FirstOrDefaultAsync();
            return await repoSession.Get(latestSession.IID);

            //DataTable dt = GetDataTable("GetLatestSession");
            //if (dt.Rows.Count > 0)
            //{
            //    string LatestSessionIID = dt.Rows[0]["IID"].ToString();

            //    return GetSessionDataDynamic(LatestSessionIID);
            //} else
            //    return null;
        }
        public DataTable GetAllOrdersForSessionDateOrderly(string SessionIID, OrderByTypes orderDirection)
        {
            string orderdir = "Asc";
            switch (orderDirection)
            {
                case OrderByTypes.Ascending:
                case OrderByTypes.None:
                    break;
                case OrderByTypes.Descending:
                    orderdir = "Desc";
                    break;
                default:
                    break;
            }
            return GetDataTable("SELECT * from OrdersView where SessionIID = '" + SessionIID + "'  Order by OrderDate " + orderdir);

        }


        /// <summary>
        /// Returns DataTable of SessionDataShort
        /// </summary>
        /// <returns></returns>
        public DataTable GetArchivedSessionDataTable(string sessionDirectory)
        {
            DataTable dt = GetSessionList();
            dt.Clear();

            CultureInfo culture = new CultureInfo("en-GB");

            string[] files = Directory.GetFiles(sessionDirectory);

            for (int i = 0; i < files.Length; i++)
            {
                DataRow dr = dt.NewRow();
                XmlTextReader myReader = new XmlTextReader(files[i]);

                bool blnContinue = true;
                while (myReader.Read() && blnContinue)
                {
                    if (myReader.NodeType == XmlNodeType.Element && myReader.LocalName.Equals("sessionData"))
                    {
                        while (myReader.Read())
                        {
                            if (myReader.LocalName.Equals("SessionIID"))
                                dr["IID"] = myReader.ReadString();
                            else if (myReader.LocalName.Equals("SessionStartDateTime"))
                                dr["StartDate"] = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("SessionEndDateTime"))
                                dr["EndDate"] = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("GrossSessionTotal"))
                                dr["GrossSessionTotal"] = double.Parse(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X1Total"))
                                dr["X1Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X2Total"))
                                dr["X2Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X3Total"))
                                dr["X3Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("Orders"))
                            {
                                blnContinue = false;
                                break;
                            }
                        }
                    }
                }
                myReader.Close();
                dt.Rows.Add(dr);

            }
            return dt;

        }

        public async Task<bool> StartNewSession()
        {
            try
            {

                //with Z report applied , a new session started
                Session TempSession = new Session();

                TempSession = await repoSession.Save(TempSession);
                shop.CurrentSessionIID = TempSession.IID;
                await repoShop.Save(shop);

                string sql = $"UPDATE Orders SET SessionIID = '{TempSession.IID}' WHERE Status < " + (int)StatusFlags.Completed;
                repoOrder.GetDBContext().Database.ExecuteSqlRaw(sql);
                return true;
            } catch
            {
                return false;
            }
        }


        /// <summary>
        /// This is only logical for current session
        /// </summary>
        /// <param name="SessionIID"></param>
        /// <returns></returns>
        public async Task<bool> PreserveSessionOrdesToX(string SessionIID)
        {
            //Move and delete Orders FROM orders and OrderItem table to xorders and xOrderItem table
            List<Order> orders = await repoOrder.GetListByField("SessionIID", SessionIID, "Items");

            foreach (var order in orders)
            {
                if (await repoXOrder.Save(order.ToXOrder()) == null)
                    return false;
            }
            return true;
        }

        public async Task<bool> GetXOrdersBackForSession(string SessionIID)
        {
            //Move and delete XOrders from xOrders and xOrderItem table to orders and orderitem table
            List<XOrder> xorders = await repoXOrder.GetListByField("SessionIID", SessionIID, "Items");

            foreach (var xorder in xorders)
            {
                if (await repoOrder.Save(xorder.ToOrder()) == null)
                    return false;
            }
            return true;
        }

       

        #endregion




        #region REPORT ADMIN SECTION

        /// <summary>
        /// Produces DataSet for given date range for sessions (which are in database already) in which session values summmarised 
        /// based on tax percentages of entity buttons and final inclusive tax in sessions sessionly and sum of periodically
        /// </summary>
        /// <param name="FirstStartDate"></param>
        /// <param name="LastEndDate"></param>
        /// <returns></returns>
        public DataSet GetTaxSummaryReport(DateTime FirstStartDate, DateTime LastEndDate)
        {
            DataSet ds = new DataSet();

            string dailysql =
                "select StartDate, EndDate, TaxPercent, TotalNoTax, NetTaxValue, GrossTotal from TaxSummary  Where startdate >= '" +
                UF.DatetimeToMSSqlDatetime(FirstStartDate) + "' and enddate <= '" +
                UF.DatetimeToMSSqlDatetime(LastEndDate) + "' order by startdate asc, TaxPercent asc";
            DataTable dtdailysql = GetDataTable(dailysql);
            dtdailysql.TableName = "Daily";
            ds.Tables.Add(dtdailysql);

            string percentsumsql =
                "select '', 'Sum of %', TaxPercent, sum(totalnotax) as TotalNoTax,  sum(nettaxvalue) as NetTaxValue,Payment, sum(grosstotal) as GrossTotal  from TaxSummary  Where startdate >= '" +
                UF.DatetimeToMSSqlDatetime(FirstStartDate) + "' and enddate <= '" +
                UF.DatetimeToMSSqlDatetime(LastEndDate) + "' group by taxpercent,payment order by taxpercent, payment";
            DataTable dtpercentsum = GetDataTable(percentsumsql);
            dtpercentsum.TableName = "Percent";
            ds.Tables.Add(dtpercentsum);

            string sumsql =
                "select '', 'Total','', sum(totalnotax) as TotalNoTax ,sum(nettaxvalue) as NetTaxValue,Payment, sum(grosstotal) as GrossTotal  from TaxSummary   Where startdate >= '" +
                UF.DatetimeToMSSqlDatetime(FirstStartDate) + "' and enddate <= '" +
                UF.DatetimeToMSSqlDatetime(LastEndDate) + "'  group by payment  order by  payment";
            DataTable dtsum = GetDataTable(sumsql);
            dtsum.TableName = "Sum";
            ds.Tables.Add(dtsum);


            return ds;
        }

        /// <summary>
        /// Produces CSV text for given date range for sessions (which are in database already) in which session values summmarised 
        /// based on tax percentages of entity buttons and final inclusive tax in sessions sessionly and sum of periodically
        /// </summary>
        /// <param name="FirstStartDate"></param>
        /// <param name="LastEndDate"></param>
        /// <returns></returns>
        public string GetTaxSummaryReportAsCSVString(DateTime FirstStartDate, DateTime LastEndDate)
        {
            using (DataSet ds = GetTaxSummaryReport(FirstStartDate, LastEndDate))
            {

                DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(null);
                exporter.GenerateFromDataTable(ds.Tables["Daily"], true, new CultureInfo(config.Database_Currency_Culture));
                exporter.NewLine();

                exporter.GenerateFromDataTable(ds.Tables["Percent"], false,
                    new CultureInfo(config.Database_Currency_Culture));
                exporter.NewLine();

                exporter.GenerateFromDataTable(ds.Tables["Sum"], false, new CultureInfo(config.Database_Currency_Culture));
                exporter.NewLine();

                return exporter.csvText;
            }
        }

        #endregion


        public async Task<OrderItem> DirectCreateTopOrderItemForOrder(Order order, string CategoryItemIID, bool blnSaveOrder = false)
        {
            CategoryItem eb = await GetJustEntityButton(CategoryItemIID);
            Category entity = await GetEntity(eb.CategoryIID);
            OrderItem oi = new OrderItem(order.IID,  POSLayer.Library.ShortGuid.NewGuid().ToString(), 1,
                UF.GetRelatedPrice(null, entity, eb, order),
                CategoryItemIID, eb.ItemName, entity.DistributionIID, OrderItemTypes.NormalOrderItem, 0,
                 order.Items.Count, GetEBTaxPercentForGenericOrder(order, eb));
            OrderItem thesameitem = order.Items.Find(x => x.CategoryItemIID == eb.IID && x.DistributionIID == eb.DistributionIID);
            if (thesameitem != null)
                thesameitem.Quantity++;
            else
                order.AddIncrementOrderItem(oi);
            if (blnSaveOrder)
                await SaveOrder(order);
            return oi;
        }
        public async Task<bool> DirectDeleteOrderItem(string orderItemIID)
        {
            return await RunQuery("DeleteOrderItem '" + orderItemIID + "'");
        }
        public async Task<bool> DirectIncrementOrderItem(string orderItemIID)
        {
            return await RunQuery("update orderitem set Quantity = Quantity + 1 where IID = '" + orderItemIID + "'");
        }
        public async Task<bool> DirectDecrementOrderItem(string orderItemIID)
        {
            await RunQuery("update orderitem set Quantity = Quantity - 1 where IID = '" + orderItemIID + "'");
            return await RunQuery("delete orderitem where Quantity = 0 and IID ='" + orderItemIID + "'");
        }

        public double GetOrderTotal(string orderIID)
        {
            return double.Parse(GetDataTable("Select CalculatedValue as Total from OrdersView where IID ='" +
                orderIID + "'").Rows[0]["Total"].ToString());
        }

        public bool HasPadItems()
        {
            try
            {
                return false;
                //int.Parse(
                //        GetDataTable(
                //            "select count(PadFlag) as PadItems from EntityButton where PadFlag > 0 and ParentMenuIID = '" +
                //            config.ActiveMenuIID + "'").Rows[0]["PadItems"].ToString()) > 0;
            } catch
            {
                return false;
            }
        }
        public double GetCurrentSessionXSum()
        {
            DataTable dt = GetDataTable("Select isnull(Sum(CalculatedValue),0) as Total from OrdersView where SessionIID = '" + shop.CurrentSessionIID + "'");
            return double.Parse(dt.Rows[0]["Total"].ToString());
        }

        public double GetSessionOrderSum(string SessionIID)
        {
            DataTable dt =
                GetDataTable("Select Sum(CalculatedValue) as Total from OrdersView where SessionIID = '" + SessionIID +
                                "'");
            return double.Parse(dt.Rows[0]["Total"].ToString());
        }

        public double GetSessionPaymentSum(string SessionIID, PaymentMethods paymentMethod)
        {
            DataTable dt =
                GetDataTable("Select Sum(CalculatedValue) as Total from OrdersView where SessionIID = '" + SessionIID +
                                "' and Payment = " + (int)paymentMethod);
            return double.Parse(dt.Rows[0]["Total"].ToString());
        }
        public void PrintImage(Bitmap b, string printerNetworkName)
        {
            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrintPage += (object printSender, PrintPageEventArgs printE) =>
                {
                    printE.Graphics.DrawImageUnscaled(b, new Point(0, 0));
                };

                using (PrintDialog dialog = new PrintDialog())
                {
                    dialog.ShowDialog();
                    pd.PrinterSettings = dialog.PrinterSettings;
                    pd.PrinterSettings.PrinterName = printerNetworkName;
                    pd.Print();
                }
            }
        }

        #region KITCHEN ORDERS

        public bool SaveKitchenOrder(KitchenOrder order)
        {
            return repoKitchenOrder.Save(order) != null;

            //if (RunQuery("SaveKitchenOrder '" + order.IID + "','" + order.Reference + "'," +
            //    DRDateTime.DatetimeToMSSql(order.CreatedDateTime) + ",'" + order.OrderIID + "'," +
            //    DRDateTime.DatetimeToMSSql(order.CompletedDateTime) + "," + (int)order.GetStatus() + "," + BoolToInt(order.BeingModified) + "," + (int)order.OrderType))
            //{
            //    bool test = true;
            //    for (int i = 0; i < order.items.Count; i++)
            //    {
            //        KitchenOrderItem koi = order.items[i];
            //        test = test && RunQuery("SaveKitchenOrderItem '" + koi.IID + "'," + koi.Quantity + ",'" +
            //            koi.ItemText + "','" + koi.KitchenOrderIID + "','" + koi.DistributionIID + "','" +
            //            koi.EntityButtonIID + "'," + (int)koi.Status);
            //        if (!test)
            //            return false;
            //    }
            //    return test;
            //} else
            //    return false;
        }
        public async Task<bool> DeleteKitchenOrder(string IID, bool blnForce)
        {
            if (blnForce)
            {
                await RunQuery("Delete from KitchenOrderItem where KitchenOrderIID ='" + IID + "'");
                await RunQuery("Delete from KitchenOrders where IID = '" + IID + "'");
            } else
                await RunQuery("DeleteKitchenOrder '" + IID + "'");
            return !IsKitchenOrderExist(IID);

        }
        public async Task DeleteRelatedKitchenOrderForceFully(string RealOrderIID)
        {
            DataTable dt = GetDataTable("Select * from KitchenOrders where OrderIID = '" + RealOrderIID + "'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    await DeleteKitchenOrder(dt.Rows[i]["IID"].ToString(), true);
            }
        }

        public bool IsKitchenOrderExist(string IID)
        {
            return GetDataTable("Select IID from KitchenOrders where IID = '" + IID + "'").Rows.Count > 0;
        }

        public bool IsKitchenOrderBeingModified(string IID)
        {
            try
            {
                return int.Parse(GetDataTable("Select BeingModified from KitchenOrders where IID = '" + IID + "'").Rows[0]["BeingModified"].ToString()) == 1;
            } catch
            {
                return false;
            }
        }

        /// <summary>
        /// if StepableOrderItemGroupIID == ""  all items are old so check if deletable
        /// if StepableOrderItemGroupIID == "a guid" than there are new items in order so check if this item is new  or not
        ///      new : deletable
        ///      old : check
        /// </summary>
        /// <param name="oi"></param>
        /// <returns></returns>
        public bool CanDeleteKitchenOrderItemIfPrepared(OrderItem oi)
        {
            //No need to check just delete
            if (!config.Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted)
                return true;

            //NEW item no problem just delete
            if (StepableOrderItemGroupIID == oi.OrderGroupIID)
                return true;

            if (StepableOrderItemGroupIID == "")
            {
                //all items must be checked if OrderGroupIID != StepableOrderItemGroupIID
                if (oi.OrderGroupIID == StepableOrderItemGroupIID)
                    return true;    //will never happen just logical sense for me
                else
                {
                    //old item check it
                    if (oi.CompletedQuantity > 0)
                        return false;
                    else
                        return true;
                }
            } else
            {
                //NEW item no problem just delete
                if (StepableOrderItemGroupIID == oi.OrderGroupIID)
                    return true;
                else
                {
                    //This is definatelly old item
                    if (oi.CompletedQuantity > 0)
                        return false;
                    else
                        return true;
                }
            }

        }



        public async Task<List<KitchenOrder>> GetKitchenOrderList()
        {
            return await repoKitchenOrder.GetAllAsync();
            //List<KitchenOrder> korderList = new List<KitchenOrder>();
            //DataTable dtKorder = GetDataTable("Select IID from KitchenOrders order by OrderNo");

            //for (int i = 0; i < dtKorder.Rows.Count; i++)
            //    korderList.Add(GetKitchenOrder(dtKorder.Rows[i]["IID"].ToString()));

            //return korderList;
        }

        public async Task<KitchenOrder> GetKitchenOrder(string IID)
        {
            return await repoKitchenOrder.Get(IID, "Items");
        }
        public async Task<List<KitchenOrder>> GetKitchenOrdersByStatus(KitchenOrderStatusTypes status, bool blnAscending, Distribution distribution)
        {
            string asctext = blnAscending ? "asc" : "desc";
            DataTable dt = null;
            if (distribution == null)
                return new List<KitchenOrder>();

            switch (status)
            {
                case KitchenOrderStatusTypes.All:
                    dt = GetDataTable("Select IID from KitchenOrders order by CreatedDateTime " + asctext);
                    break;
                case KitchenOrderStatusTypes.Waiting:
                    //waiting and partialycompleted
                    dt = GetDataTable("select IID from KitchenOrders where (status = 0 or status = 1) and " +
                        " IID in (select KitchenOrderIID from KitchenOrderItem where DistributionIID = '" +
                        distribution.IID + "' and status = 0) " + " order by CreatedDateTime " + asctext);

                    break;
                case KitchenOrderStatusTypes.Completed:
                    //partialycompleted and completed
                    dt = GetDataTable("select IID from KitchenOrders where (status = 1 or status = 2) and " +
                     " IID in (select KitchenOrderIID from KitchenOrderItem where DistributionIID = '" +
                     distribution.IID + "' and status = 2) " + " order by CompletedDateTime " + asctext);

                    break;
                case KitchenOrderStatusTypes.PartialyCompleted:
                    dt = GetDataTable("Select IID from KitchenOrders where status = " + (int)status + " order by CreatedDateTime " + asctext);
                    break;
            }

            List<KitchenOrder> theList = new List<KitchenOrder>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                theList.Add(await GetKitchenOrder(dt.Rows[i]["IID"].ToString()));
            }

            return theList;
        }

        public KitchenOrder ConvertOrderToKitchenOrder(Order order)
        {
            KitchenOrder korder = new KitchenOrder
            {
                Reference = order.Reference,
                CreatedDateTime = DateTime.Now,
                OrderIID = order.IID
            };

            for (int i = 0; i < order.Items.Count; i++)
            {
                KitchenOrderItem korderitem = new KitchenOrderItem
                {
                    CategoryItemIID = order.Items[i].CategoryItemIID,
                    Quantity = (int)order.Items[i].Quantity,
                    ItemText = order.Items[i].OrderItemText,
                    KitchenOrderIID = korder.IID,
                    DistributionIID = order.Items[i].DistributionIID
                };
                korder.Items.Add(korderitem);
            }
            return korder;
        }

        public async void SetKitchenOrderModifiedStateForAttachedOrder(bool blnBeingModified)
        {
            try
            {
                if (((AttachedOrder.Status == StatusFlags.Done || AttachedOrder.Status == StatusFlags.Holding) &&
                        (config.Table_Orders_Display_Kitchen_Orders || config.Hold_Order_Display_in_Kitchen)) ||
                        (!blnBeingModified && AttachedOrder.Status == StatusFlags.Completed))
                {
                    await repoKitchenOrder.GetDBContext().KitchenOrders.Where(x => x.OrderIID == AttachedOrder.IID).ForEachAsync(x => x.BeingModified = blnBeingModified);
                    //RunQuery("Update KitchenOrders set BeingModified = " + BoolToInt(blnBeingModified) + " where OrderIID ='" + AttachedOrder.IID + "'");
                    await SetKitchenModified();
                }
            } catch (Exception ex)
            {
               await  SaveDebug("157 : " + ex.Message);
            }
        }
        public async Task<bool> ShrinkKitchenOrderList()
        {
            DataTable dt = GetDataTable("Select IID from KitchenOrders where Status = " + (int)KitchenOrderStatusTypes.Completed);
            if (dt.Rows.Count <= config.Kitchen_Max_Completed_Order_Count)
                return false;

            int topCount = dt.Rows.Count - config.Kitchen_Max_Completed_Order_Count;
            dt = GetDataTable("Select Top " + topCount + " IID from KitchenOrders where Status = " +
                (int)KitchenOrderStatusTypes.Completed + " order by CompletedDateTime asc");
            for (int i = 0; i < dt.Rows.Count; i++)
                await DeleteKitchenOrder(dt.Rows[i]["IID"].ToString(), false);

            return true;
        }

        public DateTime GetKitchenModified()
        {
            try
            {
                return shop.KitchenModified;
            } catch { }
            return DateTime.Now;
        }
        public async Task<bool> SetKitchenModified()
        {
           return await  repoKitchenOrder.GetDBContext().Database.ExecuteSqlRawAsync("update Shops set KitchenModified = GETDATE()") > 0;
            //return RunQuery("update Luv set KitchenModified = GETDATE()");
          //  return await RunQuery("UpdateKitchenModified");
        }

        public async Task<bool> CleanKitchenOrdersHasNoParentOrder()
        {
            return await RunQuery("CleanKitchenOrdersHasNoParentOrder");
        }
        #endregion



        public async Task<List<Supplier>> GetAllSuppliersAsList()
        {
            return await repoSupplier.GetAllAsync();
        }


        #region STOCK ITEM
        public async Task<StockItem> GetStockItem(string IID)
        {
            return await repoStockItem.Get(IID);
            // return new StockItem(GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on Supplier.IID = StockItem.SupplierIID  where StockItem.IID = '" + IID + "'"));
        }


        /// <summary>
        /// Uses net quantity, it expects converted value
        /// </summary>
        /// <param name="StockItemIID"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateStockItemUsedQuantity(string StockItemIID, int quantity)
        {
            return await RunQuery("update stockItem set UsedQuantity = UsedQuantity + " + quantity + " where IID = '" + StockItemIID + "'");
        }



        /// <summary>
        /// Give Quantity, it uses conversion itself  1 for 1 crate of (24) bottles for example, pass negative value if need to remove from stock
        /// </summary>
        /// <param name="stockItemIID"></param>
        /// <param name="Quantity">Create quantity 1 for 24 luk kasaya mesela</param>
        /// <returns></returns>
        public async Task<bool> BifileStockItem(string stockItemIID, int Quantity)
        {
            return await RunQuery("update stockitem set UsedQuantity = (UsedQuantity - (" + Quantity + " * Conversion)) where IID = '" + stockItemIID + "'");
        }

        public async Task<bool> SetStockItemQuantity(string stockItemIID, int Quantity)
        {
            return await RunQuery("update stockItem set UsedQuantity = " + Quantity + " where IID = '" + stockItemIID + "'");
        }

        #endregion

        #region EB  STOCKITEM FUNCTIONS


       

        public bool PrintDataTable(Printer printer, DataTable dt, string CustomReportName, List<int> columnSize, bool blnIncludeHeaders)
        {

            if (printer != null)
            {
                return new ReportGenerator(printer, 2, printLogo).PrintDataTable(dt, CustomReportName, columnSize, blnIncludeHeaders);
            }

            return false;
        }

        public List<int> GetColumnPrintRatio(DataGridView dgv)
        {
            int totalwidth = 0;
            List<int> columnSize = new List<int>();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    columnSize.Add(dgv.Columns[i].Width);
                    totalwidth += dgv.Columns[i].Width;
                }
            }
            int max_numberofcharacters = config.GetFontMaximumCharacter(config.ReportFontSize);
            for (int i = 0; i < columnSize.Count; i++)
                columnSize[i] = (int)Math.Round((double)columnSize[i] / (totalwidth / max_numberofcharacters));
            //columnSize[i] = (int)Math.Round((double)columnSize[i] / (totalwidth / 45));
            return columnSize;
        }

        /// <summary>
        /// Returns csv text to be saved as csv file
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string GenerateCsvTextFromDataTable(DataTable dt)
        {
            // DataSet ds = new DataSet();

            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(null);
            exporter.GenerateFromDataTable(dt, true, new CultureInfo(config.Database_Currency_Culture));
            exporter.NewLine();
            return exporter.csvText;
        }


        #endregion


        #region DiSPLAY IMAGE FUNCTIONS

        public async Task<GenericImage> GetGenericImage(string ReferenceIID)
        {
            return await repoImage.GetByField("ReferenceIID", ReferenceIID);

        }

        public async Task<GenericImage> GetCategoryItemPrepImage(string CategoryItemIID)
        {
            GenericImage gim = await GetGenericImage(CategoryItemIID);
            if (gim == null)
                return null;

            gim.ExtraText = GetCategoryItemStockItemText(CategoryItemIID) + gim.ExtraText;
            return gim;
        }
        public async Task<string> GetCategoryItemStockItemText(string CategoryItemIID)
        {
            List<RecipeItem> recipeItems = await repoRecipeItem.GetListByField("CategoryItemIID", CategoryItemIID, "StockItem");
            string str = "";
            foreach (var item in recipeItems)
            {
                if (item.Quantity == 0)
                {
                    str += item.Comment; 
                    str += "\r\n";
                } else
                {
                    str += item.Comment + " ";
                    str += item.StockItemName ?? "";
                    str += "\r\n";
                }
            }
            return str;
        }



        /// <summary>
        /// Send directoryinfo fullName to folderpath
        /// </summary>
        /// <param name="folderpath"></param>
        /// <returns></returns>
        public async Task<bool> ExportDatabaseImagesIntoFolder(string folderpath)
        {
            try
            {
                List<GenericImage> images = await repoImage.GetAllAsync();
                foreach (var item in images)
                {
                    string filename = folderpath + "\\" + item.ReferenceIID + ".png";
                    File.WriteAllBytes(filename, item.DisplayImage);
                }
                //DataTable dt = GetDataTable("Select * from Images");
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    GenericImage gim = new GenericImage(dt.Rows[i]);
                //    string filename = folderpath + "\\" + gim.ReferenceIID + ".png";
                //    gim.DisplayImage.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                //}
                return true;
            } catch
            {
                return false;
            }
        }

        #endregion

        public bool HasActiveHoldOrders()
        {
            DataTable dt = GetDataTable("Select count(IID) as howmany from Orders where OrderType =" + (int)OrderTypes.Sale + " and status = " + (int)StatusFlags.Holding);
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        public bool HasActiveTableOrders()
        {
            DataTable dt = GetDataTable("Select count(IID) as howmany from Orders where OrderType =" +
                (int)OrderTypes.Sitin + " and  (status = " + (int)StatusFlags.New + " or status = " + (int)StatusFlags.Done + ")");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        /// <summary>
        /// At least there should be 1 completed order, Only checks the completed orders not concern about archived orders
        /// </summary>
        /// <returns></returns>
        public bool HasCurrentSessionCompletedOrders()
        {
            DataTable dt = GetDataTable("Select count(IID) as howmany from Orders where status = " +
                (int)StatusFlags.Completed + " and SessionIID ='" + shop.CurrentSessionIID + "'");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }



        #region BACKUP FUNCTIONS
        public async Task<DatabaseBackup> GetDatabaseBackup(DatabaseBackupOptions options)
        {
            try
            {
                DatabaseBackup backup = new DatabaseBackup();

                if (options.includeCustomers)
                    backup.customerList = await repoCustomer.GetAllAsync();

                if (options.includeUsers)
                    backup.userList = await repoUser.GetAllAsync();

                //Load Printer List
                if (options.includePrinters)
                    backup.printerList = await GetApplicationPrinterList();

                if (options.includeShop)
                    backup.shop = await repoShop.GetFirst();

                if (options.includeCurrentSession)
                {
                    backup.currentSession = await repoSession.Get(shop.CurrentSessionIID);
                    //DataTable dtCurrentSession = GetDataTable("Select * from Sessions where IID = '" + shop.CurrentSessionIID + "'");
                    //backup.currentSession = new SessionData(dtCurrentSession);
                }

                if (options.includeTables)
                {
                    backup.tableList = await repoTable.GetAllAsync();
                }

                if (options.includeMenus)
                    backup.menuList = await repoMenu.GetAllAsync();

                //Load Stock Manager
                if (options.includeStock)
                    backup.stockManager = await GetStockManager();

                //Load Orders
                if (options.includeOrders)
                    backup.orderList = await GetOrderList();

                //Load XOrders
                if (options.includeXOrders)
                    backup.xorderList = await GetXOrderList();

                //Load Kitchen Orders
                if (options.includeKitchenOrders)
                    backup.kitchenOrderList = await GetKitchenOrderList();

                //Load Debug Information
                if (options.includeDebugInformation)
                    backup.debugList = await GetDebugList();

                //Load Image Library
                //if (options.includeImages)
                //    backup.imageList = await GetImageLibraryList();

                return backup;
            } catch
            {
                return null;
            }
        }

        public async Task<StockManager> GetStockManager(int startfrom = 0)
        {
            StockManager sm = new StockManager();

            sm.Suppliers = await repoSupplier.GetAllAsync();
            sm.Recipes = await repoRecipeItem.GetAllAsync();
            sm.StockItems = await repoStockItem.GetAllAsync();

            return sm;
        }

        public async Task<bool> SaveStockManager(StockManager sm)
        {
            foreach (var supplier in sm.Suppliers)
            {
                await repoSupplier.Save(supplier);
            }
            foreach (var stockItem in sm.StockItems)
            {
                await repoStockItem.Save(stockItem);
            }
            foreach (var item in sm.Recipes)
            {
                await repoRecipeItem.Save(item);
            }
            return true;
        }
        public async Task<bool> SaveAllRecipes(List<RecipeItem> recipes)
        {
            try
            {
                foreach (RecipeItem recipe in recipes)
                {
                    await repoRecipeItem.Save(recipe);
                }
                return true;
            } catch
            {
                return false;
            }

        }


        #endregion

        #region BONUS FUNCTIONS            

        public async Task<bool> SetBonus(string BonusIID)
        {
            try
            {
                shop.BonusIID = BonusIID;
                await repoShop.Save(shop);
                shop = await repoShop.Get(config.ShopIID,"Bonus");
                return true;
            } catch
            {
                return false;
            }
        }
        public async void SetSuitableBonus()
        {
            Bonus candidate = await GetSuitableBonus();
            shop.BonusIID = candidate != null ? candidate.IID : "";
             await repoShop.Save(shop);
            shop = await repoShop.Get(config.ShopIID,"Bonus");
        }

        public async Task<Bonus> GetSuitableBonus()
        {
            WeekDays dayoftheweek = UF.GetTodaysDTRMWeekDay();
            List<Bonus> allBonus = await repoBonus.GetAllAsync();


            //Select Daily Available Bonuses
            List<Bonus> dailyAvailableBonusList = new List<Bonus>();
            foreach (Bonus bonus in allBonus)
            {
                if (DRNumeric.IsBitSet((int)bonus.DaysAvailable, (int)dayoftheweek))
                {
                    dailyAvailableBonusList.Add(bonus);
                }
            }

            //Select Hourly Available Bonuses
            List<Bonus> timelyAvailableBonusList = new List<Bonus>();
            TimeSpan NowTimeSpan = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            TimeSpan Midnight = new TimeSpan(23, 59, 59);
            foreach (Bonus bonus in dailyAvailableBonusList)
            {
                //Within the same day shifts (day shift)
                if (bonus.StartTime < bonus.EndTime)
                {
                    if (NowTimeSpan >= bonus.StartTime && NowTimeSpan <= bonus.EndTime)
                        timelyAvailableBonusList.Add(bonus);
                }
                //Within day over type, basically after 24:00 finishing shifts (night shift)
                if (bonus.StartTime > bonus.EndTime)
                {
                    if ((NowTimeSpan >= bonus.StartTime && NowTimeSpan <= Midnight) ||
                            (NowTimeSpan > new TimeSpan(0, 0, 0) && NowTimeSpan < bonus.EndTime))
                    {
                        timelyAvailableBonusList.Add(bonus);
                    }
                }

            }
            if (timelyAvailableBonusList.Count > 0)
                return timelyAvailableBonusList[0];
            else
            {
                if (dailyAvailableBonusList.Count > 0)
                    return dailyAvailableBonusList[0];
                else
                    return null;
            }

        }


        #endregion

        public DataTable GetIrrelevantUnpaidOrdersDB()
        {
            return GetDataTable("Select * from OrdersView where Payment =0 and Status = 5 and SessionIID != '" + shop.CurrentSessionIID + "'");
        }
        public DataTable GetRelevantUnpaidCreatedOrNewOrdersDB()
        {
            return GetDataTable("Select * from OrdersView where Payment =0 and (Status = 0 || Status = 1) and SessionIID == '" + shop.CurrentSessionIID + "'");
        }

    }
}
