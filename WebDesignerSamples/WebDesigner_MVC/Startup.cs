using System;
using System.IO;
using System.Linq;
using System.Web;
using GrapeCity.ActiveReports.Aspnet.Designer;
using GrapeCity.ActiveReports.Aspnet.Viewer;

using WebDesigner_MVC.Implementation;
using WebDesigner_MVC.Services;
using Owin;
using Microsoft.Owin;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.FileSystems;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(WebDesigner_MVC.Startup))]

namespace WebDesigner_MVC
{
	public class Startup
	{
		private static readonly DirectoryInfo ResourcesRootDirectory =
			new DirectoryInfo(String.Format(@"{0}.\resources\", HttpRuntime.AppDomainAppPath));
		private static readonly DirectoryInfo TemplatesRootDirectory =
			new DirectoryInfo(String.Format(@"{0}.\templates\", HttpRuntime.AppDomainAppPath));

		public void Configuration(IAppBuilder app)
		{
			app.UseErrorPage();

			var templatesService = new FileSystemTemplates(TemplatesRootDirectory);
			app.Use((context, next) =>
			{
				context.Set(typeof(ITemplatesService).ToString(), templatesService);
				return next.Invoke();
			});
			app.UseDesigner(config =>
			{
				config.UseFileStore(ResourcesRootDirectory, false);
				config.UseDataSetTemplates(new CustomDataSetTemplates());
			});

			app.UseReporting(config => config.UseFileStore(ResourcesRootDirectory));

			app.UseStaticFiles(new StaticFileOptions { FileSystem = new PhysicalFileSystem(String.Format(@"{0}.\wwwroot\", HttpRuntime.AppDomainAppPath)) });
		}
	}
}
