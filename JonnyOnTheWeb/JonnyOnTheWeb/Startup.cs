using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JonnyOnTheWeb.Startup))]
namespace JonnyOnTheWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
