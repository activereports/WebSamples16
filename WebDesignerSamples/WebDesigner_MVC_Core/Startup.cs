using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;

using WebDesignerMvcCore.Services;
using WebDesignerMvcCore.Implementation;

namespace WebDesignerMvcCore
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
		public void ConfigureServices(IServiceCollection services)
		{
			services
				.AddReporting()
				.AddDesigner()
				.AddSingleton<ITemplatesService>(new FileSystemTemplates(TemplatesRootDirectory))
				.AddSingleton<IDataSetsService>(new CustomDataSetTemplates())
				.AddMvc(options => options.EnableEndpointRouting = false)
				.AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDataSetsService dataSetsService)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseReporting(config => config.UseFileStore(ResourcesRootDirectory));
			app.UseDesigner(config =>
			{
				config.UseFileStore(ResourcesRootDirectory, false);
				config.UseDataSetTemplates(dataSetsService);
			});

			app.UseStaticFiles();
			app.UseMvc();
		}
	}
}
