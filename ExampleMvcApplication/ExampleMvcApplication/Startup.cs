using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleMvcApplication.Startup))]
namespace ExampleMvcApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
