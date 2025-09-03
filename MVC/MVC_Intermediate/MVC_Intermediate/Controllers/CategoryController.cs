using MVC_Intermediate.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_Intermediate.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult CategoryMenu()
        {
            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryId = 1, CategoryName = "Phone"},
                new Category() {CategoryId = 2, CategoryName = "Laptop"},
                new Category() {CategoryId = 3, CategoryName = "Headphones"},
                new Category() {CategoryId = 4, CategoryName = "Mouse"},
                new Category() {CategoryId = 5, CategoryName = "Monitor"}
            };

            return PartialView("CategoryMenu", categories);
        }
    }
}