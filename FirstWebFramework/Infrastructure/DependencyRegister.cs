using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Core;
using WebFramework;
using WebService;

namespace Web.Infrastructure
{
    public class DependencyRegister : IDependencyRegister
    {
        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<EntityService>().As<IEntityService>().InstancePerRequest();
        }

        public int Order()
        {
            return 0;
        }
    }
}