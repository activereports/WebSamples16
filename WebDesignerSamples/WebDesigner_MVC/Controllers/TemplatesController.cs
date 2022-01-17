using WebDesigner_MVC.Services;
using System;
using System.Web.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text;

namespace WebDesigner_MVC.Controllers
{
	[RoutePrefix("api/templates")]
	public class TemplatesController : Controller
	{
		[Route("{id}/content")]
		[HttpGet]
		public ActionResult GetTemplate(string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

			var templatesService = HttpContext.GetServiceFromContext<ITemplatesService>();
			var template = templatesService.GetTemplate(id);
			return new ContentResult() { Content = Encoding.UTF8.GetString(template), ContentType = "application/json" };
		}

		[Route("{id}/thumbnail")]
		[HttpGet]
		[OutputCache(Duration = 3600)]
		public ActionResult GetTemplateThumbnail(string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			try
			{
				var templatesService = HttpContext.GetServiceFromContext<ITemplatesService>();
				var thumbnail = templatesService.GetTemplateThumbnail(id);
				return Json(thumbnail, JsonRequestBehavior.AllowGet);
			}
			catch (Exception)
			{
				return new HttpStatusCodeResult(HttpStatusCode.NoContent);
			}
		}

		[Route("list")]
		[HttpGet]
		public ActionResult GetTemplatesList()
		{
			var templatesService = HttpContext.GetServiceFromContext<ITemplatesService>();
			var templatesList = templatesService.GetTemplatesList();
			return Json(templatesList, JsonRequestBehavior.AllowGet);
		}
	}
}
