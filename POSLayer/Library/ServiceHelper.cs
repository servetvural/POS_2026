using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace POSLayer.Library;

public static class ServiceHelper
{
    public static IServiceProvider Services { get; private set; }
    public static void Initialize(IServiceProvider serviceProvider) =>
        Services = serviceProvider;

    public static T GetService<T>()
    {
        if (Services == null)
            return default;
        else     
            return Services.GetService<T>();
    }


    /// <summary>
    /// Gets the DbContext and returns a DbSet for the specified entity type.
    /// </summary>
    public static DbSet<TEntity> GetDbSet<TContext, TEntity>()
        where TContext : DbContext
        where TEntity : class
    {
        return GetService<TContext>().Set<TEntity>();
    }


    /// <summary>
    /// Resolves the generic repository for the specified entity type.
    /// </summary>
    public static IRepository<T> GetRepository<T>() where T : BaseClass
    {
        return Services.GetService<IRepository<T>>();
    }

    public static object GetRepository(Type entityType)
    {
        var repoType = typeof(IRepository<>).MakeGenericType(entityType);
        return Services.GetService(repoType);
    }
}
