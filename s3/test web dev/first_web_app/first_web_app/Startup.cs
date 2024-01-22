using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(first_web_app.Startup))]
namespace first_web_app
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
