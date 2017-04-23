using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MS_ATG_Code_sample.Startup))]
namespace MS_ATG_Code_sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
