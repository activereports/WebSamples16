using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using WebDesignerAngularCore.DataSets;
using System.Linq;

namespace WebDesignerAngularCore.Implementation
{
	public class CustomDataSetTemplates : IDataSetsService
	{
		public DataSetTemplate GetDataSet(string id)
		{
			CustomDataSetTemplatesStore.Items.TryGetValue(id, out DataSetTemplate dataSet);
			return dataSet;
		}

		public DataSetTemplateInfo[] GetDataSetsList()
		{
			return CustomDataSetTemplatesStore.Items
				.Select(i => new DataSetTemplateInfo
				{
					Id = i.Key,
					Name = i.Key
				})
				.ToArray();
		}
	}
}