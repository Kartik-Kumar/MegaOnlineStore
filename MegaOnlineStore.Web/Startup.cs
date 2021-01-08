using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaOnlineStore.Web.Startup))]
namespace MegaOnlineStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
