using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace JsViewerBatchPrint_MVC_Core.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly string FilesPrefix = "JsViewerBatchPrint_MVC_Core.wwwroot";
        
        public object Index() => Resource("index.html");

        [HttpGet("{file}")]
        public object Resource(string file)
        {
            var stream = GetType().Assembly.GetManifestResourceStream($"{FilesPrefix}.{file}");
            if (stream == null)
                return new NotFoundResult();

            if (Path.GetExtension(file) == ".html")
                return new ContentResult() {Content = new StreamReader(stream).ReadToEnd(), ContentType = "text/html"};

            if (Path.GetExtension(file) == ".ico")
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    return new FileContentResult(memoryStream.ToArray(), "image/x-icon") {FileDownloadName = file};
                }

            using (var streamReader = new StreamReader(stream))
                return new FileContentResult(System.Text.Encoding.UTF8.GetBytes(streamReader.ReadToEnd()),
                    GetMimeType(file)) {FileDownloadName = file};
        }


        /// <summary>
        /// Gets the MIME type from the file extension
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>MIME type</returns>
        private static string GetMimeType(string fileName)
        {
            if (fileName.EndsWith(".css"))
                return "text/css";

            if (fileName.EndsWith(".js"))
                return "text/javascript";

            return "text/html";
        }
    }
}