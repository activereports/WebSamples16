using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace JSViewer_AngularCore.Controllers
{
    [Route("[controller]")]
    public class ReportsController : Controller
    {
        [HttpGet("")]
        public ActionResult Reports()
        {
            string[] validExtensions = {".rdl", ".rdlx", ".rdlx-master", ".rpx"};

            var reportsList = GetEmbeddedReports(validExtensions);
            return new ObjectResult(reportsList);
        }

        /// <summary>
        /// Gets report names from assembly resources
        /// </summary>
        /// <returns>Report names</returns>
        private static string[] GetEmbeddedReports(string[] validExtensions) =>
            typeof(ReportsController).Assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(Startup.EmbeddedReportsPrefix))
                .Where(x => validExtensions.Any(x.EndsWith))
                .Select(x => x.Substring(Startup.EmbeddedReportsPrefix.Length + 1))
                .ToArray();
    }
}