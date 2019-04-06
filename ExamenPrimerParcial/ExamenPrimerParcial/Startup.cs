using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenPrimerParcial.Startup))]
namespace ExamenPrimerParcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
