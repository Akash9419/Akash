using Akash.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akash.Data
{
    public class LabelDbContext : IdentityDbContext
    {
        public DbSet<Order> Order { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public LabelDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
