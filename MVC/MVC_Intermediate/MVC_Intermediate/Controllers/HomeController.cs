using MVC_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProductCategoryModel model = new ProductCategoryModel();

            model.Products = Database.AvailableProducts;
            model.ProductCount = model.Products.Count;

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var product = Database.ProductDetail(id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product entity)
        {
            //Product entity = new Product();
            //entity.ProductName = ProductName;
            //entity.ProductDescription = ProductDescription;
            //entity.ProductPrice = ProductPrice;
            //entity.ProductImage = ProductImage;
            //entity.ProductIsAvaible = ProductIsAvaible;

            Database.AddProduct(entity);


            return View("ProductList", Database.AllProducts);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}