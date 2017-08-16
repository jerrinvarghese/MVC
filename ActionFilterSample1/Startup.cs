using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActionFilterSample1.Startup))]
namespace ActionFilterSample1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
