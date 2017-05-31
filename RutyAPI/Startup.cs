using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RutyAPI.Startup))]
namespace RutyAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
