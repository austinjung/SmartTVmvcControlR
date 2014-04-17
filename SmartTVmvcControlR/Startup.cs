using Owin;
using Microsoft.Owin;

//[assembly: OwinStartupAttribute(typeof(SmartTVmvcControlR.Startup))]
[assembly: OwinStartup(typeof(SmartTVmvcControlR.Startup))]
namespace SmartTVmvcControlR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}