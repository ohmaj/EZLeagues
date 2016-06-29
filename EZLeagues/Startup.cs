using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZLeagues.Startup))]
namespace EZLeagues
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
