using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace JSViewer_React_Hooks.Controllers
{
    [Route("[controller]")]
    public class ReportsListController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] validExtensions = { ".rdl", ".rdlx", ".rdlx-master" };
            return GetEmbeddedReports(validExtensions);
        }
        private static string[] GetEmbeddedReports(string[] validExtensions) =>
            typeof(ReportsListController).Assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(Startup.EmbeddedReportsPrefix))
                .Where(x => validExtensions.Any(x.EndsWith))
                .Select(x => x.Substring(Startup.EmbeddedReportsPrefix.Length + 1))
                .ToArray();


    }
}
