using Microsoft.Extensions.Logging;
using PrintAgent.Interfaces;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using GrapeCity.Documents.Pdf;

namespace PrintAgent.Services
{
    internal sealed class PdfPrintService : IPdfPrintService
    {
        class PrintState
        {
            private int _pageIndex = 0;
            public readonly GcPdfDocument PdfDocument;
            public int PageIndex => _pageIndex;
            public bool EndOfDocument => _pageIndex >= PdfDocument.Pages.Count;

            public PrintState(GcPdfDocument pdfDocument) => PdfDocument = pdfDocument;
            public void GotoNextPage() => _pageIndex++;
        }        
        
        private readonly ILogger<PdfPrintService> _logger;

        public PdfPrintService(ILogger<PdfPrintService> logger)
        {
            _logger = logger;
        }

        public void Print(Stream pdfStream, string printerName)
        {
            if (pdfStream == null)
                throw new ArgumentNullException(nameof(pdfStream));

            var pdfDocument = new GcPdfDocument();
            pdfDocument.Load(pdfStream);

            _logger.LogInformation(
                $"Printing PDF containing {pdfDocument.Pages.Count} page(s) to printer '{printerName}'");

            var printState = new PrintState(pdfDocument);
            using var printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = printerName;

            printDocument.PrintPage += (_, e) => PrintDocumentOnPrintPage(e, printState);

            // To print using the Microsoft Print to PDF printer without prompting for a filename
            if (printDocument.PrinterSettings.PrinterName == "Microsoft Print to PDF")
            {
                string file = $"PrintAgent_{Path.ChangeExtension(Path.GetRandomFileName(), ".pdf")}";
                string directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
                printDocument.PrinterSettings.PrintFileName = Path.Combine(directory, file);
                printDocument.PrinterSettings.PrintToFile = true;
            }
            printDocument.Print();
        }

        private void PrintDocumentOnPrintPage(PrintPageEventArgs e, PrintState printState)
        {
            var page = printState.PdfDocument.Pages[printState.PageIndex];
            page.RenderTo(e.Graphics, e.Graphics.VisibleClipBounds);

            printState.GotoNextPage();
            e.HasMorePages = !printState.EndOfDocument;
        }
    }

    static class PdfPageExtension
    {
        public static void RenderTo(this Page page, Graphics graphics, RectangleF destinationRectInPixels,
            bool maintainAspectRatio = true, bool allowUpscaling = false, bool center = true)
        {
            Image image;
            using (var memoryStream = new MemoryStream())
            {
                page.SaveAsBmp(memoryStream, new SaveAsImageOptions{ Print = true, Resolution = 300});
                memoryStream.Position = 0;
                image = Image.FromStream(memoryStream);
            }

            var pageAspect = (float)image.Width / (float)image.Height;
            var destinationAspect = destinationRectInPixels.Width / destinationRectInPixels.Height;

            var rotate = (pageAspect >= 1.0 && destinationAspect < 1.0) || (pageAspect < 1.0 && destinationAspect >= 1.0);

            if (rotate)
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);            
            
            var scaleX = destinationRectInPixels.Width / image.Width;
            var scaleY = destinationRectInPixels.Height / image.Height;

            if (!allowUpscaling)
            {
                scaleX = Math.Min(scaleX, 1);
                scaleY = Math.Min(scaleY, 1);
            }

            if (maintainAspectRatio)
            {
                scaleX = scaleY = Math.Min(scaleX, scaleY);
            }

            var destinationWidth = Math.Min(image.Width * scaleX, destinationRectInPixels.Width);
            var destinationHeight = Math.Min(image.Height * scaleY, destinationRectInPixels.Height);

            var offsetX = center ? (destinationRectInPixels.Width - destinationWidth) / 2.0 : 0.0;
            var offsetY = center ?  (destinationRectInPixels.Height - destinationHeight) / 2.0 : 0.0;

            var boundingBox = new Rectangle(
                x: (int)(destinationRectInPixels.X + offsetX),
                y: (int)(destinationRectInPixels.Y + offsetY),
                width: (int)destinationWidth,
                height: (int)destinationHeight);

            graphics.DrawImage(image, boundingBox);
        }
    }
}
