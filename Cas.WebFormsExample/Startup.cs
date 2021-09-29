using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cas.WebFormsExample.Startup))]
namespace Cas.WebFormsExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
