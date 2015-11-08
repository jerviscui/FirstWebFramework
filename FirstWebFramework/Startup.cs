using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstWebFramework.Startup))]
namespace FirstWebFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
