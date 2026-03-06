using Microsoft.EntityFrameworkCore;

using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace PosLayer.Repository;

public class Repository<T>(PosDbContext context) : IRepository<T> where T : class
{
    private readonly PosDbContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public async Task<List<T>> GetAllAsync() => await _dbSet.ToListAsync();
    public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
    public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}
