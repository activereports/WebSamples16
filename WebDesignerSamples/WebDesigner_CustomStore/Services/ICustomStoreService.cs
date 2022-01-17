using System;

using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;


namespace WebDesignerCustomStore.Services
{
	public interface ICustomStoreService : IResourcesService, ITemplatesService, IDataSetsService, IDisposable
	{
	}
}
