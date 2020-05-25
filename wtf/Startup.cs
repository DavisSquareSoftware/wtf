using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wtf.Startup))]
namespace wtf
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
