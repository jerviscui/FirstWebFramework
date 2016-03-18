using System;
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

            ContainerBuilder builder = new ContainerBuilder();
            

            var engine = EngineContext.Engine;
            //ioc provider
            //user provider
            //init
            engine.Initialize();

            IContainer container = builder.Build();
            builder.RegisterControllers(typeof (MvcApplication).Assembly);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //container.Resolve<>();

            AutoMapperConfiguration.RegisterAutoMapperConfig();
        }
    }
}
