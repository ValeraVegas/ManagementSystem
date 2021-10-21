using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCH207_Web.Startup))]
namespace SCH207_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
