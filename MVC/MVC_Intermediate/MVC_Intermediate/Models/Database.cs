using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Intermediate.Models
{
    public static class Database
    {
        private static List<Product> _list;

        static Database()
        {
            _list = new List<Product>()
            {
                new Product(){ProductId=1, ProductName = "Samsung Galaxy S24", ProductDescription = "Smartphone", ProductPrice = 1515, ProductIsAvaible = true, ProductImage = "1.jpg"},
                new Product(){ProductId=2, ProductName = "IPhone 16", ProductDescription = "Apple smartphone", ProductPrice = 38999, ProductIsAvaible = true, ProductImage = "2.jpg"},
                new Product(){ProductId=3, ProductName = "Xiaomi Redmi Note 13", ProductDescription = "Budget-friendly smartphone", ProductPrice = 9999, ProductIsAvaible = true, ProductImage = "3.jpg"},
                new Product(){ProductId=4, ProductName = "HP Pavilion 15", ProductDescription = "Laptop computer", ProductPrice = 24999, ProductIsAvaible = true, ProductImage = "4.jpg"},
                new Product(){ProductId=5, ProductName = "Asus TUF Gaming", ProductDescription = "Gaming laptop", ProductPrice = 32999, ProductIsAvaible = false, ProductImage = "5.jpg"},
                new Product(){ProductId=6, ProductName = "Sony WH-1000XM5", ProductDescription = "Wireless headphones", ProductPrice = 8999, ProductIsAvaible = true, ProductImage = "6.jpg"},
                new Product(){ProductId=7, ProductName = "Logitech MX Master 3S", ProductDescription = "Wireless mouse", ProductPrice = 2499, ProductIsAvaible = true, ProductImage = "7.jpg"},
                new Product(){ProductId=8, ProductName = "Dell UltraSharp 27", ProductDescription = "4K monitor", ProductPrice = 14999, ProductIsAvaible = false, ProductImage = "8.jpg"},
                new Product(){ProductId=9, ProductName = "Apple IPad Air", ProductDescription = "Tablet computer", ProductPrice = 18999, ProductIsAvaible = true, ProductImage = "9.jpg"},
            };
        }

        public static List<Product> AvailableProducts
        {
            get { return _list.Where(p => p.ProductIsAvaible).ToList(); }
        }

        // Tüm ürünleri döndüren property
        public static List<Product> AllProducts
        {
            get { return _list; }
        }

        public static void AddProduct(Product entity)
        {
            _list.Add(entity);
        }

        public static Product ProductDetail(int productid)
        {
            return _list.FirstOrDefault(p => p.ProductId == productid);
        }
    }
}
