using System;
using System.Collections.Generic;
using System.Threading;
using System.Web.Services.Description;
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

namespace DTRMSimpleBackOffice
{
    static class Program
    {
        public static int Profile { get; set; } = 123456789;
        public static string UserType { get; set; } = "User";
        public static string RemoteBackUpDirectory { get; set; }  = ".\\Backup";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            //args = new string[] { "User" };
            //args = new string[] { "Accountant" };
            //args = new string[] { "MenuEditor" };
            // args = new string[] { "Owner" };


            if (args.Length >= 1 )
                UserType = args[0].Trim();
            else
                UserType = "User";

            Random random = new Random();
            Profile = random.Next(1234,int.MaxValue);

            if (args.Length >= 2)
            {
                try
                {
                    Profile = int.Parse(args[1].Trim());
                } catch (Exception ex)
                {
                    Profile = random.Next(1234, int.MaxValue);
                    MessageBox.Show("Invalid profile number.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                         
                }
            }

            if (args.Length >= 3)
            {
                try
                {
                    //string theFolder = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    //RemoteBackUpDirectory = args[2] + "\\" + theFolder ;

                    RemoteBackUpDirectory = args[2];
                } catch (Exception ex)
                {
                    RemoteBackUpDirectory = ".\\Backup";
                    MessageBox.Show("Invalid Backup Location\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   else
            {
                RemoteBackUpDirectory = ".\\Backup";
            }



            var host = Host.CreateDefaultBuilder()
              .ConfigureServices((context, services) =>
              {
                  // 1. Register DbContext (Database First)
                  //services.AddDbContext<PosDbContext>(options =>
                  //    options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;"));

                  PosConfig posConfig = UF.GetConfig() ?? new PosConfig();
                 
                  services.AddSingleton(posConfig);

                  services.AddDbContextFactory<PosDbContext>(options =>
                               options.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM2;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;", b => b.MigrationsAssembly("POSLayer"))); // Specify where migrations live


                  // 2. Register Generic Repository
                  services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

                  services.AddSingleton<IFormFactory, FormFactory>();

                  // 3. Register Forms (Forms must be in DI to receive injections)
                  services.AddTransient<frmConfig>();
                  services.AddTransient<frmOffice>();
                  services.AddSingleton<DTRMSimpleBusiness>();
                  services.AddTransient<frmKassaCalculator>();
              })
              .Build();

            ServiceHelper.Initialize(host.Services);
            using var scope = host.Services.CreateScope();
            var mainForm = scope.ServiceProvider.GetRequiredService<frmOffice>();
            

            Application.Run(mainForm);

            //Application.Run(new frmOffice());
        }
    }
}
