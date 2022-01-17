using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PrintAgent.Configuration;
using PrintAgent.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PrintAgent.Controllers
{
    public class PrintController : ControllerBase
    {
        private readonly IPdfPrintService _pdfPrintService;
        private readonly IOptions<AppConfig> _config;
        private readonly ILogger<PrintController> _logger;

        public PrintController(IPdfPrintService pdfPrintService, IOptions<AppConfig> config, ILogger<PrintController> logger)
        {
            _pdfPrintService = pdfPrintService;
            _config = config;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Index(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Problem("You have not specified a file.");

            try
            {
                await using Stream pdfStream = file.OpenReadStream();
                _pdfPrintService.Print(pdfStream, _config.Value.PrinterName);
            }
            catch (Exception ex)
            {
                return Problem("ERROR:" + ex.Message.ToString());
            }

            return Ok();
        }

        [NonAction]
        public override ObjectResult Problem(string detail = null, string instance = null, int? statusCode = null, string title = null, string type = null)
        {
            _logger.LogError(detail);
            return base.Problem(detail, instance, statusCode, title, type);
        }
    }
}
