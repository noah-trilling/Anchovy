using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Anchovy.API.Service.DAL;
using Anchovy.API.Service.Migrations;

namespace Anchovy.API.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AnchovyContext, Configuration>());
            // Web API routes


            config.MapHttpAttributeRoutes();

            config.Routes.IgnoreRoute("", "");

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
