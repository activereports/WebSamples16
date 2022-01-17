namespace WebDesignerCustomStore.Services
{
	public class TemplateInfo
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}

	public class TemplateThumbnail
	{
		public string Data { get; set; }
		public string MIMEType { get; set; }
	}

	public interface ITemplatesService
	{
		TemplateInfo[] GetTemplatesList();
		byte[] GetTemplate(string id);
		TemplateThumbnail GetTemplateThumbnail(string id);
	}
}
