using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using WebDesigner_Blazor.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Utilities;

namespace WebDesigner_Blazor.Implementation
{
	public class FileSystemTemplates : ITemplatesService
	{
		readonly DirectoryInfo _rootFolder;

		static readonly string[] TemplateExtensions = { ".rdlx", ".rdl" };
		bool IsTemplateExtension(string extension)
		{
			return TemplateExtensions.Any(ext => extension.EndsWith(ext, StringComparison.InvariantCultureIgnoreCase));
		}

		public FileSystemTemplates(DirectoryInfo rootFolder)
		{
			_rootFolder = rootFolder;
		}

		public TemplateInfo[] GetTemplatesList()
		{
			var templatesList = _rootFolder.GetFiles("*.*", SearchOption.TopDirectoryOnly)
				.Select(fileInfo => fileInfo.Name)
				.Where(x => string.Equals(Path.GetExtension(x), ".rdlx", StringComparison.InvariantCultureIgnoreCase))
				.Select(name => new TemplateInfo
				{
					Id = name,
					Name = name,
				}).ToArray();
			return templatesList;
		}


		const string templateThumbnailName = "template_thumbnail";
		// Gets template content with thumbnail cut out if it exists
		public byte[] GetTemplate(string id)
		{
			var fullPath = Path.Combine(_rootFolder.FullName, id);

			if (!File.Exists(fullPath)) throw new FileNotFoundException();

			var templateXml = File.ReadAllBytes(fullPath);
			var template = ReportConverter.FromXML(templateXml);

			var thumbnail = template.EmbeddedImages.FirstOrDefault(i => i.Name == templateThumbnailName);
			if (thumbnail != null) template.EmbeddedImages.Remove(thumbnail);

			var templateJson = ReportConverter.ToJson(template);
			return templateJson;
		}


		 // Gets a thumbnail with specific name from Embedded Images
		public TemplateThumbnail GetTemplateThumbnail(string id)
		{
			var fullPath = Path.Combine(_rootFolder.FullName, id);

			if (!File.Exists(fullPath)) throw new FileNotFoundException();

			var templateXml = File.ReadAllBytes(fullPath);
			var xElement = GetXElement(fullPath);
			var thmumbnailElement = xElement.XPathSelectElement($"*[local-name() = 'EmbeddedImages']/*[local-name() = 'EmbeddedImage' and @Name='{templateThumbnailName}']");
			if (thmumbnailElement == null) throw new FileNotFoundException();
			var data = thmumbnailElement.XPathSelectElement("*[local-name() = 'ImageData']")?.Value ?? string.Empty;
			var mimeType = thmumbnailElement.XPathSelectElement("*[local-name() = 'MIMEType']")?.Value ?? string.Empty;

			return new TemplateThumbnail() { Data = data, MIMEType = mimeType };
		}

		private XElement GetXElement(string filePath)
		{
			using (var streamReader = File.OpenText(filePath))
			{
				return XElement.Load(streamReader);
			}
		}
	}
}
