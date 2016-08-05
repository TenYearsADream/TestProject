using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CopySite.Startup))]
namespace CopySite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
