using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Akash.Models;

namespace Akash.Data
{
    public class AkashContext : DbContext
    {
        public AkashContext (DbContextOptions<AkashContext> options)
            : base(options)
        {
        }

        public DbSet<Akash.Models.Category> Category { get; set; }

        public DbSet<Akash.Models.Brand> Brand { get; set; }

        public DbSet<Akash.Models.Order> Order { get; set; }
    }
}
