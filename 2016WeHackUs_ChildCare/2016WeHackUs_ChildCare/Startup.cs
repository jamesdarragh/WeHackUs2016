using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2016WeHackUs_ChildCare.Startup))]
namespace _2016WeHackUs_ChildCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
