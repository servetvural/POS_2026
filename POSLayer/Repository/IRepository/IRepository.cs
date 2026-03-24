
using Microsoft.EntityFrameworkCore;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Views;

namespace POSLayer.Repository.IRepository;

public interface IRepository<T> where T : BaseClass
{
    PosDbContext GetDBContext();
    Task<bool> IsDatabaseExist();
    // Task<T> Get(int Id, string includeItems = "");

    Task<bool> Any();
    Task<T> Get(string IID, string includeItems = "");

    Task<T> GetFirst(string includeItems = "");

    Task<T> GetByField(string fieldName, object value, string includeItems = "");       
    Task<List<T>> GetListByField(string fieldName, object value, string includeItems = "", string OrderByField = "");
    //Task<T> GetFirst(string includeItems = "");
    Task<List<T>> GetAllAsync(string includeItems = "");
    Task<T> Save(T obj);
    Task SaveHierarchy<T>(T rootEntity);

Task SaveMenuHierarchy(TheMenu menu);
   // Task<int> Delete(int Id);
    Task<int> Delete(string IID);
    Task<int> DeleteAll();
    Task<int> DeleteByField(string fieldName, object value);
    //Task EnsureDisplayOrder();



    //Task<List<PrinterView>> GetPrinterView();
    Task<List<SessionData>> GetSessionSumView();
    Task<List<StockItemUsage>> GetStockItemUsageView();

    Task<List<EntityButtonStockItemRecipe>> GetEntityButtonStockItemRecipeView();
    Task<List<DistributionView>> GetDistributionView();
    Task<List<OrdersView>> GetOrdersView();


    //Task<string> CurrentSessionIID();

    Task<List<double>> GetAllTaxRatesForMenu(string MenuIID);


    #region MENU FUNCTIONS
    Task<TheMenu> GetMenu(string IID);

    Task<TheMenu> SaveMenu(TheMenu menu);

    #endregion
}