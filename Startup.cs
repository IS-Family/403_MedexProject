using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_403_MedexProject.Startup))]
namespace _403_MedexProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
