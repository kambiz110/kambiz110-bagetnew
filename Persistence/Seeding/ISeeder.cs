﻿using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(DataBaseContext dbContext, IdentityDatabaseContext identityDatabase, IServiceProvider serviceProvider);
    }
}
