using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using BSLayer;
using BSLayer.Forms;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using PosLayer.Repository;

using POSLayer.Context;
using POSLayer.Library;
using POSLayer.Repository.IRepository;

namespace WinKassa {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmKassaCalculator());


            var host = Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) =>
             {
                 // 1. Register DbContext (Database First)
                 //services.AddDbContext<PosDbContext>(options =>
                 //    options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;"));

                 services.AddDbContextFactory<PosDbContext>(options =>
                              options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;", b => b.MigrationsAssembly("POSLayer"))); // Specify where migrations live


                 // 2. Register Generic Repository
                 services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

                 // 3. Register Forms (Forms must be in DI to receive injections)
                 services.AddTransient<frmKassaCalculator>();
                 services.AddSingleton<DTRMSimpleBusiness>();
             })
             .Build();

            ServiceHelper.Initialize(host.Services);
            using var scope = host.Services.CreateScope();
            var mainForm = scope.ServiceProvider.GetRequiredService<frmKassaCalculator>();

            Application.Run(mainForm);


        }
    }
}
