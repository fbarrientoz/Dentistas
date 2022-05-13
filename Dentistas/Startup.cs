using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dentistas.Startup))]
namespace Dentistas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
