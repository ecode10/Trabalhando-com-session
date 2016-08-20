using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aula2.Startup))]
namespace aula2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
