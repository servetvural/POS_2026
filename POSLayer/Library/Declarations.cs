using System.ComponentModel;
using POSLayer.Models;

namespace POSLayer.Library;

public enum ReportFunctionTypes { ReportSummary = 0, CategoryReport = 1, CategoryDetailedReport = 2, OrderListReport = 4 };
public enum ReportPrintTypes { SessionReport, Receipt, Kitchen, PriceList }
public enum ReportFormatTypes { XReport = 0, ZReport = 1, YReport = 2 }

public enum WeekDays { NoDay = 0, Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16, Saturday = 32, Sunday = 64 }

public enum OrderTypes { Unknown = 0, InHouse = 1, TakeAwayB = 2, Delivery = 4, InternetTakeAway = 8, InternetDelivery = 16, All = 128, DirectSale = 256, Pad = 512 };
public enum CategoryItemTypes { SimpleItem, ExtraItem, AmountAddition, PercentAddition, CustomAddition, AmountDeduction, PercentDeduction, CustomDeduction, SpaceButton };

public enum AccessLevels { User = 0, Manager = 1, SuperUser = 2, TechnicalSupport = 3 };
public enum StatusFlags { UNKNOWN, NEW, DONE, COMPLETED, ARCHIVED, PENDING, VOID }
public enum PaymentMethods { NotPaid, Cash, Card, Online }
public enum AutoPaymentMethods { Selective, AutoCash }
public enum PrinterTypes { Unknown, Kitchen, Receipt, Mutant }   
public enum PrinterVisibilityTypes { Local, Global }
public enum AvailabilityTypes
{
    All = 0, InHouse = 1, TakeAwayB = 2, Delivery = 4, InternetTakeAway = 8,
    InternetDelivery = 16, Direct = 32, Sms = 64, NoSale = 256
}

public enum PrintColors { pcBlack = 0, pcRed = 255 }
public enum PrintSizes { psTiny, psNormal, psBig }
public enum PrintAligns { Near, Center, Far };
public enum PrintTypes { KitchenSlip, Receipt, Report, Voucher }
public enum PrintLineFlags { Unknown, Header, OrderItem, SubTotal, Total, Payment, Customer, ReportItem }
public enum ReportTypes { UnknownReport, InHouseReport, TakeAwayReport, DeliveryReport, XReport, YReport, ZReport }
public enum MessageLocations { Inbox, Outbox, Sentbox, Archivebox }
public enum MessageFlags { UnRead, Read }
public enum SignalTypes { AttentionPlease, SignalStarters, SignalSideDishes, SignalMainCourses, SignalDesserts, SignalDrinks }
public enum OrderItemTypes { NormalOrderItem = 0, AmountAddition = 7, PercentAddition = 8, CustomAddition = 9, AmountDeduction = 10, PercentDeduction = 11, CustomDeduction = 12, Refund = 13 }
public enum CategoryTypes { NormalCategory= 0, SpecialCategory = 1 }
public enum CashDrawerTypes { None, LocalAttached, PrinterAttached, USBPrinterAttached }
public enum DirectionalDeliveryTypes { IncomingDelivery, OutgoingDelivery }
public enum DeliveryTypes { FromSupplier, FromBranch, FromOthers, RefundToSupplier, ToBranch, ToOthers }
public enum StockTypes { All, NonExistStock, ExistStock, LowStocked, OverStocked }
public enum PromotionItemTypes { None, ValuePromotion, PercentPromotion }
public enum PromotionButtonTypes { EntityButton, SizeBarButton }
public enum DirectoryTypes { All, ShopDirectory, WareHouseDirectory, DatabaseDirectory, BackupDirectory }
public enum DialogTypes { YesNoCancel, OkNoCancel }
public enum PaymentSystemTypes { InternalSystem, ThirdPartySystem, ThirdPartywithCash }
public enum ViewTypes { Unknown, UnloadedOrderView, SplitView, SubTotalView, DirectSaleOrderView, InHouseOrderView, TakeAwayOrderView, DeliveryOrderView, InternetTakeAwayView, InternetDeliveryView }
public enum LicenceTypes { None, Evaluation, Valid, ValidAdvanced }
public enum HoldingActions { None, Plus, Minus, Multiply, Divide };
public enum DealItemTypes { BuyItem, GetItem };
public enum DealItemPriceTypes { NormalPrice, SpecialPrice, PercentagePrice }
public enum NumberModes { IntegerMode, FloatMode }
public enum PadFlags { EBOnly = 0, PadOnly = 1, EBAndPad = 2 }
public enum OrderDisplayHeightTypes { Narrow = 16, Middle = 32, Large = 62 }
public enum BarcodeScannerConnectorTypes { Keyboard, COM1, COM2, COM3, COM4 }
public enum SerialPortTypes { NONE, COM1, COM2, COM3, COM4, COM5, COM6, COM7, COM8, COM9, COM10, COM11, COM12 }


public enum SplitDirections { SourceToTarget, TargetToSource }

public enum BSLayerErrors
{
    UnknownError, CreateError, DatabaseConnectionError, LocalDatabaseLocationError,
    RemoteDatabaseLocationError, BSLayerStartError, GenericNetworkError, GenericUserError
}

public enum DivisionBarButtonType { Cancel, AllOver }
public enum SizeBarButtonType { Cancel, Complete }
public enum LocationTypes { DockLeft, DockRight, DockTop, DockBottom }
public enum ButtonTypes { System, Application }
public enum ProcessTypes { SingleProcess, MultiProcess }
public enum ProgressTypes { Standard, Marquee }

public enum SelectionTypes { None, Selected, All }
public enum ReportOutputActionTypes { None, View, Print, Export, Email }
public enum ReportPaperTypes { R80, A4 }

public enum ConnectionStatus { Disconnected = 0, ConnectedLocally, ConnectedRemotely };

public delegate void DelegateCreateOrderForCustomer(string CustomerIID, OrderTypes RequestedOrderType);
public delegate void CallableDelegate2(object param1, object param2);
public delegate void CallableDelegate(object param1, object param2, object param3, object param4);
public delegate void GenericEventHandler(object sender, EventArgs e);
public delegate void GenericFunctionCall();
public delegate void GenericProgressFunction(object sender, ProgressChangedEventArgs e);
public delegate bool GenericFunctionCallReturnBool();
public delegate void ScanEvent(string barcode);
public delegate bool RemoteCompleteAttachedOrder(int NumberOfCopy, bool blnArchive, bool blnPrintLocal, bool blnEnforceDeliveryArchive);
public delegate void StatusDelegate(string message, int progress);
public delegate void AsyncCallBack(IAsyncResult result);
//public delegate void PassControl(Control ctrl);
public delegate void KitchenEventHandler(KitchenOrder order);
public delegate void DisplayConfigurationChangeRequiredEvent();
public delegate void DisplayConfigurationChangeEvent(Distribution newglobaltype);
public delegate void SimpleStringEventHandler(string str);

public enum SplittingStatus { Normal, Splitting }
public enum LanguageTypes { English, Türkçe }
public enum ButtonShapeTypes { Rectangle, Circle }
public enum KitchenOrderStatusTypes { Waiting, PartialyCompleted, Completed, All }
public enum PrepDialogReturnTypes { Cancel, Hold, HoldAndPrint, Cash, CashAndPrint }
public enum QuantityTypes { None, Piece, Kilo, Gram, Litre, ml, Pack, Box, Bottle, Crate, Slice, Dash, Pinch, Bar_Spoon, Leaf, Wheel, Handful, Quarter, Drops, Halves, Barista_Scoop, Splash, Sprinkle, Sachet, Can }
public enum KitchenDisplayTypes { None, Single_Display, Double_Display, Triple_Display }
public enum OrientationTypes { Landscape, Portrait }
public enum PrintableInterfaceTypes { None_Printable, One_By_One_Printable, All_in_One_Printable, Both_Printable }
public enum ScreenLockTypes { None, PinLock, ScreenSaverLock, WindowsScreenSaverLock }
public enum OrderByTypes { None, Ascending, Descending }
public enum ModificationFlag { None, Partially, Completed }
public enum ScreenSaverTypes { None, SingleDisplay, Flow }
public enum ScreenSaverColourTypes { BlackBackGroundWhiteBrush, WhiteBackGroundBlackBrush }
public enum AlignmentTypes { Left, Center, Right }

public enum BonusTypes { NoTip, Half_Tip, Full_Tip }



public enum FormWindowStateTypes { Normal, Minimized, Maximized }



public enum ButtonDisplayStyles { None, Text, Image, ImageAndText }
//public enum ImagePositionTypes { Left, Center,  Right }
public enum ContentAlignmentX
{
    Unknown = 0x0,
    /// <summary>
    ///  Content is vertically aligned at the top, and horizontally aligned on the left.
    /// </summary>
    TopLeft = 0x001,
    /// <summary>
    ///  Content is vertically aligned at the top, and horizontally aligned at the center.
    /// </summary>
    TopCenter = 0x002,
    /// <summary>
    ///  Content is vertically aligned at the top, and horizontally aligned on the right.
    /// </summary>
    TopRight = 0x004,
    /// <summary>
    ///  Content is vertically aligned in the middle, and horizontally aligned on the left.
    /// </summary>
    MiddleLeft = 0x010,
    /// <summary>
    ///  Content is vertically aligned in the middle, and horizontally aligned at the center.
    /// </summary>
    MiddleCenter = 0x020,
    /// <summary>
    ///  Content is vertically aligned in the middle, and horizontally aligned on the right.
    /// </summary>
    MiddleRight = 0x040,
    /// <summary>
    ///  Content is vertically aligned at the bottom, and horizontally aligned on the left.
    /// </summary>
    BottomLeft = 0x100,
    /// <summary>
    ///  Content is vertically aligned at the bottom, and horizontally aligned at the center.
    /// </summary>
    BottomCenter = 0x200,
    /// <summary>
    ///  Content is vertically aligned at the bottom, and horizontally aligned on the right.
    /// </summary>
    BottomRight = 0x400,
}

public enum TextImageRelationX
{
    Overlay = AnchorStylesX.None,
    ImageBeforeText = AnchorStylesX.Left,
    TextBeforeImage = AnchorStylesX.Right,
    ImageAboveText = AnchorStylesX.Top,
    TextAboveImage = AnchorStylesX.Bottom
}

public enum AnchorStylesX
{
    /// <summary>
    ///  The control is anchored to the top edge of its container.
    /// </summary>
    Top = 0x01,

    /// <summary>
    ///  The control is anchored to the bottom edge of its container.
    /// </summary>
    Bottom = 0x02,

    /// <summary>
    ///  The control is anchored to the left edge of its container.
    /// </summary>
    Left = 0x04,

    /// <summary>
    ///  The control is anchored to the right edge of its container.
    /// </summary>
    Right = 0x08,

    /// <summary>
    ///  The control is not anchored to any edges of its container.
    /// </summary>
    None = 0,
}