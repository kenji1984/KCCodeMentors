using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Centrig.Startup))]
namespace Centrig
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
