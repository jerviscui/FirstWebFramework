using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace WebFramework
{
    public interface IEngine
    {
        User CurrentUser();

        IContainer Container { get; }

        TService Resolve<TService>();
    }
}
