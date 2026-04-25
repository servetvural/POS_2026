using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using POSLayer.Library;

using PosLibrary;

namespace DTRMNS {
    /// <summary>
    /// Summary description for UF.
    /// </summary>
    public static class UF {
        public static Color ThemeBackColour { get; set; } = Color.Black;
        public static Color ThemeForeColour { get; set; } = Color.White;


        public static string SessionDirName { get; set; } = "Sessions";
        public static string BackupDirName { get; set; } = "Backups";
        public static string ReportsDirName { get; set; } = "Reports";

        public static string DBListConfigFileName { get; set; } = "DBConfig.xml";
        public static string DBConfigFileName { get; set; } = "DTRMConfig.xml";
       
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

        public static PosConfig GetConfig() {
            try {
                PosConfig config = (PosConfig)PosLibrary.DRFile.XmlDeSerialize(DBConfigFileName, typeof(PosConfig), true);
                return config;
            }
            catch (Exception ex) {
                string str = ex.Message;
                return new PosConfig();
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



        public static bool SaveConfig(PosConfig config) {
            return PosLibrary.DRFile.XmlSerialize(DBConfigFileName, config, typeof(PosConfig), true);
        }


        public static POSLayer.Library.StatusFlags UpdateStatus(POSLayer.Library.StatusFlags CurrentFlag, POSLayer.Library.StatusFlags NewFlag, bool blnForce) {
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

      


        public static double GetRelatedPrice(POSLayer.Models.OrderItem oi, POSLayer.Models.Entity en, POSLayer.Models.EntityButton eb, POSLayer.Models.Order order) {
            return eb.GetPrice(order.OrderType);
        }
        public static WeekDays GetTodaysDTRMWeekDay() {
            return (WeekDays)Enum.Parse(typeof(WeekDays), DateTime.Now.DayOfWeek.ToString());
        }

        public static string GetBonusDaysAsString(int daysnumeric) {

            string days = "";

            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Monday))
                days += "Monday, ";
            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Tuesday))
                days += "Tuesday, ";
            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Wednesday))
                days += "Wednesday, ";
            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Thursday))
                days += "Thursday, ";
            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Friday))
                days += "Friday, ";
            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Saturday))
                days += "Saturday, ";
            if (POSLayer.Library.DRNumeric.IsBitSet(daysnumeric, (int)WeekDays.Sunday))
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
   
