using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinLayer
{
    public class ReportGenerator
    {
        private PosConfig config;
        IRepository<Session> repoSession;
        IRepository<Order> repoOrder;

        private PrinterSettings pSettings;
        private PrintDocument pDocument;

        private Font font; //must use a mono spaced font as the spaces need to line up
        private Font fontLarge;
        private int fontHeight;
        private int linespace;
        private int startX;
        private int startY;

        private Session session;
        private string orderIID;
        private string catalogIID;
        private string SessionDirectory;
        private bool blnSpecialSessionDirectory;


        private POSLayer.Models.KitchenOrder korder;

        private Brush brush;
        private Graphics g;
        private Report report;
        private int max_numberOfCharacters = 40;
        private int reportwidthcm = 250;

        private bool blnCustomGraphic;
        public int FinalLength;

        public bool blnLateReport;
        public Bitmap imgSnapShot;

        public Image Logo1;

        private IEnumerable<StockItemUsage> stockUsages;
        private string StockSupplierName;

        private Printer aPrinter;


        GenericImage printLogo;
        Order order;

        public ReportGenerator(Graphics g, Printer printer, int linespace, GenericImage printLogo)
        {
            this.g = g;                                                     
            config = ServiceHelper.GetService<PosConfig>();
            repoSession = ServiceHelper.GetService<IRepository<Session>>();
            repoOrder = ServiceHelper.GetService<IRepository<Order>>();
            this.printLogo = printLogo;
            blnCustomGraphic = true;

            CreateGenerator(printer, linespace);
        }
        public ReportGenerator(Printer printer, int linespace, GenericImage printLogo)
        {
            if (printer == null)
                return;
            this.printLogo = printLogo;
            CreateGenerator(printer, linespace);
        }
        //public ReportGenerator(BSLayer bslayer, string printerNetworkName, int linespace) {
        //    CreateGenerator(bslayer, printerNetworkName, linespace);
        //}
        public ReportGenerator(Printer printer)
        {
            if (printer == null)
                return;
            CreateGenerator(printer, 2);
        }
        public void CreateGenerator(Printer printer,  int linespace)
        {
            if (printer == null)
                return;

            config = ServiceHelper.GetService<PosConfig>();
            repoSession = ServiceHelper.GetService<IRepository<Session>>();
            repoOrder = ServiceHelper.GetService<IRepository<Order>>();

          
            //order =  await repoOrder.Get(orderIID, "Items");

            float fontSize = config.ReportFontSize;
            string fontName = config.ReportFontName;
            aPrinter = printer;

            this.font = new Font(fontName, fontSize, FontStyle.Bold);
            this.fontLarge = new Font(fontName, fontSize + 5, FontStyle.Bold);
            fontHeight = (int)font.GetHeight();
            brush = new SolidBrush(Color.Black);


            max_numberOfCharacters = config.GetFontMaximumCharacter(fontSize);

            this.linespace = linespace;
            startX = 10;
            startY = 0;

            pSettings = new PrinterSettings();
            pDocument = new PrintDocument();
            pDocument.QueryPageSettings += pDocument_QueryPageSettings;
            pDocument.PrinterSettings = pSettings;
            pSettings.PrinterName = printer.NetworkName;

            reportwidthcm = 270;

        }

        void pDocument_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void Reset()
        {
            FinalLength = startY + 10;
            startY = 10;
            report = null;
            session = null;
            orderIID = "";
            catalogIID = "";

            try
            {
                if (config.Feed_Space_Cut)
                    PosLibrary.DRShell.SendCutCommandToUSBPrinter(pSettings.PrinterName);
            } catch { }
        }


        private async Task<bool> SetXReportValueToSession()
        {

            switch (BSLayer.Instance.GetAvailableXReportSlot(session))
            {
                case 1:
                    session.X1Total = session.Total;
                    return await repoSession.Save(session) != null;
                case 2:
                    session.X2Total = session.Total;
                    return await repoSession.Save(session) != null;
                case 3:
                    session.X3Total = session.Total;
                    return await repoSession.Save(session) != null;
                default:
                    return false;
            }
        }

        #region SESSION REPORT

        /// <summary>
        /// Only does late session printing, no xorders manipulation done.
        /// </summary>
        /// <param name="SessionIID"></param>
        /// <param name="reportFormat"></param>
        /// <returns></returns>
        public async Task<bool> PrintLateSessionReport(string SessionIID, ReportFormatTypes reportFormat)
        {
            session = await repoSession.Get(SessionIID);
            report = BSLayer.Instance.GetReport(reportFormat);
            blnLateReport = true;

            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null && session != null)
                {
                    pDocument.PrintPage += pDocument_PrintSessionReport;
                    pDocument.Print();
                    Reset();
                }
                return true;
            } catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Only does late session printing, no xorders manipulation done.
        /// </summary>
        /// <param name="SessionIID"></param>
        /// <param name="reportFormat"></param>
        /// <returns></returns>
        public async Task<bool> PrintLateSessionReport(string SessionDirectory, string SessionIID, ReportFormatTypes reportFormat)
        {
            session = await repoSession.Get(SessionIID);
            report = BSLayer.Instance.GetReport(reportFormat);
            blnSpecialSessionDirectory = true;
            this.SessionDirectory = SessionDirectory;
            blnLateReport = true;

            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null && session != null)
                {
                    pDocument.PrintPage += pDocument_PrintSessionReport;
                    pDocument.Print();
                    Reset();
                }
                return true;
            } catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }

        public async Task<bool> PrintSessionReport(string SessionDirectory, string SessionIID, ReportFormatTypes reportFormat)
        {
            blnSpecialSessionDirectory = true;
            this.SessionDirectory = SessionDirectory;
            return await PrintSessionReport(SessionIID, reportFormat);
        }


        /// <summary>
        /// Only used to print currently active session, xorders transferred
        /// </summary>
        /// <param name="SessionIID"></param>
        /// <param name="reportFormat"></param>
        /// <returns></returns>
        public async Task<bool> PrintSessionReport(string SessionIID, ReportFormatTypes reportFormat)
        {

            session = await repoSession.Get(SessionIID);
            bool blnCurrentSession = session.IID == BSLayer.Instance.shop.CurrentSessionIID;
            report = BSLayer.Instance.GetReport(reportFormat);
        ZForcedLabel:

            if (report == null)
                return false;

            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null && session != null)
                {
                    pDocument.PrintPage += pDocument_PrintSessionReport;

                    if (blnCurrentSession)
                        await SetXReportValueToSession();

                    if (report.ReportType == ReportFormatTypes.ZReport && blnCurrentSession)
                    {
                        await BSLayer.Instance.GetXOrdersBackForSession(session.IID);

                        session.X1Total = 0;
                        session.X2Total = 0;
                        session.X3Total = 0;
                        await repoSession.Save(session);


                        //This is exactly the point where the current active real session to be archived for the first time
                        //if (config.Record_Stock_Usage) {
                        //    //This ensures x1+x2 total usage recorded in stockitem table, if incremental it is merged with up to yesterday's usage
                        //    // BSLayer.Instance.TransferStockItemUsageNow();

                        //    //Print the updated stockusage report up to end of tonight
                        //    //if (config.Print_Stock_Usage_Report)
                        //    //     BSLayer.Instance.PrintStockUsage(aPrinter); // pSettings.PrinterName);


                        //    //Email the updated stockusage to required people (same as print)
                        //    //if (config.Email_Stock_Usage_Report) {

                        //    //    if ( BSLayer.Instance.shop.SmtpEmailAddress != null &&  BSLayer.Instance.shop.SmtpEmailAddress.Length > 0 &&  BSLayer.Instance.shop.PurchaseEmail != null &&  BSLayer.Instance.shop.PurchaseEmail.Length > 0)
                        //    //         BSLayer.Instance.SendEmailToCustomRecepient( BSLayer.Instance.shop.PurchaseEmail,  BSLayer.Instance.shop.ShopName + "  Stock Order List", "Stock Order List.\r\n\r\n" +  BSLayer.Instance.GetOrderableStockItemUsageAsCsvText(), null);
                        //    //}

                        //    //Now time to remove the ordered items from stockitem table if true
                        //    //if (config.Delete_Stock_Usage)
                        //    //     BSLayer.Instance.RemoveOrderedStockUsage(true);

                        //}


                        //Now prepare current session to be archive
                        if (session.IID == BSLayer.Instance.shop.CurrentSessionIID)
                        {
                            await BSLayer.Instance.RemoveZeroOrdersOfCurrentSessionAndCreateNewSession();
                        }
                    }

                    if (blnCurrentSession && (report.ReportType == ReportFormatTypes.ZReport))
                    {
                        session = await repoSession.Get(session.IID);
                        await repoSession.Save(session);
                    }

                    pDocument.Print();

                    if (blnCurrentSession)
                    {
                        switch (report.ReportType)
                        {
                            case ReportFormatTypes.XReport:
                                await BSLayer.Instance.PreserveSessionOrdesToX(session.IID);
                                break;
                            case ReportFormatTypes.ZReport:
                                break;
                            case ReportFormatTypes.YReport:
                                break;
                        }
                        //if z report is forced check here
                        if (report.ReportType == ReportFormatTypes.XReport)
                        {
                            session = await repoSession.Get(session.IID);

                            if (BSLayer.Instance.Is_Z_ReportTimeNow(session))
                            {
                                //now prepare for forced Z report
                                report = BSLayer.Instance.GetReport(ReportFormatTypes.ZReport);
                                if (report != null)
                                {
                                    startY = 10;
                                    pDocument.PrintPage -= pDocument_PrintSessionReport;
                                    reportFormat = ReportFormatTypes.ZReport;
                                    goto ZForcedLabel;
                                }
                            }
                        }
                    }

                    Reset();
                }
                return true;
            } catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }
        async void pDocument_PrintSessionReport(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            if (report == null)
                return;

            //Draw in to printer
            DrawCompanyHeader(BSLayer.Instance.shop.ReportHeader);

            DrawSessionHeader();

            if (report.PrintCategoryReport)
                DrawReportCategoryTotals();

            if (report.PrintCategoryDetailedReport)
                DrawReportCategoricEntityButtonTotals();

            if (report.PrintCashOrderList)
                DrawReportOrders(PaymentMethods.Cash);
            if (report.PrintCardOrderList)
                DrawReportOrders(PaymentMethods.Card);
            if (report.PrintOnlineOrderList)
                DrawReportOrders(PaymentMethods.Online);



            DrawTaxReport();
            DrawPaymentSummary();
            DrawReportSummary();

            //take a snapshot of report 
            if (config.Preserve_Previous_Report && !blnLateReport)
            {
                imgSnapShot = new Bitmap(300, startY + 10, g);
                startY = 0;
                Image img = Image.FromHbitmap(imgSnapShot.GetHbitmap());
                g = Graphics.FromImage(img);
                g.Clear(Color.White);

                DrawCompanyHeader(BSLayer.Instance.shop.ReportHeader);

                DrawSessionHeader();

                if (report.PrintCategoryReport)
                    DrawReportCategoryTotals();

                if (report.PrintCategoryDetailedReport)
                    DrawReportCategoricEntityButtonTotals();

                if (report.PrintCashOrderList)
                    DrawReportOrders(PaymentMethods.Cash);
                if (report.PrintCardOrderList)
                    DrawReportOrders(PaymentMethods.Card);
                if (report.PrintOnlineOrderList)
                    DrawReportOrders(PaymentMethods.Online);


                DrawTaxReport();
                DrawPaymentSummary();
                DrawReportSummary();
                imgSnapShot = new Bitmap(img);

            }


            //Now Archive Session if required
            if (session != null && report.ReportType == ReportFormatTypes.ZReport && config.Z_Archive_Always)
            {
                if (session.IID != BSLayer.Instance.GetLatestSession().Result.IID)
                {
                    if (blnSpecialSessionDirectory && !string.IsNullOrEmpty(SessionDirectory))
                        await BSLayer.Instance.ArchiveSessionToDirectory(SessionDirectory, session.IID, true);
                    else
                        await BSLayer.Instance.ArchiveSessionToDirectory(session.IID);
                }

                BSLayer.Instance.CleanKitchenOrdersHasNoParentOrder();
            }



        }
        #endregion




        #region RECEIPT
        public bool PrintReceipt(Order order)
        {
            this.order = order;
            if (order == null)
                return false;

            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintReceipt;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }


        }
        async void pDocument_PrintReceipt(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawCompanyHeader(BSLayer.Instance.shop.ReceiptHeader);

            DrawReceipt();
            Reset();
        }
        private void DrawReceipt()
        {
            

            DrawDoubleLine();
            DrawText(centeredString("RECEIPT" +
                   (order.OrderType == OrderTypes.Sitin && order.Table != null && order.Table?.TableName != "" ? " - " + order.Table?.TableName : "") +
                   (order.OrderType == OrderTypes.Sale && order.Reference != null && order.Reference != "" ? " - " + order.Reference : "")
                   ));
            DrawDoubleLine();

            //test
            //DrawText(reportwidthcm.ToString());

            DrawText(centeredString(order.LastModified.ToString("dd/MMM/yyyy HH:mm:ss")));
            DrawText(centeredString(order.OrderType.ToString()));
            switch (order.OrderType)
            {
                case OrderTypes.TakeAway:
                    DrawText("Cust.Name :" + order.Customer.CName);
                    DrawText("Tel : " + order.Customer.Tel);
                    break;
                case OrderTypes.Delivery:
                    DrawText("Cust.Name :" + order.Customer.CName);
                    DrawText("Tel : " + order.Customer.Tel);
                    DrawText("Address : " + order.Customer.Address);
                    DrawText("Postcode : " + order.Customer.Postcode);
                    break;
                case OrderTypes.Sitin:
                    DrawText("Waiter: " + BSLayer.Instance.LoggedUser.UserName);
                    break;
                case OrderTypes.Sale:

                    break;
            }

            DrawLine();

            SortedDictionary<double, double> taxlist = new SortedDictionary<double, double>();
            //float ServiceChargeTaxTotal = 0;

            foreach (OrderItem item in order.Items)
            {
                string ItemText = item.OrderItemText.Length > 26 ? item.OrderItemText.Substring(0, 25) : item.OrderItemText;
                DrawText(string.Format("{0,2:n0}", item.Quantity).PadRight(3) +
                              ItemText.PadRight(26) +
                              (config.Show_Tax_Percent_in_everyline ? String.Format("{0,5:N2}%", item.TaxPercent) : "".PadRight(6)) +
                            String.Format("{0,8:C}", item.Total));

                //collect tax percent data
                if (taxlist.ContainsKey(item.TaxPercent))
                    taxlist[item.TaxPercent] += item.TotalVat;
                else
                    taxlist.Add(item.TaxPercent, item.TotalVat);


            }

            DrawLine();


            // Order order =await repoOrder.Get(order.IID);
            //OrdersView ordView = new OrdersView( BSLayer.Instance.GetDataTable("Select * from OrdersView where IID = '" + order.IID + "'"));



            //Prior to 2020
            // DrawBiggerText("Total : ".PadRight(17) + String.Format("{0,8:C}", ordView.CalculatedValue));


            //double ServiceCharge = ordView.   GetServiceCharge( BSLayer.Instance.luv.ServiceChargeType,  BSLayer.Instance.luv.ServiceChargeRate);
            //if (ServiceCharge < 0)
            //    ServiceCharge = 0;

            //double ServiceChargeTax = 0;
            //if ( BSLayer.Instance.luv.ServiceChargeTaxRate != 0 && ServiceCharge != 0) 
            //    ServiceChargeTax = ServiceCharge *  BSLayer.Instance.luv.ServiceChargeTaxRate / 100;

            if (BSLayer.Instance.shop.ServiceChargeRate > 0)
            {
                DrawText("Total : ".PadRight(20) + String.Format("{0,8:C}", order.Total - order.ServiceCharge));
                DrawText("Service Inc.Tax : ".PadRight(20) + String.Format("{0,8:C}", order.ServiceCharge));


                //ServiceChargeTaxTotal += ordView.ServiceChargeTax;                
            }
            DrawBiggerText("Total : ".PadRight(17) + String.Format("{0,8:C}", order.Total));
            if (order.MoneyPaid > 0)
            {
                DrawText("Paid : ".PadRight(20) + String.Format("{0,8:C}", order.MoneyPaid));
                DrawText("Change : ".PadRight(20) + String.Format("{0,8:C}", order.MoneyPaid - order.Total));
            }



            VerticalSpace(1);

            if (config.ShowTaxOnReceipts)
            {
                foreach (KeyValuePair<double, double> kvp in taxlist)
                {
                     DrawText(("Tax " + String.Format("{0,2:N0} %", kvp.Key)).PadRight(35) + String.Format("{0,8:C}", kvp.Value));
                    //DrawText("Tax " + kvp.Key + " %".PadRight(35) + String.Format("{0,8:C}", kvp.Value));
                }
                //Show Service Charge Tax Total
                if (BSLayer.Instance.shop.ServiceChargeRate > 0)
                     DrawText(("Service Charge Tax " + String.Format("{0,2:N0} %", BSLayer.Instance.shop.ServiceChargeTaxRate)).PadRight(35) + String.Format("{0,8:C}", order.ServiceChargeTax));


                if (config.Receipts_Print_Tax_Total)
                     DrawText("Tax Total : ".PadRight(35) + String.Format("{0,8:C}", order.ItemTotalVat + order.ServiceChargeTax));
                if (config.Receipts_Print_Ex_Tax_Total)
                     DrawText("Ex.Tax Total : ".PadRight(35) + String.Format("{0,8:C}", order.Total - order.ItemTotalVat - order.ServiceChargeTax));

            }

             DrawText("Payment Method : " + order.Payment);


             DrawLine();
            //Luv luv =  BSLayer.Instance.GetLuv();
            //DrawText(centeredString(luv.ReceiptFooter));

            string[] footer = BSLayer.Instance.shop.ReceiptFooter.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < footer.Length; i++)
            {
                 DrawText(centeredString(footer[i]));
            }

             DrawDoubleLine();

        }
        #endregion

        #region Test
        private string testline;
        private string formattestline;
        //"{0,3}"
        public bool PrintTest(string line)
        {
            testline = line;
            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintTest;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        void pDocument_PrintTest(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawText(testline);
            //DrawText(string.Format(testline, "1234567890123456789"));
            Reset();
        }

        public bool PrintFormatTest(string format, string line)
        {
            formattestline = format;
            testline = line;
            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintFormatTest;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        void pDocument_PrintFormatTest(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawText(string.Format(formattestline, testline));
            Reset();
        }

        #endregion

        #region DATA TABLE PRINT FUNCTIONS
        public string CustomReportName;
        public DataTable dtCustom;
        public List<int> columnSize;
        public bool blnIncludeHeaders;
        public bool PrintDataTable(DataTable dt, string CustomReportName, List<int> columnSize, bool blnIncludeHeaders)
        {
            try
            {
                dtCustom = dt;
                this.CustomReportName = CustomReportName;
                this.columnSize = columnSize;
                this.blnIncludeHeaders = blnIncludeHeaders;

                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintDataTable;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        void pDocument_PrintDataTable(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            //reportwidthcm = (int)GetReceiptWidth(); // max_numberOfCharacters * 7 + 7;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawTable();
            Reset();
        }
        public void DrawTable()
        {

            DrawText(centeredStringCustom(CustomReportName, max_numberOfCharacters));
            DrawLine();

            DrawDoubleLine();
            string str = "";
            if (blnIncludeHeaders)
            {
                for (int i = 0; i < dtCustom.Columns.Count; i++)
                {
                    str += ExactStr(dtCustom.Columns[i].Caption, Math.Abs(columnSize[i])) + " ";
                }
                DrawText(str);
                DrawLine();
                str = "";
            }

            for (int i = 0; i < dtCustom.Rows.Count; i++)
            {
                DataRow dr = dtCustom.Rows[i];

                for (int r = 0; r < dr.ItemArray.Length; r++)
                    str += ExactStr(dr.ItemArray[r].ToString(), columnSize[r]) + " ";

                DrawText(str);
                str = "";


            }
            if (dtCustom == null || dtCustom.Rows.Count == 0)
                DrawText("Nothing To Print");
            NewLine();
            DrawDoubleLine();

        }
        #endregion

        #region STOCK uSAGE
        public bool PrintStockUsage(IEnumerable<StockItemUsage> usages, string StockSupplierName)
        {
            try
            {
                stockUsages = usages;
                this.StockSupplierName = StockSupplierName;

                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintStockUsage;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        void pDocument_PrintStockUsage(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            //reportwidthcm = (int)GetReceiptWidth(); // max_numberOfCharacters * 7 + 7;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // DrawCompanyHeader();
            DrawStockUsage();
            Reset();
        }
        public void DrawStockUsage()
        {
            bool blnSupplier = !string.IsNullOrEmpty(StockSupplierName);

            DrawText(centeredString("STOCK USAGE REPORT"));
            DrawLine();
            if (blnSupplier)
                DrawText(centeredString(StockSupplierName.ToUpper()));

            DrawText(centeredString(DateTime.Now.ToString("dd /MMM HH:mm")));
            DrawDoubleLine();

            foreach (var item in stockUsages)
            {
                if (blnSupplier)
                    DrawText(string.Format("{0,2:N0} {1,-5} {2,-21}",
                                        item.OrderableQuantity,
                                        SubStr(item.StockItem.OrderType.ToString(), 5),
                                        SubStr(item.StockItem.StockName, 27)));

                else
                    DrawText(string.Format("{0,2:N0} {1,-5} {2,-20} {3,-6}",
                           item.OrderableQuantity,
                           SubStr(item.StockItem.OrderType.ToString(), 5),
                           SubStr(item.StockItem.StockName, 22),
                           SubStr(item.StockItem.SupplierName, 6)));

            }
            //for (int i = 0; i < dtStockUsage.Rows.Count; i++) {
            //    StockItemUsage item = new StockItemUsage(dtStockUsage.Rows[i]);
            //    if (blnSupplier)
            //        DrawText(string.Format("{0,2:N0} {1,-5} {2,-21}",
            //                            item.OrderableQuantity,
            //                            SubStr(item.OrderableType.ToString(), 5),
            //                            SubStr(item.StockName, 27)));

            //    else
            //        DrawText(string.Format("{0,2:N0} {1,-5} {2,-20} {3,-6}",
            //               item.OrderableQuantity,
            //               SubStr(item.OrderableType.ToString(), 5),
            //               SubStr(item.StockName, 22),
            //               SubStr(item.SupplierName, 6)));

            //}
            //if (dtStockUsage == null || dtStockUsage.Rows.Count == 0)
            if (stockUsages.IsNullOrEmpty())
                DrawText("No Stock Usage");
            NewLine();
            DrawDoubleLine();

        }
        #endregion  

        private bool blnKitchenOrderWithDetail;
        private Font detailFont;
        private int detailFontHeight;
        #region KITCHEN
        public bool PrintKitchen(POSLayer.Models.KitchenOrder korderlocal, bool blnWithDetail = false)
        {
            if (korderlocal == null)
                return false;

            blnKitchenOrderWithDetail = blnWithDetail;

            //font size = 10  so max = 30
            //font size = 11  so max = 25
            this.font = new Font(config.ReportFontName, config.KitchenPrintFontSize, FontStyle.Bold);
            if (blnWithDetail)
            {
                this.detailFont = new Font(config.ReportFontName, config.KitchenPrintDetailFontSize, FontStyle.Bold);
                detailFontHeight = (int)detailFont.GetHeight();
            }

            fontHeight = (int)font.GetHeight();
            max_numberOfCharacters = config.GetFontMaximumCharacter(config.KitchenPrintFontSize);

            korder = korderlocal;

            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintKitchen;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        public async void DrawKitchen()
        {
            if (korder == null)
                return;

            //Order order =  BSLayer.Instance.GetOrder(korder.OrderIID);

            DrawText(centeredString("ORDER" + " " + korder.OrderNo + " " + korder.OrderType.ToString()));
            DrawDoubleLine();


            switch (korder.OrderType)
            {
                case OrderTypes.Sale:
                    DrawText(centeredString(korder.Reference));
                    break;
                case OrderTypes.Sitin:
                    DrawText(centeredString("TABLE: " + korder.Reference));
                    break;
                default:
                    break;
            }
            DrawLine();




            List<Distribution> theList = await BSLayer.Instance.GetDistributionListForPrinter(aPrinter.IID);

            foreach (KitchenOrderItem item in korder.Items)
            {
                if (item.Status != KitchenOrderStatusTypes.Completed)
                {
                    if (theList.Find(x => x.IID == item.DistributionIID) != null)
                    {
                        DrawText(string.Format("{0,-3:N0}".PadRight(4) + "{1,-32}", item.Quantity, item.ItemText));
                        if (blnKitchenOrderWithDetail)
                            DrawDetailText(await BSLayer.Instance.GetCategoryItemStockItemText(item.CategoryItemIID));
                    }
                }
            }
            NewLine();
            DrawDoubleLine();
        }
        void pDocument_PrintKitchen(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            //reportwidthcm = (int)GetReceiptWidth(); // max_numberOfCharacters * 7 + 7;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // DrawCompanyHeader();
            DrawKitchen();
            Reset();
        }

        #endregion

        #region KASSA REPORT

        private List<string> KassaReport;
        public bool PrintKassaReport(List<string> kassaReport)
        {
            this.KassaReport = kassaReport;
            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintKassaReport;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        void pDocument_PrintKassaReport(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            //reportwidthcm = (int)GetReceiptWidth(); // max_numberOfCharacters * 7 + 7;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            foreach (string item in KassaReport)
            {
                if (item == "newline")
                {
                    NewLine();
                } else if (item == "drawline")
                {
                    DrawLine();
                } else
                {
                    DrawText(item);
                }
            }

            Reset();
        }

        #endregion


        #region PRICELIST
        public bool PrintPriceList(string catalogIID)
        {
            this.catalogIID = catalogIID;
            try
            {
                if (pSettings != null && pSettings.PrinterName != null && pDocument != null)
                {
                    pDocument.PrintPage += pDocument_PrintPriceList;
                    pDocument.Print();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        void pDocument_PrintPriceList(object sender, PrintPageEventArgs e)
        {
            if (!blnCustomGraphic)
                g = e.Graphics;

            //reportwidthcm = (int)GetReceiptWidth(); // max_numberOfCharacters * 7 + 7;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawCompanyHeader("Price List");
            DrawPriceList();
            Reset();
        }
        private void DrawPriceList()
        {
            DrawDoubleLine();
            DrawText(centeredString("PRICE LIST"));
            DrawText(centeredString(DateTime.Now.ToString("dd/MMM/yyyy HH:mm")));
            DrawDoubleLine();

            DataTable dt = BSLayer.Instance.GetDataTable("Select IID, EntityName from Entity where ParentMenuIID = '" + catalogIID + "'  order by DisplayOrder");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Write Entity Header
                string EntityIID = dt.Rows[i]["IID"].ToString();
                string EntityName = dt.Rows[i]["EntityName"].ToString().TrimStart();
                EntityName = EntityName.Length > max_numberOfCharacters - 17 ? EntityName.Substring(0, max_numberOfCharacters - 17) : EntityName;


                DrawText(EntityName.PadRight(max_numberOfCharacters - 17) + "  Direct" + "  InHouse");
                DrawLine();

                //Write Entity Button Distributions
                DataTable dteb = BSLayer.Instance.GetDataTable("Select EntityButtonName,DirectSalePrice,InHousePrice, TakeAwayPrice, DeliveryPrice from EntityButton where ParentEntityIID = '" + EntityIID + "'  order by DisplayOrder asc");
                for (int x = 0; x < dteb.Rows.Count; x++)
                {
                    string EntityButtonName = dteb.Rows[x]["EntityButtonName"].ToString().Trim();
                    EntityButtonName = EntityButtonName.Length > max_numberOfCharacters - 17 ? EntityButtonName.Substring(0, max_numberOfCharacters - 17) : EntityButtonName;
                    float DirectSalePrice = float.Parse(dteb.Rows[x]["DirectSalePrice"].ToString());
                    float InHousePrice = float.Parse(dteb.Rows[x]["InHousePrice"].ToString());


                    DrawText(EntityButtonName.PadRight(max_numberOfCharacters - 17) + String.Format("{0,8:N2} {1,8:N2}", DirectSalePrice, InHousePrice));
                }
                NewLine();
            }
            DrawLine();
            DrawText(centeredString("End Of Price List"));



        }
        #endregion

        private void DrawTaxReport()
        {
            DrawDoubleLine();
            DrawText(centeredString("TAX SUMMARY"));
            DrawDoubleLine();

            DrawText("Tax%    " + "   Sum_NoTax" + "     Net_Tax" + "   Sum_Total");
            DrawLine();

            float mainGrossTotal = 0;
            float mainNetTaxValue = 0;
            float mainTotalNoTax = 0;

            DataTable dt = BSLayer.Instance.GetDataTable("Select * from TaxSummary where SessionIID = '" + session.IID + "' Order by TaxPercent, Payment asc");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                float TaxPercent = float.Parse(dt.Rows[i]["TaxPercent"].ToString());
                float GrossTotal = float.Parse(dt.Rows[i]["GrossTotal"].ToString());
                float NetTaxValue = float.Parse(dt.Rows[i]["NetTaxValue"].ToString());
                float TotalNoTax = float.Parse(dt.Rows[i]["TotalNoTax"].ToString());
                PaymentMethods pmethod = (PaymentMethods)int.Parse(dt.Rows[i]["Payment"].ToString());

                mainGrossTotal += GrossTotal;
                mainNetTaxValue += NetTaxValue;
                mainTotalNoTax += TotalNoTax;

                //DrawText(String.Format("{0,2:N0}" + "".PadRight(2 + quarterspace) + "{1,8:N2}" + "".PadRight(2 + quarterspace) + "{2,8:N2}" + "".PadRight(2 + quarterspace * 2) + "{3,8:N2}", TaxPercent, TotalNoTax, NetTaxValue, GrossTotal));
                DrawText(String.Format("{0,-2:N0} " + pmethod.ToString().PadRight(5) + "{1,12:N2}" + "{2,12:N2}" + "{3,12:N2}",
                       TaxPercent, TotalNoTax, NetTaxValue, GrossTotal));
            }

            if (BSLayer.Instance.shop.ServiceChargeRate > 0)
            {
                dt = BSLayer.Instance.GetDataTable("Select * from ServiceChargeSummary where SessionIID ='" + session.IID + "' order by Payment asc");
                float ServiceChargeTotal = 0;
                float ServiceChargeTaxTotal = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PaymentMethods pmethod = (PaymentMethods)int.Parse(dt.Rows[i]["Payment"].ToString());
                    ServiceChargeTotal = float.Parse(dt.Rows[i]["ServiceChargeTotal"].ToString());
                    ServiceChargeTaxTotal = float.Parse(dt.Rows[i]["ServiceChargeTaxTotal"].ToString());
                    DrawText(String.Format("Srv{0,-2:N0}" + pmethod.ToString().PadRight(5) + "{1,10:N2}" + "{2,12:N2}" + "{3,12:N2}",
                             BSLayer.Instance.shop.ServiceChargeTaxRate, ServiceChargeTotal - ServiceChargeTaxTotal, ServiceChargeTaxTotal, ServiceChargeTotal));

                    mainGrossTotal += ServiceChargeTotal;
                    mainNetTaxValue += ServiceChargeTaxTotal;
                    mainTotalNoTax += ServiceChargeTotal - ServiceChargeTaxTotal;
                }

            }

             DrawLine();
            //DrawText(String.Format("".PadRight(4+quarterspace) + "{0,8:N2}" + "".PadRight(2+quarterspace) + "{1,8:N2}" + "".PadRight(2+quarterspace*2) + "{2,8:N2}", mainGrossTotal, mainNetTaxValue, mainTotalNoTax));
             DrawText(String.Format("{0,20:N2}" + "{1,12:N2}" + "{2,12:N2}", mainTotalNoTax, mainNetTaxValue, mainGrossTotal));
             NewLine();

        }

        public string SubStr(string str, int length)
        {
            if (str.Length <= length)
                return str;

            return str.Substring(0, length);
        }
        public string ExactStr(string str, int length)
        {
            int directionalLength = length;
            length = Math.Abs(length);
            if (str.Length > length)
                return str.Substring(0, length);
            if (str.Length == length)
                return str;

            if (str.Length < length)
            {
                //Need to align now 
                string frm = "{0," + directionalLength * -1 + "}";
                return string.Format(frm, str);
                //return str + new string(' ', length - str.Length);
            }

            return str;
        }
        public void VerticalSpace(int howmany)
        {
            startY += (fontHeight * howmany);
        }
        public void DrawText(string line)
        {
            g.DrawString(line, font, brush, startX, startY);
            //int a = 0;
            //if (startX < 5)
            //    a = 1;
            startY += fontHeight;
        }

        public void DrawBiggerText(string line)
        {

            g.DrawString(line, fontLarge, brush, startX, startY);
            //int a;
            //if (startX < 5)
            //    a = 1;
            startY += fontHeight + 8;
        }

        public void DrawDetailText(string line)
        {
            g.DrawString(line, detailFont, brush, startX, startY);

            startY += (detailFontHeight * line.Split('\n').Length);// + detailFontHeight;
        }

        public void DrawLine()
        {
            //DrawText(new string('-',numberOfCharacters));
            //DrawText(new string('-',  BSLayer.Instance.config.Custom_Report_Width));
            startY += 5;
            g.DrawLine(Pens.Black, new Point(startX, startY), new Point(startX + reportwidthcm, startY));
            startY += 5;
        }

        public void DrawDoubleLine()
        {
            // DrawText(new string('=', numberOfCharacters));
            // DrawText(new string('=',  BSLayer.Instance.config.Custom_Report_Width));
            startY += 5;
            g.DrawLine(Pens.Black, new Point(startX, startY), new Point(startX + reportwidthcm, startY));
            startY += 2;
            g.DrawLine(Pens.Black, new Point(startX, startY), new Point(startX + reportwidthcm, startY));
            startY += 5;


        }

        public void NewLine()
        {
            startY += linespace + fontHeight;
        }

        private bool EnsureLogo1()
        {
            if (Logo1 != null)
                return true;

        
            if (printLogo == null)
                return false;

            Logo1 = printLogo.DisplayImage.ToImage();
            if (Logo1 == null)
                return false;
            else
            {
                return true;
            }
        }

        private void DrawCompanyHeader(string CustomHeader)
        {
            //DTRMLicence licence =  BSLayer.Instance.GetLicence();


            try
            {
                //Image image = Image.FromFile( BSLayer.Instance.config.ReportLogo);

                if (EnsureLogo1())
                {

                    float receiptWidth = GetReceiptWidth();
                    float scaleratio = 1;
                    if (Logo1.Width > receiptWidth)
                        scaleratio = receiptWidth / Logo1.Width;

                    int iwidth = (int)(Logo1.Width * scaleratio);
                    int iheight = (int)(Logo1.Height * scaleratio);
                    Size size = new Size(iwidth, iheight);
                    Image newimage = null;

                    if (scaleratio == 1)
                        newimage = Logo1;
                    else
                        newimage = (Image)(new Bitmap(Logo1, size));

                    int oldstartx = startX;
                    startX = (int)((receiptWidth - iwidth) / 2);

                    g.DrawImage(newimage, startX, startY, iwidth, iheight);
                    startX = oldstartx;
                    startY += iheight;
                }
            } catch
            {

            }



            string[] header = CustomHeader.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < header.Length; i++)
            {
                DrawText(centeredString(header[i]));
            }

            string[] address = BSLayer.Instance.shop.Address.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < address.Length; i++)
            {
                DrawText(centeredString(address[i]));
            }

            //DrawText(centeredString( BSLayer.Instance.luv.ShopAddress));


            DrawText(centeredString(BSLayer.Instance.shop.Tel));
            DrawText(centeredString(BSLayer.Instance.shop.TaxNumber));

        }

        public string centeredString(string s)
        {
            if (s.Length >= max_numberOfCharacters)
            {
                return s.Substring(0, max_numberOfCharacters - 1);
            }

            int leftPadding = (max_numberOfCharacters - s.Length) / 2;
            int rightPadding = max_numberOfCharacters - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
        public string rightAlignedString(string s)
        {
            if (s.Length >= max_numberOfCharacters)
            {
                return s.Substring(0, max_numberOfCharacters - 1);
            }

            int leftPadding = (max_numberOfCharacters - s.Length - startX);
            //int rightPadding = max_numberOfCharacters - s.Length - leftPadding;

            return new string(' ', leftPadding) + s; // + new string(' ', rightPadding);
        }

        public string centeredStringCustom(string s, int ncharacters)
        {
            if (s.Length >= ncharacters)
            {
                return s.Substring(0, ncharacters - 1);
            }

            int leftPadding = (ncharacters - s.Length) / 2;
            int rightPadding = ncharacters - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
        public string rightAlignedStringCustom(string s, int ncharacters)
        {
            if (s.Length >= ncharacters)
            {
                return s.Substring(0, ncharacters - 1);
            }

            int leftPadding = (ncharacters - s.Length - startX);

            return new string(' ', leftPadding) + s; // + new string(' ', rightPadding);
        }

        private float MeasureStringMin(string str)
        {
            return g.MeasureString(str, font).Width;
        }
        private float GetReceiptWidth()
        {
            return g.MeasureString(new string('a', max_numberOfCharacters), font).Width;
        }




        private void DrawSessionHeader()
        {
            DrawDoubleLine();
            DrawText(centeredString(report.ReportName));
            DrawLine();

            DrawText("Session Start: " + session.StartDate.ToString("dd/MMM/yy HH:mm"));
            if (report != null && report.ReportType == ReportFormatTypes.ZReport)
            {
                if (session.IID == BSLayer.Instance.shop.CurrentSessionIID)
                {
                    //Current Session
                    DrawText("Session End  : " + DateTime.Now.ToString("dd/MMM/yy HH:mm"));
                } else
                {
                    //Old Session
                    DrawText("Session End  : " + session.EndDate.Value.ToString("dd/MMM/yy HH:mm"));
                }
            }
            DrawDoubleLine();
        }

        private void DrawPaymentSummary()
        {
            DrawText(centeredString("PAYMENT SUMMARY"));
            DrawDoubleLine();


            string spacer = "";



            DataTable dt = BSLayer.Instance.GetReportPaymentTypeTotals(session.IID);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                PaymentMethods paymentType = (PaymentMethods)int.Parse(dt.Rows[i]["Payment"].ToString());
                float paymentTotal = float.Parse(dt.Rows[i]["Total"].ToString());

                switch (paymentType)
                {
                    case PaymentMethods.Cash:
                        DrawText("Cash Total : " + spacer.PadRight(max_numberOfCharacters - 22) + String.Format("{0,8:N2}", paymentTotal));
                        break;
                    case PaymentMethods.Card:
                        DrawText("Card Total : " + spacer.PadRight(max_numberOfCharacters - 22) + String.Format("{0,8:N2}", paymentTotal));
                        break;
                    case PaymentMethods.Online:
                        DrawText("Online Total : " + spacer.PadRight(max_numberOfCharacters - 24) + String.Format("{0,8:N2}", paymentTotal));
                        break;

                }


            }
            //if (report.ReportType == ReportFormatTypes.ZReport) {
            DrawLine();
            DrawText("Payment  Total : ".PadRight(max_numberOfCharacters - 9) + String.Format("{0,8:N2}", session.GrossSessionTotal));
            //}
            DrawDoubleLine();
            NewLine();

        }

        private void DrawReportSummary()
        {
            DrawText(centeredString("REPORT SUMMARY"));
            DrawDoubleLine();
            string x1date = "";
            string x2date = "";
            string x3date = "";

            if (session.X3Total > 0)
                x3date = DateTime.Now.ToString("HH:mm");
            else if (session.X2Total > 0)
                x2date = DateTime.Now.ToString("HH:mm");
            else if (session.X1Total > 0)
                x1date = DateTime.Now.ToString("HH:mm");


            if (session.X1Total > 0)
                DrawText("X1 Total : " + x1date.PadRight(max_numberOfCharacters - 20) + String.Format("{0,8:N2}", session.X1Total));

            if (session.X2Total > 0)
                DrawText("X2 Total : " + x2date.PadRight(max_numberOfCharacters - 20) + String.Format("{0,8:N2}", session.X2Total));

            if (session.X3Total > 0)
                DrawText("X3 Total : " + x3date.PadRight(max_numberOfCharacters - 20) + String.Format("{0,8:N2}", session.X3Total));


            if (report.ReportType == ReportFormatTypes.ZReport)
                DrawText("Z  Total : ".PadRight(max_numberOfCharacters - 9) + String.Format("{0,8:N2}", session.GrossSessionTotal));

            DrawDoubleLine();
            DrawText(centeredString("END OF  REPORT"));

        }

        private async Task DrawReportOrders(PaymentMethods payment)
        {
            DrawText(centeredString(payment.ToString().ToUpper() + " ORDER LIST"));
            DrawDoubleLine();
            //DataTable dt =  BSLayer.Instance.GetDataTable("Select OrderDate, CalculatedValue from OrdersView where SessionIID = '" + session.IID + 
            //    "'  and (OrdersView.Status = 3 or OrdersView.Status = 4) and Payment = " + (int)payment + " order by OrderDate");

            List<Order> orderList = await repoOrder.GetListByField("SessionIID", session.IID, "Items", "OrderDate");
            orderList = orderList.Where(x => x.Payment == payment && (x.Status == StatusFlags.Completed || x.Status == StatusFlags.Archived)).OrderBy(x => x.OrderDate).ToList();

            // float OrderListTotal = 0;

            //for (int i = 0; i < dt.Rows.Count; i++) {
            //    DateTime orderDate = DateTime.Parse(dt.Rows[i]["OrderDate"].ToString());
            //    float OrderTotal = float.Parse(dt.Rows[i]["CalculatedValue"].ToString());
            //    OrderListTotal += OrderTotal;
            //    DrawText(orderDate.ToString("HH:mm:ss").PadRight(max_numberOfCharacters - 9) + String.Format("{0,8:N2}", OrderTotal));
            //}
            foreach (var order in orderList)
            {
                //DateTime orderDate = DateTime.Parse(dt.Rows[i]["OrderDate"].ToString());
                //float OrderTotal = float.Parse(dt.Rows[i]["CalculatedValue"].ToString());
                //OrderListTotal += OrderTotal;
                DrawText(order.OrderDate.ToString("HH:mm:ss").PadRight(max_numberOfCharacters - 9) + String.Format("{0,8:N2}", order.Total));
            }

            DrawLine();
            DrawText(("                 " + orderList.Count.ToString() + " Order(s) ").PadRight(max_numberOfCharacters - 9) + String.Format("{0,8:N2}", orderList.Sum(x => x.Total)));
            NewLine();
        }


        //public void PrintOrderItems() {
        //    DrawText("           ORDER ITEMS          ");
        //    DrawDoubleLine();
        //    DataTable dt =  BSLayer.Instance.GetDataTable("Select Quantity, OrderItemText, (Quantity*Price) as Total from OrderItem where SessionIID = '" + SessionIID + "' order by OrderDate");
        //    for (int i = 0; i < dt.Rows.Count; i++) {
        //        DateTime orderDate = DateTime.Parse(dt.Rows[i]["OrderDate"].ToString());
        //        float OrderTotal = float.Parse(dt.Rows[i]["CalculatedValue"].ToString());
        //        DrawText(orderDate.ToString("HH:mm:ss").PadRight(24) + String.Format("{0,8:N2}", OrderTotal));
        //    }
        //    NewLine();
        //}

        private async Task DrawReportCategoryTotals()
        {

            DrawText(centeredString("CATEGORY TOTALS"));
            DrawDoubleLine();

            //DataTable dt =  BSLayer.Instance.GetDataTable("Select * from ReportEntityTotals where SessionIID = '" + session.SessionIID + "'  order by displayorder");
            //  DataTable dt =  BSLayer.Instance.GetReportEntityTotals(session.IID);

            List<Category> categories = await repoOrder.GetCategoryTotalsForSession(session.IID);

            //for (int i = 0; i < dt.Rows.Count; i++) {
            //    string EntityName = dt.Rows[i]["EntityName"].ToString().Trim();
            //    EntityName = EntityName.Length > max_numberOfCharacters-9 ? EntityName.Substring(0, max_numberOfCharacters-9) : EntityName;
            //    float entityTotal = float.Parse(dt.Rows[i]["EntityTotal"].ToString());

            //    DrawText(EntityName.PadRight(max_numberOfCharacters-9) + string.Format("{0,8:N2}", entityTotal));
            //}
            foreach (var category in categories)
            {
                string CategoryName = category.CategoryName.Length > max_numberOfCharacters - 9 ? category.CategoryName.Substring(0, max_numberOfCharacters - 9) : category.CategoryName;
                //float entityTotal = float.Parse(dt.Rows[i]["EntityTotal"].ToString());

                DrawText(CategoryName.PadRight(max_numberOfCharacters - 9) + string.Format("{0,8:N2}", category.CategoryTotal));
            }
            NewLine();
        }

        private void DrawReportCategoricEntityButtonTotals()
        {
            DrawText(centeredString("DETAILED CATEGORY TOTALS"));
            DrawDoubleLine();

            //DataTable dt =  BSLayer.Instance.GetDataTable("Select * from ReportEntityTotals where SessionIID = '" + session.SessionIID + "'  order by displayorder");
            DataTable dt = BSLayer.Instance.GetReportEntityTotals(session.IID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Write Entity Header
                string EntityIID = dt.Rows[i]["EntityIID"].ToString();
                string EntityName = dt.Rows[i]["EntityName"].ToString().TrimStart();
                EntityName = EntityName.Length > max_numberOfCharacters - 9 ? EntityName.Substring(0, max_numberOfCharacters - 9) : EntityName;
                float entityTotal = float.Parse(dt.Rows[i]["EntityTotal"].ToString());

                DrawText(EntityName.PadRight(max_numberOfCharacters - 9) + string.Format("{0,8:N2}", entityTotal));
                DrawLine();

                //Write Entity Button Distributions
                //DataTable dteb =  BSLayer.Instance.GetDataTable("Select * from ReportEntityEBTotals where EntityIID = '" + EntityIID + "' and SessionIID = '" + session.SessionIID + "' order by ItemText asc");

                DataTable dteb = BSLayer.Instance.GetReportEntityEBTotals(session.IID, EntityIID);
                for (int x = 0; x < dteb.Rows.Count; x++)
                {
                    string ItemText = dteb.Rows[x]["ItemText"].ToString().Trim();
                    ItemText = ItemText.Length > max_numberOfCharacters - 13 ? ItemText.Substring(0, max_numberOfCharacters - 13) : ItemText;
                    float ebTotal = float.Parse(dteb.Rows[x]["total"].ToString());
                    int quantity = int.Parse(dteb.Rows[x]["SumOfQuantity"].ToString());

                    DrawText(string.Format("{0,3:n0}", quantity).PadRight(4) +
                        ItemText.PadRight(max_numberOfCharacters - 13) + String.Format("{0,8:N2}", ebTotal));
                }
                NewLine();
            }
            NewLine();
        }



    }




}

