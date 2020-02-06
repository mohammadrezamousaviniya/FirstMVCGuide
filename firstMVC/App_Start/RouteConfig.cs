using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace firstMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "mainWeb", action = "Index" }
            );
            routes.MapRoute(
                name: "anothers",
                url: "درباره-ما/{id}",
                defaults: new { controller = "mainWeb", action = "ContactUs" }
            );
        }
    }
}
