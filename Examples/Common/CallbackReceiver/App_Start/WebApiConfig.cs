﻿using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CallbackReceiver
{
    /// <summary />
    public static class WebApiConfig
    {
        /// <summary />
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
