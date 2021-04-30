﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlusEcommerce_Web.Filters
{
    public class CrawlerFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Browser.Crawler)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
    }
}