using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Core;
using Data;
using System.Reflection;

namespace WebFramework
{
    public class WebEngine : IEngine
    {
        private readonly Action<ContainerBuilder> _registerControllers;

        /// <summary>
        /// 初始化 <see cref="T:System.Object"/> 类的新实例。
        /// </summary>
        public WebEngine(IUserProvider userProvider, Action<ContainerBuilder> registerControllersAction)
        {
            _registerControllers = registerControllersAction;

            UserContext.Init(userProvider);
            DelegateRoleProvider.Init(null, null);

            Initialize();
        }

        private void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();

            //init db setting

            //regist all dependencies
            
            if (_registerControllers != null)
            {
                _registerControllers(builder);
            }
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);

            Container = builder.Build();

        }

        public User CurrentUser()
        {
            return UserContext.CurrentUser;
        }

        public IContainer Container { get; private set; }

        public TService Resolve<TService>()
        {
            return Container.Resolve<TService>();
        }

        public void EndRequest(object sender, EventArgs e)
        {
            UserContext.Clear();
        }
    }
}
