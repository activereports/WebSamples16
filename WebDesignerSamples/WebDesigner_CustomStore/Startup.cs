using System;
using System.IO;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using GrapeCity.ActiveReports.Aspnetcore.Designer;

using WebDesignerCustomStore.Services;
using WebDesignerCustomStore.Implementation.Storage;
using WebDesignerCustomStore.Implementation.CustomStore;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;

namespace WebDesignerCustomStore
{
	public class Startup
	{
		private static readonly string ResourcesRoot = Path.Combine(Directory.GetCurrentDirectory(), "Resources");

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// Add implemented IResourcesService to service collection for correct disposing and lifetime
			services
				.AddReporting()
				.AddDesigner()
				.AddSingleton<ICustomStorage>(s => new Implementation.Database.LiteDB(Path.Combine(ResourcesRoot, "lite.db")))
				//.AddSingleton<ICustomStorage, CosmoDB>()
				.AddSingleton<ICustomStoreService>(s => new CustomStoreService(s.GetRequiredService<ICustomStorage>()))
				.AddSingleton<ITemplatesService>(s => s.GetRequiredService<ICustomStoreService>())
				.AddSingleton<IDataSetsService>(s => new CustomDataSetTemplates())
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

			var resourcesService = app.ApplicationServices.GetRequiredService<ICustomStoreService>();
			app.UseReporting(config => config.UseCustomStore(id =>
			{
				if (".rpx".Equals(Path.GetExtension(id), StringComparison.InvariantCultureIgnoreCase))
					return resourcesService.GetSectionReport(id);
				return resourcesService.GetReport(id);
			}));
			app.UseDesigner(config =>
			{
				config.UseCustomStore(resourcesService);
				config.UseDataSetTemplates(dataSetsService);
			});

			app.UseStaticFiles();
			app.UseMvc();
		}
	}
}
