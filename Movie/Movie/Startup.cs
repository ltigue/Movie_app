using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieProg.Startup))]
namespace MovieProg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
