using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRenting.Startup))]
namespace eRenting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
