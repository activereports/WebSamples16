using System;
using System.IO;
using System.Linq;

using WebDesigner_MVC.Services;

namespace WebDesigner_MVC.Implementation
{
	internal class FileSystemDataSets : IDataSetsService
	{
		private readonly DirectoryInfo _rootFolder;

		public FileSystemDataSets(DirectoryInfo rootFolder)
		{
			_rootFolder = rootFolder;
		}

		private static string DataSetExtension = ".json";

		public object[] GetDataSetsList()
		{
			var rootFolder = _rootFolder.FullName;
			var dataSetsList = Directory.GetFiles(_rootFolder.FullName, "*.*", SearchOption.TopDirectoryOnly)
				.Where(x => Path.GetExtension(x) == DataSetExtension)
				.Select(name => name.Substring(rootFolder.Length))
				.Select(name => new {
					Id = name,
					Name = name.Substring(0, name.Length - DataSetExtension.Length),
				})
				.ToArray();
			return dataSetsList;
		}

		public object GetDataSet(string id)
		{
			var name = Uri.UnescapeDataString(id);
			var fullPath = Path.Combine(_rootFolder.FullName, name);

			if (!File.Exists(fullPath)) throw new ArgumentException();

			using (var streamReader = File.OpenText(fullPath))
			{
				return streamReader.ReadToEnd();
			}
		}
	}
}
