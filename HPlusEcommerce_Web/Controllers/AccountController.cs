using HPlusEcommerce_Web.Data;
using HPlusEcommerce_Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlusEcommerce_Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            Customer customer = null;

            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);

                if (user != null)
                    customer = db.Customers.FirstOrDefault(c => c.Id == user.CustomerId);
            }

            return View();
        }
    }
}