using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTT.Web.Startup))]
namespace MTT.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
