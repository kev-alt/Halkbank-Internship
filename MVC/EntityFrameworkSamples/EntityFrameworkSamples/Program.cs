using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ (Language Integrated Query)

            //ProductContext context = new ProductContext();

            //List<Category> categories = context.Categories.ToList();

            //var categories = context.Categories.ToList();

            //foreach (var category in categories)
            //{
            //    Console.WriteLine("category id : {0} category name : {1}", category.Id, category.CategoryName);
            //}

            //var products = context.Products.ToList();

            //foreach (var product in products)
            //{
            //    Console.WriteLine("product name : {0}, product price : {1}, product stock quantity : {2}", product.ProductName, product.ProductPrice, product.ProductPrice);
            //}

            //var product = context.Products.Find(5);

            //Console.WriteLine("product id : {3}, product name : {0}, product price : {1}, product stock quantity : {2}", product.ProductName, product.ProductPrice, product.ProductPrice, product.Id);

            //ProductContext context = new ProductContext();

            //var product = context.Products.Find(1);

            //Console.WriteLine("product id : {0}, product name : {1}, product price : {2}", product.Id, product.ProductName, product.ProductPrice);

            //product.ProductPrice = product.ProductPrice + product.ProductPrice* 1;
            //product.ProductName = "Samsung Galaxy S25";
            //product.ProductStockQuantity += 100;

            //context.SaveChanges();

            //product = context.Products.Find(1);

            //Console.WriteLine("product id : {0}, product name : {1}, product price : {2}", product.Id, product.ProductName, product.ProductPrice);

            //var products = context.Products.ToList();

            //foreach (var item in products)
            //{
            //    Console.WriteLine("product price : {0}", item.ProductPrice);
            //}

            //Console.WriteLine("--------------------------------------------");

            //foreach (var product in products)
            //{
            //    product.ProductPrice *= 2;
            //}

            //context.SaveChanges();

            //products = context.Products.ToList();

            //foreach (var item in products)
            //{
            //    Console.WriteLine("product price : {0}", item.ProductPrice);
            //}

            //ProductContext db = new ProductContext();

            //var product = db.Products.Find(1);

            //if (product != null)
            //{
            //    db.Products.Remove(product);
            //}

            //db.SaveChanges();

            //var products = db.Products.ToList();

            //foreach (var product in products)
            //{
            //    db.Products.Remove(product);
            //}

            //db.SaveChanges();

            //if (db.Products.Count() == 0)
            //{
            //    Console.WriteLine("No products found in the database.");
            //}
            //else
            //{
            //    foreach (var item in db.Products)
            //    {
            //        Console.WriteLine("product id : {0}, product name : {1}", item.Id, item.ProductName);
            //    }

            //}

            //ProductContext db = new ProductContext();

            //var products = db.Products.ToList();

            //foreach (var item in products)
            //{
            //    Console.WriteLine("product name : {0}", item.ProductName);
            //}

            //Console.WriteLine("Database created.");


            //int[] numbers = { 1, 5, 6, 4, 9, 8, 3 };

            //var numbers2 = numbers.Select(i => i % 2 == 1).OrderByDescending(i => i);

            //foreach (var item in numbers2)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] names = { "Kevser", "Ozzy", "Şebnem", "Özlem" };

            //var names2 = names.Where(i => i.Length > 4);

            //foreach (var item in names2)
            //{
            //    Console.WriteLine(item);
            //}

            //ProductContext db = new ProductContext();

            //var products = db.Products
            //    .Select(i => new
            //    {
            //       Name = i.ProductName.Length > 5 ? i.ProductName.Substring(0 ,9) + "..." : i.ProductName,
            //        i.ProductPrice
            //    })
            //    .ToList();

            //foreach (var product in products)
            //{
            //    Console.WriteLine("product name : {0} product price : {1}", product.Name, product.ProductPrice);
            //}

            //foreach (var product in products)
            //{
            //    Console.WriteLine("product id : {4}, product name : {0} product price : {1} , product stock quantity : {2}, category id : {3}", product.ProductName, product.ProductPrice, product.ProductStockQuantity, product.CategoryId, product.Id);
            //}

            //ProductContext db = new ProductContext();

            //var products = db.Products
            //    .Select(i => new ProductModel()
            //    {
            //        ProductName = i.ProductName.Length > 5 ? i.ProductName.Substring(0, 9) + "..." : i.ProductName,
            //        ProductPrice = i.ProductPrice,
            //        Category = i.Category.CategoryName
            //    })
            //    .ToList();

            //foreach (var product in products)
            //{
            //    Console.WriteLine("product name : {0} product price : {1}, category : {2}", product.ProductName, product.ProductPrice, product.Category);
            //}

            //ProductContext db = new ProductContext();

            //var categories = db.Categories
            //    .Select(i => 
            //     new CategoryProductModel()
            //     {
            //         CategoryName = i.CategoryName,
            //         Products = i.Products.Select(b =>
            //             new ProductModel()
            //             {
            //                ProductName = b.ProductName,
            //                 ProductPrice = b.ProductPrice
            //             }).ToList()
            //     })
            //    .ToList();

            //foreach (var category in categories)
            //{
            //    Console.WriteLine("category : {0}", category.CategoryName);


            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine("product name : {0} product price : {1}", product.ProductName, product.ProductPrice);
            //    }

            //    Console.WriteLine("--------------------------------------------");
            //}

            //ProductContext db = new ProductContext();

            //var products = db.Products.Where(i => i.Id == 1).FirstOrDefault();
            //var products = db.Products.Where(i => i.CategoryId == 1).ToList();
            //var products = db.Products.Where(i => i.ProductPrice > 28000 && i.ProductPrice < 80000).ToList();
            //var products = db.Products.Where(i => i.Category.CategoryName == "computer").ToList();

            //var products = db.Categories.Where(i => i.CategoryName == "phone")
            //    .Select(i => i.Products)
            //    .ToList();

            //var products = db.Categories
            //    .Where(i => i.CategoryName == "Computer" || i.CategoryName == "Phone")
            //    .Select(i => new CategoryProductModel()
            //    {
            //        CategoryName = i.CategoryName,
            //        Products = i.Products.Where(a => a.ProductPrice > 1000).Select(a => new ProductModel()
            //        {
            //            ProductPrice = a.ProductPrice,
            //            ProductName = a.ProductName
            //        }).ToList()
            //    });

            //foreach (var item in products)
            //{
            //    Console.WriteLine("category name {0}", item.CategoryName);

            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine("product name : {0} product price : {1}", product.ProductName, product.ProductPrice);
            //    }
            //    Console.WriteLine("--------------------------------------------");
            //}

            //ProductContext db = new ProductContext();

            ////var product = db.Products.Where(i => i.CategoryId == 1).ToList();
            ////var products = db.Products.Where(i => i.CategoryId == 1).ToList();
            ////var products = db.Products.Where(i => i.ProductPrice > 44000 && i.ProductPrice < 88000).ToList();
            ////var products = db.Products.Where(i => i.Category.CategoryName == "Watch").ToList();

            //var products = db.Categories.Where(i => i.CategoryName == "Watch")
            //    .SelectMany(i => i.Products)
            //    .ToList(); 


            //ProductContext db = new ProductContext();

            //var products = db.Categories
            //    .Where(i => i.CategoryName == "Computer" || i.CategoryName == "Phone")
            //    .Select(i => new CategoryProductModel()
            //    {
            //        CategoryName = i.CategoryName,
            //        Products = i.Products.Where(a => a.ProductPrice > 34000).Select(a => new ProductModel()
            //        {
            //            ProductPrice = a.ProductPrice,
            //            ProductName = a.ProductName
            //    }).ToList()

            //    });

            //foreach (var item in products)
            //{
            //    Console.WriteLine("category name : {0}", item.CategoryName);

            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine("product name : {0} product price : {1}", product.ProductName, product.ProductPrice);
            //    }

            //    Console.WriteLine("--------------------------------------------");
            //}

            //ProductContext db = new ProductContext();

            //var categories = db.Categories
            //    .Where(i => i.CategoryName == "Perfume")
            //    .Select(i =>
            //        new
            //        {
            //            i.CategoryName,
            //            i.Products
            //        }).ToList();

            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.CategoryName);
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //}

            //Product product = new Product();

            //product.ProductName = "YVES SAINT LAURENT Libre";
            //product.ProductPrice = 4250;
            //product.ProductStockQuantity = 33;

            //product.Category = db.Categories.Where(i => i.CategoryName == "Perfume").FirstOrDefault();

            //db.Products.Add(product);
            //db.SaveChanges();

            //foreach (var item in db.Categories.Where(i => i.CategoryName == "Perfume"))
            //{
            //    foreach (var entity in item.Products)
            //    {
            //        Console.WriteLine(entity.ProductName);
            //    }
            //}

            //Product product = new Product();

            //product.ProductName = "GUCCI Flora Gorgeous Magnolia";
            //product.ProductPrice = 150000;
            //product.ProductStockQuantity = 28;

            //product.Category = new Category() {CategoryName = "Perfume"};

            //db.Products.Add(product);
            //db.SaveChanges();

            //foreach (var item in db.Categories.Where(i => i.CategoryName == "Perfume"))
            //{
            //    foreach (var entity in item.Products)
            //    {
            //        Console.WriteLine(entity.ProductName);
            //    }
            //}


            //Category category = new Category();
            //category.CategoryName = "Major appliance";

            //Product product = new Product();
            //product.ProductName = "Smeg Refrigerator";
            //product.ProductPrice = 239.900;
            //product.ProductStockQuantity = 10;

            //category.Products.Add(product);
            //db.Categories.Add(category);
            //db.SaveChanges();

            //foreach (var item in db.Products.Where(i => i.Category.CategoryName == "Major appliance"))
            //{
            //    Console.WriteLine(item.ProductName);
            //}


            //Product entity = new Product();
            //entity.ProductName = "Iphone 16";
            //entity.ProductPrice = 77000;
            //entity.ProductStockQuantity = 100;
            //entity.CategoryId = 1;

            //db.Products.Add(entity);
            //db.SaveChanges();

            //foreach (var item in db.Products.Where(i => i.CategoryId == 1))
            //{
            //    Console.WriteLine("product name :{0}", item.ProductName);
            //}

            //Category entity = new Category();

            //entity.CategoryName = "Book";

            //db.Categories.Add(entity);

            //db.SaveChanges();

            //foreach (var item in db.Categories)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            //ProductContext db = new ProductContext();

            //var categories = db.Categories.Where(i => i.Id == 1).Select(i => new { i.CategoryName, i.Products }).ToList();

            //foreach (var category in categories)
            //{
            //    foreach (var product in category.Products)
            //    {
            //        product.ProductName += "test";
            //    }
            //}

            //var products = db.Products.Where(i => i.CategoryId == 1).ToList();

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //db.SaveChanges();


            //var products = db.Products;

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ProductPrice);
            //}

            //Console.WriteLine("--------------------------------------------");

            //foreach (var item in products)
            //{
            //    item.ProductPrice *= 1.25;
            //}

            //db.SaveChanges();

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ProductPrice);
            //}

            //var category = db.Categories.Where(i => i.Id == 1).FirstOrDefault();

            //if (category != null)
            //{
            //    category.CategoryName = "Phones";
            //    db.SaveChanges();
            //}

            //foreach (var item in db.Categories)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            //ProductContext db = new ProductContext();

            //var products = db.Products.Where(i => i.CategoryId == 2).ToList();

            //foreach (var item in products)
            //{
            //    db.Products.Remove(item);
            //}

            //db.SaveChanges();

            //var category = db.Categories.Where(i => i.Id == 1).FirstOrDefault();

            //if (category != null)
            //{
            //    db.Categories.Remove(category);
            //}

            //db.SaveChanges();

            //foreach (var item in db.Categories)
            //{
            //    Console.WriteLine(item.Id);
            //}

            ProductContext db = new ProductContext();

            var products = db.Products
                .OrderByDescending(i => i.Id)
                .Take(5)
                .ToList();

            foreach (var item in products)
            {
                Console.WriteLine("product name : {0} product price : {1}",item.ProductName, item.ProductPrice);
            }


            Console.ReadLine();

        }
    }
}
