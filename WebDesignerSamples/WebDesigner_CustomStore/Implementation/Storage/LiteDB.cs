using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using LiteDB;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.PageReportModel;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Utilities;

using WebDesignerCustomStore.Services;
using WebDesignerCustomStore.Implementation.Storage;
using WebDesignerCustomStore.Implementation.CustomStore;
using WebDesignerCustomStore.Implementation.CustomStore.Images;
using WebDesignerCustomStore.Implementation.CustomStore.Themes;
using WebDesignerCustomStore.Implementation.CustomStore.Reports;
using WebDesignerCustomStore.Implementation.CustomStore.Templates;

namespace WebDesignerCustomStore.Implementation.Database
{
	public class LiteDB : ICustomStorage
	{
		private const string IMAGES = "images";
		private const string THEMES = "themes";
		private const string REPORTS = "reports";
		private const string TEMPLATES = "templates";

		private LiteDatabase _lite;

		public LiteDB(string databasePath)
		{
			_lite = new LiteDatabase(databasePath);
		}

		public void Dispose()
		{
			_lite.Dispose();
		}

		public byte[] GetImage(string imageId)
		{
			return _lite.GetCollection<ImageInfo>(IMAGES)
					  .FindById(imageId)
					  .Content;
		}

		public IEnumerable<IImageInfo> GetImagesList()
		{
			var imagesList = _lite
				.GetCollection<ImageInfo>(IMAGES)
				.FindAll()
				.Select(img =>
				 {
					 img.Name = Uri.UnescapeDataString(img.Id);
					 img.Thumbnail = Util.GetImageThumbnail(img.Content);

					 return img;
				 });

			return imagesList;
		}

		public Report GetReport(string reportId)
		{
			var (collection, reportName) = Util.GetCollectionAndName(reportId, REPORTS);
			var reportItem = _lite.GetCollection<ReportInfo>(collection)
								  .FindById(reportName);

			if (reportItem is null)
				return null;

			var report = ReportConverter.FromXML(reportItem.Content);

			// Define our own resource locator for correct work with report resources (images, themes and so on)
			report.Site = new ReportSite(new CustomStoreResourceLocator(this));
			return report;
		}

		public void SaveReport(string reportId, Report report, bool isTemporary = false)
		{
			var reportXml = ReportConverter.ToXml(report);
			var collection = isTemporary ? Util.TEMP_SUFFIX : REPORTS;

			_lite
				.GetCollection<ReportInfo>(collection)
				.Upsert(new ReportInfo
				{
					Id = reportId,
					Name = reportId,
					Content = reportXml,
					Type = Util.GetReportType(report),
				});
		}

		public void DeleteReport(string id)
		{
			var (collection, reportName) = Util.GetCollectionAndName(id);

			_lite.GetCollection<ReportInfo>(collection)
				 .Delete(reportName);
		}

		public IEnumerable<IReportInfo> GetReportsList()
		{
			return _lite.GetCollection<ReportInfo>(REPORTS)
						.FindAll();
		}

		public Report GetTemplate(string templateId)
		{
			var template = _lite.GetCollection<Template>(TEMPLATES)
								.FindById(templateId);

			if (template is null)
				return null;

			return ReportConverter.FromXML(template.Content);
		}

		public IEnumerable<TemplateInfo> GetTemplatesList()
		{
			var templatesList = _lite.GetCollection<Template>(TEMPLATES)
				.FindAll()
				.Select(template => new TemplateInfo
				{
					Id = template.Id,
					Name = Path.GetFileNameWithoutExtension(template.Id),
				});

			return templatesList;
		}

		public Theme GetTheme(string themeId)
		{
			var bson = _lite.GetCollection(THEMES)
							.FindById(themeId);

			if (bson is null)
				return null;

			return _lite.Mapper.Deserialize<Theme>(bson);
		}

		public IEnumerable<IThemeInfo> GetThemesList()
		{
			var themes = _lite.GetCollection(THEMES);
			var themesList = themes
				.FindAll()
				.Select(bson =>
				{
					var theme = _lite.Mapper.Deserialize<Theme>(bson);
					var themeId = bson["_id"];

					return new ThemeInfo(theme)
					{
						Id = themeId,
						Title = Path.GetFileNameWithoutExtension(themeId),
					};
				});

			return themesList;
		}

		public Resource GetResource(string id)
		{
			var bson = _lite.GetCollectionNames()
						.Select(c => _lite.GetCollection(c).FindById(id))
						.FirstOrDefault(r => r != null);

			if (bson == null)
				return new Resource();

			var type = CustomStoreResourceLocator.GetResourceType(id);
			var result = _lite.Mapper.Deserialize(type, bson);

			// Special case for themes due to different storage format in the database
			var theme = result as Theme;
			if (theme != null)
				return new Resource(theme.ToStream(), null);

			return new Resource(CustomStoreResourceLocator.ToStream(result), null);
		}
	}
}
