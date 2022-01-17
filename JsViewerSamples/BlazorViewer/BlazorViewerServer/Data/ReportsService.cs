using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorViewerServer.Data
{
    public class ReportsService
    {
        public static string EmbeddedReportsPrefix = "BlazorViewerServer.Reports";
        public IEnumerable<string> GetReports()
        {
            string[] validExtensions = { ".rdl", ".rdlx", ".rdlx-master", ".rpx" };
            return GetEmbeddedReports(validExtensions);
        }

        private static string[] GetEmbeddedReports(string[] validExtensions) =>
            typeof(ReportsService).Assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(EmbeddedReportsPrefix))
                .Where(x => validExtensions.Any(x.EndsWith))
                .Select(x => x.Substring(EmbeddedReportsPrefix.Length + 1))
                .ToArray();

    }
}
