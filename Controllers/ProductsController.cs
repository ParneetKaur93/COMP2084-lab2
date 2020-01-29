using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            string[] products = { "Laptop", "Desktop", "Tablet" };
            ViewData["products"] = products;
             return View();
        }

        public string details(string product)
        {
            string message = "here is your product" + product;
                return message;
        }
    }
}