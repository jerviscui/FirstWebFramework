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
using FirstWebFramework.Infrastructure;

namespace FirstWebFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(typeof (MvcApplication).Assembly);
            RegisterDependencies(builder);
            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfiguration.RegisterAutoMapperConfig();
        }

        private static void RegisterDependencies(ContainerBuilder builder)
        {
            
        }
    }
}
