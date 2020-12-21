using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myshop.webui.Startup))]
namespace myshop.webui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
