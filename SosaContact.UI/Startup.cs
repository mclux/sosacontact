using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SosaContact.UI.Startup))]
namespace SosaContact.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
