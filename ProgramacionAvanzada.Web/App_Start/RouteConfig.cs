using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProgramacionAvanzada.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Person",
                url: "Person/{action}/{id}",
                defaults: new { controller = "Person", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Car",
                url: "Car/{action}/{id}",
                defaults: new { controller = "Car", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Job",
                url: "Job/{action}/{id}",
                defaults: new { controller = "Job", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Person", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

