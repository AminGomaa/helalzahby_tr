using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Golden_Crescent.Startup))]
namespace Golden_Crescent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
