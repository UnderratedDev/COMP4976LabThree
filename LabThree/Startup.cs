using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabThree.Startup))]
namespace LabThree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
