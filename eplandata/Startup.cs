using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(eplandata.Startup))]

namespace eplandata
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {/*
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            }); */
        }
    }
}
