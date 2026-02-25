using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTRMNS;
using DronaxLibrary;
using DronaxLibrary.Forms;
using System.IO;

using DronaxLibrary.DBSpace;

namespace DTRMSimpleBackOffice {
    public partial class frmDatabaseVisualiser : Form {
        private DTRMSimpleBusiness bslayer;
        private DatabaseBackup backup;
        private BackupNode rootNode;
        private DatabaseBackupOptions options;

        private DatabaseBackup importedBackup;

        private bool blnArchiveMode;

        //private frmSimpleProgress frmProg;

        public delegate BackupNode AddBackupNodeDelegate(BackupNode parent, BackupNodeTypes NodeType, Object RelatedObject, string txt, int imgIndex, bool blnExpand);

        public frmDatabaseVisualiser(DTRMSimpleBusiness bslayer) {
            InitializeComponent();
            this.bslayer = bslayer;
            //options = new DatabaseBackupOptions();
        }

        private void FrmDatabaseVisualiser_Load(object sender, EventArgs e) {
            BtnReload_Click(null, null);
        }

        #region Load TREEVIEW FROM XML FUNCTIONS
        public void LoadTreeFromXML() {
            try {
                
                int progress = 0;
                BackupNode ndLevel1;

                if (importedBackup.customerList != null) { //Load Customers
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.CustomerHeaderNode, null, "Customer List", 1, false });
                    bgXMLLoader.ReportProgress(progress++);
                    progress = LoadCustomerNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.userList != null) { //Load Users                   
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.UserHeaderNode, null, "User List", 2, false });
                    progress = LoadUserNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.printerList != null) { //Load Printer List                   
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.PrinterHeaderNode, null, "Printer List", 4, false });
                    progress = LoadPrinterNodesFromXML(ndLevel1, true, progress);
                }


                //Load Luv
                if (importedBackup.luv != null) {
                    Luv luv = importedBackup.luv;
                    treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.LuvNode, luv, "LUV = " + luv.ShopName + "  (" + luv.CurrentSessionIID + " ==> " + luv.SessionStartDateTime.ToString() + ") ", 6, false });
                    bgXMLLoader.ReportProgress(progress++);
                }

                //Load Current Session Data
                if (importedBackup.currentSession != null) {
                    SessionData currentSession = importedBackup.currentSession;
                    treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.SessionNode, currentSession, "SESSION DATA = (" + currentSession.SessionStartDateTime.ToString() + ")==> (" + currentSession.SessionIID + ")", 7, false });
                    bgXMLLoader.ReportProgress(progress++);
                }
               

                if (importedBackup.tableGroupList != null) { //Load Table Layout                    
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.TableHeaderNode, null, "Table Groups", 8, false });
                    progress = LoadTableGroupNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.menuList != null) { //Load All the Menus
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.MenuHeaderNode, null, "Menu List", 10, false });
                    progress = LoadMenuNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.stockManager != null) {  //Load Stock Manager
                    bgXMLLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.StockManagerNode, null, "Stock Manager", 14, false });
                    progress = LoadSupplierNodesFromXML(ndLevel1, true, true, progress);
                }

                //////17 18   19 20   21 22
                if (importedBackup.orderList !=null) {
                    bgXMLLoader.ReportProgress(progress++);
                    float total = 0;
                    foreach (Order order in importedBackup.orderList) 
                        total += order.GetTotal();
                    
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.OrderHeaderNode, null, "Orders (" + total.ToString("c2") + ")", 17, false });
                    progress = LoadOrderNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.xorderList != null) {
                    bgXMLLoader.ReportProgress(progress++);
                    float total = 0;
                    foreach (Order xorder in importedBackup.xorderList)
                        total += xorder.GetTotal();
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.XOrderHeaderNode, null, "X-Orders  (" + total.ToString("c2") + ")", 19, false });
                    progress = LoadXOrderNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.kitchenOrderList != null) {
                    bgXMLLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.KOrderHeaderNode, null, "Kitchen Orders", 21, false });
                    progress = LoadKitchenOrderNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.debugList != null) {
                    bgXMLLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.DebugHeaderNode, null, "Debug Information", 23, false });
                    progress = LoadDebugNodesFromXML(ndLevel1, true, progress);
                }

                if (importedBackup.imageList != null) {
                    bgXMLLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.ImageHeaderNode, null, "Image Library", 24, false });
                    progress = LoadImageNodesFromXML(ndLevel1, true, progress);
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public int LoadCustomerNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (Customer customer in importedBackup.customerList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.CustomerNode, customer.IID, customer.CName + (bslayer.config.DebugMode ? " IID =" + customer.IID : ""), 1, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadUserNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();            
            foreach (User usr in importedBackup.userList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.UserNode, usr.IID, usr.UserName + (bslayer.config.DebugMode ? " IID =" + usr.IID : ""), 3, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadPrinterNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (ApplicationPrinter printer in importedBackup.printerList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.ApplicationPrinterNode, printer.IID, printer.ApplicationName + (bslayer.config.DebugMode ? " IID =" + printer.IID : ""), 4, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadTableGroupNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (TableGroup tg in importedBackup.tableGroupList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.TableGroupNode, tg.IID, tg.GroupName + (bslayer.config.DebugMode ? " IID =" + tg.IID : ""), 8, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);

                foreach (Table table in importedBackup.tableList) {
                    if (table.GroupIID == tg.IID) {
                        treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { ndLevel2, BackupNodeTypes.TableNode, table.IID, table.TableName + (bslayer.config.DebugMode ? " IID =" + table.IID : ""), 9, false });
                        if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
                    }
                }                
            }
            return progress;
        }
        public int LoadMenuNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (FMenu menu in importedBackup.menuList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.MenuNode, menu.IID, menu.MenuName + (bslayer.config.DebugMode ? " IID =" + menu.IID : ""), 10, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
                //progress = LoadMenuItemNodes(ndLevel2, blnReportProgress, progress);

                //Load Entity List
                foreach (Entity entity in menu.items) {
                    BackupNode ndLevel3 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { ndLevel2, BackupNodeTypes.EntityNode, entity.IID, "Category : " + entity.EntityName + (bslayer.config.DebugMode ? " IID =" + entity.IID : ""), 11, false });
                    if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);

                    foreach (EntityButton eb in entity.Buttons) {
                        treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                                           new object[] { ndLevel3, BackupNodeTypes.EntityButtonNode, eb.IID, eb.EntityButtonName + (bslayer.config.DebugMode ? " IID =" + eb.IID : ""), 12, false });
                        if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
                    }
                }

                //Load Distributions
                foreach (Distribution distribution in menu.Distributions) {
                    treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                   new object[] { ndLevel2, BackupNodeTypes.DistributionNode, distribution.IID, "Distribution : " + distribution.DistributionName + (bslayer.config.DebugMode ? " IID =" + distribution.IID : ""), 13, false });
                    if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
                }

            }
            if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);

            return progress;
        }
        public int LoadSupplierNodesFromXML(BackupNode parentNode, bool blnLoadStockItems = true, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (Supplier supplier in importedBackup.stockManager.Suppliers) {

                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.SupplierNode, supplier.IID, "Supplier : " + supplier.SupplierName + (bslayer.config.DebugMode ? " IID =" + supplier.IID : ""), 15, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
                
                if (blnLoadStockItems) {
                    foreach (StockItem stockitem in importedBackup.stockManager.StockItems) {
                        if (stockitem.SupplierIID == supplier.IID) {
                            treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                                new object[] { ndLevel2, BackupNodeTypes.StockItemNode, stockitem.IID, stockitem.StockName + (bslayer.config.DebugMode ? " IID =" + stockitem.IID : ""), 16, false });
                            if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
                        }
                    }
                }
            }

            return progress;
        }
        public int LoadOrderNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (Order order in importedBackup.orderList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                   new object[] { parentNode, BackupNodeTypes.OrderNode, order.IID, order.GetTotal().ToString("c2") + "  =  " + order.OrderDate.ToString()+ (bslayer.config.DebugMode ? " IID =" + order.IID : ""), 17, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }            
            return progress;
        }
        public int LoadXOrderNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (Order order in importedBackup.xorderList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                   new object[] { parentNode, BackupNodeTypes.XOrderNode, order.IID, order.GetTotal().ToString("c2") + "  =  " + order.OrderDate.ToString() + (bslayer.config.DebugMode ? " IID =" + order.IID : ""), 19, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadKitchenOrderNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
           
            foreach (KitchenOrder korder in importedBackup.kitchenOrderList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.KOrderNode, korder.IID, korder.CreatedDateTime.ToString() + (bslayer.config.DebugMode ? " IID =" + korder.IID : ""), 21, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }

        public int LoadDebugNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();            
            foreach (Debug debug in importedBackup.debugList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.DebugNode, debug.DebugNo, debug.EventDateTime.ToString() + " ==> " + debug.Data, 23, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadImageNodesFromXML(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            foreach (GenericImage gim in importedBackup.imageList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.ImageNode, gim.ReferenceIID, gim.ImageFileName + " ==> " + gim.ReferenceIID, 25, false });
                if (blnReportProgress) bgXMLLoader.ReportProgress(progress++);
            }
            return progress;
        }


        #endregion
        #region LOAD TREEVIEW FUNCTIONS

        public int LoadCustomerNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            DataTable dt = bslayer.db.GetDataTable("Select IID, CName from Customer order by CName");
            for (int i = 0; i < dt.Rows.Count; i++) {
                string IID = dt.Rows[i]["IID"].ToString();
                string customerName = dt.Rows[i]["CName"].ToString();
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.CustomerNode, IID, customerName + (bslayer.config.DebugMode?" IID =" + IID:""), 1, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadUserNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<User> userList = bslayer.GetUserList();
            foreach (User usr in userList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.UserNode, usr.IID, usr.UserName + (bslayer.config.DebugMode ? " IID =" + usr.IID : ""), 3, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadPrinterNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<ApplicationPrinter> printerList = bslayer.GetApplicationPrinterList();
            foreach (ApplicationPrinter printer in printerList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.ApplicationPrinterNode, printer.IID, printer.ApplicationName + (bslayer.config.DebugMode ? " IID =" + printer.IID : ""), 4, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadTableGroupNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            DataTable dtTableGroups = bslayer.GetAllTableGroups();
            for (int i = 0; i < dtTableGroups.Rows.Count; i++) {
                TableGroup tg = new TableGroup(dtTableGroups.Rows[i]);
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.TableGroupNode, tg.IID, tg.GroupName + (bslayer.config.DebugMode ? " IID =" + tg.IID : ""), 8, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);

                progress = LoadTableNodesForTableGroup(ndLevel2, blnReportProgress, progress);
            }
            return progress;
        }
        public int LoadTableNodesForTableGroup(BackupNode parentNode, bool blnReportProgress = false,int progress =0) {
            parentNode.Nodes.Clear();
            string tableGroupIID = parentNode.NodeRelatedObject.ToString();
            List<Table> tables = bslayer.GetTableList(tableGroupIID);
            foreach (Table table in tables) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.TableNode, table.IID, table.TableName + (bslayer.config.DebugMode ? " IID =" + table.IID : ""), 9, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }

            return progress;
        }

        /// <summary>
        /// Loads all the menus for menuheadernode
        /// </summary>
        /// <param name="parentNode">This must be a MenuHeaderNode</param>
        /// <param name="blnReportProgress"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public int LoadMenuNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<IIDName> menuList = bslayer.GetJustMenuIIDNameList();
            foreach (IIDName menu in menuList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.MenuNode, menu.IID, menu.Name + (bslayer.config.DebugMode ? " IID =" + menu.IID : ""), 10, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
                progress = LoadMenuItemNodes(ndLevel2, blnReportProgress, progress);
            }
            if (blnReportProgress) bgLoader.ReportProgress(progress++);

            return progress;
        }
        public int LoadMenuItemNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            string menuIID = parentNode.NodeRelatedObject.ToString();

            List<IIDName> entityList = bslayer.GetJustEntityIIDNameList(menuIID);
            foreach (IIDName entity in entityList) {
                BackupNode ndLevel3 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.EntityNode, entity.IID, "Category : " + entity.Name + (bslayer.config.DebugMode ? " IID =" + entity.IID : ""), 11, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);

                progress = LoadEntityButtonNodes(ndLevel3, blnReportProgress, progress);
            }
            List<IIDName> distributionList = bslayer.GetJustDistributionIIDNameList(menuIID);
            foreach (IIDName distribution in distributionList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.DistributionNode, distribution.IID, "Distribution : " + distribution.Name + (bslayer.config.DebugMode ? " IID =" + distribution.IID : ""), 13, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }

            return progress;
        }
        /// <summary>
        /// Loads Entity Button Nodes for Entity Node
        /// </summary>
        /// <param name="parentNode">Must be an Entity Node</param>
        /// <param name="blnReportProgress"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public int LoadEntityButtonNodes(BackupNode parentNode, bool blnReportProgress = false, int progress =0) {
            parentNode.Nodes.Clear();
            string entityIID = parentNode.NodeRelatedObject.ToString();
            List<IIDName> entityButtonList = bslayer.GetJustEntityButtonIIDNameList(entityIID);
            foreach (IIDName eb in entityButtonList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.EntityButtonNode, eb.IID, eb.Name + (bslayer.config.DebugMode ? " IID =" + eb.IID : ""), 12, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }
        /// <summary>
        /// Loads the suppliers and StockItemNodes if required
        /// </summary>
        /// <param name="parentNode">StockManagerNode</param>
        /// <param name="blnLoadStockItems">Indicate to load sub stockitems for this supplier</param>
        /// <param name="blnReportProgress"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public int LoadSupplierNodes(BackupNode parentNode, bool blnLoadStockItems = true, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<IIDName> supplierList = bslayer.GetJustSupplierIIDNameList();
            foreach (IIDName supplier in supplierList) {

                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.SupplierNode, supplier.IID, "Supplier : " + supplier.Name + (bslayer.config.DebugMode ? " IID =" +supplier.IID : ""), 15, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);

                if (blnLoadStockItems)
                    progress = LoadStockItemNodesForSupplierNode(ndLevel2, blnReportProgress, progress);
            }

            return progress;
        }
        /// <summary>
        /// Loads the supplier StockItem Nodes
        /// </summary>
        /// <param name="parentNode">Basically Supplier Node</param>
        /// <param name="blnReportProgress"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public int LoadStockItemNodesForSupplierNode(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            string supplierIID = parentNode.NodeRelatedObject.ToString();
            List<IIDName> stockItemList = bslayer.GetJustStockItemIIDNameList(supplierIID);
            foreach (IIDName stockitem in stockItemList) {
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.StockItemNode, stockitem.IID, stockitem.Name + (bslayer.config.DebugMode ? " IID =" + stockitem.IID : ""), 16, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }
        public int LoadOrderNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<IIDValueDate> orderList = bslayer.GetOrdersIIDValueDateList();
            foreach (IIDValueDate item in orderList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.OrderNode, item.IID, item.Value.ToString("c2") + "  =  " + item.Date.ToString()  + (bslayer.config.DebugMode ? " IID =" + item.IID : ""), 17, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
                //progress = LoadOrderItemNodes(ndLevel2, blnReportProgress, progress);
            }            
            return progress;
        }
        public int LoadXOrderNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<IIDValueDate> orderList = bslayer.GetXOrdersIIDValueDateList();
            foreach (IIDValueDate item in orderList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.XOrderNode, item.IID, item.Value.ToString("c2") + "  =  " + item.Date.ToString() + (bslayer.config.DebugMode ? " IID =" + item.IID : ""), 19, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
                //progress = LoadXOrderItemNodes(ndLevel2, blnReportProgress, progress);
            }
            return progress;
        }
        public int LoadKitchenOrderNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<IIDDate> orderList = bslayer.GetKitchenOrdersIIDDateList();
            foreach (IIDDate item in orderList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.KOrderNode, item.IID, item.Date.ToString() + (bslayer.config.DebugMode ? " IID =" + item.IID : ""), 21, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
                //progress = LoadKitchenOrderItemNodes(ndLevel2, blnReportProgress, progress);
            }
            return progress;
        }

        public int LoadDebugNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<Debug> debugList = bslayer.GetDebugList();
            foreach (Debug item in debugList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.DebugNode, item.DebugNo, item.EventDateTime.ToString() + " ==> "+ item.Data, 23, false });
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }

        public int LoadImageNodes(BackupNode parentNode, bool blnReportProgress = false, int progress = 0) {
            parentNode.Nodes.Clear();
            List<GenericImage> imageList = bslayer.GetImageLibraryList();  
            foreach (GenericImage gim in imageList) {
                BackupNode ndLevel2 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { parentNode, BackupNodeTypes.ImageNode, gim.ReferenceIID, gim.ImageFileName.Replace(".png",""), 25, false });
                ndLevel2.Image = ResizeImage(gim.DisplayImage, new Size(32, 32)); 
                if (blnReportProgress) bgLoader.ReportProgress(progress++);
            }
            return progress;
        }

        // C#
        public Image ResizeImage(Image image, Size size,
            bool preserveAspectRatio = true) {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio) {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            } else {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage)) {
                graphicsHandle.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        public void LoadTreeFromDatabase() {
            try {
                
                int progress = 0;
                BackupNode ndLevel1;

                if (chkCustomers.Checked) { //Load Customers
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.CustomerHeaderNode, null, "Customer List", 1, false });
                    bgLoader.ReportProgress(progress++);
                    progress = LoadCustomerNodes(ndLevel1, true,progress);
                }

                if (chkUsers.Checked) { //Load Users                   
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.UserHeaderNode, null, "User List", 2, false });
                    progress = LoadUserNodes(ndLevel1, true, progress);
                }

                if (chkPrinters.Checked) { //Load Printer List                   
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.PrinterHeaderNode, null, "Printer List", 4, false });
                    progress = LoadPrinterNodes(ndLevel1, true, progress);
                }


                //Load Global Settings
                Luv luv = bslayer.GetLuv();
                treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                    new object[] { rootNode, BackupNodeTypes.LuvNode, luv, "LUV = " + luv.ShopName + "  (" + luv.CurrentSessionIID + " ==> " + luv.SessionStartDateTime.ToString() + ") ", 6, false });

                DataTable dtSessions = bslayer.db.GetDataTable("Select * from Sessions");
                for (int i = 0; i < dtSessions.Rows.Count; i++) {
                    SessionData sesData = new SessionData(dtSessions.Rows[i]);
                    treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.SessionNode, sesData, "SESSION DATA = (" + sesData.SessionStartDateTime.ToString() + ")==> (" +  sesData.SessionIID + ")", 7, false });
                    bgLoader.ReportProgress(progress++);
                }

                if (chkTables.Checked) { //Load Table Layout                    
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.TableHeaderNode, null, "Table Groups", 8, false });
                    progress = LoadTableGroupNodes(ndLevel1, true, progress);
                }

                if (chkMenus.Checked) { //Load All the Menus
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.MenuHeaderNode, null, "Menu List", 10, false });
                    progress = LoadMenuNodes(ndLevel1, true, progress);
                }

                if (chkStock.Checked) {  //Load Stock Manager
                    bgLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                        new object[] { rootNode, BackupNodeTypes.StockManagerNode, null, "Stock Manager", 14, false });
                    progress = LoadSupplierNodes(ndLevel1,true, true, progress);                   
                }

                //17 18   19 20   21 22
                if (chkOrders.Checked) {
                    bgLoader.ReportProgress(progress++);
                    float total = bslayer.GetOrdersTotal();
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.OrderHeaderNode, null, "Orders (" + total.ToString("c2") + ")", 17, false });
                    progress = LoadOrderNodes(ndLevel1, true, progress);
                }

                if (chkXOrders.Checked) {
                    bgLoader.ReportProgress(progress++);
                    float total = bslayer.GetXOrdersTotal();
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.XOrderHeaderNode, null, "X-Orders  (" + total.ToString("c2") + ")", 19, false });
                    progress = LoadXOrderNodes(ndLevel1, true, progress);
                }

                if (chkKitchenOrders.Checked) {
                    bgLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.KOrderHeaderNode, null, "Kitchen Orders", 21, false });
                    progress = LoadKitchenOrderNodes(ndLevel1, true, progress);
                }

                if (chkDebug.Checked) {
                    bgLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.DebugHeaderNode, null, "Debug Information", 23, false });
                    progress = LoadDebugNodes(ndLevel1, true, progress);
                }

                if (chkImages.Checked) {
                    bgLoader.ReportProgress(progress++);
                    ndLevel1 = (BackupNode)treeAdv.Invoke(new AddBackupNodeDelegate(AddBackupNode),
                       new object[] { rootNode, BackupNodeTypes.ImageHeaderNode, null, "Image Library", 24, false });                    
                    progress = LoadImageNodes(ndLevel1, true, progress);
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public BackupNode AddBackupNode(BackupNode parent, BackupNodeTypes NodeType, Object RelatedObject, string txt, int imgIndex, bool blnExpand) {
            BackupNode nd = new BackupNode(NodeType, RelatedObject, txt, imgIndex);
            parent.Nodes.Add(nd);
            if (blnExpand)
                nd.Expand();
            return nd;
        }
        private void BgLoader_DoWork(object sender, DoWorkEventArgs e) {
            LoadTreeFromDatabase();
        }
        private void BgLoader_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            //if (frmProg == null) {
            //    frmProg = new frmSimpleProgress(ref bgLoader);
            //    frmProg.Show();
                
            //}
            if (e.ProgressPercentage > pBar.Maximum)
                pBar.Maximum += 100;
            pBar.Value = e.ProgressPercentage;
            //try {
            //    if (frmProg != null) {
            //        frmProg.ChangeMaximum(pBar.Maximum);
            //        frmProg.SetValue(e.ProgressPercentage);
            //    }
            //} catch(Exception ex) {
            //    MessageBox.Show("Error " + ex.Message);
            //}
        }
        private void BgLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            pBar.Value = 0;
            pBar.Visible = false;
            barMenu.Enabled = pnlOptions.Enabled = treeAdv.Enabled = true;
            //try {
            //    frmProg.Close();
            //    frmProg = null;
            //} catch (Exception ex) {
            //    MessageBox.Show("Error " + ex.Message);
            //}
        }
        #endregion

        #region OTHER FUNCTIONS
        public int GetDatabaseItemCount() {
            int total = 0;

            if (chkCustomers.Checked) total += bslayer.GetIIDCount("Customer");
            if (chkUsers.Checked) total += bslayer.GetIIDCount("Users");
            if (chkPrinters.Checked) total += bslayer.GetIIDCount("ApplicationPrinter");

            total++;  //Luv
            total += bslayer.GetIIDCount("Sessions");
            if (chkTables.Checked) {
                total += bslayer.GetIIDCount("TableGroup");
                total += bslayer.GetIIDCount("Tables");
            }
            if (chkMenus.Checked) {
                total += bslayer.GetIIDCount("Menu");
                total += bslayer.GetIIDCount("Entity");
                total += bslayer.GetIIDCount("EntityButton");
                total += bslayer.GetIIDCount("Distribution");
            }

            if (chkStock.Checked) {
                total += bslayer.GetIIDCount("Supplier");
                total += bslayer.GetIIDCount("StockItem");
            }
            return total;
        }
        #endregion

        #region BACKUP FUNCTIONS        
        public void GenerateBackup() {
            int progress = 0;
            backup = new DatabaseBackup();

            if (options.blnCustomers) {
                //Load Customers
                DataTable dtCustomers = bslayer.GetAllCustomers();
                bgBackup.ReportProgress(progress++);
                for (int i = 0; i < dtCustomers.Rows.Count; i++) {
                    Customer customer = new Customer(dtCustomers.Rows[i]);
                    backup.customerList.Add(customer);
                    bgBackup.ReportProgress(progress++);
                }
            }

            if (options.blnUsers) {
                //Load Users
                backup.userList = bslayer.GetUserList();
                bgBackup.ReportProgress(progress++);
            }

            if (options.blnPrinters) {
                //Load Printer List
                backup.printerList = bslayer.GetApplicationPrinterList();
                bgBackup.ReportProgress(progress++);
            }

            //Load Global Settings
            backup.luv = bslayer.GetLuv();

            DataTable dtCurrentSession = bslayer.db.GetDataTable("Select * from Sessions where IID = '" + bslayer.luv.CurrentSessionIID + "'");
            backup.currentSession = new SessionData(dtCurrentSession);
            bgBackup.ReportProgress(progress++);
            
            if (options.blnTables) {
                //Load Table Layout
                DataTable dtTableGroups = bslayer.GetAllTableGroups();
                for (int i = 0; i < dtTableGroups.Rows.Count; i++) {
                    TableGroup tg = new TableGroup(dtTableGroups.Rows[i]);
                    backup.tableGroupList.Add(tg);
                    bgBackup.ReportProgress(progress++);
                    List<Table> groupTables = bslayer.GetTableList(tg.IID);
                    bgBackup.ReportProgress(progress++);
                }

                DataTable dtTables = bslayer.GetAllTables();
                for (int i = 0; i < dtTables.Rows.Count; i++) {
                    Table table = new Table(dtTables.Rows[i]);
                    backup.tableList.Add(table);
                    bgBackup.ReportProgress(progress++);
                }

            }

            if (options.blnMenus) {
                //Load All the Menus
                backup.menuList = bslayer.GetAllMenuList(new GenericProgressFunction(BgBackup_ProgressChanged), progress);
                //bgBackup_ProgressChanged,progress);
                foreach (FMenu menu in backup.menuList) {
                    bgBackup.ReportProgress(progress++);
                    foreach (Entity entity in menu.items) {
                        bgBackup.ReportProgress(progress++);
                        foreach (EntityButton eb in entity.Buttons) {
                            bgBackup.ReportProgress(progress++);
                        }
                    }

                    foreach (Distribution distribution in menu.Distributions) {
                        bgBackup.ReportProgress(progress++);
                    }
                }
                bgBackup.ReportProgress(progress++);
            }

            if (options.blnStock) {
                //Load Stock Manager
                backup.stockManager = bslayer.GetStockManager(new GenericProgressFunction(BgBackup_ProgressChanged), progress);
                bgBackup.ReportProgress(progress++);

                foreach (Supplier supplier in backup.stockManager.Suppliers) {
                    bgBackup.ReportProgress(progress++);
                    foreach (StockItem item in backup.stockManager.StockItems) {
                        bgBackup.ReportProgress(progress++);
                    }
                }
            }
            //Load Orders
            if (options.blnOrders) {
                backup.orderList = bslayer.GetOrderList();
                bgBackup.ReportProgress((progress += backup.orderList.Count));
            }

            //Load XOrders
            if (options.blnXOrders) { 
                backup.xorderList = bslayer.GetXOrderList();
                bgBackup.ReportProgress((progress += backup.xorderList.Count));
            }

            //Load Kitchen Orders
            if (options.blnKitchenOrders) { 
                backup.kitchenOrderList = bslayer.GetKitchenOrderList();
                bgBackup.ReportProgress((progress += backup.kitchenOrderList.Count));
            }

            //Load Debug Information
            if (options.blnDebugInformation) { 
                backup.debugList = bslayer.GetDebugList();
                bgBackup.ReportProgress((progress += backup.debugList.Count));
            }

            //Load Images
            if (options.blnImages) {
                backup.imageList = bslayer.GetImageLibraryList();
                bgBackup.ReportProgress((progress += backup.imageList.Count));
            }

        }
        private void BgBackup_DoWork(object sender, DoWorkEventArgs e) {
            GenerateBackup();
        }
        private void BgBackup_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > pBar.Maximum)
                pBar.Maximum += 100;

            if (pBar.InvokeRequired) {
                pBar.Invoke(new Action(delegate () {
                    //execute any code that modifies the UI in here...
                    pBar.Value = e.ProgressPercentage;
                }));
            }

            pBar.Value = e.ProgressPercentage;
            Cursor.Current = Cursors.WaitCursor;
        }
        private void BgBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            pBar.Value = 0;
            pBar.Visible = false;

            barMenu.Enabled = pnlOptions.Enabled = true;

            using (SaveFileDialog sfd = new SaveFileDialog {
                Filter = "DTRM files (*.xml)|",
                FileName = "DTRMSimple Database Backup"
            }) {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    if (sfd.FileName != null && sfd.FileName != "") {

                        if (DRFile.XmlSerialize(sfd.FileName + ".xml", backup, typeof(DatabaseBackup), false))
                            MessageBox.Show("Database Backup saved");
                        else
                            MessageBox.Show("Database Backup cannot be saved");
                    }
                } else
                    MessageBox.Show("Database Backup Aborted");
            }
            Cursor.Current = Cursors.Arrow;
        }
        #endregion


        #region NODE FUNCTIONS
        private void TreeAdv_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e) {
            if (!blnArchiveMode)
              EditNode((BackupNode)e.Node);
        }
        private void EditNode(BackupNode nd) {
            if (blnArchiveMode)
                return;
                // BackupNode nd = (BackupNode)e.Node;

                switch (nd.NodeType) {
                case BackupNodeTypes.UnknownNode:
                case BackupNodeTypes.RootNode:
                case BackupNodeTypes.HeaderNode:
                case BackupNodeTypes.CustomerHeaderNode:
                    break;
                case BackupNodeTypes.CustomerNode:
                    using (frmCustomer frmcust = new frmCustomer(bslayer, bslayer.GetCustomer(nd.NodeRelatedObject.ToString()))) {
                        if (frmcust.ShowDialog() == DialogResult.OK)
                            nd.Text = frmcust.customer.CName;
                    }
                    break;
                case BackupNodeTypes.UserHeaderNode:
                    break;
                case BackupNodeTypes.UserNode:
                    using (frmSingleUser frmuser = new frmSingleUser(bslayer, bslayer.GetUser(nd.NodeRelatedObject.ToString()))) {                        
                        if (frmuser.ShowDialog() == DialogResult.OK)
                            nd.Text = frmuser.user.UserName;
                    }
                    break;
                case BackupNodeTypes.PrinterHeaderNode:
                    break;
                case BackupNodeTypes.ApplicationPrinterNode:
                    ApplicationPrinter ap = bslayer.GetPrinter(nd.NodeRelatedObject.ToString());
                    if (ap == null)
                        break;
                    using (frmSinglePrinter frmprinter = new frmSinglePrinter(bslayer, ap)) {
                        if (frmprinter.ShowDialog() == DialogResult.OK)
                            nd.Text = frmprinter.ap.ApplicationName;
                    }
                    break;
                case BackupNodeTypes.TableHeaderNode:
                    break;
                case BackupNodeTypes.TableGroupNode:
                    using (frmTableGroup frmgroup = new frmTableGroup(bslayer, bslayer.GetTableGroup(nd.NodeRelatedObject.ToString()))) {
                        if (frmgroup.ShowDialog() == DialogResult.OK)
                            nd.Text = frmgroup.group.GroupName;
                    }
                    break;
                case BackupNodeTypes.TableNode:
                    using (frmTable frmtable = new frmTable(bslayer, bslayer.GetTable(nd.NodeRelatedObject.ToString()))) {
                        if (frmtable.ShowDialog() == DialogResult.OK)
                            nd.Text = frmtable.table.TableName;
                    }
                    break;
                case BackupNodeTypes.MenuHeaderNode:
                    break;
                case BackupNodeTypes.MenuNode:
                    using (frmInputForm frmmenuname = new frmInputForm(nd.Text)) {
                        if (frmmenuname.ShowDialog() == DialogResult.OK) {
                            if (bslayer.SaveMenu(nd.NodeRelatedObject.ToString(), frmmenuname.InputValue))
                                nd.Text = frmmenuname.InputValue;
                        }
                    }
                    break;
                case BackupNodeTypes.EntityNode:
                    using (frmEntityEditor frmentity = new frmEntityEditor(bslayer, bslayer.GetEntityDB(nd.NodeRelatedObject.ToString()))) {
                        if (frmentity.ShowDialog() == DialogResult.OK) {
                            nd.Text = frmentity.en.EntityName;
                        }
                    }
                    break;
                case BackupNodeTypes.EntityButtonNode:
                    EntityButton eb = bslayer.GetJustEntityButton(nd.NodeRelatedObject.ToString());
                    using (FrmEntityButtonsEditor frmeb = new FrmEntityButtonsEditor(bslayer, eb)) {
                        if (frmeb.ShowDialog() == DialogResult.OK)
                            nd.Text = frmeb.entityButton.EntityButtonName;
                    }
                    break;
                case BackupNodeTypes.DistributionNode:
                    using (frmDistribution frmdist = new frmDistribution(bslayer, bslayer.GetDistribution(nd.NodeRelatedObject.ToString()))) {
                        if (frmdist.ShowDialog() == DialogResult.OK)
                            nd.Text = frmdist.distributionType.DistributionName;
                    }
                    break;
                case BackupNodeTypes.StockManagerNode:
                    break;
                case BackupNodeTypes.SupplierNode:
                    using (frmSupplier frmsup = new frmSupplier(bslayer, bslayer.GetSupplier(nd.NodeRelatedObject.ToString()))) {
                        if (frmsup.ShowDialog() == DialogResult.OK)
                            nd.Text = frmsup.supplier.SupplierName;
                    }
                    break;
                case BackupNodeTypes.StockItemNode:
                    using (frmStockItem frmstockitem = new frmStockItem(bslayer, bslayer.GetStockItem(nd.NodeRelatedObject.ToString()))) {
                        if (frmstockitem.ShowDialog() == DialogResult.OK)
                            nd.Text = frmstockitem.stockItem.StockName;
                    }
                    break;
                case BackupNodeTypes.ImageHeaderNode:
                    break;
                case BackupNodeTypes.ImageNode:
                    using (frmImageDialog frmimg = new frmImageDialog(bslayer.GetGenericImage(nd.NodeRelatedObject.ToString()).DisplayImage) {
                        MdiParent = this.MdiParent
                    }) {
                        frmimg.Show();
                    }
                    break;
                default:
                    break;

            }
        }
        private void TreeAdv_BeforeNodeDrop(object sender, DevComponents.AdvTree.TreeDragDropEventArgs e) {
            if (blnArchiveMode)
                e.Cancel = true;
            BackupNode node = (BackupNode)e.Node;
            BackupNode previousParentNode = (BackupNode)e.OldParentNode;
            BackupNode parentNode = (BackupNode)e.NewParentNode;

            if (previousParentNode == parentNode) {
                //Just reorder otherwise it is a movement
                if (node.NodeType == BackupNodeTypes.EntityNode) {
                    Entity entity = bslayer.GetEntityDB(node.NodeRelatedObject.ToString());
                    entity.DisplayOrder = e.InsertPosition;
                    bslayer.SaveEntityDB(entity);
                } else if (node.NodeType == BackupNodeTypes.EntityButtonNode) {
                    EntityButton eb = bslayer.GetJustEntityButton(node.NodeRelatedObject.ToString());
                    eb.DisplayOrder = e.InsertPosition;
                    bslayer.SaveJustEntityButton(eb, eb.ParentMenuIID);
                } else
                    e.Cancel = true;
            } else if (node.NodeType == BackupNodeTypes.StockItemNode && parentNode.NodeType == BackupNodeTypes.SupplierNode) {
                if (bslayer.MoveStockItemToAnotherSupplier(node.NodeRelatedObject.ToString(), parentNode.NodeRelatedObject.ToString()))
                    MessageBox.Show("StockItem moved to Supplier");
            } else if (node.NodeType == BackupNodeTypes.EntityButtonNode && parentNode.NodeType == BackupNodeTypes.EntityNode) {
                if (bslayer.MoveEntityButtonToAnotherEntity(node.NodeRelatedObject.ToString(), parentNode.NodeRelatedObject.ToString()))
                    MessageBox.Show("EntityButton  moved to Entity");
            } else if (node.NodeType == BackupNodeTypes.TableNode && parentNode.NodeType == BackupNodeTypes.TableGroupNode) {
                if (bslayer.MoveTableToAnotherTableGroup(node.NodeRelatedObject.ToString(), parentNode.NodeRelatedObject.ToString())) {
                    MessageBox.Show("Table moved to TableGroup");
                }
            } else
                e.Cancel = true;
        }
        private void TreeAdv_AfterNodeDrop(object sender, DevComponents.AdvTree.TreeDragDropEventArgs e) {
            if (blnArchiveMode)
                e.Cancel = true;

            BackupNode node = (BackupNode)e.Node;
            BackupNode previousParentNode = (BackupNode)e.OldParentNode;
            BackupNode parentNode = (BackupNode)e.NewParentNode;
            int count = 0;
            if (previousParentNode == parentNode) {
                //Just reorder otherwise it is a movement
                if (node.NodeType == BackupNodeTypes.EntityNode) {
                    foreach (BackupNode nd in parentNode.Nodes) {
                        if (nd.NodeType == BackupNodeTypes.EntityNode) {
                            Entity entity = bslayer.GetJustEntity(nd.NodeRelatedObject.ToString());
                            entity.DisplayOrder = count++;
                            bslayer.SaveJustEntity(entity);

                        }
                    }
                } else if (node.NodeType == BackupNodeTypes.EntityButtonNode) {
                    //Now do reordering based on nodes order
                    foreach (BackupNode nd in parentNode.Nodes) {
                        if (nd.NodeType == BackupNodeTypes.EntityButtonNode) {
                            EntityButton eb = bslayer.GetJustEntityButton(nd.NodeRelatedObject.ToString());
                            eb.DisplayOrder = count++;
                            bslayer.SaveJustEntityButton(eb, eb.ParentMenuIID);
                        }
                    }
                } else
                    e.Cancel = true;
            }
        }
        #endregion

        #region MENU BAR FUNCTIONS
        private void BtnReload_Click(object sender, EventArgs e) {
            SwitchMode(true);
            pBar.Visible = true;
            pBar.Maximum = GetDatabaseItemCount();
            treeAdv.Nodes.Clear();
            treeAdv.Columns.Clear();
            rootNode = new BackupNode(BackupNodeTypes.RootNode, null, "Database", 0);
            rootNode.Expand();
            treeAdv.Nodes.Add(rootNode);

            barMenu.Enabled = pnlOptions.Enabled = treeAdv.Enabled =  false;
            bgLoader.RunWorkerAsync();
        }
        private void BtnEdit_Click(object sender, EventArgs e) {
            if (blnArchiveMode)
                return;
            if (treeAdv.SelectedNode != null)
                EditNode((BackupNode)treeAdv.SelectedNode);
        }
        private void BtnBackup_Click(object sender, EventArgs e) {
            if (blnArchiveMode)
                return;
            using (frmBackupOptions frm = new frmBackupOptions()) {
                if (frm.ShowDialog() == DialogResult.OK) {
                    this.options = frm.options;
                    if (MessageBox.Show("This might take a long time. Do you want to continue?", "Database Backup", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                        barMenu.Enabled = pnlOptions.Enabled = false;
                        pBar.Maximum = GetDatabaseItemCount();
                        pBar.Visible = true;
                        bgBackup.RunWorkerAsync();
                    }
                }
            }
        }
        private void BtnExportImagesAsXML_Click(object sender, EventArgs e) {
            if (blnArchiveMode)
                return;

            List<GenericImage> imageList = new List<GenericImage>();

            try {
                DataTable dt = bslayer.db.GetDataTable("Select * from Images");
                for (int i = 0; i < dt.Rows.Count; i++) {
                    GenericImage gim = new GenericImage(dt.Rows[i], true);
                    imageList.Add(gim);
                }
            } catch {
                MessageBox.Show("There are errors during list creation.");
                return;
            }


            using (SaveFileDialog sfd = new SaveFileDialog {
                Filter = "DTRM files (*.xml)|",
                FileName = "DTRMSimple Image Repository"
            }) {
                if (sfd.ShowDialog() == DialogResult.OK) {

                    if (sfd.FileName != null && sfd.FileName != "") {

                        if (DRFile.XmlSerialize(sfd.FileName + ".xml", imageList, typeof(List<GenericImage>), false))
                            MessageBox.Show("Image List Saved");
                        else
                            MessageBox.Show("Image List failed to be saved");
                    }
                } else
                    MessageBox.Show("Image List Aborted.");

            }

        }
        private void BtnShrink_Click(object sender, EventArgs e) {
            if (blnArchiveMode)
                return;
            if (treeAdv.SelectedNodes.Count > 0) {
                BackupNode nd = (BackupNode)treeAdv.SelectedNode;
                string IID = (nd.NodeRelatedObject != null) ? nd.NodeRelatedObject.ToString() : "";
                switch (nd.NodeType) {
                    case BackupNodeTypes.UnknownNode:
                    case BackupNodeTypes.HeaderNode:
                        break;
                    case BackupNodeTypes.LuvNode:
                    case BackupNodeTypes.SessionNode:
                        MessageBox.Show("This object cannot be shrunk");
                        break;
                    case BackupNodeTypes.CustomerHeaderNode:
                        bslayer.ShrinkAllCustomers();
                        LoadCustomerNodes(nd);
                        break;
                    case BackupNodeTypes.CustomerNode:
                        bslayer.ShrinkCustomer(IID);
                        LoadCustomerNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.UserHeaderNode:
                        //MessageBox.Show("Users can only be shrunk individually");
                        bslayer.ShrinkAllUsers();
                        LoadUserNodes((BackupNode)nd);
                        break;
                    case BackupNodeTypes.UserNode:
                        bslayer.ShrinkUser(IID);
                        LoadUserNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.PrinterHeaderNode:
                        bslayer.ShrinkAllApplicationPrinters();
                        LoadPrinterNodes((BackupNode)nd);
                        break;
                    case BackupNodeTypes.ApplicationPrinterNode:
                        bslayer.ShrinkApplicationPrinter(IID);
                        LoadPrinterNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.TableHeaderNode:
                        bslayer.ShrinkAllTableGroups();
                        LoadTableGroupNodes((BackupNode)nd);
                        break;
                    case BackupNodeTypes.TableGroupNode:
                        bslayer.ShrinkTableGroup(IID);
                        LoadTableGroupNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.TableNode:
                        bslayer.ShrinkTable(IID);
                        LoadTableNodesForTableGroup((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.MenuHeaderNode:
                        bslayer.ShrinkAllMenus();
                        LoadMenuNodes((BackupNode)nd);
                        break;
                    case BackupNodeTypes.MenuNode:
                        bslayer.ShrinkMenu(IID);
                        LoadMenuNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.EntityNode:
                        bslayer.ShrinkEntity(IID);
                        LoadMenuItemNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.EntityButtonNode:
                        bslayer.ShrinkEntityButton(IID);
                        LoadEntityButtonNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.DistributionNode:
                        bslayer.ShrinkDistribution(IID);
                        LoadMenuItemNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.StockManagerNode:
                        bslayer.ShrinkStockManager();
                        LoadSupplierNodes((BackupNode)nd);
                        break;
                    case BackupNodeTypes.SupplierNode:
                        bslayer.ShrinkSupplier(IID);
                        LoadSupplierNodes((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.StockItemNode:
                        bslayer.ShrinkStockItem(IID);
                        LoadStockItemNodesForSupplierNode((BackupNode)nd.Parent);
                        break;
                    case BackupNodeTypes.RootNode:
                        bslayer.ShrinkDatabase();
                        BtnReload_Click(null, null);
                        break;
                    default:
                        break;

                }
            }
        }
        #endregion

        private void ChkALL_CheckedChanged(object sender, EventArgs e) {
            chkCustomers.Checked = chkUsers.Checked = chkPrinters.Checked = chkTables.Checked =
                chkMenus.Checked = chkStock.Checked = chkOrders.Checked =
                chkXOrders.Checked = chkKitchenOrders.Checked = chkDebug.Checked = chkImages.Checked = chkALL.Checked;
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (treeAdv.SelectedNodes.Count > 0) {
                BackupNode nd = (BackupNode)treeAdv.SelectedNode;
                string IID = (nd.NodeRelatedObject != null) ? nd.NodeRelatedObject.ToString() : "";
                switch (nd.NodeType) {                    
                    case BackupNodeTypes.CustomerNode:
                        bslayer.DeleteCustomer(IID);
                        nd.Remove();
                        break;
                    case BackupNodeTypes.UserNode:
                        bslayer.DeleteUser(IID);
                        nd.Remove();
                        break;                    
                    case BackupNodeTypes.ApplicationPrinterNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.TableGroupNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.TableNode:
                        bslayer.DeleteTable(IID);
                        nd.Remove();
                        break;                    
                    case BackupNodeTypes.MenuNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.EntityNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.EntityButtonNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.DistributionNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;                    
                    case BackupNodeTypes.SupplierNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.StockItemNode:
                        MessageBox.Show("Please use object editor to delete this item.");
                        break;
                    case BackupNodeTypes.OrderNode:
                        if (bslayer.DeleteOrder(IID)) {
                            nd.Parent.Text = "Orders (" + bslayer.GetOrdersTotal().ToString("c2") + ")";
                            //LoadOrderNodes((BackupNode)nd.Parent);
                            nd.Remove();                            
                        }
                        break;
                    case BackupNodeTypes.KOrderNode:
                        if (bslayer.DeleteKitchenOrder(IID,true))
                            nd.Remove();
                        break;                        
                    default:
                        break;

                }
            }
        }

        #region IMPORT XML FUNCTIONS
        private void BtnImportXML_Click(object sender, EventArgs e) {

            using (OpenFileDialog dlg = new OpenFileDialog {
                Filter = "XML Files|*.xml",
                Multiselect = false,
                Title = "Database Backup Import XML"
            }) {

                if (dlg.ShowDialog() == DialogResult.OK) {
                    importedBackup = null;
                    try {
                        importedBackup = (DatabaseBackup)DRFile.XmlDeSerialize(dlg.FileName, typeof(DatabaseBackup), false);

                        if (importedBackup != null) {
                            pBar.Visible = true;
                            pBar.Maximum = importedBackup.ItemCount();
                            treeAdv.Nodes.Clear();
                            treeAdv.Columns.Clear();
                            rootNode = new BackupNode(BackupNodeTypes.RootNode, null, "Database", 0);
                            rootNode.Expand();
                            treeAdv.Nodes.Add(rootNode);

                            barMenu.Enabled = pnlOptions.Enabled = treeAdv.Enabled = false;
                            SwitchMode(false);
                            bgXMLLoader.RunWorkerAsync();
                        }

                    } catch {
                        MessageBox.Show("Database Backupcannot be imported");
                        return;
                    }
                    //treeAdv.DataSource = bslayer.GetAllCustomers();
                    //bgXMLLoader.RunWorkerAsync();
                }
            }
        }

        private void BgXMLLoader_DoWork(object sender, DoWorkEventArgs e) {
            LoadTreeFromXML();
        }

        private void BgXMLLoader_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > pBar.Maximum)
                pBar.Maximum += 100;
            pBar.Value = e.ProgressPercentage;
        }

        private void BgXMLLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            pBar.Value = 0;
            pBar.Visible = false;
            barMenu.Enabled = pnlOptions.Enabled = treeAdv.Enabled = true;
            btnSaveIntoDatabase.Enabled = true;
        }
        #endregion

        private void SwitchMode(bool blnDatabase) {
            btnEdit.Enabled = btnDelete.Enabled = btnBackupDatabase.Enabled = btnShrink.Enabled = pnlOptions.Visible = blnDatabase;
            blnArchiveMode = !blnDatabase;
            if (blnDatabase) {
                treeAdv.BackColor = SystemColors.Window;
                btnSaveIntoDatabase.Enabled = false;
            } else
                treeAdv.BackColor = Color.Silver;
        }

        private void BtnRunScript_Click(object sender, EventArgs e) {
            //frmDBUserLogin frm = new frmDBUserLogin(true);
            //if (frm.ShowDialog() == DialogResult.OK) {
            //    if (frm.db != null) {
            //        DB db = frm.db;
            //        string sql = "Create Database Test1 GO ";
            //        sql += "Use Test1 GO ";
            //        sql += "CREATE TABLE ApplicationPrinter([IID][varchar](50) NOT NULL,[ApplicationName] [varchar] (50) NULL) GO";
            //        MessageBox.Show(db.RunQuery(sql).ToString());
                    
                    
            //    }
            //}
        }

        private void BtnSaveIntoDatabase_Click(object sender, EventArgs e) {
            if (!blnArchiveMode)
                return;

            using (frmBackupOptions frm = new frmBackupOptions()) {
                frm.SetCaption("OBJECTS TO SAVE INTO DATABASE");
                if (frm.ShowDialog() == DialogResult.OK) {
                    this.options = frm.options;
                    if (MessageBox.Show("This might take a long time. Do you want to continue?", "Database Data Transfer", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3) == DialogResult.Yes) {
                        barMenu.Enabled = pnlOptions.Enabled = false;
                        pBar.Maximum = importedBackup.ItemCount();
                        pBar.Visible = true;
                        bgSaveToDatabase.RunWorkerAsync();
                    }
                }
            }
        }

        private void BgSaveToDatabase_DoWork(object sender, DoWorkEventArgs e) {
            SaveXMLItemsToDatabase();
        }

        private void BgSaveToDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage > pBar.Maximum)
                pBar.Maximum += 100;

            if (pBar.InvokeRequired) {
                pBar.Invoke(new Action(delegate () {
                    //execute any code that modifies the UI in here...
                    pBar.Value = e.ProgressPercentage;
                }));
            }

            pBar.Value = e.ProgressPercentage;
            Cursor.Current = Cursors.WaitCursor;
        }

        private void BgSaveToDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            pBar.Value = 0;
            pBar.Visible = false;

            barMenu.Enabled = pnlOptions.Enabled = true;

            MessageBox.Show("Saving Database Completed");
            Cursor.Current = Cursors.Default;
        }
        private void SaveXMLItemsToDatabase() {
            int progress = 0;
            

            if (options.blnCustomers) {
                //Save Customers
                foreach (Customer customer in importedBackup.customerList) {
                    bslayer.SaveCustomer(customer);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            if (options.blnUsers) {
                //Save Users
                foreach (User user in importedBackup.userList) {
                    bslayer.SaveUser(user);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            if (options.blnPrinters) {
                //Save Printer List
                foreach (ApplicationPrinter printer in importedBackup.printerList) {
                    bslayer.SavePrinter(printer);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            if (options.blnLuv) {
                //Save Luv
                bslayer.SaveLuv(importedBackup.luv);
                bgSaveToDatabase.ReportProgress(progress++);
            }

            if (options.blnCurrentSession) {
                //Save Current Session
                bslayer.SaveSessionData(importedBackup.currentSession);
                bgSaveToDatabase.ReportProgress(progress++);
            }
            

            if (options.blnTables) {
                //Save Table Layout
                foreach (TableGroup group in importedBackup.tableGroupList) {
                    group.Save(bslayer.db);
                    bgSaveToDatabase.ReportProgress(progress++);
                }

                foreach (Table table in importedBackup.tableList) {
                    bslayer.SaveTable(table);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            if (options.blnMenus) {
                //Save Menu List
                foreach (FMenu menu in importedBackup.menuList) {
                    bslayer.SaveMenuDB(menu);
                    bgSaveToDatabase.ReportProgress(progress++);
                }

                bslayer.SaveStockManager(importedBackup.stockManager);
                bgSaveToDatabase.ReportProgress(progress++);
            }

            
            //Save Orders
            if (options.blnOrders) {
                foreach (Order order in importedBackup.orderList) {
                    bslayer.SaveOrder(order);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            //Load XOrders
            if (options.blnXOrders) {
                foreach (Order xorder in importedBackup.xorderList) {
                    bslayer.SaveXOrder(xorder);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            //save Kitchen Orders
            if (options.blnKitchenOrders) {
                foreach (KitchenOrder korder in importedBackup.kitchenOrderList) {
                    bslayer.SaveKitchenOrder(korder);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            //Save Debug Information
            if (options.blnDebugInformation) {
                foreach (Debug debug in importedBackup.debugList) {
                    bslayer.SaveDebug(debug);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }

            //Save Image Library
            if (options.blnImages) {
                foreach(GenericImage gim in importedBackup.imageList) {
                    bslayer.SaveGenericImage(gim);
                    bgSaveToDatabase.ReportProgress(progress++);
                }
            }
        }

        private void BtnExportImagesToFolder_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog {
                ShowNewFolderButton = true
            }) {
                if (dlg.ShowDialog() == DialogResult.OK) {
                    DirectoryInfo dinfo = new DirectoryInfo(dlg.SelectedPath);
                    if (bslayer.ExportDatabaseImagesIntoFolder(dinfo.FullName))
                        MessageBox.Show("Completed");
                    else
                        MessageBox.Show("Completed with Errors");
                }
            }
        }

        private void BtnCorrectImageLibraryFileNames_Click(object sender, EventArgs e) {
            try {
                DataTable dt = bslayer.db.GetDataTable("Select * from Images Where ImageFileName = '' or ImageFileName is null");
                for (int i = 0; i < dt.Rows.Count; i++) {
                    GenericImage gim = new GenericImage(dt.Rows[i]);
                    DataTable dteb = bslayer.db.GetDataTable("Select EntityButtonName from EntityButton where IID ='" + gim.ReferenceIID +"'");
                    if (dteb.Rows.Count > 0) {
                        gim.ImageFileName = dteb.Rows[0]["EntityButtonName"].ToString() + ".png";
                        bslayer.SaveGenericImage(gim);
                    }     
                }
                MessageBox.Show("Correction Completed.");
            } catch {
                MessageBox.Show("Failed to complete");
            }
        }

        

        private void TreeAdv_SelectionChanged(object sender, EventArgs e) {
            if (treeAdv.SelectedNode != null) {
                BackupNode nd = (BackupNode)treeAdv.SelectedNode;
                btnDebug.Visible = (nd.NodeType == BackupNodeTypes.DebugNode);
                barMenu.Refresh();
            }
        }

        private void BtnDebug_Click(object sender, EventArgs e) {
            if (treeAdv.SelectedNode != null) {
                BackupNode nd = (BackupNode)treeAdv.SelectedNode;
                if (nd.NodeType == BackupNodeTypes.DebugNode) {
                    Debug debug = bslayer.GetDebug(int.Parse(nd.NodeRelatedObject.ToString()));
                    if (debug != null) {
                        using (frmXMLViewer frm = new frmXMLViewer(debug.Data) {
                            MdiParent = this.MdiParent
                        }) {
                            frm.Show();
                        }
                    }
                }
            }
        }
    }
}

