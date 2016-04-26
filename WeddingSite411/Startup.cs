using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingSite411.Startup))]
namespace WeddingSite411
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
