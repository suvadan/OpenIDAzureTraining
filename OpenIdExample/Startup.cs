using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenIdExample.Startup))]
namespace OpenIdExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
