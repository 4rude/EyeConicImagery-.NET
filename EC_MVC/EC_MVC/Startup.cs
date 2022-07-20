using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EC_MVC.Startup))]
namespace EC_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
