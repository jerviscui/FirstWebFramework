﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Web.Infrastructure;
using WebFramework;
using WebService;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            EngineContext.Init(containerBuilder => containerBuilder.RegisterControllers(typeof(MvcApplication).Assembly));
            DependencyResolver.SetResolver(new AutofacDependencyResolver(EngineContext.Engine.Container));

            //container.Resolve<>();
            //EngineContext.Engine.Container.Resolve<>()
            //EngineContext.Engine.Resolve<>()

            AutoMapperConfiguration.RegisterAutoMapperConfig();

            var aaa =  HttpContext.Current.Items["aa"];
        }
    }
}
