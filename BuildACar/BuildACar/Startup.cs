using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildACar.Startup))]
namespace BuildACar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
