using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Management_app.Startup))]
namespace Management_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
