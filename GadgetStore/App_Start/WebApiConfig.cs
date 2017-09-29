using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GadgetStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.routes.maphttproute(
            //    name: "defaultapi",
            //    routetemplate: "api/{controller}/{id}",
            //    defaults: new { id = routeparameter.optional }
            //);
        }
    }
}
