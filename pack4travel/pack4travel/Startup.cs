using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pack4travel.Startup))]
namespace pack4travel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
