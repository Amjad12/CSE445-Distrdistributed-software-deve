using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tryit_A4.Startup))]
namespace tryit_A4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
