﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Persistence.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeding
{
  public  class ApplicationDbContextSeeder : ISeeder
    {
        public async Task SeedAsync(DataBaseContext dbContext, IdentityDatabaseContext identityDatabase , IServiceProvider serviceProvider )
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

          //  var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            var seeders = new List<ISeeder>
                          {
                              new RolesSeeder(),
                              new DataSeeder(),
                          };

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, identityDatabase, serviceProvider );
                await identityDatabase.SaveChangesAsync();
              //  logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
           
        }
    }
}
