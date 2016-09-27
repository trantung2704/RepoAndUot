using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicRepository.Startup))]
namespace DynamicRepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
