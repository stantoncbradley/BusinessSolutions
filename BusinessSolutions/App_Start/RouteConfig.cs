﻿using System;
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
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AccountRoute",
                url: "{controller}/{action}",
                defaults: new { controller = "Member", action = "Index" }
            );

            routes.MapRoute(
                name: "ItemRoute",
                url: "content/item",
                defaults: new { controller = "Home", action = "Item" }
            );

            routes.MapRoute(
                name: "Admin",
                url: "{controller}/{action}",
                defaults: new { controller = "Admin", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
