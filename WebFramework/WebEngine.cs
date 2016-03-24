using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Core;
using Data;
using System.Reflection;
using DataService;

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

        public WebEngine(Action<ContainerBuilder> registerControllersAction)
            : this(new DefaultUserProvider(() => new User()
            {
                Id = 0,
                UserName = "AdminMan",
                Roles = new List<Role>()
                {
                    new Role()
                    {
                        RoleName = "Administrator", 
                        Permissions = new List<Permission>() { new Permission() { PermissionName = "All" } }
                    }
                }
            }), registerControllersAction)
        {

        }

        private void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();

            //init db setting
            builder.RegisterType<EfDbContext>().As<IDbContext>().InstancePerRequest();
            builder.RegisterGeneric(typeof (Repository<>)).As(typeof (IRepository<>)).InstancePerRequest();
            
            //regist all dependencies
            Assembly.GetCallingAssembly();

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
