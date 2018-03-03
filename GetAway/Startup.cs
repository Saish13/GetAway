using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetAway.Startup))]
namespace GetAway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
