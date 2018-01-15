using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuratCinar.Startup))]
namespace MuratCinar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
