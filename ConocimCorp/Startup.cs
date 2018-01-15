using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConocimCorp.Startup))]
namespace ConocimCorp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
