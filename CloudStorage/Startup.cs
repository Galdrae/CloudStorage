using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudStorage.Startup))]
namespace CloudStorage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
