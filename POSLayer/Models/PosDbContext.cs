using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using POSLayer.Library;
using POSLayer.Views;

namespace POSLayer.Models;

public partial class PosDbContext : DbContext
{
    public PosDbContext()
    {
    }

    public PosDbContext(DbContextOptions<PosDbContext> options)
        : base(options)
    {
        string str = "";
    }

    public virtual DbSet<ApplicationPrinter> ApplicationPrinters { get; set; }

    public virtual DbSet<Bonus> Bonus { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Debug> Debugs { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }


    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<EntityButton> EntityButtons { get; set; }

    public virtual DbSet<GenericImage> Images { get; set; }

    public virtual DbSet<KitchenOrder> KitchenOrders { get; set; }

    public virtual DbSet<KitchenOrderItem> KitchenOrderItems { get; set; }

    public virtual DbSet<LogItem> LogItems { get; set; }

    public virtual DbSet<Luv> Luvs { get; set; }

    public virtual DbSet<FoodMenu> Menus { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

   // public virtual DbSet<OrderItemView> OrderItemViews { get; set; }

    //public virtual DbSet<OrdersView> OrdersViews { get; set; }

    public virtual DbSet<PrinterLookup> PrinterLookups { get; set; }

   // public virtual DbSet<PrinterView> PrinterViews { get; set; }

   // public virtual DbSet<ServiceChargeSummary> ServiceChargeSummaries { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

   // public virtual DbSet<SessionSum> SessionSums { get; set; }

    public virtual DbSet<StockItem> StockItems { get; set; }

   // public virtual DbSet<StockItemUsage> StockItemUsages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TableGroup> TableGroups { get; set; }

   // public virtual DbSet<TaxPercentList> TaxPercentLists { get; set; }

   // public virtual DbSet<TaxSummary> TaxSummaries { get; set; }

  //  public virtual DbSet<TaxSummaryTotalView> TaxSummaryTotalViews { get; set; }

  //  public virtual DbSet<UncompletedOrdersSessionSum> UncompletedOrdersSessionSums { get; set; }

   // public virtual DbSet<UncompletedOrdersView> UncompletedOrdersViews { get; set; }

    public virtual DbSet<User> Users { get; set; }

  //  public virtual DbSet<UserSale> UserSales { get; set; }

    public virtual DbSet<XOrder> Xorders { get; set; }

    public virtual DbSet<XOrderItem> XorderItems { get; set; }

    //public virtual DbSet<XordersView> XordersViews { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<ApplicationPrinter>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("ApplicationPrinter");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.ApplicationName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Bonus>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.PlanDescription).IsUnicode(false);
        //    entity.Property(e => e.PlanName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Customer>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("Customer");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.Address)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Buzzer)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasColumnName("CName");
        //    entity.Property(e => e.CompanyName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CPassword)
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .HasColumnName("CPassword");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Fax)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Mobile)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Postcode)
        //        .HasMaxLength(10)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Tel)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Town)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Debug>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Debug");

        //    entity.Property(e => e.Data).IsUnicode(false);
        //    entity.Property(e => e.DebugNo).ValueGeneratedOnAdd();
        //    entity.Property(e => e.EventDateTime).HasColumnType("datetime");
        //});

        //modelBuilder.Entity<Distribution>(entity =>
        //{
        //    entity.HasKey(e => e.IID).HasName("PK_FoodType");

        //    entity.ToTable("Distribution");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.DistributionName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.ParentMenuIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentMenuIID");
        //    entity.Property(e => e.PrinterIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("PrinterIID");
        //    entity.Property(e => e.ShortName)
        //        .HasMaxLength(5)
        //        .IsUnicode(false);
        //});

       

        //modelBuilder.Entity<Employee>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("Employee");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.EmployeeName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Shortable).HasDefaultValue(1, "DF_Employee_Shortable");
        //});

        //modelBuilder.Entity<Entity>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("Entity");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.DistributionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("DistributionIID");
        //    entity.Property(e => e.DistributionName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.EntityName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.FFamily)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("FFamily");
        //    entity.Property(e => e.FSize).HasColumnName("FSize");
        //    entity.Property(e => e.FStyle)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("FStyle");
        //    entity.Property(e => e.ParentMenuIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentMenuIID");
        //});

        //modelBuilder.Entity<EntityButton>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("EntityButton");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.Barcode)
        //        .HasMaxLength(24)
        //        .IsUnicode(false);
        //    entity.Property(e => e.DistributionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("DistributionIID");
        //    entity.Property(e => e.EntityButtonName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.FFamily)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("FFamily");
        //    entity.Property(e => e.FSize).HasColumnName("FSize");
        //    entity.Property(e => e.FStyle)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("FStyle");
        //    entity.Property(e => e.ParentEntityIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentEntityIID");
        //    entity.Property(e => e.ParentMenuIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentMenuIID");
        //});

       

       

        //modelBuilder.Entity<GenericImage>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.DisplayImage).HasColumnType("image");
        //    entity.Property(e => e.ExtraText).IsUnicode(false);
        //    entity.Property(e => e.ImageFileName).IsUnicode(false);
        //    entity.Property(e => e.ReferenceIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ReferenceIID");
        //});

        //modelBuilder.Entity<KitchenOrder>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.CompletedDateTime).HasColumnType("datetime");
        //    entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.OrderIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("OrderIID");
        //    entity.Property(e => e.OrderNo).ValueGeneratedOnAdd();
        //    entity.Property(e => e.Reference)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<KitchenOrderItem>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("KitchenOrderItem");

        //    entity.Property(e => e.DistributionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("DistributionIID");
        //    entity.Property(e => e.EntityButtonIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("EntityButtonIID");
        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.ItemText).IsUnicode(false);
        //    entity.Property(e => e.KitchenOrderIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("KitchenOrderIID");
        //});

        //modelBuilder.Entity<LogItem>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.ComputerName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.EventDateTime)
        //        .HasDefaultValueSql("(getdate())", "DF_LogItems_EventDateTime")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.OrderContent).IsUnicode(false);
        //    entity.Property(e => e.OrderItemText)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Price).HasColumnType("money");
        //    entity.Property(e => e.Reason)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Reference)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Luv>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Luv");

        //    entity.Property(e => e.CurrentSessionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CurrentSessionIID");
        //    entity.Property(e => e.CustomerKey)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CustomerPassword)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Fax)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.KitchenFooter).HasColumnType("text");
        //    entity.Property(e => e.KitchenHeader).HasColumnType("text");
        //    entity.Property(e => e.KitchenModified)
        //        .HasDefaultValueSql("(getdate())", "DF_Luv_KitchenModified")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.MdfFileVersion).HasDefaultValue(1000, "DF_Luv_MdfFileVersion");
        //    entity.Property(e => e.NotificationEmail)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.OrdersEmail)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.PurchaseEmail)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.ReceiptFooter).HasColumnType("text");
        //    entity.Property(e => e.ReceiptHeader).HasColumnType("text");
        //    entity.Property(e => e.ReportEmail)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.ReportFooter).HasColumnType("text");
        //    entity.Property(e => e.ReportHeader).HasColumnType("text");
        //    entity.Property(e => e.SessionStartDateTime).HasColumnType("datetime");
        //    entity.Property(e => e.ShopAddress).HasColumnType("text");
        //    entity.Property(e => e.ShopName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SmtpAccountName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SmtpEmailAddress)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SmtpFromLabel)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SmtpPassword)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SmtpServer)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Tel1)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Tel2)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Vat)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.VoidText)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<FoodMenu>(entity =>
        //{
        //    entity.HasKey(e => e.IID).HasName("PK_FoodMenu");

        //    entity.ToTable("Menu");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.MenuName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Order>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.Address)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Buzzer)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasColumnName("CName");
        //    entity.Property(e => e.CustomerIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CustomerIID");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Instruction)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.LockedClientIP)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("LockedClientIP");
        //    entity.Property(e => e.Mobile)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.MoneyPaid).HasColumnType("smallmoney");
        //    entity.Property(e => e.OrderDate).HasColumnType("datetime");
        //    entity.Property(e => e.PaymentFlag)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Postcode)
        //        .HasMaxLength(10)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Reference)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SessionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("SessionIID");
        //    entity.Property(e => e.TableIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("TableIID");
        //    entity.Property(e => e.TableName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Tel)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Town)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<OrderItem>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("OrderItem");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.DistributionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("DistributionIID");
        //    entity.Property(e => e.EntityButtonIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("EntityButtonIID");
        //    entity.Property(e => e.EntityIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("EntityIID");
        //    entity.Property(e => e.EntityName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.OrderGroupIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("OrderGroupIID");
        //    entity.Property(e => e.OrderItemText)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.ParentOrderIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentOrderIID");
        //    entity.Property(e => e.Price).HasColumnType("money");
        //});

       

        //modelBuilder.Entity<PrinterLookup>(entity =>
        //{
        //    entity.HasKey(e => new { e.PrinterIID, e.ClientIID });

        //    entity.ToTable("PrinterLookup");

        //    entity.Property(e => e.PrinterIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("PrinterIID");
        //    entity.Property(e => e.ClientIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ClientIID");
        //    entity.Property(e => e.NetworkName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //});


        //modelBuilder.Entity<Session>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.Peny1).HasColumnName("peny1");
        //    entity.Property(e => e.Peny10).HasColumnName("peny10");
        //    entity.Property(e => e.Peny2).HasColumnName("peny2");
        //    entity.Property(e => e.Peny20).HasColumnName("peny20");
        //    entity.Property(e => e.Peny5).HasColumnName("peny5");
        //    entity.Property(e => e.Peny50).HasColumnName("peny50");
        //    entity.Property(e => e.Pound1).HasColumnName("pound1");
        //    entity.Property(e => e.Pound10).HasColumnName("pound10");
        //    entity.Property(e => e.Pound100).HasColumnName("pound100");
        //    entity.Property(e => e.Pound1000).HasColumnName("pound1000");
        //    entity.Property(e => e.Pound2).HasColumnName("pound2");
        //    entity.Property(e => e.Pound20).HasColumnName("pound20");
        //    entity.Property(e => e.Pound200).HasColumnName("pound200");
        //    entity.Property(e => e.Pound5).HasColumnName("pound5");
        //    entity.Property(e => e.Pound50).HasColumnName("pound50");
        //    entity.Property(e => e.Pound500).HasColumnName("pound500");
        //    entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
        //    entity.Property(e => e.X1total).HasColumnName("X1Total");
        //    entity.Property(e => e.X2total).HasColumnName("X2Total");
        //    entity.Property(e => e.X3total).HasColumnName("X3Total");
        //});

       

        //modelBuilder.Entity<StockItem>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("StockItem");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.StockName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SupplierIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("SupplierIID");
        //});

       

        //modelBuilder.Entity<Supplier>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Supplier");

        //    entity.Property(e => e.Address).IsUnicode(false);
        //    entity.Property(e => e.Email1)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Email2)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.SupplierName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Tel)
        //        .HasMaxLength(20)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Whatsup)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<Table>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.CurrentOrderIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CurrentOrderIID");
        //    entity.Property(e => e.DefaultName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.GroupIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("GroupIID");
        //    entity.Property(e => e.Height).HasColumnName("height");
        //    entity.Property(e => e.LockedClientIP)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("LockedClientIP");
        //    entity.Property(e => e.ParentTableIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentTableIID");
        //    entity.Property(e => e.TableName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Width).HasColumnName("width");
        //    entity.Property(e => e.XLocation).HasColumnName("xlocation");
        //    entity.Property(e => e.YLocation).HasColumnName("ylocation");
        //});

        //modelBuilder.Entity<TableGroup>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("TableGroup");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.GroupName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});
       


      

        //modelBuilder.Entity<User>(entity =>
        //{
        //    entity.HasKey(e => e.IID).HasName("PK_User");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.UserPassword)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        
        //modelBuilder.Entity<XOrder>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("XOrders");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.Address)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Buzzer)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasColumnName("CName");
        //    entity.Property(e => e.CustomerIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("CustomerIID");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Instruction)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.LockedClientIP)
        //        .HasMaxLength(20)
        //        .IsUnicode(false)
        //        .HasColumnName("LockedClientIP");
        //    entity.Property(e => e.Mobile)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.MoneyPaid).HasColumnType("smallmoney");
        //    entity.Property(e => e.OrderDate).HasColumnType("datetime");
        //    entity.Property(e => e.PaymentFlag)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Postcode)
        //        .HasMaxLength(10)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Reference)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.SessionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("SessionIID");
        //    entity.Property(e => e.TableIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("TableIID");
        //    entity.Property(e => e.TableName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Tel)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.Town)
        //        .HasMaxLength(255)
        //        .IsUnicode(false);
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        //modelBuilder.Entity<XOrderItem>(entity =>
        //{
        //    entity.HasKey(e => e.IID);

        //    entity.ToTable("XOrderItem");

        //    entity.Property(e => e.IID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("IID");
        //    entity.Property(e => e.DistributionIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("DistributionIID");
        //    entity.Property(e => e.EntityButtonIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("EntityButtonIID");
        //    entity.Property(e => e.EntityIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("EntityIID");
        //    entity.Property(e => e.EntityName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.OrderGroupIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("OrderGroupIID");
        //    entity.Property(e => e.OrderItemText)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.ParentOrderIID)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnName("ParentOrderIID");
        //    entity.Property(e => e.Price).HasColumnType("money");
        //});

       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
