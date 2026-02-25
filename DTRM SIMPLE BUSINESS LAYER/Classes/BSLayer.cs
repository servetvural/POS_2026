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
using System.Data.SqlClient;
using System.Linq;

namespace DTRMNS {
    
    [System.Xml.Serialization.XmlInclude(typeof(FMenu))]
    [System.Xml.Serialization.XmlInclude(typeof(Order))]
    [System.Xml.Serialization.XmlInclude(typeof(Luv))]
    [System.Xml.Serialization.XmlInclude(typeof(DTRMConfig))]
    [System.Xml.Serialization.XmlInclude(typeof(User))]
    [System.Serializable]
    public class DTRMSimpleBusiness {
        public bool DBConnectionSuccessful { get; set; }
        public string DBConnectionError { get; set; }


        [System.Xml.Serialization.XmlIgnore]
        public DTRMConfig config;

        [System.Xml.Serialization.XmlIgnore]
        public Luv luv;

        public User LoggedUser;
        public Order AttachedOrder;

        [System.Xml.Serialization.XmlIgnore]
        public FMenu ActiveMenu;

        [System.Xml.Serialization.XmlIgnore]
        public DB db;

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


        public void ShutDown() {
            Application.Exit();
        }

        public void Restart() {
            Application.Restart();
        }

        public event GenericFunctionCall OrderLoaded;
        public void OnOrderLoaded() {
            this.OrderLoaded?.Invoke();
        }

        public event GenericFunctionCall OrderUnloaded;
        public void OnOrderUnloaded() {
            OrderUnloaded?.Invoke();
        }


        public event GenericFunctionCall DisplayOrder;
        public void OnDisplayOrder() {
            DisplayOrder?.Invoke();
        }

        public event GenericFunctionCall KitchenRequestSent;
        public void OnKitchenRequestSent() {
            KitchenRequestSent?.Invoke();
        }

        public event KitchenEventHandler KitchenRequestOccured;
        public void OnKitchenRequestOccured(KitchenOrder order) {
            KitchenRequestOccured?.Invoke(order);
        }

        public event SimpleStringEventHandler ImmediateDebugOccured;
        public void OnImmediateDebugOccured(string str) {
                ImmediateDebugOccured?.Invoke(str);
        }

        public DTRMSimpleBusiness() {
        }

        public DTRMSimpleBusiness(DTRMConfig config) {
            this.config = config;
            EstablishDatabaseConnection();
        }

        //used to get simple bslayer for database panel on lock screen
        public DTRMSimpleBusiness(bool blnCheckDatabase, DTRMConfig config) {
            this.config = config;
            if (blnCheckDatabase) 
                EstablishDatabaseConnection();            
        }
        public bool IsLoginSuccess(string password) {
            User user = GetUserByPassword(password);
            if (user != null) {
                LoggedUser = user;
                return true;
            } else
                return false;
        }
        public bool IsAdmin(string password) {
            User user = GetUserByPassword(password);
            if (user != null && user.IsManagerOrMore()) {
                LoggedUser = user;
                return true;
            } else
                return false;
        }


        public DTRMSimpleBusiness(DTRMConfig config, bool blnCheckDBConnection /*, bool blnCreateReport*/) {
            this.config = config;
            if (blnCheckDBConnection) 
                EstablishDatabaseConnection();
            else
                EstablishDirectDatabaseConnection();
        }

        public DTRMSimpleBusiness(bool blnReoptainConfigFile, bool blnEnsureDatabase) {
            if (blnReoptainConfigFile) {
                config = UF.GetConfig();
                if (blnEnsureDatabase) {
                    EstablishDatabaseConnection();
                }
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="culture">mesela en-GB</param>
        /// <returns></returns>
        public CultureInfo GetCulture(string culture) {
            CultureInfo ci = new CultureInfo(culture);
            ci.NumberFormat.CurrencyDecimalDigits = 2;
            ci.NumberFormat.NumberDecimalDigits = 2;
            return ci;
        }

        public CultureInfo GetDBCulture() {
            return GetCulture(config.Database_Currency_Culture);
        }

        public CultureInfo GetUICulture() {
            return GetCulture(config.Terminal_Currency_Culture);
        }

        #region LICENCE RELATED

        //public void ValidateLicence() {
        //    Thread validationThread = new Thread(CheckLicence);
        //    validationThread.Start();
        //}

        /// <summary>
        /// It is better to run this function on a difference thread using ValidateLicence() function above.
        /// It delays the execution a lot.
        /// </summary>
        //public async void CheckLicence() {
        //   // int i = 0;
        //    //create client
        //    LicenceClient lclient = new LicenceClient();

            
        //    try {
        //        //test if localhash file exist
        //        config.TerminalLicence = await lclient.GetLicenceLocal();

        //        //There is not even localhash block it 
        //        LicenceVerified = !string.IsNullOrEmpty(config.TerminalLicence);

        //        //Now check if online restore possible which will restore the localhash file if any
        //        LicenceSimpleResponse response = await lclient.IsLicenceValid(SoftwareID);

        //        //if there is no error to jump to catch then block or not
        //        LicenceVerified = response.blnState;
                
        //        //reload localhash
        //        config.TerminalLicence = await lclient.GetLicenceLocal();
        //        if (config.TerminalLicence.Length > 0)
        //            LicenceVerified = true;

        //    } catch (Exception ex) {
        //       // config.TerminalLicence = await lclient.GetLicenceLocal();
        //       // MessageBox.Show("Validate Licence Error : i=" + i.ToString() + " , " + ex.Message);
        //    }
        //}
        #endregion

        public bool DoStartThings() {
            try {
                luv = GetLuv();
                ci = GetDBCulture();
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(config.Terminal_Currency_Culture);
            } catch {
                return false;
            }

            ReportLockClientIP = "";

            if (ActiveMenu == null)
                GetActiveMenu(false, true);
            EnsureSessionData(); //Load SessionData from database       

            return true;
        }

        /// <summary>
        /// Currently during connection this is called for creating db connection
        /// </summary>
        /// <returns></returns>
        public bool EstablishDatabaseConnection() {
            try {                       
                //Connect to remote SQLExpress Server
                db = new DB(config.Database_Instance, config.Database_Name, config.Database_User_Name,config.Database_Password);
           
                if (config != null)
                    db.DebugMode = config.DebugMode;
                string localerrormessage;
                DBConnectionSuccessful = db.CheckDatabaseConnection(out localerrormessage);
                DBConnectionError = localerrormessage;
                
            } catch (Exception ex)  {
                DBConnectionError = ex.Message;
                DBConnectionSuccessful = false;              
            }
            return DBConnectionSuccessful;
        }

        public void InitiateDBObject() {
            try {
                db = new DB(config.Database_Instance, config.Database_Name, config.Database_User_Name,
                    config.Database_Password);
                if (config != null)
                    db.DebugMode = config.DebugMode;
            } catch {
            }
        }

        /// <summary>
        /// This method doesn't ping the database server.
        /// </summary>
        /// <returns></returns>
        public bool EstablishDirectDatabaseConnection() {
            try {
                db = new DB(config.Database_Instance, config.Database_Name, config.Database_User_Name,
                    config.Database_Password);
                if (config != null)
                    db.DebugMode = config.DebugMode;
                return db.CheckDatabaseConnection();
            } catch {
                return false;
            }
        }

        public bool IsDBAvailable() {
            try {
                DataTable dt = db.GetDataTable("Select * from Menu");
                return true;
            } catch {
                return false;
            }
        }

        public bool CheckIfConfigFileExist() {
        CheckConfig:
            //Check DTRMConfig if exist
            if (!File.Exists(DRFile.GetApplicationPath() + "\\DTRMConfig.xml")) {

                using (frmConfig frm = new frmConfig(null)) {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                        // bslayer.config = frm.config;

                        goto CheckConfig;
                    } else {
                        //Application.Exit();
                        return false;
                    }
                }
            }

            //Check if config for localdb or server
            config = UF.GetConfig();
            if (config == null) {
                return false;
            }
            return true;
        }         

        public void RePriceOrderForOrderType(Order order, OrderTypes orderType) {
            FMenu fm = ActiveMenu;
            OrderItem oi;
            for (int i = 0; i < order.items.Count; i++) {
                oi = (OrderItem)order.items[i];
                oi.Price = fm.GetItemPrice(oi.EntityIID, oi.EntityButtonIID, orderType);

            }
        }

        public void ReTaxOrderForOrderType(Order order, OrderTypes orderType) {
            FMenu fm = ActiveMenu;
            OrderItem oi;
            for (int i = 0; i < order.items.Count; i++) {
                oi = (OrderItem)order.items[i];
                oi.TaxPercent = fm.GetItemTaxRate(oi.EntityIID, oi.EntityButtonIID, orderType);

            }
        }              
        public void CustomerDetailsToOrder(Customer customer) {
            if (customer != null) {
                AttachedOrder.CustomerIID = customer.IID;
                AttachedOrder.CName = customer.CName;
                AttachedOrder.Buzzer = customer.Buzzer;
                AttachedOrder.Address = customer.Address;
                AttachedOrder.PostCode = customer.PostCode;
                AttachedOrder.Town = customer.Town;
                AttachedOrder.Tel = customer.Tel;
                AttachedOrder.Mobile = customer.Mobile;
                AttachedOrder.Email = customer.Email;
            }
        }

        public Customer CustomerDetailsFromOrder() {
            Customer customer = new Customer {
                CName = AttachedOrder.CName,
                Buzzer = AttachedOrder.Buzzer,
                Address = AttachedOrder.Address,
                PostCode = AttachedOrder.PostCode,
                Town = AttachedOrder.Town,
                Tel = AttachedOrder.Tel,
                Mobile = AttachedOrder.Mobile,
                Email = AttachedOrder.Email
            };
            return customer;
        }

       

       

        public bool IsServerConnected() {
            List<FMenu> ml;
            try {
                ml = this.GetMenuListDB();
                return true;
            } catch {
                return false;
            }
        }

        public DataTable GetDataTable(string sql) {
            return db.GetDataTable(sql);
        }

        public bool RunQuery(string sql) {
            return db.RunQuery(sql);
        }

        #region "ADMIN FUNCTIONS"

        public List<Table> ReturnAllAndGetTableList(string ClientIP) {
            ReturnAllTablesAndOrders(ClientIP);
            return GetTableList();
        }

        public void ReturnAllTablesAndOrders(string ClientIP) {
            db.RunQuery("ReturnAllTablesAndOrders '" + config.Terminal_Name + "'");
        }

        public int CheckDBRowCount(string TableName) {
            DataTable dt = db.GetDataTable("select count(*) as howmany from " + TableName);
            return int.Parse(dt.Rows[0]["howmany"].ToString());
        }

        public DataTable GetLuvDB() {
            if (CheckDBRowCount("Luv") == 0) {
                SaveLuv(new Luv());
            }
            return db.GetDataTable("GetLuv");
        }

        public Luv GetLuv() {
            try {
                return new Luv(GetLuvDB());
            } catch {
                return new Luv();
            }
        }
        public void SaveLuv() {
            SaveLuv(luv);
        }
        public void SaveLuv(Luv luv) {
            try
            {
                string smtppassword = (luv.SmtpPassword == null ? "" : luv.SmtpPassword.Replace("'", "''"));
                string customerpassword = (luv.CustomerPassword == null ? "" : luv.CustomerPassword.Replace("'", "''"));

                string query = "SaveLuv '" +
                    luv.ShopName.Replace("'", "''") + "','" +
                    luv.ShopAddress.Replace("'", "''") + "','" +
                    luv.Tel1.Replace("'", "''") + "','" +
                    luv.Tel2.Replace("'", "''") + "','" +
                    luv.Fax.Replace("'", "''") + "','" +
                    luv.Vat.Replace("'", "''") + "','" +
                    luv.PurchaseEmail.Replace("'", "''") + "','" +
                    luv.OrdersEmail.Replace("'", "''") + "','" +
                    luv.ReportEmail.Replace("'", "''") + "','" +
                    luv.NotificationEmail.Replace("'", "''") + "','" +
                    luv.CurrentSessionIID + "'," +
                    DRDateTime.DatetimeToMSSql(luv.SessionStartDateTime) + ",'" +
                    luv.VoidText.ToUpper().Replace("'", "''") + "','" +
                    luv.DefaultTaxRate + "','" +
                    luv.ServiceChargeRate + "','" +
                    luv.ServiceChargeTaxRate + "','" +
                    luv.ReceiptHeader.Replace("'", "''") + "','" +
                    luv.ReceiptFooter.Replace("'", "''") + "','" +
                    luv.KitchenHeader.Replace("'", "''") + "','" +
                    luv.KitchenFooter.Replace("'", "''") + "','" +
                    luv.ReportHeader.Replace("'", "''") + "','" +
                    luv.ReportFooter.Replace("'", "''") + "','" +
                    luv.SmtpServer.Replace("'", "''") + "','" +
                    luv.SmtpEmailAddress.Replace("'", "''") + "','" +
                    luv.SmtpFromLabel.Replace("'", "''") + "','" +
                    luv.SmtpAccountName.Replace("'", "''") + "','" +
                    DRFormat.Encode(smtppassword) + "','" +
                    luv.CustomerKey.Replace("'", "''") + "','" +
                    DRFormat.Encode(customerpassword) + "'";

                db.RunQuery(query);
            } catch (Exception ex)   {
                MessageBox.Show("Save Luv Error : " + ex.Message);
            }
        }


        public DataTable GetAllTaxRates() {
            return
                db.GetDataTable("Select * from TaxPercentList where ParentMenuIID = '" + config.ActiveMenuIID + "'");
        }

        public bool SetTaxRate(float DBTaxRate, float NewTaxRate) {
            return db.RunQuery("UpdateTaxRates '" + config.ActiveMenuIID + "'," + DBTaxRate + "," + NewTaxRate);
        }      

        #endregion


        #region "USER FUNCTIONS"

        public void EnsureRequiredUsers() {
            SaveUser(new User("1", "Waiter", "1", AccessLevels.User));
            SaveUser(new User("2", "Manager", "2", AccessLevels.Manager));
            SaveUser(new User("3", "Admin", "9999", AccessLevels.SuperUser));
            SaveUser(new User("4", "Tech", "2020", AccessLevels.TechnicalSupport));
        }

        public List<User> GetUserList() {
            List<User> UserList = new List<User>();
            DataTable dt = db.GetDataTable("GetAllUsers");
            for (int i = 0; i < dt.Rows.Count; i++)
                UserList.Add(new User(dt.Rows[i]));
            return UserList;
        }

        public DataTable GetUsers() {
            return db.GetDataTable("GetAllUsers");
        }

        public bool IsPasswordExist(string Password) {
            DataTable dt = db.GetDataTable("GetUserByPassword", Password);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public User GetUserByPassword(string Password) {
            DataTable dt = db.GetDataTable("GetUserByPassword", Password);
            if (dt.Rows.Count > 0)
                return new User(dt.Rows[0]);
            else
                return null;
        }

        public User GetUser(string UserIID) {
            DataTable dt = db.GetDataTable("GetUser", UserIID);
            if (dt.Rows.Count > 0)
                return new User(dt.Rows[0]);
            else
                return null;
        }

        public bool SaveUser(User user) {
            return db.RunQuery("SaveUser '" + user.IID + "','" + user.UserName + "','" +
                               user.UserPassword + "'," + (int)user.AccessLevel);
        }

        public void DeleteUser(string UserIID) {
            db.RunQuery("DeleteUser", UserIID);
        }

        #endregion

        #region "ENTITY FUNCTIONS"

        public FMenu GetActiveMenu(bool blnReloadConfig, bool blnReloadMenu) {
            if (blnReloadMenu) {
                if (blnReloadConfig)
                    //DeSerializeConfig();
                    config = UF.GetConfig();
                //Get and load active menu 
                if (config.ActiveMenuIID == null || config.ActiveMenuIID == "") {
                    string firstMenuIID = GetFirstMenuIID();
                    if (firstMenuIID != "") {
                        config.ActiveMenuIID = firstMenuIID;
                        UF.SaveConfig(config);
                    }
                }
                if (config.ActiveMenuIID != null && config.ActiveMenuIID != "") {
                    try {
                        ActiveMenu = GetMenuDB(config.ActiveMenuIID);
                    } catch {
                        ActiveMenu = null;
                    }
                } 
            }
            return ActiveMenu;
        }

        public void SaveMenuA(FMenu foodMenu) {
            DRFile.XmlSerialize(DRFile.GetApplicationPath() + foodMenu.GetMenuFileName(), foodMenu,
                typeof(FMenu), false);
        }

        public DataTable GetMenuList() {
            if (config != null)
            {
                DataTable dt = db.GetDataTable("GetMenuList");
                dt.Columns.Add("IsActiveMenu");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["IID"].ToString() == config.ActiveMenuIID)
                        dt.Rows[i]["IsActiveMenu"] = true;
                }
                return dt;
            } else
            {
                return null;
            }
        }

        public bool IsMenuExist(string MenuIID) {
            DataTable dt = db.GetDataTable("Select * from Menu where IID = '" + MenuIID + "'");
            return dt.Rows.Count > 0;
        }

        public string GetFirstMenuIID() {
            DataTable dt = db.GetDataTable("GetMenuList");
            if (dt.Rows.Count == 0)
                return "";
            else 
                return dt.Rows[0]["IID"].ToString();       
        }

        public List<FMenu> GetMenuListDB() {
            DataTable dt = db.GetDataTable("GetMenuList");
            List<FMenu> MenuList = new List<FMenu>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                FMenu fm = new FMenu(dt.Rows[i]["IID"].ToString()) {
                    MenuName = dt.Rows[i]["MenuName"].ToString()
                };
                MenuList.Add(fm);
            }
            return MenuList;
        }

        /// <summary>
        /// Returns list of menus in the database. Menus have all the entities and entity buttons in it
        /// </summary>
        /// <returns></returns>
        public List<FMenu> GetAllMenuList(GenericProgressFunction progress=null, int startfrom=0) {
            DataTable dt = db.GetDataTable("GetMenuList");
            List<FMenu> MenuList = new List<FMenu>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                string IID = dt.Rows[i]["IID"].ToString();
                MenuList.Add(GetMenuDB(IID));
                progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            }
            return MenuList;
        }

        public List<IIDName> GetJustMenuIIDNameList() {
            List<IIDName> theList = new List<IIDName>();
            DataTable dt = db.GetDataTable("Select IID, MenuName as Name from Menu");
            for (int i=0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDName(dt.Rows[i]));
            }
            return theList;
        }
        public IIDName GetJustMenuIIDName(string MenuIID) {
            DataTable dt = db.GetDataTable("GetMenu", MenuIID);
            if (dt.Rows.Count > 0) {
                return new IIDName(dt);
            } else
                return null;
        }

        public List<IIDName> GetJustEntityIIDNameList(string MenuIID) {
            List<IIDName> theList = new List<IIDName>();
            DataTable dt = db.GetDataTable("Select IID, EntityName as Name from Entity where ParentMenuIID = '" + MenuIID + "' order by DisplayOrder");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDName(dt.Rows[i]));
            }
            return theList;
        }
        public List<IIDName> GetJustEntityButtonIIDNameList(string EntityIID) {
            List<IIDName> theList = new List<IIDName>();
            DataTable dt = db.GetDataTable("Select IID, EntityButtonName as Name from EntityButton where ParentEntityIID = '" + EntityIID + "' order by DisplayOrder");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDName(dt.Rows[i]));
            }
            return theList;
        }

        public List<IIDName> GetJustDistributionIIDNameList(string MenuIID) {
            List<IIDName> theList = new List<IIDName>();
            DataTable dt = db.GetDataTable("Select IID, DistributionName as Name from Distribution where ParentMenuIID = '" + MenuIID + "' order by DisplayOrder");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDName(dt.Rows[i]));
            }
            return theList;
        }
        public List<IIDName> GetJustSupplierIIDNameList() {
            List<IIDName> theList = new List<IIDName>();
            DataTable dt = db.GetDataTable("Select IID, SupplierName as Name from Supplier order by SupplierName");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDName(dt.Rows[i]));
            }
            return theList;
        }
        public List<IIDName> GetJustStockItemIIDNameList(string SupplierIID) {
            List<IIDName> theList = new List<IIDName>();
            DataTable dt = db.GetDataTable("Select IID, StockName as Name from StockItem Where SupplierIID = '" + SupplierIID + "' order by StockName");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDName(dt.Rows[i]));
            }
            return theList;
        }

        public List<IIDValueDate> GetOrdersIIDValueDateList() { 
            List<IIDValueDate> theList = new List<IIDValueDate>();
            DataTable dt = db.GetDataTable("Select IID, CalculatedValue as Value, OrderDate as Date from OrdersView order by OrderDate");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDValueDate(dt.Rows[i]));
            }
            return theList;
        }
        public float GetOrdersTotal() {
            DataTable dt = db.GetDataTable("Select isnull(sum(CalculatedValue),0) as Total from OrdersView");
            return float.Parse(dt.Rows[0]["Total"].ToString());
        }
        public float GetOrdersTotalForPaymentMethod(string sessionIID,PaymentMethods payment) {
            DataTable dt = GetDataTable("Select isnull(sum(CalculatedValue),0) as Total from OrdersView where SessionIID = '" + sessionIID + "'  and (OrdersView.Status = 3 or OrdersView.Status = 4) and Payment = " + (int)payment);
            return float.Parse(dt.Rows[0]["Total"].ToString());
        }
        public List<IIDValueDate> GetXOrdersIIDValueDateList() {
            List<IIDValueDate> theList = new List<IIDValueDate>();
            DataTable dt = db.GetDataTable("Select IID, CalculatedValue as Value, OrderDate as Date from XOrdersView order by OrderDate");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDValueDate(dt.Rows[i]));
            }
            return theList;
        }
        public float GetXOrdersTotal() {
            DataTable dt = db.GetDataTable("Select isnull(sum(CalculatedValue),0) as Total from XOrdersView");
            return float.Parse(dt.Rows[0]["Total"].ToString());
        }
        public List<IIDDate> GetKitchenOrdersIIDDateList() {
            List<IIDDate> theList = new List<IIDDate>();
            DataTable dt = db.GetDataTable("Select IID, CreatedDateTime as Date from KitchenOrders order by CreatedDateTime");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new IIDDate(dt.Rows[i]));
            }
            return theList;
        }

        public List<Debug> GetDebugList() {
            List<Debug> theList = new List<Debug>();
            DataTable dt = db.GetDataTable("Select * from Debug order by EventDateTime");
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new Debug(dt.Rows[i]));
            }
            return theList;
        }

        public FMenu GetMenuDB(string MenuIID, GenericProgressFunction progress=null, int startfrom=0) {
            DataTable dt = db.GetDataTable("GetMenu", MenuIID);
            if (dt.Rows.Count > 0) {
                FMenu fm = new FMenu(dt);
                dt = this.GetEntitiesForMenuDB(MenuIID);
                for (int i = 0; i < dt.Rows.Count; i++) {
                    fm.items.Add(this.GetEntityDB(dt.Rows[i]["IID"].ToString()));
                    progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
                }
                fm.Distributions = this.GetDistributionList(MenuIID);
                return fm;
            } else
                return null;
        }

        /// <summary>
        /// Saves only menu's name
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public bool SaveMenu(FMenu menu) {
            return db.RunQuery("SaveMenu '" + menu.IID + "','" + menu.MenuName + "'");
        }

        /// <summary>
        /// Saves only menu's name
        /// </summary>
        /// <param name="menuIID"></param>
        /// <param name="menuName"></param>
        /// <returns></returns>
        public bool SaveMenu(string menuIID, string menuName) {
            return db.RunQuery("SaveMenu '" + menuIID + "','" + menuName + "'");
        }


        /// <summary>
        /// Saves the entire menu
        /// </summary>
        /// <param name="foodMenu"></param>
        public void SaveMenuDB(FMenu foodMenu) {
            //Delete old Database version
            //Save new Database version

            //This only saves the foodMenu entry in foodMenu table
            db.RunQuery("SaveMenu '" + foodMenu.IID + "','" + foodMenu.MenuName + "'");

            //Delete deleted Entities
            DataTable dt = db.GetDataTable("GetEntitiesForMenu", foodMenu.IID);
            for (int r = 0; r < dt.Rows.Count; r++) {
                string DBEntityIID = dt.Rows[r]["IID"].ToString();
                bool blnEntityRequired = false;
                for (int i = 0; i < foodMenu.items.Count; i++) {
                    if (((Entity)foodMenu.items[i]).IID == DBEntityIID) {
                        blnEntityRequired = true;
                        break;
                    }
                }
                if (!blnEntityRequired)
                    DeleteEntityDB(DBEntityIID);
                //Deletes Entity, its EntityButtons and all the entitybutton's priceitems
            }
            //Save this menu's entities
            for (int i = 0; i < foodMenu.items.Count; i++)
                this.SaveEntityDB((Entity)foodMenu.items[i]);

            //Delete distributions first
            this.DeleteAllDistributionsForMenu(foodMenu.IID);

            //Save this menu's global types
            for (int i = 0; i < foodMenu.Distributions.Count; i++) {
                Distribution distribution = foodMenu.Distributions[i];
                this.SaveDistribution(distribution);
            }

            //Re-Get the foodMenu from database
            foodMenu = GetMenuDB(foodMenu.IID);
            //Now Save Serialized version
            SaveMenuA(foodMenu);
        }

        public bool DeleteMenuDB(string MenuIID) {
            //Delete database version
            return db.RunQuery("DeleteMenu", MenuIID);
        }
        public Entity GetEntityDB(string EntityIID,GenericProgressFunction progress=null, int startfrom=0) {
            DataRow dr = db.GetDataTable("GetEntity", EntityIID).Rows[0];
            Entity entity = new Entity(dr);

            DataTable dt = this.GetEntityButtonsForEntityDB(entity.IID);
            for (int i = 0; i < dt.Rows.Count; i++) {
                EntityButton eb = this.GetJustEntityButton(dt.Rows[i]["IID"].ToString());
                entity.Buttons.Add(eb);
                progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            }
            return entity;
        }

        public DataTable GetEntitiesForMenuDB(string ParentMenuIID) {
            return db.GetDataTable("GetEntitiesForMenu", ParentMenuIID);
        }

        public DataTable GetEntitiesByType(string ParentMenuIID, EntityTypes EntityType) {
            return db.GetDataTable("GetEntitiesByType '" + ParentMenuIID + "'," + (int)EntityType);
        }

        public EntityView GetEntityView(string IID) {
            return new EntityView(db.GetDataTable("Select * from Entity where IID = '" + IID + "'"));
        }

        public bool SaveEntityView(EntityView entity) {
            CultureInfo ci = GetDBCulture();
            //This only saves the entity in the EntityTable
            return db.RunQuery("SaveEntity '" + entity.IID + "','" + entity.EntityName.Replace("'", "''") + "'," +
                               entity.DisplayOrder + "," + entity.PanelColor + "," + entity.ButtonHeight + "," +
                               entity.ButtonWidth + ",'" + entity.SizeBarIID + "','" +
                               entity.DivisionBarIID + "','" + entity.ParentMenuIID + "'," +
                               (int)entity.EntityType + ",'" + entity.TaxPercent.ToString(ci) + "','" +
                               entity.DistributionIID + "','" + entity.DistributionName + "','" +
                               entity.FFamily + "','" + entity.FSize.ToString() + "','" + entity.FStyle + "'");
        }

        public bool SaveJustEntity(Entity entity) {
            CultureInfo ci = GetDBCulture();
            //This only saves the entity in the EntityTable
            return db.RunQuery("SaveEntity '" + entity.IID + "','" + entity.EntityName.Replace("'", "''") + "'," +
                        entity.DisplayOrder + "," + entity.BackColour + "," + entity.ButtonHeight + "," +
                        entity.ButtonWidth + ",'" + entity.ParentMenuIID + "'," +
                        (int)entity.entityType + ",'" + entity.DistributionIID + "','" + entity.DistributionName + "','" +
                        entity.FFamily + "','" + entity.FSize.ToString(ci) + "','" + entity.FStyle + "'," + entity.ForeColour);
        }

        public bool SetEntityDisplayOrder(string EntityIID, int displayOrder) {
            return db.RunQuery("Update Entity set DisplayOrder = " + displayOrder + " where IID = '" + EntityIID + "'");
        }

        public void SaveEntityDB(Entity entity) {



            EntityButton eb = null;

            DeleteEntityDB(entity.IID);
            CultureInfo ci = GetDBCulture();
            //This only saves the entity in the EntityTable
            db.RunQuery("SaveEntity '" + entity.IID + "','" + entity.EntityName.Replace("'", "''") + "'," +
                        entity.DisplayOrder + "," + entity.BackColour + "," + entity.ButtonHeight + "," +
                        entity.ButtonWidth + ",'" + entity.ParentMenuIID + "'," +
                        (int)entity.entityType + ",'" + entity.DistributionIID + "','" + entity.DistributionName + "','" +
                        entity.FFamily + "','" + entity.FSize.ToString(ci) + "','" + entity.FStyle + "'," + entity.ForeColour);



            DataTable dt = this.GetEntityButtonsForEntityDB(entity.IID);
            for (int r = 0; r < dt.Rows.Count; r++) {
                string DBEntityButtonIID = dt.Rows[r]["IID"].ToString();
                bool blnEntityButtonRequired = false;
                //for (int i = 0; i < entity.Buttons.Count; i++) {
                //    if (((EntityButton)entity.Buttons[i]).IID == DBEntityButtonIID) {
                //        blnEntityButtonRequired = true;
                //        break;
                //    }
                //}

                blnEntityButtonRequired = entity.Buttons.Find(x => x.IID == DBEntityButtonIID) != null;


                if (!blnEntityButtonRequired)
                    this.DeleteEntityButtonDB(DBEntityButtonIID);
            }

            for (int i = 0; i < entity.Buttons.Count; i++) {
                eb = (EntityButton)entity.Buttons[i];
                eb.DisplayOrder = i;
                this.SaveJustEntityButton(eb, entity.ParentMenuIID);
            }
        }

        public bool DeleteEntityDB(string EntityIID) {
            DataTable dt = GetEntityButtonsForEntityDB(EntityIID);
            for (int i = 0; i < dt.Rows.Count; i++)
                DeleteEntityButtonDB(dt.Rows[i]["IID"].ToString());
            return db.RunQuery("DeleteEntity", EntityIID);
        }

        public DataTable GetActiveEntityList() {
            //This should call EntityList for active food Menu but as far as the server is concerned what is the active Menu?
            return db.GetDataTable("GetEntityListForMenu", ActiveMenu.IID);
        }

        public DataTable GetActiveNormalEntityList() {
            //This should call EntityList for active food Menu but as far as the server is concerned what is the active Menu?
            return db.GetDataTable("GetNormalEntitiesForMenu", ActiveMenu.IID);
        }

        public float GetEBTaxPercent(EntityButton eb) {
            if (AttachedOrder == null)
                return 0.0f;
            switch (AttachedOrder.OrderType) {
                case OrderTypes.DirectSale:
                    return eb.DirectSaleTaxPercent;
                case OrderTypes.InHouse:
                    return eb.InHouseTaxPercent;
                case OrderTypes.TakeAwayB:
                case OrderTypes.InternetTakeAway:
                    return eb.TakeAwayTaxPercent;
                case OrderTypes.Delivery:
                case OrderTypes.InternetDelivery:
                    return eb.DeliveryTaxPercent;
                default:
                    return eb.DirectSaleTaxPercent;
            }
        }
        public float GetEBTaxPercentForGenericOrder(Order order, EntityButton eb) {
            if (order == null)
                return 0.0f;
            switch (order.OrderType) {
                case OrderTypes.DirectSale:
                    return eb.DirectSaleTaxPercent;
                case OrderTypes.InHouse:
                    return eb.InHouseTaxPercent;
                case OrderTypes.TakeAwayB:
                case OrderTypes.InternetTakeAway:
                    return eb.TakeAwayTaxPercent;
                case OrderTypes.Delivery:
                case OrderTypes.InternetDelivery:
                    return eb.DeliveryTaxPercent;
                default:
                    return eb.DirectSaleTaxPercent;
            }
        }


        public EntityButton GetJustEntityButton(string EntityButtonIID) {
            return new EntityButton(db.GetDataTable("GetEntityButton", EntityButtonIID).Rows[0]);
        }

        public DataTable GetEntityButtonsForEntityDB(string PEIID) {
            return db.GetDataTable("GetEntityButtonsForEntity", PEIID);
        }
        public DataTable GetEntityButtonsForEntityDBWithImage(string PEIID) {
            return db.GetDataTable("GetEntityButtonsForEntityWithImage", PEIID);
        }
        public DataTable GetSubEntityButtonsForEntityButtonDB(string PEBIID) {
            return db.GetDataTable("GetSubEntityButtonsForEntityButton", PEBIID);
        }

        public bool SetEntityButtonDisplayOrder(string EBIID, int displayOrder) {
            return db.RunQuery("Update EntityButton set DisplayOrder = " + displayOrder + " where IID = '" + EBIID + "'");
        }

        public bool SaveJustEntityButton(EntityButton entityButton, string ParentMenuIID) {

           // CultureInfo uici = GetUICulture();
            CultureInfo dbci = GetDBCulture();
            return
                db.RunQuery("SaveEntityButton '" + entityButton.IID + "','" +
                            entityButton.EntityButtonName.Replace("'", "''") + "'," +
                            entityButton.DisplayOrder + "," + entityButton.ButtonColor + "," + entityButton.ForeColor +
                            "," +
                            (int)entityButton.ButtonType + "," + entityButton.AvailableFor + ",'" +
                            entityButton.PEIID + "','" + ParentMenuIID + "'," +
                            entityButton.Compulsary + ",'" + entityButton.Barcode + "','" +
                            entityButton.DirectSaleTaxPercent.ToString(dbci) + "','" +
                            entityButton.InHouseTaxPercent.ToString(dbci) + "','" +
                            entityButton.TakeAwayTaxPercent.ToString(dbci) + "','" +
                            entityButton.DeliveryTaxPercent.ToString(dbci) + "'," +
                            (int)entityButton.PadFlag + ",'" +
                            entityButton.DistributionIID + "'," +
                            entityButton.DirectSalePrice.ToString(dbci) + "," +
                            entityButton.InHousePrice.ToString(dbci) + "," +
                            entityButton.TakeAwayPrice.ToString(dbci) + "," +
                            entityButton.DeliveryPrice.ToString(dbci) + "," +
                            entityButton.ButtonWidth + "," +
                            entityButton.ButtonHeight + ",'" +
                            entityButton.FFamily + "','" +
                            entityButton.FSize.ToString(dbci) + "','" +
                            entityButton.FStyle + "'," + 
                            db.BoolToInt(entityButton.WithImage));
        }

        public void DeleteEntityButtonDB(string EntityButtonIID) {
            db.RunQuery("DeleteEntityButton", EntityButtonIID);
        }

        public void DeleteEntityButtonsForEntityDB(string PEIID) {
            db.RunQuery("DeleteEntityButtonsForEntity", PEIID);
        }

        public DataTable GetEntityC(string EntityIID) {
            return db.GetDataTable("GetEntity", EntityIID);
        }

        public Entity GetJustEntity(string EntityIID) {
            return new Entity(GetEntityC(EntityIID));
        }

        #endregion

        #region EMPLOYEE FUNCTIONS
        public Employee GetEmployee(string IID) {
            return new Employee(db.GetDataTable("GetEmployee", IID));
        }

        public DataTable GetAllEmployees() {
            return db.GetDataTable("GetAllEmployees");
        }
        public List<Employee> GetAllEmployeeList() {
            DataTable dt = db.GetDataTable("GetAllEmployees");
            List<Employee> theList = new List<Employee>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new Employee(dt.Rows[i]));
            }
            return theList.OrderBy(x => x.EmployeeName).ToList();
        }
        public bool SaveEmployee(Employee employee) {
            if (employee == null)
                return false;

            try {
                db.RunQuery("SaveEmployee '" + employee.IID + "','" + employee.EmployeeName + "','" + 
                    employee.Rate + "'," + db.BoolToInt(employee.Shortable));
                return true;
            } catch {
                return false;
            }
        }
        public bool SaveEmployeeList(List<Employee> theList) {
            if (theList != null) {
                try {
                    foreach (Employee item in theList) {
                        SaveEmployee(item);
                    }
                    return true;
                } catch {
                    return false;
                }
            }
            return false;
        }
        public void DeleteEmployee(string IID) {
            db.RunQuery("DeleteEmployee", IID);
        }

        #endregion

        #region "CUSTOMER FUNCTIONS"

        public Customer GetCustomer(string IID) {
            return new Customer(db.GetDataTable("GetCustomer", IID));
        }

        public DataTable GetAllCustomers() {
            return db.GetDataTable("GetAllCustomers");
        }
        public List<Customer> GetAllCustomerList() {
            DataTable dt = db.GetDataTable("GetAllCustomers");
            List<Customer> theList = new List<Customer>();
            for (int i=0; i < dt.Rows.Count; i++) {
                theList.Add(new Customer(dt.Rows[i]));
            }
            return theList;
        }
        public bool SaveCustomer(Customer customer) {
            if (customer == null)
                return false;

            try {
                db.RunQuery("SaveCustomer '" + customer.IID + "','" + customer.CName + "','" + customer.CompanyName +
                            "','" +
                            customer.Buzzer + "','" + customer.PostCode + "','" + customer.Address + "','" +
                            customer.Town + "','" + customer.Tel + "','" + customer.Mobile + "','" +
                            customer.Email + "','" + customer.CPassword + "'");
                return true;
            } catch {
                return false;
            }
        }
        public bool SaveCustomerList(List<Customer> theList) {
            if (theList != null) {
                try {
                    foreach (Customer item in theList) {
                        SaveCustomer(item);
                    }
                    return true;
                } catch {
                    return false;
                }
            }
            return false;
        }

        public void DeleteCustomer(string IID) {
            //Check order table if this Customer IID repeated more than once do not delete customer 
            db.RunQuery("DeleteCustomer", IID);
        }

        public DataTable SearchCustomersByName(string CName) {
            return db.GetDataTable("SearchCustomersByName", CName);
        }

        public DataTable SearchCustomersByAddress(string CAddress) {
            return db.GetDataTable("SearchCustomersByAddress", CAddress);
        }

        public DataTable SearchCustomersByTel(string CTelNumber) {
            return db.GetDataTable("SearchCustomersByTel", CTelNumber);
        }

        public DataTable SearchCustomersByPostCode(string CPostCode) {
            return db.GetDataTable("SearchCustomersByPostCode", CPostCode);
        }

        public DataTable SearchCustomersByEmail(string Email) {
            return db.GetDataTable("SearchCustomersByEmail", Email);
        }

        public DataTable GetCustomerPreviousOrders(string CustomerIID) {
            return db.GetDataTable("GetCustomerPreviousOrders", CustomerIID);
        }

        public int GetCustomerPreviousOrdersCount(string CustomerIID) {
            return db.GetDataTable("GetCustomerPreviousOrders", CustomerIID).Rows.Count;
        }

        public int GetCustomersCountByTel(string CTelNumber) {
            return db.GetDataTable("SearchCustomersByTel", CTelNumber).Rows.Count;
        }

        public Customer GetCustomerByTel(string CTelNumber) {
            return new Customer(db.GetDataTable("SearchCustomersByTel", CTelNumber));
        }

        public Customer GetCustomerByEmailAndPassword(string Email, string Password) {
            return new Customer(db.GetDataTable("GetCustomerByEmailAndPassword '" + Email.Replace("'", "''") + "','" +
                                                Password.Replace("'", "''") + "'"));
        }

        public Customer GetCustomerByEmailAndTel(string Email, string Tel) {
            return new Customer(db.GetDataTable("GetCustomerByEmailAndTel '" + Email.Replace("'", "''") + "','" +
                                                Tel.Replace("'", "''") + "'"));
        }

        public Customer GetCustomerByEmailTelAndPassword(string Email, string Tel, string Password) {
            return
                new Customer(db.GetDataTable("GetCustomerByEmailTelAndPassword '" + Email.Replace("'", "''") + "','" +
                                             Tel.Replace("'", "''") + "','" + Password.Replace("'", "''") + "'"));
        }

        #endregion

        #region "TABLE FUNCTIONS"

        public DataTable GetAllTableGroups() {
            return db.GetDataTable("GetTableGroups");
        }

        public TableGroup GetTableGroup(string IID) {
            return new TableGroup(db.GetDataTable("GetTableGroup '" + IID + "'"));
        }

        public Table GetTableByName(string TableName) {
            DataTable dt = db.GetDataTable("GetTableByItsName", TableName);
            if (dt.Rows.Count > 0)
                return new Table(dt.Rows[0]);
            else
                return null;
        }

        public List<Table> GetTableList() {
            List<Table> TableList = new List<Table>();
            DataTable dt = db.GetDataTable("GetAllTables");
            for (int i = 0; i < dt.Rows.Count; i++)
                TableList.Add(new Table(dt.Rows[i]));
            return TableList;
        }

        public List<Table> GetTableList(string GroupIID) {
            List<Table> TableList = new List<Table>();
            DataTable dt = db.GetDataTable("GetTablesByGroup '" + GroupIID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
                TableList.Add(new Table(dt.Rows[i]));
            return TableList;
        }

        public bool IsPrimaryTable(string TableIID) {
            Table table = GetTable(TableIID);
            if (table == null)
                return false;
            return table.isPrimary;
        }
        public bool HasSubTables(string TableIID) {
            Table table = GetTable(TableIID);
            if (table.TableType == TableTypes.TemporaryTable) {
                TableIID = table.ParentTableIID;
                return true;
            }
            return db.GetDataTable("GetTableAndSubTables '" + TableIID + "'").Rows.Count > 1;
        }

        public Table GetFirstSubTable(string TableIID, bool blnWithOrder) {
            try {
                Table table = GetTable(TableIID);
                if (table.TableType == TableTypes.TemporaryTable) {
                    return table;
                } else {
                    DataTable dt = db.GetDataTable("Select * from Tables where ParentTableIID = '" + TableIID +
                                                   "' order by DisplayOrder asc");
                    if (blnWithOrder)
                        return BarrowTable(dt.Rows[0]["IID"].ToString());
                    else
                        return new Table(dt.Rows[0]);
                }
            } catch {
                return null;
            }
        }
        public string GetFirstSubTableIID(string TableIID) {
            DataTable dt = db.GetDataTable("Select * from Tables where ParentTableIID = '" + TableIID +
                                                   "' order by DisplayOrder asc");
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["IID"].ToString();
            else
                return "";
        }

        public string GenerateSubTableName(Table mainTable) {
            List<Table> subTableList = GetTableAndSubTables(mainTable.IID);
            // char test = 'A';
            //MessageBox.Show(((int) test).ToString());
            bool blnFound;// = false;

            for (int i = 65; i < 70; i++) {
                string str = ((char)i).ToString();
                blnFound = false;
                for (int x = 0; x < subTableList.Count; x++) {
                    if (subTableList[x].TableName == mainTable.TableName + str) {
                        blnFound = true;
                        break;
                    }
                }
                if (!blnFound) {
                    return mainTable.TableName + str;
                }
            }
            return mainTable.TableName + "error";
        }

        public void GetRidOfBlankTemporaryTablesForThisTerminalWithNoOrders() {
            string sql = "Delete from Tables where TableType = '" + (int)TableTypes.TemporaryTable +
                         "' and CurrentOrderIID ='' and (LockedClientIP = '' or LockedClientIP = '" +
                         config.Terminal_Name + "')";
            db.RunQuery(sql);
        }

        public bool AddSubTableWithTest(string rootTableIID) {
            if (string.IsNullOrEmpty(rootTableIID))
                return false;
            else {
                Table mainTable = GetParentTable(rootTableIID);
                Table subTable = mainTable.CreateSubTable();
                subTable.TableName = GenerateSubTableName(mainTable);
                return SaveTable(subTable);
            }
        }
        public Table AddSubTable(string rootTableIID) {
            if (string.IsNullOrEmpty(rootTableIID))
                return null;
            else {
                Table mainTable = GetParentTable(rootTableIID);
                Table subTable = mainTable.CreateSubTable();
                subTable.TableName = GenerateSubTableName(mainTable);
                if (SaveTable(subTable))
                    return subTable;
                else
                    return null;
            }
        }
        public List<Table> GetTableAndSubTables(string TableIID) {
            Table table = GetTable(TableIID);
            if (table.TableType == TableTypes.TemporaryTable)
                TableIID = table.ParentTableIID;

            //GetTableAndSubTables
            List<Table> TableList = new List<Table>();
            DataTable dt = db.GetDataTable("GetTableAndSubTables '" + TableIID + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
                TableList.Add(new Table(dt.Rows[i]));
            return TableList;
        }

        public DataTable GetAllTables() {
            return db.GetDataTable("GetAllTables");
        }


        public Table BarrowTable(string TableIID) {
            try {
                //Get Table 
                Table table = GetTable(TableIID);

                if (table.IsBusy(config.Terminal_Name))
                    //if busy return null
                    return null;
                else {
                    if (!string.IsNullOrEmpty(table.CurrentOrderIID)) {
                        //if table has order attached to it
                        //set table ClientIP(busy), set table OrderIID(occupied) , set order tableIID, set order ClientIP (busy), 
                        Order order = GetOrder(table.CurrentOrderIID);
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
                    } else {
                        //create a new order
                        Order order = new Order(OrderTypes.InHouse) {
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
            } catch {
                return null;
            }
        }

        ///Used to return an inhouse order
        public void ReturnTable(Table table) {

            if (table.AttachedOrder == null) {
                table.LockedClientIP = "";
                table.CurrentOrderIID = "";
                table.TableCovers = 1;
                SaveTable(table);
                return;
            }
            if ((int)table.AttachedOrder.Status >= (int)StatusFlags.COMPLETED) {
                //Temporary tables should be deleted, Order should be set free
                if (table.TableType == TableTypes.TemporaryTable) {
                    //Delete table
                    DeleteTable(table.IID);
                } else {
                    //unbusy table, delete order details from table
                    table.LockedClientIP = "";
                    table.CurrentOrderIID = "";
                    table.TableCovers = 1;
                    SaveTable(table);
                }
                //delete table details from order	
                table.AttachedOrder.TableIID = "";
            } else {
                if (table.AttachedOrder.items.Count > 0) {
                    //Order still active and has items so unbusy table, save table
                    table.LockedClientIP = "";
                    SaveTable(table);

                    //unbusy order, save order
                    table.AttachedOrder.LockedClientIP = "";
                    SaveOrder(table.AttachedOrder);
                } else {
                    //Temporary tables should be deleted, Order should be set free
                    if (table.TableType == TableTypes.TemporaryTable) {
                        //Delete table
                        DeleteTable(table.IID);
                    } else {
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
        private void ReturnTable(Order order) {
            Table table = GetTable(order.TableIID);
            if (table == null)
                return;
            if ((int)order.Status >= (int)StatusFlags.COMPLETED) {
                //Temporary tables should be deleted, Order should be set free
                if (table.TableType == TableTypes.TemporaryTable) {
                    //Delete table
                    DeleteTable(table.IID);
                } else {
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
            } else {
                if (order.items.Count > 0) {
                    //Order still active and has items so unbusy table, save table
                    table.LockedClientIP = "";
                    SaveTable(table);

                    //unbusy order, save order
                    order.LockedClientIP = "";
                    SaveOrder(order);
                } else {
                    //Temporary tables should be deleted, Order should be set free
                    if (table.TableType == TableTypes.TemporaryTable) {
                        //Delete table
                        DeleteTable(table.IID);
                    } else {
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
        public bool MoveTable(string sourceTableIID, string targetTableIID, bool blnLeaveSubTables) {
            bool blnSourcePrimary;
            bool blnTargetPrimary;
            bool blnTargetEmpty;
            bool blnSourceHasSubTables;
            bool blnTargetHasSubTables;

            Table sourceTable = GetTable(sourceTableIID);
            if (sourceTable.HasActiveOrder())
                sourceTable = BarrowTable(sourceTableIID);
            else
                return false;
            Table targetTable = GetTable(targetTableIID);
            if (targetTable.HasActiveOrder())
                targetTable = BarrowTable(targetTableIID);
            blnSourcePrimary = sourceTable.TableType == TableTypes.StaticTable;
            blnSourceHasSubTables = HasSubTables(sourceTableIID);
            blnTargetHasSubTables = HasSubTables(targetTableIID);
            blnTargetPrimary = targetTable.TableType == TableTypes.StaticTable;
            blnTargetEmpty = !targetTable.HasActiveOrder();

            Order sourceOrder;
            //Order targetOrder;
            Table subTargetTable;


            if (blnSourcePrimary) {
                if (blnSourceHasSubTables) {
                    if (blnTargetPrimary) {
                        if (blnTargetEmpty) {
                            ///2-primary(YesSub) => empty primary                     =>primary+sub  primary+sub           OrderTransfer for primary + TableTransfer for sub tables
                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            AttachOrderToTable(sourceOrder, targetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            targetTable.TableName = sourceTable.TableName;

                            ReturnTable(sourceTable);
                            ReturnTable(targetTable);

                            if (blnLeaveSubTables) {
                                //transfer first sub table to primary table
                                MoveTable(GetFirstSubTableIID(sourceTableIID), sourceTableIID, false);
                            } else {
                                //attach subtable to new parent table
                                SetNewParentTableIIDForSubTables(sourceTableIID, targetTableIID);
                            }
                            return true;

                        } else {
                            //if (blnTargetHasSubTables) {
                            ///6-primary(YesSub) => full primary(with sub tables) =>primary+sub  primary+sub+sub+sub   Transfer(with subs including source primary becomes sub)    CreateSubTable
                            ///4-primary(YesSub) => full primary(no sub tables)   =>primary+sub  primary+sub+sub       Transfer(with subs including source primary becomes sub)   CreateSubTable 

                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            //create new target table
                            subTargetTable = AddSubTable(targetTableIID);
                            AttachOrderToTable(sourceOrder, subTargetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            subTargetTable.TableName = sourceTable.TableName;

                            ReturnTable(targetTable);
                            ReturnTable(sourceTable);
                            ReturnTable(subTargetTable);
                            if (blnLeaveSubTables) {
                                //transfer first sub table to primary table
                                MoveTable(GetFirstSubTableIID(sourceTableIID), sourceTableIID, false);
                            } else {
                                //attach subtable to new parent table
                                SetNewParentTableIIDForSubTables(sourceTableIID, targetTableIID);
                            }
                            return true;
                            //}
                        }
                    } else {
                        MessageBox.Show("Not implemented 1");
                    }
                } else {
                    if (blnTargetPrimary) {
                        if (blnTargetEmpty) {
                            ///1-primary(NoSub)  => empty primary                     =>primary      primary               OrderTransfer
                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            AttachOrderToTable(sourceOrder, targetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            targetTable.TableName = sourceTable.TableName;

                            ReturnTable(sourceTable);
                            ReturnTable(targetTable);
                            return true;
                        } else {
                            ///5-primary(NoSub) => full primary(with sub tables)         =>primary      primary+sub+sub       Transfer    CreateSubTable
                            ///3-primary(NoSub) => full primary(no sub tables)           =>primary      primary+sub           OrderTransfer    CreateSubTable

                            sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                            sourceTable = MakeTableFreeFromOrder(sourceTable);
                            //create new target table
                            subTargetTable = AddSubTable(targetTableIID);
                            AttachOrderToTable(sourceOrder, subTargetTable);

                            //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                            subTargetTable.TableName = sourceTable.TableName;
                            if (CheckifPrimaryTableNameExist(subTargetTable.TableName)) {
                                EnsureSubTableHasUniqueName(subTargetTable);
                            }
                            ReturnTable(targetTable);
                            ReturnTable(sourceTable);
                            ReturnTable(subTargetTable);
                            return true;
                        }
                    } else {
                        MessageBox.Show("Not implemented 2");
                    }
                }

            } else {
                if (blnTargetPrimary) {
                    if (blnTargetEmpty) {
                        ///7-sub => empty primary                                     =>sub          primary               Transfer

                        sourceOrder = MakeOrderFreeFromTable(sourceTable.AttachedOrder);
                        sourceTable = MakeTableFreeFromOrder(sourceTable);

                        AttachOrderToTable(sourceOrder, targetTable);
                        //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                        targetTable.TableName = sourceTable.TableName;

                        ReturnTable(targetTable);
                        DeleteTable(sourceTableIID);

                        return true;
                    } else {
                        ///9-sub => full primary(with sub tables)                 =>sub          primary+sub+sub       Transfer    CreateSubTable
                        ///8-sub => full primary(no sub tables)                   =>sub          primary+sub           Transfer    CreateSubTable
                        //attach subtable to new parent table
                        ChangeParentTableIIDForSubTable(sourceTableIID, targetTableIID);
                        sourceTable = BarrowTable(sourceTableIID);

                        //possibly renamed subtable is becoming a primary table so carry the subtable name ot new primary table
                        // targetTable.TableName = sourceTable.TableName;

                        ReturnTable(sourceTable);
                        ReturnTable(targetTable);
                        return true;
                    }
                } else {
                    MessageBox.Show("Not implemented 3");
                }
            }
            return false;
        }

        private void EnsureSubTableHasUniqueName(Table t) {
            if (t == null)
                return;
            if (!t.isPrimary) {
                if (CheckifPrimaryTableNameExist(t.TableName))
                    t.TableName +=  t.TableName;
                //ChangeSubTableName(t, t.TableName + t.TableName);

            }
        }

        private bool CheckifPrimaryTableNameExist(string subName) {
            return db.GetDataTable("Select DefaultName from Tables where DefaultName = '" + subName + "'").Rows.Count > 0;
        }

        private bool ChangeSubTableName(Table subTable, string newSubName) {
            return db.RunQuery("Update Tables set TableName ='" + newSubName + "' where IID ='" + subTable.IID + "'");
        }

        private Order MakeOrderFreeFromTable(Order order) {
            order.TableIID = "";
            order.TableName = "";
            order.LockedClientIP = "";
            return order;
        }

        private Order AttachOrderToTable(Order order, Table table) {
            order.TableIID = table.IID;
            order.TableName = table.TableName;
            table.AttachedOrder = order;
            table.CurrentOrderIID = order.IID;
            return order;
        }

        private Table MakeTableFreeFromOrder(Table table) {
            table.CurrentOrderIID = "";
            table.LockedClientIP = "";
            return table;
        }

        private Table MakeTableFreeFromOrderAndParentTable(Table table) {
            table.ParentTableIID = "";
            table.CurrentOrderIID = "";
            table.LockedClientIP = "";
            return table;
        }

        public List<string> GetSubTableIIDList(Table mainTable) {
            DataTable dt = db.GetDataTable("Select IID from Tables where ParentTableIID ='" + mainTable.IID + "'");
            List<string> theList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
                theList.Add(dt.Rows[i]["IID"].ToString());
            return theList;
        }

        public bool SetNewParentTableIIDForSubTables(string oldParentTableIID, string newParentTableIID) {
            return
                db.RunQuery("update Tables set ParentTableIID ='" + newParentTableIID + "' where ParentTableIID ='" +
                            oldParentTableIID + "'");
        }

        public bool ChangeParentTableIIDForSubTable(string subTableIID, string newParentTableIID) {
            return db.RunQuery("update Tables set ParentTableIID ='" +
                newParentTableIID + "' where IID ='" + subTableIID + "'");
        }

        /// <summary>
        /// TABLE MERGE ACTION
        /// Source table cannot be primary table (static table)
        /// </summary>
        /// <param name="sourceTableIID"></param>
        /// <param name="targetTableIID"></param>
        /// <returns></returns>
        public bool MergeTable(string sourceTableIID, string targetTableIID) {
            Table sourceTable = BarrowTable(sourceTableIID);
            if (sourceTable.TableType == TableTypes.StaticTable) {
                ReturnTable(sourceTable);
                return false;
            }

            Table targetTable = BarrowTable(targetTableIID);
            targetTable.AttachedOrder.MergeOrder(sourceTable.AttachedOrder);
            DeleteOrder(sourceTable.CurrentOrderIID);
            if (sourceTable.TableType == TableTypes.TemporaryTable)
                DeleteTable(sourceTableIID);
            else
                MakeTableFreeFromOrder(sourceTable);
            ReturnTable(targetTable);

            return true;
        }

        public Table GetTable(string TableIID) {
            DataTable dt = db.GetDataTable("GetTable", TableIID);
            if (dt.Rows.Count > 0)
                return new Table(dt.Rows[0]);
            else
                return null;
        }

        public Table GetParentTable(string TableIID) {
            Table testTable = GetTable(TableIID);
            if (testTable.TableType == TableTypes.StaticTable)
                return testTable;
            else
                return GetTable(testTable.ParentTableIID);
        }

        public bool SaveTable(Table table) {
            if (table.DefaultName == null)
                table.DefaultName = table.TableName;
            return db.RunQuery("SaveTable '" + table.IID + "'," + table.Number + ",'" +
                               table.TableName + "'," + table.TableCovers + ",'" + table.LockedClientIP + "','" +
                               table.CurrentOrderIID + "'," + (int)table.TableType + "," + table.XLocation + "," +
                               table.YLocation +
                               "," + table.Width + "," + table.Height + ",'" + table.GroupIID + "','" +
                               table.ParentTableIID + "'," + (int)table.Shape + ",'" + table.DefaultName + "'");
        }

        public void DeleteTable(string TableIID) {
            db.RunQuery("DeleteTable", TableIID);
        }

        public void FreeTheTable(string TableIID) {
            Table table = GetTable(TableIID);
            if (table != null) {
                Order order = GetOrder(table.CurrentOrderIID);
                if (order != null) {
                    if (order.items.Count == 0)
                        DeleteOrderOnly(order);
                    else {
                        order.TableIID = "";
                        order.LockedClientIP = "";
                        SaveOrder(order);
                    }
                }
                if (table.TableType == TableTypes.TemporaryTable)
                    DeleteTable(TableIID);
                else {
                    table.CurrentOrderIID = "";
                    table.LockedClientIP = "";
                    table.TableCovers = 1;
                    SaveTable(table);
                }
            }
        }

        public Table SetTableStatusAndGetTableIfRequiredM(string TableIID, bool blnBusy, string ClientIP) {
            if (TableIID == "0") {
                db.RunQuery("DisconnectClientFromTables", ClientIP);
                return null;
            } else {
                Table table = GetTable(TableIID);
                if (table.IsBusy(ClientIP))
                    return null;
                else {
                    if (blnBusy) {
                        table.LockedClientIP = ClientIP;
                        SaveTable(table);
                        if (table.CurrentOrderIID != "" && table.CurrentOrderIID != null) {
                            Order order = GetOrder(table.CurrentOrderIID);
                            if (order != null) {
                                order.TableIID = table.IID;
                                order.LockedClientIP = ClientIP;
                                SaveOrder(order);
                            }
                        }
                        return table;
                    } else {
                        table.LockedClientIP = "";
                        SaveTable(table);
                        if (table.CurrentOrderIID != "" && table.CurrentOrderIID != null) {
                            Order order = GetOrder(table.CurrentOrderIID);
                            if (order != null) {
                                order.TableIID = "";
                                order.LockedClientIP = "";
                                SaveOrder(order);
                            }
                        }
                        return null;
                    }
                }
            }
        }

        public bool IsTableNameExist(string TableName) {
            return db.GetDataTable("GetTableByItsName", TableName).Rows.Count > 0 ? true : false;
        }

        public bool IsTableExist(string TableIID) {
            try {
                return (db.GetDataTable("GetTable", TableIID).Rows.Count > 0);
            } catch {
                return false;
            }
        }

        public void CreateDummyTablesAndGroups() {
            TableGroup group1 = CreateDummyTableGroup("First Floor");
            if (group1 != null) {
                Table tb = new Table("Sample Table 1", 2);
                tb.TableType = TableTypes.StaticTable;
                tb.TableCovers = 4;
                tb.XLocation = 30;
                tb.YLocation = 30;
                tb.Width = 200;
                tb.Height = 90;
                tb.Shape = ButtonShapeTypes.Circle;
                tb.GroupIID = group1.IID;
                SaveTable(tb);

                tb = new Table("Sample Table 2", 3);
                tb.TableType = TableTypes.StaticTable;
                tb.TableCovers = 3;
                tb.XLocation = 160;
                tb.YLocation = 160;
                tb.Width = 100;
                tb.Height = 50;
                tb.Shape = ButtonShapeTypes.Rectangle;
                tb.GroupIID = group1.IID;
                SaveTable(tb);
            }
            TableGroup group2 = CreateDummyTableGroup("Second Floor");
            if (group2 != null) {
                Table tb = new Table("A", 4);
                tb.TableType = TableTypes.StaticTable;
                tb.TableCovers = 4;
                tb.XLocation = 21;
                tb.YLocation = 10;
                tb.Width = 130;
                tb.Height = 50;
                tb.Shape = ButtonShapeTypes.Rectangle;
                tb.GroupIID = group2.IID;
                SaveTable(tb);

                tb = new Table("B", 6);
                tb.TableType = TableTypes.StaticTable;
                tb.TableCovers = 6;
                tb.XLocation = 60;
                tb.YLocation = 120;
                tb.Width = 180;
                tb.Height = 140;
                tb.Shape = ButtonShapeTypes.Rectangle;                
                tb.GroupIID = group2.IID;
                SaveTable(tb);
            }
        }

        public TableGroup CreateDummyTableGroup(string groupName) {
            TableGroup group = new TableGroup(groupName);
            if (group.Save(db))
                return group;
            else
                return null;
        }
        #endregion

        #region "DISTRIBUTION FUNCTIONS"

        public List<Distribution> GetDistributionList(string ActiveMenuIID) {
            List<Distribution> DistributionList = new List<Distribution>();
            DataTable dt = db.GetDataTable("GetDistributions", ActiveMenuIID);
            for (int i = 0; i < dt.Rows.Count; i++)
                DistributionList.Add(new Distribution(dt.Rows[i]));
            return DistributionList;
        }

        public string GetDistributionPrinterNetworkName(string DistributionIID) {
            try {
                return
                    db.GetDataTable("GetDistributionPrinterNetworkName", DistributionIID).Rows[0]["NetworkName"].ToString();
            } catch {
                return "";
            }
        }

        public DataTable GetAllDistributions(string ActiveMenuIID) {
            return db.GetDataTable("GetDistributions", ActiveMenuIID);
        }

        public Distribution GetDistribution(string DistributionIID) {
            return new Distribution(db.GetDataTable("GetDistribution", DistributionIID).Rows[0]);
        }

        public bool SaveDistribution(Distribution ft) {
            try {
                return db.RunQuery("SaveDistribution '" + ft.IID + "','" + ft.DistributionName + "','" +
                                   ft.ShortName + "','" + ft.PrinterIID + "','" + ft.ParentMenuIID + "'," + ft.DisplayOrder);
            } catch {
                return false;
            }
        }

        public bool DeleteDistribution(string DistributionIID) {
            return db.RunQuery("DeleteDistribution", DistributionIID);
        }

        public bool DeleteAllDistributionsForMenu(string MenuIID) {
            return db.RunQuery("DeleteAllDistributionsForMenu", MenuIID);
        }

        #endregion

        #region "ORDER FUNCTIONS"
        public List<Order> GetXOrderList() {
            List<Order> xOrderList = new List<Order>();
            DataTable dt = db.GetDataTable("SELECT * from XOrders where SessionIID = '" + luv.CurrentSessionIID + "' order by OrderDate");
            for (int i = 0; i < dt.Rows.Count; i++)
                xOrderList.Add(GetXOrder(dt.Rows[i]["IID"].ToString()));
            return xOrderList;
        }
        public Order GetXOrder(string IID) {
            DataTable dt = db.GetDataTable("SELECT * from XOrders where IID = '" + IID + "'");
            if (dt.Rows.Count > 0) {
                //create order
                Order xorder = new Order(dt);
                //add order items
                DataTable dtItems = db.GetDataTable("GetAllXOrderItems", xorder.IID);

                for (int i = dtItems.Rows.Count - 1; i >= 0; i--)
                    xorder.items.Add(new OrderItem(dtItems.Rows[i]));
                return xorder;
            } else
                return null;
        }
        public bool SaveXOrder(Order xorder) {
            CultureInfo ci = GetDBCulture();
            try {                
                if (
                    db.RunQuery("SaveXOrder  '" + xorder.IID + "','" + xorder.TableIID + "'," +
                                DRDateTime.DatetimeToMSSql(xorder.OrderDate) + "," +
                                xorder.Covers + "," + (int)xorder.OrderType + "," + (int)xorder.Payment + ",'" +
                                xorder.CustomerIID + "','" + xorder.SessionIID + "'," + (int)xorder.Status + ",'" +
                                xorder.LockedClientIP + "','" + xorder.Instruction + "'," + xorder.MoneyPaid.ToString(ci) +
                                ",'" +
                                xorder.PaymentFlag + "','" +
                                xorder.TableName + "','" + xorder.CName + "','" + xorder.PostCode + "','" + xorder.Address +
                                "','" + xorder.Buzzer + "','" +
                                xorder.Town + "','" + xorder.Tel + "','" + xorder.Mobile + "','" + xorder.Email + "','" +
                                xorder.UserName + "','" + xorder.Reference + "'")) {

                    for (int i = 0; i < xorder.items.Count; i++)
                        SaveXOrderItem(xorder.items[i]);
                   
                    return true;
                } else
                    return false;
            } catch {
                return false;
            }

        }
        private void SaveXOrderItem(OrderItem oi) {
            try {
                CultureInfo ci = GetDBCulture();
                if (db.RunQuery("SaveXOrderItem '" +
                                oi.IID + "','" + oi.EntityIID + "','" + oi.OrderItemText + "'," + oi.Quantity + ",'" +
                                oi.Price.ToString(ci) + "','" + oi.OrderGroupIID + "','" + oi.EntityButtonIID + "','" +
                                oi.DistributionIID + "','" + oi.ParentOrderIID + "'," + (int)oi.ItemType + "," +
                                oi.dorder + ",'" +
                                oi.EntityName + "'," + oi.EntityDisplayOrder + ",'" +
                                oi.TaxPercent.ToString(ci) + "'," + oi.CompletedQuantity)) {

                }
            } catch {
            }
        }





        public List<Order> GetOrderList() {
            List<Order> OrderList = new List<Order>();
            DataTable dt = db.GetDataTable("GetSessionOrders",luv.CurrentSessionIID);
            for (int i = 0; i < dt.Rows.Count; i++)
                OrderList.Add(GetOrder(dt.Rows[i]["IID"].ToString()));
            return OrderList;
        }

        public DataTable GetOrders() {
            return db.GetDataTable("GetSessionOrders",luv.CurrentSessionIID);
        }

        public DataTable GetSessionOrdersByStatus(StatusFlags InclusiveStatus) {
            return
                db.GetDataTable("GetSessionOrdersByStatus '" + luv.CurrentSessionIID + "'," +
                                (int)InclusiveStatus);
        }

        public DataTable GetSessionOrdersByType(string SessionIID, OrderTypes OrderType1, OrderTypes OrderType2,
            OrderTypes OrderType3) {
            return
                db.GetDataTable("GetSessionOrdersByType '" + SessionIID + "'," + (int)OrderType1 + "," +
                                (int)OrderType2 +
                                "," + (int)OrderType3);
        }

        public Order GetOrder(string IID) {
            DataTable dt = db.GetDataTable("GetOrder", IID);
            if (dt.Rows.Count > 0) {
                //create order
                Order order = new Order(dt);
                //add order items
                DataTable dtItems = this.GetAllOrderItems(order.IID);

                for (int i = dtItems.Rows.Count - 1; i >= 0; i--)
                    order.items.Add(this.GetOrderItem(dtItems.Rows[i]["IID"].ToString()));
                return order;
            } else
                return null;
        }

        public Order GetLastOrder() {
            DataTable dt = db.GetDataTable("GetLastOrder");
            if (dt.Rows.Count > 0) {
                //create order
                Order order = new Order(dt);
                //add order items
                DataTable dtItems = this.GetAllOrderItems(order.IID);

                for (int i = dtItems.Rows.Count - 1; i >= 0; i--)
                    order.items.Add(this.GetOrderItem(dtItems.Rows[i]["IID"].ToString()));
                return order;
            } else
                return null;
        }

        public StatusFlags GetOrderStatus(string OrderIID) {
            return GetOrder(OrderIID).Status;
        }
        public bool isOrderPaid(string OrderIID)
        {
            try
            {
                DataTable dt = db.GetDataTable("select  cast((MoneyPaid - CalculatedValue) as decimal)  as isPaid from OrdersView where IID = '" + OrderIID + "'");
                string str = dt.Rows[0]["isPaid"].ToString();
                decimal val = decimal.Parse(str);
                return val >= 0;
            } catch (Exception ex) {
                return false; 
            }
        }

        public DataTable GetPrintableOrders() {
            return db.GetDataTable("GetPrintableOrders");
        }

        public DataTable GetPrintableInternetOrders() {
            return db.GetDataTable("GetPrintableInternetOrders");
        }

        public DataTable GetPrintableStoreList() {
            return db.GetDataTable("GetAllUnPrintedStoreList");
        }

        public bool SaveOrder(Order order) {
            CultureInfo ci = GetDBCulture();
            try {
                string OrderIID = order.IID;
                if (order.SessionIID == "" || order.SessionIID == null)
                    order.SessionIID = luv.CurrentSessionIID;

                if (
                    db.RunQuery("SaveOrder  '" + order.IID + "','" + order.TableIID + "'," +
                                DRDateTime.DatetimeToMSSql(order.OrderDate) + "," +
                                order.Covers + "," + (int)order.OrderType + "," + (int)order.Payment + ",'" +
                                order.CustomerIID + "','" + order.SessionIID + "'," + (int)order.Status + ",'" +
                                order.LockedClientIP + "','" + order.Instruction + "'," + order.MoneyPaid.ToString(ci) +
                                ",'" +
                                order.PaymentFlag + "','" +
                                order.TableName + "','" + order.CName + "','" + order.PostCode + "','" + order.Address +
                                "','" + order.Buzzer + "','" +
                                order.Town + "','" + order.Tel + "','" + order.Mobile + "','" + order.Email + "','" +
                                order.UserName + "','" + order.Reference + "','" + order.ServiceChargeRate + "','" + order.ServiceChargeTaxRate + "'")) {

                    for (int i = 0; i < order.items.Count; i++)
                        SaveOrderItem((OrderItem)order.items[i]);

                    DataTable dtItems = this.GetAllOrderItems(order.IID);

                    for (int i = dtItems.Rows.Count - 1; i >= 0; i--) {
                        OrderItem oi = order.GetOrderItem(dtItems.Rows[i]["IID"].ToString());
                        if (oi == null)
                            db.RunQuery("DeleteOrderItem", dtItems.Rows[i]["IID"].ToString());

                    }
                    return true;
                } else
                    return false;
            } catch {
                return false;
            }

        }

        public bool DeleteOrder(string OrderIID) {
            return db.RunQuery("DeleteOrder", OrderIID);
        }

        //This only deletes the order , most likely called from a function which checked the inhouse, 
        //TakeAwayB, delivery possibilities
        //and deleted the table already if any or freed it.
        public void DeleteOrderOnly(Order order) {
            if (order != null) {
                //Delete Order Items
                db.RunQuery("DeleteOrderItemsForOrder", order.IID);
                //Delete Order Extras
                //db.RunQuery("DeleteExtrasForOrder", order.IID);
                //Now delete the order itself
                db.RunQuery("DeleteOrder", order.IID);
            }
        }

        public bool ConfirmForSupervision() {
            using (trmSupervisorLogin frm = new trmSupervisorLogin(this)) {
                return (frm.ShowDialog() == DialogResult.OK);
            }
        }

        public OrderItem GetOrderItem(string IID) {
            DataTable dt = db.GetDataTable("GetOrderItem", IID);
            if (dt == null)
                return null;

            return new OrderItem(dt.Rows[0]);
        }

        public DataTable GetOrderItemsForOrder(string OrderIID) {
            return
                db.GetDataTable(
                    "Select *, (Quantity * CalculationRatio * Price) as Total from OrderItem where ParentOrderIID = '" +
                    OrderIID + "' order by DisplayOrder, OrderGroupIID");
        }

        public void SaveOrderItem(OrderItem oi) {
            try {

                CultureInfo ci = GetDBCulture();
                if (db.RunQuery("SaveOrderItem '" +
                                oi.IID + "','" + oi.EntityIID + "','" + oi.OrderItemText + "'," + oi.Quantity + ",'" +
                                oi.Price.ToString(ci) + "','" + oi.OrderGroupIID + "','" + oi.EntityButtonIID + "','" +
                                oi.DistributionIID + "','" + oi.ParentOrderIID + "'," + (int)oi.ItemType + "," +
                                oi.dorder + ",'" +
                                oi.EntityName + "'," + oi.EntityDisplayOrder + ",'" +
                                oi.TaxPercent.ToString(ci) + "'," + oi.CompletedQuantity)) {

                }
            } catch {
            }
        }




        public void SaveLogItem(LogItem log)
        {
            try
            {
                CultureInfo ci = GetDBCulture();
                string sql = "SaveLogItem '" + log.IID + "','" + log.OrderItemText + "'," + log.Quantity + ",'" +
                                log.Price.ToString(ci) + "','" + log.Reason.Replace("'","''") + "'," +
                                DRDateTime.DatetimeToMSSql(log.EventDateTime) + ",'" + 
                                log.ComputerName + "','"  + log.OrderContent.Replace("'", "''") + "','"+ log.Reference +"'";

                db.RunQuery(sql);
            } catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
        public DataTable GetAllLogItems()
        {
            try
            {
                return db.GetDataTable("Select *, (Quantity * price) as Total from LogItems order by EventDateTime");
            } catch {
                return null;
            }
        }

        public void DeleteLogItems(List<string> IIDList)
        {
            foreach (var IID in IIDList)
            {
                db.RunQuery("Delete From LogItems Where IID ='" + IID + "'");
            }
        }
        public void DeleteAllLogItems()
        {
            try
            {
                db.RunQuery("Delete From LogItems");
            } catch { }
        }




        public void ReturnOrder(Order order) {
            if (order.OrderType == OrderTypes.InHouse)
                this.ReturnTable(order);
            else {
                //bool blnDeleteErrorOrders = false;
                //if (config.Erroneous_Orders_Should_Be_Deleted) {
                if (order.items.Count > 0) {
                    order.LockedClientIP = "";
                    order.TableIID = "";
                    SaveOrder(order);
                } else
                    DeleteOrder(order.IID);
                //}
                //else {
                //    order.LockedClientIP = "";
                //    order.TableIID = "";
                //    SaveOrder(order);
                //}
            }
        }

        public Order BarrowOrder(string OrderIID, string ClientIP) {
            Order order = GetOrder(OrderIID);
            if (order.IsBusy(ClientIP))
                return null;
            else {
                order.LockedClientIP = ClientIP;
                SaveOrder(order);
                return order;
            }
        }

        private DataTable GetAllOrderItems(string OrderIID) {
            return db.GetDataTable("GetAllOrderItems", OrderIID);
        }
        

        public List<Order> GetOrderListForSession(string SessionIID) {
            List<Order> OrderList = new List<Order>();
            DataTable dt = db.GetDataTable("GetSessionOrders", SessionIID);
            for (int i = 0; i < dt.Rows.Count; i++)
                OrderList.Add(GetOrder(dt.Rows[i]["IID"].ToString()));
            return OrderList;
        }

        #endregion

        #region "LOCK FUNCTIONS"

        public bool LockOT(string OrderIID, string TableIID, bool blnLockFlag) {
            return true;
        }

        #endregion

        #region "UTILITY FUNCTIONS"

        public static DialogResult MessageBoxDT(string Text, string Caption, DialogTypes DialogType) {
            using (trmYnc ync = new trmYnc(Text, Caption, DialogType)) {
                return ync.ShowDialog();
            }


        }

        public bool SendNotificationEmail(string subject, string body, Attachment attachment) {
            
            if (luv == null) {
                //MessageBox.Show("Mail Settings cannot be obtained, aborting...");
                return false;
            }

            MailMessage msg = new MailMessage(luv.SmtpEmailAddress,
                luv.NotificationEmail,
                subject, body);
            if (attachment != null)
                msg.Attachments.Add(attachment);
            SmtpClient smtp = DRSmtp.GetSmtp(luv.SmtpServer, luv.SmtpEmailAddress, luv.SmtpPassword);
            DRSmtp.SendEmail(smtp, msg);
            return true;
        }

        public bool SendEmailToCustomRecepient(string ToEmail, string subject, string body, Attachment attachment) {
            
            if (luv == null) {
                return false;
            }

            MailMessage msg = new MailMessage(luv.SmtpEmailAddress,
                ToEmail, subject, body);
            if (attachment != null)
                msg.Attachments.Add(attachment);

            SmtpClient smtp = DRSmtp.GetSmtp(luv.SmtpServer, luv.SmtpEmailAddress, luv.SmtpPassword);
            DRSmtp.SendEmail(smtp, msg);
            return true;
        }

        public bool SendEmailToCustomRecepientManyAttachment(string ToEmail, string subject, string body,
            List<Attachment> attachmentList) {
            if (luv == null) {
                return false;
            }

            MailMessage msg = new MailMessage(luv.SmtpEmailAddress,
                ToEmail, subject, body);
            if (attachmentList != null) {
                for (int i = 0; i < attachmentList.Count; i++)
                    msg.Attachments.Add(attachmentList[i]);
            }

            SmtpClient smtp = DRSmtp.GetSmtp(luv.SmtpServer, luv.SmtpEmailAddress, luv.SmtpPassword);
            DRSmtp.SendEmail(smtp, msg);
            return true;
        }

        #endregion

        #region "INSTRUCTION FUNCTIONS"
        public Debug GetDebug(string DebugNo) {
            return GetDebug(int.Parse(DebugNo));
        }
        public Debug GetDebug(int DebugNo) {
            try {
                return new Debug(db.GetDataTable("Select * from Debug where DebugNo = " + DebugNo));
            } catch {
                return null;
            }

        }
        public DataTable GetAllDebug(OrderByTypes orderby) {
            switch (orderby) {
                case OrderByTypes.None:
                    return db.GetDataTable("Select * from Debug");
                case OrderByTypes.Ascending:
                    return db.GetDataTable("Select * from Debug order by EventDateTime asc");
                case OrderByTypes.Descending:
                    return db.GetDataTable("Select * from Debug order by EventDateTime desc");
            }
            return null;
            
        }
        public bool SaveDebug(string data) {
            return db.RunQuery("Insert into Debug (Data) values ('" +  data.Replace("'","''") + "')");
        }
        public bool SaveDebug(Debug debug) {
            return db.RunQuery("Insert into Debug (EventDateTime, Data) values ('" + db.DatetimeToMSSqlDatetime(debug.EventDateTime) + "','" + debug.Data.Replace("'", "''") + "')");
        }
        public bool DeleteDebug(int debugNumber) {
            return db.RunQuery("Delete from Debug where DebugNo =" + debugNumber);
        }
        public bool DeleteDebug(string debugNumber) {
            return db.RunQuery("Delete from Debug where DebugNo =" + debugNumber);
        }
        public bool ClearAllDebugInfo() {
            return db.RunQuery("Delete from Debug");
        }
        //public string[] GetInstructionListAsArray() {
        //    DataTable dt = db.GetDataTable("GetAllInstructions");
        //    string[] insList = new string[dt.Rows.Count];
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //        insList[i] = dt.Rows[i]["Instruction"].ToString();
        //    return insList;
        //}

        //public DataTable GetInstructionList() {
        //    return db.GetDataTable("GetAllInstructions");
        //}

        //public void SaveInstruction(Instruct ins) {
        //    db.RunQuery("SaveInstruction '" + ins.IID + "','" + ins.Instruction.Replace("'", "''") + "'");
        //}

        //public void DeleteInstruction(string IID) {
        //    db.RunQuery("DeleteInstruction", IID);
        //}

        #endregion

        #region "SERVER PRINTER FUNCTIONS"

        public List<ApplicationPrinter> GetAllPrinters()
        {
            List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            DataTable dt = db.GetDataTable("Select * from PrinterView");
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            return PrinterList;
        }
        public List<ApplicationPrinter> GetPrinterList() {
            List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            DataTable dt = db.GetDataTable("GetPrinterList", config.Terminal_Name);
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            return PrinterList;
        }

        public DataTable GetPrinterListDB() {
            return db.GetDataTable("GetPrinterList", config.Terminal_Name);
        }

        public List<ApplicationPrinter> GetSystemPrinterList() {
            List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            DataTable dt = db.GetDataTable("GetSystemPrinterList");
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            return PrinterList;
        }

        public DataTable GetSystemPrinterListDB() {
            return db.GetDataTable("GetSystemPrinterList");
        }

        public DataTable GetPrintersByPrinterType(PrinterTypes PrinterType) {
            return db.GetDataTable("GetPrintersByPrinterType " + (int)PrinterType + ",'" +
                                   config.Terminal_Name + "'," + db.BoolToInt(LoggedUser.IsManagerOrMore()));
        }

        public ApplicationPrinter GetPrinterForClient(string PrinterIID) {
            DataTable dt = db.GetDataTable("GetPrinterForClient '" + PrinterIID + "','" + config.Terminal_Name + "'");
            if (dt.Rows.Count > 0)
                return new ApplicationPrinter(dt.Rows[0]);
            else
                return null;
        }
        public ApplicationPrinter GetPrinter(string PrinterIID) {
            DataTable dt = db.GetDataTable("GetPrinter '" + PrinterIID + "'");
            if (dt.Rows.Count > 0)
                return new ApplicationPrinter(dt.Rows[0]);
            else
                return null;
        }
        public ApplicationPrinter GetSystemPrinter(string PrinterIID) {
            DataTable dt = db.GetDataTable("GetSystemPrinter", PrinterIID);
            if (dt.Rows.Count > 0)
                return new ApplicationPrinter(dt.Rows[0]);
            else
                return null;
        }

        public ApplicationPrinter GetDefaultReceiptPrinter() {
            if (config.DTClientLocalReceiptPrinterIID != null && config.DTClientLocalReceiptPrinterIID != "")
                return GetPrinterForClient(config.DTClientLocalReceiptPrinterIID);
            else
                return null;

        }

        public ApplicationPrinter GetPrinterForOrderType(OrderTypes orderType) {
            string IID = GetPrinterIIDForOrderType(orderType);
            if (IID == "")
                return null;
            else
                return GetPrinterForClient(IID);

        }

        public ApplicationPrinter GetPrinterForDistribution(string distributionIID) {
            try {
                return GetPrinterForClient(GetDistribution(distributionIID).PrinterIID);
            } catch {
                return null;
            }
        }

        public List<Distribution> GetDistributionListForPrinter(string ApplicationPrinterIID) {
            DataTable dt = db.GetDataTable("Select * from Distribution where PrinterIID = '" + ApplicationPrinterIID + "'");
            List<Distribution> theList = new List<Distribution>();
            for (int i=0; i < dt.Rows.Count; i++ ) {
                theList.Add(new Distribution(dt.Rows[i]));                
            }
            return theList;
        }

        public string GetPrinterIIDForOrderType(OrderTypes orderType) {
            DataTable dt = null;
            switch (orderType) {
                case OrderTypes.DirectSale:
                    return config.DTClientLocalReceiptPrinterIID;
                case OrderTypes.Delivery:
                    dt = db.GetDataTable("GetDeliveryPrinter", config.Terminal_Name);
                    break;
                case OrderTypes.InternetDelivery:
                    dt = db.GetDataTable("GetDeliveryPrinter", config.Terminal_Name);
                    break;
                case OrderTypes.TakeAwayB:
                    dt = db.GetDataTable("GetTakeAwayPrinter", config.Terminal_Name);
                    break;
                case OrderTypes.InternetTakeAway:
                    dt = db.GetDataTable("GetTakeAwayPrinter", config.Terminal_Name);
                    break;
                case OrderTypes.InHouse:
                    break;
            }

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["IID"].ToString();
            else
                return "";
        }

        public bool SavePrinter(ApplicationPrinter ap) {
            try {
                return
                    db.RunQuery("SavePrinter '" + ap.IID + "','" + ap.NetworkName + "','" + ap.ApplicationName + "'," +
                                (int)ap.PrinterType + "," + db.BoolToInt(ap.DeliveryPrinter) + "," +
                                db.BoolToInt(ap.TakeAwayPrinter) +
                                ",'" + (ap.ClientIID == null || ap.ClientIID == ""?config.Terminal_Name:ap.ClientIID) + "'," + db.BoolToInt(ap.AdminOnly));
            } catch {
                return false;
            }
        }

        public bool SaveUniquePrinter(ApplicationPrinter AppPrinter, OrderTypes orderType) {
            try {
                switch (orderType) {
                    case OrderTypes.Delivery:
                        db.RunQuery("SaveDeliveryPrinter '" + AppPrinter.IID + "','" + config.Terminal_Name + "'");
                        break;
                    case OrderTypes.TakeAwayB:
                        db.RunQuery("SaveTakeAwayPrinter '" + AppPrinter.IID + "','" + config.Terminal_Name + "'");
                        break;
                }
                return true;
            } catch {
                return false;
            }
        }

        public bool SaveUniquePrinter(string PrinterIID, OrderTypes orderType) {
            try {
                switch (orderType) {
                    case OrderTypes.Delivery:
                        db.RunQuery("SaveDeliveryPrinter '" + PrinterIID + "','" + config.Terminal_Name + "'");
                        break;
                    case OrderTypes.TakeAwayB:
                        db.RunQuery("SaveTakeAwayPrinter '" + PrinterIID + "','" + config.Terminal_Name + "'");
                        break;
                }
                return true;
            } catch {
                return false;
            }
        }

        public void DeletePrinter(string PrinterIID) {
            db.RunQuery("DeletePrinter", PrinterIID);
        }

        public List<ApplicationPrinter> GetReceiptPrinterList() {
            List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            DataTable dt = GetPrintersByPrinterType(PrinterTypes.Receipt);
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            dt = GetPrintersByPrinterType(PrinterTypes.Mutant);
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            return PrinterList;
        }

        public List<ApplicationPrinter> GetKitchenPrinterList() {
            List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            DataTable dt = GetPrintersByPrinterType(PrinterTypes.Kitchen);
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            dt = GetPrintersByPrinterType(PrinterTypes.Mutant);
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            return PrinterList;
        }

        public List<ApplicationPrinter> GetOnlyKitchenPrinterList() {
            List<ApplicationPrinter> PrinterList = new List<ApplicationPrinter>();
            DataTable dt = GetPrintersByPrinterType(PrinterTypes.Kitchen);
            for (int i = 0; i < dt.Rows.Count; i++)
                PrinterList.Add(new ApplicationPrinter(dt.Rows[i]));
            return PrinterList;
        }

        #endregion

        #region "CASH DRAWER"
        public bool OpenCashDrawer(bool blnAsFault) {
            if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.LocalAttached)
                return OpenLocalCashDrawer();
            else if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.USBPrinterAttached)
                return OpenLocalUSBPrinterCashDrawer();
            else if (config.Attached_Cash_Drawer_Type == CashDrawerTypes.PrinterAttached)
                return OpenCashDrawerByPrinter();
            else
                return false;
        }

        public bool OpenCashDrawerByPrinter() {
            try {
                ApplicationPrinter ap = GetPrinterForClient(config.DtPrinterCashDrawerIID);

                if (ap == null)
                    return false;
                DRShell.SendOpenCashDrawerToPrinter(ap.NetworkName);
                return true;
            } catch {
                return false;
            }
        }

        public bool OpenLocalCashDrawer() {
            try {
                SerialPort comport = new SerialPort(config.Cash_Drawer_Serial_Port.ToString(), 9600, Parity.None, 8,
                    StopBits.Two);

                comport.Open();
                comport.Write("a" + '\x1C');
                comport.Close();
                return true;
            } catch {
                return false;
            }
        }

        public bool OpenLocalUSBPrinterCashDrawer() {
            try {
                ApplicationPrinter ap = GetPrinterForClient(config.DtPrinterCashDrawerIID);

                if (ap == null)
                    return false;
                DRShell.SendOpenCashDrawerToUSBPrinter(ap.NetworkName);
                //MessageBox.Show("OpenLocalUSBPrinterCashDrawer " + ap.NetworkName);
                return true;
            } catch {
                // MessageBox.Show("Failed OpenLocalUSBPrinterCashDrawer");
                return false;
            }
        }
        //public string CurrentSessionIID { get; set; }
        public void EnsureSessionData() {
            //CurrentSessionIID = GetCurrentSessionIID();
            string SessionIID = GetCurrentSessionIID();
            if (SessionIID == "" || !IsSessionExist(SessionIID))
                StartNewSession();
            
        }

        public bool IsSessionExist(string SessionIID) {
            DataTable dt = db.GetDataTable("Select * from Sessions where IID = '" + SessionIID + "'");
            return (dt.Rows.Count > 0);               
        }

        public string GetCurrentSessionIID() {
            DataTable dt = db.GetDataTable("GetLuv");
            if (dt.Rows.Count > 0) {
                if (dt.Rows[0]["CurrentSessionIID"] != null)
                    return dt.Rows[0]["CurrentSessionIID"].ToString();
            }
            return "";
        }

        public SessionData GetCurrentSession() {
            return GetSessionDataDynamic(luv.CurrentSessionIID);
        }

        public bool IsLatestAndCurrentSession(string IID) {
            return luv.CurrentSessionIID == IID;
        }

        #endregion

        #region "PRINT FUNCTIONS"

        //public bool PrintForKitchen(Order order, bool blnUnprinted, bool blnSetPrintFlags,
        //    bool blnIncrementRequestNumber, bool blnSave) {

        //    try {
        //        //so kitchen printer will have everything categorised in display order
        //        ReOrderItems(order);
        //        this.SaveOrder(order);

        //        //Print without printserver
        //        List<ApplicationPrinter> KitchenPrinters = this.GetKitchenPrinterList();

        //        for (int z = 0; z < KitchenPrinters.Count; z++) {
        //            PrintForKitchen(order.IID, KitchenPrinters[z]);
        //        }
        //        //MarkOrderAllItemsPrinted(order.IID);
        //        return true;
        //    } catch {
        //        return false;
        //    }
        //}

        public bool PrintForKitchen(string orderIID) {
            try {
                KitchenOrder korder = GetKitchenOrderForOrder(orderIID);
                if (korder != null) {
                    List<ApplicationPrinter> printerList = GetApplicationPrinterList(korder);
                    for (int i = 0; i < printerList.Count; i++) {
                        new ReportGenerator(this, printerList[i], 2).PrintKitchen(korder);
                    }
                }
                return true;
            } catch {
                return false;
            }
        }

        public bool PrintForKitchen(string orderIID, ApplicationPrinter ap) {
            KitchenOrder korder = GetKitchenOrderForOrder(orderIID);
            if (korder != null && korder.items.Count > 0)
                return new ReportGenerator(this, ap, 2).PrintKitchen(korder);
            else
                return false;
        }

        public bool PrintForKitchen(KitchenOrder korder) {
            try {                
                if (korder != null) {
                    List<ApplicationPrinter> printerList = GetApplicationPrinterList(korder);
                    for (int i = 0; i < printerList.Count; i++) {
                        new ReportGenerator(this, printerList[i], 2).PrintKitchen(korder);
                    }
                }
                return true;
            } catch {
                return false;
            }
        }

        public bool PrintForKitchen(KitchenOrder korder, ApplicationPrinter ap,bool blnWithDetail =false) {
            try {
                return new ReportGenerator(this, ap).PrintKitchen(korder,blnWithDetail);
            } catch {
                return false;
            }            
        }

        



        //public bool CreateKitchenOrderForAttachedInHouseOrder() {
        //    if (AttachedOrder != null) {
        //        Order DummyOrder = AttachedOrder.GetOrderWithKitchenableItems();

        //        if (DummyOrder.items.Count > 0) {

        //            //Now Create Kitchen Order To Display
        //            KitchenOrder korder = ConvertOrderToKitchenOrder(DummyOrder);
        //            korder.OrderType = OrderTypes.InHouse;
        //            korder.Reference = AttachedOrder.TableName;

        //            //PrepDialogReturnTypes prepDialogResult = PrepDialogReturnTypes.Cancel;
        //            frmPrep frm = new frmPrep(this, korder);

        //            //The point to return 
        //            if (frm.ShowDialog() == DialogResult.Cancel)
        //                return false;

        //            SaveKitchenOrder(korder);

        //            onKitchenRequestOccured(this.GetKitchenOrder(korder.IID));
        //        } 
        //    }
        //    return true;
        //}

        /// <summary>
        /// Checks if order has a waiting or completed and related KitchenOrder in the database
        /// </summary>
        /// <param name="orderIID"></param>
        /// <returns></returns>
        public bool HasAnyKitchenOrderInDatabase(string orderIID) {
            DataTable dt = db.GetDataTable("Select count(IID) as howmany from KitchenOrders where OrderIID ='" + orderIID + "'");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        /// <summary>
        /// Checks if KitchenOrder has any wating or partiallycompleted items
        /// </summary>
        /// <param name="korder"></param>
        /// <returns></returns>
        public bool HasAnyNonCompleteItems(KitchenOrder korder) {
            foreach (KitchenOrderItem item in korder.items) {
                if (item.Status != KitchenOrderStatusTypes.Completed)
                    return true;
            }
            return false;
        }


        public PrepDialogReturnTypes CreateKitchenOrderForOrder(Order order, out KitchenOrder korder) {
            korder = null;
            PrepDialogReturnTypes prepDialogResult = PrepDialogReturnTypes.Cancel;

            if (AttachedOrder != null) {
               
                //Now Create Kitchen Order To Display
                korder = ConvertOrderToKitchenOrder(order);
                korder.OrderType = order.OrderType;
                if (order.OrderType == OrderTypes.InHouse)
                    korder.Reference = order.TableName;


                using (frmPrep frm = new frmPrep(this, korder)) {
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

                if (blnHasOldKitchenOrder) {
                    if (blnHasNonCompleteItems) {
                        blnSaved = ModifyOldKitchenOrder(korder);
                    } 
                } else {
                    if (blnHasNonCompleteItems)
                        blnSaved = SaveKitchenOrder(korder);
                }

                if (blnSaved) {
                    korder.OrderNo = GetKitchenOrderNumber(korder.IID);

                    if (korder.items.Count > 0) {
                        switch (order.OrderType) {
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
                OnKitchenRequestOccured(this.GetKitchenOrder(korder.IID));
            }
            return prepDialogResult;
        }

        public int GetKitchenOrderNumber(string IID) {
            try {
                return int.Parse(db.GetDataTable("Select OrderNo from KitchenOrders where IID = '" + IID + "'").Rows[0]["OrderNo"].ToString());
            } catch {
                return 0;
            }
        }


        public bool UpdateCompletedQuantityForRelatedKitchenOrderItem(KitchenOrderItem koi) {
            try {
                OrderItem oi = AttachedOrder.items.Find(x => x.EntityButtonIID == koi.EntityButtonIID);
                oi.CompletedQuantity += koi.Quantity;
                //oi.OrderItemText = koi.ItemText;
                SaveOrderItem(oi);
                return true;
            } catch {
                return false;
            }
        }


        //public KitchenOrder GetKitchenOrderByOrderNumber(int OrderNumber, KitchenOrderStatusTypes status= KitchenOrderStatusTypes.Waiting) {
        //    DataTable dt = db.GetDataTable("Select IID from KitchenOrders where OrderNo =" + OrderNumber + " and status = " + (int)status);
        //    if (dt.Rows.Count > 0) {
        //        string IID = dt.Rows[0]["IID"].ToString();
        //        return GetKitchenOrder(IID);
        //    } else
        //        return null;
        //}
        //public KitchenOrder GetKitchenOrderForOrder(string orderIID, KitchenOrderStatusTypes status = KitchenOrderStatusTypes.Waiting) {
        //    DataTable dt = db.GetDataTable("Select IID from KitchenOrders where OrderIID ='" + orderIID + "' and status = " + (int)status);
        //    if (dt.Rows.Count > 0) 
        //        return GetKitchenOrder(dt.Rows[0]["IID"].ToString());
        //    else 
        //        return null;            
        //}

        public KitchenOrder GetKitchenOrderForOrder(string orderIID) {
            DataTable dt = db.GetDataTable("Select IID from KitchenOrders where OrderIID ='" + orderIID + "'");
            if (dt.Rows.Count > 0) {
                string IID = dt.Rows[0]["IID"].ToString();
                return GetKitchenOrder(IID);
            } else
                return null;
        }

        public void DeleteKitchenOrdersForOrder(string orderIID) {
            db.RunQuery("DeleteKitchenOrdersForOrder",orderIID);
        }

        public bool DeleteAllKitchenOrders() {
            return db.RunQuery("DeleteAllKitchenOrders");
        }

        public bool ModifyOldKitchenOrder(KitchenOrder newKOrder) {
            KitchenOrder oldKitchenOrder = GetKitchenOrderForOrder(newKOrder.OrderIID);
            if (oldKitchenOrder != null) {
                oldKitchenOrder.items.Clear();
                foreach (KitchenOrderItem item in newKOrder.items) {
                    item.KitchenOrderIID = oldKitchenOrder.IID;
                }
                oldKitchenOrder.items.AddRange(newKOrder.items);
                db.RunQuery("Delete from KitchenOrderItem where KitchenOrderIID = '" + oldKitchenOrder.IID + "'");
                oldKitchenOrder.CreatedDateTime = DateTime.Now;
                oldKitchenOrder.Reference = newKOrder.Reference;
                return SaveKitchenOrder(oldKitchenOrder);
            } else
                return false;
        }

        public bool CreateKitchenOrderForTakeAwayAndDeliveryOrder(Order order) {
            if (order != null) {
                //Now Create Kitchen Order To Display
                KitchenOrder korder = ConvertOrderToKitchenOrder(order);
                korder.OrderType = order.OrderType;
                korder.Reference = order.OrderType.ToString() + "  " + order.CName;
                SaveKitchenOrder(korder);
                OnKitchenRequestOccured(this.GetKitchenOrder(korder.IID));
            }
            return true;
        }

       

        public List<Distribution> GetDistributionList(KitchenOrder korder) {
            List<Distribution> theList = new List<Distribution>();
            for (int i = 0; i < korder.items.Count; i++) {
                if (theList.Find(x => x.IID == korder.items[i].DistributionIID) == null)
                    theList.Add(GetDistribution(korder.items[i].DistributionIID));
            }
            return theList;
        }
        public string GetDistributionListAsCommaSeperatedSqlString(KitchenOrder korder) {
            List<Distribution> theList = GetDistributionList(korder);
            string str = "";
            for (int i=0; i < theList.Count;i++) {
                str += "'" + theList[i].IID + "',";
            }
            if (str.Length > 0)
                str = str.Substring(0, str.Length - 1);
            return str;
        }
        public List<ApplicationPrinter> GetApplicationPrinterList() {
            string sql = "select* from printerview";
            DataTable dt = db.GetDataTable(sql);
            List<ApplicationPrinter> theList = new List<ApplicationPrinter>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(new ApplicationPrinter(dt.Rows[i]));
            }
            return theList;
        }

        public List<ApplicationPrinter> GetApplicationPrinterList(KitchenOrder korder) {
            string sql = "select * from printerview where ClientIID = '" + config.Terminal_Name + "' and IID in (select distinct PrinterIID from distribution where IID in (" + GetDistributionListAsCommaSeperatedSqlString(korder) +"))";
            DataTable dt = db.GetDataTable(sql);
            List<ApplicationPrinter> theList = new List<ApplicationPrinter>();
            for (int i=0; i < dt.Rows.Count; i++) {
                theList.Add(new ApplicationPrinter(dt.Rows[i]));
            }
            return theList;
        }



        public bool PrintFormatTest(string format, string line) {
            ApplicationPrinter ap = GetDefaultReceiptPrinter();
            if (ap != null) {
                ReportGenerator generator = new ReportGenerator(this, ap,   2);
                return generator.PrintFormatTest(format, line);
            }
            return false;
        }


        private void PrintKassaReport(string SelectedPrinterIID) {
            try {

            } catch (Exception ex) {

            }
        }
        
        public bool PrintEntireOrder(Order order, bool blnOrderly, bool blnSetPrintFlags, int NumberOfCopy,string SelectedPrinterIID) {

            try {
                SaveOrder(order);
                if (SelectedPrinterIID != null)
                    PrintReceipt(order.IID, GetPrinterForClient(SelectedPrinterIID), NumberOfCopy);
                // MarkOrderAllItemsPrinted(order.IID);
                return true;
            } catch {
                return false;
            }
        }

        /// NEW PRINT RECEIPT FUNCTIONS /////
        public int PrintReceipt(string orderiid, ApplicationPrinter ap, int NumberOfCopy) {
            ReportGenerator generator = new ReportGenerator(this, ap,   2);
            generator.PrintReceipt(orderiid);
            return generator.FinalLength;
        }

        public int PrintKassaReport(List<string> report,ApplicationPrinter ap, int NumberOfCopy) {
            ReportGenerator generator = new ReportGenerator(this, ap, 2);
            generator.PrintKassaReport(report);
            return generator.FinalLength;
        }


        public int ViewReceipt(Graphics g, string orderiid, ApplicationPrinter ap, int NumberOfCopy) {
            ReportGenerator generator = new ReportGenerator(g, this, ap,  2);
            generator.PrintReceipt(orderiid);
            return generator.FinalLength;
        }

        private void ReOrderItems(Order order) {
            try {
                List<OrderItem> OrderedOrderItems = new List<OrderItem>();
                DataTable dt = GetActiveEntityList();
                string EIID = "";
                for (int i = 0; i < dt.Rows.Count; i++) {
                    EIID = dt.Rows[i]["IID"].ToString();
                    for (int x = 0; x < order.items.Count; x++) {
                        OrderItem ooi = (OrderItem)order.items[x];
                        if (ooi.EntityIID == EIID)
                            OrderedOrderItems.Add(ooi);
                    }
                }
                for (int x = 0; x < order.items.Count; x++) {
                    OrderItem ooi = (OrderItem)order.items[x];
                    if (ooi.EntityIID == null || ooi.EntityIID == "" || ooi.EntityIID == "0")
                        OrderedOrderItems.Add(ooi);
                }
                order.items = OrderedOrderItems;
            } catch {
            }
        }

        #endregion

        #region "REPORT FUNCTIONS"
        public DataTable GetReportEntityEBTotals(string SessionIID, string EntityIID) {
            return db.GetDataTable("GetReportEntityEBTotals '" + SessionIID + "','" + EntityIID + "'");
        }

        public DataTable GetReportEntityTotals(string SessionIID) {
            return db.GetDataTable("GetReportEntityTotals '" + SessionIID + "'");
        }

        public DataTable GetReportDistributionTotals(string SessionIID) {
            return db.GetDataTable("GetReportDistributionTotals '" + SessionIID + "'");
        }

        public DataTable GetReportOrderTypeTotals(string SessionIID) {
            return db.GetDataTable("GetReportOrderTypeTotals '" + SessionIID + "'");
        }

        public DataTable GetReportPaymentTypeTotals(string SessionIID) {
            return db.GetDataTable("GetReportPaymentTypeTotals '" + SessionIID + "'");
        }

        public DataTable GetReportTableGroupSales(string SessionIID) {
            return db.GetDataTable("GetReportTableGroupSales '" + SessionIID + "'");
        }


        public bool IsReportLockOn() {
            return this.blnReportLockOn;
        }

        public void ChangeReportLockStatus(bool blnLockNow, string ClientIP) {
            if (blnLockNow) {
                this.blnReportLockOn = true;
                this.ReportLockClientIP = ClientIP;
            } else {
                this.blnReportLockOn = false;
                this.ReportLockClientIP = "";
            }
        }

        public string GetReportLockClientIP() {
            return this.ReportLockClientIP;
        }

        public bool PrintReport(string SessionDirectory, ReportFormatTypes reportFormat, string SessionIID,
            string PrinterIID, bool LatePrinting) {
            ReportGenerator generator = new ReportGenerator(this, GetPrinterForClient(PrinterIID),2);
            if (LatePrinting)
                return generator.PrintLateSessionReport(SessionDirectory, SessionIID, reportFormat);
            else {
                bool blnResult = generator.PrintSessionReport(SessionDirectory, SessionIID, reportFormat);
                imgReportSnapShot = generator.imgSnapShot;
                return blnResult;
            }
        }

        public bool PrintReport(ReportFormatTypes reportFormat, string SessionIID, string PrinterIID, bool LatePrinting) {
            ReportGenerator generator = new ReportGenerator(this, GetPrinterForClient(PrinterIID),  2);
            if (LatePrinting)
                return generator.PrintLateSessionReport(SessionIID, reportFormat);
            else {
                bool blnresult = generator.PrintSessionReport(SessionIID, reportFormat);
                imgReportSnapShot = generator.imgSnapShot;
                return blnresult;
            }

        }


        public void PrintPriceList(string catalogIID, string PrinterIID) {
            try {
                //ReportDocument report = GetPriceListReport(GetPrinter(PrinterIID));
                //report.PrintToPrinter(1, false, 0, 0);

                ReportGenerator generator = new ReportGenerator(this, GetPrinterForClient(PrinterIID), 2);
                generator.PrintPriceList(catalogIID);
            } catch {
            }
        }

        public bool HasActiveOrders() {
            DataTable dt = GetSessionOrdersByStatus(StatusFlags.DONE);
            if (dt == null)
                return false;
            else
                return dt.Rows.Count > 0;
        }

        public bool RemoveZeroOrdersOfCurrentSessionAndCreateNewSession() {
            SessionData SessionToArchive;
            try {
                SessionToArchive = GetSessionDataDynamic(luv.CurrentSessionIID); 

                //This is a second before where the current session to be archived

                if (db.RunQuery("ArchiveSessionOrders", SessionToArchive.SessionIID)) {

                    //Handle start new session things
                    SessionData sd = GetLatestSession();
                    if (sd == null) {
                        StartNewSession();
                    } else {
                        if (SessionToArchive.SessionIID == sd.SessionIID) {
                            SessionToArchive.SessionEndDateTime = DateTime.Now;
                            SaveSessionData(SessionToArchive);
                            StartNewSession();
                        }
                    }
                    return true;
                } else
                    return false;
            } catch {
                return false;
            }
        }

        public Report GetReport(ReportFormatTypes reportType) {
            Report report = new Report(reportType);
            switch (reportType) {
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


        private string TwoDigit(int num) {
            if (num.ToString().Length == 1)
                return "0" + num.ToString();
            else
                return num.ToString();
        }

        #endregion

        #region "SESSION FUNCTIONS"

        public DataTable GetSessionList() {
            return db.GetDataTable("GetSessionList");
        }

        public bool DeleteSession(string SessionIID) {
            return db.RunQuery("DeleteSession", SessionIID);
        }

        public SessionData GetSessionDataDynamic(string SessionIID) {
            return new SessionData(db.GetDataTable("GetSessionDynamic", SessionIID));
        }

        //public SessionData GetSessionDataStatic(string SessionIID) {
        //    return new SessionData(db.GetDataTable("Select * from Sessions where IID ='" + SessionIID + "'"));
        //}

        public bool SaveSessionData(string SessionIID) {
            return SaveSessionData(GetSessionDataDynamic(SessionIID));
        }

        public bool SaveSessionData(SessionData ses) {
            
            return db.RunQuery("SaveSessionData '" + ses.SessionIID + "'," +
                               DRDateTime.DatetimeToMSSql(ses.SessionStartDateTime) +
                               "," + DRDateTime.DatetimeToMSSql(ses.SessionEndDateTime) + ",'" +
                               ses.GrossSessionTotal.ToString(ci) + "','" +
                               ses.X1Total.ToString(ci) + "','" + ses.X2Total.ToString(ci) + "','" + ses.X3Total.ToString(ci) + "'");
        }

        public bool SaveDrawerSessionData(SessionData ses) {
            CultureInfo ci = GetDBCulture();
            return db.RunQuery("SaveDrawerSessionData '" + ses.SessionIID + "','" + ses.peny1.ToString(ci) +
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
        public int GetAvailableXReportSlot(SessionData givenSession) {
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
        public bool WillReportEndUpAs_Z_Report(SessionData givenSession) {
            int availableXLocation = 0;
            if (givenSession.X1Total == 0)
                availableXLocation = 1;
            else if (givenSession.X2Total == 0)
                availableXLocation = 2;
            else if (givenSession.X3Total == 0)
                availableXLocation = 3;
           
           
            return availableXLocation == config.Maximum_XReport_Count;
        }    
        
        public bool Is_Z_ReportTimeNow(SessionData givenSession) {
            if (givenSession.X1Total > 0 && config.Maximum_XReport_Count == 1)
                return true;
            else if (givenSession.X2Total > 0 && config.Maximum_XReport_Count == 2)
                return true;
            else if (givenSession.X3Total > 0 && config.Maximum_XReport_Count == 3)
                return true;           
            else
                return false;
        }

        public int GetArchiveProgress() {
            return ArchiveProgress;
        }

        public bool ArchiveSessionListToDirectory(List<string> sessionIIDList) {
            try {
                bool blnSuccess = false;
                ArchiveProgress = 100;
                int step = ArchiveProgress / sessionIIDList.Count;
                for (int i = 0; i < sessionIIDList.Count; i++) {
                    if (ArchiveSessionToDirectory(sessionIIDList[i])) {
                        ArchiveProgress -= step;
                        blnSuccess = true;
                    } else {
                        //Problem happenned
                        ArchiveProgress = 0;
                        blnSuccess = false;
                        break;
                    }
                }
                ArchiveProgress = 0;
                return blnSuccess;
            } catch {
                ArchiveProgress = 0;
                return false;
            }
        }


        public bool ArchiveSessionToDirectory(string SessionIID) {
            try {
                SessionFamily sf = new SessionFamily {
                    sessionData = GetSessionDataDynamic(SessionIID)
                };

                string SessionFileName = DRFile.GenerateFileName(sf.sessionData.SessionStartDateTime,
                    sf.sessionData.SessionEndDateTime, "xml");
                if (File.Exists(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName))
                    return false;


                if (sf.sessionData.SessionEndDateTime == null ||
                    sf.sessionData.SessionEndDateTime == sf.sessionData.SessionStartDateTime) {
                    sf.sessionData.SessionEndDateTime = DateTime.Now;
                }
                SaveSessionData(sf.sessionData);
                sf.Orders = GetOrderListForSession(SessionIID);
                DRFile.XmlSerialize(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName, sf,
                    typeof(SessionFamily), false);

                //This deletes the session from database all together
                db.RunQuery("DeleteSession", SessionIID);

                return true;
            } catch {
                return false;
            }
        }


        public bool ArchiveSessionToDirectory(string directoryPath, string SessionIID, bool blnDeleteSessionFromDatabase) {
            try {
                SessionFamily sf = new SessionFamily {
                    sessionData = GetSessionDataDynamic(SessionIID)
                };

                string SessionFileName = DRFile.GenerateFileName(sf.sessionData.SessionStartDateTime,
                    sf.sessionData.SessionEndDateTime, "xml");
                if (File.Exists(directoryPath + "\\" + SessionFileName))
                    return false;


                if (sf.sessionData.SessionEndDateTime == null ||
                    sf.sessionData.SessionEndDateTime == sf.sessionData.SessionStartDateTime) {
                    sf.sessionData.SessionEndDateTime = DateTime.Now;
                }
                SaveSessionData(sf.sessionData);
                sf.Orders = GetOrderListForSession(SessionIID);
                if (!DRFile.XmlSerialize(directoryPath + "\\" + SessionFileName, sf, typeof(SessionFamily), false))
                    return false;

                //This deletes the session from database all together
                if (blnDeleteSessionFromDatabase)
                    db.RunQuery("DeleteSession", SessionIID);

                return true;
            } catch (Exception ex) {
                string str = ex.Message;
                return false;
            }
        }



        /// <summary>
        /// copies the given session file to backup directory using startdate and enddate structure for the file name
        /// backup directory is  \\backups which is taken from UF.BackupDirectory
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public bool CopySessionFileToBackupDirectory(DateTime startDate, DateTime endDate) {
            try {
                string SessionFileName = DRFile.GenerateFileName(startDate, endDate, "xml");
                File.Copy(DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName,
                    DRFile.GetApplicationPath() + UF.BackupDirName + "\\" + SessionFileName, true);
                return true;
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Copies the given session file to session directory using startdate and enddate structure for the file name
        /// bakcup directory is \\backups which is taken from UF.BackupDirectory
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public bool RestoreSessionFileFromBackupDirectory(DateTime startDate, DateTime endDate) {
            try {
                string SessionFileName = DRFile.GenerateFileName(startDate, endDate, "xml");
                File.Copy(DRFile.GetApplicationPath() + UF.BackupDirName + "\\" + SessionFileName,
                    DRFile.GetApplicationPath() + UF.SessionDirName + "\\" + SessionFileName, true);
                return true;
            } catch {
                return false;
            }
        }


        public int GetSessionLoadProgress() {
            return SessionLoadProgress;
        }

        public bool ReloadSessionListFromDirectory(List<SessionDataShort> theList) {
            try {
                bool blnSuccess = false;
                SessionLoadProgress = 100;
                int step = SessionLoadProgress / theList.Count;
                for (int i = 0; i < theList.Count; i++) {
                    SessionDataShort session = theList[i];
                    if (ReloadSessionFromDirectory(session.StartDate, session.EndDate)) {
                        SessionLoadProgress -= step;
                        blnSuccess = true;
                    } else {
                        //There is an error
                        SessionLoadProgress = 0;
                        blnSuccess = false;
                        break;
                    }

                }
                SessionLoadProgress = 0;
                return blnSuccess;
            } catch {
                SessionLoadProgress = 0;
                return false;
            }
        }

        public bool ReloadSessionFromDirectory(DateTime startDate, DateTime endDate) {
            try {
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
            } catch  {               
                return false;
            }
        }

        public bool ReloadSessionFromCustomDirectory(string directory, DateTime startDate, DateTime endDate) {
            try {
                string SessionFileName = DRFile.GenerateFileName(startDate, endDate, "xml");
                SessionFamily sf =
                    (SessionFamily)
                    DRFile.XmlDeSerialize(directory + "\\" + SessionFileName, typeof(SessionFamily), false);
                SaveSessionData(sf.sessionData);
                for (int i = 0; i < sf.Orders.Count; i++)
                    SaveOrder(sf.Orders[i]);
                File.Delete(directory + "\\" + SessionFileName);
                return true;
            } catch {
                return false;
            }
        }

        public bool ReloadSessionFromFile(string filename) {
            try {
                SessionFamily sf = (SessionFamily)DRFile.XmlDeSerialize(filename, typeof(SessionFamily), false);
                SaveSessionData(sf.sessionData);
                for (int i = 0; i < sf.Orders.Count; i++)
                    SaveOrder(sf.Orders[i]);
                File.Delete(filename);
                return true;
            } catch {
                return false;
            }
        }

        

        public SessionData GetLatestSession() {
            DataTable dt = db.GetDataTable("GetLatestSession");
            if (dt.Rows.Count > 0) {
                string LatestSessionIID = dt.Rows[0]["IID"].ToString();
                
                return GetSessionDataDynamic(LatestSessionIID);
            } else
                return null;
        }

        public DataTable GetAllOrdersForSession(string SessionIID) {
            return db.GetDataTable("GetAllOrdersForSession", SessionIID);
        }

        public DataTable GetAllOrdersForSessionDateOrderly(string SessionIID, OrderByTypes orderDirection) {
            string orderdir = "Asc";
            switch (orderDirection) {
                case OrderByTypes.Ascending:
                case OrderByTypes.None:
                    break;
                case OrderByTypes.Descending:
                    orderdir = "Desc";
                    break;
                default:
                    break;
            }
            return db.GetDataTable("SELECT * from OrdersView where SessionIID = '" + SessionIID + "'  Order by OrderDate " + orderdir);

        }

       
        /// <summary>
        /// Returns the sum of orders in current session which are not completed or archived
        /// </summary>
        /// <returns></returns>
        public float GetUncompletedOrdersTotalForCurrentSession() {
            DataTable dt = db.GetDataTable("Select isnull(Sum(CalculatedValue),0) as SumCalVal from ordersview where SessionIID = '" + luv.CurrentSessionIID + "' and status != 3 and status != 4");
            return float.Parse(dt.Rows[0]["SumCalVal"].ToString());
        }

        public bool IsSessionOrdersExistInDatabase(string SessionIID) {
            DataTable dt = db.GetDataTable("Select * from Orders where SessionIID = '" + SessionIID + "'");
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool EnsureSessionOrdersLoadedInDatabase(SessionData session) {
            if (!IsSessionOrdersExistInDatabase(session.SessionIID)) {
                if (
                    MessageBox.Show(
                        "Session Orders doesn't exist in database!\nDo you want to load orders from session archive?",
                        "SESSION ORDERS MISSING", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                    if (!ReloadSessionFromDirectory(session.SessionStartDateTime, session.SessionEndDateTime)) {
                        RecheckSessionOrders:
                        if (DTRMSimpleBusiness.MessageBoxDT("Session orders cannot be load into database!\n" +
                                                            "Either Session has no orders or Session Backup File cannot be found.\n" +
                                                            "Would you like to locate another backup directory??",
                                "RESTORING SESSION ORDERS", DialogTypes.YesNoCancel) == DialogResult.Yes) {

                            using (FolderBrowserDialog fbdlg = new FolderBrowserDialog {
                                Description = "Select backup directory for sessions",
                                SelectedPath = DRFile.GetApplicationPath() + UF.SessionDirName
                            }) {
                                if (fbdlg.ShowDialog() == DialogResult.OK) {
                                    if (
                                        !ReloadSessionFromCustomDirectory(fbdlg.SelectedPath, session.SessionStartDateTime,
                                            session.SessionEndDateTime))
                                        goto RecheckSessionOrders;
                                    else
                                        return true;
                                } else
                                    return false;
                            }
                        }
                        //Cannot locate session backup
                        else {
                            MessageBox.Show("Session orders cannot be load into database!\n" +
                                            "Either Session has no orders or Session Backup File cannot be found.\n" +
                                            "You cannot edit this session.\n" +
                                            "Closing Editor", "RESTORING ORDER ERROR");
                            return false;
                        }
                    } else
                        return true;
                } else
                    return false;
            } else
                return true;
        }

        /// <summary>
        /// Returns List of SessionDataShort
        /// </summary>
        /// <returns></returns>
        public List<SessionDataShort> GetArchivedSessionDataList() {
            List<SessionDataShort> theList = new List<SessionDataShort>();

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");

            string[] files = Directory.GetFiles(DRFile.GetApplicationPath() + UF.SessionDirName);

            for (int i = 0; i < files.Length; i++) {
                SessionDataShort session = new SessionDataShort();
                XmlTextReader myReader = new XmlTextReader(files[i]);

                bool blnContinue = true;
                while (myReader.Read() && blnContinue) {
                    if (myReader.NodeType == XmlNodeType.Element && myReader.LocalName.Equals("sessionData")) {
                        while (myReader.Read()) {
                            if (myReader.LocalName.Equals("SessionIID"))
                                session.IID = myReader.ReadString();
                            else if (myReader.LocalName.Equals("SessionStartDateTime"))
                                session.StartDate = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("SessionEndDateTime"))
                                session.EndDate = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("GrossSessionTotal"))
                                session.GrossSessionTotal = float.Parse(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X1Total"))
                                session.X1Total = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X2Total"))
                                session.X2Total = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X3Total"))
                                session.X3Total = Convert.ToSingle(myReader.ReadString(), culture);                           
                            else if (myReader.LocalName.Equals("Orders")) {
                                blnContinue = false;
                                break;
                            }
                        }
                    }
                }
                myReader.Close();
                theList.Add(session);

            }
            return theList;
        }

        /// <summary>
        /// Returns DataTable of SessionDataShort
        /// </summary>
        /// <returns></returns>
        public DataTable GetArchivedSessionDataTable(string sessionDirectory) {
            DataTable dt = GetSessionList();
            dt.Clear();




            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-GB");

            string[] files = Directory.GetFiles(sessionDirectory);

            for (int i = 0; i < files.Length; i++) {
                DataRow dr = dt.NewRow();
                XmlTextReader myReader = new XmlTextReader(files[i]);

                bool blnContinue = true;
                while (myReader.Read() && blnContinue) {
                    if (myReader.NodeType == XmlNodeType.Element && myReader.LocalName.Equals("sessionData")) {
                        while (myReader.Read()) {
                            if (myReader.LocalName.Equals("SessionIID"))
                                dr["IID"] = myReader.ReadString();
                            else if (myReader.LocalName.Equals("SessionStartDateTime"))
                                dr["StartDate"] = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("SessionEndDateTime"))
                                dr["EndDate"] = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("GrossSessionTotal"))
                                dr["GrossSessionTotal"] = float.Parse(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X1Total"))
                                dr["X1Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X2Total"))
                                dr["X2Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X3Total"))
                                dr["X3Total"] = Convert.ToSingle(myReader.ReadString(), culture);                                                    
                            else if (myReader.LocalName.Equals("Orders")) {
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

        public bool StartNewSession() {
            try {

                //with Z report applied , a new session started
                SessionData TempSession = new SessionData();
                //try {
                //    TempSession.StartMoney = this.config.Default_Float_In_Cash_Drawer;
                //} catch {
                //    TempSession.StartMoney = 0f;
                //}
                SaveSessionData(TempSession);
                ActivateSession(TempSession);

                //Update OrderList to get rid of orders belong to the taken ZReport
                //Also update order session numbers
                //DO NOT MAKE THIS SINGLE DATABASE CALL
                db.RunQuery("UpdateSessionIIDForOrders '" + TempSession.SessionIID + "'," + (int)StatusFlags.COMPLETED);
                luv = GetLuv();
                return true;
            } catch {
                return false;
            }
        }

        public void ActivateSession(SessionData ses) {
            db.RunQuery("ActivateSession '" + ses.SessionIID + "'," +
                        DRDateTime.DatetimeToMSSql(ses.SessionStartDateTime));
        }


        /// <summary>
        /// This is only logical for current session
        /// </summary>
        /// <param name="SessionIID"></param>
        /// <returns></returns>
        public bool PreserveSessionOrdesToX(string SessionIID) {
            //Move and delete Orders FROM orders and OrderItem table to xorders and xOrderItem table
            return RunQuery("MoveOrdersToXOrdersForSession '" + SessionIID + "'");
        }

        public bool GetXOrdersBackForSession(string SessionIID) {
            //Move and delete XOrders from xOrders and xOrderItem table to orders and orderitem table
            return RunQuery("MoveXOrdersToOrdersForSession '" + SessionIID + "'");
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
        public DataSet GetTaxSummaryReport(DateTime FirstStartDate, DateTime LastEndDate) {
            DataSet ds = new DataSet();

            string dailysql =
                "select StartDate, EndDate, TaxPercent, TotalNoTax, NetTaxValue, GrossTotal from TaxSummary  Where startdate >= '" +
                db.DatetimeToMSSqlDatetime(FirstStartDate) + "' and enddate <= '" +
                db.DatetimeToMSSqlDatetime(LastEndDate) + "' order by startdate asc, TaxPercent asc";
            DataTable dtdailysql = db.GetDataTable(dailysql);
            dtdailysql.TableName = "Daily";
            ds.Tables.Add(dtdailysql);

            string percentsumsql =
                "select '', 'Sum of %', TaxPercent, sum(totalnotax) as TotalNoTax,  sum(nettaxvalue) as NetTaxValue,Payment, sum(grosstotal) as GrossTotal  from TaxSummary  Where startdate >= '" +
                db.DatetimeToMSSqlDatetime(FirstStartDate) + "' and enddate <= '" +
                db.DatetimeToMSSqlDatetime(LastEndDate) + "' group by taxpercent,payment order by taxpercent, payment";
            DataTable dtpercentsum = db.GetDataTable(percentsumsql);
            dtpercentsum.TableName = "Percent";
            ds.Tables.Add(dtpercentsum);

            string sumsql =
                "select '', 'Total','', sum(totalnotax) as TotalNoTax ,sum(nettaxvalue) as NetTaxValue,Payment, sum(grosstotal) as GrossTotal  from TaxSummary   Where startdate >= '" +
                db.DatetimeToMSSqlDatetime(FirstStartDate) + "' and enddate <= '" +
                db.DatetimeToMSSqlDatetime(LastEndDate) + "'  group by payment  order by  payment";
            DataTable dtsum = db.GetDataTable(sumsql);
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
        public string GetTaxSummaryReportAsCSVString(DateTime FirstStartDate, DateTime LastEndDate) {
            using (DataSet ds = GetTaxSummaryReport(FirstStartDate, LastEndDate)) {

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



        /// <summary>
        /// Returns a DataTable loaded ShortSessionDatas from XML Session files from Sessions directory
        /// </summary>
        /// <returns></returns>
        public DataTable GetXMLSessionsDataTable() {
            DataTable dt = GetSessionList();
            dt.Clear();

            //en-GB
            //nl-NL
            System.Globalization.CultureInfo culture =
                new System.Globalization.CultureInfo(config.Database_Currency_Culture);

            string[] files = Directory.GetFiles(DRFile.GetApplicationPath() + UF.SessionDirName);

            for (int i = 0; i < files.Length; i++) {
                DataRow dr = dt.NewRow();
                XmlTextReader myReader = new XmlTextReader(files[i]);

                bool blnContinue = true;
                while (myReader.Read() && blnContinue) {
                    if (myReader.NodeType == XmlNodeType.Element && myReader.LocalName.Equals("sessionData")) {
                        while (myReader.Read()) {
                            if (myReader.LocalName.Equals("SessionIID"))
                                dr["IID"] = myReader.ReadString();
                            else if (myReader.LocalName.Equals("SessionStartDateTime"))
                                dr["StartDate"] = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("SessionEndDateTime"))
                                dr["EndDate"] = Convert.ToDateTime(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("GrossSessionTotal"))
                                dr["GrossSessionTotal"] = float.Parse(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("NetSessionTotal"))
                                dr["NetSessionTotal"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("ItemSum"))
                                dr["ItemSum"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("ExtraSum"))
                                dr["ExtraSum"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("DiscountSum"))
                                dr["DiscountSum"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("RefundSum"))
                                dr["RefundSum"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X1Total"))
                                dr["X1Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X2Total"))
                                dr["X2Total"] = Convert.ToSingle(myReader.ReadString(), culture);
                            else if (myReader.LocalName.Equals("X3Total"))
                                dr["X3Total"] = Convert.ToSingle(myReader.ReadString(), culture);                           
                            else if (myReader.LocalName.Equals("Orders")) {
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


        #endregion




        public bool AddSimpleTopOrderItemToAttachedOrder(string EntityButtonIID, bool blnIncrementIfPossible) {
            if (AttachedOrder == null)
                return false;
            bool blnDone = false;
            EntityButton eb = GetJustEntityButton(EntityButtonIID);
            Entity entity = GetEntityDB(eb.PEIID);
            OrderItem oi = new OrderItem(AttachedOrder.IID, entity.IID, "", 1,
                UF.GetRelatedPrice(null, entity, eb, AttachedOrder),
                EntityButtonIID, eb.EntityButtonName, entity.DistributionIID, OrderItemTypes.NormalOrderItem, 0,
                entity.EntityName, entity.DisplayOrder, GetEBTaxPercent(eb));
            if (blnIncrementIfPossible) {
                foreach (OrderItem item in AttachedOrder.items) {
                    if (item.EntityButtonIID == eb.IID && item.DistributionIID == entity.DistributionIID) {
                        item.Increment();
                        blnDone = true;
                        break;
                    }
                }
            }
            if (!blnDone) {
                AttachedOrder.AddOrderItem(oi);
                blnDone = true;
            }
            return blnDone;
        }

        public OrderItem DirectCreateTopOrderItemForOrder(Order order, string EntityButtonIID, bool blnSaveOrder=false) {            
            EntityButton eb = GetJustEntityButton(EntityButtonIID);
            Entity entity = GetEntityDB(eb.PEIID);
            OrderItem oi = new OrderItem(order.IID, entity.IID, ShortGuid.NewGuid().ToString(), 1,
                UF.GetRelatedPrice(null, entity, eb, order),
                EntityButtonIID, eb.EntityButtonName, entity.DistributionIID, OrderItemTypes.NormalOrderItem, 0,
                entity.EntityName, order.items.Count, GetEBTaxPercentForGenericOrder(order, eb));
            OrderItem thesameitem = order.items.Find(x => x.EntityButtonIID == eb.IID && x.DistributionIID == eb.DistributionIID);
            if (thesameitem != null)
                thesameitem.Increment();
            else
                order.AddIncrementOrderItem(oi);
            if (blnSaveOrder)
                SaveOrder(order);
            return oi;
        }
        public OrderItem DirectCreateTopOrderItemForOrder(string orderIID, string EntityButtonIID, bool blnSaveOrder = false) {
            EntityButton eb = GetJustEntityButton(EntityButtonIID);
            Entity entity = GetEntityDB(eb.PEIID);
            Order order = GetOrder(orderIID);
            OrderItem oi = new OrderItem(orderIID, entity.IID, ShortGuid.NewGuid().ToString() , 1,
                UF.GetRelatedPrice(null, entity, eb, order),
                EntityButtonIID, eb.EntityButtonName, entity.DistributionIID, OrderItemTypes.NormalOrderItem, 0,
                entity.EntityName,order.items.Count, GetEBTaxPercentForGenericOrder(order,eb));
            OrderItem thesameitem = order.items.Find(x => x.EntityButtonIID == eb.IID && x.DistributionIID == eb.DistributionIID);
            if (thesameitem != null)
                thesameitem.Increment();
            else 
                order.AddIncrementOrderItem(oi);
            if (blnSaveOrder)
                SaveOrder(order);
            return oi;
        }
        public bool DirectDeleteOrderItem(string orderItemIID) {
            return db.RunQuery("DeleteOrderItem '" + orderItemIID + "'");
        }
        public bool DirectIncrementOrderItem(string orderItemIID) {
            return db.RunQuery("update orderitem set Quantity = Quantity + 1 where IID = '" + orderItemIID + "'");
        }
        public bool DirectDecrementOrderItem(string orderItemIID) {
            db.RunQuery("update orderitem set Quantity = Quantity - 1 where IID = '" + orderItemIID + "'");
            return db.RunQuery("delete orderitem where Quantity = 0 and IID ='" + orderItemIID + "'");
        }

        public float GetOrderTotal(string orderIID) {
            return float.Parse(db.GetDataTable("Select CalculatedValue as Total from OrdersView where IID ='" + 
                orderIID + "'").Rows[0]["Total"].ToString());
        }

        public DataTable GetWebDisplayTableForOrder() {
            DataTable dt = CreateWebDisplayTableForOrder();
            foreach (OrderItem oi in AttachedOrder.items) {
                DataRow row = dt.NewRow();
                row["IID"] = oi.IID;
                row["Quantity"] = oi.Quantity;
                row["OrderItemText"] = oi.OrderItemText;
                row["CalculatedValue"] = (oi.Quantity * oi.Price).ToString("c2");
                dt.Rows.Add(row);
            }
            return dt;
        }

        private DataTable CreateWebDisplayTableForOrder() {
            DataTable dt = new DataTable();
            dt.Columns.Add(CreateDataTableColumn("IID", System.Type.GetType("System.String")));
            dt.Columns.Add(CreateDataTableColumn("Quantity", System.Type.GetType("System.String")));
            dt.Columns.Add(CreateDataTableColumn("OrderItemText", System.Type.GetType("System.String")));
            dt.Columns.Add(CreateDataTableColumn("CalculatedValue", System.Type.GetType("System.String")));

            return dt;
        }

        private DataColumn CreateDataTableColumn(string ColumnName, Type dataType) {
            return new DataColumn(ColumnName, dataType);
        }





        public bool HasPadItems() {
            try {
                return
                    int.Parse(
                        db.GetDataTable(
                            "select count(PadFlag) as PadItems from EntityButton where PadFlag > 0 and ParentMenuIID = '" +
                            config.ActiveMenuIID + "'").Rows[0]["PadItems"].ToString()) > 0;
            } catch {
                return false;
            }
        }

        public int GetHoldingOrderCount() {
            DataTable dt =
                db.GetDataTable("select count(IID) as totalordercount from OrdersView Where payment = 0 and Status = " +
                                (int)StatusFlags.PENDING + " and SessionIID = '" + GetCurrentSessionIID() + "'");
            return int.Parse(dt.Rows[0]["totalordercount"].ToString());
        }

        public bool CurrentSessionHasXOrders() {
            DataTable dt =
                db.GetDataTable("Select Count(IID) as xordercount from XOrders where SessionIID ='" +
                                GetCurrentSessionIID() + "'");
            return int.Parse(dt.Rows[0]["xordercount"].ToString()) > 0;
        }

        public float GetCurrentSessionXSum() {
            DataTable dt =
                db.GetDataTable("Select isnull(Sum(CalculatedValue),0) as Total from OrdersView where SessionIID = '" +
                                GetCurrentSessionIID() + "'");
            return float.Parse(dt.Rows[0]["Total"].ToString());
        }

        public float GetSessionOrderSum(string SessionIID) {
            DataTable dt =
                db.GetDataTable("Select Sum(CalculatedValue) as Total from OrdersView where SessionIID = '" + SessionIID +
                                "'");
            return float.Parse(dt.Rows[0]["Total"].ToString());
        }

        public float GetSessionPaymentSum(string SessionIID, PaymentMethods paymentMethod) {
            DataTable dt =
                db.GetDataTable("Select Sum(CalculatedValue) as Total from OrdersView where SessionIID = '" + SessionIID +
                                "' and Payment = " + (int)paymentMethod);
            return float.Parse(dt.Rows[0]["Total"].ToString());
        }
        public void PrintImage(Bitmap b, string printerNetworkName) {
            using (PrintDocument pd = new PrintDocument()) {
                pd.PrintPage += (object printSender, PrintPageEventArgs printE) => {
                    printE.Graphics.DrawImageUnscaled(b, new Point(0, 0));
                };

                using (PrintDialog dialog = new PrintDialog()) {
                    dialog.ShowDialog();
                    pd.PrinterSettings = dialog.PrinterSettings;
                    pd.PrinterSettings.PrinterName = printerNetworkName;
                    pd.Print();
                }
            }
        }

        #region VersionData

        public int GetDbVersion() {
            try {
                DataTable dt = db.GetDataTable("Select MdfFileVersion from Luv");
                return int.Parse(dt.Rows[0]["MdfFileVersion"].ToString());

            } catch {
                return 1000;
            }
        }

        public bool SaveDbVersion(int DbVersion) {
            try {
                return db.RunQuery("Update Luv set MdfFileVersion = " + DbVersion);
            } catch {
                return false;
            }
        }

        public bool RunFileSql(ref int errorcount, string sql) {

            //split the script on "GO" commands
            string[] splitter = new string[] { "\r\nGO\r\n" };
            string[] sqlScriptList = sql.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string singlesql in sqlScriptList) {
                //execute commandText
                if (!RunQuery(singlesql))
                    errorcount++;
            }
            return errorcount == 0;
        }

        #endregion

        #region KITCHEN ORDERS
        public List<Distribution> GetFirstDisplayTypeList() {
            List<Distribution> theList = new List<Distribution>();
            try {
                DataTable dt = db.GetDataTable("Select * from Distribution where IID in (" + config.Default_Distribution_Terminal_Type_List + ")");
                for (int i = 0; i < dt.Rows.Count; i++)
                    theList.Add(new Distribution(dt.Rows[i]));
                return theList;                
            } catch {
                return theList;
            }
        }
        public List<Distribution> GetSecondDisplayTypeList() {
            List<Distribution> theList = new List<Distribution>();
            try {
                DataTable dt = db.GetDataTable("Select * from Distribution where IID in (" + config.Secondary_Distribution_Terminal_Type_List + ")");
                for (int i = 0; i < dt.Rows.Count; i++)
                    theList.Add(new Distribution(dt.Rows[i]));
                return theList;
            } catch {
                return theList;
            }            
        }
        public bool SaveKitchenOrder(KitchenOrder order) {
            if (db.RunQuery("SaveKitchenOrder '" + order.IID + "','" + order.Reference + "'," +
                DRDateTime.DatetimeToMSSql(order.CreatedDateTime) + ",'" + order.OrderIID + "'," +
                DRDateTime.DatetimeToMSSql(order.CompletedDateTime) + "," + (int)order.GetStatus() + "," + db.BoolToInt(order.BeingModified) + "," + (int)order.OrderType)) {
                bool test = true;
                for (int i = 0; i < order.items.Count; i++) {
                    KitchenOrderItem koi = order.items[i];
                    test = test && db.RunQuery("SaveKitchenOrderItem '" + koi.IID + "'," + koi.Quantity + ",'" +
                        koi.ItemText + "','" + koi.KitchenOrderIID + "','" + koi.DistributionIID + "','" + 
                        koi.EntityButtonIID + "'," + (int)koi.Status);
                    if (!test)
                        return false;
                }
                return test;
            } else
                return false;
        }
        public bool DeleteKitchenOrder(string IID, bool blnForce) {
            if (blnForce) {
                db.RunQuery("Delete from KitchenOrderItem where KitchenOrderIID ='" + IID + "'");
                db.RunQuery("Delete from KitchenOrders where IID = '" + IID + "'");
            } else
                db.RunQuery("DeleteKitchenOrder '" + IID + "'");
            return !IsKitchenOrderExist(IID);

        }
        public void DeleteRelatedKitchenOrderForceFully(string RealOrderIID) {
            DataTable dt = db.GetDataTable("Select * from KitchenOrders where OrderIID = '" + RealOrderIID + "'");
            if (dt.Rows.Count > 0) {
                for (int i = 0; i < dt.Rows.Count; i++)
                    DeleteKitchenOrder(dt.Rows[i]["IID"].ToString(), true);
            }
        }

        public bool IsKitchenOrderExist(string IID) {
            return db.GetDataTable("Select IID from KitchenOrders where IID = '" + IID + "'").Rows.Count > 0;
        }

        public bool IsKitchenOrderBeingModified(string IID) {
            try {
                return int.Parse(db.GetDataTable("Select BeingModified from KitchenOrders where IID = '" + IID + "'").Rows[0]["BeingModified"].ToString()) == 1;
            } catch {
                return false;
            }
        }
        public bool MarkKitchenOrderItemsCompleted(string korderIID, string DistributionIID) {
            return db.RunQuery("update kitchenOrderItem set Status =" + (int)KitchenOrderStatusTypes.Completed +
                " where KitchenOrderIID ='" + korderIID + "' and DistributionIID = '" + DistributionIID + "'");
        }
        public bool MarkKitchenOrderItemsCompleted(string korderIID, List<Distribution> theDistributionList) {
            return db.RunQuery("update kitchenOrderItem set Status =" + (int)KitchenOrderStatusTypes.Completed +
                " where KitchenOrderIID ='" + korderIID + "' and DistributionIID in (" + 
                GetCommaSeperatedDistributionIIDListForDatabase(theDistributionList) + ")");
        }

        /// <summary>
        /// if StepableOrderItemGroupIID == ""  all items are old so check if deletable
        /// if StepableOrderItemGroupIID == "a guid" than there are new items in order so check if this item is new  or not
        ///      new : deletable
        ///      old : check
        /// </summary>
        /// <param name="oi"></param>
        /// <returns></returns>
        public bool CanDeleteKitchenOrderItemIfPrepared(OrderItem oi) {
            //No need to check just delete
            if (!config.Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted)
                return true;

            //NEW item no problem just delete
            if (StepableOrderItemGroupIID == oi.OrderGroupIID)
                return true;

            if (StepableOrderItemGroupIID == "") {
                //all items must be checked if OrderGroupIID != StepableOrderItemGroupIID
                if (oi.OrderGroupIID == StepableOrderItemGroupIID)
                    return true;    //will never happen just logical sense for me
                else {
                    //old item check it
                    if (oi.CompletedQuantity > 0)
                        return false;
                    else
                        return true;
                }
            } else {
                //NEW item no problem just delete
                if (StepableOrderItemGroupIID == oi.OrderGroupIID)
                    return true;
                else {
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
        public string GetCommaSeperatedDistributionIIDListForDatabase(List<Distribution> theList) {
            string str = "";
            for (int i=0; i < theList.Count; i++) {
                str += "'" + theList[i].IID + "',";
            }
            if (str.Length > 0)
                return str.Substring(0, str.Length-1);

            return str;
        }



        public bool MarkKitchenOrderCompletedOn(string korderIID) {
            return db.RunQuery("Update KitchenOrders set CompletedDateTime = getDate() where IID ='" + korderIID + "'");
        }

        public List<KitchenOrder> GetKitchenOrderList() {
            List<KitchenOrder> korderList = new List<KitchenOrder>();
            DataTable dtKorder = db.GetDataTable("Select IID from KitchenOrders order by OrderNo");
           
            for (int i= 0; i < dtKorder.Rows.Count; i++) 
                korderList.Add(GetKitchenOrder(dtKorder.Rows[i]["IID"].ToString()));

            return korderList;
        }

        public KitchenOrder GetKitchenOrder(string IID) {
            DataTable dt = db.GetDataTable("Select * from KitchenOrders Where IID ='" + IID + "'");
            try {
                KitchenOrder korder = new KitchenOrder(dt);
                dt = db.GetDataTable("Select * from KitchenOrderItem where KitchenOrderIID = '" + IID + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                    korder.items.Add(new KitchenOrderItem(dt.Rows[i]));
                return korder;
            } catch {
                return null;
            }
        }

        public DataTable GetAllKitchenOrders() {
            return db.GetDataTable("Select * from KitchenOrders order By OrderNo");
        }
        public DataTable GetKitchenOrderItems(string korderIID) {
            return db.GetDataTable("Select * from KItchenOrderItem where KitchenOrderIID ='" + korderIID + "'");
        }

        public KitchenOrder GetRelatedKitchenOrder(string RealOrderIID) {
            DataTable dt = db.GetDataTable("Select * from KitchenOrders where OrderIID = '" + RealOrderIID + "'");
            if (dt.Rows.Count > 0)
                return new KitchenOrder(dt);
            else
                return null;
        }
        public KitchenOrder GetRelatedKitchenOrderWithItems(string RealOrderIID) {
            DataTable dt = db.GetDataTable("Select * from KitchenOrders where OrderIID = '" + RealOrderIID + "'");
            if (dt.Rows.Count > 0) {
                KitchenOrder korder = new KitchenOrder(dt);
                if (korder == null)
                    return null; 
                else {
                    //Load items
                    DataTable dtItems = db.GetDataTable("Select * from KitchenOrderItem Where KitchenOrderIID ='" + korder.IID + "'");
                    for (int i = 0; i < dtItems.Rows.Count;i++) {
                        korder.items.Add(new KitchenOrderItem(dtItems.Rows[i]));
                    }
                    return korder;
                }
            } else
                return null;
        }
        public List<KitchenOrder> GetKitchenOrdersByStatus(KitchenOrderStatusTypes status, bool blnAscending, List<Distribution> distributionList) {
            string asctext = blnAscending ? "asc" : "desc";
            DataTable dt = null;
            string distributionIIDList = GetCommaSeperatedDistributionIIDListForDatabase(distributionList);
            if (distributionIIDList == "")
                return new List<KitchenOrder>();
            
            switch (status) {
                case KitchenOrderStatusTypes.All:
                    dt = db.GetDataTable("Select IID from KitchenOrders order by CreatedDateTime " + asctext);
                    break;
                case KitchenOrderStatusTypes.Waiting:
                    //waiting and partialycompleted
                    dt = db.GetDataTable("select IID from KitchenOrders where (status = 0 or status = 1) and " +
                        " IID in (select KitchenOrderIID from KitchenOrderItem where DistributionIID in (" +
                        distributionIIDList + ") and status = 0) " + " order by CreatedDateTime " + asctext);

                    break;
                case KitchenOrderStatusTypes.Completed:
                    //partialycompleted and completed
                    dt = db.GetDataTable("select IID from KitchenOrders where (status = 1 or status = 2) and " +
                     " IID in (select KitchenOrderIID from KitchenOrderItem where DistributionIID in (" +
                     distributionIIDList + ") and status = 2) " + " order by CompletedDateTime " + asctext);

                    break;
                case KitchenOrderStatusTypes.PartialyCompleted:
                    dt = db.GetDataTable("Select IID from KitchenOrders where status = " + (int)status + " order by CreatedDateTime " + asctext);
                    break;
            }

            List<KitchenOrder> theList = new List<KitchenOrder>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                theList.Add(GetKitchenOrder(dt.Rows[i]["IID"].ToString()));
            }
            //if (theList.Count > 0 && theList[0].OrderNo > config.Kitchen_Order_Reseed_Limit)
            //    ResetKitchenOrderIdentitySeed();

            return theList;
        }

        public KitchenOrder ConvertOrderToKitchenOrder(Order order) {
            KitchenOrder korder = new KitchenOrder {
                Reference = order.Reference,
                CreatedDateTime = DateTime.Now,
                OrderIID = order.IID
            };

            for (int i = 0; i < order.items.Count; i++) {
                KitchenOrderItem korderitem = new KitchenOrderItem {
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


        /// <summary>
        /// This is to use the old kitchen order to mark new kitchen order's item's status as accordingly
        /// </summary>
        /// <param name="korder1">previous kitchen order</param>
        /// <param name="korder2">augmented kitchen order</param>
        /// <returns></returns>
        public KitchenOrder MarkCompletedItemsInKorder2UsingKorder1(KitchenOrder korder1, KitchenOrder korder2) {
            if (korder1 == null)
                return korder2;

            for (int i = 0; i < korder1.items.Count; i++) {
                KitchenOrderItem kitem1 = korder1.items[i];
                KitchenOrderItem kitem2 = korder2.items.Find(x => x.EntityButtonIID == kitem1.EntityButtonIID);
                //No item found in the new order so pass
                if (kitem2== null)
                    continue;
                //New item found but it has more quantity and the old one so pass again (reason to flash)
                if (kitem2.Quantity > kitem1.Quantity)
                    continue;

                //New item found and has less or equal quantity than the old item so mark its status whatever it was in old item
                if (kitem2.Quantity <= kitem1.Quantity)
                    kitem2.Status = kitem1.Status;
            }

            //When you got here all the existing items mark accordingly in the new order there is nothing left so return
            return korder2;
        }


        public void SetKitchenOrderModifiedStateForAttachedOrder(bool blnBeingModified) {
            try {
                if (((AttachedOrder.Status == StatusFlags.DONE || AttachedOrder.Status == StatusFlags.PENDING) &&
                        (config.Table_Orders_Display_Kitchen_Orders || config.Hold_Order_Display_in_Kitchen)) ||
                        (!blnBeingModified && AttachedOrder.Status == StatusFlags.COMPLETED)) {
                    db.RunQuery("Update KitchenOrders set BeingModified = " + db.BoolToInt(blnBeingModified) + " where OrderIID ='" + AttachedOrder.IID + "'");
                    SetKitchenModified();
                }
            } catch (Exception ex) {
                SaveDebug("157 : " + ex.Message);
            }
        }

        /// <summary>
        /// This function restarts the orderno in kitchenorders table from 1 again so the number doesn't get to ridiculious numbers
        /// </summary>
        //public void ResetKitchenOrderIdentitySeed() {
        //    db.RunQuery("DBCC CHECKIDENT ('[KitchenOrders]', RESEED, 0)");
        //}

        public bool ShrinkKitchenOrderList() {
            DataTable dt = db.GetDataTable("Select IID from KitchenOrders where Status = " + (int)KitchenOrderStatusTypes.Completed);
            if (dt.Rows.Count <= config.Kitchen_Max_Completed_Order_Count)
                return false;

            int topCount = dt.Rows.Count - config.Kitchen_Max_Completed_Order_Count;
            dt = db.GetDataTable("Select Top " + topCount + " IID from KitchenOrders where Status = " +
                (int)KitchenOrderStatusTypes.Completed + " order by CompletedDateTime asc");
            for (int i = 0; i < dt.Rows.Count; i++)
                DeleteKitchenOrder(dt.Rows[i]["IID"].ToString(), false);

            return true;
        }

        public DateTime GetKitchenModified() {
            try {
                return DateTime.Parse(db.GetDataTable("Select KitchenModified from Luv").Rows[0]["KitchenModified"].ToString());
            } catch { }
            return DateTime.Now;
        }
        public bool SetKitchenModified() {
            //return db.RunQuery("update Luv set KitchenModified = GETDATE()");
            return db.RunQuery("UpdateKitchenModified");
        }

        public bool CleanKitchenOrdersHasNoParentOrder() {
            return db.RunQuery("CleanKitchenOrdersHasNoParentOrder");
        }
        #endregion

        #region SUPPLIER
        public Supplier GetSupplier(string IID) {
            return new Supplier(db.GetDataTable("Select * from Supplier where IID ='" + IID + "'"));
        }
        public DataTable GetAllSuppliers() {
            return db.GetDataTable("Select * from Supplier");
        }
        public List<Supplier> GetAllSuppliersAsList() {
            DataTable dt = db.GetDataTable("Select * from Supplier");
            List<Supplier> theList = new List<Supplier>();
            for (int i=0; i < dt.Rows.Count; i++) {
                theList.Add(new Supplier(dt.Rows[i]));
            }
            return theList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="blnForce">True: delete the supplier even it has stockitem in the list, False: will only delete if there is no entry in stockitem table in supplierIID column</param>
        /// <returns></returns>
        public bool DeleteSupplier(string IID, bool blnForce) {
            int count = int.Parse(db.GetDataTable("Select count(IID) as howmany from StockItem where SupplierIID = '" +
                IID + "'").Rows[0]["howmany"].ToString());
            if (count > 0) {
                if (blnForce)
                    return db.RunQuery("Delete from Supplier where IID ='" + IID + "'");
                else
                    return false;
            } else
                return db.RunQuery("Delete from Supplier where IID ='" + IID + "'");
        }
        public bool SaveSupplier(Supplier supplier) {
            return db.RunQuery("SaveSupplier " +
                "'" + supplier.IID + "','" + supplier.SupplierName.Replace("'", "''") + "','" +
                supplier.Tel.Replace("'", "''") + "','" + supplier.Address.Replace("'", "''") + "','" +
                supplier.Email1 + "','" + supplier.Email2 + "','" + supplier.Whatsup.Replace("'", "''") + "'");
        }
        #endregion

        #region STOCK ITEM
        public StockItem GetStockItem(string IID) {
            return new StockItem(db.GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on Supplier.IID = StockItem.SupplierIID  where StockItem.IID = '" + IID + "'"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="blnForce">True: will delete the stock item regardless it has an entry in EBStockItemLookUp, False: it will only be deleted if no EBStockItemLookup Entry </param>
        /// <returns></returns>
        public bool DeleteStockItem(string IID, bool blnForce) {
            int count = int.Parse(db.GetDataTable("Select count(StockItemIID) as howmany from EntityButtonStockItemLookUp where StockItemIID = '" +
                IID + "'").Rows[0]["howmany"].ToString());
            if (count > 0) {
                if (blnForce)
                    return db.RunQuery("Delete from StockItem where IID ='" + IID + "'");
                else
                    return false;
            } else 
                return db.RunQuery("Delete from StockItem where IID ='" + IID + "'");
        }
        public bool SaveStockItem(StockItem stockitem) {
            string sql = "SaveStockItem " + "'" + stockitem.IID + "','" + stockitem.StockName.Replace("'", "''") + "'," +
        (int)stockitem.QuantityType + "," + (int)stockitem.OrderType + "," + stockitem.Conversion + ",'" + stockitem.SupplierIID + "'," + stockitem.UsedQuantity;
            return db.RunQuery(sql);
        }

        /// <summary>
        /// Uses net quantity, it expects converted value
        /// </summary>
        /// <param name="StockItemIID"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public bool UpdateStockItemUsedQuantity(string StockItemIID,  int quantity) {
            return db.RunQuery("update stockItem set UsedQuantity = UsedQuantity + " + quantity + " where IID = '" + StockItemIID + "'" );
        }



        /// <summary>
        /// Give Quantity, it uses conversion itself  1 for 1 crate of (24) bottles for example, pass negative value if need to remove from stock
        /// </summary>
        /// <param name="stockItemIID"></param>
        /// <param name="Quantity">Create quantity 1 for 24 luk kasaya mesela</param>
        /// <returns></returns>
        public bool BifileStockItem(string stockItemIID, int Quantity) {
            return db.RunQuery("update stockitem set UsedQuantity = (UsedQuantity - (" + Quantity + " * Conversion)) where IID = '" + stockItemIID + "'");
        }

        public bool SetStockItemQuantity(string stockItemIID, int Quantity) {
            return db.RunQuery("update stockItem set UsedQuantity = " + Quantity + " where IID = '" + stockItemIID + "'");
        }

        //public bool UpdateStockItemUsedQuantityNotConverted(string StockItemIID, int quantity) {
        //    eturn db.RunQuery("update stockItem set UsedQuantity = UsedQuantity + " + quantity + " where IID = '" + StockItemIID + "'");
        //}

        public DataTable GetAllStockItems() {
            return db.GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID order by StockName");
        }
        public List<StockItem> GetAllStockItemsList()
        {
            DataTable dtStockItems = db.GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID order by StockName");
            List<StockItem>  stockItems = new List<StockItem>();
            foreach (DataRow dr in dtStockItems.Rows)
            {
                stockItems.Add(new StockItem(dr));
            }
            return stockItems;
        }
        public DataTable SearchStockItems(string searchText) {
            return db.GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID where StockName like '%" + searchText + "%' order by StockName");
        }
        public DataTable SearchStockItems(string searchText, string SupplierIID) {
            return db.GetDataTable("Select StockItem.*, SupplierName from StockItem left join supplier on supplier.IID = StockItem.SupplierIID where StockName like '%" + searchText + "%' and SupplierIID ='" + SupplierIID + "' order by StockName");
        }
        public DataTable GetAllStockItemsShort() {
            return db.GetDataTable("Select IID,StockName from StockItem order by StockName asc");
        }
        public DataTable GetAllStockItemsShortForEB(string EntityButtonIID) {
            return db.GetDataTable("Select IID,StockName from StockItem where IID not in (Select StockItemIID from EntityButtonStockItemLookUp where EntityButtonIID = '" + EntityButtonIID + 
                "') order by StockName asc");
        }
        public DataTable GetStockItemsForSupplier(string SupplierIID) {
            return db.GetDataTable("Select StockItem.*, SupplierName from stockitem left join supplier on supplier.IID = StockItem.SupplierIID where SupplierIID = '" + SupplierIID + "'");
            //return db.GetDataTable("Select StockItem.*, SupplierName from StokItem where SupplierIID = '" + SupplierIID + "' Order by StockName asc");
            //return db.GetDataTable("Select * from StokItem where IID in (Select StockItemIID from Supplier where SupplierIID ='" + SupplierIID + "')");
        }
        public List<string> GetStockItemNamesForSupplier(string SupplierIID) {
            DataTable dt = db.GetDataTable("Select StockName from StockItem where SupplierIID ='" + SupplierIID + "'");
            List<string> theList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
                theList.Add(dt.Rows[i]["StockName"].ToString());
            return theList;
        }
        #endregion

        #region EB  STOCKITEM FUNCTIONS

        //public List<StockManager> GetAllStockManager() {
        //    DataTable dt = db.GetDataTable("GetMenuList");
        //    List<StockManager> stockManagerList = new List<StockManager>();
        //    for (int i = 0; i < dt.Rows.Count; i++) {
        //        string menuIID = dt.Rows[i]["IID"].ToString();
        //        stockManagerList.Add(GetStockManager(menuIID));
        //    }
        //    return stockManagerList;
        //}
        //GenericProgressFunction progress, int startfrom

        public StockManager GetStockManager(GenericProgressFunction progress=null, int startfrom=0) {
            StockManager sm = new StockManager();

            //Load Suppliers (all of them)
            DataTable dtSuppliers = db.GetDataTable("Select * from Supplier");
            for (int i=0; i < dtSuppliers.Rows.Count; i++) {
                sm.Suppliers.Add(new Supplier(dtSuppliers.Rows[i]));
                progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            }

            //Load EntityButtonStockItemLookUp
            DataTable dtEBStockItemLookup = db.GetDataTable("select * from EntityButtonStockItemLookUp");
            for (int i = 0; i < dtEBStockItemLookup.Rows.Count; i++) {
                sm.EBStockItemLookups.Add(new EntityButtonStockItemLookUp(dtEBStockItemLookup.Rows[i]));
                progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            }

            //Load StockItems
            DataTable dtStockItem = db.GetDataTable("Select * from StockItem");
            for (int i = 0; i < dtStockItem.Rows.Count; i++) {
                sm.StockItems.Add(new StockItem(dtStockItem.Rows[i]));
                progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            }

            ////Load GenericImages
            //DataTable dtGenericImages = db.GetDataTable("select * from Images");
            //for (int i = 0; i < dtGenericImages.Rows.Count; i++) {
            //    sm.GenericImages.Add(new GenericImage(dtGenericImages.Rows[i], true));
            //    progress?.Invoke(null, new System.ComponentModel.ProgressChangedEventArgs(startfrom + i, null));
            //}

            return sm;
        }
        
        public bool SaveStockManager(StockManager sm) {
            //Save Suppliers
            for (int i = 0; i < sm.Suppliers.Count; i++) {
                SaveSupplier(sm.Suppliers[i]);
            }

            //Save StockItems
            for (int i = 0; i < sm.StockItems.Count; i++) {
                SaveStockItem(sm.StockItems[i]);
            }

            ////Save Generic Images
            //for (int i = 0; i < sm.GenericImages.Count; i++) {
            //    SaveGenericImage(sm.GenericImages[i]);
            //}

            //Save EntityButtonStockItemLookUps
            for (int i = 0; i < sm.EBStockItemLookups.Count; i++) {
                SaveEntityButtonStockItemLookUp(sm.EBStockItemLookups[i]);
            }

            return true;
        }


        public List<EntityButtonStockItemLookUp> GetAllEntityButtonStockItemLookUps()
        {
            //Load EntityButtonStockItemLookUp
            DataTable dtEBStockItemLookup = db.GetDataTable("select * from EntityButtonStockItemLookUp");

            List<EntityButtonStockItemLookUp> lookupItems = new List<EntityButtonStockItemLookUp>();
            for (int i = 0; i < dtEBStockItemLookup.Rows.Count; i++)
            {
                //SaveEntityButtonStockItemLookUp((new EntityButtonStockItemLookUp(dtEBStockItemLookup.Rows[i])));
                lookupItems.Add(new EntityButtonStockItemLookUp(dtEBStockItemLookup.Rows[i]));
               
            }
            return lookupItems;
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
        public DataTable GetStockItemsForEB(string EBIID) {
             return db.GetDataTable("SELECT EntityButtonStockItemLookUp.*, StockItem.StockName FROM EntityButtonStockItemLookUp left join StockItem on StockItemIID = StockItem.IID where EntityButtonIID = '" + EBIID + "' order by DisplayOrder asc");
        }

        /// <summary>
        /// DataTable with Columns EntityButtonIID, EntityButtonName
        /// </summary>
        /// <param name="StockItemIID"></param>
        /// <returns></returns>
        public DataTable GetEBListForStockItem(string StockItemIID) {
            return db.GetDataTable("SELECT EntityButtonIID, EntityButtonName FROM EntityButtonStockItemLookUp left join EntityButton on EntityButtonIID = EntityButton.IID where StockItemIID = '" + StockItemIID + "'");
        }

        public EntityButtonStockItemLookUp GetEntityButtonStockItemLookUp(string IID)
        {
            return new EntityButtonStockItemLookUp(db.GetDataTable("Select * from EntityButtonStockItemLookUp where IID = '" + IID + "'"));
        }
        //public EntityButtonStockItemLookUp GetEntityButtonStockItemLookUp(string EntityButtonIID, string StockItemIID) {
        //    return new EntityButtonStockItemLookUp(db.GetDataTable("Select * from EntityButtonStockItemLookUp where EntityButtonIID = '" +
        //        EntityButtonIID + "' and StockItemIID = '" + StockItemIID + "'"));
        //}
        public bool UpdateStockItemLookUpDisplayOrder(string IID, int newdisplayOrder) {
            return db.RunQuery("Update EntityButtonStockItemLookUp set DisplayOrder =" + newdisplayOrder + " where  IID ='" + IID + "'");
        }

        //public bool DeleteEntityButtonStockItemLookUp(EntityButtonStockItemLookUp lookup)
        //{
        //    return db.RunQuery("Delete from EntityButtonStockItemLookUp where IID ='" + lookup.IID + "'");
        //}
        public bool DeleteEntityButtonStockItemLookUp(string IID)
        {
            return db.RunQuery("Delete from EntityButtonStockItemLookUp where IID ='" + IID + "'");
        }
        //public bool DeleteEntityButtonStockItemLookUp(string EBIID, string StockItemIID) {
        //    return db.RunQuery("Delete from EntityButtonStockItemLookUp where EntityButtonIID ='"+ EBIID + "' and StockItemIID = '" + StockItemIID + "'");
        //}
        //public bool SaveEntityButtonStockItemLookUp(string EBIID, string StockItemIID, QuantityTypes qType, int quantity) {
        //    return db.RunQuery("SaveEntityButtonStockItemLookUp '" + EBIID + "','" + StockItemIID + "'," + (int)qType + "," + quantity);
        //}
        public bool SaveEntityButtonStockItemLookUp(EntityButtonStockItemLookUp lookup) {
            return db.RunQuery("SaveEntityButtonStockItemLookUp '" + lookup.IID + "','" + lookup.EntityButtonIID + "','" + lookup.StockItemIID + "'," + 
                (int)lookup.QuantityType + "," + lookup.Quantity.ToString(ci) + "," + lookup.DisplayOrder + ",'" + lookup.Comment + "'");
        }
        
        /// <summary>
        /// When you run this function you should delete the orderitems.
        /// This can only be done once and at the end of the session.
        /// </summary>
        /// <param name="blnIncrement"></param> UsedQuantity + newValue / if false just UsedQuantity
        /// <returns></returns>
        public bool TransferStockItemUsageNow() {
            bool blnIncrement = true;
            return db.RunQuery("update stockItem set UsedQuantity = (Select SessionQuantity from StockItemUsage where StockItem.IID = StockItemUsage.StockItemIID) " + (blnIncrement?" + UsedQuantity":"") +
                " where stockItem.IID in (Select StockItemIID from StockItemUsage)");
        }


        public StockItemUsage GetSingleStockItemUsageAsObject(string StockItemIID) {
            DataTable dt = db.GetDataTable("Select * from StockItemUsage where StockItemIID = '" + StockItemIID + "'");
            if (dt.Rows.Count > 0)
                return new StockItemUsage(dt);
            else
                return null;
        }

        public DataTable GetStockItemUsage(bool OrderableOnly) {
            if (OrderableOnly)
                return db.GetDataTable("Select * from StockItemUsage where OrderableQuantity >= 1 order by SupplierName asc");
            else {
                //return db.GetDataTable("Select * from StockItemUsage where TotalQuantity > 0 order by SupplierName asc");
                return db.GetDataTable("Select * from StockItemUsage order by SupplierName asc");
            }
        }

        public DataTable GetSupplierListWhichHasOrderableStockItem() {
            return db.GetDataTable("select * from supplier where IID in (select SupplierIID from stockitemusage where orderablequantity > 0)");
        }

        public List<string> GetSupplierIIDListWhichHasOrderableStockItems() {
            List<string> theList = new List<string>();
            DataTable dt = db.GetDataTable("select SupplierIID from stockitemusage where orderablequantity > 0");
            for (int i= 0; i < dt.Rows.Count; i++) {
                theList.Add(dt.Rows[i]["SupplierIID"].ToString());
            }
            return theList;
        }
        public DataTable GetStockItemUsageWithSearch(bool OrderableOnly, string searchText) {
            if (OrderableOnly)
                return db.GetDataTable("Select * from StockItemUsage where OrderableQuantity >= 1  and StockName Like '%" + searchText + "%' order by SupplierName asc");
            else {
                //return db.GetDataTable("Select * from StockItemUsage where TotalQuantity > 0 order by SupplierName asc");
                return db.GetDataTable("Select * from StockItemUsage  where StockName Like '%" + searchText + "%'  order by SupplierName asc");
            }
        }
        public DataTable GetStockItemUsageBySupplier(string SupplierIID, bool OrderableOnly) {
            if (OrderableOnly)
                return db.GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' and  OrderableQuantity >= 1  order by SupplierName asc");
            else {
               // return db.GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' and TotalQuantity > 0 order by SupplierName asc");
                return db.GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' order by SupplierName asc");
            }
        }
        public DataTable GetStockItemUsageBySupplierWithSearch(string SupplierIID, bool OrderableOnly, string searchText) {
            if (OrderableOnly)
                return db.GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' and  OrderableQuantity >= 1 and StockName Like '%" + searchText + "%' order by SupplierName asc");
            else {
                // return db.GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "' and TotalQuantity > 0 order by SupplierName asc");
                return db.GetDataTable("Select * from StockItemUsage where supplierIID ='" + SupplierIID + "'  and StockName Like '%" + searchText + "%' order by SupplierName asc");
            }
        }
        public DataTable GetOrderableStockUsage() {
            return db.GetDataTable("Select OrderableQuantity as HowMany, OrderableType, StockName, SupplierName from StockItemUsage where OrderableQuantity >= 1 order by SupplierName asc");
        }

        

        /// <summary>
        /// conversion 24  and UsedQuantity 50 than the result will be  (50 % 24) = 2, simply modulus of the used quantity (kalan)
        /// Call this function carefully. It is non-reversable.
        /// </summary>
        /// <returns></returns>
        public bool RemoveOrderedStockUsage(bool blnConvertableOnly) {
            if (blnConvertableOnly)
                return db.RunQuery("update stockitem set UsedQuantity = (UsedQuantity % Conversion)");
            else
                return db.RunQuery("Update StockItem set UsedQuantity =0");
        }

        public bool PrintStockUsage( ApplicationPrinter ap) {
            return new ReportGenerator(this, ap,  2).PrintStockUsage(GetStockItemUsage(true), null);
        }
        //public bool PrintStockUsage(string printerNetworkName) {
        //    return new ReportGenerator(this, printerNetworkName, 2).PrintStockUsage(GetStockItemUsage(true), null);
        //}
        public bool PrintStockUsage( ApplicationPrinter ap, DataTable dtStockUsage, string SupplierName) {
            return new ReportGenerator(this, ap,2).PrintStockUsage(dtStockUsage, SupplierName);
        }


        public DataTable GetEntityButtonStockItemRecipeFromEntityButton(string EntityButtonIID) {
            return db.GetDataTable("Select * from EntityButtonStockItemRecipe where EntityButtonIID ='" + EntityButtonIID + "'");
        }

        public DataTable GetEntityButtonStockItemRecipeFromStockItem(string StockItemIID) {
            return db.GetDataTable("Select * from EntityButtonStockItemRecipe where StockItemIID ='" + StockItemIID + "'");
        }
        //public bool PrintStockUsage(DataTable dtStockUsage, string SupplierName) {
        //    ApplicationPrinter ap = GetDefaultReceiptPrinter();
        //    if (ap != null) {
        //        ReportGenerator generator = new ReportGenerator(this, ap.NetworkName, config.ReportFontName,
        //            config.ReportFontSize, Color.Black, 2, 1, 10);
        //        return generator.PrintStockUsage(dtStockUsage, SupplierName);
        //    }
        //    return false;
        //}

        //public bool PrintStockUsage(string printerIID, DataTable dtStockUsage) {
        //    ApplicationPrinter ap = GetPrinter(printerIID);
        //    if (ap != null) {
        //        ReportGenerator generator = new ReportGenerator(this, ap.NetworkName, config.ReportFontName,
        //            config.ReportFontSize, Color.Black, 2, 1, 10);
        //        return generator.PrintStockUsage(dtStockUsage,null);
        //    }
        //    return false;
        //}

        public bool PrintDataTable(string printerIID, DataTable dt,  string CustomReportName, List<int> columnSize,bool blnIncludeHeaders) {
            ApplicationPrinter ap = GetPrinterForClient(printerIID);
            if (ap != null) {
                return new ReportGenerator(this, ap,  2).PrintDataTable(dt,  CustomReportName,columnSize,blnIncludeHeaders);
            }

            return false;
        }
        public bool PrintDataTable(ApplicationPrinter ap, DataTable dt,  string CustomReportName, List<int> columnSize,bool blnIncludeHeaders) {
            
            if (ap != null) {
                return new ReportGenerator(this, ap, 2).PrintDataTable(dt,  CustomReportName,columnSize,blnIncludeHeaders);
            }

            return false;
        }

        public List<int> GetColumnPrintRatio(DataGridView dgv) {
            int totalwidth = 0;
            List<int> columnSize = new List<int>();
            for (int i = 0; i < dgv.Columns.Count; i++) {
                if (dgv.Columns[i].Visible) {
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
        public string GenerateCsvTextFromDataTable(DataTable dt) {
           // DataSet ds = new DataSet();

            DataGridViewCsvExporter exporter = new DataGridViewCsvExporter(null);
            exporter.GenerateFromDataTable(dt, true, new CultureInfo(config.Database_Currency_Culture));
            exporter.NewLine();
            return exporter.csvText;            
        }

        public string GetOrderableStockItemUsageAsCsvText() {
            return GenerateCsvTextFromDataTable(GetOrderableStockUsage());
        }
        public string  SaveStockItemUsageFile() {
            string filename = "Usage\\StockItemUsage_" + DateTime.Now.ToString("dd MMM yyyy HHmm") + ".csv";
            if (DataGridViewCsvExporter.Export(filename, GetOrderableStockItemUsageAsCsvText()))
                return filename;
            else
                return "";
        }
        //public string SaveStockItemUsageFile(string SupplierName, DataTable dt) {
        //    string filename = "Usage\\StockItemUsage_" + DateTime.Now.ToString("dd MMM yyyy HHmm") + "_" + SupplierName + ".csv";
        //    if (DataGridViewCsvExporter.Export(filename, GetOrderableStockItemUsageAsCsvText()))
        //        return filename;
        //    else
        //        return "";
        //}

        #endregion

        

        

        #region DiSPLAY IMAGE FUNCTIONS
        public Image GetImageFromDatabase(string ReferenceIID) {
            DataTable dt = db.GetDataTable("Select * from Images where ReferenceIID ='" + ReferenceIID + "'");
            if (dt.Rows.Count > 0) 
                return DRUF.byteArrayToImage((byte[])dt.Rows[0]["DisplayImage"]);
            else
                return null;
        }

        public GenericImage GetEntityButtonPrepImage(string EntityButtonIID) {
            GenericImage gim = GetGenericImage(EntityButtonIID);
            if (gim == null)
                return null;

            gim.ExtraText = GetEntityButtonStockItemText(EntityButtonIID) + gim.ExtraText;
            return gim;
        }
        public string GetEntityButtonStockItemText(string EntityButtonIID) {
            DataTable dt = GetStockItemsForEB(EntityButtonIID);
            //StockItemLookup , stockName
            string str = "";
            for (int i =0; i < dt.Rows.Count; i++) {
                float val = float.Parse(dt.Rows[i]["Quantity"].ToString());
                if (val == 0)
                {
                    str += dt.Rows[i]["Comment"].ToString();
                    str += "\r\n";
                } else
                {
                    //str += dt.Rows[i]["Quantity"].ToString() + "  ";
                    //str += ((QuantityTypes)int.Parse(dt.Rows[i]["QuantityType"].ToString())).ToString() + "  ";


                    str += dt.Rows[i]["Comment"].ToString() + "  ";
                    if (dt.Rows[i]["StockName"] != null)
                        str += dt.Rows[i]["StockName"].ToString();
                    str +="\r\n";
                }
            }
            return str;
        }

        public bool DeletePrepImage(string ReferenceIID) {
            return db.RunQuery("Delete from Images where ReferenceIID ='" + ReferenceIID + "'");
        }
        public GenericImage GetGenericImage(string ReferenceIID) {
            DataTable dt = db.GetDataTable("Select * from Images where ReferenceIID ='" + ReferenceIID + "'");
            if (dt.Rows.Count > 0)
                return new GenericImage(dt);
            else
                return null;
        }

        public DataTable GetAllImages() {
            return db.GetDataTable("Select * from Images");
        }
        public List<GenericImage> GetImageLibraryList() {
            List<GenericImage> imageList = new List<GenericImage>();
            try {
                DataTable dt = db.GetDataTable("Select * from Images");
                for (int i = 0; i < dt.Rows.Count; i++) {
                    GenericImage gim = new GenericImage(dt.Rows[i],true);
                    imageList.Add(gim);
                }
                return imageList;
            } catch {
                return imageList;
            }
        }

        public bool DeleteGenericImage(string referenceIID) {
            return db.RunQuery("Delete from Images where ReferenceIID = '" + referenceIID + "'");
        }
        public bool SaveGenericImage(GenericImage gim) {
            //return db.RunQuery("SaveGenericeImage '" + gim.ReferenceIID + "',")
            try {
                SqlConnection con = new SqlConnection(db.ConnectionString);

                using (SqlCommand comm = new SqlCommand("SaveGenericImage", con) {
                    CommandType = CommandType.StoredProcedure
                }) {

                    SqlParameter ReferenceIID = new SqlParameter("ReferenceIID", gim.ReferenceIID);
                    byte[] imgbuf = DRUF.imageToByteArray(gim.DisplayImage);
                    SqlParameter DisplayImage = new SqlParameter("DisplayImage", SqlDbType.VarBinary, imgbuf.Length) {
                        Value = imgbuf
                    };

                    SqlParameter ExtraText = new SqlParameter("ExtraText", gim.ExtraText);
                    SqlParameter ImageFileName = new SqlParameter("ImageFileName", gim.ImageFileName);

                    comm.Parameters.Add(ReferenceIID);
                    comm.Parameters.Add(DisplayImage);
                    comm.Parameters.Add(ExtraText);
                    comm.Parameters.Add(ImageFileName);
                    con.Open();
                    int i = comm.ExecuteNonQuery();
                    con.Close();
                    return i > 0;
                }

            } catch {
                return false;
            }
        }

        /// <summary>
        /// Send directoryinfo fullName to folderpath
        /// </summary>
        /// <param name="folderpath"></param>
        /// <returns></returns>
        public bool ExportDatabaseImagesIntoFolder(string folderpath) {
            try {
                DataTable dt = db.GetDataTable("Select * from Images");
                for (int i=0; i < dt.Rows.Count; i++) {
                    GenericImage gim = new GenericImage(dt.Rows[i]);
                    string filename = folderpath + "\\" + gim.ReferenceIID + ".png";
                    gim.DisplayImage.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                }
                return true;                  
            } catch  {
                return false;
            }
        }

        #endregion

        public bool HasActiveHoldOrders() {
            DataTable dt = db.GetDataTable("Select count(IID) as howmany from Orders where OrderType =" + (int)OrderTypes.DirectSale + " and status = " + (int)StatusFlags.PENDING);
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        public bool HasActiveTableOrders() {
            DataTable dt = db.GetDataTable("Select count(IID) as howmany from Orders where OrderType =" +
                (int)OrderTypes.InHouse + " and  (status = " + (int)StatusFlags.NEW + " or status = " + (int)StatusFlags.DONE + ")");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }

        /// <summary>
        /// At least there should be 1 completed order, Only checks the completed orders not concern about archived orders
        /// </summary>
        /// <returns></returns>
        public bool HasCurrentSessionCompletedOrders() {
            DataTable dt = db.GetDataTable("Select count(IID) as howmany from Orders where status = " +
                (int)StatusFlags.COMPLETED + " and SessionIID ='" + GetCurrentSessionIID() + "'");
            return int.Parse(dt.Rows[0]["howmany"].ToString()) > 0;
        }



        #region BACKUP FUNCTIONS
        public bool GetDatabaseBackup(ref DatabaseBackup backup, DatabaseBackupOptions options) {
            try {
                // DatabaseBackup backup = new DatabaseBackup();

                //Load Customers
                if (options.blnCustomers) {                    
                    DataTable dtCustomers = GetAllCustomers();
                    for (int i = 0; i < dtCustomers.Rows.Count; i++) {
                        backup.customerList.Add(new Customer(dtCustomers.Rows[i]));
                    }
                }

                
                //Load Users
                if (options.blnUsers)
                    backup.userList = GetUserList();

                //Load Printer List
                if (options.blnPrinters)
                    backup.printerList = GetApplicationPrinterList();

                //Load Luv
                if (options.blnLuv)
                    backup.luv = GetLuv();

                //Load Current Session
                if (options.blnCurrentSession) {
                    DataTable dtCurrentSession = db.GetDataTable("Select * from Sessions where IID = '" + luv.CurrentSessionIID + "'");
                    backup.currentSession = new SessionData(dtCurrentSession);
                }

                //Load Table Layout
                if (options.blnTables) {
                    DataTable dtTableGroups = GetAllTableGroups();
                    for (int i = 0; i < dtTableGroups.Rows.Count; i++) {
                        backup.tableGroupList.Add(new TableGroup(dtTableGroups.Rows[i]));
                    }

                    DataTable dtTables = GetAllTables();
                    for (int i = 0; i < dtTables.Rows.Count; i++) {
                        backup.tableList.Add(new Table(dtTables.Rows[i]));
                    }
                }

                //Load All the Menus
                if (options.blnMenus) 
                    backup.menuList = GetAllMenuList();
                
                //Load Stock Manager
                if (options.blnStock) 
                    backup.stockManager = GetStockManager();

                //Load Orders
                if (options.blnOrders) 
                    backup.orderList = GetOrderList();                

                //Load XOrders
                if (options.blnXOrders) 
                    backup.xorderList = GetXOrderList();                 

                //Load Kitchen Orders
                if (options.blnKitchenOrders) 
                    backup.kitchenOrderList = GetKitchenOrderList();                

                //Load Debug Information
                if (options.blnDebugInformation) 
                    backup.debugList = GetDebugList();

                //Load Image Library
                if (options.blnImages)
                    backup.imageList = GetImageLibraryList();
                
                return true;
            } catch {
                return false;
            }
        }

        public bool ShringIID(string TableName) {
            try {
                DataTable dt = db.GetDataTable("Select IID from " + TableName);
                for (int i = 0; i < dt.Rows.Count; i++) {
                    string oldIID = dt.Rows[i]["IID"].ToString();
                    string newIID = ShortGuid.NewGuid().ToString();
                    db.RunQuery("Update " + TableName + " set IID = '" + newIID + "' where IID = '" + oldIID + "'");
                }
                return true;
            } catch {
                return false;
            }
        }
        public bool ShrinkCustomer(string customerIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            return db.RunQuery("Update Customer set IID = '" + newIID + "' where IID = '" + customerIID + "'");
        }
        public bool ShrinkAllCustomers() {
            try {
                DataTable dt = db.GetDataTable("Select IID from Customer");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkCustomer(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }
        public bool ShrinkUser(string userIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            return db.RunQuery("Update Users set IID = '" + newIID + "' where IID = '" + userIID + "'");
        }
        public bool ShrinkAllUsers() {
            try {
                DataTable dt = db.GetDataTable("Select IID from Users");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkUser(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }
        public bool ShrinkApplicationPrinter(string printerIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            return db.RunQuery("Update ApplicationPrinter set IID = '" + newIID + "' where IID = '" + printerIID + "'") &&
                    db.RunQuery("Update PrinterLookup set PrinterIID = '" + newIID + "' where PrinterIID = '" + printerIID + "'") &&
                    db.RunQuery("Update Distribution set PrinterIID = '" + newIID + "' where PrinterIID = '" + printerIID + "'");
        }
        public bool ShrinkAllApplicationPrinters() {
            try {
                DataTable dt = db.GetDataTable("Select IID from ApplicationPrinter");
                for (int i = 0; i < dt.Rows.Count; i++) 
                    ShrinkApplicationPrinter(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }
        public bool ShrinkTable(string TableIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            return db.RunQuery("Update Tables set IID = '" + newIID + "' where IID = '" + TableIID + "'");
        }
        public bool ShrinkAllTables() {
            try {
                DataTable dt = db.GetDataTable("Select IID from Tables");
                for (int i = 0; i < dt.Rows.Count; i++) 
                    ShrinkTable(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }
        public bool ShrinkTableGroup(string tableGroupIID) {
            try {
                string newIID = ShortGuid.NewGuid().ToString();
                //Update TableGroup IID
                db.RunQuery("Update TableGroup set IID = '" + newIID + "' where IID = '" + tableGroupIID + "'");
                //Update GroupIID in Tables
                db.RunQuery("Update Tables set GroupIID = '" + newIID + "' where GroupIID = '" + tableGroupIID + "'");
                //Update IID Fields of this table group tables
                DataTable dt = db.GetDataTable("Select IID from Tables");
                for (int i = 0; i < dt.Rows.Count; i++) {
                    string oldTableIID = dt.Rows[i]["IID"].ToString();
                    ShrinkTable(oldTableIID);
                }
                return true;
            } catch {
                return false;
            }

        }
        public bool ShrinkAllTableGroups() {
            try {
                bool blnStatus = false;
                DataTable dt = db.GetDataTable("Select IID from TableGroup");
                for (int i = 0; i < dt.Rows.Count; i++) {
                    string oldTableGroupIID = dt.Rows[i]["IID"].ToString();
                    blnStatus = blnStatus && ShrinkTableGroup(oldTableGroupIID);
                }
                return blnStatus;
            } catch {
                return false;
            }
        }

        public bool ShrinkDistribution(string DistributionIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            //Update IID of the distribution 
            return db.RunQuery("Update Distribution set IID = '" + newIID + "' where IID = '" + DistributionIID + "'") &&
            //Update DistributionIID of the EntityButtons
            db.RunQuery("Update EntityButton set DistributionIID = '" + newIID + "' where DistributionIID = '" + DistributionIID + "'") &&
            //Update DistributionIID of the Entities
            db.RunQuery("Update Entity set DistributionIID = '" + newIID + "' where DistributionIID = '" + DistributionIID + "'");
        }

        public bool ShrinkEntityButton(string ebIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            //Update IID of the Entity Button 
            return db.RunQuery("Update EntityButton set IID = '" + newIID + "' where IID = '" + ebIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this entity button
            db.RunQuery("Update Images set ReferenceIID = '" + newIID + "' where ReferenceIID = '" + ebIID + "'") &&
            //Update DistributionIID of the Entities
            db.RunQuery("Update EntityButtonStockItemLookUp set EntityButtonIID = '" + newIID + "' where EntityButtonIID = '" + ebIID + "'");
        }

        public bool ShrinkEntity(string eIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            //Update IID of the Entity 
            return db.RunQuery("Update Entity set IID = '" + newIID + "' where IID = '" + eIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this entity
            db.RunQuery("Update Images set ReferenceIID = '" + newIID + "' where ReferenceIID = '" + eIID + "'") &&
            //Update DistributionIID of the Entities
            db.RunQuery("Update EntityButton set ParentEntityIID = '" + newIID + "' where ParentEntityIID = '" + eIID + "'");

        }

        public bool ShrinkMenu(string menuIID) {
            string newMenuIID = ShortGuid.NewGuid().ToString();
            //Update IID of the Menu 
            if (db.RunQuery("Update Menu set IID = '" + newMenuIID + "' where IID = '" + menuIID + "'") &&
                //Update ParentMenuIID in Entity
                db.RunQuery("Update Entity set ParentMenuIID = '" + newMenuIID + "' where ParentMenuIID = '" + menuIID + "'") &&
                //Update ParentMenuIID in EntityButton
                db.RunQuery("Update EntityButton set ParentMenuIID = '" + newMenuIID + "' where ParentMenuIID = '" + menuIID + "'") &&
                //Update ParentMenuIID in Distribution
                db.RunQuery("Update Distribution set ParentMenuIID = '" + newMenuIID + "' where ParentMenuIID = '" + menuIID + "'")) {

                //Now shrink Entity List
                try {
                    DataTable dt = db.GetDataTable("Select IID from Entity where ParentMenuIID ='" + newMenuIID + "'") ;
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        string entityIID = dt.Rows[i]["IID"].ToString();
                        ShrinkEntity(entityIID);
                    }
                } catch {
                    MessageBox.Show("Failed to shrink categories for this menu");
                    return false;
                }

                //Now shrink EntityButtons
                try {
                    DataTable dt = db.GetDataTable("Select IID from EntityButton where ParentMenuIID ='" + newMenuIID + "'");
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        string entityButtonIID = dt.Rows[i]["IID"].ToString();
                        ShrinkEntityButton(entityButtonIID);
                    }
                } catch {
                    MessageBox.Show("Failed to shrink category items for this menu");
                    return false;
                }

                //Now shrink Disributions
                try {
                    DataTable dt = db.GetDataTable("Select IID from Distribution where ParentMenuIID ='" + newMenuIID + "'");
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        string distributionIID = dt.Rows[i]["IID"].ToString();
                        ShrinkDistribution(distributionIID);
                    }
                } catch {
                    MessageBox.Show("Failed to shrink distributions for this menu");
                    return false;
                }

                return true;
            }
            return false;
        }

        public bool ShrinkAllMenus() {
            try {
                DataTable dt = db.GetDataTable("Select IID from Menu");
                for (int i = 0; i < dt.Rows.Count; i++)
                    ShrinkMenu(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }

        public bool ShrinkStockItem(string itemIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            //Update IID of the StockItem 
            return db.RunQuery("Update StockItem set IID = '" + newIID + "' where IID = '" + itemIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this stockItem
            db.RunQuery("Update Images set ReferenceIID = '" + newIID + "' where ReferenceIID = '" + itemIID + "'") &&
            //Update StockItemIID in EntityButtonStockItemLookUp of the StockItem
             db.RunQuery("Update EntityButtonStockItemLookUp set StockItemIID = '" + newIID + "' where StockItemIID = '" + itemIID + "'");
        }

        public bool ShrinkAllStockItems() {            
            try {
                DataTable dt = db.GetDataTable("Select IID from StockItem");
                for (int i = 0; i < dt.Rows.Count; i++) 
                    ShrinkStockItem(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }

        public bool ShrinkSupplier(string suppIID) {
            string newIID = ShortGuid.NewGuid().ToString();
            //Update IID of the StockItem 
            return db.RunQuery("Update Supplier set IID = '" + newIID + "' where IID = '" + suppIID + "'") &&
            //Update ReferenceIID in Images if any referenced to this stockItem
            db.RunQuery("Update StockItem set SupplierIID = '" + newIID + "' where SupplierIID = '" + suppIID + "'");
        }

        public bool ShrinkAllSuppliers() {            
            try {
                DataTable dt = db.GetDataTable("Select IID from Supplier");
                for (int i = 0; i < dt.Rows.Count; i++) 
                    ShrinkSupplier(dt.Rows[i]["IID"].ToString());
                return true;
            } catch {
                return false;
            }
        }

        public bool ShrinkStockManager() {
            try {
                return ShrinkAllSuppliers() && ShrinkAllStockItems();
            } catch {
                return false;
            }
        }

        public bool ShrinkDatabase() {
            try {
                return ShrinkAllCustomers() && ShrinkAllUsers() && ShrinkAllApplicationPrinters() &&
                ShrinkAllTableGroups() && ShrinkAllTables() && ShrinkAllMenus() && ShrinkStockManager();
            } catch {
                return false;
            }
        }

        public bool MoveStockItemToAnotherSupplier(string StockItemIID, string NewSupplierIID) {
            StockItem sitem = GetStockItem(StockItemIID);
            Supplier supplier = GetSupplier(NewSupplierIID);

            if (sitem != null && supplier != null && sitem.SupplierIID != supplier.IID) {
                sitem.SupplierIID = supplier.IID;
                return SaveStockItem(sitem);
            }
            return false;
        }

        public bool MoveEntityButtonToAnotherEntity(string EntityButtonIID, string newEntityIID) {
            EntityButton eb = GetJustEntityButton(EntityButtonIID);
            Entity en = GetEntityDB(newEntityIID);
            if (en != null && eb != null && en.ParentMenuIID == eb.ParentMenuIID && eb.PEIID != en.IID) {
                eb.PEIID = newEntityIID;
                return SaveJustEntityButton(eb, en.ParentMenuIID);
            }
            return false;
        }

        public bool MoveTableToAnotherTableGroup(string TableIID, string newTableGroupIID) {
            Table table = GetTable(TableIID);
            TableGroup tableGroup = GetTableGroup(newTableGroupIID);
            if (table != null && tableGroup != null && table.GroupIID != tableGroup.IID) {
                table.GroupIID = tableGroup.IID;
                return SaveTable(table);
            }
            return false;
        }
        #endregion

        #region COUNTERS         
        public int GetTableRowCount(string TableName, string FieldToCount) {
            return int.Parse(db.GetDataTable("Select count(" + FieldToCount + ") as total from " + TableName).Rows[0]["total"].ToString());
        }
        public int GetIIDCount(string TableName) {
            return int.Parse(db.GetDataTable("Select count(IID) as total from " + TableName).Rows[0]["total"].ToString());
        }
        #endregion

        #region BONUS FUNCTIONS
        public DataTable GetAllBonus() {
            return db.GetDataTable("Select *,'' as DaysAvailableAsString from Bonus Order by PlanName");
        }
        public List<Bonus> GetAllBonusList() {
            List<Bonus> theList = new List<Bonus>();
            DataTable dt = GetAllBonus();
            for (int i=0; i < dt.Rows.Count; i++) {
                theList.Add(new Bonus(dt.Rows[i]));
            }
            return theList;
        }
        public Bonus GetBonus(string IID) {
            return new Bonus(db.GetDataTable("Select * from Bonus where IID ='" + IID + "'"));
        }
        public bool SaveBonus(Bonus bonus) {
            return db.RunQuery("SaveBonus '" + bonus.IID + "','" + bonus.PlanName + "','" + bonus.PlanDescription
                + "'," + bonus.Barrier0
                + "," + bonus.Barrier1
                + "," + bonus.Barrier2
                + "," + bonus.Barrier3
                + "," + bonus.Barrier4
                + "," + bonus.Barrier5
                + "," + bonus.Barrier6
                + "," + bonus.Barrier7
                + "," + bonus.Barrier8
                + "," + bonus.Barrier9
                + "," + bonus.Barrier10
                + "," + bonus.Barrier11
                + "," + bonus.Barrier12
                + "," + bonus.Barrier13
                + "," + bonus.Barrier14
                + "," + bonus.Barrier15
                + "," + bonus.Barrier16
                + "," + bonus.Barrier17
                + "," + bonus.Barrier18
                + "," + bonus.Barrier19
                + "," + bonus.Barrier20
                + "," + (int)bonus.DaysAvailable
                + ",'" + bonus.StartTime.ToString()
                + "','" + bonus.EndTime.ToString()
                + "','" + bonus.BonusHiddenStartTime.ToString() 
                + "','" + bonus.BonusHiddenEndTime.ToString() + "','" + bonus.StepValue + "','" + bonus.HalfStepValue + "'" );
        }
        public bool DeleteBonus(string IID) {
            return db.RunQuery("Delete from Bonus where IID ='" + IID + "'");
        }

        public void SetSuitableBonus() {
            this.currentBonusScheme = GetSuitableBonus();
           //MessageBox.Show(currentBonusScheme?.PlanName ?? "null bu");
        }

        public Bonus GetSuitableBonus() {
            WeekDays dayoftheweek = UF.GetTodaysDTRMWeekDay();
            List<Bonus> allBonus = GetAllBonusList();


            //Select Daily Available Bonuses
            List<Bonus> dailyAvailableBonusList = new List<Bonus>();
            foreach (Bonus bonus in allBonus) {
                if (PosLibrary.DRNumeric.IsBitSet((int)bonus.DaysAvailable,(int)dayoftheweek) ) {
                    dailyAvailableBonusList.Add(bonus);
                }
            }

            //Select Hourly Available Bonuses
            List<Bonus> timelyAvailableBonusList = new List<Bonus>();
            TimeSpan NowTimeSpan = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            TimeSpan Midnight = new TimeSpan(23, 59, 59);
            foreach (Bonus bonus in dailyAvailableBonusList) {
                //Within the same day shifts (day shift)
                if (bonus.StartTime < bonus.EndTime) {
                    if (NowTimeSpan >= bonus.StartTime  && NowTimeSpan <= bonus.EndTime)
                        timelyAvailableBonusList.Add(bonus);
                }
                //Within day over type, basically after 24:00 finishing shifts (night shift)
                if (bonus.StartTime > bonus.EndTime) {
                    if ((NowTimeSpan >= bonus.StartTime && NowTimeSpan <= Midnight) ||
                            (NowTimeSpan > new TimeSpan(0,0,0) && NowTimeSpan < bonus.EndTime)){
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

        public List<OrdersView> GetIrrelevantUnpaidOrders() {
            List<OrdersView> theList = new List<OrdersView>();
            DataTable dt = GetIrrelevantUnpaidOrdersDB();
            for (int i = 0; i < dt.Rows.Count; i++)
                theList.Add(new OrdersView(dt.Rows[i]));
            return theList;
        }
        public DataTable GetIrrelevantUnpaidOrdersDB() {
            return db.GetDataTable("Select * from OrdersView where Payment =0 and Status = 5 and SessionIID != '" + luv.CurrentSessionIID + "'");
        }
        public DataTable GetRelevantUnpaidCreatedOrNewOrdersDB() {
            return db.GetDataTable("Select * from OrdersView where Payment =0 and (Status = 0 || Status = 1) and SessionIID == '" + luv.CurrentSessionIID + "'");
        }
        public bool CreateDemoMenu(string menuName) {
            FMenu fmenu = new FMenu(menuName);

            //Create Distributions
            Distribution dist1 = new Distribution("Hot Drinks", "");
            dist1.ShortName = "HD";
            dist1.DisplayOrder = 0;
            dist1.ParentMenuIID = fmenu.IID;
            fmenu.Distributions.Add(dist1);

            Distribution dist2 = new Distribution("Cold Drinks", "");
            dist2.ShortName = "CD";
            dist2.DisplayOrder = 1;
            dist2.ParentMenuIID = fmenu.IID;
            fmenu.Distributions.Add(dist2);

            //Create Entities
            Entity entity1 = new Entity(fmenu.IID);
            entity1.EntityName = "CoffeeAndTea";
            entity1.DistributionIID = dist1.IID;
            entity1.DistributionName = dist1.DistributionName;
            entity1.DisplayOrder = 0;
            entity1.entityType = EntityTypes.NormalEntity;
            entity1.BackColour = Color.White.ToArgb();
            entity1.ForeColour = Color.Red.ToArgb();
            entity1.ParentMenuIID = fmenu.IID;
            entity1.ButtonHeight = 50;
            entity1.ButtonWidth = 120;
            entity1.FFamily = "Arial";
            entity1.FSize = 10;
            entity1.FStyle = "Bold";
            fmenu.items.Add(entity1);

            //Create EntityButtons for first entity
            EntityButton eb1 = new EntityButton();
            eb1.EntityButtonName = "Americano";
            eb1.DisplayOrder = 0;
            eb1.ButtonColor = Color.White.ToArgb();
            eb1.ForeColor = Color.Black.ToArgb();
            eb1.ButtonType = EntityButtonTypes.SimpleItem;
            eb1.AvailableFor = 0;  //everything
            eb1.PEIID = entity1.IID;
            eb1.ParentMenuIID = fmenu.IID;
            eb1.DirectSaleTaxPercent = eb1.InHouseTaxPercent = eb1.TakeAwayTaxPercent = eb1.DeliveryTaxPercent = 10;
            eb1.DirectSalePrice = eb1.InHousePrice = eb1.TakeAwayPrice = eb1.DeliveryPrice = 4.50f;
            eb1.ButtonWidth = 200;
            eb1.ButtonHeight = 50;
            eb1.FFamily = "Arial";
            eb1.FSize = 9;
            eb1.FStyle = "Regular";
            eb1.DistributionIID = dist1.IID;
            eb1.WithImage = false;
            entity1.Buttons.Add(eb1);
            

            EntityButton eb2 = new EntityButton();
            eb2.EntityButtonName = "Ice Tea";
            eb2.DisplayOrder = 0;
            eb2.ButtonColor = Color.White.ToArgb();
            eb2.ForeColor = Color.Black.ToArgb();
            eb2.ButtonType = EntityButtonTypes.SimpleItem;
            eb2.AvailableFor = 0;  //everything
            eb2.PEIID = entity1.IID;
            eb2.ParentMenuIID = fmenu.IID;
            eb2.DirectSaleTaxPercent = eb2.InHouseTaxPercent = eb2.TakeAwayTaxPercent = eb2.DeliveryTaxPercent = 10;
            eb2.DirectSalePrice = eb2.InHousePrice = eb2.TakeAwayPrice = eb2.DeliveryPrice = 6.50f;
            eb2.ButtonWidth = 200;
            eb2.ButtonHeight = 50;
            eb2.FFamily = "Arial";
            eb2.FSize = 9.75f;
            eb2.FStyle = "Bold";
            eb2.DistributionIID = dist2.IID;
            eb2.WithImage = false;
            entity1.Buttons.Add(eb2);


            Entity entity2 = new Entity(fmenu.IID);
            entity2.EntityName = "Soda And Others";
            entity2.DistributionIID = dist2.IID;
            entity2.DistributionName = dist2.DistributionName;
            entity2.DisplayOrder = 1;
            entity2.entityType = EntityTypes.NormalEntity;
            entity2.BackColour = Color.Yellow.ToArgb();
            entity2.ForeColour = Color.DarkBlue.ToArgb();
            entity2.ParentMenuIID = fmenu.IID;

            entity2.ButtonHeight = 50;
            entity2.ButtonWidth = 150;
            entity2.FFamily = "Microsoft Sans Serif";
            entity2.FSize = 12;
            entity2.FStyle = "Bold";
            fmenu.items.Add(entity2);
            

            //Create EntityButtons for first entity
            EntityButton eb3 = new EntityButton();
            eb3.EntityButtonName = "Fanta";
            eb3.DisplayOrder = 0;
            eb3.ButtonColor = Color.Yellow.ToArgb();
            eb3.ForeColor = Color.Black.ToArgb();
            eb3.ButtonType = EntityButtonTypes.SimpleItem;
            eb3.AvailableFor = 0;  //everything
            eb3.PEIID = entity2.IID;
            eb3.ParentMenuIID = fmenu.IID;
            eb3.DirectSaleTaxPercent = eb3.InHouseTaxPercent = eb3.TakeAwayTaxPercent = eb3.DeliveryTaxPercent = 10;
            eb3.DirectSalePrice = eb3.InHousePrice = eb3.TakeAwayPrice = eb3.DeliveryPrice = 4.50f;
            eb3.ButtonWidth = 120;
            eb3.ButtonHeight = 40;
            eb3.FFamily = "Arial";
            eb3.FSize = 11;
            eb3.FStyle = "Regular";
            eb3.DistributionIID = dist2.IID;
            eb3.WithImage = false;
            entity2.Buttons.Add(eb3);

            EntityButton eb4 = new EntityButton();
            eb4.EntityButtonName = "Whisky";
            eb4.DisplayOrder = 0;
            eb4.ButtonColor = Color.DarkOrange.ToArgb();
            eb4.ForeColor = Color.Black.ToArgb();
            eb4.ButtonType = EntityButtonTypes.SimpleItem;
            eb4.AvailableFor = 0;  //everything
            eb4.PEIID = entity2.IID;
            eb4.ParentMenuIID = fmenu.IID;
            eb4.DirectSaleTaxPercent = eb4.InHouseTaxPercent = eb4.TakeAwayTaxPercent = eb4.DeliveryTaxPercent = 19;
            eb4.DirectSalePrice = eb4.InHousePrice = eb4.TakeAwayPrice = eb4.DeliveryPrice = 6.50f;
            eb4.ButtonWidth = 150;
            eb4.ButtonHeight = 50;
            eb4.FFamily = "Arial";
            eb4.FSize = 12;
            eb4.FStyle = "Bold";
            eb4.DistributionIID = dist2.IID;
            eb4.WithImage = false;
            entity2.Buttons.Add(eb4);

            SaveMenuDB(fmenu);

            return true;
        }
    }
}
