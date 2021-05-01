﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Notice the manual namespace change
namespace System.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Copyright(this HtmlHelper helper)
        {
            return helper.Raw($"&copy; H + Sport {DateTime.Now.Year}");
        }
    }
}