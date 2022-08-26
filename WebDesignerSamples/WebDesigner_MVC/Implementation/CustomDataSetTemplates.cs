using GrapeCity.ActiveReports.Aspnet.Designer.Services;
using GrapeCity.ActiveReports.Aspnet.Designer;
using WebDesigner_MVC.DataSets;
using System.Linq;

namespace WebDesigner_MVC.Implementation
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