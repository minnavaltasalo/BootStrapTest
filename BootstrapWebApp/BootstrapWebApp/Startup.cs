using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapWebApp.Startup))]
namespace BootstrapWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
