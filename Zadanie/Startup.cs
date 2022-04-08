using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadanie.Startup))]
namespace Zadanie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
