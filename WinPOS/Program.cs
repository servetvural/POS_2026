using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using PosLayer.Repository;

using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinPOS;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = Host.CreateDefaultBuilder()
     .ConfigureServices((context, services) =>
     {
         // 1. Register DbContext (Database First)
         services.AddDbContext<PosDbContext>(options =>
             options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;"));

         // 2. Register Generic Repository
         services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

         // 3. Register Forms (Forms must be in DI to receive injections)
         services.AddTransient<frmMain>();
     })
     .Build();

        using var scope = host.Services.CreateScope();
        var mainForm = scope.ServiceProvider.GetRequiredService<frmMain>();

        Application.Run(mainForm);
    }
}