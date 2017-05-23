using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManaG.MVC.Startup))]
namespace ManaG.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
