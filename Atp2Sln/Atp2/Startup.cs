using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Atp2.Startup))]
namespace Atp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
