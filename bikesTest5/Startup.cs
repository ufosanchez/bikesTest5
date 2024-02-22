using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bikesTest5.Startup))]
namespace bikesTest5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
