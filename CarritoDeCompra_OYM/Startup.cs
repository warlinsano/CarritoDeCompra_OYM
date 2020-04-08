using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarritoDeCompra_OYM.Startup))]
namespace CarritoDeCompra_OYM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
