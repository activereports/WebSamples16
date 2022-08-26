using System.Linq;
using WebDesignerCustomDataProviders.DataSets;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;

namespace WebDesignerCustomDataProviders.Implementation
{
	internal class CustomDataSetTemplates : IDataSetsService
	{
		public DataSetTemplateInfo[] GetDataSetsList()
		{
			var dataSetsList = CustomDataSetTemplatesStore.Items
				.Select(i => new DataSetTemplateInfo
				{
					Id = i.Key,
					Name = i.Key
				})
				.ToArray();

			return dataSetsList;
		}

		public DataSetTemplate GetDataSet(string id)
		{
			CustomDataSetTemplatesStore.Items.TryGetValue(id, out DataSetTemplate dataSet);
			return dataSet;
		}
	}
}
