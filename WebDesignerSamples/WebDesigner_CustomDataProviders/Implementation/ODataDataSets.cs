using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebDesignerCustomDataProviders.Services;

namespace WebDesignerCustomDataProviders.Implementation
{
	internal class ODataDataSets : IDataSetsService
	{
		private readonly DirectoryInfo _rootFolder;

		public ODataDataSets(DirectoryInfo rootFolder)
		{
			_rootFolder = rootFolder;
		}

		private static string DataSetExtension = ".json";

		public object[] GetDataSetsList()
		{
			var dataSetsList = _rootFolder.GetFiles("*.*", SearchOption.TopDirectoryOnly)
				.Select(fileInfo => fileInfo.Name)
				.Where(x => string.Equals(Path.GetExtension(x), DataSetExtension,
					StringComparison.InvariantCultureIgnoreCase))
				.Select(name => new
				{
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
			
			// Read result template
			var template = JObject.Parse(File.ReadAllText(fullPath));
			
			// Fetch OData url
			var oDataUrl = template["ODataUrl"].ToString();

			// Download and parse OData json
			JObject parsed;;
			using (var http = new HttpClient())
			{
				var request = http.GetStringAsync(oDataUrl);
				var json = request.Result;

				parsed = JObject.Parse(json);
			}
			
			// Rename "value" to "Data"
			parsed["Data"] = parsed["value"];
			parsed.Remove("value");

			var jsonData = JsonConvert.SerializeObject(parsed);

			// Set data in the template
			template["DataSource"]["ConnectionProperties"]["ConnectString"] = "jsonData=" +	jsonData;

			return template.ToString();
		}
	}
}
