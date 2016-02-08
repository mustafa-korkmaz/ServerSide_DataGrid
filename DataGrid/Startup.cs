using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataGrid.Startup))]
namespace DataGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
