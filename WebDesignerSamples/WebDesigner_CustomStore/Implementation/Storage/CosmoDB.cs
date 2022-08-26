using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

using Newtonsoft.Json.Linq;
using Microsoft.Azure.Cosmos;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.PageReportModel;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Utilities;

using WebDesignerCustomStore.Services;
using WebDesignerCustomStore.Implementation.CustomStore;
using WebDesignerCustomStore.Implementation.CustomStore.Themes;
using WebDesignerCustomStore.Implementation.CustomStore.Images;
using WebDesignerCustomStore.Implementation.CustomStore.Reports;

namespace WebDesignerCustomStore.Implementation.Storage
{
	public class CosmoDB : ICustomStorage
	{
		private const string DATABASE_NAME = "cosmos";

		private const string IMAGES = "images";
		private const string THEMES = "themes";
		private const string REPORTS = "reports";
		private const string TEMPLATES = "templates";

		private List<(string db, string container)> _containers = new()
		{
			(DATABASE_NAME, "images"),
			(DATABASE_NAME, "themes"),
			(DATABASE_NAME, "templates"),
			(DATABASE_NAME, "reports")
		};

		private CosmosClient _client;
		private Microsoft.Azure.Cosmos.Database _db;

		public CosmoDB()
		{
			var connectionString = ConfigurationManager.ConnectionStrings["CosmosDB"].ConnectionString;

			_client = CosmosClient.CreateAndInitializeAsync(connectionString, _containers).Result;
			_db = _client.GetDatabase(DATABASE_NAME);
		}

		public void Dispose()
		{
			_client.Dispose();
		}

		public byte[] GetImage(string imageId)
		{
			var response = _db.GetContainer(IMAGES)
							  .ReadItemAsync<JObject>(imageId, new PartitionKey(imageId))
							  .Result;

			if (response.StatusCode != HttpStatusCode.OK)
				return null;

			var base64 = response.Resource["Content"].ToString();
			return Convert.FromBase64String(base64);
		}

		public IEnumerable<IImageInfo> GetImagesList()
		{
			var imagesList = _db.GetContainer(IMAGES)
								.GetItemLinqQueryable<JObject>(true)
								.AsEnumerable()
								.Select(json =>
								{
									var id = json["id"].ToString();
									var base64 = json["Content"].ToString();
									var image = Convert.FromBase64String(base64);

									return new ImageInfo
									{
										Id = id,
										Name = id,
										ContentType = json["Mime"].ToString(),
										Thumbnail = Util.GetImageThumbnail(image),
									};
								});

			return imagesList;
		}

		public Report GetReport(string reportId)
		{
			var (container, id) = Util.GetCollectionAndName(reportId, REPORTS);
			var response = _db.GetContainer(container)
							  .ReadItemAsync<JObject>(id, new PartitionKey(id))
							  .Result;

			if (response.StatusCode != HttpStatusCode.OK)
				return null;

			var reportJson = GetValue(response.Resource, "Content.Report");
			var report = ReportConverter.FromJson(Encoding.UTF8.GetBytes(reportJson));
			report.Site = new ReportSite(new CustomStoreResourceLocator(this));

			return report;
		}

		public void SaveReport(string reportId, Report report, bool isTemporary = false)
		{
			var jsonBytes = ReportConverter.ToJson(report);
			var jsonString = Encoding.UTF8.GetString(jsonBytes);
			var json = JObject.Parse(jsonString);

			var container = isTemporary ? Util.TEMP_SUFFIX : REPORTS;

			var item = new JObject
			{
				["id"] = reportId,
				["Type"] = Util.GetReportType(report),
				["Content"] = new JObject { ["Report"] = json }
			};

			_db.GetContainer(container)
			   .UpsertItemAsync(item)
			   .GetAwaiter()
			   .GetResult();
		}

		public void DeleteReport(string reportId)
		{
			var (collection, id) = Util.GetCollectionAndName(reportId);

			_db.GetContainer(collection)
			   .DeleteItemAsync<JObject>(id, new PartitionKey(id))
			   .GetAwaiter()
			   .GetResult();
		}

		public IEnumerable<IReportInfo> GetReportsList()
		{
			var reportsList = _db.GetContainer(REPORTS)
								 .GetItemLinqQueryable<JObject>(true)
								 .AsEnumerable()
								 .Select(json =>
								 {
									 var id = GetValue(json, "id");
									 var type = GetValue(json, "Type");

									 return new ReportInfo
									 {
										 Id = id,
										 Type = type,
									 };
								 });

			return reportsList;
		}

		public Report GetTemplate(string templateId)
		{
			var response = _db.GetContainer(TEMPLATES)
				.ReadItemAsync<JObject>(templateId, new PartitionKey(templateId))
				.Result;

			if (response.StatusCode != HttpStatusCode.OK)
				return null;

			var templateJson = GetValue(response.Resource, "Content.Report");
			var template = ReportConverter.FromJson(Encoding.UTF8.GetBytes(templateJson));

			return template;
		}

		public IEnumerable<TemplateInfo> GetTemplatesList()
		{
			var templatesList = _db.GetContainer(TEMPLATES)
				.GetItemLinqQueryable<JObject>(true)
				.AsEnumerable()
				.Select(json =>
				{
					var id = GetValue(json, "id");

					return new TemplateInfo
					{
						Id = id,
						Name = Path.GetFileNameWithoutExtension(id),
					};
				});

			return templatesList;
		}

		public Theme GetTheme(string themeId)
		{
			var response = _db.GetContainer(THEMES)
							  .ReadItemAsync<JObject>(themeId, new PartitionKey(themeId))
							  .Result;

			if (response.StatusCode != HttpStatusCode.OK)
				return null;

			var json = response.Resource;
			return CreateThemeFromJson(json["Content"]["Theme"]);
		}

		public IEnumerable<IThemeInfo> GetThemesList()
		{
			var themesList = _db.GetContainer(THEMES)
								.GetItemLinqQueryable<JObject>(true)
								.AsEnumerable()
								.Select(json =>
								{
									var id = json["id"].ToString();
									var theme = CreateThemeFromJson(json["Content"]["Theme"]);

									return new ThemeInfo(theme)
									{
										Id = id,
										Title = Path.GetFileNameWithoutExtension(id),
									};
								});

			return themesList;
		}

		public Resource GetResource(string id)
		{
			var json = _containers
				.Select(c =>
				{
					var container = _db.GetContainer(c.container);
					var iter = container.GetItemLinqQueryable<JObject>(true);
					var enumer = iter.AsEnumerable();
					var filtered = enumer.Where(json =>
					{
						return id.Equals(json["id"].ToString());
					});
					var result = filtered.FirstOrDefault();

					return result;
				})
				.Where(j => j != null)
				.FirstOrDefault();


			if (json == null)
				return new Resource();

			var type = CustomStoreResourceLocator.GetResourceType(id);
			var content = json["Content"];

			if (type == typeof(Theme))
				return new Resource(CreateThemeFromJson(content["Theme"]).ToStream(), null);

			var bytes = Encoding.UTF8.GetBytes(content.ToString());
			var stream = new MemoryStream(bytes);
			stream.Seek(0, SeekOrigin.Begin);

			return new Resource(stream, null);
		}

		private static Theme CreateThemeFromJson(JToken json)
		{
			return new Theme
			{
				Colors = new ThemeColors
				{
					Dark1 = GetValue(json, "Colors.Dark1"),
					Dark2 = GetValue(json, "Colors.Dark2"),

					Light1 = GetValue(json, "Colors.Light1"),
					Light2 = GetValue(json, "Colors.Light2"),

					Accent1 = GetValue(json, "Colors.Accent1"),
					Accent2 = GetValue(json, "Colors.Accent2"),
					Accent3 = GetValue(json, "Colors.Accent3"),
					Accent4 = GetValue(json, "Colors.Accent4"),
					Accent5 = GetValue(json, "Colors.Accent5"),
					Accent6 = GetValue(json, "Colors.Accent6"),

					Hyperlink = GetValue(json, "Colors.Hyperlink"),
					HyperlinkFollowed = GetValue(json, "Colors.HyperlinkFollowed"),
				},

				Fonts = new ThemeFonts
				{
					MajorFont = new ThemeFont
					{
						Family = GetValue(json, "Fonts.MajorFont.Family"),
						Style = GetValue(json, "Fonts.MajorFont.Style"),
						Size = GetValue(json, "Fonts.MajorFont.Size"),
						Weight = GetValue(json, "Fonts.MajorFont.Weight"),
					},
					MinorFont = new ThemeFont
					{
						Family = GetValue(json, "Fonts.MinorFont.Family"),
						Style = GetValue(json, "Fonts.MinorFont.Style"),
						Size = GetValue(json, "Fonts.MinorFont.Size"),
						Weight = GetValue(json, "Fonts.MinorFont.Weight"),
					},
				},

				Images = json.SelectTokens("Images.Image")?.Select(child => new ThemeImage
				{
					Name = GetValue(child, "Name"),
					MIMEType = GetValue(child, "MIMEType"),
					ImageData = GetValue(child, "ImageData"),
				})
				.ToArray(),

				Constants = json.SelectTokens("Constants.Constant")?.Select(child => new ThemeConstant
				{
					Key = GetValue(child, "Key"),
					Value = GetValue(child, "Value"),
				})
				.ToArray(),
			};
		}

		private static string GetValue(JToken json, string token)
		{
			return json.SelectToken(token)?.ToString() ?? string.Empty;
		}
	}
}