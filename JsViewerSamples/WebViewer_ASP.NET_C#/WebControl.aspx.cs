using System;

namespace GrapeCity.ActiveReports.Samples.Web
{
    public partial class WebControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Put user code to initialize the page here
            // if this is not the postback, then fill the dropdown/combo with it's available viewer types.
            if (!IsPostBack)
            {
                cboViewerType.Items.Clear();
                cboViewerType.Items.Add("HtmlViewer");
                cboViewerType.Items.Add("PDF Reader");
                cboViewerType.Items.Add("RawHtml");
                // Default is HTML.
                cboViewerType.SelectedIndex = 0;

                // Default is Section.
                cboReportType.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// commit_Click - runs when the user clicks the view button
        /// and selects a different viewing mode.
        /// </summary>
        protected void commit_Click(object sender, EventArgs e)
        {
            // Set the Viewer Type from the dropdown list to the ActiveReports WebViewer
            string selectedViewerType = cboViewerType.Items[cboViewerType.SelectedIndex].Text;

            // Set the Report Type from the dropdown list to the ActiveReports WebViewer
            int selectedReportType = cboReportType.SelectedIndex;

            switch (selectedViewerType)
            {
                case "PDF Reader": // Acrobat Reader was chosen as the viewer type
                    arvWebMain.ViewerType = ActiveReports.Web.ViewerType.AcrobatReader;
                    break;
                case "HtmlViewer": // HTML Viewer was chosen as the viewer type
                    arvWebMain.ViewerType = ActiveReports.Web.ViewerType.HtmlViewer;
                    break;
                case "RawHtml": // Raw HTML was chosen as the viewer type
                    arvWebMain.ViewerType = ActiveReports.Web.ViewerType.RawHtml;
                    break;
            }

            switch (selectedReportType)
            {
                case 0: // Section Report was chosen as the report type
                    arvWebMain.ReportName = "RpxReports/Invoice.rpx";
                    break;
                case 1: // Page Report was chosen as the report type
                    arvWebMain.ReportName = "PageReports/Invoice_Grouped.rdlx";
                    break;
                case 2: // RDL Report was chosen as the report type
                    arvWebMain.ReportName = "RdlReports/SalesReceipt.rdlx";
                    break;
            }
        }
    }
}