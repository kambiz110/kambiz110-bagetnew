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

namespace Persistence.Seeding
{
    internal class RolesSeeder : ISeeder
    {
        public async Task SeedAsync(IdentityDatabaseContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

            await SeedRoleAsync(roleManager, GlobalConstants.AdministratorRoleName);
            await SeedRoleAsync(roleManager, GlobalConstants.ManegerRoleName);
            await SeedRoleAsync(roleManager, GlobalConstants.PostManegerRoleName);
            await SeedRoleAsync(roleManager, GlobalConstants.SelerManegerRoleName);
            await SeedRoleAsync(roleManager, GlobalConstants.UserRoleName);
        }

        private static async Task SeedRoleAsync(RoleManager<Role> roleManager, string roleName)
        {
            var role = await roleManager.RoleExistsAsync(roleName);
            if (!role)
            {
                Role rool = new Role() { Id=Guid.NewGuid().ToString(),Name= roleName ,NormalizedName=roleName};
                var result = await roleManager.CreateAsync(rool);
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
