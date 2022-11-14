using System;
using System.Linq;

using GrapeCity.ActiveReports.PageReportModel;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;

using WebDesignerCustomStore.Services;
using GrapeCity.ActiveReports;

namespace WebDesignerCustomStore.Implementation.CustomStore
{
	public partial class CustomStoreService : ICustomStoreService
	{
		#region IResourcesService/ISectionResourcesService implementation

		public IReportInfo[] GetReportsList()
		{
			return _db.GetReportsList()
					  .ToArray();
		}

		public Report GetReport(string id) => _db.GetReport(id);


		public string SaveReport(string id, Report report, bool isTemporary = false)
		{
			var reportId = Uri.UnescapeDataString(id);
			report.Name = reportId;

			var reportName = isTemporary ? Util.GenerateTempReportName(".rdlx") : reportId;
			reportId = string.Format("{0}{1}", isTemporary ? Util.TEMP_SUFFIX + "." : string.Empty, reportName);

			_db.SaveReport(reportName, report, isTemporary);
			return reportId;
		}

		public string UpdateReport(string id, Report report)
		{
			return SaveReport(id, report);
		}

		public void DeleteReport(string id)
		{
			_db.DeleteReport(id);
		}

		public SectionReport GetSectionReport(string id) => _db.GetSectionReport(id);

		public string SaveReport(string name, SectionReport report, bool isTemporary = false)
		{
			var reportId = Uri.UnescapeDataString(name);
			report.Name = reportId;

			var reportName = isTemporary ? Util.GenerateTempReportName(".rpx") : reportId;
			reportId = string.Format("{0}{1}", isTemporary ? Util.TEMP_SUFFIX + "." : string.Empty, reportName);

			_db.SaveSectionReport(reportName, report, isTemporary);
			return reportId;
		}

		public string UpdateReport(string id, SectionReport report)
		{
			return SaveReport(id, report);
		}

		#endregion
	}
}
