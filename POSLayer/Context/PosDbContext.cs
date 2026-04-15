using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Views;

namespace POSLayer.Context;

public partial class PosDbContext : DbContext
{
    public PosDbContext()
    {

    }

    public PosDbContext(DbContextOptions<PosDbContext> options)
        : base(options)
    {
        // When an entity is tracked (loaded from DB), set IsNew to false
        //ChangeTracker.Tracked += (sender, e) =>
        //{
        //    if (e.Entry.Entity is BaseClass baseEntity)
        //    {
        //        baseEntity.IsNew = false;
        //    }
        //};
    }

    public virtual DbSet<Printer> Printers { get; set; }

    public virtual DbSet<Bonus> Bonus { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Debug> Debugs { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }

    public virtual DbSet<DistributionPrinter> DistributionPrinters { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryItem> CategoryItems { get; set; }

    public virtual DbSet<GenericImage> Images { get; set; }

    public virtual DbSet<KitchenOrder> KitchenOrders { get; set; }

    public virtual DbSet<KitchenOrderItem> KitchenOrderItems { get; set; }

    public virtual DbSet<LogItem> LogItems { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<TheMenu> Menus { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    // public virtual DbSet<OrderItemView> OrderItemViews { get; set; }

    //public virtual DbSet<OrdersView> OrdersViews { get; set; }

    // public virtual DbSet<PrinterLookup> PrinterLookups { get; set; }

    // public virtual DbSet<PrinterView> PrinterViews { get; set; }

    // public virtual DbSet<ServiceChargeSummary> ServiceChargeSummaries { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    // public virtual DbSet<SessionSum> SessionSums { get; set; }

    public virtual DbSet<StockItem> StockItems { get; set; }

    public virtual DbSet<RecipeItem> RecipeItems { get; set; }
   // public virtual DbSet<StockItemUsage> StockItemUsages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Masa> Tables { get; set; }

    public virtual DbSet<Salon> Salons { get; set; }

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


    public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Order>().ToTable("Orders");
        //modelBuilder.Entity<XOrder>().ToTable("XOrders"); // This 

        // Define PKs for all entities inheriting from BaseClass
        foreach (var entityType in modelBuilder.Model.GetEntityTypes()
                    .Where(t => typeof(BaseClass).IsAssignableFrom(t.ClrType)))
        {
            modelBuilder.Entity(entityType.ClrType).HasKey("IID");
        }

        // 3. Configure Explicit Join Table (Distribution <-> DistributionPrinter <-> Printer)
        modelBuilder.Entity<DistributionPrinter>(entity =>
        {
            entity.ToTable("DistributionPrinters");

            entity.HasOne(dp => dp.Distribution)
                .WithMany(d => d.DistributionPrinters)
                .HasForeignKey(dp => dp.DistributionIID)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(dp => dp.Printer)
                .WithMany(p => p.DistributionPrinters)
                .HasForeignKey(dp => dp.PrinterIID)
                .OnDelete(DeleteBehavior.Cascade);
        });

        //modelBuilder.Entity<Masa>()
        //    .HasOne(t => t.Order)      // Table has one Order
        //    .WithOne(o => o.Table)           // Order has one Table
        //    .HasForeignKey<Order>(o => o.TableIID) // FK is on the Order table
        //    .IsRequired(false);              // Explicitly mark as optional






        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}




