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
                    BonusHiddenEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    Shortable = table.Column<bool>(type: "bit", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    OrderType = table.Column<int>(type: "int", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogItems", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryPrinter = table.Column<bool>(type: "bit", nullable: false),
                    TakeAwayPrinter = table.Column<bool>(type: "bit", nullable: false),
                    AdminOnly = table.Column<bool>(type: "bit", nullable: false),
                    NetworkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinterType = table.Column<int>(type: "int", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.IID);
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
                    X3total = table.Column<double>(type: "float", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.IID);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdersEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentSessionIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    KitchenModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.IID);
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
                    UsedQuantity = table.Column<double>(type: "float", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    Whatsup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    XLocation = table.Column<int>(type: "int", nullable: false),
                    YLocation = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    GroupIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTableIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shape = table.Column<int>(type: "int", nullable: false),
                    DefaultName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IID);
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
                    SessionIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    LockedClientIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyPaid = table.Column<double>(type: "float", nullable: false),
                    PaymentFlag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceChargeRate = table.Column<double>(type: "float", nullable: false),
                    ServiceChargeTaxRate = table.Column<double>(type: "float", nullable: false),
                    Waiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerIID",
                        column: x => x.CustomerIID,
                        principalTable: "Customers",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Restrict);
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
                    Status = table.Column<int>(type: "int", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
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
                name: "Categories",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgColour = table.Column<int>(type: "int", nullable: false),
                    FgColour = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    MenuIID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DistributionIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FFamily = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FSize = table.Column<double>(type: "float", nullable: false),
                    FStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Categories_Menus_MenuIID",
                        column: x => x.MenuIID,
                        principalTable: "Menus",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributions",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinterIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MenuIID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributions", x => x.IID);
                    table.ForeignKey(
                        name: "FK_Distributions_Menus_MenuIID",
                        column: x => x.MenuIID,
                        principalTable: "Menus",
                        principalColumn: "IID");
                    table.ForeignKey(
                        name: "FK_Distributions_Printers_PrinterIID",
                        column: x => x.PrinterIID,
                        principalTable: "Printers",
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
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    TaxPercent = table.Column<double>(type: "float", nullable: false),
                    CompletedQuantity = table.Column<double>(type: "float", nullable: false),
                    OrderIID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.IID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderIID",
                        column: x => x.OrderIID,
                        principalTable: "Orders",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryItems",
                columns: table => new
                {
                    IID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryIID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgColor = table.Column<int>(type: "int", nullable: false),
                    FgColor = table.Column<int>(type: "int", nullable: false),
                    ButtonType = table.Column<int>(type: "int", nullable: false),
                    AvailableFor = table.Column<int>(type: "int", nullable: false),
                    Compulsary = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaleTax = table.Column<double>(type: "float", nullable: false),
                    SitinTax = table.Column<double>(type: "float", nullable: false),
                    TaTax = table.Column<double>(type: "float", nullable: false),
                    DTax = table.Column<double>(type: "float", nullable: false),
                    PadFlag = table.Column<int>(type: "int", nullable: false),
                    DistributionIID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    SitinPrice = table.Column<double>(type: "float", nullable: false),
                    TaPrice = table.Column<double>(type: "float", nullable: false),
                    DPrice = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    FFamily = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FSize = table.Column<double>(type: "float", nullable: false),
                    FStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithImage = table.Column<bool>(type: "bit", nullable: false),
                    dorder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItems", x => x.IID);
                    table.ForeignKey(
                        name: "FK_CategoryItems_Categories_CategoryIID",
                        column: x => x.CategoryIID,
                        principalTable: "Categories",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MenuIID",
                table: "Categories",
                column: "MenuIID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryItems_CategoryIID",
                table: "CategoryItems",
                column: "CategoryIID");

            migrationBuilder.CreateIndex(
                name: "IX_Distributions_MenuIID",
                table: "Distributions",
                column: "MenuIID");

            migrationBuilder.CreateIndex(
                name: "IX_Distributions_PrinterIID",
                table: "Distributions",
                column: "PrinterIID");

            migrationBuilder.CreateIndex(
                name: "IX_KitchenOrderItems_KitchenOrderIID",
                table: "KitchenOrderItems",
                column: "KitchenOrderIID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderIID",
                table: "OrderItems",
                column: "OrderIID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerIID",
                table: "Orders",
                column: "CustomerIID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonus");

            migrationBuilder.DropTable(
                name: "CategoryItems");

            migrationBuilder.DropTable(
                name: "Debugs");

            migrationBuilder.DropTable(
                name: "Distributions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "KitchenOrderItems");

            migrationBuilder.DropTable(
                name: "LogItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Shops");

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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "KitchenOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
