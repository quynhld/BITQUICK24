using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bitquick.Startup))]
namespace bitquick
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
