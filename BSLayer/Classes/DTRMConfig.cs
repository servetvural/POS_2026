using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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



        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("Name of this terminal"), DisplayName("Unique name of this Terminal")]
        public string Terminal_Name { get; set; } = "Terminal ##";


        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute(@". or .\SQLEXPRESS or 192.168.1.20\SQLEXPRESS"), DisplayName("Database Server IP and/or instance name")]
        public string Database_Instance { get; set; } = ".";


        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("Database Name  exp:DTRMSimple , must be a valid name."), DisplayName("Name of Database")]
        public string Database_Name { get; set; } = "DTRM";

        private string _Database_User_Name = "sa";
        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("It must be a valid username to access the database."), PasswordPropertyText(true), DisplayName("Database Username")]
        public string Database_User_Name { get; set; } = "sa";


        [CategoryAttribute("10.Connection Settings"), DescriptionAttribute("It must be the given password during installation"), PasswordPropertyText(true), DisplayName("Database Password")]
        public string Database_Password { get; set; } = string.Empty;



        [CategoryAttribute("10.Connection Settings"), DisplayName("What is currency culture in database"), DescriptionAttribute("Database Currency Culture as Text exp: en-GB, nl-NL, tr-TR ")]
        public string Database_Currency_Culture { get; set; } = "en-GB";


        [CategoryAttribute("10.Connection Settings"), DisplayName("What is currency culture in terminal"), DescriptionAttribute("Terminal Currency Culture as Text exp:  en-GB, nl-NL, tr-TR ")]
        public string Terminal_Currency_Culture { get; set; } = "en-GB";

        [CategoryAttribute("10.Connection Settings"), DisplayName("Language of this terminal"), DescriptionAttribute("Terminal User Interface Language as Text exp:  English, Türkçe")]
        public LanguageTypes Terminal_UserInterface_Culture { get; set; } = LanguageTypes.English;
        #endregion

        #region 11.Direct Sale Order Settings
        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Allow direct sale method"), DescriptionAttribute("Is Direct Sale Allowed On This Terminal")]
        public bool Direct_Sale_Allowed { get; set; } = true;


        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("How many receipt for direct sale to print"), DescriptionAttribute("Direct Sale Receipt Count")]
        public int Direct_Sale_Receipt_Count { get; set; } = 1;


        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Auto payment method for direct sale"), DescriptionAttribute("Direct Sale Default Payment Method")]
        public AutoPaymentMethods Direct_Sale_Auto_Payment_Mehtod { get; set; } = AutoPaymentMethods.AutoCash;


        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Text on direct sale button"), DescriptionAttribute("Direct Sale Button Text")]
        public string Direct_Sale_Order_Button_Text { get; set; } = "SALE";


        [CategoryAttribute("11.Direct Sale Order Settings"), DisplayName("Width of direct sale button"), DescriptionAttribute("Direct Sale Button Width")]
        public int Direct_Sale_Button_Width { get; set; } = 100;
        #endregion

        #region 12.Hold Order Settings
        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Allow order hold"), DescriptionAttribute("Can Hold Orders")]
        public bool Hold_Order_Available { get; set; } = true;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Width of Shrunk Hold Order Button"), DescriptionAttribute("Maximum Width of Shrunk Hold Order Button"), Range(50, 300)]
        public int Hold_Button_Maximum_Shrunk_Width { get; set; } = 100;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Height of Shrunk Hold Order Button"), DescriptionAttribute("Maximum Height of Shrunk Hold Order Button"), Range(30, 100)]
        public int Hold_Button_Maximum_Shrunk_Height { get; set; } = 50;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Width of Extended Hold Order Button"), DescriptionAttribute("Maximum Width of Extended Hold Order Button When Extended"), Range(50, 100)]
        public int Hold_Button_Maximum_Extended_Width { get; set; } = 100;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum Height of Extended Hold Order Button"), DescriptionAttribute("Maximum Height of Extended Hold Order Button When Extended")]
        public int Hold_Button_Maximum_Extended_Height { get; set; } = 200;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Held orders reload seconds"), DescriptionAttribute("Number of seconds to reload Hold Orders"), Range(3, 10)]
        public int Hold_Orders_Reload_Seconds { get; set; } = 5;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Maximum number of held orders allowed"), DescriptionAttribute("Maximum number of Hold Orders allowed"), Range(3, 12)]
        public int Hold_Order_Maximum_Allowed { get; set; } = 12;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Print held orders in kitchen printer"), DescriptionAttribute("Will print Hold Orders in Kitchen/Bar")]
        public bool Hold_Order_Print_in_Kitchen { get; set; }


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Display held orders in kitchen screen"), DescriptionAttribute("Will display Hold Orders in Kitchen/Bar")]
        public bool Hold_Order_Display_in_Kitchen { get; set; }


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Allow kitchen to delete completed orders from screen"), DescriptionAttribute("True: Prevents prepared items to be deleted from order")]
        public bool Hold_Order_Kitchen_Prepared_Items_Cannot_Be_Deleted { get; set; }


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Font size of held order buttons"), DescriptionAttribute("Hold button price font size")]
        public float Hold_Button_Price_Font_Size { get; set; } = 22;


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Hold Order Auto Close Enabled"), DescriptionAttribute("False: Closes the Hold Order automatically after certain period of time if no change is made")]
        public bool Hold_Order_Auto_Close { get; set; }


        [CategoryAttribute("12.Hold Order Settings"), DisplayName("Hold Order Auto Close Seconds"), DescriptionAttribute("How many seconds to wait to close the Hold Order automatically"), Range(5, 30)]
        public int Hold_Order_Auto_Close_Seconds { get; set; } = 10;

        #endregion

        #region 13.Table Orders Settings
        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Allow table orders"), DescriptionAttribute("Table Sale Allowed On This Terminal")]
        public bool Table_Orders_Allowed { get; set; }


        [CategoryAttribute("13.Table Orders Settings"), DisplayName("How many receipt for table order to print"), DescriptionAttribute("Table Sale Receipt Count"), Range(0, 2)]
        public int Table_Orders_Receipt_Count { get; set; } = 1;



        [CategoryAttribute("13.Table Orders Settings"), DisplayName("How many kitchen receipt for table order to print"), DescriptionAttribute("Table Kitchen Receipt Count"), Range(0, 2)]
        public int Table_Orders_Kitchen_Receipt_Count { get; set; } = 1;


        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Auto payment method for table orders"), DescriptionAttribute("Table Sale Default Payment Method")]
        public AutoPaymentMethods Table_Orders_Auto_Payment_Method { get; set; } = AutoPaymentMethods.Selective;


        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Text on table order button"), DescriptionAttribute("Table Sale Button Text")]
        public string Table_Orders_Button_Text { get; set; } = "TABLES";


        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Width of table order button"), DescriptionAttribute("Table Sale Button Width"), Range(100, 200)]
        public int Table_Orders_Button_Width { get; set; } = 100;


        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Display table orders in kitchen screen"), DescriptionAttribute("Create/Allow table orders to be displayed in kitchen display")]
        public bool Table_Orders_Display_Kitchen_Orders { get; set; }


        [CategoryAttribute("13.Table Orders Settings"), DisplayName("Display table orders always shrinked"), DescriptionAttribute("Display table order's sub orders seperately")]
        public bool Table_Orders_Always_Shrinked { get; set; } = true;
        #endregion

        #region 14.Take-Away Orders Settings
        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Allow take-away orders"), DescriptionAttribute("Is Take-Away Sale Allowed On This Terminal")]
        public bool TakeAway_Orders_Allowed { get; set; }


        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("How many receipt for take-away orders to print"), DescriptionAttribute("Take-Away Sale Receipt Count")]
        public int TakeAway_Orders_Receipt_Count { get; set; } = 1;


        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Auto payment method for take-away orders"), DescriptionAttribute("Take-Away Sale Default Payment Method")]
        public AutoPaymentMethods TakeAway_Orders_Auto_Payment_Method { get; set; } = AutoPaymentMethods.AutoCash;


        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Text on take-away order button"), DescriptionAttribute("Take-Away Sale Button Text")]
        public string TakeAway_Orders_Button_Text { get; set; } = "Take Away";


        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Width of take-away order button"), DescriptionAttribute("Take-Away Sale Button Width")]
        public int TakeAway_Orders_Button_Width { get; set; } = 100;


        [CategoryAttribute("14.Take-Away Orders Settings"), DisplayName("Display take-away orders in kitchen screen"), DescriptionAttribute("Allow takeaway orders to be displayed in kitchen display")]
        public bool TakeAway_Orders_Display_Kitchen_Orders { get; set; }

        #endregion

        #region 15.Delivery Orders Settings
        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Allow delivery orders"), DescriptionAttribute("Is Delivery Sale Allowed On This Terminal")]
        public bool Delivery_Orders_Allowed { get; set; }


        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("How many receipt for delivery orders to print"), DescriptionAttribute("Delivery Sale Receipt Count")]
        public int Delivery_Orders_Receipt_Count { get; set; } = 2;


        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Auto payment method for delivery orders"), DescriptionAttribute("Delivery Sale Default Payment Method")]
        public AutoPaymentMethods Delivery_Orders_Auto_Payment_Method { get; set; } = AutoPaymentMethods.Selective;


        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Text on delivery order button"), DescriptionAttribute("Delivery Sale Button Text")]
        public string Delivery_Orders_Button_Text { get; set; } = "Delivery";


        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Width of delivery order button"), DescriptionAttribute("Delivery Sale Button Width")]
        public int Delivery_Orders_Button_Width { get; set; } = 100;



        [CategoryAttribute("15.Delivery Orders Settings"), DisplayName("Display delivery orders in kitchen screen"), DescriptionAttribute("Allow delivery orders to be displayed in kitchen display")]
        public bool Delivery_Orders_Display_Kitchen_Orders { get; set; }


        #endregion

        #region 16.Other Order Settings
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Width of Cancel/Close Order Button"), DescriptionAttribute("Cancel/Close Order Button Width")]
        public int Cancel_Button_Width { get; set; } = 100;


        [CategoryAttribute("16.Other Order Settings"), DisplayName("Full file name of Cancel Button Image"), Editor(typeof(FilteredImageFileEditor), typeof(UITypeEditor)), DescriptionAttribute("Full name of Cancel Button Image with extension"), DefaultValueAttribute("")]
        public string Cancel_Button_Image { get; set; } = string.Empty;


        [CategoryAttribute("16.Other Order Settings"), DisplayName("Background Colour of Cancel Button"), Editor(typeof(FilteredColorSelectEditor), typeof(UITypeEditor)), DescriptionAttribute("Background Colour of Cancel Button"), DefaultValueAttribute("Black")]
        public string Cancel_Button_BackColour { get; set; } = "Black";

        [CategoryAttribute("16.Other Order Settings"), DisplayName("Show Cancel/Close Order Button Border"), DescriptionAttribute("Show Cancel/Close Order Button Border")]
        public bool Cancel_Button_Show_Borders { get; set; }



        [CategoryAttribute("16.Other Order Settings"), DisplayName("Allow use of PAD"), DescriptionAttribute("Pad can be used to take orders")]
        public bool Pad_Allowed { get; set; }


        [CategoryAttribute("16.Other Order Settings"), DisplayName("Default order type for OrderPad"), DescriptionAttribute("Pad Default Order Type. Identifies which order type should be instantiated when Pad Button Clicked")]
        public OrderTypes Order_Pad_Default_Order_Type { get; set; } = OrderTypes.DirectSale;


        [CategoryAttribute("16.Other Order Settings"), DisplayName("OrderPad Orientation"), DescriptionAttribute("OrderPad Orientation Landscape or Portrait")]
        public OrientationTypes OrderPad_Orientation { get; set; } = OrientationTypes.Landscape;



        //NOT NECESSARY
        [CategoryAttribute("16.Other Order Settings"), DisplayName("Default order type for default order creation"), DescriptionAttribute("Default Order Type. Identifies which order type should be instantiated when a Order Created")]
        public OrderTypes Auto_Order_Type { get; set; } = OrderTypes.Unknown;


        [CategoryAttribute("16.Other Order Settings"), DisplayName("Allow standard users to see session total"), DescriptionAttribute("Can Basic Users See Session Totals from this Terminal")]
        public bool Standard_Users_Can_See_Session_Totals { get; set; } = true;

        [CategoryAttribute("16.Other Order Settings"), DisplayName("Allow orders to be reloaded"), DescriptionAttribute("Orders can be reloaded")]
        public bool Order_Reloads_Allowed { get; set; } = true;


        [CategoryAttribute("16.Other Order Settings"), DisplayName("Number of detailed orders displayed on order list"), DescriptionAttribute("Maximum number of orders will be displayed in detail in order list")]
        public int Order_List_Detailed_Orders_Max_Counter { get; set; } = 5;


        [CategoryAttribute("16.Other Order Settings"), DisplayName("Force order deletion for supervisor user"), DescriptionAttribute("Delete Order Item Requires Supervisor Authorisation")]
        public bool Deleting_OrderItem_Requires_Supervision { get; set; }


        [CategoryAttribute("16.Other Order Settings"), DisplayName("log deleted order item quantities"), DescriptionAttribute("Log deleted order item quantities")]
        public bool Log_Deleted_Order_Items { get; set; }
        #endregion



        #region 18.Cash Drawer Settings
        [CategoryAttribute("18.Cash Drawer Settings"), DisplayName("Allow cash drawer to be openned with VOID button"), DescriptionAttribute("Cash Drawer can be openned directly")]
        public bool Cash_Drawer_Void_Open_Allowed { get; set; }


        [CategoryAttribute("18.Cash Drawer Settings"), DisplayName("Which type of cash drawer used"), DescriptionAttribute("Attached Cash Drawer Type")]
        public CashDrawerTypes Attached_Cash_Drawer_Type { get; set; } = CashDrawerTypes.None;


        [CategoryAttribute("18.Cash Drawer Settings"), DisplayName("Which COM Port is cash drawer connected to"), DescriptionAttribute("Cash Drawer Serially Connected to Port exp: COM1, COM4 etc")]
        public SerialPortTypes Cash_Drawer_Serial_Port { get; set; } = SerialPortTypes.COM1;

        #endregion

        #region 19.Screen Lock / Screen Saver Settings

        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Allow lock screen block the entire display"), DescriptionAttribute("Lock screen will cover the entire window")]
        public System.Windows.Forms.FormWindowState Lock_Screen_Window_Format { get; set; } = System.Windows.Forms.FormWindowState.Normal;

        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Screen locking method"), DescriptionAttribute("How to lock the system when there is no interaction")]
        public ScreenLockTypes Screen_Lock_Method { get; set; } = ScreenLockTypes.None;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Seconds to wait"), DescriptionAttribute("Activates screen saver after ? seconds"), Range(3, 300)]
        public int Seconds_Before_ScreenLock { get; set; } = 30;



        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Image Folder"), Editor(typeof(FolderNameEditor), typeof(UITypeEditor)), DescriptionAttribute("Image Folder to pickup screen saver images")]
        public string Screen_Saver_Image_Folder { get; set; } = string.Empty;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Extra space between images"), Range(0, 50), DescriptionAttribute("Extra space required between images")]
        public int Screen_Saver_Image_Spacer { get; set; } = 20;



        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Maximum number of images"), Range(20, 150), DescriptionAttribute("Maximum number of images to pickup from image folder")]
        public int Screen_Saver_Maximum_Image_Count { get; set; } = 20;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Maximum number of drawable images"), Range(5, 100), DescriptionAttribute("Maximum number of images can be drawn at any time on the screen descp attribute")]
        public int Screen_Saver_Maximum_Drawable_Image_Count { get; set; } = 5;



        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Maximum image size"), Range(500, 2000), DescriptionAttribute("Maximum size of images in KB to load to screen saver")]
        public int Screen_Saver_Maximum_Image_Size { get; set; } = 500;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Speed Difference"), Range(1, 20), DescriptionAttribute("Variable speeds amongs the images between 1 and 20 pixels a second")]
        public int Screen_Saver_Speed_Difference { get; set; } = 10;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Speed towards left"), Range(3, 10), DescriptionAttribute("Movement speed towards the left 0 to 3 pixels a second")]
        public int Screen_Saver_Left_Step { get; set; } = 3;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Speed towards right"), Range(3, 10), DescriptionAttribute("Movement speed towards the right 0 to 10  pixels a second")]
        public int Screen_Saver_Right_Step { get; set; } = 3;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Redraw cycle in miliseconds"), DescriptionAttribute("Redraw cycle in miliseconds for timer"), Range(20, 10000)]
        public int Screen_Saver_Timer_Interval { get; set; } = 5000;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Stop screen saver if mouse clicked"), DescriptionAttribute("Ensures mouse down event captured to activate screen saver")]
        public bool Screen_Saver_Capture_Mouse_Down_Event { get; set; } = true;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Stop screen saver if mouse moved"), DescriptionAttribute("Ensures mouse moves captured to activate screen saver")]
        public bool Screen_Saver_Capture_Mouse_Move_Event { get; set; }


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Show Pos Logo as default"), DescriptionAttribute("Shows Pos Logo on Screen Saver")]
        public bool Screen_Saver_Show_Pos_Logo { get; set; } = true;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Show debug information"), DescriptionAttribute("Show debug information on screen saver")]
        public bool Screen_Saver_Debug { get; set; }


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Type of screen saver"), DescriptionAttribute("Appication specific screen saver type")]
        public ScreenSaverTypes Screen_Saver_Type { get; set; } = ScreenSaverTypes.None;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Color format of the screen saver"), DescriptionAttribute("Colour of the screen saver"), DefaultValueAttribute(ScreenSaverColourTypes.BlackBackGroundWhiteBrush)]
        public ScreenSaverColourTypes Screen_Saver_Color { get; set; } = ScreenSaverColourTypes.BlackBackGroundWhiteBrush;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Size of large font on screen saver"), DescriptionAttribute("Size of large font on screen saver (40 to 150)"), Range(30, 150)]
        public int Screen_Saver_Large_Font_Size { get; set; } = 70;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Size of small font on screen saver"), DescriptionAttribute("Size of small font on screen saver (20 to 90)"), Range(10, 90)]
        public int Screen_Saver_Small_Font_Size { get; set; } = 50;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Image alignment in given space"), DescriptionAttribute("Image alignment in given space")]
        public AlignmentTypes Screen_Saver_Image_Alignment { get; set; } = AlignmentTypes.Center;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver left/right indentation of the image"), DescriptionAttribute("Regardless alignment minus value forces left plus value forces right indentation to the image")]
        public int Screen_Saver_Image_Indent { get; set; }


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver top indentation of the image"), DescriptionAttribute("Single screen saver top indentation of the image (set to -1 for auto indentation) (-1 to 700)"), Range(-1, 700)]
        public int Screen_Saver_Image_Top_Indent { get; set; } = -1;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver left indentation of the text"), DescriptionAttribute("Single screen saver left indentation of the text (set to -1 for auto indentation)")]
        public int Screen_Saver_Text_Left_Indent { get; set; } = 50;


        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver top indentation of the text"), DescriptionAttribute("Single screen saver top indentation of the text (set to -1 for auto indentation) (-1 to 1200)"), Range(-1, 1200)]
        public int Screen_Saver_Text_Top_Indent { get; set; } = -1;

        private int _Screen_Saver_Text_Line_Space = 25;
        [CategoryAttribute("19.Screen Lock / Screen Saver Settings"), DisplayName("Single screen saver line space between text lines"), DescriptionAttribute("Single screen saver line space between text lines (10 to 100)"), Range(10, 100)]
        public int Screen_Saver_Text_Line_Space { get; set; } = 25;

        #endregion


        //


        #region 20.Kitchen Display Settings
        [Browsable(false)]
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Which distribution type to display on primary kitchen screen"), DescriptionAttribute("Select do display which preparation terminal")]
        public string Default_Distribution_Terminal_Type_List { get; set; } = string.Empty;

        [Browsable(false)]
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Which distribution type to display on secondary kitchen screen"), DescriptionAttribute("Select do display which preparation terminal on secondary window")]
        public string Secondary_Distribution_Terminal_Type_List { get; set; } = string.Empty;


        [Browsable(false)]
        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allowed good time for kitchen in seconds"), DescriptionAttribute("Will display Kitchen/Bar order preperation good time (in seconds")]
        public int Kitchen_Prep_Good_Time { get; set; } = 20;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allowed bad time for kitchen in seconds"), DescriptionAttribute("Will display Kitchen/Bar order preperation bad time (in seconds), will start flashing after time elapsed")]
        public int Kitchen_Prep_Bad_Time { get; set; } = 40;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Show progress bar on kitchen screen during order preparation"), DescriptionAttribute("Will display Kitchen/Bar order preperation progress bar")]
        public bool Kitchen_Show_Progress_Bar { get; set; }


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Display clock on kitchen screen"), DescriptionAttribute("Show Clock in Kitchen Displays")]
        public bool Show_Clock_in_Kitchen { get; set; }


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Delete completed orders after how many"), DescriptionAttribute("Will only display x number of completed orders in display terminal")]
        public int Kitchen_Max_Completed_Order_Count { get; set; } = 10;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen screen small font size"), DescriptionAttribute("Kitchen small font (irrelevant item's font) size."), Range(10, 16)]
        public int Kitchen_Small_Font_Size { get; set; } = 12;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen screen big font size"), DescriptionAttribute("Kitchen large font (relevant item's font) size."), Range(10, 16)]
        public int Kitchen_Large_Font_Size { get; set; } = 12;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen screen detailed font size"), DescriptionAttribute("Kitchen detail font (detailed description text) size."), Range(8, 13)]
        public int Kitchen_Detail_Font_Size { get; set; } = 10;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen printer font size"), DescriptionAttribute("Kitchen Print Font Size, 7 to 12"), Range(10, 12)]
        public float KitchenPrintFontSize { get; set; } = 10;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen printer detailed font size"), DescriptionAttribute("Kitchen Print Font Size, 7 to 12"), Range(8, 9)]
        public float KitchenPrintDetailFontSize { get; set; } = 8;



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


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allow kitchen to print orders from this terminal"), DescriptionAttribute("Kitchen can print orders locally")]
        public bool Kitchen_Can_Print { get; set; }


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("How many distribution type to display on kitchen screen"), DescriptionAttribute("Automatically Jumps to Display Screen 1,2,3 or none")]
        public KitchenDisplayTypes Kitchen_Monitor_Auto_Display_Type { get; set; } = KitchenDisplayTypes.None;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Display kitchen order's remaining quantity"), DescriptionAttribute("Displays kitchen order's remaining quantity"), DefaultValueAttribute(true)]
        public bool Display_Kitchen_Orders_As_Reminders { get; set; } = true;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Display kitchen chef on display screen"), DescriptionAttribute("Displays kitchen chef button on display screen"), DefaultValueAttribute(true)]
        public bool Display_Kitchen_Chef_on_Display { get; set; } = true;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Allow Kitchen OrderItems to be FullScreen"), DescriptionAttribute("Allow kitchen order items to be enlarged for better view"), DefaultValueAttribute(true)]
        public bool Display_Kitchen_FullScreen_on_Display { get; set; } = true;


        [CategoryAttribute("20.Kitchen Display Settings"), DisplayName("Kitchen OrderItem FullScreen Font Size"), DescriptionAttribute("Minimum and Maximum Font Size for kitchen orderitem during FullScreen Mode, between 16 to 46"), Range(16, 46)]
        public float Display_Kitchen_FullScreen_Font_Size { get; set; } = 30;

        #endregion

        #region 21.Prep Window Settings
        [CategoryAttribute("21.Prep Window Settings"), DisplayName("Allow Prep window to hold orders"), DescriptionAttribute("Prep Window Can Hold without payment")]
        public bool Prep_Can_Hold { get; set; } = true;

        [CategoryAttribute("21.Prep Window Settings"), DisplayName("Allow Prep window to hold and cash orders"), DescriptionAttribute("Prep Window Can Hold and Cashout")]
        public bool Prep_Can_Hold_And_Cash { get; set; }


        [CategoryAttribute("21.Prep Window Settings"), DisplayName("Allow Prep window to hold, cash and print orders"), DescriptionAttribute("Prep Window Can Hold, Cashout and Print Receipt")]
        public bool Prep_Can_Hold_Cash_And_Print { get; set; }
        #endregion

        #region 23.Report Settings
        [CategoryAttribute("23.Report Settings"), DisplayName("Allow this terminal to produce reports"), DescriptionAttribute("Allow This Terminal to print reports.")]
        public bool This_Terminal_Can_Produce_Reports { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Allow standard users to produce reports"), DescriptionAttribute("Can Basic Users Print Reports from this Terminal")]
        public bool Standard_Users_Can_Produce_Reports { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Font size for reports"), DescriptionAttribute("Report Font Size, 7 or 8"), Range(7, 8)]
        public float ReportFontSize { get; set; } = 7;


        [CategoryAttribute("23.Report Settings"), DisplayName("Font size for report button"), DescriptionAttribute("Report Button Font Size 10 or above"), Range(10, 12)]
        public float ReportButtonFontSize { get; set; } = 10;


        [CategoryAttribute("23.Report Settings"), DisplayName("Font name for reports"), DescriptionAttribute("Report Font Name (Mono Space) like 'Courier New'")]
        public string ReportFontName { get; set; } = "Courier New";







        [CategoryAttribute("23.Report Settings"), DisplayName("Name of report logo/image file"), Editor(typeof(FilteredImageFileEditor), typeof(UITypeEditor)), DescriptionAttribute("Report Image Filename with extension"), DefaultValueAttribute("printlogo.png")]
        public string ReportLogo { get; set; } = "printlogo.png";





        [CategoryAttribute("23.Report Settings"), DisplayName("Allow managers to re-print previous reports"), DescriptionAttribute("It allows managers to re-print previous reports")]
        public bool Preserve_Previous_Report { get; set; }


        [CategoryAttribute("23.Report Settings"), DisplayName("Force printer to extra cut on reports"), DescriptionAttribute("True: Extra paper feed/cut applied to reports")]
        public bool Feed_Space_Cut { get; set; }


        [CategoryAttribute("23.Report Settings"), DisplayName("Do not allow held orders during report production"), DescriptionAttribute("True: All Hold Orders must be cashed out before report produced")]
        public bool No_Hold_Orders_Allowed_During_Report { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Do not allow tables order during report production"), DescriptionAttribute("True: All Table Orders must be cashed out before report produced")]
        public bool No_Table_Orders_Allowed_During_Report { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Show tax details on receipts"), DescriptionAttribute("Show Tax Details on Receipts")]
        public bool ShowTaxOnReceipts { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Show tax percentages on every line"), DescriptionAttribute("Show Tax Details on Receipts in every line")]
        public bool Show_Tax_Percent_in_everyline { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Print Tax Totals in Receipts"), DescriptionAttribute("True: Receipts print total of tax amount")]
        public bool Receipts_Print_Tax_Total { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Print Excluding Tax Totals in Receipts"), DescriptionAttribute("True: Receipts print excluding tax total amount")]
        public bool Receipts_Print_Ex_Tax_Total { get; set; } = true;


        [CategoryAttribute("23.Report Settings"), DisplayName("Display Service Charge On Order Screen"), DescriptionAttribute("Display Service Charge On Order Screen"),]
        public bool Order_Screen_Display_Service_Charge { get; set; } = true;
        #endregion




        #region 24.X Report Settings
        [CategoryAttribute("24.X Report Settings"), DisplayName("Maximum number of X Report to print"), DescriptionAttribute("Maximum number of X Reports can be taken before the final Z Report can be taken"), Range(1, 3)]
        public int Maximum_XReport_Count { get; set; } = 1;


        [CategoryAttribute("24.X Report Settings"), DisplayName("Force cash drawer to be counted before printing the X Report"), DescriptionAttribute("True: Cash Drawer must be counted before report is printed")]
        public bool X_Cash_Drawer_Count_Required { get; set; }


        [CategoryAttribute("24.X Report Settings"), DisplayName("Remind Pin Machine Report to be taken before printing the X Report"), DescriptionAttribute("True: Before X Report reminder will be displayed")]
        public bool X_Pin_Machine_Report_Required { get; set; }


        [CategoryAttribute("24.X Report Settings"), DisplayName("Print category report in X Report"), DescriptionAttribute("True: Category report is printed")]
        public bool X_Print_Category_Report { get; set; }


        [CategoryAttribute("24.X Report Settings"), DisplayName("Print detailed category report in X Report"), DescriptionAttribute("True: Category detailed report is printed")]
        public bool X_Print_Category_Detailed_Report { get; set; }


        // Cash, Card, Online

        [CategoryAttribute("24.X Report Settings"), DisplayName("Print cash paid order list report in X Report"), DescriptionAttribute("True: Cash Paid Order List report is printed")]
        public bool X_Print_Cash_Order_List { get; set; }


        [CategoryAttribute("24.X Report Settings"), DisplayName("Print card paid order list report in X Report"), DescriptionAttribute("True: Card Paid Order List report is printed")]
        public bool X_Print_Card_Order_List { get; set; }


        [CategoryAttribute("24.X Report Settings"), DisplayName("Print online paid order list report in X Report"), DescriptionAttribute("True: Online Paid Order List report is printed")]
        public bool X_Print_Online_Order_List { get; set; }

        #endregion

        #region 25.Z Report Settings

        [CategoryAttribute("25.Z Report Settings"), DisplayName("Force cash drawer to be counted before printing the Z Report"), DescriptionAttribute("True: Cash Drawer must be counted before report is printed")]
        public bool Z_Cash_Drawer_Count_Required { get; set; }


        [CategoryAttribute("25.Z Report Settings"), DisplayName("Remind Pin Machine Report to be taken before printing the Z Report"), DescriptionAttribute("True: Before Z Report reminder will be displayed")]
        public bool Z_Pin_Machine_Report_Required { get; set; }


        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print category report in Z Report"), DescriptionAttribute("True: Category report is printed")]
        public bool Z_Print_Category_Report { get; set; }


        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print detailed category report in Z Report"), DescriptionAttribute("True: Category detailed report is printed")]
        public bool Z_Print_Category_Detailed_Report { get; set; }

        // Cash, Card, Online

        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print cash paid order list report in Z Report"), DescriptionAttribute("True: Cash Paid Order List report is printed")]
        public bool Z_Print_Cash_Order_List { get; set; }


        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print card paid order list report in Z Report"), DescriptionAttribute("True: Card Paid Order List report is printed")]
        public bool Z_Print_Card_Order_List { get; set; }


        [CategoryAttribute("25.Z Report Settings"), DisplayName("Print online paid order list report in Z Report"), DescriptionAttribute("True: Online Paid Order List report is printed")]
        public bool Z_Print_Online_Order_List { get; set; }


        [CategoryAttribute("25.Z Report Settings"), DisplayName("Archive Z Report Always"), DescriptionAttribute("True: Archives Z Report anytime report is printed")]
        public bool Z_Archive_Always { get; set; }

        #endregion

        #region 26.Stock Settings

        [CategoryAttribute("26.Stock Settings"), DisplayName("Record details for use of stock items"), DescriptionAttribute("True: Stock Usage data will be recorded in the system")]
        public bool Record_Stock_Usage { get; set; }


        [CategoryAttribute("26.Stock Settings"), DisplayName("Print stock usage report"), DescriptionAttribute("True:  Print Stock Usage Report")]
        public bool Print_Stock_Usage_Report { get; set; }


        [CategoryAttribute("26.Stock Settings"), DisplayName("Email stock usage report"), DescriptionAttribute("True:  Email Stock Usage Report")]
        public bool Email_Stock_Usage_Report { get; set; }


        [CategoryAttribute("26.Stock Settings"), DisplayName("Delete stock usage"), DescriptionAttribute("True:  Delete the Stock Usage")]
        public bool Delete_Stock_Usage { get; set; }

        #endregion

        #region 27.Bonus Scheme Settings

        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Session Bonus"), DescriptionAttribute("Displays Session Bonus")]
        public bool Display_Session_Bonus { get; set; }


        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Session Total on Bonus Bar"), DescriptionAttribute("Displays Session Total on Bonus Bar")]
        public bool Display_Session_Total_On_Bonus_Bar { get; set; }


        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Progress Bar on Bonus Bar"), DescriptionAttribute("Displays Progress Bar on Bonus Bar")]
        public bool Display_Progress_Bar_On_Bonus_Bar { get; set; }


        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Progress on Bonus Bar"), DescriptionAttribute("Displays Progress on Bonus Bar")]
        public bool Display_Progress_On_Bonus_Bar { get; set; }


        [CategoryAttribute("27.Bonus Scheme Settings"), DisplayName("Display Remaining Balance on Bonus Bar"), DescriptionAttribute("Display Remaining Balance on Bonus Bar")]
        public bool Display_Remaining_Balance_On_Bonus_Bar { get; set; }
        #endregion

        #region 28.Functional Settings

        [CategoryAttribute("28.Functional Settings"), DisplayName("Force receipt printer to cut the receipt after print"), DescriptionAttribute("If printer doesn't cut normally")]
        public bool Force_Receipt_Printer_To_Cut { get; set; }


        [CategoryAttribute("28.Functional Settings"), DisplayName("Allow entity buttons to be scrolled"), DescriptionAttribute("True: ScrollBar available for Entity Buttons")]
        public bool Entity_Buttons_Scrollable { get; set; }


        [CategoryAttribute("28.Functional Settings"), DisplayName("System in debug mode now"), DescriptionAttribute("Database Connection Debug Mode")]
        public bool DebugMode { get; set; }

        #endregion

        #region 29.User Interface Settings



        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow cash payment"), DescriptionAttribute("Is Cash Payment Button Visible")]
        public bool Payments_Can_Be_Made_By_Cash { get; set; } = true;


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow cash payment and print"), DescriptionAttribute("Is Cash Payment and Print Button Visible")]
        public bool Payments_Can_Be_Made_By_Cash_And_Print { get; set; } = true;


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow card payment"), DescriptionAttribute("Is Card Payment Button Visible")]
        public bool Payments_Can_Be_Made_By_Card { get; set; }


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow card and print payment"), DescriptionAttribute("Is Card and Print Payment Button Visible")]
        public bool Payments_Can_Be_Made_By_Card_And_Print { get; set; }



        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow online payment"), DescriptionAttribute("Is Online Payment Button Visible")]
        public bool Payments_Can_Be_Made_Online { get; set; }


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow online and print payment"), DescriptionAttribute("Is Online and Print Payment Button Visible")]
        public bool Payments_Can_Be_Made_Online_And_Print { get; set; }


        [CategoryAttribute("29.User Interface Settings"), DisplayName("What is order display screen width"), DescriptionAttribute("Order Display Screen Width, Default: 314"), Range(314, 450)]
        public int DisplayWidth { get; set; } = 315;


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Order item display height"), DescriptionAttribute("Order Item Display Height on Order Screen")]
        public OrderDisplayHeightTypes Order_Item_Display_Height { get; set; } = OrderDisplayHeightTypes.Narrow;


        [CategoryAttribute("29.User Interface Settings"), DisplayName("What is order split display height"), DescriptionAttribute("Split Display Screen Height, Default:200"), Range(200, 250)]
        public int SplitDisplayHeight { get; set; } = 240;


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow SubTotal panel to be used"), DescriptionAttribute("Is Sub Total Payment Button Visible")]
        public bool Sub_Total_Panel_Visible { get; set; } = true;


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow additional receipt print before cashout"), DescriptionAttribute("Is Print Invoice Button Visible")]
        public bool Print_Invoice_Button_Visible { get; set; }


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Allow small change calculator screen"), DescriptionAttribute("Is Cash Drawer Money Calculator Button Visible")]
        public bool Drawer_Calculator_Visible { get; set; }


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Display Session Total On Menu"), DescriptionAttribute("Displays Session Total On Menu")]
        public bool Display_Session_Total_On_Menu { get; set; }


        [CategoryAttribute("29.User Interface Settings"), DisplayName("Display advertisement"), DescriptionAttribute("Displays advertisements"), DefaultValueAttribute(true)]
        public bool Display_Reklam { get; set; } = true;

        #endregion

        #region 30.User Interface Money Panel Settings
        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Money Action Panel Height"), DescriptionAttribute("Change the Hold Button Height, Default:98"), Range(100, 500)]
        public int MoneyActionPanelHeight { get; set; } = 325;



        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Individual Hold Button Height"), DescriptionAttribute("Change the Hold Button Height, Default:98"), Range(50, 100)]
        public int HoldButtonItemsHeight { get; set; } = 98;


        //FIRST COLUMN

        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Done Button Row Number"), DescriptionAttribute("Done Button Horizontal Row, Default:0, Max:7"), Range(0, 11)]
        public int DoneButtonRow { get; set; }

        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Done Button Vertical RowSpan"), DescriptionAttribute("Done Button Vertical Row Span, Default:2, Max:7"), Range(2, 7)]
        public int DoneButtonRowSpan { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Drawer Button Row Number"), DescriptionAttribute("Cash Drawer Button Horizontal Row, Default:2, Max:7"), Range(2, 11)]
        public int CashDrawerButtonRow { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Drawer Button Vertical RowSpan"), DescriptionAttribute("Cash Drawer Button Vertical Row Span, Default:2, Max:7"), Range(2, 11)]
        public int CashDrawerButtonRowSpan { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Print Button Row Number"), DescriptionAttribute("Print Button Horizontal Row, Default:6, Max:7"), Range(0, 11)]
        public int PrintButtonRow { get; set; } = 6;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Print Button Vertical RowSpan"), DescriptionAttribute("Print Button Vertical Row Span, Default:2, Max:7"), Range(2, 11)]
        public int PrintButtonRowSpan { get; set; } = 2;

        //SECOND COLUMN


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold Order Button Row Number"), DescriptionAttribute("Hold Order Button Horizontal Row, Default:0, Max:7"), Range(0, 11)]
        public int HoldOrderButtonRow { get; set; }


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold Order Button Vertical RowSpan"), DescriptionAttribute("Hold Order Button Vertical Row Span, Default:4, Max:7"), Range(0, 11)]
        public int HoldOrderButtonRowSpan { get; set; } = 2;




        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Column Number"), DescriptionAttribute("Cash Button Vertical Column, Default:1, Max:2"), Range(1, 2)]
        public int CashButtonColumn { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Horizontal Column Span"), DescriptionAttribute("Cash Button Horizontal ColumnSpan, Default:1, Max:2"), Range(1, 2)]
        public int CashButtonColumnSpan { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Row Number"), DescriptionAttribute("Cash Button Horizontal Row, Default:4, Max:7"), Range(0, 7)]
        public int CashButtonRow { get; set; } = 4;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash Button Vertical RowSpan"), DescriptionAttribute("Cash Button Vertical Row Span, Default:2, Max:7"), Range(2, 7)]
        public int CashButtonRowSpan { get; set; } = 2;




        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Column Number"), DescriptionAttribute("Card Button Vertical Column, Default:1, Max:2"), Range(1, 2)]
        public int CardButtonColumn { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Horizontal Column Span"), DescriptionAttribute("Card Button Horizontal Column Span, Default:1, Max:2"), Range(1, 2)]
        public int CardButtonColumnSpan { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Row Number"), DescriptionAttribute("Card Button Horizontal Row, Default:6, Max:7"), Range(6, 11)]
        public int CardButtonRow { get; set; } = 6;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card Button Vertical RowSpan"), DescriptionAttribute("Card Button Vertical Row Span, Default:2, Max:7"), Range(2, 11)]
        public int CardButtonRowSpan { get; set; } = 2;



        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Column Number"), DescriptionAttribute("Online Button Vertical Column, Default:1, Max:2"), Range(1, 2)]
        public int OnlineButtonColumn { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Horizontal Column Span"), DescriptionAttribute("Online Button Horizontal Column Span, Default:1, Max:2"), Range(1, 2)]
        public int OnlineButtonColumnSpan { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Row Number"), DescriptionAttribute("Online Button Horizontal Row, Default:10, Max:7"), Range(0, 11)]
        public int OnlineButtonRow { get; set; } = 10;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online Button Vertical RowSpan"), DescriptionAttribute("Online Button Vertical Row Span, Default:2, Max:7"), Range(2, 11)]
        public int OnlineButtonRowSpan { get; set; } = 2;


        //THIRD COLUMN


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold And Print Order Button Row Number"), DescriptionAttribute("Hold  And Print Order Button Horizontal Row, Default:0, Max:7"), Range(0, 11)]
        public int HoldAndPrintOrderButtonRow { get; set; }


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Hold And Print Order Button Vertical RowSpan"), DescriptionAttribute("Hold  And Print Order Button Vertical Row Span, Default:4, Max:7"), Range(0, 11)]
        public int HoldAndPrintOrderButtonRowSpan { get; set; } = 2;




        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print Button Column Number"), DescriptionAttribute("Cash  And Print Button Vertifal Column, Default:2, Max:2"), Range(1, 2)]
        public int CashAndPrintButtonColumn { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print  Button Horizontal Column Span"), DescriptionAttribute("Cash And Print  Button Horizontal Column Span, Default:1, Max:2"), Range(1, 2)]
        public int CashAndPrintButtonColumnSpan { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print Button Row Number"), DescriptionAttribute("Cash  And Print Button Horizontal Row, Default:4, Max:7"), Range(0, 11)]
        public int CashAndPrintButtonRow { get; set; } = 4;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Cash And Print  Button Vertical RowSpan"), DescriptionAttribute("Cash And Print  Button Vertical Row Span, Default:2, Max:7"), Range(0, 11)]
        public int CashAndPrintButtonRowSpan { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Column Number"), DescriptionAttribute("Card And Print Button Vertical Column, Default:2, Max:2"), Range(0, 2)]
        public int CardAndPrintButtonColumn { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Horizontal Column Span"), DescriptionAttribute("Card And Print Button Horizontal Column Span, Default:1, Max:2"), Range(0, 2)]
        public int CardAndPrintButtonColumnSpan { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Row Number"), DescriptionAttribute("Card And Print Button Horizontal Row, Default:6, Max:7"), Range(0, 11)]
        public int CardAndPrintButtonRow { get; set; } = 6;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Card And Print Button Vertical RowSpan"), DescriptionAttribute("Card And Print Button Vertical Row Span, Default:2, Max:7"), Range(0, 11)]
        public int CardAndPrintButtonRowSpan { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Column Number"), DescriptionAttribute("Online And Print Button Vertical Column, Default:2, Max:2"), Range(0, 2)]
        public int OnlineAndPrintButtonColumn { get; set; } = 2;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Horizontal Column Span"), DescriptionAttribute("Online And Print Button Horizontal Column Span, Default:1, Max:2"), Range(0, 2)]
        public int OnlineAndPrintButtonColumnSpan { get; set; } = 1;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Row Number"), DescriptionAttribute("Online And Print Button Horizontal Row, Default:10, Max:7"), Range(0, 11)]
        public int OnlineAndPrintButtonRow { get; set; } = 10;


        [CategoryAttribute("30.User Interface Money Panel Settings"), DisplayName("Online And Print Button Vertical RowSpan"), DescriptionAttribute("Online And Print Button Vertical Row Span, Default:2, Max:7"), Range(0, 11)]
        public int OnlineAndPrintButtonRowSpan { get; set; } = 2;

        #endregion

        #region IID values

        [BrowsableAttribute(false)]
        public string DtPrinterCashDrawerIID { get; set; } = string.Empty;


        [BrowsableAttribute(false)]
        public string ActiveMenuIID { get; set; } = string.Empty;


        [BrowsableAttribute(false)]
        public string DTClientLocalReceiptPrinterIID { get; set; } = string.Empty;

        #endregion


        public string GetInfoAsSting()
        {
            return Database_Instance + ",DTRMSimple," + Database_User_Name + "," + Database_Password;
        }
    }



}
