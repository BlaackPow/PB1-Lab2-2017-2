using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaDeConttroleDeCinema.Startup))]
namespace SistemaDeConttroleDeCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
