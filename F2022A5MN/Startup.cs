using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(F2022A5MN.Startup))]

namespace F2022A5MN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
