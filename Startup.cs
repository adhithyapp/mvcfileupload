using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fileupload2mvc.Startup))]
namespace fileupload2mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
