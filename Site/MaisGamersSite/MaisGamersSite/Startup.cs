using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaisGamersSite.Startup))]
namespace MaisGamersSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
