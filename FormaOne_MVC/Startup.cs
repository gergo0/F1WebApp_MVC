using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormaOne_MVC.Startup))]
namespace FormaOne_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
