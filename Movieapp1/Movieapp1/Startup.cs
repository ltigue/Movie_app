using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movieapp1.Startup))]
namespace Movieapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
