using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Traffic.Startup))]
namespace Traffic
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
