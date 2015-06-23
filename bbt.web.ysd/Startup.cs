using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBT.Web.YSD.Startup))]
namespace BBT.Web.YSD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
