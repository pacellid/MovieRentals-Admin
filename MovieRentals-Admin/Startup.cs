using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRentals_Admin.Startup))]
namespace MovieRentals_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
