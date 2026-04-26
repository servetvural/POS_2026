using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Xml.Linq;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;

using POSLayer.Context;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;
using POSLayer.Views;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
    public async Task<bool> Any(string IID)
    {
        using var _db = GetDBContext();
        try
        {
            if (string.IsNullOrEmpty(IID))
                return false;
            return _db.Set<T>().Any(x => x.IID == IID);
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
            IQueryable<T> query = _db.Set<T>();

            // Split comma-separated list and apply each include
            if (!string.IsNullOrWhiteSpace(includeItems))
            {
                var includes = includeItems.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var include in includes)
                {
                    query = query.Include(include.Trim());
                }
            }
            T t = await query.FirstOrDefaultAsync(x => x.IID == IID);

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


            return await query.OrderBy(x => x.DOrder).ToListAsync();
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

            if (!string.IsNullOrWhiteSpace(includeItems))
            {
                var includes = includeItems.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var include in includes)
                {
                    query = query.Include(include.Trim());
                }
            }
            // List<T> theList = await query.ToListAsync();
            return await query.OrderBy(x => x.DOrder).ToListAsync();
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }

    public async Task<T> Save(T obj, string includeItemsOnReturn = "")
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

            if (obj == null)
                return null;
            else
                return await Get(obj.IID, includeItemsOnReturn);
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }

    public async Task<T> SaveByField(string fieldName, object value, T obj, string includeItemsOnReturn = "")
    {
        using var _db = GetDBContext();

        try
        {
            DbSet<T> table = _db.Set<T>();

            T existing = await GetByField(fieldName, value); //  table.FindAsync(obj.IID);
            if (existing == null)
            {
                await table.AddAsync(obj);
            } else
            {
                obj.IID = existing.IID;
                var entry = _db.Entry(existing);
                // This copies all scalar values from 'obj' to 'existing'
                entry.CurrentValues.SetValues(obj);

                // FORCE EF to recognize changes if SetValues is being "lazy"
                entry.State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();

            if (obj == null)
                return null;
            else
                return await Get(obj.IID, includeItemsOnReturn);
        } catch (Exception ex)
        {
            string str = ex.Message;
            return null;
        }
    }

    public async Task<T> SaveTree(T rootEntity, string includeItemsOnReturn = "")
    {
        using var _db = GetDBContext();

        try
        {
            // Step 1: Collect ALL IDs in the graph (Sync - No DB hits here)
            var allIds = new HashSet<string>();
            _db.ChangeTracker.TrackGraph(rootEntity, node =>
            {
                var entity = (BaseClass)node.Entry.Entity;
                if (!string.IsNullOrEmpty(entity.IID))
                    allIds.Add(entity.IID);
                node.Entry.State = EntityState.Detached; // Reset for next step
            });

            // Step 2: Single Async DB hit to find what exists
            // We check against the Menu set because it's the root of your hierarchy
            var existingIds = await _db.Set<T>()
                .Where(x => allIds.Contains(x.IID))
                .Select(x => x.IID)
                .ToListAsync();

            // Step 3: Final pass to set states
            _db.ChangeTracker.TrackGraph(rootEntity, node =>
            {
                var entry = node.Entry;
                var entity = (BaseClass)entry.Entity;

                if (string.IsNullOrEmpty(entity.IID))
                {
                    entry.State = EntityState.Added;
                } else
                {
                    entry.State = EntityState.Modified;
                }
            });

            await _db.SaveChangesAsync();

            if (rootEntity == null)
                return null;
            else
                return await Get(rootEntity.IID, includeItemsOnReturn);
        } catch (Exception ex)
        {
            return null;
        }
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

    public async Task<int> Delete(T obj)
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> table = _db.Set<T>();
            T existing = await table.FindAsync(obj.IID);

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

    public async Task<int> DeleteRange(List<T> items)
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> table = _db.Set<T>();

            // Extract IDs to find all existing records in one query
            var ids = items.Select(x => x.IID).ToList();
            var existingItems = await table.Where(x => ids.Contains(x.IID)).ToListAsync();

            if (existingItems.Any())
            {
                table.RemoveRange(existingItems);
                return await _db.SaveChangesAsync(); // Returns the number of rows deleted
            }

            return 0;
        } catch (Exception ex)
        {
            // Log ex.Message here
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


    public async Task Sort()
    {
        using var _db = GetDBContext();
        try
        {
            IEnumerable<T> theList = await GetAllAsync();
            int count = 1;
            foreach (var item in theList)
            {
                item.DOrder = count++;
                _db.Entry(item).State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();

        } catch (Exception ex)
        {

        }
    }
    public async Task SortByField(string fieldName, object value)
    {
        using var _db = GetDBContext();
        try
        {
            IEnumerable<T> theList = await GetListByField(fieldName, value);
            int count = 1;
            foreach (var item in theList)
            {
                item.DOrder = count++;
                _db.Entry(item).State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();

        } catch (Exception ex)
        {

        }
    }
    public async Task MoveUp(T item)
    {
        using var _db = GetDBContext();
        try
        {
            List<T> theList = await GetAllAsync();
            theList.MoveUp(item);

            foreach (var li in theList)
            {
                _db.Entry(li).State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();

        } catch (Exception ex)
        {

        }
    }
    public async Task MoveUpByField(T item, string fieldName, object value)
    {
        using var _db = GetDBContext();
        try
        {
            List<T> theList = await GetListByField(fieldName, value);
            theList.MoveUp(item);

            foreach (var li in theList)
            {
                _db.Entry(li).State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();

        } catch (Exception ex)
        {

        }
    }
    public async Task MoveDown(T item)
    {
        using var _db = GetDBContext();
        try
        {
            List<T> theList = await GetAllAsync();
            theList.MoveDown(item);

            foreach (var li in theList)
            {
                _db.Entry(li).State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();
        } catch (Exception ex)
        {

        }
    }
    public async Task MoveDownByField(T item, string fieldName, object value)
    {
        using var _db = GetDBContext();
        try
        {
            List<T> theList = await GetListByField(fieldName, value);
            theList.MoveDown(item);

            foreach (var li in theList)
            {
                _db.Entry(li).State = EntityState.Modified;
            }
            await _db.SaveChangesAsync();
        } catch (Exception ex)
        {

        }
    }
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


    //public async Task<List<SessionData>> GetSessionSumView()
    //{
    //    var sql = @"SELECT  TOP (100) PERCENT Sessions.IID, Sessions.StartDate, Sessions.EndDate, COUNT(OrdersView.IID) AS OrderCount, SUM(ISNULL(OrdersView.CalculatedValue, 0)) AS GrossSessionTotal, Sessions.X1Total, 
    //                     Sessions.X2Total, Sessions.X3Total, Sessions.peny1, Sessions.peny2, Sessions.peny5, Sessions.peny10, Sessions.peny20, Sessions.peny50, Sessions.pound1, Sessions.pound2, 
    //                     Sessions.pound5, Sessions.pound10, Sessions.pound20, Sessions.pound50, Sessions.pound100, Sessions.pound200, Sessions.pound500, Sessions.pound1000, Sessions.CashTotal, 
    //                     Sessions.CardTotal, Sessions.OnlineTotal, ISNULL(UncompletedOrdersSessionSum.GrossSessionTotalUncompleted, 0) AS GrossSessionTotalUncompleted
    //            FROM Sessions LEFT OUTER JOIN
    //                     UncompletedOrdersSessionSum ON Sessions.IID = UncompletedOrdersSessionSum.SessionIID LEFT OUTER JOIN
    //                     OrdersView AS OrdersView ON Sessions.IID = OrdersView.SessionIID
    //            GROUP BY Sessions.IID, Sessions.StartDate, Sessions.EndDate, Sessions.peny1, Sessions.peny5, Sessions.peny10, Sessions.peny20, Sessions.peny50, Sessions.pound1, Sessions.pound5, 
    //                     Sessions.pound10, Sessions.pound20, Sessions.pound50, Sessions.pound100, Sessions.pound200, Sessions.pound500, Sessions.pound1000, Sessions.CardTotal, 
    //                     Sessions.OnlineTotal, Sessions.CashTotal, Sessions.pound2, Sessions.peny2, Sessions.X1Total, Sessions.X2Total, Sessions.X3Total, 
    //                     ISNULL(UncompletedOrdersSessionSum.GrossSessionTotalUncompleted, 0)";
    //    return await GetDBContext().Set<SessionData>().FromSqlRaw(sql).ToListAsync();
    //}

    //public async Task<List<StockItemUsage>> GetStockItemUsageView()
    //{
    //    var sql = @"SELECT  Distribution.IID, Distribution.DistributionName, Distribution.ShortName, Distribution.DisplayOrder, Distribution.ParentMenuIID, Menu.MenuName, Distribution.PrinterIID, 
    //                     ApplicationPrinter.ApplicationName AS PrinterNetworkName
    //            FROM Distribution LEFT OUTER JOIN
    //                     ApplicationPrinter ON Distribution.PrinterIID = ApplicationPrinter.IID LEFT OUTER JOIN
    //                     Menu ON Distribution.ParentMenuIID = Menu.IID";
    //    return await GetDBContext().Set<StockItemUsage>().FromSqlRaw(sql).ToListAsync();
    //}

    //public async Task<List<EntityButtonStockItemRecipe>> GetEntityButtonStockItemRecipeView()
    //{
    //    var sql = @"SELECT StockItem.StockName, EntityButton.EntityButtonName, EntityButtonStockItemLookUp.EntityButtonIID, EntityButtonStockItemLookUp.StockItemIID, EntityButtonStockItemLookUp.QuantityType, 
    //                     EntityButtonStockItemLookUp.Quantity, EntityButton.ParentMenuIID
    //            FROM EntityButtonStockItemLookUp LEFT OUTER JOIN
    //                     EntityButton ON EntityButtonStockItemLookUp.EntityButtonIID = EntityButton.IID LEFT OUTER JOIN
    //                     StockItem ON EntityButtonStockItemLookUp.StockItemIID = StockItem.IID";
    //    return await GetDBContext().Set<EntityButtonStockItemRecipe>().FromSqlRaw(sql).ToListAsync();
    //}

    //public async Task<List<DistributionView>> GetDistributionView()
    //{
    //    var sql = @"SELECT Distribution.IID, Distribution.DistributionName, Distribution.ShortName, Distribution.DisplayOrder, Distribution.ParentMenuIID, Menu.MenuName, Distribution.PrinterIID, 
    //                     ApplicationPrinter.ApplicationName AS PrinterNetworkName
    //              FROM Distribution LEFT OUTER JOIN
    //                     ApplicationPrinter ON Distribution.PrinterIID = ApplicationPrinter.IID LEFT OUTER JOIN
    //                     Menu ON Distribution.ParentMenuIID = Menu.IID";
    //    return await GetDBContext().Set<DistributionView>().FromSqlRaw(sql).ToListAsync();
    //}

    //public async Task<List<OrdersView>> GetOrdersView()
    //{
    //    var sql = @"SELECT TOP (100) PERCENT Orders.IID, Orders.TableIID, Orders.OrderDate, Orders.Covers, Orders.OrderType, Orders.Payment, Orders.CustomerIID, Orders.SessionIID, Orders.Status, 
    //                     Orders.LockedClientIP, Orders.Instruction, Orders.MoneyPaid, Orders.TableName, Orders.CName, Orders.Postcode, Orders.Address, Orders.Buzzer, Orders.Town, Orders.Tel, 
    //                     Orders.Mobile, Orders.Email, Orders.UserName, COUNT(OrderItem.IID) AS ItemCount, Orders.TableName + ' ' + Orders.CName + ', ' + Orders.Address AS CustomerDetails, Orders.PaymentFlag, 
    //                     Orders.Reference, KitchenOrders.OrderNo AS KitchenOrderNo, SUM(ROUND(ISNULL(OrderItem.Quantity * OrderItem.Price, 0) + (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) 
    //                     - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent)) * Orders.ServiceChargeRate / 100, 2)) AS CalculatedValue, 
    //                     SUM(ROUND((ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent), 2)) AS CalculatedVat, SUM(ROUND(ISNULL(OrderItem.Quantity * OrderItem.Price, 
    //                     0) - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent), 2)) AS CalculatedExVatValue, SUM(ROUND((ISNULL(OrderItem.Quantity * OrderItem.Price, 0) 
    //                     - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent)) * Orders.ServiceChargeRate / 100, 2)) AS ServiceCharge, 
    //                     SUM(ROUND((ISNULL(OrderItem.Quantity * OrderItem.Price, 0) - (ISNULL(OrderItem.Quantity * OrderItem.Price, 0) * OrderItem.TaxPercent) / (100 + OrderItem.TaxPercent)) 
    //                     * Orders.ServiceChargeRate / 100 * Orders.ServiceChargeTaxRate / 100, 2)) AS ServiceChargeTax
    //                FROM Orders LEFT OUTER JOIN
    //                     KitchenOrders ON Orders.IID = KitchenOrders.OrderIID LEFT OUTER JOIN
    //                     OrderItem ON Orders.IID = OrderItem.ParentOrderIID
    //                GROUP BY Orders.IID, Orders.TableIID, Orders.OrderDate, Orders.Covers, Orders.OrderType, Orders.Payment, Orders.CustomerIID, Orders.SessionIID, Orders.Status, Orders.LockedClientIP, 
    //                     Orders.Instruction, Orders.LockedClientIP, Orders.Instruction, Orders.MoneyPaid, Orders.TableName, Orders.CName, Orders.Postcode, Orders.Address, Orders.Buzzer, Orders.Town, 
    //                     Orders.Tel, Orders.Mobile, Orders.Email, Orders.UserName, Orders.TableName + ' ' + Orders.CName + ', ' + Orders.Address, Orders.PaymentFlag, Orders.Reference, 
    //                     KitchenOrders.OrderNo
    //                ORDER BY Orders.OrderDate";
    //    return await GetDBContext().Set<OrdersView>().FromSqlRaw(sql).ToListAsync();
    //}

    //public async Task<List<TaxSummary>> GetTaxSummaryView()
    //{
    //    var sql = @"SELECT Orders.SessionIID, Sessions.StartDate, Sessions.EndDate, OrderItem.TaxPercent, SUM(ROUND(OrderItem.Quantity * OrderItem.Price, 2)) AS GrossTotal, 
    //                     SUM(ROUND((OrderItem.Quantity * OrderItem.Price) / (100 + OrderItem.TaxPercent) * OrderItem.TaxPercent, 2)) AS NetTaxValue, SUM(ROUND(ROUND(OrderItem.Quantity * OrderItem.Price, 2) 
    //                     - ROUND((OrderItem.Quantity * OrderItem.Price) / (100 + OrderItem.TaxPercent) * OrderItem.TaxPercent, 2), 2)) AS TotalNoTax, Orders.Payment
    //                FROM OrderItem INNER JOIN
    //                     Orders ON OrderItem.ParentOrderIID = Orders.IID INNER JOIN
    //                     Sessions ON Orders.SessionIID = Sessions.IID
    //                WHERE (Orders.Status = 3) OR (Orders.Status = 4)
    //                GROUP BY OrderItem.TaxPercent, Orders.SessionIID, Sessions.StartDate, Sessions.EndDate, Orders.Payment";
    //    return await GetDBContext().Set<TaxSummary>().FromSqlRaw(sql).ToListAsync();
    //}

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
    public async Task<bool> SetMenuIsActive(string IID)
    {
        using var _db = GetDBContext();
        try
        {
            foreach (var menu in _db.Menus)
            {
                if (menu.IID == IID)
                    menu.IsActive = true;
                else
                    menu.IsActive = false;
            }
            await _db.SaveChangesAsync();
            return true;
        } catch (Exception ex)
        {
            return false;
        }
    }


    #endregion

    #region STOCK FUNCTIONS

    //public async Task<List<StockItemView>> GetStockItesWithSupplier(string SupplierIID = null)
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        var query = _db.StockItems.Join(_db.Suppliers,
    //stock => stock.SupplierIID,      // Key from first list
    //supp => supp.IID,   // Key from second list
    //(stock, supp) => new StockItemView {   // Resulting "merged" object
    //    student.Name,
    //    score.Grade
    //});


    //    if (string.IsNullOrEmpty(SupplierIID))
    //    {
    //        var sql = @"SELECT StockItem.*, Supplier.SupplierName
    //                FROM StockItem LEFT OUTER JOIN
    //                     Supplier ON StockItem.SupplierIID = Supplier.IID";
    //        return await GetDBContext().Set<StockItemView>().FromSqlRaw(sql).ToListAsync();
    //    } else
    //    {
    //        var sql = @"SELECT StockItem.*, Supplier.SupplierName
    //                FROM StockItem LEFT OUTER JOIN
    //                     Supplier ON StockItem.SupplierIID = Supplier.IID
    //                WHERE StockItem.SupplierIID = '" + SupplierIID + "'";
    //        return await GetDBContext().Set<StockItemView>().FromSqlRaw(sql).ToListAsync();
    //    }
    //    } catch (Exception ex)
    //    {
    //        return null;
    //    }
    //}
    //public async Task<List<StockItem>> GetStockItemsForMenu(string MenuIID)
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        var stockItems = await _db.Menus.Where(m => m.IID == MenuIID)
    //            .SelectMany(m => m.categories)
    //            .SelectMany(c => c.Items)
    //            .SelectMany(i => new[] { i.StockItem1, i.StockItem2, i.StockItem3, i.StockItem4, i.StockItem5 })
    //            .Where(si => si != null) // Filter out nulls
    //            .Distinct() // Get unique stock items
    //            .ToListAsync();
    //        return stockItems;
    //    } catch (Exception ex)
    //    {
    //        return null;
    //    }
    //}

    #endregion

    public async Task<List<RecipeUsage>> GetSessionRecipeUsage(string sessionIID)
    {
        using var _db = GetDBContext();
        try
        {
            //var oitems = _db.OrderItems.Where(oi => oi.Order.SessionIID == sessionIID).Include(oi => oi.CategoryItem).ThenInclude(c => c.recipes);
           // var ritems = oitems.SelectMany(oi => oi.CategoryItem.recipes.Where(ci => ci.StockItemIID != null)).Include(s => s.StockItem);



            List<RecipeUsage> recipeSummary = await _db.OrderItems
                .Where(oi => oi.Order.SessionIID == sessionIID)
                // 1. Use the (collection, result) overload of SelectMany
                .SelectMany(
                    oi => oi.CategoryItem.recipes.Where(ri => ri.StockItemIID != null),
                    (oi, ri) => new {
                        RecipeIID = ri.IID,
                        StockItemIID = ri.StockItemIID,
                        StockItemName = ri.StockItem.StockName,
                        QuantityType = ri.QuantityType,
                        // Both 'oi' and 'ri' are accessible here for translation
                        CalculatedUsage = (decimal)oi.Quantity * (decimal)ri.Quantity
                    }
                )
                // 2. Group the flat results
                .GroupBy(r => new { r.RecipeIID, r.StockItemIID, r.StockItemName, r.QuantityType })
                .Select(g => new RecipeUsage
                {
                    IID = g.Key.RecipeIID,
                    StockItemIID = g.Key.StockItemIID,
                    StockItemName = g.Key.StockItemName,
                    Quantity = (double)g.Sum(x => x.CalculatedUsage),
                    QuantityType =   g.Key.QuantityType
                })
                .ToListAsync();

            return recipeSummary;

        } catch (Exception ex)
        {
            return new List<RecipeUsage>();
        }
    }

    public async  Task<List<OrderItemSummary>> GetSessionOrderItemSummary(string sessionIID)
    {
        using var _db = GetDBContext();
        try
        {
            var summary = await _db.OrderItems
                .Where(oi => oi.Order.SessionIID == sessionIID)
                .GroupBy(oi => new { oi.CategoryItemIID, oi.CategoryItem.ItemName, oi.Price  })
                .Select(g => new OrderItemSummary
                {                              
                    OrderItemText = g.Key.ItemName,
                    Quantity = g.Sum(oi => oi.Quantity),
                    Price = g.Key.Price,
                    Total = g.Sum(oi => oi.Quantity * oi.Price)
                })
                .ToListAsync();
            return summary;
        } catch (Exception ex)
        {
            return new List<OrderItemSummary>();
        }   
    }

    //public async Task<Order> BarrowOrder(string OrderIID, string ClientIP)
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        Order order = await _db.Orders.FirstOrDefaultAsync(x => x.IID == OrderIID);
    //        if (order == null )
    //            return null;
    //        if (order.LockedClientIP == null)
    //        {
    //            order.LockedClientIP = ClientIP;
    //            _db.Orders.Update(order);
    //            await _db.SaveChangesAsync();
    //            return order;
    //        } else
    //        { 
    //            if (order.LockedClientIP == ClientIP)
    //            {
    //                return order;
    //            } else
    //            {
    //                return null;
    //            }
    //        }
    //    } catch (Exception ex)
    //    {
    //        return null;
    //    }        
    //}

    //public async Task ReturnOrder(Order order)
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {

    //    } catch (Exception ex)
    //    {
    //        return null;
    //    }


    //    if (order.OrderType == OrderTypes.Sitin)
    //        this.ReturnTable(order);
    //    else
    //    {
    //        if (order.Items.Count > 0)
    //        {
    //            order.LockedClientIP = "";
    //            order.TableIID = "";
    //            await SaveOrder(order);
    //        } else
    //            await DeleteOrder(order.IID);
    //    }
    //}


    //public async Task<Masa> GetTableToEditAsync(string tableIID, string terminalName)
    //{
    //    using var _db = GetDBContext();
    //    try
    //    {
    //        // 1.Fetch the current state
    //        var table = await _db.Tables.FindAsync(tableIID);

    //        if (table == null)
    //            return null;

    //        // 2. Check if it's already locked by someone else and NOT expired
    //        bool isLockedByOthers = table.LockedClientIP != null
    //                                && table.LockedClientIP != terminalName
    //                                && table.LockedUntil > DateTime.UtcNow;
    //        if (isLockedByOthers)
    //        {
    //            return null;
    //        }
    //        // 3. Apply your lock
    //        table.LockedClientIP = terminalName;
    //        table.LockedUntil = DateTime.UtcNow.AddMinutes(5);

    //        // 4. Save Changes
    //        // EF Core will compare the RowVersion. If another terminal saved 
    //        // a lock 0.001s before you, this will throw an exception.
    //        await _db.SaveChangesAsync();

    //        Order order = await _db.Orders.Where(x => x.TableIID == tableIID && x.OrderType == OrderTypes.Sitin && 
    //        (x.Status == StatusFlags.Unknown || x.Status == StatusFlags.New || x.Status == StatusFlags.Done)
    //        ).FirstOrDefaultAsync();

    //        //if (order == )



    //        table = await _db.Tables.Where(x => x.IID == tableIID)
    //            .Include(x => x.orders.Where(o => o.Status == StatusFlags.New || o.Status == StatusFlags.Done)).FirstOrDefaultAsync();
    //        return table;

    //    } catch (Exception ex)
    //    {
    //        return null;
    //    }
    //}


    /// <summary>
    /// Gets the first table that has one or more active sit-in orders with a status of Unknown, New, or Done.
    /// </summary>
    /// <remarks>Active orders are considered those with an order type of sit-in and a status of Unknown, New,
    /// or Done. Only the first matching table is returned. The result includes the related orders that meet these
    /// criteria.</remarks>
    /// <returns>A <see cref="Masa"/> object representing the first table with active sit-in orders, or <see langword="null"/> if
    /// no such table exists.</returns>
    public async Task<List<Masa>> GetAllTablesWithActiveOrders()
    {
        using var _db = GetDBContext();
        try
        {
            return await _db.Tables.Include(x => x.orders.Where(x => x.OrderType == OrderTypes.Sitin &&
            ( x.Status == StatusFlags.New || x.Status == StatusFlags.Done))).ToListAsync();

        } catch (Exception ex)
        {
            return new List<Masa>();
        }
    }


    public async Task<List<Masa>> GetAllTablesWithActiveOrders(string salonIID)
    {
        using var _db = GetDBContext();
        try
        {
            return await _db.Tables.Where(x => x.SalonIID == salonIID).Include(x => x.orders.Where(x => x.OrderType == OrderTypes.Sitin &&
            ( x.Status == StatusFlags.New || x.Status == StatusFlags.Done))).ThenInclude(o => o.Items).ToListAsync();

        } catch (Exception ex)
        {
            return new List<Masa>();
        }

    }


    /// <summary>
    /// Retrieves a table by its identifier, including only active sit-in orders associated with the table.
    /// </summary>
    /// <remarks>Active orders are those with a status of Unknown, New, or Done and an order type of Sitin.
    /// Only these orders are included in the returned table's order collection.</remarks>
    /// <param name="tableIID">The unique identifier of the table to retrieve. Cannot be null.</param>
    /// <returns>A <see cref="Masa"/> object representing the table and its active sit-in orders, or <see langword="null"/> if
    /// the table is not found.</returns>
    public async Task<Masa> GetTableWithActiveOrders(string tableIID)
    {
        using var _db = GetDBContext();
        try
        {
            return  await _db.Tables.Where(x => x.IID == tableIID).Include(x => x.orders.Where(x => x.TableIID == tableIID && x.OrderType == OrderTypes.Sitin &&
            (x.Status == StatusFlags.New || x.Status == StatusFlags.Done))).FirstOrDefaultAsync();             

        } catch (Exception ex)
        {
            return null;
        }
    }


    /// <summary>
    /// Retrieves an order for editing and applies a temporary lock to prevent concurrent modifications from other
    /// terminals.
    /// </summary>
    /// <remarks>If the order is already locked by another terminal and the lock has not expired, the method
    /// returns null. The lock is set for five minutes from the time of the request. If the order is of type 'Sitin' and
    /// associated with a table, the table is also locked for the same duration. If a concurrency conflict occurs while
    /// saving the lock, the method returns null.</remarks>
    /// <param name="orderIID">The unique identifier of the order to retrieve and lock for editing.</param>
    /// <param name="terminalName">The name of the terminal requesting to edit the order. Used to identify the lock owner.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the order if it is available for
    /// editing and successfully locked; otherwise, null.</returns>
    public async Task<Order> GetOrderToEditAsync(string orderIID, string terminalName)
    {
        using var _db = GetDBContext();
        try
        {
            // 1.Fetch the current state
            var order = await _db.Orders.Where(x => x.IID == orderIID).Include("Table").Include("Items").FirstOrDefaultAsync();

            if (order == null)
                return null;

            bool isCompletedSitinOrder = order.OrderType == OrderTypes.Sitin && (order.Status == StatusFlags.Completed || order.Status == StatusFlags.Archived);

            // 2. Check if it's already locked by someone else and NOT expired
            bool isLockedByOthers = order.LockedClientIP != null
                                    && order.LockedClientIP != terminalName
                                    && order.LockedUntil > DateTime.UtcNow;
            if (isLockedByOthers)
            {
                return null;
            }
            // 3. Apply your lock
            order.LockedClientIP = terminalName;
            order.LockedUntil = DateTime.UtcNow.AddMinutes(5);

            //dont lock the table if it's a completed sitin order,
            if (order.OrderType == OrderTypes.Sitin && !isCompletedSitinOrder && order.Table != null )
            {
                order.Table.LockedClientIP = terminalName;
                order.Table.LockedUntil = order.LockedUntil;
            }


            // 4. Save Changes
            // EF Core will compare the RowVersion. If another terminal saved 
            // a lock 0.001s before you, this will throw an exception.
            await _db.SaveChangesAsync();

            return order;

        } catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<Order> GetTableWithOrderToEditAsync(string tableIID, string terminalName)
    {
        using var _db = GetDBContext();
        try
        {
            var order = await _db.Orders.Where(x => x.TableIID == tableIID &&
                ( x.Status == StatusFlags.New || x.Status == StatusFlags.Done)).Include("Table").Include("Items").FirstOrDefaultAsync();

            if (order == null)
            {
                order = new Order()
                {
                    OrderType = OrderTypes.Sitin,
                    TableIID = tableIID,
                };
            } else
            {
                // 2. Check if it's already locked by someone else and NOT expired
                bool isLockedByOthers = !string.IsNullOrWhiteSpace(order.LockedClientIP)
                                        && order.LockedClientIP != terminalName
                                        && order.LockedUntil > DateTime.UtcNow;
                if (isLockedByOthers)
                {
                    return null;
                }
            }
            // 3. Apply your lock
            order.LockedClientIP = terminalName;
            order.LockedUntil = DateTime.Now.AddMinutes(5);

            if (order.OrderType == OrderTypes.Sitin && order.Table != null)
            {
                order.Table.LockedClientIP = terminalName;
                order.Table.LockedUntil = order.LockedUntil;
            }

            if (order.IID == null)
            {
                _db.Orders.Add(order);
            }

            // 4. Save Changes
            // EF Core will compare the RowVersion. If another terminal saved 
            // a lock 0.001s before you, this will throw an exception.
            await _db.SaveChangesAsync();


            return await GetOrderToEditAsync(order.IID, terminalName);// order;

        } catch (Exception ex)
        {
            return null;
        }
    }


   


    public async Task<GenericImage> GetImageAsync(string EntityIID)
    {
        using var _db = GetDBContext();
        try
        {
            GenericImage gim = await _db.Images.Where(img => img.ReferenceIID == EntityIID).FirstOrDefaultAsync();
            return gim;
        } catch (Exception ex)
        {
            return null;
        }
    }



    public async Task<double> GetOrdersTotalForPaymentMethod(string sessionIID, PaymentMethods payment)
    {
        using var _db = GetDBContext();
        try
        {
            return _db.Orders.Where(x => x.SessionIID == sessionIID && (x.Status == StatusFlags.Completed || x.Status == StatusFlags.Archived) && x.Payment == payment).Sum(x => x.Total);
        } catch (Exception ex)
        {
            return -1;
        }
    }

    public async Task<List<Order>> GetPendingOrdersForSession(string sessionIID)
    {
        using var _db = GetDBContext();
        try
        {
            return await _db.Orders.Where(x => x.Payment == PaymentMethods.NotPaid && x.Status == StatusFlags.Holding && x.SessionIID == sessionIID).Include("Items").ToListAsync();
        } catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<List<Category>> GetCategoryTotalsForSession(string sessionIID)
    {
        using var _db = GetDBContext();
        try
        {
            var rawData = await _db.OrderItems
            .Where(oi => oi.Order.SessionIID == sessionIID)
            .GroupBy(oi => oi.CategoryItem.CategoryIID)
            .Select(g => new
            {
                Category = g.FirstOrDefault().CategoryItem.Category,
                CategoryIID = g.Key,
                TotalSum = g.Sum(oi => oi.Total)
            })
            .ToListAsync();

            // 2. Map the calculated sum back to the Category property in memory
            foreach (var item in rawData)
            {
                if (item.Category != null)
                {
                    // Assuming your Category class has a 'TotalSum' property
                    item.Category.CategoryTotal = item.TotalSum;
                }
            }
            // 3. Get the list of updated categories
            return rawData.Select(x => x.Category).ToList();


        } catch (Exception ex)
        {
            return null;
        }
    }

    /// <summary>
    /// Retrieves a shop by its identifier, including the current session and associated bonus information.
    /// </summary>
    /// <param name="ShopIID"></param>
    /// <returns></returns>
    public async Task<Shop> GetShopWithCurrentSession(string ShopIID)
    {
        using var _db = GetDBContext();
        try
        {
            var shop = await _db.Shops.Include(b => b.Bonus).FirstOrDefaultAsync(s => s.IID == ShopIID);

            if (shop != null && !string.IsNullOrEmpty(shop.CurrentSessionIID))
            {
                // Explicitly load only the session matching the CurrentSessionIID
                shop.sessions.Add(await _db.Sessions.FirstOrDefaultAsync(s => s.IID == shop.CurrentSessionIID));
            }
            return shop;
        } catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<double> GetSessionOrderTotal(string sessionIID)
    {
        using var _db = GetDBContext();
        try
        {
            var session = await _db.Sessions
                 .Where(s => s.IID == sessionIID)
                 .Include(s => s.Orders)
                     .ThenInclude(o => o.Items)
                 .FirstOrDefaultAsync();

            if (session == null)
                return 0;

            return session.Total;

        } catch (Exception ex)
        {
            return 0;
        }
    }

    public async Task MoveXOrdersToOrdersAsync(int sessionIID)
    {
        // Access the underlying DbContext from your repository
        using var _db = GetDBContext();

        using var transaction = await _db.Database.BeginTransactionAsync();

        try
        {
            // 1. Define the SQL (using parameters to prevent SQL Injection)
            var sql = @"
            -- Move Items first (due to Foreign Key constraints)
            INSERT INTO OrderItem (ParentOrderIID, ProductID, Quantity, Price) -- List specific columns
            SELECT ParentOrderIID, ProductID, Quantity, Price 
            FROM XOrderItem 
            WHERE ParentOrderIID IN (SELECT IID FROM XOrders WHERE SessionIID = @sessionIID);

            -- Delete moved Items
            DELETE FROM XOrderItem 
            WHERE ParentOrderIID IN (SELECT IID FROM XOrders WHERE SessionIID = @sessionIID);

            -- Move Orders
            INSERT INTO Orders (IID, SessionIID, OrderDate, Total) -- List specific columns
            SELECT IID, SessionIID, OrderDate, Total 
            FROM XOrders 
            WHERE SessionIID = @sessionIID;

            -- Delete moved Orders
            DELETE FROM XOrders WHERE SessionIID = @sessionIID;";

            // 2. Execute the raw SQL
            await _db.Database.ExecuteSqlRawAsync(sql, new SqlParameter("@sessionIID", sessionIID));

            // 3. Commit the transaction
            await transaction.CommitAsync();
        } catch (Exception)
        {
            // If anything fails, rollback changes automatically
            await transaction.RollbackAsync();
            throw;
        }
    }
}
