using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiPrac.Web.Startup))]
namespace WebApiPrac.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
