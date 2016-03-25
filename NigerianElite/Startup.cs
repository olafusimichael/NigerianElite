using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NigerianElite.Startup))]
namespace NigerianElite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
