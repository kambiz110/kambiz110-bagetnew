using Domain.Visitors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
   public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options)
            : base(options)
        {
        }
        public DbSet<OnlineVisitor> OnlineVisitors { get; set; }
        
    }
}
