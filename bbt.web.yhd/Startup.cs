using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBT.Web.YHD.Startup))]
namespace BBT.Web.YHD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
