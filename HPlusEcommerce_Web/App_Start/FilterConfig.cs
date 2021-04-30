using HPlusEcommerce_Web.Filters;
using System.Web;
using System.Web.Mvc;

namespace HPlusEcommerce_Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogRequestFilter());
        }
    }
}
