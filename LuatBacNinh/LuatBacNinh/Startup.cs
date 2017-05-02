using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuatBacNinh.Startup))]
namespace LuatBacNinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
