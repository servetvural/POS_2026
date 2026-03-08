
using POSLayer.Models;

namespace POSLayer.Repository.IRepository;

public interface IRepository<T> where T : BaseClass
{
    Task<bool> IsDatabaseExist();
   // Task<T> Get(int Id, string includeItems = "");
    Task<T> Get(string IID, string includeItems = "");
    Task<T> GetByField(string fieldName, object value, string includeItems = "");
    Task<IQueryable<T>> GetListByField(string fieldName, object value, string includeItems = "");
    //Task<T> GetFirst(string includeItems = "");
    Task<List<T>> GetAllAsync(string includeItems = "");
    Task<T> Save(T obj);
   // Task<int> Delete(int Id);
    Task<int> Delete(string IID);
    Task<int> DeleteAll();
    Task<int> DeleteByField(string fieldName, object value);
    //Task EnsureDisplayOrder();
}