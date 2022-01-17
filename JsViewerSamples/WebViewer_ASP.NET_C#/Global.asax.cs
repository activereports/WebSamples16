using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using GrapeCity.ActiveReports.Web;

namespace GrapeCity.ActiveReports.Samples.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            this.UseReporting(settings =>
            {
                settings.UseFileStore(new DirectoryInfo(Server.MapPath("~")));
                settings.UseCompression = true;
            });
        }
    }
}