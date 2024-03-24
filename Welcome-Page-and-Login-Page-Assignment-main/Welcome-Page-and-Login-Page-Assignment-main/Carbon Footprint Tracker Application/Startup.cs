using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carbon_Footprint_Tracker_Application.Startup))]
namespace Carbon_Footprint_Tracker_Application
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
