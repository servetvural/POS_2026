using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using POSLayer.Models;
using POSLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using POSLayer.Views;
using POSLayer.Library;

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

    public async Task<T> Get(string IID, string includeItems = "")
    {
        using var _db = GetDBContext();
        try
        {
            DbSet<T> table = _db.Set<T>();
            if (string.IsNullOrEmpty(includeItems))
            {
                return await table.Where(x => x.IID == IID).FirstOrDefaultAsync();
            } else
            {
                return await table.Where(x => x.IID == IID).Include(includeItems).FirstOrDefaultAsync();
            }
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
            DbSet<T> _dbSet = _db.Set<T>();

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, fieldName);
            var constant = Expression.Constant(value);
            var equality = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(equality, parameter);

            if (string.IsNullOrEmpty(includeItems))
            {
                return await _dbSet.Where(lambda).FirstOrDefaultAsync();
            } else
            {
                return await _dbSet.Where(lambda).Include(includeItems).FirstOrDefaultAsync();
            }
        } catch (Exception ex)
        {
            return null;
        }
    }

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
            DbSet<T> table = _db.Set<T>();
            if (string.IsNullOrEmpty(includeItems))
                return await table.ToListAsync();
            else
                return await table.Include(includeItems).ToListAsync();
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


    public async Task<IEnumerable<SessionData>> GetSessionSumView()
    {
        var sql = @"
                SELECT        TOP (100) PERCENT Sessions.IID, Sessions.StartDate, Sessions.EndDate, COUNT(OrdersView.IID) AS OrderCount, SUM(ISNULL(OrdersView.CalculatedValue, 0)) AS GrossSessionTotal, Sessions.X1Total, 
                         Sessions.X2Total, Sessions.X3Total, Sessions.peny1, Sessions.peny2, Sessions.peny5, Sessions.peny10, Sessions.peny20, Sessions.peny50, Sessions.pound1, Sessions.pound2, 
                         Sessions.pound5, Sessions.pound10, Sessions.pound20, Sessions.pound50, Sessions.pound100, Sessions.pound200, Sessions.pound500, Sessions.pound1000, Sessions.CashTotal, 
                         Sessions.CardTotal, Sessions.OnlineTotal, ISNULL(UncompletedOrdersSessionSum.GrossSessionTotalUncompleted, 0) AS GrossSessionTotalUncompleted
                FROM            Sessions LEFT OUTER JOIN
                         UncompletedOrdersSessionSum ON Sessions.IID = UncompletedOrdersSessionSum.SessionIID LEFT OUTER JOIN
                         OrdersView AS OrdersView ON Sessions.IID = OrdersView.SessionIID
                GROUP BY Sessions.IID, Sessions.StartDate, Sessions.EndDate, Sessions.peny1, Sessions.peny5, Sessions.peny10, Sessions.peny20, Sessions.peny50, Sessions.pound1, Sessions.pound5, 
                         Sessions.pound10, Sessions.pound20, Sessions.pound50, Sessions.pound100, Sessions.pound200, Sessions.pound500, Sessions.pound1000, Sessions.CardTotal, 
                         Sessions.OnlineTotal, Sessions.CashTotal, Sessions.pound2, Sessions.peny2, Sessions.X1Total, Sessions.X2Total, Sessions.X3Total, 
                         ISNULL(UncompletedOrdersSessionSum.GrossSessionTotalUncompleted, 0)
                ";
        return await GetDBContext().Set<SessionData>().FromSqlRaw(sql).ToListAsync();
    }

    public async Task<IEnumerable<StockItemUsage>> GetStockItemUsageView()
    {
        var sql = @"   
                SELECT  Distribution.IID, Distribution.DistributionName, Distribution.ShortName, Distribution.DisplayOrder, Distribution.ParentMenuIID, Menu.MenuName, Distribution.PrinterIID, 
                         ApplicationPrinter.ApplicationName AS PrinterNetworkName
                FROM            Distribution LEFT OUTER JOIN
                         ApplicationPrinter ON Distribution.PrinterIID = ApplicationPrinter.IID LEFT OUTER JOIN
                         Menu ON Distribution.ParentMenuIID = Menu.IID
                ";
        return await GetDBContext().Set<StockItemUsage>().FromSqlRaw(sql).ToListAsync();
    }
    public async Task<IEnumerable<EntityButtonStockItemRecipe>> GetEntityButtonStockItemRecipeView()
    {
        var sql = @"
                SELECT        StockItem.StockName, EntityButton.EntityButtonName, EntityButtonStockItemLookUp.EntityButtonIID, EntityButtonStockItemLookUp.StockItemIID, EntityButtonStockItemLookUp.QuantityType, 
                         EntityButtonStockItemLookUp.Quantity, EntityButton.ParentMenuIID
                FROM            EntityButtonStockItemLookUp LEFT OUTER JOIN
                         EntityButton ON EntityButtonStockItemLookUp.EntityButtonIID = EntityButton.IID LEFT OUTER JOIN
                         StockItem ON EntityButtonStockItemLookUp.StockItemIID = StockItem.IID
                ";
        return await GetDBContext().Set<EntityButtonStockItemRecipe>().FromSqlRaw(sql).ToListAsync();   
    }
    #endregion
}
