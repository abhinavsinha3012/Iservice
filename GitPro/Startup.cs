using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitPro.Startup))]
namespace GitPro
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
