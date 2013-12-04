using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BusinessSolutions
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AccountRoute",
                url: "community/account",
                defaults: new { controller = "Account", action = "Index" }
            );
            
            routes.MapRoute(
                name: "ItemRoute",
                url: "content/article",
                defaults: new { controller = "Home", action = "Item" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{action}/",
                defaults: new { controller = "Home", action = "Products", id = UrlParameter.Optional }
            );
        }
    }
}
