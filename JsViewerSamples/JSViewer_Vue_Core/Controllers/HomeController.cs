using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace JSViewerVueCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env) => _env = env;

        public IActionResult Index()
        {
            return new PhysicalFileResult(Path.Combine(_env.WebRootPath, "index.html"), "text/html");
        }

        [HttpGet("reports")]
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
            typeof(HomeController).Assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(Startup.EmbeddedReportsPrefix))
                .Where(x => validExtensions.Any(x.EndsWith))
                .Select(x => x.Substring(Startup.EmbeddedReportsPrefix.Length + 1))
                .ToArray();
    }
}