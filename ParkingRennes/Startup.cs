using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParkingRennes.Startup))]
namespace ParkingRennes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
