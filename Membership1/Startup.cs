using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membership1.Startup))]
namespace Membership1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
