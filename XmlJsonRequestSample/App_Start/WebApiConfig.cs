using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace XmlJsonRequestSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            xml.UseXmlSerializer = true;
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
