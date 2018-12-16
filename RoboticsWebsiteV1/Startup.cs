using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoboticsWebsiteV1.Startup))]
namespace RoboticsWebsiteV1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
