using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReyBusiness.Web.Startup))]
namespace ReyBusiness.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
