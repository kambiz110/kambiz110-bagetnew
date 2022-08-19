using Common.Useful;
using Domain.Users;
using Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Seeding
{
    public class DataSeeder : ISeeder
    {
        public async Task SeedAsync(IdentityDatabaseContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

            // creating admin user;
            await CreateUser(
                userManager,
                roleManager,
                GlobalConstants.DataSeeding.AdminName,
                GlobalConstants.DataSeeding.AdminEmail,
                GlobalConstants.AdministratorRoleName);

            // creating teacher user;
      await CreateUser(
                userManager,
                roleManager,
                GlobalConstants.DataSeeding.ManegerName,
                GlobalConstants.DataSeeding.ManegerEmail,
                GlobalConstants.ManegerRoleName);

           
          
        }
        private static async Task<string> CreateUser(
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            string name,
            string email,
            string roleName = null)
        {
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                FullName = name,
                Email = email,
            };

            var userpassword = GlobalConstants.DataSeeding.ManegerPassword;
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
    }
}
