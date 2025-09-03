using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            return View();
        }

        public ViewResult Detail()
        {
            return View();
        }
    }
}