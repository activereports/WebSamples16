using System;
using Microsoft.AspNetCore.Mvc;

using WebDesigner_Blazor.Services;

namespace WebDesigner_Blazor.Controllers
{
	[Route("api/templates")]
    public class TemplatesController : Controller
    {
		[HttpGet("{id}/content")]
		public ActionResult GetTemplate([FromServices] ITemplatesService templatesService, [FromRoute] string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return BadRequest();
			var template = templatesService.GetTemplate(id);

			return File(template, "application/json");
		}

		[HttpGet("{id}/thumbnail")]
		[ResponseCache(Duration = 3600)]
		public ActionResult GetTemplateThumbnail([FromServices] ITemplatesService templatesService, [FromRoute] string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return BadRequest();
			try
			{
				var thumbnail = templatesService.GetTemplateThumbnail(id);
				return Json(thumbnail);
			}
			catch (Exception)
			{
				return NoContent();
			}
		}

		[HttpGet("list")]
		public ActionResult GetTemplatesList([FromServices] ITemplatesService templatesService)
		{
			var templatesList = templatesService.GetTemplatesList();
			return Json(templatesList);
		}
	}
}
