using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UPC_ASP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Share", // 路由名称，这个只要保证在路由集合中唯一即可
                url: "Share/{action}/{id}", //路由规则,匹配以Admin开头的url
                defaults: new { controller = "Share", action = "Index", id = UrlParameter.Optional } // 
            );

            routes.MapRoute(
                name:"Work", // 路由名称，这个只要保证在路由集合中唯一即可
                url: "Work/{action}/{id}", //路由规则,匹配以Admin开头的url
                defaults: new { controller = "Work", action = "Homework", id = UrlParameter.Optional } // 
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
