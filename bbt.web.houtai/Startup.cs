using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBT.Web.HouTai.Startup))]
namespace BBT.Web.HouTai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
