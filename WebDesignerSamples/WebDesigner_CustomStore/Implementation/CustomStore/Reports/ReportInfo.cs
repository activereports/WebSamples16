using LiteDB;

using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;


namespace WebDesignerCustomStore.Implementation.CustomStore.Reports
{
	internal class ReportInfo : IReportInfo
	{
		public string Name { get => Id; set => Id = value; }
		public string Type { get; set; }

		[BsonField("_id")]
		public string Id { get; set; }

		[BsonField("Report")]
		public byte[] Content { get; set; }
	}
}
