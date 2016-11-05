using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2Quickstart.Startup))]
namespace Angular2Quickstart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
