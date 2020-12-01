using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
