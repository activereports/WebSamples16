using LiteDB;


namespace WebDesignerCustomStore.Implementation.CustomStore.Templates
{
	public class Template
	{
		[BsonField("_id")]
		public string Id { get; set; }

		[BsonField("Template")]
		public byte[] Content { get; set; }
	}
}
