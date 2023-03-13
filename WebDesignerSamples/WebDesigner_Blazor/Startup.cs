using System.IO;
using WebDesigner_Blazor.Implementation;
using WebDesigner_Blazor.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace WebDesigner_Blazor
{
	public class Startup
	{
		private static readonly DirectoryInfo ResourcesRootDirectory =
			new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "resources" + Path.DirectorySeparatorChar));

		private static readonly DirectoryInfo TemplatesRootDirectory =
			new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "templates" + Path.DirectorySeparatorChar));

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			services.AddReporting();
			services.AddDesigner();
			services.AddSingleton<ITemplatesService>(new FileSystemTemplates(TemplatesRootDirectory));
			services.AddSingleton<IDataSetsService>(new CustomDataSetTemplates());
			services.AddRazorPages().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
			services.AddServerSideBlazor();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDataSetsService dataSetsService)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseReporting(config => config.UseFileStore(ResourcesRootDirectory));
			app.UseDesigner(config =>
			{
				config.UseFileStore(ResourcesRootDirectory, false);
				config.UseDataSetTemplates(dataSetsService);
			});

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/Index");
			});
		}
	}
}
