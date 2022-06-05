using Common.Useful;

using Persistence.Contexts;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeding
{
    internal class RolesSeeder : ISeeder
    {
        public async Task SeedAsync(DataBaseContext dbContext, IdentityDatabaseContext identityDatabase, IServiceProvider serviceProvider )
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            await SeedRoleAsync(roleManager, GlobalConstants.AdministratorRoleName);
 
        }

        private static async Task SeedRoleAsync(RoleManager<IdentityRole> roleManager, string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
