using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HayfordTechnologies.Startup))]
namespace HayfordTechnologies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
