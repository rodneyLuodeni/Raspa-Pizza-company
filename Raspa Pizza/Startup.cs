using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Raspa_Pizza.Startup))]
namespace Raspa_Pizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
