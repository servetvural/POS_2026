using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;
using PosLibrary;

using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace DTRMNS {
    /// <summary>
    /// Summary description for UF.
    /// </summary>
    public class UF {
        public static Color ThemeBackColour = Color.Black;
        public static Color ThemeForeColour = Color.White;

        //public static string SessionDirectory = DRFile.GetApplicationPath() + "Sessions";
        //public static string BackupDirectory = DRFile.GetApplicationPath() + "Backups";
        //public static string ReportsDirectory = DRFile.GetApplicationPath() + "Reports";

        public static string SessionDirName = "Sessions";
        public static string BackupDirName = "Backups";
        public static string ReportsDirName = "Reports";

        public static string DBListConfigFileName = "DBConfig.xml";
        public static string DBConfigFileName = "DTRMConfig.xml";
        public UF() {
        }

        public static void ChangeDataGridViewZoom(DataGridView dgv) {
            bool blnSmall = (dgv.RowTemplate.Height == 22);
            if (blnSmall) {
                dgv.RowTemplate.Height = 30;
                dgv.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            } else {
                dgv.RowTemplate.Height = 22;
                dgv.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9);
            }
        }

        public static bool IsDBListFileExist() {
            return File.Exists(DBListConfigFileName);
            
        }

        public static bool IsConfigFileExist() {
            return File.Exists(DBConfigFileName);
        }

        public static DTRMConfig GetConfig() {
            try {
                return (DTRMConfig) PosLibrary.DRFile.XmlDeSerialize(DBConfigFileName, typeof(DTRMConfig), true);
            }
            catch {
                return new DTRMConfig();
            }
        }


        public static bool SaveTextFile(string fullpath, string content)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(fullpath))
                {
                    sw.Write(content);
                }
                return true;
            } catch
            {
                   return false;
            }
        }
        public static string GetTextFile(string fullpath)
        {
            try
            {
                return System.IO.File.ReadAllText(fullpath);
              
            } catch
            {
                return "";
            }
        }



        public static bool SaveConfig(DTRMConfig config) {
            return PosLibrary.DRFile.XmlSerialize(DBConfigFileName, config, typeof(DTRMConfig), true);
        }

        public static Object GetXMLFile(string filename, Type type) {
            try {
                return PosLibrary.DRFile.XmlDeSerialize(filename, type, true);
            }
            catch {
                return null;
            }
        }


        public static string SerializeObject(Type type, Object objectToSerialize) {
            System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(type);
            System.IO.StringWriter writer = new System.IO.StringWriter();
            xser.Serialize(writer, objectToSerialize);
            return writer.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="xmlfilename">Include xml extension suchas "customconfig.xml"</param>
        /// <returns></returns>
        public static bool SaveCustomConfig(DTRMConfig config, string xmlfilename) {
            return PosLibrary.DRFile.XmlSerialize(xmlfilename, config, typeof(DTRMConfig), true);
        }

        public static string GetConfigInfo() {
            string msg = "";
            try
            {
                string[] valueNames = Application.UserAppDataRegistry.GetValueNames();
                foreach (string v in valueNames)
                {
                    if (v != "DBUserName" && v != "DBPassword")
                    {
                        if (v == "DataSource" || v == "DBCatalog")
                            msg += v + " = " + DRFormat.Decode(Application.UserAppDataRegistry.GetValue(v).ToString()) + "\r\n";
                        else
                            msg += v + " = " + Application.UserAppDataRegistry.GetValue(v).ToString() + "\r\n";
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                return "Error occured....!!!!\r\n" + ex.Message;
            }



        }

        public static string GetStatusFlagAsString(StatusFlags Flag) {
            switch (Flag) {
                case StatusFlags.NEW:
                    return "NewOrder";
                case StatusFlags.DONE:
                    return "DoneOrder";
                case StatusFlags.COMPLETED:
                    return "CompletedOrder";
                case StatusFlags.ARCHIVED:
                    return "ArchievedOrder";
                default:
                    return "Unknown";
            }
        }

        public static string GetStatusFlagAsStringForReports(StatusFlags Flag) {
            switch (Flag) {
                case StatusFlags.NEW:
                    return "*";
                case StatusFlags.DONE:
                    return "*";
                case StatusFlags.COMPLETED:
                    return "";
                case StatusFlags.ARCHIVED:
                    return "";
                default:
                    return "";
            }
        }

        public static string[] GetLocalDirectoryList(DirectoryTypes dType) {
            string searchtype = "";
            switch (dType) {
                case DirectoryTypes.All:
                    searchtype = "*";
                    break;
                case DirectoryTypes.ShopDirectory:
                    searchtype = "DTShop_*";
                    break;
                case DirectoryTypes.WareHouseDirectory:
                    searchtype = "DTWare_*";
                    break;
                default:
                    searchtype = "*";
                    break;
            }
            return Directory.GetDirectories(DRFile.GetApplicationPath(), searchtype);
        }

        public static string GetPaymentMethodsText(PaymentMethods pt) {
            switch (pt) {
                case PaymentMethods.Cash:
                    return "Cash";
                case PaymentMethods.Card:
                    return "Card";                
                case PaymentMethods.Online:
                    return "Online";
                case PaymentMethods.Unknown:
                    return "Unknown";
            }
            return "Unknown";
        }

        public static StatusFlags UpdateStatus(StatusFlags CurrentFlag, StatusFlags NewFlag, bool blnForce) {
            if (((int)NewFlag) > ((int)CurrentFlag)) {
                return NewFlag;
            }
            else {
                if (blnForce)
                    return NewFlag;
                else
                    return CurrentFlag;
            }
        }

        public static string GetOrderTypeAsText(OrderTypes OrderType) {
            switch (OrderType) {
                case OrderTypes.DirectSale:
                    return "Direct Sale";
                case OrderTypes.InHouse:
                    return "in-House";
                case OrderTypes.TakeAwayB:
                    return "Take Away";
                case OrderTypes.InternetTakeAway:
                    return "Internet TakeAway";
                case OrderTypes.Delivery:
                    return "Delivery";
                case OrderTypes.InternetDelivery:
                    return "Internet Delivery";
                default:
                    return "Unknown";
            }
        }

        public static OrderItemTypes EBTypeToOrderItemType(EntityButtonTypes ebtype) {
            switch (ebtype) {
                case EntityButtonTypes.AmountAddition:
                    return OrderItemTypes.AmountAddition;
                case EntityButtonTypes.PercentAddition:
                    return OrderItemTypes.PercentAddition;
                case EntityButtonTypes.CustomAddition:
                    return OrderItemTypes.CustomAddition;
                case EntityButtonTypes.AmountDeduction:
                    return OrderItemTypes.AmountDeduction;
                case EntityButtonTypes.PercentDeduction:
                    return OrderItemTypes.PercentDeduction;
                case EntityButtonTypes.CustomDeduction:
                    return OrderItemTypes.CustomDeduction;
                default:
                    return OrderItemTypes.NormalOrderItem;
            }
        }

        public static string GetOrderTypeAsShortText(OrderTypes OrderType) {
            switch (OrderType) {
                case OrderTypes.DirectSale:
                    return "DS";
                case OrderTypes.InHouse:
                    return "H";
                case OrderTypes.TakeAwayB:
                    return "TA";
                case OrderTypes.InternetTakeAway:
                    return "ITA";
                case OrderTypes.Delivery:
                    return "D";
                case OrderTypes.InternetDelivery:
                    return "ID";
                default:
                    return "U";
            }
        }

        public static string GetAccessLevelAsText(AccessLevels accesslevel) {
            //User, Manager, Developer
            switch (accesslevel) {
                case AccessLevels.User:
                    return "User";
                case AccessLevels.Manager:
                    return "Manager";
                case AccessLevels.SuperUser:
                    return "Super User";
                case AccessLevels.TechnicalSupport:
                    return "Technical Support";
            }
            return "";
        }

        public static bool LoadLuv(ref DTRMConfig dtrmConfig) {
            dtrmConfig = GetConfig();
            return true;
        }            

        public static bool IsRemoteServerConfigAvailable(string ServerIP, string PortNumber) {
            try {
                if (ServerIP == "")
                    return false;
                if (ServerIP == null)
                    return false;
                if (int.Parse(PortNumber) > 0)
                    return true;
            }
            catch {
                return false;
            }
            return false;
        }

        public static float GetRelatedPrice(OrderItem oi, Entity en, EntityButton eb, Order order) {
            return eb.GetPrice(order.OrderType);
        }


        public static WeekDays ConvertDayOfWeekTODTRMWeekDays(DayOfWeek dayofweek) {
            //WeekDays {  NoDay =0, Monday =1, Tuesday= 2,Wednesday =4, Thursday = 8, Friday = 16, Saturday = 32, Sunday = 64 }
            return (WeekDays)Enum.Parse(typeof(WeekDays), dayofweek.ToString());
        }
        public static WeekDays GetTodaysDTRMWeekDay() {
            return (WeekDays)Enum.Parse(typeof(WeekDays), DateTime.Now.DayOfWeek.ToString());
        }

        public static string GetBonusDaysAsString(int daysnumeric) {

            string days = "";

            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Monday))
                days += "Monday, ";
            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Tuesday))
                days += "Tuesday, ";
            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Wednesday))
                days += "Wednesday, ";
            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Thursday))
                days += "Thursday, ";
            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Friday))
                days += "Friday, ";
            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Saturday))
                days += "Saturday, ";
            if (DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Sunday))
                days += "Sunday";

            days = days.Trim();
            if (days.EndsWith(","))
                days = days.Substring(0, days.Length - 1);

            return days;
        }

        public static Image ByteArrayToImage(object imageArray) {
            if (imageArray == null)
                return null;
            if (imageArray is byte[]) {

                using (var ms = new MemoryStream((byte[])imageArray)) {
                    return Image.FromStream(ms);
                }
            } else
                return null;
        }

        public static void SetBackgroundColour(Control control, string newColourName) {
            Color oldColour = control.BackColor;
            try {
               
                control.BackColor = Color.FromName(newColourName);
            } catch {
                control.BackColor = oldColour;
            }
        }
        public static void SetForegroundColour(Control control, string newColourName) {
            Color oldColour = control.ForeColor;
            try {
                control.ForeColor = Color.FromName(newColourName);
            }
            catch {
                control.ForeColor = oldColour;
            }
        }
        public static void SetImageForButton(Button btn, string filename, Image defaultImage) {
            if (filename == null)
                return;
            if (filename == "") {
                btn.Image = defaultImage;
                return;
            }

            else {
                try {
                    Image img = Image.FromFile(filename);
                    btn.Image = img;
                }
                catch {
                    btn.Image = defaultImage;
                }
            }
        }
        public static void SetBackgroundImageForButton(Button btn, string filename, Image defaultImage, ImageLayout layout) {
            if (filename == null)
                return;
            if (filename == "") 
                btn.BackgroundImage = defaultImage;             

            else {
                try {
                    Image img = Image.FromFile(filename);
                    btn.BackgroundImage = img;
                }
                catch {
                    btn.BackgroundImage = defaultImage;
                }
            }

            btn.BackgroundImageLayout = layout;
        }

        public static DataTable StringifyEnumInDataTable(DataTable dt, string enumColumnName, string stringColumnName, Type enumtype) {
            return StringifyEnumInDataTable(dt, enumColumnName, stringColumnName, System.Enum.GetNames(enumtype));
        }

        public static DataTable StringifyEnumInDataTable(DataTable dt, string enumColumnName, string stringColumnName, string[] enumNames) {
            if (dt == null)
                return null;

            dt.Columns.Add(stringColumnName);
            for (int i = 0; i < dt.Rows.Count; i++) {
                int index = int.Parse(dt.Rows[i][enumColumnName].ToString());
                dt.Rows[i][stringColumnName] = enumNames[index];
            }
            return dt;


        }


        public static Image ReSizeImageTo(Image imgPhoto, int Width, int Height, bool KeepAspectRatio = true) {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW) {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            } else {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;
            if (KeepAspectRatio) {
                grPhoto.DrawImage(imgPhoto,
                    new Rectangle(destX, destY, destWidth + 1, destHeight),
                    new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                    GraphicsUnit.Pixel);
            } else {
                grPhoto.DrawImage(imgPhoto,
                    new Rectangle(destX, destY, Width + 1, Height),
                    new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                    GraphicsUnit.Pixel);
            }

            grPhoto.Dispose();
            return bmPhoto;
        }

        public static Bitmap LoadBitmapNolock(string path) {
            using (var img = Image.FromFile(path)) {
                return new Bitmap(img);
            }
        }

        public static Image CropImage(Image img, Rectangle cropArea) {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        public static string MaximumString(string str, int maxChars, PrintAligns align) {
            if (str.Length > maxChars) {
                return str.Substring(0, maxChars);
            } else {
                switch (align) {
                    case PrintAligns.Near:
                        return str + Repeat(" ", maxChars - str.Length);
                    case PrintAligns.Center:
                        return Repeat(" ", (maxChars - str.Length) == 0 ? 0 : (maxChars - str.Length) / 2) + str + ((maxChars - str.Length) == 0 ? 0 : (maxChars - str.Length) / 2);
                    case PrintAligns.Far:
                        return Repeat(" ", maxChars - str.Length) + str;
                    default:
                        return str;
                }
            }
        }
        private static string Repeat(string str, int manyTimes) {
            string result = "";
            for (int i = 0; i < manyTimes; i++) {
                result += str;
            }
            return result;
        }

    }


}
