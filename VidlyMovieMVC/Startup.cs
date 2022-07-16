using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMovieMVC.Startup))]
namespace VidlyMovieMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
