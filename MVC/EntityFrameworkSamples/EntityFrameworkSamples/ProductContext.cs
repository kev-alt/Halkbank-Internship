using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
