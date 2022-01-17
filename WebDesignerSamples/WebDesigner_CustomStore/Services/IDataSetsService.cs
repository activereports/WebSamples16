namespace WebDesignerCustomStore.Services
{
	/// <summary>
	/// Allows to load data definition from custom storage.
	/// </summary>
	public interface IDataSetsService
	{
		object[] GetDataSetsList();
		object GetDataSet(string id);
	}
}

