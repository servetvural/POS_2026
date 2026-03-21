using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationPrinters",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeliveryPrinter = table.Column<bool>(type: "bit", nullable: false),
                    TakeAwayPrinter = table.Column<bool>(type: "bit", nullable: false),
                    AdminOnly = table.Column<bool>(type: "bit", nullable: false),
                    ClientIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetworkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinterType = table.Column<int>(type: "int", nullable: false),
                    PrinterTypeAsString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPrinters", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Bonus",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepValue = table.Column<double>(type: "float", nullable: false),
                    HalfStepValue = table.Column<double>(type: "float", nullable: false),
                    Barrier0 = table.Column<int>(type: "int", nullable: false),
                    Barrier1 = table.Column<int>(type: "int", nullable: false),
                    Barrier2 = table.Column<int>(type: "int", nullable: false),
                    Barrier3 = table.Column<int>(type: "int", nullable: false),
                    Barrier4 = table.Column<int>(type: "int", nullable: false),
                    Barrier5 = table.Column<int>(type: "int", nullable: false),
                    Barrier6 = table.Column<int>(type: "int", nullable: false),
                    Barrier7 = table.Column<int>(type: "int", nullable: false),
                    Barrier8 = table.Column<int>(type: "int", nullable: false),
                    Barrier9 = table.Column<int>(type: "int", nullable: false),
                    Barrier10 = table.Column<int>(type: "int", nullable: false),
                    Barrier11 = table.Column<int>(type: "int", nullable: false),
                    Barrier12 = table.Column<int>(type: "int", nullable: false),
                    Barrier13 = table.Column<int>(type: "int", nullable: false),
                    Barrier14 = table.Column<int>(type: "int", nullable: false),
                    Barrier15 = table.Column<int>(type: "int", nullable: false),
                    Barrier16 = table.Column<int>(type: "int", nullable: false),
                    Barrier17 = table.Column<int>(type: "int", nullable: false),
                    Barrier18 = table.Column<int>(type: "int", nullable: false),
                    Barrier19 = table.Column<int>(type: "int", nullable: false),
                    Barrier20 = table.Column<int>(type: "int", nullable: false),
                    DaysAvailable = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BonusHiddenStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BonusHiddenEndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonus", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buzzer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Debugs",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DebugNo = table.Column<int>(type: "int", nullable: false),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debugs", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Shortable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReferenceIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ExtraText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "KitchenOrders",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    BeingModified = table.Column<bool>(type: "bit", nullable: false),
                    OrderType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenOrders", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "LogItems",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderItemText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogItems", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Luvs",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdersEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentSessionIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoidText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultTaxRate = table.Column<double>(type: "float", nullable: false),
                    ServiceChargeRate = table.Column<double>(type: "float", nullable: false),
                    ServiceChargeTaxRate = table.Column<double>(type: "float", nullable: false),
                    ReceiptHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptFooter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KitchenHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KitchenFooter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportFooter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpServer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpFromLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MdfFileVersion = table.Column<int>(type: "int", nullable: false),
                    KitchenModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luvs", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveMenu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TableIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Covers = table.Column<int>(type: "int", nullable: false),
                    OrderType = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<int>(type: "int", nullable: false),
                    CustomerIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LockedClientIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyPaid = table.Column<double>(type: "float", nullable: false),
                    PaymentFlag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Buzzer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceChargeRate = table.Column<double>(type: "float", nullable: false),
                    ServiceChargeTaxRate = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "PrinterLookups",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrinterIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetworkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryPrinter = table.Column<int>(type: "int", nullable: false),
                    TakeAwayPrinter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterLookups", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrossSessionTotal = table.Column<double>(type: "float", nullable: false),
                    Peny1 = table.Column<double>(type: "float", nullable: false),
                    Peny2 = table.Column<double>(type: "float", nullable: false),
                    Peny5 = table.Column<double>(type: "float", nullable: false),
                    Peny10 = table.Column<double>(type: "float", nullable: false),
                    Peny20 = table.Column<double>(type: "float", nullable: false),
                    Peny50 = table.Column<double>(type: "float", nullable: false),
                    Pound1 = table.Column<double>(type: "float", nullable: false),
                    Pound2 = table.Column<double>(type: "float", nullable: false),
                    Pound5 = table.Column<double>(type: "float", nullable: false),
                    Pound10 = table.Column<double>(type: "float", nullable: false),
                    Pound20 = table.Column<double>(type: "float", nullable: false),
                    Pound50 = table.Column<double>(type: "float", nullable: false),
                    Pound100 = table.Column<double>(type: "float", nullable: false),
                    Pound200 = table.Column<double>(type: "float", nullable: false),
                    Pound500 = table.Column<double>(type: "float", nullable: false),
                    Pound1000 = table.Column<double>(type: "float", nullable: false),
                    CashTotal = table.Column<double>(type: "float", nullable: false),
                    CardTotal = table.Column<double>(type: "float", nullable: false),
                    OnlineTotal = table.Column<double>(type: "float", nullable: false),
                    X1total = table.Column<double>(type: "float", nullable: false),
                    X2total = table.Column<double>(type: "float", nullable: false),
                    X3total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "StockItems",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StockName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityType = table.Column<int>(type: "int", nullable: false),
                    OrderType = table.Column<int>(type: "int", nullable: false),
                    Conversion = table.Column<int>(type: "int", nullable: false),
                    SupplierIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsedQuantity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItems", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Whatsup = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "TableGroups",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableGroups", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableCovers = table.Column<int>(type: "int", nullable: false),
                    LockedClientIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentOrderIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableType = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    XLocation = table.Column<int>(type: "int", nullable: false),
                    YLocation = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    GroupIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTableIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shape = table.Column<int>(type: "int", nullable: false),
                    DefaultName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "KitchenOrderItems",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KitchenOrderIID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DistributionIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityButtonIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenOrderItems", x => x.IID);
                    table.ForeignKey(
                        name: "FK_KitchenOrderItems_KitchenOrders_KitchenOrderIID",
                        column: x => x.KitchenOrderIID,
                        principalTable: "KitchenOrders",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributions",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DistributionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinterIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentMenuIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    FoodMenuIID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributions", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Distributions_Menus_FoodMenuIID",
                        column: x => x.FoodMenuIID,
                        principalTable: "Menus",
                        principalColumn: "IID");
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    BackColour = table.Column<int>(type: "int", nullable: false),
                    ForeColour = table.Column<int>(type: "int", nullable: false),
                    ButtonHeight = table.Column<int>(type: "int", nullable: false),
                    ButtonWidth = table.Column<int>(type: "int", nullable: false),
                    ParentMenuIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    DistributionIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FFamily = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FSize = table.Column<double>(type: "float", nullable: false),
                    FStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodMenuIID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Entities_Menus_FoodMenuIID",
                        column: x => x.FoodMenuIID,
                        principalTable: "Menus",
                        principalColumn: "IID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityDisplayOrder = table.Column<int>(type: "int", nullable: false),
                    OrderItemText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OrderGroupIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityButtonIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistributionIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentOrderIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    TaxPercent = table.Column<double>(type: "float", nullable: false),
                    CompletedQuantity = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    OrderIID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.IID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderIID",
                        column: x => x.OrderIID,
                        principalTable: "Orders",
                        principalColumn: "IID");
                });

            migrationBuilder.CreateTable(
                name: "EntityButtons",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityButtonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ButtonColor = table.Column<int>(type: "int", nullable: false),
                    ForeColor = table.Column<int>(type: "int", nullable: false),
                    ButtonType = table.Column<int>(type: "int", nullable: false),
                    AvailableFor = table.Column<int>(type: "int", nullable: false),
                    ParentEntityIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentMenuIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Compulsary = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectSaleTaxPercent = table.Column<double>(type: "float", nullable: false),
                    InHouseTaxPercent = table.Column<double>(type: "float", nullable: false),
                    TakeAwayTaxPercent = table.Column<double>(type: "float", nullable: false),
                    DeliveryTaxPercent = table.Column<double>(type: "float", nullable: false),
                    PadFlag = table.Column<int>(type: "int", nullable: false),
                    DistributionIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectSalePrice = table.Column<double>(type: "float", nullable: false),
                    InHousePrice = table.Column<double>(type: "float", nullable: false),
                    TakeAwayPrice = table.Column<double>(type: "float", nullable: false),
                    DeliveryPrice = table.Column<double>(type: "float", nullable: false),
                    ButtonWidth = table.Column<int>(type: "int", nullable: false),
                    ButtonHeight = table.Column<int>(type: "int", nullable: false),
                    FFamily = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FSize = table.Column<double>(type: "float", nullable: false),
                    FStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithImage = table.Column<bool>(type: "bit", nullable: false),
                    EntityIID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityButtons", x => x.IID);
                    table.ForeignKey(
                        name: "FK_EntityButtons_Entities_EntityIID",
                        column: x => x.EntityIID,
                        principalTable: "Entities",
                        principalColumn: "IID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distributions_FoodMenuIID",
                table: "Distributions",
                column: "FoodMenuIID");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_FoodMenuIID",
                table: "Entities",
                column: "FoodMenuIID");

            migrationBuilder.CreateIndex(
                name: "IX_EntityButtons_EntityIID",
                table: "EntityButtons",
                column: "EntityIID");

            migrationBuilder.CreateIndex(
                name: "IX_KitchenOrderItems_KitchenOrderIID",
                table: "KitchenOrderItems",
                column: "KitchenOrderIID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderIID",
                table: "OrderItems",
                column: "OrderIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationPrinters");

            migrationBuilder.DropTable(
                name: "Bonus");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Debugs");

            migrationBuilder.DropTable(
                name: "Distributions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EntityButtons");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "KitchenOrderItems");

            migrationBuilder.DropTable(
                name: "LogItems");

            migrationBuilder.DropTable(
                name: "Luvs");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "PrinterLookups");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "StockItems");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "TableGroups");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "KitchenOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
