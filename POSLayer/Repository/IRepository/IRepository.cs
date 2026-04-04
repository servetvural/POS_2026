
using System.ComponentModel;

using Microsoft.EntityFrameworkCore;

using POSLayer.Context;
using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Views;

namespace POSLayer.Repository.IRepository;

public interface IRepository<T> where T : BaseClass
{
    PosDbContext GetDBContext();
    Task<bool> IsDatabaseExist();
    Task<bool> Any();
    Task<bool> Any(string IID);
    Task<T> Get(string IID, string includeItems = "");
    Task<T> GetFirst(string includeItems = "");
    Task<T> GetByField(string fieldName, object value, string includeItems = "");       
    Task<List<T>> GetListByField(string fieldName, object value, string includeItems = "", string OrderByField = "");

    Task<List<T>> GetAllAsync(string includeItems = "");
    Task<T> Save(T obj,string includeItemsOnReturn = "");
    Task<T> SaveByField(string fieldName, object value, T obj, string includeItemsOnReturn = "");
    Task<T> SaveTree(T rootEntity, string includeItemsOnReturn = "");
    Task<int> Delete(string IID);
    Task<int> Delete(T obj);
    Task<int> DeleteAll();
    Task<int> DeleteByField(string fieldName, object value);

    Task Sort();
    Task SortByField(string fieldName, object value);
    Task MoveUp(T item);
    Task MoveUpByField(T item, string fieldName, object value);
    Task MoveDown(T item);
    Task MoveDownByField(T item, string fieldName, object value);






    //Task<List<SessionData>> GetSessionSumView();
    //Task<List<StockItemUsage>> GetStockItemUsageView();

    //Task<List<DistributionView>> GetDistributionView();
    //Task<List<OrdersView>> GetOrdersView();


    Task<List<double>> GetAllTaxRatesForMenu(string MenuIID);


    #region MENU FUNCTIONS
    Task<bool> SetMenuIsActive(string IID);



    #endregion

    #region STOCK ITEM FUNCTIONS
    //Task<List<StockItemView>> GetStockItesWithSupplier(string SupplierIID = null);
    #endregion

    Task<GenericImage> GetImageAsync(string EntityIID);

    Task<double> GetOrdersTotalForPaymentMethod(string sessionIID, PaymentMethods payment);
    Task<List<Order>> GetPendingOrdersForSession(string sessionIID);

    Task<List<Category>> GetCategoryTotalsForSession(string sessionIID);
}