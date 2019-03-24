using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moren.Startup))]
namespace Moren
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
