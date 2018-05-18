using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pogin.Startup))]
namespace Pogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
