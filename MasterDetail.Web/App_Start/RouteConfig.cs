﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MasterDetail.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var route = new Route(
                        "{controller}/{action}/{id}",
                        new RouteValueDictionary(new
                        {
                            controller = "Home",
                            action = "Index",
                            id = UrlParameter.Optional
                        }),
                        new MasterDetail.Web.ControllerLess.Mvc.ControllerLessRouteHandler());

            routes.Add(route);

        }
    }
}
