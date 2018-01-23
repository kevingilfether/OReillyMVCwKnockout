using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OReilleyMVCwKnockout.Startup))]
namespace OReilleyMVCwKnockout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
