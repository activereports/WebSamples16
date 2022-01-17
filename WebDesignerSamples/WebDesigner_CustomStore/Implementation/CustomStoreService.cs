using System;

using WebDesignerCustomStore.Services;
using WebDesignerCustomStore.Implementation.Storage;


namespace WebDesignerCustomStore.Implementation.CustomStore
{
	public partial class CustomStoreService : ICustomStoreService
	{
		private ICustomStorage _db;

		public CustomStoreService(ICustomStorage database)
		{
			_db = database;
		}

		public void Dispose()
		{
			_db.Dispose();
		}

		#region IResourcesService implementation

		public Uri GetBaseUri()
		{
			return null;
		}

		#endregion
	}
}
