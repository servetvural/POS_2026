using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

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

    public virtual DbSet<Recipe> Recipes { get; set; }
    public virtual DbSet<StockItemUsage> StockItemUsages { get; set; }

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






        // Configure One-to-Many: Menu -> Category
        modelBuilder.Entity<Category>()
            .HasOne(c => c.Menu)
            .WithMany(m => m.categories)
            .HasForeignKey(c => c.MenuIID)
            .OnDelete(DeleteBehavior.NoAction);

        // Configure Optional One-to-Many: Distribution -> Category
        modelBuilder.Entity<Category>()
            .HasOne(c => c.Distribution)
            .WithMany() // No collection on Distribution for this
            .HasForeignKey(c => c.DistributionIID)
            .OnDelete(DeleteBehavior.SetNull);

        // Configure Optional One-to-Many: Distribution -> CategoryItem
        modelBuilder.Entity<CategoryItem>()
            .HasOne(ci => ci.Distribution)
            .WithMany()
            .HasForeignKey(ci => ci.DistributionIID)
            .OnDelete(DeleteBehavior.SetNull);



        modelBuilder.Entity<StockItemUsage>(entity =>
        {
            entity.ToTable("StockItemUsages");

            entity.HasOne(dp => dp.StockItem)
                .WithMany(d => d.stockUsages)
                .HasForeignKey(dp => dp.StockItemIID)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(dp => dp.CategoryItem)
                .WithMany(p => p.stockUsages)
                .HasForeignKey(dp => dp.CategoryItemIID)
                .OnDelete(DeleteBehavior.SetNull);
        });


        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.ToTable("Recipes");

            entity.HasOne(dp => dp.StockItem)
                .WithMany(d => d.recipes)
                .HasForeignKey(dp => dp.StockItemIID)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(dp => dp.CategoryItem)
                .WithMany(p => p.recipes)
                .HasForeignKey(dp => dp.CategoryItemIID)
                .OnDelete(DeleteBehavior.Cascade);
        });



        // Relationship: Customer -> Order
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)      // Order has one Customer
            .WithMany(c => c.Orders)      // Customer has many Orders
            .HasForeignKey(o => o.CustomerIID)
            .OnDelete(DeleteBehavior.Restrict); // Usually, deleting a customer shouldn't delete all their orders automatically

        // Your existing Order -> OrderItem relationship
        modelBuilder.Entity<Order>()
            .HasMany(o => o.items)
            .WithOne(oi => oi.Order)
            .HasForeignKey(oi => oi.OrderIID);


       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}




