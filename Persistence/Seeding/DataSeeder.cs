using Common.Useful;
using Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Domain.Catalogs;

namespace Persistence.Seeding
{
    public class DataSeeder : ISeeder
    {
        public async Task SeedAsync(DataBaseContext dbContext, IdentityDatabaseContext identityDatabase, IServiceProvider serviceProvider )
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // creating admin user;
            await CreateUser(
                userManager,
                roleManager,
                GlobalConstants.DataSeeding.AdminName,
                GlobalConstants.DataSeeding.AdminEmail,
                GlobalConstants.AdministratorRoleName);
            // creating admin user;
            await CreateUser(
                userManager,
                roleManager,
                GlobalConstants.DataSeeding.CustomerName,
                GlobalConstants.DataSeeding.CustomerEmail,
                GlobalConstants.UserRoleName);
            await CatalogAndbrandSeed(dbContext);



        }
        private static async Task<string> CreateUser(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            string name,
            string email,
            string roleName = null)
        {
            var user = new User
            {
                UserName = email,
                Email = email,
            };

            var userpassword = GlobalConstants.DataSeeding.CustomerPassword;
            var adminpassword = GlobalConstants.DataSeeding.AdminPassword;
            if (roleName != null)
            {
                var role = await roleManager.FindByNameAsync(roleName);

                if (!userManager.Users.Any(x => x.UserRoles.Any(x => x.RoleId == role.Id)))
                {
                    var result = await userManager.CreateAsync(user, user.UserName == "admin@admin.com" ? adminpassword : userpassword);

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, roleName);
                    }
                }
                
            }
            else
            {
                if (!userManager.Users.Any(x => x.UserRoles.Count() == 0))
                {
                    var result = await userManager.CreateAsync(user, user.UserName== "admin@admin.com" ? adminpassword : userpassword);
                }
            }

            return user.Id;
        }
        private async Task CatalogAndbrandSeed(DataBaseContext dbContext)
        {
            foreach (var catalog in GetCatalogTypes())
            {
              
                if (!dbContext.CatalogTypes.AsNoTracking().Where(p => p.Id == catalog.Id).Any())
                {
                    await dbContext.CatalogTypes.AddAsync(catalog);
                }
               
            }
            foreach (var brand in GetCatalogBrands())
            {
                if (!dbContext.CatalogBrands.AsNoTracking().Where(p => p.Id == brand.Id).Any())
                {
                    await dbContext.CatalogBrands.AddAsync(brand);
                }
            }
            foreach (var car in GetCatalogCars())
            {
                if (!dbContext.CatologCars.AsNoTracking().Where(p => p.Id == car.Id).Any())
                {
                    await dbContext.CatalogBrands.AddAsync(car);
                }
            }
        }

        private static IEnumerable<CatalogType> GetCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() {  Id=1,  Type="جلوبندی"},
                new CatalogType() {  Id= 2,  Type="دیفرانسیل" , ParentCatalogTypeId = 1},
                new CatalogType() {  Id= 3,  Type="موتور" , ParentCatalogTypeId=2},
                new CatalogType() {  Id= 4,  Type="گریبکس", ParentCatalogTypeId=2},
                new CatalogType() {  Id= 5,  Type="داشبورد", ParentCatalogTypeId=2},
            };
        }

        private static IEnumerable<CatalogBrand> GetCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand() { Id=1, Brand = "ایساکو" },
                new CatalogBrand() { Id=2, Brand = "اعزام" },
                new CatalogBrand() { Id=3, Brand = "ایران یدک" }
            };
        }
        private static IEnumerable<CatologCar> GetCatalogCars()
        {
            return new List<CatologCar>()
            {
                new CatologCar() { Id=1, Name = "تیبا" },
                new CatologCar() { Id=2, Name = "پراید" },
                new CatologCar() { Id=3, Name = "ساینا" }
            };
        }
    }
}
