﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlusEcommerce_Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                FormsAuthentication.SetAuthCookie(username, false);

                return Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            }

            return View();
        }
    }
}