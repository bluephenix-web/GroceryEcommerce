using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grocery.Models;

namespace Grocery.Data
{
    public class GroceryContext : DbContext
    {
        public GroceryContext (DbContextOptions<GroceryContext> options)
            : base(options)
        {
        }

        public DbSet<Grocery.Models.Products> Products { get; set; } = default!;
        public DbSet<Grocery.Models.Cart> Cart { get; set; } = default!;
    }
}
