using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        // Entity Framework Initializer

        protected override void Seed(ProductContext context)
        {


            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryName = "Phone"},
                new Category() { CategoryName = "Computer"},
                new Category() { CategoryName = "Tablet"},
                new Category() { CategoryName = "Watch"},
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }


            List<Product> products = new List<Product>()
            {
                new Product() { ProductName = "Samsung Galaxy S24", ProductPrice = 40399, ProductStockQuantity = 100, CategoryId = 1},
                new Product() { ProductName = "iPhone 15 Pro", ProductPrice = 59699, ProductStockQuantity = 50, CategoryId = 1},
                new Product() { ProductName = "Xiaomi 14 Ultra", ProductPrice = 38999, ProductStockQuantity = 75, CategoryId = 1},
                new Product() { ProductName = "Apple MacBook Pro 14", ProductPrice = 75999, ProductStockQuantity = 40, CategoryId = 2},
                new Product() { ProductName = "Dell XPS 13", ProductPrice = 45999, ProductStockQuantity = 35, CategoryId = 2},
                new Product() { ProductName = "Microsoft Surface Pro 9", ProductPrice = 32999, ProductStockQuantity = 60, CategoryId = 2},
                new Product() { ProductName = "Samsung Galaxy Tab S9 Ultra", ProductPrice = 28999, ProductStockQuantity = 80, CategoryId = 3},
                new Product() { ProductName = "Apple iPad Pro 12.9", ProductPrice = 35999, ProductStockQuantity = 70, CategoryId = 3},
                new Product() { ProductName = "Apple Watch Ultra 2", ProductPrice = 25999, ProductStockQuantity = 90, CategoryId = 4},
                new Product() { ProductName = "Samsung Galaxy Watch 6 Classic", ProductPrice = 8999, ProductStockQuantity = 120, CategoryId = 4}
            };

            foreach (var item in products)
            {
                context.Products.Add(item);
            }

            context.SaveChanges();



            base.Seed(context);
        }
    }
}
