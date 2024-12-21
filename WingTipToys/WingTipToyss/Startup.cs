using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingTipToyss.Startup))]
namespace WingTipToyss
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
