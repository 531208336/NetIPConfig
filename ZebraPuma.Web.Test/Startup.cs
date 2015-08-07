using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZebraPuma.Web.Test.Startup))]
namespace ZebraPuma.Web.Test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
