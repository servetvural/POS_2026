using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace POSLayer.Context;


public class PosDbContextFactory : IDesignTimeDbContextFactory<PosDbContext>
{
    public PosDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PosDbContext>();

        // Option A: Hardcoded connection string for migrations (simple but less flexible)
        //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyMigrationDB;Trusted_Connection=True;");

        // optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TestAgent;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt = False;");

        optionsBuilder.UseSqlServer("Server=Servet2022\\SQLExpress;Database=DTRM2;User Id=sa;Password=servetvural;TrustServerCertificate=True;Encrypt=True;");

        //optionsBuilder.UseSqlServer("Server=eo3jfludah.database.windows.net;Database=TestAgent;User Id =ServetVuralTestAgentUser;Password =StrongPassword123;Encrypt = False;MultipleActiveResultSets=true;Connect Timeout=120;");

        // Option B: Read from appsettings.json in the current directory (more flexible)
        // You might need a dummy appsettings.json in your shared library for this
        //var configuration = new ConfigurationBuilder()
        //    .SetBasePath(Directory.GetCurrentDirectory())
        //    .AddJsonFile("appsettings.json")
        //    .Build();

        //var connectionString = configuration.GetConnectionString("DefaultConnection");
        //optionsBuilder.UseSqlServer(connectionString);

        // Crucial: Specify the assembly where the migrations files will reside if different from the DbContext assembly
        //optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("RelayUKTest.Shared"));

        return new PosDbContext(optionsBuilder.Options);
    }
}