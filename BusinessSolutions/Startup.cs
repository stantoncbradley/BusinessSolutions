using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessSolutions.Startup))]
namespace BusinessSolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
