using Microsoft.Owin;
using Owin;
using System.Web.Routing;
using GrapeCity.ActiveReports.Aspnet.Viewer;
using System.Reflection;

[assembly: OwinStartup(typeof(CORS.Server.Startup))]

namespace CORS.Server
{
    public class Startup
    {
        public static string EmbeddedReportsPrefix = "CORS.Server.Reports";

        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.UseReporting(settings =>
            {
                settings.UseEmbeddedTemplates(EmbeddedReportsPrefix, Assembly.GetAssembly(GetType()));
                settings.UseCompression = true;
            });

            RouteTable.Routes.RouteExistingFiles = true;
        }
    }
}