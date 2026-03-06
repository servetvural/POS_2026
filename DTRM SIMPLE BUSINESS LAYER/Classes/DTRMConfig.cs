using System.ComponentModel;
using System.Drawing.Design;

namespace DTRMNS
{

    //CategoryAttribute 	This attribute places your property in the appropriate category in a node on the property grid.
    //DescriptionAttribute	This attribute places a description of your property at the bottom of the property grid
    //BrowsableAttribute	This is used to determine whether or not the property is shown or hidden in the property grid
    //ReadOnlyAttribute	Use this attribute to make your property read only inside the property grid
    //DefaultValueAttribute Specifies the default value of the property shown in the property grid
    //DefaultPropertyAttribute  If placed above a property, this property gets the focus when the property grid is first launched. 
    //Unlike the other attributes, this attribute goes above the class.

    //how to 
    //[CategoryAttribute("ID Settings"), DescriptionAttribute("Social Security Number of the customer")]
    //public proptype propName {
    //
    //}
    /*
        * [Browsable(false)] = to show property or not
        * [ReadOnly(bool)] = possibility to edit property
        * [Category(string)] = groups of property
        * [Description(string)] = property description.It is a hint
        * [DisplayName(string)] = display property
        * [Editor
        * [Editor(typeof(PropertyGridBrowseEditor), typeof(BaseInputEditor)]
        * */



    [System.Serializable]
    public class DTRMConfig
    {


        #region 10.Connection Settings



        private string _TerminalName = "Terminal ##";
        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("Name of this terminal"), DisplayName("Unique name of this Terminal")]
        public string Terminal_Name
        {
            get { return _TerminalName; }
            set { _TerminalName = value; }
        }

        private string _Database_Instance = ".";
        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute(@". or .\SQLEXPRESS or 192.168.1.20\SQLEXPRESS"), DisplayName("Database Server IP and/or instance name")]
        //[EditorAttribute(typeof(DatabaseServerEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string Database_Instance
        {
            get { return _Database_Instance; }
            set { _Database_Instance = value; }
        }

        private string _Database_Name = "DTRMSimple";
        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("Database Name  exp:DTRMSimple , must be a valid name."), DisplayName("Name of Database")]
        public string Database_Name
        {
            get { return _Database_Name; }
            set { _Database_Name = value; }
        }
        private string _Database_User_Name = "sa";
        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("It must be a valid username to access the database."), PasswordPropertyText(true), DisplayName("Database Username")]
        public string Database_User_Name
        {
            get { return _Database_User_Name; }
            set { _Database_User_Name = value; }
        }
        private string _Database_Password = "servetvural";
        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("It must be the given password during installation"), PasswordPropertyText(true), DisplayName("Database Password")]
        public string Database_Password
        {
            get { return _Database_Password; }
            set { _Database_Password = value; }
        }

        private string _Database_Currency_Culture = "en-GB";
        [CategoryAttribute("10.Connection Settings"), DisplayName("What is currency culture in database"), DescriptionAttribute("Database Currency Culture as Text exp: en-GB, nl-NL, tr-TR ")]
        public string Database_Currency_Culture { get { return _Database_Currency_Culture; } set { _Database_Currency_Culture = value; } }

        private string _Terminal_Currency_Culture = "en-GB";
        [CategoryAttribute("10.Connection Settings"), DisplayName("What is currency culture in terminal"), DescriptionAttribute("Terminal Currency Culture as Text exp:  en-GB, nl-NL, tr-TR ")]
        public string Terminal_Currency_Culture { get { return _Terminal_Currency_Culture; } set { _Terminal_Currency_Culture = value; } }

        private LanguageTypes _Terminal_UserInterface_Culture = LanguageTypes.English;
        [CategoryAttribute("10.Connection Settings"), DisplayName("Language of this terminal"), DescriptionAttribute("Terminal User Interface Language as Text exp:  English, Türkçe")]
        public LanguageTypes Terminal_UserInterface_Culture { get { return _Terminal_UserInterface_Culture; } set { _Terminal_UserInterface_Culture = value; } }

        #endregion

        #region 11.Direct Sale Order Settings
        private bool _Direct_Sale_Allowed = true;
        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Allow direct sale method"), DescriptionAttribute("Is Direct Sale Allowed On This Terminal")]
        public bool Direct_Sale_Allowed { get { return _Direct_Sale_Allowed; } set { _Direct_Sale_Allowed = value; } }

        private int _Direct_Sale_Receipt_Count = 1;
        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("How many receipt for direct sale to print"), DescriptionAttribute("Direct Sale Receipt Count")]
        public int Direct_Sale_Receipt_Count { get { return _Direct_Sale_Receipt_Count; } set { _Direct_Sale_Receipt_Count = value; } }

        private AutoPaymentMethods _DirectSalePaymentMehtod = AutoPaymentMethods.AutoCash;
        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Auto payment method for direct sale"), DescriptionAttribute("Direct Sale Default Payment Method")]
        public AutoPaymentMethods Direct_Sale_Auto_Payment_Mehtod { get { return _DirectSalePaymentMehtod; } set { _DirectSalePaymentMehtod = value; } }

        private string _Direct_Sale_Order_Button_Text = "SALE";
        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Text on direct sale button"), DescriptionAttribute("Direct Sale Button Text")]
        public string Direct_Sale_Order_Button_Text { get { return _Direct_Sale_Order_Button_Text; } set { _Direct_Sale_Order_Button_Text = value; } }

        private int _Direct_Sale_Button_Width = 100;
        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Width of direct sale button"), DescriptionAttribute("Direct Sale Button Width")]
        public int Direct_Sale_Button_Width { get { return _Direct_Sale_Button_Width; } set { _Direct_Sale_Button_Width = value; } }

        #endregion

        #region 12.Hold Order Settings
        private bool _Hold_Order_Available = true;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Allow order hold"), DescriptionAttribute("Can Hold Orders")]
        public bool Hold_Order_Available { get { return _Hold_Order_Available; } set { _Hold_Order_Available = value; } }

        private int _Hold_Button_Maximum_Shrunk_Width = 100;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Width of Shrunk Hold Order Button"), DescriptionAttribute("Maximum Width of Shrunk Hold Order Button")]
        public int Hold_Button_Maximum_Shrunk_Width { get { return _Hold_Button_Maximum_Shrunk_Width; } set { _Hold_Button_Maximum_Shrunk_Width = value; } }

        private int _Hold_Button_Maximum_Shrunk_Height = 50;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Height of Shrunk Hold Order Button"), DescriptionAttribute("Maximum Height of Shrunk Hold Order Button")]
        public int Hold_Button_Maximum_Shrunk_Height { get { return _Hold_Button_Maximum_Shrunk_Height; } set { _Hold_Button_Maximum_Shrunk_Height = value; } }


        private int _Hold_Button_Maximum_Extended_Width = 100;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Width of Extended Hold Order Button"), DescriptionAttribute("Maximum Width of Extended Hold Order Button When Extended")]
        public int Hold_Button_Maximum_Extended_Width { get { return _Hold_Button_Maximum_Extended_Width; } set { _Hold_Button_Maximum_Extended_Width = value; } }


        private int _Hold_Button_Maximum_Extended_Height = 200;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Height of Extended Hold Order Button"), DescriptionAttribute("Maximum Height of Extended Hold Order Button When Extended")]
        public int Hold_Button_Maximum_Extended_Height { get { return _Hold_Button_Maximum_Extended_Height; } set { _Hold_Button_Maximum_Extended_Height = value; } }




        private int _Hold_Order_Reload_Seconds = 5;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Held orders reload seconds"), DescriptionAttribute("Number of seconds to reload Hold Orders")]
        public int Hold_Orders_Reload_Seconds
        {
            get { return _Hold_Order_Reload_Seconds; }
            set
            {
                if (value < 3)
                    _Hold_Order_Reload_Seconds = 3;
                else
                    _Hold_Order_Reload_Seconds = value;
            }
        }

        private int _Hold_Order_Maximum_Allowed = 12;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum number of held orders allowed"), DescriptionAttribute("Maximum number of Hold Orders allowed")]
        public int Hold_Order_Maximum_Allowed { get { return _Hold_Order_Maximum_Allowed; } set { _Hold_Order_Maximum_Allowed = value; } }

        private bool _Hold_Order_Print_in_Kitchen = false;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Print held orders in kitchen printer"), DescriptionAttribute("Will print Hold Orders in Kitchen/Bar")]
        public bool Hold_Order_Print_in_Kitchen { get { return _Hold_Order_Print_in_Kitchen; } set { _Hold_Order_Print_in_Kitchen = value; } }

        private bool _Hold_Order_Display_in_Kitchen = false;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Display held orders in kitchen screen"), DescriptionAttribute("Will display Hold Orders in Kitchen/Bar")]
        public bool Hold_Order_Display_in_Kitchen { get { return _Hold_Order_Display_in_Kitchen; } set { _Hold_Order_Display_in_Kitchen = value; } }

        private bool _Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted = false;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Allow kitchen to delete completed orders from screen"), DescriptionAttribute("True: Prevents prepared items to be deleted from order")]
        public bool Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted { get { return _Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted; } set { _Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted = value; } }


        private float _Hold_Button_Price_Font_Size = 22;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Font size of held order buttons"), DescriptionAttribute("Hold button price font size")]
        public float Hold_Button_Price_Font_Size { get { return _Hold_Button_Price_Font_Size; } set { _Hold_Button_Price_Font_Size = value; } }


        private bool _Hold_Order_Auto_Close = false;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Hold Order Auto Close Enabled"), DescriptionAttribute("False: Closes the Hold Order automatically after certain period of time if no change is made")]
        public bool Hold_Order_Auto_Close { get { return _Hold_Order_Auto_Close; } set { _Hold_Order_Auto_Close = value; } }


        private int _Hold_Order_Auto_Close_Seconds = 10;
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Hold Order Auto Close Seconds"), DescriptionAttribute("How many seconds to wait to close the Hold Order automatically")]
        public int Hold_Order_Auto_Close_Seconds { get { return _Hold_Order_Auto_Close_Seconds; } set { _Hold_Order_Auto_Close_Seconds = value < 5 ? 5 : value; } }


        #endregion

        #region 13.Table Orders Settings
        private bool _Table_Orders_Allowed = false;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Allow table orders"), DescriptionAttribute("Table Sale Allowed On This Terminal")]
        public bool Table_Orders_Allowed { get { return _Table_Orders_Allowed; } set { _Table_Orders_Allowed = value; } }

        private int _Table_Orders_Receipt_Count = 1;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("How many receipt for table order to print"), DescriptionAttribute("Table Sale Receipt Count")]
        public int Table_Orders_Receipt_Count { get { return _Table_Orders_Receipt_Count; } set { _Table_Orders_Receipt_Count = value; } }

        private int _Table_Orders_Kitchen_Receipt_Count = 1;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("How many kitchen receipt for table order to print"), DescriptionAttribute("Table Kitchen Receipt Count")]
        public int Table_Orders_Kitchen_Receipt_Count { get { return _Table_Orders_Kitchen_Receipt_Count; } set { _Table_Orders_Kitchen_Receipt_Count = value; } }

        private AutoPaymentMethods _Table_Orders_Auto_Payment_Method = AutoPaymentMethods.Selective;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Auto payment method for table orders"), DescriptionAttribute("Table Sale Default Payment Method")]
        public AutoPaymentMethods Table_Orders_Auto_Payment_Method { get { return _Table_Orders_Auto_Payment_Method; } set { _Table_Orders_Auto_Payment_Method = value; } }


        private string _Table_Orders_Button_Text = "TABLES";
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Text on table order button"), DescriptionAttribute("Table Sale Button Text")]
        public string Table_Orders_Button_Text { get { return _Table_Orders_Button_Text; } set { _Table_Orders_Button_Text = value; } }

        private int _Table_Orders_Button_Width = 100;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Width of table order button"), DescriptionAttribute("Table Sale Button Width")]
        public int Table_Orders_Button_Width { get { return _Table_Orders_Button_Width; } set { _Table_Orders_Button_Width = value; } }

        private bool _Table_Orders_Display_Kitchen_Orders = false;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Display table orders in kitchen screen"), DescriptionAttribute("Create/Allow table orders to be displayed in kitchen display")]
        public bool Table_Orders_Display_Kitchen_Orders { get { return _Table_Orders_Display_Kitchen_Orders; } set { _Table_Orders_Display_Kitchen_Orders = value; } }

        private bool _Table_Orders_Always_Shrinked = true;
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Display table orders always shrinked"), DescriptionAttribute("Display table order's sub orders seperately")]
        public bool Table_Orders_Always_Shrinked { get { return _Table_Orders_Always_Shrinked; } set { _Table_Orders_Always_Shrinked = value; } }

        #endregion

        #region 14.Take-Away Orders Settings
        private bool _TakeAway_Orders_Allowed;
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Allow take-away orders"), DescriptionAttribute("Is Take-Away Sale Allowed On This Terminal")]
        public bool TakeAway_Orders_Allowed { get { return _TakeAway_Orders_Allowed; } set { _TakeAway_Orders_Allowed = value; } }

        private int _TakeAway_Orders_Receipt_Count = 1;
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("How many receipt for take-away orders to print"), DescriptionAttribute("Take-Away Sale Receipt Count")]
        public int TakeAway_Orders_Receipt_Count { get { return _TakeAway_Orders_Receipt_Count; } set { _TakeAway_Orders_Receipt_Count = value; } }

        private AutoPaymentMethods _TakeAway_Orders_Auto_Payment_Method = AutoPaymentMethods.AutoCash;
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Auto payment method for take-away orders"), DescriptionAttribute("Take-Away Sale Default Payment Method")]
        public AutoPaymentMethods TakeAway_Orders_Auto_Payment_Method { get { return _TakeAway_Orders_Auto_Payment_Method; } set { _TakeAway_Orders_Auto_Payment_Method = value; } }

        private string _TakeAway_Orders_Button_Text = "Take Away";
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Text on take-away order button"), DescriptionAttribute("Take-Away Sale Button Text")]
        public string TakeAway_Orders_Button_Text { get { return _TakeAway_Orders_Button_Text; } set { _TakeAway_Orders_Button_Text = value; } }

        private int _TakeAway_Orders_Button_Width = 100;
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Width of take-away order button"), DescriptionAttribute("Take-Away Sale Button Width")]
        public int TakeAway_Orders_Button_Width { get { return _TakeAway_Orders_Button_Width; } set { _TakeAway_Orders_Button_Width = value; } }

        private bool _TakeAway_Orders_Display_Kitchen_Orders = false;
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Display take-away orders in kitchen screen"), DescriptionAttribute("Allow takeaway orders to be displayed in kitchen display")]
        public bool TakeAway_Orders_Display_Kitchen_Orders { get { return _TakeAway_Orders_Display_Kitchen_Orders; } set { _TakeAway_Orders_Display_Kitchen_Orders = value; } }

        #endregion

        #region 15.Delivery Orders Settings
        private bool _Delivery_Orders_Allowed;
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Allow delivery orders"), DescriptionAttribute("Is Delivery Sale Allowed On This Terminal")]
        public bool Delivery_Orders_Allowed { get { return _Delivery_Orders_Allowed; } set { _Delivery_Orders_Allowed = value; } }

        private int _Delivery_Orders_Receipt_Count = 2;
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("How many receipt for delivery orders to print"), DescriptionAttribute("Delivery Sale Receipt Count")]
        public int Delivery_Orders_Receipt_Count { get { return _Delivery_Orders_Receipt_Count; } set { _Delivery_Orders_Receipt_Count = value; } }

        private AutoPaymentMethods _Delivery_Orders_Auto_Payment_Method = AutoPaymentMethods.Selective;
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Auto payment method for delivery orders"), DescriptionAttribute("Delivery Sale Default Payment Method")]
        public AutoPaymentMethods Delivery_Orders_Auto_Payment_Method { get { return _Delivery_Orders_Auto_Payment_Method; } set { _Delivery_Orders_Auto_Payment_Method = value; } }

        private string _Delivery_Orders_Button_Text = "Delivery";
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Text on delivery order button"), DescriptionAttribute("Delivery Sale Button Text")]
        public string Delivery_Orders_Button_Text { get { return _Delivery_Orders_Button_Text; } set { _Delivery_Orders_Button_Text = value; } }

        private int _Delivery_Orders_Button_Width = 100;
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Width of delivery order button"), DescriptionAttribute("Delivery Sale Button Width")]
        public int Delivery_Orders_Button_Width { get { return _Delivery_Orders_Button_Width; } set { _Delivery_Orders_Button_Width = value; } }


        private bool _Delivery_Orders_Display_Kitchen_Orders = false;
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Display delivery orders in kitchen screen"), DescriptionAttribute("Allow delivery orders to be displayed in kitchen display")]
        public bool Delivery_Orders_Display_Kitchen_Orders { get { return _Delivery_Orders_Display_Kitchen_Orders; } set { _Delivery_Orders_Display_Kitchen_Orders = value; } }


        #endregion

        #region 16.Other Order Settings
        private int _Cancel_Button_Width = 100;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Width of Cancel/Close Order Button"), DescriptionAttribute("Cancel/Close Order Button Width")]
        public int Cancel_Button_Width { get { return _Cancel_Button_Width; } set { _Cancel_Button_Width = value; } }

        private string _Cancel_Button_Image = "";
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Full file name of Cancel Button Image"), Editor(typeof(FilteredImageFileEditor), typeof(UITypeEditor)), DescriptionAttribute("Full name of Cancel Button Image with extension"), DefaultValueAttribute("")]
        public string Cancel_Button_Image { get { return _Cancel_Button_Image; } set { _Cancel_Button_Image = value; } }

        private string _Cancel_Button_BackColour = "Black";
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Background Colour of Cancel Button"), Editor(typeof(FilteredColorSelectEditor), typeof(UITypeEditor)), DescriptionAttribute("Background Colour of Cancel Button"), DefaultValueAttribute("Black")]
        public string Cancel_Button_BackColour { get { return _Cancel_Button_BackColour; } set { _Cancel_Button_BackColour = value; } }

        private bool _Cancel_Button_Show_Borders = false;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Show Cancel/Close Order Button Border"), DescriptionAttribute("Show Cancel/Close Order Button Border")]
        public bool Cancel_Button_Show_Borders { get { return _Cancel_Button_Show_Borders; } set { _Cancel_Button_Show_Borders = value; } }


        private bool _Pad_Allowed = false;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Allow use of PAD"), DescriptionAttribute("Pad can be used to take orders")]
        public bool Pad_Allowed { get { return _Pad_Allowed; } set { _Pad_Allowed = value; } }

        private OrderTypes _Order_Pad_Default_Order_Type = OrderTypes.DirectSale;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Default order type for OrderPad"), DescriptionAttribute("Pad Default Order Type. Identifies which order type should be instantiated when Pad Button Clicked")]
        public OrderTypes Order_Pad_Default_Order_Type { get { return _Order_Pad_Default_Order_Type; } set { _Order_Pad_Default_Order_Type = value; } }

        private OrientationTypes _OrderPad_Orientation = OrientationTypes.Landscape;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("OrderPad Orientation"), DescriptionAttribute("OrderPad Orientation Landscape or Portrait")]
        public OrientationTypes OrderPad_Orientation { get { return _OrderPad_Orientation; } set { _OrderPad_Orientation = value; } }






        //NOT NECESSARY
        private OrderTypes _Auto_Order_Type = OrderTypes.Unknown;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Default order type for default order creation"), DescriptionAttribute("Default Order Type. Identifies which order type should be instantiated when a Order Created")]
        public OrderTypes Auto_Order_Type { get { return _Auto_Order_Type; } set { _Auto_Order_Type = value; } }

        private bool _Standard_Users_Can_See_Session_Totals = true;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Allow standard users to see session total"), DescriptionAttribute("Can Basic Users See Session Totals from this Terminal")]
        public bool Standard_Users_Can_See_Session_Totals { get { return _Standard_Users_Can_See_Session_Totals; } set { _Standard_Users_Can_See_Session_Totals = value; } }

        private bool _Order_Reloads_Allowed = true;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Allow orders to be reloaded"), DescriptionAttribute("Orders can be reloaded")]
        public bool Order_Reloads_Allowed { get { return _Order_Reloads_Allowed; } set { _Order_Reloads_Allowed = value; } }

        private int _Order_List_Detailed_Orders_Max_Counter = 5;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Number of detailed orders displayed on order list"), DescriptionAttribute("Maximum number of orders will be displayed in detail in order list")]
        public int Order_List_Detailed_Orders_Max_Counter { get { return _Order_List_Detailed_Orders_Max_Counter; } set { _Order_List_Detailed_Orders_Max_Counter = value; } }

        private bool _DeleteSupervisionRequired = false;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Force order deletion for supervisor user"), DescriptionAttribute("Delete Order Item Requires Supervisor Authorisation")]
        public bool Deleting_OrderItem_Requires_Supervision
        {
            get { return _DeleteSupervisionRequired; }
            set { _DeleteSupervisionRequired = value; }
        }

        private bool _LogDeletedOrderItems = false;
        [CategoryAttribute("16.Other Order Settings"), DisplayName("log deleted order item quantities"), DescriptionAttribute("Log deleted order item quantities")]
        public bool Log_Deleted_Order_Items
        {
            get { return _LogDeletedOrderItems; }
            set { _LogDeletedOrderItems = value; }
        }
        #endregion






        #region 17.Customer Display Settings

        //private CustomerDisplayTypes _Customer_Display_Type = CustomerDisplayTypes.NONE;
        //[CategoryAttribute("17.Customer Display Settings"),DisplayName("Customer Display Type if any"), DescriptionAttribute("Type of Manufacturer")]
        //public CustomerDisplayTypes Customer_Display_Type { get { return _Customer_Display_Type; } set { _Customer_Display_Type = value; } }

        //private CustomerDisplayCharacterSetTypes _Customer_Display_Character_Set = CustomerDisplayCharacterSetTypes.UK; //default uk
        //[CategoryAttribute("17.Customer Display Settings"),DisplayName("Customer Display Character Set"), DescriptionAttribute("Character Set")]
        //public CustomerDisplayCharacterSetTypes Customer_Display_Character_Set { get { return _Customer_Display_Character_Set; } set { _Customer_Display_Character_Set = value; } }

        //private SerialPortTypes _Customer_Display_Unit_Connected_To_COM = SerialPortTypes.NONE;
        //[CategoryAttribute("17.Customer Display Settings"),DisplayName("Which COM Port is customer display connected to"), DescriptionAttribute("COM Port to communicate with the customer display exp:COM1, COM2 or COM4 etc")]
        //public SerialPortTypes Customer_Display_Unit_Connected_To_COM { get { return _Customer_Display_Unit_Connected_To_COM; } set { _Customer_Display_Unit_Connected_To_COM = value; } }

        //private int _Customer_Display_Text_Length = 20;
        //[CategoryAttribute("17.Customer Display Settings"),DisplayName("Number of characters on Customer Display"), DescriptionAttribute("Character Length of the Customer Display")]
        //public int Customer_Display_Text_Length { get { return _Customer_Display_Text_Length; } set { _Customer_Display_Text_Length = value; } }



        #endregion

        #region 18.Cash Drawer Settings
        private bool _Cash_Drawer_Void_Open_Allowed = true;
        [CategoryAttribute("18.Cash Drawer Settings"), DisplayName("Allow cash drawer to be openned with VOID button"), DescriptionAttribute("Cash Drawer can be openned directly")]
        public bool Cash_Drawer_Void_Open_Allowed { get { return _Cash_Drawer_Void_Open_Allowed; } set { _Cash_Drawer_Void_Open_Allowed = value; } }

        private CashDrawerTypes _Attached_Cash_Drawer_Type = CashDrawerTypes.None;
        [CategoryAttribute("18.Cash Drawer Settings"), DisplayName("Which type of cash drawer used"), DescriptionAttribute("Attached Cash Drawer Type")]
        public CashDrawerTypes Attached_Cash_Drawer_Type { get { return _Attached_Cash_Drawer_Type; } set { _Attached_Cash_Drawer_Type = value; } }

        private SerialPortTypes _Cash_Drawer_Serial_Port = SerialPortTypes.COM1;
        [CategoryAttribute("18.Cash Drawer Settings"), DisplayName("Which COM Port is cash drawer connected to"), DescriptionAttribute("Cash Drawer Serially Connected to Port exp: COM1, COM4 etc")]
        public SerialPortTypes Cash_Drawer_Serial_Port { get { return _Cash_Drawer_Serial_Port; } set { _Cash_Drawer_Serial_Port = value; } }


        #endregion

        #region 19.Screen Lock / Screen Saver Settings
        private System.Windows.Forms.FormWindowState _Lock_Screen_Window_Format = System.Windows.Forms.FormWindowState.Normal;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Allow lock screen block the entire display"), DescriptionAttribute("Lock screen will cover the entire window")]
        public System.Windows.Forms.FormWindowState Lock_Screen_Window_Format
        {
            get { return _Lock_Screen_Window_Format; }
            set { _Lock_Screen_Window_Format = value; }
        }

        private ScreenLockTypes _Screen_Lock_Method = ScreenLockTypes.None;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Screen locking method"), DescriptionAttribute("How to lock the system when there is no interaction")]
        public ScreenLockTypes Screen_Lock_Method { get { return _Screen_Lock_Method; } set { _Screen_Lock_Method = value; } }

        private int _Seconds_Before_ScreenLock = 30;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Seconds to wait"), DescriptionAttribute("Activates screen saver after ? seconds")]
        public int Seconds_Before_ScreenLock
        {
            get { return _Seconds_Before_ScreenLock; }
            set
            {
                if (value < 3)
                    value = 3;
                _Seconds_Before_ScreenLock = value;
            }
        }

        private string _Screen_Saver_Image_Folder = "";
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Image Folder"), Editor(typeof(FolderNameEditor), typeof(UITypeEditor)), DescriptionAttribute("Image Folder to pickup screen saver images")]
        public string Screen_Saver_Image_Folder { get { return _Screen_Saver_Image_Folder; } set { _Screen_Saver_Image_Folder = value; } }


        private int _Screen_Saver_Image_Spacer = 20;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Extra space between images"), DefaultValueAttribute(20), DescriptionAttribute("Extra space required between images")]
        public int Screen_Saver_Image_Spacer { get { return _Screen_Saver_Image_Spacer; } set { _Screen_Saver_Image_Spacer = value <= 0 || value > 50 ? 20 : value; } }

        private int _Screen_Saver_Maximum_Image_Count = 20;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Maximum number of images"), DefaultValueAttribute(20), DescriptionAttribute("Maximum number of images to pickup from image folder")]
        public int Screen_Saver_Maximum_Image_Count { get { return _Screen_Saver_Maximum_Image_Count; } set { _Screen_Saver_Maximum_Image_Count = value <= 0 || value > 150 ? 20 : value; } }

        private int _Screen_Saver_Maximum_Drawable_Image_Count = 5;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Maximum number of drawable images"), DefaultValueAttribute(5), DescriptionAttribute("Maximum number of images can be drawn at any time on the screen descp attribute")]
        public int Screen_Saver_Maximum_Drawable_Image_Count { get { return _Screen_Saver_Maximum_Drawable_Image_Count; } set { _Screen_Saver_Maximum_Drawable_Image_Count = value <= 0 || value > 100 ? 5 : value; } }


        private int _Screen_Saver_Maximum_Image_Size = 500;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Maximum image size"), DefaultValueAttribute(500), DescriptionAttribute("Maximum size of images in KB to load to screen saver")]
        public int Screen_Saver_Maximum_Image_Size { get { return _Screen_Saver_Maximum_Image_Size; } set { _Screen_Saver_Maximum_Image_Size = value <= 0 || value > 2000 ? 500 : value; } }


        private int _Screen_Saver_Speed_Difference = 10;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Speed Difference"), DefaultValueAttribute(10), DescriptionAttribute("Variable speeds amongs the images between 1 and 20 pixels a second")]
        public int Screen_Saver_Speed_Difference { get { return _Screen_Saver_Speed_Difference; } set { _Screen_Saver_Speed_Difference = value <= 0 || value > 20 ? 1 : value; } }

        private int _Screen_Saver_Left_Step = 3;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Speed towards left"), DefaultValueAttribute(3), DescriptionAttribute("Movement speed towards the left 0 to 3 pixels a second")]
        public int Screen_Saver_Left_Step { get { return _Screen_Saver_Left_Step; } set { _Screen_Saver_Left_Step = value <= 0 || value > 10 ? 0 : value; } }

        private int _Screen_Saver_Right_Step = 3;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Speed towards right"), DefaultValueAttribute(3), DescriptionAttribute("Movement speed towards the right 0 to 10  pixels a second")]
        public int Screen_Saver_Right_Step { get { return _Screen_Saver_Right_Step; } set { _Screen_Saver_Right_Step = value <= 0 || value > 10 ? 0 : value; } }

        private int _Screen_Saver_Timer_Interval = 5000;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Redraw cycle in miliseconds"), DescriptionAttribute("Redraw cycle in miliseconds for timer"), DefaultValueAttribute(50)]
        public int Screen_Saver_Timer_Interval { get { return _Screen_Saver_Timer_Interval; } set { _Screen_Saver_Timer_Interval = value <= 20 || value > 10000 ? 50 : value; } }

        private bool _Screen_Saver_Capture_Mouse_Down_Event = true;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Stop screen saver if mouse clicked"), DescriptionAttribute("Ensures mouse down event captured to activate screen saver"), DefaultValueAttribute(true)]
        public bool Screen_Saver_Capture_Mouse_Down_Event { get { return _Screen_Saver_Capture_Mouse_Down_Event; } set { _Screen_Saver_Capture_Mouse_Down_Event = value; } }

        private bool _Screen_Saver_Capture_Mouse_Move_Event = false;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Stop screen saver if mouse moved"), DescriptionAttribute("Ensures mouse moves captured to activate screen saver"), DefaultValueAttribute(false)]
        public bool Screen_Saver_Capture_Mouse_Move_Event { get { return _Screen_Saver_Capture_Mouse_Move_Event; } set { _Screen_Saver_Capture_Mouse_Move_Event = value; } }

        private bool _Screen_Saver_Show_Pos_Logo = true;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Show Pos Logo as default"), DescriptionAttribute("Shows Pos Logo on Screen Saver"), DefaultValueAttribute(true)]
        public bool Screen_Saver_Show_Pos_Logo { get { return _Screen_Saver_Show_Pos_Logo; } set { _Screen_Saver_Show_Pos_Logo = value; } }

        private bool _Screen_Saver_Debug = false;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Show debug information"), DescriptionAttribute("Show debug information on screen saver"), DefaultValueAttribute(false)]
        public bool Screen_Saver_Debug { get { return _Screen_Saver_Debug; } set { _Screen_Saver_Debug = value; } }

        private ScreenSaverTypes _Screen_Saver_Type = ScreenSaverTypes.None;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Type of screen saver"), DescriptionAttribute("Appication specific screen saver type")]
        public ScreenSaverTypes Screen_Saver_Type { get { return _Screen_Saver_Type; } set { _Screen_Saver_Type = value; } }

        private ScreenSaverColourTypes _Screen_Saver_Color = ScreenSaverColourTypes.BlackBackGroundWhiteBrush;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Color format of the screen saver"), DescriptionAttribute("Colour of the screen saver"), DefaultValueAttribute(ScreenSaverColourTypes.BlackBackGroundWhiteBrush)]
        public ScreenSaverColourTypes Screen_Saver_Color { get { return _Screen_Saver_Color; } set { _Screen_Saver_Color = value; } }

        private int _Screen_Saver_Large_Font_Size = 70;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Size of large font on screen saver"), DescriptionAttribute("Size of large font on screen saver (40 to 150)"), DefaultValueAttribute(70)]
        public int Screen_Saver_Large_Font_Size { get { return _Screen_Saver_Large_Font_Size; } set { _Screen_Saver_Large_Font_Size = value < 30 || value > 150 ? 70 : value; } }

        private int _Screen_Saver_Small_Font_Size = 50;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Size of small font on screen saver"), DescriptionAttribute("Size of small font on screen saver (20 to 90)"), DefaultValueAttribute(50)]
        public int Screen_Saver_Small_Font_Size { get { return _Screen_Saver_Small_Font_Size; } set { _Screen_Saver_Small_Font_Size = value < 10 || value > 90 ? 90 : value; } }

        private AlignmentTypes _Screen_Saver_Image_Alignment = AlignmentTypes.Center;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Image alignment in given space"), DescriptionAttribute("Image alignment in given space"), DefaultValueAttribute(AlignmentTypes.Center)]
        public AlignmentTypes Screen_Saver_Image_Alignment { get { return _Screen_Saver_Image_Alignment; } set { _Screen_Saver_Image_Alignment = value; } }

        private int _Screen_Saver_Image_Indent = 0;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver left/right indentation of the image"), DescriptionAttribute("Regardless alignment minus value forces left plus value forces right indentation to the image"), DefaultValueAttribute(0)]
        public int Screen_Saver_Image_Indent { get { return _Screen_Saver_Image_Indent; } set { _Screen_Saver_Image_Indent = value; } }

        private int _Screen_Saver_Image_Top_Indent = -1;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver top indentation of the image"), DescriptionAttribute("Single screen saver top indentation of the image (set to -1 for auto indentation) (-1 to 700)"), DefaultValueAttribute(-1)]
        public int Screen_Saver_Image_Top_Indent { get { return _Screen_Saver_Image_Top_Indent; } set { _Screen_Saver_Image_Top_Indent = value < -1 || value > 700 ? -1 : value; } }

        private int _Screen_Saver_Text_Left_Indent = 50;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver left indentation of the text"), DescriptionAttribute("Single screen saver left indentation of the text (set to -1 for auto indentation)"), DefaultValueAttribute(50)]
        public int Screen_Saver_Text_Left_Indent { get { return _Screen_Saver_Text_Left_Indent; } set { _Screen_Saver_Text_Left_Indent = value; } }

        private int _Screen_Saver_Text_Top_Indent = -1;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver top indentation of the text"), DescriptionAttribute("Single screen saver top indentation of the text (set to -1 for auto indentation) (-1 to 1200)"), DefaultValueAttribute(-1)]
        public int Screen_Saver_Text_Top_Indent { get { return _Screen_Saver_Text_Top_Indent; } set { _Screen_Saver_Text_Top_Indent = value < -1 || value > 1200 ? -1 : value; } }

        private int _Screen_Saver_Text_Line_Space = 25;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver line space between text lines"), DescriptionAttribute("Single screen saver line space between text lines (10 to 100)"), DefaultValueAttribute(25)]
        public int Screen_Saver_Text_Line_Space { get { return _Screen_Saver_Text_Line_Space; } set { _Screen_Saver_Text_Line_Space = value < 10 || value > 100 ? 25 : value; } }


        #endregion


        //


        #region 20.Kitchen Display Settings
        private string _Default_Distribution_Terminal_Type_List = "";
        [Browsable(false)]
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Which distribution type to display on primary kitchen screen"), DescriptionAttribute("Select do display which preparation terminal")]
        public string Default_Distribution_Terminal_Type_List { get { return _Default_Distribution_Terminal_Type_List; } set { _Default_Distribution_Terminal_Type_List = value; } }

        private string _Secondary_Distribution_Terminal_Type_List = "";
        [Browsable(false)]
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Which distribution type to display on secondary kitchen screen"), DescriptionAttribute("Select do display which preparation terminal on secondary window")]
        public string Secondary_Distribution_Terminal_Type_List { get { return _Secondary_Distribution_Terminal_Type_List; } set { _Secondary_Distribution_Terminal_Type_List = value; } }

        private int _Kitchen_Prep_Good_Time = 20;
        [Browsable(false)]
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allowed good time for kitchen in seconds"), DescriptionAttribute("Will display Kitchen/Bar order preperation good time (in seconds")]
        public int Kitchen_Prep_Good_Time { get { return _Kitchen_Prep_Good_Time; } set { _Kitchen_Prep_Good_Time = value; } }

        private int _Kitchen_Prep_Bad_Time = 40;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allowed bad time for kitchen in seconds"), DescriptionAttribute("Will display Kitchen/Bar order preperation bad time (in seconds), will start flashing after time elapsed")]
        public int Kitchen_Prep_Bad_Time { get { return _Kitchen_Prep_Bad_Time; } set { _Kitchen_Prep_Bad_Time = value; } }

        private bool _Kitchen_Show_Progress_Bar = false;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Show progress bar on kitchen screen during order preparation"), DescriptionAttribute("Will display Kitchen/Bar order preperation progress bar")]
        public bool Kitchen_Show_Progress_Bar { get { return _Kitchen_Show_Progress_Bar; } set { _Kitchen_Show_Progress_Bar = value; } }

        private bool _Show_Clock_in_Kitchen = false;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Display clock on kitchen screen"), DescriptionAttribute("Show Clock in Kitchen Displays")]
        public bool Show_Clock_in_Kitchen { get { return _Show_Clock_in_Kitchen; } set { _Show_Clock_in_Kitchen = value; } }

        private int _Kitchen_Max_Completed_Order_Count = 10;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Delete completed orders after how many"), DescriptionAttribute("Will only display x number of completed orders in display terminal")]
        public int Kitchen_Max_Completed_Order_Count { get { return _Kitchen_Max_Completed_Order_Count; } set { _Kitchen_Max_Completed_Order_Count = value; } }

        private int _Kitchen_Small_Font_Size = 12;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen screen small font size"), DescriptionAttribute("Kitchen small font (irrelevant item's font) size.")]
        public int Kitchen_Small_Font_Size
        {
            get { return _Kitchen_Small_Font_Size; }
            set
            {
                if (value < 10)
                    value = 10;
                if (value > 16)
                    value = 16;
                _Kitchen_Small_Font_Size = value;
            }
        }

        private int _Kitchen_Large_Font_Size = 12;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen screen big font size"), DescriptionAttribute("Kitchen large font (relevant item's font) size.")]
        public int Kitchen_Large_Font_Size
        {
            get { return _Kitchen_Large_Font_Size; }
            set
            {
                if (value < 10)
                    value = 10;
                if (value > 16)
                    value = 16;
                _Kitchen_Large_Font_Size = value;
            }
        }

        private int _Kitchen_Detail_Font_Size = 10;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen screen detailed font size"), DescriptionAttribute("Kitchen detail font (detailed description text) size.")]
        public int Kitchen_Detail_Font_Size
        {
            get { return _Kitchen_Detail_Font_Size; }
            set
            {
                if (value < 8)
                    value = 8;
                if (value > 13)
                    value = 13;
                _Kitchen_Detail_Font_Size = value;
            }
        }

        private float _KitchenPrintFontSize = 10;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen printer font size"), DescriptionAttribute("Kitchen Print Font Size, 7 to 12"), DefaultValueAttribute(10)]
        public float KitchenPrintFontSize { get { return _KitchenPrintFontSize; } set { _KitchenPrintFontSize = value < 7 || value > 12 ? 10 : value; } }

        private float _KitchenPrintDetailFontSize = 8;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen printer detailed font size"), DescriptionAttribute("Kitchen Print Font Size, 7 to 12"), DefaultValueAttribute(8)]
        public float KitchenPrintDetailFontSize { get { return _KitchenPrintDetailFontSize; } set { _KitchenPrintDetailFontSize = value < 7 || value > 9 ? 8 : value; } }



        /// <summary>
        ///font size = 7  so max = 45
        ///font size = 8  so max = 40
        ///font size = 9  so max = 35
        ///font size = 10  so max = 30
        ///font size = 11  so max = 25
        ///font size = 12  so max = 20
        /// </summary>
        /// <param name="fontsize"></param>
        /// <returns></returns>
        public int GetFontMaximumCharacter(int fontsize)
        {
            switch (fontsize)
            {
                case 7:
                    return 45;
                case 8:
                    return 40;
                case 9:
                    return 35;
                case 10:
                    return 30;
                case 11:
                    return 25;
                case 12:
                    return 20;
                default:
                    return 30;
            }
        }
        public int GetFontMaximumCharacter(float fontsize)
        {
            return GetFontMaximumCharacter((int)fontsize);
        }

        private bool _Kitchen_Can_Print = false;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allow kitchen to print orders from this terminal"), DescriptionAttribute("Kitchen can print orders locally")]
        public bool Kitchen_Can_Print { get { return _Kitchen_Can_Print; } set { _Kitchen_Can_Print = value; } }

        private KitchenDisplayTypes _Kitchen_Monitor_Auto_Display_Type = KitchenDisplayTypes.None;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("How many distribution type to display on kitchen screen"), DescriptionAttribute("Automatically Jumps to Display Screen 1,2,3 or none")]
        public KitchenDisplayTypes Kitchen_Monitor_Auto_Display_Type { get { return _Kitchen_Monitor_Auto_Display_Type; } set { _Kitchen_Monitor_Auto_Display_Type = value; } }

        private bool _Display_Kitchen_Orders_As_Reminders = true;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Display kitchen order's remaining quantity"), DescriptionAttribute("Displays kitchen order's remaining quantity"), DefaultValueAttribute(true)]
        public bool Display_Kitchen_Orders_As_Reminders { get { return _Display_Kitchen_Orders_As_Reminders; } set { _Display_Kitchen_Orders_As_Reminders = value; } }

        private bool _Display_Kitchen_Chef_on_Display = true;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Display kitchen chef on display screen"), DescriptionAttribute("Displays kitchen chef button on display screen"), DefaultValueAttribute(true)]
        public bool Display_Kitchen_Chef_on_Display { get { return _Display_Kitchen_Chef_on_Display; } set { _Display_Kitchen_Chef_on_Display = value; } }


        private bool _Display_Kitchen_FullScreen_on_Display = true;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allow Kitchen OrderItems to be FullScreen"), DescriptionAttribute("Allow kitchen order items to be enlarged for better view"), DefaultValueAttribute(true)]
        public bool Display_Kitchen_FullScreen_on_Display { get { return _Display_Kitchen_FullScreen_on_Display; } set { _Display_Kitchen_FullScreen_on_Display = value; } }

        private float _Display_Kitchen_FullScreen_Font_Size = 30;
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen OrderItem FullScreen Font Size"), DescriptionAttribute("Minimum and Maximum Font Size for kitchen orderitem during FullScreen Mode, between 16 to 46"), DefaultValueAttribute(30)]
        public float Display_Kitchen_FullScreen_Font_Size { get { return _Display_Kitchen_FullScreen_Font_Size; } set { _Display_Kitchen_FullScreen_Font_Size = value < 16 || value > 46 ? 30 : value; } }


        #endregion

        #region 21.Prep Window Settings
        private bool _Prep_Can_Hold = true;
        [CategoryAttribute("21.Prep Window Settings"), DisplayName("Allow Prep window to hold orders"), DescriptionAttribute("Prep Window Can Hold without payment")]
        public bool Prep_Can_Hold { get { return _Prep_Can_Hold; } set { _Prep_Can_Hold = value; } }

        private bool _Prep_Can_Hold_And_Cash = false;
        [CategoryAttribute("21.Prep Window Settings"), DisplayName("Allow Prep window to hold and cash orders"), DescriptionAttribute("Prep Window Can Hold and Cashout")]
        public bool Prep_Can_Hold_And_Cash { get { return _Prep_Can_Hold_And_Cash; } set { _Prep_Can_Hold_And_Cash = value; } }

        private bool _Prep_Can_Hold_Cash_And_Print = false;
        [CategoryAttribute("21.Prep Window Settings"), DisplayName("Allow Prep window to hold, cash and print orders"), DescriptionAttribute("Prep Window Can Hold, Cashout and Print Receipt")]
        public bool Prep_Can_Hold_Cash_And_Print { get { return _Prep_Can_Hold_Cash_And_Print; } set { _Prep_Can_Hold_Cash_And_Print = value; } }
        #endregion

        #region 23.Report Settings
        private bool _This_Terminal_Can_Produce_Reports = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Allow this terminal to produce reports"), DescriptionAttribute("Allow This Terminal to print reports.")]
        public bool This_Terminal_Can_Produce_Reports { get { return _This_Terminal_Can_Produce_Reports; } set { _This_Terminal_Can_Produce_Reports = value; } }

        private bool _Standard_Users_Can_Produce_Reports = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Allow standard users to produce reports"), DescriptionAttribute("Can Basic Users Print Reports from this Terminal")]
        public bool Standard_Users_Can_Produce_Reports { get { return _Standard_Users_Can_Produce_Reports; } set { _Standard_Users_Can_Produce_Reports = value; } }

        private float _ReportFontSize = 7;
        [CategoryAttribute("23.Report Settings"), DisplayName("Font size for reports"), DescriptionAttribute("Report Font Size, 7 or 8"), DefaultValueAttribute(7), ReadOnly(true)]
        public float ReportFontSize { get { return _ReportFontSize; } } // set { _ReportFontSize = value < 7 || value > 8 ? 7 : value; } }

        private float _ReportButtonFontSize = 10;
        [CategoryAttribute("23.Report Settings"), DisplayName("Font size for report button"), DescriptionAttribute("Report Button Font Size 10 or above"), DefaultValueAttribute(10)]
        public float ReportButtonFontSize { get { return _ReportButtonFontSize; } set { _ReportButtonFontSize = value < 10 ? 10 : value; } }

        private string _ReportFontName = "Courier New";
        [CategoryAttribute("23.Report Settings"), DisplayName("Font name for reports"), DescriptionAttribute("Report Font Name (Mono Space) like 'Courier New'"), DefaultValueAttribute("Courier New"), ReadOnly(true)]
        public string ReportFontName { get { return _ReportFontName; } set { _ReportFontName = value; } }

        private string _ReportLogo = "printlogo.png";
        [CategoryAttribute("23.Report Settings"), DisplayName("Name of report logo/image file"), Editor(typeof(FilteredImageFileEditor), typeof(UITypeEditor)), DescriptionAttribute("Report Image Filename with extension"), DefaultValueAttribute("printlogo.png")]
        public string ReportLogo { get { return _ReportLogo; } set { _ReportLogo = value; } }

        private bool _Preserve_Previous_Report = false;
        [CategoryAttribute("23.Report Settings"), DisplayName("Allow managers to re-print previous reports"), DescriptionAttribute("It allows managers to re-print previous reports")]
        public bool Preserve_Previous_Report { get { return _Preserve_Previous_Report; } set { _Preserve_Previous_Report = value; } }


        private bool _Feed_Space_Cut = false;
        [CategoryAttribute("23.Report Settings"), DisplayName("Force printer to extra cut on reports"), DescriptionAttribute("True: Extra paper feed/cut applied to reports"), DefaultValueAttribute(false)]
        public bool Feed_Space_Cut { get { return _Feed_Space_Cut; } set { _Feed_Space_Cut = value; } }

        private bool _No_Hold_Orders_Allowed_During_Report = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Do not allow held orders during report production"), DescriptionAttribute("True: All Hold Orders must be cashed out before report produced"), DefaultValueAttribute(true)]
        public bool No_Hold_Orders_Allowed_During_Report { get { return _No_Hold_Orders_Allowed_During_Report; } set { _No_Hold_Orders_Allowed_During_Report = value; } }

        private bool _No_Table_Orders_Allowed_During_Report = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Do not allow tables order during report production"), DescriptionAttribute("True: All Table Orders must be cashed out before report produced"), DefaultValueAttribute(true)]
        public bool No_Table_Orders_Allowed_During_Report { get { return _No_Table_Orders_Allowed_During_Report; } set { _No_Table_Orders_Allowed_During_Report = value; } }

        private bool _ShowTaxOnReceipts = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Show tax details on receipts"), DescriptionAttribute("Show Tax Details on Receipts")]
        public bool ShowTaxOnReceipts { get { return _ShowTaxOnReceipts; } set { _ShowTaxOnReceipts = value; } }

        private bool _Show_Tax_Percent_in_everyline = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Show tax percentages on every line"), DescriptionAttribute("Show Tax Details on Receipts in every line")]
        public bool Show_Tax_Percent_in_everyline { get { return _Show_Tax_Percent_in_everyline; } set { _Show_Tax_Percent_in_everyline = value; } }


        private bool _Receipts_Print_Tax_Total = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Print Tax Totals in Receipts"), DescriptionAttribute("True: Receipts print total of tax amount"), DefaultValueAttribute(true)]
        public bool Receipts_Print_Tax_Total { get { return _Receipts_Print_Tax_Total; } set { _Receipts_Print_Tax_Total = value; } }

        private bool _Receipts_Print_Ex_Tax_Total = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Print Excluding Tax Totals in Receipts"), DescriptionAttribute("True: Receipts print excluding tax total amount"), DefaultValueAttribute(true)]
        public bool Receipts_Print_Ex_Tax_Total { get { return _Receipts_Print_Ex_Tax_Total; } set { _Receipts_Print_Ex_Tax_Total = value; } }

        private bool _Order_Screen_Display_Service_Charge = true;
        [CategoryAttribute("23.Report Settings"), DisplayName("Display Service Charge On Order Screen"), DescriptionAttribute("Display Service Charge On Order Screen"), DefaultValueAttribute(true)]
        public bool Order_Screen_Display_Service_Charge { get { return _Order_Screen_Display_Service_Charge; } set { _Order_Screen_Display_Service_Charge = value; } }

        #endregion

        #region 24.X Report Settings
        private int _Maximum_XReport_Count = 1;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Maximum number of X Report to print"), DescriptionAttribute("Maximum number of X Reports can be taken before the final Z Report can be taken"), DefaultValueAttribute(1)]
        public int Maximum_XReport_Count { get { return _Maximum_XReport_Count; } set { _Maximum_XReport_Count = value < 0 || value > 3 ? 1 : value; } }

        private bool _X_Cash_Drawer_Count_Required = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Force cash drawer to be counted before printing the X Report"), DescriptionAttribute("True: Cash Drawer must be counted before report is printed"), DefaultValueAttribute(false)]
        public bool X_Cash_Drawer_Count_Required { get { return _X_Cash_Drawer_Count_Required; } set { _X_Cash_Drawer_Count_Required = value; } }

        private bool _X_Pin_Machine_Report_Required = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Remind Pin Machine Report to be taken before printing the X Report"), DescriptionAttribute("True: Before X Report reminder will be displayed"), DefaultValueAttribute(false)]
        public bool X_Pin_Machine_Report_Required { get { return _X_Pin_Machine_Report_Required; } set { _X_Pin_Machine_Report_Required = value; } }


        private bool _X_Print_Category_Report = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Print category report in X Report"), DescriptionAttribute("True: Category report is printed"), DefaultValueAttribute(false)]
        public bool X_Print_Category_Report { get { return _X_Print_Category_Report; } set { _X_Print_Category_Report = value; } }

        private bool _X_Print_Category_Detailed_Report = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Print detailed category report in X Report"), DescriptionAttribute("True: Category detailed report is printed"), DefaultValueAttribute(false)]
        public bool X_Print_Category_Detailed_Report { get { return _X_Print_Category_Detailed_Report; } set { _X_Print_Category_Detailed_Report = value; } }


        // Cash, Card, Online

        private bool _X_Print_Cash_Order_List = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Print cash paid order list report in X Report"), DescriptionAttribute("True: Cash Paid Order List report is printed"), DefaultValueAttribute(false)]
        public bool X_Print_Cash_Order_List { get { return _X_Print_Cash_Order_List; } set { _X_Print_Cash_Order_List = value; } }

        private bool _X_Print_Card_Order_List = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Print card paid order list report in X Report"), DescriptionAttribute("True: Card Paid Order List report is printed"), DefaultValueAttribute(false)]
        public bool X_Print_Card_Order_List { get { return _X_Print_Card_Order_List; } set { _X_Print_Card_Order_List = value; } }


        private bool _X_Print_Online_Order_List = false;
        [CategoryAttribute("24.X Report Settings"), DisplayName("Print online paid order list report in X Report"), DescriptionAttribute("True: Online Paid Order List report is printed"), DefaultValueAttribute(false)]
        public bool X_Print_Online_Order_List { get { return _X_Print_Online_Order_List; } set { _X_Print_Online_Order_List = value; } }


        #endregion

        #region 25.Z Report Settings

        private bool _Z_Cash_Drawer_Count_Required = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Force cash drawer to be counted before printing the Z Report"), DescriptionAttribute("True: Cash Drawer must be counted before report is printed"), DefaultValueAttribute(false)]
        public bool Z_Cash_Drawer_Count_Required { get { return _Z_Cash_Drawer_Count_Required; } set { _Z_Cash_Drawer_Count_Required = value; } }

        private bool _Z_Pin_Machine_Report_Required = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Remind Pin Machine Report to be taken before printing the Z Report"), DescriptionAttribute("True: Before Z Report reminder will be displayed"), DefaultValueAttribute(false)]
        public bool Z_Pin_Machine_Report_Required { get { return _Z_Pin_Machine_Report_Required; } set { _Z_Pin_Machine_Report_Required = value; } }


        private bool _Z_Print_Category_Report = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print category report in Z Report"), DescriptionAttribute("True: Category report is printed"), DefaultValueAttribute(false)]
        public bool Z_Print_Category_Report { get { return _Z_Print_Category_Report; } set { _Z_Print_Category_Report = value; } }

        private bool _Z_Print_Category_Detailed_Report = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print detailed category report in Z Report"), DescriptionAttribute("True: Category detailed report is printed"), DefaultValueAttribute(false)]
        public bool Z_Print_Category_Detailed_Report { get { return _Z_Print_Category_Detailed_Report; } set { _Z_Print_Category_Detailed_Report = value; } }

        // Cash, Card, Online

        private bool _Z_Print_Cash_Order_List = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print cash paid order list report in Z Report"), DescriptionAttribute("True: Cash Paid Order List report is printed"), DefaultValueAttribute(false)]
        public bool Z_Print_Cash_Order_List { get { return _Z_Print_Cash_Order_List; } set { _Z_Print_Cash_Order_List = value; } }

        private bool _Z_Print_Card_Order_List = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print card paid order list report in Z Report"), DescriptionAttribute("True: Card Paid Order List report is printed"), DefaultValueAttribute(false)]
        public bool Z_Print_Card_Order_List { get { return _Z_Print_Card_Order_List; } set { _Z_Print_Card_Order_List = value; } }

        private bool _Z_Print_Online_Order_List = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print online paid order list report in Z Report"), DescriptionAttribute("True: Online Paid Order List report is printed"), DefaultValueAttribute(false)]
        public bool Z_Print_Online_Order_List { get { return _Z_Print_Online_Order_List; } set { _Z_Print_Online_Order_List = value; } }

        private bool _Z_Archive_Always = false;
        [CategoryAttribute("25.Z Report Settings"), DisplayName("Archive Z Report Always"), DescriptionAttribute("True: Archives Z Report anytime report is printed"), DefaultValueAttribute(false)]
        public bool Z_Archive_Always { get { return _Z_Archive_Always; } set { _Z_Archive_Always = value; } }

        #endregion

        #region 26.Stock Settings

        private bool _Record_Stock_Usage = false;
        [CategoryAttribute("26.Stock Settings"), DisplayName("Record details for use of stock items"), DescriptionAttribute("True: Stock Usage data will be recorded in the system"), DefaultValueAttribute(false)]
        public bool Record_Stock_Usage { get { return _Record_Stock_Usage; } set { _Record_Stock_Usage = value; } }

        private bool _Print_Stock_Usage_Report = false;
        [CategoryAttribute("26.Stock Settings"), DisplayName("Print stock usage report"), DescriptionAttribute("True:  Print Stock Usage Report"), DefaultValueAttribute(false)]
        public bool Print_Stock_Usage_Report { get { return _Print_Stock_Usage_Report; } set { _Print_Stock_Usage_Report = value; } }

        private bool _Email_Stock_Usage_Report = false;
        [CategoryAttribute("26.Stock Settings"), DisplayName("Email stock usage report"), DescriptionAttribute("True:  Email Stock Usage Report"), DefaultValueAttribute(false)]
        public bool Email_Stock_Usage_Report { get { return _Email_Stock_Usage_Report; } set { _Email_Stock_Usage_Report = value; } }

        private bool _Delete_Stock_Usage = false;
        [CategoryAttribute("26.Stock Settings"), DisplayName("Delete stock usage"), DescriptionAttribute("True:  Delete the Stock Usage"), DefaultValueAttribute(false)]
        public bool Delete_Stock_Usage { get { return _Delete_Stock_Usage; } set { _Delete_Stock_Usage = value; } }

        #endregion

        #region 27.Bonus Scheme Settings

        private bool _Display_Session_Bonus = false;
        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Session Bonus"), DescriptionAttribute("Displays Session Bonus"), DefaultValueAttribute(false)]
        public bool Display_Session_Bonus { get { return _Display_Session_Bonus; } set { _Display_Session_Bonus = value; } }

        private bool _Display_Session_Total_On_Bonus_Bar = false;
        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Session Total on Bonus Bar"), DescriptionAttribute("Displays Session Total on Bonus Bar"), DefaultValueAttribute(false)]
        public bool Display_Session_Total_On_Bonus_Bar { get { return _Display_Session_Total_On_Bonus_Bar; } set { _Display_Session_Total_On_Bonus_Bar = value; } }

        private bool _Display_Progress_Bar_On_Bonus_Bar = false;
        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Progress Bar on Bonus Bar"), DescriptionAttribute("Displays Progress Bar on Bonus Bar"), DefaultValueAttribute(false)]
        public bool Display_Progress_Bar_On_Bonus_Bar { get { return _Display_Progress_Bar_On_Bonus_Bar; } set { _Display_Progress_Bar_On_Bonus_Bar = value; } }

        private bool _Display_Progress_On_Bonus_Bar = false;
        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Progress on Bonus Bar"), DescriptionAttribute("Displays Progress on Bonus Bar"), DefaultValueAttribute(false)]
        public bool Display_Progress_On_Bonus_Bar { get { return _Display_Progress_On_Bonus_Bar; } set { _Display_Progress_On_Bonus_Bar = value; } }

        private bool _Display_Remaining_Balance_On_Bonus_Bar = false;
        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Remaining Balance on Bonus Bar"), DescriptionAttribute("Display Remaining Balance on Bonus Bar"), DefaultValueAttribute(false)]
        public bool Display_Remaining_Balance_On_Bonus_Bar { get { return _Display_Remaining_Balance_On_Bonus_Bar; } set { _Display_Remaining_Balance_On_Bonus_Bar = value; } }

        #endregion

        #region 28.Functional Settings

        private bool _Force_Receipt_Printer_To_Cut = false;
        [CategoryAttribute("28.Functional Settings"), DisplayName("Force receipt printer to cut the receipt after print"), DescriptionAttribute("If printer doesn't cut normally")]
        public bool Force_Receipt_Printer_To_Cut { get { return _Force_Receipt_Printer_To_Cut; } set { _Force_Receipt_Printer_To_Cut = value; } }

        private bool _Entity_Buttons_Scrollable = false;
        [CategoryAttribute("28.Functional Settings"), DisplayName("Allow entity buttons to be scrolled"), DescriptionAttribute("True: ScrollBar available for Entity Buttons"), DefaultValueAttribute(false)]
        public bool Entity_Buttons_Scrollable { get { return _Entity_Buttons_Scrollable; } set { _Entity_Buttons_Scrollable = value; } }


        private bool _DebugMode = false;
        [CategoryAttribute("28.Functional Settings"), DisplayName("System in debug mode now"), DescriptionAttribute("Database Connection Debug Mode")]
        public bool DebugMode { get { return _DebugMode; } set { _DebugMode = value; } }

        #endregion

        #region 29.User Interface Settings



        private bool _Payments_Can_Be_Made_By_Cash = true;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow cash payment"), DescriptionAttribute("Is Cash Payment Button Visible")]
        public bool Payments_Can_Be_Made_By_Cash { get { return _Payments_Can_Be_Made_By_Cash; } set { _Payments_Can_Be_Made_By_Cash = value; } }

        private bool _Payments_Can_Be_Made_By_Cash_And_Print = true;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow cash payment and print"), DescriptionAttribute("Is Cash Payment and Print Button Visible")]
        public bool Payments_Can_Be_Made_By_Cash_And_Print { get { return _Payments_Can_Be_Made_By_Cash_And_Print; } set { _Payments_Can_Be_Made_By_Cash_And_Print = value; } }


        private bool _Payments_Can_Be_Made_By_Card = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow card payment"), DescriptionAttribute("Is Card Payment Button Visible")]
        public bool Payments_Can_Be_Made_By_Card { get { return _Payments_Can_Be_Made_By_Card; } set { _Payments_Can_Be_Made_By_Card = value; } }

        private bool _Payments_Can_Be_Made_By_Card_And_Print = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow card and print payment"), DescriptionAttribute("Is Card and Print Payment Button Visible")]
        public bool Payments_Can_Be_Made_By_Card_And_Print { get { return _Payments_Can_Be_Made_By_Card_And_Print; } set { _Payments_Can_Be_Made_By_Card_And_Print = value; } }




        private bool _Payments_Can_Be_Made_Online = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow online payment"), DescriptionAttribute("Is Online Payment Button Visible")]
        public bool Payments_Can_Be_Made_Online { get { return _Payments_Can_Be_Made_Online; } set { _Payments_Can_Be_Made_Online = value; } }

        private bool _Payments_Can_Be_Made_Online_And_Print = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow online and print payment"), DescriptionAttribute("Is Online and Print Payment Button Visible")]
        public bool Payments_Can_Be_Made_Online_And_Print { get { return _Payments_Can_Be_Made_Online_And_Print; } set { _Payments_Can_Be_Made_Online_And_Print = value; } }



        private int _DisplayWidth = 315;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("What is order display screen width"), DescriptionAttribute("Order Display Screen Width, Default: 314")]
        public int DisplayWidth { get { return _DisplayWidth; } set { _DisplayWidth = value < 315 ? 315 : value; } }

        private OrderDisplayHeightTypes _Order_Item_Display_Height = OrderDisplayHeightTypes.Narrow;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Order item display height"), DescriptionAttribute("Order Item Display Height on Order Screen")]
        public OrderDisplayHeightTypes Order_Item_Display_Height
        {
            get { return _Order_Item_Display_Height; }
            set { _Order_Item_Display_Height = value; }
        }

        private int _SplitDisplayHeight = 240;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("What is order split display height"), DescriptionAttribute("Split Display Screen Height, Default:200")]
        public int SplitDisplayHeight { get { return _SplitDisplayHeight; } set { _SplitDisplayHeight = value < 200 ? 200 : value; } }

        private bool _Sub_Total_Panel_Visible = true;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow SubTotal panel to be used"), DescriptionAttribute("Is Sub Total Payment Button Visible")]
        public bool Sub_Total_Panel_Visible { get { return _Sub_Total_Panel_Visible; } set { _Sub_Total_Panel_Visible = value; } }

        private bool _Print_Invoice_Button_Visible = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow additional receipt print before cashout"), DescriptionAttribute("Is Print Invoice Button Visible")]
        public bool Print_Invoice_Button_Visible { get { return _Print_Invoice_Button_Visible; } set { _Print_Invoice_Button_Visible = value; } }

        private bool _Drawer_Calculator_Visible = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow small change calculator screen"), DescriptionAttribute("Is Cash Drawer Money Calculator Button Visible")]
        public bool Drawer_Calculator_Visible { get { return _Drawer_Calculator_Visible; } set { _Drawer_Calculator_Visible = value; } }

        private bool _Display_Session_Total_On_Menu = false;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Display Session Total On Menu"), DescriptionAttribute("Displays Session Total On Menu"), DefaultValueAttribute(false)]
        public bool Display_Session_Total_On_Menu { get { return _Display_Session_Total_On_Menu; } set { _Display_Session_Total_On_Menu = value; } }

        private bool _Display_Reklam = true;
        [CategoryAttribute("29.User Interface Settings"), DisplayName("Display advertisement"), DescriptionAttribute("Displays advertisements"), DefaultValueAttribute(true)]
        public bool Display_Reklam { get { return _Display_Reklam; } set { _Display_Reklam = value; } }

        #endregion

        #region 30.User Interface Money Panel Settings
        private int _MoneyActionPanelHeight = 325;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Money Action Panel Height"), DescriptionAttribute("Change the Hold Button Height, Default:98")]
        public int MoneyActionPanelHeight
        {
            get { return _MoneyActionPanelHeight; }
            set
            {
                _MoneyActionPanelHeight = value > 500 ? 500 : value;
                _MoneyActionPanelHeight = value < 100 ? 100 : value;
            }
        }



        private int _HoldButtonItemsHeight = 98;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Individual Hold Button Height"), DescriptionAttribute("Change the Hold Button Height, Default:98")]
        public int HoldButtonItemsHeight { get { return _HoldButtonItemsHeight; } set { _HoldButtonItemsHeight = value > 100 ? 98 : value; } }


        //FIRST COLUMN

        private int _DoneButtonRow = 0;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Done Button Row Number"), DescriptionAttribute("Done Button Horizontal Row, Default:0, Max:7")]
        public int DoneButtonRow { get { return _DoneButtonRow; } set { _DoneButtonRow = value > 11 ? 11 : value; } }

        private int _DoneButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Done Button Vertical RowSpan"), DescriptionAttribute("Done Button Vertical Row Span, Default:2, Max:7")]
        public int DoneButtonRowSpan { get { return _DoneButtonRowSpan; } set { _DoneButtonRowSpan = value > 11 ? 11 : value; } }

        private int _CashDrawerButtonRow = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Drawer Button Row Number"), DescriptionAttribute("Cash Drawer Button Horizontal Row, Default:2, Max:7")]
        public int CashDrawerButtonRow { get { return _CashDrawerButtonRow; } set { _CashDrawerButtonRow = value > 11 ? 11 : value; } }

        private int _CashDrawerButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Drawer Button Vertical RowSpan"), DescriptionAttribute("Cash Drawer Button Vertical Row Span, Default:2, Max:7")]
        public int CashDrawerButtonRowSpan { get { return _CashDrawerButtonRowSpan; } set { _CashDrawerButtonRowSpan = value > 11 ? 11 : value; } }


        private int _PrintButtonRow = 6;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Print Button Row Number"), DescriptionAttribute("Print Button Horizontal Row, Default:6, Max:7")]
        public int PrintButtonRow { get { return _PrintButtonRow; } set { _PrintButtonRow = value > 11 ? 11 : value; } }

        private int _PrintButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Print Button Vertical RowSpan"), DescriptionAttribute("Print Button Vertical Row Span, Default:2, Max:7")]
        public int PrintButtonRowSpan { get { return _PrintButtonRowSpan; } set { _PrintButtonRowSpan = value > 11 ? 11 : value; } }

        //SECOND COLUMN

        private int _HoldOrderButtonRow = 0;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold Order Button Row Number"), DescriptionAttribute("Hold Order Button Horizontal Row, Default:0, Max:7")]
        public int HoldOrderButtonRow { get { return _HoldOrderButtonRow; } set { _HoldOrderButtonRow = value > 11 ? 11 : value; } }

        private int _HoldOrderButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold Order Button Vertical RowSpan"), DescriptionAttribute("Hold Order Button Vertical Row Span, Default:4, Max:7")]
        public int HoldOrderButtonRowSpan { get { return _HoldOrderButtonRowSpan; } set { _HoldOrderButtonRowSpan = value > 11 ? 11 : value; } }




        private int _CashButtonColumn = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Column Number"), DescriptionAttribute("Cash Button Vertical Column, Default:1, Max:2")]
        public int CashButtonColumn { get { return _CashButtonColumn; } set { _CashButtonColumn = value > 2 ? 2 : value; } }

        private int _CashButtonColumnSpan = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Horizontal Column Span"), DescriptionAttribute("Cash Button Horizontal ColumnSpan, Default:1, Max:2")]
        public int CashButtonColumnSpan { get { return _CashButtonColumnSpan; } set { _CashButtonColumnSpan = value > 2 ? 2 : value; } }

        private int _CashButtonRow = 4;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Row Number"), DescriptionAttribute("Cash Button Horizontal Row, Default:4, Max:7")]
        public int CashButtonRow { get { return _CashButtonRow; } set { _CashButtonRow = value > 11 ? 11 : value; } }

        private int _CashButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Vertical RowSpan"), DescriptionAttribute("Cash Button Vertical Row Span, Default:2, Max:7")]
        public int CashButtonRowSpan { get { return _CashButtonRowSpan; } set { _CashButtonRowSpan = value > 11 ? 11 : value; } }



        private int _CardButtonColumn = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Column Number"), DescriptionAttribute("Card Button Vertical Column, Default:1, Max:2")]
        public int CardButtonColumn { get { return _CardButtonColumn; } set { _CardButtonColumn = value > 2 ? 2 : value; } }

        private int _CardButtonColumnSpan = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Horizontal Column Span"), DescriptionAttribute("Card Button Horizontal Column Span, Default:1, Max:2")]
        public int CardButtonColumnSpan { get { return _CardButtonColumnSpan; } set { _CardButtonColumnSpan = value > 2 ? 2 : value; } }


        private int _CardButtonRow = 6;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Row Number"), DescriptionAttribute("Card Button Horizontal Row, Default:6, Max:7")]
        public int CardButtonRow { get { return _CardButtonRow; } set { _CardButtonRow = value > 11 ? 11 : value; } }

        private int _CardButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Vertical RowSpan"), DescriptionAttribute("Card Button Vertical Row Span, Default:2, Max:7")]
        public int CardButtonRowSpan { get { return _CardButtonRowSpan; } set { _CardButtonRowSpan = value > 11 ? 11 : value; } }


        private int _OnlineButtonColumn = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Column Number"), DescriptionAttribute("Online Button Vertical Column, Default:1, Max:2")]
        public int OnlineButtonColumn { get { return _OnlineButtonColumn; } set { _OnlineButtonColumn = value > 2 ? 2 : value; } }

        private int _OnlineButtonColumnSpan = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Horizontal Column Span"), DescriptionAttribute("Online Button Horizontal Column Span, Default:1, Max:2")]
        public int OnlineButtonColumnSpan { get { return _OnlineButtonColumnSpan; } set { _OnlineButtonColumnSpan = value > 2 ? 2 : value; } }


        private int _OnlineButtonRow = 10;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Row Number"), DescriptionAttribute("Online Button Horizontal Row, Default:10, Max:7")]
        public int OnlineButtonRow { get { return _OnlineButtonRow; } set { _OnlineButtonRow = value > 11 ? 11 : value; } }

        private int _OnlineButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Vertical RowSpan"), DescriptionAttribute("Online Button Vertical Row Span, Default:2, Max:7")]
        public int OnlineButtonRowSpan { get { return _OnlineButtonRowSpan; } set { _OnlineButtonRowSpan = value > 11 ? 11 : value; } }


        //THIRD COLUMN

        private int _HoldAndPrintOrderButtonRow = 0;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold And Print Order Button Row Number"), DescriptionAttribute("Hold  And Print Order Button Horizontal Row, Default:0, Max:7")]
        public int HoldAndPrintOrderButtonRow { get { return _HoldAndPrintOrderButtonRow; } set { _HoldAndPrintOrderButtonRow = value > 11 ? 11 : value; } }

        private int _HoldAndPrintOrderButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold And Print Order Button Vertical RowSpan"), DescriptionAttribute("Hold  And Print Order Button Vertical Row Span, Default:4, Max:7")]
        public int HoldAndPrintOrderButtonRowSpan { get { return _HoldAndPrintOrderButtonRowSpan; } set { _HoldAndPrintOrderButtonRowSpan = value > 11 ? 11 : value; } }



        private int _CashAndPrintButtonColumn = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print Button Column Number"), DescriptionAttribute("Cash  And Print Button Vertifal Column, Default:2, Max:2")]
        public int CashAndPrintButtonColumn { get { return _CashAndPrintButtonColumn; } set { _CashAndPrintButtonColumn = value > 2 ? 2 : value; } }

        private int _CashAndPrintButtonColumnSpan = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print  Button Horizontal Column Span"), DescriptionAttribute("Cash And Print  Button Horizontal Column Span, Default:1, Max:2")]
        public int CashAndPrintButtonColumnSpan { get { return _CashAndPrintButtonColumnSpan; } set { _CashAndPrintButtonColumnSpan = value > 2 ? 2 : value; } }


        private int _CashAndPrintButtonRow = 4;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print Button Row Number"), DescriptionAttribute("Cash  And Print Button Horizontal Row, Default:4, Max:7")]
        public int CashAndPrintButtonRow { get { return _CashAndPrintButtonRow; } set { _CashAndPrintButtonRow = value > 11 ? 11 : value; } }

        private int _CashAndPrintButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print  Button Vertical RowSpan"), DescriptionAttribute("Cash And Print  Button Vertical Row Span, Default:2, Max:7")]
        public int CashAndPrintButtonRowSpan { get { return _CashAndPrintButtonRowSpan; } set { _CashAndPrintButtonRowSpan = value > 11 ? 11 : value; } }



        private int _CardAndPrintButtonColumn = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Column Number"), DescriptionAttribute("Card And Print Button Vertical Column, Default:2, Max:2")]
        public int CardAndPrintButtonColumn { get { return _CardAndPrintButtonColumn; } set { _CardAndPrintButtonColumn = value > 2 ? 2 : value; } }


        private int _CardAndPrintButtonColumnSpan = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Horizontal Column Span"), DescriptionAttribute("Card And Print Button Horizontal Column Span, Default:1, Max:2")]
        public int CardAndPrintButtonColumnSpan { get { return _CardAndPrintButtonColumnSpan; } set { _CardAndPrintButtonColumnSpan = value > 2 ? 2 : value; } }


        private int _CardAndPrintButtonRow = 6;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Row Number"), DescriptionAttribute("Card And Print Button Horizontal Row, Default:6, Max:7")]
        public int CardAndPrintButtonRow { get { return _CardAndPrintButtonRow; } set { _CardAndPrintButtonRow = value > 11 ? 11 : value; } }


        private int _CardAndPrintButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Vertical RowSpan"), DescriptionAttribute("Card And Print Button Vertical Row Span, Default:2, Max:7")]
        public int CardAndPrintButtonRowSpan { get { return _CardAndPrintButtonRowSpan; } set { _CardAndPrintButtonRowSpan = value > 11 ? 11 : value; } }



        private int _OnlineAndPrintButtonColumn = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Column Number"), DescriptionAttribute("Online And Print Button Vertical Column, Default:2, Max:2")]
        public int OnlineAndPrintButtonColumn { get { return _OnlineAndPrintButtonColumn; } set { _OnlineAndPrintButtonColumn = value > 2 ? 2 : value; } }


        private int _OnlineAndPrintButtonColumnSpan = 1;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Horizontal Column Span"), DescriptionAttribute("Online And Print Button Horizontal Column Span, Default:1, Max:2")]
        public int OnlineAndPrintButtonColumnSpan { get { return _OnlineAndPrintButtonColumnSpan; } set { _OnlineAndPrintButtonColumnSpan = value > 2 ? 2 : value; } }


        private int _OnlineAndPrintButtonRow = 10;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Row Number"), DescriptionAttribute("Online And Print Button Horizontal Row, Default:10, Max:7")]
        public int OnlineAndPrintButtonRow { get { return _OnlineAndPrintButtonRow; } set { _OnlineAndPrintButtonRow = value > 11 ? 11 : value; } }


        private int _OnlineAndPrintButtonRowSpan = 2;
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Vertical RowSpan"), DescriptionAttribute("Online And Print Button Vertical Row Span, Default:2, Max:7")]
        public int OnlineAndPrintButtonRowSpan { get { return _OnlineAndPrintButtonRowSpan; } set { _OnlineAndPrintButtonRowSpan = value > 11 ? 11 : value; } }


        #endregion

        #region 31.Service Charge Settings

        #endregion

        #region IID values

        private string _DtPrinterCashDrawerIID = "";
        [BrowsableAttribute(false)]
        public string DtPrinterCashDrawerIID
        {
            get { return _DtPrinterCashDrawerIID; }
            set { _DtPrinterCashDrawerIID = value; }
        }

        private string _ActiveMenuIID = "";
        [BrowsableAttribute(false)]
        public string ActiveMenuIID { get { return _ActiveMenuIID; } set { _ActiveMenuIID = value; } }

        private string _DTClientLocalReceiptPrinterIID = "";
        [BrowsableAttribute(false)]
        public string DTClientLocalReceiptPrinterIID
        {
            get { return _DTClientLocalReceiptPrinterIID; }
            set { _DTClientLocalReceiptPrinterIID = value; }
        }

        #endregion





        #region
        //private string[] _test1 = new string[]{};
        //[CategoryAttribute("Test"),  DescriptionAttribute("this is the description"), DefaultValueAttribute("localhost")]
        //public string[] test1 { get { return _test1; } set { _test1 = value; } }

        //private string _test2 = "";
        //[CategoryAttribute("Test"), EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor)), DescriptionAttribute("this is the description"), DefaultValueAttribute("localhost")]
        //public string test2 { get { return _test2; } set { _test2 = value; } }

        //private List<string>  _test3 = new List<string>();
        //[CategoryAttribute("Test"), EditorAttribute(typeof(CollectionEditor), typeof(System.Drawing.Design.UITypeEditor)), DescriptionAttribute("this is the description"), DefaultValueAttribute("localhost")]
        //public List<string> test3 { get { return _test3; } set { _test3 = value; } }


        // private CollectionEditor

        //[EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        #endregion



        public DTRMConfig()
        {

        }

        public string GetInfoAsSting()
        {
            return Database_Instance + ",DTRMSimple," + Database_User_Name + "," + Database_Password;
        }
    }



}
