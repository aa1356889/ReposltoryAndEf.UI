using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReposltoryAndEf.UI.Startup))]
namespace ReposltoryAndEf.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
