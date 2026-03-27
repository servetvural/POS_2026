using System;
using System.Xml;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data;
using System.Globalization;
using PosLibrary;
using PosLibrary.DBSpace;
using System.Net.Mail;
using System.Drawing.Printing;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.DataProtection.Repositories;
using POSLayer.Repository.IRepository;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DTRMNS
{
    public class DTRMSimpleBusiness
    {
        public bool DBConnectionSuccessful { get; set; }
        public string DBConnectionError { get; set; }


        private PosConfig config;

        public Shop shop;
        public User LoggedUser;
        public Order AttachedOrder;
        public TheMenu ActiveMenu;

        public bool blnReportLockOn;
        public string ReportLockClientIP;
        public ConnectionStatus OfficeConnectionStatus = ConnectionStatus.Disconnected;
        public string SelectedOrderItemIID;

        public int ArchiveProgress;
        public int SessionLoadProgress;

        [System.Xml.Serialization.XmlIgnore]
        public Bitmap imgReportSnapShot;

        public string ApplicationVersion = "5.0.0.192";
        public int RequiredMdfFileVersion = 1016;

        public string StepableOrderItemGroupIID = "";

        public int maxHeight;

        public Bonus currentBonusScheme;

        private CultureInfo ci;


        private string connectionString { get; set; }

        public event GenericFunctionCall OrderLoaded;
        public void OnOrderLoaded()
        {
            this.OrderLoaded?.Invoke();
        }

        public event GenericFunctionCall OrderUnloaded;
        public void OnOrderUnloaded()
        {
            OrderUnloaded?.Invoke();
        }


        public event GenericFunctionCall DisplayOrder;
        public void OnDisplayOrder()
        {
            DisplayOrder?.Invoke();
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

        public readonly IServiceProvider sp;

        IRepository<Shop> repoShop;
        IRepository<Session> repoSession;
        IRepository<Employee> repoEmployee;
        IRepository<TheMenu> repoMenu;
        IRepository<User> repoUser;
        IRepository<Debug> repoDebug;
        IRepository<Category> repoCategory;
        IRepository<CategoryItem> repoCategoryItem;
        IRepository<Distribution> repoDistribution;
        IRepository<Printer> repoPrinter;
        IRepository<Order> repoOrder;
        IRepository<OrderItem> repoOrderItem;
        IRepository<Customer> repoCustomer;
        IRepository<Bonus> repoBonus;
        IRepository<KitchenOrder> repoKitchenOrder;
        IRepository<KitchenOrderItem> repoKitchenOrderItem;
        IRepository<Table> repoTable;
        IRepository<TableGroup> repoTableGroup;
        IRepository<XOrder> repoXOrder;
        IRepository<XOrderItem> repoXOrderItem;
        IRepository<Supplier> repoSupplier;
        IRepository<EntityButtonStockItemLookUp> repoEntityButtonStockItemLookUp;
        IRepository<StockItem> repoStockItem;
        IRepository<StockItemUsage> repoStockItemUsage;
        IRepository<GenericImage> repoImage;

        public DTRMSimpleBusiness(IServiceProvider _sp,
            PosConfig configAsService, IRepository<Shop> _repoShop,
            IRepository<Session> _repoSession,
            IRepository<Employee> _repoEmployee,
            IRepository<TheMenu> _repoMenu,
            IRepository<User> _repoUser, IRepository<Debug> _repoDebug,
            IRepository<Category> _repoCategory, IRepository<CategoryItem> _repoCategoryItem,
            IRepository<Distribution> _repoDistribution, IRepository<Printer> _repoPrinter,
            IRepository<Order> _repoOrder, IRepository<OrderItem> _repoOrderItem,
            IRepository<Customer> _repoCustomer, IRepository<Bonus> _repoBonus,
              IRepository<KitchenOrder> _repoKitchenOrder, IRepository<KitchenOrderItem> _repoKitchenOrderItem,
               IRepository<Table> _repoTable, IRepository<TableGroup> _repoTableGroup,
               IRepository<XOrder> _repoXOrder, IRepository<XOrderItem> _repoXOrderItem,
               IRepository<Supplier> _repoSupplier, IRepository<EntityButtonStockItemLookUp> _repoEntityButtonStockItemLookUp,
               IRepository<StockItem> _repoStockItem, IRepository<StockItemUsage> _repoStockItemUsage,
               IRepository<GenericImage> _repoImage)
        {
            sp = _sp;

            config = configAsService;
            repoShop = _repoShop;
            repoSession = _repoSession;
            repoEmployee = _repoEmployee;
            repoMenu = _repoMenu;
            repoUser = _repoUser;
            repoDebug = _repoDebug;
            repoCategory = _repoCategory;
            repoCategoryItem = _repoCategoryItem;
            repoDistribution = _repoDistribution;
            repoPrinter = _repoPrinter;
            repoOrder = _repoOrder;
            repoOrderItem = _repoOrderItem;
            repoCustomer = _repoCustomer;
            repoBonus = _repoBonus;
            repoKitchenOrder = _repoKitchenOrder;
            repoKitchenOrderItem = _repoKitchenOrderItem;
            repoTable = _repoTable;
            repoTableGroup = _repoTableGroup;
            repoXOrder = _repoXOrder;
            repoXOrderItem = _repoXOrderItem;
            repoSupplier = _repoSupplier;
            repoEntityButtonStockItemLookUp = _repoEntityButtonStockItemLookUp;
            repoStockItem = _repoStockItem;
            repoStockItemUsage = _repoStockItemUsage;

            repoImage = _repoImage;
        }

        public async Task<bool> IsLoginSuccess(string password)
        {
            User user = await GetUserByPassword(password);
            if (user != null)
            {
                LoggedUser = user;
                return true;
            } else
                return false;
        }
        public async Task<bool> IsAdmin(string password)
        {
            User user = await GetUserByPassword(password);
            if (user != null && user.IsManagerOrMore())
            {
                LoggedUser = user;
                return true;
            } else
                return false;
        }

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
                shop = await repoShop.GetFirst();
                ci = GetDBCulture();
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(config.Terminal_Currency_Culture);
            } catch
            {
                return false;
            }

            ReportLockClientIP = "";

            if (ActiveMenu == null)
                GetActiveMenu(false, true);
            EnsureSessionData(); //Load SessionData from database

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
            for (int i = 0; i < order.items.Count; i++)
            {
                oi = (OrderItem)order.items[i];
                oi.Price = fm.GetItemPrice(oi.EntityIID, oi.EntityButtonIID, orderType);

            }
        }

        public void ReTaxOrderForOrderType(Order order, OrderTypes orderType)
        {
            TheMenu fm = ActiveMenu;
            OrderItem oi;
            for (int i = 0; i < order.items.Count; i++)
            {
                oi = (OrderItem)order.items[i];
                oi.TaxPercent = fm.GetItemTaxRate(oi.EntityIID, oi.EntityButtonIID, orderType);

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

                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(dt); // Fills the table in one go
                    return dt;
                }
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


        #region "USER FUNCTIONS"

        public async void EnsureRequiredUsers()
        {
            await SaveUser(new User("1", "Waiter", "1", AccessLevels.User));
            await SaveUser(new User("2", "Manager", "2", AccessLevels.Manager));
            await SaveUser(new User("3", "Admin", "9999", AccessLevels.SuperUser));
            await SaveUser(new User("4", "Tech", "2020", AccessLevels.TechnicalSupport));
        }

        public async Task<List<User>> GetUserList()
        {
            return await repoUser.GetAllAsync();
            //List<User> UserList = new List<User>();
            //DataTable dt = GetDataTable("GetAllUsers");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    UserList.Add(new User(dt.Rows[i]));
            //return UserList;
        }
        public async Task<User> GetUserByPassword(string Password)
        {
            return await repoUser.GetByField("Password", Password);
            //DataTable dt = GetDataTable("GetUserByPassword", Password);
            //if (dt.Rows.Count > 0)
            //    return new User(dt.Rows[0]);
            //else
            //    return null;
        }

        public async Task<User> GetUser(string UserIID)
        {
            return await repoUser.Get(UserIID);
            //DataTable dt = GetDataTable("GetUser", UserIID);
            //if (dt.Rows.Count > 0)
            //    return new User(dt.Rows[0]);
            //else
            //    return null;
        }

        public async Task<bool> SaveUser(User user)
        {
            return await repoUser.Save(user) != null;

            //return RunQuery("SaveUser '" + user.IID + "','" + user.UserName + "','" +
            //                   user.UserPassword + "'," + (int)user.AccessLevel);
        }

        public async Task<bool> DeleteUser(string UserIID)
        {
            return await repoUser.Delete(UserIID) > 0;
            //RunQuery("DeleteUser", UserIID);
        }

        #endregion

        #region "ENTITY FUNCTIONS"

        public TheMenu GetActiveMenu(bool blnReloadConfig, bool blnReloadMenu)
        {
            if (blnReloadMenu)
            {
                if (blnReloadConfig)
                    config = UF.GetConfig();
                //Get and load active menu 
                if (config.ActiveMenuIID == null || config.ActiveMenuIID == "")
                {
                    string firstMenuIID = GetFirstMenuIID();
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

        public void SaveMenuA(TheMenu foodMenu)
        {
            DRFile.XmlSerialize(DRFile.GetApplicationPath() + foodMenu.GetMenuFileName(), foodMenu,
                typeof(TheMenu), false);
        }

        public async Task<List<TheMenu>> GetMenuList()
        {
            List<TheMenu> menuList = await repoMenu.GetAllAsync();
            return menuList;
            //if (config != null)
            //{
            //    DataTable dt = GetDataTable("GetMenuList");
            //    dt.Columns.Add("IsActiveMenu");
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i]["IID"].ToString() == config.ActiveMenuIID)
            //            dt.Rows[i]["IsActiveMenu"] = true;
            //    }
            //    return dt;
            //} else
            //{
            //    return null;
            //}
        }

        public bool IsMenuExist(string MenuIID)
        {
            return repoMenu.Get(MenuIID) != null;
            // return repoMenu.GetDBContext().Menus.Any(x => x.IID == MenuIID);
            //DataTable dt = GetDataTable("Select * from Menu where IID = '" + MenuIID + "'");
            //return dt.Rows.Count > 0;
        }

        public string GetFirstMenuIID()
        {
            TheMenu menu = repoMenu.GetAllAsync().Result.FirstOrDefault();
            return menu?.IID ?? "";

            //DataTable dt = GetDataTable("GetMenuList");
            //if (dt.Rows.Count == 0)
            //    return "";
            //else
            //    return dt.Rows[0]["IID"].ToString();
        }

        public async Task<List<TheMenu>> GetMenuListDB()
        {
            return await repoMenu.GetAllAsync();
            //DataTable dt = GetDataTable("GetMenuList");
            //List<FMenu> MenuList = new List<FMenu>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    FMenu fm = new FMenu(dt.Rows[i]["IID"].ToString())
            //    {
            //        MenuName = dt.Rows[i]["MenuName"].ToString()
            //    };
            //    MenuList.Add(fm);
            //}
            //return MenuList;
        }

        /// <summary>
        /// Returns list of menus in the database. Menus have all the entities and entity buttons in it
        /// </summary>
        /// <returns></returns>
        public async Task<List<TheMenu>> GetAllMenuList(GenericProgressFunction progress = null, int startfrom = 0)
        {
            return await repoMenu.GetAllAsync("Entity");
            //DataTable dt = GetDataTable("GetMenuList");
            //List<FMenu> MenuList = new List<FMenu>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    string IID = dt.Rows[i]["IID"].ToString();
            //    MenuList.Add(GetMenuDB(IID));
            //    progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            //}
            //return MenuList;
        }

        public async Task<double> GetOrdersTotalForPaymentMethod(string sessionIID, PaymentMethods payment)
        {
            List<OrdersView> orders = await repoOrder.GetOrdersView();

            //DataTable dt = GetDataTable("Select isnull(sum(CalculatedValue),0) as Total from OrdersView where SessionIID = '" + sessionIID + "'  and (OrdersView.Status = 3 or OrdersView.Status = 4) and Payment = " + (int)payment);
            //return float.Parse(dt.Rows[0]["Total"].ToString());

            return orders.Where(x => x.SessionIID == sessionIID && (x.Status == StatusFlags.COMPLETED || x.Status == StatusFlags.ARCHIVED) && x.Payment == payment).Sum(x => x.CalculatedValue);
        }

        public async Task<List<Debug>> GetDebugList()
        {
            return await repoDebug.GetAllAsync();

            //List<Debug> theList = new List<Debug>();
            //DataTable dt = GetDataTable("Select * from Debug order by EventDateTime");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    theList.Add(new Debug(dt.Rows[i]));
            //}
            //return theList;
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

        /// <summary>
        /// Saves only menu's name
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public async Task<bool> SaveMenu(TheMenu menu)
        {
            return await repoMenu.Save(menu) != null;

            // return RunQuery("SaveMenu '" + menu.IID + "','" + menu.MenuName + "'");
        }


        /// <summary>
        /// Saves the entire menu
        /// </summary>
        /// <param name="foodMenu"></param>
        public async Task<bool> SaveMenuDB(TheMenu foodMenu)
        {
            return await repoMenu.Save(foodMenu) != null;

            ////This only saves the foodMenu entry in foodMenu table
            //RunQuery("SaveMenu '" + foodMenu.IID + "','" + foodMenu.MenuName + "'");

            ////Delete deleted Entities
            //DataTable dt = GetDataTable("GetEntitiesForMenu", foodMenu.IID);
            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    string DBEntityIID = dt.Rows[r]["IID"].ToString();
            //    bool blnEntityRequired = false;
            //    for (int i = 0; i < foodMenu.items.Count; i++)
            //    {
            //        if (((Entity)foodMenu.items[i]).IID == DBEntityIID)
            //        {
            //            blnEntityRequired = true;
            //            break;
            //        }
            //    }
            //    if (!blnEntityRequired)
            //        DeleteEntityDB(DBEntityIID);
            //    //Deletes Entity, its EntityButtons and all the entitybutton's priceitems
            //}
            ////Save this menu's entities
            //for (int i = 0; i < foodMenu.items.Count; i++)
            //    this.SaveEntityDB((Entity)foodMenu.items[i]);

            ////Delete distributions first
            //this.DeleteAllDistributionsForMenu(foodMenu.IID);

            ////Save this menu's global types
            //for (int i = 0; i < foodMenu.Distributions.Count; i++)
            //{
            //    Distribution distribution = foodMenu.Distributions[i];
            //    this.SaveDistribution(distribution);
            //}

            ////Re-Get the foodMenu from database
            //foodMenu = GetMenuDB(foodMenu.IID).Result;
            ////Now Save Serialized version
            //SaveMenuA(foodMenu);
        }

        public async Task<bool> DeleteMenuDB(string MenuIID)
        {
            return await repoMenu.Delete(MenuIID) > 0;
            //return RunQuery("DeleteMenu", MenuIID);
        }

        public async Task<Category> GetEntity(string EntityIID)
        {
            return await repoCategory.Get(EntityIID);
        }

        public async Task<List<Category>> GetAllEntities(string MenuIID)
        {
            return await repoCategory.GetDBContext().Categories.Where(x => x.MenuIID == MenuIID).ToListAsync();
        }
        //public async Task<Entity> GetEntity(string EntityIID)
        //{
        //    //DataRow dr = GetDataTable("GetEntity", EntityIID).Rows[0];
        //    return await repoEntity.Get(EntityIID, "Buttons");


        //    //DataTable dt = this.GetEntityButtonsForEntityDB(entity.IID);
        //    //for (int i = 0; i < dt.Rows.Count; i++)
        //    //{
        //    //    EntityButton eb = this.GetJustEntityButton(dt.Rows[i]["IID"].ToString()).Result;
        //    //    entity.Buttons.Add(eb);
        //    //    //progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
        //    //}
        //    //return entity;
        //}

        //public DataTable GetEntitiesForMenuDB(string ParentMenuIID)
        //{
        //    return GetDataTable("GetEntitiesForMenu", ParentMenuIID);
        //}

        public async Task<bool> SetEntityDisplayOrder(string EntityIID, int displayOrder)
        {
            return await RunQuery("Update Entity set DisplayOrder = " + displayOrder + " where IID = '" + EntityIID + "'");
        }

        public void SaveEntityDB(Category entity)
        {
            repoCategory.Save(entity);


            //CategoryItem eb = null;

            //DeleteEntityDB(entity.IID);
            //CultureInfo ci = GetDBCulture();
            ////This only saves the entity in the EntityTable
            //RunQuery("SaveEntity '" + entity.IID + "','" + entity.Name.Replace("'", "''") + "'," +
            //            entity.dorder + "," + entity.BgColour + "," + entity.Height + "," +
            //            entity.Width + ",'" + entity.MenuIID + "'," +
            //            (int)entity.EntityType + ",'" + entity.DistributionIID + "','" + entity.DistributionName + "','" +
            //            entity.FFamily + "','" + entity.FSize.ToString(ci) + "','" + entity.FStyle + "'," + entity.FgColour);



            //DataTable dt = this.GetEntityButtonsForEntityDB(entity.IID);
            //for (int r = 0; r < dt.Rows.Count; r++)
            //{
            //    string DBEntityButtonIID = dt.Rows[r]["IID"].ToString();
            //    bool blnEntityButtonRequired = false;
            //    blnEntityButtonRequired = entity.Buttons.Find(x => x.IID == DBEntityButtonIID) != null;

            //    if (!blnEntityButtonRequired)
            //        this.DeleteEntityButtonDB(DBEntityButtonIID);
            //}

            //for (int i = 0; i < entity.Buttons.Count; i++)
            //{
            //    eb = (CategoryItem)entity.Buttons[i];
            //    eb.dorder = i;
            //    this.SaveJustEntityButton(eb);
            //}
        }

        public async Task<bool> DeleteEntityDB(string EntityIID)
        {
            return await repoCategoryItem.GetDBContext().CategoryItems.Where(x => x.CategoryIID == EntityIID).ExecuteDeleteAsync() > 0;
            //DataTable dt = GetEntityButtonsForEntityDB(EntityIID);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    DeleteEntityButtonDB(dt.Rows[i]["IID"].ToString());
            //return RunQuery("DeleteEntity", EntityIID);
        }

        //public DataTable GetActiveEntityList()
        //{
        //    //This should call EntityList for active food Menu but as far as the server is concerned what is the active Menu?
        //    return GetDataTable("GetEntityListForMenu", ActiveMenu.IID);
        //}
        public double GetEBTaxPercent(CategoryItem eb)
        {
            if (AttachedOrder == null)
                return 0.0f;
            switch (AttachedOrder.OrderType)
            {
                case OrderTypes.DirectSale:
                    return eb.SaleTax;
                case OrderTypes.InHouse:
                    return eb.SitinTax;
                case OrderTypes.TakeAwayB:
                case OrderTypes.InternetTakeAway:
                    return eb.TaTax;
                case OrderTypes.Delivery:
                case OrderTypes.InternetDelivery:
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
                case OrderTypes.DirectSale:
                    return eb.SaleTax;
                case OrderTypes.InHouse:
                    return eb.SitinTax;
                case OrderTypes.TakeAwayB:
                case OrderTypes.InternetTakeAway:
                    return eb.TaTax;
                case OrderTypes.Delivery:
                case OrderTypes.InternetDelivery:
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

        public DataTable GetEntityButtonsForEntityDB(string PEIID)
        {
            return GetDataTable("GetEntityButtonsForEntity '" + PEIID + "'");
        }
        public DataTable GetEntityButtonsForEntityDBWithImage(string PEIID)
        {
            return GetDataTable("GetEntityButtonsForEntityWithImage '" + PEIID + "'");
        }
        public async Task<bool> SetEntityButtonDisplayOrder(string EBIID, int displayOrder)
        {
            return  await RunQuery("Update EntityButton set DisplayOrder = " + displayOrder + " where IID = '" + EBIID + "'");
        }

        public async Task<List<CategoryItem>> GetEntityButtonsForNumberPad()
        {
            return await repoCategoryItem.GetDBContext().Database.SqlQuery<CategoryItem>($"SELECT EntityButton.*, Entity.DistributionIID, Entity.EntityName FROM EntityButton LEFT OUTER JOIN Entity ON EntityButton.ParentEntityIID = Entity.IID WHERE  EntityButton.PadFlag > 0 and EntityButton.ParentMenuIID = '{config.ActiveMenuIID}' Order by Entitybutton.EntityButtonName").ToListAsync();
        }


        public async Task<bool> SaveJustEntityButton(CategoryItem entityButton)
        {
            return (await repoCategoryItem.Save(entityButton) != null);

            //CultureInfo dbci = GetDBCulture();
            //return
            //    RunQuery("SaveEntityButton '" + entityButton.IID + "','" +
            //                entityButton.EntityButtonName.Replace("'", "''") + "'," +
            //                entityButton.DisplayOrder + "," + entityButton.ButtonColor + "," + entityButton.ForeColor +
            //                "," +
            //                (int)entityButton.ButtonType + "," + entityButton.AvailableFor + ",'" +
            //                entityButton.ParentEntityIID + "','" + ParentMenuIID + "'," +
            //                entityButton.Compulsary + ",'" + entityButton.Barcode + "','" +
            //                entityButton.DirectSaleTaxPercent.ToString(dbci) + "','" +
            //                entityButton.InHouseTaxPercent.ToString(dbci) + "','" +
            //                entityButton.TakeAwayTaxPercent.ToString(dbci) + "','" +
            //                entityButton.DeliveryTaxPercent.ToString(dbci) + "'," +
            //                (int)entityButton.PadFlag + ",'" +
            //                entityButton.DistributionIID + "'," +
            //                entityButton.DirectSalePrice.ToString(dbci) + "," +
            //                entityButton.InHousePrice.ToString(dbci) + "," +
            //                entityButton.TakeAwayPrice.ToString(dbci) + "," +
            //                entityButton.DeliveryPrice.ToString(dbci) + "," +
            //                entityButton.ButtonWidth + "," +
            //                entityButton.ButtonHeight + ",'" +
            //                entityButton.FFamily + "','" +
            //                entityButton.FSize.ToString(dbci) + "','" +
            //                entityButton.FStyle + "'," +
            //                BoolToInt(entityButton.WithImage));
        }

        public void DeleteEntityButtonDB(string EntityButtonIID)
        {
            RunQuery("DeleteEntityButton '" + EntityButtonIID + "'");
        }
        //public DataTable GetEntityC(string EntityIID)
        //{
        //    return GetDataTable("GetEntity", EntityIID);
        //}

        public async Task<Category> GetJustEntity(string EntityIID)
        {
            return await repoCategory.Get(EntityIID);
            //return new Entity(GetEntityC(EntityIID));
        }

        #endregion

        #region EMPLOYEE FUNCTIONS
        public async Task<Employee> GetEmployee(string IID)
        {
            return await repoEmployee.Get(IID);
            //return new Employee(GetDataTable("GetEmployee", IID));
        }
        public async Task<List<Employee>> GetAllEmployeeList()
        {
            return await repoEmployee.GetAllAsync();

            //DataTable dt = GetDataTable("GetAllEmployees");
            //List<Employee> theList = new List<Employee>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    theList.Add(new Employee(dt.Rows[i]));
            //}
            //return theList.OrderBy(x => x.EmployeeName).ToList();
        }
        public bool SaveEmployee(Employee employee)
        {
            if (employee == null)
                return false;

            try
            {
                return (repoEmployee.Save(employee) != null);
                //RunQuery("SaveEmployee '" + employee.IID + "','" + employee.EmployeeName + "','" +
                //    employee.Rate + "'," + BoolToInt(employee.Shortable));
                //return true;
            } catch
            {
                return false;
            }
        }
        public void DeleteEmployee(string IID)
        {
            repoEmployee.Delete(IID);
            //RunQuery("DeleteEmployee", IID);
        }

        #endregion

        #region "CUSTOMER FUNCTIONS"

        public async Task<Customer> GetCustomer(string IID)
        {
            return await repoCustomer.Get(IID);
            //return new Customer(GetDataTable("GetCustomer", IID));
        }

        //public DataTable GetAllCustomers()
        //{

        //    return GetDataTable("GetAllCustomers");
        //}
        public bool SaveCustomer(Customer customer)
        {

            if (customer == null)
                return false;

            return (repoCustomer.Save(customer) != null);

            //try
            //{
            //    RunQuery("SaveCustomer '" + customer.IID + "','" + customer.CName + "','" + customer.CompanyName +
            //                "','" +
            //                customer.Buzzer + "','" + customer.PostCode + "','" + customer.Address + "','" +
            //                customer.Town + "','" + customer.Tel + "','" + customer.Mobile + "','" +
            //                customer.Email + "','" + customer.CPassword + "'");
            //    return true;
            //} catch
            //{
            //    return false;
            //}
        }
        public void DeleteCustomer(string IID)
        {
            repoCustomer.Delete(IID);
            //Check order table if this Customer IID repeated more than once do not delete customer 
            // RunQuery("DeleteCustomer", IID);
        }

        public async Task<List<Customer>> SearchCustomersByName(string CName)
        {
            return await repoCustomer.GetDBContext().Database.SqlQuery<Customer>($"SELECT * from Customer where CName like '%{CName}%'").ToListAsync();
            //return GetDataTable("SearchCustomersByName", CName);
        }

        public async Task<List<Customer>> SearchCustomersByAddress(string CAddress)
        {
            return await repoCustomer.GetDBContext().Database.SqlQuery<Customer>($"SELECT * from Customer where Address like '%{CAddress}%'").ToListAsync();
            //return GetDataTable("SearchCustomersByAddress", CAddress);
        }

        public async Task<List<Customer>> SearchCustomersByTel(string CTelNumber)
        {
            return await repoCustomer.GetDBContext().Database.SqlQuery<Customer>($"SELECT * from Customer where Tel like '%{CTelNumber}%'   or Mobile like '%{CTelNumber}%'  or Email like '%{CTelNumber}%'").ToListAsync();
            //return GetDataTable("SearchCustomersByTel", CTelNumber);
        }

        public async Task<List<Customer>> SearchCustomersByPostCode(string CPostcode)
        {
            return await repoCustomer.GetDBContext().Database.SqlQuery<Customer>($"SELECT * from Customer where Postcode like '%{CPostcode}%'").ToListAsync();
            //return GetDataTable("SearchCustomersByPostCode", CPostCode);
        }

        public async Task<List<Customer>> SearchCustomersByEmail(string Email)
        {
            return await repoCustomer.GetDBContext().Database.SqlQuery<Customer>($"SELECT * from Customer where Email like '%{Email}%'").ToListAsync();
            //return GetDataTable("SearchCustomersByEmail", Email);
        }
        #endregion

        #region "TABLE FUNCTIONS"

        public DataTable GetAllTableGroups()
        {
            return GetDataTable("GetTableGroups");
        }

        public async Task<TableGroup> GetTableGroup(string IID)
        {
            return await repoTableGroup.Get(IID);
            // return new TableGroup(GetDataTable("GetTableGroup '" + IID + "'"));
        }

        public async Task<List<Table>> GetTableList(string GroupIID)
        {
            return await repoTable.GetListByField("GroupIID", GroupIID);
            //List<Table> TableList = new List<Table>();
            //DataTable dt = GetDataTable("GetTablesByGroup '" + GroupIID + "'");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    TableList.Add(new Table(dt.Rows[i]));
            //return TableList;
        }

        public async Task<bool> IsPrimaryTable(string TableIID)
        {
            Table table = await GetTable(TableIID);
            if (table == null)
                return false;
            return table.isPrimary;
        }
        public async Task<bool> HasSubTables(string TableIID)
        {
            Table table = await GetTable(TableIID);
            if (table.TableType == TableTypes.TemporaryTable)
            {
                TableIID = table.ParentTableIID;
                return true;
            }
            return GetDataTable("GetTableAndSubTables '" + TableIID + "'").Rows.Count > 1;
        }

        public async Task<Table> GetFirstSubTable(string TableIID, bool blnWithOrder)
        {
            try
            {
                Table table = await GetTable(TableIID);
                if (table.TableType == TableTypes.TemporaryTable)
                {
                    return table;
                } else
                {
                    Table subTable = await repoTable.GetDBContext().Tables.Where(x => x.ParentTableIID == TableIID).FirstOrDefaultAsync();

                    //DataTable dt = GetDataTable("Select * from Tables where ParentTableIID = '" + TableIID +
                    //                               "' order by DisplayOrder asc");
                    if (blnWithOrder)
                        return await BarrowTable(subTable.IID);
                    else
                        return subTable;
                }
            } catch
            {
                return null;
            }
        }
        public string GetFirstSubTableIID(string TableIID)
        {
            DataTable dt = GetDataTable("Select * from Tables where ParentTableIID = '" + TableIID +
                                                   "' order by DisplayOrder asc");
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["IID"].ToString();
            else
                return "";
        }

        public async Task<string> GenerateSubTableName(Table mainTable)
        {
            List<Table> subTableList = await GetTableAndSubTables(mainTable.IID);
            bool blnFound;// = false;

            for (int i = 65; i < 70; i++)
            {
                string str = ((char)i).ToString();
                blnFound = false;
                for (int x = 0; x < subTableList.Count; x++)
                {
                    if (subTableList[x].TableName == mainTable.TableName + str)
                    {
                        blnFound = true;
                        break;
                    }
                }
                if (!blnFound)
                {
                    return mainTable.TableName + str;
                }
            }
            return mainTable.TableName + "error";
        }

        public void GetRidOfBlankTemporaryTablesForThisTerminalWithNoOrders()
        {
            string sql = "Delete from Tables where TableType = '" + (int)TableTypes.TemporaryTable +
                         "' and CurrentOrderIID ='' and (LockedClientIP = '' or LockedClientIP = '" +
                         config.Terminal_Name + "')";
            RunQuery(sql);
        }

        public async Task<bool> AddSubTableWithTest(string rootTableIID)
        {
            if (string.IsNullOrEmpty(rootTableIID))
                return false;
            else
            {
                Table mainTable = await GetParentTable(rootTableIID);
                Table subTable = mainTable.CreateSubTable();
                subTable.TableName = await GenerateSubTableName(mainTable);
                return await SaveTable(subTable);
            }
        }
        public async Task<Table> AddSubTable(string rootTableIID)
        {
            if (string.IsNullOrEmpty(rootTableIID))
                return null;
            else
            {
                Table mainTable = await GetParentTable(rootTableIID);
                Table subTable = mainTable.CreateSubTable();
                subTable.TableName = await GenerateSubTableName(mainTable);
                if (await SaveTable(subTable))
                    return subTable;
                else
                    return null;
            }
        }
        public async Task<List<Table>> GetTableAndSubTables(string TableIID)
        {
            return await repoTable.GetDBContext().Tables.Where(x => x.IID == TableIID || x.ParentTableIID == TableIID).ToListAsync();
            //Table table = await GetTable(TableIID);
            //if (table.TableType == TableTypes.TemporaryTable)
            //    TableIID = table.ParentTableIID;

            ////GetTableAndSubTables
            //List<Table> TableList = new List<Table>();
            //DataTable dt = GetDataTable("GetTableAndSubTables '" + TableIID + "'");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    TableList.Add(new Table(dt.Rows[i]));
            //return TableList;
        }

        //public DataTable GetAllTables()
        //{
        //    return GetDataTable("GetAllTables");
        //}


        public async Task<Table> BarrowTable(string TableIID)
        {
            try
            {
                //Get Table 
                Table table = await GetTable(TableIID);

                if (table.IsBusy(config.Terminal_Name))
                    //if busy return null
                    return null;
                else
                {
                    if (!string.IsNullOrEmpty(table.CurrentOrderIID))
                    {
                        //if table has order attached to it
                        //set table ClientIP(busy), set table OrderIID(occupied) , set order tableIID, set order ClientIP (busy), 
                        Order order = await GetOrder(table.CurrentOrderIID);
                        order.TableIID = table.IID;
                        order.TableName = table.TableName;
                        order.LockedClientIP = config.Terminal_Name;
                        order.Title = "Table " + table.TableName + " C " + order.Covers.ToString();
                        table.CurrentOrderIID = order.IID;
                        table.LockedClientIP = config.Terminal_Name;
                        SaveOrder(order);
                        SaveTable(table);
                        table.AttachedOrder = order;
                        return table; //return table
                    } else
                    {
                        //create a new order
                        Order order = new Order(OrderTypes.InHouse)
                        {
                            //order.customer = new Customer();
                            TableIID = table.IID,
                            TableName = table.TableName,
                            LockedClientIP = config.Terminal_Name
                        };
                        order.Title = "Table " + table.TableName + " C " + order.Covers.ToString();
                        table.CurrentOrderIID = order.IID;
                        table.LockedClientIP = config.Terminal_Name;
                        SaveOrder(order);
                        SaveTable(table);
                        //retun table
                        table.AttachedOrder = order;
                        return table;
                    }
                }
            } catch
            {
                return null;
            }
        }

        ///Used to return an inhouse order
        public void ReturnTable(Table table)
        {

            if (table.AttachedOrder == null)
            {
                table.LockedClientIP = "";
                table.CurrentOrderIID = "";
                table.TableCovers = 1;
                SaveTable(table);
                return;
            }
            if ((int)table.AttachedOrder.Status >= (int)StatusFlags.COMPLETED)
            {
                //Temporary tables should be deleted, Order should be set free
                if (table.TableType == TableTypes.TemporaryTable)
                {
                    //Delete table
                    DeleteTable(table.IID);
                } else
                {
                    //unbusy table, delete order details from table
                    table.LockedClientIP = "";
                    table.CurrentOrderIID = "";
                    table.TableCovers = 1;
                    SaveTable(table);
                }
                //delete table details from order	
                table.AttachedOrder.TableIID = "";
            } else
            {
                if (table.AttachedOrder.items.Count > 0)
                {
                    //Order still active and has items so unbusy table, save table
                    table.LockedClientIP = "";
                    SaveTable(table);

                    //unbusy order, save order
                    table.AttachedOrder.LockedClientIP = "";
                    SaveOrder(table.AttachedOrder);
                } else
                {
                    //Temporary tables should be deleted, Order should be set free
                    if (table.TableType == TableTypes.TemporaryTable)
                    {
                        //Delete table
                        DeleteTable(table.IID);
                    } else
                    {
                        //unbusy table, delete order details from table
                        table.LockedClientIP = "";
                        table.CurrentOrderIID = "";
                        table.TableCovers = 1;
                        SaveTable(table);
                    }
                    DeleteOrderOnly(table.AttachedOrder);
                    //DeleteOrder(table.AttachedOrder.IID);
                }
            }
        }

        ///Used to return an inhouse order , this function is ONLY CALLED BY RETURN ORDER
        private async void ReturnTable(Order order)
        {
            Table table = await GetTable(order.TableIID);
            if (table == null)
                return;
            if ((int)order.Status >= (int)StatusFlags.COMPLETED)
            {
                //Temporary tables should be deleted, Order should be set free
                if (table.TableType == TableTypes.TemporaryTable)
                {
                    //Delete table
                    DeleteTable(table.IID);
                } else
                {
                    //unbusy table, delete order details from table
                    table.LockedClientIP = "";
                    table.CurrentOrderIID = "";
                    table.TableCovers = 1;
                    SaveTable(table);
                }
                //delete table details from order	
                order.TableIID = "";

                //unbusy order, save order
                order.LockedClientIP = "";
                SaveOrder(order);
            } else
            {
                if (order.items.Count > 0)
                {
                    //Order still active and has items so unbusy table, save table
                    table.LockedClientIP = "";
                    SaveTable(table);

                    //unbusy order, save order
                    order.LockedClientIP = "";
                    SaveOrder(order);
                } else
                {
                    //Temporary tables should be deleted, Order should be set free
                    if (table.TableType == TableTypes.TemporaryTable)
                    {
                        //Delete table
                        DeleteTable(table.IID);
                    } else
                    {
                        //unbusy table, delete order details from table
                        table.LockedClientIP = "";
                        table.CurrentOrderIID = "";
                        table.TableCovers = 1;
                        SaveTable(table);
                    }
                    DeleteOrderOnly(order);
                    //DeleteOrder(order.IID);
                }
            }
        }

        /// <summary>
        /// TABLE MOVE ACTION
        ///==========================
        ///parameter(primary or sub TableIID, primary)
        ///return (bool)
        /// 
        ///1-primary(NoSub)  => empty primary                 =>primary      primary               OrderTransfer
        ///     if (blnSourcePrimary && !blnSourceHasSubTables && blnTargetPrimary && blnTargetEmpty)
        ///2-primary(YesSub) => empty primary                 =>primary+sub  primary+sub           OrderTransfer for primary + TableTransfer for sub tables
        ///     if (blnSourcePrimary && blnSourceHasSubTables && blnTargetPrimary && blnTargetEmpty)
        ///3-primary(NoSub) => full primary(no sub tables)           =>primary      primary+sub           OrderTransfer    CreateSubTable
        ///     if (blnSourcePrimary && !blnSourceHasSubTables && blnTargetPrimary && !blnTargetEmpty && !blnTargetHasSubTables)
        ///4-primary(YesSub) => full primary(no sub tables)   =>primary+sub  primary+sub+sub       Transfer(with subs including source primary becomes sub)   CreateSubTable 
        ///     if (blnSourcePrimary && blnSourceHasSubTables && blnTargetPrimary && !blnTargetEmpty && !blnTargetHasSubTables)
        ///5-primary(NoSub) => full primary(with sub tables)         =>primary      primary+sub+sub       Transfer    CreateSubTable
        ///     if (blnSourcePrimary && !blnSourceHasSubTables && blnTargetPrimary && !blnTargetEmpty && blnTargetHasSubTables)
        ///6-primary(YesSub) => full primary(with sub tables) =>primary+sub  primary+sub+sub+sub   Transfer(with subs including source primary becomes sub)    CreateSubTable
        ///     if (blnSourcePrimary && blnSourceHasSubTables && blnTargetPrimary && !blnTargetEmpty && blnTargetHasSubTables)
        ///7-sub => empty primary                             =>sub          primary               Transfer
        ///     if (!blnSourcePrimary && blnTargetPrimary && blnTargetEmpty)
        ///8-sub => full primary(no sub tables)               =>sub          primary+sub           Transfer    CreateSubTable
        ///     if (!blnSourcePrimary && blnTargetPrimary && !blnTargetEmpty && !blnTargetHasSubTables)
        ///9-sub => full primary(with sub tables)             =>sub          primary+sub+sub       Transfer    CreateSubTable
        ///     if (!blnSourcePrimary && blnTargetPrimary && !blnTargetEmpty && blnTargetHasSubTables)
        /// 
        /// </summary>
        /// <param name="sourceTableIID"></param>
        /// <param name="targetTableIID"></param>
        /// <returns></returns>
        public async Task<bool> MoveTable(string sourceTableIID, string targetTableIID, bool blnLeaveSubTables)
        {
            bool blnSourcePrimary;
            bool blnTargetPrimary;
            bool blnTargetEmpty;
            bool blnSourceHasSubTables;
            bool blnTargetHasSubTables;

            Table sourceTable = await GetTable(sourceTableIID);
            if (sourceTable.HasActiveOrder())
                sourceTable = await BarrowTable(sourceTableIID);
            else
                return false;
            Table targetTable = await GetTable(targetTableIID);
            if (targetTable.HasActiveOrder())
                targetTable = await BarrowTable(targetTableIID);
            blnSourcePrimary = sourceTable.TableType == TableTypes.StaticTable;
            blnSourceHasSubTables = await HasSubTables(sourceTableIID);
            blnTargetHasSubTables = await HasSubTables(targetTableIID);
            blnTargetPrimary = targetTable.TableType == TableTypes.StaticTable;
            blnTargetEmpty = !targetTable.HasActiveOrder();

            Order sourceOrder;
            //Order targetOrder;
            Table subTargetTable;


            if (blnSourcePrimary)
            {
                if (blnSourceHasSubTables)
                {
                    if (blnTargetPrimary)
                    {
                        if (blnTargetEmpty)
                        {
                            ///2-primary(YesSub) => empty primary                     =>primary+sub  primary+sub           OrderTransfer for primary + TableTransfer for sub tables
                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            AttachOrderToTable(sourceOrder, targetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            targetTable.TableName = sourceTable.TableName;

                            ReturnTable(sourceTable);
                            ReturnTable(targetTable);

                            if (blnLeaveSubTables)
                            {
                                //transfer first sub table to primary table
                                MoveTable(GetFirstSubTableIID(sourceTableIID), sourceTableIID, false);
                            } else
                            {
                                //attach subtable to new parent table
                                SetNewParentTableIIDForSubTables(sourceTableIID, targetTableIID);
                            }
                            return true;

                        } else
                        {
                            //if (blnTargetHasSubTables) {
                            ///6-primary(YesSub) => full primary(with sub tables) =>primary+sub  primary+sub+sub+sub   Transfer(with subs including source primary becomes sub)    CreateSubTable
                            ///4-primary(YesSub) => full primary(no sub tables)   =>primary+sub  primary+sub+sub       Transfer(with subs including source primary becomes sub)   CreateSubTable 

                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            //create new target table
                            subTargetTable = await AddSubTable(targetTableIID);
                            AttachOrderToTable(sourceOrder, subTargetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            subTargetTable.TableName = sourceTable.TableName;

                            ReturnTable(targetTable);
                            ReturnTable(sourceTable);
                            ReturnTable(subTargetTable);
                            if (blnLeaveSubTables)
                            {
                                //transfer first sub table to primary table
                                MoveTable(GetFirstSubTableIID(sourceTableIID), sourceTableIID, false);
                            } else
                            {
                                //attach subtable to new parent table
                                SetNewParentTableIIDForSubTables(sourceTableIID, targetTableIID);
                            }
                            return true;
                            //}
                        }
                    } else
                    {
                        MessageBox.Show("Not implemented 1");
                    }
                } else
                {
                    if (blnTargetPrimary)
                    {
                        if (blnTargetEmpty)
                        {
                            ///1-primary(NoSub)  => empty primary                     =>primary      primary               OrderTransfer
                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            AttachOrderToTable(sourceOrder, targetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            targetTable.TableName = sourceTable.TableName;

                            ReturnTable(sourceTable);
                            ReturnTable(targetTable);
                            return true;
                        } else
                        {
                            ///5-primary(NoSub) => full primary(with sub tables)         =>primary      primary+sub+sub       Transfer    CreateSubTable
                            ///3-primary(NoSub) => full primary(no sub tables)           =>primary      primary+sub           OrderTransfer    CreateSubTable

                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            //create new target table
                            subTargetTable = await AddSubTable(targetTableIID);
                            AttachOrderToTable(sourceOrder, subTargetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            subTargetTable.TableName = sourceTable.TableName;
                            if (CheckifPrimaryTableNameExist(subTargetTable.TableName))
                            {
                                EnsureSubTableHasUniqueName(subTargetTable);
                            }
                            ReturnTable(targetTable);
                            ReturnTable(sourceTable);
                            ReturnTable(subTargetTable);
                            return true;
                        }
                    } else
                    {
                        MessageBox.Show("Not implemented 2");
                    }
                }

            } else
            {
                if (blnTargetPrimary)
                {
                    if (blnTargetEmpty)
                    {
                        ///7-sub => empty primary                                     =>sub          primary               Transfer

                        sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                        sourceTable = MakeTableFreeFromOrder(sourceTable);

                        AttachOrderToTable(sourceOrder, targetTable);
                        //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                        targetTable.TableName = sourceTable.TableName;

                        ReturnTable(targetTable);
                        DeleteTable(sourceTableIID);

                        return true;
                    } else
                    {
                        ///9-sub => full primary(with sub tables)                 =>sub          primary+sub+sub       Transfer    CreateSubTable
                        ///8-sub => full primary(no sub tables)                   =>sub          primary+sub           Transfer    CreateSubTable
                        //attach subtable to new parent table
                        ChangeParentTableIIDForSubTable(sourceTableIID, targetTableIID);
                        sourceTable = await BarrowTable(sourceTableIID);

                        //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                        // targetTable.TableName = sourceTable.TableName;

                        ReturnTable(sourceTable);
                        ReturnTable(targetTable);
                        return true;
                    }
                } else
                {
                    MessageBox.Show("Not implemented 3");
                }
            }
            return false;
        }

        private void EnsureSubTableHasUniqueName(Table t)
        {
            if (t == null)
                return;
            if (!t.isPrimary)
            {
                if (CheckifPrimaryTableNameExist(t.TableName))
                    t.TableName += t.TableName;
                //ChangeSubTableName(t, t.TableName + t.TableName);

            }
        }

        private bool CheckifPrimaryTableNameExist(string subName)
        {
            return GetDataTable("Select DefaultName from Tables where DefaultName = '" + subName + "'").Rows.Count > 0;
        }

        private Order MakeOrderFreeFromTable(Order order)
        {
            order.TableIID = "";
            order.TableName = "";
            order.LockedClientIP = "";
            return order;
        }

        private Order AttachOrderToTable(Order order, Table table)
        {
            order.TableIID = table.IID;
            order.TableName = table.TableName;
            table.AttachedOrder = order;
            table.CurrentOrderIID = order.IID;
            return order;
        }

        private Table MakeTableFreeFromOrder(Table table)
        {
            table.CurrentOrderIID = "";
            table.LockedClientIP = "";
            return table;
        }

        public async Task<bool> SetNewParentTableIIDForSubTables(string oldParentTableIID, string newParentTableIID)
        {
            return await RunQuery("update Tables set ParentTableIID ='" + newParentTableIID + "' where ParentTableIID ='" + oldParentTableIID + "'");
        }

        public async Task<bool> ChangeParentTableIIDForSubTable(string subTableIID, string newParentTableIID)
        {
            return await RunQuery("update Tables set ParentTableIID ='" + newParentTableIID + "' where IID ='" + subTableIID + "'");
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
            Table sourceTable = await BarrowTable(sourceTableIID);
            if (sourceTable.TableType == TableTypes.StaticTable)
            {
                ReturnTable(sourceTable);
                return false;
            }

            Table targetTable = await BarrowTable(targetTableIID);
            targetTable.AttachedOrder.MergeOrder(sourceTable.AttachedOrder);
            DeleteOrder(sourceTable.CurrentOrderIID);
            if (sourceTable.TableType == TableTypes.TemporaryTable)
                DeleteTable(sourceTableIID);
            else
                MakeTableFreeFromOrder(sourceTable);
            ReturnTable(targetTable);

            return true;
        }

        public async Task<Table> GetTable(string TableIID)
        {
            return await repoTable.Get(TableIID);
            //DataTable dt =await GetDataTable("GetTable", TableIID);
            //if (dt.Rows.Count > 0)
            //    return new Table(dt.Rows[0]);
            //else
            //    return null;
        }

        public async Task<Table> GetParentTable(string TableIID)
        {
            return await GetTable(TableIID);
            //if (testTable.TableType == TableTypes.StaticTable)
            //    return testTable;
            //else
            //    return GetTable(testTable.ParentTableIID);
        }

        public async Task<bool> SaveTable(Table table)
        {
            if (table.DefaultName == null)
                table.DefaultName = table.TableName;
            return await RunQuery("SaveTable '" + table.IID + "'," + table.Number + ",'" +
                               table.TableName + "'," + table.TableCovers + ",'" + table.LockedClientIP + "','" +
                               table.CurrentOrderIID + "'," + (int)table.TableType + "," + table.XLocation + "," +
                               table.YLocation +
                               "," + table.Width + "," + table.Height + ",'" + table.GroupIID + "','" +
                               table.ParentTableIID + "'," + (int)table.Shape + ",'" + table.DefaultName + "'");
        }

        public async Task DeleteTable(string TableIID)
        {
            await repoTable.Delete(TableIID);
            //RunQuery("DeleteTable", TableIID);
        }

        public async void FreeTheTable(string TableIID)
        {
            Table table = await GetTable(TableIID);
            if (table != null)
            {
                Order order = await GetOrder(table.CurrentOrderIID);
                if (order != null)
                {
                    if (order.items.Count == 0)
                        await DeleteOrderOnly(order);
                    else
                    {
                        order.TableIID = "";
                        order.LockedClientIP = "";
                        await SaveOrder(order);
                    }
                }
                if (table.TableType == TableTypes.TemporaryTable)
                    await DeleteTable(TableIID);
                else
                {
                    table.CurrentOrderIID = "";
                    table.LockedClientIP = "";
                    table.TableCovers = 1;
                    SaveTable(table);
                }
            }
        }

        #endregion

        #region "DISTRIBUTION FUNCTIONS"

        public async Task<List<Distribution>> GetDistributionList(string ActiveMenuIID)
        {
            return await repoDistribution.GetDBContext().Distributions.Where(x => x.MenuIID == ActiveMenuIID).OrderBy(x => x.DOrder).ToListAsync();
            //List<Distribution> DistributionList = new List<Distribution>();
            //DataTable dt = GetDataTable("GetDistributions", ActiveMenuIID);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    DistributionList.Add(new Distribution(dt.Rows[i]));
            //return DistributionList;
        }

        public async Task<List<Distribution>> GetAllDistributions()             
        {
            return await repoDistribution.GetAllAsync("Printer");
        }
        public async Task<List<Distribution>> GetAllDistributionsForMenu(string ActiveMenuIID)
        {
            return await repoDistribution.GetListByField("ParentMenuIID", ActiveMenuIID,includeItems: "Printer") ?? new();
        }

        public async Task<List<DistributionView>> GetAllDistributionsAsView()
        {
            return await repoDistribution.GetDistributionView();
            //return GetDataTable($"SELECT * FROM Distribution where ParentMenuIID = {ActiveMenuIID}  order by DisplayOrder");
        }

        public async Task<Distribution> GetDistribution(string DistributionIID)
        {
            return await repoDistribution.Get(DistributionIID);
            // return new Distribution(GetDataTable("GetDistribution", DistributionIID).Rows[0]);
        }

        public async  Task<bool> SaveDistribution(Distribution distribution)
        {
            return (await repoDistribution.Save(distribution) != null);
            //try
            //{
            //    return RunQuery("SaveDistribution '" + ft.IID + "','" + ft.DistributionName + "','" +
            //                       ft.ShortName + "','" + ft.PrinterIID + "','" + ft.ParentMenuIID + "'," + ft.DisplayOrder);
            //} catch
            //{
            //    return false;
            //}
        }

        public async Task<bool> DeleteDistribution(string DistributionIID)
        {
            return (await repoDistribution.Delete(DistributionIID) > 0);
            //return RunQuery("DeleteDistribution", DistributionIID);
        }

        public async Task<bool> DeleteAllDistributionsForMenu(string MenuIID)
        {
            return await repoDistribution.GetDBContext().Distributions.Where(x => x.MenuIID == MenuIID).ExecuteDeleteAsync() > 0;
            //return RunQuery("DeleteAllDistributionsForMenu", MenuIID);
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

        public async Task<OrdersView> GetOrderView(string IID)
        {
            return (await repoOrder.GetOrdersView()).Where(x => x.IID == IID).FirstOrDefault();
        }

        public bool isOrderPaid(string OrderIID)
        {
            try
            {
                DataTable dt = GetDataTable("select  cast((MoneyPaid - CalculatedValue) as decimal)  as isPaid from OrdersView where IID = '" + OrderIID + "'");
                string str = dt.Rows[0]["isPaid"].ToString();
                decimal val = decimal.Parse(str);
                return val >= 0;
            } catch
            {
                return false;
            }
        }
        public async Task<bool> SaveOrder(Order order)
        {
            CultureInfo ci = GetDBCulture();
            try
            {
                string OrderIID = order.IID;
                if (order.SessionIID == "" || order.SessionIID == null)
                    order.SessionIID = shop.CurrentSessionIID;

                if (await repoOrder.Save(order) != null)
                //RunQuery("SaveOrder  '" + order.IID + "','" + order.TableIID + "'," +
                //            DRDateTime.DatetimeToMSSql(order.OrderDate) + "," +
                //            order.Covers + "," + (int)order.OrderType + "," + (int)order.Payment + ",'" +
                //            order.CustomerIID + "','" + order.SessionIID + "'," + (int)order.Status + ",'" +
                //            order.LockedClientIP + "','" + order.Instruction + "'," + order.MoneyPaid.ToString(ci) +
                //            ",'" +
                //            order.PaymentFlag + "','" +
                //            order.TableName + "','" + order.CName + "','" + order.Postcode + "','" + order.Address +
                //            "','" + order.Buzzer + "','" +
                //            order.Town + "','" + order.Tel + "','" + order.Mobile + "','" + order.Email + "','" +
                //            order.UserName + "','" + order.Reference + "','" + order.ServiceChargeRate + "','" + order.ServiceChargeTaxRate + "'"))
                {

                    //for (int i = 0; i < order.items.Count; i++)
                    //    SaveOrderItem((OrderItem)order.items[i]);

                    //DataTable dtItems = this.GetAllOrderItems(order.IID);

                    //for (int i = dtItems.Rows.Count - 1; i >= 0; i--)
                    //{
                    //    OrderItem oi = order.GetOrderItem(dtItems.Rows[i]["IID"].ToString());
                    //    if (oi == null)
                    //        RunQuery("DeleteOrderItem", dtItems.Rows[i]["IID"].ToString());

                    //}
                    return true;
                } else
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
            using (trmSupervisorLogin frm = ActivatorUtilities.CreateInstance<trmSupervisorLogin>(sp))
            {
                return (frm.ShowDialog() == DialogResult.OK);
            }
        }

        public async Task<OrderItem> GetOrderItem(string IID)
        {
            return await repoOrderItem.Get(IID);
            //DataTable dt = GetDataTable("GetOrderItem", IID);
            //if (dt == null)
            //    return null;

            //return new OrderItem(dt.Rows[0]);
        }
        public async Task SaveOrderItem(OrderItem oi)
        {
            try
            {
                await repoOrderItem.Save(oi);
                //CultureInfo ci = GetDBCulture();
                //if (RunQuery("SaveOrderItem '" +
                //                oi.IID + "','" + oi.EntityIID + "','" + oi.OrderItemText + "'," + oi.Quantity + ",'" +
                //                oi.Price.ToString(ci) + "','" + oi.OrderGroupIID + "','" + oi.EntityButtonIID + "','" +
                //                oi.DistributionIID + "','" + oi.OrderIID + "'," + (int)oi.ItemType + "," +
                //                oi.DisplayOrder + ",'" +
                //                oi.EntityName + "'," + oi.EntityDisplayOrder + ",'" +
                //                oi.TaxPercent.ToString(ci) + "'," + oi.CompletedQuantity))
                //{

                //}
            } catch
            {
            }
        }

        public void SaveLogItem(LogItem log)
        {
            try
            {
                CultureInfo ci = GetDBCulture();
                string sql = "SaveLogItem '" + log.IID + "','" + log.OrderItemText + "'," + log.Quantity + ",'" +
                                log.Price.ToString(ci) + "','" + log.Reason.Replace("'", "''") + "'," +
                                DRDateTime.DatetimeToMSSql(log.EventDateTime) + ",'" +
                                log.ComputerName + "','" + log.OrderContent.Replace("'", "''") + "','" + log.Reference + "'";

                RunQuery(sql);
            } catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
        public DataTable GetAllLogItems()
        {
            try
            {
                return GetDataTable("Select *, (Quantity * price) as Total from LogItems order by EventDateTime");
            } catch
            {
                return null;
            }
        }

        public void DeleteLogItems(List<string> IIDList)
        {
            foreach (var IID in IIDList)
            {
                RunQuery("Delete From LogItems Where IID ='" + IID + "'");
            }
        }
        public void DeleteAllLogItems()
        {
            try
            {
                RunQuery("Delete From LogItems");
            } catch { }
        }




        public void ReturnOrder(Order order)
        {
            if (order.OrderType == OrderTypes.InHouse)
                this.ReturnTable(order);
            else
            {
                if (order.items.Count > 0)
                {
                    order.LockedClientIP = "";
                    order.TableIID = "";
                    SaveOrder(order);
                } else
                    DeleteOrder(order.IID);
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
                SaveOrder(order);
                return order;
            }
        }

        //private DataTable GetAllOrderItems(string OrderIID)
        //{
        //    return GetDataTable("GetAllOrderItems", OrderIID);
        //}


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

        #region "UTILITY FUNCTIONS"

        public static DialogResult MessageBoxDT(string Text, string Caption, DialogTypes DialogType)
        {
            using (trmYnc ync = new trmYnc(Text, Caption, DialogType))
            {
                return ync.ShowDialog();
            }
        }

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
        #endregion

        #region "INSTRUCTION FUNCTIONS"
        public async Task<Debug> GetDebug(int DebugNo)
        {
            try
            {
                return await repoDebug.GetByField("DebugNo", DebugNo);
                // return new Debug(GetDataTable("Select * from Debug where DebugNo = " + DebugNo));
            } catch
            {
                return null;
            }

        }

        //}
        public async Task<bool> SaveDebug(string data)
        {
            return await RunQuery("Insert into Debug (Data) values ('" + data.Replace("'", "''") + "')");
        }

        #endregion

        #region "SERVER PRINTER FUNCTIONS"

        public async Task<List<Printer>> GetAllPrinters()
        {
            return await repoPrinter.GetAllAsync();

            //List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            //DataTable dt = GetDataTable("Select * from PrinterView");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            //return PrinterList;
        }

        //public DataTable GetPrinterListDB()
        //{
        //    return GetDataTable("GetPrinterList", config.Terminal_Name);
        //}

        //public DataTable GetSystemPrinterListDB()
        //{
        //    return GetDataTable("GetSystemPrinterList");
        //}

        public async Task<List<Printer>> GetPrintersByPrinterType(PrinterTypes PrinterType)
        {
            return await repoPrinter.GetDBContext().Printers.Where(x => x.PrinterType == PrinterType).ToListAsync();
            //return GetDataTable("GetPrintersByPrinterType " + (int)PrinterType + ",'" +
            //                       config.Terminal_Name + "'," + BoolToInt(LoggedUser.IsManagerOrMore()));
        }

        public async Task<Printer> GetPrinterForClient(string PrinterIID)
        {
            return await repoPrinter.GetDBContext().Printers
                .Where(x => x.IID == PrinterIID && x.LocalTerminal == config.Terminal_Name).FirstOrDefaultAsync();
            //DataTable dt = GetDataTable("GetPrinterForClient '" + PrinterIID + "','" + config.Terminal_Name + "'");
            //if (dt.Rows.Count > 0)
            //    return new ApplicationPrinter(dt.Rows[0]);
            //else
            //    return null;
        }
        public async Task<Printer> GetPrinter(string PrinterIID)
        {
            return await repoPrinter.GetDBContext().Printers
        .Where(x => x.IID == PrinterIID).FirstOrDefaultAsync();

            //DataTable dt = GetDataTable("GetPrinter '" + PrinterIID + "'");
            //if (dt.Rows.Count > 0)
            //    return new ApplicationPrinter(dt.Rows[0]);
            //else
            //    return null;
        }

        public async Task<Printer> GetDefaultReceiptPrinter()
        {
            if (config.DTClientLocalReceiptPrinterIID != null && config.DTClientLocalReceiptPrinterIID != "")
                return await GetPrinterForClient(config.DTClientLocalReceiptPrinterIID);
            else
                return null;

        }

        public async Task<Printer> GetPrinterForOrderType(OrderTypes orderType)
        {
            switch (orderType)
            {
                case OrderTypes.DirectSale:
                case OrderTypes.InHouse:
                    return await repoPrinter.Get(config.DTClientLocalReceiptPrinterIID);
                case OrderTypes.Delivery:
                case OrderTypes.InternetDelivery:
                    return await repoPrinter.GetDBContext().Printers.Where(x => x.DeliveryPrinter && x.LocalTerminal == config.Terminal_Name).FirstOrDefaultAsync();
                case OrderTypes.TakeAwayB:
                case OrderTypes.InternetTakeAway:
                    return await repoPrinter.GetDBContext().Printers.Where(x => x.TakeAwayPrinter && x.LocalTerminal == config.Terminal_Name).FirstOrDefaultAsync();
                default:
                    return await repoPrinter.Get(config.DTClientLocalReceiptPrinterIID);
            }
        }
        public async Task<List<Distribution>> GetDistributionListForPrinter(string ApplicationPrinterIID)
        {
            MessageBox.Show("bslayer GetDistributionListForPrinter");
            return null;
          //  return await repoDistribution.GetDBContext().Distributions.Where(x => x.PrinterIID == ApplicationPrinterIID).ToListAsync();
        }

        public async Task<bool> SavePrinter(Printer ap)
        {
            return await repoPrinter.Save(ap) != null;
        }
        public async Task<bool> SaveUniquePrinter(string PrinterIID, OrderTypes orderType)
        {
            Printer printer = await repoPrinter.Get(PrinterIID);
            if (printer == null)
                return false;

            try
            {
                switch (orderType)
                {
                    case OrderTypes.Delivery:
                        printer.LocalTerminal = config.Terminal_Name;
                        printer.DeliveryPrinter = true;
                        break;
                    case OrderTypes.TakeAwayB:
                        printer.LocalTerminal = config.Terminal_Name;
                        printer.TakeAwayPrinter = true;
                        break;
                }
                return true;
            } catch
            {
                return false;
            }
        }

        public async Task DeletePrinter(string PrinterIID)
        {
            await repoPrinter.Delete(PrinterIID);
        }

        public async Task<List<Printer>> GetReceiptPrinterList()
        {
            return await repoPrinter.GetAllAsync();
        }

        #endregion

        #region "CASH DRAWER"
        public async Task<bool> OpenCashDrawer(bool blnAsFault)
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
        public async Task EnsureSessionData()
        {
            string SessionIID = (await repoShop.GetFirst())?.CurrentSessionIID;
            if (SessionIID == "" || !IsSessionExist(SessionIID))
                await StartNewSession();
        }

        public bool IsSessionExist(string SessionIID)
        {
            DataTable dt = GetDataTable("Select * from Sessions where IID = '" + SessionIID + "'");
            return (dt.Rows.Count > 0);
        }

        //public string GetCurrentSessionIID()
        //{
        //    DataTable dt = GetDataTable("GetLuv");
        //    if (dt.Rows.Count > 0)
        //    {
        //        if (dt.Rows[0]["CurrentSessionIID"] != null)
        //            return dt.Rows[0]["CurrentSessionIID"].ToString();
        //    }
        //    return "";
        //}

        public async Task<SessionData> GetCurrentSession()
        {
            return await GetSessionDataDynamic(shop.CurrentSessionIID);
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
                        new ReportGenerator(this, printerList[i], 2).PrintKitchen(korder);
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
                        new ReportGenerator(this, printerList[i], 2).PrintKitchen(korder);
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
                return new ReportGenerator(this, printer).PrintKitchen(korder, blnWithDetail);
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
            foreach (KitchenOrderItem item in korder.items)
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
                if (order.OrderType == OrderTypes.InHouse)
                    korder.Reference = order.TableName;



                using (frmPrep frm = ActivatorUtilities.CreateInstance<frmPrep>(sp, this, korder))
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

                    if (korder.items.Count > 0)
                    {
                        switch (order.OrderType)
                        {
                            case OrderTypes.DirectSale:
                                if ((order.Status == StatusFlags.NEW || order.Status == StatusFlags.PENDING) && config.Hold_Order_Print_in_Kitchen)
                                    PrintForKitchen(korder);
                                break;
                            case OrderTypes.InHouse:
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
                OrderItem oi = AttachedOrder.items.Find(x => x.EntityButtonIID == koi.EntityButtonIID);
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
                oldKitchenOrder.items.Clear();
                foreach (KitchenOrderItem item in newKOrder.items)
                {
                    item.KitchenOrderIID = oldKitchenOrder.IID;
                }
                oldKitchenOrder.items.AddRange(newKOrder.items);
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
            for (int i = 0; i < korder.items.Count; i++)
            {
                if (theList.Find(x => x.IID == korder.items[i].DistributionIID) == null)
                    theList.Add(await GetDistribution(korder.items[i].DistributionIID));
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
                await SaveOrder(order);
                if (SelectedPrinterIID != null)
                {
                    PrintReceipt(order.IID, await GetPrinterForClient(SelectedPrinterIID), NumberOfCopy);
                }
                return true;
            } catch
            {
                return false;
            }
        }

        /// NEW PRINT RECEIPT FUNCTIONS /////
        public int PrintReceipt(string orderiid, Printer printer, int NumberOfCopy)
        {
            ReportGenerator generator = new ReportGenerator(this, printer, 2);
            generator.PrintReceipt(orderiid);
            return generator.FinalLength;
        }

        public int PrintKassaReport(List<string> report, Printer printer, int NumberOfCopy)
        {
            ReportGenerator generator = new ReportGenerator(this, printer, 2);
            generator.PrintKassaReport(report);
            return generator.FinalLength;
        }


        public int ViewReceipt(Graphics g, string orderiid, Printer printer, int NumberOfCopy)
        {
            ReportGenerator generator = ActivatorUtilities.CreateInstance<ReportGenerator>(sp, g, this, printer, 2);
            generator.PrintReceipt(orderiid);
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
            ReportGenerator generator = new ReportGenerator(this, await GetPrinterForClient(PrinterIID), 2);
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
                ReportGenerator generator = new ReportGenerator(this, await GetPrinterForClient(PrinterIID), 2);
                generator.PrintPriceList(catalogIID);
            } catch
            {
            }
        }

        public async Task<bool> RemoveZeroOrdersOfCurrentSessionAndCreateNewSession()
        {
            SessionData SessionToArchive;
            try
            {
                SessionToArchive = await GetSessionDataDynamic(shop.CurrentSessionIID);

                //This is a second before where the current session to be archived


                if (await RunQuery($"UPDATE  Orders SET Status = 4 WHERE SessionIID = '{SessionToArchive.SessionIID}' And Status = 3"))
                {

                    //Handle start new session things
                    SessionData sd = await GetLatestSession();
                    if (sd == null)
                    {
                        await StartNewSession();
                    } else
                    {
                        if (SessionToArchive.SessionIID == sd.SessionIID)
                        {
                            SessionToArchive.SessionEndDateTime = DateTime.Now;
                            await SaveSessionData(SessionToArchive);
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

        public async Task<SessionData> GetSessionDataDynamic(string SessionIID)
        {
            return (await repoSession.GetSessionSumView()).Where(x => x.SessionIID == SessionIID).FirstOrDefault();
            //return new SessionData(GetDataTable("GetSessionDynamic", SessionIID));
        }
        public async Task<bool> SaveSessionData(string SessionIID)
        {
            return await SaveSessionData(await GetSessionDataDynamic(SessionIID));
        }

        public async Task<bool> SaveSessionData(SessionData ses)
        {

            return await RunQuery("SaveSessionData '" + ses.SessionIID + "'," +
                               DRDateTime.DatetimeToMSSql(ses.SessionStartDateTime) +
                               "," + DRDateTime.DatetimeToMSSql(ses.SessionEndDateTime) + ",'" +
                               ses.GrossSessionTotal.ToString(ci) + "','" +
                               ses.X1Total.ToString(ci) + "','" + ses.X2Total.ToString(ci) + "','" + ses.X3Total.ToString(ci) + "'");
        }

        public async Task<bool> SaveDrawerSessionData(SessionData ses)
        {
            CultureInfo ci = GetDBCulture();
            return await RunQuery("SaveDrawerSessionData '" + ses.SessionIID + "','" + ses.peny1.ToString(ci) +
                               "','" + ses.peny2.ToString(ci) +
                               "','" + ses.peny5.ToString(ci) +
                               "','" + ses.peny10.ToString(ci) +
                               "','" + ses.peny20.ToString(ci) +
                               "','" + ses.peny50.ToString(ci) +
                               "','" + ses.pound1.ToString(ci) +
                               "','" + ses.pound2.ToString(ci) +
                               "','" + ses.pound5.ToString(ci) +
                               "','" + ses.pound10.ToString(ci) +
                               "','" + ses.pound20.ToString(ci) +
                               "','" + ses.pound50.ToString(ci) +
                               "','" + ses.pound100.ToString(ci) +
                               "','" + ses.pound200.ToString(ci) +
                               "','" + ses.pound500.ToString(ci) +
                               "','" + ses.pound1000.ToString(ci) +
                               "','" + ses.CashTotal.ToString(ci) +
                               "','" + ses.CardTotal.ToString(ci) +
                               "','" + ses.OnlineTotal.ToString(ci) + "'");
        }


        /// <summary>
        /// Determines X1, X2 or X3 will be printed
        /// </summary>
        /// <param name="givenSession"></param>
        /// <returns></returns>
        public int GetAvailableXReportSlot(SessionData givenSession)
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
        public bool WillReportEndUpAs_Z_Report(SessionData givenSession)
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

        public bool Is_Z_ReportTimeNow(SessionData givenSession)
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
                SessionFamily sf = new SessionFamily
                {
                    sessionData = await GetSessionDataDynamic(SessionIID)
                };

                string SessionFileName = DRFile.GenerateFileName(sf.sessionData.SessionStartDateTime,
                    sf.sessionData.SessionEndDateTime.Value, "xml");
                if (File.Exists(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName))
                    return false;


                if (sf.sessionData.SessionEndDateTime == sf.sessionData.SessionStartDateTime)
                {
                    sf.sessionData.SessionEndDateTime = DateTime.Now;
                }
                SaveSessionData(sf.sessionData);
                sf.Orders = await GetOrderListForSession(SessionIID);
                DRFile.XmlSerialize(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName, sf,
                    typeof(SessionFamily), false);

                //This deletes the session from database all together
                await repoSession.Delete(SessionIID);
                //RunQuery("DeleteSession", SessionIID);

                return true;
            } catch
            {
                return false;
            }
        }


        public async Task<bool> ArchiveSessionToDirectory(string directoryPath, string SessionIID, bool blnDeleteSessionFromDatabase)
        {
            try
            {
                SessionFamily sf = new SessionFamily
                {
                    sessionData = await GetSessionDataDynamic(SessionIID)
                };

                string SessionFileName = DRFile.GenerateFileName(sf.sessionData.SessionStartDateTime,
                    sf.sessionData.SessionEndDateTime.Value, "xml");
                if (File.Exists(directoryPath + "\\" + SessionFileName))
                    return false;


                if (sf.sessionData.SessionEndDateTime == sf.sessionData.SessionStartDateTime)
                {
                    sf.sessionData.SessionEndDateTime = DateTime.Now;
                }
                SaveSessionData(sf.sessionData);
                sf.Orders = await GetOrderListForSession(SessionIID);
                if (!DRFile.XmlSerialize(directoryPath + "\\" + SessionFileName, sf, typeof(SessionFamily), false))
                    return false;

                //This deletes the session from database all together
                if (blnDeleteSessionFromDatabase)
                {
                    await repoSession.Delete(SessionIID);
                    //RunQuery("DeleteSession", SessionIID);
                }

                return true;
            } catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }


        public bool ReloadSessionFromDirectory(DateTime startDate, DateTime endDate)
        {
            try
            {
                string SessionFileName = DRFile.GenerateFileName(startDate, endDate, "xml");
                SessionFamily sf =
                    (SessionFamily)
                    DRFile.XmlDeSerialize(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName,
                        typeof(SessionFamily), false);
                SaveSessionData(sf.sessionData);
                for (int i = 0; i < sf.Orders.Count; i++)
                    SaveOrder(sf.Orders[i]);
                File.Delete(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName);
                return true;
            } catch
            {
                return false;
            }
        }

        public bool ReloadSessionFromCustomDirectory(string directory, DateTime startDate, DateTime endDate)
        {
            try
            {
                string SessionFileName = DRFile.GenerateFileName(startDate, endDate, "xml");
                SessionFamily sf =
                    (SessionFamily)
                    DRFile.XmlDeSerialize(directory + "\\" + SessionFileName, typeof(SessionFamily), false);
                SaveSessionData(sf.sessionData);
                for (int i = 0; i < sf.Orders.Count; i++)
                    SaveOrder(sf.Orders[i]);
                File.Delete(directory + "\\" + SessionFileName);
                return true;
            } catch
            {
                return false;
            }
        }

        public bool ReloadSessionFromFile(string filename)
        {
            try
            {
                SessionFamily sf = (SessionFamily)DRFile.XmlDeSerialize(filename, typeof(SessionFamily), false);
                SaveSessionData(sf.sessionData);
                for (int i = 0; i < sf.Orders.Count; i++)
                    SaveOrder(sf.Orders[i]);
                File.Delete(filename);
                return true;
            } catch
            {
                return false;
            }
        }



        public async Task<SessionData> GetLatestSession()
        {
            Session latestSession = await repoSession.GetDBContext().Database.SqlQuery<Session>($"select * from sessions where startdate in ( SELECT  Max(sessions.StartDate) AS Startdate FROM sessions)").FirstOrDefaultAsync();
            return await GetSessionDataDynamic(latestSession.IID);

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

        public bool IsSessionOrdersExistInDatabase(string SessionIID)
        {
            DataTable dt = GetDataTable("Select * from Orders where SessionIID = '" + SessionIID + "'");
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Returns DataTable of SessionDataShort
        /// </summary>
        /// <returns></returns>
        public DataTable GetArchivedSessionDataTable(string sessionDirectory)
        {
            DataTable dt = GetSessionList();
            dt.Clear();

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");

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
                SessionData TempSession = new SessionData();

                SaveSessionData(TempSession);
                ActivateSession(TempSession);

                //Update OrderList to get rid of orders belong to the taken ZReport
                //Also update order session numbers
                //DO NOT MAKE THIS SINGLE DATABASE CALL
                RunQuery("UpdateSessionIIDForOrders '" + TempSession.SessionIID + "'," + (int)StatusFlags.COMPLETED);
                shop = await repoShop.GetFirst();
                return true;
            } catch
            {
                return false;
            }
        }

        public async Task ActivateSession(SessionData ses)
        {
            await RunQuery("ActivateSession '" + ses.SessionIID + "'," + DRDateTime.DatetimeToMSSql(ses.SessionStartDateTime));
        }


        /// <summary>
        /// This is only logical for current session
        /// </summary>
        /// <param name="SessionIID"></param>
        /// <returns></returns>
        public async Task<bool> PreserveSessionOrdesToX(string SessionIID)
        {
            //Move and delete Orders FROM orders and OrderItem table to xorders and xOrderItem table
            return await RunQuery("MoveOrdersToXOrdersForSession '" + SessionIID + "'");
        }

        public async Task<bool> GetXOrdersBackForSession(string SessionIID)
        {
            //Move and delete XOrders from xOrders and xOrderItem table to orders and orderitem table
            return await RunQuery("MoveXOrdersToOrdersForSession '" + SessionIID + "'");
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


        public async Task<OrderItem> DirectCreateTopOrderItemForOrder(Order order, string EntityButtonIID, bool blnSaveOrder = false)
        {
            CategoryItem eb = await GetJustEntityButton(EntityButtonIID);
            Category entity = await GetEntity(eb.CategoryIID);
            OrderItem oi = new OrderItem(order.IID, entity.IID, POSLayer.Library.ShortGuid.NewGuid().ToString(), 1,
                UF.GetRelatedPrice(null, entity, eb, order),
                EntityButtonIID, eb.ItemName, entity.DistributionIID, OrderItemTypes.NormalOrderItem, 0,
                entity.CategoryName, order.items.Count, GetEBTaxPercentForGenericOrder(order, eb));
            OrderItem thesameitem = order.items.Find(x => x.EntityButtonIID == eb.IID && x.DistributionIID == eb.DistributionIID);
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
                return
                    int.Parse(
                        GetDataTable(
                            "select count(PadFlag) as PadItems from EntityButton where PadFlag > 0 and ParentMenuIID = '" +
                            config.ActiveMenuIID + "'").Rows[0]["PadItems"].ToString()) > 0;
            } catch
            {
                return false;
            }
        }
        public double GetCurrentSessionXSum()
        {
            DataTable dt =
                GetDataTable("Select isnull(Sum(CalculatedValue),0) as Total from OrdersView where SessionIID = '" +
                                shop.CurrentSessionIID + "'");
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
        public async Task<List<Distribution>> GetFirstDisplayTypeList()
        {
            return await repoDistribution.GetDBContext().Database.SqlQuery<Distribution>($"Select * from Distribution where IID in ({config.Default_Distribution_Terminal_Type_List})").ToListAsync();
            //List<Distribution> theList = new List<Distribution>();
            //try
            //{
            //    DataTable dt = GetDataTable("Select * from Distribution where IID in (" + config.Default_Distribution_Terminal_Type_List + ")");
            //    if (dt == null)
            //        return theList;
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //        theList.Add(new Distribution(dt.Rows[i]));
            //    return theList;
            //} catch
            //{
            //    return theList;
            //}
        }
        public async Task<List<Distribution>> GetSecondDisplayTypeList()
        {
            return await repoDistribution.GetDBContext().Database.SqlQuery<Distribution>($"Select * from Distribution where IID in ({config.Secondary_Distribution_Terminal_Type_List})").ToListAsync();
            //List<Distribution> theList = new List<Distribution>();
            //try
            //{                   
            //    DataTable dt = GetDataTable("Select * from Distribution where IID in (" + config.Secondary_Distribution_Terminal_Type_List + ")");
            //    if (dt == null)
            //        return theList;
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //        theList.Add(new Distribution(dt.Rows[i]));
            //    return theList;
            //} catch
            //{
            //    return theList;
            //}
        }
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
        public bool DeleteKitchenOrder(string IID, bool blnForce)
        {
            if (blnForce)
            {
                RunQuery("Delete from KitchenOrderItem where KitchenOrderIID ='" + IID + "'");
                RunQuery("Delete from KitchenOrders where IID = '" + IID + "'");
            } else
                RunQuery("DeleteKitchenOrder '" + IID + "'");
            return !IsKitchenOrderExist(IID);

        }
        public void DeleteRelatedKitchenOrderForceFully(string RealOrderIID)
        {
            DataTable dt = GetDataTable("Select * from KitchenOrders where OrderIID = '" + RealOrderIID + "'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    DeleteKitchenOrder(dt.Rows[i]["IID"].ToString(), true);
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



        /// <summary>
        /// 'iid','iid'  gibi
        /// </summary>
        /// <param name="theList"></param>
        /// <returns></returns>
        public string GetCommaSeperatedDistributionIIDListForDatabase(List<Distribution> theList)
        {
            string str = "";
            for (int i = 0; i < theList.Count; i++)
            {
                str += "'" + theList[i].IID + "',";
            }
            if (str.Length > 0)
                return str.Substring(0, str.Length - 1);

            return str;
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

            //DataTable dt = GetDataTable("Select * from KitchenOrders Where IID ='" + IID + "'");
            //try
            //{
            //    KitchenOrder korder = new KitchenOrder(dt);
            //    dt = GetDataTable("Select * from KitchenOrderItem where KitchenOrderIID = '" + IID + "'");
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //        korder.items.Add(new KitchenOrderItem(dt.Rows[i]));
            //    return korder;
            //} catch
            //{
            //    return null;
            //}
        }
        public async Task<List<KitchenOrder>> GetKitchenOrdersByStatus(KitchenOrderStatusTypes status, bool blnAscending, List<Distribution> distributionList)
        {
            string asctext = blnAscending ? "asc" : "desc";
            DataTable dt = null;
            string distributionIIDList = GetCommaSeperatedDistributionIIDListForDatabase(distributionList);
            if (distributionIIDList == "")
                return new List<KitchenOrder>();

            switch (status)
            {
                case KitchenOrderStatusTypes.All:
                    dt = GetDataTable("Select IID from KitchenOrders order by CreatedDateTime " + asctext);
                    break;
                case KitchenOrderStatusTypes.Waiting:
                    //waiting and partialycompleted
                    dt = GetDataTable("select IID from KitchenOrders where (status = 0 or status = 1) and " +
                        " IID in (select KitchenOrderIID from KitchenOrderItem where DistributionIID in (" +
                        distributionIIDList + ") and status = 0) " + " order by CreatedDateTime " + asctext);

                    break;
                case KitchenOrderStatusTypes.Completed:
                    //partialycompleted and completed
                    dt = GetDataTable("select IID from KitchenOrders where (status = 1 or status = 2) and " +
                     " IID in (select KitchenOrderIID from KitchenOrderItem where DistributionIID in (" +
                     distributionIIDList + ") and status = 2) " + " order by CompletedDateTime " + asctext);

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

            for (int i = 0; i < order.items.Count; i++)
            {
                KitchenOrderItem korderitem = new KitchenOrderItem
                {
                    EntityButtonIID = order.items[i].EntityButtonIID,
                    Quantity = (int)order.items[i].Quantity,
                    ItemText = order.items[i].OrderItemText,
                    KitchenOrderIID = korder.IID,
                    DistributionIID = order.items[i].DistributionIID
                };
                korder.items.Add(korderitem);
            }
            return korder;
        }

        public async void SetKitchenOrderModifiedStateForAttachedOrder(bool blnBeingModified)
        {
            try
            {
                if (((AttachedOrder.Status == StatusFlags.DONE || AttachedOrder.Status == StatusFlags.PENDING) &&
                        (config.Table_Orders_Display_Kitchen_Orders || config.Hold_Order_Display_in_Kitchen)) ||
                        (!blnBeingModified && AttachedOrder.Status == StatusFlags.COMPLETED))
                {
                    await repoKitchenOrder.GetDBContext().KitchenOrders.Where(x => x.OrderIID == AttachedOrder.IID).ForEachAsync(x => x.BeingModified = blnBeingModified);
                    //RunQuery("Update KitchenOrders set BeingModified = " + BoolToInt(blnBeingModified) + " where OrderIID ='" + AttachedOrder.IID + "'");
                    SetKitchenModified();
                }
            } catch (Exception ex)
            {
                SaveDebug("157 : " + ex.Message);
            }
        }
        public bool ShrinkKitchenOrderList()
        {
            DataTable dt = GetDataTable("Select IID from KitchenOrders where Status = " + (int)KitchenOrderStatusTypes.Completed);
            if (dt.Rows.Count <= config.Kitchen_Max_Completed_Order_Count)
                return false;

            int topCount = dt.Rows.Count - config.Kitchen_Max_Completed_Order_Count;
            dt = GetDataTable("Select Top " + topCount + " IID from KitchenOrders where Status = " +
                (int)KitchenOrderStatusTypes.Completed + " order by CompletedDateTime asc");
            for (int i = 0; i < dt.Rows.Count; i++)
                DeleteKitchenOrder(dt.Rows[i]["IID"].ToString(), false);

            return true;
        }

        public DateTime GetKitchenModified()
        {
            try
            {
                return DateTime.Parse(GetDataTable("Select KitchenModified from Luv").Rows[0]["KitchenModified"].ToString());
            } catch { }
            return DateTime.Now;
        }
        public async Task<bool> SetKitchenModified()
        {
            //return RunQuery("update Luv set KitchenModified = GETDATE()");
            return await RunQuery("UpdateKitchenModified");
        }

        public async Task<bool> CleanKitchenOrdersHasNoParentOrder()
        {
            return await RunQuery("CleanKitchenOrdersHasNoParentOrder");
        }
        #endregion

        #region SUPPLIER
        public async Task<Supplier> GetSupplier(string IID)
        {
            return await repoSupplier.Get(IID);
            //return new Supplier(GetDataTable("Select * from Supplier where IID ='" + IID + "'"));
        }
        //public DataTable GetAllSuppliers()
        //{
        //    return GetDataTable("Select * from Supplier");
        //}
        public async Task<List<Supplier>> GetAllSuppliersAsList()
        {
            return await repoSupplier.GetAllAsync();

            //DataTable dt = GetDataTable("Select * from Supplier");
            //List<Supplier> theList = new List<Supplier>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    theList.Add(new Supplier(dt.Rows[i]));
            //}
            //return theList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="blnForce">True: delete the supplier even it has stockitem in the list, False: will only delete if there is no entry in stockitem table in supplierIID column</param>
        /// <returns></returns>
        public async Task<bool> DeleteSupplier(string IID, bool blnForce)
        {
            int count = int.Parse(GetDataTable("Select count(IID) as howmany from StockItem where SupplierIID = '" +
                IID + "'").Rows[0]["howmany"].ToString());
            if (count > 0)
            {
                if (blnForce)
                    return await RunQuery("Delete from Supplier where IID ='" + IID + "'");
                else
                    return false;
            } else
                return await RunQuery("Delete from Supplier where IID ='" + IID + "'");
        }
        public async Task<bool> SaveSupplier(Supplier supplier)
        {
            return await RunQuery("SaveSupplier " +
                "'" + supplier.IID + "','" + supplier.SupplierName.Replace("'", "''") + "','" +
                supplier.Tel.Replace("'", "''") + "','" + supplier.Address.Replace("'", "''") + "','" +
                supplier.Email1 + "','" + supplier.Email2 + "','" + supplier.Whatsup.Replace("'", "''") + "'");
        }
        #endregion

        #region STOCK ITEM
        public async Task<StockItem> GetStockItem(string IID)
        {
            return await repoStockItem.Get(IID);
            // return new StockItem(GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on Supplier.IID = StockItem.SupplierIID  where StockItem.IID = '" + IID + "'"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="blnForce">True: will delete the stock item regardless it has an entry in EBStockItemLookUp, False: it will only be deleted if no EBStockItemLookup Entry </param>
        /// <returns></returns>
        public async Task<bool> DeleteStockItem(string IID, bool blnForce)
        {
            int count = int.Parse(GetDataTable("Select count(StockItemIID) as howmany from EntityButtonStockItemLookUp where StockItemIID = '" +
                IID + "'").Rows[0]["howmany"].ToString());
            if (count > 0)
            {
                if (blnForce)
                    return await RunQuery("Delete from StockItem where IID ='" + IID + "'");
                else
                    return false;
            } else
                return await RunQuery("Delete from StockItem where IID ='" + IID + "'");
        }
        public async Task<bool> SaveStockItem(StockItem stockitem)
        {
            string sql = "SaveStockItem " + "'" + stockitem.IID + "','" + stockitem.StockName.Replace("'", "''") + "'," +
        (int)stockitem.QuantityType + "," + (int)stockitem.OrderType + "," + stockitem.Conversion + ",'" + stockitem.SupplierIID + "'," + stockitem.UsedQuantity;
            return await RunQuery(sql);
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
        public DataTable GetAllStockItems()
        {
            return GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID order by StockName");
        }
        public async Task<List<StockItem>> GetAllStockItemsList()
        {
            return await repoStockItem.GetDBContext().Database.SqlQuery<StockItem>($"Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID order by StockName").ToListAsync();
            //DataTable dtStockItems = GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID order by StockName");
            //List<StockItem> stockItems = new List<StockItem>();
            //foreach (DataRow dr in dtStockItems.Rows)
            //{
            //    stockItems.Add(new StockItem(dr));
            //}
            //return stockItems;
        }
        public async Task<List<StockItem>> SearchStockItems(string searchText)
        {
            return await repoStockItem.GetDBContext().Database.SqlQuery<StockItem>($"Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID where StockName like '%{searchText}%' order by StockName").ToListAsync();
            //return GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID where StockName like '%" + searchText + "%' order by StockName");
        }
        public async Task<List<StockItem>> SearchStockItems(string searchText, string SupplierIID)
        {
            return await repoStockItem.GetDBContext().Database.SqlQuery<StockItem>($"Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID where StockName like '%{searchText}%' and SupplierIID ='{SupplierIID}' order by StockName").ToListAsync();
            // return GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID where StockName like '%" + searchText + "%' and SupplierIID ='" + SupplierIID + "' order by StockName");
        }
        public async Task<List<StockItem>> GetAllStockItemsShort()
        {
            return await repoStockItem.GetDBContext().Database.SqlQuery<StockItem>($"Select IID,StockName from StockItem order by StockName asc").ToListAsync();
            //return GetDataTable("Select IID,StockName from StockItem order by StockName asc");
        }
        public async Task<List<StockItem>> GetStockItemsForSupplier(string SupplierIID)
        {
            return await repoStockItem.GetDBContext().Database.SqlQuery<StockItem>($"Select StockItem.*, SupplierName from stockitem left join supplier on supplier.IID = StockItem.SupplierIID where SupplierIID = '{SupplierIID}'").ToListAsync();
            //return GetDataTable("Select StockItem.*, SupplierName from stockitem left join supplier on supplier.IID = StockItem.SupplierIID where SupplierIID = '" + SupplierIID + "'");
        }

        #endregion

        #region EB  STOCKITEM FUNCTIONS


        public async Task<StockManager> GetStockManager(int startfrom = 0)
        {
            StockManager sm = new StockManager();

            sm.Suppliers = await repoSupplier.GetAllAsync();
            sm.EBStockItemLookups = await repoEntityButtonStockItemLookUp.GetAllAsync();
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
            foreach (var item in sm.EBStockItemLookups)
            {
                await repoEntityButtonStockItemLookUp.Save(item);
            }
            return true;
        }


        public async Task<List<EntityButtonStockItemLookUp>> GetAllEntityButtonStockItemLookUps()
        {
            return await repoEntityButtonStockItemLookUp.GetAllAsync();
        }

        public bool SaveAllStockItemLookups(List<EntityButtonStockItemLookUp> lookupItems)
        {
            try
            {
                foreach (EntityButtonStockItemLookUp lookup in lookupItems)
                {
                    SaveEntityButtonStockItemLookUp(lookup);
                }
                return true;
            } catch
            {
                return false;
            }

        }

        /// <summary>
        /// EntityButtonStockItemLookUp + StockName 
        /// </summary>
        /// <param name="EBIID"></param>
        /// <returns></returns>
        public async Task<List<EntityButtonStockItemLookUp>> GetStockItemsForEB(string EBIID)
        {
            return await repoMenu.GetDBContext().Database.SqlQuery<EntityButtonStockItemLookUp>($"SELECT EntityButtonStockItemLookUp.*, StockItem.StockName FROM EntityButtonStockItemLookUp left join StockItem on StockItemIID = StockItem.IID where EntityButtonIID = '{EBIID}' order by DisplayOrder asc").ToListAsync();
            // return GetDataTable("SELECT EntityButtonStockItemLookUp.*, StockItem.StockName FROM EntityButtonStockItemLookUp left join StockItem on StockItemIID = StockItem.IID where EntityButtonIID = '" + EBIID + "' order by DisplayOrder asc");
        }

        public async Task<EntityButtonStockItemLookUp> GetEntityButtonStockItemLookUp(string IID)
        {
            return await repoEntityButtonStockItemLookUp.Get(IID);
        }
        public async Task<bool> UpdateStockItemLookUpDisplayOrder(string IID, int newdisplayOrder)
        {
            EntityButtonStockItemLookUp lookup = await repoEntityButtonStockItemLookUp.Get(IID);
            lookup.DisplayOrder = newdisplayOrder;
            return await repoEntityButtonStockItemLookUp.Save(lookup) != null;
        }

        public async Task<bool> DeleteEntityButtonStockItemLookUp(string IID)
        {
            return await repoEntityButtonStockItemLookUp.Delete(IID) > 0;
        }
        public async Task<bool> SaveEntityButtonStockItemLookUp(EntityButtonStockItemLookUp lookup)
        {
            return await repoEntityButtonStockItemLookUp.Save(lookup) != null;
        }

        /// <summary>
        /// When you run this function you should delete the orderitems.
        /// This can only be done once and at the end of the session.
        /// </summary>
        /// <param name="blnIncrement"></param> UsedQuantity + newValue / if false just UsedQuantity
        /// <returns></returns>
        public async Task<bool> TransferStockItemUsageNow()
        {
            bool blnIncrement = true;
            return await RunQuery("update stockItem set UsedQuantity = (Select SessionQuantity from StockItemUsage where StockItem.IID = StockItemUsage.StockItemIID) " + (blnIncrement ? " + UsedQuantity" : "") +
                " where stockItem.IID in (Select StockItemIID from StockItemUsage)");
        }


        public async Task<StockItemUsage> GetSingleStockItemUsageAsObject(string StockItemIID)
        {
            return await repoStockItemUsage.GetDBContext().Database.SqlQuery<StockItemUsage>($"Select * from StockItemUsage where StockItemIID = '{StockItemIID}'").FirstOrDefaultAsync();
            //DataTable dt = GetDataTable("Select * from StockItemUsage where StockItemIID = '" + StockItemIID + "'");
            //if (dt.Rows.Count > 0)
            //    return new StockItemUsage(dt);
            //else
            //    return null;
        }

        public async Task<IEnumerable<StockItemUsage>> GetStockItemUsages(bool OrderableOnly)
        {

            if (OrderableOnly)
                return repoMenu.GetStockItemUsageView().Result.Where(x => x.OrderableQuantity >= 1).OrderBy(x => x.SupplierName);
            //return GetDataTable("Select * from StockItemUsage where OrderableQuantity >= 1 order by SupplierName asc");
            else
            {
                return repoMenu.GetStockItemUsageView().Result.OrderBy(x => x.SupplierName);
                //return GetDataTable("Select * from StockItemUsage order by SupplierName asc");
            }
        }
        public List<string> GetSupplierIIDListWhichHasOrderableStockItems()
        {
            List<string> theList = new List<string>();
            DataTable dt = GetDataTable("select SupplierIID from stockitemusage where orderablequantity > 0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                theList.Add(dt.Rows[i]["SupplierIID"].ToString());
            }
            return theList;
        }
        public DataTable GetStockItemUsageWithSearch(bool OrderableOnly, string searchText)
        {
            if (OrderableOnly)
                return GetDataTable("Select * from StockItemUsage where OrderableQuantity >= 1  and StockName Like '%" + searchText + "%' order by SupplierName asc");
            else
            {
                //return GetDataTable("Select * from StockItemUsage where TotalQuantity > 0 order by SupplierName asc");
                return GetDataTable("Select * from StockItemUsage  where StockName Like '%" + searchText + "%'  order by SupplierName asc");
            }
        }
        public async Task<IEnumerable<StockItemUsage>> GetStockItemUsageBySupplier(string SupplierIID, bool OrderableOnly)
        {
            if (OrderableOnly)
                return repoMenu.GetStockItemUsageView().Result.Where(x => x.SupplierIID == SupplierIID && x.OrderableQuantity >= 1).OrderBy(x => x.SupplierName).ToList();
            //return GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' and  OrderableQuantity >= 1  order by SupplierName asc");
            else
            {
                return repoMenu.GetStockItemUsageView().Result.Where(x => x.SupplierIID == SupplierIID).OrderBy(x => x.SupplierName).ToList();
                //return GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' order by SupplierName asc");
            }
        }
        public async Task<IEnumerable<StockItemUsage>> GetStockItemUsageBySupplierWithSearch(string SupplierIID, bool OrderableOnly, string searchText)
        {
            if (OrderableOnly)
                return repoMenu.GetStockItemUsageView().Result.Where(x => x.SupplierIID == SupplierIID && x.OrderableQuantity >= 1 && x.StockName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).OrderBy(x => x.SupplierName).ToList();
            //return GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' and  OrderableQuantity >= 1 and StockName Like '%" + searchText + "%' order by SupplierName asc");
            else
            {
                return repoMenu.GetStockItemUsageView().Result.Where(x => x.SupplierIID == SupplierIID && x.StockName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).OrderBy(x => x.SupplierName).ToList();
                //return GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "'  and StockName Like '%" + searchText + "%' order by SupplierName asc");
            }
        }
        public async Task<IEnumerable<StockItemUsage>> GetOrderableStockUsage()
        {
            return repoMenu.GetStockItemUsageView().Result.Where(x => x.OrderableQuantity >= 1).OrderBy(x => x.SupplierName).ToList();
            //return GetDataTable("Select OrderableQuantity as HowMany, OrderableType, StockName, SupplierName from StockItemUsage where OrderableQuantity >= 1 order by SupplierName asc");
        }



        /// <summary>
        /// conversion 24  and UsedQuantity 50 than the result will be  (50 % 24) = 2, simply modulus of the used quantity (kalan)
        /// Call this function carefully. It is non-reversable.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> RemoveOrderedStockUsage(bool blnConvertableOnly)
        {
            if (blnConvertableOnly)
                return await RunQuery("update stockitem set UsedQuantity = (UsedQuantity % Conversion)");
            else
                return await RunQuery("Update StockItem set UsedQuantity =0");
        }

        public async Task<bool> PrintStockUsage(Printer printer)
        {
            return new ReportGenerator(this, printer, 2).PrintStockUsage(await GetStockItemUsages(true), null);
        }
        public bool PrintStockUsage(Printer printer, IEnumerable<StockItemUsage> stockUsages, string SupplierName)
        {
            return new ReportGenerator(this, printer, 2).PrintStockUsage(stockUsages, SupplierName);
        }

        public DataTable GetEntityButtonStockItemRecipeFromStockItem(string StockItemIID)
        {
            return GetDataTable("Select * from EntityButtonStockItemRecipe where StockItemIID ='" + StockItemIID + "'");
        }
        public bool PrintDataTable(Printer printer, DataTable dt, string CustomReportName, List<int> columnSize, bool blnIncludeHeaders)
        {

            if (printer != null)
            {
                return new ReportGenerator(this, printer, 2).PrintDataTable(dt, CustomReportName, columnSize, blnIncludeHeaders);
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

        public string GetOrderableStockItemUsageAsCsvText()
        {
            return "no need to implement";
            //return GenerateCsvTextFromDataTable(GetOrderableStockUsage());
        }

        #endregion


        #region DiSPLAY IMAGE FUNCTIONS
        //public async Task<GenericImage> GetImageFromDatabase(string ReferenceIID)
        //{
        //    return await repoImage.GetByField("ReferenceIID", ReferenceIID);
        //    //DataTable dt = GetDataTable("Select * from Images where ReferenceIID ='" + ReferenceIID + "'");
        //    //if (dt.Rows.Count > 0)
        //    //    return DRUF.byteArrayToImage((byte[])dt.Rows[0]["DisplayImage"]);
        //    //else
        //    //    return null;
        //}

        public async Task<GenericImage> GetGenericImage(string ReferenceIID)
        {
            return await repoImage.GetByField("ReferenceIID", ReferenceIID);
            // return await repoImage.GetDBContext().Images.Where(x => x.ReferenceIID == ReferenceIID).FirstOrDefaultAsync();
            //DataTable dt = GetDataTable("Select * from Images where ReferenceIID ='" + ReferenceIID + "'");
            //if (dt.Rows.Count > 0)
            //    return new GenericImage(dt);
            //else
            //    return null;
        }

        public async Task<GenericImage> GetEntityButtonPrepImage(string EntityButtonIID)
        {
            GenericImage gim = await GetGenericImage(EntityButtonIID);
            if (gim == null)
                return null;

            gim.ExtraText = GetEntityButtonStockItemText(EntityButtonIID) + gim.ExtraText;
            return gim;
        }
        public async Task<string> GetEntityButtonStockItemText(string EntityButtonIID)
        {
            List<EntityButtonStockItemLookUp> lookupList = await GetStockItemsForEB(EntityButtonIID);
            string str = "";
            foreach (var item in lookupList)
            {

                //double val = double.Parse(dt.Rows[i]["Quantity"].ToString());
                if (item.Quantity == 0)
                {
                    str += item.Comment; // dt.Rows[i]["Comment"].ToString();
                    str += "\r\n";
                } else
                {
                    str += item.Comment + " "; // dt.Rows[i]["Comment"].ToString() + "  ";
                    str += item.StockName ?? "";
                    str += "\r\n";
                }
            }
            return str;



            //DataTable dt = GetStockItemsForEB(EntityButtonIID);

            //string str = "";
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    double val = double.Parse(dt.Rows[i]["Quantity"].ToString());
            //    if (val == 0)
            //    {
            //        str += dt.Rows[i]["Comment"].ToString();
            //        str += "\r\n";
            //    } else
            //    {
            //        str += dt.Rows[i]["Comment"].ToString() + "  ";
            //        if (dt.Rows[i]["StockName"] != null)
            //            str += dt.Rows[i]["StockName"].ToString();
            //        str += "\r\n";
            //    }
            //}
            //return str;
        }

        //public async Task<bool> DeletePrepImage(string ReferenceIID)
        //{
        //    return await repoImage.DeleteByField("ReferenceIID", ReferenceIID) > 0;
        //    //return RunQuery("Delete from Images where ReferenceIID ='" + ReferenceIID + "'");
        //}


        //public DataTable GetAllImages()
        //{
        //    return GetDataTable("Select * from Images");
        //}
        public async Task<List<GenericImage>> GetAllImages()
        {
            return await repoImage.GetAllAsync();
            //List<GenericImage> imageList = new List<GenericImage>();
            //try
            //{
            //    DataTable dt = GetDataTable("Select * from Images");
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        GenericImage gim = new GenericImage(dt.Rows[i], true);
            //        imageList.Add(gim);
            //    }
            //    return imageList;
            //} catch
            //{
            //    return imageList;
            //}
        }

        public async Task<bool> DeleteGenericImage(string referenceIID)
        {
            return await repoImage.DeleteByField("ReferenceIID", referenceIID) > 0;
            // return RunQuery("Delete from Images where ReferenceIID = '" + referenceIID + "'");
        }
        public async Task<bool> SaveGenericImage(GenericImage gim)
        {
            return await repoImage.Save(gim) != null;
            // return false;  
            // bu onemli

            //try
            //{
            //    SqlConnection con = new SqlConnection(ConnectionString);

            //    using (SqlCommand comm = new SqlCommand("SaveGenericImage", con)
            //    {
            //        CommandType = CommandType.StoredProcedure
            //    })
            //    {

            //        SqlParameter ReferenceIID = new SqlParameter("ReferenceIID", gim.ReferenceIID);
            //        byte[] imgbuf = DRUF.imageToByteArray(gim.DisplayImage);
            //        SqlParameter DisplayImage = new SqlParameter("DisplayImage", SqlDbType.VarBinary, imgbuf.Length)
            //        {
            //            Value = imgbuf
            //        };

            //        SqlParameter ExtraText = new SqlParameter("ExtraText", gim.ExtraText);
            //        SqlParameter ImageFileName = new SqlParameter("ImageFileName", gim.ImageFileName);

            //        comm.Parameters.Add(ReferenceIID);
            //        comm.Parameters.Add(DisplayImage);
            //        comm.Parameters.Add(ExtraText);
            //        comm.Parameters.Add(ImageFileName);
            //        con.Open();
            //        int i = comm.ExecuteNonQuery();
            //        con.Close();
            //        return i > 0;
            //    }

            //} catch
            //{
            //    return false;
            //}
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
            DataTable dt = GetDataTable("Select count(IID) as howmany from Orders where OrderType =" + (int)OrderTypes.DirectSale + " and status = " + (int)StatusFlags.PENDING);
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        public bool HasActiveTableOrders()
        {
            DataTable dt = GetDataTable("Select count(IID) as howmany from Orders where OrderType =" +
                (int)OrderTypes.InHouse + " and  (status = " + (int)StatusFlags.NEW + " or status = " + (int)StatusFlags.DONE + ")");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        /// <summary>
        /// At least there should be 1 completed order, Only checks the completed orders not concern about archived orders
        /// </summary>
        /// <returns></returns>
        public bool HasCurrentSessionCompletedOrders()
        {
            DataTable dt = GetDataTable("Select count(IID) as howmany from Orders where status = " +
                (int)StatusFlags.COMPLETED + " and SessionIID ='" + shop.CurrentSessionIID + "'");
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
                    backup.currentSession = new SessionData(await repoSession.Get(shop.CurrentSessionIID));
                    //DataTable dtCurrentSession = GetDataTable("Select * from Sessions where IID = '" + shop.CurrentSessionIID + "'");
                    //backup.currentSession = new SessionData(dtCurrentSession);
                }

                if (options.includeTables)
                {
                    backup.tableGroupList = await repoTableGroup.GetAllAsync();
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
        public async Task<bool> ShrinkCustomer(string customerIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            return await RunQuery("Update Customer set IID = '" + newIID + "' where IID = '" + customerIID + "'");
        }
        public async Task<bool> ShrinkAllCustomers()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from Customer");
                for (int i = 0; i < dt.Rows.Count; i++)
                    await ShrinkCustomer(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }
        public async Task<bool> ShrinkUser(string userIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            return await RunQuery("Update Users set IID = '" + newIID + "' where IID = '" + userIID + "'");
        }
        public bool ShrinkAllUsers()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from Users");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkUser(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }
        public async Task<bool> ShrinkApplicationPrinter(string printerIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            return await RunQuery("Update ApplicationPrinter set IID = '" + newIID + "' where IID = '" + printerIID + "'") &&
                  await  RunQuery("Update PrinterLookup set PrinterIID = '" + newIID + "' where PrinterIID = '" + printerIID + "'") &&
                  await  RunQuery("Update Distribution set PrinterIID = '" + newIID + "' where PrinterIID = '" + printerIID + "'");
        }
        public bool ShrinkAllApplicationPrinters()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from ApplicationPrinter");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkApplicationPrinter(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }
        public async Task<bool> ShrinkTable(string TableIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            return await RunQuery("Update Tables set IID = '" + newIID + "' where IID = '" + TableIID + "'");
        }
        public bool ShrinkAllTables()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from Tables");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkTable(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }
        public async Task<bool> ShrinkTableGroup(string tableGroupIID)
        {
            try
            {
                string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
                //Update TableGroup IID
                await RunQuery("Update TableGroup set IID = '" + newIID + "' where IID = '" + tableGroupIID + "'");
                //Update GroupIID in Tables
                await RunQuery("Update Tables set GroupIID = '" + newIID + "' where GroupIID = '" + tableGroupIID + "'");
                //Update IID Fields of this table group tables
                DataTable dt = GetDataTable("Select IID from Tables");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string oldTableIID = dt.Rows[i]["IID"].ToString();
                    await ShrinkTable(oldTableIID);
                }
                return true;
            } catch
            {
                return false;
            }

        }
        public async Task<bool> ShrinkAllTableGroups()
        {
            try
            {
                bool blnStatus = false;
                DataTable dt = GetDataTable("Select IID from TableGroup");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string oldTableGroupIID = dt.Rows[i]["IID"].ToString();
                    blnStatus = blnStatus && await ShrinkTableGroup(oldTableGroupIID);
                }
                return blnStatus;
            } catch
            {
                return false;
            }
        }

        public async Task<bool> ShrinkDistribution(string DistributionIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            //Update IID of the distribution 
            return await RunQuery("Update Distribution set IID = '" + newIID + "' where IID = '" + DistributionIID + "'") &&
            //Update DistributionIID of the EntityButtons
           await RunQuery("Update EntityButton set DistributionIID = '" + newIID + "' where DistributionIID = '" + DistributionIID + "'") &&
            //Update DistributionIID of the Entities
         await   RunQuery("Update Entity set DistributionIID = '" + newIID + "' where DistributionIID = '" + DistributionIID + "'");
        }

        public async Task<bool> ShrinkEntityButton(string ebIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            //Update IID of the Entity Button 
            return await RunQuery("Update EntityButton set IID = '" + newIID + "' where IID = '" + ebIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this entity button
            await RunQuery("Update Images set ReferenceIID = '" + newIID + "' where ReferenceIID = '" + ebIID + "'") &&
            //Update DistributionIID of the Entities
           await RunQuery("Update EntityButtonStockItemLookUp set EntityButtonIID = '" + newIID + "' where EntityButtonIID = '" + ebIID + "'");
        }

        public async Task<bool> ShrinkEntity(string eIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            //Update IID of the Entity 
            return await RunQuery("Update Entity set IID = '" + newIID + "' where IID = '" + eIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this entity
           await RunQuery("Update Images set ReferenceIID = '" + newIID + "' where ReferenceIID = '" + eIID + "'") &&
            //Update DistributionIID of the Entities
          await  RunQuery("Update EntityButton set ParentEntityIID = '" + newIID + "' where ParentEntityIID = '" + eIID + "'");

        }

        public async Task<bool> ShrinkMenu(string menuIID)
        {
            string newMenuIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            //Update IID of the Menu 
            if (await RunQuery("Update Menu set IID = '" + newMenuIID + "' where IID = '" + menuIID + "'") &&
                //Update ParentMenuIID in Entity
              await  RunQuery("Update Entity set ParentMenuIID = '" + newMenuIID + "' where ParentMenuIID = '" + menuIID + "'") &&
                //Update ParentMenuIID in EntityButton
              await  RunQuery("Update EntityButton set ParentMenuIID = '" + newMenuIID + "' where ParentMenuIID = '" + menuIID + "'") &&
                //Update ParentMenuIID in Distribution
             await   RunQuery("Update Distribution set ParentMenuIID = '" + newMenuIID + "' where ParentMenuIID = '" + menuIID + "'"))
            {

                //Now shrink Entity List
                try
                {
                    DataTable dt = GetDataTable("Select IID from Entity where ParentMenuIID ='" + newMenuIID + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string entityIID = dt.Rows[i]["IID"].ToString();
                        ShrinkEntity(entityIID);
                    }
                } catch
                {
                    MessageBox.Show("Failed to shrink categories for this menu");
                    return false;
                }

                //Now shrink EntityButtons
                try
                {
                    DataTable dt = GetDataTable("Select IID from EntityButton where ParentMenuIID ='" + newMenuIID + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string entityButtonIID = dt.Rows[i]["IID"].ToString();
                        ShrinkEntityButton(entityButtonIID);
                    }
                } catch
                {
                    MessageBox.Show("Failed to shrink category items for this menu");
                    return false;
                }

                //Now shrink Disributions
                try
                {
                    DataTable dt = GetDataTable("Select IID from Distribution where ParentMenuIID ='" + newMenuIID + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string distributionIID = dt.Rows[i]["IID"].ToString();
                        ShrinkDistribution(distributionIID);
                    }
                } catch
                {
                    MessageBox.Show("Failed to shrink distributions for this menu");
                    return false;
                }

                return true;
            }
            return false;
        }

        public bool ShrinkAllMenus()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from Menu");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkMenu(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }

        public async Task<bool> ShrinkStockItem(string itemIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            //Update IID of the StockItem 
            return await RunQuery("Update StockItem set IID = '" + newIID + "' where IID = '" + itemIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this stockItem
           await RunQuery("Update Images set ReferenceIID = '" + newIID + "' where ReferenceIID = '" + itemIID + "'") &&
            //Update StockItemIID in EntityButtonStockItemLookUp of the StockItem
          await   RunQuery("Update EntityButtonStockItemLookUp set StockItemIID = '" + newIID + "' where StockItemIID = '" + itemIID + "'");
        }

        public bool ShrinkAllStockItems()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from StockItem");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkStockItem(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }

        public async Task<bool> ShrinkSupplier(string suppIID)
        {
            string newIID = POSLayer.Library.ShortGuid.NewGuid().ToString();
            //Update IID of the StockItem 
            return await RunQuery("Update Supplier set IID = '" + newIID + "' where IID = '" + suppIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this stockItem
           await RunQuery("Update StockItem set SupplierIID = '" + newIID + "' where SupplierIID = '" + suppIID + "'");
        }

        public async Task<bool> ShrinkAllSuppliers()
        {
            try
            {
                DataTable dt = GetDataTable("Select IID from Supplier");
                for (int i = 0; i < dt.Rows.Count; i++)
                   await ShrinkSupplier(dt.Rows[i]["IID"].ToString());
                return true;
            } catch
            {
                return false;
            }
        }

        public async Task<bool> ShrinkStockManager()
        {
            try
            {
                return await ShrinkAllSuppliers() && ShrinkAllStockItems();
            } catch
            {
                return false;
            }
        }

        #endregion

        #region BONUS FUNCTIONS
        //public DataTable GetAllBonus()
        //{

        //    return GetDataTable("Select *,'' as DaysAvailableAsString from Bonus Order by PlanName");
        //}
        public async Task<List<Bonus>> GetAllBonusList()
        {
            return await repoBonus.GetAllAsync();
            //List<Bonus> theList = new List<Bonus>();
            //DataTable dt = GetAllBonus();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    theList.Add(new Bonus(dt.Rows[i]));
            //}
            //return theList;
        }
        public async Task<Bonus> GetBonus(string IID)
        {
            return await repoBonus.Get(IID);
            //return new Bonus(GetDataTable("Select * from Bonus where IID ='" + IID + "'"));
        }
        public async Task<bool> SaveBonus(Bonus bonus)
        {
            return await repoBonus.Save(bonus) != null;
            //return RunQuery("SaveBonus '" + bonus.IID + "','" + bonus.PlanName + "','" + bonus.PlanDescription
            //    + "'," + bonus.Barrier0
            //    + "," + bonus.Barrier1
            //    + "," + bonus.Barrier2
            //    + "," + bonus.Barrier3
            //    + "," + bonus.Barrier4
            //    + "," + bonus.Barrier5
            //    + "," + bonus.Barrier6
            //    + "," + bonus.Barrier7
            //    + "," + bonus.Barrier8
            //    + "," + bonus.Barrier9
            //    + "," + bonus.Barrier10
            //    + "," + bonus.Barrier11
            //    + "," + bonus.Barrier12
            //    + "," + bonus.Barrier13
            //    + "," + bonus.Barrier14
            //    + "," + bonus.Barrier15
            //    + "," + bonus.Barrier16
            //    + "," + bonus.Barrier17
            //    + "," + bonus.Barrier18
            //    + "," + bonus.Barrier19
            //    + "," + bonus.Barrier20
            //    + "," + (int)bonus.DaysAvailable
            //    + ",'" + bonus.StartTime.ToString()
            //    + "','" + bonus.EndTime.ToString()
            //    + "','" + bonus.BonusHiddenStartTime.ToString()
            //    + "','" + bonus.BonusHiddenEndTime.ToString() + "','" + bonus.StepValue + "','" + bonus.HalfStepValue + "'");
        }
        public async Task<bool> DeleteBonus(string IID)
        {
            return await repoBonus.Delete(IID) > 0;
            // return RunQuery("Delete from Bonus where IID ='" + IID + "'");
        }

        public async void SetSuitableBonus()
        {
            this.currentBonusScheme = await GetSuitableBonus();
        }

        public async Task<Bonus> GetSuitableBonus()
        {
            WeekDays dayoftheweek = UF.GetTodaysDTRMWeekDay();
            List<Bonus> allBonus = await GetAllBonusList();


            //Select Daily Available Bonuses
            List<Bonus> dailyAvailableBonusList = new List<Bonus>();
            foreach (Bonus bonus in allBonus)
            {
                if (PosLibrary.DRNumeric.IsBitSet((int)bonus.DaysAvailable, (int)dayoftheweek))
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
        public async Task<bool> CreateDemoMenu(string menuName)
        {
            TheMenu menu = new TheMenu()
            {
                MenuName = "New Menu",
                IsActive = true,
                distributions = new List<Distribution>()
                {
                        new Distribution() {DistributionName = "Distro 1"}
                },
                categories = new List<Category>()
                {
                    new      Category()
                    {
                        CategoryName = "First Category" ,
                        Items = new List<CategoryItem>()
                        {
                            new   CategoryItem()
                            {
                                ItemName = "First Category Item"
                            }
                        }
                    }
                }
            };
            menu =  await repoMenu.SaveTree(menu);           

            return true;
        }
    }
}
