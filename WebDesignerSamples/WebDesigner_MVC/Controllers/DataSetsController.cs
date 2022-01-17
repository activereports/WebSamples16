using System.Net;
using System.Web.Mvc;
using System.Web;
using WebDesigner_MVC.Services;
using Owin;
using Microsoft.Owin;

namespace WebDesigner_MVC.Controllers
{
	[RoutePrefix("api/datasets")]
	public class DataSetsController : Controller
	{
		[Route("{id}/content")]
		[HttpGet]
		public ActionResult GetDataSetContent(string id)
		{
			var dataSetsService = HttpContext.GetServiceFromContext<IDataSetsService>();

			if (string.IsNullOrWhiteSpace(id)) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			var dataSet = (string) dataSetsService.GetDataSet(id);
			return new ContentResult { Content = dataSet, ContentType = "application/json" };
		}

		[Route("list")]
		[HttpGet]
		public ActionResult GetDataSetsList()
		{
			var dataSetsService = HttpContext.GetServiceFromContext<IDataSetsService>();

			var dataSetsList = dataSetsService.GetDataSetsList();
			return Json(dataSetsList, JsonRequestBehavior.AllowGet);
		}
	}
}
