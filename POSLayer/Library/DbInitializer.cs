using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace POSLayer.Library;

public class DbInitializer
{
    readonly IServiceProvider serviceProvider;
    readonly PosConfig config;
    readonly IRepository<Shop> repoShop;
    readonly IRepository<Session> repoSession;
    readonly IRepository<User> repoUser;
    readonly IRepository<TheMenu> repoMenu;

    public DbInitializer(IServiceProvider serviceProvider, PosConfig configAsService, IRepository<Shop> _repoShop,
        IRepository<Session> _repoSession, IRepository<User> _repoUser, IRepository<TheMenu> _repoMenu)
    {
        this.serviceProvider = serviceProvider;
        config = configAsService;
        repoShop = _repoShop;
        repoSession = _repoSession;
        repoUser = _repoUser;
        this.repoMenu = _repoMenu;
    }
    public void InitializeDatabase()
    {



        // Use a scope to ensure the DbContext is properly disposed
        //using (var scope = ServiceProvider.CreateScope())
        //{
        // var context = scope.ServiceProvider.GetRequiredService<PosDbContext>();
        var context = ServiceHelper.GetService<PosDbContext>();

        // 1. Create or Update Schema
        // Use Migrate() if using migrations, or EnsureCreated() for simple setups
        context.Database.Migrate();

        // 2. Populate (Seed) Data
        SeedData();
        //}
    }

    private async void SeedData()
    {
        //Add Session if not exist
        if (!await repoSession.Any())
        {
            await repoSession.Save(new Session());
        }

        Session currentSession = await repoSession.GetByField("EndDate", null);

        //Add Shop if not exist
        if (!await repoShop.Any())
        {
            await repoShop.Save(new Shop()
            {
                CurrentSessionIID = currentSession.IID
            }
             );
        }

        //Add Superuser if doesn't exist
        List<User> users = await repoUser.GetAllAsync();
        if (!users.Any(x => x.AccessLevel == AccessLevels.SuperUser))
        {
            await repoUser.Save(new User()
            {
                UserName = "Super User",
                UserPassword = "9999",
                AccessLevel = AccessLevels.SuperUser
            });
        }

        if (!await repoMenu.Any())
        {
            //TheMenu menu = new TheMenu()
            //{
            //    MenuName = "New Menu",
            //    IsActive = true
            //};
            //Category firstCategory = new Category()
            //{
            //    Name = "First Category",
            //    MenuIID = menu.IID
            //};
            //menu.categories.Add(firstCategory);

            //CategoryItem firstItem = new CategoryItem()
            //{
            //    Name = "First Category Item",
            //    CategoryIID = firstCategory.IID
            //};
            //firstCategory.Items.Add(firstItem);
            //menu = await repoMenu.Save(menu);

            //Category secondCategory = new Category()
            //{
            //    Name = "Second Category",
            //    MenuIID = menu.IID
            //};
            //menu.categories.Add(secondCategory);
            //menu = await repoMenu.Save(menu);

            //config.ActiveMenuIID = menu.IID;
            //UF.SaveConfig(config);


            TheMenu menu = new TheMenu()
            {
                MenuName = "New Menu",
                IsActive = true,
                //distributions = new List<Distribution>()
                //{
                //        new Distribution() {Name = "Distro 1"}
                //} ,
                categories = new List<Category>()
                {
                    new      Category()
                    {
                        Name = "First Category" ,
                        Items = new List<CategoryItem>()
                        {
                            new   CategoryItem()
                            {
                                Name = "First Category Item"
                            }
                        }
                    }
                }
            };
            await repoMenu.Save(menu);

            menu = await repoMenu.GetMenu(menu.IID);

            menu.categories.Add( 
                new Category() {
                    Name = "Second CAtegory"
                });

            // menu = await repoMenu.Save(menu);

            //Category secondCategory = new Category()
            //{
            //    Name = "Second Category"
            //};
            //menu.categories.Add(secondCategory);

            //menu = await repoMenu.Save(menu);
            // menu = await repoMenu.Save(menu);
            // await repoMenu.SaveHierarchy(menu);
            await repoMenu.SaveMenu(menu);

            config.ActiveMenuIID = menu.IID;
            UF.SaveConfig(config);





            //TheMenu menu = await repoMenu.Save(new TheMenu()
            //{
            //    MenuName = "New Menu",
            //    IsActive = true
            //});
            //if (menu != null)
            //{
            //    menu.categories.Add(new Category()
            //    {
            //        Name = "First Category"
            //       // MenuIID = menu.IID
            //    });
            //    menu = await repoMenu.Save(menu);
            //    Category firstCategory = menu.categories.First();

            //    firstCategory.Items.Add(new CategoryItem()
            //    {
            //        Name = "First Category Item"
            //       // CategoryIID = firstCategory.IID
            //    });

            //    menu = await repoMenu.Save(menu);
            //    await repoMenu.SaveHierarchy(menu);

            //    config.ActiveMenuIID = menu.IID;
            //    UF.SaveConfig(config);
            //}


            // PosConfig config = ServiceHelper.GetService<PosConfig>();
            // config.ActiveMenuIID = menus.FirstOrDefault().IID;
            //   UF.SaveConfig(config);
        }
    }
}
