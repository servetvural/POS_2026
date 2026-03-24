using System.Linq.Expressions;
using System.Security.Cryptography;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using POSLayer.Views;

namespace PosLayer.Repository;


public class Repository<T> : IRepository<T> where T : BaseClass
{
    //private readonly PosDbContext _context = context;
    //private readonly DbSet<T> _dbSet = context.Set<T>();

    #region GENERIC FUNCTIONS
    protected readonly IDbContextFactory<PosDbContext>? contextFactory;
    public Repository(IDbContextFactory<PosDbContext> _contextFactory)
    {
        contextFactory = _contextFactory;
    }

    public PosDbContext GetDBContext()
    {
        return this.contextFactory.CreateDbContext();
    }

    public async Task<bool> IsDatabaseExist()
    {
        using var _db = GetDBContext();
        try
        {
            return _db.GetService<IRelationalDatabaseCreator>().Exists();
        } catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<bool> Any()
    {
        using var _db = GetDBContext();
        try
        {
            return _db.Set<T>().Any();
        } catch (Exception ex)
        {
            return false;
        }
    }
    //public async Task<T> Get(int Id, string includeItems = "")
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        DbSet<T> table = _db.Set<T>();
    //        if (string.IsNullOrEmpty(includeItems))
    //        {
    //            return await table.Where(x => x.Id == Id).FirstOrDefaultAsync();
    //        } else
    //        {
    //            return await table.Where(x => x.Id == Id).Include(includeItems).FirstOrDefaultAsync();
    //        }
    //    } catch (Exception ex)
    //    {
    //        string str = ex.Message;
    //        return null;
    //    }
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IID"></param>
    /// <param name="includeItems">Comma seperated includes. If thenInclude required it is a different issue</param>
    /// <returns></returns>
    public async Task<T> Get(string IID, string includeItems = "")
    {
        using var _db = GetDBContext();
        try
        {
            //DbSet<T> table = _db.Set<T>();
            IQueryable<T> query = _db.Set<T>();
            //if (string.IsNullOrEmpty(includeItems))
            //{
            //    return await table.Where(x => x.IID == IID).FirstOrDefaultAsync();
            //} else
            //{
            //    return await table.Where(x => x.IID == IID).Include(includeItems).FirstOrDefaultAsync();
            //}
            // Split comma-separated list and apply each include
            if (!string.IsNullOrWhiteSpace(includeItems))
            {
                var includes = includeItems.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var include in includes)
                {
                    query = query.Include(include.Trim());
                }
            }

            return await query.FirstOrDefaultAsync(x => x.IID == IID);
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }

    public async Task<T> GetFirst(string includeItems = "")
    {
        using var _db = GetDBContext();
        try
        {
            //DbSet<T> table = _db.Set<T>();
            IQueryable<T> query = _db.Set<T>();
            //if (string.IsNullOrEmpty(includeItems))
            //{
            //    return await table.FirstOrDefaultAsync();
            //} else
            //{
            //    return await table.Include(includeItems).FirstOrDefaultAsync();
            //}
            if (!string.IsNullOrWhiteSpace(includeItems))
            {
                var includes = includeItems.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var include in includes)
                {
                    query = query.Include(include.Trim());
                }
            }

            return await query.FirstOrDefaultAsync();
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }

    public async Task<T> GetByField(string fieldName, object value, string includeItems = "")
    {
        using var _db = GetDBContext();
        try
        {
            //DbSet<T> _dbSet = _db.Set<T>();
            IQueryable<T> query = _db.Set<T>();

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, fieldName);
            var constant = Expression.Constant(value);
            var equality = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(equality, parameter);

            //if (string.IsNullOrEmpty(includeItems))
            //{
            //    return await _dbSet.Where(lambda).FirstOrDefaultAsync();
            //} else
            //{
            //    return await _dbSet.Where(lambda).Include(includeItems).FirstOrDefaultAsync();
            //}
            if (!string.IsNullOrWhiteSpace(includeItems))
            {
                var includes = includeItems.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var include in includes)
                {
                    query = query.Include(include.Trim());
                }
            }
            return await query.Where(lambda).FirstOrDefaultAsync();
        } catch (Exception ex)
        {
            return null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fieldName"></param>
    /// <param name="value"></param>
    /// <param name="includeItems">Comma seperated list</param>
    /// <param name="OrderByField"></param>
    /// <returns></returns>
    public async Task<List<T>> GetListByField(string fieldName, object value, string includeItems = "", string OrderByField = "")
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> _dbSet = _db.Set<T>();


            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, fieldName);
            var constant = Expression.Constant(value);
            var equality = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(equality, parameter);

            IQueryable<T> query = _dbSet.Where(lambda);

            if (!string.IsNullOrEmpty(includeItems))
            {
                // Split by comma if multiple includes are passed
                foreach (var include in includeItems.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(include.Trim());
                }
            }
            // 3. Setup OrderBy (Dynamic Expression Tree)
            if (!string.IsNullOrEmpty(OrderByField))
            {
                var orderParam = Expression.Parameter(typeof(T), "p");
                var orderProp = Expression.Property(orderParam, OrderByField);
                var orderLambda = Expression.Lambda(orderProp, orderParam);

                // Use reflection to call OrderBy because we don't know the property type at compile time
                var methodName = "OrderBy";
                var method = typeof(Queryable).GetMethods()
                    .First(m => m.Name == methodName && m.GetParameters().Length == 2)
                    .MakeGenericMethod(typeof(T), orderProp.Type);

                query = (IQueryable<T>)method.Invoke(null, new object[] { query, orderLambda });
            }


            return await query.ToListAsync();
        } catch (Exception ex)
        {
            return null;
        }
    }

    //public async Task<T> GetFirst(string includeItems = "")
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        DbSet<T> table = _db.Set<T>();
    //        if (string.IsNullOrEmpty(includeItems))
    //        {
    //            return await table.OrderBy(x => x.DisplayOrder).FirstOrDefaultAsync();
    //        } else
    //        {
    //            return await table.Include(includeItems).OrderBy(x => x.DisplayOrder).FirstOrDefaultAsync();
    //        }
    //    } catch (Exception ex)
    //    {
    //        string str = ex.Message;
    //        return null;
    //    }
    //}
    public async Task<List<T>> GetAllAsync(string includeItems = "")
    {
        using var _db = GetDBContext();
        try
        {
            IQueryable<T> query = _db.Set<T>().AsNoTracking();

            if (string.IsNullOrEmpty(includeItems))
                return await query.ToListAsync();
            else
                return await query.Include(includeItems).ToListAsync();
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }

    public async Task<T> Save(T obj)
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> table = _db.Set<T>();

            T existing = await table.FindAsync(obj.IID);
            if (existing == null)
            {
                //if (obj.DisplayOrder == 0 && table.Count() > 0)
                //    obj.DisplayOrder = table.Max(x => x.DisplayOrder) + 1;
                await table.AddAsync(obj);

            } else
            {
                _db.Entry(existing).CurrentValues.SetValues(obj);
            }
            await _db.SaveChangesAsync();
            return obj;
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }
    //public async Task SaveHierarchy<T>(T rootEntity) 
    //{
    //    using var _db = GetDBContext();
    //    // Use TrackGraph to visit the Parent, Children, and Grandchildren
    //    _db.ChangeTracker.TrackGraph(rootEntity, node =>
    //    {
    //        var entity = (BaseClass)node.Entry.Entity;

    //        // 1. Check if this IID exists in the Database
    //        // Use 'Any' for a fast check without loading the whole object
    //        var exists = _db.Set(node.Entry.Metadata.ClrType)
    //                             .Cast<BaseClass>()
    //                             .Any(e => e.IID == entity.IID);

    //        if (exists)
    //        {
    //            // If it exists, EF should UPDATE it
    //            node.Entry.State = EntityState.Modified;
    //        } else
    //        {
    //            // If it doesn't exist, EF should INSERT it
    //            node.Entry.State = EntityState.Added;
    //        }
    //    });

    //    await _db.SaveChangesAsync();
    //}

    public async Task SaveHierarchy<T>(T rootEntity)
    {
        using var _db = GetDBContext();
        // TrackGraph visits every entity in the object graph (children, grandchildren, etc.)
        _db.ChangeTracker.TrackGraph(rootEntity, node =>
        {
            var entry = node.Entry;
            var entity = (BaseClass)entry.Entity;

            // 1. If IID is missing, it's brand new
            if (entity.IsNew)
            {
                entry.State = EntityState.Added;
            } else
            {
                // 2. Check if this specific IID is already being tracked in the current context
                var trackedEntry = _db.ChangeTracker.Entries<BaseClass>()
                    .FirstOrDefault(e => e.Entity.IID == entity.IID);

                if (trackedEntry == null)
                {
                    // If it's not tracked, assume it's a new child being added with a manual ID
                    // Alternatively, use 'entry.State = EntityState.Unchanged' if it's an existing reference
                    entry.State = EntityState.Added;
                } else
                {
                    // 3. If it's already tracked, mark it as Modified to capture changes
                    entry.State = EntityState.Modified;
                }
            }
        });

        await _db.SaveChangesAsync();
    }


    public async Task SaveMenuHierarchy(TheMenu menu)
    {
        using var _db = GetDBContext();
        _db.ChangeTracker.TrackGraph(menu, node =>
        {
            // 1. Check if the entity is already being tracked
            var alreadyTracked = _db.ChangeTracker.Entries()
                .Any(e => e.Entity.GetType() == node.Entry.Entity.GetType()
                     && ((BaseClass)e.Entity).IID == ((BaseClass)node.Entry.Entity).IID);

            // 2. If it's not tracked, it's either NEW or needs to be ATTACHED
            if (node.Entry.IsKeySet)
            {
                // If you know this is a mix of new and old, 
                // you can check the DB or just force 'Added' if it's a new child
                node.Entry.State = EntityState.Added;
            } else
            {
                node.Entry.State = EntityState.Added;
            }
        });

        await _db.SaveChangesAsync();
    }

    //public async Task<int> Delete(int Id)
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        DbSet<T> table = _db.Set<T>();
    //        T existing = await table.FindAsync(Id);

    //        if (existing != null)
    //        {
    //            table.Remove(existing);
    //            return await _db.SaveChangesAsync();
    //        } else
    //        {
    //            return 0;
    //        }
    //    } catch (Exception ex)
    //    {
    //        string str = ex.Message;
    //        return 0;
    //    }
    //}

    public async Task<int> Delete(string IID)
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> table = _db.Set<T>();
            T existing = await table.FindAsync(IID);

            if (existing != null)
            {
                table.Remove(existing);
                return await _db.SaveChangesAsync();
            } else
            {
                return 0;
            }
        } catch (Exception ex)
        {
            string str = ex.Message;
            return 0;
        }
    }

    public async Task<int> DeleteAll()
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> table = _db.Set<T>();
            await table.ExecuteDeleteAsync();
            return await _db.SaveChangesAsync();

        } catch (Exception ex)
        {
            string str = ex.Message;
            return 0;
        }
    }


    /// <summary>
    /// Use carefully, Deletes all the items in the database in which value of the fieldName matches...!!!
    /// </summary>
    /// <param name="fieldName"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task<int> DeleteByField(string fieldName, object value)
    {
        using var _db = GetDBContext();
        try
        {
            // Build the dynamic lambda expression
            var predicate = BuildDeletePredicate<T>(fieldName, value);

            // Find the entities matching the predicate
            var entitiesToDelete = _db.Set<T>().Where(predicate);

            // Remove the entities from the context
            _db.Set<T>().RemoveRange(entitiesToDelete);

            // Save the changes to the database
            return await _db.SaveChangesAsync();
        } catch (Exception ex)
        {
            string str = ex.Message;
            return 0;
        }
    }


    /// <summary>
    /// Creates a generic lambda expression for filtering based on a property name and value.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    /// <param name="fieldName">The name of the property to filter on.</param>
    /// <param name="value">The value to match.</param>
    /// <returns>An Expression<Func<T, bool>> predicate for a delete operation.</returns>
    public static Expression<Func<T, bool>> BuildDeletePredicate<T>(string fieldName, object value)
    {
        // Define the parameter for the lambda expression (e.g., `x` in `x => ...`)
        var parameter = Expression.Parameter(typeof(T), "x");

        // Access the property by name (e.g., `x.Id`)
        var member = Expression.Property(parameter, fieldName);

        // Convert the property's value to a constant expression
        var constant = Expression.Constant(value, member.Type);

        // Create the equality comparison (e.g., `x.Id == someValue`)
        var equality = Expression.Equal(member, constant);

        // Combine the parameter and the comparison into a full lambda expression
        return Expression.Lambda<Func<T, bool>>(equality, parameter);
    }


    //public async Task EnsureDisplayOrder()
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        IEnumerable<T> theList = await GetAllAsync();
    //        int count = 0;
    //        foreach (var item in theList)
    //        {
    //            item.DisplayOrder = count++;
    //            _db.Entry(item).State = EntityState.Modified;
    //        }
    //        await _db.SaveChangesAsync();

    //    } catch (Exception ex)
    //    {

    //    }
    //}
    #endregion


    #region VIEW FUNCTIONS
    //public async Task<List<PrinterView>> GetPrinterView()
    //{
    //    var sql = @"
    //                SELECT  ap.IID, ap.ApplicationName, ap.PrinterType, 
    //                        ISNULL(pl.ClientIID, '') AS ClientIID, 
    //                        ISNULL(pl.NetworkName, '') AS NetworkName, 
    //                        ISNULL(pl.DeliveryPrinter, 0) AS DeliveryPrinter, 
    //                        ISNULL(pl.TakeAwayPrinter, 0) AS TakeAwayPrinter, 
    //                        ap.AdminOnly
    //                FROM    dbo.ApplicationPrinter ap 
    //                LEFT OUTER JOIN dbo.PrinterLookup pl ON ap.IID = pl.PrinterIID";

    //    var results = await GetDBContext().Set<PrinterView>()
    //        .FromSqlRaw(sql)
    //        .ToListAsync();

    //    return results;
    //}


    public async Task<List<SessionData>> GetSessionSumView()
    {
        var sql = @"SELECT  TOP (100) PERCENT Sessions.IID, Sessions.StartDate, Sessions.EndDate, COUNT(OrdersView.IID) AS OrderCount, SUM(ISNULL(OrdersView.CalculatedValue, 0)) AS GrossSessionTotal, Sessions.X1Total, 
                         Sessions.X2Total, Sessions.X3Total, Sessions.peny1, Sessions.peny2, Sessions.peny5, Sessions.peny10, Sessions.peny20, Sessions.peny50, Sessions.pound1, Sessions.pound2, 
                         Sessions.pound5, Sessions.pound10, Sessions.pound20, Sessions.pound50, Sessions.pound100, Sessions.pound200, Sessions.pound500, Sessions.pound1000, Sessions.CashTotal, 
                         Sessions.CardTotal, Sessions.OnlineTotal, ISNULL(UncompletedOrdersSessionSum.GrossSessionTotalUncompleted, 0) AS GrossSessionTotalUncompleted
                FROM Sessions LEFT OUTER JOIN
                         UncompletedOrdersSessionSum ON Sessions.IID = UncompletedOrdersSessionSum.SessionIID LEFT OUTER JOIN
                         OrdersView AS OrdersView ON Sessions.IID = OrdersView.SessionIID
                GROUP BY Sessions.IID, Sessions.StartDate, Sessions.EndDate, Sessions.peny1, Sessions.peny5, Sessions.peny10, Sessions.peny20, Sessions.peny50, Sessions.pound1, Sessions.pound5, 
                         Sessions.pound10, Sessions.pound20, Sessions.pound50, Sessions.pound100, Sessions.pound200, Sessions.pound500, Sessions.pound1000, Sessions.CardTotal, 
                         Sessions.OnlineTotal, Sessions.CashTotal, Sessions.pound2, Sessions.peny2, Sessions.X1Total, Sessions.X2Total, Sessions.X3Total, 
                         ISNULL(UncompletedOrdersSessionSum.GrossSessionTotalUncompleted, 0)";
        return await GetDBContext().Set<SessionData>().FromSqlRaw(sql).ToListAsync();
    }

    public async Task<List<StockItemUsage>> GetStockItemUsageView()
    {
        var sql = @"SELECT  Distribution.IID, Distribution.DistributionName, Distribution.ShortName, Distribution.DisplayOrder, Distribution.ParentMenuIID, Menu.MenuName, Distribution.PrinterIID, 
                         ApplicationPrinter.ApplicationName AS PrinterNetworkName
                FROM Distribution LEFT OUTER JOIN
                         ApplicationPrinter ON Distribution.PrinterIID = ApplicationPrinter.IID LEFT OUTER JOIN
                         Menu ON Distribution.ParentMenuIID = Menu.IID";
        return await GetDBContext().Set<StockItemUsage>().FromSqlRaw(sql).ToListAsync();
    }
    public async Task<List<EntityButtonStockItemRecipe>> GetEntityButtonStockItemRecipeView()
    {
        var sql = @"SELECT StockItem.StockName, EntityButton.EntityButtonName, EntityButtonStockItemLookUp.EntityButtonIID, EntityButtonStockItemLookUp.StockItemIID, EntityButtonStockItemLookUp.QuantityType, 
                         EntityButtonStockItemLookUp.Quantity, EntityButton.ParentMenuIID
                FROM EntityButtonStockItemLookUp LEFT OUTER JOIN
                         EntityButton ON EntityButtonStockItemLookUp.EntityButtonIID = EntityButton.IID LEFT OUTER JOIN
                         StockItem ON EntityButtonStockItemLookUp.StockItemIID = StockItem.IID";
        return await GetDBContext().Set<EntityButtonStockItemRecipe>().FromSqlRaw(sql).ToListAsync();
    }

    public async Task<List<DistributionView>> GetDistributionView()
    {
        var sql = @"SELECT Distribution.IID, Distribution.DistributionName, Distribution.ShortName, Distribution.DisplayOrder, Distribution.ParentMenuIID, Menu.MenuName, Distribution.PrinterIID, 
                         ApplicationPrinter.ApplicationName AS PrinterNetworkName
                  FROM Distribution LEFT OUTER JOIN
                         ApplicationPrinter ON Distribution.PrinterIID = ApplicationPrinter.IID LEFT OUTER JOIN
                         Menu ON Distribution.ParentMenuIID = Menu.IID";
        return await GetDBContext().Set<DistributionView>().FromSqlRaw(sql).ToListAsync();
    }

    public async Task<List<OrdersView>> GetOrdersView()
    {
        var sql = @"SELECT TOP (100) PERCENT Orders.IID, Orders.TableIID, Orders.OrderDate, Orders.Covers, Orders.OrderType, Orders.Payment, Orders.CustomerIID, Orders.SessionIID, Orders.Status, 
                         Orders.LockedClientIP, Orders.Instruction, Orders.MoneyPaid, Orders.TableName, Orders.CName, Orders.Postcode, Orders.Address, Orders.Buzzer, Orders.Town, Orders.Tel, 
                         Orders.Mobile, Orders.Email, Orders.UserName, COUNT(OrderItem.IID) AS ItemCount, Orders.TableName + ' ' + Orders.CName + ', ' + Orders.Address AS CustomerDetails, Orders.PaymentFlag, 
                         Orders.Reference, KitchenOrders.OrderNo AS KitchenOrderNo, SUM(ROUND(ISNULL(OrderItem.Quantity * OrderItem.Price, 0) + (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) 
                         - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent)) * Orders.ServiceChargeRate / 100, 2)) AS CalculatedValue, 
                         SUM(ROUND((ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent), 2)) AS CalculatedVat, SUM(ROUND(ISNULL(OrderItem.Quantity * OrderItem.Price, 
                         0) - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent), 2)) AS CalculatedExVatValue, SUM(ROUND((ISNULL(OrderItem.Quantity * OrderItem.Price, 0) 
                         - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent)) * Orders.ServiceChargeRate / 100, 2)) AS ServiceCharge, 
                         SUM(ROUND((ISNULL(OrderItem.Quantity * OrderItem.Price, 0) - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent)) 
                         * Orders.ServiceChargeRate / 100 * Orders.ServiceChargeTaxRate / 100, 2)) AS ServiceChargeTax
                    FROM Orders LEFT OUTER JOIN
                         KitchenOrders ON Orders.IID = KitchenOrders.OrderIID LEFT OUTER JOIN
                         OrderItem ON Orders.IID = OrderItem.ParentOrderIID
                    GROUP BY Orders.IID, Orders.TableIID, Orders.OrderDate, Orders.Covers, Orders.OrderType, Orders.Payment, Orders.CustomerIID, Orders.SessionIID, Orders.Status, Orders.LockedClientIP, 
                         Orders.Instruction, Orders.LockedClientIP, Orders.Instruction, Orders.MoneyPaid, Orders.TableName, Orders.CName, Orders.Postcode, Orders.Address, Orders.Buzzer, Orders.Town, 
                         Orders.Tel, Orders.Mobile, Orders.Email, Orders.UserName, Orders.TableName + ' ' + Orders.CName + ', ' + Orders.Address, Orders.PaymentFlag, Orders.Reference, 
                         KitchenOrders.OrderNo
                    ORDER BY Orders.OrderDate";
        return await GetDBContext().Set<OrdersView>().FromSqlRaw(sql).ToListAsync();
    }

    public async Task<List<TaxSummary>> GetTaxSummaryView()
    {
        var sql = @"SELECT Orders.SessionIID, Sessions.StartDate, Sessions.EndDate, OrderItem.TaxPercent, SUM(ROUND(OrderItem.Quantity * OrderItem.Price, 2)) AS GrossTotal, 
                         SUM(ROUND((OrderItem.Quantity * OrderItem.Price) / (100 + OrderItem.TaxPercent) * OrderItem.TaxPercent, 2)) AS NetTaxValue, SUM(ROUND(ROUND(OrderItem.Quantity * OrderItem.Price, 2) 
                         - ROUND((OrderItem.Quantity * OrderItem.Price) / (100 + OrderItem.TaxPercent) * OrderItem.TaxPercent, 2), 2)) AS TotalNoTax, Orders.Payment
                    FROM OrderItem INNER JOIN
                         Orders ON OrderItem.ParentOrderIID = Orders.IID INNER JOIN
                         Sessions ON Orders.SessionIID = Sessions.IID
                    WHERE (Orders.Status = 3) OR (Orders.Status = 4)
                    GROUP BY OrderItem.TaxPercent, Orders.SessionIID, Sessions.StartDate, Sessions.EndDate, Orders.Payment";
        return await GetDBContext().Set<TaxSummary>().FromSqlRaw(sql).ToListAsync();
    }

    //    public async Task<List<SessionView>> GetSessionView()
    //    {
    //        var sql = @"

    //";
    //        return await GetDBContext().Set<SessionView>().FromSqlRaw(sql).ToListAsync();

    //    }

    #endregion



    //public async Task<string> CurrentSessionIID()
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        return _db.Shops.First().CurrentSessionIID;

    //    } catch (Exception ex)
    //    {
    //        return null;
    //    }
    //}


    public async Task<List<double>> GetAllTaxRatesForMenu(string MenuIID)
    {
        using var _db = GetDBContext();
        try
        {
            var query = _db.Menus.Where(m => m.IID == MenuIID)
                .SelectMany(m => m.categories)
                .SelectMany(c => c.Items);

            var distinctList = await query.Select(ci => ci.SaleTax)
                .Union(query.Select(ci => ci.SitinTax))
                .Union(query.Select(ci => ci.TaTax))
                .Union(query.Select(ci => ci.DTax))
                .ToListAsync();

            return distinctList;
            //var distinctProperties = await _db.Menus
            //        .Where(m => m.IID == MenuIID)
            //        .SelectMany(m => m.categories)          // Flatten Categories
            //        .SelectMany(c => c.Buttons)       // Flatten CategoryItems
            //        .Select(ci => ci.PropertyName)          // Select the specific property
            //        .Distinct()                             // Get only unique values
            //        .ToListAsync();

        } catch (Exception ex)
        {
            return null;
        }



    }



    #region MENU FUNCTIONS
    public async Task<TheMenu> GetMenu(string IID)
    {
        using var _db = GetDBContext();
        try
        {
            return await _db.Menus.Where(x => x.IID == IID)
                .Include(m => m.categories).ThenInclude(c => c.Items)
                .Include(m => m.distributions).FirstOrDefaultAsync();
            
        } catch (Exception ex)
        {
            return null;
        }

    }
    public async Task<TheMenu> SaveMenu(TheMenu menu)
    {
        using var _db = GetDBContext();
        try
        {
            if (menu.IsNew)
            {
                await _db.Menus.AddAsync(menu);
            } else
            {

                
                foreach (var distro in menu.distributions)
                {
                    if (distro.IsNew)
                        await _db.Distributions.AddAsync(distro);
                    else
                        _db.Distributions.Update(distro);
                }
                foreach (var cat in menu.categories)
                {
                    if (cat.IsNew)
                    {
                        await _db.Categories.AddAsync(cat);
                    }                                      
                    else
                    {
                        _db.Categories.Update(cat);
                        
                    }
                    foreach (var item in cat.Items)
                    {
                        if (item.IsNew)
                        {
                            await _db.CategoryItems.AddAsync(item);
                        } else
                        {
                            _db.CategoryItems.Update(item);

                        }
                    }
                }
                _db.Menus.Update(menu);
            }
            await _db.SaveChangesAsync();
            return menu;
        } catch (Exception ex)
        {
            return null;
        }
    }
    #endregion
}
