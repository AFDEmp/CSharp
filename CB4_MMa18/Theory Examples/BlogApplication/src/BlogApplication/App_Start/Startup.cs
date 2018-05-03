using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BlogApplication.Startup))]
namespace BlogApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
