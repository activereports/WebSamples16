using System.IO;
using System.Net;
using System.Web.Mvc;

namespace WebDesigner_MVC.Controllers
{
	public class DesignController : Controller
	{
		[Route("")]
		[HttpGet]
		public ActionResult Index()
		{
			return RedirectToAction("create");
		}

		[Route("create")]
		[HttpGet]
		public ActionResult Create()
		{
			return View("Index");
		}

		[Route("edit/{id}")]
		[HttpGet]
		public ActionResult Edit(string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			ViewBag.Id = id;
			return View("Index");
		}

		[HttpGet]
		[Route("{file}")]
		public ActionResult Resource(string file)
		{
			var stream = GetType().Assembly.GetManifestResourceStream("WebDesigner_MVC.wwwroot." + file);
			if (stream == null)
				return new HttpNotFoundResult();

			if (Path.GetExtension(file) == ".html")
				return new ContentResult { Content = new StreamReader(stream).ReadToEnd(), ContentType = "text/html" };

			if (Path.GetExtension(file) == ".ico")
				using (var memoryStream = new MemoryStream())
				{
					stream.CopyTo(memoryStream);
					return new FileContentResult(memoryStream.ToArray(), "image/x-icon") { FileDownloadName = file };
				}

			using (var streamReader = new StreamReader(stream))
				return new FileContentResult(System.Text.Encoding.UTF8.GetBytes(streamReader.ReadToEnd()),
					GetMimeType(file))
				{ FileDownloadName = file };
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
