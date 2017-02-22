using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15.WebGame.Startup))]
namespace _15.WebGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
