using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemo.web.Startup))]
namespace GitDemo.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
