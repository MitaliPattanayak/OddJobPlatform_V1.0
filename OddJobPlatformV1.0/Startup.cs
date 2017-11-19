using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OddJobPlatformV1._0.Startup))]
namespace OddJobPlatformV1._0
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
