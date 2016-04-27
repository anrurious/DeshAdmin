using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeshAdmin.Startup))]
namespace DeshAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
