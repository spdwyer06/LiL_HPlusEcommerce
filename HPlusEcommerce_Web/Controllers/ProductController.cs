using HPlusEcommerce_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlusEcommerce_Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            // All will return the same thing

            // If the view filename is the same as the controller method name
            return View();

            // To specify a specific view file
            //return View("Index");

            // Give the exact file path
            //return View("~/Views/Product/Index.cshtml");
        }

        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            ViewBag.Product = new Product
            {
                Name = "Women's Winter Jacket",
                FullPrice = 20.00m,
                CurrentPrice = 16.00m,
                PercentOff = 20,
                ImagePath = "/Content/Images/Products/1.jpg",
                StarRating = 4
            };

            return View();
        }
    }
}