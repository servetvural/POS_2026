using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DTRMNS;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using PosLayer.Repository;

using POSLayer.Library;
using POSLayer.Models;
using POSLayer.Repository.IRepository;

using POSWinFormLayer;

namespace DTRMClientNS
{
    static class Program
    {

        // You often store this in a static property so you can access it 
        // to create new forms with ActivatorUtilities later.
        public static IServiceProvider ServiceProvider { get; private set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new FrmLock());

            var host = Host.CreateDefaultBuilder()
              .ConfigureServices((context, services) =>
              {
                  // 1. Register DbContext (Database First)
                  //services.AddDbContext<PosDbContext>(options =>
                  //    options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;"));

                  PosConfig posConfig = UF.GetConfig() ?? new PosConfig();

                  services.AddSingleton(posConfig);

                  //services.AddDbContextFactory<PosDbContext>(options =>
                  //             options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;", b => b.MigrationsAssembly("POSLayer"))); // Specify where migrations live

                  services.AddDbContextFactory<PosDbContext>(options =>
                    options.UseSqlServer(posConfig.ConnectionString, b => b.MigrationsAssembly("POSLayer"))); // Specify where migrations live

                  // 2. Register Generic Repository
                  services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                  services.AddScoped<DbInitializer>();

                  services.AddSingleton<IFormFactory, FormFactory>();

                  // 3. Register Forms (Forms must be in DI to receive injections)
                  services.AddTransient<FrmLock>();
                  services.AddSingleton<DTRMSimpleBusiness>();

                  // 2. Build the provider
                  ServiceProvider = services.BuildServiceProvider();
              })
              .Build();

            ServiceHelper.Initialize(host.Services);
            using var scope = host.Services.CreateScope();
            var mainForm = scope.ServiceProvider.GetRequiredService<FrmLock>();

            var initilizer = scope.ServiceProvider.GetService<DbInitializer>();
            initilizer.InitializeDatabase();

            Application.Run(mainForm);
        }


    }
}