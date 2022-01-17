using System.IO;

namespace PrintAgent.Interfaces
{
    public interface IPdfPrintService
    {
        void Print(Stream pdfStream, string printerName);
    }
}
