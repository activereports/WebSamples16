using Microsoft.AspNetCore.Mvc;
using WebDesignerAngularCore.Services;

namespace WebDesignerAngularCore.Controllers
{
	[Route("api/datasets")]
	public class DataSetsController : Controller
	{
		[HttpGet("{id}/content")]
		public ActionResult GetDataSetContent([FromServices] IDataSetsService dataSetsService, [FromRoute] string id)
		{
			if (string.IsNullOrWhiteSpace(id)) return BadRequest();
			var dataSet = dataSetsService.GetDataSet(id);
			return Content(dataSet.ToString(), "application/json");
		}

		[HttpGet("list")]
		public ActionResult GetDataSetsList([FromServices] IDataSetsService dataSetsService)
		{
			var dataSetsList = dataSetsService.GetDataSetsList();
			return Json(dataSetsList);
		}
	}
}
