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
    }
}